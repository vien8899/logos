Imports System.Data.SqlClient

Public Class FrmClass_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmClass_view.LoadData()
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
        Call getTermList(cb_course.SelectedValue)
        Call getLearningShiftList(cb_course.SelectedValue)
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = "SELECT class_id ,class_code ,class_des, class_status ,term_id ,term_no ,term_des ,course_id ,course_des_la ,"
        Sql &= " course_des_en, scheme_id, scheme_des_la, scheme_des_en, learning_shift_id, learning_shift_des"
        Sql &= " FROM view_class_list"
        Sql &= " WHERE(class_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_class_code.Text = .Item("class_code")
            txt_class_des.Text = .Item("class_des")
            cb_course.SelectedValue = .Item("course_id")
            cb_term.SelectedValue = .Item("term_id")
            cb_learning_time.SelectedValue = .Item("learning_shift_id")

            'Status
            If (.Item("class_status") = 1) Then
                rdo_active.Checked = True
            Else
                rdo_disabled.Checked = True
            End If
        End With
    End Sub

    Private Sub getCourseList()
        Sql = "SELECT (scheme_des_la+' -['+course_des_la+']') AS full_course, course_id "
        Sql &= " FROM view_course_list"
        Sql &= " ORDER BY course_id "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "full_course"
    End Sub

    Private Sub getTermList(ByVal c As Integer)
        Sql = "SELECT (term_no+' -['+term_des+']') AS full_term, term_id "
        Sql &= " FROM view_term_table WHERE(term_status <> 0) AND (course_id=" & c & ") "
        Sql &= " ORDER BY course_id, term_no "
        dt = ExecuteDatable(Sql)
        cb_term.DataSource = dt
        cb_term.ValueMember = "term_id"
        cb_term.DisplayMember = "full_term"
    End Sub

    Private Sub getLearningShiftList(ByVal c As Integer)
        Sql = "SELECT learning_shift_des, learning_shift_id "
        Sql &= " FROM tbl_setting_learning_shift WHERE(learning_shift_status <> 0) AND (course_id=" & c & ") "
        Sql &= " ORDER BY course_id, learning_shift_id "
        dt = ExecuteDatable(Sql)
        cb_learning_time.DataSource = dt
        cb_learning_time.ValueMember = "learning_shift_id"
        cb_learning_time.DisplayMember = "learning_shift_des"
    End Sub

    Private Sub clear_text()
        txt_class_des.Text = ""
        txt_class_code.Text = ""
        txt_class_code.Select()
    End Sub

    Private Sub edit_user()
        If (CStr(txt_class_des.Text.Trim) = "") Then
            MessageBox.Show("Class discription is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_class_des.Focus()
            Exit Sub
        End If
        If (txt_class_code.Text.Trim = "") Then
            MessageBox.Show("Class-ID is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_class_code.Focus()
            Exit Sub
        End If
        If (cb_course.Items.Count = 0) Then
            MessageBox.Show("Course is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_course.Focus()
            Exit Sub
        End If
        If (cb_term.Items.Count = 0) Then
            MessageBox.Show("Term is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_term.Focus()
            Exit Sub
        End If
        If (cb_learning_time.Items.Count = 0) Then
            MessageBox.Show("Day/Time for learning is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_learning_time.Focus()
            Exit Sub
        End If

        Dim user_status As Integer = 0
        If (rdo_active.Checked = True) Then
            user_status = 1
        End If


        Call ConnectDB()
        Sql = "UPDATE tbl_setting_class SET class_code=@class_code ,class_des=@class_des ,term_id=@term_id ,"
        Sql &= " learning_shift_id=@learning_shift_id, class_status=@class_status, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(class_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("class_code", txt_class_code.Text.Trim)
        cm.Parameters.AddWithValue("class_des", txt_class_des.Text.Trim)
        cm.Parameters.AddWithValue("term_id", cb_term.SelectedValue)
        cm.Parameters.AddWithValue("learning_shift_id", cb_learning_time.SelectedValue)
        cm.Parameters.AddWithValue("class_status", user_status)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit class completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call edit_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

End Class