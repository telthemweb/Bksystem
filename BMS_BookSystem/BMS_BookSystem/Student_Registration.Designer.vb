<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Registration))
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNational = New System.Windows.Forms.TextBox()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblbanner = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimerCownd = New System.Windows.Forms.Timer(Me.components)
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.GpMain = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dpRegistered = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOcpy = New System.Windows.Forms.TextBox()
        Me.txtFather = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GpMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(142, 489)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(277, 24)
        Me.lblError.TabIndex = 57
        Me.lblError.Text = "This is the label for all Errors"
        Me.lblError.Visible = False
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDOB.Location = New System.Drawing.Point(234, 172)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(200, 29)
        Me.txtDOB.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Physical Address"
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.ForeColor = System.Drawing.Color.White
        Me.btnExt.Location = New System.Drawing.Point(439, 541)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(158, 43)
        Me.btnExt.TabIndex = 56
        Me.btnExt.Text = "Close"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(234, 414)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(370, 31)
        Me.txtAddress.TabIndex = 47
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Nationality"
        '
        'txtNational
        '
        Me.txtNational.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNational.Location = New System.Drawing.Point(234, 364)
        Me.txtNational.Name = "txtNational"
        Me.txtNational.Size = New System.Drawing.Size(370, 31)
        Me.txtNational.TabIndex = 45
        Me.txtNational.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboTerm
        '
        Me.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Items.AddRange(New Object() {"First Term", "Second Term", "Third Term"})
        Me.cboTerm.Location = New System.Drawing.Point(234, 313)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(370, 32)
        Me.cboTerm.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "School Term"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.lblbanner)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1279, 56)
        Me.Panel4.TabIndex = 74
        '
        'lblbanner
        '
        Me.lblbanner.AutoSize = True
        Me.lblbanner.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbanner.ForeColor = System.Drawing.Color.White
        Me.lblbanner.Location = New System.Drawing.Point(3, 0)
        Me.lblbanner.Name = "lblbanner"
        Me.lblbanner.Size = New System.Drawing.Size(327, 51)
        Me.lblbanner.TabIndex = 21
        Me.lblbanner.Text = "Student Registration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Location = New System.Drawing.Point(1040, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 36)
        Me.Panel1.TabIndex = 82
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(38, 10)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(120, 16)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Time come here"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(234, 217)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(370, 32)
        Me.cboGender.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Gender"
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"1 A", "1 B", "1 C", "2 A", "2 B", "2 C", "3 A", "3 B", "3 C", "4 A", "4 B", "4 C", "5 A", "5 S", "5 C", "6 A", "6 S", "6 C"})
        Me.cboClass.Location = New System.Drawing.Point(234, 266)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(370, 32)
        Me.cboClass.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 24)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Class"
        '
        'TimerCownd
        '
        Me.TimerCownd.Enabled = True
        Me.TimerCownd.Interval = 1000
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.White
        Me.btnReg.Location = New System.Drawing.Point(49, 541)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(196, 43)
        Me.btnReg.TabIndex = 31
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(261, 541)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 43)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(15, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 24)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Birthday"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(15, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 24)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Surname"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(15, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "First Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(15, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "School ID"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(641, 534)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 50)
        Me.btnExit.TabIndex = 87
        Me.btnExit.Text = "Delete"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(234, 82)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(370, 31)
        Me.txtFname.TabIndex = 28
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(234, 126)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(370, 31)
        Me.txtSurname.TabIndex = 27
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReg
        '
        Me.txtReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReg.Location = New System.Drawing.Point(234, 40)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(370, 31)
        Me.txtReg.TabIndex = 25
        Me.txtReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GpMain
        '
        Me.GpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GpMain.Controls.Add(Me.Panel2)
        Me.GpMain.Controls.Add(Me.dpRegistered)
        Me.GpMain.Controls.Add(Me.btnExit)
        Me.GpMain.Controls.Add(Me.Label5)
        Me.GpMain.Controls.Add(Me.txtPhone)
        Me.GpMain.Controls.Add(Me.Label8)
        Me.GpMain.Controls.Add(Me.Label11)
        Me.GpMain.Controls.Add(Me.txtOcpy)
        Me.GpMain.Controls.Add(Me.txtFather)
        Me.GpMain.Controls.Add(Me.Label10)
        Me.GpMain.Controls.Add(Me.lblError)
        Me.GpMain.Controls.Add(Me.txtDOB)
        Me.GpMain.Controls.Add(Me.Label4)
        Me.GpMain.Controls.Add(Me.btnExt)
        Me.GpMain.Controls.Add(Me.txtAddress)
        Me.GpMain.Controls.Add(Me.Label3)
        Me.GpMain.Controls.Add(Me.txtNational)
        Me.GpMain.Controls.Add(Me.cboTerm)
        Me.GpMain.Controls.Add(Me.Label2)
        Me.GpMain.Controls.Add(Me.cboGender)
        Me.GpMain.Controls.Add(Me.Label1)
        Me.GpMain.Controls.Add(Me.cboClass)
        Me.GpMain.Controls.Add(Me.Label7)
        Me.GpMain.Controls.Add(Me.btnReg)
        Me.GpMain.Controls.Add(Me.btnClear)
        Me.GpMain.Controls.Add(Me.Label13)
        Me.GpMain.Controls.Add(Me.Label15)
        Me.GpMain.Controls.Add(Me.Label16)
        Me.GpMain.Controls.Add(Me.Label17)
        Me.GpMain.Controls.Add(Me.txtFname)
        Me.GpMain.Controls.Add(Me.txtSurname)
        Me.GpMain.Controls.Add(Me.txtReg)
        Me.GpMain.Location = New System.Drawing.Point(7, 69)
        Me.GpMain.Name = "GpMain"
        Me.GpMain.Size = New System.Drawing.Size(1264, 593)
        Me.GpMain.TabIndex = 73
        Me.GpMain.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.BMS_BookSystem.My.Resources.Resources.library_image_lots_of_books_on_shelf
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(641, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 311)
        Me.Panel2.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Forte", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label6.Location = New System.Drawing.Point(21, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(544, 41)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Welcome to Kotwa High Library"
        '
        'dpRegistered
        '
        Me.dpRegistered.Enabled = False
        Me.dpRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpRegistered.Location = New System.Drawing.Point(848, 171)
        Me.dpRegistered.Name = "dpRegistered"
        Me.dpRegistered.Size = New System.Drawing.Size(378, 29)
        Me.dpRegistered.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(637, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(856, 130)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(370, 31)
        Me.txtPhone.TabIndex = 91
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(637, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 24)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Father's Occupation"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(637, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 24)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Father's Name"
        '
        'txtOcpy
        '
        Me.txtOcpy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcpy.Location = New System.Drawing.Point(856, 83)
        Me.txtOcpy.Name = "txtOcpy"
        Me.txtOcpy.Size = New System.Drawing.Size(370, 31)
        Me.txtOcpy.TabIndex = 88
        Me.txtOcpy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFather
        '
        Me.txtFather.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFather.Location = New System.Drawing.Point(856, 41)
        Me.txtFather.Name = "txtFather"
        Me.txtFather.Size = New System.Drawing.Size(370, 31)
        Me.txtFather.TabIndex = 87
        Me.txtFather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(637, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 24)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Date Registered"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Segoe Script", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(0, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1279, 10)
        Me.Label9.TabIndex = 85
        '
        'Student_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1279, 667)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Student_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GpMain.ResumeLayout(False)
        Me.GpMain.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExt As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNational As TextBox
    Friend WithEvents cboTerm As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblbanner As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TimerCownd As Timer
    Friend WithEvents btnReg As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtReg As TextBox
    Friend WithEvents GpMain As GroupBox
    Friend WithEvents dpRegistered As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtOcpy As TextBox
    Friend WithEvents txtFather As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
End Class
