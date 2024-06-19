<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Me.txtViewGitHubRepo = New System.Windows.Forms.TextBox()
        Me.txtViewPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtViewEmail = New System.Windows.Forms.TextBox()
        Me.txtViewName = New System.Windows.Forms.TextBox()
        Me.txtGitHubRepo = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtViewSubmissionTime = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtViewGitHubRepo
        '
        Me.txtViewGitHubRepo.Location = New System.Drawing.Point(357, 257)
        Me.txtViewGitHubRepo.Name = "txtViewGitHubRepo"
        Me.txtViewGitHubRepo.ReadOnly = True
        Me.txtViewGitHubRepo.Size = New System.Drawing.Size(275, 26)
        Me.txtViewGitHubRepo.TabIndex = 15
        '
        'txtViewPhoneNumber
        '
        Me.txtViewPhoneNumber.Location = New System.Drawing.Point(357, 204)
        Me.txtViewPhoneNumber.Name = "txtViewPhoneNumber"
        Me.txtViewPhoneNumber.ReadOnly = True
        Me.txtViewPhoneNumber.Size = New System.Drawing.Size(275, 26)
        Me.txtViewPhoneNumber.TabIndex = 14
        '
        'txtViewEmail
        '
        Me.txtViewEmail.Location = New System.Drawing.Point(357, 148)
        Me.txtViewEmail.Name = "txtViewEmail"
        Me.txtViewEmail.ReadOnly = True
        Me.txtViewEmail.Size = New System.Drawing.Size(275, 26)
        Me.txtViewEmail.TabIndex = 13
        '
        'txtViewName
        '
        Me.txtViewName.Location = New System.Drawing.Point(357, 97)
        Me.txtViewName.Name = "txtViewName"
        Me.txtViewName.ReadOnly = True
        Me.txtViewName.Size = New System.Drawing.Size(275, 26)
        Me.txtViewName.TabIndex = 12
        '
        'txtGitHubRepo
        '
        Me.txtGitHubRepo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtGitHubRepo.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGitHubRepo.Location = New System.Drawing.Point(162, 257)
        Me.txtGitHubRepo.Multiline = True
        Me.txtGitHubRepo.Name = "txtGitHubRepo"
        Me.txtGitHubRepo.Size = New System.Drawing.Size(155, 28)
        Me.txtGitHubRepo.TabIndex = 11
        Me.txtGitHubRepo.Text = "GitHub Repo Link"
        Me.txtGitHubRepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(162, 202)
        Me.txtPhoneNumber.Multiline = True
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(155, 28)
        Me.txtPhoneNumber.TabIndex = 10
        Me.txtPhoneNumber.Text = "Phone Number"
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(162, 146)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(155, 28)
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.Text = "Email"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtName.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(162, 97)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 28)
        Me.txtName.TabIndex = 8
        Me.txtName.Text = "Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtViewSubmissionTime
        '
        Me.txtViewSubmissionTime.Location = New System.Drawing.Point(357, 314)
        Me.txtViewSubmissionTime.Name = "txtViewSubmissionTime"
        Me.txtViewSubmissionTime.ReadOnly = True
        Me.txtViewSubmissionTime.Size = New System.Drawing.Size(275, 26)
        Me.txtViewSubmissionTime.TabIndex = 17
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox10.Font = New System.Drawing.Font("Lucida Bright", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(162, 314)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(155, 28)
        Me.TextBox10.TabIndex = 16
        Me.TextBox10.Text = "Submission Time"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Info
        Me.btnNext.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnNext.Location = New System.Drawing.Point(523, 379)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(160, 42)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.Info
        Me.btnPrevious.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnPrevious.Location = New System.Drawing.Point(61, 379)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(160, 42)
        Me.btnPrevious.TabIndex = 19
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtViewSubmissionTime)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.txtViewGitHubRepo)
        Me.Controls.Add(Me.txtViewPhoneNumber)
        Me.Controls.Add(Me.txtViewEmail)
        Me.Controls.Add(Me.txtViewName)
        Me.Controls.Add(Me.txtGitHubRepo)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtViewGitHubRepo As TextBox
    Friend WithEvents txtViewPhoneNumber As TextBox
    Friend WithEvents txtViewEmail As TextBox
    Friend WithEvents txtViewName As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtViewSubmissionTime As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
