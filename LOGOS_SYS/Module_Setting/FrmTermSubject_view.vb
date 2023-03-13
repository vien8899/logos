Public Class FrmTermSubject_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).modify_term = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        Call getSchemeList()
        Call getCourseList(CInt(cb_scheme.SelectedValue))
        Call getTermList(CInt(cb_course.SelectedValue))
        Call LoadData()
        load_finishied = 0
    End Sub

    Private Sub getSchemeList()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS scheme_des_la, 0 AS scheme_id "
        Sql &= "UNION "
        Sql &= "SELECT scheme_des_la, scheme_id "
        Sql &= " FROM tbl_setting_scheme "
        Sql &= " ORDER BY scheme_id "
        dt = ExecuteDatable(Sql)
        cb_scheme.DataSource = dt
        cb_scheme.ValueMember = "scheme_id"
        cb_scheme.DisplayMember = "scheme_des_la"
        cb_scheme.SelectedValue = 0
    End Sub

    Private Sub getCourseList(ByVal sch As Integer)
        Dim ct As String = ""
        If (sch <> 0) Then
            ct = " WHERE(scheme_id = " & sch & ")"
        End If
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS course_des_la, 0 AS course_id "
        Sql &= "UNION "
        Sql &= "SELECT course_des_la, course_id "
        Sql &= " FROM tbl_setting_course " & ct
        Sql &= " ORDER BY course_id "
        dt = ExecuteDatable(Sql)
        cb_course.DataSource = dt
        cb_course.ValueMember = "course_id"
        cb_course.DisplayMember = "course_des_la"
    End Sub

    Private Sub getTermList(ByVal sch As Integer)
        Dim ct As String = ""
        If (sch <> 0) Then
            ct = " WHERE(course_id = " & sch & ")"
        End If
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS full_term, 0 AS term_id, 0 AS course_id, 0 AS term_list_id "
        Sql &= "UNION "
        Sql &= "SELECT (term_no+' ('+term_des+')') AS full_term, term_id, course_id, term_list_id "
        Sql &= " FROM view_term_table " & ct
        Sql &= " ORDER BY course_id, term_list_id "
        dt = ExecuteDatable(Sql)
        cb_term.DataSource = dt
        cb_term.ValueMember = "term_id"
        cb_term.DisplayMember = "full_term"
    End Sub

    Public Sub LoadData()
        Dim ct_scheme As String = ""
        Dim ct_course As String = ""
        Dim ct_term As String = ""
        If (cb_scheme.SelectedValue <> 0) Then
            ct_scheme = " AND (scheme_id = " & cb_scheme.SelectedValue & ")"
        End If
        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If
        If (cb_term.SelectedValue <> 0) Then
            ct_term = " AND (term_id = " & cb_term.SelectedValue & ")"
        End If

        Sql = "SELECT term_subject_id ,term_id ,term_no ,term_des ,course_id ,course_des_la ,course_des_en ,"
        Sql &= " scheme_id ,scheme_des_la ,scheme_des_en ,more_des ,subject_id ,subject_code ,subject_name_la ,"
        Sql &= " subject_name_en ,last_update ,user_update"
        Sql &= " FROM view_term_subject_list"
        Sql &= " WHERE(term_subject_id > 0) " & ct_scheme & ct_course & ct_term
        Sql &= " ORDER BY scheme_id, course_des_la, term_no "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("term_subject_id"), (i + 1), (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), _
                          dt.Rows(i).Item("term_no") & " (" & dt.Rows(i).Item("term_des") & ")", _
                          dt.Rows(i).Item("subject_code") & " (" & dt.Rows(i).Item("subject_name_la") & ")", _
                          dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_edit.Enabled = True
                btn_disable.Enabled = True
            Else
                btn_edit.Enabled = False
                btn_disable.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmTermSubject_add.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmTermSubject_edit.ShowDialog()
    End Sub

    Private Sub cb_scheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_scheme.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call getCourseList(CInt(cb_scheme.SelectedValue))
            Call getTermList(CInt(cb_course.SelectedValue))
            Call LoadData()
        End If
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call getTermList(CInt(cb_course.SelectedValue))
            Call LoadData()
        End If
    End Sub

    Private Sub cb_term_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_term.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        If MessageBox.Show("Are you sure want to delete subject in term?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM tbl_setting_term_subject "
            Sql &= " WHERE (term_subject_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ");" & vbNewLine
            Call ExecuteUpdate(Sql)

            MessageBox.Show("Info deleted!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LoadData()
        End If
    End Sub

End Class