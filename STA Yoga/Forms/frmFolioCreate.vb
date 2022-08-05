﻿Imports MySql.Data.MySqlClient

Public Class frmFolioCreate
    Dim mnCompId As Long
    Dim msCompName As String
    Dim mnCloneFolioId As Long
    Dim mbSwapFlag As Boolean

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure to close ?", gsProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If MessageBox.Show("Are you sure to submit ?", gsProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If mbSwapFlag = True Then
                If _
                    txtHolder1.Text = txtHolder1.Tag And _
                    txtFHName1.Text = txtFHName1.Tag And _
                    txtPanNo1.Text = txtPanNo1.Tag And _
                    txtHolder2.Text = txtHolder2.Tag And _
                    txtFHName2.Text = txtFHName2.Tag And _
                    txtPanNo2.Text = txtPanNo2.Tag And _
                    txtHolder3.Text = txtHolder3.Tag And _
                    txtFHName3.Text = txtFHName3.Tag And _
                    txtPanNo3.Text = txtPanNo3.Tag Then
                    MessageBox.Show("No change in transposition !", gsProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            Call UpdateInformation()
        End If
    End Sub

    Private Sub UpdateInformation()
        Dim lnResult As Long
        Dim lsTxt As String

        Dim lnNewFolioId As Long = 0

        Dim lsHolder1 As String = ""
        Dim lsFHName1 As String = ""
        Dim lsPanNo1 As String = ""
        Dim lsHolder2 As String = ""
        Dim lsFHName2 As String = ""
        Dim lsPanNo2 As String = ""
        Dim lsHolder3 As String = ""
        Dim lsFHName3 As String = ""
        Dim lsPanNo3 As String = ""

        Dim lsAddr1 As String = ""
        Dim lsAddr2 As String = ""
        Dim lsAddr3 As String = ""
        Dim lsCity As String = ""
        Dim lsState As String = ""
        Dim lsCountry As String = ""
        Dim lsPincode As String = ""
        Dim lsEmailId As String = ""
        Dim lsContactNo As String = ""
        Dim lnCategoryId As Long = 0

        Try
            lsHolder1 = QuoteFilter(txtHolder1.Text)
            lsFHName1 = QuoteFilter(txtFHName1.Text)
            lsPanNo1 = QuoteFilter(txtPanNo1.Text)
            lsHolder2 = QuoteFilter(txtHolder2.Text)
            lsFHName2 = QuoteFilter(txtFHName2.Text)
            lsPanNo2 = QuoteFilter(txtPanNo2.Text)
            lsHolder3 = QuoteFilter(txtHolder3.Text)
            lsFHName3 = QuoteFilter(txtFHName3.Text)
            lsPanNo3 = QuoteFilter(txtPanNo3.Text)

            lsAddr1 = QuoteFilter(txtAddr1.Text)
            lsAddr2 = QuoteFilter(txtAddr2.Text)
            lsAddr3 = QuoteFilter(txtAddr3.Text)
            lsCity = QuoteFilter(txtCity.Text)
            lsState = QuoteFilter(txtState.Text)
            lsCountry = QuoteFilter(txtCountry.Text)
            lsPincode = QuoteFilter(txtPincode.Text)
            lsContactNo = QuoteFilter(txtPhoneNo.Text)
            lsEmailId = QuoteFilter(txtEmailId.Text)

            If cboCategory.Text <> "" And cboCategory.SelectedIndex <> -1 Then
                lnCategoryId = Val(cboCategory.SelectedValue.ToString())
            End If

            Using cmd As New MySqlCommand("pr_sta_set_folioregister", gOdbcConn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("?in_comp_gid", mnCompId)
                cmd.Parameters.AddWithValue("?in_holder1_name", lsHolder1)
                cmd.Parameters.AddWithValue("?in_holder1_fh_name", lsFHName1)
                cmd.Parameters.AddWithValue("?in_holder1_pan_no", lsPanNo1)
                cmd.Parameters.AddWithValue("?in_holder2_name", lsHolder2)
                cmd.Parameters.AddWithValue("?in_holder2_fh_name", lsFHName2)
                cmd.Parameters.AddWithValue("?in_holder2_pan_no", lsPanNo2)
                cmd.Parameters.AddWithValue("?in_holder3_name", lsHolder3)
                cmd.Parameters.AddWithValue("?in_holder3_fh_name", lsFHName3)
                cmd.Parameters.AddWithValue("?in_holder3_pan_no", lsPanNo3)

                cmd.Parameters.AddWithValue("?in_folio_addr1", lsAddr1)
                cmd.Parameters.AddWithValue("?in_folio_addr2", lsAddr2)
                cmd.Parameters.AddWithValue("?in_folio_addr3", lsAddr3)
                cmd.Parameters.AddWithValue("?in_folio_city", lsCity)
                cmd.Parameters.AddWithValue("?in_folio_state", lsState)
                cmd.Parameters.AddWithValue("?in_folio_country", lsCountry)
                cmd.Parameters.AddWithValue("?in_folio_pincode", lsPincode)
                cmd.Parameters.AddWithValue("?in_folio_mail_id", lsEmailId)
                cmd.Parameters.AddWithValue("?in_folio_contact_no", lsContactNo)
                cmd.Parameters.AddWithValue("?in_folio_category_gid", lnCategoryId)

                cmd.Parameters.AddWithValue("?in_action_by", gsLoginUserCode)

                'Out put Para
                cmd.Parameters.Add("?out_folio_gid", MySqlDbType.Int32)
                cmd.Parameters("?out_folio_gid").Direction = ParameterDirection.Output
                cmd.Parameters.Add("?out_result", MySqlDbType.Int32)
                cmd.Parameters("?out_result").Direction = ParameterDirection.Output
                cmd.Parameters.Add("?out_msg", MySqlDbType.VarChar)
                cmd.Parameters("?out_msg").Direction = ParameterDirection.Output

                cmd.CommandTimeout = 0

                cmd.ExecuteNonQuery()

                lnNewFolioId = Val(cmd.Parameters("?out_folio_gid").Value.ToString())
                lnResult = Val(cmd.Parameters("?out_result").Value.ToString())
                lsTxt = cmd.Parameters("?out_msg").Value.ToString()

                If lnResult = 1 Then
                    MessageBox.Show(lsTxt, gsProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gnSearchId = lnNewFolioId
                    Me.Close()
                Else
                    MessageBox.Show(lsTxt, gsProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, gsProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmFolioCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lsSql As String

        ' category
        lsSql = ""
        lsSql &= " select * from sta_mst_tcategory "
        lsSql &= " where delete_flag = 'N' "
        lsSql &= " order by category_name asc "

        Call gpBindCombo(lsSql, "category_name", "category_gid", cboCategory, gOdbcConn)

        If mnCloneFolioId > 0 Then LoadFolio(mnCloneFolioId)
    End Sub

    Private Sub LoadFolio(FolioId)
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As DataTable

        cmd = New MySqlCommand("pr_sta_get_folio", gOdbcConn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("?in_folio_gid", FolioId)
        cmd.Parameters.AddWithValue("?in_comp_gid", 0)
        cmd.Parameters.AddWithValue("?in_folio_no", "")

        cmd.CommandTimeout = 0

        dt = New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        With dt
            If .Rows.Count > 0 Then
                txtHolder1.Text = .Rows(0).Item("holder1_name").ToString
                txtFHName1.Text = .Rows(0).Item("holder1_fh_name").ToString
                txtPanNo1.Text = .Rows(0).Item("holder1_pan_no").ToString

                txtHolder2.Text = .Rows(0).Item("holder2_name").ToString
                txtFHName2.Text = .Rows(0).Item("holder2_fh_name").ToString
                txtPanNo2.Text = .Rows(0).Item("holder2_pan_no").ToString

                txtHolder3.Text = .Rows(0).Item("holder3_name").ToString
                txtFHName3.Text = .Rows(0).Item("holder3_fh_name").ToString
                txtPanNo3.Text = .Rows(0).Item("holder3_pan_no").ToString

                ' store existing data
                txtHolder1.Tag = .Rows(0).Item("holder1_name").ToString
                txtFHName1.Tag = .Rows(0).Item("holder1_fh_name").ToString
                txtPanNo1.Tag = .Rows(0).Item("holder1_pan_no").ToString

                txtHolder2.Tag = .Rows(0).Item("holder2_name").ToString
                txtFHName2.Tag = .Rows(0).Item("holder2_fh_name").ToString
                txtPanNo2.Tag = .Rows(0).Item("holder2_pan_no").ToString

                txtHolder3.Tag = .Rows(0).Item("holder3_name").ToString
                txtFHName3.Tag = .Rows(0).Item("holder3_fh_name").ToString
                txtPanNo3.Tag = .Rows(0).Item("holder3_pan_no").ToString

                txtAddr1.Text = .Rows(0).Item("folio_addr1").ToString
                txtAddr2.Text = .Rows(0).Item("folio_addr2").ToString
                txtAddr3.Text = .Rows(0).Item("folio_addr3").ToString
                txtCity.Text = .Rows(0).Item("folio_city").ToString
                txtState.Text = .Rows(0).Item("folio_state").ToString
                txtCountry.Text = .Rows(0).Item("folio_country").ToString
                txtPincode.Text = .Rows(0).Item("folio_pincode").ToString
                txtPhoneNo.Text = .Rows(0).Item("folio_contact_no").ToString
                txtEmailId.Text = .Rows(0).Item("folio_mail_id").ToString
                cboCategory.Text = .Rows(0).Item("category_name").ToString

                If mbSwapFlag = True Then
                    If txtHolder2.Text = "" Then
                        btnSwapOneAndTwo.Enabled = False
                        btnSwapTwoAndThree.Enabled = False
                    End If
                End If
            Else
                Call frmCtrClear(Me)
            End If
        End With

        da.Dispose()
        dt.Dispose()
        cmd.Dispose()
    End Sub

    Public Sub New(CompId As Long, CompName As String, Optional CloneFolioId As Long = 0, Optional SwapFlag As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mnCompId = CompId
        msCompName = CompName

        mnCloneFolioId = CloneFolioId
        mbSwapFlag = SwapFlag

        If SwapFlag = True Then
            btnSwapOneAndTwo.Visible = True
            btnSwapTwoAndThree.Visible = True

            txtHolder1.Enabled = False
            txtFHName1.Enabled = False
            txtPanNo1.Enabled = False

            txtHolder2.Enabled = False
            txtFHName2.Enabled = False
            txtPanNo2.Enabled = False

            txtHolder3.Enabled = False
            txtFHName3.Enabled = False
            txtPanNo3.Enabled = False
        Else
            btnSwapOneAndTwo.Visible = False
            btnSwapTwoAndThree.Visible = False
        End If

        grpFolio.Text = "Company : " & msCompName
    End Sub

    Private Sub btnSwapOneAndTwo_Click(sender As Object, e As EventArgs) Handles btnSwapOneAndTwo.Click
        Dim lsHolderName As String = ""
        Dim lsFHName As String = ""
        Dim lsPanNo As String = ""

        If txtHolder1.Text = "" Or txtHolder2.Text = "" Then
            MessageBox.Show("Blank data !", gsProjectName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        lsHolderName = txtHolder1.Text
        lsFHName = txtFHName1.Text
        lsPanNo = txtPanNo1.Text

        txtHolder1.Text = txtHolder2.Text
        txtFHName1.Text = txtFHName2.Text
        txtPanNo1.Text = txtPanNo2.Text

        txtHolder2.Text = lsHolderName
        txtFHName2.Text = lsFHName
        txtPanNo2.Text = lsPanNo
    End Sub

    Private Sub btnSwapTwoAndThree_Click(sender As Object, e As EventArgs) Handles btnSwapTwoAndThree.Click
        Dim lsHolderName As String = ""
        Dim lsFHName As String = ""
        Dim lsPanNo As String = ""

        If txtHolder2.Text = "" Or txtHolder3.Text = "" Then
            MessageBox.Show("Blank data !", gsProjectName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        lsHolderName = txtHolder2.Text
        lsFHName = txtFHName2.Text
        lsPanNo = txtPanNo2.Text

        txtHolder2.Text = txtHolder3.Text
        txtFHName2.Text = txtFHName3.Text
        txtPanNo2.Text = txtPanNo3.Text

        txtHolder3.Text = lsHolderName
        txtFHName3.Text = lsFHName
        txtPanNo3.Text = lsPanNo
    End Sub
End Class