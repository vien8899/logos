Imports System.Data.SqlClient

Public Class FrmSale

    Dim COLLE As New DataSet
    Dim added As Boolean = False
    Dim save As Boolean = False
    Public dbset As New DataSet
    Dim NoE As Integer
    Dim fileCon As String
    Dim total As Double
    Dim Pro_ID As String = ""
    Dim Pro_name As String = ""
    Dim Pro_price As Double = 0
    Dim Task As String = ""

    Private Sub Fm_Menu_Sale_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If (had_change_val = 1) Then
            Call FrmSale_view.LoadData()
        End If
    End Sub

    Dim load_fn As Integer = 1
    Dim sell_point As String = ""
    Private Sub Fm_CheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call First_Load()
        load_fn = 0
    End Sub

    Private Sub First_Load()
        Call SearchMaincat()
        Call DatagridExpress1()
        Call DatagridExpress2()
        btnConfirmRC.Enabled = False
        gbPayment.Enabled = False
        btnDel_Menu.Enabled = False

        DataGridView1.Enabled = True
        DataGridView2.Enabled = True
        gbAddmenu.Enabled = True
        txt_percent_dis.ReadOnly = False
        panel_paytype.Enabled = False

        btnConfirmRC.Enabled = False
        rdo_cash.Checked = True
        rdo_card.Checked = False

        Call clear_text()
        txtsearch.Focus()
    End Sub

    Private Sub clear_text()
        txt_percent_dis.Text = "0.00"
        txtTotal_All.Clear()
        txt_total_pay.Clear()
        txt_discount.Clear()
    End Sub

    Private Sub DatagridExpress1()
        With DataGridView1
            .ColumnHeadersHeight = "35"
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersWidth = "25"
            .ForeColor = Color.Black
            .GridColor = Color.DarkGray
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'pro_id, 0, name_la, name_en, price1
            .Columns(0).Visible = False ' pro_id
            .Columns(1).HeaderText = "ລຳດັບ"
            .Columns(2).HeaderText = "ຊື່ລາຍການ(LAO)"
            .Columns(3).HeaderText = "ຊື່ລາຍການ(EN)"
            .Columns(4).HeaderText = "ລາຄາຂາຍ"
            .Columns(4).DefaultCellStyle.Format = "N0"

            .Columns(1).Width = 50
            .Columns(2).Width = 160
            .Columns(3).Width = 160
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For i As Integer = 0 To .RowCount - 1
                .Rows(i).Cells(1).Value = i + 1
            Next
        End With
    End Sub

    Private Sub DatagridExpress2()
        Call ConnectDB()
        Sql = "SELECT  product_id ,0 , product_name_la ,product_name_en ,0 ,sell_price, 0 "
        Sql &= " FROM tbl_product "
        Sql &= " WHERE product_id=999999999"
        da = New SqlDataAdapter(Sql, conn)
        COLLE.Tables.Clear()
        da.Fill(COLLE, 0)
        DataGridView2.DataSource = COLLE.Tables(0)
        With DataGridView2
            .ColumnHeadersHeight = "35"
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersWidth = "25"
            .ForeColor = Color.Black
            .GridColor = Color.DarkGray
            .Columns(0).Visible = False ' prod_id
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderText = "ລຳດັບ"
            .Columns(2).HeaderText = "ຊື່ລາຍການ(LAO)"
            .Columns(3).HeaderText = "ຊື່ລາຍການ(EN)"
            .Columns(4).HeaderText = "ຈຳນວນ"
            .Columns(5).HeaderText = "ລາຄາຂາຍ"
            .Columns(6).HeaderText = "ລວມເງິນ"

            .Columns(6).DefaultCellStyle.Format = "N0"
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns(5).DefaultCellStyle.Format = "N0"

            .Columns(1).Width = 42
            .Columns(2).Width = 140
            .Columns(3).Width = 140
            .Columns(4).Width = 55
            .Columns(5).Width = 70
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = False
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True

            For i As Integer = 0 To .RowCount - 1
                .Rows(i).Cells(1).Value = i + 1
            Next

        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAddMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMenu.Click
        Call Addmenu()
    End Sub

    Private Sub Addmenu()
        Try
            Pro_price = DataGridView1.CurrentRow.Cells(4).Value
        Catch ex As Exception
        End Try
        Dim remark As String = "--"
        If (Chk_free.Checked = True) Then
            Pro_price = 0
            remark = "FREE"
        End If
        If (DataGridView1.RowCount > 0) Then
            If (txtAmount_Food.Text) = "" Then
                MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນອາຫານຫຼືເຄື່ອງດື່ມທີ່ທ່ານຕ້ອງການເພີ່ມກ່ອນ", "ແນະນຳ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAmount_Food.Text = 1
                txtAmount_Food.Focus()
                Exit Sub
            End If
            Dim ia, rindex As Integer
            If DataGridView2.Rows.Count > 0 Then
                For ia = 0 To COLLE.Tables(0).Rows.Count - 1
                    If (DataGridView2.Rows(ia).Cells(0).Value = Pro_ID) And (DataGridView2.Rows(ia).Cells(5).Value = Pro_price) Then
                        rindex = ia
                        added = True
                        Exit For
                    Else
                        added = False
                    End If
                Next
            End If


            With DataGridView1.CurrentRow
                If added = True Then
                    DataGridView2.Rows(rindex).Cells(4).Value = DataGridView2.Rows(rindex).Cells(4).Value + Val(txtAmount_Food.Text)
                    added = False
                Else
                    Try

                        ' pro_id, no, product_name_la, product_name_en, price (G1)
                        ' pro_id, no, product_name_la, product_name_en, qty, price, total (G2)

                        COLLE.Tables(0).Rows.Add( _
                       .Cells(0).Value, _
                       0, _
                       .Cells(2).Value, _
                       .Cells(3).Value, _
                       Val(txtAmount_Food.Text), _
                       Pro_price, _
                       (.Cells(4).Value * Val(txtAmount_Food.Text)))
                        DataGridView2.Refresh()
                    Catch ex As Exception
                        MsgBox("ກະລຸນາເລືອກລາຍການກ່ອນ ເພີ່ມ", MsgBoxStyle.OkOnly)
                    End Try

                End If

            End With

            Dim m As Integer
            Dim s As Double = 0
            For m = 0 To DataGridView2.Rows.Count - 1
                DataGridView2.Rows(m).Cells(1).Value = m + 1
                DataGridView2.Rows(m).Cells(6).Value = (DataGridView2.Rows(m).Cells(5).Value * DataGridView2.Rows(m).Cells(4).Value)
                DataGridView2.Refresh()
                s += CDbl(DataGridView2.Rows(m).Cells(6).Value)
            Next
            txtTotal_All.Text = FormatNumber(s, 0, TriState.True)
            Dim t_pay As Double = txtTotal_All.Text
            Dim discout As Double = FormatNumber(((t_pay * CDbl(txt_percent_dis.Text.Trim)) / 100), 0, TriState.True)
            txt_discount.Text = FormatNumber(((t_pay * CDbl(txt_percent_dis.Text.Trim)) / 100), 0, TriState.True)
            txt_total_pay.Text = FormatNumber(t_pay - discout, 0, TriState.True)

            btnConfirmRC.Enabled = False
            With DataGridView2
                If .RowCount > 0 Then
                    btnDel_Menu.Enabled = True
                    gbPayment.Enabled = True
                    panel_paytype.Enabled = True
                    btnConfirmRC.Enabled = True
                End If
            End With
        Else
            MsgBox("Can not be add empty row.")
            Exit Sub
        End If
    End Sub

    Private Sub btnDel_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel_Menu.Click
        Try
            If DataGridView2.RowCount > 0 Then
                DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
                DataGridView2.Refresh()
                panel_paytype.Enabled = True
                Call SumTotal()
            End If
            If DataGridView2.RowCount < 1 Then
                txtTotal_All.Clear()
                btnDel_Menu.Enabled = False
                panel_paytype.Enabled = False
                gbPayment.Enabled = False
                txt_discount.Clear()
                txt_total_pay.Clear()
                txt_percent_dis.Text = "0.00"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Dim true_pay As Double = 0
    Private Sub SumTotal()
        If COLLE.Tables(0).Rows.Count > 0 Then
            Dim s As Double
            Dim m As Byte
            For m = 0 To COLLE.Tables(0).Rows.Count - 1
                DataGridView2.Rows(m).Cells(1).Value = m + 1
                DataGridView2.Rows(m).Cells(6).Value = (DataGridView2.Rows(m).Cells(5).Value * DataGridView2.Rows(m).Cells(4).Value)
                DataGridView2.Refresh()
                s += CDbl(DataGridView2.Rows(m).Cells(6).Value)
            Next
            txtTotal_All.Text = FormatNumber(s, 0, TriState.True)
            Dim t_pay As Double = txtTotal_All.Text
            Dim discout As Double = FormatNumber(((t_pay * CDbl(txt_percent_dis.Text.Trim)) / 100), 0, TriState.True)
            txt_discount.Text = FormatNumber(((t_pay * CDbl(txt_percent_dis.Text.Trim)) / 100), 0, TriState.True)
            true_pay = t_pay - discout
            txt_total_pay.Text = FormatNumber(true_pay, 0, TriState.True)
        End If

        btnConfirmRC.Enabled = False
        With DataGridView2
            If .RowCount > 0 Then
                btnDel_Menu.Enabled = True
                btnConfirmRC.Enabled = True
            End If
        End With
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Call Addmenu()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Pro_ID = DataGridView1.CurrentRow.Cells(0).Value 'ID auto
            Pro_price = DataGridView1.CurrentRow.Cells(4).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SearchMaincat()
        Sql = "SELECT product_id ,0 ,product_name_la ,product_name_en ,sell_price"
        Sql &= " FROM tbl_product"
        Sql &= " WHERE(sell_status=1) ORDER BY product_name_la, product_name_en "
        dt = ExecuteDatable(Sql)
        DataGridView1.DataSource = dt
        Call DatagridExpress1()
        txtsearch.Clear()
        txtsearch.Focus()
    End Sub

    Private Sub SearchCate()
        If txtsearch.Text.Trim <> "" Then
            Sql = "SELECT product_id ,0 ,product_name_la ,product_name_en ,sell_price"
            Sql &= " FROM tbl_product"
            Sql &= " WHERE(sell_status=1) AND ((product_name_la LIKE N'%" & txtsearch.Text.Trim & "%') OR (product_name_en LIKE N'%" & txtsearch.Text.Trim & "%'))"
            Sql &= " ORDER BY product_name_la, product_name_en "
            dt = ExecuteDatable(Sql)
            DataGridView1.DataSource = dt
            Call DatagridExpress1()
        Else
            Call SearchMaincat()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Call SearchCate()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        SearchCate()
    End Sub

    Private Sub cb_discount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim t_pay As Double = txtTotal_All.Text
            Dim discout As Double = FormatNumber(((t_pay * CDbl(txt_percent_dis.Text.Trim)) / 100), , TriState.True)
            txt_discount.Text = FormatNumber(((t_pay * CDbl(txt_percent_dis.Text.Trim)) / 100), , TriState.True)
            true_pay = t_pay - discout
            txt_total_pay.Text = FormatNumber(true_pay, , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call First_Load()
    End Sub

    Dim task_bill As String = ""
    Private Sub Btn_Print_Bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmRC.Click
        Cursor = Cursors.WaitCursor
        BILL_ID = Max_Bill_id("SAL-", "tbl_product_sell", "bill_id")

        'Payment
        Dim payment_type As Integer = 1
        If (rdo_card.Checked = True) Then
            payment_type = 2
        End If

        With DataGridView2
            For add As Integer = 0 To .RowCount - 1
                Sql = "INSERT INTO tbl_product_sell(bill_id ,product_id ,sell_qty ,sell_price ,sell_discount, sell_by_user ,sell_by_user_id, payment_type)"
                Sql &= " VALUES('" & BILL_ID & "',"
                Sql &= " " & .Rows(add).Cells(0).Value & ","
                Sql &= " " & CInt(.Rows(add).Cells(4).Value) & ","
                Sql &= " " & CDbl(.Rows(add).Cells(5).Value) & ","
                Sql &= " " & CDbl(txt_percent_dis.Text.Trim) & ", "
                Sql &= " '" & User_name & "', " & User_ID & ", "
                Sql &= " " & payment_type & ")"
                Call ExecuteInsert(Sql)
            Next
        End With

        'Print Bill
        rpt_status = 6
        Rpt_OnlyView = 0
        FrmReport_A5.ShowDialog()

        Call First_Load()
        had_change_val = 1
        Cursor = Cursors.Default
        'Me.Close()
    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        With DataGridView2
            'Dim sell_qty As Integer = .CurrentRow.Cells(4).Value
            'Dim stock_qty As Integer = .CurrentRow.Cells(7).Value
            'Dim chk_st As Integer = .CurrentRow.Cells(8).Value
            'If (sell_qty >= stock_qty) And (chk_st = 1) Then
            '    MessageBox.Show("ບໍ່ສາມາດຂາຍສິນຄ້າເກີນຈຳນວນທີມີຢູ່ໃນສາງໄດ້", "ແນະນຳ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    .CurrentRow.Cells(4).Value = stock_qty
            'End If
        End With

        Call SumTotal()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Call First_Load()
    End Sub

    Function get_amt_pay() As Double
        If (txtTotal_All.Text.Trim <> "") Then
            Return CDbl(txtTotal_All.Text)
        Else
            Return 0
        End If
    End Function

    Private Sub txt_percent_dis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_percent_dis.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ເປີເຊັນສ່ວນລຸດທ່ານສາມາດປ້ອນໄດ້ພຽງຕົວເລກແຕ່[0-100] ເທົ່ານັ້ນ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_percent_dis_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_percent_dis.Leave
        If (DataGridView2.RowCount > 0) Then
            If (load_fn = 0) Then
                'MsgBox(get_amt_pay())
                true_pay = get_amt_pay() - ((get_amt_pay() * CDbl(txt_percent_dis.Text.Trim)) / 100)
                txt_total_pay.Text = FormatNumber(true_pay, 0, TriState.True)
                txt_discount.Text = FormatNumber(((get_amt_pay() * CDbl(txt_percent_dis.Text.Trim)) / 100), 0, TriState.True)
            End If
        End If
    End Sub

    Private Sub txt_percent_dis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_percent_dis.TextChanged
        If (load_fn = 0) Then
            If (txt_percent_dis.Text.Trim <> "") Then
                If CDbl((txt_percent_dis.Text.Trim) < 0) Or CDbl((txt_percent_dis.Text.Trim) > 100) Then
                    MessageBox.Show("ເປີເຊັນສ່ວນລຸດທ່ານສາມາດປ້ອນໄດ້ພຽງຕົວເລກແຕ່[0-100] ເທົ່ານັ້ນ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_percent_dis.Text = "0.00"
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txtAmount_Food_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount_Food.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນເປັນຕົວເລກ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

End Class