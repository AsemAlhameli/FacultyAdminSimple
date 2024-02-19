Imports Dapper

Public Class SectionData
    Dim sql As New SqlDataAccess()
    Public Function GetSections() As List(Of SectionModel)
        Try
            Dim query As String = $"SELECT * FROM tblSections"
            Return sql.LoadData(Of SectionModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function
    Public Function SaveSection(model As SectionModel)
        Dim query As String = $"insert into tblSections (SectionName,IsScientificSection) values (@SectionName,@IsScientificSection)"
        Dim p = New DynamicParameters()
        p.Add("SectionName", model.SectionName)
        p.Add("IsScientificSection", model.IsScientificSection)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function UpdateSection(model As SectionModel)
        Dim query As String = $"update tblSections set SectionName = @SectionName , IsScientificSection = @IsScientificSection"
        Dim p = New DynamicParameters()
        p.Add("SectionName", model.SectionName)
        p.Add("IsScientificSection", model.IsScientificSection)
        p.Add("Id", model.Id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function deleteSection(id As Integer)
        Dim query As String = $"delete tblSections where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
End Class
