Imports Dapper

Public Class UserData

    Dim sql As New SqlDataAccess()
    Public Function GetUser(userNmae As String) As UserModel
        Try
            Dim query As String = $"select * from tblUsers where UserName = @UserName"
            Dim p As New DynamicParameters()
            p.Add("UserName", userNmae)
            Return sql.LoadData(Of UserModel, DynamicParameters)(query, p).FirstOrDefault()
        Catch ex As Exception
        End Try
    End Function
    Public Function GetUser(id As Integer) As UserModel
        Try
            Dim query As String = $"select * from tblUsers where Id = @Id"
            Dim p As New DynamicParameters()
            p.Add("Id", id)
            Return sql.LoadData(Of UserModel, DynamicParameters)(query, p).FirstOrDefault()
        Catch ex As Exception
        End Try
    End Function
    Public Function GetUsers() As List(Of UserModel)
        Try
            Dim query As String = $"select * from tblUsers"
            Return sql.LoadData(Of UserModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function
    Public Function SaveUser(model As UserModel)
        Dim query As String = $"insert into tblUsers (UserFullName, UserName, UserPassword)  values (@UserFullName, @UserName, @UserPassword)"
        Dim p = New DynamicParameters()
        p.Add("UserFullName", model.UserFullName)
        p.Add("UserName", model.UserName)
        p.Add("UserPassword", model.UserPassword)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function

    Public Function UpdateUser(model As UserModel)
        Dim p = New DynamicParameters()
        p.Add("UserFullName", model.UserFullName)
        p.Add("Id", model.Id)
        Dim query As String
        If model.UserPassword IsNot Nothing Then
            p.Add("UserPassword", model.UserPassword)
            query = $"UPDATE tblUsers SET UserFullName = @UserFullName, UserPassword = @UserPassword WHERE Id = @Id"
        Else
            query = $"UPDATE tblUsers SET UserFullName = @UserFullName WHERE Id = @Id"
        End If
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function

    Public Function deleteUser(id As Integer)
        Dim query As String = $"delete tblUsers where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
End Class
