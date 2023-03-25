Public Class FrmSale_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).sale_product = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        chk_active.Checked = True
        chk_cancel.Checked = False
        Call LoadData()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct_active As String = ""
        Dim ct_cal As String = ""
        If (chk_active.Checked = False) Then
            ct_active = " AND (bill_status<>1)"
        End If
        If (chk_cancel.Checked = False) Then
            ct_cal = " AND (bill_status<>0)"
        End If

        Dim ct_search As String = ""
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((bill_id LIKE N'%" & txt_search.Text.Trim & "%') OR (sell_by_user LIKE N'%" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT TOP(40) 0, bill_id ,sell_date ,sell_by_user ,sell_by_user_id ,payment_type ,bill_total, cnl_remark, bill_status "
        Sql &= " FROM view_sale_product_bill "
        Sql &= " WHERE(bill_id IS NOT NULL) " & ct_search & ct_active & ct_cal
        Sql &= " ORDER BY bill_id"
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                'Payment
                Dim sex As String = "ຮັບເງິນສົດ"
                If (dt.Rows(i).Item("payment_type") = 2) Then
                    sex = "ຮັບເງິນໂອນ"
                End If

                .Rows.Add((i + 1), dt.Rows(i).Item("sell_date"), dt.Rows(i).Item("bill_id"), _
                         dt.Rows(i).Item("bill_total"), sex, dt.Rows(i).Item("sell_by_user"), dt.Rows(i).Item("cnl_remark"), dt.Rows(i).Item("bill_status"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_print.Enabled = True
                btn_edit.Enabled = False
                If (.Rows(0).Cells(7).Value = 1) Then
                    btn_edit.Enabled = True
                End If
            Else
                btn_edit.Enabled = False
                btn_print.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmSale.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        BILL_ID = Datagridview1.CurrentRow.Cells(2).Value
        FrmSaleCancelReason.txt_inv.Text = BILL_ID
        FrmSaleCancelReason.txt_total.Text = FormatNumber(Datagridview1.CurrentRow.Cells(3).Value, 0, TriState.True)
        FrmSaleCancelReason.txt_reason.Select()
        FrmSaleCancelReason.ShowDialog()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        BILL_ID = Datagridview1.CurrentRow.Cells(2).Value
        rpt_status = 6
        Rpt_OnlyView = 1
        FrmReport_A5.ShowDialog()
    End Sub

    Private Sub chk_active_CheckedChanged(sender As Object, e As EventArgs) Handles chk_active.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub chk_cancel_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cancel.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        If (load_finishied = 0) Then
            With Datagridview1
                If (.RowCount > 0) Then
                    btn_print.Enabled = True
                    btn_edit.Enabled = False
                    If (.CurrentRow.Cells(7).Value = 1) Then
                        btn_edit.Enabled = True
                    End If
                Else
                    btn_edit.Enabled = False
                    btn_print.Enabled = False
                End If
            End With
        End If

    End Sub

End Class