Imports System.Data.SqlClient

Public Class FrmStudentRegister_Second

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentRegister_view.LoadData()
        End If
    End Sub

    Private Sub getLearningShiftList(ByVal c As Integer)
        Sql = "SELECT learning_shift_des, learning_shift_id "
        Sql &= " FROM tbl_setting_learning_shift WHERE((learning_shift_status <> 0) AND (course_id=" & c & ")) OR (course_id=0) "
        Sql &= " ORDER BY course_id, learning_shift_id "
        dt = ExecuteDatable(Sql)
        cb_learning_time.DataSource = dt
        cb_learning_time.ValueMember = "learning_shift_id"
        cb_learning_time.DisplayMember = "learning_shift_des"
        cb_learning_time.SelectedIndex = 0
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
        txt_name_en.Text = ""
        txt_phone.Text = ""
        txt_total.Text = ""
        txt_scheme_id.Text = ""
        txt_course.Tag = ""
        txt_course.Text = ""
        txt_comment.Text = ""
        txt_total.Text = 0
        txt_discount.Text = 0
        txt_receive.Text = 0
        txt_paid.Text = 0
        txt_remain.Text = 0
        txt_paid.ReadOnly = True
        Datagridview1.Rows.Clear()
        btn_save.Enabled = False

        Dim cur_yyyy As Integer = Format(CDate(cur_date), "yyyy")
        start_year = cur_yyyy

        Dim test_date As String = Format(CDate(My.Settings.default_learn_date), "yyyy-MM-dd")
        If (test_date < cur_date) Then
            My.Settings.default_learn_date = cur_date
            My.Settings.Save()
        End If

        calendar_test.MinDate = CDate(cur_date)
        Call SetTestDate()
        txt_std_code.Select()
    End Sub

    Public Sub SetTestDate()
        calendar_test.SetSelectionRange(CDate(My.Settings.default_learn_date), CDate(My.Settings.default_learn_date))
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub add_new_user()
        If (txt_std_code.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກ ຫຼື ຄົ້ນຫານັກສຶກສາ ທີ່ຕ້ອງການລົງທະບຽນກ່ອນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If
        If (txt_name.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກ ຫຼື ຄົ້ນຫານັກສຶກສາ ທີ່ຕ້ອງການລົງທະບຽນກ່ອນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_search.Focus()
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
        Dim min_bill As String = ""
        Dim max_bill As String = ""
        Dim count_chked As Integer = 0
        Dim text_chked As Integer = 0
        For i As Integer = 0 To Datagridview1.Rows.Count - 1
            If (Datagridview1.Rows(i).Cells(1).Value) = True Then
                count_chked += 1
                text_chked &= Datagridview1.Rows(i).Cells(2).Value & "/"
                BILL_ID = Max_Bill_id("INV-", "tbl_term_register", "bill_id")
                If (min_bill = "") Then
                    min_bill = BILL_ID
                End If
                max_bill = BILL_ID

                Call ConnectDB()
                Dim learn_date As String = Format(CDate(lb_test_date.Text), "yyyy-MM-dd")
                Sql = "INSERT INTO tbl_term_register(bill_id ,student_id ,term_id ,register_amount ,register_discount ,register_year ,start_learn_date ,register_comment, user_update, learning_shift_id) "
                Sql &= " VALUES(@bill_id ,@student_id ,@term_id ,@register_amount ,@register_discount ,@register_year ,@start_learn_date ,@register_comment, @user_update, @learning_shift_id)"
                cm = New SqlCommand(Sql, conn)
                cm.Parameters.AddWithValue("bill_id", BILL_ID)
                cm.Parameters.AddWithValue("student_id", CInt(txt_std_code.Tag))
                cm.Parameters.AddWithValue("term_id", Datagridview1.Rows(i).Cells(0).Value)
                cm.Parameters.AddWithValue("register_amount", CDbl(Datagridview1.Rows(i).Cells(3).Value))
                cm.Parameters.AddWithValue("register_discount", CDbl(Datagridview1.Rows(i).Cells(4).Value))
                cm.Parameters.AddWithValue("register_year", CStr(Datagridview1.Rows(i).Cells(5).Value))
                cm.Parameters.AddWithValue("start_learn_date", learn_date)
                cm.Parameters.AddWithValue("register_comment", cmt)
                cm.Parameters.AddWithValue("user_update", User_name)
                cm.Parameters.AddWithValue("learning_shift_id", CInt(cb_learning_time.SelectedValue))
                cm.ExecuteNonQuery()

                'Get-Payment QTY
                Dim qty_payment As Double = CDbl(Datagridview1.Rows(i).Cells(3).Value) - CDbl(Datagridview1.Rows(i).Cells(4).Value)
                If (txt_paid.ReadOnly = False) And (CInt(txt_remain.Text) > 0) Then
                    qty_payment = CDbl(txt_paid.Text.Trim)
                End If

                Sql = "INSERT INTO tbl_term_payment(bill_id ,paid_amount ,payment_type ,receive_by ,receive_id) "
                Sql &= " VALUES(@bill_id ,@paid_amount ,@payment_type ,@receive_by ,@receive_id)"
                cm = New SqlCommand(Sql, conn)
                cm.Parameters.AddWithValue("bill_id", BILL_ID)
                cm.Parameters.AddWithValue("paid_amount", qty_payment)
                cm.Parameters.AddWithValue("payment_type", payment_type)
                cm.Parameters.AddWithValue("receive_by", User_name)
                cm.Parameters.AddWithValue("receive_id", User_ID)
                cm.Parameters.AddWithValue("learning_shift_id", CInt(cb_learning_time.SelectedValue))
                cm.ExecuteNonQuery()
            End If
        Next

        'StudentLog
        If (count_chked = 1) Then
            If (CInt(txt_remain.Text) > 0) Then
                Dim action_detail As String = "ລົງທະບຽນເຂົ້າຮຽນ " & Mid(text_chked, 1, Len(text_chked) - 1) & "(ຕິດໜີ້: " & txt_remain.Text & ")"
                Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
            Else
                Dim action_detail As String = "ລົງທະບຽນເຂົ້າຮຽນ " & Mid(text_chked, 1, Len(text_chked) - 1)
                Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
            End If
        Else
            Dim action_detail As String = "ລົງທະບຽນເຂົ້າຮຽນ " & Mid(text_chked, 1, Len(text_chked) - 1)
            Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
        End If

        'MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        reg_number_of_term_where = " WHERE(bill_id BETWEEN '" & min_bill & "' AND '" & max_bill & "')"
        had_change_val = 1
        rpt_status = 2
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
        Sql &= " WHERE(term_status <> 0) AND (course_id=" & c & ")"
        Sql &= " ORDER BY term_list_id"

        dt = ExecuteDatable(Sql)
        Datagridview1.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            Dim is_geted_index_next_term As Integer = 0
            Dim index_next_term As Integer = 0
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

                    'GetIndex Checked next 1 term
                    If (dt.Rows(i).Item("register_st") = 1) And (is_geted_index_next_term = 0) Then
                        index_next_term = i
                        is_geted_index_next_term = 1
                    End If

                    .Rows.Add(dt.Rows(i).Item("term_id"), chked, (dt.Rows(i).Item("term_no") & "-[" & dt.Rows(i).Item("term_des") & "]"), _
                              dt.Rows(i).Item("register_amount"), dt.Rows(i).Item("register_discount"), sokhien, _
                              registed_text, dt.Rows(i).Item("register_st"))
                Next

            End With

            Datagridview1.ReadOnly = False
            Dim checked_num As Integer = 0
            For Each row As DataGridViewRow In Datagridview1.Rows
                If (row.Cells(7).Value = 0) Then
                    checked_num += 1
                End If
            Next
            For Each row As DataGridViewRow In Datagridview1.Rows
                If (row.Index > checked_num) Then
                    Datagridview1.Rows(row.Index).ReadOnly = True
                    Datagridview1.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

            'If all term Registered
            Datagridview1.Enabled = True
            If (checked_num = Datagridview1.RowCount) Then
                Datagridview1.Enabled = False
            End If

            'Checked Next term
            btn_save.Enabled = True
            If (checked_num < Datagridview1.RowCount) Then
                Datagridview1.Rows(index_next_term).Cells(1).Value = True
                If (index_next_term < Datagridview1.RowCount) Then
                    Datagridview1.Rows(index_next_term + 1).ReadOnly = False
                    Datagridview1.Rows(index_next_term + 1).DefaultCellStyle.ForeColor = Color.Black
                End If
            ElseIf (checked_num = Datagridview1.RowCount) Then
                btn_save.Enabled = False
            End If

            'Summary
            Call SummayMoney()
        Else
            btn_save.Enabled = False
        End If
    End Sub

    Private Sub txt_course_TextChanged(sender As Object, e As EventArgs) Handles txt_course.TextChanged
        'If (txt_course.Text <> "") Then
        '    Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)
        'End If
    End Sub

    Private Sub calendar_test_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar_test.DateChanged
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub lb_test_date_Click(sender As Object, e As EventArgs) Handles lb_test_date.Click
        FrmStudentReg_SetDate.ShowDialog()
    End Sub

    Private Sub SummayMoney()
        Dim sum As Double = 0
        Dim dis As Double = 0
        Dim count_check As Integer = 0
        With Datagridview1

            For x As Integer = 0 To .RowCount - 1
                .Rows(x).Cells(4).ReadOnly = True
                .Rows(x).Cells(4).Value = Format(CDbl(.Rows(x).Cells(4).Value), "N0")
                If ((.Rows(x).Cells(1).Value = True) Or (.Rows(x).Cells(1).Value = 1)) And (.Rows(x).Cells(7).Value = 1) Then
                    count_check += 1
                    sum += CDbl(.Rows(x).Cells(3).Value)
                    dis += CDbl(.Rows(x).Cells(4).Value)
                    .Rows(x).Cells(4).ReadOnly = False
                End If
            Next

            txt_total.Text = Format(sum, "N0")
            txt_discount.Text = Format(CDbl(dis), "N0")
            txt_receive.Text = Format(CDbl(txt_total.Text) - CDbl(txt_discount.Text), "N0")
            txt_paid.Text = txt_receive.Text
            txt_remain.Text = Format(CDbl(txt_receive.Text) - CDbl(txt_paid.Text), "N0")

            btn_save.Enabled = False
            If (count_check > 0) Then
                btn_save.Enabled = True
                txt_paid.ReadOnly = False
                If (count_check > 1) Then
                    txt_paid.ReadOnly = True
                End If
            End If
        End With
    End Sub

    Private Sub Datagridview1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellEndEdit
        If e.ColumnIndex = 4 Then
            Call SummayMoney()
        End If
    End Sub

    Private Sub Datagridview1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Datagridview1.RowPostPaint
        For Each row As DataGridViewRow In Datagridview1.Rows
            If row.Cells(7).Value = 0 Then
                Datagridview1.Rows(row.Index).ReadOnly = True
                Datagridview1.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Gray
                Datagridview1.Rows(row.Index).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub ClickBox(ByVal indx As Integer, ByVal bl1 As Boolean, ByVal bl4 As Boolean, ByVal cl As Color)
        With Datagridview1
            Datagridview1.Rows(indx).Cells(1).ReadOnly = bl1
            Datagridview1.Rows(indx).Cells(4).ReadOnly = bl4
            Datagridview1.Rows(indx).Cells(2).Style.ForeColor = cl

            Datagridview1.Rows(indx).Cells(3).Style.ForeColor = cl
            Datagridview1.Rows(indx).Cells(4).Style.ForeColor = cl
            Datagridview1.Rows(indx).Cells(5).Style.ForeColor = cl
            Datagridview1.Rows(indx).Cells(6).Style.ForeColor = cl
        End With
    End Sub
    Private Sub Datagridview1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datagridview1.CellMouseUp
        Datagridview1.EndEdit()
        If Datagridview1.Rows(e.RowIndex).Cells(1).Value.ToString() = "" Then
            Datagridview1.Rows(e.RowIndex).Cells(1).Value = 0
        End If
        If e.ColumnIndex = 1 And Datagridview1.CurrentRow.ReadOnly = False Then
            'MsgBox(Datagridview1.Rows(e.RowIndex).Cells(1).Value)
            If Not Datagridview1.Rows(e.RowIndex).Cells(1).Value = 0 Then
                If Not (e.RowIndex + 1) = Datagridview1.Rows.Count AndAlso Not Datagridview1.Rows(e.RowIndex + 1).Cells(1).Value = "1" Then
                    Call ClickBox(e.RowIndex + 1, False, False, Color.Black)
                End If
                If Not e.RowIndex = 0 Then
                    If (Datagridview1.Rows(e.RowIndex - 1).Cells(7).Value = 1) Then
                        Call ClickBox(e.RowIndex - 1, True, False, Color.Black)
                    Else
                        Call ClickBox(e.RowIndex - 1, True, False, Color.Gray)
                    End If
                End If
            Else
                If Not e.RowIndex = 0 Then
                    If Not Datagridview1.Rows(e.RowIndex - 1).Cells(7).Value = 0 AndAlso Not Datagridview1.Rows(e.RowIndex - 1).Cells(1).Value = "0" Then
                        If (Datagridview1.Rows(e.RowIndex - 1).Cells(7).Value = 1) Then
                            Call ClickBox(e.RowIndex - 1, False, True, Color.Black)
                        Else
                            Call ClickBox(e.RowIndex - 1, False, True, Color.Gray)
                        End If

                    End If
                End If
                If Not (e.RowIndex + 1) = Datagridview1.Rows.Count Then
                    Call ClickBox(e.RowIndex + 1, True, True, Color.Gray)
                End If

                If (Datagridview1.Rows(e.RowIndex).Cells(7).Value = 1) Then
                    Datagridview1.Rows(e.RowIndex).Cells(4).Value = 0
                End If
            End If
        End If

        'Summary
        Call SummayMoney()
    End Sub

    Private Sub txt_paid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_paid.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_paid_Leave(sender As Object, e As EventArgs) Handles txt_paid.Leave
        If (txt_paid.Text.Trim = "") Or (CInt(txt_paid.Text.Trim) < 0) Or (CInt(txt_paid.Text.Trim) > CInt(txt_receive.Text.Trim)) Then
            txt_paid.Text = txt_receive.Text
        End If
        txt_paid.Text = Format(CDbl(txt_paid.Text), "N0")
        txt_remain.Text = Format(CDbl(txt_receive.Text) - CDbl(txt_paid.Text), "N0")
    End Sub

    Private Sub txt_std_code_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_std_code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SearchingStudent()
        End If
    End Sub

    Dim old_learning_id As Integer = 0
    Private Sub SearchingStudent()
        Sql = " SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,date_of_birth ,"
        Sql &= " birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,phone_number ,wa_number ,job_des ,"
        Sql &= " hight_school_name ,hight_school_graduate_year ,parent_name ,parent_contact ,course_id ,current_term_id ,"
        Sql &= " class_id ,start_year ,end_year ,create_date ,student_status ,last_update ,user_update, "
        Sql &= " (SELECT scheme_des_la+' ('+course_des_la+')' FROM view_course_list WHERE(course_id=tbl_student.course_id)) AS course_des_la, "
        Sql &= " (SELECT TOP(1) learning_shift_id FROM tbl_term_register WHERE(student_id=tbl_student.student_id) ORDER BY term_register_id DESC) AS learning_shift_id "
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
            select_student_from = 1
            reg_search_where = txt_std_code.Text.Trim
            If FrmStudentRegister_Select.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txt_std_code.Text = FrmStudentRegister_Select.get_std_code
                txt_std_code.Tag = FrmStudentRegister_Select.get_student_id
                lb_title.Text = "ຊື່ນັກສຶກສາ(" & FrmStudentRegister_Select.get_sex & ")"
                txt_name.Text = FrmStudentRegister_Select.get_student_name_la
                txt_name_en.Text = FrmStudentRegister_Select.get_student_name_en
                DateTimePicker1.Text = FrmStudentRegister_Select.get_birth_date
                txt_course.Tag = FrmStudentRegister_Select.get_course_id
                txt_course.Text = FrmStudentRegister_Select.get_full_course
                txt_phone.Text = FrmStudentRegister_Select.get_telephone
                txt_comment.Text = "--"
                Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)

                Call getLearningShiftList(txt_course.Tag)
                cb_learning_time.SelectedValue = FrmStudentRegister_Select.get_lnsh_id
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
                txt_name_en.Text = .Item("student_fullname_en")
                txt_phone.Text = .Item("phone_number")
                DateTimePicker1.Text = .Item("date_of_birth")
                txt_course.Tag = .Item("course_id")
                txt_course.Text = .Item("course_des_la")
                txt_comment.Text = "--"
                old_learning_id = .Item("learning_shift_id")


                If (txt_course.Text <> "") Then
                    Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)
                End If

                Call getLearningShiftList(txt_course.Tag)
                cb_learning_time.SelectedValue = old_learning_id
            End With
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Call SearchingStudent()
    End Sub

End Class