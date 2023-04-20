Public Class Frm_Report_Student_train

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        DateTimePicker2.Value = CDate(cur_date)
        Dim Last_Month As Date = DateAdd(DateInterval.Day, -90, CDate(cur_date))
        DateTimePicker1.Value = CDate(Last_Month)
        DateTimePicker2.MinDate = CDate(DateTimePicker1.Value)

        'Checkbox
        rdo_info.Checked = True
        chk_studying.Checked = True
        chk_completed.Checked = True
        chk_outed.Checked = False

        chk_completed.Enabled = True
        chk_outed.Enabled = True
        chk_studying.Enabled = True

        Call getCourseList()
        load_finishied = 0
    End Sub

    Private Sub getCourseList()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_course, 0 AS train_course_id "
        Sql &= "UNION "
        Sql &= "SELECT (train_course_des_en+' -['+train_course_des_la+']') AS full_course, train_course_id "
        Sql &= " FROM tbl_train_course_list"
        Sql &= " ORDER BY train_course_id "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "train_course_id"
        cb_course.DisplayMember = "full_course"
        cb_course.SelectedIndex = 0
    End Sub

    Public Sub LoadData()
        Dim ft_date As String = "FILTER STUDY FROM DATE: " & Format(CDate(DateTimePicker1.Value.Date), "dd/MM/yyyy") & " - " & Format(CDate(DateTimePicker2.Value.Date), "dd/MM/yyyy")
        Dim s_d As String = Convert.ToDateTime(DateTimePicker1.Value.Date).ToString("yyyy-MM-dd")
        Dim e_d As String = Convert.ToDateTime(DateTimePicker2.Value.Date).ToString("yyyy-MM-dd")

        '1. Print Info
        If (rdo_info.Checked = True) Then
            Cursor = Cursors.WaitCursor
            Dim ct_course As String = ""

            Dim st_studying As Integer = 1
            Dim st_completed As Integer = 2
            Dim st_outed As Integer = 0

            If (chk_studying.Checked = False) Then
                st_studying = 5
            End If
            If (chk_completed.Checked = False) Then
                st_completed = 5
            End If
            If (chk_outed.Checked = False) Then
                st_outed = 5
            End If

            Dim ct_status As String = " AND (std_train_status IN(" & st_studying & "," & st_completed & "," & st_outed & "))"
            If (cb_course.SelectedValue <> 0) Then
                ct_course = " AND (train_course_id = " & cb_course.SelectedValue & ")"
            End If

            Sql = "SELECT * FROM view_train_std_register "
            Sql &= " WHERE(learn_date BETWEEN '" & s_d & "' AND '" & e_d & "') " & ct_status & ct_course
            Sql &= " ORDER BY train_course_id, std_train_fullname_en "
            dt = ExecuteDatable(Sql)
            Dim crt As New Rpt_StudentList_Train
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.SetParameterValue("report_title", ft_date)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
            Cursor = Cursors.Default
        End If

        '2. Print Certificate
        If (rdo_info.Checked = True) Then
            Cursor = Cursors.WaitCursor
            Dim ct_course As String = ""
            Dim ct_status As String = " AND (std_train_status IN(2))"
            If (cb_course.SelectedValue <> 0) Then
                ct_course = " AND (train_course_id = " & cb_course.SelectedValue & ")"
            End If

            Sql = "SELECT * FROM view_train_std_register "
            Sql &= " WHERE(learn_date BETWEEN '" & s_d & "' AND '" & e_d & "') " & ct_status & ct_course
            Sql &= " ORDER BY train_course_id, std_train_fullname_en "
            dt = ExecuteDatable(Sql)
            Dim crt As New Rpt_StudentList_Train_Certificate
            crt.SetDataSource(dt)

            'crt.SetParameterValue("user_print", User_name)
            'crt.SetParameterValue("report_title", ft_date)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        Call LoadData()
    End Sub

    Private Sub btn_SetClass_Clear_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Clear.Click
        Me.Close()
    End Sub

    Private Sub rdo_info_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_info.CheckedChanged
        If (load_finishied = 0) And rdo_info.Checked = True Then
            chk_outed.Enabled = True
            chk_studying.Enabled = True
            chk_completed.Enabled = True
            chk_studying.Checked = True
            chk_completed.Checked = True
            chk_outed.Checked = False
        End If
    End Sub

    Private Sub rdo_certificate_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_certificate.CheckedChanged
        If (load_finishied = 0) And rdo_certificate.Checked = True Then
            chk_outed.Enabled = False
            chk_studying.Enabled = False
            chk_completed.Enabled = False
            chk_studying.Checked = False
            chk_completed.Checked = True
            chk_outed.Checked = False
        End If
    End Sub
End Class