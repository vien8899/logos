Public Class FrmTermSubject_select

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        txt_search.Text = ""
        Call LoadData()
        txt_search.Focus()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct_search As String = ""
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((subject_code LIKE N'" & txt_search.Text.Trim & "%') OR (subject_name_la LIKE N'%" & txt_search.Text.Trim & "%') OR (subject_name_en LIKE N'%" & txt_search.Text.Trim & "%'))"
        End If

        Sql = " SELECT subject_id ,subject_code ,subject_name_la ,subject_name_en ,subject_status ,last_update ,user_update, subject_credit, subject_upgrade_price "
        Sql &= " FROM tbl_setting_subject"
        Sql &= " WHERE(subject_status <> 0 ) " & ct_search & subject_filter
        Sql &= " ORDER BY subject_code, subject_name_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("subject_id"), (i + 1), dt.Rows(i).Item("subject_code"), dt.Rows(i).Item("subject_name_la") & " (" & dt.Rows(i).Item("subject_name_en") & ")", dt.Rows(i).Item("subject_upgrade_price"), dt.Rows(i).Item("subject_credit"))
            Next
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Public sb_id, sb_code, sb_desc, sb_upgrade_price, sb_credit As String
    Private Sub Datagridview1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datagridview1.CellMouseClick
        If Datagridview1.RowCount > 0 Then
            sb_id = Datagridview1.CurrentRow.Cells(0).Value.ToString()
            sb_code = Datagridview1.CurrentRow.Cells(2).Value.ToString()
            sb_desc = Datagridview1.CurrentRow.Cells(3).Value.ToString()
            sb_upgrade_price = Datagridview1.CurrentRow.Cells(4).Value.ToString()
            sb_credit = Datagridview1.CurrentRow.Cells(5).Value.ToString()

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class