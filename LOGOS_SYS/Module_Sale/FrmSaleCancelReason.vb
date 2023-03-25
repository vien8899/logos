Imports System.Data.SqlClient

Public Class FrmSaleCancelReason

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_reason.Text = ""
        txt_reason.Select()
    End Sub

    Private Sub add_new_user()
        If (CStr(txt_reason.Text.Trim) = "") Then
            MessageBox.Show("ກະລຸນາໃສ່ເຫດຜົນການຍົກເລີບບິນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_reason.Focus()
            Exit Sub
        End If

        'If MessageBox.Show("Are you sure want print bill?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        Dim rm As String = "Cancelled By: " & User_name & ", Date: " & Now.Date & ", ສາເຫດຍົກເລີກ: " & vbNewLine & txt_reason.Text.Trim
        Sql = "UPDATE tbl_product_sell SET bill_status=0, cnl_remark= N'" & rm & "' "
        Sql &= " WHERE (bill_id ='" & txt_inv.Text & "')"
        Call ExecuteUpdate(Sql)

        MessageBox.Show("Bill deleted!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Call FrmSale_view.LoadData()
        'End If
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

End Class