<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penalty
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
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btnokay = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.txtamountreceived = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.txttotal.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Location = New System.Drawing.Point(190, 17)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(224, 46)
        Me.txttotal.TabIndex = 0
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(-6, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(433, 66)
        Me.Panel3.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(99, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Penalty Payment"
        '
        'Btnokay
        '
        Me.Btnokay.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Btnokay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnokay.ForeColor = System.Drawing.Color.Black
        Me.Btnokay.Location = New System.Drawing.Point(134, 280)
        Me.Btnokay.Name = "Btnokay"
        Me.Btnokay.Size = New System.Drawing.Size(143, 57)
        Me.Btnokay.TabIndex = 17
        Me.Btnokay.Text = "OK"
        Me.Btnokay.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtchange)
        Me.Panel2.Controls.Add(Me.txtamountreceived)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Location = New System.Drawing.Point(1, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(426, 189)
        Me.Panel2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount Receive"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Amount"
        '
        'txtchange
        '
        Me.txtchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.txtchange.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.ForeColor = System.Drawing.Color.Black
        Me.txtchange.Location = New System.Drawing.Point(142, 123)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(272, 46)
        Me.txtchange.TabIndex = 2
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtamountreceived
        '
        Me.txtamountreceived.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.txtamountreceived.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamountreceived.ForeColor = System.Drawing.Color.Black
        Me.txtamountreceived.Location = New System.Drawing.Point(222, 71)
        Me.txtamountreceived.Name = "txtamountreceived"
        Me.txtamountreceived.Size = New System.Drawing.Size(192, 46)
        Me.txtamountreceived.TabIndex = 1
        Me.txtamountreceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'penalty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(421, 350)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Btnokay)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "penalty"
        Me.Text = "penalty"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txttotal As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Btnokay As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents txtamountreceived As TextBox
End Class
