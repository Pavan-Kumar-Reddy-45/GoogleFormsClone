Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero

    ' Event handler for the Submit button click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newSubmission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGitHubRepo.Text,
            .SubmissionTime = elapsedTime
        }

        ' Add the new submission to the shared list
        SubmissionManager.Submissions.Add(newSubmission)

        ' Optionally, clear the form fields after submission
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtGitHubRepo.Clear()
        elapsedTime = TimeSpan.Zero
        lblStopWatch.Text = "00:00:00"
        timerStopwatch.Stop()
        stopwatchRunning = False
    End Sub

    ' Event handler for the Start/Pause button click
    Private Sub btnStartPauseStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartPauseStopwatch.Click
        If stopwatchRunning Then
            timerStopwatch.Stop()
            stopwatchRunning = False
        Else
            timerStopwatch.Start()
            stopwatchRunning = True
        End If
    End Sub

    ' Event handler for the Timer tick
    Private Sub timerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        lblStopWatch.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    ' Override ProcessCmdKey to handle Ctrl+S shortcut
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
