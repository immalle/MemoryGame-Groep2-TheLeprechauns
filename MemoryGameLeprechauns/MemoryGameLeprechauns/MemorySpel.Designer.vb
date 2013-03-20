<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemorySpel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemorySpel))
        Me.ButtonExit = New System.Windows.Forms.PictureBox()
        Me.ButtonExitSelected = New System.Windows.Forms.PictureBox()
        Me.ButtonMenu = New System.Windows.Forms.PictureBox()
        Me.ButtonMenuSelected = New System.Windows.Forms.PictureBox()
        Me.KaartenTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ButtonExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonExitSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMenuSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
        Me.ButtonExit.Location = New System.Drawing.Point(1271, 686)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(111, 112)
        Me.ButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonExit.TabIndex = 8
        Me.ButtonExit.TabStop = False
        '
        'ButtonExitSelected
        '
        Me.ButtonExitSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExitSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExitSelected.Image = CType(resources.GetObject("ButtonExitSelected.Image"), System.Drawing.Image)
        Me.ButtonExitSelected.Location = New System.Drawing.Point(1271, 686)
        Me.ButtonExitSelected.Name = "ButtonExitSelected"
        Me.ButtonExitSelected.Size = New System.Drawing.Size(111, 112)
        Me.ButtonExitSelected.TabIndex = 9
        Me.ButtonExitSelected.TabStop = False
        Me.ButtonExitSelected.Visible = False
        '
        'ButtonMenu
        '
        Me.ButtonMenu.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMenu.Image = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsButton_Menu
        Me.ButtonMenu.Location = New System.Drawing.Point(1272, 570)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(110, 110)
        Me.ButtonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonMenu.TabIndex = 10
        Me.ButtonMenu.TabStop = False
        '
        'ButtonMenuSelected
        '
        Me.ButtonMenuSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMenuSelected.Image = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsButton_Menu_clicked
        Me.ButtonMenuSelected.Location = New System.Drawing.Point(1272, 570)
        Me.ButtonMenuSelected.Name = "ButtonMenuSelected"
        Me.ButtonMenuSelected.Size = New System.Drawing.Size(110, 110)
        Me.ButtonMenuSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonMenuSelected.TabIndex = 11
        Me.ButtonMenuSelected.TabStop = False
        Me.ButtonMenuSelected.Visible = False
        '
        'KaartenTimer
        '
        Me.KaartenTimer.Interval = 1000
        '
        'MemorySpel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsSpeelveld
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1384, 800)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonMenuSelected)
        Me.Controls.Add(Me.ButtonExitSelected)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemorySpel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemorySpel"
        CType(Me.ButtonExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonExitSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMenuSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonExit As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonExitSelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonMenu As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonMenuSelected As System.Windows.Forms.PictureBox
    Friend WithEvents KaartenTimer As System.Windows.Forms.Timer
End Class
