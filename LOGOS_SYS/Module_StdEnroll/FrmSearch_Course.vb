Public Class FrmSearch_Course

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        Call LoadData()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Sql = " SELECT course_id ,course_des_la, course_des_en ,course_test_amount ,scheme_id ,scheme_des_la "
        Sql &= " FROM view_course_list "
        Sql &= " WHERE(course_status = 1) "
        Sql &= " ORDER BY scheme_id, course_id "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("course_id"), (i + 1), dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]", dt.Rows(i).Item("course_test_amount"), dt.Rows(i).Item("scheme_id"))
            Next
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Public course_id, full_course, course_test_amt, scheme_id As String
    Private Sub Datagridview1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datagridview1.CellMouseClick
        If Datagridview1.RowCount > 0 Then
            course_id = Datagridview1.CurrentRow.Cells(0).Value.ToString()
            course_test_amt = Datagridview1.CurrentRow.Cells(3).Value.ToString()
            full_course = Datagridview1.CurrentRow.Cells(2).Value.ToString()
            scheme_id = Datagridview1.CurrentRow.Cells(4).Value.ToString()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class