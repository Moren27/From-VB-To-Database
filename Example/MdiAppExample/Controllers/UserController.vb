Imports Dhanifudin.Database
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class UserController
    Inherits MySqlAutoController(Of User)

    Protected Overrides Function GetTableName() As String
        Return "pengguna"
    End Function

    Protected Overrides Function GetPrimaryKey() As String
        Return "user_id"
    End Function

    Protected Overrides Function LengthId() As Integer
        Return 6
    End Function

    Protected Overrides Function DefaultSelectSql() As String
        Return "select * from pengguna"
    End Function

    Protected Overrides Function DefaultInsertSql(item As User) As String
        Return "insert into pengguna(user_id, username, nama, kata_sandi, jenis_kelamin, tempat_lahir, tanggal_lahir) values(@user_id, @username, @nama, @kata_sandi, @jenis_kelamin, @tempat_lahir, @tanggal_lahir)"
    End Function

    Protected Overrides Function DefaultUpdateSql(item As User) As String
        Return "update pengguna set username=@username, nama=@nama, jenis_kelamin=@jenis_kelamin, tempat_lahir=@tempat_lahir, tanggal_lahir=@tanggal_lahir where user_id=@user_id"
    End Function

    Protected Overrides Function DefaultDeleteSql(item As User) As String
        Return "delete from pengguna where user_id=@user_id"
    End Function

    Protected Overrides Sub InsertParameters(ByRef command As MySqlCommand, item As User)
        command.Parameters.AddWithValue("@user_id", item.UserId)
        command.Parameters.AddWithValue("@username", item.Username)
        command.Parameters.AddWithValue("@nama", item.Nama)
        command.Parameters.AddWithValue("@kata_sandi", item.KataSandi)
        command.Parameters.AddWithValue("@jenis_kelamin", item.JenisKelamin)
        command.Parameters.AddWithValue("@tempat_lahir", item.TempatLahir)
        command.Parameters.AddWithValue("@tanggal_lahir", item.TanggalLahir)
    End Sub

    Protected Overrides Sub UpdateParameters(ByRef command As MySqlCommand, item As User)
        command.Parameters.AddWithValue("@username", item.Username)
        command.Parameters.AddWithValue("@nama", item.Nama)
        command.Parameters.AddWithValue("@kata_sandi", item.KataSandi)
        command.Parameters.AddWithValue("@jenis_kelamin", item.JenisKelamin)
        command.Parameters.AddWithValue("@tempat_lahir", item.TempatLahir)
        command.Parameters.AddWithValue("@tanggal_lahir", item.TanggalLahir)
        command.Parameters.AddWithValue("@user_id", item.UserId)
    End Sub

    Protected Overrides Sub DeleteParameters(ByRef command As MySqlCommand, item As User)
        command.Parameters.AddWithValue("@user_id", item.UserId)
    End Sub

    Protected Overrides Sub PopulateData(reader As MySql.Data.MySqlClient.MySqlDataReader, ByRef result As BindingList(Of User))
        If reader.HasRows() Then
            Do While reader.Read()
                Dim user As New User()
                user.UserId = Parse.Value(reader("user_id"))
                user.Username = Parse.Value(reader("username"))
                user.KataSandi = Parse.Value(reader("kata_sandi"))
                user.Nama = Parse.Value(reader("nama"))
                user.JenisKelamin = Parse.Value(reader("jenis_kelamin"))
                user.TempatLahir = Parse.Value(reader("tempat_lahir"))
                user.TanggalLahir = Parse.Value(reader("tanggal_lahir"))
                result.Add(user)
            Loop
        End If
    End Sub

    Public Function Login(username As String, password As String) As User
        Dim filter As String = String.Format("username='{0}' and kata_sandi='{1}'", username, password)
        Dim results As BindingList(Of User) = Me.Search(filter)
        Return If(results.Count > 0, results.Item(0), Nothing)
    End Function
End Class
