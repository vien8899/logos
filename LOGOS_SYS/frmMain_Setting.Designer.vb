﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain_Setting
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
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain_Setting))
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement12 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement13 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
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
        Me.btnManageGroup = New DevExpress.XtraEditors.TileItem()
        Me.btnEmp = New DevExpress.XtraEditors.TileItem()
        Me.btnDEclass = New DevExpress.XtraEditors.TileItem()
        Me.tileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem7 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.btnSetting = New DevExpress.XtraEditors.TileItem()
        Me.TileItem4 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem6 = New DevExpress.XtraEditors.TileItem()
        Me.btnPermision = New DevExpress.XtraEditors.TileItem()
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
        Me.tileGroup4.Items.Add(Me.btnManageGroup)
        Me.tileGroup4.Items.Add(Me.btnEmp)
        Me.tileGroup4.Items.Add(Me.btnDEclass)
        Me.tileGroup4.Items.Add(Me.tileItem2)
        Me.tileGroup4.Items.Add(Me.TileItem7)
        Me.tileGroup4.Items.Add(Me.TileItem3)
        Me.tileGroup4.Items.Add(Me.btnSetting)
        Me.tileGroup4.Items.Add(Me.TileItem4)
        Me.tileGroup4.Items.Add(Me.TileItem5)
        Me.tileGroup4.Items.Add(Me.TileItem6)
        Me.tileGroup4.Items.Add(Me.btnPermision)
        Me.tileGroup4.Name = "tileGroup4"
        '
        'btnManageGroup
        '
        Me.btnManageGroup.AppearanceItem.Normal.BackColor = System.Drawing.Color.Chocolate
        Me.btnManageGroup.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Chocolate
        Me.btnManageGroup.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnManageGroup.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Image = Global.LOGOS_SYS.My.Resources.Resources.user_group
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement1.ImageLocation = New System.Drawing.Point(-10, 0)
        TileItemElement1.Text = "ກຸ່ມຜູ້ໃຊ້ລະບົບ"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.TextLocation = New System.Drawing.Point(60, 0)
        Me.btnManageGroup.Elements.Add(TileItemElement1)
        Me.btnManageGroup.Id = 4
        Me.btnManageGroup.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btnManageGroup.Name = "btnManageGroup"
        '
        'btnEmp
        '
        Me.btnEmp.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green
        Me.btnEmp.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Green
        Me.btnEmp.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnEmp.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Image = Global.LOGOS_SYS.My.Resources.Resources.user1
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement2.ImageLocation = New System.Drawing.Point(-10, 0)
        TileItemElement2.Text = "ຂໍ້ມູນຜູ້ໃຊ້"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement2.TextLocation = New System.Drawing.Point(50, 0)
        Me.btnEmp.Elements.Add(TileItemElement2)
        Me.btnEmp.Id = 0
        Me.btnEmp.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btnEmp.Name = "btnEmp"
        '
        'btnDEclass
        '
        Me.btnDEclass.AppearanceItem.Normal.BackColor = System.Drawing.Color.Purple
        Me.btnDEclass.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Purple
        Me.btnDEclass.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnDEclass.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement3.Appearance.Normal.Options.UseFont = True
        TileItemElement3.Image = Global.LOGOS_SYS.My.Resources.Resources.folders1
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement3.ImageLocation = New System.Drawing.Point(0, -25)
        TileItemElement3.Text = "ລາຍການອຸປະກອນຂາຍ"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement3.TextLocation = New System.Drawing.Point(0, 10)
        Me.btnDEclass.Elements.Add(TileItemElement3)
        Me.btnDEclass.Id = 5
        Me.btnDEclass.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btnDEclass.Name = "btnDEclass"
        '
        'tileItem2
        '
        Me.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.tileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.tileItem2.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileItem2.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement4.Appearance.Normal.Options.UseFont = True
        TileItemElement4.Image = Global.LOGOS_SYS.My.Resources.Resources.Scheme11
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement4.Text = "ຫຼັກສູດການຮຽນ"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement4.TextLocation = New System.Drawing.Point(0, -15)
        Me.tileItem2.Elements.Add(TileItemElement4)
        Me.tileItem2.Id = 6
        Me.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.tileItem2.Name = "tileItem2"
        '
        'TileItem7
        '
        Me.TileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal
        Me.TileItem7.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement5.Appearance.Normal.Options.UseFont = True
        TileItemElement5.Image = Global.LOGOS_SYS.My.Resources.Resources.Open_Close
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement5.Text = "ເປີດ-ປິດ ການລົງທະບຽນ"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement5.TextLocation = New System.Drawing.Point(0, -7)
        Me.TileItem7.Elements.Add(TileItemElement5)
        Me.TileItem7.Id = 18
        Me.TileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem7.Name = "TileItem7"
        '
        'TileItem3
        '
        TileItemElement6.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement6.Appearance.Hovered.Options.UseFont = True
        TileItemElement6.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement6.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement6.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement6.Appearance.Normal.Options.UseFont = True
        TileItemElement6.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement6.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement6.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement6.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement6.Appearance.Selected.Options.UseFont = True
        TileItemElement6.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement6.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement6.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement6.Image = CType(resources.GetObject("TileItemElement6.Image"), System.Drawing.Image)
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement6.ImageLocation = New System.Drawing.Point(0, 2)
        TileItemElement6.Text = "ສາຂາຮຽນ"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem3.Elements.Add(TileItemElement6)
        Me.TileItem3.Id = 8
        Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem3.Name = "TileItem3"
        '
        'btnSetting
        '
        Me.btnSetting.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSetting.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSetting.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnSetting.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement7.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement7.Appearance.Hovered.Options.UseFont = True
        TileItemElement7.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement7.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        TileItemElement7.Text = "ເທີມຮຽນ"
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement7.TextLocation = New System.Drawing.Point(0, 8)
        Me.btnSetting.Elements.Add(TileItemElement7)
        Me.btnSetting.Id = 1
        Me.btnSetting.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btnSetting.Name = "btnSetting"
        '
        'TileItem4
        '
        TileItemElement8.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement8.Appearance.Hovered.Options.UseFont = True
        TileItemElement8.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement8.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement8.Appearance.Normal.Options.UseFont = True
        TileItemElement8.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement8.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement8.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement8.Appearance.Selected.Options.UseFont = True
        TileItemElement8.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement8.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement8.Image = Global.LOGOS_SYS.My.Resources.Resources.Subject
        TileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement8.ImageLocation = New System.Drawing.Point(3, 2)
        TileItemElement8.Text = "ວິຊາຮຽນ"
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement8.TextLocation = New System.Drawing.Point(0, 5)
        Me.TileItem4.Elements.Add(TileItemElement8)
        Me.TileItem4.Id = 12
        Me.TileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem4.Name = "TileItem4"
        '
        'TileItem5
        '
        Me.TileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TileItem5.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement9.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement9.Appearance.Hovered.Options.UseFont = True
        TileItemElement9.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement9.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement9.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement9.Appearance.Normal.Options.UseFont = True
        TileItemElement9.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement9.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement9.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement9.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement9.Appearance.Selected.Options.UseFont = True
        TileItemElement9.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement9.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement9.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement9.Image = Global.LOGOS_SYS.My.Resources.Resources.Subject_InTerm
        TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement9.Text = "ວິຊາຮຽນໃນເທີມ"
        TileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem5.Elements.Add(TileItemElement9)
        Me.TileItem5.Id = 14
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem5.Name = "TileItem5"
        '
        'TileItem6
        '
        Me.TileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TileItem6.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement10.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement10.Appearance.Hovered.Options.UseFont = True
        TileItemElement10.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement10.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement10.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement10.Appearance.Normal.ForeColor = System.Drawing.Color.White
        TileItemElement10.Appearance.Normal.Options.UseFont = True
        TileItemElement10.Appearance.Normal.Options.UseForeColor = True
        TileItemElement10.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement10.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement10.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement10.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement10.Appearance.Selected.Options.UseFont = True
        TileItemElement10.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement10.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement10.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement10.Image = Global.LOGOS_SYS.My.Resources.Resources.Time
        TileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement10.ImageLocation = New System.Drawing.Point(0, -5)
        TileItemElement10.Text = "ເວລາຮຽນ"
        TileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement10.TextLocation = New System.Drawing.Point(0, 8)
        Me.TileItem6.Elements.Add(TileItemElement10)
        Me.TileItem6.Id = 13
        Me.TileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem6.Name = "TileItem6"
        '
        'btnPermision
        '
        Me.btnPermision.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray
        Me.btnPermision.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray
        Me.btnPermision.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnPermision.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement11.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement11.Appearance.Hovered.Options.UseFont = True
        TileItemElement11.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement11.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement11.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement11.Appearance.Normal.Options.UseFont = True
        TileItemElement11.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement11.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement11.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement11.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 21.25!)
        TileItemElement11.Appearance.Selected.Options.UseFont = True
        TileItemElement11.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement11.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement11.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement11.Image = Global.LOGOS_SYS.My.Resources.Resources.Class11
        TileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement11.ImageLocation = New System.Drawing.Point(0, -10)
        TileItemElement11.Text = "ຫ້ອງຮຽນ"
        TileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement11.TextLocation = New System.Drawing.Point(0, 5)
        Me.btnPermision.Elements.Add(TileItemElement11)
        Me.btnPermision.Id = 2
        Me.btnPermision.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btnPermision.Name = "btnPermision"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement12.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement12.Appearance.Normal.Options.UseFont = True
        TileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement12.ImageLocation = New System.Drawing.Point(0, -8)
        TileItemElement12.Text = "ເທີມຮຽນ"
        TileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement12.TextLocation = New System.Drawing.Point(0, 8)
        Me.TileItem1.Elements.Add(TileItemElement12)
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
        TileItemElement13.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement13.Appearance.Normal.Options.UseFont = True
        TileItemElement13.Image = Global.LOGOS_SYS.My.Resources.Resources.folders1
        TileItemElement13.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement13.ImageLocation = New System.Drawing.Point(0, -25)
        TileItemElement13.Text = "ລາຍການອຸປະກອນຂາຍ"
        TileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement13.TextLocation = New System.Drawing.Point(0, 10)
        Me.TileItem8.Elements.Add(TileItemElement13)
        Me.TileItem8.Id = 5
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem8.Name = "TileItem8"
        '
        'frmMain_Setting
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
        Me.Name = "frmMain_Setting"
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
    Private WithEvents btnEmp As DevExpress.XtraEditors.TileItem
    Private WithEvents btnManageGroup As DevExpress.XtraEditors.TileItem
    Private WithEvents btnDEclass As DevExpress.XtraEditors.TileItem
    Private WithEvents tileItem2 As DevExpress.XtraEditors.TileItem
    Private WithEvents btnSetting As DevExpress.XtraEditors.TileItem
    Private WithEvents btnPermision As DevExpress.XtraEditors.TileItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TileItem3 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem4 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem6 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem7 As DevExpress.XtraEditors.TileItem
    Private WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
End Class
