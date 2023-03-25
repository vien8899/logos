Public Class FrmStudentEnroll_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).student_enroll_test = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        Call getYearList()
        Call getCourseList()
        Call getLearningShiftList(CInt(cb_course.SelectedValue))
        Call LoadData()
        load_finishied = 0
    End Sub

    Private Sub getYearList()
        cb_year.Items.Clear()
        Dim cur_year As Integer = CInt(Format(CDate(getCurrentDate()), "yyyy")) - 9
        Dim i As Integer = 9
        While i > 0
            cb_year.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            i -= 1
        End While
        cb_year.SelectedIndex = 0
    End Sub

     Private Sub getCourseList()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_course, 0 AS course_id "
        Sql &= "UNION "
        Sql &= "SELECT (scheme_des_la+' -['+course_des_la+']') AS full_course, course_id "
        Sql &= " FROM view_course_list"
        Sql &= " ORDER BY course_id "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "full_course"
    End Sub

    Private Sub getLearningShiftList(ByVal c As Integer)
        Dim ct As String = "AND (course_id=" & c & ") "
        If (c = 0) Then
            ct = ""
        End If
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS learning_shift_des, 0 AS learning_shift_id "
        Sql &= "UNION "
        Sql &= "SELECT learning_shift_des, learning_shift_id "
        Sql &= " FROM tbl_setting_learning_shift WHERE(learning_shift_status <> 0) " & ct
        Sql &= " ORDER BY learning_shift_id "
        dt = ExecuteDatable(Sql)
        cb_learning_time.DataSource = dt
        cb_learning_time.ValueMember = "learning_shift_id"
        cb_learning_time.DisplayMember = "learning_shift_des"
    End Sub

    Public Sub LoadData()
        Dim ct_year As String = " AND (year_register='" & cb_year.SelectedItem & "')"
        Dim ct_course As String = ""
        Dim ct_time_learn As String = ""
        Dim ct_search As String = ""

        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (cb_learning_time.SelectedValue <> 0) Then
            ct_time_learn = " AND (learning_shift_id = " & cb_learning_time.SelectedValue & ")"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((std_enroll_fullname_la LIKE N'%" & txt_search.Text.Trim & "%') OR (std_enroll_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') OR (phone_number LIKE '" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT enroll_id ,std_enroll_id ,enroll_date ,course_id ,learning_shift_id ,enroll_amount ,"
        Sql &= " enroll_discount ,test_date ,year_register ,last_update ,user_update ,learning_shift_des ,"
        Sql &= " course_des_la ,course_des_en ,course_test_amount ,scheme_id ,scheme_des_la ,scheme_des_en ,"
        Sql &= " std_enroll_fullname_la ,std_enroll_fullname_en ,std_enroll_gender ,date_of_birth ,birth_address ,"
        Sql &= " location_address ,phone_number ,wa_number ,parent_contact, enroll_inv_id, reg_first_term_st, title_la, title_en "
        Sql &= " FROM view_std_enroll "
        Sql &= " WHERE(enroll_id > 0) " & ct_year & ct_course & ct_time_learn & ct_search
        Sql &= " ORDER BY scheme_id, course_id, std_enroll_fullname_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                'Sex
                Dim sex As String = dt.Rows(i).Item("title_la") & ". "

                'Status: 1 = ຫາກະລົງທະບຽນເສັງ/2 = ລົງທະບຽນຮຽນແລ້ວ
                Dim st As String = "---"
                If (dt.Rows(i).Item("reg_first_term_st") = 1) Then
                    st = "ມາລົງທະບຽນຮຽນແລ້ວ"
                End If

                .Rows.Add(dt.Rows(i).Item("enroll_id"), (i + 1), sex & dt.Rows(i).Item("std_enroll_fullname_la"), dt.Rows(i).Item("phone_number"), dt.Rows(i).Item("year_register"), _
                         (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), dt.Rows(i).Item("learning_shift_des"), _
                         dt.Rows(i).Item("course_test_amount"), dt.Rows(i).Item("test_date"), dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"), dt.Rows(i).Item("enroll_inv_id"), st)
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_edit.Enabled = True
                btn_print.Enabled = True
            Else
                btn_edit.Enabled = False
                btn_print.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'Check for open enroll or not?
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        Dim cur_yyyy As Integer = Format(CDate(cur_date), "yyyy")
        Sql = "SELECT register_type FROM tbl_setting_open_close_reg "
        Sql &= " WHERE(register_type=1) AND ((open_date <= CAST(GETDATE() AS DATE)) AND (close_date >= CAST(GETDATE() AS DATE))) "
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count <= 0) Then
            MessageBox.Show("ກະລຸນາເປີດການລົງທະບຽນເສັງທຽບກ່ອນ ດຳເນີນການລົງທະບຽນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        FrmStudentEnroll_add.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmStudentEnroll_edit.ShowDialog()
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call getLearningShiftList(CInt(cb_course.SelectedValue))
            Call LoadData()
        End If
    End Sub


    Private Sub btn_disable_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure want print bill?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Sql = "DELETE FROM tbl_setting_term "
            'Sql &= " WHERE (term_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ");" & vbNewLine
            'Call ExecuteUpdate(Sql)

            'MessageBox.Show("Info deleted!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Call LoadData()
        End If
    End Sub

    Private Sub cb_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_year.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub cb_learning_time_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_learning_time.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        BILL_ID = Datagridview1.CurrentRow.Cells(11).Value
        rpt_status = 1
        Rpt_OnlyView = 1
        FrmReport_A5.ShowDialog()
    End Sub

End Class