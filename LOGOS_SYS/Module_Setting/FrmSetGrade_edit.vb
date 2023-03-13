Imports System.Data.SqlClient

Public Class FrmSetGrade_edit

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmSetGrade_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = True
        If (user_permission.Item(0).modify_course = 0) Then
            btn_save.Enabled = False
        End If
        had_change_val = 0
        load_finished = 1
        Call load_data()
        load_finished = 0
    End Sub
    Dim load_finished As Integer = 1

    Private Sub load_data()
        Sql = " SELECT score_id ,score_start ,score_end ,score_grade ,score_gpa ,score_grade_des ,last_update ,user_update "
        Sql &= " FROM tbl_setting_grade "
        Sql &= " WHERE(score_id=" & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_desc.Text = .Item("score_grade_des")
            txt_start.Text = Format(.Item("score_start"), "N0")
            txt_end.Text = Format(.Item("score_end"), "N0")
            txt_grade.Text = .Item("score_grade")
            txt_GPA.Text = .Item("score_gpa")
        End With
    End Sub

    Private Sub edit_user()
        If (txt_start.Text.Trim = "") Then
            MessageBox.Show("Score start range is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_start.Focus()
            Exit Sub
        End If
        If (CInt(txt_start.Text.Trim) < 0) Or (CInt(txt_start.Text.Trim) > 100) Then
            MessageBox.Show("Score should be from [0-100].", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_start.Focus()
            Exit Sub
        End If
        If (txt_end.Text.Trim = "") Then
            MessageBox.Show("Score end range is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_end.Focus()
            Exit Sub
        End If
        If (CInt(txt_end.Text.Trim) < 0) Or (CInt(txt_end.Text.Trim) > 100) Then
            MessageBox.Show("Score should be from [0-100].", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_end.Focus()
            Exit Sub
        End If
        If (txt_grade.Text.Trim = "") Then
            MessageBox.Show("Grade is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_grade.Focus()
            Exit Sub
        End If
        If (txt_GPA.Text.Trim = "") Then
            MessageBox.Show("GPA is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_GPA.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txt_GPA.Text) Then
            MessageBox.Show("GPA should be [F=0, D=1, D+=1.5, C=2, C+=2.5, B=3, B+=3.5, A=4]", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_GPA.Focus()
            Exit Sub
        End If
        If (CInt(txt_GPA.Text.Trim) < 0) Or (CInt(txt_GPA.Text.Trim) > 4) Then
            MessageBox.Show("GPA should be [F=0, D=1, D+=1.5, C=2, C+=2.5, B=3, B+=3.5, A=4]", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_GPA.Focus()
            Exit Sub
        End If
       
        Call ConnectDB()
        Sql = "UPDATE tbl_setting_grade SET score_start=@score_start ,score_end=@score_end ,"
        Sql &= " score_grade=@score_grade ,score_gpa=@score_gpa ,score_grade_des=@score_grade_des, user_update=@user_update, last_update=getdate() "
        Sql &= " WHERE(score_id = @id_edit)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("id_edit", id_edit)
        cm.Parameters.AddWithValue("score_start", CDbl(txt_start.Text.Trim))
        cm.Parameters.AddWithValue("score_end", CDbl(txt_end.Text.Trim))
        cm.Parameters.AddWithValue("score_grade", txt_grade.Text.Trim)
        cm.Parameters.AddWithValue("score_gpa", CDbl(txt_GPA.Text.Trim))
        cm.Parameters.AddWithValue("score_grade_des", CStr(txt_desc.Text.Trim))
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Edit completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call edit_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub txt_amount_regis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_start.KeyPress, txt_end.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric only...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_amount_regis_Leave(sender As Object, e As EventArgs) Handles txt_GPA.Leave
        If (txt_start.Text.Trim = "") Then
            txt_start.Text = "0"
        End If
        txt_start.Text = Format(CDbl(txt_start.Text), "N1")
    End Sub

End Class