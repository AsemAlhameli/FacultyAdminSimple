<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label2 = New Label()
        lbl_Close = New Label()
        Panel2 = New Panel()
        btn_Attendance = New Button()
        btn_JobForm = New Button()
        btn_SectionForm = New Button()
        btn_TeachersForm = New Button()
        btn_StudentForm = New Button()
        btn_UsersFrom = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel10 = New Panel()
        Panel9 = New Panel()
        GroupBox2 = New GroupBox()
        Panel8 = New Panel()
        GroupBox3 = New GroupBox()
        Panel7 = New Panel()
        Panel6 = New Panel()
        GroupBox1 = New GroupBox()
        btn_CourseForms = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lbl_Close)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 45)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(498, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(283, 25)
        Label2.TabIndex = 0
        Label2.Text = "نظام الموارد البشرية لهيئة التدريس"
        ' 
        ' lbl_Close
        ' 
        lbl_Close.AutoSize = True
        lbl_Close.ForeColor = Color.White
        lbl_Close.Location = New Point(12, 9)
        lbl_Close.Name = "lbl_Close"
        lbl_Close.Size = New Size(24, 25)
        lbl_Close.TabIndex = 0
        lbl_Close.Text = "X"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btn_CourseForms)
        Panel2.Controls.Add(btn_Attendance)
        Panel2.Controls.Add(btn_JobForm)
        Panel2.Controls.Add(btn_SectionForm)
        Panel2.Controls.Add(btn_TeachersForm)
        Panel2.Controls.Add(btn_StudentForm)
        Panel2.Controls.Add(btn_UsersFrom)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 45)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1281, 82)
        Panel2.TabIndex = 1
        ' 
        ' btn_Attendance
        ' 
        btn_Attendance.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_Attendance.FlatAppearance.BorderSize = 0
        btn_Attendance.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_Attendance.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_Attendance.FlatStyle = FlatStyle.Flat
        btn_Attendance.ForeColor = Color.SeaGreen
        btn_Attendance.Location = New Point(35, 0)
        btn_Attendance.Name = "btn_Attendance"
        btn_Attendance.Size = New Size(163, 45)
        btn_Attendance.TabIndex = 0
        btn_Attendance.Text = "الحضور والانصراف"
        btn_Attendance.UseVisualStyleBackColor = True
        ' 
        ' btn_JobForm
        ' 
        btn_JobForm.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_JobForm.FlatAppearance.BorderSize = 0
        btn_JobForm.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_JobForm.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_JobForm.FlatStyle = FlatStyle.Flat
        btn_JobForm.ForeColor = Color.SeaGreen
        btn_JobForm.Location = New Point(199, 0)
        btn_JobForm.Name = "btn_JobForm"
        btn_JobForm.Size = New Size(163, 45)
        btn_JobForm.TabIndex = 0
        btn_JobForm.Text = "الوظائف"
        btn_JobForm.UseVisualStyleBackColor = True
        ' 
        ' btn_SectionForm
        ' 
        btn_SectionForm.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_SectionForm.FlatAppearance.BorderSize = 0
        btn_SectionForm.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_SectionForm.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_SectionForm.FlatStyle = FlatStyle.Flat
        btn_SectionForm.ForeColor = Color.SeaGreen
        btn_SectionForm.Location = New Point(527, 3)
        btn_SectionForm.Name = "btn_SectionForm"
        btn_SectionForm.Size = New Size(163, 45)
        btn_SectionForm.TabIndex = 0
        btn_SectionForm.Text = "الاقسام"
        btn_SectionForm.UseVisualStyleBackColor = True
        ' 
        ' btn_TeachersForm
        ' 
        btn_TeachersForm.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_TeachersForm.FlatAppearance.BorderSize = 0
        btn_TeachersForm.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_TeachersForm.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_TeachersForm.FlatStyle = FlatStyle.Flat
        btn_TeachersForm.ForeColor = Color.SeaGreen
        btn_TeachersForm.Location = New Point(691, 3)
        btn_TeachersForm.Name = "btn_TeachersForm"
        btn_TeachersForm.Size = New Size(215, 45)
        btn_TeachersForm.TabIndex = 0
        btn_TeachersForm.Text = "اعضاء هيئة التدريس"
        btn_TeachersForm.UseVisualStyleBackColor = True
        ' 
        ' btn_StudentForm
        ' 
        btn_StudentForm.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_StudentForm.FlatAppearance.BorderSize = 0
        btn_StudentForm.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_StudentForm.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_StudentForm.FlatStyle = FlatStyle.Flat
        btn_StudentForm.ForeColor = Color.SeaGreen
        btn_StudentForm.Location = New Point(907, 3)
        btn_StudentForm.Name = "btn_StudentForm"
        btn_StudentForm.Size = New Size(163, 45)
        btn_StudentForm.TabIndex = 0
        btn_StudentForm.Text = "الطلاب"
        btn_StudentForm.UseVisualStyleBackColor = True
        ' 
        ' btn_UsersFrom
        ' 
        btn_UsersFrom.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_UsersFrom.FlatAppearance.BorderSize = 0
        btn_UsersFrom.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_UsersFrom.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_UsersFrom.FlatStyle = FlatStyle.Flat
        btn_UsersFrom.ForeColor = Color.SeaGreen
        btn_UsersFrom.Location = New Point(1071, 0)
        btn_UsersFrom.Name = "btn_UsersFrom"
        btn_UsersFrom.Size = New Size(163, 45)
        btn_UsersFrom.TabIndex = 0
        btn_UsersFrom.Text = "المستخدمين"
        btn_UsersFrom.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SeaGreen
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 757)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1281, 10)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SeaGreen
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 127)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1281, 10)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel10)
        Panel5.Controls.Add(Panel9)
        Panel5.Controls.Add(Panel8)
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(Panel6)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(0, 137)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1281, 620)
        Panel5.TabIndex = 4
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.SeaGreen
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(306, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(10, 620)
        Panel10.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(GroupBox2)
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(306, 620)
        Panel9.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.SeaGreen
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(306, 620)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "تقرير بغياب الاساتذة بحسب الفصل الدراسي"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(GroupBox3)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(870, 620)
        Panel8.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.SeaGreen
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(870, 620)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "الاساتذة المكلفين على مشاريع التخرج"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.SeaGreen
        Panel7.Dock = DockStyle.Right
        Panel7.Location = New Point(870, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 620)
        Panel7.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(GroupBox1)
        Panel6.Dock = DockStyle.Right
        Panel6.Location = New Point(880, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(401, 620)
        Panel6.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.SeaGreen
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(401, 620)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "الأساتذة المكلفين برئاسة الاقسام"
        ' 
        ' btn_CourseForms
        ' 
        btn_CourseForms.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_CourseForms.FlatAppearance.BorderSize = 0
        btn_CourseForms.FlatAppearance.MouseDownBackColor = Color.IndianRed
        btn_CourseForms.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btn_CourseForms.FlatStyle = FlatStyle.Flat
        btn_CourseForms.ForeColor = Color.SeaGreen
        btn_CourseForms.Location = New Point(363, 3)
        btn_CourseForms.Name = "btn_CourseForms"
        btn_CourseForms.Size = New Size(163, 45)
        btn_CourseForms.TabIndex = 0
        btn_CourseForms.Text = "البرامج"
        btn_CourseForms.UseVisualStyleBackColor = True
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1281, 767)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmHome"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        Text = "frmHome"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_JobForm As Button
    Friend WithEvents btn_SectionForm As Button
    Friend WithEvents btn_TeachersForm As Button
    Friend WithEvents btn_UsersFrom As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_Attendance As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_StudentForm As Button
    Friend WithEvents btn_CourseForms As Button
End Class
