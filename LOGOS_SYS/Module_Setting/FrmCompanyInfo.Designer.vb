<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompanyInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompanyInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.copies_sell = New System.Windows.Forms.NumericUpDown()
        Me.copies_register = New System.Windows.Forms.NumericUpDown()
        Me.copies_enroll = New System.Windows.Forms.NumericUpDown()
        Me.cb_sell = New System.Windows.Forms.ComboBox()
        Me.cb_register = New System.Windows.Forms.ComboBox()
        Me.cb_enroll = New System.Windows.Forms.ComboBox()
        Me.txt_laoname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_en = New System.Windows.Forms.TextBox()
        Me.btcalcel = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.LinkLabel_Browse = New System.Windows.Forms.LinkLabel()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_update = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.copies_sell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copies_register, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copies_enroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.copies_sell)
        Me.GroupBox1.Controls.Add(Me.copies_register)
        Me.GroupBox1.Controls.Add(Me.copies_enroll)
        Me.GroupBox1.Controls.Add(Me.cb_sell)
        Me.GroupBox1.Controls.Add(Me.cb_register)
        Me.GroupBox1.Controls.Add(Me.cb_enroll)
        Me.GroupBox1.Controls.Add(Me.txt_laoname)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_en)
        Me.GroupBox1.Controls.Add(Me.btcalcel)
        Me.GroupBox1.Controls.Add(Me.btsave)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.LinkLabel_Browse)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lb_update)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 451)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'copies_sell
        '
        Me.copies_sell.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copies_sell.Location = New System.Drawing.Point(494, 319)
        Me.copies_sell.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.copies_sell.Name = "copies_sell"
        Me.copies_sell.Size = New System.Drawing.Size(42, 26)
        Me.copies_sell.TabIndex = 8
        Me.copies_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.copies_sell.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'copies_register
        '
        Me.copies_register.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copies_register.Location = New System.Drawing.Point(494, 289)
        Me.copies_register.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.copies_register.Name = "copies_register"
        Me.copies_register.Size = New System.Drawing.Size(42, 26)
        Me.copies_register.TabIndex = 6
        Me.copies_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.copies_register.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'copies_enroll
        '
        Me.copies_enroll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copies_enroll.Location = New System.Drawing.Point(494, 258)
        Me.copies_enroll.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.copies_enroll.Name = "copies_enroll"
        Me.copies_enroll.Size = New System.Drawing.Size(42, 26)
        Me.copies_enroll.TabIndex = 4
        Me.copies_enroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.copies_enroll.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cb_sell
        '
        Me.cb_sell.BackColor = System.Drawing.Color.White
        Me.cb_sell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sell.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sell.FormattingEnabled = True
        Me.cb_sell.Location = New System.Drawing.Point(172, 318)
        Me.cb_sell.Name = "cb_sell"
        Me.cb_sell.Size = New System.Drawing.Size(268, 27)
        Me.cb_sell.TabIndex = 7
        '
        'cb_register
        '
        Me.cb_register.BackColor = System.Drawing.Color.White
        Me.cb_register.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_register.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_register.FormattingEnabled = True
        Me.cb_register.Location = New System.Drawing.Point(172, 288)
        Me.cb_register.Name = "cb_register"
        Me.cb_register.Size = New System.Drawing.Size(268, 27)
        Me.cb_register.TabIndex = 5
        '
        'cb_enroll
        '
        Me.cb_enroll.BackColor = System.Drawing.Color.White
        Me.cb_enroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_enroll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_enroll.FormattingEnabled = True
        Me.cb_enroll.Location = New System.Drawing.Point(172, 258)
        Me.cb_enroll.Name = "cb_enroll"
        Me.cb_enroll.Size = New System.Drawing.Size(268, 27)
        Me.cb_enroll.TabIndex = 3
        '
        'txt_laoname
        '
        Me.txt_laoname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_laoname.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_laoname.Location = New System.Drawing.Point(36, 51)
        Me.txt_laoname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_laoname.MaxLength = 200
        Me.txt_laoname.Name = "txt_laoname"
        Me.txt_laoname.ReadOnly = True
        Me.txt_laoname.Size = New System.Drawing.Size(404, 29)
        Me.txt_laoname.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(449, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "2. ປິ່ນເຕີລົງທະບຽນ-ຮຽນ"
        '
        'txt_en
        '
        Me.txt_en.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_en.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_en.Location = New System.Drawing.Point(35, 110)
        Me.txt_en.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_en.MaxLength = 200
        Me.txt_en.Name = "txt_en"
        Me.txt_en.ReadOnly = True
        Me.txt_en.Size = New System.Drawing.Size(405, 26)
        Me.txt_en.TabIndex = 1
        '
        'btcalcel
        '
        Me.btcalcel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btcalcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcalcel.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcalcel.Image = CType(resources.GetObject("btcalcel.Image"), System.Drawing.Image)
        Me.btcalcel.Location = New System.Drawing.Point(412, 372)
        Me.btcalcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btcalcel.Name = "btcalcel"
        Me.btcalcel.Size = New System.Drawing.Size(85, 43)
        Me.btcalcel.TabIndex = 11
        Me.btcalcel.Text = "ອອກ"
        Me.btcalcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btcalcel.UseVisualStyleBackColor = False
        '
        'btsave
        '
        Me.btsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsave.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.Image = CType(resources.GetObject("btsave.Image"), System.Drawing.Image)
        Me.btsave.Location = New System.Drawing.Point(172, 372)
        Me.btsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(88, 43)
        Me.btsave.TabIndex = 10
        Me.btsave.Text = "ບັນທຶກ"
        Me.btsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(35, 367)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 2)
        Me.Panel1.TabIndex = 21
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Phetsarath OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(35, 160)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.ReadOnly = True
        Me.txt_address.Size = New System.Drawing.Size(501, 94)
        Me.txt_address.TabIndex = 2
        '
        'LinkLabel_Browse
        '
        Me.LinkLabel_Browse.AutoSize = True
        Me.LinkLabel_Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel_Browse.Enabled = False
        Me.LinkLabel_Browse.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LinkLabel_Browse.Location = New System.Drawing.Point(465, 33)
        Me.LinkLabel_Browse.Name = "LinkLabel_Browse"
        Me.LinkLabel_Browse.Size = New System.Drawing.Size(59, 15)
        Me.LinkLabel_Browse.TabIndex = 12
        Me.LinkLabel_Browse.TabStop = True
        Me.LinkLabel_Browse.Text = "Select Logo"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.Location = New System.Drawing.Point(77, 372)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(89, 43)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "ແກ້ໄຂ"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(217, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ຊື່ວິທະຍາໄລ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(221, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "College"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(440, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 21)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "ຈຳນວນໃບ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(214, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ທີ່ຢູສະຖາບັນ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(440, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ຈຳນວນໃບ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "3. ປິ່ນເຕີຂາຍອຸປະກອນຮຽນ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(440, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "ຈຳນວນໃບ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "1. ປິ່ນເຕີລົງທະບຽນເສັງທຽບ"
        '
        'lb_update
        '
        Me.lb_update.AutoSize = True
        Me.lb_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lb_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_update.Location = New System.Drawing.Point(169, 351)
        Me.lb_update.Name = "lb_update"
        Me.lb_update.Size = New System.Drawing.Size(272, 16)
        Me.lb_update.TabIndex = 35
        Me.lb_update.Text = "Last Update: 20/09/2022 12:15:35, By: Admin"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmCompanyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCompanyInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.copies_sell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copies_register, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copies_enroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_laoname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_en As System.Windows.Forms.TextBox
    Friend WithEvents btcalcel As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Browse As System.Windows.Forms.LinkLabel
    Friend WithEvents copies_sell As System.Windows.Forms.NumericUpDown
    Friend WithEvents copies_register As System.Windows.Forms.NumericUpDown
    Friend WithEvents copies_enroll As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_sell As System.Windows.Forms.ComboBox
    Friend WithEvents cb_register As System.Windows.Forms.ComboBox
    Friend WithEvents cb_enroll As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_update As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
