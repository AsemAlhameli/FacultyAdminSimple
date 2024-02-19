Imports Dapper

Public Class StudentData
    Dim sql As New SqlDataAccess()
    Public Function GetStudents() As List(Of StudentModel)
        Try
            Dim query As String = $"SELECT dbo.tblStudents.Id, dbo.tblStudents.StudentName, dbo.tblStudents.AcademicNumber, dbo.tblStudents.SectionsId,
                                    dbo.tblSections.SectionName FROM dbo.tblStudents 
                                        INNER JOIN dbo.tblSections ON dbo.tblStudents.SectionsId = dbo.tblSections.Id"
            Return sql.LoadData(Of StudentModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function

    Public Function SaveStudent(model As StudentModel)
        Dim query As String = $"insert into tblStudents (StudentName,AcademicNumber,SectionsId) values (@StudentName,@AcademicNumber,@SectionsId)"
        Dim p = New DynamicParameters()
        p.Add("StudentName", model.StudentName)
        p.Add("AcademicNumber", model.AcademicNumber)
        p.Add("SectionsId", model.SectionsId)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function UpdateStudent(model As StudentModel)
        Dim query As String = $"update tblStudents set StudentName = @StudentName,AcademicNumber =@AcademicNumber,SectionsId = @SectionsId where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("StudentName", model.StudentName)
        p.Add("AcademicNumber", model.AcademicNumber)
        p.Add("SectionsId", model.SectionsId)
        p.Add("Id", model.Id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function deleteStudent(id As Integer)
        Dim query As String = $"delete tblStudents where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function

End Class
