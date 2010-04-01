Module hexakun

    Private Function StrCarveR(ByRef s As String, ByVal n As Integer) As String
        ' 2010/04/01 新規

        Dim r As String

        If n > s.Length Then
            n = s.Length
        End If

        r = s.Substring(s.Length - n)
        s = s.Substring(0, s.Length - n)

        Return r

    End Function

    Private Function Char2Num(ByVal c As Char) As Integer
        ' 2010/04/01 新規

        Dim r As Integer

        r = "0123456789abcdef".IndexOf(LCase(c))

        Debug.Assert(r >= 0, "Char2Num()が負数を返しました")

        Return r

    End Function

    Private Function Num2Char(ByVal i As Integer) As Char
        ' 2010/04/01 新規

        Debug.Assert(i >= 0 And i < 16, "Num2Char(): 引数が不正")

        Return "0123456789abcdef".ToCharArray(i, 1)(0)

    End Function

    Public Function Text2Number(ByVal s As String, ByVal FromRadix As Integer) As Long
        ' 2010/04/01 新規

        Dim i As Integer
        Dim r As Long

        s = s.Replace(" ", "")
		s = s.Replace(",", "")

        r = 0
        For i = 1 To s.Length
            r = r * FromRadix
            r = r + Char2Num(s.ToCharArray()(i - 1))
        Next

        Return r

    End Function

    Public Function Number2Text(ByVal n As Long, ByVal ToRadix As Integer) As String
        ' 2010/04/01 新規

        Dim i As Integer
        Dim r As String

        Debug.Assert(ToRadix > 1, "Number2Text(): ToRadixが不正")

        r = ""
        Do While n > 0
            i = CInt(n Mod ToRadix)
            r = Num2Char(i) & r
            n = n \ ToRadix
        Loop

        If r = "" Then
            r = "0"
        End If

        Return r

    End Function

    Private Function HexakunFormat(ByVal s As String, ByVal FromRadix As Integer, ByVal ToRadix As Integer) As String
        ' 2010/04/01 新規

        If s = "" Then
            Return ""
        End If

        Return Number2Text(Text2Number(s, FromRadix), ToRadix)

    End Function

    Public Function ShrinkFormat(ByVal s As String, ByVal FromRadix As Integer, ByVal ToRadix As Integer) As String
        ' 2010/04/01 新規

        Return HexakunFormat(s, FromRadix, ToRadix)

    End Function

    Public Function ExpandFormat(ByVal s As String, ByVal FromRadix As Integer, ByVal ToRadix As Integer) As String
        ' 2010/04/01 新規

        Dim r As String

        s = HexakunFormat(s, FromRadix, ToRadix)
        r = ""

        Select ToRadix
        Case 16
            r = s
        Case 10
            Do Until s.Length = 0
                If r.Length > 0 Then
                    r = "," & r
                End If
                r = StrCarveR(s, 3) & r
            Loop
        Case 8
            Do Until s.Length = 0
                If r.Length > 0 Then
                    r = " " & r
                End If
                r = StrCarveR(s, 3) & r
            Loop
        Case 2
            s = StrDup(3 - ((s.Length + 3) Mod 4), "0") & s ' 4桁単位に揃える

            Do Until s.Length = 0
                If r.Length > 0 Then
                    r = " " & r
                End If
                r = StrCarveR(s, 4) & r
            Loop
        End Select

        Return r

    End Function

    Public Function ValidateHex(ByVal s As String) As Boolean
        ' 2010/04/01 新規

        If Not System.Text.RegularExpressions.Regex.IsMatch(s, "^[0-9a-fA-F]*$") Then
            Return False
        End If

        If Text2Number(s, 16) > &HFFFFFFFFL Then
            Return False
        End If

        Return True

    End Function

    Public Function ValidateDec(ByVal s As String) As Boolean
        ' 2010/04/01 新規

		If Not System.Text.RegularExpressions.Regex.IsMatch(s, "^[,0-9]*$") Then
			Return False
		End If

        If Text2Number(s, 10) > &HFFFFFFFFL Then
            Return False
        End If

        Return True

    End Function

    Public Function ValidateOct(ByVal s As String) As Boolean
        ' 2010/04/01 新規

		If Not System.Text.RegularExpressions.Regex.IsMatch(s, "^[ 0-7]*$") Then
			Return False
		End If

        If Text2Number(s, 8) > &HFFFFFFFFL Then
            Return False
        End If

        Return True

    End Function

    Public Function ValidateBin(ByVal s As String) As Boolean
        ' 2010/04/01 新規

        If Not System.Text.RegularExpressions.Regex.IsMatch(s, "^[ 01]*$") Then
            Return False
        End If

        If Text2Number(s, 2) > &HFFFFFFFFL Then
            Return False
        End If

        Return True

    End Function

End Module
