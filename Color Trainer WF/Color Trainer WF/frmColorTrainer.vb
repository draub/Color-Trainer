Public Class frmColorTrainer
    Private Sub CmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        colorTrain()
    End Sub

    Private Sub FrmColorTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLayout()
        pnlPlay.Visible = True
        pnlSet.Visible = True
        lblPrevious.Visible = False
        lblCongrats.Visible = False
        lblRetry.Visible = False
        lblFindValue.Visible = False


    End Sub

    Private Sub frmColorTrainer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        formLayout()
    End Sub

    Private Sub formLayout()
        pnlPlay.Height = Me.Height - 148
        pnlPlay.Width = Me.Width - 15
        pnlPlay.Top = 110
        pnlPlay.Left = 0

        pnlSet.Height = 110
        pnlSet.Width = Me.Width - 15
        pnlSet.Top = 0
        pnlSet.Left = 0

        cboSetType.Top = (pnlSet.Height / 2) - (cboSetType.Height / 2)
        cboSetType.Left = (Me.Width / 5) - (cboSetType.Width / 2)
        lblFormat.Left = cboSetType.Left - 5
        lblFormat.Top = cboSetType.Top - lblFormat.Height

        cboSetDifficulty.Top = cboSetType.Top
        cboSetDifficulty.Left = (Me.Width / 2) - (cboSetType.Width / 2)
        lblDifficulty.Left = cboSetDifficulty.Left - 5
        lblDifficulty.Top = cboSetDifficulty.Top - lblDifficulty.Height


        cmdPlay.Height = cboSetType.Height
        cmdPlay.Top = cboSetType.Top
        cmdPlay.Left = ((Me.Width / 5) * 4) - (cmdPlay.Width / 2)

        lblColor.Left = (Me.Width / 2) - (lblColor.Width / 2)
        lblColor.Top = cboSetType.Top

        lblFindValue.Left = lblColor.Left
        lblFindValue.Top = lblColor.Top - lblFindValue.Height

        lblPrevious.Left = (Me.Width / 2) - (lblPrevious.Width / 2)
        lblPrevious.Top = (Me.Height / 2) - (lblPrevious.Height / 2)

        lblCongrats.Top = lblPrevious.Top - lblCongrats.Height
        lblCongrats.Left = lblPrevious.Left

        lblRetry.Top = lblPrevious.Top + lblPrevious.Height + 10
        lblRetry.Left = lblPrevious.Left
    End Sub


End Class
