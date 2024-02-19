Public Class frmCourse
    Dim dataAccess As New CourseData()
    Dim id As Integer = 0
    Private Function componentInit(isEnable As Boolean)
        txt_CourseName.Enabled = isEnable
        txt_NumberOfHours.Enabled = isEnable
        cb_IsProject.Enabled = isEnable
        cb_IsTheoretical.Enabled = isEnable
        btn_Save.Enabled = isEnable
        btn_New.Enabled = Not isEnable
        If Not isEnable Then
            id = 0
            txt_CourseName.Text = ""
            txt_NumberOfHours.Text = ""
        End If
    End Function
    Private Sub RefreshData()
        Dim userList As List(Of CourseModel) = dataAccess.GetCourses()
        dgv_ProjectData.DataSource = Nothing
        dgv_ProjectData.DataSource = userList
    End Sub
    Private Function IntModel() As CourseModel
        Dim model As CourseModel = New CourseModel()
        model.NumberOfHours = txt_NumberOfHours.Text
        model.CourseName = txt_CourseName.Text
        model.IsTheoretical = cb_IsTheoretical.Checked
        model.IsProject = cb_IsProject.Checked
        model.Id = id
        Return model
    End Function
    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        componentInit(True)
        id = 0
    End Sub

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
            If String.IsNullOrEmpty(txt_CourseName.Text) AndAlso String.IsNullOrEmpty(txt_NumberOfHours.Text) Then
                Return
            End If
            Dim confirmMessage As String
            If id > 0 Then
                confirmMessage = "هل تريد تحديث المشروع المهمة؟"
            Else
                confirmMessage = "هل تريد إضافة المشروع؟"
            End If
            Dim result As DialogResult = MessageBox.Show(confirmMessage, "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If id > 0 Then
                    dataAccess.UpdateCourse(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم تحديث بيانات المشروع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    dataAccess.SaveCourse(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم اضافة المشروع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                dataAccess.deleteCourse(id)
                RefreshData()
                componentInit(False)
                MessageBox.Show("تم حذف المشروع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Close()
    End Sub

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_ProjectData.AutoGenerateColumns = False

        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.DataPropertyName = "Id"
        idColumn.HeaderText = "Id"
        idColumn.Visible = False
        dgv_ProjectData.Columns.Add(idColumn)

        Dim courseNameColumn As New DataGridViewTextBoxColumn()
        courseNameColumn.DataPropertyName = "CourseName"
        courseNameColumn.HeaderText = "اسم المشروع"
        dgv_ProjectData.Columns.Add(courseNameColumn)

        Dim numberOfHoursColumn As New DataGridViewTextBoxColumn()
        numberOfHoursColumn.DataPropertyName = "NumberOfHours"
        numberOfHoursColumn.HeaderText = "عدد الساعات"
        dgv_ProjectData.Columns.Add(numberOfHoursColumn)

        Dim isTheoreticalColumn As New DataGridViewTextBoxColumn()
        isTheoreticalColumn.DataPropertyName = "IsTheoretical"
        isTheoreticalColumn.HeaderText = "المشروع نظري"
        dgv_ProjectData.Columns.Add(isTheoreticalColumn)

        Dim isProjectColumn As New DataGridViewTextBoxColumn()
        isProjectColumn.DataPropertyName = "IsProject"
        isProjectColumn.HeaderText = "المشروع عملية "
        dgv_ProjectData.Columns.Add(isProjectColumn)
        dgv_ProjectData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        RefreshData()
    End Sub

    Private Sub dgv_ProjectData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProjectData.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = dgv_ProjectData.Rows(e.RowIndex)
                If selectedRow IsNot Nothing Then
                    If selectedRow.Cells.Count >= 2 Then
                        Dim isProjectnCellValue As Object = selectedRow.Cells(4).Value
                        Dim courseNameCellValue As Object = selectedRow.Cells(1).Value
                        Dim numberOfHoursCellValue As Object = selectedRow.Cells(2).Value
                        Dim isTheoreticalCellValue As Object = selectedRow.Cells(3).Value
                        Dim projectIdCellValue As Object = selectedRow.Cells(0).Value

                        If numberOfHoursCellValue IsNot Nothing AndAlso courseNameCellValue IsNot Nothing AndAlso projectIdCellValue IsNot Nothing Then
                            Dim courseNameColumn As String = courseNameCellValue.ToString()
                            Dim numberOfHoursColumn As String = numberOfHoursCellValue.ToString()
                            Dim isProjectnColumn As Boolean = Boolean.Parse(isProjectnCellValue)
                            Dim isTheoreticalColumn As Boolean = Boolean.Parse(isTheoreticalCellValue)
                            Dim userId As Integer
                            If Integer.TryParse(projectIdCellValue.ToString(), userId) Then
                                txt_CourseName.Text = courseNameColumn
                                txt_NumberOfHours.Text = numberOfHoursColumn
                                cb_IsProject.Checked = isProjectnColumn
                                cb_IsTheoretical.Checked = isTheoreticalColumn
                                id = userId
                                btnEdit.Enabled = True
                                btn_Delete.Enabled = True
                                btn_New.Enabled = False
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "حصل خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class