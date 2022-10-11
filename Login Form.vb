Public Class Login_Form
    'PROJECT 1 DFP40223 Visual Basic Programming

    'Name : MUAZZAM SHAH BIN HASAN
    'NO MATRIK : 20DDT19F1802
    'Name : JUSTINE NANGGAI
    'NO MATRIK : 20DDT20F1010
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ' if user do not check the checkbox the system will display the messagges box 
        If cbxagreement.Checked = False Then
            MessageBox.Show("Hi! You forgot to tick the condition and term. Thank you", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.Close()
        End If
        'if user do not enter the password and username the the system will display the message box

        If txtpswd.Text = "" And txtusername.Text = "" Then
            MessageBox.Show("Incomplete !Please Complete the form", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ' if user login as User, The user only can view the statistic covid 19 case only !!
        ElseIf txtpswd.Text = "user" And txtusername.Text = "user" Then
            MessageBox.Show("You Log In As User ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information)
            View_statistics_of_current_cases.Show()
            Form1.Hide()
        Else
            MessageBox.Show("Good Job ! Form Complete ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        'Clear the texbox
        txtpswd.Clear()
        txtusername.Clear()
    End Sub
End Class