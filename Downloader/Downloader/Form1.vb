Imports System.IO
Public Class Form1
    Private Sub btn_location_Click(sender As Object, e As EventArgs) Handles btn_location.Click
        'This is SaveFileDialong that you can use to make a full destination path for your file.
        Dim SD As SaveFileDialog = New SaveFileDialog
        If SD.ShowDialog = DialogResult.OK Then
            txt_Location.Text = SD.FileName
        End If
    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click
        Dim newDownloader As Form_Downloader = New Form_Downloader 'Make a new downloader
        newDownloader._FileUrl = txt_url.Text 'Set the new downloader's url
        newDownloader._Location = txt_Location.Text 'Set the new downloader's file location
        If newDownloader.ShowDialog = DialogResult.OK Then ' Show the downloader and wait 
            'Code here that will triger when and if the download is completed.
            '
            MsgBox("Downloaded")
        Else
            'Code here that will triger if the download is cancels for any reason.
            MsgBox("Download Canceld")
            'This will check if the file exist and delete it cause the downloader was canceled and the file is partial downloaded.
            If File.Exists(txt_Location.Text) Then
                File.Delete(txt_Location.Text)
            End If
        End If
    End Sub
End Class
