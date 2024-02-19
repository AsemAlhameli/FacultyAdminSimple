Imports Dapper

Public Class AttendanceData
    Dim sql As New SqlDataAccess()
    Public Function GetAttendances() As List(Of AttendanceModel)
        Try
            Dim query As String = $"select * from tblAttendance"
            Return sql.LoadData(Of AttendanceModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function

    Public Function SaveAttendance(model As AttendanceModel)
        Dim query As String = $"insert into tblAttendance (TeacherId,EventDate,EventType) values (@TeacherId,@EventDate,@EventType)"
        Dim p = New DynamicParameters()
        p.Add("TeacherId", model.TeacherId)
        p.Add("EventDate", model.EventDate)
        p.Add("EventType", model.EventType)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function UpdateAttendance(model As AttendanceModel)
        Dim query As String = $"update tblAttendance set TeacherId = @TeacherId,EventDate = @EventDate ,EventType =EventType"
        Dim p = New DynamicParameters()
        p.Add("TeacherId", model.TeacherId)
        p.Add("EventDate", model.EventDate)
        p.Add("EventType", model.EventType)
        p.Add("Id", model.Id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function deleteAttendance(id As Integer)
        Dim query As String = $"delete tblJobs where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function

End Class
