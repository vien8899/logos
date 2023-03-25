Imports System.Data.SqlClient

Public Class FrmStdDrop_add

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStdDrop_view.LoadData()
        End If
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_finished = 1
        had_change_val = 0
        Call clear_text()
        load_finished = 0
    End Sub

    Dim load_finished As Integer = 1
    Dim start_year As Integer = 0
    Private Sub clear_text()
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        txt_std_code.Text = ""
        txt_name.Text = ""
        txt_name.Tag = ""
        txt_term.Text = ""
        txt_term.Tag = ""
        txt_course.Tag = ""
        txt_course.Text = ""
        txt_sokhien.Text = ""
        txt_comment.Text = ""
        btn_search_term.Enabled = False
        Dim cur_yyyy As Integer = Format(CDate(cur_date), "yyyy")
        start_year = cur_yyyy
        txt_std_code.Select()
    End Sub

    Private Sub add_new_user()
        If (txt_std_code.Text.Trim = "") Then
            MessageBox.Show("Please select student.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If
        If (txt_name.Text.Trim = "") Then
            MessageBox.Show("Please select student.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_search_std.Focus()
            Exit Sub
        End If
        If (txt_term.Text.Trim = "") Then
            MessageBox.Show("Please term need to drop.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_search_term.Focus()
            Exit Sub
        End If

        'Remark
        If (txt_comment.Text.Trim = "") Then
            MessageBox.Show("Please enter drop reason.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_comment.Focus()
            Exit Sub
        End If

        'check for dupplicate drop
        Sql = "SELECT student_id FROM tbl_student_drop WHERE(student_id=" & txt_name.Tag & ") AND (term_id=" & txt_term.Tag & ")"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("ນັກສຶກສາໄດ້ຢຸດຮຽນເທີມນີ້ແລ້ວ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If

        'check for dupplicate drop
        Sql = "SELECT student_id FROM tbl_student_drop WHERE(student_id=" & txt_name.Tag & ") AND (drop_status=1)"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 1) Then
            MessageBox.Show("ນັກສຶກສາບໍ່ສາມາດຢຸດຮຽນຫຼາຍກວ່າ 2 ເທີມ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If

        'For New Studen
        Call ConnectDB()
        Sql = "INSERT INTO tbl_student_drop(student_id ,term_id ,drop_year ,drop_des ,user_update) "
        Sql &= "                     VALUES(@student_id ,@term_id ,@drop_year ,@drop_des ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("student_id", txt_name.Tag)
        cm.Parameters.AddWithValue("term_id", txt_term.Tag)
        cm.Parameters.AddWithValue("drop_year", txt_sokhien.Text)
        cm.Parameters.AddWithValue("drop_des", CStr(txt_comment.Text.Trim))
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()

        MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_search_term.Click
        select_term_where = " WHERE(term_id IN(SELECT term_id FROM tbl_term_register WHERE(student_id=" & txt_name.Tag & "))) "

        Dim PS As Point = btn_search_term.PointToScreen(New Point(btn_search_term.Width - 5, btn_search_term.Height - 230))
        FrmStdDropTerm_select.Location = PS
        If FrmStdDropTerm_select.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_term.Tag = FrmStdDropTerm_select.t_id
            txt_term.Text = FrmStdDropTerm_select.t_code
        End If
    End Sub

    Private Sub getTermListInCourse(ByVal c As Integer)
        'Sql = "SELECT term_id ,term_no ,term_des ,register_amount ,course_id ,term_status, term_study_year "
        'Sql &= " FROM view_term_table WHERE(term_status <> 0) AND (course_id=" & c & ") "
        'Sql &= " ORDER BY term_list_id "
        'dt = ExecuteDatable(Sql)
        'Datagridview1.Rows.Clear()
        'If (dt.Rows.Count > 0) Then
        '    With Datagridview1
        '        For i As Integer = 0 To dt.Rows.Count - 1
        '            Dim money_dis As Double = 0
        '            Dim first As Boolean = True
        '            If (i > 0) Then
        '                first = False
        '            End If

        '            .Rows.Add(dt.Rows(i).Item("term_id"), first, (dt.Rows(i).Item("term_no") & "-[" & dt.Rows(i).Item("term_des") & "]"), _
        '                      dt.Rows(i).Item("register_amount"), CInt(money_dis), (start_year - 1 + CInt(dt.Rows(i).Item("term_study_year"))) & "-" & (start_year + CInt(dt.Rows(i).Item("term_study_year"))))
        '        Next

        '    End With

        '    Dim max_enable As Integer = 6
        '    If (Datagridview1.Rows.Count < 6) Then
        '        max_enable = Datagridview1.Rows.Count
        '    End If
        '    For i As Integer = 2 To max_enable
        '        For Each btn As Control In Me.Panel_Reg.Controls
        '            If TypeOf btn Is RadioButton And btn.Name = "rdo" & i Then
        '                CType(btn, RadioButton).Enabled = True
        '            End If
        '        Next
        '    Next

        '    rdo1.Enabled = True
        '    rdo1.Checked = True
        '    rdo7.Enabled = True
        '    btn_save.Enabled = True
        'Else
        '    btn_save.Enabled = False
        '    Call LockedRDO()
        'End If
    End Sub

    Private Sub btn_search_enroll_Click(sender As Object, e As EventArgs) Handles btn_search_std.Click
        If (txt_std_code.Text.Trim <> "") Then
            FrmStdDrop_StudentSelect.txt_search.Text = txt_std_code.Text.Trim
        End If

        'get_student_id, get_std_code, get_student_name_la, get_student_name_en, get_course_id, get_full_course, get_birth_date, get_telephone, get_sex, get_parent_name, get_parent_contact
        If FrmStdDrop_StudentSelect.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_course.Tag = FrmStdDrop_StudentSelect.get_course_id
            txt_course.Text = FrmStdDrop_StudentSelect.get_full_course
            txt_std_code.Text = FrmStdDrop_StudentSelect.get_std_code
            txt_name.Tag = FrmStdDrop_StudentSelect.get_student_id
            txt_name.Text = FrmStdDrop_StudentSelect.get_sex & ". " & FrmStdDrop_StudentSelect.get_student_name_la
            txt_parent.Text = FrmStdDrop_StudentSelect.get_parent_name & " [ໂທລະສັບ: " & FrmStdDrop_StudentSelect.get_parent_contact & "]"
        End If
    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        If (txt_name.Text.Trim <> "") Then
            btn_search_term.Enabled = True
        Else
            btn_search_term.Enabled = False
        End If
    End Sub

End Class