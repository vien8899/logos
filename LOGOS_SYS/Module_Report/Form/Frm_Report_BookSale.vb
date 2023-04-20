Public Class Frm_Report_BookSale

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        DateTimePicker2.Value = CDate(cur_date)
        Dim Last_Month As Date = DateAdd(DateInterval.Day, -180, CDate(cur_date))
        DateTimePicker1.Value = CDate(Last_Month)
        DateTimePicker2.MinDate = CDate(DateTimePicker1.Value)

        rdo_by_qty.Checked = True
        rdo_by_bill.Checked = False
        rdo_by_price.Checked = False

        chk_bt.Checked = True
        chk_cash.Checked = True

        chk_bt.Enabled = False
        chk_cash.Enabled = False
        cb_user.Enabled = False

        Call getUser()
        load_finishied = 0
    End Sub

    Private Sub getUser()
        Sql = "SELECT N'ເລືອກທັງໝົດ' AS user_name, 0 AS em_id "
        Sql &= "UNION "
        Sql &= "SELECT user_name, em_id "
        Sql &= " FROM tbl_user "
        Sql &= " ORDER BY em_id "
        dt = ExecuteDatable(Sql)
        cb_user.DataSource = dt
        cb_user.ValueMember = "em_id"
        cb_user.DisplayMember = "user_name"
        cb_user.SelectedIndex = 0
    End Sub

    Public Sub LoadData()
        Cursor = Cursors.WaitCursor
        Dim ft_date As String = "FILTER FROM DATE: " & Format(CDate(DateTimePicker1.Value.Date), "dd/MM/yyyy") & " - " & Format(CDate(DateTimePicker2.Value.Date), "dd/MM/yyyy")
        Dim s_d As String = Convert.ToDateTime(DateTimePicker1.Value.Date).ToString("yyyy-MM-dd")
        Dim e_d As String = Convert.ToDateTime(DateTimePicker2.Value.Date).ToString("yyyy-MM-dd")

        '1. By Bill
        If (rdo_by_bill.Checked = True) Then
            Dim ct_user As String = ""
            Dim cash As Integer = 1
            Dim bt As Integer = 2

            If (chk_cash.Checked = False) Then
                cash = 0
            End If
            If (chk_bt.Checked = False) Then
                bt = 0
            End If

            If (cb_user.SelectedValue <> 0) Then
                ct_user = " AND (sell_by_user_id =" & cb_user.SelectedValue & ")"
            End If
            Dim ct_payment As String = " AND (payment_type IN(" & cash & "," & bt & "))"


            Sql = "SELECT * FROM view_sale_product_bill "
            Sql &= " WHERE(sell_date BETWEEN '" & s_d & "' AND '" & e_d & "')" & ct_payment & ct_user
            Sql &= " ORDER BY sell_date "
            dt = ExecuteDatable(Sql)
            Dim crt As New Rpt_SaleBook_ByBill
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.SetParameterValue("report_title", ft_date)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
            Cursor = Cursors.Default
        End If

        '2. By Price
        If (rdo_by_price.Checked = True) Then
            Sql = "EXEC sell_by_price '" & s_d & "', '" & e_d & "'; "
            dt = ExecuteDatable(Sql)
            Dim crt As New Rpt_SaleBook_ByPrice
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.SetParameterValue("report_title", ft_date)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
            Cursor = Cursors.Default
        End If

        '3. By QTY
        If (rdo_by_qty.Checked = True) Then
            Sql = "EXEC sell_by_QTY '" & s_d & "', '" & e_d & "'; "
            dt = ExecuteDatable(Sql)
            Dim crt As New Rpt_SaleBook_ByQTY
            crt.SetDataSource(dt)

            crt.SetParameterValue("user_print", User_name)
            crt.SetParameterValue("report_title", ft_date)
            crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            'Show Report
            FrmReport_A4.CrystalReportViewer1.ReportSource = crt
            FrmReport_A4.ShowDialog()
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        Call LoadData()
    End Sub

    Private Sub btn_SetClass_Clear_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Clear.Click
        Me.Close()
    End Sub

    Private Sub rdo_by_qty_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_by_qty.CheckedChanged
        If (rdo_by_qty.Checked = True) And load_finishied = 0 Then
            chk_bt.Checked = True
            chk_cash.Checked = True
            cb_user.SelectedIndex = 0

            chk_bt.Enabled = False
            chk_cash.Enabled = False
            cb_user.Enabled = False
        End If
    End Sub

    Private Sub rdo_by_price_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_by_price.CheckedChanged
        If (rdo_by_price.Checked = True) And load_finishied = 0 Then
            chk_bt.Checked = True
            chk_cash.Checked = True
            cb_user.SelectedIndex = 0

            chk_bt.Enabled = False
            chk_cash.Enabled = False
            cb_user.Enabled = False
        End If
    End Sub

    Private Sub rdo_by_bill_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_by_bill.CheckedChanged
        If (rdo_by_bill.Checked = True) And load_finishied = 0 Then
            chk_bt.Checked = True
            chk_cash.Checked = True
            cb_user.SelectedIndex = 0

            chk_bt.Enabled = True
            chk_cash.Enabled = True
            cb_user.Enabled = True
        End If
    End Sub

End Class