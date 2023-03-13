Imports System.Data.SqlClient

Public Class FrmReg_Open_Closed_add

    Dim cur_date As String = ""
    Private Sub FrmUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        had_change_val = 0

        Call ClearData()
        Call getYearList()
        cur_date = Format(CDate(getCurrentDate()), "yyyy-MM-dd")
        DateTimePicker1.Text = CDate(cur_date)
        DateTimePicker1.MinDate = CDate(cur_date)
        DateTimePicker2.MinDate = DateTimePicker1.MinDate
    End Sub

    Private Sub getYearList()
        cb_year.Items.Clear()
        Dim cur_year As Integer = CInt(Format(CDate(getCurrentDate()), "yyyy"))
        cb_year.Items.Add(cur_year & "-" & cur_year + 1)
        'cb_year.Items.Add(cur_year + 1 & "-" & cur_year + 2)
        cb_year.SelectedIndex = 0
    End Sub

    Private Sub ClearData()
        txt_comment.Text = "--"
        cb_year.Select()
    End Sub

    Private Sub add_new_user()
        If (rdo_enroll.Checked = False And rdo_register.Checked) Then
            MessageBox.Show("Seasion(Term) is required.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdo_enroll.Focus()
            Exit Sub
        End If

        Dim st_date As String = Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd")
        Dim end_date As String = Format(CDate(DateTimePicker2.Text), "yyyy-MM-dd")
        Dim cmt As String = "--"
        If (txt_comment.Text.Trim <> "") Then
            cmt = txt_comment.Text.Trim
        End If

        'Enroll/Register
        Dim enroll_or_register As Integer = 1
        If (rdo_register.Checked = True) Then
            enroll_or_register = 2
        End If

        Call ConnectDB()
        Sql = "INSERT INTO tbl_setting_open_close_reg(year_study ,open_date ,close_date ,open_close_des ,enroll_or_register ,open_close_type ,user_update) "
        Sql &= " VALUES(@year_study ,@open_date ,@close_date ,@open_close_des ,@enroll_or_register ,@open_close_type ,@user_update)"
        cm = New SqlCommand(Sql, conn)
        cm.Parameters.AddWithValue("year_study", cb_year.SelectedItem)
        cm.Parameters.AddWithValue("open_date", st_date)
        cm.Parameters.AddWithValue("close_date", end_date)
        cm.Parameters.AddWithValue("open_close_des", cmt)
        cm.Parameters.AddWithValue("enroll_or_register", enroll_or_register)
        cm.Parameters.AddWithValue("open_close_type", de_or_se)
        cm.Parameters.AddWithValue("user_update", User_name)
        cm.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Add info completed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call FrmReg_Open_Closed_view.LoadData()
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Call add_new_user()
        'MsgBox(cb_user_group.SelectedValue)
    End Sub

    Private Sub btn_disable_Click_1(sender As Object, e As EventArgs) Handles btn_disable.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value.Date
    End Sub

End Class