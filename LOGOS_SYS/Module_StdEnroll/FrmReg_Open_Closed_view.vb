Public Class FrmReg_Open_Closed_view

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permission-Check
        Panel_Control.Enabled = True
        If (user_permission.Item(0).student_enroll_test = 0) Then
            Panel_Control.Enabled = False
        End If

        'Load Data
        load_finishied = 1
        chk_enroll.Checked = True
        chk_enroll_train.Checked = True
        chk_register.Checked = True
        chk_register_train.Checked = True
        chk_show_disable.Checked = False
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")

        Call LoadData()
        load_finishied = 0
    End Sub

    Public Sub LoadData()
        Dim ct_cloased As String = " AND (close_date >= CAST(GETDATE() AS DATE)) "
        If (chk_show_disable.Checked = True) Then
            ct_cloased = ""
        End If

        Dim ct_enroll As String = ""
        Dim ct_enroll_train As String = ""
        Dim ct_register As String = ""
        Dim ct_register_train As String = ""

        If (chk_enroll.Checked = False) Then
            ct_enroll = " AND (register_type <> 1)"
        End If
        If (chk_enroll_train.Checked = False) Then
            ct_enroll_train = " AND (register_type <> 3)"
        End If
        If (chk_register.Checked = False) Then
            ct_register = " AND (register_type <> 2)"
        End If
        If (chk_register_train.Checked = False) Then
            ct_register_train = " AND (register_type <> 4)"
        End If

        Sql = " SELECT open_close_id ,open_date ,close_date ,register_type ,open_close_des ,last_update ,user_update"
        Sql &= " FROM tbl_setting_open_close_reg "
        Sql &= " WHERE(open_close_id > 0) " & ct_cloased & ct_enroll & ct_enroll_train & ct_register & ct_register_train
        Sql &= " ORDER BY register_type, close_date"
        dt = ExecuteDatable(Sql)
        With Datagridview1
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1

                'Sex
                Dim st As String = "ເປີດລົງທະບຽນຢູ່... "
                If (Format(CDate(dt.Rows(i).Item("close_date")), "yyyy-MM-dd") < cur_date) Then
                    st = "ໝົດກຳນົດແລ້ວ. "
                End If

                'Status: 1 = ລົງທະບຽນເສັງທຽບຮຽນ/ 2 = ລົງທະບຽນຮຽນ/ 3 = ລົງທະບຽນເສັງທຽບຮຽນບຳລຸງ/ 4 = ລົງທະບຽນຮຽນບຳລຸງ
                Dim type As String = ""
                If (dt.Rows(i).Item("register_type") = 1) Then
                    type = "ລົງທະບຽນເສັງທຽບຮຽນ"
                ElseIf (dt.Rows(i).Item("register_type") = 2) Then
                    type = "ລົງທະບຽນຮຽນ"
                ElseIf (dt.Rows(i).Item("register_type") = 3) Then
                    type = "ລົງທະບຽນເສັງທຽບຮຽນບຳລຸງ"
                Else
                    type = "ລົງທະບຽນຮຽນບຳລຸງ"
                End If

                .Rows.Add(dt.Rows(i).Item("open_close_id"), (i + 1), type, _
                         Format(CDate(dt.Rows(i).Item("open_date")), "dd/MM/yyyy"), Format(CDate(dt.Rows(i).Item("close_date")), "dd/MM/yyyy"), st, _
                         dt.Rows(i).Item("open_close_des"), dt.Rows(i).Item("user_update"), dt.Rows(i).Item("last_update"))
            Next

            btn_add.Enabled = True
            If (.RowCount > 0) Then
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

    Private Sub chk_show_disable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_show_disable.CheckedChanged, chk_enroll.CheckedChanged, chk_enroll_train.CheckedChanged, chk_register.CheckedChanged, chk_register_train.CheckedChanged
        If (load_finishied = 0) Then
            Call LoadData()
        End If
    End Sub

End Class