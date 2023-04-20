Public Class FrmStdDrop_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).sale_product = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        chk_undrop.Checked = False
        chk_droping.Checked = True
        Call LoadData()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct_droping As String = ""
        Dim ct_undrop As String = ""
        If (chk_undrop.Checked = False) Then
            ct_undrop = " AND (drop_status<>0)"
        End If
        If (chk_droping.Checked = False) Then
            ct_droping = " AND (drop_status<>1)"
        End If

        Dim ct_search As String = ""
        If (txt_search.Text.Trim <> "") Then
            ct_search = " AND ((student_code LIKE N'%" & txt_search.Text.Trim & "%') OR (student_fullname_en LIKE N'%" & txt_search.Text.Trim & "%') OR (student_fullname_la LIKE N'%" & txt_search.Text.Trim & "%')) "
        End If

        Sql = "SELECT student_code ,student_fullname_la ,student_fullname_en ,phone_number ,job_des ,title_la ,title_en ,sex_id ,"
        Sql &= " course_id, course_des_la, course_des_en, scheme_id, scheme_des_la, scheme_des_en, drop_id, student_id,"
        Sql &= " class_room, year_study, drop_des, drop_reson, drop_remark, drop_status, user_update, last_update"
        Sql &= " FROM view_std_drop"
        Sql &= " WHERE(student_status > 0) " & ct_search & ct_droping & ct_undrop   'student_status=0 ແມ່ນນັກສຶກສາອອກແລ້ວ
        Sql &= " ORDER BY drop_id"
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                'status
                Dim st As String = "ກຳລັງຢຸດຮຽນ"
                If (dt.Rows(i).Item("drop_status") = 0) Then
                    st = "ຮຽນຄືນແລ້ວ"
                End If

                .Rows.Add(dt.Rows(i).Item("drop_id"), (i + 1), dt.Rows(i).Item("title_la") & ". " & dt.Rows(i).Item("student_fullname_la"), (dt.Rows(i).Item("scheme_des_la") & "-[" & dt.Rows(i).Item("course_des_la") & "]"), _
                         dt.Rows(i).Item("drop_des"), st, dt.Rows(i).Item("user_update"), dt.Rows(i).Item("drop_reson"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
                btn_print.Enabled = True
                btn_edit.Enabled = True
            Else
                btn_edit.Enabled = False
                btn_print.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmStdDrop_add.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_edit = Datagridview1.CurrentRow.Cells(0).Value
        FrmStdDrop_edit.ShowDialog()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Cursor = Cursors.WaitCursor
        BILL_ID = Datagridview1.CurrentRow.Cells(0).Value
        Sql = "SELECT * FROM view_std_drop "
        Sql &= " WHERE(drop_id = " & BILL_ID & ") "
        dt = ExecuteDatable(Sql)
        Dim crt As New Rpt_StudentDrop_LA
        crt.SetDataSource(dt)

        'crt.SetParameterValue("user_print", User_name)
        crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        'Show Report
        FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        FrmReport_A4.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub chk_active_CheckedChanged(sender As Object, e As EventArgs) Handles chk_undrop.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub chk_cancel_CheckedChanged(sender As Object, e As EventArgs) Handles chk_droping.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub Datagridview1_SelectionChanged(sender As Object, e As EventArgs) Handles Datagridview1.SelectionChanged
        'If (load_finishied = 0) Then
        '    With Datagridview1
        '        If (.RowCount > 0) Then
        '            btn_print.Enabled = True
        '            btn_edit.Enabled = False
        '            If (.CurrentRow.Cells(7).Value = 1) Then
        '                btn_edit.Enabled = True
        '            End If
        '        Else
        '            btn_edit.Enabled = False
        '            btn_print.Enabled = False
        '        End If
        '    End With
        'End If

    End Sub

End Class