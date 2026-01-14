Imports System
Imports System.Windows.Forms
Imports Ticketsystem.UniqueTicketingNamespace

Public Class Form2

    Private ticketingManager As New TicketManager()

    ' Clear all inputs
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdults.Text = ""
        txtChildren.Text = ""
        lblTotal.Text = ""
        rbtnGroupStage.Checked = False
        rbtnQuarterFinals.Checked = False
        rbtnSemiFinals.Checked = False
        rbtnFinals.Checked = False
        rbtnSeniorCashier.Checked = False
        rbtnJuniorCashier.Checked = False
    End Sub

    ' Calculate total price
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim stage As String = GetSelectedStage()
            Dim numAdults As Integer = Integer.Parse(txtAdults.Text)
            Dim numChildren As Integer = Integer.Parse(txtChildren.Text)

            If rbtnJuniorCashier.Checked AndAlso (stage = "semi_finals" OrElse stage = "final") Then
                MessageBox.Show("Junior Cashiers can only select Group Stage and Quarter Finals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If rbtnJuniorCashier.Checked Then
                numChildren = 0
            End If

            Dim total As Integer = ticketingManager.CalculateTotal(stage, numAdults, numChildren)
            lblTotal.Text = $"Total: ${total}"

        Catch ex As FormatException
            MessageBox.Show("Please enter valid numbers for adults and children.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Print ticket and save to MongoDB
    Private Sub btnPrintTicket_Click(sender As Object, e As EventArgs) Handles btnPrintTicket.Click
        Try
            Dim stage As String = GetSelectedStage()
            Dim numAdults As Integer = Integer.Parse(txtAdults.Text)
            Dim numChildren As Integer = Integer.Parse(txtChildren.Text)

            If rbtnJuniorCashier.Checked AndAlso (stage = "semi_finals" OrElse stage = "final") Then
                MessageBox.Show("Junior Cashiers can only select Group Stage and Quarter Finals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If rbtnJuniorCashier.Checked Then
                numChildren = 0
            End If

            Dim total As Integer = ticketingManager.CalculateTotal(stage, numAdults, numChildren)
            ticketingManager.PrintTicket(stage, numAdults, numChildren, total)

            ' Save ticket to MongoDB
            Dim newTicket As New TicketManager.Ticket With {
                .Id = Guid.NewGuid().ToString(),
                .Title = $"Booking: {stage}",
                .Description = $"Adults: {numAdults}, Children: {numChildren}, Total: ${total}",
                .Status = "Printed"
            }
            ticketingManager.AddTicket(newTicket)

            MessageBox.Show("Ticket printed and saved successfully!")

        Catch ex As FormatException
            MessageBox.Show("Please enter valid numbers for adults and children.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper to get selected stage
    Private Function GetSelectedStage() As String
        If rbtnGroupStage.Checked Then Return "group_stage"
        If rbtnQuarterFinals.Checked Then Return "quarter_finals"
        If rbtnSemiFinals.Checked Then Return "semi_finals"
        If rbtnFinals.Checked Then Return "final"
        Throw New Exception("No stage selected")
    End Function

End Class
