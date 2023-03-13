<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudentEnroll_view
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStudentEnroll_view))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Datagridview1 = New System.Windows.Forms.DataGridView()
        Me.id_edit_group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_stu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sok_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_ttt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.u_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_register = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.u_loginname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_modify = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_date_modify = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INV_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RG_ST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cb_year = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_search = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cb_learning_time = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_course = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel_Control = New System.Windows.Forms.Panel()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.btnNewCur = New DevExpress.XtraEditors.TileItem()
        Me.tileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.tileItem4 = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem6 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem7 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem8 = New DevExpress.XtraEditors.TileItem()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Top.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_Control.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Datagridview1)
        Me.Panel1.Controls.Add(Me.Panel_Top)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 589)
        Me.Panel1.TabIndex = 4
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToAddRows = False
        Me.Datagridview1.AllowUserToDeleteRows = False
        Me.Datagridview1.AllowUserToResizeColumns = False
        Me.Datagridview1.AllowUserToResizeRows = False
        Me.Datagridview1.BackgroundColor = System.Drawing.Color.White
        Me.Datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagridview1.ColumnHeadersHeight = 30
        Me.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_edit_group, Me.no, Me.student_name, Me.tel_stu, Me.sok_year, Me.t_ttt, Me.u_name, Me.price_register, Me.u_loginname, Me.g_modify, Me.g_date_modify, Me.INV_ID, Me.RG_ST})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Datagridview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridview1.EnableHeadersVisualStyles = False
        Me.Datagridview1.Location = New System.Drawing.Point(0, 63)
        Me.Datagridview1.MultiSelect = False
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datagridview1.RowHeadersVisible = False
        Me.Datagridview1.RowTemplate.Height = 35
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.Size = New System.Drawing.Size(1378, 526)
        Me.Datagridview1.TabIndex = 23
        '
        'id_edit_group
        '
        Me.id_edit_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_edit_group.HeaderText = "user_id_edit"
        Me.id_edit_group.Name = "id_edit_group"
        Me.id_edit_group.ReadOnly = True
        Me.id_edit_group.Visible = False
        '
        'no
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.no.DefaultCellStyle = DataGridViewCellStyle2
        Me.no.HeaderText = "ລຳດັບ"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.no.Width = 55
        '
        'student_name
        '
        Me.student_name.HeaderText = "ຊື່ນັກສຶກສາ"
        Me.student_name.Name = "student_name"
        Me.student_name.ReadOnly = True
        Me.student_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.student_name.Width = 180
        '
        'tel_stu
        '
        Me.tel_stu.HeaderText = "ເບີໂທລະສັບ"
        Me.tel_stu.Name = "tel_stu"
        Me.tel_stu.ReadOnly = True
        Me.tel_stu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.tel_stu.Width = 110
        '
        'sok_year
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.sok_year.DefaultCellStyle = DataGridViewCellStyle3
        Me.sok_year.HeaderText = "ສົກຮຽນ"
        Me.sok_year.Name = "sok_year"
        Me.sok_year.ReadOnly = True
        '
        't_ttt
        '
        Me.t_ttt.HeaderText = "ຫຼັກສູດ-ສາຂາວິຊາ"
        Me.t_ttt.Name = "t_ttt"
        Me.t_ttt.ReadOnly = True
        Me.t_ttt.Width = 200
        '
        'u_name
        '
        Me.u_name.HeaderText = "ວັນ-ເວລາຮຽນ"
        Me.u_name.Name = "u_name"
        Me.u_name.ReadOnly = True
        Me.u_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.u_name.Width = 200
        '
        'price_register
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        Me.price_register.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_register.HeaderText = "ຄ່າລົງທະບຽນເສັງ"
        Me.price_register.Name = "price_register"
        Me.price_register.ReadOnly = True
        Me.price_register.Width = 110
        '
        'u_loginname
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.u_loginname.DefaultCellStyle = DataGridViewCellStyle5
        Me.u_loginname.HeaderText = "ມື້ສອບເສັງ"
        Me.u_loginname.Name = "u_loginname"
        Me.u_loginname.ReadOnly = True
        Me.u_loginname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'g_modify
        '
        Me.g_modify.HeaderText = "ຜູ້ລົງທະບຽນ"
        Me.g_modify.Name = "g_modify"
        Me.g_modify.ReadOnly = True
        Me.g_modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.g_modify.Width = 110
        '
        'g_date_modify
        '
        Me.g_date_modify.HeaderText = "ມື້ລົງທະບຽນເສັງ"
        Me.g_date_modify.Name = "g_date_modify"
        Me.g_date_modify.ReadOnly = True
        Me.g_date_modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.g_date_modify.Width = 110
        '
        'INV_ID
        '
        Me.INV_ID.HeaderText = "INV_ID"
        Me.INV_ID.Name = "INV_ID"
        Me.INV_ID.ReadOnly = True
        Me.INV_ID.Visible = False
        '
        'RG_ST
        '
        Me.RG_ST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RG_ST.HeaderText = "ສະຖານະ"
        Me.RG_ST.Name = "RG_ST"
        Me.RG_ST.ReadOnly = True
        Me.RG_ST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Panel_Top
        '
        Me.Panel_Top.Controls.Add(Me.Panel4)
        Me.Panel_Top.Controls.Add(Me.Panel5)
        Me.Panel_Top.Controls.Add(Me.Panel3)
        Me.Panel_Top.Controls.Add(Me.Panel2)
        Me.Panel_Top.Controls.Add(Me.Panel_Control)
        Me.Panel_Top.Controls.Add(Me.Button1)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1378, 63)
        Me.Panel_Top.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cb_year)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(94, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(134, 63)
        Me.Panel4.TabIndex = 1
        '
        'cb_year
        '
        Me.cb_year.BackColor = System.Drawing.Color.White
        Me.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_year.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_year.FormattingEnabled = True
        Me.cb_year.Location = New System.Drawing.Point(10, 28)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(115, 29)
        Me.cb_year.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(28, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ສົກຮຽນ-ປີ"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txt_search)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(716, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(202, 63)
        Me.Panel5.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(6, 28)
        Me.txt_search.MaxLength = 200
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(190, 29)
        Me.txt_search.TabIndex = 0
        Me.txt_search.WaterMark = "Search..."
        Me.txt_search.WaterMarkActiveForeColor = System.Drawing.Color.LightGray
        Me.txt_search.WaterMarkFont = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.WaterMarkForeColor = System.Drawing.Color.DarkGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(47, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ຄົ້ນຫາ-ນັກສຶກສາ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cb_learning_time)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(485, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 63)
        Me.Panel3.TabIndex = 3
        '
        'cb_learning_time
        '
        Me.cb_learning_time.BackColor = System.Drawing.Color.White
        Me.cb_learning_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_learning_time.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_learning_time.FormattingEnabled = True
        Me.cb_learning_time.Location = New System.Drawing.Point(9, 28)
        Me.cb_learning_time.Name = "cb_learning_time"
        Me.cb_learning_time.Size = New System.Drawing.Size(208, 29)
        Me.cb_learning_time.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(64, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ວັນເວລາ-ຮຽນ"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cb_course)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(232, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 63)
        Me.Panel2.TabIndex = 2
        '
        'cb_course
        '
        Me.cb_course.BackColor = System.Drawing.Color.White
        Me.cb_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_course.Font = New System.Drawing.Font("Noto Sans Lao", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_course.FormattingEnabled = True
        Me.cb_course.Location = New System.Drawing.Point(4, 28)
        Me.cb_course.Name = "cb_course"
        Me.cb_course.Size = New System.Drawing.Size(240, 29)
        Me.cb_course.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Noto Sans Lao", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(44, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "ຂຶ້ນກັບຫຼັກສູດ-ສາຂາວິຊາ"
        '
        'Panel_Control
        '
        Me.Panel_Control.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel_Control.Controls.Add(Me.btn_print)
        Me.Panel_Control.Controls.Add(Me.btn_add)
        Me.Panel_Control.Controls.Add(Me.btn_edit)
        Me.Panel_Control.Location = New System.Drawing.Point(941, 0)
        Me.Panel_Control.Name = "Panel_Control"
        Me.Panel_Control.Size = New System.Drawing.Size(398, 63)
        Me.Panel_Control.TabIndex = 4
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.White
        Me.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.Location = New System.Drawing.Point(265, 3)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(125, 55)
        Me.btn_print.TabIndex = 22
        Me.btn_print.Text = "Print"
        Me.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.White
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(8, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(117, 55)
        Me.btn_add.TabIndex = 21
        Me.btn_add.Text = "New"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.White
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Image = Global.LOGOS_SYS.My.Resources.Resources.PocketEdit
        Me.btn_edit.Location = New System.Drawing.Point(140, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(117, 55)
        Me.btn_edit.TabIndex = 21
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.LOGOS_SYS.My.Resources.Resources.back50
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 57)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tileGroup1
        '
        Me.tileGroup1.Items.Add(Me.btnNewCur)
        Me.tileGroup1.Items.Add(Me.tileItem3)
        Me.tileGroup1.Items.Add(Me.tileItem4)
        Me.tileGroup1.Name = "tileGroup1"
        '
        'btnNewCur
        '
        Me.btnNewCur.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.btnNewCur.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.btnNewCur.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnNewCur.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileItemElement1.Image = Global.LOGOS_SYS.My.Resources.Resources.new_Ico50
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement1.ImageLocation = New System.Drawing.Point(10, 5)
        TileItemElement1.Text = "ຫຼັກສູດໃໝ່"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement1.TextLocation = New System.Drawing.Point(0, 18)
        Me.btnNewCur.Elements.Add(TileItemElement1)
        Me.btnNewCur.Id = 1
        Me.btnNewCur.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btnNewCur.Name = "btnNewCur"
        '
        'tileItem3
        '
        Me.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.tileItem3.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.tileItem3.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileItem3.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileItemElement2.Image = Global.LOGOS_SYS.My.Resources.Resources.Graduation_Edit
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement2.ImageLocation = New System.Drawing.Point(-10, 5)
        TileItemElement2.Text = "ແກ້ໄຂຫຼັກສູດ"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement2.TextLocation = New System.Drawing.Point(10, 18)
        Me.tileItem3.Elements.Add(TileItemElement2)
        Me.tileItem3.Id = 3
        Me.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileItem3.Name = "tileItem3"
        '
        'tileItem4
        '
        Me.tileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.tileItem4.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.tileItem4.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileItem4.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.Red
        TileItemElement3.Appearance.Normal.Options.UseFont = True
        TileItemElement3.Appearance.Normal.Options.UseForeColor = True
        TileItemElement3.Image = Global.LOGOS_SYS.My.Resources.Resources.Graduation_Del
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement3.ImageLocation = New System.Drawing.Point(-5, 5)
        TileItemElement3.Text = "ລຶບຫຼັກສູດ"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement3.TextLocation = New System.Drawing.Point(10, 18)
        Me.tileItem4.Elements.Add(TileItemElement3)
        Me.tileItem4.Id = 4
        Me.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileItem4.Name = "tileItem4"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Items.Add(Me.TileItem2)
        Me.TileGroup2.Items.Add(Me.TileItem5)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        TileItemElement4.Appearance.Normal.Options.UseFont = True
        TileItemElement4.Appearance.Normal.Options.UseForeColor = True
        TileItemElement4.Image = Global.LOGOS_SYS.My.Resources.Resources.new_Ico50
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement4.ImageLocation = New System.Drawing.Point(10, 5)
        TileItemElement4.Text = "ຫຼັກສູດໃໝ່"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement4.TextLocation = New System.Drawing.Point(0, 18)
        Me.TileItem1.Elements.Add(TileItemElement4)
        Me.TileItem1.Id = 1
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'TileItem2
        '
        Me.TileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileItem2.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem2.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        TileItemElement5.Appearance.Normal.Options.UseFont = True
        TileItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileItemElement5.Image = Global.LOGOS_SYS.My.Resources.Resources.Graduation_Edit
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement5.ImageLocation = New System.Drawing.Point(-10, 5)
        TileItemElement5.Text = "ແກ້ໄຂຫຼັກສູດ"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement5.TextLocation = New System.Drawing.Point(10, 18)
        Me.TileItem2.Elements.Add(TileItemElement5)
        Me.TileItem2.Id = 3
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem2.Name = "TileItem2"
        '
        'TileItem5
        '
        Me.TileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileItem5.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileItem5.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem5.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.Red
        TileItemElement6.Appearance.Normal.Options.UseFont = True
        TileItemElement6.Appearance.Normal.Options.UseForeColor = True
        TileItemElement6.Image = Global.LOGOS_SYS.My.Resources.Resources.Graduation_Del
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement6.ImageLocation = New System.Drawing.Point(-5, 5)
        TileItemElement6.Text = "ລຶບຫຼັກສູດ"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement6.TextLocation = New System.Drawing.Point(10, 18)
        Me.TileItem5.Elements.Add(TileItemElement6)
        Me.TileItem5.Id = 4
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem5.Name = "TileItem5"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.TileItem6)
        Me.TileGroup3.Items.Add(Me.TileItem7)
        Me.TileGroup3.Items.Add(Me.TileItem8)
        Me.TileGroup3.Name = "TileGroup3"
        '
        'TileItem6
        '
        Me.TileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileItem6.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileItem6.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem6.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        TileItemElement7.Appearance.Normal.Options.UseFont = True
        TileItemElement7.Appearance.Normal.Options.UseForeColor = True
        TileItemElement7.Image = Global.LOGOS_SYS.My.Resources.Resources.new_Ico50
        TileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement7.ImageLocation = New System.Drawing.Point(10, 5)
        TileItemElement7.Text = "ຫຼັກສູດໃໝ່"
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement7.TextLocation = New System.Drawing.Point(0, 18)
        Me.TileItem6.Elements.Add(TileItemElement7)
        Me.TileItem6.Id = 1
        Me.TileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem6.Name = "TileItem6"
        '
        'TileItem7
        '
        Me.TileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileItem7.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileItem7.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem7.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement8.Appearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        TileItemElement8.Appearance.Normal.Options.UseFont = True
        TileItemElement8.Appearance.Normal.Options.UseForeColor = True
        TileItemElement8.Image = Global.LOGOS_SYS.My.Resources.Resources.Graduation_Edit
        TileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement8.ImageLocation = New System.Drawing.Point(-10, 5)
        TileItemElement8.Text = "ແກ້ໄຂຫຼັກສູດ"
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement8.TextLocation = New System.Drawing.Point(10, 18)
        Me.TileItem7.Elements.Add(TileItemElement8)
        Me.TileItem7.Id = 3
        Me.TileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem7.Name = "TileItem7"
        '
        'TileItem8
        '
        Me.TileItem8.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileItem8.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileItem8.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem8.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement9.Appearance.Normal.ForeColor = System.Drawing.Color.Red
        TileItemElement9.Appearance.Normal.Options.UseFont = True
        TileItemElement9.Appearance.Normal.Options.UseForeColor = True
        TileItemElement9.Image = Global.LOGOS_SYS.My.Resources.Resources.Graduation_Del
        TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement9.ImageLocation = New System.Drawing.Point(-5, 5)
        TileItemElement9.Text = "ລຶບຫຼັກສູດ"
        TileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement9.TextLocation = New System.Drawing.Point(10, 18)
        Me.TileItem8.Elements.Add(TileItemElement9)
        Me.TileItem8.Id = 4
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem8.Name = "TileItem8"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.AllowRightClickInMenu = False
        Me.BarLargeButtonItem1.Glyph = Global.LOGOS_SYS.My.Resources.Resources.back50
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'FrmStudentEnroll_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmStudentEnroll_view"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Enroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_Control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents tileGroup1 As DevExpress.XtraEditors.TileGroup
    Private WithEvents btnNewCur As DevExpress.XtraEditors.TileItem
    Private WithEvents tileItem3 As DevExpress.XtraEditors.TileItem
    Private WithEvents tileItem4 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Private WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Private WithEvents TileItem6 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem7 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Panel_Control As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_course As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cb_year As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txt_search As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents cb_learning_time As System.Windows.Forms.ComboBox
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents id_edit_group As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents student_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel_stu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sok_year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_ttt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents u_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_register As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents u_loginname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_modify As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_date_modify As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INV_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RG_ST As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
