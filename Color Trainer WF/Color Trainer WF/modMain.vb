Public Module modMain
    Dim squareMax, numWin, xTableRowCount As Int32
    Dim squareWinner, modeDifficulty As String
    Dim uiPnlPlay As Control = frmColorTrainer.pnlPlay
    Dim uiPnlSet As Control = frmColorTrainer.pnlSet
    Public rngRoll As Random = New Random


    '-----------------------------------------------------------
    '
    ' The main sub.  All the subs needed to set the board in one place
    '
    '-----------------------------------------------------------

    Public Sub colorTrain()
        Try
            trainInit()
            setWinner()
            setDifficulty()
            buildBoard()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    '-----------------------------------------------------------
    '
    ' Set variables and controls to initial / clean state:
    '
    '-----------------------------------------------------------
    Private Sub trainInit()
        squareMax = 0
        numWin = 0
        squareWinner = ""
        clearButtons(uiPnlPlay)

        With frmColorTrainer
            .pnlPlay.BackColor = Color.FromArgb(255, rgbUi, rgbUi, rgbUi)

            .pnlSet.Visible = False

            .lblPrevious.SendToBack()

            .lblCongrats.Visible = False

            .lblRetry.Visible = False

            .lblFindValue.Text = "Choose the right color for " & frmColorTrainer.cboSetType.Text & " value"
            .lblFindValue.Visible = True
        End With
    End Sub


    '-----------------------------------------------------------
    '
    ' Pick which "square" will be the winner
    '
    '-----------------------------------------------------------
    Private Sub setWinner()
        numWin = rngGen(1, squareMax + 1)
        squareWinner = "btnColorBox" & numWin
    End Sub

    '-----------------------------------------------------------
    '
    ' Set paramaters to be used based on which difficulty is selected
    ' - NOTE:  parameters are used in sub buildBoard()
    '
    '-----------------------------------------------------------
    Private Sub setDifficulty()
        modeDifficulty = frmColorTrainer.cboSetDifficulty.Text

        If modeDifficulty = "Easy" Then
            squareMax = 3
            xTableRowCount = 1
        ElseIf modeDifficulty = "Medium" Then
            squareMax = 6
            xTableRowCount = 2
        Else
            squareMax = 9
            xTableRowCount = 3
        End If
    End Sub


    '-----------------------------------------------------------
    '
    ' Populate the board:
    '   - NOTE:  Difficulty parameters previously set in sub setDifficulty()
    '   - Create a Table Layout Panel (number of rows based on difficulty).
    '   - Create buttons to act as each square (button count based on difficulty).
    '
    '-----------------------------------------------------------

    Private Sub buildBoard()

        Dim iteration As Int32
        Dim xTableRow, xTableCol, xTableColCount As Int32
        Dim xTable As New TableLayoutPanel()

        'There are always 3 columns
        xTableColCount = 3

        '
        With xTable
            .Name = "xTable"
            .Width = uiPnlPlay.Width
            .Height = uiPnlPlay.Height
            .Top = 0
            .Left = 0
            .Dock = DockStyle.Fill

            .ColumnCount = xTableColCount
            .RowCount = xTableRowCount

            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        End With

        Select Case xTableRowCount
            Case 1
                xTable.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            Case 2
                xTable.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
                xTable.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
            Case 3
                xTable.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
                xTable.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
                xTable.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        End Select

        uiPnlPlay.Controls.Add(xTable)

        For iteration = 1 To squareMax
            Dim rVal, gVal, bVal As Int32

            'Pick the color
            rVal = rngGen(0, 256)
            gVal = rngGen(0, 256)
            bVal = rngGen(0, 256)

            'Winning square is based on which square number.  Make sure to set the more larger scope r, g, and b variable as well as any labels.
            If iteration = numWin Then
                rgbColorR = rVal
                rgbColorG = gVal
                rgbColorB = bVal

                If frmColorTrainer.cboSetType.Text = "RGB" Then
                    frmColorTrainer.lblColor.Text = rgbColorR & ", " & rgbColorG & ", " & rgbColorB
                Else
                    frmColorTrainer.lblColor.Text = convertToHex(rgbColorR) & " " & convertToHex(rgbColorG) & " " & convertToHex(rgbColorB)
                End If

            End If

            'Assign columns for each button
            Select Case iteration
                Case 1, 4, 7
                    xTableCol = 0
                Case 2, 5, 8
                    xTableCol = 1
                Case 3, 6, 9
                    xTableCol = 2
            End Select

            'Assign rows for each button
            Select Case iteration
                Case 1 To 3
                    xTableRow = 0
                Case 4 To 6
                    xTableRow = 1
                Case 7 To 9
                    xTableRow = 2
            End Select

            'Create each button
            Dim xButton As New Button

            AddHandler xButton.Click, AddressOf checkSquare
            AddHandler xButton.MouseEnter, AddressOf xButtonHoverOn
            AddHandler xButton.MouseLeave, AddressOf xButtonHoverOff

            With xButton
                .Name = "btnColorBox" & iteration
                .Text = ""
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(255, rVal, gVal, bVal)
                .FlatAppearance.BorderSize = 15
                .FlatAppearance.BorderColor = Color.FromArgb(255, rgbUi, rgbUi, rgbUi)
                .FlatStyle = FlatStyle.Flat
                .Visible = True
                .BackColor = Color.FromArgb(255, rVal, gVal, bVal)
                .Dock = DockStyle.Fill
            End With

            'Place the button in the correct layout panel cell
            xTable.Controls.Add(xButton, xTableCol, xTableRow)
        Next
    End Sub

    '-----------------------------------------------------------
    '
    ' subs for dynamic button behavior
    '
    '-----------------------------------------------------------

    Private Sub checkSquare(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If sender.Name = squareWinner Then
                winHandle()
            Else
                frmColorTrainer.pnlPlay.Controls.Remove(sender)
                sender.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub xButtonHoverOn(ByVal sender As Object, ByVal e As EventArgs)
        Try
            sender.FlatAppearance.BorderSize = 5
            sender.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255, 255)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub xButtonHoverOff(ByVal sender As Object, ByVal e As EventArgs)
        Try
            sender.FlatAppearance.BorderSize = 15
            sender.FlatAppearance.BorderColor = Color.FromArgb(255, rgbUi, rgbUi, rgbUi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '-----------------------------------------------------------
    '
    ' When a winner is found...
    '
    '-----------------------------------------------------------

    Private Sub winHandle()
        Try
            Dim rgbYiq As Int32
            rgbYiq = rgbContrast(rgbColorR, rgbColorG, rgbColorB)

            With frmColorTrainer

                .pnlPlay.BackColor = Color.FromArgb(255, rgbColorR, rgbColorG, rgbColorB)
                .pnlPlay.BackColor = Color.FromArgb(255, rgbColorR, rgbColorG, rgbColorB)

                .pnlSet.BackColor = Color.FromArgb(255, rgbColorR, rgbColorG, rgbColorB)
                .pnlSet.Visible = True

                .lblPrevious.Text = frmColorTrainer.lblColor.Text
                .lblPrevious.BackColor = Color.FromArgb(255, rgbColorR, rgbColorG, rgbColorB)
                .lblPrevious.ForeColor = Color.FromArgb(255, rgbYiq, rgbYiq, rgbYiq)
                .lblPrevious.Visible = True
                .lblPrevious.BringToFront()


                .lblCongrats.Text = "You found the right color for " & frmColorTrainer.cboSetType.Text & " value"
                .lblCongrats.ForeColor = Color.FromArgb(255, rgbColorR, rgbColorG, rgbColorB)
                .lblCongrats.BackColor = Color.FromArgb(255, rgbYiq, rgbYiq, rgbYiq)
                .lblCongrats.BringToFront()
                .lblCongrats.Visible = True

                .lblRetry.Text = "Well done!  Why not give it another go?"
                .lblRetry.ForeColor = Color.FromArgb(255, rgbColorR, rgbColorG, rgbColorB)
                .lblRetry.BackColor = Color.FromArgb(255, rgbYiq, rgbYiq, rgbYiq)
                .lblRetry.BringToFront()
                .lblRetry.Visible = True


                .lblFormat.ForeColor = Color.FromArgb(255, rgbYiq, rgbYiq, rgbYiq)
                .lblDifficulty.ForeColor = Color.FromArgb(255, rgbYiq, rgbYiq, rgbYiq)

                .lblFindValue.Visible = False
            End With

            clearButtons(uiPnlPlay)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '-----------------------------------------------------------
    '
    ' Supporting subs and functions
    '
    '-----------------------------------------------------------

    Private Function rngGen(ByVal rngMin As Int32, ByVal rngMax As Int32)
        Return rngRoll.Next(rngMin, rngMax)
    End Function

    Private Sub clearButtons(ByVal uiPnlPlay As Control)
        uiPnlPlay.Controls.Clear()
    End Sub


    Private Function convertToHex(ByVal rgbValue As Integer) As String
        Dim hexValue As String
        If rgbValue < 10 Then
            hexValue = "0" & Hex(rgbValue)
        Else
            hexValue = Hex(rgbValue)
        End If

        Return hexValue
    End Function

End Module

