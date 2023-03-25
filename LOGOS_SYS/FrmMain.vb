Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userlb.Caption = User_Fullname
        pnlmain.Hide()
        mainMenu.Visible = False

        FrmLogin.ShowDialog()
        If FrmLogin.DialogResult = DialogResult.Cancel Then
            Environment.Exit(1)
        Else
            pnlmain.Show()
            mainMenu.Visible = True
        End If
    End Sub

    Private Sub PermissionChk()
        'Permission-Check
        If (user_permission.Item(0).view_report = 0) Then
            btnReport.Enabled = False
        End If
    End Sub

    Private Sub btnManagedata_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnManagedata.ItemClick
        frmMain_Setting.ShowDialog()
    End Sub

    Private Sub btnSetScore_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSetScore.ItemClick
        FrmScore_Import.ShowDialog()
    End Sub

    Private Sub btnLogout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLogout.ItemClick
        pnlmain.Hide()
        mainMenu.Visible = False
        FrmLogin.txtusername.Text = ""
        FrmLogin.txtpassword.Text = ""
        FrmLogin.txtusername.Select()
        FrmLogin.ShowDialog()
        If FrmLogin.DialogResult = DialogResult.Cancel Then
            Environment.Exit(1)
        Else
            pnlmain.Show()
            mainMenu.Visible = True
        End If
    End Sub

    Private Sub btnSetting_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSetting_College.ItemClick
        FrmCompanyInfo.ShowDialog()
    End Sub

    Private Sub btnSetting_Grade_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSetting_Grade.ItemClick
        FrmSetGrade_view.ShowDialog()
    End Sub

    Private Sub btnEnroll_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnEnroll.ItemClick
        FrmStudentEnroll_view.ShowDialog()
        FrmStudentEnroll_view.txt_search.Select()
    End Sub

    Private Sub btnRegister_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnRegister.ItemClick
        FrmStudentRegister_view.ShowDialog()
        FrmStudentRegister_view.txt_search.Select()
    End Sub

    Private Sub btn_Trainning_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_Trainning.ItemClick
        frmMain_Trainning.ShowDialog()
    End Sub

    Private Sub btnReport_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnReport.ItemClick
        frmMain_Report.ShowDialog()
    End Sub

    Private Sub btnViewScore_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnViewScore.ItemClick
        FrmScore_view.ShowDialog()
    End Sub

    Private Sub btnViewStudent_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnViewStudent.ItemClick
        FrmStudent_view.ShowDialog()
        FrmStudent_view.txt_search.Select()
    End Sub

    Private Sub btnSale_Book_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSale_Book.ItemClick
        FrmSale_view.ShowDialog()
        FrmSale_view.txt_search.Select()
    End Sub

    Private Sub btnTestResult_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnTestResult.ItemClick
        FrmStdDrop_view.ShowDialog()
        FrmStdDrop_view.txt_search.Select()
    End Sub

End Class