Public Class FrmStdDropTerm_select

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        Call LoadData()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Sql = " SELECT term_list_id ,term_no ,term_no_la "
        Sql &= " FROM view_term_list "
        Sql &= select_term_where
        Sql &= " ORDER BY term_list_id "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("term_list_id"), (i + 1), dt.Rows(i).Item("term_no_la") & " (" & dt.Rows(i).Item("term_no") & ")", "ລົງທະບຽນແລ້ວ")
            Next
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Public t_id, t_code As String
    Private Sub Datagridview1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datagridview1.CellMouseClick
        If Datagridview1.RowCount > 0 Then
            t_id = Datagridview1.CurrentRow.Cells(0).Value.ToString()
            t_code = Datagridview1.CurrentRow.Cells(2).Value.ToString()

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class