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
        Sql = "SELECT drop_id ,student_id ,term_id ,drop_year ,drop_des ,drop_status ,user_update ,last_update ,"
        Sql &= " term_no ,term_no_la ,term_des ,term_list_id ,term_study_year ,student_code ,student_fullname_la ,"
        Sql &= " student_fullname_en ,phone_number ,job_des ,scheme_des_la ,scheme_des_en ,course_des_la ,course_des_en, course_id, scheme_id "
        Sql &= " FROM view_std_drop"
        Sql &= " WHERE(drop_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_std_code.Text = CStr(.Item("student_code"))
            txt_name.Text = .Item("student_fullname_la")
            txt_name.Tag = .Item("student_id")
            old_sokhien = .Item("drop_year")
            txt_term.Text = .Item("term_no")
            txt_term.Tag = .Item("term_id")
            txt_comment.Text = .Item("drop_des")

            'If have payment cannot edit discount
            If (CInt(.Item("drop_status")) = 0) Then
                rdo_undroping.Checked = True
            Else
                rdo_droping.Checked = True
            End If

            txt_course.Tag = .Item("course_id")
            txt_course.Text = .Item("scheme_des_la") & "(" & .Item("course_des_la") & ")"
            txt_comment.Select()
        End With
    End Sub

    Private Sub add_new_user()
        'Remark
        If (txt_comment.Text.Trim = "") Then
            MessageBox.Show("Please enter drop reason.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_comment.Focus()
            Exit Sub
        End If

        'check for have next term drop
        If (rdo_droping.Checked = True) Then
            Sql = "SELECT student_id FROM tbl_student_drop WHERE(term_list_id > " & txt_term.Tag & ")"
            dt = ExecuteDatable(Sql)
            If (dt.Rows.Count > 1) Then
                MessageBox.Show("ນັກສຶກສາໄດ້ຢຸດຮຽນເທີມທັດໄປ 2 ເທີມແລ້ວ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_std_code.Focus()
                Exit Sub
            End If
        End If

        Dim st As Integer = 1
        If (rdo_undroping.Checked = True) Then
            st = 0
        End If

        Call ConnectDB()
        Sql = "UPDATE tbl_student_drop SET drop_status=@drop_status ,drop_des=@drop_des, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(drop_id=@drop_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("drop_id", id_edit)
        cm.Parameters.AddWithValue("drop_status", st)
        cm.Parameters.AddWithValue("drop_des", txt_comment.Text.Trim)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

End Class