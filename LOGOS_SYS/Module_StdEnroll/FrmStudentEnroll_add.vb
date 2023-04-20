Imports System.Data.SqlClient

Public Class FrmStudentEnroll_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentEnroll_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call clear_text()
        Call getSexList()
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

    Private Sub getSexList()
        Sql = "SELECT title_id, title_la, title_en "
        Sql &= " FROM tbl_student_title "
        Sql &= " ORDER BY title_id"
        dt = ExecuteDatable(Sql)
        cb_sex.DataSource = dt
        cb_sex.ValueMember = "title_id"
        cb_sex.DisplayMember = "title_la"
    End Sub

    Private Sub clear_text()
        cb_sex.SelectedIndex = 0
        txt_name.Text = ""
        txt_phone.Text = ""
        txt_phone_parent.Text = ""
        txt_detail.Text = ""
        txt_course.Tag = ""
        txt_course.Text = ""
        txt_amt_regis.Text = ""
        txt_comment.Text = ""

        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        Dim test_date As String = Format(CDate(My.Settings.default_test_date), "yyyy-MM-dd")
        If (test_date < cur_date) Then
            My.Settings.default_test_date = cur_date
            My.Settings.Save()
        End If

        calendar_test.MinDate = CDate(cur_date)
        Call SetTestDate()
        cb_sex.Select()
    End Sub

    Public Sub SetTestDate()
        calendar_test.SetSelectionRange(CDate(My.Settings.default_test_date), CDate(My.Settings.default_test_date))
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub add_new_user()
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
        If (cb_learning_time.Items.Count = 0) Then
            MessageBox.Show("Date/Time learning shift is require.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_learning_time.Focus()
            Exit Sub
        End If
        If (rdo_BT.Checked = False) And (rdo_cash.Checked = False) Then
            MessageBox.Show("Please select payment type.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_cash.Focus()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Dim sex As Integer = cb_sex.SelectedValue
        Call ConnectDB()
        Sql = "INSERT INTO tbl_std_enroll(std_enroll_fullname_la ,std_enroll_fullname_en ,std_enroll_gender ,phone_number ,parent_contact ,std_enroll_status ,user_update) "
        Sql &= " VALUES(@std_enroll_fullname_la ,@std_enroll_fullname_en ,@std_enroll_gender ,@phone_number ,@parent_contact ,@std_enroll_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("std_enroll_fullname_la", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("std_enroll_fullname_en", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("std_enroll_gender", sex)
        cm.Parameters.AddWithValue("phone_number", CStr(txt_phone.Text.Trim))
        cm.Parameters.AddWithValue("parent_contact", CStr(txt_phone_parent.Text.Trim))
        cm.Parameters.AddWithValue("std_enroll_status", 1)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        'Get Max-ID
        Sql = "SELECT MAX(std_enroll_id) AS max_std_id FROM tbl_std_enroll "
        dt = ExecuteDatable(Sql)
        Dim std_enroll_id As Integer = CInt(dt.Rows(0).Item("max_std_id"))
        BILL_ID = Max_Bill_id("ENR-", "tbl_std_enroll_test", "enroll_inv_id")

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
        Sql = "INSERT INTO tbl_std_enroll_test(std_enroll_id ,enroll_inv_id ,course_id ,learning_shift_id ,enroll_amount ,enroll_discount ,enroll_comment ,test_date ,payment_type, user_update, user_id, user_receive) "
        Sql &= " VALUES(@std_enroll_id ,@enroll_inv_id ,@course_id ,@lerning_shift_id ,@enroll_amount ,@enroll_discount ,@enroll_comment ,@test_date ,@payment_type, @user_update, @user_id, @user_receive)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("std_enroll_id", std_enroll_id)
        cm.Parameters.AddWithValue("enroll_inv_id", BILL_ID)
        cm.Parameters.AddWithValue("course_id", txt_course.Tag)
        cm.Parameters.AddWithValue("lerning_shift_id", cb_learning_time.SelectedValue)
        cm.Parameters.AddWithValue("enroll_amount", CDbl(txt_amt_regis.Text.Trim))
        cm.Parameters.AddWithValue("enroll_discount", 0)
        cm.Parameters.AddWithValue("enroll_comment", cmt)
        cm.Parameters.AddWithValue("test_date", test_date)
        cm.Parameters.AddWithValue("payment_type", payment_type)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.Parameters.AddWithValue("user_id", User_ID)
        cm.Parameters.AddWithValue("user_receive", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        'MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
        rpt_status = 1
        Rpt_OnlyView = 0
        FrmReport_A5.ShowDialog()

        Cursor = Cursors.Default
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
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
        If (txt_course.Text <> "") Then
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

    Private Sub lb_test_date_Click(sender As Object, e As EventArgs) Handles lb_test_date.Click
        FrmStudentEnroll_SetDate.ShowDialog()
    End Sub

End Class