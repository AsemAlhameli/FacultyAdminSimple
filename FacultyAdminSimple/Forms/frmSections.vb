Public Class frmSections
    Dim dataAccess As New SectionData()
    Dim id As Integer = 0
    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Close()
    End Sub
    Private Function componentInit(isEnable As Boolean)
        txt_SectionName.Enabled = isEnable
        cb_Section.Enabled = isEnable
        btn_Save.Enabled = isEnable
        btn_New.Enabled = Not isEnable
        If Not isEnable Then
            Id = 0
            txt_SectionName.Text = ""
        End If
    End Function
    Private Sub RefreshData()
        Dim userList As List(Of SectionModel) = dataAccess.GetSections()
        dgv_SectionData.DataSource = Nothing
        dgv_SectionData.DataSource = userList
    End Sub
    Private Function IntModel() As SectionModel
        Dim model As SectionModel = New SectionModel()
        model.SectionName = txt_SectionName.Text
        model.IsScientificSection = cb_Section.Checked
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
            If String.IsNullOrEmpty(txt_SectionName.Text) Then
                Return
            End If
            Dim confirmMessage As String
            If id > 0 Then
                confirmMessage = "هل تريد تحديث بيانات القسم؟"
            Else
                confirmMessage = "هل تريد إضافة القسم؟"
            End If
            Dim result As DialogResult = MessageBox.Show(confirmMessage, "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If id > 0 Then
                    dataAccess.UpdateSection(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم تحديث بيانات القسم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    dataAccess.SaveSection(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم اضافة القسم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                dataAccess.deleteSection(id)
                RefreshData()
                componentInit(False)
                MessageBox.Show("تم حذف القسم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub frmSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_SectionData.AutoGenerateColumns = False

        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.DataPropertyName = "Id"
        idColumn.HeaderText = "Id"
        idColumn.Visible = False
        dgv_SectionData.Columns.Add(idColumn)

        Dim sectionNameColumn As New DataGridViewTextBoxColumn()
        sectionNameColumn.DataPropertyName = "SectionName"
        sectionNameColumn.HeaderText = "اسم القسم"
        dgv_SectionData.Columns.Add(sectionNameColumn)

        Dim isScientificSectionColumn As New DataGridViewTextBoxColumn()
        isScientificSectionColumn.DataPropertyName = "IsScientificSection"
        isScientificSectionColumn.HeaderText = "هل القسم علمي"
        dgv_SectionData.Columns.Add(isScientificSectionColumn)

        dgv_SectionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        RefreshData()
    End Sub

    Private Sub dgv_SectionData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SectionData.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = dgv_SectionData.Rows(e.RowIndex)
                If selectedRow IsNot Nothing Then
                    If selectedRow.Cells.Count >= 2 Then
                        Dim isScientificSectionCellValue As Object = selectedRow.Cells(2).Value
                        Dim sectionNameCellValue As Object = selectedRow.Cells(1).Value
                        Dim userIdCellValue As Object = selectedRow.Cells(0).Value

                        If sectionNameCellValue IsNot Nothing AndAlso userIdCellValue IsNot Nothing Then
                            Dim sectionNameColumn As String = sectionNameCellValue.ToString()
                            Dim isScientificSectionColumn As Boolean = Boolean.Parse(isScientificSectionCellValue)
                            Dim userId As Integer
                            If Integer.TryParse(userIdCellValue.ToString(), userId) Then
                                txt_SectionName.Text = sectionNameColumn
                                cb_Section.Checked = isScientificSectionColumn
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