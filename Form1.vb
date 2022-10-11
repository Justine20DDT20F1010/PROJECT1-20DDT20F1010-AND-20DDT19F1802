Public Class Form1
    'NAME : MUAZZAM SHAH BIN HASAN
    'NO MATRIK : 20DDT19F1802

    'NAME : JUSTINE NANGGAI
    'NO MATRIK : 20DDT19F1010

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        ' Save File
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        ' Open File
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        'Messagebox dislay when user click insert button
        MessageBox.Show("Call : 01116064361 OR Email: CovidVaccineVolunteer@gmail.com", "Help Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Call back about form by using .Show
        About.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' The form will close
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim place, name, age, gender, bloodtype, address As String
        Dim details, messages, display As String

        place = InputBox("What country do you live in?", "District of Residence", "Malaysia")

        If cbxLOH.SelectedIndex = 0 Then
            MessageBox.Show("Congratulations! you can be a volunteer", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' user input volunteer detail
            gender = InputBox("Male or Female?", "Volunteer Detail ")
            name = InputBox("What your name ?", "Volunteer Detail ")
            age = InputBox("How old are you ?", "Volunteer Detail ")
            bloodtype = InputBox("Blood Type
        A+, B+, AB+
        A-, B-, AB-
        0+, 0-  ", "Volunteer Detail ")
            address = InputBox(" Volunteer Address :", "Volunteer Detail ")
        Else
            MessageBox.Show("Oops! you are not eligible to be a volunteer for the time being", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            'if the user is not eligible being the volunteer the form will close
            Me.Close()
        End If

        'if the user meets the requirements, become a volunteer
        If cbxTypesOfVaccine.SelectedIndex = 0 Then
            details = "Your Detail About Vaccine
            Name : Pfizer-BioTech
            Type: mRNA
            Dose: 2
            Country :  " + place + "
            Efficacy: 95%"
        ElseIf cbxTypesOfVaccine.SelectedIndex = 1 Then
            details = "Your Detail About Vaccine

            Name : AstraZeneca      
            Type: Viral vector
            Country :  " + place + "
            Dose: 2
            Efficacy: 70%"
        Else
            details = "Your Detail About Vaccine

            Name : Sinovac
            Type: Whole virus (Inactivated SARS-CoV-2 virus)
            Country :  " + place + "            
            Dose: 2
            Efficacy: 50,65% - 91,25%"
        End If




        display = InputBox(details, "Messagges", "Type OK")

        messages = "Thank you for your cooperation, have a good day"
        MessageBox.Show(messages, "Thank You")



        ' Display to the Display Volunteer DAetail
        lblname.Text = "Name : " + name
        lblage.Text = "Age : " + age
        lblgender.Text = "Gender  : " + gender
        lblbloodtype.Text = "BloodType : " + bloodtype
        lbladdress.Text = "Address : " + address
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
