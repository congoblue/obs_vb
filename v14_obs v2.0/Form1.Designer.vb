<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.eVISMacrosAppHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bConnect = New System.Windows.Forms.Button()
        Me.mLog = New System.Windows.Forms.TextBox()
        Me.chkLogMessages = New System.Windows.Forms.CheckBox()
        Me.BtnPresetSave = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonSetup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LabelProfile = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxOBSBroadcastTime = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TextPlayerTime = New System.Windows.Forms.TextBox()
        Me.TextBoxOBSRecTime = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBoxPipSrc = New System.Windows.Forms.TextBox()
        Me.TextLeaderName = New System.Windows.Forms.TextBox()
        Me.TextPreacherName = New System.Windows.Forms.TextBox()
        Me.LabelCap1 = New System.Windows.Forms.Label()
        Me.LabelCap2 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ListBoxMedia = New System.Windows.Forms.ListBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BtnMNext = New AtemController.MyButton()
        Me.BtnInp5 = New AtemController.MyButton()
        Me.BtnPip = New AtemController.MyButton()
        Me.BtnOBSRecord = New AtemController.MyButton()
        Me.BtnOBSBroadcast = New AtemController.MyButton()
        Me.BtnMPrev = New AtemController.MyButton()
        Me.BtnLiveSlow = New AtemController.MyButton()
        Me.BtnLiveFast = New AtemController.MyButton()
        Me.BtnPreload = New AtemController.MyButton()
        Me.BtnLivePTZ = New AtemController.MyButton()
        Me.BtnLive = New AtemController.MyButton()
        Me.MyButtonCamDR = New AtemController.MyButton()
        Me.MyButtonCamD = New AtemController.MyButton()
        Me.MyButtonCamDL = New AtemController.MyButton()
        Me.MyButtonCamR = New AtemController.MyButton()
        Me.MyButtonCamL = New AtemController.MyButton()
        Me.MyButtonCamUR = New AtemController.MyButton()
        Me.MyButtonCamU = New AtemController.MyButton()
        Me.MyButtonCamUL = New AtemController.MyButton()
        Me.BtnAELock = New AtemController.MyButton()
        Me.BtnFocus = New AtemController.MyButton()
        Me.BtnSlowOut = New AtemController.MyButton()
        Me.BtnSlowIn = New AtemController.MyButton()
        Me.BtnPreset4 = New AtemController.MyButton()
        Me.BtnPreset3 = New AtemController.MyButton()
        Me.BtnPreset2 = New AtemController.MyButton()
        Me.BtnPreset1 = New AtemController.MyButton()
        Me.BtnMediaNxt = New AtemController.MyButton()
        Me.BtnMediaOverlay = New AtemController.MyButton()
        Me.BtnOverlay = New AtemController.MyButton()
        Me.BtnTransition = New AtemController.MyButton()
        Me.BtnCut = New AtemController.MyButton()
        Me.BtnMediaPrev = New AtemController.MyButton()
        Me.BtnInp4 = New AtemController.MyButton()
        Me.BtnInp3 = New AtemController.MyButton()
        Me.BtnInp2 = New AtemController.MyButton()
        Me.BtnInp1 = New AtemController.MyButton()
        Me.BtnCam4 = New AtemController.MyButton()
        Me.BtnCam3 = New AtemController.MyButton()
        Me.BtnCam2 = New AtemController.MyButton()
        Me.BtnCam1 = New AtemController.MyButton()
        Me.OverrideBtn = New AtemController.MyButton()
        Me.LabelCap3 = New System.Windows.Forms.Label()
        Me.TextCaptionOther = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'eVISMacrosAppHost
        '
        Me.eVISMacrosAppHost.Location = New System.Drawing.Point(17, 386)
        Me.eVISMacrosAppHost.Margin = New System.Windows.Forms.Padding(4)
        Me.eVISMacrosAppHost.Name = "eVISMacrosAppHost"
        Me.eVISMacrosAppHost.Size = New System.Drawing.Size(187, 22)
        Me.eVISMacrosAppHost.TabIndex = 0
        Me.eVISMacrosAppHost.Text = "localhost"
        Me.eVISMacrosAppHost.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 242)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address of VIS Macros Application Computer"
        Me.Label1.Visible = False
        '
        'bConnect
        '
        Me.bConnect.Location = New System.Drawing.Point(16, 262)
        Me.bConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.bConnect.Name = "bConnect"
        Me.bConnect.Size = New System.Drawing.Size(120, 26)
        Me.bConnect.TabIndex = 2
        Me.bConnect.Text = "Connect"
        Me.bConnect.UseVisualStyleBackColor = True
        Me.bConnect.Visible = False
        '
        'mLog
        '
        Me.mLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mLog.Location = New System.Drawing.Point(16, 262)
        Me.mLog.Margin = New System.Windows.Forms.Padding(4)
        Me.mLog.Multiline = True
        Me.mLog.Name = "mLog"
        Me.mLog.Size = New System.Drawing.Size(128, 114)
        Me.mLog.TabIndex = 4
        Me.mLog.Text = "Log window"
        '
        'chkLogMessages
        '
        Me.chkLogMessages.AutoSize = True
        Me.chkLogMessages.Checked = True
        Me.chkLogMessages.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLogMessages.ForeColor = System.Drawing.Color.White
        Me.chkLogMessages.Location = New System.Drawing.Point(19, 418)
        Me.chkLogMessages.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLogMessages.Name = "chkLogMessages"
        Me.chkLogMessages.Size = New System.Drawing.Size(122, 21)
        Me.chkLogMessages.TabIndex = 44
        Me.chkLogMessages.Text = "Log Messages"
        Me.chkLogMessages.UseVisualStyleBackColor = True
        Me.chkLogMessages.Visible = False
        '
        'BtnPresetSave
        '
        Me.BtnPresetSave.Font = New System.Drawing.Font("Wingdings", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BtnPresetSave.Location = New System.Drawing.Point(1280, 508)
        Me.BtnPresetSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPresetSave.Name = "BtnPresetSave"
        Me.BtnPresetSave.Size = New System.Drawing.Size(67, 62)
        Me.BtnPresetSave.TabIndex = 57
        Me.BtnPresetSave.Text = "<"
        Me.BtnPresetSave.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox1.Location = New System.Drawing.Point(1271, 1076)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 30)
        Me.TextBox1.TabIndex = 87
        Me.TextBox1.Text = "1.0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnStop
        '
        Me.BtnStop.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.Location = New System.Drawing.Point(1289, 727)
        Me.BtnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(81, 79)
        Me.BtnStop.TabIndex = 72
        Me.BtnStop.Text = "Stop all"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Wingdings", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button7.Location = New System.Drawing.Point(1355, 508)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 62)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "?"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox2.Location = New System.Drawing.Point(1472, 1076)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(82, 30)
        Me.TextBox2.TabIndex = 89
        Me.TextBox2.Text = "1.0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox5.Location = New System.Drawing.Point(504, 174)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(61, 30)
        Me.TextBox5.TabIndex = 116
        Me.TextBox5.Text = "8"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox6.Location = New System.Drawing.Point(641, 174)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(61, 30)
        Me.TextBox6.TabIndex = 119
        Me.TextBox6.Text = "6"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox7.Location = New System.Drawing.Point(573, 174)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(61, 30)
        Me.TextBox7.TabIndex = 122
        Me.TextBox7.Text = "10"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox9.Location = New System.Drawing.Point(711, 174)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(61, 30)
        Me.TextBox9.TabIndex = 129
        Me.TextBox9.Text = "190"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(53, 1041)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 22)
        Me.Label14.TabIndex = 155
        Me.Label14.Text = "Next Source select"
        '
        'SerialPort1
        '
        '
        'ButtonSetup
        '
        Me.ButtonSetup.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ButtonSetup.Location = New System.Drawing.Point(52, 54)
        Me.ButtonSetup.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSetup.Name = "ButtonSetup"
        Me.ButtonSetup.Size = New System.Drawing.Size(61, 52)
        Me.ButtonSetup.TabIndex = 164
        Me.ButtonSetup.Text = "@"
        Me.ButtonSetup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(1281, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 22)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Camera preset positions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(1281, 594)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 22)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Live moves (use presets)"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1707, 1102)
        Me.ShapeContainer1.TabIndex = 184
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 671
        Me.LineShape11.X2 = 863
        Me.LineShape11.Y1 = 383
        Me.LineShape11.Y2 = 383
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 670
        Me.LineShape10.X2 = 862
        Me.LineShape10.Y1 = 226
        Me.LineShape10.Y2 = 226
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 671
        Me.LineShape9.X2 = 863
        Me.LineShape9.Y1 = 69
        Me.LineShape9.Y2 = 69
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 164
        Me.LineShape8.X2 = 575
        Me.LineShape8.Y1 = 68
        Me.LineShape8.Y2 = 68
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 970
        Me.LineShape2.X2 = 1249
        Me.LineShape2.Y1 = 68
        Me.LineShape2.Y2 = 68
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 967
        Me.LineShape1.X2 = 1255
        Me.LineShape1.Y1 = 491
        Me.LineShape1.Y2 = 491
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(1473, 1041)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 22)
        Me.Label16.TabIndex = 185
        Me.Label16.Text = "Overlay"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(60, 31)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 22)
        Me.Label17.TabIndex = 186
        Me.Label17.Text = "Setup"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(171, 73)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 22)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "Camera controls"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(447, 101)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 22)
        Me.Label19.TabIndex = 189
        Me.Label19.Text = "Iris"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(513, 101)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 22)
        Me.Label20.TabIndex = 190
        Me.Label20.Text = "AGC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(564, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 22)
        Me.Label8.TabIndex = 195
        Me.Label8.Text = "AGC Limit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(641, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 22)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "AE Shift"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(716, 101)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 22)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "WB"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Webdings", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.Location = New System.Drawing.Point(1637, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 214
        Me.Button1.Text = "r"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(1561, 32)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 22)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "v14.0"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button2.Location = New System.Drawing.Point(355, 156)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 31)
        Me.Button2.TabIndex = 224
        Me.Button2.Text = "#"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button3.Location = New System.Drawing.Point(355, 123)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 31)
        Me.Button3.TabIndex = 225
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button4.Location = New System.Drawing.Point(355, 252)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 31)
        Me.Button4.TabIndex = 226
        Me.Button4.Text = ","
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button6.Location = New System.Drawing.Point(355, 215)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(61, 31)
        Me.Button6.TabIndex = 227
        Me.Button6.Text = "$"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(360, 101)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 22)
        Me.Label25.TabIndex = 228
        Me.Label25.Text = "Zoom"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(52, 113)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 52)
        Me.Button5.TabIndex = 247
        Me.Button5.Text = "Retry cam"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LabelProfile
        '
        Me.LabelProfile.AutoSize = True
        Me.LabelProfile.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfile.ForeColor = System.Drawing.Color.Yellow
        Me.LabelProfile.Location = New System.Drawing.Point(1357, 32)
        Me.LabelProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProfile.Name = "LabelProfile"
        Me.LabelProfile.Size = New System.Drawing.Size(55, 22)
        Me.LabelProfile.TabIndex = 248
        Me.LabelProfile.Text = "profile"
        Me.LabelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(1691, 372)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(537, 310)
        Me.GroupBox1.TabIndex = 258
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label22.Location = New System.Drawing.Point(24, 31)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 24)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Startup..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(819, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 22)
        Me.Label6.TabIndex = 267
        Me.Label6.Text = "OBS broadcast"
        '
        'TextBoxOBSBroadcastTime
        '
        Me.TextBoxOBSBroadcastTime.BackColor = System.Drawing.Color.Black
        Me.TextBoxOBSBroadcastTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxOBSBroadcastTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOBSBroadcastTime.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxOBSBroadcastTime.Location = New System.Drawing.Point(919, 124)
        Me.TextBoxOBSBroadcastTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxOBSBroadcastTime.Name = "TextBoxOBSBroadcastTime"
        Me.TextBoxOBSBroadcastTime.Size = New System.Drawing.Size(215, 30)
        Me.TextBoxOBSBroadcastTime.TabIndex = 268
        Me.TextBoxOBSBroadcastTime.Text = "..."
        Me.TextBoxOBSBroadcastTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPlayerTime
        '
        Me.TextPlayerTime.BackColor = System.Drawing.Color.Black
        Me.TextPlayerTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPlayerTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPlayerTime.ForeColor = System.Drawing.Color.Yellow
        Me.TextPlayerTime.Location = New System.Drawing.Point(465, 634)
        Me.TextPlayerTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPlayerTime.Name = "TextPlayerTime"
        Me.TextPlayerTime.Size = New System.Drawing.Size(286, 30)
        Me.TextPlayerTime.TabIndex = 279
        Me.TextPlayerTime.Text = "00:00:00"
        Me.TextPlayerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextPlayerTime.Visible = False
        '
        'TextBoxOBSRecTime
        '
        Me.TextBoxOBSRecTime.BackColor = System.Drawing.Color.Black
        Me.TextBoxOBSRecTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxOBSRecTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOBSRecTime.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxOBSRecTime.Location = New System.Drawing.Point(919, 198)
        Me.TextBoxOBSRecTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxOBSRecTime.Name = "TextBoxOBSRecTime"
        Me.TextBoxOBSRecTime.Size = New System.Drawing.Size(215, 30)
        Me.TextBoxOBSRecTime.TabIndex = 296
        Me.TextBoxOBSRecTime.Text = "..."
        Me.TextBoxOBSRecTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(536, 594)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 22)
        Me.Label23.TabIndex = 297
        Me.Label23.Text = "Clip time left"
        Me.Label23.Visible = False
        '
        'TextBoxPipSrc
        '
        Me.TextBoxPipSrc.BackColor = System.Drawing.Color.Black
        Me.TextBoxPipSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPipSrc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPipSrc.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxPipSrc.Location = New System.Drawing.Point(993, 1076)
        Me.TextBoxPipSrc.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPipSrc.Multiline = True
        Me.TextBoxPipSrc.Name = "TextBoxPipSrc"
        Me.TextBoxPipSrc.Size = New System.Drawing.Size(86, 30)
        Me.TextBoxPipSrc.TabIndex = 302
        Me.TextBoxPipSrc.Text = "Words"
        Me.TextBoxPipSrc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextLeaderName
        '
        Me.TextLeaderName.BackColor = System.Drawing.Color.Black
        Me.TextLeaderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextLeaderName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLeaderName.ForeColor = System.Drawing.Color.Yellow
        Me.TextLeaderName.Location = New System.Drawing.Point(920, 298)
        Me.TextLeaderName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextLeaderName.Name = "TextLeaderName"
        Me.TextLeaderName.Size = New System.Drawing.Size(215, 30)
        Me.TextLeaderName.TabIndex = 308
        Me.TextLeaderName.Text = "..."
        Me.TextLeaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPreacherName
        '
        Me.TextPreacherName.BackColor = System.Drawing.Color.Black
        Me.TextPreacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPreacherName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPreacherName.ForeColor = System.Drawing.Color.Yellow
        Me.TextPreacherName.Location = New System.Drawing.Point(919, 341)
        Me.TextPreacherName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPreacherName.Name = "TextPreacherName"
        Me.TextPreacherName.Size = New System.Drawing.Size(215, 30)
        Me.TextPreacherName.TabIndex = 309
        Me.TextPreacherName.Text = "..."
        Me.TextPreacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCap1
        '
        Me.LabelCap1.AutoSize = True
        Me.LabelCap1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCap1.ForeColor = System.Drawing.Color.Yellow
        Me.LabelCap1.Location = New System.Drawing.Point(853, 303)
        Me.LabelCap1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCap1.Name = "LabelCap1"
        Me.LabelCap1.Size = New System.Drawing.Size(63, 22)
        Me.LabelCap1.TabIndex = 310
        Me.LabelCap1.Text = "Leader*"
        '
        'LabelCap2
        '
        Me.LabelCap2.AutoSize = True
        Me.LabelCap2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCap2.ForeColor = System.Drawing.Color.Yellow
        Me.LabelCap2.Location = New System.Drawing.Point(839, 346)
        Me.LabelCap2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCap2.Name = "LabelCap2"
        Me.LabelCap2.Size = New System.Drawing.Size(72, 22)
        Me.LabelCap2.TabIndex = 311
        Me.LabelCap2.Text = "Preacher"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Yellow
        Me.Label27.Location = New System.Drawing.Point(831, 268)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(94, 22)
        Me.Label27.TabIndex = 312
        Me.Label27.Text = "Caption text"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Yellow
        Me.Label28.Location = New System.Drawing.Point(824, 460)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 22)
        Me.Label28.TabIndex = 313
        Me.Label28.Text = "Media player"
        '
        'ListBoxMedia
        '
        Me.ListBoxMedia.BackColor = System.Drawing.Color.Black
        Me.ListBoxMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxMedia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxMedia.ForeColor = System.Drawing.Color.Yellow
        Me.ListBoxMedia.FormattingEnabled = True
        Me.ListBoxMedia.ItemHeight = 24
        Me.ListBoxMedia.Items.AddRange(New Object() {"..."})
        Me.ListBoxMedia.Location = New System.Drawing.Point(919, 508)
        Me.ListBoxMedia.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxMedia.Name = "ListBoxMedia"
        Me.ListBoxMedia.Size = New System.Drawing.Size(217, 122)
        Me.ListBoxMedia.TabIndex = 314
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(52, 172)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(61, 52)
        Me.Button9.TabIndex = 315
        Me.Button9.Text = "Retry OBS"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'BtnMNext
        '
        Me.BtnMNext.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMNext.Image = CType(resources.GetObject("BtnMNext.Image"), System.Drawing.Image)
        Me.BtnMNext.Location = New System.Drawing.Point(837, 577)
        Me.BtnMNext.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMNext.Name = "BtnMNext"
        Me.BtnMNext.Size = New System.Drawing.Size(67, 62)
        Me.BtnMNext.TabIndex = 307
        Me.BtnMNext.Text = "Next"
        Me.BtnMNext.UseVisualStyleBackColor = True
        '
        'BtnInp5
        '
        Me.BtnInp5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInp5.Image = CType(resources.GetObject("BtnInp5.Image"), System.Drawing.Image)
        Me.BtnInp5.Location = New System.Drawing.Point(752, 1114)
        Me.BtnInp5.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInp5.Name = "BtnInp5"
        Me.BtnInp5.Size = New System.Drawing.Size(100, 92)
        Me.BtnInp5.TabIndex = 306
        Me.BtnInp5.Text = "Stage"
        Me.BtnInp5.UseVisualStyleBackColor = True
        '
        'BtnPip
        '
        Me.BtnPip.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPip.Image = CType(resources.GetObject("BtnPip.Image"), System.Drawing.Image)
        Me.BtnPip.Location = New System.Drawing.Point(985, 1114)
        Me.BtnPip.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPip.Name = "BtnPip"
        Me.BtnPip.Size = New System.Drawing.Size(100, 92)
        Me.BtnPip.TabIndex = 303
        Me.BtnPip.Text = "PiP"
        Me.BtnPip.UseVisualStyleBackColor = True
        '
        'BtnOBSRecord
        '
        Me.BtnOBSRecord.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOBSRecord.Image = CType(resources.GetObject("BtnOBSRecord.Image"), System.Drawing.Image)
        Me.BtnOBSRecord.Location = New System.Drawing.Point(844, 185)
        Me.BtnOBSRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOBSRecord.Name = "BtnOBSRecord"
        Me.BtnOBSRecord.Size = New System.Drawing.Size(67, 62)
        Me.BtnOBSRecord.TabIndex = 295
        Me.BtnOBSRecord.Text = "Rec"
        Me.BtnOBSRecord.UseVisualStyleBackColor = True
        '
        'BtnOBSBroadcast
        '
        Me.BtnOBSBroadcast.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOBSBroadcast.Image = CType(resources.GetObject("BtnOBSBroadcast.Image"), System.Drawing.Image)
        Me.BtnOBSBroadcast.Location = New System.Drawing.Point(844, 110)
        Me.BtnOBSBroadcast.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOBSBroadcast.Name = "BtnOBSBroadcast"
        Me.BtnOBSBroadcast.Size = New System.Drawing.Size(67, 62)
        Me.BtnOBSBroadcast.TabIndex = 294
        Me.BtnOBSBroadcast.Text = "Broad cast"
        Me.BtnOBSBroadcast.UseVisualStyleBackColor = True
        '
        'BtnMPrev
        '
        Me.BtnMPrev.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMPrev.Image = CType(resources.GetObject("BtnMPrev.Image"), System.Drawing.Image)
        Me.BtnMPrev.Location = New System.Drawing.Point(837, 508)
        Me.BtnMPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMPrev.Name = "BtnMPrev"
        Me.BtnMPrev.Size = New System.Drawing.Size(67, 62)
        Me.BtnMPrev.TabIndex = 290
        Me.BtnMPrev.Text = "Prev"
        Me.BtnMPrev.UseVisualStyleBackColor = True
        '
        'BtnLiveSlow
        '
        Me.BtnLiveSlow.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiveSlow.Image = CType(resources.GetObject("BtnLiveSlow.Image"), System.Drawing.Image)
        Me.BtnLiveSlow.Location = New System.Drawing.Point(1277, 622)
        Me.BtnLiveSlow.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLiveSlow.Name = "BtnLiveSlow"
        Me.BtnLiveSlow.Size = New System.Drawing.Size(100, 92)
        Me.BtnLiveSlow.TabIndex = 244
        Me.BtnLiveSlow.Text = "Slow"
        Me.BtnLiveSlow.UseVisualStyleBackColor = True
        '
        'BtnLiveFast
        '
        Me.BtnLiveFast.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiveFast.Image = CType(resources.GetObject("BtnLiveFast.Image"), System.Drawing.Image)
        Me.BtnLiveFast.Location = New System.Drawing.Point(1377, 622)
        Me.BtnLiveFast.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLiveFast.Name = "BtnLiveFast"
        Me.BtnLiveFast.Size = New System.Drawing.Size(100, 92)
        Me.BtnLiveFast.TabIndex = 243
        Me.BtnLiveFast.Text = "Fast"
        Me.BtnLiveFast.UseVisualStyleBackColor = True
        '
        'BtnPreload
        '
        Me.BtnPreload.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreload.Image = CType(resources.GetObject("BtnPreload.Image"), System.Drawing.Image)
        Me.BtnPreload.Location = New System.Drawing.Point(1575, 721)
        Me.BtnPreload.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreload.Name = "BtnPreload"
        Me.BtnPreload.Size = New System.Drawing.Size(100, 92)
        Me.BtnPreload.TabIndex = 240
        Me.BtnPreload.Text = "Pre load"
        Me.BtnPreload.UseVisualStyleBackColor = True
        '
        'BtnLivePTZ
        '
        Me.BtnLivePTZ.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLivePTZ.Image = CType(resources.GetObject("BtnLivePTZ.Image"), System.Drawing.Image)
        Me.BtnLivePTZ.Location = New System.Drawing.Point(1377, 721)
        Me.BtnLivePTZ.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLivePTZ.Name = "BtnLivePTZ"
        Me.BtnLivePTZ.Size = New System.Drawing.Size(100, 92)
        Me.BtnLivePTZ.TabIndex = 237
        Me.BtnLivePTZ.Text = "Joystick live"
        Me.BtnLivePTZ.UseVisualStyleBackColor = True
        '
        'BtnLive
        '
        Me.BtnLive.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLive.Image = CType(resources.GetObject("BtnLive.Image"), System.Drawing.Image)
        Me.BtnLive.Location = New System.Drawing.Point(1477, 721)
        Me.BtnLive.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLive.Name = "BtnLive"
        Me.BtnLive.Size = New System.Drawing.Size(100, 92)
        Me.BtnLive.TabIndex = 236
        Me.BtnLive.Text = "Move  now"
        Me.BtnLive.UseVisualStyleBackColor = True
        '
        'MyButtonCamDR
        '
        Me.MyButtonCamDR.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamDR.Image = CType(resources.GetObject("MyButtonCamDR.Image"), System.Drawing.Image)
        Me.MyButtonCamDR.Location = New System.Drawing.Point(271, 234)
        Me.MyButtonCamDR.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamDR.Name = "MyButtonCamDR"
        Me.MyButtonCamDR.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamDR.TabIndex = 223
        Me.MyButtonCamDR.Text = ""
        Me.MyButtonCamDR.UseVisualStyleBackColor = True
        '
        'MyButtonCamD
        '
        Me.MyButtonCamD.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamD.Image = CType(resources.GetObject("MyButtonCamD.Image"), System.Drawing.Image)
        Me.MyButtonCamD.Location = New System.Drawing.Point(216, 234)
        Me.MyButtonCamD.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamD.Name = "MyButtonCamD"
        Me.MyButtonCamD.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamD.TabIndex = 222
        Me.MyButtonCamD.Text = ""
        Me.MyButtonCamD.UseVisualStyleBackColor = True
        '
        'MyButtonCamDL
        '
        Me.MyButtonCamDL.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamDL.Image = CType(resources.GetObject("MyButtonCamDL.Image"), System.Drawing.Image)
        Me.MyButtonCamDL.Location = New System.Drawing.Point(160, 234)
        Me.MyButtonCamDL.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamDL.Name = "MyButtonCamDL"
        Me.MyButtonCamDL.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamDL.TabIndex = 221
        Me.MyButtonCamDL.Text = ""
        Me.MyButtonCamDL.UseVisualStyleBackColor = True
        '
        'MyButtonCamR
        '
        Me.MyButtonCamR.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamR.Image = CType(resources.GetObject("MyButtonCamR.Image"), System.Drawing.Image)
        Me.MyButtonCamR.Location = New System.Drawing.Point(271, 177)
        Me.MyButtonCamR.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamR.Name = "MyButtonCamR"
        Me.MyButtonCamR.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamR.TabIndex = 220
        Me.MyButtonCamR.Text = ""
        Me.MyButtonCamR.UseVisualStyleBackColor = True
        '
        'MyButtonCamL
        '
        Me.MyButtonCamL.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamL.Image = CType(resources.GetObject("MyButtonCamL.Image"), System.Drawing.Image)
        Me.MyButtonCamL.Location = New System.Drawing.Point(160, 177)
        Me.MyButtonCamL.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamL.Name = "MyButtonCamL"
        Me.MyButtonCamL.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamL.TabIndex = 219
        Me.MyButtonCamL.Text = ""
        Me.MyButtonCamL.UseVisualStyleBackColor = True
        '
        'MyButtonCamUR
        '
        Me.MyButtonCamUR.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamUR.Image = CType(resources.GetObject("MyButtonCamUR.Image"), System.Drawing.Image)
        Me.MyButtonCamUR.Location = New System.Drawing.Point(271, 123)
        Me.MyButtonCamUR.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamUR.Name = "MyButtonCamUR"
        Me.MyButtonCamUR.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamUR.TabIndex = 218
        Me.MyButtonCamUR.Text = ""
        Me.MyButtonCamUR.UseVisualStyleBackColor = True
        '
        'MyButtonCamU
        '
        Me.MyButtonCamU.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamU.Image = CType(resources.GetObject("MyButtonCamU.Image"), System.Drawing.Image)
        Me.MyButtonCamU.Location = New System.Drawing.Point(216, 123)
        Me.MyButtonCamU.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamU.Name = "MyButtonCamU"
        Me.MyButtonCamU.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamU.TabIndex = 217
        Me.MyButtonCamU.Text = ""
        Me.MyButtonCamU.UseVisualStyleBackColor = True
        '
        'MyButtonCamUL
        '
        Me.MyButtonCamUL.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MyButtonCamUL.Image = CType(resources.GetObject("MyButtonCamUL.Image"), System.Drawing.Image)
        Me.MyButtonCamUL.Location = New System.Drawing.Point(160, 123)
        Me.MyButtonCamUL.Margin = New System.Windows.Forms.Padding(4)
        Me.MyButtonCamUL.Name = "MyButtonCamUL"
        Me.MyButtonCamUL.Size = New System.Drawing.Size(53, 49)
        Me.MyButtonCamUL.TabIndex = 216
        Me.MyButtonCamUL.Text = ""
        Me.MyButtonCamUL.UseVisualStyleBackColor = True
        '
        'BtnAELock
        '
        Me.BtnAELock.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAELock.Image = CType(resources.GetObject("BtnAELock.Image"), System.Drawing.Image)
        Me.BtnAELock.Location = New System.Drawing.Point(498, 244)
        Me.BtnAELock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAELock.Name = "BtnAELock"
        Me.BtnAELock.Size = New System.Drawing.Size(67, 62)
        Me.BtnAELock.TabIndex = 211
        Me.BtnAELock.Text = "  AE  Lock"
        Me.BtnAELock.UseVisualStyleBackColor = True
        '
        'BtnFocus
        '
        Me.BtnFocus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFocus.Image = CType(resources.GetObject("BtnFocus.Image"), System.Drawing.Image)
        Me.BtnFocus.Location = New System.Drawing.Point(431, 244)
        Me.BtnFocus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFocus.Name = "BtnFocus"
        Me.BtnFocus.Size = New System.Drawing.Size(67, 62)
        Me.BtnFocus.TabIndex = 210
        Me.BtnFocus.Text = "Focus Lock"
        Me.BtnFocus.UseVisualStyleBackColor = True
        '
        'BtnSlowOut
        '
        Me.BtnSlowOut.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSlowOut.Image = CType(resources.GetObject("BtnSlowOut.Image"), System.Drawing.Image)
        Me.BtnSlowOut.Location = New System.Drawing.Point(1575, 622)
        Me.BtnSlowOut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSlowOut.Name = "BtnSlowOut"
        Me.BtnSlowOut.Size = New System.Drawing.Size(100, 92)
        Me.BtnSlowOut.TabIndex = 154
        Me.BtnSlowOut.Text = "Zoom out"
        Me.BtnSlowOut.UseVisualStyleBackColor = True
        '
        'BtnSlowIn
        '
        Me.BtnSlowIn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSlowIn.Image = CType(resources.GetObject("BtnSlowIn.Image"), System.Drawing.Image)
        Me.BtnSlowIn.Location = New System.Drawing.Point(1477, 622)
        Me.BtnSlowIn.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSlowIn.Name = "BtnSlowIn"
        Me.BtnSlowIn.Size = New System.Drawing.Size(100, 92)
        Me.BtnSlowIn.TabIndex = 153
        Me.BtnSlowIn.Text = "Zoom in"
        Me.BtnSlowIn.UseVisualStyleBackColor = True
        '
        'BtnPreset4
        '
        Me.BtnPreset4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreset4.Image = CType(resources.GetObject("BtnPreset4.Image"), System.Drawing.Image)
        Me.BtnPreset4.Location = New System.Drawing.Point(1577, 103)
        Me.BtnPreset4.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreset4.Name = "BtnPreset4"
        Me.BtnPreset4.Size = New System.Drawing.Size(100, 92)
        Me.BtnPreset4.TabIndex = 159
        Me.BtnPreset4.Text = "4"
        Me.BtnPreset4.UseVisualStyleBackColor = True
        '
        'BtnPreset3
        '
        Me.BtnPreset3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreset3.Image = CType(resources.GetObject("BtnPreset3.Image"), System.Drawing.Image)
        Me.BtnPreset3.Location = New System.Drawing.Point(1477, 103)
        Me.BtnPreset3.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreset3.Name = "BtnPreset3"
        Me.BtnPreset3.Size = New System.Drawing.Size(100, 92)
        Me.BtnPreset3.TabIndex = 158
        Me.BtnPreset3.Text = "3"
        Me.BtnPreset3.UseVisualStyleBackColor = True
        '
        'BtnPreset2
        '
        Me.BtnPreset2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreset2.Image = CType(resources.GetObject("BtnPreset2.Image"), System.Drawing.Image)
        Me.BtnPreset2.Location = New System.Drawing.Point(1377, 103)
        Me.BtnPreset2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreset2.Name = "BtnPreset2"
        Me.BtnPreset2.Size = New System.Drawing.Size(100, 92)
        Me.BtnPreset2.TabIndex = 157
        Me.BtnPreset2.Text = "2"
        Me.BtnPreset2.UseVisualStyleBackColor = True
        '
        'BtnPreset1
        '
        Me.BtnPreset1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreset1.Image = CType(resources.GetObject("BtnPreset1.Image"), System.Drawing.Image)
        Me.BtnPreset1.Location = New System.Drawing.Point(1277, 103)
        Me.BtnPreset1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreset1.Name = "BtnPreset1"
        Me.BtnPreset1.Size = New System.Drawing.Size(100, 92)
        Me.BtnPreset1.TabIndex = 156
        Me.BtnPreset1.Text = "1"
        Me.BtnPreset1.UseVisualStyleBackColor = True
        '
        'BtnMediaNxt
        '
        Me.BtnMediaNxt.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BtnMediaNxt.Location = New System.Drawing.Point(1620, 1065)
        Me.BtnMediaNxt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMediaNxt.Name = "BtnMediaNxt"
        Me.BtnMediaNxt.Size = New System.Drawing.Size(47, 43)
        Me.BtnMediaNxt.TabIndex = 154
        Me.BtnMediaNxt.Text = "u"
        Me.BtnMediaNxt.UseVisualStyleBackColor = True
        '
        'BtnMediaOverlay
        '
        Me.BtnMediaOverlay.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMediaOverlay.Image = CType(resources.GetObject("BtnMediaOverlay.Image"), System.Drawing.Image)
        Me.BtnMediaOverlay.Location = New System.Drawing.Point(1567, 1114)
        Me.BtnMediaOverlay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMediaOverlay.Name = "BtnMediaOverlay"
        Me.BtnMediaOverlay.Size = New System.Drawing.Size(100, 92)
        Me.BtnMediaOverlay.TabIndex = 153
        Me.BtnMediaOverlay.Text = "Caption overlay"
        Me.BtnMediaOverlay.UseVisualStyleBackColor = True
        '
        'BtnOverlay
        '
        Me.BtnOverlay.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOverlay.Image = CType(resources.GetObject("BtnOverlay.Image"), System.Drawing.Image)
        Me.BtnOverlay.Location = New System.Drawing.Point(1464, 1114)
        Me.BtnOverlay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOverlay.Name = "BtnOverlay"
        Me.BtnOverlay.Size = New System.Drawing.Size(100, 92)
        Me.BtnOverlay.TabIndex = 152
        Me.BtnOverlay.Text = "Words overlay"
        Me.BtnOverlay.UseVisualStyleBackColor = True
        '
        'BtnTransition
        '
        Me.BtnTransition.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransition.Image = CType(resources.GetObject("BtnTransition.Image"), System.Drawing.Image)
        Me.BtnTransition.Location = New System.Drawing.Point(1261, 1114)
        Me.BtnTransition.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransition.Name = "BtnTransition"
        Me.BtnTransition.Size = New System.Drawing.Size(120, 92)
        Me.BtnTransition.TabIndex = 151
        Me.BtnTransition.Text = "Fade"
        Me.BtnTransition.UseVisualStyleBackColor = True
        '
        'BtnCut
        '
        Me.BtnCut.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCut.Image = CType(resources.GetObject("BtnCut.Image"), System.Drawing.Image)
        Me.BtnCut.Location = New System.Drawing.Point(1133, 1114)
        Me.BtnCut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCut.Name = "BtnCut"
        Me.BtnCut.Size = New System.Drawing.Size(120, 92)
        Me.BtnCut.TabIndex = 150
        Me.BtnCut.Text = "Cut"
        Me.BtnCut.UseVisualStyleBackColor = True
        '
        'BtnMediaPrev
        '
        Me.BtnMediaPrev.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BtnMediaPrev.Location = New System.Drawing.Point(1572, 1065)
        Me.BtnMediaPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMediaPrev.Name = "BtnMediaPrev"
        Me.BtnMediaPrev.Size = New System.Drawing.Size(47, 43)
        Me.BtnMediaPrev.TabIndex = 149
        Me.BtnMediaPrev.Text = "t"
        Me.BtnMediaPrev.UseVisualStyleBackColor = True
        '
        'BtnInp4
        '
        Me.BtnInp4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInp4.Image = CType(resources.GetObject("BtnInp4.Image"), System.Drawing.Image)
        Me.BtnInp4.Location = New System.Drawing.Point(652, 1114)
        Me.BtnInp4.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInp4.Name = "BtnInp4"
        Me.BtnInp4.Size = New System.Drawing.Size(100, 92)
        Me.BtnInp4.TabIndex = 148
        Me.BtnInp4.Text = "Media Player"
        Me.BtnInp4.UseVisualStyleBackColor = True
        '
        'BtnInp3
        '
        Me.BtnInp3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInp3.Image = CType(resources.GetObject("BtnInp3.Image"), System.Drawing.Image)
        Me.BtnInp3.Location = New System.Drawing.Point(452, 1114)
        Me.BtnInp3.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInp3.Name = "BtnInp3"
        Me.BtnInp3.Size = New System.Drawing.Size(100, 92)
        Me.BtnInp3.TabIndex = 147
        Me.BtnInp3.Text = "CAM5"
        Me.BtnInp3.UseVisualStyleBackColor = True
        '
        'BtnInp2
        '
        Me.BtnInp2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInp2.Image = CType(resources.GetObject("BtnInp2.Image"), System.Drawing.Image)
        Me.BtnInp2.Location = New System.Drawing.Point(552, 1114)
        Me.BtnInp2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInp2.Name = "BtnInp2"
        Me.BtnInp2.Size = New System.Drawing.Size(100, 92)
        Me.BtnInp2.TabIndex = 146
        Me.BtnInp2.Text = "Words"
        Me.BtnInp2.UseVisualStyleBackColor = True
        '
        'BtnInp1
        '
        Me.BtnInp1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInp1.Image = CType(resources.GetObject("BtnInp1.Image"), System.Drawing.Image)
        Me.BtnInp1.Location = New System.Drawing.Point(849, 1114)
        Me.BtnInp1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInp1.Name = "BtnInp1"
        Me.BtnInp1.Size = New System.Drawing.Size(100, 92)
        Me.BtnInp1.TabIndex = 145
        Me.BtnInp1.Text = "Black"
        Me.BtnInp1.UseVisualStyleBackColor = True
        '
        'BtnCam4
        '
        Me.BtnCam4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCam4.Image = CType(resources.GetObject("BtnCam4.Image"), System.Drawing.Image)
        Me.BtnCam4.Location = New System.Drawing.Point(352, 1114)
        Me.BtnCam4.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCam4.Name = "BtnCam4"
        Me.BtnCam4.Size = New System.Drawing.Size(100, 92)
        Me.BtnCam4.TabIndex = 144
        Me.BtnCam4.Text = "CAM4"
        Me.BtnCam4.UseVisualStyleBackColor = True
        '
        'BtnCam3
        '
        Me.BtnCam3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCam3.Image = CType(resources.GetObject("BtnCam3.Image"), System.Drawing.Image)
        Me.BtnCam3.Location = New System.Drawing.Point(252, 1114)
        Me.BtnCam3.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCam3.Name = "BtnCam3"
        Me.BtnCam3.Size = New System.Drawing.Size(100, 92)
        Me.BtnCam3.TabIndex = 143
        Me.BtnCam3.Text = "CAM3"
        Me.BtnCam3.UseVisualStyleBackColor = True
        '
        'BtnCam2
        '
        Me.BtnCam2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCam2.Image = CType(resources.GetObject("BtnCam2.Image"), System.Drawing.Image)
        Me.BtnCam2.Location = New System.Drawing.Point(152, 1114)
        Me.BtnCam2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCam2.Name = "BtnCam2"
        Me.BtnCam2.Size = New System.Drawing.Size(100, 92)
        Me.BtnCam2.TabIndex = 142
        Me.BtnCam2.Text = "CAM2"
        Me.BtnCam2.UseVisualStyleBackColor = True
        '
        'BtnCam1
        '
        Me.BtnCam1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCam1.Image = CType(resources.GetObject("BtnCam1.Image"), System.Drawing.Image)
        Me.BtnCam1.Location = New System.Drawing.Point(52, 1114)
        Me.BtnCam1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCam1.Name = "BtnCam1"
        Me.BtnCam1.Size = New System.Drawing.Size(100, 92)
        Me.BtnCam1.TabIndex = 141
        Me.BtnCam1.Text = "CAM1"
        Me.BtnCam1.UseVisualStyleBackColor = True
        '
        'OverrideBtn
        '
        Me.OverrideBtn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverrideBtn.Image = CType(resources.GetObject("OverrideBtn.Image"), System.Drawing.Image)
        Me.OverrideBtn.Location = New System.Drawing.Point(280, 295)
        Me.OverrideBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.OverrideBtn.Name = "OverrideBtn"
        Me.OverrideBtn.Size = New System.Drawing.Size(53, 49)
        Me.OverrideBtn.TabIndex = 238
        Me.OverrideBtn.Text = "Over ride"
        Me.OverrideBtn.UseVisualStyleBackColor = True
        '
        'LabelCap3
        '
        Me.LabelCap3.AutoSize = True
        Me.LabelCap3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCap3.ForeColor = System.Drawing.Color.Yellow
        Me.LabelCap3.Location = New System.Drawing.Point(855, 392)
        Me.LabelCap3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCap3.Name = "LabelCap3"
        Me.LabelCap3.Size = New System.Drawing.Size(49, 22)
        Me.LabelCap3.TabIndex = 317
        Me.LabelCap3.Text = "Other"
        '
        'TextCaptionOther
        '
        Me.TextCaptionOther.BackColor = System.Drawing.Color.Black
        Me.TextCaptionOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCaptionOther.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCaptionOther.ForeColor = System.Drawing.Color.Yellow
        Me.TextCaptionOther.Location = New System.Drawing.Point(920, 386)
        Me.TextCaptionOther.Margin = New System.Windows.Forms.Padding(4)
        Me.TextCaptionOther.Name = "TextCaptionOther"
        Me.TextCaptionOther.Size = New System.Drawing.Size(215, 30)
        Me.TextCaptionOther.TabIndex = 316
        Me.TextCaptionOther.Text = "..."
        Me.TextCaptionOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1707, 1102)
        Me.Controls.Add(Me.LabelCap3)
        Me.Controls.Add(Me.TextCaptionOther)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ListBoxMedia)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.LabelCap2)
        Me.Controls.Add(Me.LabelCap1)
        Me.Controls.Add(Me.TextPreacherName)
        Me.Controls.Add(Me.TextLeaderName)
        Me.Controls.Add(Me.BtnMNext)
        Me.Controls.Add(Me.BtnInp5)
        Me.Controls.Add(Me.BtnPip)
        Me.Controls.Add(Me.TextBoxPipSrc)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBoxOBSRecTime)
        Me.Controls.Add(Me.BtnOBSRecord)
        Me.Controls.Add(Me.BtnOBSBroadcast)
        Me.Controls.Add(Me.BtnMPrev)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextPlayerTime)
        Me.Controls.Add(Me.TextBoxOBSBroadcastTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelProfile)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnLiveSlow)
        Me.Controls.Add(Me.BtnLiveFast)
        Me.Controls.Add(Me.BtnPreload)
        Me.Controls.Add(Me.BtnLivePTZ)
        Me.Controls.Add(Me.BtnLive)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MyButtonCamDR)
        Me.Controls.Add(Me.MyButtonCamD)
        Me.Controls.Add(Me.MyButtonCamDL)
        Me.Controls.Add(Me.MyButtonCamR)
        Me.Controls.Add(Me.MyButtonCamL)
        Me.Controls.Add(Me.MyButtonCamUR)
        Me.Controls.Add(Me.MyButtonCamU)
        Me.Controls.Add(Me.MyButtonCamUL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAELock)
        Me.Controls.Add(Me.BtnFocus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnSlowOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSlowIn)
        Me.Controls.Add(Me.ButtonSetup)
        Me.Controls.Add(Me.BtnPreset4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnPreset3)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnPreset2)
        Me.Controls.Add(Me.BtnPreset1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnMediaNxt)
        Me.Controls.Add(Me.BtnPresetSave)
        Me.Controls.Add(Me.BtnMediaOverlay)
        Me.Controls.Add(Me.BtnOverlay)
        Me.Controls.Add(Me.BtnTransition)
        Me.Controls.Add(Me.BtnCut)
        Me.Controls.Add(Me.BtnMediaPrev)
        Me.Controls.Add(Me.BtnInp4)
        Me.Controls.Add(Me.BtnInp3)
        Me.Controls.Add(Me.BtnInp2)
        Me.Controls.Add(Me.BtnInp1)
        Me.Controls.Add(Me.BtnCam4)
        Me.Controls.Add(Me.BtnCam3)
        Me.Controls.Add(Me.BtnCam2)
        Me.Controls.Add(Me.BtnCam1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.chkLogMessages)
        Me.Controls.Add(Me.mLog)
        Me.Controls.Add(Me.bConnect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eVISMacrosAppHost)
        Me.Controls.Add(Me.OverrideBtn)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "AtemController"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents eVISMacrosAppHost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bConnect As System.Windows.Forms.Button
    Friend WithEvents mLog As System.Windows.Forms.TextBox
    Friend WithEvents chkLogMessages As System.Windows.Forms.CheckBox
    Friend WithEvents BtnPresetSave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtnCam1 As AtemController.MyButton
    Friend WithEvents BtnCam2 As AtemController.MyButton
    Friend WithEvents BtnCam3 As AtemController.MyButton
    Friend WithEvents BtnCam4 As AtemController.MyButton
    Friend WithEvents BtnInp1 As AtemController.MyButton
    Friend WithEvents BtnInp2 As AtemController.MyButton
    Friend WithEvents BtnInp3 As AtemController.MyButton
    Friend WithEvents BtnInp4 As AtemController.MyButton
    Friend WithEvents BtnMediaPrev As AtemController.MyButton
    Friend WithEvents BtnCut As AtemController.MyButton
    Friend WithEvents BtnTransition As AtemController.MyButton
    Friend WithEvents BtnOverlay As AtemController.MyButton
    Friend WithEvents BtnMediaOverlay As AtemController.MyButton
    Friend WithEvents BtnMediaNxt As AtemController.MyButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents BtnPreset1 As AtemController.MyButton
    Friend WithEvents BtnPreset4 As AtemController.MyButton
    Friend WithEvents BtnPreset3 As AtemController.MyButton
    Friend WithEvents BtnPreset2 As AtemController.MyButton
    Friend WithEvents ButtonSetup As System.Windows.Forms.Button
    Friend WithEvents BtnSlowIn As AtemController.MyButton
    Friend WithEvents BtnSlowOut As AtemController.MyButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnFocus As AtemController.MyButton
    Friend WithEvents BtnAELock As AtemController.MyButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MyButtonCamDR As AtemController.MyButton
    Friend WithEvents MyButtonCamD As AtemController.MyButton
    Friend WithEvents MyButtonCamDL As AtemController.MyButton
    Friend WithEvents MyButtonCamR As AtemController.MyButton
    Friend WithEvents MyButtonCamL As AtemController.MyButton
    Friend WithEvents MyButtonCamUR As AtemController.MyButton
    Friend WithEvents MyButtonCamU As AtemController.MyButton
    Friend WithEvents MyButtonCamUL As AtemController.MyButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents BtnLive As AtemController.MyButton
    Friend WithEvents BtnLivePTZ As AtemController.MyButton
    Friend WithEvents BtnPreload As AtemController.MyButton
    Friend WithEvents BtnLiveSlow As AtemController.MyButton
    Friend WithEvents BtnLiveFast As AtemController.MyButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LabelProfile As System.Windows.Forms.Label
    Friend WithEvents OverrideBtn As AtemController.MyButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOBSBroadcastTime As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextPlayerTime As System.Windows.Forms.TextBox
    Friend WithEvents BtnMPrev As AtemController.MyButton
    Friend WithEvents BtnOBSBroadcast As AtemController.MyButton
    Friend WithEvents BtnOBSRecord As AtemController.MyButton
    Friend WithEvents TextBoxOBSRecTime As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BtnPip As AtemController.MyButton
    Friend WithEvents TextBoxPipSrc As System.Windows.Forms.TextBox
    Friend WithEvents BtnInp5 As AtemController.MyButton
    Friend WithEvents BtnMNext As AtemController.MyButton
    Friend WithEvents TextLeaderName As System.Windows.Forms.TextBox
    Friend WithEvents TextPreacherName As System.Windows.Forms.TextBox
    Friend WithEvents LabelCap1 As System.Windows.Forms.Label
    Friend WithEvents LabelCap2 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ListBoxMedia As System.Windows.Forms.ListBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LabelCap3 As System.Windows.Forms.Label
    Friend WithEvents TextCaptionOther As System.Windows.Forms.TextBox

End Class
