Imports System.Data.SqlClient
Module Module1
    Public ds As New DataSet()
    Public connectionstring As String = "workstation id=lanlinh.mssql.somee.com;packet size=4096;user id=lanlinh-ps03199_SQLLogin_1;pwd=ly5o4hrot9;data source=lanlinh.mssql.somee.com;persist security info=False;initial catalog=lanlinh"
    'Public connectionstring As String = "Server=localhost;Database=INF205-PS03199;Integrated Security=True"
    Public Sub Executenonquery(sql As String)
        Dim connection As New SqlConnection(connectionstring)
        Dim command As New SqlCommand(sql, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Public Sub fill(sql As String, tenbang As String)
        Dim connection As New SqlConnection(connectionstring)
        Dim dataAdapter As New SqlDataAdapter(sql, connection)
        If ds.Tables.Contains(tenbang) Then
            ds.Tables(tenbang).Clear()
        End If
        dataAdapter.Fill(ds, tenbang)
        connection.Close()

    End Sub
End Module
'linhctl_SQLLogin_1
'enfwio4nlv