Imports System.Data.SqlClient

Public Class FrmTerm_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmTerm_view.LoadData()
        End If
    End Sub

    Dim load_finished As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finished = 1
        Call clear_text()
        Call getCourseList()
        load_finished = 0
    End Sub

    Private Sub getCourseList()
        Sql = "SELECT (scheme_des_la+' -['+course_des_la+']') AS course_name, course_id "
        Sql &= " FROM view_course_list WHERE(course_status <> 0) "
        Sql &= " ORDER BY scheme_des_la, course_des_la "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "course_name"
    End Sub

    Private Sub clear_text()
        txt_term_desc.Text = ""
        txt_term_id.Text = ""
        txt_amount_regis.Text = "0"

        txt_term_desc.Select()
    End Sub

    Private Sub add_new_user()
        If (CStr(txt_term_desc.Text.Trim) = "") Then
            MessageBox.Show("Term-ID (la) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_term_desc.Focus()
            Exit Sub
        End If
        If (txt_term_id.Text.Trim = "") Then
            MessageBox.Show("Term disciption (en) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_search.Focus()
            Exit Sub
        End If

        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_term(term_list_id ,term_des ,register_amount ,course_id ,term_status ,user_update) "
        Sql &= " VALUES(@term_no ,@term_des ,@register_amount ,@course_id ,@term_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("term_no", txt_term_id.Tag)
        cm.Parameters.AddWithValue("term_des", txt_term_desc.Text.Trim)
        cm.Parameters.AddWithValue("register_amount", CDbl(txt_amount_regis.Text.Trim))
        cm.Parameters.AddWithValue("term_status", 1)
        cm.Parameters.AddWithValue("course_id", cb_course.SelectedValue)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new term completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        filter_term_course = " WHERE(term_list_id NOT IN(SELECT term_list_id FROM tbl_setting_term WHERE(course_id=" & cb_course.SelectedValue & ")))"
        Dim PS As Point = btn_search.PointToScreen(New Point(btn_search.Width - 5, btn_search.Height - 100))
        FrmTerm_select.Location = PS
        If FrmTerm_select.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_term_id.Tag = FrmTerm_select.t_id
            txt_term_id.Text = FrmTerm_select.t_code
        End If
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finished = 0) Then
            txt_term_id.Tag = ""
            txt_term_id.Text = ""
        End If
    End Sub

End Class