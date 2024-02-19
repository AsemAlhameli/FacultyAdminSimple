Public Class frmLogin
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Close()
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If String.IsNullOrEmpty(txt_UserName.Text) OrElse String.IsNullOrEmpty(txt_Password.Text) Then
            Return
        End If

        If ValidateLogin(txt_UserName.Text, txt_Password.Text) Then
            Dim homeForm As frmHome = New frmHome()
            homeForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("كلمة السر او اسم المستخدم غير صحيح!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
    Public Function ValidateLogin(username As String, password As String) As Boolean
        Try
            Dim user As UserModel = New UserData().GetUser(username)
            Dim storedPassword As String
            If user IsNot Nothing Then
                storedPassword = user.UserPassword
                If String.IsNullOrEmpty(storedPassword) OrElse String.IsNullOrEmpty(password) Then
                    Return False
                End If
                Return password = storedPassword
            Else
                Return False
            End If
            Return False
        Catch ex As Exception

        End Try
    End Function
End Class