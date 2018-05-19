Public Class FormPay
    Private Sub FormPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalPrice.Text = FormCashier.TotalPrice.Text
        PayAmount.Focus()
    End Sub

    Private Sub FormPay_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PayAmount.Focus()
    End Sub

    Private Sub PayAmount_TextChanged(sender As Object, e As EventArgs) Handles PayAmount.TextChanged
        Try
            PayReturn.Text = Convert.ToInt32(PayAmount.Text) - Convert.ToInt32(TotalPrice.Text)
        Catch ex As Exception
            PayReturn.Text = ""
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        PayAmount.Focus()
        Me.Hide()
        FormCashier.Show()
    End Sub
End Class