<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain_Trainning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain_Trainning))
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
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
        Me.btn_train_course = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_student = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_assign_class = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_class = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_time = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_openReg = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_enroll = New DevExpress.XtraEditors.TileItem()
        Me.btn_train_register = New DevExpress.XtraEditors.TileItem()
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
        Me.tileGroup4.Items.Add(Me.btn_train_course)
        Me.tileGroup4.Items.Add(Me.btn_train_student)
        Me.tileGroup4.Items.Add(Me.btn_train_assign_class)
        Me.tileGroup4.Items.Add(Me.btn_train_class)
        Me.tileGroup4.Items.Add(Me.btn_train_time)
        Me.tileGroup4.Items.Add(Me.btn_train_openReg)
        Me.tileGroup4.Items.Add(Me.btn_train_enroll)
        Me.tileGroup4.Items.Add(Me.btn_train_register)
        Me.tileGroup4.Name = "tileGroup4"
        '
        'btn_train_course
        '
        Me.btn_train_course.AppearanceItem.Normal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_train_course.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_train_course.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_train_course.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Image = Global.LOGOS_SYS.My.Resources.Resources.Scheme11
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement1.Text = "ຫຼັກສູດ-ວິຊາຮຽນບຳລຸງ"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement1.TextLocation = New System.Drawing.Point(0, -15)
        Me.btn_train_course.Elements.Add(TileItemElement1)
        Me.btn_train_course.Id = 6
        Me.btn_train_course.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btn_train_course.Name = "btn_train_course"
        '
        'btn_train_student
        '
        TileItemElement2.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement2.Appearance.Hovered.Options.UseFont = True
        TileItemElement2.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement2.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement2.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement2.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement2.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement2.Appearance.Selected.Options.UseFont = True
        TileItemElement2.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement2.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement2.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement2.ImageLocation = New System.Drawing.Point(0, 2)
        TileItemElement2.Text = "ນັກສຶກສາ"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.btn_train_student.Elements.Add(TileItemElement2)
        Me.btn_train_student.Id = 8
        Me.btn_train_student.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_train_student.Name = "btn_train_student"
        '
        'btn_train_assign_class
        '
        Me.btn_train_assign_class.AppearanceItem.Normal.BackColor = System.Drawing.Color.Purple
        Me.btn_train_assign_class.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Purple
        Me.btn_train_assign_class.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_train_assign_class.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement3.Appearance.Normal.Options.UseFont = True
        TileItemElement3.Image = Global.LOGOS_SYS.My.Resources.Resources.T001
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement3.ImageLocation = New System.Drawing.Point(0, -7)
        TileItemElement3.Text = "ຈັດຫ້ອງຮຽນ"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement3.TextLocation = New System.Drawing.Point(0, 10)
        Me.btn_train_assign_class.Elements.Add(TileItemElement3)
        Me.btn_train_assign_class.Id = 5
        Me.btn_train_assign_class.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_train_assign_class.Name = "btn_train_assign_class"
        '
        'btn_train_class
        '
        Me.btn_train_class.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray
        Me.btn_train_class.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray
        Me.btn_train_class.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_train_class.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement4.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement4.Appearance.Hovered.Options.UseFont = True
        TileItemElement4.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement4.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement4.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement4.Appearance.Normal.Options.UseFont = True
        TileItemElement4.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement4.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement4.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement4.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement4.Appearance.Selected.Options.UseFont = True
        TileItemElement4.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement4.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement4.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement4.Image = Global.LOGOS_SYS.My.Resources.Resources.Class11
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement4.ImageLocation = New System.Drawing.Point(0, -10)
        TileItemElement4.Text = "ຫ້ອງຮຽນ"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement4.TextLocation = New System.Drawing.Point(0, 5)
        Me.btn_train_class.Elements.Add(TileItemElement4)
        Me.btn_train_class.Id = 2
        Me.btn_train_class.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_train_class.Name = "btn_train_class"
        '
        'btn_train_time
        '
        Me.btn_train_time.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_train_time.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement5.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement5.Appearance.Hovered.Options.UseFont = True
        TileItemElement5.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement5.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement5.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.White
        TileItemElement5.Appearance.Normal.Options.UseFont = True
        TileItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileItemElement5.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement5.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement5.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement5.Appearance.Selected.Options.UseFont = True
        TileItemElement5.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement5.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement5.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement5.Image = Global.LOGOS_SYS.My.Resources.Resources.Time
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement5.ImageLocation = New System.Drawing.Point(0, -5)
        TileItemElement5.Text = "ເວລາຮຽນ"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement5.TextLocation = New System.Drawing.Point(0, 8)
        Me.btn_train_time.Elements.Add(TileItemElement5)
        Me.btn_train_time.Id = 13
        Me.btn_train_time.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_train_time.Name = "btn_train_time"
        '
        'btn_train_openReg
        '
        Me.btn_train_openReg.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal
        Me.btn_train_openReg.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement6.Appearance.Normal.Options.UseFont = True
        TileItemElement6.Image = Global.LOGOS_SYS.My.Resources.Resources.Open_Close
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement6.Text = "ເປີດ-ປິດ ການລົງທະບຽນ"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement6.TextLocation = New System.Drawing.Point(0, -7)
        Me.btn_train_openReg.Elements.Add(TileItemElement6)
        Me.btn_train_openReg.Id = 18
        Me.btn_train_openReg.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btn_train_openReg.Name = "btn_train_openReg"
        '
        'btn_train_enroll
        '
        Me.btn_train_enroll.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_train_enroll.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_train_enroll.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btn_train_enroll.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement7.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement7.Appearance.Hovered.Options.UseFont = True
        TileItemElement7.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement7.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement7.Appearance.Normal.Options.UseFont = True
        TileItemElement7.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement7.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement7.Appearance.Selected.Options.UseFont = True
        TileItemElement7.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement7.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.Image = Global.LOGOS_SYS.My.Resources.Resources.resources11
        TileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement7.ImageLocation = New System.Drawing.Point(0, -15)
        TileItemElement7.Text = "ລົງທະບຽນເສັງ"
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement7.TextLocation = New System.Drawing.Point(0, 8)
        Me.btn_train_enroll.Elements.Add(TileItemElement7)
        Me.btn_train_enroll.Id = 1
        Me.btn_train_enroll.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_train_enroll.Name = "btn_train_enroll"
        '
        'btn_train_register
        '
        Me.btn_train_register.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_train_register.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement8.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement8.Appearance.Hovered.Options.UseFont = True
        TileItemElement8.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement8.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement8.Appearance.Normal.Options.UseFont = True
        TileItemElement8.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement8.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement8.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement8.Appearance.Selected.Options.UseFont = True
        TileItemElement8.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement8.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement8.Image = Global.LOGOS_SYS.My.Resources.Resources.Subject_InTerm
        TileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement8.Text = "ລົງທະບຽນຮຽນ"
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.btn_train_register.Elements.Add(TileItemElement8)
        Me.btn_train_register.Id = 14
        Me.btn_train_register.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btn_train_register.Name = "btn_train_register"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement9.Appearance.Normal.Options.UseFont = True
        TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement9.ImageLocation = New System.Drawing.Point(0, -8)
        TileItemElement9.Text = "ເທີມຮຽນ"
        TileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement9.TextLocation = New System.Drawing.Point(0, 8)
        Me.TileItem1.Elements.Add(TileItemElement9)
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
        TileItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement10.Appearance.Normal.Options.UseFont = True
        TileItemElement10.Image = Global.LOGOS_SYS.My.Resources.Resources.folders1
        TileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement10.ImageLocation = New System.Drawing.Point(0, -25)
        TileItemElement10.Text = "ລາຍການອຸປະກອນຂາຍ"
        TileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement10.TextLocation = New System.Drawing.Point(0, 10)
        Me.TileItem8.Elements.Add(TileItemElement10)
        Me.TileItem8.Id = 5
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem8.Name = "TileItem8"
        '
        'frmMain_Trainning
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
        Me.Name = "frmMain_Trainning"
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
    Private WithEvents btn_train_assign_class As DevExpress.XtraEditors.TileItem
    Private WithEvents btn_train_course As DevExpress.XtraEditors.TileItem
    Private WithEvents btn_train_enroll As DevExpress.XtraEditors.TileItem
    Private WithEvents btn_train_class As DevExpress.XtraEditors.TileItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_train_student As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_train_time As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_train_register As DevExpress.XtraEditors.TileItem
    Friend WithEvents btn_train_openReg As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
End Class
