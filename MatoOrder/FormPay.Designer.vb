<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PayReturn = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PayAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PayReturn)
        Me.GroupBox6.Location = New System.Drawing.Point(464, 59)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(223, 59)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Jumlah Kembalian (Rp)"
        '
        'PayReturn
        '
        Me.PayReturn.AutoSize = True
        Me.PayReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayReturn.Location = New System.Drawing.Point(3, 22)
        Me.PayReturn.Name = "PayReturn"
        Me.PayReturn.Size = New System.Drawing.Size(24, 25)
        Me.PayReturn.TabIndex = 0
        Me.PayReturn.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PayAmount)
        Me.GroupBox5.Controls.Add(Me.PayButton)
        Me.GroupBox5.Location = New System.Drawing.Point(240, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(218, 87)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Jumlah Bayar (Rp)"
        '
        'PayAmount
        '
        Me.PayAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PayAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayAmount.Location = New System.Drawing.Point(7, 19)
        Me.PayAmount.Name = "PayAmount"
        Me.PayAmount.Size = New System.Drawing.Size(205, 31)
        Me.PayAmount.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TotalPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 59)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Harga (Rp)"
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPrice.Location = New System.Drawing.Point(3, 22)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(72, 25)
        Me.TotalPrice.TabIndex = 0
        Me.TotalPrice.Text = "10000"
        '
        'PayButton
        '
        Me.PayButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PayButton.AutoSize = True
        Me.PayButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PayButton.FlatAppearance.BorderSize = 0
        Me.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayButton.ForeColor = System.Drawing.Color.White
        Me.PayButton.Location = New System.Drawing.Point(7, 56)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(205, 23)
        Me.PayButton.TabIndex = 1
        Me.PayButton.Text = "Bayar"
        Me.PayButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 47)
        Me.Panel1.TabIndex = 18
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Moccasin
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.ForeColor = System.Drawing.Color.Orange
        Me.CloseButton.Location = New System.Drawing.Point(612, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        Me.CloseButton.Text = "Batal"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MatoOrder › Kasir › Bayar"
        '
        'FormPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(699, 156)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MatoOrder › Kasir › Bayar"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PayReturn As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PayAmount As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TotalPrice As Label
    Friend WithEvents PayButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CloseButton As Button
End Class
