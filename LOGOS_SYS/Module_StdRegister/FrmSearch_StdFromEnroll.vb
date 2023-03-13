Public Class FrmSearch_StdFromEnroll

    Dim load_finishied As Integer = 1
    Dim cur_sokhien As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        Dim cur_year As Integer = CInt(Format(CDate(getCurrentDate()), "yyyy"))
        cur_sokhien = cur_year & "-" & (cur_year + 1)
        Call LoadData()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct As String = ""
        If (txt_search.Text.Trim <> "") Then
            ct = " AND ((std_enroll_fullname_la LIKE N'" & txt_search.Text.Trim & "%') OR (phone_number LIKE '%" & txt_search.Text.Trim & "%'))"
        End If
        Sql = "SELECT enroll_id ,enroll_date ,enroll_amount ,enroll_discount ,enroll_comment ,test_date ,"
        Sql &= " year_register ,last_update ,user_update ,std_enroll_id ,std_enroll_fullname_la ,std_enroll_fullname_en ,"
        Sql &= " std_enroll_gender ,date_of_birth ,birth_address ,location_address ,phone_number ,wa_number ,"
        Sql &= " parent_contact ,std_enroll_status ,course_id ,course_des_la ,course_des_en ,course_test_amount ,"
        Sql &= " scheme_id ,scheme_des_la ,scheme_des_en ,learning_shift_id ,learning_shift_des"
        Sql &= " FROM view_std_enroll"
        Sql &= " WHERE(reg_first_term_st=0) AND (year_register='" & cur_sokhien & "') "
        Sql &= " ORDER BY std_enroll_fullname_la "
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                'Sex
                Dim sex As String = "ທ. "
                If (dt.Rows(i).Item("std_enroll_gender") = 2) Then
                    sex = "ນ. "
                End If

                .Rows.Add(dt.Rows(i).Item("enroll_id"), (i + 1), sex & dt.Rows(i).Item("std_enroll_fullname_la"), dt.Rows(i).Item("phone_number"), dt.Rows(i).Item("year_register"), _
                          dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]", dt.Rows(i).Item("course_id"), _
                          dt.Rows(i).Item("learning_shift_id"), dt.Rows(i).Item("std_enroll_gender"), dt.Rows(i).Item("scheme_id"))
            Next
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Public course_id, full_course, enroll_id, student_fname, phone_number, year_register, learning_shift_id, std_enroll_gender, scheme_id As String
    Private Sub Datagridview1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datagridview1.CellMouseClick
        If Datagridview1.RowCount > 0 Then
            course_id = Datagridview1.CurrentRow.Cells(6).Value.ToString()
            full_course = Datagridview1.CurrentRow.Cells(5).Value.ToString()
            enroll_id = Datagridview1.CurrentRow.Cells(0).Value.ToString()
            student_fname = Mid(Datagridview1.CurrentRow.Cells(2).Value.ToString(), 4, Len(Datagridview1.CurrentRow.Cells(2).Value.ToString()) - 3)
            phone_number = Datagridview1.CurrentRow.Cells(3).Value.ToString()
            year_register = Datagridview1.CurrentRow.Cells(4).Value.ToString()
            learning_shift_id = Datagridview1.CurrentRow.Cells(7).Value.ToString()
            std_enroll_gender = CInt(Datagridview1.CurrentRow.Cells(8).Value.ToString())
            scheme_id = CInt(Datagridview1.CurrentRow.Cells(9).Value.ToString())
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub txt_search_TextChanged_1(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

End Class