<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateContainer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateContainer))
        Me.fd_save = New System.Windows.Forms.SaveFileDialog()
        Me.VisualStudioContainer1 = New PasswordManager.VisualStudioContainer()
        Me.VisualStudioButton1 = New PasswordManager.VisualStudioButton()
        Me.txt_repassword = New PasswordManager.VisualStudioNormalTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New PasswordManager.VisualStudioNormalTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New PasswordManager.VisualStudioNormalTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_close = New PasswordManager.VisualStudioButton()
        Me.VisualStudioContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fd_save
        '
        Me.fd_save.DefaultExt = "pwm"
        Me.fd_save.Filter = "PasswordManager Container (*pwm)|*.pwm"
        '
        'VisualStudioContainer1
        '
        Me.VisualStudioContainer1.AllowClose = False
        Me.VisualStudioContainer1.AllowMaximize = False
        Me.VisualStudioContainer1.AllowMinimize = True
        Me.VisualStudioContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_close)
        Me.VisualStudioContainer1.Controls.Add(Me.Label4)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioButton1)
        Me.VisualStudioContainer1.Controls.Add(Me.txt_repassword)
        Me.VisualStudioContainer1.Controls.Add(Me.Label3)
        Me.VisualStudioContainer1.Controls.Add(Me.txt_password)
        Me.VisualStudioContainer1.Controls.Add(Me.Label2)
        Me.VisualStudioContainer1.Controls.Add(Me.txt_name)
        Me.VisualStudioContainer1.Controls.Add(Me.Label1)
        Me.VisualStudioContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualStudioContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioContainer1.FontSize = 12
        Me.VisualStudioContainer1.Form = Nothing
        Me.VisualStudioContainer1.FormOrWhole = PasswordManager.VisualStudioContainer.__FormOrWhole.Form
        Me.VisualStudioContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.VisualStudioContainer1.IconStyle = PasswordManager.VisualStudioContainer.__IconStyle.FormIcon
        Me.VisualStudioContainer1.Location = New System.Drawing.Point(0, 0)
        Me.VisualStudioContainer1.Name = "VisualStudioContainer1"
        Me.VisualStudioContainer1.ShowIcon = True
        Me.VisualStudioContainer1.Size = New System.Drawing.Size(418, 244)
        Me.VisualStudioContainer1.TabIndex = 0
        Me.VisualStudioContainer1.Text = "Create Container"
        '
        'VisualStudioButton1
        '
        Me.VisualStudioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VisualStudioButton1.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.VisualStudioButton1.ImageChoice = Nothing
        Me.VisualStudioButton1.Location = New System.Drawing.Point(12, 200)
        Me.VisualStudioButton1.Name = "VisualStudioButton1"
        Me.VisualStudioButton1.ShowBorder = True
        Me.VisualStudioButton1.ShowImage = False
        Me.VisualStudioButton1.ShowText = True
        Me.VisualStudioButton1.Size = New System.Drawing.Size(393, 31)
        Me.VisualStudioButton1.TabIndex = 2
        Me.VisualStudioButton1.Text = "Create Container"
        Me.VisualStudioButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txt_repassword
        '
        Me.txt_repassword.BackColor = System.Drawing.Color.Transparent
        Me.txt_repassword.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txt_repassword.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txt_repassword.Location = New System.Drawing.Point(12, 164)
        Me.txt_repassword.MaxLength = 32767
        Me.txt_repassword.Multiline = False
        Me.txt_repassword.Name = "txt_repassword"
        Me.txt_repassword.ReadOnly = False
        Me.txt_repassword.Size = New System.Drawing.Size(394, 25)
        Me.txt_repassword.Style = PasswordManager.VisualStudioNormalTextBox.Styles.NotRounded
        Me.txt_repassword.TabIndex = 1
        Me.txt_repassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_repassword.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txt_repassword.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Repeat password :"
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Transparent
        Me.txt_password.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txt_password.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(12, 112)
        Me.txt_password.MaxLength = 32767
        Me.txt_password.Multiline = False
        Me.txt_password.Name = "txt_password"
        Me.txt_password.ReadOnly = False
        Me.txt_password.Size = New System.Drawing.Size(394, 25)
        Me.txt_password.Style = PasswordManager.VisualStudioNormalTextBox.Styles.NotRounded
        Me.txt_password.TabIndex = 1
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_password.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txt_password.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Container password :"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Transparent
        Me.txt_name.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txt_name.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txt_name.Location = New System.Drawing.Point(12, 60)
        Me.txt_name.MaxLength = 32767
        Me.txt_name.Multiline = False
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = False
        Me.txt_name.Size = New System.Drawing.Size(394, 25)
        Me.txt_name.Style = PasswordManager.VisualStudioNormalTextBox.Styles.NotRounded
        Me.txt_name.TabIndex = 1
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_name.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txt_name.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Container name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "                        "
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_close.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_close.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cmd_close.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmd_close.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_close.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmd_close.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.cmd_close.ImageChoice = Nothing
        Me.cmd_close.Location = New System.Drawing.Point(393, 5)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.ShowBorder = True
        Me.cmd_close.ShowImage = False
        Me.cmd_close.ShowText = True
        Me.cmd_close.Size = New System.Drawing.Size(20, 21)
        Me.cmd_close.TabIndex = 8
        Me.cmd_close.Text = "X"
        Me.cmd_close.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'CreateContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 244)
        Me.Controls.Add(Me.VisualStudioContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateContainer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisualStudioContainer1.ResumeLayout(False)
        Me.VisualStudioContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisualStudioContainer1 As VisualStudioContainer
    Friend WithEvents txt_name As VisualStudioNormalTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VisualStudioButton1 As VisualStudioButton
    Friend WithEvents txt_repassword As VisualStudioNormalTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password As VisualStudioNormalTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fd_save As SaveFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_close As VisualStudioButton
End Class
