Public Class frmMain_Report

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

    Private Sub btnManageGroup_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        'FrmUserGroup_view.ShowDialog()
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        Frm_Report_Register.ShowDialog()
    End Sub

    Private Sub btn_receive_enroll_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_receive_enroll.ItemClick
        Frm_Report_Enroll.ShowDialog()
    End Sub

    Private Sub btn_receive_register_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_receive_register.ItemClick
        Frm_Report_Enroll_train.ShowDialog()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        Frm_Report_Register_train.ShowDialog()
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        Frm_Report_Register_Upgrade.ShowDialog()
    End Sub

    Private Sub btn_debt_term_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_debt_term.ItemClick
        Cursor = Cursors.WaitCursor
        Sql = "SELECT * FROM view_std_register "
        Sql &= " WHERE(sum_term_paid < (register_amount-register_discount))"
        Sql &= " ORDER BY scheme_id, course_id, term_list_id, student_fullname_la "
        dt = ExecuteDatable(Sql)
        Dim crt As New Rpt_StudentDebt
        crt.SetDataSource(dt)

        crt.SetParameterValue("user_print", User_name)
        crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        'Show Report
        FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        FrmReport_A4.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub btn_drop_term_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_drop_term.ItemClick
        Frm_Report_DropList.ShowDialog()
    End Sub

    Private Sub btn_sale_product_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_sale_product.ItemClick
        Frm_Report_BookSale.ShowDialog()
    End Sub

    Private Sub btn_student_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_student.ItemClick
        Frm_Report_Student_Normal.ShowDialog()
    End Sub

    Private Sub btn_student_trainning_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_student_trainning.ItemClick
        Frm_Report_Student_train.ShowDialog()
    End Sub

    Private Sub btn_score_inform_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_score_inform.ItemClick

    End Sub

End Class