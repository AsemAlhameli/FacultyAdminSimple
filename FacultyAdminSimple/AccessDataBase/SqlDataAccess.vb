Imports System.Data.SqlClient
Imports System.Data
Imports Dapper


Public Class SqlDataAccess
    'هذه الدالى تعيد نص الاتصال با القاعدة 
    Public Function GetConnectionString(name As String) As String
        'نص الاتصال    الجزء الاول اسم السرفر الجزء الثاني اسم القاعدة الجزء الثالث نوع الحماية 
        Return $"Server=(localdb)\ProjectModels;Database={name};Trusted_Connection=True;"

    End Function
    ''' <summary>
    ''' نقوم بجلب البينات من القاعدة با استخدام هذه الدالة 
    ''' </summary>
    ''' <typeparam name="T"> نوع البيانات </typeparam>
    ''' <typeparam name="U">نوع البرمترات المرسلة </typeparam>
    ''' <param name="query">نص الاستعلام</param>
    ''' <param name="parameter">البرمترات</param>
    ''' <param name="connectionString">اسم القاعدة</param>
    ''' <param name="queryType">نوع الاستعلام</param>
    ''' <returns></returns>
    Public Function LoadData(Of T, U)(query As String, parameter As U, Optional connectionString As String = "SystemDb", Optional queryType As CommandType = CommandType.Text) As List(Of T)
        connectionString = GetConnectionString(connectionString)
        Using connection As IDbConnection = New SqlConnection(connectionString)
            Dim rows As List(Of T) = connection.Query(Of T)(query, parameter, commandType:=queryType).ToList()
            Return rows
        End Using
    End Function
    ''' <summary>
    ''' هذه الدالة تقوم بحفظ البيانات للقاعدة 
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="query"></param>
    ''' <param name="parameter"></param>
    ''' <param name="connectionString"></param>
    ''' <param name="queryType"></param>
    ''' <returns></returns>
    Public Function SaveData(Of T)(query As String, parameter As T, Optional connectionString As String = "SystemDb", Optional queryType As CommandType = CommandType.Text)
        connectionString = GetConnectionString(connectionString)
        Using connection As IDbConnection = New SqlConnection(connectionString)
            connection.Execute(query, parameter, commandType:=queryType)


        End Using
    End Function

End Class


