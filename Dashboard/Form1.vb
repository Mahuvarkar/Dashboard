Imports System.IO.Ports

Public Class Form1
    Dim vpb_sy, vpb_ly As Integer
    Dim SpeedL, TempL, BattL As Integer
    Dim Speed, Batt, Temp, SpeedResult, BatteryResult, TempResult As String
    Dim StrSerialIn, StrSerialInRam As String
    Dim ChartLimit As Integer = 30
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ConnectionPanel.Focus()
        ''CircularProgressBarSpeed.Value = 0
        ComboBoxBaudRate.SelectedIndex = 0

        '-------------------creating default graph----------------------------------'
        'For i = 0 To 30 Step 1
        'ChartTemperature.Series("Temperature").Points.AddY(0)
        ' If ChartTemperature.Series(0).Points.Count = ChartLimit Then
        '        ChartTemperature.Series(0).Points.RemoveAt(0)
        ' End If
        ' Next
        '-----------------------------------------------------------------------------
        '------------------Labeling values of the graph-------------------------------'
        ' ChartTemperature.ChartAreas(0).AxisY.Maximum = 40
        ' ChartTemperature.ChartAreas(0).AxisY.Minimum = 0
        ' ChartTemperature.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        '-----------------------------------------------------------------------------
    End Sub

    '================================ Connection Panel ======================================='
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ConnectionPanel.Focus()
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to scan the new port.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub

    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        ConnectionPanel.Focus()
    End Sub

    Private Sub LinkLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub ComboBoxPort_Click(sender As Object, e As EventArgs) Handles ComboBoxPort.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Connection in progress, please Disconnect to change COM.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub ComboBoxBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub



    Private Sub ComboBoxBaudRate_DropDown(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.DropDown
        ConnectionPanel.Focus()
    End Sub


    Private Sub ComboBoxBaudRate_Click(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to change Baud Rate.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        ConnectionPanel.Focus()
        Try
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            SerialPort1.Open()
            TimerSerial.Start()

            LabelStatus.Text = "Status : Connected"
            ButtonConnect.SendToBack()
            ButtonDisconnect.BringToFront()
            PictureBoxConnectionStatus.BackColor = Color.Green
        Catch ex As Exception
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub
    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        ConnectionPanel.Focus()
        TimerSerial.Stop()
        SerialPort1.Close()
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
        LabelStatus.Text = "Status : Disconnect"
        PictureBoxConnectionStatus.Visible = True
        PictureBoxConnectionStatus.BackColor = Color.Red
    End Sub

    '====================================== Connection Panel End ================================================'
End Class
