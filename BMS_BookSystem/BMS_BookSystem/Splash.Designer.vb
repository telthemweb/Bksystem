<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.splashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pillar = New System.Windows.Forms.ProgressBar()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splashTimer
        '
        '
        'pillar
        '
        Me.pillar.Location = New System.Drawing.Point(-18, 90)
        Me.pillar.Name = "pillar"
        Me.pillar.Size = New System.Drawing.Size(801, 7)
        Me.pillar.TabIndex = 3
        Me.pillar.Visible = False
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Silver
        Me.lblWait.Location = New System.Drawing.Point(12, 60)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(151, 23)
        Me.lblWait.TabIndex = 4
        Me.lblWait.Text = "Preparing system"
        Me.lblWait.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 38)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(157, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Automated Book Management System "
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(738, 98)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.pillar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents splashTimer As Timer
    Friend WithEvents pillar As ProgressBar
    Friend WithEvents lblWait As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
