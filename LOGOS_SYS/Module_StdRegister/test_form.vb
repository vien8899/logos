Public Class test_form

    Private Sub test_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = New DataTable()
        Dim column1 As DataColumn = New DataColumn("check")
        column1.DataType = System.Type.GetType("System.Int32")
        Dim column2 As DataColumn = New DataColumn("term")
        column2.DataType = System.Type.GetType("System.String")
        Dim column3 As DataColumn = New DataColumn("enable")
        column3.DataType = System.Type.GetType("System.Int32")

        dt.Columns.Add(column1)
        dt.Columns.Add(column2)
        dt.Columns.Add(column3)
        For index As Integer = 1 To 8
            Dim row As DataRow
            row = dt.NewRow()

            row.Item("term") = "Term " & index
            If index > 4 Then
                row.Item("check") = 0
                row.Item("enable") = 1
            Else
                row.Item("check") = 1
                row.Item("enable") = 0
            End If
            dt.Rows.Add(row)
        Next
        DGV.DataSource = dt
        DGV.ReadOnly = False
        Dim checked_num As Integer = 0
        For Each row As DataGridViewRow In DGV.Rows
            If (row.Cells(2).Value = 0) Then
                checked_num += 1
            End If
        Next
        For Each row As DataGridViewRow In DGV.Rows
            If (row.Index > checked_num) Then
                DGV.Rows(row.Index).ReadOnly = True
                DGV.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Gray
            End If
        Next
    End Sub

    Private Sub DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DGV.RowPostPaint

        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells(2).Value = 0 Then
                DGV.Rows(row.Index).ReadOnly = True
                DGV.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Gray
                DGV.Rows(row.Index).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub DGV_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseUp
        DGV.EndEdit()
        If DGV.Rows(e.RowIndex).Cells(0).Value.ToString() = "" Then
            DGV.Rows(e.RowIndex).Cells(0).Value = 0
        End If
        If e.ColumnIndex = 0 Then
            If Not DGV.Rows(e.RowIndex).Cells(0).Value.ToString() = "0" Then
                If Not (e.RowIndex + 1) = DGV.Rows.Count AndAlso Not DGV.Rows(e.RowIndex + 1).Cells(0).Value.ToString() = "1" Then
                    DGV.Rows(e.RowIndex + 1).ReadOnly = False
                    DGV.Rows(e.RowIndex + 1).DefaultCellStyle.ForeColor = Color.Black
                End If
                If Not e.RowIndex = 0 Then
                    DGV.Rows(e.RowIndex - 1).ReadOnly = True
                    DGV.Rows(e.RowIndex - 1).DefaultCellStyle.ForeColor = Color.Gray
                End If
            Else
                If Not e.RowIndex = 0 Then
                    If Not DGV.Rows(e.RowIndex - 1).Cells(2).Value = 0 AndAlso Not DGV.Rows(e.RowIndex - 1).Cells(0).Value.ToString() = "0" Then
                        DGV.Rows(e.RowIndex - 1).ReadOnly = False
                        DGV.Rows(e.RowIndex - 1).DefaultCellStyle.ForeColor = Color.Black
                    End If
                End If
                If Not (e.RowIndex + 1) = DGV.Rows.Count Then
                    DGV.Rows(e.RowIndex + 1).ReadOnly = True
                    DGV.Rows(e.RowIndex + 1).DefaultCellStyle.ForeColor = Color.Gray
                End If
            End If
        End If
    End Sub
End Class