Public Class FormCashier

    '-----------------
    ' Global Variables
    '-----------------
    Dim OrderData As New List(Of String())

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
        AddMenu()
        Menus.Focus()
        NumMenu.Value = 0
    End Sub

    Private Sub ProcessButton_Click(sender As Object, e As EventArgs) Handles ProcessButton.Click
        If CustomerName.Text <> "" Then
            FormPay.TotalPrice.Text = TotalPrice.Text
            Me.Hide()
            FormPay.Show()
        Else
            CustomerName.Focus()
        End If
    End Sub

    Sub AddMenu()
        If Menus.Text <> "" And NumMenu.Value > 0 Then
            ' Bind the data
            Dim Data As String() = {Menus.Text, Convert.ToString(NumMenu.Value), Convert.ToString(1000 * NumMenu.Value)}
            ' Check whether menu exists
            Dim Exists As Boolean = False
            Dim ActiveIndex As Integer
            For Index = 0 To OrderData.Count - 1
                If OrderData.Item(Index)(0) = Menus.Text Then
                    Exists = True
                    ActiveIndex = Index
                End If
            Next
            ' Then if exists, replace
            If Exists Then
                OrderData.RemoveAt(ActiveIndex)
                OrderData.Insert(ActiveIndex, Data)
            Else
                OrderData.Add(Data)
            End If
            RefreshOrderList()
        End If
    End Sub

    Sub RefreshOrderList()
        OrderList.Items.Clear()
        Dim TotalPriceNum As Integer
        For index = 0 To OrderData.Count - 1
            Dim Menu As New ListViewItem
            Menu = OrderList.Items.Add(index + 1)
            Menu.SubItems.Add(OrderData.Item(index)(0))
            Menu.SubItems.Add(OrderData.Item(index)(1))
            Menu.SubItems.Add(OrderData.Item(index)(2))
            TotalPriceNum += Convert.ToInt32(OrderData.Item(index)(2))
        Next
        TotalPrice.Text = Convert.ToString(TotalPriceNum)
    End Sub

    Private Sub FormCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrderList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub OrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderList.SelectedIndexChanged
        Dim Index = OrderList.FocusedItem.Index
        OrderData.RemoveAt(Index)
        RefreshOrderList()
    End Sub

End Class