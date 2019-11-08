<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.FolderPathNameSRC = New System.Windows.Forms.TextBox()
        Me.BtnSelectSRC = New System.Windows.Forms.Button()
        Me.FolderPathNameDST = New System.Windows.Forms.TextBox()
        Me.BtnSelectDST = New System.Windows.Forms.Button()
        Me.Txty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtheight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtwidth = New System.Windows.Forms.TextBox()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSearchPattern = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAddNM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtR000 = New System.Windows.Forms.RadioButton()
        Me.RbtR090 = New System.Windows.Forms.RadioButton()
        Me.RbtR180 = New System.Windows.Forms.RadioButton()
        Me.RbtR270 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(419, 169)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(121, 42)
        Me.BtnGo.TabIndex = 0
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'FolderPathNameSRC
        '
        Me.FolderPathNameSRC.Location = New System.Drawing.Point(59, 6)
        Me.FolderPathNameSRC.Name = "FolderPathNameSRC"
        Me.FolderPathNameSRC.Size = New System.Drawing.Size(410, 19)
        Me.FolderPathNameSRC.TabIndex = 6
        '
        'BtnSelectSRC
        '
        Me.BtnSelectSRC.Location = New System.Drawing.Point(475, 6)
        Me.BtnSelectSRC.Name = "BtnSelectSRC"
        Me.BtnSelectSRC.Size = New System.Drawing.Size(66, 19)
        Me.BtnSelectSRC.TabIndex = 5
        Me.BtnSelectSRC.Text = "Select"
        Me.BtnSelectSRC.UseVisualStyleBackColor = True
        '
        'FolderPathNameDST
        '
        Me.FolderPathNameDST.Location = New System.Drawing.Point(59, 56)
        Me.FolderPathNameDST.Name = "FolderPathNameDST"
        Me.FolderPathNameDST.Size = New System.Drawing.Size(410, 19)
        Me.FolderPathNameDST.TabIndex = 8
        '
        'BtnSelectDST
        '
        Me.BtnSelectDST.Location = New System.Drawing.Point(475, 56)
        Me.BtnSelectDST.Name = "BtnSelectDST"
        Me.BtnSelectDST.Size = New System.Drawing.Size(66, 19)
        Me.BtnSelectDST.TabIndex = 7
        Me.BtnSelectDST.Text = "Select"
        Me.BtnSelectDST.UseVisualStyleBackColor = True
        '
        'Txty
        '
        Me.Txty.Location = New System.Drawing.Point(59, 131)
        Me.Txty.Name = "Txty"
        Me.Txty.Size = New System.Drawing.Size(51, 19)
        Me.Txty.TabIndex = 12
        Me.Txty.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "x"
        '
        'Txtx
        '
        Me.Txtx.Location = New System.Drawing.Point(59, 106)
        Me.Txtx.Name = "Txtx"
        Me.Txtx.Size = New System.Drawing.Size(51, 19)
        Me.Txtx.TabIndex = 9
        Me.Txtx.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "SRC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "DST"
        '
        'Txtheight
        '
        Me.Txtheight.Location = New System.Drawing.Point(59, 181)
        Me.Txtheight.Name = "Txtheight"
        Me.Txtheight.Size = New System.Drawing.Size(51, 19)
        Me.Txtheight.TabIndex = 18
        Me.Txtheight.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "height"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "width"
        '
        'Txtwidth
        '
        Me.Txtwidth.Location = New System.Drawing.Point(59, 156)
        Me.Txtwidth.Name = "Txtwidth"
        Me.Txtwidth.Size = New System.Drawing.Size(51, 19)
        Me.Txtwidth.TabIndex = 15
        Me.Txtwidth.Text = "0"
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.Location = New System.Drawing.Point(128, 131)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(26, 12)
        Me.LblMsg.TabIndex = 19
        Me.LblMsg.Text = "Msg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 12)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Pattern"
        '
        'TxtSearchPattern
        '
        Me.TxtSearchPattern.Location = New System.Drawing.Point(59, 31)
        Me.TxtSearchPattern.Name = "TxtSearchPattern"
        Me.TxtSearchPattern.Size = New System.Drawing.Size(82, 19)
        Me.TxtSearchPattern.TabIndex = 20
        Me.TxtSearchPattern.Text = "*.jpg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "AddName"
        '
        'TxtAddNM
        '
        Me.TxtAddNM.Location = New System.Drawing.Point(72, 81)
        Me.TxtAddNM.Name = "TxtAddNM"
        Me.TxtAddNM.Size = New System.Drawing.Size(82, 19)
        Me.TxtAddNM.TabIndex = 22
        Me.TxtAddNM.Text = "Conv_"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtR270)
        Me.GroupBox1.Controls.Add(Me.RbtR180)
        Me.GroupBox1.Controls.Add(Me.RbtR090)
        Me.GroupBox1.Controls.Add(Me.RbtR000)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 42)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rotation"
        '
        'RbtR000
        '
        Me.RbtR000.AutoSize = True
        Me.RbtR000.Checked = True
        Me.RbtR000.Location = New System.Drawing.Point(6, 18)
        Me.RbtR000.Name = "RbtR000"
        Me.RbtR000.Size = New System.Drawing.Size(49, 16)
        Me.RbtR000.TabIndex = 0
        Me.RbtR000.TabStop = True
        Me.RbtR000.Text = "None"
        Me.RbtR000.UseVisualStyleBackColor = True
        '
        'RbtR090
        '
        Me.RbtR090.AutoSize = True
        Me.RbtR090.Location = New System.Drawing.Point(61, 18)
        Me.RbtR090.Name = "RbtR090"
        Me.RbtR090.Size = New System.Drawing.Size(47, 16)
        Me.RbtR090.TabIndex = 1
        Me.RbtR090.Text = "90°"
        Me.RbtR090.UseVisualStyleBackColor = True
        '
        'RbtR180
        '
        Me.RbtR180.AutoSize = True
        Me.RbtR180.Location = New System.Drawing.Point(114, 18)
        Me.RbtR180.Name = "RbtR180"
        Me.RbtR180.Size = New System.Drawing.Size(53, 16)
        Me.RbtR180.TabIndex = 2
        Me.RbtR180.Text = "180°"
        Me.RbtR180.UseVisualStyleBackColor = True
        '
        'RbtR270
        '
        Me.RbtR270.AutoSize = True
        Me.RbtR270.Location = New System.Drawing.Point(173, 18)
        Me.RbtR270.Name = "RbtR270"
        Me.RbtR270.Size = New System.Drawing.Size(53, 16)
        Me.RbtR270.TabIndex = 3
        Me.RbtR270.Text = "270°"
        Me.RbtR270.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtAddNM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSearchPattern)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.Txtheight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtwidth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtx)
        Me.Controls.Add(Me.FolderPathNameDST)
        Me.Controls.Add(Me.BtnSelectDST)
        Me.Controls.Add(Me.FolderPathNameSRC)
        Me.Controls.Add(Me.BtnSelectSRC)
        Me.Controls.Add(Me.BtnGo)
        Me.Name = "Form1"
        Me.Text = "ImageTrim"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents FolderPathNameSRC As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectSRC As System.Windows.Forms.Button
    Friend WithEvents FolderPathNameDST As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectDST As System.Windows.Forms.Button
    Friend WithEvents Txty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtx As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtheight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtwidth As System.Windows.Forms.TextBox
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchPattern As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtAddNM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtR270 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtR180 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtR090 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtR000 As System.Windows.Forms.RadioButton

End Class
