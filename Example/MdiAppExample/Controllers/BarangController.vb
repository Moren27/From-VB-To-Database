Imports Dhanifudin.Database
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class BarangController
    Inherits MySqlAutoController(Of Barang)

    Protected Overrides Function GetPrimaryKey() As String
        Return "barang_id"
    End Function

    Protected Overrides Function GetTableName() As String
        Return "barang"
    End Function

    Protected Overrides Function LengthId() As Integer
        Return 10
    End Function

    Protected Overrides Function DefaultSelectSql() As String
        Return "select * from barang"
    End Function

    Protected Overrides Function DefaultInsertSql(item As Barang) As String
        Return "insert into barang(barang_id, nama) values(@barang_id, @nama)"
    End Function

    Protected Overrides Function DefaultUpdateSql(item As Barang) As String
        Return "update barang set nama=@nama where barang_id=@barang_id"
    End Function

    Protected Overrides Function DefaultDeleteSql(item As Barang) As String
        Return "delete from barang where barang_id=@barang_id"
    End Function

    Protected Overrides Sub InsertParameters(ByRef command As MySqlCommand, item As Barang)
        command.Parameters.AddWithValue("@barang_id", item.Id)
        command.Parameters.AddWithValue("@nama", item.Nama)
    End Sub

    Protected Overrides Sub UpdateParameters(ByRef command As MySqlCommand, item As Barang)
        command.Parameters.AddWithValue("@barang_id", item.Id)
        command.Parameters.AddWithValue("@nama", item.Nama)
    End Sub

    Protected Overrides Sub DeleteParameters(ByRef command As MySqlCommand, item As Barang)
        command.Parameters.AddWithValue("@barang_id", item.Id)
    End Sub

    Protected Overrides Sub PopulateData(reader As MySqlDataReader, ByRef result As BindingList(Of Barang))
        If reader.HasRows() Then
            Do While reader.Read()
                Dim barang As New Barang()
                barang.Id = Parse.Value(reader("barang_id"))
                barang.Nama = Parse.Value(reader("nama"))
                result.Add(Barang)
            Loop
        End If
    End Sub
End Class
