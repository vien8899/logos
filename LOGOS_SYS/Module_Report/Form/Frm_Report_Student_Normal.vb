Public Class Frm_Report_Student_Normal

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        chk_completed.Checked = True
        chk_studying.Checked = True
        chk_outed.Checked = False

        Call getYearList()
        Call getScheme()
        Call getCourseList(CInt(cb_scheme.SelectedValue), cb_course)
        Call getTermList(CInt(cb_course.SelectedValue), cb_Term)

        'Score
        Call getScheme_NotAll()
        Call getCourseList(CInt(cb_scheme_score.SelectedValue), cb_course_score)

        'ID Card
        Call getCourseList(CInt(cb_scheme_card.SelectedValue), cb_course_card)
        cb_year_studying.SelectedIndex = 0

        start_year = CInt(Format(CDate(cur_date), "yyyy"))
        Dim issued_date As String = Format(CDate(start_year & "-10-20"))
        Dim expired_date As String = Format(CDate((start_year + (number_of_term / 2)) & "-10-30"))
        DateTimePicker1.Value = CDate(issued_date)
        DateTimePicker2.Value = CDate(expired_date)

        load_finishied = 0
    End Sub

    Private Sub getYearList()
        cb_year.Items.Clear()
        Dim cur_year As Integer = CInt(Format(CDate(cur_date), "yyyy")) - 17
        Dim i As Integer = 18
        While i > 0
            cb_year.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            cb_year_card.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            cb_year_score.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            i -= 1
        End While
        cb_year.SelectedIndex = 1
        cb_year_card.SelectedIndex = 1
        cb_year_score.SelectedIndex = 1
    End Sub

    Dim endload_scheme As Integer = 1
    Private Sub getScheme()
        endload_scheme = 1
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_scheme, 0 AS scheme_id "
        Sql &= "UNION "
        Sql &= "SELECT (scheme_des_la+' -('+scheme_des_en+')') AS full_scheme, scheme_id "
        Sql &= " FROM tbl_setting_scheme"
        Sql &= " ORDER BY scheme_id "
        dt = ExecuteDatable(Sql)

        'Std Info
        cb_scheme.DataSource = dt
        cb_scheme.ValueMember = "scheme_id"
        cb_scheme.DisplayMember = "full_scheme"
        cb_scheme.SelectedIndex = 0

        endload_scheme = 0
    End Sub

    Private Sub getScheme_NotAll()
        endload_scheme = 1
        Sql = "SELECT (scheme_des_la+' -('+scheme_des_en+')') AS full_scheme, scheme_id "
        Sql &= " FROM tbl_setting_scheme"
        Sql &= " ORDER BY scheme_id "
        dt = ExecuteDatable(Sql)

        'Std Score
        cb_scheme_score.DataSource = dt
        cb_scheme_score.ValueMember = "scheme_id"
        cb_scheme_score.DisplayMember = "full_scheme"
        cb_scheme_score.SelectedIndex = 0

        'Std Card
        cb_scheme_card.DataSource = dt
        cb_scheme_card.ValueMember = "scheme_id"
        cb_scheme_card.DisplayMember = "full_scheme"
        cb_scheme_card.SelectedIndex = 0

        endload_scheme = 0
    End Sub

    Dim endload_course As Integer = 1
    Private Sub getCourseList(ByVal scheme As Integer, ByVal cb As ComboBox)
        endload_course = 1
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_course, 0 AS course_id "
        Sql &= "UNION "
        Sql &= "SELECT (course_des_la+' -('+course_des_en+')') AS full_course, course_id "
        Sql &= " FROM tbl_setting_course"
        If (scheme > 0) Then
            Sql &= " WHERE(scheme_id=" & scheme & ") "
        End If
        Sql &= " ORDER BY course_id "
        dt = ExecuteDatable(Sql)
        cb.DataSource = dt
        cb.ValueMember = "course_id"
        cb.DisplayMember = "full_course"
        cb.SelectedIndex = 0

        endload_course = 0
    End Sub

    Private Sub getTermList(ByVal course As Integer, ByVal cb As ComboBox)
        Dim ct As String = ""
        If (course <> 0) Then
            ct = " WHERE(course_id = " & course & ")"
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
        cb.DataSource = dt
        cb.ValueMember = "term_list_id"
        cb.DisplayMember = "full_term"
        cb.SelectedIndex = 0
    End Sub

    Public Sub PrintStudent_List()
        Cursor = Cursors.WaitCursor

        Dim ft_scheme As String = "ALL"
        Dim ft_course As String = "ALL"
        Dim ft_term As String = "ALL"

        Dim ct_course As String = ""
        Dim ct_term As String = ""
        Dim ct_scheme As String = ""
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

        Dim ct_status As String = " AND (student_status IN(" & st_studying & "," & st_completed & "," & st_outed & "))"
        If (cb_scheme.SelectedValue <> 0) Then
            ct_scheme = " AND (scheme_id = " & cb_scheme.SelectedValue & ")"
        End If
        If (cb_Term.SelectedValue <> 0) Then
            ct_term = " AND (current_term_list_id = '" & cb_Term.SelectedValue & "')"
        End If
        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If

        Sql = "SELECT * FROM view_std_list "
        Sql &= " WHERE(current_sokhien='" & CStr(cb_year.SelectedItem) & "')" & ct_status & ct_scheme & ct_course & ct_term
        Sql &= " ORDER BY scheme_id, course_id, current_term  "
        dt = ExecuteDatable(Sql)
        Dim crt As New Rpt_StudentList_Normal
        crt.SetDataSource(dt)

        Dim filter As String = "FILTER: Academic Year: " & cb_year.SelectedItem
        crt.SetParameterValue("user_print", User_name)
        crt.SetParameterValue("report_title", filter)
        crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        'Show Report
        FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        FrmReport_A4.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Public Sub PrintStudent_Card()
        Cursor = Cursors.WaitCursor

        Dim ct_course As String = ""
        Dim ct_scheme As String = ""
        Dim ct_sokhien As String = " AND (current_sokhien='" & CStr(cb_year_card.SelectedItem) & "')"
        Dim ct_year_studying As String = " AND (current_term_study_year=" & CInt(cb_year_studying.SelectedItem) & ")"

        If (cb_scheme_card.SelectedValue <> 0) Then
            ct_scheme = " AND (scheme_id = " & cb_scheme_card.SelectedValue & ")"
        End If
        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If

        Dim issue_date As String = Format(CDate(DateTimePicker1.Value.Date), "yyyy-MM-dd")
        Dim exp_date As String = Format(CDate(DateTimePicker2.Value.Date), "yyyy-MM-dd")

        Sql = "SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,"
        Sql &= " date_of_birth ,birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,"
        Sql &= " phone_number ,wa_number ,course_id ,start_year ,end_year ,create_date ,student_status ,course_des_la ,"
        Sql &= " course_des_en ,scheme_des_la ,scheme_des_en ,student_remark ,title_la ,title_en ,sex_id ,"
        Sql &= " std_img ,college_name_en ,college_name_la ,college_address ,minister_of_en ,minister_of_la ,"
        Sql &= " only_tel ,only_email ,college_logo ,nationality_en ,expected_graduate ,number_of_term ,"
        Sql &= " '" & issue_date & "' AS id_card_issued,'" & exp_date & "' AS id_card_expired ,college_website ,std_id_card_dept "
        Sql &= " FROM view_std_ID_CARD"
        Sql &= " WHERE(student_status =1)" & ct_scheme & ct_course & ct_sokhien & ct_year_studying
        Sql &= " ORDER BY scheme_id, course_id, student_fullname_en "
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

    Private Sub btn_SetClass_Clear_Click(sender As Object, e As EventArgs) Handles btn_close1.Click, btn_close2.Click, btn_close3.Click
        Me.Close()
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_scheme.SelectedIndexChanged
        If (load_finishied = 0) And (endload_scheme = 0) Then
            Call getCourseList(CInt(cb_scheme.SelectedValue), cb_course)
        End If
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) And (endload_course = 0) Then
            Call getTermList(CInt(cb_course.SelectedValue), cb_Term)
        End If
    End Sub

    Private Sub rdo_info_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_info.CheckedChanged
        If (rdo_info.Checked = True) And load_finishied = 0 Then
            Panel_Info.Visible = True
            Panel_Score.Visible = False
            Panel_IDCard.Visible = False
        End If
    End Sub

    Private Sub rdo_Score_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Score.CheckedChanged
        If (rdo_Score.Checked = True) And load_finishied = 0 Then
            Panel_Info.Visible = False
            Panel_Score.Visible = True
            Panel_IDCard.Visible = False
        End If
    End Sub

    Private Sub rdo_Card1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Card.CheckedChanged
        If (rdo_Card.Checked = True) And load_finishied = 0 Then

            Panel_Info.Visible = False
            Panel_Score.Visible = False
            Panel_IDCard.Visible = True
        End If
    End Sub

    Private Sub cb_scheme_score_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_scheme_score.SelectedIndexChanged
        If (load_finishied = 0) And (endload_scheme = 0) Then
            Call getCourseList(CInt(cb_scheme_score.SelectedValue), cb_course_score)
        End If
    End Sub

    Private Sub cb_scheme_card_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_scheme_card.SelectedIndexChanged
        If (load_finishied = 0) And (endload_scheme = 0) Then
            Call getCourseList(CInt(cb_scheme_card.SelectedValue), cb_course_card)
        End If
    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        Call PrintStudent_List()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call PrintStudent_Card()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Print Score
    End Sub

End Class