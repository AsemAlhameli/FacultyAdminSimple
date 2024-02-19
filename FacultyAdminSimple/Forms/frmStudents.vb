Public Class frmStudents
    Dim dataAccess As New StudentData()
    Dim id As Integer = 0
    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Close()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        componentInit(True)
        id = 0
    End Sub
    Private Function componentInit(isEnable As Boolean)
        txt_AcademicNumber.Enabled = isEnable
        txt_StudentName.Enabled = isEnable
        com_SectionsId.Enabled = isEnable
        btn_Save.Enabled = isEnable
        btn_New.Enabled = Not isEnable
        If Not isEnable Then
            id = 0
            txt_StudentName.Text = ""
            txt_AcademicNumber.Text = ""
        End If
    End Function
    Private Sub RefreshData()
        Dim studentList As List(Of StudentModel) = dataAccess.GetStudents()
        Dim SectionData As SectionData = New SectionData()
        Dim sectionList As List(Of SectionModel) = SectionData.GetSections()
        dgv_StudentsData.DataSource = Nothing
        dgv_StudentsData.DataSource = studentList



        com_SectionsId.DataSource = Nothing
        com_SectionsId.DataSource = sectionList

        com_SectionsId.DisplayMember = "SectionName"
        com_SectionsId.ValueMember = "Id"

    End Sub


    Private Function IntModel() As StudentModel
        Dim model As StudentModel = New StudentModel()
        model.StudentName = txt_StudentName.Text
        model.AcademicNumber = txt_AcademicNumber.Text
        model.SectionsId = Convert.ToInt32(com_SectionsId.SelectedValue)
        model.Id = id
        Return model
    End Function
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btn_Delete.Enabled = False
        componentInit(True)
    End Sub

    Private Sub btn_Init_Click(sender As Object, e As EventArgs) Handles btn_Init.Click
        componentInit(False)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            If String.IsNullOrEmpty(txt_StudentName.Text) OrElse String.IsNullOrEmpty(txt_AcademicNumber.Text) Then
                Return
            End If
            Dim confirmMessage As String
            If id > 0 Then
                confirmMessage = "هل تريد تحديث بيانات الطالب؟"
            Else
                confirmMessage = "هل تريد إضافة الطالب؟"
            End If
            Dim result As DialogResult = MessageBox.Show(confirmMessage, "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If id > 0 Then
                    dataAccess.UpdateStudent(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم تحديث بيانات الطالب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    dataAccess.SaveStudent(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم اضافة الطالب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("لم يتم القيام بأي عملية", "إلغاء", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "حصل خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If id > 0 Then
            Dim result As DialogResult = MessageBox.Show("هل انت متاكد من عملية الحذف", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                dataAccess.deleteStudent(id)
                RefreshData()
                componentInit(False)
                MessageBox.Show("تم حذف الطالب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_StudentsData.AutoGenerateColumns = False
        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.DataPropertyName = "Id"
        idColumn.HeaderText = "Id"
        idColumn.Visible = False
        dgv_StudentsData.Columns.Add(idColumn)


        Dim sectionsIdColumn As New DataGridViewTextBoxColumn()
        sectionsIdColumn.DataPropertyName = "SectionsId"
        sectionsIdColumn.HeaderText = "SectionsId"
        sectionsIdColumn.Visible = False
        dgv_StudentsData.Columns.Add(sectionsIdColumn)

        Dim studentNameColumn As New DataGridViewTextBoxColumn()
        studentNameColumn.DataPropertyName = "StudentName"
        studentNameColumn.HeaderText = "اسم الطالب"
        dgv_StudentsData.Columns.Add(studentNameColumn)

        Dim academicNumberColumn As New DataGridViewTextBoxColumn()
        academicNumberColumn.DataPropertyName = "AcademicNumber"
        academicNumberColumn.HeaderText = "الرقم الجامعي"
        dgv_StudentsData.Columns.Add(academicNumberColumn)

        Dim sectionsNameColumn As New DataGridViewTextBoxColumn()
        sectionsNameColumn.DataPropertyName = "SectionName"
        sectionsNameColumn.HeaderText = "اسم القسم"
        dgv_StudentsData.Columns.Add(sectionsNameColumn)

        dgv_StudentsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        RefreshData()
    End Sub

    Private Sub dgv_StudentsData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_StudentsData.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = dgv_StudentsData.Rows(e.RowIndex)
                If selectedRow IsNot Nothing Then
                    If selectedRow.Cells.Count >= 4 Then
                        Dim studentIdCellValue As Object = selectedRow.Cells(0).Value
                        Dim sectionsIdCellValue As Object = selectedRow.Cells(1).Value
                        Dim studentNameCellValue As Object = selectedRow.Cells(2).Value
                        Dim academicNumberCellValue As Object = selectedRow.Cells(3).Value
                        If studentIdCellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(studentIdCellValue.ToString()) AndAlso
                                sectionsIdCellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(sectionsIdCellValue.ToString()) AndAlso
                                studentNameCellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(studentNameCellValue.ToString()) AndAlso
                                academicNumberCellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(academicNumberCellValue.ToString()) Then
                            Dim studentName As String = studentNameCellValue.ToString()
                            Dim academicNumber As String = academicNumberCellValue.ToString()


                            Dim studentId As Integer
                            Dim sectionId As Integer

                            If Integer.TryParse(studentIdCellValue.ToString(), studentId) AndAlso Integer.TryParse(sectionsIdCellValue.ToString(), sectionId) Then
                                txt_StudentName.Text = studentName.ToString()
                                txt_AcademicNumber.Text = academicNumber.ToString()
                                id = studentId
                                btnEdit.Enabled = True
                                btn_Delete.Enabled = True
                                btn_New.Enabled = False
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class