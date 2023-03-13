Public Class FrmUser_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).modify_user = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        chk_show_disable.Checked = False
        txt_search.Text = ""
        Call LoadData()
        txt_search.Focus()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct_active As String = ""
        Dim ct_search As String = ""
        If (chk_show_disable.Checked = False) Then
            ct_active = " AND (user_status <> 0)"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_active = " AND ((em_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') OR (user_name LIKE N'" & txt_search.Text.Trim & "%'))"
        End If


        Sql = " SELECT em_id ,em_fullname_la ,em_fullname_en ,em_gender ,date_of_birth ,edu_qualification ,"
        Sql &= " graduation_subj ,graduation_country ,phone_number ,em_position ,started_job_date ,"
        Sql &= " user_name ,user_password ,user_status ,user_group_id ,last_update ,user_update, user_group_code "
        Sql &= " FROM view_user_list "
        Sql &= " WHERE(user_name<>'ADMIN') " & ct_active & ct_search
        Sql &= " ORDER BY em_fullname_en "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim gender As String = "Male"
                If (dt.Rows(i).Item("em_gender") = 2) Then
                    gender = "Female"
                End If

                Dim st As String = "Active"
                If (dt.Rows(i).Item("user_status") = 0) Then
                    st = "Disabled"
                End If

                .Rows.Add(dt.Rows(i).Item("em_id"), (i + 1), dt.Rows(i).Item("em_fullname_en"), dt.Rows(i).Item("user_name"), gender, _
                          dt.Rows(i).Item("phone_number"), dt.Rows(i).Item("user_group_code"), st, dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_edit.Enabled = True
                btn_disable.Enabled = False
                If (.Rows(0).Cells(7).Value = "Active") Then 'Can disable omnly active user
                    btn_disable.Enabled = True
                End If
            Else
                btn_edit.Enabled = False
                btn_disable.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmUser_add.ShowDialog()
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        If MessageBox.Show("Are you sure want to disable this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE tbl_user SET user_status=0 "
            Sql &= " WHERE (em_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ")"
            Call ExecuteUpdate(Sql)

            MessageBox.Show("User had disabled", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LoadData()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmUser_edit.ShowDialog()
    End Sub

    Private Sub chk_show_disable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_show_disable.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        If (Datagridview1.RowCount > 0) Then
            btn_disable.Enabled = False
            If (Datagridview1.CurrentRow.Cells(7).Value = "Active") Then 'Can disable omnly active user
                btn_disable.Enabled = True
            End If
        End If
    End Sub

End Class