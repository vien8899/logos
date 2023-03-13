Imports System.Data.SqlClient

Public Class FrmStudentEnroll_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentEnroll_view.LoadData()
        End If
    End Sub

    Dim load_finish As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finish = 1
        Call load_data()
        load_finish = 0
    End Sub

    Dim std_enroll_id As Integer = 0
    Private Sub load_data()
        Sql = "SELECT enroll_id ,std_enroll_id ,enroll_date ,course_id ,learning_shift_id ,enroll_amount ,"
        Sql &= " enroll_discount ,enroll_comment, test_date ,year_register ,last_update ,user_update ,learning_shift_des ,"
        Sql &= " course_id, course_des_la ,course_des_en ,course_test_amount ,scheme_id ,scheme_des_la ,scheme_des_en ,"
        Sql &= " std_enroll_fullname_la ,std_enroll_fullname_en ,std_enroll_gender ,date_of_birth ,birth_address ,"
        Sql &= " location_address ,phone_number ,wa_number ,parent_contact, enroll_inv_id, std_enroll_id, payment_type "
        Sql &= " FROM view_std_enroll "
        Sql &= " WHERE(enroll_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            BILL_ID = .Item("enroll_inv_id")
            std_enroll_id = CInt(.Item("std_enroll_id"))
            cb_sex.SelectedIndex = CInt(.Item("std_enroll_gender")) - 1
            txt_name.Text = .Item("std_enroll_fullname_la")
            txt_phone.Text = .Item("phone_number")
            txt_phone_parent.Text = .Item("parent_contact")
            txt_amt_regis.Text = Format(CDbl(.Item("enroll_amount")), "N0")
            txt_comment.Text = .Item("enroll_comment")

            'Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
            'calendar_test.MinDate = CDate(cur_date)
            calendar_test.SetSelectionRange(CDate(.Item("test_date")), CDate(.Item("test_date")))
            lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
            Dim learning_shift_id As Integer = .Item("learning_shift_id")
            txt_course.Tag = .Item("course_id")
            txt_course.Text = .Item("scheme_des_la") & "(" & .Item("course_des_la") & ")"
            If CInt(.Item("course_id")) = 1 Then
                rdo_cash.Checked = True
            Else
                rdo_BT.Checked = True
            End If

            Call getLearningShiftList(txt_course.Tag)
            cb_learning_time.SelectedValue = learning_shift_id
            Call CollectDetail()

            txt_name.Select()
        End With
    End Sub

    Private Sub getLearningShiftList(ByVal c As Integer)
        Sql = "SELECT learning_shift_des, learning_shift_id "
        Sql &= " FROM tbl_setting_learning_shift WHERE(learning_shift_status <> 0) AND (course_id=" & c & ") "
        Sql &= " ORDER BY course_id, learning_shift_id "
        dt = ExecuteDatable(Sql)
        cb_learning_time.DataSource = dt
        cb_learning_time.ValueMember = "learning_shift_id"
        cb_learning_time.DisplayMember = "learning_shift_des"
    End Sub

    Public Sub SetTestDate()
        calendar_test.SetSelectionRange(CDate(My.Settings.default_test_date), CDate(My.Settings.default_test_date))
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub add_new_user()
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
        If (cb_learning_time.Items.Count = 0) Then
            MessageBox.Show("Date/Time learning shift is require.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_learning_time.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim sex As Integer = cb_sex.SelectedIndex + 1


        Call ConnectDB()
        Sql = "UPDATE tbl_std_enroll SET std_enroll_fullname_la=@std_enroll_fullname_la ,std_enroll_fullname_en=@std_enroll_fullname_en ,"
        Sql &= " std_enroll_gender=@std_enroll_gender ,phone_number=@phone_number ,parent_contact=@parent_contact ,user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(std_enroll_id=@std_enroll_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("std_enroll_id", std_enroll_id)
        cm.Parameters.AddWithValue("std_enroll_fullname_la", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("std_enroll_fullname_en", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("std_enroll_gender", sex)
        cm.Parameters.AddWithValue("phone_number", CStr(txt_phone.Text.Trim))
        cm.Parameters.AddWithValue("parent_contact", CStr(txt_phone_parent.Text.Trim))
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        'Insert Enroll
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If
        Dim payment_type As Integer = 1
        If (rdo_BT.Checked = True) Then
            payment_type = 2
        End If

        Dim test_date As String = Format(CDate(lb_test_date.Text), "yyyy-MM-dd")
        Sql = "UPDATE tbl_std_enroll_test SET course_id=@course_id ,learning_shift_id=@lerning_shift_id ,enroll_amount=@enroll_amount ,"
        Sql &= " enroll_comment=@enroll_comment ,test_date=@test_date ,payment_type=@payment_type, user_update=@user_update ,last_update=getdate() "
        Sql &= " WHERE(enroll_id=@enroll_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("enroll_id", id_edit)
        cm.Parameters.AddWithValue("course_id", txt_course.Tag)
        cm.Parameters.AddWithValue("lerning_shift_id", cb_learning_time.SelectedValue)
        cm.Parameters.AddWithValue("enroll_amount", CDbl(txt_amt_regis.Text.Trim))
        cm.Parameters.AddWithValue("enroll_comment", cmt)
        cm.Parameters.AddWithValue("test_date", test_date)
        cm.Parameters.AddWithValue("payment_type", payment_type)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        had_change_val = 1
        Me.Close()
        If (needprint = 1) Then
            rpt_status = 1
            Rpt_OnlyView = 1
            FrmReport_A5.ShowDialog()
        End If

        Cursor = Cursors.Default
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

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        If FrmSearch_Course.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_amt_regis.Text = Format(CDbl(FrmSearch_Course.course_test_amt), "N0")
            txt_course.Tag = FrmSearch_Course.course_id
            txt_course.Text = FrmSearch_Course.full_course
        End If
    End Sub

    Private Sub txt_course_TextChanged(sender As Object, e As EventArgs) Handles txt_course.TextChanged
        If (txt_course.Text <> "") And (load_finish = 0) Then
            Call getLearningShiftList(txt_course.Tag)
            Call CollectDetail()
        End If
    End Sub

    Private Sub CollectDetail()
        If (txt_course.Text <> "") Then
            Dim concat_str As String = "1. ສາຍຮຽນ: " & txt_course.Text & vbNewLine
            concat_str &= "2. ຄ່າລົງທະບຽນເສັງທຽບ: " & txt_amt_regis.Text & " ກີບ" & vbNewLine
            concat_str &= "3. ເລືອກວັນເວລາຮຽນ: " & cb_learning_time.Text & vbNewLine
            concat_str &= "4. ວັນທີ່ເສັງທຽບ: " & lb_test_date.Text
            txt_detail.Text = concat_str
        Else
            txt_detail.Text = ""
        End If
    End Sub

    Private Sub calendar_test_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar_test.DateChanged
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
        Call CollectDetail()
    End Sub

    'Private Sub lb_test_date_Click(sender As Object, e As EventArgs) Handles lb_test_date.Click
    '    FrmStudentEnroll_SetDate.ShowDialog()
    'End Sub

End Class