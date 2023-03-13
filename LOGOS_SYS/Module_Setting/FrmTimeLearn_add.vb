Imports System.Data.SqlClient

Public Class FrmTimeLearn_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmTimeLearn_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call clear_text()
        Call getCourseList()
    End Sub

    Private Sub getCourseList()
        Sql = "SELECT (scheme_des_la+' -['+course_des_la+']') AS full_course, course_id "
        Sql &= " FROM view_course_list"
        Sql &= " WHERE(course_status <> 0) "
        Sql &= " ORDER BY scheme_id, course_des_la "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "full_course"
    End Sub

    Private Sub clear_text()
        txt_time_learning.Text = ""
        txt_time_learning.Select()
    End Sub

    Private Sub add_new_user()
        If (cb_course.Items.Count = 0) Then
            MessageBox.Show("Course is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_course.Focus()
            Exit Sub
        End If
        If (CStr(txt_time_learning.Text.Trim) = "") Then
            MessageBox.Show("Setting day/time is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_time_learning.Focus()
            Exit Sub
        End If


        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_learning_shift(learning_shift_des ,course_id ,learning_shift_status ,user_update) "
        Sql &= " VALUES(@learning_shift_des ,@course_id ,@learning_shift_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("learning_shift_des", txt_time_learning.Text.Trim)
        cm.Parameters.AddWithValue("learning_shift_status", 1)
        cm.Parameters.AddWithValue("course_id", cb_course.SelectedValue)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

End Class