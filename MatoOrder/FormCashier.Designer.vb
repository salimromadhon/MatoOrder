<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddMenuButton = New System.Windows.Forms.Button()
        Me.NumMenu = New System.Windows.Forms.NumericUpDown()
        Me.Menus = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OrderNumber = New System.Windows.Forms.Label()
        Me.ProcessButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.OrderList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.CloseButton.Location = New System.Drawing.Point(612, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.TabStop = False
        Me.CloseButton.Text = "Keluar"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MatoOrder › Kasir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 47)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddMenuButton)
        Me.GroupBox1.Controls.Add(Me.NumMenu)
        Me.GroupBox1.Controls.Add(Me.Menus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 84)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Menu"
        '
        'AddMenuButton
        '
        Me.AddMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddMenuButton.BackColor = System.Drawing.Color.SteelBlue
        Me.AddMenuButton.FlatAppearance.BorderSize = 0
        Me.AddMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMenuButton.ForeColor = System.Drawing.Color.White
        Me.AddMenuButton.Location = New System.Drawing.Point(6, 53)
        Me.AddMenuButton.Name = "AddMenuButton"
        Me.AddMenuButton.Size = New System.Drawing.Size(333, 23)
        Me.AddMenuButton.TabIndex = 3
        Me.AddMenuButton.Text = "Tambah"
        Me.AddMenuButton.UseVisualStyleBackColor = False
        '
        'NumMenu
        '
        Me.NumMenu.BackColor = System.Drawing.Color.Lavender
        Me.NumMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMenu.Location = New System.Drawing.Point(271, 22)
        Me.NumMenu.Name = "NumMenu"
        Me.NumMenu.Size = New System.Drawing.Size(68, 22)
        Me.NumMenu.TabIndex = 2
        Me.NumMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Menus
        '
        Me.Menus.BackColor = System.Drawing.Color.White
        Me.Menus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Menus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menus.FormattingEnabled = True
        Me.Menus.Items.AddRange(New Object() {"Es Teh", "Es Jeruk", "Es Milo", "Es Kopi", "Kopi Arabika", "Kopi Robusta", "Kopi Kintamani", "Ayam Geprek", "Ayam Bakar"})
        Me.Menus.Location = New System.Drawing.Point(6, 19)
        Me.Menus.Name = "Menus"
        Me.Menus.Size = New System.Drawing.Size(259, 28)
        Me.Menus.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CustomerName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 59)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nama Pelanggan"
        '
        'CustomerName
        '
        Me.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerName.Location = New System.Drawing.Point(7, 19)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(332, 31)
        Me.CustomerName.TabIndex = 0
        Me.CustomerName.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.OrderNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 59)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nomor Pesanan"
        '
        'OrderNumber
        '
        Me.OrderNumber.AutoSize = True
        Me.OrderNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderNumber.Location = New System.Drawing.Point(3, 22)
        Me.OrderNumber.Name = "OrderNumber"
        Me.OrderNumber.Size = New System.Drawing.Size(48, 25)
        Me.OrderNumber.TabIndex = 0
        Me.OrderNumber.Text = "001"
        '
        'ProcessButton
        '
        Me.ProcessButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessButton.AutoSize = True
        Me.ProcessButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ProcessButton.FlatAppearance.BorderSize = 0
        Me.ProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProcessButton.ForeColor = System.Drawing.Color.White
        Me.ProcessButton.Location = New System.Drawing.Point(364, 313)
        Me.ProcessButton.Name = "ProcessButton"
        Me.ProcessButton.Size = New System.Drawing.Size(323, 23)
        Me.ProcessButton.TabIndex = 4
        Me.ProcessButton.Text = "Bayar"
        Me.ProcessButton.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TotalPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(345, 59)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Harga (Rp)"
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPrice.Location = New System.Drawing.Point(3, 22)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(24, 25)
        Me.TotalPrice.TabIndex = 0
        Me.TotalPrice.Text = "0"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(364, 58)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(323, 249)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.OrderList)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(315, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu Pesanan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.OrderList.FullRowSelect = True
        Me.OrderList.GridLines = True
        Me.OrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.OrderList.Location = New System.Drawing.Point(0, 0)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(315, 218)
        Me.OrderList.TabIndex = 0
        Me.OrderList.TabStop = False
        Me.OrderList.UseCompatibleStateImageBehavior = False
        Me.OrderList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Menu........................."
        Me.ColumnHeader2.Width = 142
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Byk."
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Harga....."
        Me.ColumnHeader4.Width = 103
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(315, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Catatan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(315, 235)
        Me.TextBox1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.CheckBox1.Location = New System.Drawing.Point(268, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Bungkus?"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(699, 348)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ProcessButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MatoOrder › Kasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CustomerName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OrderNumber As Label
    Friend WithEvents Menus As ComboBox
    Friend WithEvents NumMenu As NumericUpDown
    Friend WithEvents AddMenuButton As Button
    Friend WithEvents ProcessButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TotalPrice As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OrderList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents CheckBox1 As CheckBox
End Class
