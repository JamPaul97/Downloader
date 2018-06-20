<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_location = New System.Windows.Forms.Button()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.txt_Location = New System.Windows.Forms.TextBox()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_location
        '
        Me.btn_location.Location = New System.Drawing.Point(15, 64)
        Me.btn_location.Name = "btn_location"
        Me.btn_location.Size = New System.Drawing.Size(146, 25)
        Me.btn_location.TabIndex = 0
        Me.btn_location.Text = "Save File Destination"
        Me.btn_location.UseVisualStyleBackColor = True
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(73, 12)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(368, 20)
        Me.txt_url.TabIndex = 1
        '
        'txt_Location
        '
        Me.txt_Location.Location = New System.Drawing.Point(73, 38)
        Me.txt_Location.Name = "txt_Location"
        Me.txt_Location.Size = New System.Drawing.Size(368, 20)
        Me.txt_Location.TabIndex = 2
        '
        'btn_download
        '
        Me.btn_download.Location = New System.Drawing.Point(295, 64)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(146, 25)
        Me.btn_download.TabIndex = 3
        Me.btn_download.Text = "Download"
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "File Url :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Local File :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 98)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.txt_Location)
        Me.Controls.Add(Me.txt_url)
        Me.Controls.Add(Me.btn_location)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(469, 137)
        Me.MinimumSize = New System.Drawing.Size(469, 137)
        Me.Name = "Form1"
        Me.Text = "Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_location As Button
    Friend WithEvents txt_url As TextBox
    Friend WithEvents txt_Location As TextBox
    Friend WithEvents btn_download As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
