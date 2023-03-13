Imports System.Data.SqlClient

Public Class FrmStudentRegister_Upgrade_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudentRegister_view.LoadData_StudentUpgrade()
        End If
    End Sub

    Dim load_finish As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finish = 1
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        Call load_data()
        load_finish = 0
    End Sub

    Dim student_id As Integer = 0
    Private Sub load_data()
        Sql = "SELECT register_upg_id ,bill_id ,register_date ,register_amount ,register_remark ,receive_by ,receive_id ,"
        Sql &= " student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,phone_number ,course_id ,"
        Sql &= " course_des_la ,course_des_en ,scheme_id ,scheme_des_la ,scheme_des_en ,subject_id ,subject_code ,subject_name_la ,"
        Sql &= " subject_name_en ,subject_credit, payment_type "
        Sql &= " FROM view_register_upgrade"
        Sql &= " WHERE(register_upg_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            BILL_ID = .Item("bill_id")
            student_id = CInt(.Item("student_id"))
            txt_std_code.Text = CStr(.Item("student_code"))
            lb_title.Text = "ຊື່ນັກສຶກສາ(ທ້າວ)"
            If (CInt(.Item("student_gender")) = 2) Then
                lb_title.Text = "ຊື່ນັກສຶກສາ(ນາງ)"
            End If
            txt_name.Text = .Item("student_fullname_la")
            DateTimePicker1.Text = .Item("register_date")
            If (Format(CDate(.Item("register_date")), "yyyy-MM-dd") > cur_date) Then
                DateTimePicker1.MinDate = CDate(cur_date)
            Else
                DateTimePicker1.MinDate = CDate(.Item("register_date"))
            End If

            txt_phone.Text = .Item("phone_number")
            txt_course.Text = .Item("scheme_des_la") & "(" & .Item("course_des_la") & ")"
            txt_subject.Text = .Item("subject_code") & "(" & .Item("subject_name_la") & "): " & .Item("subject_credit") & " ໜ່ວຍກິດ"
            txt_total.Text = Format(CDbl(.Item("register_amount")), "N0")

            'If have payment cannot edit discount
            If (CInt(.Item("payment_type")) = 1) Then
                rdo_cash.Checked = True
            Else
                rdo_BT.Checked = True
            End If
            txt_comment.Text = .Item("register_remark")
            txt_comment.Select()
        End With
    End Sub

    Private Sub add_new_user()
        'Update Register
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If

        'Payment
        Dim payment_type As Integer = 1
        If (rdo_BT.Checked = True) Then
            payment_type = 2
        End If

        Dim learn_date As String = Format(CDate(DateTimePicker1.Value.Date), "yyyy-MM-dd")
        Sql = "UPDATE tbl_term_register_upgrade SET register_date=@register_date ,last_update=getdate() ,user_update=@user_update, payment_type=@payment_type ,register_remark=@register_remark "
        Sql &= " WHERE(register_upg_id=@register_upg_id)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("register_upg_id", id_edit)
        cm.Parameters.AddWithValue("register_date", learn_date)
        cm.Parameters.AddWithValue("register_remark", cmt)
        cm.Parameters.AddWithValue("payment_type", payment_type)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        had_change_val = 1
        reg_number_of_term_where = " WHERE(bill_id = '" & BILL_ID & "')"
        Me.Close()
        If (needprint = 1) Then
            Cursor = Cursors.WaitCursor
            rpt_status = 3
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

End Class