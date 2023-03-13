Imports System.Data.SqlClient

Public Class FrmCourse_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmCourse_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call clear_text()
        Call getSchemeList()
    End Sub

    Private Sub getSchemeList()
        Sql = "SELECT scheme_des_la, scheme_id "
        Sql &= " FROM tbl_setting_scheme WHERE(scheme_status <> 0) "
        Sql &= " ORDER BY scheme_des_la "
        dt = ExecuteDatable(Sql)
        cb_scheme.DataSource = dt
        cb_scheme.ValueMember = "scheme_id"
        cb_scheme.DisplayMember = "scheme_des_la"
    End Sub

    Private Sub clear_text()
        txt_course_la.Text = ""
        txt_course_en.Text = ""
        txt_amount_regis.Text = "0"

        txt_course_la.Select()
    End Sub

    Private Sub add_new_user()
        If (CStr(txt_course_la.Text.Trim) = "") Then
            MessageBox.Show("Course name (la) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_course_la.Focus()
            Exit Sub
        End If
        If (txt_course_en.Text.Trim = "") Then
            MessageBox.Show("Course name (en) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_course_en.Focus()
            Exit Sub
        End If


        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_course(course_des_la ,course_des_en ,course_test_amount ,course_status ,scheme_id ,user_update) "
        Sql &= " VALUES(@course_des_la ,@course_des_en ,@course_test_amount ,@course_status ,@scheme_id ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("course_des_la", txt_course_la.Text.Trim)
        cm.Parameters.AddWithValue("course_des_en", txt_course_en.Text.Trim)
        cm.Parameters.AddWithValue("course_test_amount", CDbl(txt_amount_regis.Text.Trim))
        cm.Parameters.AddWithValue("course_status", 1)
        cm.Parameters.AddWithValue("scheme_id", cb_scheme.SelectedValue)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new user completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub txt_amount_regis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount_regis.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_amount_regis_Leave(sender As Object, e As EventArgs) Handles txt_amount_regis.Leave
        If (txt_amount_regis.Text.Trim = "") Then
            txt_amount_regis.Text = "0"
        End If
        txt_amount_regis.Text = Format(CDbl(txt_amount_regis.Text), "N0")
    End Sub

End Class