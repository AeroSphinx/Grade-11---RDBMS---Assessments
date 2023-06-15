'
' Created by SharpDevelop.
' User: Twinkle
' Date: 13/06/2023
' Time: 11:57 am
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
'
' Created by SharpDevelop.
' User: Twinkle
' Date: 13/06/2023
' Time: 11:51 am
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Partial Class MainForm
    Inherits System.Windows.Forms.Form
    
    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer
    
    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    	Me.pnlHeader = New System.Windows.Forms.Panel()
    	Me.btnMinimize = New System.Windows.Forms.Button()
    	Me.btnMaxed = New System.Windows.Forms.Button()
    	Me.btnMax = New System.Windows.Forms.Button()
    	Me.btnClose = New System.Windows.Forms.Button()
    	Me.listView1 = New System.Windows.Forms.ListView()
    	Me.ID = New System.Windows.Forms.ColumnHeader()
    	Me.firstname = New System.Windows.Forms.ColumnHeader()
    	Me.lastname = New System.Windows.Forms.ColumnHeader()
    	Me.sex = New System.Windows.Forms.ColumnHeader()
    	Me.strand = New System.Windows.Forms.ColumnHeader()
    	Me.section = New System.Windows.Forms.ColumnHeader()
    	Me.txtSearch = New System.Windows.Forms.TextBox()
    	Me.pnlControls = New System.Windows.Forms.Panel()
    	Me.btnClearSearch = New System.Windows.Forms.Button()
    	Me.btnClearList = New System.Windows.Forms.Button()
    	Me.btnPopList = New System.Windows.Forms.Button()
    	Me.btnApplyFilter = New System.Windows.Forms.Button()
    	Me.pnlRedLine = New System.Windows.Forms.Panel()
    	Me.btnSearch = New System.Windows.Forms.Button()
    	Me.cmbSexFilter = New System.Windows.Forms.ComboBox()
    	Me.pictureBox1 = New System.Windows.Forms.PictureBox()
    	Me.label1 = New System.Windows.Forms.Label()
    	Me.pnlHeader.SuspendLayout
    	Me.pnlControls.SuspendLayout
    	CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.SuspendLayout
    	'
    	'pnlHeader
    	'
    	Me.pnlHeader.BackColor = System.Drawing.Color.White
    	Me.pnlHeader.Controls.Add(Me.btnMinimize)
    	Me.pnlHeader.Controls.Add(Me.btnMaxed)
    	Me.pnlHeader.Controls.Add(Me.btnMax)
    	Me.pnlHeader.Controls.Add(Me.btnClose)
    	Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
    	Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
    	Me.pnlHeader.Name = "pnlHeader"
    	Me.pnlHeader.Size = New System.Drawing.Size(800, 42)
    	Me.pnlHeader.TabIndex = 0
    	'
    	'btnMinimize
    	'
    	Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"),System.Drawing.Image)
    	Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    	Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
    	Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnMinimize.ForeColor = System.Drawing.Color.White
    	Me.btnMinimize.Location = New System.Drawing.Point(624, 0)
    	Me.btnMinimize.Name = "btnMinimize"
    	Me.btnMinimize.Size = New System.Drawing.Size(44, 42)
    	Me.btnMinimize.TabIndex = 3
    	Me.btnMinimize.UseVisualStyleBackColor = true
    	AddHandler Me.btnMinimize.Click, AddressOf Me.BtnMinimizeClick
    	'
    	'btnMaxed
    	'
    	Me.btnMaxed.BackgroundImage = CType(resources.GetObject("btnMaxed.BackgroundImage"),System.Drawing.Image)
    	Me.btnMaxed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    	Me.btnMaxed.Dock = System.Windows.Forms.DockStyle.Right
    	Me.btnMaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnMaxed.ForeColor = System.Drawing.Color.White
    	Me.btnMaxed.Location = New System.Drawing.Point(668, 0)
    	Me.btnMaxed.Name = "btnMaxed"
    	Me.btnMaxed.Size = New System.Drawing.Size(44, 42)
    	Me.btnMaxed.TabIndex = 2
    	Me.btnMaxed.UseVisualStyleBackColor = true
    	Me.btnMaxed.Visible = false
    	AddHandler Me.btnMaxed.Click, AddressOf Me.BtnMaxedClick
    	'
    	'btnMax
    	'
    	Me.btnMax.BackgroundImage = CType(resources.GetObject("btnMax.BackgroundImage"),System.Drawing.Image)
    	Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    	Me.btnMax.Dock = System.Windows.Forms.DockStyle.Right
    	Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnMax.ForeColor = System.Drawing.Color.White
    	Me.btnMax.Location = New System.Drawing.Point(712, 0)
    	Me.btnMax.Name = "btnMax"
    	Me.btnMax.Size = New System.Drawing.Size(44, 42)
    	Me.btnMax.TabIndex = 1
    	Me.btnMax.UseVisualStyleBackColor = true
    	AddHandler Me.btnMax.Click, AddressOf Me.BtnMaximizeClick
    	'
    	'btnClose
    	'
    	Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"),System.Drawing.Image)
    	Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    	Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
    	Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnClose.ForeColor = System.Drawing.Color.White
    	Me.btnClose.Location = New System.Drawing.Point(756, 0)
    	Me.btnClose.Name = "btnClose"
    	Me.btnClose.Size = New System.Drawing.Size(44, 42)
    	Me.btnClose.TabIndex = 0
    	Me.btnClose.UseVisualStyleBackColor = true
    	AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
    	'
    	'listView1
    	'
    	Me.listView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.listView1.BackColor = System.Drawing.Color.DarkGray
    	Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.firstname, Me.lastname, Me.sex, Me.strand, Me.section})
    	Me.listView1.GridLines = true
    	Me.listView1.Location = New System.Drawing.Point(344, 48)
    	Me.listView1.Name = "listView1"
    	Me.listView1.Size = New System.Drawing.Size(444, 540)
    	Me.listView1.TabIndex = 1
    	Me.listView1.UseCompatibleStateImageBehavior = false
    	Me.listView1.View = System.Windows.Forms.View.Details
    	'
    	'ID
    	'
    	Me.ID.Text = "ID"
    	Me.ID.Width = 25
    	'
    	'firstname
    	'
    	Me.firstname.Text = "First Name"
    	Me.firstname.Width = 110
    	'
    	'lastname
    	'
    	Me.lastname.Text = "Last Name"
    	Me.lastname.Width = 94
    	'
    	'sex
    	'
    	Me.sex.Text = "Sex"
    	Me.sex.Width = 59
    	'
    	'strand
    	'
    	Me.strand.Text = "Strand"
    	Me.strand.Width = 82
    	'
    	'section
    	'
    	Me.section.Text = "Section"
    	Me.section.Width = 70
    	'
    	'txtSearch
    	'
    	Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(75,Byte),Integer))
    	Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
    	Me.txtSearch.Font = New System.Drawing.Font("Cambria", 12!)
    	Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.txtSearch.Location = New System.Drawing.Point(39, 193)
    	Me.txtSearch.Name = "txtSearch"
    	Me.txtSearch.Size = New System.Drawing.Size(123, 19)
    	Me.txtSearch.TabIndex = 2
    	'
    	'pnlControls
    	'
    	Me.pnlControls.Controls.Add(Me.btnClearSearch)
    	Me.pnlControls.Controls.Add(Me.btnClearList)
    	Me.pnlControls.Controls.Add(Me.btnPopList)
    	Me.pnlControls.Controls.Add(Me.btnApplyFilter)
    	Me.pnlControls.Controls.Add(Me.pnlRedLine)
    	Me.pnlControls.Controls.Add(Me.btnSearch)
    	Me.pnlControls.Controls.Add(Me.cmbSexFilter)
    	Me.pnlControls.Controls.Add(Me.txtSearch)
    	Me.pnlControls.Location = New System.Drawing.Point(12, 287)
    	Me.pnlControls.Name = "pnlControls"
    	Me.pnlControls.Size = New System.Drawing.Size(326, 301)
    	Me.pnlControls.TabIndex = 3
    	'
    	'btnClearSearch
    	'
    	Me.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(117,Byte),Integer), CType(CType(23,Byte),Integer), CType(CType(17,Byte),Integer))
    	Me.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnClearSearch.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btnClearSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.btnClearSearch.Location = New System.Drawing.Point(38, 122)
    	Me.btnClearSearch.Name = "btnClearSearch"
    	Me.btnClearSearch.Size = New System.Drawing.Size(251, 44)
    	Me.btnClearSearch.TabIndex = 9
    	Me.btnClearSearch.Text = "Clear Search Bar"
    	Me.btnClearSearch.UseVisualStyleBackColor = false
    	AddHandler Me.btnClearSearch.Click, AddressOf Me.BtnClearSearchClick
    	'
    	'btnClearList
    	'
    	Me.btnClearList.BackColor = System.Drawing.Color.FromArgb(CType(CType(117,Byte),Integer), CType(CType(23,Byte),Integer), CType(CType(17,Byte),Integer))
    	Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnClearList.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btnClearList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.btnClearList.Location = New System.Drawing.Point(38, 72)
    	Me.btnClearList.Name = "btnClearList"
    	Me.btnClearList.Size = New System.Drawing.Size(251, 44)
    	Me.btnClearList.TabIndex = 8
    	Me.btnClearList.Text = "Clear Listview"
    	Me.btnClearList.UseVisualStyleBackColor = false
    	AddHandler Me.btnClearList.Click, AddressOf Me.BtnClearListClick
    	'
    	'btnPopList
    	'
    	Me.btnPopList.BackColor = System.Drawing.Color.FromArgb(CType(CType(117,Byte),Integer), CType(CType(23,Byte),Integer), CType(CType(17,Byte),Integer))
    	Me.btnPopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnPopList.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btnPopList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.btnPopList.Location = New System.Drawing.Point(38, 22)
    	Me.btnPopList.Name = "btnPopList"
    	Me.btnPopList.Size = New System.Drawing.Size(251, 44)
    	Me.btnPopList.TabIndex = 7
    	Me.btnPopList.Text = "Populate Listview"
    	Me.btnPopList.UseVisualStyleBackColor = false
    	AddHandler Me.btnPopList.Click, AddressOf Me.BtnPopListClick
    	'
    	'btnApplyFilter
    	'
    	Me.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(117,Byte),Integer), CType(CType(23,Byte),Integer), CType(CType(17,Byte),Integer))
    	Me.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnApplyFilter.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btnApplyFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.btnApplyFilter.Location = New System.Drawing.Point(168, 240)
    	Me.btnApplyFilter.Name = "btnApplyFilter"
    	Me.btnApplyFilter.Size = New System.Drawing.Size(124, 44)
    	Me.btnApplyFilter.TabIndex = 6
    	Me.btnApplyFilter.Text = "Apply Filter"
    	Me.btnApplyFilter.UseVisualStyleBackColor = false
    	AddHandler Me.btnApplyFilter.Click, AddressOf Me.BtnFilterClick
    	'
    	'pnlRedLine
    	'
    	Me.pnlRedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117,Byte),Integer), CType(CType(23,Byte),Integer), CType(CType(17,Byte),Integer))
    	Me.pnlRedLine.Location = New System.Drawing.Point(38, 214)
    	Me.pnlRedLine.Name = "pnlRedLine"
    	Me.pnlRedLine.Size = New System.Drawing.Size(124, 5)
    	Me.pnlRedLine.TabIndex = 5
    	'
    	'btnSearch
    	'
    	Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(117,Byte),Integer), CType(CType(23,Byte),Integer), CType(CType(17,Byte),Integer))
    	Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    	Me.btnSearch.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.btnSearch.Location = New System.Drawing.Point(38, 240)
    	Me.btnSearch.Name = "btnSearch"
    	Me.btnSearch.Size = New System.Drawing.Size(124, 44)
    	Me.btnSearch.TabIndex = 4
    	Me.btnSearch.Text = "Search Data"
    	Me.btnSearch.UseVisualStyleBackColor = false
    	AddHandler Me.btnSearch.Click, AddressOf Me.BtnSearchClick
    	'
    	'cmbSexFilter
    	'
    	Me.cmbSexFilter.BackColor = System.Drawing.Color.DimGray
    	Me.cmbSexFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    	Me.cmbSexFilter.FormattingEnabled = true
    	Me.cmbSexFilter.Items.AddRange(New Object() {"Male", "Female"})
    	Me.cmbSexFilter.Location = New System.Drawing.Point(168, 195)
    	Me.cmbSexFilter.Name = "cmbSexFilter"
    	Me.cmbSexFilter.Size = New System.Drawing.Size(121, 21)
    	Me.cmbSexFilter.TabIndex = 3
    	'
    	'pictureBox1
    	'
    	Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
    	Me.pictureBox1.Location = New System.Drawing.Point(65, 59)
    	Me.pictureBox1.Name = "pictureBox1"
    	Me.pictureBox1.Size = New System.Drawing.Size(212, 161)
    	Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    	Me.pictureBox1.TabIndex = 4
    	Me.pictureBox1.TabStop = false
    	'
    	'label1
    	'
    	Me.label1.Font = New System.Drawing.Font("Cambria", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
    	Me.label1.Location = New System.Drawing.Point(76, 234)
    	Me.label1.Name = "label1"
    	Me.label1.Size = New System.Drawing.Size(193, 35)
    	Me.label1.TabIndex = 5
    	Me.label1.Text = "Q4 - Homework 2"
    	'
    	'MainForm
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(75,Byte),Integer))
    	Me.ClientSize = New System.Drawing.Size(800, 600)
    	Me.Controls.Add(Me.label1)
    	Me.Controls.Add(Me.pictureBox1)
    	Me.Controls.Add(Me.pnlControls)
    	Me.Controls.Add(Me.listView1)
    	Me.Controls.Add(Me.pnlHeader)
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    	Me.Name = "MainForm"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "mainFrm"
    	Me.pnlHeader.ResumeLayout(false)
    	Me.pnlControls.ResumeLayout(false)
    	Me.pnlControls.PerformLayout
    	CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Private ID As System.Windows.Forms.ColumnHeader
    Private section As System.Windows.Forms.ColumnHeader
    Private strand As System.Windows.Forms.ColumnHeader
    Private sex As System.Windows.Forms.ColumnHeader
    Private lastname As System.Windows.Forms.ColumnHeader
    Private firstname As System.Windows.Forms.ColumnHeader
    Private btnApplyFilter As System.Windows.Forms.Button
    Private btnPopList As System.Windows.Forms.Button
    Private btnClearList As System.Windows.Forms.Button
    Private btnClearSearch As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private cmbSexFilter As System.Windows.Forms.ComboBox
    Private btnSearch As System.Windows.Forms.Button
    Private pnlRedLine As System.Windows.Forms.Panel
    Private pnlControls As System.Windows.Forms.Panel
    Private txtSearch As System.Windows.Forms.TextBox
    Private listView1 As System.Windows.Forms.ListView
    Private btnClose As System.Windows.Forms.Button
    Private btnMax As System.Windows.Forms.Button
    Private btnMaxed As System.Windows.Forms.Button
    Private btnMinimize As System.Windows.Forms.Button
    Private pnlHeader As System.Windows.Forms.Panel
End Class



