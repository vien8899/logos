Imports System.Data.SqlClient

Public Class FrmTermSubject_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmTermSubject_view.LoadData()
        End If
    End Sub

    Dim load_finished As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finished = 1
        Call clear_text()
        Call getCourseList()
        Call getTermList(cb_course.SelectedValue)
        cb_course.Focus()
        load_finished = 0
    End Sub

    Private Sub clear_text()
        txt_subjecct.Text = ""
        txt_subject_id.Text = ""
        txt_remark.Text = "--"
    End Sub

    Private Sub getCourseList()
        Sql = "SELECT (scheme_des_la+' -['+course_des_la+']') AS course_name, course_id "
        Sql &= " FROM view_course_list WHERE(course_status <> 0) "
        Sql &= " ORDER BY scheme_des_la, course_des_la "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "course_name"
        'cb_course.SelectedIndex = 0
    End Sub

    Private Sub getTermList(ByVal c_id As Integer)
        Sql = "SELECT term_id ,(term_no+' ('+term_des+')') AS full_term ,course_id ,term_status"
        Sql &= " FROM view_term_table WHERE(term_status <> 0) AND (course_id=" & c_id & ") "
        Sql &= " ORDER BY course_id, term_no, term_des "
        dt = ExecuteDatable(Sql)
        cb_term.DataSource = dt
        cb_term.ValueMember = "term_id"
        cb_term.DisplayMember = "full_term"
    End Sub

    Private Sub add_new_user()
        If (cb_course.Items.Count = 0) Then
            MessageBox.Show("Course is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cb_course.Focus()
            Exit Sub
        End If

        If (cb_term.Items.Count = 0) Then
            MessageBox.Show("Term is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cb_term.Focus()
            Exit Sub
        End If

        If (txt_subjecct.Text.Trim = "") Then
            MessageBox.Show("Subject is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button1.Focus()
            Exit Sub
        End If

        Dim rm As String = "--"
        If (txt_remark.Text.Trim <> "") Then
            rm = txt_remark.Text.Trim
        End If

        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_term_subject(term_id ,subject_id ,more_des ,user_update) "
        Sql &= " VALUES(@term_id ,@subject_id ,@more_des ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("term_id", cb_term.SelectedValue)
        cm.Parameters.AddWithValue("subject_id", CInt(txt_subject_id.Text))
        cm.Parameters.AddWithValue("more_des", rm)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Info Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cb_course.Items.Count = 0) Then
            MessageBox.Show("Course is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cb_course.Focus()
            Exit Sub
        End If

        subject_filter = " AND (subject_id NOT IN(SELECT subject_id FROM view_term_subject_list WHERE(course_id=" & cb_course.SelectedValue & ")))"
        If FrmTermSubject_select.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_subject_id.Text = FrmTermSubject_select.sb_id
            txt_subjecct.Text = FrmTermSubject_select.sb_desc
        End If
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finished = 0) Then
            Call getTermList(cb_course.SelectedValue)
        End If
    End Sub

End Class