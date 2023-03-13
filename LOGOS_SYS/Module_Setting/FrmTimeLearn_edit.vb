Imports System.Data.SqlClient

Public Class FrmTimeLearn_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmTimeLearn_view.LoadData()
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
        Call getCourseList()
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = "SELECT learning_shift_id ,learning_shift_des ,course_id "
        Sql &= " FROM tbl_setting_learning_shift"
        Sql &= " WHERE(learning_shift_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_time_learning.Text = .Item("learning_shift_des")
            cb_course.SelectedValue = .Item("course_id")
        End With
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

    Private Sub edit_user()
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
        Sql = "UPDATE tbl_setting_learning_shift SET learning_shift_des=@learning_shift_des ,course_id=@course_id ,user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(learning_shift_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("learning_shift_des", txt_time_learning.Text.Trim)
        cm.Parameters.AddWithValue("learning_shift_status", 1)
        cm.Parameters.AddWithValue("course_id", cb_course.SelectedValue)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit Info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
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