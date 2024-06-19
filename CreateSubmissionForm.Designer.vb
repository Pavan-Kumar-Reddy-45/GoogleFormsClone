<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubRepo = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblStopWatch = New System.Windows.Forms.Label()
        Me.btnStartPauseStopwatch = New System.Windows.Forms.TextBox()
        Me.timerStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtName.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(159, 92)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 28)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(159, 141)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(155, 28)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.Text = "Email"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(159, 197)
        Me.txtPhoneNumber.Multiline = True
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(155, 28)
        Me.txtPhoneNumber.TabIndex = 2
        Me.txtPhoneNumber.Text = "Phone Number"
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGitHubRepo
        '
        Me.txtGitHubRepo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtGitHubRepo.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGitHubRepo.Location = New System.Drawing.Point(159, 252)
        Me.txtGitHubRepo.Multiline = True
        Me.txtGitHubRepo.Name = "txtGitHubRepo"
        Me.txtGitHubRepo.Size = New System.Drawing.Size(155, 28)
        Me.txtGitHubRepo.TabIndex = 3
        Me.txtGitHubRepo.Text = "GitHub Repo Link"
        Me.txtGitHubRepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(354, 92)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(275, 26)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(354, 143)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(275, 26)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(354, 199)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(275, 26)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(354, 252)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(275, 26)
        Me.TextBox8.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Info
        Me.btnSubmit.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnSubmit.Location = New System.Drawing.Point(296, 373)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 42)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblStopWatch
        '
        Me.lblStopWatch.AutoSize = True
        Me.lblStopWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopWatch.Location = New System.Drawing.Point(350, 331)
        Me.lblStopWatch.Name = "lblStopWatch"
        Me.lblStopWatch.Size = New System.Drawing.Size(79, 20)
        Me.lblStopWatch.TabIndex = 9
        Me.lblStopWatch.Text = "00:00:00"
        '
        'btnStartPauseStopwatch
        '
        Me.btnStartPauseStopwatch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStartPauseStopwatch.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartPauseStopwatch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnStartPauseStopwatch.Location = New System.Drawing.Point(526, 327)
        Me.btnStartPauseStopwatch.Multiline = True
        Me.btnStartPauseStopwatch.Name = "btnStartPauseStopwatch"
        Me.btnStartPauseStopwatch.Size = New System.Drawing.Size(226, 28)
        Me.btnStartPauseStopwatch.TabIndex = 10
        Me.btnStartPauseStopwatch.Text = "Start/Pause Stopwatch"
        Me.btnStartPauseStopwatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timerStopwatch
        '
        Me.timerStopwatch.Enabled = True
        Me.timerStopwatch.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(159, 327)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 28)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Stop Watch"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnStartPauseStopwatch)
        Me.Controls.Add(Me.lblStopWatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.txtGitHubRepo)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.KeyPreview = True
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopWatch As Label
    Friend WithEvents btnStartPauseStopwatch As TextBox
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
