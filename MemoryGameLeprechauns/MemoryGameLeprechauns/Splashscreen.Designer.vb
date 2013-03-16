<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splashscreen
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
        Me.components = New System.ComponentModel.Container()
        Me.Splashscreenlogo = New System.Windows.Forms.PictureBox()
        Me.Splashscreentimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Splashscreenlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splashscreenlogo
        '
        Me.Splashscreenlogo.BackColor = System.Drawing.Color.Transparent
        Me.Splashscreenlogo.Image = Global.MemoryGameLeprechauns.My.Resources.Resources.Splashscreen
        Me.Splashscreenlogo.Location = New System.Drawing.Point(-5, -2)
        Me.Splashscreenlogo.Name = "Splashscreenlogo"
        Me.Splashscreenlogo.Size = New System.Drawing.Size(382, 369)
        Me.Splashscreenlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Splashscreenlogo.TabIndex = 0
        Me.Splashscreenlogo.TabStop = False
        '
        'Splashscreentimer
        '
        Me.Splashscreentimer.Interval = 500
        '
        'Splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 369)
        Me.Controls.Add(Me.Splashscreenlogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Splashscreenlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splashscreenlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Splashscreentimer As System.Windows.Forms.Timer

End Class
