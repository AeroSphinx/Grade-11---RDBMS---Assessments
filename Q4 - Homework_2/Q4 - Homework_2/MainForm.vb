Imports System.Data.OleDb
Imports System.Data
'
' Created by SharpDevelop.
' User: Twinkle
' Date: 13/06/2023
' Time: 11:57 am
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
    
    Sub BtnPopListClick(sender As Object, e As EventArgs)
    	con = New OleDbConnection(conStr)
        con.Open 
        
        Dim dt As New DataTable 
        Dim da As New OleDbDataAdapter("SELECT * FROM [Input];", con)
        da.Fill(dt)
        
        listView1.Items.Clear
        
        For Each row As DataRow In dt.Rows
            Dim Item As New ListViewItem(row(0).ToString())
            Item.SubItems.Add(row(1).ToString())
            Item.SubItems.Add(row(2).ToString())
            Item.SubItems.Add(row(3).ToString())
            Item.SubItems.Add(row(4).ToString())
            item.SubItems.Add(row(5).ToString())
            listView1.Items.Add(Item)
        Next
        con.Close
    End Sub
    
    Sub BtnClearListClick(sender As Object, e As EventArgs)
    	listView1.Items.Clear
    End Sub
    
    
    Sub BtnClearSearchClick(sender As Object, e As EventArgs)
    	txtSearch.Clear
    End Sub
    
    Sub BtnApplyFilterClick(sender As Object, e As EventArgs)
    	
    End Sub
    
    Sub BtnFilterClick(sender As Object, e As EventArgs)
    	con = New OleDbConnection(conStr) 
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("SELECT * FROM [Input] WHERE [Sex] LIKE ? ;",con)
        da.SelectCommand.Parameters.AddWithValue("?", cmbSexFilter.Text & "%")
        da.Fill(dt)
        
        listView1.Items.Clear
        
        For Each row As DataRow In dt.Rows 
            Dim item As ListViewItem = New ListViewItem(row(0).ToString())
            item.SubItems.Add(row(1).ToString()) 
            item.SubItems.Add(row(2).ToString())
            item.SubItems.Add(row(3).ToString()) 
            item.SubItems.Add(row(4).ToString())
            item.SubItems.Add(row(5).ToString())
            listView1.Items.Add(item)
        Next
    End Sub
    
   
    
    Sub BtnSearchClick(sender As Object, e As EventArgs)
    	Try
        Using con As New OleDbConnection(conStr)
            con.Open()
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter("SELECT * FROM [Input] WHERE [First Name] LIKE ? AND [Sex] = ?;", con)
            da.SelectCommand.Parameters.AddWithValue("FirstName", txtSearch.Text & "%")
            da.SelectCommand.Parameters.AddWithValue("Sex", cmbSexFilter.Text)
            da.Fill(dt)
            
            listView1.Items.Clear

            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row(0).ToString())
                item.SubItems.Add(row(1).ToString())
                item.SubItems.Add(row(2).ToString())
                item.SubItems.Add(row(3).ToString())
                item.SubItems.Add(row(4).ToString())
                item.SubItems.Add(row(5).ToString())
                listView1.Items.Add(item)
            Next
        End Using
    Catch ex As Exception
        ' Handle any exceptions that occurred during the execution
        MessageBox.Show("An error occurred: " & ex.Message)
    End Try
    End Sub

    
    Sub btnCloseClick(sender As Object, e As EventArgs)
        Dim response As Integer
        
        response = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If response = vbYes Then
            Application.ExitThread
        Else
            Return
        End If

    End Sub
    
    Sub BtnMaximizeClick(sender As Object, e As EventArgs)
    	Me.WindowState = FormWindowState.Maximized
    	btnMax.Visible = False
		btnMaxed.Location = btnMax.Location
		btnMaxed.Visible = True
    End Sub
    
    
    Sub BtnMaxedClick(sender As Object, e As EventArgs)
    	Me.WindowState = FormWindowState.Normal
		btnMaxed.Visible = False
		btnMax.Visible = True
    End Sub
    
    Sub BtnMinimizeClick(sender As Object, e As EventArgs)
    	Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
