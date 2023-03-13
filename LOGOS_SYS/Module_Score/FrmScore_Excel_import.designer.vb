<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScore_Excel_import
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_score = New System.Windows.Forms.ComboBox()
        Me.cb_student_code = New System.Windows.Forms.ComboBox()
        Me.cb_worksheet = New System.Windows.Forms.ComboBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_file = New System.Windows.Forms.Label()
        Me.lb_des = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.tileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.btnSave = New DevExpress.XtraEditors.TileItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.deleteRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cb_score)
        Me.Panel1.Controls.Add(Me.cb_student_code)
        Me.Panel1.Controls.Add(Me.cb_worksheet)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lb_file)
        Me.Panel1.Controls.Add(Me.lb_des)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 178)
        Me.Panel1.TabIndex = 0
        '
        'cb_score
        '
        Me.cb_score.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_score.FormattingEnabled = True
        Me.cb_score.Location = New System.Drawing.Point(581, 134)
        Me.cb_score.Name = "cb_score"
        Me.cb_score.Size = New System.Drawing.Size(178, 34)
        Me.cb_score.TabIndex = 5
        '
        'cb_student_code
        '
        Me.cb_student_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_student_code.FormattingEnabled = True
        Me.cb_student_code.Location = New System.Drawing.Point(397, 134)
        Me.cb_student_code.Name = "cb_student_code"
        Me.cb_student_code.Size = New System.Drawing.Size(178, 34)
        Me.cb_student_code.TabIndex = 5
        '
        'cb_worksheet
        '
        Me.cb_worksheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_worksheet.FormattingEnabled = True
        Me.cb_worksheet.Location = New System.Drawing.Point(17, 134)
        Me.cb_worksheet.Name = "cb_worksheet"
        Me.cb_worksheet.Size = New System.Drawing.Size(374, 34)
        Me.cb_worksheet.TabIndex = 5
        '
        'btnImport
        '
        Me.btnImport.Image = Global.LOGOS_SYS.My.Resources.Resources.excel_16
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(17, 65)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Padding = New System.Windows.Forms.Padding(15, 0, 10, 0)
        Me.btnImport.Size = New System.Drawing.Size(134, 37)
        Me.btnImport.TabIndex = 4
        Me.btnImport.Text = "ເລືອກຟາຍ"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(576, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ຄະແນນ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ລະຫັດນັກສືກສາ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Work Sheet"
        '
        'lb_file
        '
        Me.lb_file.AutoSize = True
        Me.lb_file.Location = New System.Drawing.Point(157, 70)
        Me.lb_file.Name = "lb_file"
        Me.lb_file.Size = New System.Drawing.Size(0, 26)
        Me.lb_file.TabIndex = 0
        '
        'lb_des
        '
        Me.lb_des.AutoSize = True
        Me.lb_des.Location = New System.Drawing.Point(12, 9)
        Me.lb_des.Name = "lb_des"
        Me.lb_des.Size = New System.Drawing.Size(71, 26)
        Me.lb_des.TabIndex = 0
        Me.lb_des.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tileControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 536)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 66)
        Me.Panel2.TabIndex = 0
        '
        'tileControl1
        '
        Me.tileControl1.BackColor = System.Drawing.Color.White
        Me.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.tileControl1.Groups.Add(Me.tileGroup1)
        Me.tileControl1.ItemPadding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.tileControl1.ItemSize = 60
        Me.tileControl1.Location = New System.Drawing.Point(0, 0)
        Me.tileControl1.MaxId = 6
        Me.tileControl1.Name = "tileControl1"
        Me.tileControl1.Padding = New System.Windows.Forms.Padding(0, 5, 18, 0)
        Me.tileControl1.Size = New System.Drawing.Size(913, 66)
        Me.tileControl1.TabIndex = 11
        Me.tileControl1.Text = "tileControl3"
        '
        'tileGroup1
        '
        Me.tileGroup1.Items.Add(Me.btnSave)
        Me.tileGroup1.Name = "tileGroup1"
        '
        'btnSave
        '
        Me.btnSave.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.btnSave.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.btnSave.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnSave.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Black
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileItemElement1.Image = Global.LOGOS_SYS.My.Resources.Resources.Floppy_disk40
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement1.ImageLocation = New System.Drawing.Point(10, 2)
        TileItemElement1.Text = "ບັນທຶກ"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement1.TextLocation = New System.Drawing.Point(25, 8)
        Me.btnSave.Elements.Add(TileItemElement1)
        Me.btnSave.Id = 5
        Me.btnSave.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.btnSave.Name = "btnSave"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 178)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(913, 358)
        Me.Panel3.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.remark})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.GridColor = System.Drawing.Color.White
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(913, 358)
        Me.DGV.TabIndex = 0
        '
        'remark
        '
        Me.remark.HeaderText = ""
        Me.remark.Name = "remark"
        Me.remark.Visible = False
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteRow})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(127, 34)
        '
        'deleteRow
        '
        Me.deleteRow.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteRow.Name = "deleteRow"
        Me.deleteRow.Size = New System.Drawing.Size(126, 30)
        Me.deleteRow.Text = "ລຶບແຖວ"
        '
        'FrmScore_Excel_import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 602)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmScore_Excel_import"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Private WithEvents tileControl1 As DevExpress.XtraEditors.TileControl
    Private WithEvents tileGroup1 As DevExpress.XtraEditors.TileGroup
    Private WithEvents btnSave As DevExpress.XtraEditors.TileItem
    Friend WithEvents lb_des As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents cb_score As System.Windows.Forms.ComboBox
    Friend WithEvents cb_student_code As System.Windows.Forms.ComboBox
    Friend WithEvents cb_worksheet As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_file As System.Windows.Forms.Label
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents deleteRow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents remark As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
