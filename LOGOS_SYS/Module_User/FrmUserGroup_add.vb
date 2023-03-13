Public Class FrmUserGroup_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmUserGroup_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0
        Call loadPermission_List()
        Call clear_text()
    End Sub
    Private Sub loadPermission_List()
        Datagridview1.Rows.Clear()
        Sql = "SELECT default_checked, permission_code ,permission_des ,module_code ,permission_id "
        Sql &= " FROM tbl_user_permission_list"
        Sql &= " ORDER BY permission_id "
        dt = ExecuteDatable(Sql)
        For i As Integer = 0 To dt.Rows.Count - 1
            Datagridview1.Rows.Add(CInt(dt.Rows(i).Item("default_checked")), dt.Rows(i).Item("permission_code"), dt.Rows(i).Item("permission_des"), dt.Rows(i).Item("module_code"), dt.Rows(i).Item("permission_id"))
        Next
    End Sub

    Private Sub clear_text()
        txt_groupname.Text = ""
        txt_group_des.Text = ""
        txt_groupname.Select()
    End Sub

    Private Sub add_new_group()
        If (CStr(txt_groupname.Text.Trim) = "") Then
            MessageBox.Show("Group name is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_groupname.Focus()
            Exit Sub
        ElseIf (txt_group_des.Text = "") Then
            MessageBox.Show("Group Description is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_group_des.Focus()
            Exit Sub
        End If

        Sql = "INSERT INTO tbl_user_group(user_group_code ,user_group_des ,group_status, user_update) "
        Sql &= " VALUES(N'" & Trim(txt_groupname.Text) & "', N'" & Trim(txt_group_des.Text) & "', 1, N'" & User_name & "') "
        Call ExecuteInsert(Sql)

        Sql = "SELECT MAX(user_group_id) AS max_id FROM tbl_user_group "
        Dim max_group_id As Integer = MAX_ID(Sql)

        Sql = ""
        For Each row As DataGridViewRow In Datagridview1.Rows
            If CInt(row.Cells(0).Value) <> 0 Then
                Sql &= "INSERT INTO tbl_user_group_permission(user_group_id ,permission_id) VALUES(" & max_group_id & ", " & CInt(row.Cells(4).Value) & "); " & vbNewLine
            End If
        Next
        Call ExecuteInsert(Sql)

        MessageBox.Show("Add new user group completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1

        Call loadPermission_List()
        Call clear_text()
        'Me.Close()
    End Sub

    Function MAX_ID(ByVal cmd As String) As Integer
        dt = ExecuteDatable(cmd)
        Return CInt(dt.Rows(0).Item("max_id"))
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_group()
    End Sub

End Class