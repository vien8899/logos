Imports System.Data.SqlClient

Public Class FrmProduct_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmProduct_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call clear_text()
    End Sub

    Private Sub clear_text()
        txt_course_la.Text = ""
        txt_course_en.Text = ""
        txt_amount_regis.Text = "0"

        txt_course_la.Select()
    End Sub

    Private Sub add_new_user()
        If (CStr(txt_course_la.Text.Trim) = "") Then
            MessageBox.Show("Product name (la) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_course_la.Focus()
            Exit Sub
        End If
        If (txt_course_en.Text.Trim = "") Then
            MessageBox.Show("Product name (en) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_course_en.Focus()
            Exit Sub
        End If

        Call ConnectDB()
        Sql = "INSERT INTO tbl_product(product_name_la ,product_name_en ,sell_price ,sell_status ,user_update) "
        Sql &= " VALUES(@product_name_la ,@product_name_en ,@sell_price ,@sell_status ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("product_name_la", txt_course_la.Text.Trim)
        cm.Parameters.AddWithValue("product_name_en", txt_course_en.Text.Trim)
        cm.Parameters.AddWithValue("sell_price", CDbl(txt_amount_regis.Text.Trim))
        cm.Parameters.AddWithValue("sell_status", 1)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add new product completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Call clear_text()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub txt_amount_regis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount_regis.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_amount_regis_Leave(sender As Object, e As EventArgs) Handles txt_amount_regis.Leave
        If (txt_amount_regis.Text.Trim = "") Then
            txt_amount_regis.Text = "0"
        End If
        txt_amount_regis.Text = Format(CDbl(txt_amount_regis.Text), "N0")
    End Sub

End Class