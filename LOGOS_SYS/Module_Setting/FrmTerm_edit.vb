Imports System.Data.SqlClient

Public Class FrmTerm_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmTerm_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finished = 1
        Call first_load()
        load_finished = 0
    End Sub

    Dim load_finished As Integer = 1
    Private Sub first_load()
        Call clear_text()
        Call getCourseList()
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = " SELECT term_id ,term_list_id, term_no, term_no_la ,term_des ,register_amount ,course_id ,term_status ,last_update ,"
        Sql &= " user_update, course_des_la, course_des_en, scheme_id, scheme_des_la, scheme_des_en "
        Sql &= " FROM view_term_list "
        Sql &= " WHERE(term_id=" & id_edit & ") "
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_term_id.Tag = .Item("term_list_id")
            txt_term_id.Text = .Item("term_no_la") & "(" & .Item("term_no") & ")"
            txt_term_desc.Text = .Item("term_des")
            txt_amount_regis.Text = Format(.Item("register_amount"), "N0")
            cb_course.SelectedValue = .Item("course_id")

            'Status
            If (.Item("term_status") = 1) Then
                rdo_active.Checked = True
            Else
                rdo_disabled.Checked = True
            End If
        End With
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
        txt_term_id.Text = ""
        txt_term_id.Tag = ""
        txt_term_desc.Text = ""
        txt_amount_regis.Text = "0"
        txt_term_id.Select()
    End Sub

    Private Sub edit_user()
        If (CStr(txt_term_desc.Text.Trim) = "") Then
            MessageBox.Show("Term-ID (la) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_term_desc.Focus()
            Exit Sub
        End If
        If (txt_term_id.Text.Trim = "") Then
            MessageBox.Show("Term disciption (en) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_term_id.Focus()
            Exit Sub
        End If

        Dim user_status As Integer = 0
        If (rdo_active.Checked = True) Then
            user_status = 1
        End If

        Call ConnectDB()
        Sql = "UPDATE tbl_setting_term SET term_list_id=@term_list_id ,term_des=@term_des ,register_amount=@register_amount ,"
        Sql &= " term_status=@term_status, course_id=@course_id, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(term_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("term_list_id", txt_term_id.Tag)
        cm.Parameters.AddWithValue("term_des", txt_term_desc.Text.Trim)
        cm.Parameters.AddWithValue("register_amount", CDbl(txt_amount_regis.Text.Trim))
        cm.Parameters.AddWithValue("term_status", user_status)
        cm.Parameters.AddWithValue("course_id", cb_course.SelectedValue)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit term completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call edit_user()
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

    Private Sub btn_search_enroll_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        filter_term_course = " WHERE(term_list_id NOT IN(SELECT term_list_id FROM tbl_setting_term WHERE(course_id=" & cb_course.SelectedValue & ")))"
        Dim PS As Point = btn_search.PointToScreen(New Point(btn_search.Width, btn_search.Height))
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