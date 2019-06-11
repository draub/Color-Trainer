<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmColorTrainer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColorTrainer))
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.pnlPlay = New System.Windows.Forms.Panel()
        Me.picText = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboSetDifficulty = New System.Windows.Forms.ComboBox()
        Me.cboSetType = New System.Windows.Forms.ComboBox()
        Me.pnlSet = New System.Windows.Forms.Panel()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.lblCongrats = New System.Windows.Forms.Label()
        Me.lblRetry = New System.Windows.Forms.Label()
        Me.lblFindValue = New System.Windows.Forms.Label()
        Me.pnlPlay.SuspendLayout()
        CType(Me.picText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSet.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPlay
        '
        Me.cmdPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdPlay.BackColor = System.Drawing.Color.White
        Me.cmdPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPlay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmdPlay.Location = New System.Drawing.Point(846, 26)
        Me.cmdPlay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(150, 46)
        Me.cmdPlay.TabIndex = 2
        Me.cmdPlay.Text = "Train"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.Color.Transparent
        Me.lblColor.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(676, 79)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(431, 81)
        Me.lblColor.TabIndex = 16
        Me.lblColor.Text = "000, 000, 000"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPlay
        '
        Me.pnlPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.pnlPlay.Controls.Add(Me.picText)
        Me.pnlPlay.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlPlay.ForeColor = System.Drawing.Color.Black
        Me.pnlPlay.Location = New System.Drawing.Point(2, 321)
        Me.pnlPlay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlPlay.Name = "pnlPlay"
        Me.pnlPlay.Size = New System.Drawing.Size(1142, 555)
        Me.pnlPlay.TabIndex = 22
        '
        'picText
        '
        Me.picText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picText.Image = CType(resources.GetObject("picText.Image"), System.Drawing.Image)
        Me.picText.Location = New System.Drawing.Point(0, 0)
        Me.picText.Name = "picText"
        Me.picText.Size = New System.Drawing.Size(1142, 555)
        Me.picText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picText.TabIndex = 0
        Me.picText.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(534, 279)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(637, 376)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cboSetDifficulty
        '
        Me.cboSetDifficulty.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSetDifficulty.FormattingEnabled = True
        Me.cboSetDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cboSetDifficulty.Location = New System.Drawing.Point(467, 29)
        Me.cboSetDifficulty.Name = "cboSetDifficulty"
        Me.cboSetDifficulty.Size = New System.Drawing.Size(150, 46)
        Me.cboSetDifficulty.TabIndex = 29
        Me.cboSetDifficulty.Text = "Easy"
        '
        'cboSetType
        '
        Me.cboSetType.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSetType.FormattingEnabled = True
        Me.cboSetType.Items.AddRange(New Object() {"RGB", "Hex"})
        Me.cboSetType.Location = New System.Drawing.Point(159, 29)
        Me.cboSetType.Name = "cboSetType"
        Me.cboSetType.Size = New System.Drawing.Size(150, 46)
        Me.cboSetType.TabIndex = 30
        Me.cboSetType.Text = "RGB"
        '
        'pnlSet
        '
        Me.pnlSet.Controls.Add(Me.cboSetType)
        Me.pnlSet.Controls.Add(Me.lblDifficulty)
        Me.pnlSet.Controls.Add(Me.lblFormat)
        Me.pnlSet.Controls.Add(Me.cmdPlay)
        Me.pnlSet.Controls.Add(Me.cboSetDifficulty)
        Me.pnlSet.Location = New System.Drawing.Point(2, -2)
        Me.pnlSet.Name = "pnlSet"
        Me.pnlSet.Size = New System.Drawing.Size(1151, 78)
        Me.pnlSet.TabIndex = 31
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.ForeColor = System.Drawing.Color.Gray
        Me.lblDifficulty.Location = New System.Drawing.Point(462, 0)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(99, 28)
        Me.lblDifficulty.TabIndex = 30
        Me.lblDifficulty.Text = "Difficulty: "
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormat.ForeColor = System.Drawing.Color.Gray
        Me.lblFormat.Location = New System.Drawing.Point(154, 4)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(79, 28)
        Me.lblFormat.TabIndex = 0
        Me.lblFormat.Text = "Format:"
        '
        'lblPrevious
        '
        Me.lblPrevious.AutoSize = True
        Me.lblPrevious.BackColor = System.Drawing.Color.Transparent
        Me.lblPrevious.Font = New System.Drawing.Font("Segoe UI Black", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevious.Location = New System.Drawing.Point(510, 160)
        Me.lblPrevious.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(597, 112)
        Me.lblPrevious.TabIndex = 33
        Me.lblPrevious.Text = "000, 000, 000"
        Me.lblPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCongrats
        '
        Me.lblCongrats.AutoSize = True
        Me.lblCongrats.BackColor = System.Drawing.Color.Transparent
        Me.lblCongrats.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongrats.Location = New System.Drawing.Point(12, 137)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.Size = New System.Drawing.Size(167, 38)
        Me.lblCongrats.TabIndex = 34
        Me.lblCongrats.Text = "lblCongrats"
        '
        'lblRetry
        '
        Me.lblRetry.AutoSize = True
        Me.lblRetry.BackColor = System.Drawing.Color.Transparent
        Me.lblRetry.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetry.Location = New System.Drawing.Point(12, 187)
        Me.lblRetry.Name = "lblRetry"
        Me.lblRetry.Size = New System.Drawing.Size(120, 38)
        Me.lblRetry.TabIndex = 35
        Me.lblRetry.Text = "lblRetry"
        '
        'lblFindValue
        '
        Me.lblFindValue.AutoSize = True
        Me.lblFindValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindValue.Location = New System.Drawing.Point(12, 94)
        Me.lblFindValue.Name = "lblFindValue"
        Me.lblFindValue.Size = New System.Drawing.Size(145, 32)
        Me.lblFindValue.TabIndex = 36
        Me.lblFindValue.Text = "lblFindValue"
        '
        'frmColorTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1120, 798)
        Me.Controls.Add(Me.lblFindValue)
        Me.Controls.Add(Me.lblRetry)
        Me.Controls.Add(Me.lblCongrats)
        Me.Controls.Add(Me.lblPrevious)
        Me.Controls.Add(Me.pnlSet)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.pnlPlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(800, 627)
        Me.Name = "frmColorTrainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Trainer"
        Me.pnlPlay.ResumeLayout(False)
        CType(Me.picText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSet.ResumeLayout(False)
        Me.pnlSet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPlay As Button
    Friend WithEvents lblColor As Label
    Friend WithEvents pnlPlay As Panel
    Friend WithEvents cboSetDifficulty As ComboBox
    Friend WithEvents cboSetType As ComboBox
    Friend WithEvents pnlSet As Panel
    Friend WithEvents lblPrevious As Label
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents lblFormat As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents picText As PictureBox
    Friend WithEvents lblCongrats As Label
    Friend WithEvents lblRetry As Label
    Friend WithEvents lblFindValue As Label
End Class
