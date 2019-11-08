Public Module FileLoadTrimSave

    'ファイルからトリミングして保存
    Public Sub LoadTrimSave(ByVal SrcFileName As String, ByVal DstFileName As String, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)

        ''画像ファイルを読み込んで、Imageオブジェクトとして取得する
        Dim WrkImage As System.Drawing.Image = System.Drawing.Image.FromFile(SrcFileName)

        '描画先とするImageオブジェクトを作成する
        Dim WrkBitmap As New System.Drawing.Bitmap(width, height)

        'BITMAPにImageを描画
        DrawOnBITMAP(WrkBitmap, WrkImage, x, y)

        'ファイルに保存
        SaveJPGFile.SaveBitmap(WrkBitmap, DstFileName)

        'Imageオブジェクトのリソースを解放する
        WrkImage.Dispose()

    End Sub

    'BITMAPにImageを描画
    Private Sub DrawOnBITMAP(ByVal WrkBitmap As System.Drawing.Bitmap, ByVal WrkImage As System.Drawing.Image, ByVal x As Integer, ByVal y As Integer)

        Dim WrkGraphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(WrkBitmap)

        WrkGraphics.DrawImage(WrkImage, x * -1, y * -1, WrkImage.Width, WrkImage.Height)

        WrkGraphics.Dispose()

    End Sub

End Module
