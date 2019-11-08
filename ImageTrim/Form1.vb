
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

        On Error Resume Next
        Dim WrkFileList As String() = System.IO.Directory.GetFiles(FolderPathNameSRC.Text, TxtSearchPattern.Text)
        On Error GoTo 0

        For Each WrkStr As String In WrkFileList
            Dim WrkCnt As Integer

            Dim WrkFileName As String
            WrkFileName = System.IO.Path.GetFileNameWithoutExtension(WrkStr)

            Dim WrkFilePathName As String
            WrkFilePathName = FolderPathNameDST.Text & "\" & TxtAddNM.Text & WrkFileName & ".jpg"

            FileLoadTrimSave.LoadTrimSave(WrkStr, WrkFilePathName, CInt(Txtx.Text), CInt(Txty.Text), CInt(Txtwidth.Text), CInt(Txtheight.Text))

            WrkCnt = WrkCnt + 1
            LblMsg.Text = WrkStr & vbCrLf _
                        & WrkFilePathName & vbCrLf _
                        & WrkCnt & "/" & WrkFileList.Count
            LblMsg.Refresh()

        Next

    End Sub

End Class
