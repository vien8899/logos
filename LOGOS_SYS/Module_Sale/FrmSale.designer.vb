<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btnConfirmRC = New System.Windows.Forms.Button()
        Me.gbPayment = New System.Windows.Forms.GroupBox()
        Me.txt_percent_dis = New System.Windows.Forms.TextBox()
        Me.panel_paytype = New System.Windows.Forms.Panel()
        Me.rdo_card = New System.Windows.Forms.RadioButton()
        Me.rdo_cash = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.txtTotal_All = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_total_pay = New System.Windows.Forms.TextBox()
        Me.lbTotalFood = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.gbAddmenu = New System.Windows.Forms.GroupBox()
        Me.Chk_free = New System.Windows.Forms.CheckBox()
        Me.btnAddMenu = New System.Windows.Forms.Button()
        Me.txtAmount_Food = New System.Windows.Forms.TextBox()
        Me.btnDel_Menu = New System.Windows.Forms.Button()
        Me.lbAmountfood = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel6.SuspendLayout()
        Me.gbPayment.SuspendLayout()
        Me.panel_paytype.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAddmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Controls.Add(Me.btn_Cancel)
        Me.Panel6.Controls.Add(Me.btnConfirmRC)
        Me.Panel6.Location = New System.Drawing.Point(611, 488)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(534, 112)
        Me.Panel6.TabIndex = 25
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.White
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Font = New System.Drawing.Font("Noto Sans Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Image = CType(resources.GetObject("btn_Cancel.Image"), System.Drawing.Image)
        Me.btn_Cancel.Location = New System.Drawing.Point(306, 17)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(147, 70)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "ຍົກເລີກ"
        Me.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btnConfirmRC
        '
        Me.btnConfirmRC.BackColor = System.Drawing.Color.White
        Me.btnConfirmRC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmRC.Font = New System.Drawing.Font("Noto Sans Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmRC.Image = CType(resources.GetObject("btnConfirmRC.Image"), System.Drawing.Image)
        Me.btnConfirmRC.Location = New System.Drawing.Point(72, 17)
        Me.btnConfirmRC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConfirmRC.Name = "btnConfirmRC"
        Me.btnConfirmRC.Size = New System.Drawing.Size(182, 70)
        Me.btnConfirmRC.TabIndex = 5
        Me.btnConfirmRC.Text = "ພິມບິນຮັບເງິນ"
        Me.btnConfirmRC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmRC.UseVisualStyleBackColor = False
        '
        'gbPayment
        '
        Me.gbPayment.BackColor = System.Drawing.Color.Silver
        Me.gbPayment.Controls.Add(Me.txt_percent_dis)
        Me.gbPayment.Controls.Add(Me.panel_paytype)
        Me.gbPayment.Controls.Add(Me.Panel4)
        Me.gbPayment.Controls.Add(Me.txt_discount)
        Me.gbPayment.Controls.Add(Me.txtTotal_All)
        Me.gbPayment.Controls.Add(Me.Label2)
        Me.gbPayment.Controls.Add(Me.Label6)
        Me.gbPayment.Controls.Add(Me.txt_total_pay)
        Me.gbPayment.Controls.Add(Me.lbTotalFood)
        Me.gbPayment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.gbPayment.Location = New System.Drawing.Point(611, 278)
        Me.gbPayment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbPayment.Name = "gbPayment"
        Me.gbPayment.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbPayment.Size = New System.Drawing.Size(534, 206)
        Me.gbPayment.TabIndex = 24
        Me.gbPayment.TabStop = False
        Me.gbPayment.Text = "Payment Info"
        '
        'txt_percent_dis
        '
        Me.txt_percent_dis.BackColor = System.Drawing.Color.White
        Me.txt_percent_dis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_percent_dis.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_percent_dis.Location = New System.Drawing.Point(203, 61)
        Me.txt_percent_dis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_percent_dis.MaxLength = 6
        Me.txt_percent_dis.Name = "txt_percent_dis"
        Me.txt_percent_dis.Size = New System.Drawing.Size(70, 32)
        Me.txt_percent_dis.TabIndex = 0
        '
        'panel_paytype
        '
        Me.panel_paytype.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_paytype.Controls.Add(Me.rdo_card)
        Me.panel_paytype.Controls.Add(Me.rdo_cash)
        Me.panel_paytype.Location = New System.Drawing.Point(71, 135)
        Me.panel_paytype.Name = "panel_paytype"
        Me.panel_paytype.Size = New System.Drawing.Size(381, 42)
        Me.panel_paytype.TabIndex = 38
        '
        'rdo_card
        '
        Me.rdo_card.AutoSize = True
        Me.rdo_card.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdo_card.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_card.ForeColor = System.Drawing.Color.Maroon
        Me.rdo_card.Location = New System.Drawing.Point(234, 6)
        Me.rdo_card.Name = "rdo_card"
        Me.rdo_card.Size = New System.Drawing.Size(103, 30)
        Me.rdo_card.TabIndex = 1
        Me.rdo_card.Text = "ຮັບເງິນໂອນ"
        Me.rdo_card.UseVisualStyleBackColor = True
        '
        'rdo_cash
        '
        Me.rdo_cash.AutoSize = True
        Me.rdo_cash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdo_cash.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_cash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdo_cash.Location = New System.Drawing.Point(130, 6)
        Me.rdo_cash.Name = "rdo_cash"
        Me.rdo_cash.Size = New System.Drawing.Size(98, 30)
        Me.rdo_cash.TabIndex = 0
        Me.rdo_cash.Text = "ຮັບເງິນສົດ"
        Me.rdo_cash.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(71, 182)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 2)
        Me.Panel4.TabIndex = 32
        '
        'txt_discount
        '
        Me.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_discount.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_discount.Location = New System.Drawing.Point(280, 61)
        Me.txt_discount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.ReadOnly = True
        Me.txt_discount.Size = New System.Drawing.Size(121, 32)
        Me.txt_discount.TabIndex = 30
        '
        'txtTotal_All
        '
        Me.txtTotal_All.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal_All.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtTotal_All.Location = New System.Drawing.Point(203, 26)
        Me.txtTotal_All.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal_All.Name = "txtTotal_All"
        Me.txtTotal_All.ReadOnly = True
        Me.txtTotal_All.Size = New System.Drawing.Size(248, 32)
        Me.txtTotal_All.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ລວມເປັນເງິນທັງໝົດ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ກຳນົດສ່ວນຫຼຸດ(%)"
        '
        'txt_total_pay
        '
        Me.txt_total_pay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_total_pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_pay.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_total_pay.ForeColor = System.Drawing.Color.White
        Me.txt_total_pay.Location = New System.Drawing.Point(203, 97)
        Me.txt_total_pay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_total_pay.Name = "txt_total_pay"
        Me.txt_total_pay.ReadOnly = True
        Me.txt_total_pay.Size = New System.Drawing.Size(248, 32)
        Me.txt_total_pay.TabIndex = 27
        '
        'lbTotalFood
        '
        Me.lbTotalFood.AutoSize = True
        Me.lbTotalFood.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalFood.Location = New System.Drawing.Point(69, 99)
        Me.lbTotalFood.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalFood.Name = "lbTotalFood"
        Me.lbTotalFood.Size = New System.Drawing.Size(132, 26)
        Me.lbTotalFood.TabIndex = 26
        Me.lbTotalFood.Text = "ເງິນຮັບຕົວຈິງ(ກີບ)"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox6.Controls.Add(Me.DataGridView2)
        Me.GroupBox6.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(611, 3)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox6.Size = New System.Drawing.Size(534, 271)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ລາຍການທີ່ໄດ້ເພີ່ມແລ້ວ"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(531, 248)
        Me.DataGridView2.TabIndex = 5
        '
        'gbAddmenu
        '
        Me.gbAddmenu.BackColor = System.Drawing.Color.Gainsboro
        Me.gbAddmenu.Controls.Add(Me.Chk_free)
        Me.gbAddmenu.Controls.Add(Me.btnAddMenu)
        Me.gbAddmenu.Controls.Add(Me.txtAmount_Food)
        Me.gbAddmenu.Controls.Add(Me.btnDel_Menu)
        Me.gbAddmenu.Controls.Add(Me.lbAmountfood)
        Me.gbAddmenu.Location = New System.Drawing.Point(515, 4)
        Me.gbAddmenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbAddmenu.Name = "gbAddmenu"
        Me.gbAddmenu.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbAddmenu.Size = New System.Drawing.Size(92, 596)
        Me.gbAddmenu.TabIndex = 2
        Me.gbAddmenu.TabStop = False
        '
        'Chk_free
        '
        Me.Chk_free.AutoSize = True
        Me.Chk_free.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_free.Location = New System.Drawing.Point(12, 113)
        Me.Chk_free.Name = "Chk_free"
        Me.Chk_free.Size = New System.Drawing.Size(70, 25)
        Me.Chk_free.TabIndex = 6
        Me.Chk_free.Text = "ແຖມຟຣີ"
        Me.Chk_free.UseVisualStyleBackColor = True
        '
        'btnAddMenu
        '
        Me.btnAddMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMenu.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMenu.Image = CType(resources.GetObject("btnAddMenu.Image"), System.Drawing.Image)
        Me.btnAddMenu.Location = New System.Drawing.Point(8, 153)
        Me.btnAddMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddMenu.Name = "btnAddMenu"
        Me.btnAddMenu.Size = New System.Drawing.Size(75, 32)
        Me.btnAddMenu.TabIndex = 2
        Me.btnAddMenu.Text = "ເພີ່ມ"
        Me.btnAddMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddMenu.UseVisualStyleBackColor = True
        '
        'txtAmount_Food
        '
        Me.txtAmount_Food.BackColor = System.Drawing.SystemColors.Menu
        Me.txtAmount_Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount_Food.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmount_Food.Location = New System.Drawing.Point(13, 75)
        Me.txtAmount_Food.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAmount_Food.MaxLength = 3
        Me.txtAmount_Food.Name = "txtAmount_Food"
        Me.txtAmount_Food.Size = New System.Drawing.Size(68, 30)
        Me.txtAmount_Food.TabIndex = 4
        Me.txtAmount_Food.Text = "1"
        Me.txtAmount_Food.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDel_Menu
        '
        Me.btnDel_Menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel_Menu.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel_Menu.Image = CType(resources.GetObject("btnDel_Menu.Image"), System.Drawing.Image)
        Me.btnDel_Menu.Location = New System.Drawing.Point(8, 191)
        Me.btnDel_Menu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDel_Menu.Name = "btnDel_Menu"
        Me.btnDel_Menu.Size = New System.Drawing.Size(75, 32)
        Me.btnDel_Menu.TabIndex = 3
        Me.btnDel_Menu.Text = "ລຶບ"
        Me.btnDel_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel_Menu.UseVisualStyleBackColor = True
        '
        'lbAmountfood
        '
        Me.lbAmountfood.AutoSize = True
        Me.lbAmountfood.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAmountfood.Location = New System.Drawing.Point(15, 54)
        Me.lbAmountfood.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAmountfood.Name = "lbAmountfood"
        Me.lbAmountfood.Size = New System.Drawing.Size(67, 21)
        Me.lbAmountfood.TabIndex = 1
        Me.lbAmountfood.Text = "ຈຳນວນເພີ່ມ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 42)
        Me.Panel1.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(171, 6)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.MaxLength = 15
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(180, 28)
        Me.txtsearch.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(360, 6)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(72, 29)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.Text = "ຄົ້ນຫາ"
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ເລືອກລາຍການສິນຄ້າ"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(3, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(511, 555)
        Me.Panel5.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(508, 555)
        Me.DataGridView1.TabIndex = 1
        '
        'FrmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 603)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbAddmenu)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.gbPayment)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSale"
        Me.Text = "SALE.."
        Me.Panel6.ResumeLayout(False)
        Me.gbPayment.ResumeLayout(False)
        Me.gbPayment.PerformLayout()
        Me.panel_paytype.ResumeLayout(False)
        Me.panel_paytype.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAddmenu.ResumeLayout(False)
        Me.gbAddmenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btnConfirmRC As System.Windows.Forms.Button
    Friend WithEvents gbPayment As System.Windows.Forms.GroupBox
    Friend WithEvents txt_percent_dis As System.Windows.Forms.TextBox
    Friend WithEvents panel_paytype As System.Windows.Forms.Panel
    Friend WithEvents rdo_card As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_cash As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal_All As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_total_pay As System.Windows.Forms.TextBox
    Friend WithEvents lbTotalFood As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents gbAddmenu As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_free As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddMenu As System.Windows.Forms.Button
    Friend WithEvents txtAmount_Food As System.Windows.Forms.TextBox
    Friend WithEvents btnDel_Menu As System.Windows.Forms.Button
    Friend WithEvents lbAmountfood As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
