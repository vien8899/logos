<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.lbError = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtusername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtpassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lb_err = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbError
        '
        Me.lbError.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbError.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbError.Location = New System.Drawing.Point(12, 440)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(413, 63)
        Me.lbError.TabIndex = 14
        Me.lbError.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.label1.Location = New System.Drawing.Point(172, 516)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 15)
        Me.label1.TabIndex = 12
        Me.label1.Text = "© logos college"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = Global.LOGOS_SYS.My.Resources.Resources.user100
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox1.Location = New System.Drawing.Point(132, 22)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(173, 183)
        Me.pictureBox1.TabIndex = 10
        Me.pictureBox1.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Webdings", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label2.Location = New System.Drawing.Point(338, 305)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 39)
        Me.label2.TabIndex = 13
        Me.label2.Text = ""
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Webdings", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label3.Location = New System.Drawing.Point(333, 245)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 39)
        Me.label3.TabIndex = 11
        Me.label3.Text = ""
        '
        'txtusername
        '
        Me.txtusername.Depth = 0
        Me.txtusername.Hint = ""
        Me.txtusername.Location = New System.Drawing.Point(88, 259)
        Me.txtusername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.SelectedText = ""
        Me.txtusername.SelectionLength = 0
        Me.txtusername.SelectionStart = 0
        Me.txtusername.Size = New System.Drawing.Size(260, 23)
        Me.txtusername.TabIndex = 0
        Me.txtusername.Text = "ADMIN"
        Me.txtusername.UseSystemPasswordChar = False
        '
        'txtpassword
        '
        Me.txtpassword.Depth = 0
        Me.txtpassword.Hint = ""
        Me.txtpassword.Location = New System.Drawing.Point(88, 314)
        Me.txtpassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.SelectionLength = 0
        Me.txtpassword.SelectionStart = 0
        Me.txtpassword.Size = New System.Drawing.Size(260, 23)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.Text = "1"
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(88, 352)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Show password"
        Me.CheckEdit1.Size = New System.Drawing.Size(204, 23)
        Me.CheckEdit1.TabIndex = 17
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(88, 406)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(124, 36)
        Me.MaterialFlatButton1.TabIndex = 2
        Me.MaterialFlatButton1.Text = "          Login          ."
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(219, 406)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(129, 36)
        Me.MaterialFlatButton2.TabIndex = 3
        Me.MaterialFlatButton2.Text = "          Cancel        ."
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'lb_err
        '
        Me.lb_err.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_err.ForeColor = System.Drawing.Color.Red
        Me.lb_err.Location = New System.Drawing.Point(88, 212)
        Me.lb_err.Name = "lb_err"
        Me.lb_err.Size = New System.Drawing.Size(260, 23)
        Me.lb_err.TabIndex = 23
        Me.lb_err.Text = "Incorrect Username Or password"
        Me.lb_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(437, 553)
        Me.Controls.Add(Me.lb_err)
        Me.Controls.Add(Me.MaterialFlatButton2)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lbError)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbError As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txtusername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtpassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lb_err As System.Windows.Forms.Label

End Class
