<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ConnectionPanel = New System.Windows.Forms.Panel()
        Me.PictureBoxConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ConnectionTitle = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectionPanel.SuspendLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionPanel
        '
        Me.ConnectionPanel.BackColor = System.Drawing.Color.White
        Me.ConnectionPanel.Controls.Add(Me.PictureBoxConnectionStatus)
        Me.ConnectionPanel.Controls.Add(Me.LabelStatus)
        Me.ConnectionPanel.Controls.Add(Me.ButtonConnect)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.LabelBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxPort)
        Me.ConnectionPanel.Controls.Add(Me.ButtonScanPort)
        Me.ConnectionPanel.Controls.Add(Me.ConnectionTitle)
        Me.ConnectionPanel.Controls.Add(Me.ButtonDisconnect)
        Me.ConnectionPanel.Location = New System.Drawing.Point(12, 12)
        Me.ConnectionPanel.Name = "ConnectionPanel"
        Me.ConnectionPanel.Size = New System.Drawing.Size(220, 187)
        Me.ConnectionPanel.TabIndex = 0
        '
        'PictureBoxConnectionStatus
        '
        Me.PictureBoxConnectionStatus.BackColor = System.Drawing.Color.Red
        Me.PictureBoxConnectionStatus.Location = New System.Drawing.Point(140, 160)
        Me.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus"
        Me.PictureBoxConnectionStatus.Size = New System.Drawing.Size(10, 10)
        Me.PictureBoxConnectionStatus.TabIndex = 8
        Me.PictureBoxConnectionStatus.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkViolet
        Me.LabelStatus.Location = New System.Drawing.Point(22, 160)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(112, 13)
        Me.LabelStatus.TabIndex = 7
        Me.LabelStatus.Text = "Status: Disconnected "
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDisconnect.ForeColor = System.Drawing.Color.White
        Me.ButtonDisconnect.Location = New System.Drawing.Point(36, 124)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(143, 23)
        Me.ButtonDisconnect.TabIndex = 6
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = False
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.White
        Me.ButtonConnect.Location = New System.Drawing.Point(36, 124)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(143, 23)
        Me.ButtonConnect.TabIndex = 5
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.BackColor = System.Drawing.Color.White
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(92, 90)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBaudRate.TabIndex = 4
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.LabelBaudRate.Location = New System.Drawing.Point(11, 93)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(75, 13)
        Me.LabelBaudRate.TabIndex = 3
        Me.LabelBaudRate.Text = "Baud Rate :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.Color.White
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(92, 55)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.White
        Me.ButtonScanPort.Location = New System.Drawing.Point(11, 54)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'ConnectionTitle
        '
        Me.ConnectionTitle.AutoSize = True
        Me.ConnectionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionTitle.ForeColor = System.Drawing.Color.DarkViolet
        Me.ConnectionTitle.Location = New System.Drawing.Point(36, 14)
        Me.ConnectionTitle.Name = "ConnectionTitle"
        Me.ConnectionTitle.Size = New System.Drawing.Size(150, 20)
        Me.ConnectionTitle.TabIndex = 0
        Me.ConnectionTitle.Text = "Connection Panel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 215)
        Me.Controls.Add(Me.ConnectionPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ConnectionPanel.ResumeLayout(False)
        Me.ConnectionPanel.PerformLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConnectionPanel As Panel
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ConnectionTitle As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxConnectionStatus As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
End Class
