<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.menu_data = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mi_add = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mi_Import = New System.Windows.Forms.ToolStripMenuItem()
        Me.fd_open = New System.Windows.Forms.OpenFileDialog()
        Me.imglist = New System.Windows.Forms.ImageList(Me.components)
        Me.notify_tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.VisualStudioContainer1 = New PasswordManager.VisualStudioContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_search = New PasswordManager.VisualStudioNormalTextBox()
        Me.cmd_minimize = New PasswordManager.VisualStudioButton()
        Me.cmd_close = New PasswordManager.VisualStudioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VisualStudioSeperator3 = New PasswordManager.VisualStudioSeperator()
        Me.lv_data = New System.Windows.Forms.ListView()
        Me.ch_website = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VisualStudioSeperator2 = New PasswordManager.VisualStudioSeperator()
        Me.cmd_Settings = New PasswordManager.VisualStudioButton()
        Me.cmd_Create = New PasswordManager.VisualStudioButton()
        Me.cmd_Save = New PasswordManager.VisualStudioButton()
        Me.cmd_Load = New PasswordManager.VisualStudioButton()
        Me.statusbar = New PasswordManager.VisualStudioStatusBar()
        Me.VisualStudioSeperator1 = New PasswordManager.VisualStudioSeperator()
        Me.menu_data.SuspendLayout()
        Me.VisualStudioContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu_data
        '
        Me.menu_data.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_add, Me.mi_Remove, Me.ToolStripSeparator1, Me.mi_Import})
        Me.menu_data.Name = "menu_data"
        Me.menu_data.Size = New System.Drawing.Size(166, 76)
        '
        'mi_add
        '
        Me.mi_add.Name = "mi_add"
        Me.mi_add.Size = New System.Drawing.Size(165, 22)
        Me.mi_add.Text = "Add Account"
        '
        'mi_Remove
        '
        Me.mi_Remove.Name = "mi_Remove"
        Me.mi_Remove.Size = New System.Drawing.Size(165, 22)
        Me.mi_Remove.Text = "Remove Account"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'mi_Import
        '
        Me.mi_Import.Name = "mi_Import"
        Me.mi_Import.Size = New System.Drawing.Size(165, 22)
        Me.mi_Import.Text = "Import Container"
        '
        'fd_open
        '
        Me.fd_open.Filter = "PasswordManager Container (.pwm)|*.pwm"
        '
        'imglist
        '
        Me.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.imglist.ImageSize = New System.Drawing.Size(16, 16)
        Me.imglist.TransparentColor = System.Drawing.Color.Transparent
        '
        'notify_tray
        '
        Me.notify_tray.BalloonTipText = "Minimized to tray"
        Me.notify_tray.BalloonTipTitle = "Information"
        Me.notify_tray.Icon = CType(resources.GetObject("notify_tray.Icon"), System.Drawing.Icon)
        Me.notify_tray.Text = "PasswordManager"
        '
        'VisualStudioContainer1
        '
        Me.VisualStudioContainer1.AllowClose = True
        Me.VisualStudioContainer1.AllowMaximize = False
        Me.VisualStudioContainer1.AllowMinimize = False
        Me.VisualStudioContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioContainer1.Controls.Add(Me.PictureBox1)
        Me.VisualStudioContainer1.Controls.Add(Me.txt_search)
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_minimize)
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_close)
        Me.VisualStudioContainer1.Controls.Add(Me.Label4)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioSeperator3)
        Me.VisualStudioContainer1.Controls.Add(Me.lv_data)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioSeperator2)
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_Settings)
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_Create)
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_Save)
        Me.VisualStudioContainer1.Controls.Add(Me.cmd_Load)
        Me.VisualStudioContainer1.Controls.Add(Me.statusbar)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioSeperator1)
        Me.VisualStudioContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualStudioContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VisualStudioContainer1.FontSize = 12
        Me.VisualStudioContainer1.Form = Me
        Me.VisualStudioContainer1.FormOrWhole = PasswordManager.VisualStudioContainer.__FormOrWhole.WholeApplication
        Me.VisualStudioContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.VisualStudioContainer1.IconStyle = PasswordManager.VisualStudioContainer.__IconStyle.VSIcon
        Me.VisualStudioContainer1.Location = New System.Drawing.Point(0, 0)
        Me.VisualStudioContainer1.Name = "VisualStudioContainer1"
        Me.VisualStudioContainer1.ShowIcon = True
        Me.VisualStudioContainer1.Size = New System.Drawing.Size(637, 586)
        Me.VisualStudioContainer1.TabIndex = 0
        Me.VisualStudioContainer1.Text = "PasswordManager"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(540, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.Transparent
        Me.txt_search.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txt_search.BorderColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txt_search.Location = New System.Drawing.Point(360, 4)
        Me.txt_search.MaxLength = 32767
        Me.txt_search.Multiline = False
        Me.txt_search.Name = "txt_search"
        Me.txt_search.ReadOnly = False
        Me.txt_search.Size = New System.Drawing.Size(179, 25)
        Me.txt_search.Style = PasswordManager.VisualStudioNormalTextBox.Styles.NotRounded
        Me.txt_search.TabIndex = 8
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_search.TextColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_search.UseSystemPasswordChar = False
        '
        'cmd_minimize
        '
        Me.cmd_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_minimize.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_minimize.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cmd_minimize.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmd_minimize.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_minimize.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmd_minimize.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.cmd_minimize.ImageChoice = Nothing
        Me.cmd_minimize.Location = New System.Drawing.Point(583, 4)
        Me.cmd_minimize.Name = "cmd_minimize"
        Me.cmd_minimize.ShowBorder = True
        Me.cmd_minimize.ShowImage = False
        Me.cmd_minimize.ShowText = True
        Me.cmd_minimize.Size = New System.Drawing.Size(20, 21)
        Me.cmd_minimize.TabIndex = 7
        Me.cmd_minimize.Text = "_"
        Me.cmd_minimize.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.cmd_close.Location = New System.Drawing.Point(609, 4)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.ShowBorder = True
        Me.cmd_close.ShowImage = False
        Me.cmd_close.ShowText = True
        Me.cmd_close.Size = New System.Drawing.Size(20, 21)
        Me.cmd_close.TabIndex = 7
        Me.cmd_close.Text = "X"
        Me.cmd_close.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "                  "
        '
        'VisualStudioSeperator3
        '
        Me.VisualStudioSeperator3.AddEndNotch = False
        Me.VisualStudioSeperator3.BackColor = System.Drawing.Color.Transparent
        Me.VisualStudioSeperator3.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioSeperator3.LineColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VisualStudioSeperator3.Location = New System.Drawing.Point(288, 52)
        Me.VisualStudioSeperator3.Name = "VisualStudioSeperator3"
        Me.VisualStudioSeperator3.OnlyUnderlineText = False
        Me.VisualStudioSeperator3.ShowText = False
        Me.VisualStudioSeperator3.ShowTextAboveLine = False
        Me.VisualStudioSeperator3.Size = New System.Drawing.Size(58, 10)
        Me.VisualStudioSeperator3.TabIndex = 5
        Me.VisualStudioSeperator3.Text = "VisualStudioSeperator3"
        Me.VisualStudioSeperator3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.VisualStudioSeperator3.TextLocation = PasswordManager.VisualStudioSeperator.__TextLocation.Left
        Me.VisualStudioSeperator3.UnderlineText = False
        '
        'lv_data
        '
        Me.lv_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lv_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv_data.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch_website, Me.ch_username, Me.ch_password})
        Me.lv_data.ContextMenuStrip = Me.menu_data
        Me.lv_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_data.ForeColor = System.Drawing.Color.White
        Me.lv_data.FullRowSelect = True
        Me.lv_data.Location = New System.Drawing.Point(3, 89)
        Me.lv_data.MultiSelect = False
        Me.lv_data.Name = "lv_data"
        Me.lv_data.Size = New System.Drawing.Size(631, 468)
        Me.lv_data.SmallImageList = Me.imglist
        Me.lv_data.TabIndex = 4
        Me.lv_data.UseCompatibleStateImageBehavior = False
        Me.lv_data.View = System.Windows.Forms.View.Details
        '
        'ch_website
        '
        Me.ch_website.Text = "Website"
        Me.ch_website.Width = 205
        '
        'ch_username
        '
        Me.ch_username.Text = "Username / E-Mail"
        Me.ch_username.Width = 157
        '
        'ch_password
        '
        Me.ch_password.Text = "Password"
        Me.ch_password.Width = 237
        '
        'VisualStudioSeperator2
        '
        Me.VisualStudioSeperator2.AddEndNotch = False
        Me.VisualStudioSeperator2.BackColor = System.Drawing.Color.Transparent
        Me.VisualStudioSeperator2.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioSeperator2.LineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.VisualStudioSeperator2.Location = New System.Drawing.Point(3, 75)
        Me.VisualStudioSeperator2.Name = "VisualStudioSeperator2"
        Me.VisualStudioSeperator2.OnlyUnderlineText = False
        Me.VisualStudioSeperator2.ShowText = False
        Me.VisualStudioSeperator2.ShowTextAboveLine = False
        Me.VisualStudioSeperator2.Size = New System.Drawing.Size(631, 12)
        Me.VisualStudioSeperator2.TabIndex = 3
        Me.VisualStudioSeperator2.Text = "VisualStudioSeperator2"
        Me.VisualStudioSeperator2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.VisualStudioSeperator2.TextLocation = PasswordManager.VisualStudioSeperator.__TextLocation.Left
        Me.VisualStudioSeperator2.UnderlineText = False
        '
        'cmd_Settings
        '
        Me.cmd_Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Settings.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Settings.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cmd_Settings.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Settings.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmd_Settings.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.cmd_Settings.ImageChoice = Nothing
        Me.cmd_Settings.Location = New System.Drawing.Point(494, 43)
        Me.cmd_Settings.Name = "cmd_Settings"
        Me.cmd_Settings.ShowBorder = True
        Me.cmd_Settings.ShowImage = False
        Me.cmd_Settings.ShowText = True
        Me.cmd_Settings.Size = New System.Drawing.Size(131, 27)
        Me.cmd_Settings.TabIndex = 2
        Me.cmd_Settings.Text = "Import Chrome"
        Me.cmd_Settings.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmd_Create
        '
        Me.cmd_Create.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Create.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Create.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cmd_Create.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Create.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmd_Create.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.cmd_Create.ImageChoice = Nothing
        Me.cmd_Create.Location = New System.Drawing.Point(357, 43)
        Me.cmd_Create.Name = "cmd_Create"
        Me.cmd_Create.ShowBorder = True
        Me.cmd_Create.ShowImage = False
        Me.cmd_Create.ShowText = True
        Me.cmd_Create.Size = New System.Drawing.Size(131, 27)
        Me.cmd_Create.TabIndex = 2
        Me.cmd_Create.Text = "Create Container"
        Me.cmd_Create.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmd_Save
        '
        Me.cmd_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Save.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Save.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cmd_Save.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Save.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmd_Save.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.cmd_Save.ImageChoice = Nothing
        Me.cmd_Save.Location = New System.Drawing.Point(149, 43)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.ShowBorder = True
        Me.cmd_Save.ShowImage = False
        Me.cmd_Save.ShowText = True
        Me.cmd_Save.Size = New System.Drawing.Size(131, 27)
        Me.cmd_Save.TabIndex = 2
        Me.cmd_Save.Text = "Save Container"
        Me.cmd_Save.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmd_Load
        '
        Me.cmd_Load.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Load.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmd_Load.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.cmd_Load.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_Load.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmd_Load.ImageAlignment = PasswordManager.VisualStudioButton.__ImageAlignment.Left
        Me.cmd_Load.ImageChoice = Nothing
        Me.cmd_Load.Location = New System.Drawing.Point(12, 43)
        Me.cmd_Load.Name = "cmd_Load"
        Me.cmd_Load.ShowBorder = True
        Me.cmd_Load.ShowImage = False
        Me.cmd_Load.ShowText = True
        Me.cmd_Load.Size = New System.Drawing.Size(131, 27)
        Me.cmd_Load.TabIndex = 2
        Me.cmd_Load.Text = "Load Container"
        Me.cmd_Load.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'statusbar
        '
        Me.statusbar.AmountOfString = PasswordManager.VisualStudioStatusBar.AmountOfStrings.Two
        Me.statusbar.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.statusbar.BorderColour = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.statusbar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.statusbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusbar.FirstLabelAlignment = PasswordManager.VisualStudioStatusBar.Alignments.Left
        Me.statusbar.FirstLabelText = "Status :"
        Me.statusbar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.statusbar.LinesToShow = PasswordManager.VisualStudioStatusBar.LinesCount.One
        Me.statusbar.Location = New System.Drawing.Point(0, 563)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.RectangleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.statusbar.SecondLabelAlignment = PasswordManager.VisualStudioStatusBar.Alignments.Center
        Me.statusbar.SecondLabelText = "Container name : "
        Me.statusbar.ShowBorder = True
        Me.statusbar.ShowLine = True
        Me.statusbar.Size = New System.Drawing.Size(637, 23)
        Me.statusbar.TabIndex = 1
        Me.statusbar.TextColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.statusbar.ThirdLabelAlignment = PasswordManager.VisualStudioStatusBar.Alignments.Center
        Me.statusbar.ThirdLabelText = "Label3"
        '
        'VisualStudioSeperator1
        '
        Me.VisualStudioSeperator1.AddEndNotch = False
        Me.VisualStudioSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.VisualStudioSeperator1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioSeperator1.LineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.VisualStudioSeperator1.Location = New System.Drawing.Point(3, 27)
        Me.VisualStudioSeperator1.Name = "VisualStudioSeperator1"
        Me.VisualStudioSeperator1.OnlyUnderlineText = False
        Me.VisualStudioSeperator1.ShowText = False
        Me.VisualStudioSeperator1.ShowTextAboveLine = False
        Me.VisualStudioSeperator1.Size = New System.Drawing.Size(632, 10)
        Me.VisualStudioSeperator1.TabIndex = 0
        Me.VisualStudioSeperator1.Text = "VisualStudioSeperator1"
        Me.VisualStudioSeperator1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.VisualStudioSeperator1.TextLocation = PasswordManager.VisualStudioSeperator.__TextLocation.Left
        Me.VisualStudioSeperator1.UnderlineText = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 586)
        Me.Controls.Add(Me.VisualStudioContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.menu_data.ResumeLayout(False)
        Me.VisualStudioContainer1.ResumeLayout(False)
        Me.VisualStudioContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisualStudioContainer1 As VisualStudioContainer
    Friend WithEvents VisualStudioSeperator1 As VisualStudioSeperator
    Friend WithEvents VisualStudioSeperator2 As VisualStudioSeperator
    Friend WithEvents cmd_Settings As VisualStudioButton
    Friend WithEvents cmd_Create As VisualStudioButton
    Friend WithEvents cmd_Load As VisualStudioButton
    Friend WithEvents statusbar As VisualStudioStatusBar
    Friend WithEvents lv_data As ListView
    Friend WithEvents ch_website As ColumnHeader
    Friend WithEvents ch_username As ColumnHeader
    Friend WithEvents ch_password As ColumnHeader
    Friend WithEvents menu_data As ContextMenuStrip
    Friend WithEvents mi_add As ToolStripMenuItem
    Friend WithEvents mi_Remove As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mi_Import As ToolStripMenuItem
    Friend WithEvents VisualStudioSeperator3 As VisualStudioSeperator
    Friend WithEvents cmd_Save As VisualStudioButton
    Friend WithEvents cmd_close As VisualStudioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents fd_open As OpenFileDialog
    Friend WithEvents imglist As ImageList
    Friend WithEvents cmd_minimize As VisualStudioButton
    Friend WithEvents notify_tray As NotifyIcon
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_search As VisualStudioNormalTextBox
End Class
