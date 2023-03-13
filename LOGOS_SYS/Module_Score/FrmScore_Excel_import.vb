Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmScore_Excel_import
    Dim excelDataAdapter As OleDbDataAdapter
    Dim student_data As Dictionary(Of String, String)
    Dim student_code_str As String
    Public term_id As String
    Public school_year As String
    Private Sub FrmScore_Excel_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_des.Text = "ເຂົ້າຄະແນນນັກສຶກສາ ຫຼັກສູດ " & FrmScore_Import.scheme_name & "-" & FrmScore_Import.course & ", ສົກຮຽນ: " & FrmScore_Import.school_year & ", " & FrmScore_Import.cb_term.Text & vbNewLine
        lb_des.Text &= "ວິຊາ: " & FrmScore_Import.cb_subject.Text
        student_data = New Dictionary(Of String, String)
        student_code_str = "("
        For Each row As DataGridViewRow In FrmScore_Import.DGV.Rows
            student_data.Add(row.Cells("student_code").Value.ToString(), row.Cells("student_id").Value.ToString())
            student_code_str &= "'" & row.Cells("student_code").Value.ToString() & "',"
        Next
        student_code_str = student_code_str.Substring(0, (student_code_str.Length - 1)) & ")"
        'MessageBox.Show(student_code_str)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim openExcel As OpenFileDialog = New OpenFileDialog()
        openExcel.Filter = "Excel file (*.xlsx)|*.xlsx|Excel 2003 file (*.xls)|*.xls|All files (*.*)|*.*"
        If openExcel.ShowDialog() = DialogResult.OK Then
            lb_file.Text = openExcel.FileName
            Me.Cursor = Cursors.WaitCursor
            Dim excelCommand As OleDbCommand = New OleDbCommand()
            excelDataAdapter = New OleDbDataAdapter()
            Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + lb_file.Text + ";Extended Properties='Excel 12.0;IMEX=1;'"
            Dim conn As OleDbConnection = New OleDbConnection(strcon)
            conn.Open()
            Dim dtsheet As DataTable = New DataTable()
            dtsheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            cb_worksheet.Items.Clear()
            For i As Integer = 0 To (dtsheet.Rows.Count - 1)
                Dim sheets As String = dtsheet.Rows(i).Item("Table_name").ToString()
                sheets = sheets.Replace("#", ".")
                sheets = sheets.Replace("'", "")
                If sheets.EndsWith("$") Then
                    sheets = sheets.Replace("$", "")
                    cb_worksheet.Items.Add(sheets)
                End If
            Next
            cb_worksheet.SelectedIndex = 0
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cb_worksheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_worksheet.SelectedIndexChanged
        If Not cb_worksheet.Text = "" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + lb_file.Text + ";Extended Properties='Excel 12.0;IMEX=1;'"
                Dim conn As OleDbConnection = New OleDbConnection(strcon)
                excelDataAdapter = New OleDbDataAdapter("select*from [" & cb_worksheet.Text & "$]", conn)
                Dim data As DataTable = New DataTable()
                excelDataAdapter.Fill(data)
                DGV.DataSource = data
                addcbValues()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub addcbValues()
        cb_student_code.Items.Clear()
        cb_score.Items.Clear()
        cb_student_code.Items.Add("None")
        cb_score.Items.Add("None")
        For Each col As DataGridViewColumn In DGV.Columns
            If col.Visible Then
                cb_student_code.Items.Add(col.HeaderText)
                cb_score.Items.Add(col.HeaderText)
            End If
        Next
        cb_student_code.SelectedIndex = 0
        cb_score.SelectedIndex = 0
    End Sub

    Private Sub DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DGV.RowPostPaint
        For Each row As DataGridViewRow In DGV.Rows
            row.ContextMenuStrip = cms
        Next
    End Sub

    Private Sub DGV_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            DGV.CurrentCell = DGV(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub deleteRow_Click(sender As Object, e As EventArgs) Handles deleteRow.Click
        DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSave.ItemClick
        If Not DGV.RowCount = 0 Then
            If Not cb_student_code.Text = "None" Then
                If Not cb_score.Text = "None" Then
                    DGV.Columns("remark").Visible = True
                    For Each row As DataGridViewRow In DGV.Rows
                        If student_data.ContainsKey(row.Cells(cb_student_code.Text).Value.ToString()) Then
                            Call ConnectDB()
                            Dim student_id As String = student_data(row.Cells(cb_student_code.Text).Value.ToString())
                            Sql = "select count(*) from tbl_student_score where subject_id='" & FrmScore_Import.subject_id & "' AND student_id='" & student_id & "'"
                            cm = New SqlCommand(Sql, conn)
                            Dim item_count As Integer = Convert.ToInt32(cm.ExecuteScalar())
                            If item_count > 0 Then
                                'has value then update old value
                                Try
                                    Sql = "UPDATE tbl_student_score SET score=@score, last_update=getdate(), user_update=@user_update WHERE student_id=@student_id AND subject_id=@subject_id"
                                    cm = New SqlCommand(Sql, conn)
                                    cm.Parameters.AddWithValue("score", row.Cells(cb_score.Text).Value.ToString())
                                    cm.Parameters.AddWithValue("user_update", User_name)
                                    cm.Parameters.AddWithValue("student_id", student_id)
                                    cm.Parameters.AddWithValue("subject_id", FrmScore_Import.subject_id.Trim)
                                    cm.ExecuteNonQuery()
                                    DGV.Rows(row.Index).Cells("remark").Value = "Success !"
                                Catch ex As Exception
                                    DGV.Rows(row.Index).Cells("remark").Value = "failed"
                                    DGV.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Red
                                End Try
                            Else
                                'create new item record
                                Try
                                    Sql = "INSERT INTO tbl_student_score(subject_id,student_id,score,study_year,term_id,create_date,last_update,user_update) "
                                    Sql &= " values(@subject_id,@student_id,@score,@study_year,@term_id,getdate(),getdate(),@user_update)"
                                    cm = New SqlCommand(Sql, conn)
                                    cm.Parameters.AddWithValue("subject_id", FrmScore_Import.subject_id.Trim)
                                    cm.Parameters.AddWithValue("student_id", student_id)
                                    cm.Parameters.AddWithValue("score", row.Cells(cb_score.Text).Value.ToString())
                                    cm.Parameters.AddWithValue("study_year", school_year)
                                    cm.Parameters.AddWithValue("term_id", term_id)
                                    cm.Parameters.AddWithValue("user_update", User_name)
                                    cm.ExecuteNonQuery()
                                    DGV.Rows(row.Index).Cells("remark").Value = "Success !"
                                Catch ex As Exception
                                    DGV.Rows(row.Index).Cells("remark").Value = "failed"
                                    DGV.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Red
                                End Try
                            End If
                        Else
                            DGV.Rows(row.Index).Cells("remark").Value = "ລະຫັດນັກສຶກສາບໍ່ກົງ"
                            DGV.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Gold
                        End If
                    Next
                    MessageBox.Show("success !")
                Else
                    MessageBox.Show("Select score column first")
                End If
            Else
                MessageBox.Show("Select Student ID first")
            End If
        End If
    End Sub

    Private Sub FrmScore_Excel_import_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmScore_Import.load_student_data()
    End Sub
End Class