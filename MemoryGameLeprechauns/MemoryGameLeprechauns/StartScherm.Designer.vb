<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScherm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartScherm))
        Me.ButtonEasy = New System.Windows.Forms.PictureBox()
        Me.ButtonMedium = New System.Windows.Forms.PictureBox()
        Me.ButtonHard = New System.Windows.Forms.PictureBox()
        Me.ButtonEasySelected = New System.Windows.Forms.PictureBox()
        Me.ButtonMediumSelected = New System.Windows.Forms.PictureBox()
        Me.ButtonHardSelected = New System.Windows.Forms.PictureBox()
        Me.ButtonExitSelected = New System.Windows.Forms.PictureBox()
        Me.ButtonExit = New System.Windows.Forms.PictureBox()
        Me.AfbeeldingenPad = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighscoresDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HighscoresDataSet = New MemoryGameLeprechauns.HighscoresDataSet()
        CType(Me.ButtonEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEasySelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMediumSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonHardSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonExitSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoresDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEasy
        '
        Me.ButtonEasy.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEasy.BackgroundImage = CType(resources.GetObject("ButtonEasy.BackgroundImage"), System.Drawing.Image)
        Me.ButtonEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEasy.Location = New System.Drawing.Point(723, 221)
        Me.ButtonEasy.Name = "ButtonEasy"
        Me.ButtonEasy.Size = New System.Drawing.Size(441, 115)
        Me.ButtonEasy.TabIndex = 0
        Me.ButtonEasy.TabStop = False
        '
        'ButtonMedium
        '
        Me.ButtonMedium.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMedium.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsButton_Medium
        Me.ButtonMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMedium.Location = New System.Drawing.Point(720, 335)
        Me.ButtonMedium.Name = "ButtonMedium"
        Me.ButtonMedium.Size = New System.Drawing.Size(441, 115)
        Me.ButtonMedium.TabIndex = 1
        Me.ButtonMedium.TabStop = False
        '
        'ButtonHard
        '
        Me.ButtonHard.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHard.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsButton_Hard
        Me.ButtonHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHard.Location = New System.Drawing.Point(720, 447)
        Me.ButtonHard.Name = "ButtonHard"
        Me.ButtonHard.Size = New System.Drawing.Size(441, 115)
        Me.ButtonHard.TabIndex = 2
        Me.ButtonHard.TabStop = False
        '
        'ButtonEasySelected
        '
        Me.ButtonEasySelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEasySelected.BackgroundImage = CType(resources.GetObject("ButtonEasySelected.BackgroundImage"), System.Drawing.Image)
        Me.ButtonEasySelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEasySelected.Location = New System.Drawing.Point(723, 221)
        Me.ButtonEasySelected.Name = "ButtonEasySelected"
        Me.ButtonEasySelected.Size = New System.Drawing.Size(441, 115)
        Me.ButtonEasySelected.TabIndex = 3
        Me.ButtonEasySelected.TabStop = False
        Me.ButtonEasySelected.Visible = False
        '
        'ButtonMediumSelected
        '
        Me.ButtonMediumSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMediumSelected.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsButton_Medium_Clicked
        Me.ButtonMediumSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMediumSelected.Location = New System.Drawing.Point(720, 335)
        Me.ButtonMediumSelected.Name = "ButtonMediumSelected"
        Me.ButtonMediumSelected.Size = New System.Drawing.Size(441, 115)
        Me.ButtonMediumSelected.TabIndex = 4
        Me.ButtonMediumSelected.TabStop = False
        Me.ButtonMediumSelected.Visible = False
        '
        'ButtonHardSelected
        '
        Me.ButtonHardSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHardSelected.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsButton_Hard_Clicked
        Me.ButtonHardSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHardSelected.Location = New System.Drawing.Point(720, 447)
        Me.ButtonHardSelected.Name = "ButtonHardSelected"
        Me.ButtonHardSelected.Size = New System.Drawing.Size(441, 115)
        Me.ButtonHardSelected.TabIndex = 5
        Me.ButtonHardSelected.TabStop = False
        Me.ButtonHardSelected.Visible = False
        '
        'ButtonExitSelected
        '
        Me.ButtonExitSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExitSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExitSelected.Image = CType(resources.GetObject("ButtonExitSelected.Image"), System.Drawing.Image)
        Me.ButtonExitSelected.Location = New System.Drawing.Point(1271, 650)
        Me.ButtonExitSelected.Name = "ButtonExitSelected"
        Me.ButtonExitSelected.Size = New System.Drawing.Size(111, 112)
        Me.ButtonExitSelected.TabIndex = 6
        Me.ButtonExitSelected.TabStop = False
        Me.ButtonExitSelected.Visible = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
        Me.ButtonExit.Location = New System.Drawing.Point(1271, 650)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(111, 112)
        Me.ButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonExit.TabIndex = 7
        Me.ButtonExit.TabStop = False
        '
        'AfbeeldingenPad
        '
        Me.AfbeeldingenPad.Location = New System.Drawing.Point(855, 2)
        Me.AfbeeldingenPad.Name = "AfbeeldingenPad"
        Me.AfbeeldingenPad.Size = New System.Drawing.Size(527, 20)
        Me.AfbeeldingenPad.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Username, Me.Score})
        Me.DataGridView1.DataSource = Me.HighscoresDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'Score
        '
        Me.Score.HeaderText = "Score"
        Me.Score.Name = "Score"
        Me.Score.ReadOnly = True
        '
        'HighscoresDataSetBindingSource
        '
        Me.HighscoresDataSetBindingSource.DataSource = Me.HighscoresDataSet
        Me.HighscoresDataSetBindingSource.Position = 0
        '
        'HighscoresDataSet
        '
        Me.HighscoresDataSet.DataSetName = "HighscoresDataSet"
        Me.HighscoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StartScherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.TheLeprechaunsStartScherm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1384, 800)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AfbeeldingenPad)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonExitSelected)
        Me.Controls.Add(Me.ButtonHard)
        Me.Controls.Add(Me.ButtonHardSelected)
        Me.Controls.Add(Me.ButtonEasy)
        Me.Controls.Add(Me.ButtonEasySelected)
        Me.Controls.Add(Me.ButtonMedium)
        Me.Controls.Add(Me.ButtonMediumSelected)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartScherm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.ButtonEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEasySelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMediumSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonHardSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonExitSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoresDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEasy As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonMedium As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonHard As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonEasySelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonMediumSelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonHardSelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonExitSelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonExit As System.Windows.Forms.PictureBox
    Friend WithEvents AfbeeldingenPad As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Score As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HighscoresDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HighscoresDataSet As MemoryGameLeprechauns.HighscoresDataSet
End Class
