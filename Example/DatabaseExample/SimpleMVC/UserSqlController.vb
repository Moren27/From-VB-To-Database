Imports Dhanifudin.Database
Imports System.ComponentModel

Public Class UserSqlController
    Inherits SqlController(Of User)

    Protected Overrides Function DefaultSelectSql() As String
        Return "select * from pengguna"
    End Function

    Protected Overrides Function DefaultInsertSql(item As User) As String
        Return String.Format("insert into pengguna values('{0}','{1}','{2}')", item.Id, item.Name, item.Password)
    End Function

    Protected Overrides Function DefaultUpdateSql(item As User) As String
        Return String.Format("update pengguna set name='{0}',password='{1}' where user_id='{2}'", item.Name, item.Password, item.Id)
    End Function

    Protected Overrides Function DefaultDeleteSql(item As User) As String
        Return String.Format("delete from pengguna where user_id='{0}'", item.Id)
    End Function

    Protected Overrides Sub PopulateData(reader As System.Data.SqlClient.SqlDataReader, ByRef result As BindingList(Of User))
        If reader.HasRows Then
            Do While reader.Read()
                Dim user As New User()
                user.Id = reader("user_id")
                user.Name = reader("name")
                user.Password = reader("password")
                result.Add(user)
            Loop
        End If
    End Sub
End Class
