<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.bt_info_verbindung = New System.Windows.Forms.Button()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_help = New System.Windows.Forms.Button()
        Me.bt_minimize = New System.Windows.Forms.Button()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.bt_info_brain = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label_stepper_velo = New System.Windows.Forms.Button()
        Me.bt_verbinden = New System.Windows.Forms.Button()
        Me.bt_trennen = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label_dc_velo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label_linear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label_irsensor = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.label_stepper_power = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.label_rotary = New System.Windows.Forms.Button()
        Me.label_dc_power = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.label_joyx = New System.Windows.Forms.Button()
        Me.label_joyy = New System.Windows.Forms.Button()
        Me.bt_notexit = New System.Windows.Forms.Button()
        Me.TimeBomb = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnl_main.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_info_verbindung
        '
        Me.bt_info_verbindung.BackColor = System.Drawing.Color.White
        Me.bt_info_verbindung.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bt_info_verbindung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_info_verbindung.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.bt_info_verbindung.ForeColor = System.Drawing.Color.Red
        Me.bt_info_verbindung.Image = CType(resources.GetObject("bt_info_verbindung.Image"), System.Drawing.Image)
        Me.bt_info_verbindung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_info_verbindung.Location = New System.Drawing.Point(206, 46)
        Me.bt_info_verbindung.Name = "bt_info_verbindung"
        Me.bt_info_verbindung.Size = New System.Drawing.Size(170, 50)
        Me.bt_info_verbindung.TabIndex = 0
        Me.bt_info_verbindung.Text = "Verbindung"
        Me.bt_info_verbindung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_info_verbindung.UseVisualStyleBackColor = False
        '
        'bt_close
        '
        Me.bt_close.FlatAppearance.BorderSize = 0
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.Location = New System.Drawing.Point(1015, 5)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(30, 30)
        Me.bt_close.TabIndex = 2
        Me.bt_close.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bt_help)
        Me.Panel1.Controls.Add(Me.bt_minimize)
        Me.Panel1.Controls.Add(Me.bt_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 40)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Location = New System.Drawing.Point(449, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "[ Schlitten V3C11 ]"
        '
        'bt_help
        '
        Me.bt_help.FlatAppearance.BorderSize = 0
        Me.bt_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_help.Image = CType(resources.GetObject("bt_help.Image"), System.Drawing.Image)
        Me.bt_help.Location = New System.Drawing.Point(5, 5)
        Me.bt_help.Name = "bt_help"
        Me.bt_help.Size = New System.Drawing.Size(30, 30)
        Me.bt_help.TabIndex = 4
        Me.bt_help.UseVisualStyleBackColor = True
        '
        'bt_minimize
        '
        Me.bt_minimize.FlatAppearance.BorderSize = 0
        Me.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_minimize.Image = CType(resources.GetObject("bt_minimize.Image"), System.Drawing.Image)
        Me.bt_minimize.Location = New System.Drawing.Point(980, 5)
        Me.bt_minimize.Name = "bt_minimize"
        Me.bt_minimize.Size = New System.Drawing.Size(30, 30)
        Me.bt_minimize.TabIndex = 3
        Me.bt_minimize.UseVisualStyleBackColor = True
        '
        'pnl_main
        '
        Me.pnl_main.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnl_main.Controls.Add(Me.bt_notexit)
        Me.pnl_main.Controls.Add(Me.bt_trennen)
        Me.pnl_main.Controls.Add(Me.bt_verbinden)
        Me.pnl_main.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_main.Location = New System.Drawing.Point(0, 40)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(200, 530)
        Me.pnl_main.TabIndex = 5
        '
        'bt_info_brain
        '
        Me.bt_info_brain.BackColor = System.Drawing.Color.White
        Me.bt_info_brain.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bt_info_brain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_info_brain.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.bt_info_brain.ForeColor = System.Drawing.Color.Red
        Me.bt_info_brain.Image = CType(resources.GetObject("bt_info_brain.Image"), System.Drawing.Image)
        Me.bt_info_brain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_info_brain.Location = New System.Drawing.Point(382, 46)
        Me.bt_info_brain.Name = "bt_info_brain"
        Me.bt_info_brain.Size = New System.Drawing.Size(136, 50)
        Me.bt_info_brain.TabIndex = 6
        Me.bt_info_brain.Text = "Brain.py"
        Me.bt_info_brain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_info_brain.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(451, 390)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(501, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 39)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Geschwindigkeit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(293, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 39)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Stepper Brick"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(242, 445)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'label_stepper_velo
        '
        Me.label_stepper_velo.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_stepper_velo.ForeColor = System.Drawing.Color.Black
        Me.label_stepper_velo.Location = New System.Drawing.Point(451, 446)
        Me.label_stepper_velo.Name = "label_stepper_velo"
        Me.label_stepper_velo.Size = New System.Drawing.Size(223, 51)
        Me.label_stepper_velo.TabIndex = 8
        Me.label_stepper_velo.Text = "2400"
        Me.label_stepper_velo.UseVisualStyleBackColor = True
        '
        'bt_verbinden
        '
        Me.bt_verbinden.BackColor = System.Drawing.Color.Transparent
        Me.bt_verbinden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_verbinden.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.bt_verbinden.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.bt_verbinden.Image = CType(resources.GetObject("bt_verbinden.Image"), System.Drawing.Image)
        Me.bt_verbinden.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bt_verbinden.Location = New System.Drawing.Point(5, 5)
        Me.bt_verbinden.Name = "bt_verbinden"
        Me.bt_verbinden.Size = New System.Drawing.Size(190, 50)
        Me.bt_verbinden.TabIndex = 0
        Me.bt_verbinden.Text = "Verbinden"
        Me.bt_verbinden.UseVisualStyleBackColor = False
        '
        'bt_trennen
        '
        Me.bt_trennen.BackColor = System.Drawing.Color.Transparent
        Me.bt_trennen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_trennen.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.bt_trennen.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.bt_trennen.Image = CType(resources.GetObject("bt_trennen.Image"), System.Drawing.Image)
        Me.bt_trennen.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bt_trennen.Location = New System.Drawing.Point(5, 61)
        Me.bt_trennen.Name = "bt_trennen"
        Me.bt_trennen.Size = New System.Drawing.Size(190, 50)
        Me.bt_trennen.TabIndex = 1
        Me.bt_trennen.Text = "Trennen"
        Me.bt_trennen.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(293, 508)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 39)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "DC Brick"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(242, 502)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'label_dc_velo
        '
        Me.label_dc_velo.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_dc_velo.ForeColor = System.Drawing.Color.Black
        Me.label_dc_velo.Location = New System.Drawing.Point(451, 503)
        Me.label_dc_velo.Name = "label_dc_velo"
        Me.label_dc_velo.Size = New System.Drawing.Size(223, 51)
        Me.label_dc_velo.TabIndex = 11
        Me.label_dc_velo.Text = "18642"
        Me.label_dc_velo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(615, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 39)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Linear Poti"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(564, 177)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'label_linear
        '
        Me.label_linear.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_linear.ForeColor = System.Drawing.Color.Black
        Me.label_linear.Location = New System.Drawing.Point(773, 178)
        Me.label_linear.Name = "label_linear"
        Me.label_linear.Size = New System.Drawing.Size(224, 51)
        Me.label_linear.TabIndex = 19
        Me.label_linear.Text = "100"
        Me.label_linear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(615, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 39)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "IR Sensor"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(564, 120)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(823, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 39)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Distanz | Value"
        '
        'label_irsensor
        '
        Me.label_irsensor.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_irsensor.ForeColor = System.Drawing.Color.Black
        Me.label_irsensor.Location = New System.Drawing.Point(773, 121)
        Me.label_irsensor.Name = "label_irsensor"
        Me.label_irsensor.Size = New System.Drawing.Size(224, 51)
        Me.label_irsensor.TabIndex = 16
        Me.label_irsensor.Text = "27cm"
        Me.label_irsensor.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(773, 65)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(741, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 39)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Frequenz / Strom"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(689, 390)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'label_stepper_power
        '
        Me.label_stepper_power.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_stepper_power.ForeColor = System.Drawing.Color.Black
        Me.label_stepper_power.Location = New System.Drawing.Point(689, 444)
        Me.label_stepper_power.Name = "label_stepper_power"
        Me.label_stepper_power.Size = New System.Drawing.Size(224, 51)
        Me.label_stepper_power.TabIndex = 29
        Me.label_stepper_power.Text = "850 mA"
        Me.label_stepper_power.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(615, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 39)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Rotary Poti"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(564, 234)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        '
        'label_rotary
        '
        Me.label_rotary.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_rotary.ForeColor = System.Drawing.Color.Black
        Me.label_rotary.Location = New System.Drawing.Point(773, 235)
        Me.label_rotary.Name = "label_rotary"
        Me.label_rotary.Size = New System.Drawing.Size(224, 51)
        Me.label_rotary.TabIndex = 26
        Me.label_rotary.Text = "+ 130"
        Me.label_rotary.UseVisualStyleBackColor = True
        '
        'label_dc_power
        '
        Me.label_dc_power.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_dc_power.ForeColor = System.Drawing.Color.Black
        Me.label_dc_power.Location = New System.Drawing.Point(689, 501)
        Me.label_dc_power.Name = "label_dc_power"
        Me.label_dc_power.Size = New System.Drawing.Size(224, 51)
        Me.label_dc_power.TabIndex = 33
        Me.label_dc_power.Text = "8400 Hz"
        Me.label_dc_power.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Reem Kufi", 15.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(615, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 39)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Joystick"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(564, 291)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox9.TabIndex = 32
        Me.PictureBox9.TabStop = False
        '
        'label_joyx
        '
        Me.label_joyx.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_joyx.ForeColor = System.Drawing.Color.Black
        Me.label_joyx.Location = New System.Drawing.Point(773, 292)
        Me.label_joyx.Name = "label_joyx"
        Me.label_joyx.Size = New System.Drawing.Size(110, 51)
        Me.label_joyx.TabIndex = 30
        Me.label_joyx.Text = "X (32)"
        Me.label_joyx.UseVisualStyleBackColor = True
        '
        'label_joyy
        '
        Me.label_joyy.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.label_joyy.ForeColor = System.Drawing.Color.Black
        Me.label_joyy.Location = New System.Drawing.Point(887, 292)
        Me.label_joyy.Name = "label_joyy"
        Me.label_joyy.Size = New System.Drawing.Size(110, 51)
        Me.label_joyy.TabIndex = 34
        Me.label_joyy.Text = "Y (80)"
        Me.label_joyy.UseVisualStyleBackColor = True
        '
        'bt_notexit
        '
        Me.bt_notexit.BackColor = System.Drawing.Color.Transparent
        Me.bt_notexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_notexit.Font = New System.Drawing.Font("Reem Kufi", 14.25!)
        Me.bt_notexit.ForeColor = System.Drawing.Color.Crimson
        Me.bt_notexit.Location = New System.Drawing.Point(5, 475)
        Me.bt_notexit.Name = "bt_notexit"
        Me.bt_notexit.Size = New System.Drawing.Size(190, 50)
        Me.bt_notexit.TabIndex = 2
        Me.bt_notexit.Text = "SOFORT  STOP"
        Me.bt_notexit.UseVisualStyleBackColor = False
        '
        'TimeBomb
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 570)
        Me.Controls.Add(Me.label_joyy)
        Me.Controls.Add(Me.label_dc_power)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.label_joyx)
        Me.Controls.Add(Me.label_stepper_power)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.label_rotary)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.label_linear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.label_irsensor)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.label_dc_velo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_stepper_velo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_info_brain)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bt_info_verbindung)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "/"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_info_verbindung As Button
    Friend WithEvents bt_close As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bt_minimize As Button
    Friend WithEvents bt_help As Button
    Friend WithEvents pnl_main As Panel
    Friend WithEvents bt_info_brain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bt_trennen As Button
    Friend WithEvents bt_verbinden As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents label_stepper_velo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents label_dc_velo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents label_linear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents label_irsensor As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents label_stepper_power As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents label_rotary As Button
    Friend WithEvents label_dc_power As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents label_joyx As Button
    Friend WithEvents label_joyy As Button
    Friend WithEvents bt_notexit As Button
    Friend WithEvents TimeBomb As Timer
End Class
