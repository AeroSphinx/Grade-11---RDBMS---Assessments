Imports System.Data.OleDb
Imports System.Data
' Created by SharpDevelop.
' User: Twinkle
' Date: 23/05/2023
' Time: 9:47 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Module myModule
	    Public conStr As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\myDbase3.mdb"
	
        Public con As OleDbConnection = New OleDbConnection(conStr)
End Module
