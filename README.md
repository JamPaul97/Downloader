
[![ForTheBadge built-with-love](http://ForTheBadge.com/images/badges/built-with-love.svg)](https://GitHub.com/Naereen/)
[![forthebadge](https://forthebadge.com/images/badges/winter-is-coming.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/60-percent-of-the-time-works-every-time.svg)](https://forthebadge.com)
[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source-200x33.png?v=103)](https://github.com/ellerbrock/open-source-badges/)

# Downloader
A form that can be used on any application to download files.

This is a simple example of how you can make a renewable downloader that will show a form and download a file with progress bar & bytes info.

The code is commented and easy to understand and reproduce on any project.
This example takes user's input from textboxes to download the files but in your project, you can just call them automatically to your desire.

To reproduce the donwload you have to :

#### 1.Create a new form and call it (Example :Form_Downloader)

#### 2.On the new form create 2 public vars.
* _FileUrl
* _Location

#### 3.Declare a client

```Dim client As WebClient = New WebClient 'A WebClient```

#### 4.On the form.Load event add this line
```downloadFiles(_FileUrl, _Location```

#### 5.Make a sub called downloadFiles.

```
Public Sub downloadFiles(ByVal pUrl As String, ByVal pFile As String)
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged 'Add a ProgressChanged handler to update the progressbar and the info label
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted 'Add a DownloadComplete handler to triger events when and if the download completes.
        client.DownloadFileAsync(New Uri(pUrl), pFile) 'Start the download.
    End Sub
```

#### 6.Make the Handlers

* ProgressChanged Handels
```
Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString()) 'Calculate the bytes that have been downloaded.
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString()) 'Calculate the total Bytes
        Dim percentage As Double = bytesIn / totalBytes * 100 'Calculate percentace of downloaded file.
        Dim MBin = bytesIn / 1024 / 1024 ' Convert Bytes to MegaBytes
        Dim MBTotal = totalBytes / 1024 / 1024 'Convert Bytes to MegaBytes
        progressBar.Maximum = 100 'Set the maximum value for the progress bar
        progressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString()) 'Set the current value of the progres bar.
    End Sub
```
'There are some vars here you can use on your own way.
* DownloadCompleted Handler
```
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        'Here you can do what ever you want.
        'You can just close the form, dispote it sent a message....
    End Sub
```
* FormClosing event
```
    Private Sub Form_Downloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Its your chouse again if you want to cancel the download if the form close.
        'If you dont cancel the download and the form close the download will continue to download
        client.CancelAsync() 'If the user closed the form that means that the download will automaticly cancel\   
        Me.Dispose() 'After cancenling the download dispose the form.
    End Sub
```
>This event will trigger if the form close for any reason.

#### 7.Call the downloader
To call the download you will have to make make a new downloader :
```
Dim newDownloader As Form_Downloader = New Form_Downloader 'Make a new downloader
newDownloader._FileUrl = "A url as string" 'Set the new downloader's url
newDownloader._Location = "The file location as string" 'Set the new downloader's file location
```
Then you can either call the form as a dialog. By doing it this way the main form will be paused and the form will wait for the download either to complete or cancel.
```
If newDownloader.ShowDialog = DialogResult.OK Then ' Show the downloader and wait 
    MsgBox("Downloaded")
Else
    MsgBox("Download Canceld")
End If
```
