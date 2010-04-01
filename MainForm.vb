Public Class MainForm

    Private Updating As Boolean
    Private LastText As String
    Private LastSelectionStart As Integer
    Private LastSelectionLength As Integer

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' 2010/04/01 新規

        Me.Close()

    End Sub

    Private Sub HexText_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HexText.Leave
        ' 2010/04/01 新規

        HexText.Text = ExpandFormat(HexText.Text, 16, 16)

    End Sub

    Private Sub DecText_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecText.Leave
        ' 2010/04/01 新規

        DecText.Text = ExpandFormat(DecText.Text, 10, 10)

    End Sub

    Private Sub OctText_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OctText.Leave
        ' 2010/04/01 新規

        OctText.Text = ExpandFormat(OctText.Text, 8, 8)

    End Sub

    Private Sub BinText_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinText.Leave
        ' 2010/04/01 新規

        BinText.Text = ExpandFormat(BinText.Text, 2, 2)

    End Sub

    Private Sub HexText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HexText.TextChanged
        ' 2010/04/01 新規

        Dim t As String

        If Not Updating Then
            Updating = True

            If Not ValidateHex(HexText.Text) Then
                HexText.Text = LastText
                HexText.SelectionStart = LastSelectionStart
                HexText.SelectionLength = LastSelectionLength
            End If

            t = HexText.Text
'            HexText.Text = ExpandFormat(t, 16, 16)
            DecText.Text = ExpandFormat(t, 16, 10)
            OctText.Text = ExpandFormat(t, 16, 8)
            BinText.Text = ExpandFormat(t, 16, 2)

            Updating = False
        End If

    End Sub

    Private Sub DecText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecText.TextChanged
        ' 2010/04/01 新規

        Dim t As String


        If Not Updating Then
            Updating = True

            If Not ValidateDec(DecText.Text) Then
                DecText.Text = LastText
                DecText.SelectionStart = LastSelectionStart
                DecText.SelectionLength = LastSelectionLength
            End If

            t = DecText.Text
            HexText.Text = ExpandFormat(t, 10, 16)
'            DecText.Text = ExpandFormat(t, 10, 10)
            OctText.Text = ExpandFormat(t, 10, 8)
            BinText.Text = ExpandFormat(t, 10, 2)

            Updating = False
        End If

    End Sub

    Private Sub OctText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OctText.TextChanged
        ' 2010/04/01 新規

        Dim t As String

        If Not Updating Then
            Updating = True

            If Not ValidateOct(OctText.Text) Then
                OctText.Text = LastText
                OctText.SelectionStart = LastSelectionStart
                OctText.SelectionLength = LastSelectionLength
            End If

            t = OctText.Text
            HexText.Text = ExpandFormat(t, 8, 16)
            DecText.Text = ExpandFormat(t, 8, 10)
'            OctText.Text = ExpandFormat(t, 8, 8)
            BinText.Text = ExpandFormat(t, 8, 2)

            Updating = False
        End If

    End Sub

    Private Sub BinText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinText.TextChanged
        ' 2010/04/01 新規

        Dim t As String

        If Not Updating Then
            Updating = True

            If Not ValidateBin(BinText.Text) Then
                BinText.Text = LastText
                BinText.SelectionStart = LastSelectionStart
                BinText.SelectionLength = LastSelectionLength
            End If

            t = BinText.Text
            HexText.Text = ExpandFormat(t, 2, 16)
            DecText.Text = ExpandFormat(t, 2, 10)
            OctText.Text = ExpandFormat(t, 2, 8)
'            BinText.Text = ExpandFormat(t, 2, 2)

            Updating = False
        End If

    End Sub

    Private Sub HexText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HexText.KeyPress
        ' 2010/04/01 新規
        LastText = HexText.Text
        LastSelectionStart = HexText.SelectionStart
        LastSelectionLength = HexText.SelectionLength
    End Sub

    Private Sub DecText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DecText.KeyPress
        ' 2010/04/01 新規
        LastText = DecText.Text
        LastSelectionStart = DecText.SelectionStart
        LastSelectionLength = DecText.SelectionLength
    End Sub

    Private Sub OctText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OctText.KeyPress
        ' 2010/04/01 新規
        LastText = OctText.Text
        LastSelectionStart = OctText.SelectionStart
        LastSelectionLength = OctText.SelectionLength
    End Sub

    Private Sub BinText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BinText.KeyPress
        ' 2010/04/01 新規
        LastText = BinText.Text
        LastSelectionStart = BinText.SelectionStart
        LastSelectionLength = BinText.SelectionLength
    End Sub

End Class
