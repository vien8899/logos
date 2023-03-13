<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserGroup_edit
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserGroup_edit))
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
        Me.no = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.g_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Work_Module = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permission_id_edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_groupname = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txt_group_des = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_disable = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_count_useringroup = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
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
        Me.Panel1.SuspendLayout()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Datagridview1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 650)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagridview1.ColumnHeadersHeight = 30
        Me.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.g_name, Me.g_des, Me.Work_Module, Me.permission_id_edit})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datagridview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridview1.EnableHeadersVisualStyles = False
        Me.Datagridview1.Location = New System.Drawing.Point(0, 140)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datagridview1.RowHeadersVisible = False
        Me.Datagridview1.RowTemplate.Height = 35
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.Size = New System.Drawing.Size(885, 510)
        Me.Datagridview1.TabIndex = 1
        '
        'no
        '
        Me.no.HeaderText = "Check"
        Me.no.Name = "no"
        Me.no.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.no.Width = 65
        '
        'g_name
        '
        Me.g_name.HeaderText = "Permission-Name"
        Me.g_name.Name = "g_name"
        Me.g_name.ReadOnly = True
        Me.g_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.g_name.Width = 250
        '
        'g_des
        '
        DataGridViewCellStyle2.Format = "#,##0 kip"
        Me.g_des.DefaultCellStyle = DataGridViewCellStyle2
        Me.g_des.HeaderText = "Description"
        Me.g_des.Name = "g_des"
        Me.g_des.ReadOnly = True
        Me.g_des.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.g_des.Width = 420
        '
        'Work_Module
        '
        Me.Work_Module.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Work_Module.HeaderText = "Work-Module"
        Me.Work_Module.Name = "Work_Module"
        Me.Work_Module.ReadOnly = True
        Me.Work_Module.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'permission_id_edit
        '
        Me.permission_id_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.permission_id_edit.HeaderText = "permission_id"
        Me.permission_id_edit.Name = "permission_id_edit"
        Me.permission_id_edit.ReadOnly = True
        Me.permission_id_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.permission_id_edit.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_groupname)
        Me.Panel2.Controls.Add(Me.txt_group_des)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_disable)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lb_count_useringroup)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(885, 140)
        Me.Panel2.TabIndex = 0
        '
        'txt_groupname
        '
        Me.txt_groupname.Location = New System.Drawing.Point(238, 8)
        Me.txt_groupname.Name = "txt_groupname"
        Me.txt_groupname.Size = New System.Drawing.Size(242, 26)
        Me.txt_groupname.TabIndex = 0
        Me.txt_groupname.WaterMark = "Enter..."
        Me.txt_groupname.WaterMarkActiveForeColor = System.Drawing.Color.LightGray
        Me.txt_groupname.WaterMarkFont = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_groupname.WaterMarkForeColor = System.Drawing.Color.DarkGray
        '
        'txt_group_des
        '
        Me.txt_group_des.Location = New System.Drawing.Point(238, 39)
        Me.txt_group_des.Name = "txt_group_des"
        Me.txt_group_des.Size = New System.Drawing.Size(426, 26)
        Me.txt_group_des.TabIndex = 1
        Me.txt_group_des.WaterMark = "Enter..."
        Me.txt_group_des.WaterMarkActiveForeColor = System.Drawing.Color.LightGray
        Me.txt_group_des.WaterMarkFont = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_group_des.WaterMarkForeColor = System.Drawing.Color.DarkGray
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.White
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = Global.LOGOS_SYS.My.Resources.Resources.PocketEdit
        Me.btn_save.Location = New System.Drawing.Point(238, 73)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(117, 55)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_disable
        '
        Me.btn_disable.BackColor = System.Drawing.Color.White
        Me.btn_disable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_disable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_disable.FlatAppearance.BorderSize = 0
        Me.btn_disable.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_disable.Image = CType(resources.GetObject("btn_disable.Image"), System.Drawing.Image)
        Me.btn_disable.Location = New System.Drawing.Point(363, 73)
        Me.btn_disable.Name = "btn_disable"
        Me.btn_disable.Size = New System.Drawing.Size(117, 55)
        Me.btn_disable.TabIndex = 3
        Me.btn_disable.Text = "Cancel"
        Me.btn_disable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_disable.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Group Description"
        '
        'lb_count_useringroup
        '
        Me.lb_count_useringroup.AutoSize = True
        Me.lb_count_useringroup.Location = New System.Drawing.Point(486, 11)
        Me.lb_count_useringroup.Name = "lb_count_useringroup"
        Me.lb_count_useringroup.Size = New System.Drawing.Size(54, 19)
        Me.lb_count_useringroup.TabIndex = 22
        Me.lb_count_useringroup.Text = "User(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Group Name"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.AllowRightClickInMenu = False
        Me.BarLargeButtonItem1.Glyph = Global.LOGOS_SYS.My.Resources.Resources.back50
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
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
        'FrmUserGroup_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserGroup_edit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit user group"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
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
    Friend WithEvents btn_disable As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_groupname As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents txt_group_des As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents lb_count_useringroup As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents g_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Work_Module As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents permission_id_edit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
