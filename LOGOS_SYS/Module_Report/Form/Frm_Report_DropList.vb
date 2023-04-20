Public Class Frm_Report_DropList

    Dim load_finishied As Integer = 1
    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data
        load_finishied = 1
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        Call getYearList()
        load_finishied = 0
    End Sub

    Private Sub getYearList()
        cb_year.Items.Clear()
        cb_year.Items.Add("ເລືອກທັງໝົດ")
        Dim cur_year As Integer = CInt(Format(CDate(cur_date), "yyyy")) - 8
        Dim i As Integer = 9
        While i > 0
            cb_year.Items.Add(cur_year + i & "-" & cur_year + i + 1)
            i -= 1
        End While
        cb_year.SelectedIndex = 0
    End Sub

    Public Sub LoadData()
        Cursor = Cursors.WaitCursor
        Dim ct_sokhien As String = ""
        Dim stoping As Integer = 1
        Dim unstoping As Integer = 0

        If (chk_droping.Checked = False) Then
            stoping = 3
        End If
        If (chk_undrop.Checked = False) Then
            unstoping = 3
        End If

        Dim ct_payment As String = " AND (drop_status IN(" & stoping & "," & unstoping & "))"
        If (cb_year.SelectedIndex <> 0) Then
            ct_sokhien = " AND (at_sokhien = '" & CStr(cb_year.SelectedItem) & "')"
        End If

        Sql = "SELECT * FROM view_std_drop "
        Sql &= " WHERE(drop_id > 0) " & ct_sokhien
        Sql &= " ORDER BY scheme_id, course_id, at_sokhien "
        dt = ExecuteDatable(Sql)
        Dim crt As New Rpt_StudentDrop_List
        crt.SetDataSource(dt)

        crt.SetParameterValue("user_print", User_name)
        crt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        'Show Report
        FrmReport_A4.CrystalReportViewer1.ReportSource = crt
        FrmReport_A4.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub btn_SetClass_Search_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Search.Click
        Call LoadData()
    End Sub

    Private Sub btn_SetClass_Clear_Click(sender As Object, e As EventArgs) Handles btn_SetClass_Clear.Click
        Me.Close()
    End Sub

End Class