Public Class FrmReport_A5

    Private Sub PrintBill_Enroll_A5()
        Sql = "SELECT * FROM view_std_enroll "
        Sql &= " WHERE(enroll_inv_id = '" & BILL_ID & "') "
        dt = ExecuteDatable(Sql)
        Dim cr As New BILL_ENROLL
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("user_print", User_name)
        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5

        'If only view no print
        If (Rpt_OnlyView = 0) Then
            Try
                cr.PrintOptions.PrinterName = My.Settings.setting_printer_enroll
                cr.PrintToPrinter(print_copy_bill_enroll, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Not found printer name: " & My.Settings.setting_printer_enroll & "", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub PrintBill_Register_A5()
        Sql = "SELECT * FROM view_std_register "
        Sql &= reg_number_of_term_where
        dt = ExecuteDatable(Sql)
        Dim cr As New BILL_REGISTER
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("user_print", User_name)
        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5

        'If only view no print
        If (Rpt_OnlyView = 0) Then
            Try
                cr.PrintOptions.PrinterName = My.Settings.setting_printer_register
                cr.PrintToPrinter(print_copy_bill_register, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Not found printer name: " & My.Settings.setting_printer_register & "", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub PrintBill_RegisterUpgrade_A5()
        Sql = "SELECT * FROM view_register_upgrade "
        Sql &= reg_number_of_term_where
        dt = ExecuteDatable(Sql)
        Dim cr As New BILL_REGISTER_UPGRADE
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("user_print", User_name)
        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5

        'If only view no print
        If (Rpt_OnlyView = 0) Then
            Try
                cr.PrintOptions.PrinterName = My.Settings.setting_printer_register
                cr.PrintToPrinter(print_copy_bill_register, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Not found printer name: " & My.Settings.setting_printer_register & "", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub PrintBill_RegisterTrainingTest_A5()
        Sql = "SELECT * FROM view_register_upgrade "
        Sql &= reg_number_of_term_where
        dt = ExecuteDatable(Sql)
        Dim cr As New BILL_REGISTER
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("user_print", User_name)
        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5

        'If only view no print
        If (Rpt_OnlyView = 0) Then
            Try
                cr.PrintOptions.PrinterName = My.Settings.setting_printer_register
                cr.PrintToPrinter(print_copy_bill_register, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Not found printer name: " & My.Settings.setting_printer_register & "", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub PrintBill_RegisterTraining_A5()
        Sql = "SELECT * FROM view_register_upgrade "
        Sql &= reg_number_of_term_where
        dt = ExecuteDatable(Sql)
        Dim cr As New BILL_REGISTER
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("user_print", User_name)
        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5

        'If only view no print
        If (Rpt_OnlyView = 0) Then
            Try
                cr.PrintOptions.PrinterName = My.Settings.setting_printer_register
                cr.PrintToPrinter(print_copy_bill_register, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Not found printer name: " & My.Settings.setting_printer_register & "", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub PrintBill_SaleBook_A5()
        Sql = "SELECT * FROM view_sale_product "
        Sql &= "WHERE(bill_id='" & BILL_ID & "')"
        dt = ExecuteDatable(Sql)
        Dim cr As New BILL_SELL_BOOK
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("user_print", User_name)
        cr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5

        'If only view no print
        If (Rpt_OnlyView = 0) Then
            Try
                cr.PrintOptions.PrinterName = My.Settings.setting_printer_sell
                cr.PrintToPrinter(print_copy_bill_sell, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Not found printer name: " & My.Settings.setting_printer_register & "", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub FrmReport_A5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (rpt_status = 1) Then
            Call PrintBill_Enroll_A5()
        End If
        If (rpt_status = 2) Then
            Call PrintBill_Register_A5()
        End If
        If (rpt_status = 3) Then
            Call PrintBill_RegisterUpgrade_A5()
        End If
        If (rpt_status = 4) Then
            Call PrintBill_RegisterTrainingTest_A5()
        End If
        If (rpt_status = 5) Then
            Call PrintBill_RegisterTraining_A5()
        End If
        If (rpt_status = 6) Then
            Call PrintBill_SaleBook_A5()
        End If

    End Sub

End Class