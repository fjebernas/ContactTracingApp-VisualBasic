﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.btnDisplayData = New System.Windows.Forms.Button()
        Me.listBxEntries = New System.Windows.Forms.ListBox()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSelectedLabel = New System.Windows.Forms.Label()
        Me.gbxSecondQuestion = New System.Windows.Forms.GroupBox()
        Me.gbxFirstQuestion = New System.Windows.Forms.GroupBox()
        Me.lblThirdQuestion1 = New System.Windows.Forms.Label()
        Me.lblSecondQuestion2 = New System.Windows.Forms.Label()
        Me.lblSecondQuestion1 = New System.Windows.Forms.Label()
        Me.lblFirstQuestion = New System.Windows.Forms.Label()
        Me.txtBxCpNum = New System.Windows.Forms.TextBox()
        Me.lblCPnum = New System.Windows.Forms.Label()
        Me.txtBxGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtBxAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtBxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtBxMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblDateSubmitted = New System.Windows.Forms.Label()
        Me.lblFirstQuestionYes = New System.Windows.Forms.Label()
        Me.lblFirstQuestionNo = New System.Windows.Forms.Label()
        Me.lblSecondQuestionYes = New System.Windows.Forms.Label()
        Me.lblSecondQuestionNo = New System.Windows.Forms.Label()
        Me.lblSecondQuestionNS = New System.Windows.Forms.Label()
        Me.gbxSymptoms = New System.Windows.Forms.GroupBox()
        Me.lblFever = New System.Windows.Forms.Label()
        Me.lblCough = New System.Windows.Forms.Label()
        Me.lblDB = New System.Windows.Forms.Label()
        Me.lblLossOfTasteAndSmell = New System.Windows.Forms.Label()
        Me.lblSoreThroat = New System.Windows.Forms.Label()
        Me.lblDiarrhea = New System.Windows.Forms.Label()
        Me.lblChestPain = New System.Windows.Forms.Label()
        Me.lblTiredness = New System.Windows.Forms.Label()
        Me.lblHeadaches = New System.Windows.Forms.Label()
        Me.panelTop.SuspendLayout()
        Me.panelNav.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.gbxSecondQuestion.SuspendLayout()
        Me.gbxFirstQuestion.SuspendLayout()
        Me.gbxSymptoms.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(944, 85)
        Me.panelTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(213, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Tracing Data Viewer"
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 583)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(944, 48)
        Me.panelBottom.TabIndex = 1
        '
        'panelNav
        '
        Me.panelNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelNav.Controls.Add(Me.btnDisplayData)
        Me.panelNav.Controls.Add(Me.listBxEntries)
        Me.panelNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelNav.Location = New System.Drawing.Point(0, 85)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(265, 498)
        Me.panelNav.TabIndex = 2
        '
        'btnDisplayData
        '
        Me.btnDisplayData.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplayData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDisplayData.Location = New System.Drawing.Point(76, 439)
        Me.btnDisplayData.Name = "btnDisplayData"
        Me.btnDisplayData.Size = New System.Drawing.Size(117, 36)
        Me.btnDisplayData.TabIndex = 1
        Me.btnDisplayData.Text = "Display Data"
        Me.btnDisplayData.UseVisualStyleBackColor = False
        '
        'listBxEntries
        '
        Me.listBxEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.listBxEntries.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBxEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.listBxEntries.FormattingEnabled = True
        Me.listBxEntries.ItemHeight = 16
        Me.listBxEntries.Location = New System.Drawing.Point(24, 54)
        Me.listBxEntries.Name = "listBxEntries"
        Me.listBxEntries.Size = New System.Drawing.Size(220, 372)
        Me.listBxEntries.TabIndex = 0
        '
        'panelContent
        '
        Me.panelContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.panelContent.Controls.Add(Me.gbxSymptoms)
        Me.panelContent.Controls.Add(Me.lblDate)
        Me.panelContent.Controls.Add(Me.lblSelected)
        Me.panelContent.Controls.Add(Me.lblDateSubmitted)
        Me.panelContent.Controls.Add(Me.lblSelectedLabel)
        Me.panelContent.Controls.Add(Me.gbxSecondQuestion)
        Me.panelContent.Controls.Add(Me.gbxFirstQuestion)
        Me.panelContent.Controls.Add(Me.lblThirdQuestion1)
        Me.panelContent.Controls.Add(Me.lblSecondQuestion2)
        Me.panelContent.Controls.Add(Me.lblSecondQuestion1)
        Me.panelContent.Controls.Add(Me.lblFirstQuestion)
        Me.panelContent.Controls.Add(Me.txtBxCpNum)
        Me.panelContent.Controls.Add(Me.lblCPnum)
        Me.panelContent.Controls.Add(Me.txtBxGender)
        Me.panelContent.Controls.Add(Me.lblGender)
        Me.panelContent.Controls.Add(Me.txtBxAddress)
        Me.panelContent.Controls.Add(Me.lblAddress)
        Me.panelContent.Controls.Add(Me.txtBxAge)
        Me.panelContent.Controls.Add(Me.lblAge)
        Me.panelContent.Controls.Add(Me.txtBxLastName)
        Me.panelContent.Controls.Add(Me.lblLastName)
        Me.panelContent.Controls.Add(Me.txtBxMiddleName)
        Me.panelContent.Controls.Add(Me.lblMiddleName)
        Me.panelContent.Controls.Add(Me.txtBxFirstName)
        Me.panelContent.Controls.Add(Me.lblFirstName)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(265, 85)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(679, 498)
        Me.panelContent.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(451, 14)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 18)
        Me.lblDate.TabIndex = 113
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblSelected.Location = New System.Drawing.Point(122, 13)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(0, 19)
        Me.lblSelected.TabIndex = 111
        '
        'lblSelectedLabel
        '
        Me.lblSelectedLabel.AutoSize = True
        Me.lblSelectedLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblSelectedLabel.Location = New System.Drawing.Point(33, 12)
        Me.lblSelectedLabel.Name = "lblSelectedLabel"
        Me.lblSelectedLabel.Size = New System.Drawing.Size(96, 21)
        Me.lblSelectedLabel.TabIndex = 112
        Me.lblSelectedLabel.Text = "Selected is:"
        '
        'gbxSecondQuestion
        '
        Me.gbxSecondQuestion.Controls.Add(Me.lblSecondQuestionNS)
        Me.gbxSecondQuestion.Controls.Add(Me.lblSecondQuestionNo)
        Me.gbxSecondQuestion.Controls.Add(Me.lblSecondQuestionYes)
        Me.gbxSecondQuestion.Location = New System.Drawing.Point(39, 309)
        Me.gbxSecondQuestion.Name = "gbxSecondQuestion"
        Me.gbxSecondQuestion.Size = New System.Drawing.Size(383, 42)
        Me.gbxSecondQuestion.TabIndex = 101
        Me.gbxSecondQuestion.TabStop = False
        '
        'gbxFirstQuestion
        '
        Me.gbxFirstQuestion.Controls.Add(Me.lblFirstQuestionNo)
        Me.gbxFirstQuestion.Controls.Add(Me.lblFirstQuestionYes)
        Me.gbxFirstQuestion.Location = New System.Drawing.Point(37, 204)
        Me.gbxFirstQuestion.Name = "gbxFirstQuestion"
        Me.gbxFirstQuestion.Size = New System.Drawing.Size(209, 42)
        Me.gbxFirstQuestion.TabIndex = 100
        Me.gbxFirstQuestion.TabStop = False
        '
        'lblThirdQuestion1
        '
        Me.lblThirdQuestion1.AutoSize = True
        Me.lblThirdQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdQuestion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblThirdQuestion1.Location = New System.Drawing.Point(33, 365)
        Me.lblThirdQuestion1.Name = "lblThirdQuestion1"
        Me.lblThirdQuestion1.Size = New System.Drawing.Size(553, 21)
        Me.lblThirdQuestion1.TabIndex = 17
        Me.lblThirdQuestion1.Text = "Do you currently have any of the following conditions during this time?"
        '
        'lblSecondQuestion2
        '
        Me.lblSecondQuestion2.AutoSize = True
        Me.lblSecondQuestion2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblSecondQuestion2.Location = New System.Drawing.Point(33, 285)
        Me.lblSecondQuestion2.Name = "lblSecondQuestion2"
        Me.lblSecondQuestion2.Size = New System.Drawing.Size(421, 21)
        Me.lblSecondQuestion2.TabIndex = 15
        Me.lblSecondQuestion2.Text = "country between the period of last month until now?"
        '
        'lblSecondQuestion1
        '
        Me.lblSecondQuestion1.AutoSize = True
        Me.lblSecondQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblSecondQuestion1.Location = New System.Drawing.Point(33, 258)
        Me.lblSecondQuestion1.Name = "lblSecondQuestion1"
        Me.lblSecondQuestion1.Size = New System.Drawing.Size(579, 21)
        Me.lblSecondQuestion1.TabIndex = 16
        Me.lblSecondQuestion1.Text = "Have you come into contact with anyone who has traveled outside your "
        '
        'lblFirstQuestion
        '
        Me.lblFirstQuestion.AutoSize = True
        Me.lblFirstQuestion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblFirstQuestion.Location = New System.Drawing.Point(34, 180)
        Me.lblFirstQuestion.Name = "lblFirstQuestion"
        Me.lblFirstQuestion.Size = New System.Drawing.Size(589, 21)
        Me.lblFirstQuestion.TabIndex = 14
        Me.lblFirstQuestion.Text = "Have you traveled outside the country anytime from last month until now?"
        '
        'txtBxCpNum
        '
        Me.txtBxCpNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxCpNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxCpNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCpNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxCpNum.Location = New System.Drawing.Point(389, 138)
        Me.txtBxCpNum.Multiline = True
        Me.txtBxCpNum.Name = "txtBxCpNum"
        Me.txtBxCpNum.Size = New System.Drawing.Size(166, 32)
        Me.txtBxCpNum.TabIndex = 12
        Me.txtBxCpNum.Tag = "requiredField"
        Me.txtBxCpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCPnum
        '
        Me.lblCPnum.AutoSize = True
        Me.lblCPnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPnum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblCPnum.Location = New System.Drawing.Point(385, 114)
        Me.lblCPnum.Name = "lblCPnum"
        Me.lblCPnum.Size = New System.Drawing.Size(89, 21)
        Me.lblCPnum.TabIndex = 8
        Me.lblCPnum.Text = "Phone No."
        '
        'txtBxGender
        '
        Me.txtBxGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxGender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxGender.Location = New System.Drawing.Point(562, 138)
        Me.txtBxGender.Multiline = True
        Me.txtBxGender.Name = "txtBxGender"
        Me.txtBxGender.Size = New System.Drawing.Size(57, 32)
        Me.txtBxGender.TabIndex = 13
        Me.txtBxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(558, 112)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(70, 21)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxAddress.Location = New System.Drawing.Point(38, 138)
        Me.txtBxAddress.Multiline = True
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(342, 32)
        Me.txtBxAddress.TabIndex = 11
        Me.txtBxAddress.Tag = "requiredField"
        Me.txtBxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(35, 112)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 21)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address"
        '
        'txtBxAge
        '
        Me.txtBxAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxAge.Location = New System.Drawing.Point(560, 69)
        Me.txtBxAge.Multiline = True
        Me.txtBxAge.Name = "txtBxAge"
        Me.txtBxAge.Size = New System.Drawing.Size(57, 32)
        Me.txtBxAge.TabIndex = 6
        Me.txtBxAge.Tag = "requiredField"
        Me.txtBxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(556, 43)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 21)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age"
        '
        'txtBxLastName
        '
        Me.txtBxLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxLastName.Location = New System.Drawing.Point(386, 69)
        Me.txtBxLastName.Multiline = True
        Me.txtBxLastName.Name = "txtBxLastName"
        Me.txtBxLastName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxLastName.TabIndex = 2
        Me.txtBxLastName.Tag = "requiredField"
        Me.txtBxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(382, 45)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(93, 21)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
        '
        'txtBxMiddleName
        '
        Me.txtBxMiddleName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxMiddleName.Location = New System.Drawing.Point(212, 69)
        Me.txtBxMiddleName.Multiline = True
        Me.txtBxMiddleName.Name = "txtBxMiddleName"
        Me.txtBxMiddleName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxMiddleName.TabIndex = 2
        Me.txtBxMiddleName.Tag = "requiredField"
        Me.txtBxMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(208, 45)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(115, 21)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxFirstName.Location = New System.Drawing.Point(38, 69)
        Me.txtBxFirstName.Multiline = True
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxFirstName.TabIndex = 2
        Me.txtBxFirstName.Tag = "requiredField"
        Me.txtBxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(34, 45)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(91, 21)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'lblDateSubmitted
        '
        Me.lblDateSubmitted.AutoSize = True
        Me.lblDateSubmitted.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSubmitted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblDateSubmitted.Location = New System.Drawing.Point(316, 12)
        Me.lblDateSubmitted.Name = "lblDateSubmitted"
        Me.lblDateSubmitted.Size = New System.Drawing.Size(138, 21)
        Me.lblDateSubmitted.TabIndex = 112
        Me.lblDateSubmitted.Text = "Date submitted:"
        '
        'lblFirstQuestionYes
        '
        Me.lblFirstQuestionYes.AutoSize = True
        Me.lblFirstQuestionYes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstQuestionYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblFirstQuestionYes.Location = New System.Drawing.Point(6, 16)
        Me.lblFirstQuestionYes.Name = "lblFirstQuestionYes"
        Me.lblFirstQuestionYes.Size = New System.Drawing.Size(33, 18)
        Me.lblFirstQuestionYes.TabIndex = 113
        Me.lblFirstQuestionYes.Text = "Yes"
        '
        'lblFirstQuestionNo
        '
        Me.lblFirstQuestionNo.AutoSize = True
        Me.lblFirstQuestionNo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstQuestionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblFirstQuestionNo.Location = New System.Drawing.Point(170, 16)
        Me.lblFirstQuestionNo.Name = "lblFirstQuestionNo"
        Me.lblFirstQuestionNo.Size = New System.Drawing.Size(29, 18)
        Me.lblFirstQuestionNo.TabIndex = 113
        Me.lblFirstQuestionNo.Text = "No"
        '
        'lblSecondQuestionYes
        '
        Me.lblSecondQuestionYes.AutoSize = True
        Me.lblSecondQuestionYes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestionYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblSecondQuestionYes.Location = New System.Drawing.Point(6, 16)
        Me.lblSecondQuestionYes.Name = "lblSecondQuestionYes"
        Me.lblSecondQuestionYes.Size = New System.Drawing.Size(33, 18)
        Me.lblSecondQuestionYes.TabIndex = 113
        Me.lblSecondQuestionYes.Text = "Yes"
        '
        'lblSecondQuestionNo
        '
        Me.lblSecondQuestionNo.AutoSize = True
        Me.lblSecondQuestionNo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblSecondQuestionNo.Location = New System.Drawing.Point(168, 16)
        Me.lblSecondQuestionNo.Name = "lblSecondQuestionNo"
        Me.lblSecondQuestionNo.Size = New System.Drawing.Size(29, 18)
        Me.lblSecondQuestionNo.TabIndex = 113
        Me.lblSecondQuestionNo.Text = "No"
        '
        'lblSecondQuestionNS
        '
        Me.lblSecondQuestionNS.AutoSize = True
        Me.lblSecondQuestionNS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestionNS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblSecondQuestionNS.Location = New System.Drawing.Point(312, 16)
        Me.lblSecondQuestionNS.Name = "lblSecondQuestionNS"
        Me.lblSecondQuestionNS.Size = New System.Drawing.Size(67, 18)
        Me.lblSecondQuestionNS.TabIndex = 113
        Me.lblSecondQuestionNS.Text = "Not sure"
        '
        'gbxSymptoms
        '
        Me.gbxSymptoms.Controls.Add(Me.lblHeadaches)
        Me.gbxSymptoms.Controls.Add(Me.lblDiarrhea)
        Me.gbxSymptoms.Controls.Add(Me.lblDB)
        Me.gbxSymptoms.Controls.Add(Me.lblTiredness)
        Me.gbxSymptoms.Controls.Add(Me.lblSoreThroat)
        Me.gbxSymptoms.Controls.Add(Me.lblCough)
        Me.gbxSymptoms.Controls.Add(Me.lblChestPain)
        Me.gbxSymptoms.Controls.Add(Me.lblLossOfTasteAndSmell)
        Me.gbxSymptoms.Controls.Add(Me.lblFever)
        Me.gbxSymptoms.Location = New System.Drawing.Point(38, 390)
        Me.gbxSymptoms.Name = "gbxSymptoms"
        Me.gbxSymptoms.Size = New System.Drawing.Size(579, 90)
        Me.gbxSymptoms.TabIndex = 114
        Me.gbxSymptoms.TabStop = False
        '
        'lblFever
        '
        Me.lblFever.AutoSize = True
        Me.lblFever.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFever.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblFever.Location = New System.Drawing.Point(5, 16)
        Me.lblFever.Name = "lblFever"
        Me.lblFever.Size = New System.Drawing.Size(48, 18)
        Me.lblFever.TabIndex = 113
        Me.lblFever.Text = "Fever"
        '
        'lblCough
        '
        Me.lblCough.AutoSize = True
        Me.lblCough.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCough.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblCough.Location = New System.Drawing.Point(5, 41)
        Me.lblCough.Name = "lblCough"
        Me.lblCough.Size = New System.Drawing.Size(58, 18)
        Me.lblCough.TabIndex = 113
        Me.lblCough.Text = "Cough"
        '
        'lblDB
        '
        Me.lblDB.AutoSize = True
        Me.lblDB.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblDB.Location = New System.Drawing.Point(5, 66)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(136, 18)
        Me.lblDB.TabIndex = 113
        Me.lblDB.Text = "Difficult Breathing"
        '
        'lblLossOfTasteAndSmell
        '
        Me.lblLossOfTasteAndSmell.AutoSize = True
        Me.lblLossOfTasteAndSmell.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLossOfTasteAndSmell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblLossOfTasteAndSmell.Location = New System.Drawing.Point(226, 16)
        Me.lblLossOfTasteAndSmell.Name = "lblLossOfTasteAndSmell"
        Me.lblLossOfTasteAndSmell.Size = New System.Drawing.Size(168, 18)
        Me.lblLossOfTasteAndSmell.TabIndex = 113
        Me.lblLossOfTasteAndSmell.Text = "Loss of taste and smell"
        '
        'lblSoreThroat
        '
        Me.lblSoreThroat.AutoSize = True
        Me.lblSoreThroat.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoreThroat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblSoreThroat.Location = New System.Drawing.Point(226, 41)
        Me.lblSoreThroat.Name = "lblSoreThroat"
        Me.lblSoreThroat.Size = New System.Drawing.Size(87, 18)
        Me.lblSoreThroat.TabIndex = 113
        Me.lblSoreThroat.Text = "Sore throat"
        '
        'lblDiarrhea
        '
        Me.lblDiarrhea.AutoSize = True
        Me.lblDiarrhea.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiarrhea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblDiarrhea.Location = New System.Drawing.Point(226, 66)
        Me.lblDiarrhea.Name = "lblDiarrhea"
        Me.lblDiarrhea.Size = New System.Drawing.Size(72, 18)
        Me.lblDiarrhea.TabIndex = 113
        Me.lblDiarrhea.Text = "Diarrhea"
        '
        'lblChestPain
        '
        Me.lblChestPain.AutoSize = True
        Me.lblChestPain.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChestPain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblChestPain.Location = New System.Drawing.Point(462, 16)
        Me.lblChestPain.Name = "lblChestPain"
        Me.lblChestPain.Size = New System.Drawing.Size(86, 18)
        Me.lblChestPain.TabIndex = 113
        Me.lblChestPain.Text = "Chest pain"
        '
        'lblTiredness
        '
        Me.lblTiredness.AutoSize = True
        Me.lblTiredness.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiredness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblTiredness.Location = New System.Drawing.Point(462, 41)
        Me.lblTiredness.Name = "lblTiredness"
        Me.lblTiredness.Size = New System.Drawing.Size(74, 18)
        Me.lblTiredness.TabIndex = 113
        Me.lblTiredness.Text = "Tiredness"
        '
        'lblHeadaches
        '
        Me.lblHeadaches.AutoSize = True
        Me.lblHeadaches.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadaches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblHeadaches.Location = New System.Drawing.Point(462, 66)
        Me.lblHeadaches.Name = "lblHeadaches"
        Me.lblHeadaches.Size = New System.Drawing.Size(93, 18)
        Me.lblHeadaches.TabIndex = 113
        Me.lblHeadaches.Text = "Headaches"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 631)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelNav)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing Data Viewer"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelNav.ResumeLayout(False)
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.gbxSecondQuestion.ResumeLayout(False)
        Me.gbxSecondQuestion.PerformLayout()
        Me.gbxFirstQuestion.ResumeLayout(False)
        Me.gbxFirstQuestion.PerformLayout()
        Me.gbxSymptoms.ResumeLayout(False)
        Me.gbxSymptoms.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents panelBottom As Panel
    Friend WithEvents panelNav As Panel
    Friend WithEvents panelContent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents listBxEntries As ListBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtBxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtBxMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtBxFirstName As TextBox
    Friend WithEvents txtBxAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtBxCpNum As TextBox
    Friend WithEvents lblCPnum As Label
    Friend WithEvents txtBxGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtBxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblFirstQuestion As Label
    Friend WithEvents lblSecondQuestion2 As Label
    Friend WithEvents lblSecondQuestion1 As Label
    Friend WithEvents lblThirdQuestion1 As Label
    Friend WithEvents gbxSecondQuestion As GroupBox
    Friend WithEvents gbxFirstQuestion As GroupBox
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSelectedLabel As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnDisplayData As Button
    Friend WithEvents lblDateSubmitted As Label
    Friend WithEvents gbxSymptoms As GroupBox
    Friend WithEvents lblSecondQuestionNS As Label
    Friend WithEvents lblSecondQuestionNo As Label
    Friend WithEvents lblSecondQuestionYes As Label
    Friend WithEvents lblFirstQuestionNo As Label
    Friend WithEvents lblFirstQuestionYes As Label
    Friend WithEvents lblHeadaches As Label
    Friend WithEvents lblDiarrhea As Label
    Friend WithEvents lblDB As Label
    Friend WithEvents lblTiredness As Label
    Friend WithEvents lblSoreThroat As Label
    Friend WithEvents lblCough As Label
    Friend WithEvents lblChestPain As Label
    Friend WithEvents lblLossOfTasteAndSmell As Label
    Friend WithEvents lblFever As Label
End Class
