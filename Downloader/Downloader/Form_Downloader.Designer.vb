<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Downloader
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
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.Label_Info = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 66)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(263, 23)
        Me.progressBar.TabIndex = 0
        '
        'Label_Info
        '
        Me.Label_Info.AutoSize = True
        Me.Label_Info.Location = New System.Drawing.Point(12, 50)
        Me.Label_Info.Name = "Label_Info"
        Me.Label_Info.Size = New System.Drawing.Size(31, 13)
        Me.Label_Info.TabIndex = 1
        Me.Label_Info.Text = "$Info"
        '
        'Form_Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 128)
        Me.Controls.Add(Me.Label_Info)
        Me.Controls.Add(Me.progressBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Downloader"
        Me.Text = "Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents Label_Info As Label
End Class
