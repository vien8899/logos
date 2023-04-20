Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.OleDb

Module Module1

    'User Permission
    Public user_permission As List(Of get_permission)
    Public Function queryString(ByVal sql_sc As String) As String
        Call ConnectDB()
        Dim val As String
        cm = New SqlCommand(sql_sc, conn)
        val = cm.ExecuteScalar().ToString()
        Return val
    End Function

    Public Class get_permission
        Public view_user As Integer = 0
        Public modify_user As Integer = 0
        Public view_scheme As Integer = 0
        Public modify_scheme As Integer = 0
        Public view_course As Integer = 0
        Public modify_course As Integer = 0
        Public view_term As Integer = 0
        Public modify_term As Integer = 0
        Public view_class As Integer = 0
        Public modify_class As Integer = 0
        Public view_subject As Integer = 0
        Public modify_subject As Integer = 0
        Public view_learning_shift As Integer = 0
        Public modify_learning_shift As Integer = 0
        Public view_student_enroll As Integer = 0
        Public student_enroll_test As Integer = 0
        Public view_student_register As Integer = 0
        Public student_register As Integer = 0
        Public view_score As Integer = 0
        Public add_edit_score As Integer = 0
        Public add_edit_product As Integer = 0
        Public sale_product As Integer = 0
        Public view_report As Integer = 0
        Public set_printer_bill As Integer = 0
    End Class

    Public BILL_ID As String = ""
    Public BILL_ID2 As String = ""
    Public filter_term_course As String = ""
    Public had_change_val As Integer = 0
    Public conn As New SqlConnection
    Public active_menu As Integer = 0
    Public Sql As String = ""
    Public sql_rpt As String = ""
    Public ds As New DataSet
    Public dt As DataTable
    Public dtchk As DataTable
    Public da As SqlDataAdapter
    Public cm As SqlCommand
    Public Rcount As Integer = 0
    Public Rpt_print As Integer = 0
    Public User_ID As Integer = 0
    Public User_ID_edit As Integer = 0
    Public User_name As String = ""
    Public User_Fullname As String = ""
    Public id_edit As Integer = 0
    Public subject_filter As String = ""
    Public rpt_status As Integer = 0
    Public Rpt_OnlyView As Integer = 0
    Public print_copy_bill_register As Integer = 1
    Public print_copy_bill_enroll As Integer = 1
    Public print_copy_bill_sell As Integer = 1
    Public reg_number_of_term_where As String = ""
    'Public de_or_se As Integer = 1
    Public reg_search_where As String = ""
    Public select_student_from As Integer = 1
    Public select_term_where As String = ""
    Public number_of_term As Integer = 0
    Public start_year As Integer = 0

    Public StrconSQL, servername, dbname, dbuser, dbpass As String
    Public Sub ConnectDB()
        Try
            servername = My.Settings.setting_svrname
            dbname = My.Settings.setting_dbname
            dbuser = My.Settings.setting_dbuser
            dbpass = My.Settings.setting_dbpass

            StrconSQL = "Data Source=" & servername & ";Initial Catalog=" & dbname & ";User ID=" & dbuser & "; password=" & dbpass & ""
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = StrconSQL
                .Open()
                'MessageBox.Show("success")
            End With
        Catch ex As Exception
            MessageBox.Show("Connection Database fail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function ExecuteDatable(ByVal sql As String) As DataTable
        Call ConnectDB()
        da = New SqlDataAdapter(sql, conn)
        ds.Tables.Clear()
        da.Fill(ds, "tb")
        dt = ds.Tables("tb")
        Return dt
        conn.Close()
    End Function

    Public Sub ExecuteInsert(ByVal sql As String)
        Call ConnectDB()
        cm = New SqlCommand(sql, conn)
        cm.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub ExecuteUpdate(ByVal sql As String)
        Call ConnectDB()
        cm = New SqlCommand(sql, conn)
        cm.ExecuteNonQuery()
        conn.Close()
    End Sub

    Function getCurrentDate() As String
        Sql = "SELECT GETDATE() AS cur_date "
        dt = ExecuteDatable(Sql)
        Return dt.Rows(0).Item("cur_date")
    End Function

    'Public Sub ExecuteUpdateBG(ByVal img As Byte())
    '    Call ConnectDB()
    '    Dim sql As String = ""
    '    sql = "UPDATE Tb_Picture SET Logo=@pic, status= 1 WHERE pic_id=1"
    '    cm = New SqlCommand(sql, conn)
    '    cm.Parameters.AddWithValue("pic", img)
    '    cm.ExecuteNonQuery()
    '    conn.Close()
    'End Sub

    Public Sub ExecuteDelete(ByVal sql As String)
        Call ConnectDB()
        cm = New SqlCommand(sql, conn)
        cm.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function MD5(ByVal number As String) As String
        Dim ASCIIenc As New ASCIIEncoding
        Dim strReturn As String
        strReturn = vbNullString
        Dim ByteSourceText() As Byte = ASCIIenc.GetBytes(number)
        Dim Md5Hash As New MD5CryptoServiceProvider
        Dim ByteHash() As Byte = Md5Hash.ComputeHash(ByteSourceText)
        For Each b As Byte In ByteHash
            strReturn &= b.ToString("x2")
        Next
        Return strReturn
    End Function

    Public Function Max_Bill_id(ByVal first_text As String, ByVal tb_name As String, ByVal field_name As String) As String 'Max Bill ID
        Sql = "SELECT MAX(" & field_name & ") AS max_id FROM " & tb_name & " "
        dt = ExecuteDatable(Sql)
        Dim max_id As String = Mid(dt.Rows(0).Item("max_id").ToString(), 5, 6)
        Dim id_no As Integer = 0
        If (max_id = "") Then
            id_no = 0
        Else
            id_no = Convert.ToInt64(max_id)
        End If
        Dim id_up As Integer = id_no + 1
        Dim true_id As String = ""
        Dim len As String = id_up
        If (len.Length = 1) Then
            true_id = first_text & "00000" & id_up
        ElseIf (len.Length = 2) Then
            true_id = first_text & "0000" & id_up
        ElseIf (len.Length = 3) Then
            true_id = first_text & "000" & id_up
        ElseIf (len.Length = 4) Then
            true_id = first_text & "00" & id_up
        ElseIf (len.Length = 5) Then
            true_id = first_text & "0" & id_up
        Else
            true_id = first_text & id_up
        End If
        Return true_id
        conn.Close()
    End Function

    Public Sub AddStudentLog(ByVal student_id As Integer, ByVal action_detail As String)
        Call ConnectDB()
        Dim sql As String = ""
        sql = "INSERT INTO tbl_student_log(student_id, action_detail, action_by) "
        sql &= " VALUES(@student_id, @action_detail, @action_by)"
        cm = New SqlCommand(sql, conn)
        cm.Parameters.AddWithValue("student_id", student_id)
        cm.Parameters.AddWithValue("action_detail", action_detail)
        cm.Parameters.AddWithValue("action_by", User_name)
        cm.ExecuteNonQuery()
        conn.Close()
    End Sub

End Module


