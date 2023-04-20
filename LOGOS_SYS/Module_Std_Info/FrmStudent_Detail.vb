Imports System.Data.SqlClient
Imports System.IO

Public Class FrmStudent_Detail

    Private Sub FrmUserGroup_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmStudent_view.LoadData()
        End If
    End Sub

    Private Sub getSexList()
        Sql = "SELECT title_id, title_la, title_en "
        Sql &= " FROM tbl_student_title "
        Sql &= " ORDER BY title_id"
        dt = ExecuteDatable(Sql)
        cb_sex.DataSource = dt
        cb_sex.ValueMember = "title_id"
        cb_sex.DisplayMember = "title_la"
    End Sub

    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_finished = 1
        had_change_val = 0
        Call getSexList()
        Call firstLoad()
        load_finished = 0
    End Sub

    Dim load_finished As Integer = 1
    Private Sub firstLoad()
        Dim cur_date As String = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        txt_std_code.Text = ""
        txt_std_code.Tag = ""
        txt_name.Text = ""
        txt_name.Tag = ""
        txt_name_en.Text = ""
        txt_phone.Text = ""
        txt_birth_address_la.Text = ""
        txt_birth_address_en.Text = ""
        txt_address_la.Text = ""
        txt_address_en.Text = ""
        txt_national_la.Text = ""
        txt_national_en.Text = ""
        txt_job.Text = ""
        txt_secondary_from.Text = ""
        txt_parent_name.Text = ""
        txt_parent_tel.Text = ""
        txt_course.Tag = ""
        txt_course.Text = ""
        txt_comment.Text = ""
        gridview_term.Rows.Clear()
        gridview_score.Rows.Clear()
        gridview_upgarde.Rows.Clear()
        gridview_drop.Rows.Clear()

        Call lockedText()
        Call getStudent_info()
        Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)
        Call visible_gride_btn_checked(btn_reg_inf, gridview_term)
        Call getStudentDrop(txt_std_code.Tag)

        btn_edit.Select()
    End Sub

    Private Sub lockedText()
        txt_std_code.ReadOnly = True
        txt_name.ReadOnly = True
        txt_name_en.ReadOnly = True
        txt_phone.ReadOnly = True
        DateTimePicker1.Enabled = False
        txt_birth_address_la.ReadOnly = True
        txt_address_la.ReadOnly = True
        txt_national_la.ReadOnly = True
        txt_birth_address_en.ReadOnly = True
        txt_address_en.ReadOnly = True
        txt_national_en.ReadOnly = True
        txt_job.ReadOnly = True
        txt_secondary_from.ReadOnly = True
        txt_parent_name.ReadOnly = True
        txt_parent_tel.ReadOnly = True
        txt_course.ReadOnly = True
        txt_comment.ReadOnly = True
        school_year1.Enabled = False
        school_year2.Enabled = False
        cb_sex.Enabled = False
        PictureBox1.Enabled = False

        rdo_studying.Enabled = False
        rdo_outed.Enabled = False
        rdo_completed.Enabled = False

        btn_save.Visible = False
        btn_edit.Visible = True
        btn_cancel.Enabled = False
    End Sub

    Private Sub UnlockedText()
        txt_std_code.ReadOnly = False
        txt_name.ReadOnly = False
        txt_name_en.ReadOnly = False
        txt_phone.ReadOnly = False
        DateTimePicker1.Enabled = True
        txt_birth_address_la.ReadOnly = False
        txt_address_la.ReadOnly = False
        txt_national_la.ReadOnly = False
        txt_birth_address_en.ReadOnly = False
        txt_address_en.ReadOnly = False
        txt_national_en.ReadOnly = False
        txt_job.ReadOnly = False
        txt_secondary_from.ReadOnly = False
        txt_parent_name.ReadOnly = False
        txt_parent_tel.ReadOnly = False
        txt_course.ReadOnly = True
        txt_comment.ReadOnly = False
        school_year1.Enabled = True
        school_year2.Enabled = True
        cb_sex.Enabled = True
        PictureBox1.Enabled = True

        rdo_studying.Enabled = True
        rdo_outed.Enabled = True
        If (haveTermNotRegister = False) Then
            rdo_completed.Enabled = True
        End If

        btn_save.Visible = True
        btn_edit.Visible = False
        btn_cancel.Enabled = True
    End Sub

    Private Sub visible_gride_btn_checked(ByVal btn As Button, ByVal dgb As DataGridView)
        btn_reg_inf.BackColor = Color.FromArgb(0, 102, 204)
        btn_score_inf.BackColor = Color.FromArgb(0, 102, 204)
        btn_upgrade_inf.BackColor = Color.FromArgb(0, 102, 204)
        btn_drop_inf.BackColor = Color.FromArgb(0, 102, 204)
        gridview_term.Visible = False
        gridview_score.Visible = False
        gridview_upgarde.Visible = False
        gridview_drop.Visible = False

        btn.BackColor = Color.FromArgb(64, 0, 0)
        dgb.Visible = True
    End Sub
    '
    Dim old_std_id As String = ""
    Dim old_std_status As String = ""
    Private Sub getStudent_info()
        Sql = " SELECT student_id ,student_code ,student_fullname_la ,student_fullname_en ,student_gender ,date_of_birth ,"
        Sql &= " birth_address_la ,birth_address_en ,nationality ,nationality_en, address_la ,address_en ,phone_number ,wa_number ,job_des ,"
        Sql &= " hight_school_name ,hight_school_graduate_year ,parent_name ,parent_contact ,course_id ,current_term_id ,"
        Sql &= " class_id ,start_year ,end_year ,create_date ,student_status ,last_update ,user_update ,course_des_la ,"
        Sql &= " course_des_en ,scheme_id ,scheme_des_la ,scheme_des_en ,max_term_id_reg ,get_current_class_id ,"
        Sql &= " current_sokhien ,get_current_term_id ,max_sokhien ,student_remark, std_img, expected_graduate "
        Sql &= " FROM view_std_list_prepare "
        Sql &= " WHERE(student_id = " & id_edit & ")"
        dt = ExecuteDatable(Sql)
        With dt.Rows(0)
            txt_std_code.Text = CStr(.Item("student_code"))
            old_std_id = txt_std_code.Text
            txt_std_code.Tag = CInt(.Item("student_id"))
            cb_sex.SelectedValue = CInt(.Item("student_gender"))
            txt_name.Text = .Item("student_fullname_la")
            txt_name_en.Text = .Item("student_fullname_en")
            txt_phone.Text = .Item("phone_number")
            DateTimePicker1.Text = .Item("date_of_birth")
            If Not IsDBNull(.Item("birth_address_la")) Then
                txt_birth_address_la.Text = .Item("birth_address_la")
            End If
            If Not IsDBNull(.Item("address_la")) Then
                txt_address_la.Text = .Item("address_la")
            End If
            If Not IsDBNull(.Item("nationality")) Then
                txt_national_la.Text = .Item("nationality")
            End If

            If Not IsDBNull(.Item("birth_address_en")) Then
                txt_birth_address_en.Text = .Item("birth_address_en")
            End If
            If Not IsDBNull(.Item("address_en")) Then
                txt_address_en.Text = .Item("address_en")
            End If
            If Not IsDBNull(.Item("nationality_en")) Then
                txt_national_en.Text = .Item("nationality_en")
            End If

            If Not IsDBNull(.Item("job_des")) Then
                txt_job.Text = .Item("job_des")
            End If
            If Not IsDBNull(.Item("hight_school_name")) Then
                txt_secondary_from.Text = .Item("hight_school_name")
            End If
            If Not IsDBNull(.Item("parent_name")) Then
                txt_parent_name.Text = .Item("parent_name")
            End If
            If Not IsDBNull(.Item("parent_contact")) Then
                txt_parent_tel.Text = .Item("parent_contact")
            End If
            If Not IsDBNull(.Item("expected_graduate")) Then
                txt_will_complete.Text = .Item("expected_graduate")
            End If

            school_year1.Value = .Item("start_year")
            school_year2.Value = .Item("end_year")

            txt_course.Tag = .Item("course_id")
            txt_course.Text = .Item("course_des_la")
            txt_comment.Text = .Item("student_remark")

            'Status
            old_std_status = .Item("student_status")
            If (old_std_status = 0) Then
                rdo_outed.Checked = True
            ElseIf (old_std_status = 1) Then
                rdo_studying.Checked = True
            Else
                rdo_completed.Checked = True '=2
            End If

            'IMG
            have_img = False
            If Not IsDBNull(.Item("std_img")) Then
                have_img = True
                Dim picture() As Byte = .Item("std_img")
                Dim streampic As New MemoryStream(picture)
                PictureBox1.Image = Image.FromStream(streampic)
            End If
        End With
    End Sub

    Dim have_img As Boolean = False
    Dim sFilePath As String = ""
    Private Sub Save_Student_Edited()
        If (txt_std_code.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກ ຫຼື ຄົ້ນຫານັກສຶກສາ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_std_code.Focus()
            Exit Sub
        End If
        If (old_std_id <> txt_std_code.Text.Trim) Then
            'check for Student-ID
            Sql = "SELECT student_code FROM tbl_student WHERE(student_code=N'" & txt_std_code.Text.Trim & "')"
            dt = ExecuteDatable(Sql)
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("ລະຫັດນັກສຶກສາທີ່ທ່ານປ້ອນຊໍ້າກັນ ກັບລະຫັດນັກສຶກສາທີ່ມີຢູ່ແລ້ວ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_std_code.Focus()
                Exit Sub
            End If
        End If
        If (txt_name.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກປ້ອນຊື່ແລະນາມສະກຸນນັກສຶກສາ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_name.Focus()
            Exit Sub
        End If
        If (txt_name_en.Text.Trim = "") Then
            MessageBox.Show("ກະລຸນາເລືອກປ້ອນຊື່ແລະນາມສະກຸນນັກສຶກສາເປັນພາສາອັງກິດ.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_name_en.Focus()
            Exit Sub
        End If

        Dim sex As Integer = cb_sex.SelectedValue
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If

        Dim student_status As Integer = 0
        If (rdo_studying.Checked = True) Then
            student_status = 1
        End If
        If (rdo_completed.Checked = True) Then
            student_status = 2
        End If

        'IMG
        Dim go_update_img As Integer = 0
        Dim img As Byte()
        If (sFilePath <> "") Then
            go_update_img = 1
            Dim fs As FileStream = New FileStream(sFilePath.ToString(), FileMode.Open, FileAccess.Read)
            Dim binReader As New BinaryReader(fs)
            img = binReader.ReadBytes(fs.Length)
        End If

        If (sFilePath = "") And (have_img = False) Then
            go_update_img = 1
            sFilePath = "std_icon.jpg"
            Dim fs As FileStream = New FileStream(sFilePath.ToString(), FileMode.Open, FileAccess.Read)
            Dim binReader As New BinaryReader(fs)
            img = binReader.ReadBytes(fs.Length)
        End If

        'UPDATE Student Info
        'Dim bod As String = Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd")
        Call ConnectDB()
        Sql = "UPDATE tbl_student SET student_code=@student_code ,student_fullname_la=@student_fullname_la ,student_fullname_en=@student_fullname_en ,"
        Sql &= " student_gender=@student_gender, date_of_birth=@date_of_birth, phone_number=@phone_number, "
        Sql &= " start_year=@start_year ,end_year=@end_year ,user_update=@user_update, last_update=getdate(), "
        Sql &= " parent_name=@parent_name, parent_contact=@parent_contact, student_remark=@student_remark, hight_school_name=@hight_school_name, "
        Sql &= " nationality=@nationality, job_des=@job_des, birth_address_la=@birth_address_la, address_la=@address_la, std_img=@std_img, "
        Sql &= " nationality_en=@nationality_en, birth_address_en=@birth_address_en, address_en=@address_en, expected_graduate=@expected_graduate, student_status=@student_status "
        Sql &= " WHERE(student_id=" & id_edit & ")"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("student_code", txt_std_code.Text.Trim)
        cm.Parameters.AddWithValue("student_fullname_la", txt_name.Text.Trim)
        cm.Parameters.AddWithValue("student_fullname_en", txt_name_en.Text.Trim)
        cm.Parameters.AddWithValue("student_gender", sex)
        cm.Parameters.AddWithValue("date_of_birth", CDate(DateTimePicker1.Text))
        cm.Parameters.AddWithValue("phone_number", CStr(txt_phone.Text.Trim))
        cm.Parameters.AddWithValue("start_year", school_year1.Value)
        cm.Parameters.AddWithValue("end_year", school_year2.Value)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.Parameters.AddWithValue("parent_name", txt_parent_name.Text.Trim)
        cm.Parameters.AddWithValue("parent_contact", txt_parent_tel.Text.Trim)
        cm.Parameters.AddWithValue("student_remark", cmt)
        cm.Parameters.AddWithValue("hight_school_name", txt_secondary_from.Text.Trim)
        cm.Parameters.AddWithValue("nationality", txt_national_la.Text.Trim)
        cm.Parameters.AddWithValue("job_des", txt_job.Text.Trim)
        cm.Parameters.AddWithValue("birth_address_la", txt_birth_address_la.Text.Trim)
        cm.Parameters.AddWithValue("address_la", txt_address_la.Text.Trim)
        cm.Parameters.AddWithValue("nationality_en", txt_national_en.Text.Trim)
        cm.Parameters.AddWithValue("birth_address_en", txt_birth_address_en.Text.Trim)
        cm.Parameters.AddWithValue("address_en", txt_address_en.Text.Trim)
        cm.Parameters.AddWithValue("expected_graduate", txt_will_complete.Text.Trim)
        cm.Parameters.AddWithValue("student_status", student_status)
        If (go_update_img = 1) Then
            cm.Parameters.AddWithValue("std_img", img)
        End If
        cm.ExecuteNonQuery()

        If (old_std_status = 1) And (student_status = 0) Then
            'StudentLog
            Dim action_detail As String = "ກຳນົດໃຫ້ນັກສຶກສາ ສິ້ນສຸດສະຖານະພາບເປັນນັກສຶກສາ"
            Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
        End If
        If (old_std_status = 1) And (student_status = 2) Then
            'StudentLog
            Dim action_detail As String = "ປ່ຽນສະຖານະນັກສຶກສາ ໃຫ້ຈົບການສຶກສາແລ້ວ"
            Call AddStudentLog(CInt(txt_std_code.Tag), action_detail)
        End If

        MessageBox.Show("Save completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        had_change_val = 1
        Me.Close()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call Save_Student_Edited()
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Dim haveTermNotRegister As Boolean = False
    Private Sub getTermListInCourse(ByVal c As Integer, ByVal student_id As Integer)
        haveTermNotRegister = False
        Sql = "SELECT term_id ,term_no ,term_des ,course_id ,term_status, term_study_year, "
        Sql &= " ISNULL((SELECT 0 FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), 1) AS register_st,"
        Sql &= " ISNULL((SELECT register_amount FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), view_term_table.register_amount) AS register_amount, "
        Sql &= " ISNULL((SELECT register_discount FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), 0) AS register_discount, "
        Sql &= " ISNULL((SELECT register_year FROM tbl_term_register WHERE (student_id = " & student_id & ") AND (term_id=view_term_table.term_id)), 0) AS register_year "
        Sql &= " FROM view_term_table"
        Sql &= " WHERE(term_status <> 0) AND (course_id=" & c & ")"
        Sql &= " ORDER BY term_list_id"

        dt = ExecuteDatable(Sql)
        gridview_term.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            Dim is_geted_index_next_term As Integer = 0
            Dim index_next_term As Integer = 0
            Dim max_y As Integer = 0
            Dim idx As Integer = 0
            Dim get_idx As Integer = 0

            With gridview_term
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim registed_text As String = "ລົງທະບຽນແລ້ວ"
                    Dim chked As Integer = 1
                    If (dt.Rows(i).Item("register_st") = 1) Then
                        registed_text = "ຍັງບໍ່ລົງທະບຽນ"
                        chked = 0
                        haveTermNotRegister = True
                    End If

                    Dim sokhien As String = dt.Rows(i).Item("register_year")
                    If (sokhien = "0") And (get_idx = 0) Then
                        idx = i - 1
                        get_idx = 1
                    End If

                    max_y = Mid(dt.Rows(idx).Item("register_year"), 1, 4)
                    sokhien = max_y - 1 + CInt(dt.Rows(i).Item("term_study_year")) & "-" & max_y + CInt(dt.Rows(i).Item("term_study_year"))

                    .Rows.Add(dt.Rows(i).Item("term_id"), chked, (dt.Rows(i).Item("term_no") & "-[" & dt.Rows(i).Item("term_des") & "]"), _
                              dt.Rows(i).Item("register_amount"), dt.Rows(i).Item("register_discount"), sokhien, _
                              registed_text, dt.Rows(i).Item("register_st"))

                    If (dt.Rows(i).Item("register_st") = 0) Then
                        .Rows(i).DefaultCellStyle.ForeColor = Color.Green
                    End If
                Next

            End With
        End If
    End Sub

    Private Sub getStudentScoreRegistered(ByVal student_id As Integer)
        Sql = "SELECT score_id ,subject_id ,subject_code ,subject_name_la ,subject_name_en ,subject_credit ,"
        Sql &= " score, upgrade_score, term_id, term_no, term_no_la, term_des, register_year, GPA, Grade"
        Sql &= " FROM view_std_score"
        Sql &= " WHERE(student_id =" & student_id & ") "
        Sql &= " ORDER BY term_list_id"
        dt = ExecuteDatable(Sql)
        gridview_score.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            With gridview_score
                For i As Integer = 0 To dt.Rows.Count - 1
                    .Rows.Add((i + 1), dt.Rows(i).Item("subject_name_en"), dt.Rows(i).Item("subject_credit"), dt.Rows(i).Item("Grade"), dt.Rows(i).Item("term_no"))
                Next
            End With
        End If
    End Sub

    Private Sub getStudentScoreUpgrade(ByVal student_id As Integer)
        Sql = "SELECT student_id ,subject_id ,subject_code ,subject_name_la ,subject_name_en ,register_date ,"
        Sql &= " register_remark ,subject_credit ,score ,upgrade_score ,Old_GPA ,Old_Grade ,UP_GPA ,UP_Grade"
        Sql &= " FROM view_std_upgrade "
        Sql &= " WHERE(student_id =" & student_id & ") "
        Sql &= " ORDER BY register_date"
        dt = ExecuteDatable(Sql)
        gridview_upgarde.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            With gridview_upgarde
                For i As Integer = 0 To dt.Rows.Count - 1
                    .Rows.Add((i + 1), dt.Rows(i).Item("subject_name_en"), dt.Rows(i).Item("subject_credit"), dt.Rows(i).Item("Old_Grade"), dt.Rows(i).Item("UP_Grade"))
                Next
            End With
        End If
    End Sub

    Private Sub getStudentDrop(ByVal student_id As Integer)
        Sql = "SELECT student_code ,course_id ,course_des_la ,course_des_en ,scheme_id ,scheme_des_la ,scheme_des_en ,"
        Sql &= " drop_id ,student_id ,class_room ,year_study ,drop_des ,drop_reson ,drop_remark ,drop_status ,"
        Sql &= " at_sokhien ,at_seasion ,user_update ,last_update ,std_img ,time_learn ,drop_date "
        Sql &= " FROM view_std_drop"
        Sql &= " WHERE(student_id =" & student_id & ") "
        Sql &= " ORDER BY drop_id DESC "
        dt = ExecuteDatable(Sql)
        gridview_drop.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            With gridview_drop
                For i As Integer = 0 To dt.Rows.Count - 1
                    .Rows.Add((i + 1), dt.Rows(i).Item("drop_date"), dt.Rows(i).Item("drop_des"), dt.Rows(i).Item("drop_reson"), dt.Rows(i).Item("drop_status"), dt.Rows(i).Item("drop_remark"), _
                              "ປີ " & dt.Rows(i).Item("year_study") & ", ພາກຮຽນ: " & dt.Rows(i).Item("at_seasion") & "(ສົກຮຽນ: " & dt.Rows(i).Item("at_sokhien") & ")")
                Next

                Call click_std_drop_row(0)
            End With
        End If
    End Sub

    Private Sub gridview_drop_SelectionChanged(sender As Object, e As EventArgs) Handles gridview_drop.SelectionChanged
        If (gridview_drop.Rows.Count > 0) Then
            Call click_std_drop_row(gridview_drop.CurrentRow.Index)
        End If
    End Sub

    Private Sub click_std_drop_row(ByVal r As Integer)
        txt_drop_date.Text = ""
        txt_drop_at.Text = ""
        txt_drop_desc.Text = ""
        txt_drop_reason.Text = ""
        txt_drop_remark.Text = ""
        rdo_droping.Checked = False
        rdo_continue.Checked = False

        With gridview_drop
            txt_drop_date.Text = Format(CDate(.Rows(r).Cells(1).Value), "dd/MM/yyyy")
            txt_drop_at.Text = .Rows(r).Cells(6).Value
            txt_drop_desc.Text = .Rows(r).Cells(2).Value
            txt_drop_reason.Text = .Rows(r).Cells(3).Value
            txt_drop_remark.Text = .Rows(r).Cells(5).Value

            If (.Rows(r).Cells(4).Value = 1) Then
                rdo_droping.Checked = True
            End If
            If (.Rows(r).Cells(4).Value = 0) Then
                rdo_continue.Checked = True
            End If
        End With
    End Sub

    Private Sub btn_reg_inf_Click(sender As Object, e As EventArgs) Handles btn_reg_inf.Click
        Call getTermListInCourse(txt_course.Tag, txt_std_code.Tag)
        Call visible_gride_btn_checked(btn_reg_inf, gridview_term)
    End Sub

    Private Sub btn_score_inf_Click(sender As Object, e As EventArgs) Handles btn_score_inf.Click
        Call getStudentScoreRegistered(txt_std_code.Tag)
        Call visible_gride_btn_checked(btn_score_inf, gridview_score)
    End Sub

    Private Sub btn_upgrade_inf_Click(sender As Object, e As EventArgs) Handles btn_upgrade_inf.Click
        Call getStudentScoreUpgrade(txt_std_code.Tag)
        Call visible_gride_btn_checked(btn_upgrade_inf, gridview_upgarde)
    End Sub

    Private Sub btn_drop_inf_Click(sender As Object, e As EventArgs) Handles btn_drop_inf.Click
        Call getStudentDrop(txt_std_code.Tag)
        Call visible_gride_btn_checked(btn_drop_inf, gridview_drop)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call UnlockedText()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call firstLoad()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.Title = "ເລືອກຮູບ"
            sFilePath = OpenFileDialog1.FileName
            'MsgBox(sFilePath)
            PictureBox1.Image = Image.FromFile(sFilePath)
        Else : Exit Sub
        End If
    End Sub

    Private Sub gridview_drop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_drop.CellContentClick

    End Sub
End Class