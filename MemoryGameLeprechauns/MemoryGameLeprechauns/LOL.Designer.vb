<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOL
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
        Me.TimerIndexLOL = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxLOL = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLOL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerIndexLOL
        '
        Me.TimerIndexLOL.Interval = 300
        '
        'PictureBoxLOL
        '
        Me.PictureBoxLOL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLOL.Image = Global.MemoryGameLeprechauns.My.Resources.Resources.Stino
        Me.PictureBoxLOL.Location = New System.Drawing.Point(518, 191)
        Me.PictureBoxLOL.Name = "PictureBoxLOL"
        Me.PictureBoxLOL.Size = New System.Drawing.Size(272, 304)
        Me.PictureBoxLOL.TabIndex = 0
        Me.PictureBoxLOL.TabStop = False
        '
        'LOL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 761)
        Me.Controls.Add(Me.PictureBoxLOL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LOL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOL"
        CType(Me.PictureBoxLOL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerIndexLOL As System.Windows.Forms.Timer
    Friend WithEvents PictureBoxLOL As System.Windows.Forms.PictureBox
End Class
