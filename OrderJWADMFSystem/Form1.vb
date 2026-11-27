Public Class Form1

    Private dbJAJCMNJMMLNMSize As Decimal
    Private dbJAJCMNJMMLNMPine As Decimal
    Private dbJAJCMNJMMLNMHam As Decimal
    Private dbJAJCMNJMMLNMCombo As Decimal
    Private dbJAJCMNJMMLNMDrinks As Decimal
    Private dbJAJCMNJMMLNMTotal As Decimal

    Private Function computeJAJCMNJMMLNMOrders(dbJAJCMNJMMLNMSizePrice As Decimal,
                                         dbJAJCMNJMMLNMPinePrice As Decimal,
                                         dbJAJCMNJMMLNMHamPrice As Decimal,
                                         dbJAJCMNJMMLNMComboPrice As Decimal,
                                         dbJAJCMNJMMLNMDrinksPrice As Decimal) As Decimal
        Return dbJAJCMNJMMLNMSizePrice + dbJAJCMNJMMLNMPinePrice + dbJAJCMNJMMLNMHamPrice + dbJAJCMNJMMLNMComboPrice + dbJAJCMNJMMLNMDrinksPrice
    End Function

    Private Sub btnJAJCMNJMMLNMAmount_Click(sender As Object, e As EventArgs) Handles btnJAJCMNJMMLNMAmount.Click
        If optJAJCMNJMMLNMSolo.Checked Then
            dbJAJCMNJMMLNMSize = 50D
        ElseIf optJAJCMNJMMLNMRegular.Checked Then
            dbJAJCMNJMMLNMSize = 100D
        ElseIf optJAJCMNJMMLNMFamily.Checked Then
            dbJAJCMNJMMLNMSize = 250D
        Else
            MessageBox.Show("Please select a pizza size.", "JAJCMNJMMLNM Pizza", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dbJAJCMNJMMLNMPine = If(chkJAJCMNJMMLNMPine.Checked, 20D, 0D)
        dbJAJCMNJMMLNMHam = If(chkJAJCMNJMMLNMHam.Checked, 50D, 0D)
        dbJAJCMNJMMLNMCombo = If(chkJAJCMNJMMLNMCombo.Checked, 100D, 0D)

        Select Case cmbJAJCMNJMMLNMDrinks.Text.Trim().ToUpperInvariant()
            Case "SOFTDRINKS 30.00"
                dbJAJCMNJMMLNMDrinks = 30D
            Case "COFFEE 50.00"
                dbJAJCMNJMMLNMDrinks = 50D
            Case "MANGO JUICE 50.00"
                dbJAJCMNJMMLNMDrinks = 50D
            Case Else
                MessageBox.Show("Please select one drink.", "JAJCMNJMMLNM Pizza", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

        dbJAJCMNJMMLNMTotal = computeJAJCMNJMMLNMOrders(dbJAJCMNJMMLNMSize, dbJAJCMNJMMLNMPine, dbJAJCMNJMMLNMHam, dbJAJCMNJMMLNMCombo, dbJAJCMNJMMLNMDrinks)
        txtJAJCMNJMMLNMAmount.Text = dbJAJCMNJMMLNMTotal.ToString("N2")
    End Sub

    Private Sub btnJAJCMNJMMLNMReceipt_Click(sender As Object, e As EventArgs) Handles btnJAJCMNJMMLNMReceipt.Click
        If dbJAJCMNJMMLNMTotal <= 0D OrElse String.IsNullOrWhiteSpace(txtJAJCMNJMMLNMAmount.Text) Then
            MessageBox.Show("Please calculate the amount first.", "JAJCMNJMMLNM Pizza", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim strJAJCMNJMMLNMReceipt As New System.Text.StringBuilder()
        strJAJCMNJMMLNMReceipt.AppendLine("JAJCMNJMMLNM PIZZA ORDER RECEIPT")
        strJAJCMNJMMLNMReceipt.AppendLine()
        strJAJCMNJMMLNMReceipt.AppendLine("Last Name: " & txtJAJCMNJMMLNMLName.Text.Trim())
        strJAJCMNJMMLNMReceipt.AppendLine("First Name: " & txtJAJCMNJMMLNMName.Text.Trim())
        strJAJCMNJMMLNMReceipt.AppendLine("Middle Name: " & txtJAJCMNJMMLNM_MName.Text.Trim())
        strJAJCMNJMMLNMReceipt.AppendLine()

        If optJAJCMNJMMLNMSolo.Checked Then
            strJAJCMNJMMLNMReceipt.AppendLine("Pizza: Solo - 50.00")
        ElseIf optJAJCMNJMMLNMRegular.Checked Then
            strJAJCMNJMMLNMReceipt.AppendLine("Pizza: Regular - 100.00")
        ElseIf optJAJCMNJMMLNMFamily.Checked Then
            strJAJCMNJMMLNMReceipt.AppendLine("Pizza: Family - 250.00")
        End If

        If chkJAJCMNJMMLNMPine.Checked Then
            strJAJCMNJMMLNMReceipt.AppendLine("Pineapple - 20.00")
        End If
        If chkJAJCMNJMMLNMHam.Checked Then
            strJAJCMNJMMLNMReceipt.AppendLine("Ham and Cheese - 50.00")
        End If
        If chkJAJCMNJMMLNMCombo.Checked Then
            strJAJCMNJMMLNMReceipt.AppendLine("Combo - 100.00")
        End If

        strJAJCMNJMMLNMReceipt.AppendLine("Drink: " & cmbJAJCMNJMMLNMDrinks.Text)
        strJAJCMNJMMLNMReceipt.AppendLine()
        strJAJCMNJMMLNMReceipt.AppendLine("TOTAL: " & dbJAJCMNJMMLNMTotal.ToString("N2"))

        MessageBox.Show(strJAJCMNJMMLNMReceipt.ToString(), "JAJCMNJMMLNM Pizza Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnJAJCMNJMMLNMClear_Click(sender As Object, e As EventArgs) Handles btnJAJCMNJMMLNMClear.Click
        txtJAJCMNJMMLNMLName.Clear()
        txtJAJCMNJMMLNMName.Clear()
        txtJAJCMNJMMLNM_MName.Clear()
        txtJAJCMNJMMLNMAmount.Clear()

        optJAJCMNJMMLNMSolo.Checked = False
        optJAJCMNJMMLNMRegular.Checked = False
        optJAJCMNJMMLNMFamily.Checked = False
        chkJAJCMNJMMLNMPine.Checked = False
        chkJAJCMNJMMLNMHam.Checked = False
        chkJAJCMNJMMLNMCombo.Checked = False
        cmbJAJCMNJMMLNMDrinks.SelectedIndex = -1

        dbJAJCMNJMMLNMSize = 0D
        dbJAJCMNJMMLNMPine = 0D
        dbJAJCMNJMMLNMHam = 0D
        dbJAJCMNJMMLNMCombo = 0D
        dbJAJCMNJMMLNMDrinks = 0D
        dbJAJCMNJMMLNMTotal = 0D
    End Sub

End Class
