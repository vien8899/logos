Imports System.Data.SqlClient

Public Class FrmStudentRegister_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentEnroll_view.LoadData()
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

    Dim load_finish As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finish = 1
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        cur_year = Format(CDate(cur_date), "yyyy")

        Call getSexList()
        Call load_data()
        load_finish = 0
    End Sub

    Dim student_id As Integer = 0
    Dim std_reg_oldcode As String = ""
    Dim old_dis As Double = 0
    Dim cur_year As Integer = 0

    Dim old_sokhien As String = ""
    Private Sub load_data()
        Sql = "SELECT term_register_id ,bill_id ,student_id ,term_id ,class_id ,register_amount ,register_discount ,register_year ,"
        Sql &= " register_date ,last_update ,user_update ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,"
        Sql &= " date_of_birth ,birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,phone_number ,wa_number ,"
        Sql &= " job_des ,hight_school_name ,hight_school_graduate_year ,parent_name ,parent_contact ,start_year ,end_year ,student_status ,"
        Sql &= " term_no ,term_des ,term_register_amt ,course_id ,course_des_la ,course_des_en ,course_test_amount ,scheme_id ,"
        Sql &= " scheme_des_la ,scheme_des_en ,class_room, sum_term_paid ,start_learn_date ,register_comment "
        Sql &= " FROM view_std_register"
        Sql &= " WHERE(term_register_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            BILL_ID = .Item("bill_id")
            student_id = CInt(.Item("student_id"))
            std_reg_oldcode = CStr(.Item("student_code"))
            txt_std_code.Text = std_reg_oldcode
            cb_sex.SelectedValue = CInt(.Item("student_gender"))
            txt_name.Text = .Item("student_fullname_la")
            txt_name_en.Text = .Item("student_fullname_en")
            DateTimePicker1.Text = .Item("date_of_birth")
            txt_phone.Text = .Item("phone_number")
            old_sokhien = .Item("register_year")
            txt_term.Text = .Item("term_no")
            txt_total.Text = Format(CDbl(.Item("register_amount")), "N0")
            txt_discount.Text = Format(CDbl(.Item("register_discount")), "N0")
            txt_receive.Text = Format(CDbl(txt_total.Text) - CDbl(txt_discount.Text), "N0")
            txt_paid.Text = Format(CDbl(.Item("sum_term_paid")), "N0")

            'If have payment cannot edit discount
            If (CDbl(.Item("sum_term_paid")) > 0) Then
                txt_discount.ReadOnly = True
            Else
                txt_discount.ReadOnly = False
            End If

            txt_remain.Text = Format(CDbl(txt_receive.Text) - CDbl(txt_paid.Text), "N0")
            txt_comment.Text = .Item("register_comment")
            old_dis = CDbl(txt_discount.Text)

            calendar_test.SetSelectionRange(CDate(.Item("start_learn_date")), CDate(.Item("start_learn_date")))
            lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
            txt_course.Tag = .Item("course_id")
            txt_course.Text = .Item("scheme_des_la") & "(" & .Item("course_des_la") & ")"

            'Add Sok Hien List
            cb_sokhien.Items.Clear()
            If (CInt(Mid(old_sokhien, 1, 4)) < cur_year) Then
                Dim diff As Integer = cur_year - CInt(Mid(old_sokhien, 1, 4))
                For i As Integer = 0 To diff
                    cb_sokhien.Items.Add(CInt(Mid(old_sokhien, 1, 4)) + i & "-" & CInt(Mid(old_sokhien, 1, 4)) + i + 1)
                Next
            Else
                cb_sokhien.Items.Add(old_sokhien)
            End If
            cb_sokhien.SelectedIndex = 0
            txt_name.Select()
        End With
    End Sub

    Public Sub SetTestDate()
        calendar_test.SetSelectionRange(CDate(My.Settings.default_test_date), CDate(My.Settings.default_test_date))
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

        'check for Student-ID
        Sql = "SELECT student_code FROM tbl_student WHERE(student_code=N'" & txt_std_code.Text.Trim & "')"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 0) And (std_reg_oldcode <> txt_std_code.Text.Trim) Then
            MessageBox.Show("ລະຫັດນັກສຶກສາທີ່ທ່ານປ້ອນຊໍ້າກັນ ກັບລະຫັດນັກສຶກສາທີ່ມີຢູ່ແລ້ວ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If

        Dim sex As Integer = cb_sex.SelectedValue
        Call ConnectDB()
        Sql = "UPDATE tbl_student SET student_code=@student_code ,student_fullname_la=@student_fullname_la ,student_fullname_en=@student_fullname_en ,"
        Sql &= " student_gender=@student_gender ,date_of_birth=@date_of_birth ,phone_number=@phone_number, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(student_id=@student_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("student_id", student_id)
        cm.Parameters.AddWithValue("student_code", txt_std_code.Text.Trim)
        cm.Parameters.AddWithValue("student_fullname_la", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("student_fullname_en", txt_name_en.Text.Trim)
        cm.Parameters.AddWithValue("student_gender", sex)
        cm.Parameters.AddWithValue("date_of_birth", CDate(DateTimePicker1.Text))
        cm.Parameters.AddWithValue("phone_number", CStr(txt_phone.Text.Trim))
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        'Insert Enroll
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If
        Dim learn_date As String = Format(CDate(lb_test_date.Text), "yyyy-MM-dd")
        Sql = "UPDATE tbl_term_register SET register_amount=@register_amount ,register_discount=@register_discount ,register_year=@register_year ,"
        Sql &= " start_learn_date=@start_learn_date ,register_comment=@register_comment, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(bill_id=@bill_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("bill_id", BILL_ID)
        cm.Parameters.AddWithValue("register_amount", CDbl(txt_total.Text))
        cm.Parameters.AddWithValue("register_discount", CDbl(txt_discount.Text))
        cm.Parameters.AddWithValue("register_year", cb_sokhien.SelectedItem)
        cm.Parameters.AddWithValue("start_learn_date", learn_date)
        cm.Parameters.AddWithValue("register_comment", cmt)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        had_change_val = 1
        reg_number_of_term_where = " WHERE(bill_id = '" & BILL_ID & "')"
        Me.Close()
        If (needprint = 1) Then
            Cursor = Cursors.WaitCursor
            rpt_status = 2
            Rpt_OnlyView = 1
            FrmReport_A5.ShowDialog()
            Cursor = Cursors.Default
        End If
    End Sub

    Dim needprint As Integer = 0
    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save_print.Click
        needprint = 1
        Call add_new_user()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        needprint = 0
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub


    Private Sub calendar_test_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar_test.DateChanged
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub txt_discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_discount.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_discount_Leave(sender As Object, e As EventArgs) Handles txt_discount.Leave
        If (txt_discount.Text.Trim = "") Then
            txt_discount.Text = old_dis
        End If
        If CInt(txt_discount.Text) > CInt(txt_total.Text) Then
            MessageBox.Show("Discount must be less than or equal to total term cost", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_discount.Text = txt_total.Text
        End If
        txt_discount.Text = Format(CDbl(txt_discount.Text), "N0")
        txt_receive.Text = Format(CDbl(txt_total.Text) - CDbl(txt_discount.Text), "N0")
        txt_remain.Text = Format(CDbl(txt_receive.Text) - CDbl(txt_paid.Text), "N0")
    End Sub

End Class