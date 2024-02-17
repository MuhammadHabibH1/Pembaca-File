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
        Me.Button_pencarian = New System.Windows.Forms.Button()
        Me.TreeView_tampilanfolder = New System.Windows.Forms.TreeView()
        Me.TextBox_pencarian = New System.Windows.Forms.TextBox()
        Me.TextBox_tampilanfolder = New System.Windows.Forms.TextBox()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button_pencarian
        '
        Me.Button_pencarian.Location = New System.Drawing.Point(233, 12)
        Me.Button_pencarian.Name = "Button_pencarian"
        Me.Button_pencarian.Size = New System.Drawing.Size(118, 29)
        Me.Button_pencarian.TabIndex = 0
        Me.Button_pencarian.Text = "Button1"
        Me.Button_pencarian.UseVisualStyleBackColor = True
        '
        'TreeView_tampilanfolder
        '
        Me.TreeView_tampilanfolder.Location = New System.Drawing.Point(13, 47)
        Me.TreeView_tampilanfolder.Name = "TreeView_tampilanfolder"
        Me.TreeView_tampilanfolder.Size = New System.Drawing.Size(416, 403)
        Me.TreeView_tampilanfolder.TabIndex = 1
        '
        'TextBox_pencarian
        '
        Me.TextBox_pencarian.Location = New System.Drawing.Point(13, 13)
        Me.TextBox_pencarian.Multiline = True
        Me.TextBox_pencarian.Name = "TextBox_pencarian"
        Me.TextBox_pencarian.Size = New System.Drawing.Size(214, 28)
        Me.TextBox_pencarian.TabIndex = 2
        '
        'TextBox_tampilanfolder
        '
        Me.TextBox_tampilanfolder.Location = New System.Drawing.Point(439, 94)
        Me.TextBox_tampilanfolder.Multiline = True
        Me.TextBox_tampilanfolder.Name = "TextBox_tampilanfolder"
        Me.TextBox_tampilanfolder.Size = New System.Drawing.Size(353, 96)
        Me.TextBox_tampilanfolder.TabIndex = 3
        '
        'Label_status
        '
        Me.Label_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_status.Location = New System.Drawing.Point(439, 50)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(357, 31)
        Me.Label_status.TabIndex = 4
        Me.Label_status.Text = "Label1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 459)
        Me.Controls.Add(Me.Label_status)
        Me.Controls.Add(Me.TextBox_tampilanfolder)
        Me.Controls.Add(Me.TextBox_pencarian)
        Me.Controls.Add(Me.TreeView_tampilanfolder)
        Me.Controls.Add(Me.Button_pencarian)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_pencarian As Button
    Friend WithEvents TreeView_tampilanfolder As TreeView
    Friend WithEvents TextBox_pencarian As TextBox
    Friend WithEvents TextBox_tampilanfolder As TextBox
    Friend WithEvents Label_status As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
