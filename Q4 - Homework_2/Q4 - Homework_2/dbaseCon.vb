Imports System.Data.OleDb
Imports System.Data


Public Module DbaseConnector
    Public conStr As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\myDbase.mdb"
    Public con As OleDbConnection = New OleDbConnection(conStr)
    
    
End Module
