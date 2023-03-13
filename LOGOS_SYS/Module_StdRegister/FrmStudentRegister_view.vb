Public Class FrmStudentRegister_view

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control_Reg.Enabled = True
        If (user_permission.Item(0).student_enroll_test = 0) Then
            Panel_Control_Reg.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        maintab.SelectedTabPageIndex = 0
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        DateTimePicker2.Value = CDate(cur_date)
        Dim Last_Month As Date = DateAdd(DateInterval.Day, -180, CDate(cur_date))
        DateTimePicker1.Value = CDate(Last_Month)
        DateTimePicker2.MinDate = CDate(DateTimePicker1.Value)

        Call getYearList()
        Call getCourseList()
        Call getTermList(CInt(cb_course.SelectedValue))
        Call LoadData()
        load_finishied = 0
    End Sub

    Private Sub getYearList()
        cb_year.Items.Clear()
        Dim cur_year As Integer = CInt(Format(CDate(cur_date), "yyyy")) - 8
        Dim i As Integer = 9
        While i > 0
            cb_year.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            i -= 1
        End While
        cb_year.SelectedIndex = 1
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

        cb_course_upg.DataSource = dt
        cb_course_upg.ValueMember = "course_id"
        cb_course_upg.DisplayMember = "full_course"
    End Sub

    Private Sub getTermList(ByVal sch As Integer)
        Dim ct As String = ""
        If (sch <> 0) Then
            ct = " WHERE(course_id = " & sch & ")"
        End If
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_term, 0 AS term_id "
        Sql &= "UNION "
        Sql &= "SELECT (term_no+' ('+term_des+')') AS full_term, term_id "
        Sql &= " FROM view_term_table " & ct
        Sql &= " ORDER BY term_id "
        dt = ExecuteDatable(Sql)
        cb_term.DataSource = dt
        cb_term.ValueMember = "term_id"
        cb_term.DisplayMember = "full_term"
    End Sub

    Public Sub LoadData()
        Dim ct_year As String = " AND (register_year='" & cb_year.SelectedItem & "')"
        Dim ct_course As String = ""
        Dim ct_term As String = ""
        Dim ct_search As String = ""

        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (cb_term.SelectedValue <> 0) Then
            ct_term = " AND (term_id = " & cb_term.SelectedValue & ")"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((student_code LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (class_room LIKE N'" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (phone_number LIKE '" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT term_register_id ,bill_id ,student_id ,term_id ,class_id ,register_amount ,register_discount ,register_year ,"
        Sql &= " register_date ,last_update ,user_update ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,"
        Sql &= " date_of_birth ,birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,phone_number ,wa_number ,"
        Sql &= " job_des ,hight_school_name ,hight_school_graduate_year ,parent_name ,parent_contact ,start_year ,end_year ,"
        Sql &= " student_status ,term_no ,term_des ,term_register_amt ,course_id ,course_des_la ,course_des_en ,course_test_amount ,"
        Sql &= " scheme_id ,scheme_des_la ,scheme_des_en ,class_room, dbo.payment_amt(bill_id) AS sum_term_paid "
        Sql &= " FROM view_std_register"
        Sql &= " WHERE(term_register_id > 0) " & ct_year & ct_course & ct_term & ct_search
        Sql &= " ORDER BY scheme_id, course_id, student_fullname_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                Dim sex As String = "ທ້າວ. "
                If (dt.Rows(i).Item("student_gender") = 2) Then
                    sex = "ນາງ. "
                End If

                .Rows.Add(dt.Rows(i).Item("term_register_id"), dt.Rows(i).Item("bill_id"), (i + 1), dt.Rows(i).Item("student_code"), sex & dt.Rows(i).Item("student_fullname_la"), _
                          dt.Rows(i).Item("phone_number"), dt.Rows(i).Item("register_year"), _
                         (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), (dt.Rows(i).Item("term_no") & "-[" & dt.Rows(i).Item("term_des") & "]"), _
                          dt.Rows(i).Item("class_room"), CInt(dt.Rows(i).Item("register_amount")) - CInt(dt.Rows(i).Item("register_discount")), dt.Rows(i).Item("sum_term_paid"), _
                          dt.Rows(i).Item("user_update"), dt.Rows(i).Item("register_date"))

                'Color Font
                If ((CInt(dt.Rows(i).Item("register_amount")) - CInt(dt.Rows(i).Item("register_discount"))) > dt.Rows(i).Item("sum_term_paid")) Then
                    .Rows(i).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next

            btn_reg_new.Enabled = True
            btn_debt_payment.Enabled = False
            If (.RowCount > 0) Then
                If (IsDBNull(dt.Rows(0).Item("class_room"))) Then
                    btn_edit.Enabled = True
                End If
                If ((CInt(dt.Rows(0).Item("register_amount")) - CInt(dt.Rows(0).Item("register_discount"))) > CInt(dt.Rows(0).Item("sum_term_paid"))) Then
                    btn_debt_payment.Enabled = True
                End If
                btn_print.Enabled = True
            Else
                btn_edit.Enabled = False
                btn_print.Enabled = False
            End If
        End With
    End Sub

    Public Sub LoadData_StudentUpgrade()
        btn_upg_new.Enabled = True
        Dim s_d As String = Convert.ToDateTime(DateTimePicker1.Value.Date).ToString("yyyy-MM-dd")
        Dim e_d As String = Convert.ToDateTime(DateTimePicker2.Value.Date).ToString("yyyy-MM-dd")
        Dim ct_date As String = " AND (register_date BETWEEN '" & s_d & "' AND '" & e_d & "')"
        Dim ct_course As String = ""
        Dim ct_search As String = ""

        If (cb_course_upg.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((student_code LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (subject_name_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (subject_name_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (phone_number LIKE '" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT register_upg_id ,bill_id ,register_date ,register_amount ,register_remark ,receive_by ,receive_id ,"
        Sql &= " student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,phone_number ,"
        Sql &= " course_id ,course_des_la ,course_des_en ,scheme_id ,scheme_des_la ,scheme_des_en ,"
        Sql &= " subject_id ,subject_code ,subject_name_la ,subject_name_en ,subject_credit"
        Sql &= " FROM view_register_upgrade "
        Sql &= " WHERE(register_upg_id > 0) " & ct_date & ct_course & ct_search
        Sql &= " ORDER BY register_date, student_code  "
        dt = ExecuteDatable(Sql)

        With DataGridView2
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                Dim sex As String = "ທ້າວ. "
                If (dt.Rows(i).Item("student_gender") = 2) Then
                    sex = "ນາງ. "
                End If

                .Rows.Add(dt.Rows(i).Item("register_upg_id"), dt.Rows(i).Item("bill_id"), (i + 1), dt.Rows(i).Item("student_code"), sex & dt.Rows(i).Item("student_fullname_la"), _
                          dt.Rows(i).Item("phone_number"), (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), _
                          dt.Rows(i).Item("register_date"), dt.Rows(i).Item("subject_name_la"), dt.Rows(i).Item("subject_credit"), CInt(dt.Rows(i).Item("register_amount")), _
                          dt.Rows(i).Item("receive_by"), dt.Rows(i).Item("register_remark"))
            Next

            If (.RowCount > 0) Then
                btn_upg_delete.Enabled = True
                btn_upg_edit.Enabled = True
                btn_upg_print.Enabled = True
            Else
                btn_upg_delete.Enabled = False
                btn_upg_edit.Enabled = False
                btn_upg_print.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_reg_new.Click
        ''Check for open enroll or not?
        'Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        'Dim cur_yyyy As Integer = Format(CDate(cur_date), "yyyy")
        'Dim sokhien As String = cur_yyyy & "-" & cur_yyyy + 1
        'Sql = "SELECT year_study FROM tbl_setting_open_close_reg "
        'Sql &= " WHERE(open_close_type=1) AND (enroll_or_register=2) AND (year_study='" & sokhien & "') AND ((open_date <= CAST(GETDATE() AS DATE)) AND (close_date >= CAST(GETDATE() AS DATE))) "
        'dt = ExecuteDatable(Sql)
        'If (dt.Rows.Count <= 0) Then
        '    MessageBox.Show("ກະລຸນາເປີດການລົງທະບຽນເຂົ້າຮຽນກ່ອນ ດຳເນີນການລົງທະບຽນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If

        FrmStudentRegister_add.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs)
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        'FrmStudentEnroll_edit.ShowDialog()
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call getTermList(CInt(cb_course.SelectedValue))
            Call LoadData()
        End If
    End Sub

    Private Sub cb_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_year.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub cb_learning_time_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_term.SelectedIndexChanged
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
        BILL_ID = Datagridview1.CurrentRow.Cells(1).Value
        reg_number_of_term_where = " WHERE(bill_id='" & BILL_ID & "')"
        rpt_status = 2
        Rpt_OnlyView = 1
        FrmReport_A5.ShowDialog()
    End Sub

    Private Sub btn_edit_Click_1(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_edit = Datagridview1.CurrentRow.Cells(0).Value
        FrmStudentRegister_edit.ShowDialog()
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        With Datagridview1
            btn_edit.Enabled = False
            btn_debt_payment.Enabled = False
            If (.RowCount > 0) Then
                If (IsDBNull(.CurrentRow.Cells(9).Value)) Then
                    btn_edit.Enabled = True
                End If
                If (CInt(.CurrentRow.Cells(10).Value) > CInt(.CurrentRow.Cells(11).Value)) Then
                    btn_debt_payment.Enabled = True
                End If
            Else
                btn_print.Enabled = False
            End If
        End With
    End Sub

    Private Sub btn_reg_payment_Click(sender As Object, e As EventArgs) Handles btn_reg_payment.Click
        FrmStudentRegister_Second.ShowDialog()
    End Sub

    Private Sub btn_debt_payment_Click(sender As Object, e As EventArgs) Handles btn_debt_payment.Click
        id_edit = Datagridview1.CurrentRow.Cells(0).Value
        FrmStudentRegister_RePayment.ShowDialog()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (load_finishied = 0) Then
            DateTimePicker2.MinDate = CDate(DateTimePicker1.Value)
            Call LoadData_StudentUpgrade()
        End If
    End Sub
    Private Sub cb_course_upg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course_upg.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData_StudentUpgrade()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If (load_finishied = 0) Then
            Call LoadData_StudentUpgrade()
        End If
    End Sub

    Private Sub txt_upg_search_TextChanged(sender As Object, e As EventArgs) Handles txt_upg_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData_StudentUpgrade()
        End If
    End Sub

    Private Sub maintab_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles maintab.SelectedPageChanged
        If (load_finishied = 0) Then
            If (maintab.SelectedTabPageIndex = 0) Then
                Call LoadData()
            End If
            If (maintab.SelectedTabPageIndex = 1) Then
                Call LoadData_StudentUpgrade()
            End If
            If (maintab.SelectedTabPageIndex = 2) Then
                Call ResetStdFilterSetClass()
            End If
        End If
    End Sub

    Private Sub getCourseListSetClass()
        Sql = "SELECT (scheme_des_la+' -['+course_des_la+']') AS full_course, course_id "
        Sql &= " FROM view_course_list"
        Sql &= " ORDER BY course_id "
        dt = ExecuteDatable(Sql)
        cb_SetClass_course.DataSource = dt
        cb_SetClass_course.ValueMember = "course_id"
        cb_SetClass_course.DisplayMember = "full_course"
        cb_SetClass_course.SelectedIndex = 0
    End Sub

    Private Sub getTermListSetClass(ByVal sch As Integer)
        load_class = 1
        Sql = "SELECT (term_no+' ('+term_des+')') AS full_term, term_id "
        Sql &= " FROM view_term_table "
        Sql &= " WHERE(course_id = " & sch & ")"
        Sql &= " ORDER BY term_id "
        dt = ExecuteDatable(Sql)
        cb_SetClass_Term.DataSource = dt
        cb_SetClass_Term.ValueMember = "term_id"
        cb_SetClass_Term.DisplayMember = "full_term"
        load_class = 0
    End Sub

    Dim load_class As Integer = 1
    Private Sub getClassListSetClass(ByVal term As Integer)
        Sql = "SELECT class_id ,(class_code+'('+class_des+')') AS full_class"
        Sql &= " FROM tbl_setting_class"
        Sql &= " WHERE(term_id=" & term & ") AND (class_status=1)"
        Sql &= " ORDER BY class_code, class_des "
        dt = ExecuteDatable(Sql)
        cb_SetClass_Class.DataSource = dt
        cb_SetClass_Class.ValueMember = "class_id"
        cb_SetClass_Class.DisplayMember = "full_class"
    End Sub

    Private Sub ResetStdFilterSetClass()
        DataGridView3.Rows.Clear()
        txt_SetClass_Sokhien.Text = cb_year.Items(1)
        Call getCourseListSetClass()
        Call getTermListSetClass(cb_SetClass_course.SelectedValue)
        Call getClassListSetClass(cb_SetClass_Term.SelectedValue)
        txt_SetClass_Search.Text = ""
        txt_SetClass_Search.Select()
    End Sub

    Private Sub cb_SetClass_Term_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_SetClass_Term.SelectedIndexChanged
        If (load_finishied = 0) And (load_class = 0) Then
            Call getClassListSetClass(cb_SetClass_Term.SelectedValue)
        End If
    End Sub

    Private Sub btn_upg_new_Click(sender As Object, e As EventArgs) Handles btn_upg_new.Click
        FrmStudentRegister_Upgrade_add.ShowDialog()
    End Sub

    Private Sub btn_upg_edit_Click(sender As Object, e As EventArgs) Handles btn_upg_edit.Click
        id_edit = DataGridView2.CurrentRow.Cells(0).Value
        FrmStudentRegister_Upgrade_edit.ShowDialog()
    End Sub

    Private Sub btn_upg_delete_Click(sender As Object, e As EventArgs) Handles btn_upg_delete.Click
        'Check Student have upgrade Score
        Dim del_id As Integer = DataGridView2.CurrentRow.Cells(0).Value
        Dim std_id As Integer = DataGridView2.CurrentRow.Cells(13).Value
        Dim subject_id As Integer = DataGridView2.CurrentRow.Cells(14).Value
        Sql = "SELECT student_id "
        Sql &= " FROM tbl_student_score"
        Sql &= " WHERE(subject_id=" & subject_id & ") AND (student_id=" & std_id & ") AND (upgrade_score IS NOT NULL)"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("ບໍ່ສາມາດລຶບຂໍ້ມູນນີ້້ໄດ້, ເນື່ອງຈາກໄດ້ລົງຄະແນນອັບເກຣດຂອງນັກສຶກສາໃນວິຊານີ້ແລ້ວ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure want to delete this info?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM tbl_term_register_upgrade "
            Sql &= " WHERE(register_upg_id=" & del_id & ")"
            Call ExecuteDelete(Sql)
            Call LoadData_StudentUpgrade()
        End If
    End Sub

    Private Sub btn_upg_print_Click(sender As Object, e As EventArgs) Handles btn_upg_print.Click
        BILL_ID = DataGridView2.CurrentRow.Cells(1).Value
        reg_number_of_term_where = " WHERE(bill_id='" & BILL_ID & "')"
        rpt_status = 3
        Rpt_OnlyView = 1
        FrmReport_A5.ShowDialog()
    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        btn_upg_new.Enabled = True
        Dim s_d As String = Convert.ToDateTime(DateTimePicker1.Value.Date).ToString("yyyy-MM-dd")
        Dim e_d As String = Convert.ToDateTime(DateTimePicker2.Value.Date).ToString("yyyy-MM-dd")
        Dim ct_date As String = " AND (register_date BETWEEN '" & s_d & "' AND '" & e_d & "')"
        Dim ct_course As String = ""
        Dim ct_search As String = ""

        If (cb_course_upg.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((student_code LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (subject_name_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (subject_name_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (phone_number LIKE '" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT register_upg_id ,bill_id ,register_date ,register_amount ,register_remark ,receive_by ,receive_id ,"
        Sql &= " student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,phone_number ,"
        Sql &= " course_id ,course_des_la ,course_des_en ,scheme_id ,scheme_des_la ,scheme_des_en ,"
        Sql &= " subject_id ,subject_code ,subject_name_la ,subject_name_en ,subject_credit"
        Sql &= " FROM view_register_upgrade "
        Sql &= " WHERE(register_upg_id > 0) " & ct_date & ct_course & ct_search
        Sql &= " ORDER BY register_date, student_code  "
        dt = ExecuteDatable(Sql)

        With DataGridView2
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                Dim sex As String = "ທ້າວ. "
                If (dt.Rows(i).Item("student_gender") = 2) Then
                    sex = "ນາງ. "
                End If

                .Rows.Add(dt.Rows(i).Item("register_upg_id"), dt.Rows(i).Item("bill_id"), (i + 1), dt.Rows(i).Item("student_code"), sex & dt.Rows(i).Item("student_fullname_la"), _
                          dt.Rows(i).Item("phone_number"), (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), _
                          dt.Rows(i).Item("register_date"), dt.Rows(i).Item("subject_name_la"), dt.Rows(i).Item("subject_credit"), CInt(dt.Rows(i).Item("register_amount")), _
                          dt.Rows(i).Item("receive_by"), dt.Rows(i).Item("register_remark"))
            Next

            If (.RowCount > 0) Then
                btn_upg_delete.Enabled = True
                btn_upg_edit.Enabled = True
                btn_upg_print.Enabled = True
            Else
                btn_upg_delete.Enabled = False
                btn_upg_edit.Enabled = False
                btn_upg_print.Enabled = False
            End If
        End With
    End Sub

End Class