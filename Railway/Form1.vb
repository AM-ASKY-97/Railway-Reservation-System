Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim Adult = 0, Child = 0, NoSeats = 0, AdultA = 0, ChildA = 0, AmountPait = 0, TotalAmount = 0, Balance = 0, TStartNo As Integer

            Adult = txtAdult.Text
            Child = txtChild.Text
            AmountPait = txtAmountPait.Text
            TStartNo = txtTstartNo.Text

            NoSeats = Adult + Child

            txtNoOfSeats.Text = NoSeats

            If txtStationTo.Text = "Batticaloa" Then
                txtDistance.Text = 349.7

            ElseIf txtStationTo.Text = "Polonnaruwa" Then
                txtDistance.Text = 259.7

            ElseIf txtStationTo.Text = "Gal-Oya" Then
                txtDistance.Text = 226.7

            ElseIf txtStationTo.Text = "Maaho" Then
                txtDistance.Text = 140.8

            Else
                txtDistance.Text = 0
            End If

            If txtClassType.Text = "1st Class" Then
                AdultA = 840
                ChildA = 800
                TotalAmount = ((Adult * AdultA) + (Child * ChildA))
            ElseIf txtClassType.Text = "2nd Class" Then
                AdultA = 500
                ChildA = 440
                TotalAmount = ((Adult * AdultA) + (Child * ChildA))
            ElseIf txtClassType.Text = "3rd Class" Then
                AdultA = 310
                ChildA = 270
                TotalAmount = ((Adult * AdultA) + (Child * ChildA))
            End If

            txtTotalAmount.Text = TotalAmount
            Balance = AmountPait - TotalAmount
            txtBalance.Text = Balance

            MessageBox.Show("Book seat Nos :  " & TStartNo & " to " & TStartNo + NoSeats & " on " & Now, "Passenger Details")

        Catch ex As Exception
            MsgBox("Fill The All TextBoxes", MsgBoxStyle.Critical, "Alert Message")
        End Try


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtStationFrom.SelectedIndexChanged

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If String.IsNullOrEmpty(txtTrainNo.Text.Trim()) Then
            txtTrainNo.BackColor = Color.Blue
        Else
            txtTrainNo.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtTrainName.Text.Trim()) Then
            txtTrainName.BackColor = Color.Blue
        Else
            txtTrainName.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtStationFrom.Text.Trim()) Then
            txtStationFrom.BackColor = Color.Blue
        Else
            txtStationFrom.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtDistance.Text.Trim()) Then
            txtDistance.BackColor = Color.Blue
        Else
            txtDistance.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtClassType.Text.Trim()) Then
            txtClassType.BackColor = Color.Blue
        Else
            txtClassType.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtTstartNo.Text.Trim()) Then
            txtTstartNo.BackColor = Color.Blue
        Else
            txtTstartNo.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtStationTo.Text.Trim()) Then
            txtStationTo.BackColor = Color.Blue
        Else
            txtStationTo.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtAdult.Text.Trim()) Then
            txtAdult.BackColor = Color.Blue
        Else
            txtAdult.BackColor = Color.White
        End If

        If String.IsNullOrEmpty(txtChild.Text.Trim()) Then
            txtChild.BackColor = Color.Blue
        Else
            txtChild.BackColor = Color.White
            MsgBox("Successfully Check", MsgBoxStyle.Information, "Check")
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTrainNo.Text = ""
        txtTrainName.Text = ""
        txtStationFrom.Text = ""
        txtDistance.Text = ""
        txtClassType.Text = ""
        txtTstartNo.Text = ""
        txtStationTo.Text = ""
        txtAdult.Text = ""
        txtChild.Text = ""
        txtTotalAmount.Text = ""
        txtAmountPait.Text = ""
        txtBalance.Text = ""
        txtNoOfSeats.Text = ""

        txtTotalAmount.Text = 0
        txtAmountPait.Text = 0
        txtBalance.Text = 0

        MsgBox("Successfully Clear", MsgBoxStyle.Information, "Clear")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class
