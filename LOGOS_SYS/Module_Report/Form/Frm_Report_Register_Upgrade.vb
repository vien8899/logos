Public Class Frm_Report_Register_Upgrade

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

        Call getSubjectList()
        Call getUser()
        load_finishied = 0
    End Sub

    Private Sub getSubjectList()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_subject, 0 AS subject_id "
        Sql &= "UNION "
        Sql &= "SELECT (subject_name_en+' -['+subject_name_la+']') AS full_subject, subject_id "
        Sql &= " FROM tbl_setting_subject"
        Sql &= " ORDER BY subject_id "
        dt = ExecuteDatable(Sql)
        cb_subject.DataSource = dt
        cb_subject.ValueMember = "subject_id"
        cb_subject.DisplayMember = "full_subject"
        cb_subject.SelectedIndex = 0
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
        If (cb_subject.SelectedValue <> 0) Then
            ct_course = " AND (subject_id = " & cb_subject.SelectedValue & ")"
        End If
        If (cb_user.SelectedValue <> 0) Then
            ct_course = " AND (receive_id = " & cb_user.SelectedValue & ")"
        End If

        Sql = "SELECT * FROM view_register_upgrade "
        Sql &= " WHERE(register_date BETWEEN '" & s_d & "' AND '" & e_d & "') " & ct_payment & ct_course & ct_user
        Sql &= " ORDER BY bill_id "
        dt = ExecuteDatable(Sql)
        Dim crt As New Rpt_Register_Upgrade
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