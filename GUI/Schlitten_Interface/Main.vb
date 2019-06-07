Imports System
Imports Tinkerforge

Public Class Main

    '//Variablen'

    Const HOST As String = "localhost"
    Const PORT As Integer = 4223
    Const UIDir As String = ""
    Const UIDstepper As String = ""
    Const UIDoled As String = ""
    Const UIDrotary As String = ""
    Const UIDlinear As String = ""
    Const UIDjoystick As String = ""
    Const UIDdcb As String = ""

    Dim onOf As Boolean = False

    Dim dis_ir As Integer
    Dim dis_rotary As Integer
    Dim dis_linear As Integer
    Dim pos_joystick As Short
    Dim freque As Integer
    Dim x, y As Short

    Dim ipcon As New IPConnection()
    Dim irsensor As New BrickletDistanceIR(UIDir, ipcon)
    Dim ropoti As New BrickletRotaryPoti(UIDrotary, ipcon)
    Dim linear As New BrickletLinearPoti(UIDlinear, ipcon)
    Dim joystick As New BrickletJoystick(UIDjoystick, ipcon)
    Dim dcb As New BrickDC(UIDdcb, ipcon)
    Dim stepper As New BrickStepper(UIDstepper, ipcon)



    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub




    '//Panel Button'
    Private Sub Bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub Bt_minimize_Click(sender As Object, e As EventArgs) Handles bt_minimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub



    '//Menü Button'
    Private Sub Bt_verbinden_Click(sender As Object, e As EventArgs) Handles bt_verbinden.Click
        If onOf = False Then
            Verbindung()
        End If
    End Sub

    Private Sub Bt_trennen_Click(sender As Object, e As EventArgs) Handles bt_trennen.Click
        If onOf = True Then
            Verbindung()
        End If
    End Sub



    '//Funktionen'

    Public Sub Verbindung()
        If onOf = False Then
            ipcon.Connect(HOST, PORT)
            bt_info_verbindung.ForeColor = Color.MediumAquamarine
            onOf = True
            TimeBomb.Start()
        Else
            stepper.Stop()
            dcb.Disable()
            ipcon.Disconnect()
        End If
    End Sub

    Private Sub Bt_notexit_Click(sender As Object, e As EventArgs) Handles bt_notexit.Click
        If onOf = True Then
            stepper.FullBrake()
            dcb.Disable()
            ipcon.Disconnect()
        End If
    End Sub

    Private Sub TimeBomb_Tick(sender As Object, e As EventArgs) Handles TimeBomb.Tick

        label_stepper_velo.Text = stepper.GetCurrentVelocity()
        label_stepper_power.Text = stepper.GetMotorCurrent() + " mA"

        label_dc_velo.Text = dcb.GetCurrentVelocity()
        label_dc_power.Text = dcb.GetPWMFrequency() + " HZ"

        joystick.GetPosition(x, y)
        label_joyx.Text = "X (" + x + ")"
        label_joyy.Text = "Y (" + y + ")"


        label_linear.Text = linear.GetPosition() + "cm"
        label_rotary.Text = ropoti.GetAnalogValue()

        dis_ir = irsensor.GetDistance()
        label_irsensor.Text = (dis_ir / 10).ToString() + "cm"
    End Sub
End Class
