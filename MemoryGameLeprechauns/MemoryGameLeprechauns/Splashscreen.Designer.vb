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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splashscreen))
        Me.Splashscreentimer = New System.Windows.Forms.Timer(Me.components)
        Me.Splashscreenlogo = New System.Windows.Forms.PictureBox()
        CType(Me.Splashscreenlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splashscreentimer
        '
        Me.Splashscreentimer.Interval = 500
        '
        'Splashscreenlogo
        '
        Me.Splashscreenlogo.BackColor = System.Drawing.Color.Transparent
        Me.Splashscreenlogo.Image = CType(resources.GetObject("Splashscreenlogo.Image"), System.Drawing.Image)
        Me.Splashscreenlogo.Location = New System.Drawing.Point(24, 7)
        Me.Splashscreenlogo.Name = "Splashscreenlogo"
        Me.Splashscreenlogo.Size = New System.Drawing.Size(951, 489)
        Me.Splashscreenlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Splashscreenlogo.TabIndex = 0
        Me.Splashscreenlogo.TabStop = False
        '
        'Splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 508)
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
