Imports System.Net
Imports System.IO
Public Class Form_Downloader
    Public _FileUrl As String 'A public var that will hold the file's URL
    Public _Location As String 'A public var that will hold the file's local location
    Dim client As WebClient = New WebClient 'A WebClient
    Private Sub Form_Downloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        downloadFiles(_FileUrl, _Location) 'Call the downloadFile sub.
    End Sub
    Public Sub downloadFiles(ByVal pUrl As String, ByVal pFile As String)
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged 'Add a ProgressChanged handler to update the progressbar and the info label
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted 'Add a DownloadComplete handler to triger events when and if the download completes.
        client.DownloadFileAsync(New Uri(pUrl), pFile) 'Start the download.
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString()) 'Calculate the bytes that have been downloaded.
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString()) 'Calculate the total Bytes
        Dim percentage As Double = bytesIn / totalBytes * 100 'Calculate percentace of downloaded file.
        Dim MBin = bytesIn / 1024 / 1024 ' Convert Bytes to MegaBytes
        Dim MBTotal = totalBytes / 1024 / 1024 'Convert Bytes to MegaBytes
        Label_Info.Text = "Downloading now : " & Math.Round(MBin, 2) & "/" & Math.Round(MBTotal, 2) & " - " & Math.Round(percentage, 0) & "%" 'Update the info label
        Dim a = Me.Width 'Get the form's width
        Dim b = Label_Info.Width 'Get the label's width
        Label_Info.Location = New Point((a - b) / 2, Label_Info.Location.Y) 'Center the label to the form.
        progressBar.Maximum = 100 'Set the maximum value for the progress bar
        progressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString()) 'Set the current value of the progres bar.
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK 'Return dialog ok.
        Me.Dispose() 'Dispone the form
    End Sub

    Private Sub Form_Downloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        client.CancelAsync() 'If the user closed the form that means that the download will automaticly cancel\   
        Me.Dispose() 'After cancenling the download dispose the form.
    End Sub
End Class