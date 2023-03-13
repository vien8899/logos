Imports System.Data.SqlClient

Public Class FrmClass_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmClass_view.LoadData()
        End If
    End Sub

    Dim load_finished As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finished = 1
        Call clear_text()
        Call getCourseList()
        Call getTermList(cb_course.SelectedValue)
        Call getLearningShiftList(cb_course.SelectedValue)
        load_finished = 0
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

    Private Sub add_new_user()
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


        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_class(class_code ,class_des ,term_id ,learning_shift_id ,class_status ,user_update) "
        Sql &= " VALUES(@class_code ,@class_des ,@term_id ,@learning_shift_id ,@class_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("class_code", txt_class_code.Text.Trim)
        cm.Parameters.AddWithValue("class_des", txt_class_des.Text.Trim)
        cm.Parameters.AddWithValue("term_id", cb_term.SelectedValue)
        cm.Parameters.AddWithValue("learning_shift_id", cb_learning_time.SelectedValue)
        cm.Parameters.AddWithValue("class_status", 1)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new class completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finished = 0) Then
            Call getTermList(cb_course.SelectedValue)
            Call getLearningShiftList(cb_course.SelectedValue)
        End If
    End Sub

End Class