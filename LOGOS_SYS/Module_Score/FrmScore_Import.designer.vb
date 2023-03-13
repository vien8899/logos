<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScore_Import
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.cb_term = New System.Windows.Forms.ComboBox()
        Me.school_year2 = New System.Windows.Forms.NumericUpDown()
        Me.school_year1 = New System.Windows.Forms.NumericUpDown()
        Me.buttonMenu = New DevExpress.XtraEditors.TileControl()
        Me.tileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.btnSearch = New DevExpress.XtraEditors.TileItem()
        Me.btnImport = New DevExpress.XtraEditors.TileItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cb_subject = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.student_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_course = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.btn_scheme = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.topMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.MainMenu = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnBack = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panel5.SuspendLayout()
        CType(Me.school_year2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.school_year1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.topMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.cb_term)
        Me.panel5.Controls.Add(Me.school_year2)
        Me.panel5.Controls.Add(Me.school_year1)
        Me.panel5.Controls.Add(Me.buttonMenu)
        Me.panel5.Controls.Add(Me.Label1)
        Me.panel5.Controls.Add(Me.Label4)
        Me.panel5.Controls.Add(Me.Label3)
        Me.panel5.Controls.Add(Me.label2)
        Me.panel5.Controls.Add(Me.cb_subject)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel5.Location = New System.Drawing.Point(0, 1)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(1290, 89)
        Me.panel5.TabIndex = 0
        '
        'cb_term
        '
        Me.cb_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_term.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_term.FormattingEnabled = True
        Me.cb_term.Location = New System.Drawing.Point(470, 7)
        Me.cb_term.Name = "cb_term"
        Me.cb_term.Size = New System.Drawing.Size(109, 34)
        Me.cb_term.TabIndex = 9
        '
        'school_year2
        '
        Me.school_year2.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.school_year2.Location = New System.Drawing.Point(245, 7)
        Me.school_year2.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.school_year2.Name = "school_year2"
        Me.school_year2.ReadOnly = True
        Me.school_year2.Size = New System.Drawing.Size(141, 34)
        Me.school_year2.TabIndex = 8
        Me.school_year2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.school_year2.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'school_year1
        '
        Me.school_year1.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.school_year1.Location = New System.Drawing.Point(82, 7)
        Me.school_year1.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.school_year1.Name = "school_year1"
        Me.school_year1.ReadOnly = True
        Me.school_year1.Size = New System.Drawing.Size(141, 34)
        Me.school_year1.TabIndex = 8
        Me.school_year1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.school_year1.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'buttonMenu
        '
        Me.buttonMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonMenu.AppearanceGroupHighlighting.HoveredMaskColor = System.Drawing.SystemColors.Control
        Me.buttonMenu.AppearanceGroupHighlighting.MaskColor = System.Drawing.SystemColors.Control
        Me.buttonMenu.BackColor = System.Drawing.SystemColors.Control
        Me.buttonMenu.DragSize = New System.Drawing.Size(0, 0)
        Me.buttonMenu.Groups.Add(Me.tileGroup3)
        Me.buttonMenu.ItemPadding = New System.Windows.Forms.Padding(0)
        Me.buttonMenu.ItemSize = 80
        Me.buttonMenu.Location = New System.Drawing.Point(585, 2)
        Me.buttonMenu.MaxId = 8
        Me.buttonMenu.Name = "buttonMenu"
        Me.buttonMenu.Padding = New System.Windows.Forms.Padding(5, 5, 18, 0)
        Me.buttonMenu.Size = New System.Drawing.Size(329, 86)
        Me.buttonMenu.TabIndex = 7
        Me.buttonMenu.Text = "tileControl3"
        '
        'tileGroup3
        '
        Me.tileGroup3.Items.Add(Me.btnSearch)
        Me.tileGroup3.Items.Add(Me.btnImport)
        Me.tileGroup3.Name = "tileGroup3"
        '
        'btnSearch
        '
        Me.btnSearch.AppearanceItem.Hovered.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnSearch.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.AppearanceItem.Normal.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSearch.AppearanceItem.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnSearch.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.btnSearch.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Black
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileItemElement1.Image = Global.LOGOS_SYS.My.Resources.Resources.search55
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement1.ImageLocation = New System.Drawing.Point(0, 1)
        TileItemElement1.Text = "ຄົ້ນຫາ"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.btnSearch.Elements.Add(TileItemElement1)
        Me.btnSearch.Id = 3
        Me.btnSearch.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btnSearch.Name = "btnSearch"
        '
        'btnImport
        '
        Me.btnImport.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.Control
        Me.btnImport.AppearanceItem.Normal.BorderColor = System.Drawing.SystemColors.Control
        Me.btnImport.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnImport.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Black
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileItemElement2.Image = Global.LOGOS_SYS.My.Resources.Resources.Excel55
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement2.Text = "Import from Excel"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
        TileItemElement2.TextLocation = New System.Drawing.Point(-25, -4)
        Me.btnImport.Elements.Add(TileItemElement2)
        Me.btnImport.Id = 2
        Me.btnImport.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btnImport.Name = "btnImport"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(390, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ເລືອກເທີມ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ສົກຮຽນ"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(35, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(36, 26)
        Me.label2.TabIndex = 4
        Me.label2.Text = "ວິຊາ"
        '
        'cb_subject
        '
        Me.cb_subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subject.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_subject.FormattingEnabled = True
        Me.cb_subject.Location = New System.Drawing.Point(82, 47)
        Me.cb_subject.Name = "cb_subject"
        Me.cb_subject.Size = New System.Drawing.Size(497, 34)
        Me.cb_subject.TabIndex = 3
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.student_code, Me.dataGridViewTextBoxColumn3, Me.Column3, Me.Column2, Me.Column4, Me.student_id, Me.Column5})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 35
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1290, 390)
        Me.DGV.TabIndex = 19
        '
        'student_code
        '
        Me.student_code.DataPropertyName = "student_code"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student_code.DefaultCellStyle = DataGridViewCellStyle2
        Me.student_code.HeaderText = "ລະຫັດນັກສຶກສາ"
        Me.student_code.Name = "student_code"
        Me.student_code.ReadOnly = True
        Me.student_code.Width = 150
        '
        'dataGridViewTextBoxColumn3
        '
        Me.dataGridViewTextBoxColumn3.DataPropertyName = "student_fullname_la"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewTextBoxColumn3.HeaderText = "ຊື່ ແລະ ນາມສະກຸນ"
        Me.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3"
        Me.dataGridViewTextBoxColumn3.ReadOnly = True
        Me.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dataGridViewTextBoxColumn3.Width = 350
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "student_fullname_en"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Name & Surname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 400
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "score"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column2.HeaderText = "ຄະແນນ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "grade"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "ເກຣດ"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 70
        '
        'student_id
        '
        Me.student_id.DataPropertyName = "student_id"
        Me.student_id.HeaderText = "student_id"
        Me.student_id.Name = "student_id"
        Me.student_id.ReadOnly = True
        Me.student_id.Visible = False
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btn_course
        '
        Me.btn_course.AppearanceButton.Hovered.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_course.AppearanceButton.Hovered.Options.UseFont = True
        Me.btn_course.AppearanceButton.Normal.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_course.AppearanceButton.Normal.Options.UseFont = True
        Me.btn_course.AppearanceButton.Pressed.BackColor = System.Drawing.Color.White
        Me.btn_course.AppearanceButton.Pressed.BorderColor = System.Drawing.Color.White
        Me.btn_course.AppearanceButton.Pressed.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_course.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.btn_course.AppearanceButton.Pressed.Options.UseBorderColor = True
        Me.btn_course.AppearanceButton.Pressed.Options.UseFont = True
        Me.btn_course.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_course.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_course.Location = New System.Drawing.Point(341, 0)
        Me.btn_course.Name = "btn_course"
        Me.btn_course.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_course.Size = New System.Drawing.Size(863, 79)
        Me.btn_course.TabIndex = 4
        Me.btn_course.Text = "windowsUIButtonPanel2"
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel4.Location = New System.Drawing.Point(340, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(1, 79)
        Me.panel4.TabIndex = 0
        '
        'btn_scheme
        '
        Me.btn_scheme.AppearanceButton.Hovered.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scheme.AppearanceButton.Hovered.Options.UseFont = True
        Me.btn_scheme.AppearanceButton.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scheme.AppearanceButton.Normal.Options.UseFont = True
        Me.btn_scheme.AppearanceButton.Pressed.BackColor = System.Drawing.Color.White
        Me.btn_scheme.AppearanceButton.Pressed.BorderColor = System.Drawing.Color.White
        Me.btn_scheme.AppearanceButton.Pressed.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scheme.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.btn_scheme.AppearanceButton.Pressed.Options.UseBorderColor = True
        Me.btn_scheme.AppearanceButton.Pressed.Options.UseFont = True
        Me.btn_scheme.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("    ຊັ້ນສູງ    ", Global.LOGOS_SYS.My.Resources.Resources.Education20, -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, "HDPM01", 1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ປະລິນຍາຕີ", Global.LOGOS_SYS.My.Resources.Resources.Graduation20, -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, "BLDG01", 1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ປະລິນຍາໂທ", Global.LOGOS_SYS.My.Resources.Resources.Graduation20, -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, "MTDG01", 1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ປະລິນຍາເອກ", Global.LOGOS_SYS.My.Resources.Resources.Graduation20, -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, "DTGD01", 1, False, False)})
        Me.btn_scheme.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_scheme.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_scheme.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scheme.Location = New System.Drawing.Point(0, 0)
        Me.btn_scheme.Name = "btn_scheme"
        Me.btn_scheme.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_scheme.Size = New System.Drawing.Size(340, 79)
        Me.btn_scheme.TabIndex = 1
        Me.btn_scheme.Text = "WindowsUIButtonPanel1"
        '
        'panel2
        '
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 562)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1290, 52)
        Me.panel2.TabIndex = 2
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.panel5)
        Me.panel1.Controls.Add(Me.Panel8)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1290, 91)
        Me.panel1.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1290, 1)
        Me.Panel8.TabIndex = 0
        '
        'topMenu
        '
        Me.topMenu.Manager = Me.MainMenu
        Me.topMenu.Name = "topMenu"
        '
        'MainMenu
        '
        Me.MainMenu.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.MainMenu.DockControls.Add(Me.barDockControlTop)
        Me.MainMenu.DockControls.Add(Me.barDockControlBottom)
        Me.MainMenu.DockControls.Add(Me.barDockControlLeft)
        Me.MainMenu.DockControls.Add(Me.barDockControlRight)
        Me.MainMenu.Form = Me
        Me.MainMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.btnBack, Me.SkinBarSubItem1})
        Me.MainMenu.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "MainMenu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnBack)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "MainMenu"
        '
        'btnBack
        '
        Me.btnBack.AllowRightClickInMenu = False
        Me.btnBack.Glyph = Global.LOGOS_SYS.My.Resources.Resources.back50
        Me.btnBack.Id = 1
        Me.btnBack.Name = "btnBack"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.barDockControlTop.Appearance.BackColor2 = System.Drawing.SystemColors.Control
        Me.barDockControlTop.Appearance.BorderColor = System.Drawing.SystemColors.Control
        Me.barDockControlTop.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.barDockControlTop.Appearance.Options.UseBackColor = True
        Me.barDockControlTop.Appearance.Options.UseBorderColor = True
        Me.barDockControlTop.Appearance.Options.UseFont = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1290, 80)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 614)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1290, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 80)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 534)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1290, 80)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 534)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Caption = "SkinBarSubItem1"
        Me.SkinBarSubItem1.Id = 2
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.panel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 80)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1290, 92)
        Me.Panel6.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DGV)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 172)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1290, 390)
        Me.Panel7.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btn_course)
        Me.Panel3.Controls.Add(Me.panel4)
        Me.Panel3.Controls.Add(Me.btn_scheme)
        Me.Panel3.Location = New System.Drawing.Point(86, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1204, 79)
        Me.Panel3.TabIndex = 14
        '
        'FrmScore_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 614)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmScore_Import"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        CType(Me.school_year2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.school_year1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.topMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel5 As System.Windows.Forms.Panel
    Private WithEvents buttonMenu As DevExpress.XtraEditors.TileControl
    Private WithEvents tileGroup3 As DevExpress.XtraEditors.TileGroup
    Private WithEvents btnSearch As DevExpress.XtraEditors.TileItem
    Private WithEvents btnImport As DevExpress.XtraEditors.TileItem
    Private WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents DGV As System.Windows.Forms.DataGridView
    Private WithEvents btn_course As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_scheme As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents topMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents MainMenu As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnBack As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel8 As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cb_subject As System.Windows.Forms.ComboBox
    Public WithEvents cb_term As System.Windows.Forms.ComboBox
    Friend WithEvents student_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents student_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents school_year1 As System.Windows.Forms.NumericUpDown
    Public WithEvents school_year2 As System.Windows.Forms.NumericUpDown
End Class
