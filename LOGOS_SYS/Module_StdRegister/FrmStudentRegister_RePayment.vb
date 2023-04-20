Imports System.Data.SqlClient

Public Class FrmStudentRegister_RePayment

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
    Dim cur_year As Integer = 0

    Dim old_sokhien As String = ""
    Dim old_learning_id As Integer = 0
    Private Sub load_data()
        Sql = "SELECT term_register_id ,bill_id ,student_id ,term_id ,class_id ,register_amount ,register_discount ,register_year ,"
        Sql &= " register_date ,last_update ,user_update ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,"
        Sql &= " date_of_birth ,birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,phone_number ,wa_number ,"
        Sql &= " job_des ,hight_school_name ,hight_school_graduate_year ,parent_name ,parent_contact ,start_year ,end_year ,student_status ,"
        Sql &= " term_no ,term_des ,term_register_amt ,course_id ,course_des_la ,course_des_en ,course_test_amount ,scheme_id ,"
        Sql &= " scheme_des_la ,scheme_des_en ,class_room, sum_term_paid ,start_learn_date ,register_comment, learning_shift_id "
        Sql &= " FROM view_std_register"
        Sql &= " WHERE(term_register_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            BILL_ID = .Item("bill_id")
            student_id = CInt(.Item("student_id"))
            txt_std_code.Text = CStr(.Item("student_code"))
            lb_title.Text = "ນັກສຶກສາ(ນາງ)"
            If (CInt(.Item("student_gender")) = 1) Then
                lb_title.Text = "ນັກສຶກສາ(ທ້າວ)"
            End If
            txt_name.Text = .Item("student_fullname_la")
            txt_name_en.Text = .Item("student_fullname_en")
            DateTimePicker1.Text = .Item("date_of_birth")
            txt_phone.Text = .Item("phone_number")
            cb_sokhien.Text = .Item("register_year")
            txt_term.Text = .Item("term_no")
            txt_total.Text = Format(CDbl(.Item("register_amount")), "N0")
            txt_discount.Text = Format(CDbl(.Item("register_discount")), "N0")
            txt_receive.Text = Format(CDbl(txt_total.Text) - CDbl(txt_discount.Text), "N0")
            txt_paid.Text = Format(CDbl(.Item("sum_term_paid")), "N0")
            txt_remain.Text = Format(CDbl(txt_receive.Text) - CDbl(txt_paid.Text), "N0")
            txt_payment2.Text = Format(CDbl(txt_remain.Text.Trim), "N0")
            txt_remain2.Text = "0"
            txt_comment.Text = "--"
            txt_course.Tag = .Item("course_id")
            txt_course.Text = .Item("scheme_des_la") & "(" & .Item("course_des_la") & ")"
            old_learning_id = .Item("learning_shift_id")

            calendar_test.SetSelectionRange(CDate(getCurrentDate()), CDate(getCurrentDate()))
            lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")


            Call getLearningShiftList(txt_course.Tag)
            cb_learning_time.SelectedValue = old_learning_id


            txt_payment2.Select()
        End With
    End Sub

    Private Sub add_new_user()
        If (CInt(txt_payment2.Text.Trim) <= 0) Then
            MessageBox.Show("ຈຳນວນເງິນທີ່ຊຳລະຕ້ອງ ຫຼາຍກວ່າ 0.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_payment2.Focus()
            Exit Sub
        End If
        If (rdo_BT.Checked = False) And (rdo_cash.Checked = False) Then
            MessageBox.Show("ກະລຸນາເລືອກຮູບແບບຮັບເງິນ (ເງິນສົດ/ເງິນໂອນ).", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_cash.Focus()
            Exit Sub
        End If

        'Insert Payment
        Dim payment_des As String = "ຈ່າຍເງິນຊຳລະໜີ້-ລົງທະບຽນ"
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If

        'Payment
        Dim payment_type As Integer = 1
        If (rdo_BT.Checked = True) Then
            payment_type = 2
        End If

        Call ConnectDB()
        Dim payment_date As String = Format(CDate(lb_test_date.Text), "yyyy-MM-dd")
        Sql = "INSERT INTO tbl_term_payment(bill_id ,paid_amount ,payment_type ,payment_des ,payment_remark ,receive_by ,receive_id) "
        Sql &= " VALUES(@bill_id ,@paid_amount ,@payment_type, @payment_des ,@payment_remark ,@receive_by ,@receive_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("bill_id", BILL_ID)
        cm.Parameters.AddWithValue("paid_amount", CDbl(txt_payment2.Text.Trim))
        cm.Parameters.AddWithValue("payment_type", payment_type)
        cm.Parameters.AddWithValue("payment_des", payment_des)
        cm.Parameters.AddWithValue("payment_remark", cmt)
        cm.Parameters.AddWithValue("receive_by", User_name)
        cm.Parameters.AddWithValue("receive_id", User_ID)
        cm.ExecuteNonQuery()

        'TimeLearning
        Sql = "UPDATE tbl_term_payment SET learning_shift_id=" & CInt(cb_learning_time.SelectedValue) & " "
        Sql &= " WHERE(term_register_id=" & id_edit & ")"
        cm = New SqlCommand(Sql, conn)
        cm.ExecuteNonQuery()

        'StudentLog
        Dim action_detail As String = "ຊຳລະຄ່າເທີມຕິດໜີ້ (" & txt_term.Text & ") ຈຳນວນ: " & txt_payment2.Text
        Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
        conn.Close()

        had_change_val = 1
        reg_number_of_term_where = " WHERE(bill_id = '" & BILL_ID & "')"
        Me.Close()
        If (needprint = 1) Then
            Cursor = Cursors.WaitCursor
            rpt_status = 2
            Rpt_OnlyView = 0
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

    Private Sub txt_payment2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_payment2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_payment2_Leave(sender As Object, e As EventArgs) Handles txt_payment2.Leave
        If (txt_payment2.Text.Trim = "") Then
            txt_payment2.Text = txt_receive.Text
        End If
        If (CInt(txt_payment2.Text) > CInt(txt_receive.Text)) Or (CInt(txt_payment2.Text) <= 0) Then
            MessageBox.Show("ຈຳນວນເງິນຊຳລະຕ້ອງຢູ່ໃນລະຫວ່າງເງິນທີ່ຍັງຕິດໜີ້", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_payment2.Text = txt_receive.Text
        End If
        txt_payment2.Text = Format(CDbl(txt_payment2.Text), "N0")
        txt_remain2.Text = Format(CDbl(txt_remain.Text) - CDbl(txt_payment2.Text), "N0")
    End Sub


End Class