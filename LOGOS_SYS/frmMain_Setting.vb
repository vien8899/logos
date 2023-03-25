Public Class frmMain_Setting

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

    Private Sub btnManageGroup_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnManageGroup.ItemClick
        FrmUserGroup_view.ShowDialog()
    End Sub

    Private Sub btnEmp_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnEmp.ItemClick
        FrmUser_view.ShowDialog()
    End Sub

    Private Sub tileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileItem2.ItemClick
        FrmScheme_view.ShowDialog()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        FrmCourse_view.ShowDialog()
    End Sub

    Private Sub btnSetting_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSetting.ItemClick
        FrmTerm_view.ShowDialog()
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        FrmSubject_view.ShowDialog()
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        FrmTermSubject_view.ShowDialog()
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
        FrmTimeLearn_view.ShowDialog()
    End Sub

    Private Sub btnPermision_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnPermision.ItemClick
        FrmClass_view.ShowDialog()
    End Sub

    Private Sub btnDEclass_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnDEclass.ItemClick
        FrmProduct_view.ShowDialog()
    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem7.ItemClick
        'de_or_se = 1
        FrmReg_Open_Closed_view.ShowDialog()
    End Sub

End Class