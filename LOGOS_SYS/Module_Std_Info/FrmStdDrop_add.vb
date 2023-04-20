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
        txt_desc.Text = ""
        txt_desc.Tag = ""
        txt_course.Tag = ""
        txt_course.Text = ""
        txt_year.Text = ""
        txt_class.Text = ""
        txt_sokhien.Text = ""
        txt_seasion.Text = ""
        txt_reason.Text = ""
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

        If (txt_class.Text.Trim = "") Then
            MessageBox.Show("Please enter class room.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_class.Focus()
            Exit Sub
        End If

        If (txt_year.Text.Trim = "") Then
            MessageBox.Show("Please enter year studying...", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_year.Focus()
            Exit Sub
        End If

        If (txt_desc.Text.Trim = "") Then
            MessageBox.Show("Please enter drop detail.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_desc.Focus()
            Exit Sub
        End If
        If (txt_reason.Text.Trim = "") Then
            MessageBox.Show("Please enter drop reason.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_reason.Focus()
            Exit Sub
        End If

        If (txt_sokhien.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາປ້ອນສົກຮຽນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_sokhien.Focus()
            Exit Sub
        End If
        If (txt_seasion.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາປ້ອນພາກຮຽນ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_seasion.Focus()
            Exit Sub
        End If

        Dim rm As String = "--"
        If (txt_remark.Text.Trim <> "") Then
            rm = txt_remark.Text.Trim
        End If

        'check for dupplicate drop
        Sql = "SELECT student_id FROM tbl_student_drop WHERE(student_id=" & txt_name.Tag & ") AND (drop_status=1)"
        dt = ExecuteDatable(Sql)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("ນັກສຶກສາກຳລັງຢູ່ໃນການໂຈະຮຽນຢູ່, ບໍ່ສາມາດເພີ່ມການໂຈະຮຽນຕື່ມໄດ້.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If

        'For New Student
        Call ConnectDB()
        Sql = "INSERT INTO tbl_student_drop(student_id ,class_room ,year_study ,drop_des ,drop_reson ,drop_remark ,user_update, at_seasion, at_sokhien) "
        Sql &= "                     VALUES(@student_id ,@class_room ,@year_study ,@drop_des ,@drop_reson ,@drop_remark ,@user_update, @at_seasion, @at_sokhien)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("student_id", txt_name.Tag)
        cm.Parameters.AddWithValue("class_room", txt_class.Text.Trim)
        cm.Parameters.AddWithValue("year_study", txt_year.Text.Trim)
        cm.Parameters.AddWithValue("drop_des", txt_desc.Text.Trim)
        cm.Parameters.AddWithValue("drop_reson", txt_reason.Text.Trim)
        cm.Parameters.AddWithValue("drop_remark", rm)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.Parameters.AddWithValue("at_seasion", txt_seasion.Text.Trim)
        cm.Parameters.AddWithValue("at_sokhien", txt_sokhien.Text.Trim)
        cm.ExecuteNonQuery()

        'StudentLog
        Dim action_detail As String = "Drop ການຮຽນຊົ່ວຄາວ (" & txt_desc.Text & ")"
        Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)

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
            txt_class.Text = FrmStdDrop_StudentSelect.get_class
            txt_year.Text = FrmStdDrop_StudentSelect.get_year
            txt_sokhien.Text = FrmStdDrop_StudentSelect.get_sokhien
            txt_seasion.Text = FrmStdDrop_StudentSelect.get_seasion
        End If
    End Sub

End Class