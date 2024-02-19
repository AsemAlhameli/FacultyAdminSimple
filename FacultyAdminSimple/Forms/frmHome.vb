Public Class frmHome
    Private Sub btn_UsersFrom_Click(sender As Object, e As EventArgs) Handles btn_UsersFrom.Click
        Dim userForm As frmUsers = New frmUsers()
        userForm.ShowDialog()
    End Sub

    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_JobForm_Click(sender As Object, e As EventArgs) Handles btn_JobForm.Click
        Dim jobForm As frmJobs = New frmJobs()
        jobForm.ShowDialog()
    End Sub

    Private Sub btn_SectionForm_Click(sender As Object, e As EventArgs) Handles btn_SectionForm.Click
        Dim sectionFrom = New frmSections
        sectionFrom.ShowDialog()
    End Sub

    Private Sub btn_StudentForm_Click(sender As Object, e As EventArgs) Handles btn_StudentForm.Click
        Dim studentFrom As frmStudents = New frmStudents()
        studentFrom.ShowDialog()
    End Sub

    Private Sub btn_Attendance_Click(sender As Object, e As EventArgs) Handles btn_Attendance.Click
        Dim studentFrom As frmAttendance = New frmAttendance()
        studentFrom.ShowDialog()
    End Sub

    Private Sub btn_CourseForms_Click(sender As Object, e As EventArgs) Handles btn_CourseForms.Click
        Dim studentFrom As frmCourse = New frmCourse()
        studentFrom.ShowDialog()
    End Sub

    Private Sub btn_TeachersForm_Click(sender As Object, e As EventArgs) Handles btn_TeachersForm.Click
        Dim studentFrom As frmTeachers = New frmTeachers()
        studentFrom.ShowDialog()
    End Sub
End Class