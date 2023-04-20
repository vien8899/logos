Public Class Frm_Report_Student_PrintOption

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        rdo_info.Checked = True

        Panel_Refer.Visible = True
        Panel_Term.Visible = False
        Panel_IDCard.Visible = False

        Dim issued_date As String = Format(CDate(start_year & "-10-20"))
        Dim expired_date As String = Format(CDate((start_year + (number_of_term / 2)) & "-10-30"))
        DateTimePicker1.Value = CDate(issued_date)
        DateTimePicker2.Value = CDate(expired_date)

        Call DisabledRDO()
        rdo_font.Checked = True
        load_finishied = 0
    End Sub

    Private Sub DisabledRDO()
        'rdo_1term.Enabled = False
        'rdo_2term.Enabled = False
        'rdo_3term.Enabled = False
        'rdo_4term.Enabled = False
        'rdo_5term.Enabled = False
        'rdo_6term.Enabled = False
        'rdo_7term.Enabled = False
        'rdo_8term.Enabled = False
    End Sub

    Private Sub EnabledRDO()
        'For j As Integer = 1 To number_of_term
        '    For Each btn As Control In Me.Panel_Term.Controls
        '        If TypeOf btn Is RadioButton And btn.Name = "rdo_" & j & "term" Then
        '            CType(btn, Button).Enabled = True
        '        End If
        '    Next
        'Next
    End Sub

    Private Sub btn_SetClass_Clear_Click(sender As Object, e As EventArgs) Handles btn_close1.Click, btn_close2.Click, btn_close3.Click, btn_close4.Click
        Me.Close()
    End Sub

    Private Sub rdo_info_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_info.CheckedChanged
        If (rdo_info.Checked = True) And load_finishied = 0 Then
            Panel_Refer.Visible = True
            Panel_Term.Visible = False
            Panel_IDCard.Visible = False
            Panel_Log.Visible = False
        End If
    End Sub

    Private Sub rdo_score_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_score.CheckedChanged
        If (rdo_score.Checked = True) Then
            Panel_Refer.Visible = False
            Panel_Term.Visible = True
            Panel_IDCard.Visible = False
            Panel_Log.Visible = False
        End If
    End Sub

    Private Sub rdo_card_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_card.CheckedChanged
        If (rdo_card.Checked = True) Then
            Panel_Refer.Visible = False
            Panel_Term.Visible = False
            Panel_IDCard.Visible = True
            Panel_Log.Visible = False
        End If
    End Sub

    Private Sub rdo_log_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_log.CheckedChanged
        If (rdo_log.Checked = True) Then
            Panel_Refer.Visible = False
            Panel_Term.Visible = False
            Panel_IDCard.Visible = False
            Panel_Log.Visible = True
        End If
    End Sub

    Public Sub PrintStudentReference()
        Cursor = Cursors.WaitCursor

        Sql = "SELECT * FROM view_std_list "
        Sql &= " WHERE(student_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)

        'LA
        If (rdo_LA.Checked = True) Then
            Dim crt As New Rpt_StudentReference_LA
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
        End If

        'EN
        If (rdo_EN.Checked = True) Then
            Dim crt As New Rpt_StudentReference_EN
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
        End If

        Cursor = Cursors.Default
    End Sub

    Public Sub PrintScore()
        Cursor = Cursors.WaitCursor

        'Dim ft_scheme As String = "ALL"
        'Dim ft_course As String = "ALL"
        'Dim ft_term As String = "ALL"
        'Dim ft_sokhien As String = CStr(cb_year.SelectedItem)

        'Dim ct_course As String = ""
        'Dim ct_term As String = ""
        'Dim ct_scheme As String = ""
        'Dim st_studying As Integer = 1
        'Dim st_completed As Integer = 2
        'Dim st_outed As Integer = 0

        'If (chk_studying.Checked = False) Then
        '    st_studying = 5
        'End If
        'If (chk_completed.Checked = False) Then
        '    st_completed = 5
        'End If
        'If (chk_outed.Checked = False) Then
        '    st_outed = 5
        'End If

        'Dim ct_status As String = " AND (student_status IN(" & st_studying & "," & st_completed & "," & st_outed & "))"
        'If (cb_scheme.SelectedValue <> 0) Then
        '    ct_scheme = " AND (scheme_id = " & cb_scheme.SelectedValue & ")"
        'End If
        'If (cb_Term.SelectedValue <> 0) Then
        '    ct_term = " AND (current_term_list_id = '" & cb_Term.SelectedValue & "')"
        'End If
        'If (cb_course.SelectedValue <> 0) Then
        '    ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        'End If

        'Sql = "SELECT * FROM view_std_list "
        'Sql &= " WHERE(current_sokhien='" & CStr(cb_year.SelectedItem) & "')" & ct_status & ct_scheme & ct_course & ct_course
        'Sql &= " ORDER BY scheme_id, course_id, current_term  "
        'dt = ExecuteDatable(Sql)
        'Dim crt As New Rpt_StudentList_Normal
        'crt.SetDataSource(dt)

        'Dim filter As String = "FILTER: Academic Year: " & cb_year.SelectedItem
        'crt.SetParameterValue("user_print", User_name)
        'crt.SetParameterValue("report_title", filter)
        'crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        ''Show Report
        'FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        'FrmReport_A4.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Public Sub PrintStudent_Card()
        Cursor = Cursors.WaitCursor

        Dim issue_date As String = Format(CDate(DateTimePicker1.Value.Date), "yyyy-MM-dd")
        Dim exp_date As String = Format(CDate(DateTimePicker2.Value.Date), "yyyy-MM-dd")

        Sql = "SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,"
        Sql &= " date_of_birth ,birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,"
        Sql &= " phone_number ,wa_number ,course_id ,start_year ,end_year ,create_date ,student_status ,course_des_la ,"
        Sql &= " course_des_en ,scheme_des_la ,scheme_des_en ,student_remark ,title_la ,title_en ,sex_id ,"
        Sql &= " std_img ,college_name_en ,college_name_la ,college_address ,minister_of_en ,minister_of_la ,"
        Sql &= " only_tel ,only_email ,college_logo ,nationality_en ,expected_graduate ,number_of_term ,"
        Sql &= " '" & issue_date & "' AS id_card_issued,'" & exp_date & "' AS id_card_expired ,college_website ,std_id_card_dept"
        Sql &= " FROM view_std_ID_CARD"
        Sql &= " WHERE(student_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)

        'Font
        If (rdo_font.Checked = True) Then
            Dim crt As New ID_CARD_FONT
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
        End If

        'Back
        If (rdo_back.Checked = True) Then
            Dim crt As New ID_CARD_BACK
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
        End If

        Cursor = Cursors.Default
    End Sub

    Public Sub PrintStudent_Log()
        Cursor = Cursors.WaitCursor

        Sql = "SELECT * FROM view_std_log "
        Sql &= " WHERE(student_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)

        Dim crt As New Rpt_Student_Log
        crt.SetDataSource(dt)

        crt.SetParameterValue("user_print", User_name)
        crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        'Show Report
        FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        FrmReport_A4.ShowDialog()

        Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call PrintStudentReference()
    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        Call PrintStudent_Card()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call PrintStudent_Card()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call PrintStudent_Log()
    End Sub

   
End Class