Imports Dapper

Public Class TeachersData
    Dim sql As New SqlDataAccess()
    Public Function GetTeachers() As List(Of TeachersModel)
        Try
            Dim query As String = $"  select * from tblTeachers"
            Return sql.LoadData(Of TeachersModel, Object)(query, Nothing)
        Catch ex As Exception
        End Try
    End Function
    Public Function SaveTeacher(model As TeachersModel)
        Dim query As String = $"insert into tblTeachers (FullName,NationalNumber,EducationalLevel,BirthDay,PersonalPhoto,BankAccountNumber,PhoneNumber,TeacherAddress,capacity)
                                          values (@FullName,@NationalNumber,@EducationalLevel,@BirthDay,@PersonalPhoto,@BankAccountNumber,@PhoneNumber,@TeacherAddress,@Capacity)"
        Dim p = New DynamicParameters()
        p.Add("FullName", model.FullName)
        p.Add("NationalNumber", model.NationalNumber)
        p.Add("EducationalLevel", model.EducationalLevel)
        p.Add("BirthDay", model.BirthDay)
        p.Add("PersonalPhoto", model.PersonalPhoto)
        p.Add("BankAccountNumber", model.BankAccountNumber)
        p.Add("PhoneNumber", model.PhoneNumber)
        p.Add("TeacherAddress", model.TeacherAddress)
        p.Add("Capacity", model.Capacity)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function UpdateTeacher(model As TeachersModel)
        Dim query As String = $"  update  tblTeachers set FullName = @FullName,NationalNumber= @NationalNumber,
                                  EducationalLevel = @EducationalLevel,BirthDay = @BirthDay,PersonalPhoto = @PersonalPhoto,
                                  BankAccountNumber = @BankAccountNumber,PhoneNumber = @PhoneNumber,TeacherAddress = @TeacherAddress,capacity = @capacity
                                  where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("FullName", model.FullName)
        p.Add("NationalNumber", model.NationalNumber)
        p.Add("EducationalLevel", model.EducationalLevel)
        p.Add("BirthDay", model.BirthDay)
        p.Add("PersonalPhoto", model.PersonalPhoto)
        p.Add("BankAccountNumber", model.BankAccountNumber)
        p.Add("PhoneNumber", model.PhoneNumber)
        p.Add("TeacherAddress", model.TeacherAddress)
        p.Add("Capacity", model.Capacity)
        p.Add("Id", model.Id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
    Public Function deleteTeacher(id As Integer)
        Dim query As String = $"delete tblTeachers where Id = @Id"
        Dim p = New DynamicParameters()
        p.Add("Id", id)
        sql.SaveData(Of DynamicParameters)(query, p)
    End Function
End Class
