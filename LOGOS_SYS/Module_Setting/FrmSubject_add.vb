Imports System.Data.SqlClient

Public Class FrmSubject_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmSubject_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call ClearData()
    End Sub

    Private Sub ClearData()
        txt_subject_id.Text = ""
        txt_subject_la.Text = ""
        txt_subject_en.Text = ""
        txt_credit.Text = "2"

        txt_upgrade_price.Text = "0"
        txt_subject_id.Select()
    End Sub

    Private Sub add_new_user()
        If (CStr(txt_subject_id.Text.Trim) = "") Then
            MessageBox.Show("Subject ID is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_subject_la.Focus()
            Exit Sub
        End If
        If (CStr(txt_subject_la.Text.Trim) = "") Then
            MessageBox.Show("Subject (la) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_subject_la.Focus()
            Exit Sub
        End If
        If (CStr(txt_subject_en.Text.Trim) = "") Then
            MessageBox.Show("Subject (en) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_subject_en.Focus()
            Exit Sub
        End If

        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_subject(subject_code ,subject_name_la ,subject_name_en ,subject_credit, subject_upgrade_price, subject_status ,user_update) "
        Sql &= " VALUES(@subject_code, @subject_name_la, @subject_name_en ,@subject_credit, @subject_upgrade_price, @subject_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("subject_code", txt_subject_id.Text.Trim)
        cm.Parameters.AddWithValue("subject_name_la", txt_subject_la.Text.Trim)
        cm.Parameters.AddWithValue("subject_name_en", txt_subject_en.Text.Trim)
        cm.Parameters.AddWithValue("subject_credit", CInt(txt_credit.Text.Trim))
        cm.Parameters.AddWithValue("subject_upgrade_price", CInt(txt_upgrade_price.Text.Trim))
        cm.Parameters.AddWithValue("subject_status", 1)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new subject completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1

        Call ClearData()
        txt_subject_id.Select()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        txt_credit.Text = CInt(txt_credit.Text) - 1
    End Sub

    Private Sub txt_credit_TextChanged(sender As Object, e As EventArgs) Handles txt_credit.TextChanged
        'Minus
        If (CInt(txt_credit.Text) > 1) Then
            btn_minus.Enabled = True
        Else
            btn_minus.Enabled = False
        End If

        'Plus
        If (CInt(txt_credit.Text) < 10) Then
            btn_plus.Enabled = True
        Else
            btn_plus.Enabled = False
        End If
    End Sub

    Private Sub txt_upgrade_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_upgrade_price.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_upgrade_price_Leave(sender As Object, e As EventArgs) Handles txt_upgrade_price.Leave
        If (txt_upgrade_price.Text.Trim = "") Then
            txt_upgrade_price.Text = "0"
        End If
        txt_upgrade_price.Text = Format(CDbl(txt_upgrade_price.Text), "N0")
    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        txt_credit.Text = CInt(txt_credit.Text) + 1
    End Sub

End Class