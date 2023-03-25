Public Class FrmStudent_view

    Dim load_finishied As Integer = 1
    Dim cur_year As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        'Panel_Control_Reg.Enabled = True
        'If (user_permission.Item(0).student_register = 0) Then
        '    Panel_Control_Reg.Enabled = False
        'End If

        'Load Data
        load_finishied = 1
        cur_year = Format(CDate(getCurrentDate()), "yyyy")
        school_year1.Value = cur_year
        school_year2.Value = cur_year

        Call getSchemeList()
        Call getCourseList(CInt(cb_scheme.SelectedValue))
        Call LoadData()
        load_finishied = 0
    End Sub

    Private Sub getSchemeList()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS scheme_des_la, 0 AS scheme_id "
        Sql &= "UNION "
        Sql &= "SELECT scheme_des_la, scheme_id "
        Sql &= " FROM tbl_setting_scheme"
        Sql &= " ORDER BY scheme_id "
        dt = ExecuteDatable(Sql)
        cb_scheme.DataSource = dt
        cb_scheme.ValueMember = "scheme_id"
        cb_scheme.DisplayMember = "scheme_des_la"
    End Sub

    Private Sub getCourseList(ByVal sc As Integer)
        Dim ct_sc As String = ""
        If (sc <> 0) Then
            ct_sc = " WHERE(scheme_id=" & sc & ") "
        End If
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS course_des_la, 0 AS course_id "
        Sql &= "UNION "
        Sql &= "SELECT course_des_la, course_id "
        Sql &= " FROM tbl_setting_course " & ct_sc
        Sql &= " ORDER BY course_id "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "course_des_la"
    End Sub

    Public Sub LoadData()
        Dim ct_year As String = " WHERE((start_year<= " & school_year2.Value & ") AND (end_year>=" & school_year1.Value & ")) "
        Dim ct_scheme As String = ""
        Dim ct_course As String = ""
        Dim ct_search As String = ""

        If (cb_scheme.SelectedValue <> 0) Then
            ct_scheme = " AND (scheme_id = " & cb_scheme.SelectedValue & ")"
        End If
        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((student_code LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (phone_number LIKE '" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,date_of_birth ,birth_address_la ,"
        Sql &= " birth_address_en ,nationality ,address_la ,address_en ,phone_number ,wa_number ,job_des ,hight_school_name ,"
        Sql &= " hight_school_graduate_year ,parent_name ,parent_contact ,course_id ,current_term_id ,class_id ,start_year ,end_year ,"
        Sql &= " create_date ,student_status ,last_update ,user_update ,course_des_la ,course_des_en ,scheme_id ,scheme_des_la ,scheme_des_en ,"
        Sql &= " max_term_id_reg ,get_current_class_id ,current_sokhien ,get_current_term_id ,max_sokhien ,student_remark,  "
        Sql &= " (SELECT term_no+' (' + term_no_la + ')' AS maxt FROM dbo.view_term_list WHERE(term_id = dbo.view_std_list_prepare.max_term_id_reg)) AS max_term_reg, title_la, title_en "
        Sql &= " FROM view_std_list_prepare"
        Sql &= ct_year & ct_scheme & ct_course & ct_search
        Sql &= " ORDER BY scheme_id, start_year, course_id, student_fullname_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                Dim sex As String = dt.Rows(i).Item("title_la") & ". "

                Dim rm As String = dt.Rows(i).Item("student_remark")
                If (dt.Rows(i).Item("student_status") = 0) Then
                    rm = "ຢຸດຮຽນຊົ່ວຄາວ - " & dt.Rows(i).Item("student_remark")
                End If

                .Rows.Add(dt.Rows(i).Item("student_id"), (i + 1), dt.Rows(i).Item("student_code"), sex & dt.Rows(i).Item("student_fullname_la"), _
                          dt.Rows(i).Item("date_of_birth"), dt.Rows(i).Item("phone_number"), dt.Rows(i).Item("start_year"), _
                         (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), dt.Rows(i).Item("max_term_reg"), _
                          dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"), rm)

                'Color Font
                If (cur_year > dt.Rows(i).Item("end_year")) Then
                    .Rows(i).DefaultCellStyle.ForeColor = Color.Green
                End If

                'Color Font
                If (dt.Rows(i).Item("student_status") = 0) Then
                    .Rows(i).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next

            If (.RowCount > 0) Then
                btn_edit.Enabled = True
                btn_print_score.Enabled = True
                btn_print_cer.Enabled = True
            Else
                btn_edit.Enabled = False
                btn_print_score.Enabled = False
                btn_print_cer.Enabled = False
            End If
        End With
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        Dim frm As New FrmStudent_Detail
        frm.ShowDialog()
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged(sender As Object, e As EventArgs)
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub cb_year_SelectedIndexChanged(sender As Object, e As EventArgs)
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub cb_learning_time_SelectedIndexChanged(sender As Object, e As EventArgs)
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print_cer.Click
        BILL_ID = Datagridview1.CurrentRow.Cells(1).Value
        reg_number_of_term_where = " WHERE(bill_id='" & BILL_ID & "')"
        rpt_status = 2
        Rpt_OnlyView = 1
        FrmReport_A5.ShowDialog()
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        'With Datagridview1
        '    btn_edit.Enabled = False
        '    btn_debt_payment.Enabled = False
        '    If (.RowCount > 0) Then
        '        If (IsDBNull(.CurrentRow.Cells(9).Value)) Then
        '            btn_edit.Enabled = True
        '        End If
        '        If (CInt(.CurrentRow.Cells(10).Value) > CInt(.CurrentRow.Cells(11).Value)) Then
        '            btn_debt_payment.Enabled = True
        '        End If
        '    Else
        '        btn_print.Enabled = False
        '    End If
        'End With
    End Sub

    Private Sub btn_debt_payment_Click(sender As Object, e As EventArgs) Handles btn_print_score.Click
        id_edit = Datagridview1.CurrentRow.Cells(0).Value
        FrmStudentRegister_RePayment.ShowDialog()
    End Sub

    Private Sub cb_SetClass_Term_SelectedIndexChanged(sender As Object, e As EventArgs)
        '    If (load_finishied = 0) And (load_class = 0) Then
        '        Call getClassListSetClass(cb_SetClass_Term.SelectedValue)
        '    End If
    End Sub

    Private Sub DataGridView3_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        'DataGridView3.EndEdit()
        'If (e.ColumnIndex = 1) Then
        '    Dim checked_num As Integer = 0
        '    For Each row As DataGridViewRow In DataGridView3.Rows
        '        If (row.Cells(1).Value = True) Or (row.Cells(1).Value = 1) Then
        '            checked_num += 1
        '            Exit For
        '        End If
        '    Next

        '    btn_SetClass_Confirm.Enabled = False
        '    If (checked_num > 0) Then
        '        btn_SetClass_Confirm.Enabled = True
        '    End If
        'End If
    End Sub

    Private Sub school_year1_ValueChanged(sender As Object, e As EventArgs) Handles school_year1.ValueChanged
        If (load_finishied = 0) Then
            If (school_year2.Value < school_year1.Value) Then
                school_year2.Value = school_year1.Value
            End If
            Call LoadData()
        End If
    End Sub
    Private Sub school_year2_ValueChanged(sender As Object, e As EventArgs) Handles school_year2.ValueChanged
        If (load_finishied = 0) Then
            If (school_year2.Value < school_year1.Value) Then
                school_year1.Value = school_year2.Value
            End If
            Call LoadData()
        End If
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cb_scheme.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class