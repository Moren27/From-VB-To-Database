Imports Dhanifudin.Database
Imports System.Text

Public Class TransaksiController
    Inherits MySqlAutoController(Of Transaksi)

    Protected Overrides Function GetPrimaryKey() As String
        Return "transaksi_id"
    End Function

    Protected Overrides Function GetTableName() As String
        Return "transaksi"
    End Function

    Protected Overrides Function LengthId() As Integer
        Return 10
    End Function

    Protected Overrides Function DefaultSelectSql() As String
        Return "select * from transaksi"
    End Function

    Protected Overrides Function DefaultInsertSql(item As Transaksi) As String
        Dim sql As New StringBuilder
        sql.Append(String.Format("insert into transaksi(transaksi_id,nama) values('{0}', '{1}');", item.Id, item.Nama))
        For Each d As Detail In item.DetailList
            sql.Append(String.Format("insert into detail(transaksi_id, barang_id, jumlah) values ('{0}', '{1}', {2});", d.Transaksi.Id, d.Barang.Id, d.Quantity))
        Next
        Return sql.ToString()
    End Function

    Protected Overrides Sub PopulateData(reader As MySql.Data.MySqlClient.MySqlDataReader, ByRef result As System.ComponentModel.BindingList(Of Transaksi))
        If reader.HasRows() Then
            Do While reader.Read()
                Dim item As New Transaksi()
                item.Id = Parse.Value(reader("transaksi_id"))
                item.Nama = Parse.Value(reader("nama"))
                result.Add(item)
            Loop
        End If
    End Sub
End Class
