Public Class frmUsers
    Dim dataAccess As New UserData()
    Dim id As Integer = 0

    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Close()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        componentInit(True)
        id = 0
    End Sub
    Private Function componentInit(isEnable As Boolean)
        txtUserName.Enabled = (id > 0 AndAlso Not isEnable) OrElse (id = 0 AndAlso isEnable)
        txtUserPassword.Enabled = isEnable
        txt_UserConvermPassword.Enabled = isEnable
        txt_UserFullName.Enabled = isEnable
        btn_Save.Enabled = isEnable
        btn_New.Enabled = Not isEnable
        If Not isEnable Then
            id = 0
            txtUserName.Text = ""
            txtUserPassword.Text = ""
            txt_UserConvermPassword.Text = ""
            txt_UserFullName.Text = ""
        End If
    End Function

    Private Sub RefreshData()
        Dim userList As List(Of UserModel) = dataAccess.GetUsers()
        dgv_UserData.DataSource = Nothing
        dgv_UserData.DataSource = userList
    End Sub
    Private Function IntModel() As UserModel
        Dim model As UserModel = New UserModel()
        model.UserFullName = txt_UserFullName.Text
        model.UserName = txtUserName.Text
        model.UserPassword = txtUserPassword.Text
        model.Id = id
        Return model
    End Function


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        Try
            Dim confirmMessage As String
            If id > 0 Then
                confirmMessage = "هل تريد تحديث بيانات المستخدم؟"
            Else
                confirmMessage = "هل تريد إضافة المستخدم؟"
            End If
            Dim result As DialogResult = MessageBox.Show(confirmMessage, "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If id > 0 Then
                    If String.IsNullOrEmpty(txtUserName.Text) OrElse String.IsNullOrEmpty(txt_UserFullName.Text) Then
                        Return
                    End If
                    If txtUserPassword.Text <> txt_UserConvermPassword.Text Then
                        Return
                    End If
                    dataAccess.UpdateUser(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم تحديث بيانات المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If String.IsNullOrEmpty(txtUserName.Text) OrElse String.IsNullOrEmpty(txtUserPassword.Text) OrElse String.IsNullOrEmpty(txt_UserFullName.Text) OrElse String.IsNullOrEmpty(txt_UserConvermPassword.Text) Then
                        Return
                    End If
                    If txtUserPassword.Text <> txt_UserConvermPassword.Text Then
                        Return
                    End If
                    dataAccess.SaveUser(IntModel())
                    componentInit(False)
                    RefreshData()
                    MessageBox.Show("تم اضافة المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("لم يتم القيام بأي عملية", "إلغاء", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "حصل خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_UserData.AutoGenerateColumns = False
        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.DataPropertyName = "Id"
        idColumn.HeaderText = "Id"
        idColumn.Visible = False
        dgv_UserData.Columns.Add(idColumn)

        Dim userNameColumn As New DataGridViewTextBoxColumn()
        userNameColumn.DataPropertyName = "UserName"
        userNameColumn.HeaderText = "اسم المستخدم"
        dgv_UserData.Columns.Add(userNameColumn)

        Dim userFullNameColumn As New DataGridViewTextBoxColumn()
        userFullNameColumn.DataPropertyName = "UserFullName"
        userFullNameColumn.HeaderText = "الاسم الكامل"
        dgv_UserData.Columns.Add(userFullNameColumn)

        dgv_UserData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        RefreshData()

    End Sub

    Private Sub dgv_UserData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_UserData.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = dgv_UserData.Rows(e.RowIndex)
                If selectedRow IsNot Nothing Then
                    If selectedRow.Cells.Count >= 3 Then
                        Dim userIdCellValue As Object = selectedRow.Cells(0).Value
                        Dim userName As Object = selectedRow.Cells(1).Value
                        Dim userFullName As Object = selectedRow.Cells(2).Value
                        If userIdCellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(userIdCellValue.ToString()) AndAlso
                           userName IsNot Nothing AndAlso Not String.IsNullOrEmpty(userName.ToString()) AndAlso
                           userFullName IsNot Nothing AndAlso Not String.IsNullOrEmpty(userFullName.ToString()) Then

                            Dim userId As Integer
                            If Integer.TryParse(userIdCellValue.ToString(), userId) Then
                                txtUserName.Text = userName.ToString()
                                txt_UserFullName.Text = userFullName.ToString()
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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btn_Delete.Enabled = False
        componentInit(True)
    End Sub

    Private Sub btn_Init_Click(sender As Object, e As EventArgs) Handles btn_Init.Click
        componentInit(False)
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If id > 0 Then
            Dim result As DialogResult = MessageBox.Show("هل انت متاكد من عملية الحذف", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                dataAccess.deleteUser(id)
                RefreshData()
                componentInit(False)
                MessageBox.Show("تم حذف المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
End Class