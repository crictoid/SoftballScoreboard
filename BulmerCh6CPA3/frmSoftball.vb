' Program Name:     Softball Scoreboard
' Author:           Mark Bulmer
' Date:             3/27/2022
' Purpose:          The Softball Scoreboard program enters the score
'                   from each inning in a softball game. It displays each
'                   inning's runs. After all innings have been entered, 
'                   it displays the total score for the game.

Option Strict On
Public Class frmSoftball
    Private Sub btnSoftball_Click(sender As Object, e As EventArgs) Handles btnSoftball.Click
        ' The btnSoftball_click event accepts and displays up to 7 score values
        ' and then calculates and displays the total score for the game

        ' Declare and initialize variables
        Dim strSoftball As String
        Dim decSoftball As Decimal
        Dim decAverageSoftball As Decimal
        Dim decTotalSoftball As Decimal = 0D
        Dim strInputMessage As String = "Enter the score for inning #"
        Dim strInputHeading As String = "Softball Score"
        Dim strNormalMessage As String = "Enter the score for inning #"
        Dim strNonNumericError As String = "Error - Enter a number for the score of inning #"
        Dim strNegativeError As String = "Error - Enter a positive number for the score of inning #"

        ' Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 7
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the runs for up to 7 innings.
        ' The loop terminates when the user has entered 7 scoreboard values or the user
        ' clicks the Cancel button or the Close button in the InputBox
        strSoftball = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strSoftball = strCancelClicked
            If IsNumeric(strSoftball) Then
                decSoftball = Convert.ToDecimal(strSoftball)
                If decSoftball > 0 Then
                    lstSoftball.Items.Add(decSoftball)
                    decTotalSoftball += decSoftball
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strSoftball = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Calculates and displays average inning runs
        If intNumberOfEntries > 1 Then
            lblFinalScore.Visible = True
            decAverageSoftball = decTotalSoftball / (intNumberOfEntries - 1)
            lblFinalScore.Text = "The final score is " &
                decTotalSoftball.ToString("F1") & " runs"
        Else
            MsgBox("No score entered")
        End If

        ' Disables the Softball button
        btnSoftball.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears the ListBox object and hides 
        ' the softball score label. It also enables the Softball button

        lstSoftball.Items.Clear()
        lblFinalScore.Visible = False
        btnSoftball.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application

        Close()
    End Sub
End Class
