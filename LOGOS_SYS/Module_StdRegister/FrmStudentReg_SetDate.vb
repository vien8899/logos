Imports System.Data.SqlClient

Public Class FrmStudentReg_SetDate

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        calendar_test.MinDate = CDate(cur_date)
        calendar_test.SetSelectionRange(CDate(My.Settings.default_learn_date), CDate(My.Settings.default_learn_date))
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub calendar_test_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar_test.DateChanged
        lb_test_date.Text = calendar_test.SelectionStart.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        My.Settings.default_learn_date = CDate(lb_test_date.Text)
        My.Settings.Save()
        Call FrmStudentRegister_add.SetTestDate()
        Call FrmStudentRegister_Second.SetTestDate()
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

End Class