<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpswd = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.cbxagreement = New System.Windows.Forms.CheckBox()
        Me.btnreset = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 462)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username       :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password        :"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(160, 147)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(220, 26)
        Me.txtusername.TabIndex = 4
        '
        'txtpswd
        '
        Me.txtpswd.Location = New System.Drawing.Point(160, 219)
        Me.txtpswd.Multiline = True
        Me.txtpswd.Name = "txtpswd"
        Me.txtpswd.Size = New System.Drawing.Size(220, 28)
        Me.txtpswd.TabIndex = 5
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Chartreuse
        Me.btnsubmit.Location = New System.Drawing.Point(160, 341)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(220, 38)
        Me.btnsubmit.TabIndex = 6
        Me.btnsubmit.Text = "OK"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'cbxagreement
        '
        Me.cbxagreement.AutoSize = True
        Me.cbxagreement.BackColor = System.Drawing.Color.Lavender
        Me.cbxagreement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxagreement.Location = New System.Drawing.Point(160, 296)
        Me.cbxagreement.Name = "cbxagreement"
        Me.cbxagreement.Size = New System.Drawing.Size(221, 19)
        Me.cbxagreement.TabIndex = 7
        Me.cbxagreement.Text = "I am agree with Condition and Term"
        Me.cbxagreement.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Yellow
        Me.btnreset.Location = New System.Drawing.Point(160, 385)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(220, 38)
        Me.btnreset.TabIndex = 8
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(764, 456)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.cbxagreement)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtpswd)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_Form"
        Me.Text = "Login_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpswd As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents cbxagreement As CheckBox
    Friend WithEvents btnreset As Button
End Class
