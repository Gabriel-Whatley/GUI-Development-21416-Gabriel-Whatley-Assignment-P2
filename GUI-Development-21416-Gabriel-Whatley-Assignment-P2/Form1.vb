'Name: Gabriel Whatley
'Date : 2/22/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that calculates exactly how much money the various governments and programs will take from your paycheck.
Imports System.Runtime.CompilerServices

Public Class Form1

    'Constants'
    Dim cdecFica As Decimal = 0.0765
    Dim cdecFed As Decimal = 0.22
    Dim cdecState As Decimal = 0.04

    'Variables'
    Dim strIncome As String
    Dim decIncome As Decimal 'Input from text box after converting to decimal
    Dim decFica As Decimal 'calculated fica tax
    Dim decFed As Decimal 'calculated federal tax
    Dim decState As Decimal 'Calculated state tax
    Dim decNet As Decimal 'calculated take home pay (net - (fica + fed+ state))

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        clear() 'When the form loads clear the inputs, outputs, and reset the focus.
    End Sub

    Private Sub btn_compute_Click(sender As Object, e As EventArgs) Handles btn_compute.Click
        strIncome = box_input.Text 'Store string from text box as string variable.
        If Decimal.TryParse(strIncome, decIncome) = False Then 'if the str can't be made a dec, pop the message, clear inputs, and break.
            MsgBox("The input needs to be a whole or decimal number, please try again", 0, "Error")
            clear()
            Exit Sub '<-- Secondary sub exit point.
        End If
        calculate_taxes(decIncome) 'Calculate the taxes, filling the output variables.
        set_output() 'Write the output variables.
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Close() 'Exit the form
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear() 'Clear all outputs and input, refocus on the input text box.
    End Sub

    Private Sub calculate_taxes(net As Decimal) 'Calculate the taxes and set the output variables.
        decFica = Math.Round(net * cdecFica, 2)
        decFed = Math.Round(net * cdecFed, 2)
        decState = Math.Round(net * cdecState, 2)
        decNet = net - (decFica + decFed + decState)
    End Sub

    Private Sub set_output() 'Write the values of the output variables to the labels on the form.
        out_fica.Text = decFica.ToString()
        out_fed.Text = decFed.ToString()
        out_state.Text = decState.ToString()
        out_net.Text = decNet.ToString()
    End Sub

    Private Sub clear() 'Clear the input, outputs, and refocus on the input text box.
        out_fica.Text = ""
        out_fed.Text = ""
        out_state.Text = ""
        out_net.Text = ""
        box_input.Text = ""
        box_input.Focus()
    End Sub

    Private Sub box_input_TextChanged(sender As Object, e As EventArgs) Handles box_input.TextChanged

    End Sub

    Private Sub lbl_state_Click(sender As Object, e As EventArgs) Handles lbl_state.Click

    End Sub
End Class
