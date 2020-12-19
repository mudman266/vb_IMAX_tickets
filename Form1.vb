Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show the splash screen for ~4 seconds.
        Threading.Thread.Sleep(4000)
    End Sub

    Private Sub cmbTicketType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTicketType.SelectedValueChanged
        ' When a selection is made in the combobox, make the other fields visible
        lblNumTickets.Visible = True
        txtNumTickets.Visible = True
        btnCalculatePrice.Visible = True
        lblPrice.Visible = True
        btnClear.Visible = True
    End Sub

    Private Sub btnCalculatePrice_Click(sender As Object, e As EventArgs) Handles btnCalculatePrice.Click
        ' Get Price button clicked
        Dim decPrice As Decimal
        Dim intNumTickets As Integer
        ' Validate input
        intNumTickets = ValidateInput(txtNumTickets.Text)
        decPrice = If(cmbTicketType.SelectedIndex = 0, ComputeMatinee(intNumTickets), ComputeEvening(intNumTickets))
        ' Update price label
        ' Use an If statement to check if we exited the verification without returning a value. Meaning we won't need to update the Price label.
        If decPrice > 0 Then
            lblPrice.Text = "Price: " & decPrice.ToString("C2")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear button
        cmbTicketType.SelectedIndex = -1
        lblNumTickets.Visible = False
        txtNumTickets.Clear()
        txtNumTickets.Visible = False
        btnCalculatePrice.Visible = False
        lblPrice.Text = "Price: " ' Reset in case it holds a value
        lblPrice.Visible = False
        btnClear.Visible = False
    End Sub

    Private Function ComputeMatinee(intNumTix As Integer)
        ' Matinee price computer
        Dim decTotalPrice As Decimal = 16 * intNumTix
        Return decTotalPrice
    End Function

    Private Function ComputeEvening(intNumTix As Integer)
        ' Evening price computer
        Dim decTotalPrice As Decimal = 27 * intNumTix
        Return decTotalPrice
    End Function

    Private Function ValidateInput(strInput)
        Dim intNumTickets As Integer
        Try
            intNumTickets = Convert.ToInt32(strInput)
            If (intNumTickets < 1) Then
                MsgBox("Number of tickets must an integer greater than 0. Try again.")
                ' Exiting the function without returning a value.
                Exit Function
            End If
        Catch Exception As ArgumentNullException
            MsgBox("Invalid number of tickets entered. Try again.")
        Catch Exception As FormatException
            MsgBox("Number of tickets must be a whole integer. Try again.")
        Catch Exception As SystemException
            MsgBox("There was an error. Try again.")
        End Try
        Return intNumTickets
    End Function
End Class