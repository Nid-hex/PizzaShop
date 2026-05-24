Public Class Form1

    ' Plain Checkbox
    Private Sub chkPlain_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlain.CheckedChanged

        If chkPlain.Checked = True Then
            chkSauce.Checked = False
        End If

    End Sub

    ' Sauce Checkbox
    Private Sub chkSauce_CheckedChanged(sender As Object, e As EventArgs) Handles chkSauce.CheckedChanged

        If chkSauce.Checked = True Then
            chkPlain.Checked = False
        End If

    End Sub

    ' Supreme Pizza
    Private Sub chkSupreme_CheckedChanged(sender As Object, e As EventArgs) Handles chkSupreme.CheckedChanged

        If chkSupreme.Checked = True Then

            chkMushroom.Enabled = False
            chkSausage.Enabled = False
            chkOnions.Enabled = False
            chkGreenPepper.Enabled = False

            chkMushroom.Checked = False
            chkSausage.Checked = False
            chkOnions.Checked = False
            chkGreenPepper.Checked = False

        Else

            chkMushroom.Enabled = True
            chkSausage.Enabled = True
            chkOnions.Enabled = True
            chkGreenPepper.Enabled = True

        End If

    End Sub

    ' Place Order Button
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Dim cost As Double = 0
        Dim toppingCost As Double = 0
        Dim tax As Double
        Dim total As Double

        ' Pizza Size

        'Small Pizza
        If rdoSmall.Checked = True Then

            If chkSupreme.Checked = True Then
                cost = 15
            Else
                cost = 10
                toppingCost = 1
            End If

        End If

        'Medium Pizza
        If rdoMedium.Checked = True Then

            If chkSupreme.Checked = True Then
                cost = 21
            Else
                cost = 12
                toppingCost = 1.5
            End If

        End If

        'Large Pizza
        If rdoLarge.Checked = True Then

            If chkSupreme.Checked = True Then
                cost = 27
            Else
                cost = 15
                toppingCost = 2.25
            End If

        End If

        ' Base Pizza

        'Sauce Pizza Extra Charge
        If chkSauce.Checked = True Then
            cost = cost + 2
        End If

        ' Extra Toppings
        If chkMushroom.Checked = True Then
            cost = cost + toppingCost
        End If

        If chkSausage.Checked = True Then
            cost = cost + toppingCost
        End If

        If chkOnions.Checked = True Then
            cost = cost + toppingCost
        End If

        If chkGreenPepper.Checked = True Then
            cost = cost + toppingCost
        End If

        ' Tax Calculation
        tax = cost * 0.06

        ' Total Amount
        total = cost + tax

        ' Display Output
        lblCost.Text = "$" & cost.ToString("0.00")
        lblTax.Text = "$" & tax.ToString("0.00")
        lblTotal.Text = "$" & total.ToString("0.00")

    End Sub

    ' Exit Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

End Class