Public Module FileLoadTrimSave

    'ファイルからトリミングして保存
    Public Sub LoadTrimSave(ByVal SrcFileName As String, ByVal DstFileName As String, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal WrkRotation As Integer)

        ''画像ファイルを読み込んで、Imageオブジェクトとして取得する
        Dim WrkImage As System.Drawing.Image = System.Drawing.Image.FromFile(SrcFileName)

        '幅/高さが指定されてない場合、変更しない
        If width = 0 Then
            width = WrkImage.Width - x
        End If
        If height = 0 Then
            height = WrkImage.Height - y
        End If

        '描画先とするImageオブジェクトを作成する
        Dim WrkBitmap As New System.Drawing.Bitmap(width, height)

        'BITMAPにImageを描画
        DrawOnBITMAP(WrkBitmap, WrkImage, x, y)

        '回転実行
        Select Case WrkRotation
            Case 90
                WrkBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Case 180
                WrkBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Case 270
                WrkBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End Select

        'ファイルに保存
        SaveJPGFile.SaveBitmap(WrkBitmap, DstFileName)

        'リソース解放
        WrkImage.Dispose()
        WrkBitmap.Dispose()

    End Sub

    'BITMAPにImageを描画
    Private Sub DrawOnBITMAP(ByRef WrkBitmap As System.Drawing.Bitmap, ByRef WrkImage As System.Drawing.Image, ByVal x As Integer, ByVal y As Integer)

        Dim WrkGraphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(WrkBitmap)

        WrkGraphics.DrawImage(WrkImage, x * -1, y * -1, WrkImage.Width, WrkImage.Height)

        WrkGraphics.Dispose()

    End Sub

End Module
