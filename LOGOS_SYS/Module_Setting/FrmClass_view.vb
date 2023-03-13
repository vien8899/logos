Public Class FrmClass_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).modify_class = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        Call getCourseList()
        Call getTermList(cb_course.SelectedValue)
        Call LoadData()

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
    End Sub

    Private Sub getTermList(ByVal c As Integer)
        Dim ct As String = ""
        If (c <> 0) Then
            ct = " AND (course_id=" & c & ")"
        End If
        Sql = "SELECT (term_no+' -['+term_des+']') AS full_term, term_id "
        Sql &= " FROM view_term_table WHERE(term_status <> 0) " & ct
        Sql &= " ORDER BY course_id, term_no "
        dt = ExecuteDatable(Sql)
        cb_term.DataSource = dt
        cb_term.ValueMember = "term_id"
        cb_term.DisplayMember = "full_term"
    End Sub

    Public Sub LoadData()
        Dim ct_course As String = ""
        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If

        Dim ct_term As String = ""
        If (cb_term.SelectedValue <> 0) Then
            ct_term = " AND (term_id = " & cb_term.SelectedValue & ")"
        End If

        Sql = " SELECT class_id ,class_code ,class_des, class_status ,term_id ,term_no ,term_des ,course_id ,course_des_la ,"
        Sql &= " course_des_en, scheme_id, scheme_des_la, scheme_des_en, learning_shift_id, learning_shift_des, user_update, last_update "
        Sql &= " FROM view_class_list"
        Sql &= " WHERE(class_id > 0) " & ct_course & ct_term
        Sql &= " ORDER BY scheme_id, course_id, term_id, learning_shift_id "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                Dim st As String = "ໃຊ້ງານ"
                If (dt.Rows(i).Item("class_status") = 0) Then
                    st = "ປິດໄວ້"
                End If

                .Rows.Add(dt.Rows(i).Item("class_id"), (i + 1), _
                         (dt.Rows(i).Item("scheme_des_la") & " (" & dt.Rows(i).Item("course_des_la") & ")"), _
                         (dt.Rows(i).Item("term_no") & " (" & dt.Rows(i).Item("term_des") & ")"), _
                         (dt.Rows(i).Item("class_code") & " (" & dt.Rows(i).Item("class_des") & ")"), _
                          dt.Rows(i).Item("learning_shift_des"), st, dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_edit.Enabled = True
            Else
                btn_edit.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmClass_add.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmClass_edit.ShowDialog()
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call getTermList(cb_course.SelectedValue)
            Call LoadData()
        End If
    End Sub

    Private Sub cb_term_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_term.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

End Class