Imports System.Data.SqlClient

Public Class FrmProduct_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmProduct_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        load_finished = 1
        Call first_load()
        load_finished = 0
    End Sub

    Dim load_finished As Integer = 1
    Private Sub first_load()
        Call clear_text()
        Call load_data()
    End Sub

    Private Sub load_data()
        Sql = "SELECT product_id ,product_name_la ,product_name_en ,sell_price ,sell_status ,last_update ,user_update "
        Sql &= " FROM tbl_product"
        Sql &= " WHERE(product_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_course_la.Text = .Item("product_name_la")
            txt_course_en.Text = .Item("product_name_en")
            txt_amount_regis.Text = Format(.Item("sell_price"), "N0")

            'Status
            If (.Item("sell_status") = 1) Then
                rdo_active.Checked = True
            Else
                rdo_disabled.Checked = True
            End If
        End With
    End Sub

    Private Sub clear_text()
        txt_course_la.Text = ""
        txt_course_en.Text = ""
        txt_amount_regis.Text = "0"
        txt_course_la.Select()
    End Sub

    Private Sub edit_user()
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

        Dim user_status As Integer = 0
        If (rdo_active.Checked = True) Then
            user_status = 1
        End If

        Call ConnectDB()
        Sql = "UPDATE tbl_product SET product_name_la=@product_name_la ,product_name_en=@product_name_en ,"
        Sql &= " sell_price=@sell_price ,sell_status=@sell_status ,user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(product_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("product_name_la", txt_course_la.Text.Trim)
        cm.Parameters.AddWithValue("product_name_en", txt_course_en.Text.Trim)
        cm.Parameters.AddWithValue("sell_status", user_status)
        cm.Parameters.AddWithValue("sell_price", CDbl(txt_amount_regis.Text.Trim))
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit product completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call edit_user()
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