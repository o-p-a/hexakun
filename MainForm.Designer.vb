<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
	'Windows フォーム デザイナを使用して変更できます。  
	'コード エディタを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
Me.HexText = New System.Windows.Forms.TextBox
Me.HexLabel = New System.Windows.Forms.Label
Me.DecLabel = New System.Windows.Forms.Label
Me.OctLabel = New System.Windows.Forms.Label
Me.BinLabel = New System.Windows.Forms.Label
Me.DecText = New System.Windows.Forms.TextBox
Me.OctText = New System.Windows.Forms.TextBox
Me.BinText = New System.Windows.Forms.TextBox
Me.ExitButton = New System.Windows.Forms.Button
Me.SuspendLayout()
'
'HexText
'
Me.HexText.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
Me.HexText.Location = New System.Drawing.Point(45, 7)
Me.HexText.MaxLength = 8
Me.HexText.Name = "HexText"
Me.HexText.Size = New System.Drawing.Size(242, 19)
Me.HexText.TabIndex = 1
Me.HexText.Text = "0"
Me.HexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'HexLabel
'
Me.HexLabel.AutoSize = True
Me.HexLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.HexLabel.Location = New System.Drawing.Point(11, 8)
Me.HexLabel.Name = "HexLabel"
Me.HexLabel.Size = New System.Drawing.Size(28, 14)
Me.HexLabel.TabIndex = 0
Me.HexLabel.Text = "&Hex"
'
'DecLabel
'
Me.DecLabel.AutoSize = True
Me.DecLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.DecLabel.Location = New System.Drawing.Point(11, 38)
Me.DecLabel.Name = "DecLabel"
Me.DecLabel.Size = New System.Drawing.Size(28, 14)
Me.DecLabel.TabIndex = 2
Me.DecLabel.Text = "&Dec"
'
'OctLabel
'
Me.OctLabel.AutoSize = True
Me.OctLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.OctLabel.Location = New System.Drawing.Point(11, 68)
Me.OctLabel.Name = "OctLabel"
Me.OctLabel.Size = New System.Drawing.Size(27, 14)
Me.OctLabel.TabIndex = 4
Me.OctLabel.Text = "&Oct"
'
'BinLabel
'
Me.BinLabel.AutoSize = True
Me.BinLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.BinLabel.Location = New System.Drawing.Point(11, 98)
Me.BinLabel.Name = "BinLabel"
Me.BinLabel.Size = New System.Drawing.Size(23, 14)
Me.BinLabel.TabIndex = 6
Me.BinLabel.Text = "&Bin"
'
'DecText
'
Me.DecText.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
Me.DecText.Location = New System.Drawing.Point(45, 37)
Me.DecText.MaxLength = 10
Me.DecText.Name = "DecText"
Me.DecText.Size = New System.Drawing.Size(242, 19)
Me.DecText.TabIndex = 3
Me.DecText.Text = "0"
Me.DecText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'OctText
'
Me.OctText.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
Me.OctText.Location = New System.Drawing.Point(45, 67)
Me.OctText.MaxLength = 11
Me.OctText.Name = "OctText"
Me.OctText.Size = New System.Drawing.Size(242, 19)
Me.OctText.TabIndex = 5
Me.OctText.Text = "0"
Me.OctText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'BinText
'
Me.BinText.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
Me.BinText.Location = New System.Drawing.Point(45, 97)
Me.BinText.MaxLength = 32
Me.BinText.Name = "BinText"
Me.BinText.Size = New System.Drawing.Size(242, 19)
Me.BinText.TabIndex = 7
Me.BinText.Text = "0"
Me.BinText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'ExitButton
'
Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
Me.ExitButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.ExitButton.Location = New System.Drawing.Point(232, 122)
Me.ExitButton.Name = "ExitButton"
Me.ExitButton.Size = New System.Drawing.Size(55, 25)
Me.ExitButton.TabIndex = 8
Me.ExitButton.TabStop = False
Me.ExitButton.Text = "Exit"
Me.ExitButton.UseVisualStyleBackColor = True
'
'MainForm
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.CancelButton = Me.ExitButton
Me.ClientSize = New System.Drawing.Size(300, 152)
Me.Controls.Add(Me.BinText)
Me.Controls.Add(Me.OctText)
Me.Controls.Add(Me.DecText)
Me.Controls.Add(Me.BinLabel)
Me.Controls.Add(Me.OctLabel)
Me.Controls.Add(Me.DecLabel)
Me.Controls.Add(Me.HexLabel)
Me.Controls.Add(Me.HexText)
Me.Controls.Add(Me.ExitButton)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
Me.ImeMode = System.Windows.Forms.ImeMode.Off
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "MainForm"
Me.Text = "ヘキサくん"
Me.TopMost = True
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents HexText As System.Windows.Forms.TextBox
    Friend WithEvents HexLabel As System.Windows.Forms.Label
    Friend WithEvents DecLabel As System.Windows.Forms.Label
    Friend WithEvents OctLabel As System.Windows.Forms.Label
    Friend WithEvents BinLabel As System.Windows.Forms.Label
    Friend WithEvents DecText As System.Windows.Forms.TextBox
    Friend WithEvents OctText As System.Windows.Forms.TextBox
    Friend WithEvents BinText As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
