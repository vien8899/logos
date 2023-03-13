Imports System.Data.SqlClient

Public Class FrmUser_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmUser_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call clear_text()
        Call getUsergroupList()
    End Sub

    Private Sub getUsergroupList()
        Sql = "SELECT user_group_id, user_group_code "
        Sql &= " FROM tbl_user_group WHERE(group_status <> 0) "
        Sql &= " ORDER BY user_group_id "
        dt = ExecuteDatable(Sql)
        cb_user_group.DataSource = dt
        cb_user_group.ValueMember = "user_group_id"
        cb_user_group.DisplayMember = "user_group_code"
    End Sub

    Private Sub clear_text()
        txt_fullname_la.Text = ""
        txt_fullname_en.Text = ""
        rdo_female.Checked = False
        rdo_male.Checked = False
        txt_edu_level.Text = ""
        txt_edu_subject.Text = ""
        txt_edu_from.Text = ""
        txt_position.Text = ""
        txt_tel.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        txt_password_confirm.Text = ""

        txt_fullname_la.Select()
    End Sub

    Private Sub add_new_user()
        If (CStr(txt_fullname_la.Text.Trim) = "") Then
            MessageBox.Show("Staff name (la) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_fullname_la.Focus()
            Exit Sub
        End If
        If (txt_fullname_en.Text.Trim = "") Then
            MessageBox.Show("Staff name (en) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_fullname_en.Focus()
            Exit Sub
        End If
        If (rdo_female.Checked = False) And (rdo_male.Checked = False) Then
            MessageBox.Show("Staff gender is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_male.Focus()
            Exit Sub
        End If
        If (txt_tel.Text.Trim = "") Then
            MessageBox.Show("Staff's phone number is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_tel.Focus()
            Exit Sub
        End If
        If (txt_username.Text.Trim = "") Then
            MessageBox.Show("Username is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_username.Focus()
            Exit Sub
        End If
        If (txt_password.Text.Trim = "") Then
            MessageBox.Show("Password is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_password.Focus()
            Exit Sub
        End If
        If (txt_password.Text.Trim <> txt_password_confirm.Text.Trim) Then
            MessageBox.Show("Password & Confirm password is not match.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_password.Focus()
            Exit Sub
        End If


        Dim bod As String = Format(CDate(DateTimePicker_BoD.Text), "yyyy-MM-dd")
        Dim start_job_date As String = Format(CDate(DateTimePicker_Job_start.Text), "yyyy-MM-dd")
        Dim gender As Integer = 1
        If (rdo_female.Checked = True) Then
            gender = 2
        End If


        Call ConnectDB()
        Sql = "INSERT INTO tbl_user(em_fullname_la ,em_fullname_en ,em_gender ,date_of_birth ,edu_qualification ,graduation_subj ,graduation_country ,phone_number ,"
        Sql &= " em_position ,started_job_date ,user_name ,user_password ,user_group_id ,user_update) "
        Sql &= " VALUES( @em_fullname_la ,@em_fullname_en ,@em_gender ,@date_of_birth ,@edu_qualification ,@graduation_subj ,@graduation_country ,@phone_number ,"
        Sql &= " @em_position ,@started_job_date ,@user_name ,@user_password ,@user_group_id ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("em_fullname_la", txt_fullname_la.Text.Trim)
        cm.Parameters.AddWithValue("em_fullname_en", txt_fullname_en.Text.Trim)
        cm.Parameters.AddWithValue("em_gender", gender)
        cm.Parameters.AddWithValue("date_of_birth", bod)
        cm.Parameters.AddWithValue("edu_qualification", txt_edu_level.Text.Trim)
        cm.Parameters.AddWithValue("graduation_subj", txt_edu_subject.Text.Trim)
        cm.Parameters.AddWithValue("graduation_country", txt_edu_from.Text.Trim)
        cm.Parameters.AddWithValue("phone_number", txt_tel.Text.Trim)
        cm.Parameters.AddWithValue("em_position", txt_position.Text.Trim)
        cm.Parameters.AddWithValue("started_job_date", start_job_date)
        cm.Parameters.AddWithValue("user_name", txt_username.Text.Trim)
        cm.Parameters.AddWithValue("user_password", MD5(txt_password.Text.Trim))
        cm.Parameters.AddWithValue("user_group_id", cb_user_group.SelectedValue)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new user completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

End Class