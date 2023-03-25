Imports System.Data.SqlClient

Public Class FrmReg_Open_Closed_add

    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        txt_comment.Text = "--"
        DateTimePicker1.Text = CDate(cur_date)
        'DateTimePicker1.MinDate = CDate(cur_date)
        DateTimePicker2.MinDate = DateTimePicker1.MinDate
    End Sub


    Private Sub add_new_user()
        If (rdo_enroll.Checked = False And rdo_enroll_train.Checked = False And rdo_register.Checked = False And rdo_register_train.Checked = False) Then
            MessageBox.Show("Register type is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_enroll.Focus()
            Exit Sub
        End If

        Dim st_date As String = Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd")
        Dim end_date As String = Format(CDate(DateTimePicker2.Text), "yyyy-MM-dd")
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If

        'Enroll/Register
        Dim enroll_or_register As Integer = 1
        If (rdo_enroll.Checked = True) Then
            enroll_or_register = 1
        ElseIf (rdo_register.Checked = True) Then
            enroll_or_register = 2
        ElseIf (rdo_enroll_train.Checked = True) Then
            enroll_or_register = 3
        ElseIf (rdo_register_train.Checked = True) Then
            enroll_or_register = 4
        End If

        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_open_close_reg(open_date ,close_date ,open_close_des ,register_type ,user_update) "
        Sql &= " VALUES(@open_date ,@close_date ,@open_close_des ,@register_type ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("open_date", st_date)
        cm.Parameters.AddWithValue("close_date", end_date)
        cm.Parameters.AddWithValue("open_close_des", cmt)
        cm.Parameters.AddWithValue("register_type", enroll_or_register)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call FrmReg_Open_Closed_view.LoadData()
        txt_comment.Text = "--"
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value.Date
    End Sub

End Class