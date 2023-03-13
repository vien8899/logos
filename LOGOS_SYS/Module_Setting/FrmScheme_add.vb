Imports System.Data.SqlClient

Public Class FrmScheme_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmScheme_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        txt_scheme_la.Text = ""
        txt_scheme_la.Select()
    End Sub

    Private Sub add_new_user()
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

        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_scheme(scheme_des_la, scheme_des_en, scheme_status ,user_update) "
        Sql &= " VALUES( @scheme_des, @scheme_des_en ,@scheme_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("scheme_des", txt_scheme_la.Text.Trim)
        cm.Parameters.AddWithValue("scheme_des_en", txt_scheme_en.Text.Trim)
        cm.Parameters.AddWithValue("scheme_status", 1)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new scheme completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        txt_scheme_la.Text = ""
        txt_scheme_la.Select()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

End Class