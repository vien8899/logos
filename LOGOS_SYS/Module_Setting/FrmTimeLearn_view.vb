Public Class FrmTimeLearn_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).modify_learning_shift = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        Call getCourseList()
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

    Public Sub LoadData()
        Dim ct_course As String = ""
        If (cb_course.SelectedValue <> 0) Then
            ct_course = " AND (course_id = " & cb_course.SelectedValue & ")"
        End If

        Sql = "SELECT learning_shift_id ,learning_shift_des ,course_id ,course_des_la ,course_des_en ,"
        Sql &= " scheme_id ,scheme_des_la ,scheme_des_en ,learning_shift_status ,last_update ,user_update"
        Sql &= " FROM view_timelearn_list"
        Sql &= " WHERE(learning_shift_id > 0) " & ct_course
        Sql &= " ORDER BY scheme_id, course_id, learning_shift_des "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("learning_shift_id"), (i + 1), (dt.Rows(i).Item("scheme_des_la") & " (" & dt.Rows(i).Item("course_des_la") & ")"), dt.Rows(i).Item("learning_shift_des"), _
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
        FrmTimeLearn_add.ShowDialog()
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        'Check for using class info
        Sql = "SELECT learning_shift_id FROM tbl_setting_class WHERE(learning_shift_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ")"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("This info is using for class. Cannot delete!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure want to delete this info?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM tbl_setting_learning_shift "
            Sql &= " WHERE (learning_shift_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ")"
            Call ExecuteUpdate(Sql)

            MessageBox.Show("Info had delete!!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LoadData()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmTimeLearn_edit.ShowDialog()
    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

End Class