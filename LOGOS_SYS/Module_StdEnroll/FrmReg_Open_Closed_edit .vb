﻿Imports System.Data.SqlClient

Public Class FrmReg_Open_Closed_edit

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = " SELECT open_close_id ,open_date ,close_date ,open_close_des ,register_type ,last_update ,user_update "
        Sql &= " FROM tbl_setting_open_close_reg "
        Sql &= " WHERE(open_close_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_comment.Text = .Item("open_close_des")
            DateTimePicker1.Text = CDate(.Item("open_date"))
            DateTimePicker2.Text = CDate(.Item("close_date"))

            'User Status
            If (.Item("register_type") = 1) Then
                rdo_enroll.Checked = True
            ElseIf (.Item("register_type") = 2) Then
                rdo_register.Checked = True
            ElseIf (.Item("register_type") = 3) Then
                rdo_enroll_train.Checked = True
            ElseIf (.Item("register_type") = 4) Then
                rdo_register_train.Checked = True
            End If
        End With
    End Sub

    Private Sub edit_user()
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
        ElseIf (rdo_enroll_train.Checked = True) Then
            enroll_or_register = 3
        ElseIf (rdo_register.Checked = True) Then
            enroll_or_register = 2
        ElseIf (rdo_register_train.Checked = True) Then
            enroll_or_register = 4
        End If

        MsgBox(enroll_or_register)
        'Exit Sub

        Call ConnectDB()
        Sql = "UPDATE tbl_setting_open_close_reg "
        Sql &= " SET open_date=@open_date ,close_date=@close_date ,open_close_des=@open_close_des ,register_type=@register_type ,user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(open_close_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("open_date", st_date)
        cm.Parameters.AddWithValue("close_date", end_date)
        cm.Parameters.AddWithValue("open_close_des", cmt)
        cm.Parameters.AddWithValue("register_type", enroll_or_register)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call FrmReg_Open_Closed_view.LoadData()
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call edit_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value.Date
    End Sub

End Class