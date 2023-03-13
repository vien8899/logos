Public Class Fm_SetSQLDB

    Private Sub btcalcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcalcel.Click
        Me.Close()
    End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        If (txtServerName.Text = "") Then
            MessageBox.Show("Please Enter Server name", "REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtServerName.Focus()
            Exit Sub
        End If
        If (txt_db_name.Text = "") Then
            MessageBox.Show("Please Enter Database name", "REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_db_name.Focus()
            Exit Sub
        End If
        If (txt_Username.Text = "") Then
            MessageBox.Show("Please Enter user name", "REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Focus()
            Exit Sub
        End If
        If (txt_Password.Text = "") Then
            MessageBox.Show("Please Enter password", "REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Password.Focus()
            Exit Sub
        End If

        StrconSQL = "Data Source=" & txtServerName.Text.Trim & ";Initial Catalog=" & txt_db_name.Text.Trim & ";User ID=" & txt_Username.Text.Trim & "; password=" & txt_Password.Text.Trim & ""
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = StrconSQL
                .Open()

                My.Settings.setting_svrname = txtServerName.Text.Trim
                My.Settings.setting_dbname = txt_db_name.Text.Trim
                My.Settings.setting_dbuser = txt_Username.Text.Trim
                My.Settings.setting_dbpass = txt_Password.Text.Trim
                My.Settings.Save()
                MessageBox.Show("Database Connected!!!")
                Me.Close()
            End With
        Catch ex As Exception
            MessageBox.Show("Database Connection Fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Fm_SetSQLDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServerName.Clear()
        txt_db_name.Clear()
        txt_Username.Clear()
        txt_Password.Clear()
        txtServerName.Focus()
    End Sub

End Class