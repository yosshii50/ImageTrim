Public Module SelectFolder

    Public Function BtnSelect_Core(ByVal owner As System.Windows.Forms.IWin32Window, ByRef WrkFolderPathName As String) As Boolean

        Dim WrkFBD As New FolderBrowserDialog
        With WrkFBD

            .RootFolder = Environment.SpecialFolder.Desktop 'ルートフォルダ
            .SelectedPath = FolderNameCheck(WrkFolderPathName) '初期フォルダ
            .ShowNewFolderButton = False '新しいフォルダの作成

            'ダイアログ表示
            If .ShowDialog(owner) = DialogResult.OK Then

                WrkFolderPathName = .SelectedPath

                Return True

            End If

        End With

        Return False
    End Function

    'フォルダ名をきれいにする
    Public Function FolderNameCheck(ByVal WrkStr As String) As String

        If Strings.Left(WrkStr, 1) = """" And Strings.Right(WrkStr, 1) = """" Then
            '前後に["]が付いている場合

            '前後の["]を除ける
            WrkStr = Microsoft.VisualBasic.Strings.Mid(WrkStr, 2, WrkStr.Length - 2)

        End If

        If Strings.Right(WrkStr, 1) = "\" Then
            '文字列の最後が[\]の場合

            '[\]を除ける
            WrkStr = Microsoft.VisualBasic.Strings.Left(WrkStr, WrkStr.Length - 1)

        End If

        Return WrkStr
    End Function

End Module
