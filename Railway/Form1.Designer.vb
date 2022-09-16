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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ReservationDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTstartNo = New System.Windows.Forms.TextBox()
        Me.txtClassType = New System.Windows.Forms.ComboBox()
        Me.txtStationTo = New System.Windows.Forms.ComboBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtStationFrom = New System.Windows.Forms.ComboBox()
        Me.txtTrainName = New System.Windows.Forms.ComboBox()
        Me.txtTrainNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNoOfSeats = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtChild = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAdult = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtAmountPait = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.ReservationDate)
        Me.GroupBox1.Controls.Add(Me.txtTstartNo)
        Me.GroupBox1.Controls.Add(Me.txtClassType)
        Me.GroupBox1.Controls.Add(Me.txtStationTo)
        Me.GroupBox1.Controls.Add(Me.txtDistance)
        Me.GroupBox1.Controls.Add(Me.txtStationFrom)
        Me.GroupBox1.Controls.Add(Me.txtTrainName)
        Me.GroupBox1.Controls.Add(Me.txtTrainNo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(10, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservation info"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Location = New System.Drawing.Point(145, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(297, 28)
        Me.DateTimePicker2.TabIndex = 18
        Me.DateTimePicker2.Value = New Date(2021, 5, 9, 0, 16, 46, 0)
        '
        'ReservationDate
        '
        Me.ReservationDate.CustomFormat = ""
        Me.ReservationDate.Location = New System.Drawing.Point(703, 37)
        Me.ReservationDate.Name = "ReservationDate"
        Me.ReservationDate.Size = New System.Drawing.Size(297, 28)
        Me.ReservationDate.TabIndex = 17
        Me.ReservationDate.Value = New Date(2021, 5, 9, 0, 16, 46, 0)
        '
        'txtTstartNo
        '
        Me.txtTstartNo.Location = New System.Drawing.Point(703, 110)
        Me.txtTstartNo.Name = "txtTstartNo"
        Me.txtTstartNo.Size = New System.Drawing.Size(181, 28)
        Me.txtTstartNo.TabIndex = 16
        '
        'txtClassType
        '
        Me.txtClassType.FormattingEnabled = True
        Me.txtClassType.Items.AddRange(New Object() {"1st Class", "2nd Class", "3rd Class"})
        Me.txtClassType.Location = New System.Drawing.Point(703, 72)
        Me.txtClassType.Name = "txtClassType"
        Me.txtClassType.Size = New System.Drawing.Size(202, 28)
        Me.txtClassType.TabIndex = 14
        '
        'txtStationTo
        '
        Me.txtStationTo.FormattingEnabled = True
        Me.txtStationTo.Items.AddRange(New Object() {"Batticaloa", "Polonnaruwa", "Gal-Oya", "Maaho"})
        Me.txtStationTo.Location = New System.Drawing.Point(703, 149)
        Me.txtStationTo.Name = "txtStationTo"
        Me.txtStationTo.Size = New System.Drawing.Size(202, 28)
        Me.txtStationTo.TabIndex = 13
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(145, 188)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.ReadOnly = True
        Me.txtDistance.Size = New System.Drawing.Size(181, 28)
        Me.txtDistance.TabIndex = 12
        '
        'txtStationFrom
        '
        Me.txtStationFrom.FormattingEnabled = True
        Me.txtStationFrom.Items.AddRange(New Object() {"Colombo"})
        Me.txtStationFrom.Location = New System.Drawing.Point(145, 149)
        Me.txtStationFrom.Name = "txtStationFrom"
        Me.txtStationFrom.Size = New System.Drawing.Size(202, 28)
        Me.txtStationFrom.TabIndex = 11
        '
        'txtTrainName
        '
        Me.txtTrainName.FormattingEnabled = True
        Me.txtTrainName.Items.AddRange(New Object() {"Night Mail"})
        Me.txtTrainName.Location = New System.Drawing.Point(145, 110)
        Me.txtTrainName.Name = "txtTrainName"
        Me.txtTrainName.Size = New System.Drawing.Size(202, 28)
        Me.txtTrainName.TabIndex = 10
        '
        'txtTrainNo
        '
        Me.txtTrainNo.Location = New System.Drawing.Point(145, 73)
        Me.txtTrainNo.Name = "txtTrainNo"
        Me.txtTrainNo.Size = New System.Drawing.Size(181, 28)
        Me.txtTrainNo.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(546, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Station To :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(546, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ticket Start No :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(546, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Class Type :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(546, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Reservation Date : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Distance :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Station From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Train Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Train No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Date : "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox2.Controls.Add(Me.txtNoOfSeats)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtChild)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtAdult)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox2.Location = New System.Drawing.Point(13, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 178)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Passenger info."
        '
        'txtNoOfSeats
        '
        Me.txtNoOfSeats.Location = New System.Drawing.Point(142, 129)
        Me.txtNoOfSeats.Name = "txtNoOfSeats"
        Me.txtNoOfSeats.ReadOnly = True
        Me.txtNoOfSeats.Size = New System.Drawing.Size(44, 28)
        Me.txtNoOfSeats.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "No of Seats"
        '
        'txtChild
        '
        Me.txtChild.FormattingEnabled = True
        Me.txtChild.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.txtChild.Location = New System.Drawing.Point(142, 75)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(72, 28)
        Me.txtChild.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Child :"
        '
        'txtAdult
        '
        Me.txtAdult.FormattingEnabled = True
        Me.txtAdult.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.txtAdult.Location = New System.Drawing.Point(142, 35)
        Me.txtAdult.Name = "txtAdult"
        Me.txtAdult.Size = New System.Drawing.Size(72, 28)
        Me.txtAdult.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Adult :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox3.Controls.Add(Me.txtBalance)
        Me.GroupBox3.Controls.Add(Me.txtAmountPait)
        Me.GroupBox3.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(434, 347)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 178)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Amound Detail"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(184, 124)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(102, 28)
        Me.txtBalance.TabIndex = 26
        Me.txtBalance.Text = "0"
        '
        'txtAmountPait
        '
        Me.txtAmountPait.Location = New System.Drawing.Point(184, 75)
        Me.txtAmountPait.Name = "txtAmountPait"
        Me.txtAmountPait.Size = New System.Drawing.Size(102, 28)
        Me.txtAmountPait.TabIndex = 25
        Me.txtAmountPait.Text = "0"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(184, 35)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(102, 28)
        Me.txtTotalAmount.TabIndex = 22
        Me.txtTotalAmount.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(133, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 20)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Rs"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(133, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 20)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Rs"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(133, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Rs"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Balance :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 20)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Amount Pait :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 20)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Total Amount :"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCheck.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(824, 392)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(145, 31)
        Me.btnCheck.TabIndex = 23
        Me.btnCheck.Text = "CHECK"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(824, 438)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(145, 31)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "CALCULATE "
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(824, 483)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 31)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(469, 32)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "RAILWAY RESERVATION SYSTEM"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(293, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(489, 44)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.btnClear)
        Me.GroupBox5.Controls.Add(Me.btnCalculate)
        Me.GroupBox5.Controls.Add(Me.btnCheck)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1050, 533)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1065, 550)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTstartNo As TextBox
    Friend WithEvents txtClassType As ComboBox
    Friend WithEvents txtStationTo As ComboBox
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents txtStationFrom As ComboBox
    Friend WithEvents txtTrainName As ComboBox
    Friend WithEvents txtTrainNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNoOfSeats As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtChild As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAdult As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtAmountPait As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents ReservationDate As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
End Class
