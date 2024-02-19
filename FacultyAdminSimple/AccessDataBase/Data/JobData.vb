Imports Dapper

Public Class JobData
    Dim sql As New SqlDataAccess()
    Public Function GetJobs() As List(Of JobModel)
        Try
            Dim query As String = $"select * from tblJobs"
            Return sql.LoadData(Of JobModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function

    Public Function SaveJob(model As JobModel)
        Dim query As String = $"INSERT INTO tblJobs (JobName) VALUES (@JobName)"
        Dim p = New DynamicParameters()
        p.Add("JobName", model.JobName)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function UpdateJob(model As JobModel)
        Dim query As String = $"update tblJobs set JobName  = @JobName where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("JobName", model.JobName)
        p.Add("Id", model.Id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function deleteJob(id As Integer)
        Dim query As String = $"delete tblJobs where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function

End Class
