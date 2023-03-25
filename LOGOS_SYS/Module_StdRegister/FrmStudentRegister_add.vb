Imports System.Data.SqlClient

Public Class FrmStudentRegister_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentRegister_view.LoadData()
        End If
    End Sub

    Private Sub getSexList()
        Sql = "SELECT title_id, title_la, title_en "
        Sql &= " FROM tbl_student_title "
        Sql &= " ORDER BY title_id"
        dt = ExecuteDatable(Sql)
        cb_sex.DataSource = dt
        cb_sex.ValueMember = "title_id"
        cb_sex.DisplayMember = "title_la"
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_finished = 1
        had_change_val = 0
        Call clear_text()
        Call getSexList()
        Call LockedRDO()
        load_finished = 0
    End Sub

    Dim load_finished As Integer = 1
    Dim start_year As Integer = 0
    Private Sub clear_text()
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        cb_sex.SelectedIndex = 0
        txt_std_code.Text = ""
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
        Datagridview1.Rows.Clear()

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
            MessageBox.Show("Please enter student ID.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If
        'If (cb_sex.SelectedIndex = 0) Then
        '    MessageBox.Show("Please select gender.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cb_sex.Focus()
        '    Exit Sub
        'End If
        If (txt_name.Text.Trim = "") Then
            MessageBox.Show("Please enter name (la).", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_name.Focus()
            Exit Sub
        End If
        If (txt_phone.Text.Trim = "") Then
            MessageBox.Show("Please enter phone number.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_phone.Focus()
            Exit Sub
        End If
        If (txt_course.Text.Trim = "") Then
            MessageBox.Show("Please select course.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_Search.Focus()
            Exit Sub
        End If
        If (rdo_BT.Checked = False) And (rdo_cash.Checked = False) Then
            MessageBox.Show("Please select payment type.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_cash.Focus()
            Exit Sub
        End If

        Dim start_year As Integer = CInt(Mid(Datagridview1.Rows(0).Cells(5).Value, 1, 4))
        Dim end_year As Integer = start_year
        If (Datagridview1.RowCount > 1) Then
            end_year = CInt(Mid(Datagridview1.Rows(Datagridview1.Rows.Count - 1).Cells(5).Value, 6, 4))
        End If
        Dim sex As Integer = cb_sex.SelectedValue

        'check for Student-ID
        Sql = "SELECT student_code FROM tbl_student WHERE(student_code=N'" & txt_std_code.Text.Trim & "')"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("ລະຫັດນັກສຶກສາທີ່ທ່ານປ້ອນຊໍ້າກັນ ກັບລະຫັດນັກສຶກສາທີ່ມີຢູ່ແລ້ວ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If

        'For New Studen
        Cursor = Cursors.WaitCursor
        Call ConnectDB()
        Sql = "INSERT INTO tbl_student(student_code ,student_fullname_la ,student_fullname_en ,student_gender ,date_of_birth ,phone_number, "
        Sql &= "                       course_id ,current_term_id ,start_year ,end_year ,student_status ,user_update) "
        Sql &= " VALUES(@student_code ,@student_fullname_la ,@student_fullname_en ,@student_gender ,@date_of_birth ,@phone_number, "
        Sql &= "        @course_id ,@current_term_id ,@start_year ,@end_year ,@student_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("student_code", txt_std_code.Text.Trim)
        cm.Parameters.AddWithValue("student_fullname_la", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("student_fullname_en", txt_name_en.Text.Trim)
        cm.Parameters.AddWithValue("student_gender", sex)
        cm.Parameters.AddWithValue("date_of_birth", CDate(DateTimePicker1.Text))
        cm.Parameters.AddWithValue("phone_number", CStr(txt_phone.Text.Trim))
        cm.Parameters.AddWithValue("course_id", txt_course.Tag)
        cm.Parameters.AddWithValue("current_term_id", CInt(Datagridview1.Rows(0).Cells(0).Value))
        cm.Parameters.AddWithValue("start_year", start_year)
        cm.Parameters.AddWithValue("end_year", end_year)
        cm.Parameters.AddWithValue("student_status", 1)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        'Get Max-ID
        Sql = "SELECT MAX(student_id) AS max_std_id FROM tbl_student "
        dt = ExecuteDatable(Sql)
        Dim std_register_id As Integer = CInt(dt.Rows(0).Item("max_std_id"))

        'Insert Enroll
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
        For i As Integer = 0 To Datagridview1.Rows.Count - 1
            If (Datagridview1.Rows(i).Cells(1).Value) = True Then
                BILL_ID = Max_Bill_id("INV-", "tbl_term_register", "bill_id")
                If (min_bill = "") Then
                    min_bill = BILL_ID
                End If
                max_bill = BILL_ID

                Dim learn_date As String = Format(CDate(lb_test_date.Text), "yyyy-MM-dd")
                Sql = "INSERT INTO tbl_term_register(bill_id ,student_id ,term_id ,register_amount ,register_discount ,register_year ,start_learn_date ,register_comment, user_update) "
                Sql &= " VALUES(@bill_id ,@student_id ,@term_id ,@register_amount ,@register_discount ,@register_year ,@start_learn_date ,@register_comment, @user_update)"
                cm = New SqlCommand(Sql, conn)
                cm.Parameters.AddWithValue("bill_id", BILL_ID)
                cm.Parameters.AddWithValue("student_id", std_register_id)
                cm.Parameters.AddWithValue("term_id", Datagridview1.Rows(i).Cells(0).Value)
                cm.Parameters.AddWithValue("register_amount", CDbl(Datagridview1.Rows(i).Cells(3).Value))
                cm.Parameters.AddWithValue("register_discount", CDbl(Datagridview1.Rows(i).Cells(4).Value))
                cm.Parameters.AddWithValue("register_year", CStr(Datagridview1.Rows(i).Cells(5).Value))
                cm.Parameters.AddWithValue("start_learn_date", learn_date)
                cm.Parameters.AddWithValue("register_comment", cmt)
                cm.Parameters.AddWithValue("user_update", User_name)
                cm.ExecuteNonQuery()

                Sql = "INSERT INTO tbl_term_payment(bill_id ,paid_amount ,payment_type ,receive_by ,receive_id) "
                Sql &= " VALUES(@bill_id ,@paid_amount ,@payment_type ,@receive_by ,@receive_id)"
                cm = New SqlCommand(Sql, conn)
                cm.Parameters.AddWithValue("bill_id", BILL_ID)
                cm.Parameters.AddWithValue("paid_amount", (CDbl(Datagridview1.Rows(i).Cells(3).Value) - CDbl(Datagridview1.Rows(i).Cells(4).Value)))
                cm.Parameters.AddWithValue("payment_type", payment_type)
                cm.Parameters.AddWithValue("receive_by", User_name)
                cm.Parameters.AddWithValue("receive_id", User_ID)
                cm.ExecuteNonQuery()
            End If
        Next

        'If Student from enrool
        If (txt_name.Tag <> "") Then
            Sql = "UPDATE tbl_std_enroll_test SET reg_first_term_st=1 WHERE(enroll_id=" & CInt(txt_name.Tag) & " ) "
            Call ExecuteUpdate(Sql)
            conn.Close()
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

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        If FrmSearch_Course.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_course.Tag = FrmSearch_Course.course_id
            txt_course.Text = FrmSearch_Course.full_course
            txt_scheme_id.Text = FrmSearch_Course.scheme_id
        End If
    End Sub

    Private Sub LockedRDO()
        For i As Integer = 1 To 7
            For Each btn As Control In Me.Panel_Reg.Controls
                If TypeOf btn Is RadioButton And btn.Name = "rdo" & i Then
                    CType(btn, RadioButton).Checked = False
                    CType(btn, RadioButton).Enabled = False
                End If
            Next
        Next
    End Sub
    Private Sub getTermListInCourse(ByVal c As Integer)
        Sql = "SELECT term_id ,term_no ,term_des ,register_amount ,course_id ,term_status, term_study_year "
        Sql &= " FROM view_term_table WHERE(term_status <> 0) AND (course_id=" & c & ") "
        Sql &= " ORDER BY term_list_id "
        dt = ExecuteDatable(Sql)
        Datagridview1.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            With Datagridview1
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim money_dis As Double = 0
                    Dim first As Boolean = True
                    If (i > 0) Then
                        first = False
                    End If

                    .Rows.Add(dt.Rows(i).Item("term_id"), first, (dt.Rows(i).Item("term_no") & "-[" & dt.Rows(i).Item("term_des") & "]"), _
                              dt.Rows(i).Item("register_amount"), CInt(money_dis), (start_year - 1 + CInt(dt.Rows(i).Item("term_study_year"))) & "-" & (start_year + CInt(dt.Rows(i).Item("term_study_year"))))
                Next

            End With

            Dim max_enable As Integer = 6
            If (Datagridview1.Rows.Count < 6) Then
                max_enable = Datagridview1.Rows.Count
            End If
            For i As Integer = 2 To max_enable
                For Each btn As Control In Me.Panel_Reg.Controls
                    If TypeOf btn Is RadioButton And btn.Name = "rdo" & i Then
                        CType(btn, RadioButton).Enabled = True
                    End If
                Next
            Next

            rdo1.Enabled = True
            rdo1.Checked = True
            rdo7.Enabled = True
            btn_save.Enabled = True
        Else
            btn_save.Enabled = False
            Call LockedRDO()
        End If
    End Sub

    Private Sub txt_course_TextChanged(sender As Object, e As EventArgs) Handles txt_course.TextChanged
        If (txt_course.Text <> "") Then
            Call getTermListInCourse(txt_course.Tag)
            Call EnableDisbleTerm()
        End If
    End Sub

    Private Sub calendar_test_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar_test.DateChanged
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub lb_test_date_Click(sender As Object, e As EventArgs) Handles lb_test_date.Click
        FrmStudentReg_SetDate.ShowDialog()
    End Sub

    Private Sub btn_search_enroll_Click(sender As Object, e As EventArgs) Handles btn_search_enroll.Click
        If FrmSearch_StdFromEnroll.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_course.Tag = FrmSearch_StdFromEnroll.course_id
            txt_course.Text = FrmSearch_StdFromEnroll.full_course
            txt_name.Tag = FrmSearch_StdFromEnroll.enroll_id
            txt_name.Text = FrmSearch_StdFromEnroll.student_fname
            cb_sex.SelectedIndex = FrmSearch_StdFromEnroll.std_enroll_gender
            'cb_sokhien.SelectedItem = CStr(FrmSearch_StdFromEnroll.std_enroll_gender)
            txt_scheme_id.Text = FrmSearch_StdFromEnroll.scheme_id
            'cb_learning_time.SelectedValue = CInt(FrmSearch_StdFromEnroll.learning_shift_id)
        End If
    End Sub

    Private Sub EnableDisbleTerm()
        Dim sum As Double = 0
        Dim dis As Double = 0
        Dim count_check As Integer = 0
        With Datagridview1

            For x As Integer = 0 To .RowCount - 1
                .Rows(x).Cells(4).ReadOnly = True
                .Rows(x).Cells(4).Value = Format(CDbl(.Rows(x).Cells(4).Value), "N0")
                If (.Rows(x).Cells(1).Value) = True Then
                    count_check += 1
                    sum += CDbl(.Rows(x).Cells(3).Value)
                    dis += CDbl(.Rows(x).Cells(4).Value)
                    .Rows(x).Cells(4).ReadOnly = False
                End If
            Next

            txt_total.Text = Format(sum, "N0")
            txt_discount.Text = Format(CDbl(dis), "N0")
            txt_receive.Text = Format(CDbl(txt_total.Text) - CDbl(txt_discount.Text), "N0")

        End With
    End Sub

    Private Sub ResetChecked(ByVal bl As Boolean, ByVal tomax As Integer)
        With Datagridview1
            If (.Rows.Count > 0) Then
                For x As Integer = 0 To tomax
                    .Rows(x).Cells(1).Value = bl
                Next
            End If
        End With
    End Sub
    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged, rdo3.CheckedChanged, rdo4.CheckedChanged, rdo5.CheckedChanged, rdo6.CheckedChanged, rdo7.CheckedChanged
        Dim btn As RadioButton = CType(sender, RadioButton)
        Dim btn_number As Integer = CInt(Mid(btn.Name, 4, 1))
        'MsgBox(btn_number)

        Call ResetChecked(False, Datagridview1.Rows.Count - 1)
        If (btn.Enabled = True) Then
            If (btn_number = 7) Then
                Call ResetChecked(True, Datagridview1.Rows.Count - 1)
            Else
                Call ResetChecked(True, btn_number - 1)
            End If
        End If
        Call EnableDisbleTerm()
    End Sub

    Private Sub Datagridview1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellEndEdit
        If e.ColumnIndex = 4 Then
            Call EnableDisbleTerm()
        End If
    End Sub

End Class