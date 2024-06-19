Public Class ViewSubmissionsForm
    Private currentIndex As Integer

    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.currentIndex = 0

        ' Display the first submission if any
        If SubmissionManager.Submissions.Count > 0 Then
            DisplaySubmission(0)
        End If
    End Sub

    ' Display submission at a specific index
    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < SubmissionManager.Submissions.Count Then
            txtName.Text = SubmissionManager.Submissions(index).Name
            txtEmail.Text = SubmissionManager.Submissions(index).Email
            txtPhoneNumber.Text = SubmissionManager.Submissions(index).PhoneNumber
            txtGitHubRepo.Text = SubmissionManager.Submissions(index).GitHubLink
        End If
    End Sub

    ' Handle Next button click
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < SubmissionManager.Submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    ' Handle Previous button click
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
