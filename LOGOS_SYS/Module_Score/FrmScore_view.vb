Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking2010
Public Class FrmScore_view
    Public scheme_name As String
    Public course As String
    Dim scheme_data As DataTable
    Dim course_data As DataTable
    Dim study_year_data As DataTable
    Dim term_data As DataTable
    Dim subject_data As DataTable
    Dim course_id As String = ""
    Dim start_year As String = Today().Year.ToString()
    Dim end_year As String = (Today().Year + 1).ToString()
    Dim school_year = start_year & "-" & end_year
    Private Sub FrmScore_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_startyear.Text = start_year
        txt_endyear.Text = end_year
        load_scheme()
        'load_columns()
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
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
                load_year(row("course_id").ToString())
                'load_term(row("course_id").ToString())
                course_id = row("course_id").ToString()
                course = row("course_des_la").ToString()
            End If
            checked = False
        Next
        If course_data.Rows.Count = 0 Then
            clear_data()
        End If
    End Sub
    Private Sub load_year(course_id As String)
        Call ConnectDB()
        Sql = "SELECT term_study_year'study_year',CONCAT(N'ປີ ',term_study_year)'study_year_des' FROM view_term_list WHERE course_id=" & course_id & " GROUP BY term_study_year"
        study_year_data = New DataTable
        study_year_data = ExecuteDatable(Sql)
        cb_year.DataSource = study_year_data
        cb_year.DisplayMember = "study_year_des"
        cb_year.ValueMember = "study_year"
        If study_year_data.Rows.Count > 0 Then
            load_term(course_id, cb_year.SelectedValue.ToString())
        Else
            clear_data()
        End If
    End Sub
    Private Sub load_term(course_id As String, year_no As String)
        Call ConnectDB()
        Sql = "select term_id,term_no from view_term_list where course_id = " & course_id & " AND term_study_year<= " & year_no
        term_data = New DataTable
        term_data = ExecuteDatable(Sql)
        cb_term.DataSource = term_data
        cb_term.DisplayMember = "term_no"
        cb_term.ValueMember = "term_id"
        If term_data.Rows.Count > 0 Then
            load_columns()
        End If
    End Sub

    Private Sub btn_scheme_ButtonChecked(sender As Object, e As ButtonEventArgs) Handles btn_scheme.ButtonChecked
        Dim btn As WindowsUIButton = e.Button
        load_course(btn.Tag.ToString())
        scheme_name = btn.Caption
    End Sub
    Private Sub clear_data()
        cb_year.DataSource = New DataTable
        cb_term.DataSource = New DataTable
        DGV.DataSource = New DataTable
        DGV.Columns.Clear()
        Dim col_student_code As New DataGridViewTextBoxColumn
        Dim col_student_fullname As New DataGridViewTextBoxColumn
        Dim col_classroom_des As New DataGridViewTextBoxColumn
        col_student_code.Name = "student_code"
        col_student_code.DataPropertyName = "student_code"
        col_student_code.HeaderText = "ລະຫັດນັກສຶກສາ"
        col_student_code.Width = 150
        col_student_fullname.Name = "student_fullname_la"
        col_student_fullname.DataPropertyName = "student_fullname_la"
        col_student_fullname.HeaderText = "ຊື່ ແລະ ນາມສະກຸນ"
        col_student_fullname.Width = 350
        col_classroom_des.Name = "classroom_des"
        col_classroom_des.DataPropertyName = "classroom_des"
        col_classroom_des.HeaderText = "ຫ້ອງຮຽນ"
        col_classroom_des.Width = 100
        DGV.Columns.Add(col_student_code)
        DGV.Columns.Add(col_student_fullname)
        DGV.Columns.Add(col_classroom_des)
        Dim col_act As New DataGridViewTextBoxColumn
        col_act.Name = "act"
        col_act.DataPropertyName = "act"
        col_act.HeaderText = ""
        col_act.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV.Columns.Add(col_act)
        DGV.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub btn_course_ButtonChecked(sender As Object, e As ButtonEventArgs) Handles btn_course.ButtonChecked
        Dim btn As WindowsUIButton = e.Button
        load_year(btn.Tag.ToString())
        course_id = btn.Tag.ToString()
        course = btn.Caption
    End Sub
    Private Sub load_columns()
        DGV.Columns.Clear()
        DGV.DataSource = New DataTable
        Dim col_student_code As New DataGridViewTextBoxColumn
        Dim col_student_fullname As New DataGridViewTextBoxColumn
        Dim col_classroom_des As New DataGridViewTextBoxColumn
        col_student_code.Name = "student_code"
        col_student_code.DataPropertyName = "student_code"
        col_student_code.HeaderText = "ລະຫັດນັກສຶກສາ"
        col_student_code.Width = 150
        col_student_fullname.Name = "student_fullname_la"
        col_student_fullname.DataPropertyName = "student_fullname_la"
        col_student_fullname.HeaderText = "ຊື່ ແລະ ນາມສະກຸນ"
        col_student_fullname.Width = 350
        col_classroom_des.Name = "classroom_des"
        col_classroom_des.DataPropertyName = "classroom_des"
        col_classroom_des.HeaderText = "ຫ້ອງຮຽນ"
        col_classroom_des.Width = 100
        DGV.Columns.Add(col_student_code)
        DGV.Columns.Add(col_student_fullname)
        DGV.Columns.Add(col_classroom_des)
        Call ConnectDB()
        'MessageBox.Show(cb_year.SelectedValue.ToString())
        'Sql = "select s.subject_id, s.subject_name_en from tbl_student_score sc inner join tbl_setting_subject s on sc.subject_id=s.subject_id where "
        'Sql &= "study_year=(select CONCAT((YEAR(GETDATE())-((" & cb_year.SelectedValue.ToString() & "-term_study_year))),'-',YEAR(GETDATE())-((" & cb_year.SelectedValue.ToString() & "-term_study_year))+1) "
        'Sql &= "from view_term_list where term_id = " & cb_term.SelectedValue.ToString() & ") AND term_id = " & cb_term.SelectedValue.ToString() & " group by s.subject_id, s.subject_name_en"
        Sql = "select s.subject_id, s.subject_name_en from tbl_student_score sc inner join tbl_setting_subject s on sc.subject_id=s.subject_id where "
        Sql &= " term_id = '" & cb_term.SelectedValue.ToString() & "' AND sc.student_id in (select s.student_id from tbl_term_register r inner join "
        Sql &= " tbl_student s on r.student_id = s.student_id where register_year ='" & school_year & "' AND s.course_id='" & course_id & "' "
        Sql &= " AND r.term_id in (select term_id from view_term_list where term_study_year='" & cb_year.SelectedValue.ToString() & "') group by s.student_id)"
        Sql &= " group by s.subject_id, s.subject_name_en"
        subject_data = New DataTable
        subject_data = ExecuteDatable(Sql)
        For Each row As DataRow In subject_data.Rows
            Dim col As New DataGridViewTextBoxColumn
            col.Name = "s" & row(0)
            col.DataPropertyName = "s" & row(0)
            col.HeaderText = row(1)
            DGV.Columns.Add(col)
        Next
        Dim col_act As New DataGridViewTextBoxColumn
        col_act.Name = "act"
        col_act.DataPropertyName = "act"
        col_act.HeaderText = ""
        col_act.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV.Columns.Add(col_act)
        DGV.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub cb_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_year.SelectedIndexChanged
        If Not cb_year.SelectedValue.ToString() = "System.Data.DataRowView" Then
            load_term(course_id, cb_year.SelectedValue.ToString())
        End If
    End Sub

    Private Sub cb_term_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_term.SelectedIndexChanged
        If Not cb_term.SelectedValue.ToString() = "System.Data.DataRowView" Then
            load_columns()
        End If
    End Sub

    Private Sub DGV_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DGV.CellPainting
        If e.RowIndex = -1 And e.ColumnIndex > 2 Then
            Dim format As StringFormat = New StringFormat(StringFormatFlags.FitBlackBox)
            Dim Rectf As RectangleF = New Rectangle(5, 5, 160, 80)
            e.PaintBackground(e.CellBounds, True)
            e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom)
            e.Graphics.RotateTransform(270)
            e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.White, Rectf, format)
            e.Graphics.ResetTransform()
            e.Handled = True
        End If
    End Sub

    Private Sub btn_showdata_Click(sender As Object, e As EventArgs) Handles btn_showdata.Click
        If (subject_data.Rows.Count > 0) Then
            Dim query_str As String = "select s.student_code,CONCAT((CASE WHEN (s.student_gender=1) THEN N'ທ້າວ' ELSE N'ນາງ' END),' ',s.student_fullname_la)'student_fullname_la', c.class_des'classroom_des',"
            For Each row As DataRow In subject_data.Rows
                query_str &= " (SELECT FORMAT(score,'#.0') FROM tbl_student_score WHERE subject_id=" & row(0) & " AND student_id=s.student_id)'s" & row(0) & "',"
            Next
            query_str = query_str.Substring(0, query_str.Length - 1)
            'query_str &= " ,null as 'act' from tbl_term_register r inner join tbl_student s on r.student_id = s.student_id left join tbl_setting_class c on s.class_id = c.class_id "
            'query_str &= " where register_year =(select CONCAT((YEAR(GETDATE())-((" & cb_year.SelectedValue.ToString() & "-term_study_year))),'-',YEAR(GETDATE())-"
            'query_str &= "((" & cb_year.SelectedValue.ToString() & "-term_study_year))+1) from view_term_list where term_id = " & cb_term.SelectedValue.ToString() & ") "
            'query_str &= " AND r.term_id='" & cb_term.SelectedValue.ToString() & "' AND s.course_id='" & course_id & "'"
            query_str &= " ,null as 'act' from tbl_term_register r inner join tbl_student s on r.student_id = s.student_id left join tbl_setting_class c on s.class_id = c.class_id "
            query_str &= " where r.term_id='" & cb_term.SelectedValue.ToString() & "' AND s.course_id='" & course_id & "' AND s.student_id in (select s.student_id from tbl_term_register r inner join "
            query_str &= " tbl_student s on r.student_id = s.student_id where register_year ='" & school_year & "' AND s.course_id='" & course_id & "' "
            query_str &= " AND r.term_id in (select term_id from view_term_list where term_study_year='" & cb_year.SelectedValue.ToString() & "') group by s.student_id)"
            Call ConnectDB()
            dt = New DataTable
            dt = ExecuteDatable(query_str)
            DGV.DataSource = dt
            'Dim frm = New frmtxt
            'frm.txt.Text = query_str
            'frm.ShowDialog()
        Else
            MessageBox.Show("No Data found !")
        End If
    End Sub
End Class