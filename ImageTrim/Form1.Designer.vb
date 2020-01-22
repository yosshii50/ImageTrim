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
        Me.Txty1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtx1 = New System.Windows.Forms.TextBox()
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
        Me.RbtR270 = New System.Windows.Forms.RadioButton()
        Me.RbtR180 = New System.Windows.Forms.RadioButton()
        Me.RbtR090 = New System.Windows.Forms.RadioButton()
        Me.RbtR000 = New System.Windows.Forms.RadioButton()
        Me.Txty2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtx2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(408, 122)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(121, 42)
        Me.BtnGo.TabIndex = 13
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'FolderPathNameSRC
        '
        Me.FolderPathNameSRC.Location = New System.Drawing.Point(59, 6)
        Me.FolderPathNameSRC.Name = "FolderPathNameSRC"
        Me.FolderPathNameSRC.Size = New System.Drawing.Size(410, 19)
        Me.FolderPathNameSRC.TabIndex = 0
        '
        'BtnSelectSRC
        '
        Me.BtnSelectSRC.Location = New System.Drawing.Point(475, 6)
        Me.BtnSelectSRC.Name = "BtnSelectSRC"
        Me.BtnSelectSRC.Size = New System.Drawing.Size(66, 19)
        Me.BtnSelectSRC.TabIndex = 1
        Me.BtnSelectSRC.Text = "Select"
        Me.BtnSelectSRC.UseVisualStyleBackColor = True
        '
        'FolderPathNameDST
        '
        Me.FolderPathNameDST.Location = New System.Drawing.Point(59, 56)
        Me.FolderPathNameDST.Name = "FolderPathNameDST"
        Me.FolderPathNameDST.Size = New System.Drawing.Size(410, 19)
        Me.FolderPathNameDST.TabIndex = 3
        '
        'BtnSelectDST
        '
        Me.BtnSelectDST.Location = New System.Drawing.Point(475, 56)
        Me.BtnSelectDST.Name = "BtnSelectDST"
        Me.BtnSelectDST.Size = New System.Drawing.Size(66, 19)
        Me.BtnSelectDST.TabIndex = 4
        Me.BtnSelectDST.Text = "Select"
        Me.BtnSelectDST.UseVisualStyleBackColor = True
        '
        'Txty1
        '
        Me.Txty1.Location = New System.Drawing.Point(33, 43)
        Me.Txty1.Name = "Txty1"
        Me.Txty1.Size = New System.Drawing.Size(51, 19)
        Me.Txty1.TabIndex = 7
        Me.Txty1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "y1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "x1"
        '
        'Txtx1
        '
        Me.Txtx1.Location = New System.Drawing.Point(33, 18)
        Me.Txtx1.Name = "Txtx1"
        Me.Txtx1.Size = New System.Drawing.Size(51, 19)
        Me.Txtx1.TabIndex = 6
        Me.Txtx1.Text = "0"
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
        Me.Txtheight.Location = New System.Drawing.Point(128, 43)
        Me.Txtheight.Name = "Txtheight"
        Me.Txtheight.Size = New System.Drawing.Size(51, 19)
        Me.Txtheight.TabIndex = 9
        Me.Txtheight.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "height"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "width"
        '
        'Txtwidth
        '
        Me.Txtwidth.Location = New System.Drawing.Point(128, 18)
        Me.Txtwidth.Name = "Txtwidth"
        Me.Txtwidth.Size = New System.Drawing.Size(51, 19)
        Me.Txtwidth.TabIndex = 8
        Me.Txtwidth.Text = "0"
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.Location = New System.Drawing.Point(15, 243)
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
        Me.TxtSearchPattern.TabIndex = 2
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
        Me.TxtAddNM.TabIndex = 5
        Me.TxtAddNM.Text = "Conv_"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtR270)
        Me.GroupBox1.Controls.Add(Me.RbtR180)
        Me.GroupBox1.Controls.Add(Me.RbtR090)
        Me.GroupBox1.Controls.Add(Me.RbtR000)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 42)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rotation"
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
        'Txty2
        '
        Me.Txty2.Location = New System.Drawing.Point(208, 43)
        Me.Txty2.Name = "Txty2"
        Me.Txty2.Size = New System.Drawing.Size(51, 19)
        Me.Txty2.TabIndex = 11
        Me.Txty2.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "y2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(185, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "x2"
        '
        'Txtx2
        '
        Me.Txtx2.Location = New System.Drawing.Point(208, 18)
        Me.Txtx2.Name = "Txtx2"
        Me.Txtx2.Size = New System.Drawing.Size(51, 19)
        Me.Txtx2.TabIndex = 10
        Me.Txtx2.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txtx1)
        Me.GroupBox2.Controls.Add(Me.Txty2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Txty1)
        Me.GroupBox2.Controls.Add(Me.Txtheight)
        Me.GroupBox2.Controls.Add(Me.Txtx2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Txtwidth)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 76)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(417, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(52, 16)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Same"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 27)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "B5R→A5"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 27)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "B5R→B6"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 291)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtAddNM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSearchPattern)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FolderPathNameDST)
        Me.Controls.Add(Me.BtnSelectDST)
        Me.Controls.Add(Me.FolderPathNameSRC)
        Me.Controls.Add(Me.BtnSelectSRC)
        Me.Controls.Add(Me.BtnGo)
        Me.Name = "Form1"
        Me.Text = "ImageTrim"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents FolderPathNameSRC As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectSRC As System.Windows.Forms.Button
    Friend WithEvents FolderPathNameDST As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectDST As System.Windows.Forms.Button
    Friend WithEvents Txty1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtx1 As System.Windows.Forms.TextBox
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
    Friend WithEvents Txty2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtx2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
