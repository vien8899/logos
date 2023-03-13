<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test_form
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.term = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.term, Me.enable})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Margin = New System.Windows.Forms.Padding(6)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(836, 553)
        Me.DGV.TabIndex = 0
        '
        'check
        '
        Me.check.DataPropertyName = "check"
        Me.check.HeaderText = "ເລືອກ"
        Me.check.Name = "check"
        Me.check.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'term
        '
        Me.term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.term.DataPropertyName = "term"
        Me.term.HeaderText = "Register Term"
        Me.term.Name = "term"
        Me.term.ReadOnly = True
        Me.term.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'enable
        '
        Me.enable.DataPropertyName = "enable"
        Me.enable.HeaderText = "Column2"
        Me.enable.Name = "enable"
        Me.enable.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.enable.Visible = False
        '
        'test_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 553)
        Me.Controls.Add(Me.DGV)
        Me.Font = New System.Drawing.Font("Noto Sans Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "test_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "test_form"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents term As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enable As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
