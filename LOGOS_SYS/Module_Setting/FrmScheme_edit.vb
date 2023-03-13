Imports System.Data.SqlClient

Public Class FrmScheme_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmScheme_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = " SELECT scheme_id ,scheme_des_la ,scheme_des_en ,scheme_status ,last_update ,user_update"
        Sql &= " FROM tbl_setting_scheme "
        Sql &= " WHERE(scheme_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_scheme_la.Text = .Item("scheme_des_la")
            txt_scheme_en.Text = .Item("scheme_des_en")

            'User Status
            If (.Item("scheme_status") = 1) Then
                rdo_active.Checked = True
            Else
                rdo_disabled.Checked = True
            End If
        End With
    End Sub

    Private Sub edit_user()
        If (CStr(txt_scheme_la.Text.Trim) = "") Then
            MessageBox.Show("Scheme is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_scheme_la.Focus()
            Exit Sub
        End If
        If (CStr(txt_scheme_en.Text.Trim) = "") Then
            MessageBox.Show("Scheme is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_scheme_en.Focus()
            Exit Sub
        End If

        Dim user_status As Integer = 0
        If (rdo_active.Checked = True) Then
            user_status = 1
        End If


        Call ConnectDB()
        Sql = "UPDATE tbl_setting_scheme SET scheme_des_la=@scheme_des , scheme_des_en=@scheme_des_en, scheme_status=@scheme_status, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(scheme_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("scheme_des", txt_scheme_la.Text.Trim)
        cm.Parameters.AddWithValue("scheme_des_en", txt_scheme_en.Text.Trim)
        cm.Parameters.AddWithValue("scheme_status", user_status)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


End Class