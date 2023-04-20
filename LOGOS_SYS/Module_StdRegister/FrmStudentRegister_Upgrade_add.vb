Imports System.Data.SqlClient

Public Class FrmStudentRegister_Upgrade_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentRegister_view.LoadData_StudentUpgrade()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_finished = 1
        had_change_val = 0
        Call clear_text()
        load_finished = 0
    End Sub

    Dim load_finished As Integer = 1
    Dim start_year As Integer = 0
    Private Sub clear_text()
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        txt_std_code.Text = ""
        txt_std_code.Tag = ""
        txt_name.Text = ""
        txt_name.Tag = ""
        txt_subject.Text = ""
        txt_subject.Tag = ""
        txt_phone.Text = ""
        txt_total.Text = ""
        txt_course.Tag = ""
        txt_course.Text = ""
        txt_comment.Text = ""
        txt_total.Text = 0
        Datagridview1.Rows.Clear()
        btn_save.Enabled = False

        Dim cur_yyyy As Integer = Format(CDate(cur_date), "yyyy")
        start_year = cur_yyyy

        calendar_test.SetSelectionRange(CDate(cur_date), CDate(cur_date))
        calendar_test.MinDate = CDate(cur_date)

        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
        txt_std_code.Select()
    End Sub
    Private Sub calendar_test_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar_test.DateChanged
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub add_new_user()
        If (txt_std_code.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກ ຫຼື ຄົ້ນຫານັກສຶກສາ ທີ່ຕ້ອງການລົງທະບຽນອັບເກຣດກ່ອນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If
        If (txt_name.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກ ຫຼື ຄົ້ນຫານັກສຶກສາ ທີ່ຕ້ອງການລົງທະບຽນກ່ອນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_search.Focus()
            Exit Sub
        End If
        If (txt_subject.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກວິຊາຮຽນ ທີ່ຕ້ອງການລົງທະບຽນກ່ອນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_subject.Focus()
            Exit Sub
        End If
        If (rdo_BT.Checked = False) And (rdo_cash.Checked = False) Then
            MessageBox.Show("Please select payment type.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_cash.Focus()
            Exit Sub
        End If

        'Insert Enroll
        Cursor = Cursors.WaitCursor

        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If

        'Payment
        Dim payment_type As Integer = 1
        If (rdo_BT.Checked = True) Then
            payment_type = 2
        End If

        'Register
        BILL_ID = Max_Bill_id("UPG-", "tbl_term_register_upgrade", "bill_id")

        Call ConnectDB()
        Dim learn_date As String = Format(CDate(lb_test_date.Text), "yyyy-MM-dd")
        Sql = "INSERT INTO tbl_term_register_upgrade(bill_id ,student_id ,subject_id ,register_amount ,register_date ,register_remark ,payment_type ,receive_by ,receive_id, user_update) "
        Sql &= " VALUES(@bill_id ,@student_id ,@subject_id ,@register_amount ,@register_date ,@register_remark ,@payment_type ,@receive_by ,@receive_id, @user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("bill_id", BILL_ID)
        cm.Parameters.AddWithValue("student_id", CInt(txt_std_code.Tag))
        cm.Parameters.AddWithValue("subject_id", txt_subject.Tag)
        cm.Parameters.AddWithValue("register_amount", CDbl(txt_total.Text))
        cm.Parameters.AddWithValue("register_date", learn_date)
        cm.Parameters.AddWithValue("register_remark", cmt)
        cm.Parameters.AddWithValue("payment_type", payment_type)
        cm.Parameters.AddWithValue("receive_by", User_name)
        cm.Parameters.AddWithValue("receive_id", User_ID)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        'StudentLog
        Dim action_detail As String = "ລົງທະບຽນອັບເກດ (ວິຊາ: " & txt_subject.Text & ") ຈຳນວນເງິນ: " & txt_total.Text
        Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)

        'MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        reg_number_of_term_where = " WHERE(bill_id = '" & BILL_ID & "')"
        had_change_val = 1
        rpt_status = 3
        Rpt_OnlyView = 0
        FrmReport_A5.ShowDialog()
        Cursor = Cursors.Default
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub getTermListInCourse(ByVal c As Integer, ByVal student_id As Integer)
        Sql = "SELECT term_id ,term_no ,term_des ,course_id ,term_status, term_study_year, "
        Sql &= " ISNULL((SELECT 0 FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), 1) AS register_st,"
        Sql &= " ISNULL((SELECT register_amount FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), view_term_table.register_amount) AS register_amount, "
        Sql &= " ISNULL((SELECT register_discount FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), 0) AS register_discount, "
        Sql &= " ISNULL((SELECT register_year FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), 0) AS register_year "
        Sql &= " FROM view_term_table"
        Sql &= " WHERE(term_status <> 0) AND (course_id=1)"
        Sql &= " ORDER BY term_list_id"

        dt = ExecuteDatable(Sql)
        Datagridview1.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            Dim max_y As Integer = 0
            Dim idx As Integer = 0
            Dim get_idx As Integer = 0

            With Datagridview1
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim registed_text As String = "ຍັງບໍ່ລົງທະບຽນ"
                    Dim chked As Integer = 0
                    If (dt.Rows(i).Item("register_st") = 0) Then
                        registed_text = "ລົງທະບຽນແລ້ວ"
                        chked = 1
                    End If

                    Dim sokhien As String = dt.Rows(i).Item("register_year")
                    If (sokhien = "0") And (get_idx = 0) Then
                        idx = i - 1
                        get_idx = 1
                    End If

                    max_y = Mid(dt.Rows(idx).Item("register_year"), 1, 4)
                    sokhien = max_y - 1 + CInt(dt.Rows(i).Item("term_study_year")) & "-" & max_y + CInt(dt.Rows(i).Item("term_study_year"))

                    .Rows.Add(dt.Rows(i).Item("term_id"), chked, (dt.Rows(i).Item("term_no") & "-[" & dt.Rows(i).Item("term_des") & "]"), _
                              dt.Rows(i).Item("register_amount"), dt.Rows(i).Item("register_discount"), sokhien, _
                              registed_text, dt.Rows(i).Item("register_st"))
                Next

            End With

            Datagridview1.ReadOnly = True
            Dim checked_num As Integer = 0
            For Each row As DataGridViewRow In Datagridview1.Rows
                If (row.Cells(7).Value = 0) Then
                    checked_num += 1
                End If
            Next
            For Each row As DataGridViewRow In Datagridview1.Rows
                If (row.Index >= checked_num) Then
                    Datagridview1.Rows(row.Index).ReadOnly = True
                    Datagridview1.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

        End If
    End Sub

    Private Sub txt_std_code_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_std_code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SearchingStudent()
        End If
    End Sub

    Private Sub SearchingStudent()
        Sql = " SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,date_of_birth ,"
        Sql &= " birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,phone_number ,wa_number ,job_des ,"
        Sql &= " hight_school_name ,hight_school_graduate_year ,parent_name ,parent_contact ,course_id ,current_term_id ,"
        Sql &= " class_id ,start_year ,end_year ,create_date ,student_status ,last_update ,user_update, "
        Sql &= " (SELECT scheme_des_la+' ('+course_des_la+')' FROM view_course_list WHERE(course_id=tbl_student.course_id)) AS course_des_la "
        Sql &= " FROM tbl_student "
        Sql &= " WHERE(student_code LIKE '%" & txt_std_code.Text.Trim & "%') "
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count = 0) Then
            Call clear_text()
            MessageBox.Show("ລະຫັດນັກສຶກສາທີ່ທ່ານຄົ້ນຫາບໍ່ມີ", "ລາຍງານ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If (dt.Rows.Count > 1) Or (txt_std_code.Text.Trim = "") Then
            'Go to form Student list
            reg_search_where = txt_std_code.Text.Trim
            If FrmStudentRegister_Select.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txt_std_code.Text = FrmStudentRegister_Select.get_std_code
                txt_std_code.Tag = FrmStudentRegister_Select.get_student_id
                lb_title.Text = "ຊື່ນັກສຶກສາ(" & FrmStudentRegister_Select.get_sex & ")"
                txt_name.Text = FrmStudentRegister_Select.get_student_name_la
                DateTimePicker1.Text = FrmStudentRegister_Select.get_birth_date
                txt_course.Tag = FrmStudentRegister_Select.get_course_id
                txt_course.Text = FrmStudentRegister_Select.get_full_course
                txt_phone.Text = FrmStudentRegister_Select.get_telephone
                txt_comment.Text = "--"
                Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)
            End If
        End If
        If (dt.Rows.Count = 1) Then
            'Get Data Student
            With dt.Rows(0)
                txt_std_code.Text = CStr(.Item("student_code"))
                txt_std_code.Tag = CInt(.Item("student_id"))
                lb_title.Text = "ຊື່ນັກສຶກສາ(ນາງ)"
                If (CInt(.Item("student_gender")) = 1) Then
                    lb_title.Text = "ຊື່ນັກສຶກສາ(ທ້າວ)"
                End If
                txt_name.Text = .Item("student_fullname_la")
                txt_phone.Text = .Item("phone_number")
                DateTimePicker1.Text = .Item("date_of_birth")
                txt_course.Tag = .Item("course_id")
                txt_course.Text = .Item("course_des_la")
                txt_comment.Text = "--"

                If (txt_course.Text <> "") Then
                    Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)
                End If
            End With
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Call SearchingStudent()
    End Sub

    Private Sub btn_search_subject_Click(sender As Object, e As EventArgs) Handles btn_search_subject.Click
        subject_filter = ""
        If FrmTermSubject_select.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_subject.Tag = FrmTermSubject_select.sb_id
            txt_subject.Text = FrmTermSubject_select.sb_desc & "-[" & FrmTermSubject_select.sb_credit & " ໜ່ວຍກິດ]"
            txt_total.Text = Format(CDbl(FrmTermSubject_select.sb_upgrade_price), "N0")
        End If
    End Sub

    Private Sub txt_subject_TextChanged(sender As Object, e As EventArgs) Handles txt_subject.TextChanged
        If (load_finished = 0) Then
            If (txt_subject.Text.Trim <> "") And (txt_name.Text.Trim <> "") Then
                btn_save.Enabled = True
            Else
                btn_save.Enabled = False
            End If
        End If
    End Sub
End Class