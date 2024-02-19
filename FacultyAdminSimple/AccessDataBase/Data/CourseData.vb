Imports Dapper

Public Class CourseData
    Dim sql As New SqlDataAccess()
    Public Function GetCourses() As List(Of CourseModel)
        Try
            Dim query As String = $"select * from tblCourse"
            Return sql.LoadData(Of CourseModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function

    Public Function SaveCourse(model As CourseModel)
        Dim query As String = $"insert into tblCourse (CoursetName, IsTheoretical,IsProject,NumberOfHours) values (@CoursetName, @IsTheoretical,@IsProject,@NumberOfHours)"
        Dim p = New DynamicParameters()
        p.Add("CoursetName", model.CourseName)
        p.Add("IsTheoretical", model.IsTheoretical)
        p.Add("IsProject", model.IsProject)
        p.Add("NumberOfHours", model.NumberOfHours)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function UpdateCourse(model As CourseModel)
        Dim query As String = $"  update  tblCourse set CoursetName = @CoursetName, IsTheoretical = @IsTheoretical,IsProject = @IsProject,NumberOfHours = @NumberOfHours where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("CoursetName", model.CourseName)
        p.Add("IsTheoretical", model.IsTheoretical)
        p.Add("IsProject", model.IsProject)
        p.Add("NumberOfHours", model.NumberOfHours)
        p.Add("Id", model.Id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function deleteCourse(id As Integer)
        Dim query As String = $"delete tblCourse where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
End Class
