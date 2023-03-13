Imports Newtonsoft.Json
Public Class FrmLogin

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Call CheckLogin()
    End Sub

    Private Sub CheckLogin()
        Sql = "SELECT em_id, em_fullname_en, user_name, user_password, user_status, user_group_id "
        Sql &= " FROM tbl_user "
        Sql &= " WHERE(user_name=N'" & txtusername.Text.Trim & "') AND (user_password='" & MD5(txtpassword.Text.Trim) & "') AND (user_status=1) "
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count = 0) Then
            lb_err.Visible = True
        Else
            User_ID = CInt(dt.Rows(0).Item("em_id"))
            User_name = dt.Rows(0).Item("user_name")
            User_Fullname = dt.Rows(0).Item("em_fullname_en")
            FrmMain.userlb.Caption = User_Fullname

            'User Permission
            Dim json_str As String
            Sql = "SELECT dbo.get_permission_group(" & CInt(dt.Rows(0).Item("user_group_id")) & ")"
            json_str = queryString(Sql)
            user_permission = JsonConvert.DeserializeObject(Of List(Of get_permission))(json_str)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CheckConnectionDB()
        lb_err.Visible = False
        txtusername.Focus()
    End Sub

    Private Sub GetPrintCopies()
        Sql = "SELECT print_copy_bill_register, print_copy_bill_enroll, print_copy_bill_sell "
        Sql &= " FROM tbl_college_inf "
        dt = ExecuteDatable(Sql)
        print_copy_bill_register = CInt(dt.Rows(0).Item("print_copy_bill_register"))
        print_copy_bill_enroll = CInt(dt.Rows(0).Item("print_copy_bill_enroll"))
        print_copy_bill_sell = CInt(dt.Rows(0).Item("print_copy_bill_sell"))
    End Sub

    Private Sub CheckConnectionDB()
        Try
            servername = My.Settings.setting_svrname
            dbname = My.Settings.setting_dbname
            dbuser = My.Settings.setting_dbuser
            dbpass = My.Settings.setting_dbpass
            StrconSQL = "Data Source=" & servername & ";Initial Catalog=" & dbname & ";User ID=" & dbuser & "; password=" & dbpass & ""
            MessageBox.Show(StrconSQL)
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = StrconSQL
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show("Database Connection Fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Fm_SetSQLDB.ShowDialog()
            Me.Close()
        End Try
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CheckLogin()
        End If
    End Sub

End Class
