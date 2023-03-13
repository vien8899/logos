Public Class FrmReg_Open_Closed_view

    Dim load_finishied As Integer = 1
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).student_enroll_test = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        Call getYearList()
        Call LoadData()
        load_finishied = 0
    End Sub

    Dim cur_date As String = ""
    Private Sub getYearList()
        cb_year.Items.Clear()
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        Dim cur_year As Integer = CInt(Format(CDate(getCurrentDate()), "yyyy")) - 3
        Dim i As Integer = 3
        While i > 0
            cb_year.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            i -= 1
        End While
        cb_year.SelectedIndex = 0
    End Sub

    Public Sub LoadData()
        Dim ct_year As String = " AND (year_study='" & cb_year.SelectedItem & "')"
        Dim ct_cloased As String = " AND (close_date >= CAST(GETDATE() AS DATE)) "

        If (chk_show_disable.Checked = True) Then
            ct_cloased = ""
        End If

        Sql = " SELECT open_close_id ,year_study ,open_date ,close_date ,seasion_part, open_close_type ,open_close_des ,last_update ,user_update"
        Sql &= " FROM tbl_setting_open_close_reg "
        Sql &= " WHERE(open_close_type = " & de_or_se & ") " & ct_year & ct_cloased
        Sql &= " ORDER BY close_date"
        dt = ExecuteDatable(Sql)
        With Datagridview1
            If (de_or_se = 1) Then
                .Columns(3).Visible = True
            Else
                .Columns(3).Visible = False
            End If

            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                'Sex
                Dim st As String = "ເປີດລົງທະບຽນຢູ່... "
                If (Format(CDate(dt.Rows(i).Item("close_date")), "yyyy-MM-dd") < cur_date) Then
                    st = "ໝົດກຳນົດແລ້ວ. "
                End If

                'Status: 1 = ຫາກະລົງທະບຽນເສັງ/2 = ລົງທະບຽນຮຽນແລ້ວ
                Dim type As String = "ພາກຮຽນ I"
                If (dt.Rows(i).Item("seasion_part") = 2) Then
                    type = "ພາກຮຽນ II"
                End If

                .Rows.Add(dt.Rows(i).Item("open_close_id"), (i + 1), dt.Rows(i).Item("year_study"), type, _
                         dt.Rows(i).Item("open_date"), dt.Rows(i).Item("close_date"), st, _
                         dt.Rows(i).Item("open_close_des"), dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) And (cb_year.SelectedIndex = 0) Then
                btn_edit.Enabled = True
            Else
                btn_edit.Enabled = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FrmReg_Open_Closed_add.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        had_change_val = 0
        id_edit = CInt(Datagridview1.CurrentRow.Cells(0).Value)
        FrmReg_Open_Closed_edit.ShowDialog()
    End Sub

    Private Sub cb_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_year.SelectedIndexChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

    Private Sub chk_show_disable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_show_disable.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

End Class