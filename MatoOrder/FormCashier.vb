Public Class FormCashier
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        FormSplash.Show()
        Me.Close()
    End Sub

    Private Sub FormCashier_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CustomerName.Focus()
    End Sub

    Private Sub NumMenu_Enter(sender As Object, e As EventArgs) Handles NumMenu.Enter
        NumMenu.Value = 0
        NumMenu.ResetText()
    End Sub

    Private Sub Menus_Enter(sender As Object, e As EventArgs) Handles Menus.Enter
        Menus.DroppedDown = True
    End Sub

    Private Sub AddMenuButton_Click(sender As Object, e As EventArgs) Handles AddMenuButton.Click
        Menus.Focus()
        NumMenu.Value = 0
    End Sub

    Private Sub ProcessButton_Click(sender As Object, e As EventArgs) Handles ProcessButton.Click
        FormPay.TotalPrice.Text = TotalPrice.Text
        Me.Hide()
        FormPay.Show()
    End Sub

End Class