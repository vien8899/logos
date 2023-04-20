Public Class Frm_Report_Register

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        DateTimePicker2.Value = CDate(cur_date)
        Dim Last_Month As Date = DateAdd(DateInterval.Day, -180, CDate(cur_date))
        DateTimePicker1.Value = CDate(Last_Month)
        DateTimePicker2.MinDate = CDate(DateTimePicker1.Value)

        Call getCourseList()
        Call getTermList(CInt(cb_course.SelectedValue))
        Call getUser()
        load_finishied = 0
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
        cb_course.SelectedIndex = 0
    End Sub

    Private Sub getTermList(ByVal sch As Integer)
        Dim ct As String = ""
        If (sch <> 0) Then
            ct = " WHERE(course_id = " & sch & ")"
            Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_term, 0 AS term_list_id "
            Sql &= "UNION "
            Sql &= "SELECT (term_no+' ('+term_des+')') AS full_term, term_list_id "
            Sql &= " FROM view_term_table " & ct
            Sql &= " ORDER BY term_list_id "
        Else
            Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_term, 0 AS term_list_id "
            Sql &= "UNION "
            Sql &= "SELECT (term_no+' ('+term_no_la+')') AS full_term, term_list_id "
            Sql &= " FROM tbl_setting_term_list "
            Sql &= " ORDER BY term_list_id "
        End If

        dt = ExecuteDatable(Sql)
        cb_term.DataSource = dt
        cb_Term.ValueMember = "term_list_id"
        cb_Term.DisplayMember = "full_term"
        cb_Term.SelectedIndex = 0
    End Sub

    Private Sub getUser()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS user_name, 0 AS em_id "
        Sql &= "UNION "
        Sql &= "SELECT user_name, em_id "
        Sql &= " FROM tbl_user "
        Sql &= " ORDER BY em_id "
        dt = ExecuteDatable(Sql)
        cb_user.DataSource = dt
        cb_user.ValueMember = "em_id"
        cb_user.DisplayMember = "user_name"
        cb_user.SelectedIndex = 0
    End Sub

    Public Sub LoadData()
        Cursor = Cursors.WaitCursor
        Dim ft_date As String = "FILTER FROM DATE: " & Format(CDate(DateTimePicker1.Value.Date), "dd/MM/yyyy") & " - " & Format(CDate(DateTimePicker2.Value.Date), "dd/MM/yyyy")
        Dim s_d As String = Convert.ToDateTime(DateTimePicker1.Value.Date).ToString("yyyy-MM-dd")
        Dim e_d As String = Convert.ToDateTime(DateTimePicker2.Value.Date).ToString("yyyy-MM-dd")
        Dim ct_course As String = ""
        Dim ct_term As String = ""
        Dim ct_user As String = ""
        Dim cash As Integer = 1
        Dim bt As Integer = 2

        If (chk_cash.Checked = False) Then
            cash = 0
        End If
        If (chk_bt.Checked = False) Then
            bt = 0
        End If
        Dim ct_payment As String = " AND (payment_type IN(" & cash & "," & bt & "))"

        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (cb_Term.SelectedValue <> 0) Then
            ct_term = " AND (term_list_id = " & cb_Term.SelectedValue & ")"
        End If
        If (cb_user.SelectedValue <> 0) Then
            ct_user = " AND (receive_id = " & cb_user.SelectedValue & ")"
        End If

        Sql = "SELECT * FROM view_std_register_payment "
        Sql &= " WHERE(paid_date BETWEEN '" & s_d & "' AND '" & e_d & "') AND (paid_amount > 0) " & ct_payment & ct_course & ct_term & ct_user
        Sql &= " ORDER BY payment_id "
        dt = ExecuteDatable(Sql)
        Dim crt As New Rpt_Register
        crt.SetDataSource(dt)

        crt.SetParameterValue("user_print", User_name)
        crt.SetParameterValue("report_title", ft_date)
        crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        'Show Report
        FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        FrmReport_A4.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        Call LoadData()
    End Sub

    Private Sub btn_SetClass_Clear_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Clear.Click
        Me.Close()
    End Sub
End Class