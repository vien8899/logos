Public Class FrmSetGrade_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        Call LoadData()
    End Sub

    Public Sub LoadData()
        Sql = " SELECT score_id ,score_start ,score_end ,score_grade ,score_gpa ,score_grade_des ,last_update ,user_update "
        Sql &= " FROM tbl_setting_grade "
        Sql &= " ORDER BY score_start DESC "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("score_id"), (i + 1), "ຄະແນນແຕ່ [ " & dt.Rows(i).Item("score_start") & " - " & dt.Rows(i).Item("score_end") & " ]", _
                          dt.Rows(i).Item("score_grade"), dt.Rows(i).Item("score_gpa"), dt.Rows(i).Item("score_grade_des"), dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Datagridview1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellContentClick
        If e.ColumnIndex = 2 Then
            id_edit = Datagridview1.CurrentRow.Cells(0).Value
            FrmSetGrade_edit.ShowDialog()
        End If
    End Sub

End Class