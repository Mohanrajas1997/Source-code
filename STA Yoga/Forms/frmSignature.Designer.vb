﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignature
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDocStatus = New System.Windows.Forms.Label()
        Me.lnkAddAttachment = New System.Windows.Forms.LinkLabel()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvChklst = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grpHeader = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtPanNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShareHolder = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFolioNo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtInwardNo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureSignature = New System.Windows.Forms.PictureBox()
        CType(Me.dgvChklst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDocStatus
        '
        Me.lblDocStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDocStatus.Location = New System.Drawing.Point(624, 243)
        Me.lblDocStatus.Name = "lblDocStatus"
        Me.lblDocStatus.Size = New System.Drawing.Size(74, 13)
        Me.lblDocStatus.TabIndex = 14
        Me.lblDocStatus.Text = "Status"
        Me.lblDocStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkAddAttachment
        '
        Me.lnkAddAttachment.AutoSize = True
        Me.lnkAddAttachment.Location = New System.Drawing.Point(951, 243)
        Me.lnkAddAttachment.Name = "lnkAddAttachment"
        Me.lnkAddAttachment.Size = New System.Drawing.Size(100, 13)
        Me.lnkAddAttachment.TabIndex = 15
        Me.lnkAddAttachment.TabStop = True
        Me.lnkAddAttachment.Text = "Add Attachment"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(624, 166)
        Me.txtRemark.MaxLength = 255
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(427, 70)
        Me.txtRemark.TabIndex = 11
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(544, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Remark"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvChklst
        '
        Me.dgvChklst.AllowUserToAddRows = False
        Me.dgvChklst.AllowUserToDeleteRows = False
        Me.dgvChklst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChklst.Location = New System.Drawing.Point(12, 166)
        Me.dgvChklst.Name = "dgvChklst"
        Me.dgvChklst.Size = New System.Drawing.Size(526, 124)
        Me.dgvChklst.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(544, 243)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Status"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.Panel1)
        Me.grpHeader.Controls.Add(Me.Label2)
        Me.grpHeader.Controls.Add(Me.txtFileName)
        Me.grpHeader.Controls.Add(Me.btnBrowse)
        Me.grpHeader.Controls.Add(Me.txtPanNo)
        Me.grpHeader.Controls.Add(Me.Label1)
        Me.grpHeader.Controls.Add(Me.txtShareHolder)
        Me.grpHeader.Controls.Add(Me.Label21)
        Me.grpHeader.Controls.Add(Me.txtFolioNo)
        Me.grpHeader.Controls.Add(Me.Label22)
        Me.grpHeader.Controls.Add(Me.txtCompName)
        Me.grpHeader.Controls.Add(Me.Label20)
        Me.grpHeader.Controls.Add(Me.txtInwardNo)
        Me.grpHeader.Controls.Add(Me.Label19)
        Me.grpHeader.Location = New System.Drawing.Point(13, 0)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(1038, 160)
        Me.grpHeader.TabIndex = 0
        Me.grpHeader.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(403, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Select File"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFileName
        '
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(493, 21)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(377, 21)
        Me.txtFileName.TabIndex = 84
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(880, 21)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 21)
        Me.btnBrowse.TabIndex = 83
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPanNo
        '
        Me.txtPanNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPanNo.Location = New System.Drawing.Point(101, 128)
        Me.txtPanNo.MaxLength = 10
        Me.txtPanNo.Name = "txtPanNo"
        Me.txtPanNo.ReadOnly = True
        Me.txtPanNo.Size = New System.Drawing.Size(284, 21)
        Me.txtPanNo.TabIndex = 4
        Me.txtPanNo.TabStop = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "PAN No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShareHolder
        '
        Me.txtShareHolder.BackColor = System.Drawing.SystemColors.Window
        Me.txtShareHolder.Location = New System.Drawing.Point(101, 101)
        Me.txtShareHolder.MaxLength = 0
        Me.txtShareHolder.Name = "txtShareHolder"
        Me.txtShareHolder.ReadOnly = True
        Me.txtShareHolder.Size = New System.Drawing.Size(284, 21)
        Me.txtShareHolder.TabIndex = 3
        Me.txtShareHolder.TabStop = False
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(6, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 13)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Share Holder"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFolioNo
        '
        Me.txtFolioNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolioNo.Location = New System.Drawing.Point(101, 74)
        Me.txtFolioNo.MaxLength = 0
        Me.txtFolioNo.Name = "txtFolioNo"
        Me.txtFolioNo.ReadOnly = True
        Me.txtFolioNo.Size = New System.Drawing.Size(284, 21)
        Me.txtFolioNo.TabIndex = 2
        Me.txtFolioNo.TabStop = False
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(21, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Folio No"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompName
        '
        Me.txtCompName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompName.Location = New System.Drawing.Point(101, 47)
        Me.txtCompName.MaxLength = 0
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.ReadOnly = True
        Me.txtCompName.Size = New System.Drawing.Size(284, 21)
        Me.txtCompName.TabIndex = 1
        Me.txtCompName.TabStop = False
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(21, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Company"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInwardNo
        '
        Me.txtInwardNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtInwardNo.Location = New System.Drawing.Point(101, 20)
        Me.txtInwardNo.MaxLength = 0
        Me.txtInwardNo.Name = "txtInwardNo"
        Me.txtInwardNo.ReadOnly = True
        Me.txtInwardNo.Size = New System.Drawing.Size(284, 21)
        Me.txtInwardNo.TabIndex = 0
        Me.txtInwardNo.TabStop = False
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(21, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Inward No"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(729, 266)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(76, 24)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReject
        '
        Me.btnReject.Location = New System.Drawing.Point(811, 266)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(76, 24)
        Me.btnReject.TabIndex = 4
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(893, 266)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(76, 24)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(975, 266)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 24)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PictureSignature)
        Me.Panel1.Location = New System.Drawing.Point(406, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 100)
        Me.Panel1.TabIndex = 86
        '
        'PictureSignature
        '
        Me.PictureSignature.Location = New System.Drawing.Point(4, 6)
        Me.PictureSignature.Name = "PictureSignature"
        Me.PictureSignature.Size = New System.Drawing.Size(619, 91)
        Me.PictureSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSignature.TabIndex = 0
        Me.PictureSignature.TabStop = False
        '
        'frmSignature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 303)
        Me.Controls.Add(Me.lnkAddAttachment)
        Me.Controls.Add(Me.lblDocStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dgvChklst)
        Me.Controls.Add(Me.grpHeader)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signature"
        CType(Me.dgvChklst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHeader.ResumeLayout(False)
        Me.grpHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvChklst As System.Windows.Forms.DataGridView
    Friend WithEvents grpHeader As System.Windows.Forms.GroupBox
    Friend WithEvents txtShareHolder As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtFolioNo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCompName As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtInwardNo As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnReject As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lnkAddAttachment As System.Windows.Forms.LinkLabel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblDocStatus As System.Windows.Forms.Label
    Friend WithEvents txtPanNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureSignature As System.Windows.Forms.PictureBox
End Class
