<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain_Report
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
        Dim TileItemElement23 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement24 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement25 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement26 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement27 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement28 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement29 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement30 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement31 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement32 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement33 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tileControl3 = New DevExpress.XtraEditors.TileControl()
        Me.tileGroup4 = New DevExpress.XtraEditors.TileGroup()
        Me.btn_student = New DevExpress.XtraEditors.TileItem()
        Me.btn_student_trainning = New DevExpress.XtraEditors.TileItem()
        Me.btn_score_inform = New DevExpress.XtraEditors.TileItem()
        Me.btn_print_score = New DevExpress.XtraEditors.TileItem()
        Me.btn_receive_enroll = New DevExpress.XtraEditors.TileItem()
        Me.btn_receive_register = New DevExpress.XtraEditors.TileItem()
        Me.btn_sale_product = New DevExpress.XtraEditors.TileItem()
        Me.btn_debt_term = New DevExpress.XtraEditors.TileItem()
        Me.btn_drop_term = New DevExpress.XtraEditors.TileItem()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem8 = New DevExpress.XtraEditors.TileItem()
        CType(Me.topMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MainMenu.MaxItemId = 3
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
        Me.barDockControlTop.Appearance.BackColor = System.Drawing.Color.White
        Me.barDockControlTop.Appearance.BackColor2 = System.Drawing.Color.White
        Me.barDockControlTop.Appearance.BorderColor = System.Drawing.Color.White
        Me.barDockControlTop.Appearance.Options.UseBackColor = True
        Me.barDockControlTop.Appearance.Options.UseBorderColor = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1303, 65)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 628)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1303, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 65)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 563)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1303, 65)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 563)
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
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 567)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1303, 61)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tileControl3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1303, 502)
        Me.Panel2.TabIndex = 4
        '
        'tileControl3
        '
        Me.tileControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileControl3.DragSize = New System.Drawing.Size(0, 0)
        Me.tileControl3.Groups.Add(Me.tileGroup4)
        Me.tileControl3.ItemSize = 150
        Me.tileControl3.Location = New System.Drawing.Point(0, 0)
        Me.tileControl3.MaxId = 19
        Me.tileControl3.Name = "tileControl3"
        Me.tileControl3.Size = New System.Drawing.Size(1303, 502)
        Me.tileControl3.TabIndex = 1
        Me.tileControl3.Text = "tileControl3"
        '
        'tileGroup4
        '
        Me.tileGroup4.Items.Add(Me.btn_student)
        Me.tileGroup4.Items.Add(Me.btn_student_trainning)
        Me.tileGroup4.Items.Add(Me.btn_score_inform)
        Me.tileGroup4.Items.Add(Me.btn_print_score)
        Me.tileGroup4.Items.Add(Me.btn_receive_enroll)
        Me.tileGroup4.Items.Add(Me.btn_receive_register)
        Me.tileGroup4.Items.Add(Me.btn_sale_product)
        Me.tileGroup4.Items.Add(Me.btn_debt_term)
        Me.tileGroup4.Items.Add(Me.btn_drop_term)
        Me.tileGroup4.Name = "tileGroup4"
        '
        'btn_student
        '
        Me.btn_student.AppearanceItem.Normal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_student.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_student.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_student.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement23.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement23.Appearance.Normal.Options.UseFont = True
        TileItemElement23.Image = Global.LOGOS_SYS.My.Resources.Resources.Scheme11
        TileItemElement23.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement23.Text = "ນັກສຶກສາ-ພາກປົກກະຕິ"
        TileItemElement23.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement23.TextLocation = New System.Drawing.Point(0, -15)
        Me.btn_student.Elements.Add(TileItemElement23)
        Me.btn_student.Id = 6
        Me.btn_student.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btn_student.Name = "btn_student"
        '
        'btn_student_trainning
        '
        TileItemElement24.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement24.Appearance.Hovered.Options.UseFont = True
        TileItemElement24.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement24.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement24.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement24.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement24.Appearance.Normal.Options.UseFont = True
        TileItemElement24.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement24.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement24.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement24.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement24.Appearance.Selected.Options.UseFont = True
        TileItemElement24.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement24.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement24.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement24.Image = Global.LOGOS_SYS.My.Resources.Resources.T001
        TileItemElement24.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement24.ImageLocation = New System.Drawing.Point(0, -10)
        TileItemElement24.Text = "ນັກສຶກສາ-ຮຽນບຳລຸງ"
        TileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement24.TextLocation = New System.Drawing.Point(0, 10)
        Me.btn_student_trainning.Elements.Add(TileItemElement24)
        Me.btn_student_trainning.Id = 8
        Me.btn_student_trainning.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_student_trainning.Name = "btn_student_trainning"
        '
        'btn_score_inform
        '
        Me.btn_score_inform.AppearanceItem.Normal.BackColor = System.Drawing.Color.Purple
        Me.btn_score_inform.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Purple
        Me.btn_score_inform.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_score_inform.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement25.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement25.Appearance.Normal.Options.UseFont = True
        TileItemElement25.Image = Global.LOGOS_SYS.My.Resources.Resources.pa
        TileItemElement25.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement25.ImageLocation = New System.Drawing.Point(0, -5)
        TileItemElement25.Text = "ປະກາດຜົນຄະແນນ"
        TileItemElement25.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement25.TextLocation = New System.Drawing.Point(0, 10)
        Me.btn_score_inform.Elements.Add(TileItemElement25)
        Me.btn_score_inform.Id = 5
        Me.btn_score_inform.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_score_inform.Name = "btn_score_inform"
        '
        'btn_print_score
        '
        TileItemElement26.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement26.Appearance.Hovered.Options.UseFont = True
        TileItemElement26.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement26.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement26.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement26.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement26.Appearance.Normal.Options.UseFont = True
        TileItemElement26.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement26.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement26.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement26.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement26.Appearance.Selected.Options.UseFont = True
        TileItemElement26.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement26.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement26.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement26.Image = Global.LOGOS_SYS.My.Resources.Resources.Subject
        TileItemElement26.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement26.ImageLocation = New System.Drawing.Point(3, 2)
        TileItemElement26.Text = "ພິມໃບຄະແນນ"
        TileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement26.TextLocation = New System.Drawing.Point(0, 5)
        Me.btn_print_score.Elements.Add(TileItemElement26)
        Me.btn_print_score.Id = 12
        Me.btn_print_score.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_print_score.Name = "btn_print_score"
        '
        'btn_receive_enroll
        '
        Me.btn_receive_enroll.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal
        Me.btn_receive_enroll.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement27.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement27.Appearance.Normal.Options.UseFont = True
        TileItemElement27.Image = Global.LOGOS_SYS.My.Resources.Resources.resources11
        TileItemElement27.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement27.ImageLocation = New System.Drawing.Point(0, 15)
        TileItemElement27.Text = "ລາຍຮັບລົງທະບຽນເສັງທຽບ"
        TileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement27.TextLocation = New System.Drawing.Point(0, -7)
        Me.btn_receive_enroll.Elements.Add(TileItemElement27)
        Me.btn_receive_enroll.Id = 18
        Me.btn_receive_enroll.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_receive_enroll.Name = "btn_receive_enroll"
        '
        'btn_receive_register
        '
        Me.btn_receive_register.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_receive_register.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement28.Appearance.Hovered.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement28.Appearance.Hovered.Options.UseFont = True
        TileItemElement28.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement28.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement28.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement28.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement28.Appearance.Normal.ForeColor = System.Drawing.Color.White
        TileItemElement28.Appearance.Normal.Options.UseFont = True
        TileItemElement28.Appearance.Normal.Options.UseForeColor = True
        TileItemElement28.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement28.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement28.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement28.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement28.Appearance.Selected.Options.UseFont = True
        TileItemElement28.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement28.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement28.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement28.Image = Global.LOGOS_SYS.My.Resources.Resources.Time
        TileItemElement28.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement28.ImageLocation = New System.Drawing.Point(0, -5)
        TileItemElement28.Text = "ລາຍຮັບລົງທະບຽນຮຽນ"
        TileItemElement28.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement28.TextLocation = New System.Drawing.Point(0, 8)
        Me.btn_receive_register.Elements.Add(TileItemElement28)
        Me.btn_receive_register.Id = 13
        Me.btn_receive_register.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_receive_register.Name = "btn_receive_register"
        '
        'btn_sale_product
        '
        Me.btn_sale_product.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sale_product.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sale_product.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_sale_product.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement29.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement29.Appearance.Hovered.Options.UseFont = True
        TileItemElement29.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement29.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement29.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement29.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement29.Appearance.Normal.Options.UseFont = True
        TileItemElement29.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement29.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement29.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement29.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement29.Appearance.Selected.Options.UseFont = True
        TileItemElement29.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement29.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement29.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement29.Image = Global.LOGOS_SYS.My.Resources.Resources.Suite
        TileItemElement29.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement29.ImageLocation = New System.Drawing.Point(0, -15)
        TileItemElement29.Text = "ລາຍຮັບຂາຍອຸປະກອນຮຽນ"
        TileItemElement29.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement29.TextLocation = New System.Drawing.Point(0, 8)
        Me.btn_sale_product.Elements.Add(TileItemElement29)
        Me.btn_sale_product.Id = 1
        Me.btn_sale_product.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_sale_product.Name = "btn_sale_product"
        '
        'btn_debt_term
        '
        Me.btn_debt_term.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_debt_term.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement30.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement30.Appearance.Hovered.Options.UseFont = True
        TileItemElement30.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement30.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement30.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement30.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement30.Appearance.Normal.Options.UseFont = True
        TileItemElement30.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement30.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement30.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement30.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement30.Appearance.Selected.Options.UseFont = True
        TileItemElement30.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement30.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement30.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement30.Image = Global.LOGOS_SYS.My.Resources.Resources.Subject_InTerm
        TileItemElement30.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement30.Text = "ຕິດໜີ້ຄ່າຮຽນ"
        TileItemElement30.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.btn_debt_term.Elements.Add(TileItemElement30)
        Me.btn_debt_term.Id = 14
        Me.btn_debt_term.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_debt_term.Name = "btn_debt_term"
        '
        'btn_drop_term
        '
        Me.btn_drop_term.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray
        Me.btn_drop_term.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray
        Me.btn_drop_term.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_drop_term.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement31.Appearance.Hovered.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement31.Appearance.Hovered.Options.UseFont = True
        TileItemElement31.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement31.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement31.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement31.Appearance.Normal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement31.Appearance.Normal.Options.UseFont = True
        TileItemElement31.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement31.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement31.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement31.Appearance.Selected.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement31.Appearance.Selected.Options.UseFont = True
        TileItemElement31.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement31.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement31.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement31.Image = Global.LOGOS_SYS.My.Resources.Resources.Drop
        TileItemElement31.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement31.Text = "Drop Term"
        TileItemElement31.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement31.TextLocation = New System.Drawing.Point(0, 5)
        Me.btn_drop_term.Elements.Add(TileItemElement31)
        Me.btn_drop_term.Id = 2
        Me.btn_drop_term.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_drop_term.Name = "btn_drop_term"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement32.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement32.Appearance.Normal.Options.UseFont = True
        TileItemElement32.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement32.ImageLocation = New System.Drawing.Point(0, -8)
        TileItemElement32.Text = "ເທີມຮຽນ"
        TileItemElement32.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement32.TextLocation = New System.Drawing.Point(0, 8)
        Me.TileItem1.Elements.Add(TileItemElement32)
        Me.TileItem1.Id = 1
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem1.Name = "TileItem1"
        '
        'TileItem8
        '
        Me.TileItem8.AppearanceItem.Normal.BackColor = System.Drawing.Color.Purple
        Me.TileItem8.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Purple
        Me.TileItem8.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem8.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement33.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement33.Appearance.Normal.Options.UseFont = True
        TileItemElement33.Image = Global.LOGOS_SYS.My.Resources.Resources.folders1
        TileItemElement33.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement33.ImageLocation = New System.Drawing.Point(0, -25)
        TileItemElement33.Text = "ລາຍການອຸປະກອນຂາຍ"
        TileItemElement33.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement33.TextLocation = New System.Drawing.Point(0, 10)
        Me.TileItem8.Elements.Add(TileItemElement33)
        Me.TileItem8.Id = 5
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem8.Name = "TileItem8"
        '
        'frmMain_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 628)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain_Report"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.topMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents tileControl3 As DevExpress.XtraEditors.TileControl
    Private WithEvents tileGroup4 As DevExpress.XtraEditors.TileGroup
    Private WithEvents btn_score_inform As DevExpress.XtraEditors.TileItem
    Private WithEvents btn_student As DevExpress.XtraEditors.TileItem
    Private WithEvents btn_sale_product As DevExpress.XtraEditors.TileItem
    Private WithEvents btn_drop_term As DevExpress.XtraEditors.TileItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_student_trainning As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_print_score As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_receive_register As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_debt_term As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_receive_enroll As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
End Class
