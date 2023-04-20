Imports System.Data.SqlClient

Public Class FrmStdDrop_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStdDrop_view.LoadData()
        End If
    End Sub

    Dim load_finish As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finish = 1
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        cur_year = Format(CDate(cur_date), "yyyy")
        Call load_data()
        load_finish = 0
    End Sub

    Dim student_id As Integer = 0
    Dim std_reg_oldcode As String = ""
    Dim old_dis As Double = 0
    Dim cur_year As Integer = 0

    Dim old_sokhien As String = ""
    Private Sub load_data()
        Sql = "SELECT student_code ,student_fullname_la ,student_fullname_en ,phone_number ,job_des ,title_la ,title_en ,sex_id ,"
        Sql &= " course_id, course_des_la, course_des_en, scheme_id, scheme_des_la, scheme_des_en, drop_id, student_id, at_seasion, at_sokhien, "
        Sql &= " class_room, year_study, drop_des, drop_reson, drop_remark, drop_status, user_update, last_update"
        Sql &= " FROM view_std_drop"
        Sql &= " WHERE(drop_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_std_code.Text = CStr(.Item("student_code"))
            txt_name.Text = .Item("student_fullname_la")
            txt_name.Tag = .Item("student_id")
            old_sokhien = .Item("drop_year")
            txt_desc.Text = .Item("drop_des")
            txt_reason.Text = .Item("drop_reson")
            txt_remark.Text = .Item("drop_remark")
            txt_class.Text = .Item("class_room")
            txt_year.Text = .Item("year_study")
            txt_sokhien.Text = .Item("at_sokhien")
            txt_seasion.Text = .Item("at_seasion")

            'If have payment cannot edit discount
            If (CInt(.Item("drop_status")) = 0) Then
                rdo_undroping.Checked = True
            Else
                rdo_droping.Checked = True
            End If

            txt_course.Tag = .Item("course_id")
            txt_course.Text = .Item("scheme_des_la") & "(" & .Item("course_des_la") & ")"
            txt_desc.Select()
        End With
    End Sub

    Private Sub add_new_user()
        'Remark
        If (txt_class.Text.Trim = "") Then
            MessageBox.Show("Please enter class room.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_class.Focus()
            Exit Sub
        End If

        If (txt_year.Text.Trim = "") Then
            MessageBox.Show("Please enter year studying...", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_year.Focus()
            Exit Sub
        End If

        If (txt_desc.Text.Trim = "") Then
            MessageBox.Show("Please enter drop detail.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_desc.Focus()
            Exit Sub
        End If
        If (txt_reason.Text.Trim = "") Then
            MessageBox.Show("Please enter drop reason.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_reason.Focus()
            Exit Sub
        End If

        If (txt_sokhien.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາປ້ອນສົກຮຽນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_sokhien.Focus()
            Exit Sub
        End If
        If (txt_seasion.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາປ້ອນພາກຮຽນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_seasion.Focus()
            Exit Sub
        End If

        Dim st As Integer = 1
        If (rdo_undroping.Checked = True) Then
            st = 0
        End If

        Dim rm As String = "--"
        If (txt_remark.Text.Trim <> "") Then
            rm = txt_remark.Text.Trim
        End If

        Call ConnectDB()
        Sql = "UPDATE tbl_student_drop SET class_room=@class_room ,year_study=@year_study ,drop_des=@drop_des ,drop_reson=@drop_reson ,at_seasion=@at_seasion, at_sokhien=@at_sokhien,"
        Sql &= " drop_remark=@drop_remark ,drop_status=@drop_status ,user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(drop_id=@drop_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("drop_id", id_edit)
        cm.Parameters.AddWithValue("drop_status", st)
        cm.Parameters.AddWithValue("class_room", txt_class.Text.Trim)
        cm.Parameters.AddWithValue("year_study", txt_year.Text.Trim)
        cm.Parameters.AddWithValue("drop_des", txt_desc.Text.Trim)
        cm.Parameters.AddWithValue("drop_reson", txt_reason.Text.Trim)
        cm.Parameters.AddWithValue("drop_remark", rm)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.Parameters.AddWithValue("at_seasion", txt_seasion.Text.Trim)
        cm.Parameters.AddWithValue("at_sokhien", txt_sokhien.Text.Trim)
        cm.ExecuteNonQuery()

        If (rdo_undroping.Checked = True) Then
            'StudentLog
            Dim action_detail As String = "ດຳເນີນການຮຽນຕໍ່ ໃນການ Drop (" & txt_desc.Text & ")"
            Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
        End If

        MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

End Class