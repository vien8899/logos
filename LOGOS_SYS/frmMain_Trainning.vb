Public Class frmMain_Trainning

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

    Private Sub btnManageGroup_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        'FrmUserGroup_view.ShowDialog()
    End Sub

    Private Sub btn_train_openReg_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_train_openReg.ItemClick
        'de_or_se = 2
        FrmReg_Open_Closed_view.ShowDialog()
    End Sub

End Class