Public Module SaveJPGFile

    'JPGファイルとして保存する
    Public Sub SaveBitmap(ByVal WrkBitmap As System.Drawing.Bitmap, ByVal WrkFileName As String)

        '品質を指定
        Dim WrkEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)
        WrkEncoderParameters.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 90) '数が大きいほど高品質、[90]を基準にする

        'イメージエンコーダに関する情報を取得する
        Dim WrkImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo = GetImageCodecInfo("image/jpeg")

        'ファイルに保存
        WrkBitmap.Save(WrkFileName, WrkImageCodecInfo, WrkEncoderParameters)

    End Sub

    'イメージコーデックを返す
    Private Function GetImageCodecInfo(ByVal WrkMimeType As String) As System.Drawing.Imaging.ImageCodecInfo

        'イメージコーデックの一覧を取得
        Dim WrkImageCodecList As System.Drawing.Imaging.ImageCodecInfo() = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()

        'イメージコーデックを検索
        For Each WrkImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo In WrkImageCodecList
            If WrkImageCodecInfo.MimeType = WrkMimeType Then
                '見つかった場合

                'イメージコーデックを返す
                Return WrkImageCodecInfo

            End If
        Next

        '見つからなかった場合
        Return Nothing
    End Function

End Module
