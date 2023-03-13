Public Class FrmUserGroup_view

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).modify_user = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        Call LoadData()
    End Sub

    Public Sub LoadData()
        Sql = "SELECT user_group_id, user_group_code, user_group_des ,"
        Sql &= " (SELECT COUNT(em_id) FROM tbl_user WHERE(user_group_id = tbl_user_group.user_group_id)) AS numberof_user, last_update ,user_update "
        Sql &= " FROM tbl_user_group "
        Sql &= " WHERE(group_status=1) ORDER BY user_group_code "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                .Rows.Add(dt.Rows(i).Item("user_group_id"), (i + 1), dt.Rows(i).Item("user_group_code"), dt.Rows(i).Item("user_group_des"), dt.Rows(i).Item("numberof_user"), dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_edit.Enabled = True
                btn_disable.Enabled = True
                If (.Rows(0).Cells(4).Value = 0) Then 'Not have user in group, is can delete
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
        Dim screenH As Integer = Screen.PrimaryScreen.Bounds.Height
        FrmUserGroup_add.Height = screenH
        FrmUserGroup_add.ShowDialog()
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        If (Datagridview1.RowCount > 0) Then
            btn_disable.Enabled = False
            If (Datagridview1.CurrentRow.Cells(4).Value = 0) Then 'Not have user in group, is can delete
                btn_disable.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        If MessageBox.Show("Are you sure want to delete this user group?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM tbl_user_group "
            Sql &= " WHERE (user_group_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ");" & vbNewLine

            Sql &= "DELETE FROM tbl_user_group_permission "
            Sql &= " WHERE (user_group_id=" & CInt(Datagridview1.CurrentRow.Cells(0).Value) & ");" & vbNewLine
            Call ExecuteUpdate(Sql)

            MessageBox.Show("User Group deleted!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LoadData()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call OpenEditForm()
    End Sub

    Private Sub OpenEditForm()
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmUserGroup_edit.txt_groupname.Text = CStr(Datagridview1.CurrentRow.Cells(2).Value)
        FrmUserGroup_edit.txt_group_des.Text = CStr(Datagridview1.CurrentRow.Cells(3).Value)
        FrmUserGroup_edit.lb_count_useringroup.Text = "User In Group: [" & CInt(Datagridview1.CurrentRow.Cells(4).Value) & " User(s)]"
        Dim screenH As Integer = Screen.PrimaryScreen.Bounds.Height
        FrmUserGroup_edit.Height = screenH
        FrmUserGroup_edit.ShowDialog()
        FrmUserGroup_edit.BringToFront()
    End Sub

End Class