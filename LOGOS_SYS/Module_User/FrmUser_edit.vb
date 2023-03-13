Imports System.Data.SqlClient

Public Class FrmUser_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmUser_view.LoadData()
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
        Call getUsergroupList()
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = "SELECT em_id ,em_fullname_la ,em_fullname_en ,em_gender ,date_of_birth ,edu_qualification ,graduation_subj ,"
        Sql &= " graduation_country ,phone_number ,em_position ,started_job_date ,user_name ,user_password ,"
        Sql &= " user_status ,user_group_id ,last_update ,user_update ,user_group_code"
        Sql &= " FROM view_user_list"
        Sql &= " WHERE(em_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_fullname_la.Text = .Item("em_fullname_la")
            txt_fullname_en.Text = .Item("em_fullname_en")
            DateTimePicker_BoD.Text = CDate(.Item("date_of_birth"))
            txt_edu_level.Text = .Item("edu_qualification")
            txt_edu_subject.Text = .Item("graduation_subj")
            txt_edu_from.Text = .Item("graduation_country")
            DateTimePicker_Job_start.Text = CDate(.Item("started_job_date"))
            txt_position.Text = .Item("em_position")
            txt_tel.Text = .Item("phone_number")

            txt_username.Text = .Item("user_name")
            txt_password.Text = .Item("user_password")
            txt_password_confirm.Text = .Item("user_password")
            cb_user_group.SelectedValue = .Item("user_group_id")

            'gender
            If (.Item("em_gender") = 1) Then
                rdo_male.Checked = True
            Else
                rdo_female.Checked = True
            End If

            'User Status
            If (.Item("user_status") = 1) Then
                rdo_active.Checked = True
            Else
                rdo_disabled.Checked = True
            End If
        End With
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
        chk_change_pass.Checked = False
        txt_password_confirm.ReadOnly = True
        txt_password.ReadOnly = True
        txt_fullname_la.Select()
    End Sub

    Private Sub edit_user()
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

        Dim pwd As String = txt_password.Text.Trim
        If (chk_change_pass.Checked = True) Then
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
            pwd = MD5(txt_password.Text.Trim)
        End If

        Dim bod As String = Format(CDate(DateTimePicker_BoD.Text), "yyyy-MM-dd")
        Dim start_job_date As String = Format(CDate(DateTimePicker_Job_start.Text), "yyyy-MM-dd")
        Dim gender As Integer = 1
        If (rdo_female.Checked = True) Then
            gender = 2
        End If

        Dim user_status As Integer = 0
        If (rdo_active.Checked = True) Then
            user_status = 1
        End If


        Call ConnectDB()
        Sql = "UPDATE tbl_user SET em_fullname_la=@em_fullname_la ,em_fullname_en=@em_fullname_en ,em_gender=@em_gender ,"
        Sql &= " date_of_birth=@date_of_birth, edu_qualification=@edu_qualification, graduation_subj=@graduation_subj , graduation_country=@graduation_country, phone_number=@phone_number, "
        Sql &= " em_position=@em_position ,started_job_date=@started_job_date ,user_name=@user_name ,user_password=@user_password ,user_group_id=@user_group_id ,"
        Sql &= " user_status=@user_status, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(em_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
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
        cm.Parameters.AddWithValue("user_password", pwd)
        cm.Parameters.AddWithValue("user_group_id", cb_user_group.SelectedValue)
        cm.Parameters.AddWithValue("user_status", user_status)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit user info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call edit_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub chk_change_pass_CheckedChanged(sender As Object, e As EventArgs) Handles chk_change_pass.CheckedChanged
        If (load_finished = 0) Then
            If (chk_change_pass.Checked = True) Then
                txt_password_confirm.ReadOnly = False
                txt_password.ReadOnly = False
                txt_password.Text = ""
                txt_password_confirm.Text = ""
                txt_password.Focus()
            Else
                txt_password_confirm.ReadOnly = True
                txt_password.ReadOnly = True
                txt_password.Text = "12345"
                txt_password_confirm.Text = "12345"
            End If
        End If
    End Sub

    Private Sub chk_active_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

End Class