Public Class FrmScheme_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).modify_scheme = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        chk_show_disable.Checked = False
        txt_search.Text = ""
        Call LoadData()
        txt_search.Focus()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct_active As String = ""
        Dim ct_search As String = ""
        If (chk_show_disable.Checked = False) Then
            ct_active = " AND (scheme_status <> 0)"
        End If
        If (txt_search.Text.Trim <> "") Then
            ct_active = " AND ((scheme_des_la LIKE N'%" & txt_search.Text.Trim & "%') OR (scheme_des_en LIKE N'%" & txt_search.Text.Trim & "%'))"
        End If


        Sql = " SELECT scheme_id ,scheme_des_la, scheme_des_en, scheme_status ,last_update ,user_update"
        Sql &= " FROM tbl_setting_scheme "
        Sql &= " WHERE(scheme_id> 0 ) " & ct_active & ct_search
        Sql &= " ORDER BY scheme_des_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim st As String = "ໃຊ້ງານ"
                If (dt.Rows(i).Item("scheme_status") = 0) Then
                    st = "ປິດໄວ້"
                End If

                .Rows.Add(dt.Rows(i).Item("scheme_id"), (i + 1), dt.Rows(i).Item("scheme_des_la") & " (" & dt.Rows(i).Item("scheme_des_en") & ")", st, dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_edit.Enabled = True
                btn_disable.Enabled = False
                If (.Rows(0).Cells(3).Value = "ໃຊ້ງານ") Then 'Can disable omnly active user
                    btn_disable.Enabled = True
                End If
            Else
                btn_edit.Enabled = False
                btn_disable.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmScheme_add.ShowDialog()
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        If MessageBox.Show("Are you sure want to disable this info?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE tbl_setting_scheme SET scheme_status=0 "
            Sql &= " WHERE (scheme_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ")"
            Call ExecuteUpdate(Sql)

            MessageBox.Show("Info had disabled", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LoadData()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmScheme_edit.ShowDialog()
    End Sub

    Private Sub chk_show_disable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_show_disable.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        If (Datagridview1.RowCount > 0) Then
            btn_disable.Enabled = False
            If (Datagridview1.CurrentRow.Cells(3).Value = "ໃຊ້ງານ") Then 'Can disable omnly active user
                btn_disable.Enabled = True
            End If
        End If
    End Sub

End Class