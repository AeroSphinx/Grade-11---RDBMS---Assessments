Imports System.Data.OleDb
Imports System.Data


Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		
	End Sub
	
	Sub BtnDisplayDataClick(sender As Object, e As EventArgs)
		con = New OleDbConnection(conStr)
    con.Open() ' Open the database connection

    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter("SELECT * FROM [Personal Information];", con)
    da.Fill(dt)

 For Each row As DataRow In dt.Rows
   Dim Item As New ListViewItem(row(0).ToString())
Item.SubItems.Add(row(1).ToString())
Item.SubItems.Add(row(2).ToString())
Item.SubItems.Add(row(3).ToString())
listViewDbase.Items.Add(Item)
		Next
		
		con.Close
		
	End Sub
	
	Sub BtnClearDataClick(sender As Object, e As EventArgs)
		listViewDbase.Items.Clear
	End Sub
	
	Sub BtnExitClick(sender As Object, e As EventArgs)
		If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then 
			End
		End if
	End Sub
End Class
