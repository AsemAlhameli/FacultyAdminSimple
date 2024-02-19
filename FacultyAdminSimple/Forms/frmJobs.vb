Public Class frmJobs
    Dim dataAccess As New JobData()
    Dim id As Integer = 0

    Private Function componentInit(isEnable As Boolean)
        txt_jobName.Enabled = isEnable
        btn_Save.Enabled = isEnable
        btn_New.Enabled = Not isEnable
        If Not isEnable Then
            id = 0
            txt_jobName.Text = ""
        End If
    End Function
    Private Sub RefreshData()
        Dim userList As List(Of JobModel) = dataAccess.GetJobs()
        dgv_jobData.DataSource = Nothing
        dgv_jobData.DataSource = userList
    End Sub
    Private Function IntModel() As JobModel
        Dim model As JobModel = New JobModel()
        model.JobName = txt_jobName.Text
        model.Id = id
        Return model
    End Function
    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Close()
    End Sub

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
            If String.IsNullOrEmpty(txt_jobName.Text) Then
                Return
            End If
            Dim confirmMessage As String
            If id > 0 Then
                confirmMessage = "هل تريد تحديث بيانات المهمة؟"
            Else
                confirmMessage = "هل تريد إضافة المهمة؟"
            End If
            Dim result As DialogResult = MessageBox.Show(confirmMessage, "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If id > 0 Then
                    dataAccess.UpdateJob(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم تحديث بيانات المهمة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    dataAccess.SaveJob(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم اضافة المهمة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                dataAccess.deleteJob(id)
                RefreshData()
                componentInit(False)
                MessageBox.Show("تم حذف المهمة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub frmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_jobData.AutoGenerateColumns = False

        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.DataPropertyName = "Id"
        idColumn.HeaderText = "Id"
        idColumn.Visible = False
        dgv_jobData.Columns.Add(idColumn)

        Dim jobNameColumn As New DataGridViewTextBoxColumn()
        jobNameColumn.DataPropertyName = "JobName"
        jobNameColumn.HeaderText = "اسم المهمة"
        dgv_jobData.Columns.Add(jobNameColumn)

        dgv_jobData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        RefreshData()
    End Sub

    Private Sub dgv_jobData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jobData.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = dgv_jobData.Rows(e.RowIndex)
                If selectedRow IsNot Nothing Then
                    If selectedRow.Cells.Count >= 2 Then
                        Dim jobNameCellValue As Object = selectedRow.Cells(1).Value
                        Dim userIdCellValue As Object = selectedRow.Cells(0).Value

                        If jobNameCellValue IsNot Nothing AndAlso userIdCellValue IsNot Nothing Then
                            Dim jobNameColumn As String = jobNameCellValue.ToString()
                            Dim userId As Integer
                            If Integer.TryParse(userIdCellValue.ToString(), userId) Then
                                txt_jobName.Text = jobNameColumn
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