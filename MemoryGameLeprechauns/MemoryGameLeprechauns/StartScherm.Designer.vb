﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ButtonEasy = New System.Windows.Forms.PictureBox()
        Me.ButtonMedium = New System.Windows.Forms.PictureBox()
        Me.ButtonHard = New System.Windows.Forms.PictureBox()
        Me.ButtonEasySelected = New System.Windows.Forms.PictureBox()
        Me.ButtonMediumSelected = New System.Windows.Forms.PictureBox()
        Me.ButtonHardSelected = New System.Windows.Forms.PictureBox()
        CType(Me.ButtonEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEasySelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMediumSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonHardSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEasy
        '
        Me.ButtonEasy.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEasy.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.ButtonMemoryGameEasy
        Me.ButtonEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEasy.Location = New System.Drawing.Point(471, 30)
        Me.ButtonEasy.Name = "ButtonEasy"
        Me.ButtonEasy.Size = New System.Drawing.Size(470, 187)
        Me.ButtonEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ButtonEasy.TabIndex = 0
        Me.ButtonEasy.TabStop = False
        '
        'ButtonMedium
        '
        Me.ButtonMedium.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMedium.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.ButtonMemoryGameMedium
        Me.ButtonMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMedium.Location = New System.Drawing.Point(471, 211)
        Me.ButtonMedium.Name = "ButtonMedium"
        Me.ButtonMedium.Size = New System.Drawing.Size(470, 187)
        Me.ButtonMedium.TabIndex = 1
        Me.ButtonMedium.TabStop = False
        '
        'ButtonHard
        '
        Me.ButtonHard.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHard.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.ButtonMemoryGameHard
        Me.ButtonHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHard.Location = New System.Drawing.Point(471, 391)
        Me.ButtonHard.Name = "ButtonHard"
        Me.ButtonHard.Size = New System.Drawing.Size(470, 187)
        Me.ButtonHard.TabIndex = 2
        Me.ButtonHard.TabStop = False
        '
        'ButtonEasySelected
        '
        Me.ButtonEasySelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEasySelected.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.ButtonMemoryGameEasySelected
        Me.ButtonEasySelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEasySelected.Location = New System.Drawing.Point(471, 30)
        Me.ButtonEasySelected.Name = "ButtonEasySelected"
        Me.ButtonEasySelected.Size = New System.Drawing.Size(470, 187)
        Me.ButtonEasySelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ButtonEasySelected.TabIndex = 3
        Me.ButtonEasySelected.TabStop = False
        Me.ButtonEasySelected.Visible = False
        '
        'ButtonMediumSelected
        '
        Me.ButtonMediumSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMediumSelected.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.ButtonMemoryGameMediumSelected
        Me.ButtonMediumSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMediumSelected.Location = New System.Drawing.Point(471, 211)
        Me.ButtonMediumSelected.Name = "ButtonMediumSelected"
        Me.ButtonMediumSelected.Size = New System.Drawing.Size(470, 187)
        Me.ButtonMediumSelected.TabIndex = 4
        Me.ButtonMediumSelected.TabStop = False
        Me.ButtonMediumSelected.Visible = False
        '
        'ButtonHardSelected
        '
        Me.ButtonHardSelected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHardSelected.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.ButtonMemoryGameHardSelected
        Me.ButtonHardSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHardSelected.Location = New System.Drawing.Point(471, 391)
        Me.ButtonHardSelected.Name = "ButtonHardSelected"
        Me.ButtonHardSelected.Size = New System.Drawing.Size(470, 187)
        Me.ButtonHardSelected.TabIndex = 5
        Me.ButtonHardSelected.TabStop = False
        Me.ButtonHardSelected.Visible = False
        '
        'MemoryGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.MemoryGameLeprechauns.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1384, 800)
        Me.Controls.Add(Me.ButtonHardSelected)
        Me.Controls.Add(Me.ButtonMediumSelected)
        Me.Controls.Add(Me.ButtonEasySelected)
        Me.Controls.Add(Me.ButtonHard)
        Me.Controls.Add(Me.ButtonMedium)
        Me.Controls.Add(Me.ButtonEasy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemoryGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.ButtonEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEasySelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMediumSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonHardSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEasy As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonMedium As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonHard As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonEasySelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonMediumSelected As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonHardSelected As System.Windows.Forms.PictureBox
End Class
