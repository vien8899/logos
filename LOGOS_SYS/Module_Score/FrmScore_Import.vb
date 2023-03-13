Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking2010

Public Class FrmScore_Import
    Public scheme_name As String
    Public course As String
    Public subject_id As String
    Dim scheme_data As DataTable
    Dim course_data As DataTable
    Dim term_data As DataTable
    Dim subject_data As DataTable
    Dim course_id As String = ""
    Dim current_year As Integer = Convert.ToInt32(Now.ToString("yyyy"))
    Public school_year As String = current_year.ToString() & "-" & (current_year + 1).ToString()
    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

    Private Sub FrmScore_Import_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmScore_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        school_year1.Value = current_year
        school_year2.Value = current_year + 1
        load_scheme()
        load_subject(cb_term.SelectedValue.ToString())
    End Sub
    Private Sub load_scheme()
        Call ConnectDB()
        Sql = "SELECT*FROM tbl_setting_scheme WHERE scheme_status = 1;"
        scheme_data = New DataTable
        scheme_data = ExecuteDatable(Sql)
        btn_scheme.Buttons.Clear()
        Dim checked As Boolean = True
        For Each row As DataRow In scheme_data.Rows
            btn_scheme.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.BaseButton() {
                                        New WindowsUIButton(row("scheme_des_la").ToString(), My.Resources.Resources.Graduation20, -1,
                                                            ImageLocation.Default, ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, checked, True, Nothing,
                                                            row("scheme_id").ToString(), 1, False, False)
                                        })
            If checked Then
                load_course(row("scheme_id").ToString())
                scheme_name = row("scheme_des_la").ToString()
            End If
            checked = False
        Next
        'btn_scheme.Padding = New Padding(10, 0, 0, 0)
    End Sub

    Private Sub btn_scheme_ButtonChecked(sender As Object, e As ButtonEventArgs) Handles btn_scheme.ButtonChecked
        Dim btn As WindowsUIButton = e.Button
        load_course(btn.Tag.ToString())
        scheme_name = btn.Caption
    End Sub
    Private Sub load_course(scheme_id As String)
        Call ConnectDB()
        Sql = "SELECT*FROM tbl_setting_course WHERE course_status = 1 AND scheme_id=" & scheme_id
        course_data = New DataTable
        course_data = ExecuteDatable(Sql)
        btn_course.Buttons.Clear()
        Dim checked As Boolean = True
        For Each row As DataRow In course_data.Rows
            btn_course.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.BaseButton() {
                                        New WindowsUIButton(row("course_des_la").ToString(), My.Resources.Resources.Education20, -1,
                                                            ImageLocation.Default, ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, checked, True, Nothing,
                                                            row("course_id").ToString(), 1, False, False)
                                        })
            If checked Then
                load_term(row("course_id").ToString())
                course_id = row("course_id").ToString()
                course = row("course_des_la").ToString()
            End If
            checked = False
        Next
    End Sub
    Private Sub load_term(course_id As String)
        Call ConnectDB()
        Sql = "select term_id,term_no from view_term_list where course_id = " & course_id
        term_data = New DataTable
        term_data = ExecuteDatable(Sql)
        cb_term.DataSource = term_data
        cb_term.DisplayMember = "term_no"
        cb_term.ValueMember = "term_id"
    End Sub

    Private Sub school_year1_ValueChanged(sender As Object, e As EventArgs) Handles school_year1.ValueChanged
        school_year2.Value = school_year1.Value + 1
        school_year = school_year1.Value.ToString() & "-" & school_year2.Value.ToString()
        clear_data()
    End Sub

    Private Sub school_year2_ValueChanged(sender As Object, e As EventArgs) Handles school_year2.ValueChanged
        school_year1.Value = school_year2.Value - 1
        school_year = school_year1.Value.ToString() & "-" & school_year2.Value.ToString()
        clear_data()
    End Sub

    Private Sub btn_course_ButtonChecked(sender As Object, e As ButtonEventArgs) Handles btn_course.ButtonChecked
        Dim btn As WindowsUIButton = e.Button
        load_term(btn.Tag.ToString())
        course_id = btn.Tag.ToString()
        course = btn.Caption
    End Sub
    Private Sub load_subject(term_id As String)
        Try
            Call ConnectDB()
            Sql = "select subject_id,CONCAT(subject_name_la,'(',subject_name_en,')')'subject_name' from view_term_subject_list where term_id = " & term_id
            subject_data = New DataTable
            subject_data = ExecuteDatable(Sql)
            cb_subject.DataSource = subject_data
            cb_subject.DisplayMember = "subject_name"
            cb_subject.ValueMember = "subject_id"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cb_term_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_term.SelectedIndexChanged
        If Not cb_term.SelectedValue.ToString() = "System.Data.DataRowView" Then
            load_subject(cb_term.SelectedValue.ToString())
        End If
        clear_data()
    End Sub
    Public Sub load_student_data()
        Call ConnectDB()
        Try
            subject_id = cb_subject.SelectedValue.ToString()
            Sql = "select s.student_code,s.student_fullname_la,s.student_fullname_en,ss.score,case when ss.score=null then null else dbo.getGrade(ss.score) end as grade,s.student_id from tbl_term_register r "
            Sql &= " inner join tbl_student s on r.student_id = s.student_id left join (select*from tbl_student_score where subject_id='" & subject_id & "') as ss on s.student_id = ss.student_id "
            Sql &= " where register_year = '" & school_year & "' AND r.term_id = '" & cb_term.SelectedValue.ToString() & "' AND s.course_id='" & course_id & "'"
            dt = ExecuteDatable(Sql)
            DGV.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Dim dt As DataTable
            dt = New DataTable()
            Dim column1 As DataColumn = New DataColumn("student_code")
            column1.DataType = System.Type.GetType("System.String")
            Dim column2 As DataColumn = New DataColumn("student_fullname_la")
            column2.DataType = System.Type.GetType("System.String")
            Dim column3 As DataColumn = New DataColumn("student_fullname_en")
            column3.DataType = System.Type.GetType("System.String")
            Dim column4 As DataColumn = New DataColumn("score")
            column4.DataType = System.Type.GetType("System.Int32")
            Dim column5 As DataColumn = New DataColumn("grade")
            column5.DataType = System.Type.GetType("System.String")
            Dim column6 As DataColumn = New DataColumn("student_id")
            column6.DataType = System.Type.GetType("System.String")
            dt.Columns.Add(column1)
            dt.Columns.Add(column2)
            dt.Columns.Add(column3)
            dt.Columns.Add(column4)
            dt.Columns.Add(column5)
            dt.Columns.Add(column6)
            DGV.DataSource = dt
        End Try

    End Sub

    Private Sub btnSearch_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSearch.ItemClick
        load_student_data()
    End Sub

    Private Sub btnImport_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnImport.ItemClick
        If DGV.Rows.Count = 0 Then
            MessageBox.Show("Data not found !")
        Else
            Dim frm = New FrmScore_Excel_import()
            frm.term_id = cb_term.SelectedValue.ToString()
            frm.school_year = school_year1.Value.ToString() & "-" & school_year2.Value.ToString()
            frm.ShowDialog()
        End If
    End Sub
    Private Sub clear_data()
        Dim dt As DataTable
        dt = New DataTable()
        Dim column1 As DataColumn = New DataColumn("student_code")
        column1.DataType = System.Type.GetType("System.String")
        Dim column2 As DataColumn = New DataColumn("student_fullname_la")
        column2.DataType = System.Type.GetType("System.String")
        Dim column3 As DataColumn = New DataColumn("student_fullname_en")
        column3.DataType = System.Type.GetType("System.String")
        Dim column4 As DataColumn = New DataColumn("score")
        column4.DataType = System.Type.GetType("System.Int32")
        Dim column5 As DataColumn = New DataColumn("grade")
        column5.DataType = System.Type.GetType("System.String")
        Dim column6 As DataColumn = New DataColumn("student_id")
        column6.DataType = System.Type.GetType("System.String")
        dt.Columns.Add(column1)
        dt.Columns.Add(column2)
        dt.Columns.Add(column3)
        dt.Columns.Add(column4)
        dt.Columns.Add(column5)
        dt.Columns.Add(column6)
        DGV.DataSource = dt
    End Sub

    Private Sub cb_subject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_subject.SelectedIndexChanged
        clear_data()
    End Sub

    Private Sub btn_course_Click(sender As Object, e As EventArgs) Handles btn_course.Click
        clear_data()
    End Sub

    Private Sub btn_scheme_Click(sender As Object, e As EventArgs) Handles btn_scheme.Click
        clear_data()
    End Sub
End Class