<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_SetSQLDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_SetSQLDB))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_db_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btcalcel = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(8, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 2)
        Me.Panel1.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Password)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_db_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtServerName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 161)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'txt_Password
        '
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Password.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(116, 120)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(177, 26)
        Me.txt_Password.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "PASSWORD:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Username
        '
        Me.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Username.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(116, 87)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(110, 26)
        Me.txt_Username.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USER NAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_db_name
        '
        Me.txt_db_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_db_name.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_db_name.Location = New System.Drawing.Point(116, 55)
        Me.txt_db_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_db_name.Name = "txt_db_name"
        Me.txt_db_name.Size = New System.Drawing.Size(233, 26)
        Me.txt_db_name.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "DB NAME:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerName
        '
        Me.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtServerName.Location = New System.Drawing.Point(116, 23)
        Me.txtServerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(233, 26)
        Me.txtServerName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "SERVER NAME:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(397, 57)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Config Database"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btcalcel
        '
        Me.btcalcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcalcel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btcalcel.Image = CType(resources.GetObject("btcalcel.Image"), System.Drawing.Image)
        Me.btcalcel.Location = New System.Drawing.Point(262, 238)
        Me.btcalcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btcalcel.Name = "btcalcel"
        Me.btcalcel.Size = New System.Drawing.Size(87, 43)
        Me.btcalcel.TabIndex = 30
        Me.btcalcel.Text = "Exit"
        Me.btcalcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btcalcel.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btsave.Image = CType(resources.GetObject("btsave.Image"), System.Drawing.Image)
        Me.btsave.Location = New System.Drawing.Point(124, 238)
        Me.btsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(132, 43)
        Me.btsave.TabIndex = 29
        Me.btsave.Text = "Test Connect DB"
        Me.btsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsave.UseVisualStyleBackColor = True
        '
        'Fm_SetSQLDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(397, 294)
        Me.Controls.Add(Me.btcalcel)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_SetSQLDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Setting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btcalcel As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_db_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
