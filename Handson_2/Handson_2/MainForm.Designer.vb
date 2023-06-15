'
' Created by SharpDevelop.
' User: Twinkle
' Date: 23/05/2023
' Time: 8:31 pm
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
		Me.listViewDbase = New System.Windows.Forms.ListView()
		Me.ID1 = New System.Windows.Forms.ColumnHeader()
		Me.LastName2 = New System.Windows.Forms.ColumnHeader()
		Me.FirstName3 = New System.Windows.Forms.ColumnHeader()
		Me.Strand4 = New System.Windows.Forms.ColumnHeader()
		Me.btnDisplayData = New System.Windows.Forms.Button()
		Me.btnClearData = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'listViewDbase
		'
		Me.listViewDbase.BackColor = System.Drawing.Color.DimGray
		Me.listViewDbase.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listViewDbase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID1, Me.LastName2, Me.FirstName3, Me.Strand4})
		Me.listViewDbase.GridLines = true
		Me.listViewDbase.Location = New System.Drawing.Point(18, 83)
		Me.listViewDbase.Name = "listViewDbase"
		Me.listViewDbase.Size = New System.Drawing.Size(527, 294)
		Me.listViewDbase.TabIndex = 0
		Me.listViewDbase.UseCompatibleStateImageBehavior = false
		Me.listViewDbase.View = System.Windows.Forms.View.Details
		'
		'ID1
		'
		Me.ID1.Text = "ID"
		Me.ID1.Width = 117
		'
		'LastName2
		'
		Me.LastName2.Text = "Last Name"
		Me.LastName2.Width = 148
		'
		'FirstName3
		'
		Me.FirstName3.Text = "First Name"
		Me.FirstName3.Width = 141
		'
		'Strand4
		'
		Me.Strand4.Text = "Strand"
		Me.Strand4.Width = 346
		'
		'btnDisplayData
		'
		Me.btnDisplayData.BackColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(139,Byte),Integer))
		Me.btnDisplayData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnDisplayData.ForeColor = System.Drawing.Color.White
		Me.btnDisplayData.Location = New System.Drawing.Point(32, 424)
		Me.btnDisplayData.Name = "btnDisplayData"
		Me.btnDisplayData.Size = New System.Drawing.Size(93, 39)
		Me.btnDisplayData.TabIndex = 1
		Me.btnDisplayData.Text = "Display Data"
		Me.btnDisplayData.UseVisualStyleBackColor = false
		AddHandler Me.btnDisplayData.Click, AddressOf Me.BtnDisplayDataClick
		'
		'btnClearData
		'
		Me.btnClearData.BackColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(139,Byte),Integer))
		Me.btnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnClearData.ForeColor = System.Drawing.Color.White
		Me.btnClearData.Location = New System.Drawing.Point(167, 424)
		Me.btnClearData.Name = "btnClearData"
		Me.btnClearData.Size = New System.Drawing.Size(93, 39)
		Me.btnClearData.TabIndex = 2
		Me.btnClearData.Text = "Clear Data"
		Me.btnClearData.UseVisualStyleBackColor = false
		AddHandler Me.btnClearData.Click, AddressOf Me.BtnClearDataClick
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(139,Byte),Integer))
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnExit.ForeColor = System.Drawing.Color.White
		Me.btnExit.Location = New System.Drawing.Point(418, 655)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(93, 39)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = false
		AddHandler Me.btnExit.Click, AddressOf Me.BtnExitClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(564, 743)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClearData)
		Me.Controls.Add(Me.btnDisplayData)
		Me.Controls.Add(Me.listViewDbase)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainForm"
		Me.Text = "Database"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
	End Sub
	Private Strand4 As System.Windows.Forms.ColumnHeader
	Private FirstName3 As System.Windows.Forms.ColumnHeader
	Private LastName2 As System.Windows.Forms.ColumnHeader
	Private ID1 As System.Windows.Forms.ColumnHeader
	Private btnExit As System.Windows.Forms.Button
	Private btnClearData As System.Windows.Forms.Button
	Private btnDisplayData As System.Windows.Forms.Button
	Private listViewDbase As System.Windows.Forms.ListView
End Class
