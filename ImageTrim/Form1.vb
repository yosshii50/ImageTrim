
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FolderPathNameSRC.Text = "C:\!Delete"
        'FolderPathNameDST.Text = "C:\!Delete\DST"
        'TxtAddNM.Text = ""
        'Txtwidth.Text = "1166"
    End Sub

    'フォルダ選択
    '[Select]実行
    Private Sub BtnSelectSRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSRC.Click
        Call BtnSelectSRC_Exec()
    End Sub
    Public Sub BtnSelectSRC_Exec()

        'フォルダ選択
        SelectFolder.BtnSelect_Core(Me, FolderPathNameSRC.Text)
        
    End Sub

    'フォルダ選択
    '[Select]実行
    Private Sub BtnSelectDST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectDST.Click
        Call BtnSelectDST_Exec()
    End Sub
    Public Sub BtnSelectDST_Exec()

        'フォルダ選択
        SelectFolder.BtnSelect_Core(Me, FolderPathNameDST.Text)

    End Sub

    '[Go]実行
    Private Sub BtnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        Call BtnGo_Exec()
    End Sub
    Public Sub BtnGo_Exec()

        Dim WrkRotation As Integer
        If RbtR090.Checked = True Then
            WrkRotation = 90
        ElseIf RbtR180.Checked = True Then
            WrkRotation = 180
        ElseIf RbtR270.Checked = True Then
            WrkRotation = 270
        Else
            WrkRotation = 0
        End If

        On Error Resume Next
        Dim WrkFileList As String() = System.IO.Directory.GetFiles(FolderPathNameSRC.Text, TxtSearchPattern.Text)
        On Error GoTo 0

        For Each WrkStr As String In WrkFileList
            Dim WrkCnt As Integer

            Dim WrkFileName As String
            WrkFileName = System.IO.Path.GetFileNameWithoutExtension(WrkStr)

            Dim WrkFilePathName As String
            WrkFilePathName = FolderPathNameDST.Text & "\" & TxtAddNM.Text & WrkFileName & ".jpg"

            FileLoadTrimSave.LoadTrimSave(WrkStr, WrkFilePathName, GInt(Txtx1.Text), GInt(Txty1.Text), GInt(Txtwidth.Text), GInt(Txtheight.Text), WrkRotation)

            WrkCnt = WrkCnt + 1
            LblMsg.Text = WrkStr & vbCrLf _
                        & WrkFilePathName & vbCrLf _
                        & WrkCnt & "/" & WrkFileList.Count
            LblMsg.Refresh()

        Next

    End Sub

    Private Sub Txtx1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtx1.TextChanged
        Call Txtwidth_Calc()
    End Sub
    Private Sub Txtx2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtx2.TextChanged
        Call Txtwidth_Calc()
    End Sub
    Private Sub Txtwidth_Calc()
        Txtwidth.Text = GInt(Txtx2.Text) - GInt(Txtx1.Text)
    End Sub

    Private Sub Txty1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txty1.TextChanged
        Call Txtheight_Calc()
    End Sub
    Private Sub Txty2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txty2.TextChanged
        Call Txtheight_Calc()
    End Sub
    Private Sub Txtheight_Calc()
        Txtheight.Text = GInt(Txty2.Text) - GInt(Txty1.Text)
    End Sub

    Private Sub Txtwidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtwidth.TextChanged
        Txtx2.Text = GInt(Txtwidth.Text) + GInt(Txtx1.Text)
    End Sub

    Private Sub Txtheight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtheight.TextChanged
        Txty2.Text = GInt(Txtheight.Text) + GInt(Txty1.Text)
    End Sub

    Private Function GInt(ByVal WrkStr As String) As Integer
        If WrkStr = "" Then
            Return 0
        Else
            Return CInt(WrkStr)
        End If
    End Function

    Private Sub FolderPathNameSRC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderPathNameSRC.TextChanged
        Call FolderPathNameSRC_Copy()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Call FolderPathNameSRC_Copy()
    End Sub

    Private Sub FolderPathNameSRC_Copy()
        If CheckBox1.Checked = True Then
            FolderPathNameDST.Text = FolderPathNameSRC.Text
        End If
    End Sub

    'B5R→A5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Txtx1.Text = 0
        Txtwidth.Text = 1646
        Txty1.Text = 130
        Txtheight.Text = 1165
        RbtR090.Checked = True
    End Sub

    'B5R→B6
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Txtx1.Text = 0
        Txtwidth.Text = 1424
        Txty1.Text = 208
        Txtheight.Text = 1008
        RbtR090.Checked = True
    End Sub
End Class
