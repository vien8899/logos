Public Class FrmStdDrop_StudentSelect

    Dim load_finishied As Integer = 1
    Dim curyear As Integer = 0
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        curyear = CInt(Format(CDate(getCurrentDate()), "yyyy"))
        'txt_search.Text = reg_search_where
        Call getCourseList()
        Call LoadData()
        load_finishied = 0
        txt_search.Select()
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
    End Sub

    Public Sub LoadData()
        Dim ct_course As String = ""
        Dim ct_search As String = ""

        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((student_code LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_la LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (student_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') "
            ct_search &= " OR (phone_number LIKE '" & txt_search.Text.Trim & "%')) "
        End If

        Sql = " SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,"
        Sql &= " date_of_birth ,birth_address_la ,birth_address_en ,nationality ,address_la ,address_en ,"
        Sql &= " phone_number ,wa_number ,job_des ,hight_school_name ,hight_school_graduate_year ,"
        Sql &= " parent_name ,parent_contact ,course_id ,current_term_id ,class_id ,start_year ,end_year ,"
        Sql &= " create_date ,student_status ,last_update ,user_update ,course_des_la ,course_des_en ,"
        Sql &= " scheme_id ,scheme_des_la ,scheme_des_en ,max_term_id_reg ,get_current_class_id ,current_sokhien ,"
        Sql &= " get_current_term_id ,max_term_reg ,current_class ,current_year ,max_term_list_id_reg, title_la, title_en "
        Sql &= " FROM view_std_list"
        Sql &= " WHERE(start_year <= " & curyear & ")  AND (end_year>= " & curyear & ") "
        Sql &= ct_course & ct_search
        Sql &= " ORDER BY student_code, scheme_id, course_id, student_fullname_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

               'Sex
                Dim sex As String = dt.Rows(i).Item("title_la") & ". "

                .Rows.Add(dt.Rows(i).Item("student_id"), (i + 1), dt.Rows(i).Item("student_code"), sex, sex & dt.Rows(i).Item("student_fullname_la"), dt.Rows(i).Item("student_fullname_en"), _
                          dt.Rows(i).Item("date_of_birth"), dt.Rows(i).Item("phone_number"), (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), _
                          dt.Rows(i).Item("max_term_reg"), dt.Rows(i).Item("current_class"), dt.Rows(i).Item("current_sokhien"), dt.Rows(i).Item("current_year"), dt.Rows(i).Item("course_id"), dt.Rows(i).Item("parent_name"), dt.Rows(i).Item("parent_contact"))
            Next

        End With
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Public get_student_id, get_std_code, get_student_name_la, get_student_name_en, get_course_id, get_full_course, get_birth_date, get_telephone, get_sex, get_parent_name, get_parent_contact As String
    Private Sub Datagridview1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datagridview1.CellMouseClick
        If Datagridview1.RowCount > 0 Then
            get_student_id = Datagridview1.CurrentRow.Cells(0).Value.ToString()
            get_std_code = Datagridview1.CurrentRow.Cells(2).Value.ToString()
            get_sex = Datagridview1.CurrentRow.Cells(3).Value.ToString()
            get_student_name_la = Datagridview1.CurrentRow.Cells(4).Value.ToString()
            get_student_name_en = Datagridview1.CurrentRow.Cells(5).Value.ToString()
            get_course_id = Datagridview1.CurrentRow.Cells(13).Value.ToString()
            get_full_course = Datagridview1.CurrentRow.Cells(8).Value.ToString()
            get_birth_date = Datagridview1.CurrentRow.Cells(6).Value.ToString()
            get_telephone = Datagridview1.CurrentRow.Cells(7).Value.ToString()
            get_parent_name = Datagridview1.CurrentRow.Cells(14).Value.ToString()
            get_parent_contact = Datagridview1.CurrentRow.Cells(15).Value.ToString()

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub


End Class