Imports System.IO
Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class FrmCompanyInfo

    Private Sub FrmCompanyInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AddInstalledPrinter()
        Call LoadCompanyInf()
        Call lockedText()
    End Sub

    Private Sub LoadCompanyInf()
        Sql = " SELECT college_id ,college_name_en ,college_name_la ,college_address ,college_logo ,"
        Sql &= " print_copy_bill_register ,print_copy_bill_enroll ,print_copy_bill_sell ,last_update ,user_update,"
        Sql &= " minister_of_la, minister_of_en, only_email, only_tel "
        Sql &= " FROM tbl_college_inf "
        dt = ExecuteDatable(Sql)
        txt_ministry_la.Text = dt.Rows(0).Item("minister_of_la")
        txt_ministry_en.Text = dt.Rows(0).Item("minister_of_en")
        txt_telephone.Text = dt.Rows(0).Item("only_tel")
        txt_email.Text = dt.Rows(0).Item("only_email")

        txt_enname.Text = dt.Rows(0).Item("college_name_en")
        txt_laoname.Text = dt.Rows(0).Item("college_name_la")
        txt_address.Text = dt.Rows(0).Item("college_address")

        copies_enroll.Value = dt.Rows(0).Item("print_copy_bill_enroll")
        copies_register.Value = dt.Rows(0).Item("print_copy_bill_register")
        copies_sell.Value = dt.Rows(0).Item("print_copy_bill_sell")
        lb_update.Text = "Last Modified: " & dt.Rows(0).Item("last_update") & ", By: " & dt.Rows(0).Item("user_update")

        cb_enroll.SelectedItem = My.Settings.setting_printer_enroll
        cb_register.SelectedItem = My.Settings.setting_printer_register
        cb_sell.SelectedItem = My.Settings.setting_printer_sell
        Try
            Dim picture() As Byte = dt.Rows(0).Item("college_logo")
            Dim streampic As New MemoryStream(picture)
            PictureBox1.Image = Image.FromStream(streampic)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Logo image can't found!")
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub AddInstalledPrinter()
        Dim strInstalledPrinters As String
        Dim prntDoc As New PrintDocument
        cb_enroll.Items.Add("Please Select Printer")
        cb_register.Items.Add("Please Select Printer")
        cb_sell.Items.Add("Please Select Printer")

        'check if there is installed printer
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            MsgBox("No Printer Installed")
            Exit Sub
        End If

        'display installed printer into combobox list item
        cb_enroll.Items.Clear()
        cb_register.Items.Clear()
        cb_sell.Items.Clear()
        For Each strInstalledPrinters In PrinterSettings.InstalledPrinters
            cb_enroll.Items.Add(strInstalledPrinters)
            cb_register.Items.Add(strInstalledPrinters)
            cb_sell.Items.Add(strInstalledPrinters)
        Next strInstalledPrinters

        cb_enroll.SelectedIndex = 0
        cb_register.SelectedIndex = 0
        cb_sell.SelectedIndex = 0
    End Sub

    Private Sub lockedText()
        sFilePath = ""
        btsave.Enabled = False
        btn_edit.Enabled = True
        txt_ministry_en.ReadOnly = True
        txt_ministry_la.ReadOnly = True
        txt_telephone.ReadOnly = True
        txt_email.ReadOnly = True
        txt_enname.ReadOnly = True
        txt_laoname.ReadOnly = True
        txt_address.ReadOnly = True
        LinkLabel_Browse.Enabled = False
        cb_enroll.Enabled = False
        cb_register.Enabled = False
        cb_sell.Enabled = False

        copies_enroll.Enabled = False
        copies_register.Enabled = False
        copies_sell.Enabled = False
    End Sub

    Private Sub UnlockedText()
        sFilePath = ""
        btsave.Enabled = True
        btn_edit.Enabled = False
        txt_ministry_en.ReadOnly = False
        txt_ministry_la.ReadOnly = False
        txt_telephone.ReadOnly = False
        txt_email.ReadOnly = False
        txt_enname.ReadOnly = False
        txt_laoname.ReadOnly = False
        txt_address.ReadOnly = False
        LinkLabel_Browse.Enabled = True
        cb_enroll.Enabled = True
        cb_register.Enabled = True
        cb_sell.Enabled = True

        copies_enroll.Enabled = True
        copies_register.Enabled = True
        copies_sell.Enabled = True
    End Sub

    Dim sFilePath As String = ""
    Private Sub LinkLabel_Browse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Browse.LinkClicked
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.Title = "ເລືອກຮູບໂລໂກ້ທີ່ຕ້ອງການປ່ຽນ"
            sFilePath = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(sFilePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else : Exit Sub
        End If
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        If txt_laoname.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ສະຖາບັນດເປັນພາສາລາວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_laoname.Focus()
            Exit Sub
        End If
        If txt_enname.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ສະຖາບັນເປັນພາສາອັງກິດ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_enname.Focus()
            Exit Sub
        End If
        If txt_address.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນທີ່ຢູ່ສະຖາບັນ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_address.Focus()
            Exit Sub
        End If
        If txt_ministry_la.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ກະຊວງສຶກສາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_ministry_la.Focus()
            Exit Sub
        End If
        If txt_ministry_en.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນ Ministry of Education", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_ministry_en.Focus()
            Exit Sub
        End If
        If txt_telephone.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນ Telephone", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_telephone.Focus()
            Exit Sub
        End If
        If txt_email.Text.Trim = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນ Email ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_email.Focus()
            Exit Sub
        End If

        'Printer
        If (cb_enroll.SelectedIndex <> 0) Then
            My.Settings.setting_printer_enroll = cb_enroll.SelectedItem
            My.Settings.Save()
        End If
        If (cb_register.SelectedIndex <> 0) Then
            My.Settings.setting_printer_register = cb_register.SelectedItem
            My.Settings.Save()
        End If
        If (cb_sell.SelectedIndex <> 0) Then
            My.Settings.setting_printer_sell = cb_sell.SelectedItem
            My.Settings.Save()
        End If

        'Sql = " SELECT college_id ,college_name_en ,college_name_la ,college_address ,college_logo ,"
        'Sql &= " print_copy_bill_register ,print_copy_bill_enroll ,print_copy_bill_sell ,last_update ,user_update"
        Call ConnectDB()
        If (sFilePath <> "") Then
            Dim fs As FileStream = New FileStream(sFilePath.ToString(), FileMode.Open, FileAccess.Read)
            Dim binReader As New BinaryReader(fs)
            Dim img As Byte() = binReader.ReadBytes(fs.Length)
            Sql = "UPDATE tbl_college_inf SET college_logo=@pic, college_address= @ad, college_name_en=@en, college_name_la=@la, "
            Sql &= " print_copy_bill_enroll=@cp1, print_copy_bill_register=@cp2, print_copy_bill_sell=@cp2, user_update=@u, last_update=getdate(), "
            Sql &= " minister_of_la=@minister_of_la, minister_of_en=@minister_of_en, only_email=@only_email, only_tel=@only_tel "
            Sql &= " WHERE(college_id=1)"
            cm = New SqlCommand(Sql, conn)
            cm.Parameters.AddWithValue("pic", img)
            cm.Parameters.AddWithValue("ad", txt_address.Text.Trim)
            cm.Parameters.AddWithValue("en", txt_enname.Text.Trim)
            cm.Parameters.AddWithValue("la", txt_laoname.Text.Trim)
            cm.Parameters.AddWithValue("cp1", CDbl(copies_enroll.Text))
            cm.Parameters.AddWithValue("cp2", CDbl(copies_register.Text))
            cm.Parameters.AddWithValue("cp3", CDbl(copies_sell.Text))
            cm.Parameters.AddWithValue("minister_of_la", txt_ministry_la.Text.Trim)
            cm.Parameters.AddWithValue("minister_of_en", txt_ministry_en.Text.Trim)
            cm.Parameters.AddWithValue("only_email", txt_email.Text.Trim)
            cm.Parameters.AddWithValue("only_tel", txt_telephone.Text.Trim)
            cm.Parameters.AddWithValue("u", User_name)
            cm.ExecuteNonQuery()
            fs.Close()
        Else
            Sql = "UPDATE tbl_college_inf SET college_address= @ad, college_name_en=@en, college_name_la=@la, "
            Sql &= " print_copy_bill_enroll=@cp1, print_copy_bill_register=@cp2, print_copy_bill_sell=@cp2, user_update=@u, last_update=getdate(), "
            Sql &= " minister_of_la=@minister_of_la, minister_of_en=@minister_of_en, only_email=@only_email, only_tel=@only_tel "
            Sql &= " WHERE(college_id=1)"
            cm = New SqlCommand(Sql, conn)
            cm.Parameters.AddWithValue("ad", txt_address.Text.Trim)
            cm.Parameters.AddWithValue("en", txt_enname.Text.Trim)
            cm.Parameters.AddWithValue("la", txt_laoname.Text.Trim)
            cm.Parameters.AddWithValue("cp1", CDbl(copies_enroll.Text))
            cm.Parameters.AddWithValue("cp2", CDbl(copies_register.Text))
            cm.Parameters.AddWithValue("cp3", CDbl(copies_sell.Text))
            cm.Parameters.AddWithValue("minister_of_la", txt_ministry_la.Text.Trim)
            cm.Parameters.AddWithValue("minister_of_en", txt_ministry_en.Text.Trim)
            cm.Parameters.AddWithValue("only_email", txt_email.Text.Trim)
            cm.Parameters.AddWithValue("only_tel", txt_telephone.Text.Trim)
            cm.Parameters.AddWithValue("u", User_name)
            cm.ExecuteNonQuery()
        End If

        MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ !", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btcalcel_Click(sender As Object, e As EventArgs) Handles btcalcel.Click
        Me.Close()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call UnlockedText()
        txt_laoname.Select()
    End Sub

End Class