<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lbl_tatile = New Label()
        lbl_Close = New Label()
        GroupBox1 = New GroupBox()
        cb_IsTheoretical = New CheckBox()
        cb_IsProject = New CheckBox()
        txt_NumberOfHours = New TextBox()
        txt_CourseName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btn_Init = New Button()
        btnEdit = New Button()
        btn_Delete = New Button()
        btn_New = New Button()
        btn_Save = New Button()
        GroupBox2 = New GroupBox()
        dgv_ProjectData = New DataGridView()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgv_ProjectData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(lbl_tatile)
        Panel1.Controls.Add(lbl_Close)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(715, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_tatile
        ' 
        lbl_tatile.AutoSize = True
        lbl_tatile.ForeColor = Color.White
        lbl_tatile.Location = New Point(260, 9)
        lbl_tatile.Name = "lbl_tatile"
        lbl_tatile.Size = New Size(147, 25)
        lbl_tatile.TabIndex = 1
        lbl_tatile.Text = "البرامج والمشاريع"
        ' 
        ' lbl_Close
        ' 
        lbl_Close.AutoSize = True
        lbl_Close.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Close.ForeColor = Color.White
        lbl_Close.Location = New Point(12, 9)
        lbl_Close.Name = "lbl_Close"
        lbl_Close.Size = New Size(24, 25)
        lbl_Close.TabIndex = 0
        lbl_Close.Text = "X"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cb_IsTheoretical)
        GroupBox1.Controls.Add(cb_IsProject)
        GroupBox1.Controls.Add(txt_NumberOfHours)
        GroupBox1.Controls.Add(txt_CourseName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btn_Init)
        GroupBox1.Controls.Add(btnEdit)
        GroupBox1.Controls.Add(btn_Delete)
        GroupBox1.Controls.Add(btn_New)
        GroupBox1.Controls.Add(btn_Save)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(715, 172)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات"
        ' 
        ' cb_IsTheoretical
        ' 
        cb_IsTheoretical.AutoSize = True
        cb_IsTheoretical.Enabled = False
        cb_IsTheoretical.Location = New Point(89, 80)
        cb_IsTheoretical.Name = "cb_IsTheoretical"
        cb_IsTheoretical.Size = New Size(73, 29)
        cb_IsTheoretical.TabIndex = 17
        cb_IsTheoretical.Text = "نظري"
        cb_IsTheoretical.UseVisualStyleBackColor = True
        ' 
        ' cb_IsProject
        ' 
        cb_IsProject.AutoSize = True
        cb_IsProject.Checked = True
        cb_IsProject.CheckState = CheckState.Checked
        cb_IsProject.Enabled = False
        cb_IsProject.Location = New Point(78, 33)
        cb_IsProject.Name = "cb_IsProject"
        cb_IsProject.Size = New Size(84, 29)
        cb_IsProject.TabIndex = 17
        cb_IsProject.Text = "مشروع"
        cb_IsProject.UseVisualStyleBackColor = True
        ' 
        ' txt_NumberOfHours
        ' 
        txt_NumberOfHours.Enabled = False
        txt_NumberOfHours.Location = New Point(168, 76)
        txt_NumberOfHours.Name = "txt_NumberOfHours"
        txt_NumberOfHours.Size = New Size(349, 33)
        txt_NumberOfHours.TabIndex = 16
        ' 
        ' txt_CourseName
        ' 
        txt_CourseName.Enabled = False
        txt_CourseName.Location = New Point(168, 29)
        txt_CourseName.Name = "txt_CourseName"
        txt_CourseName.Size = New Size(349, 33)
        txt_CourseName.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(522, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 25)
        Label2.TabIndex = 15
        Label2.Text = "عدد الساعات: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(522, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 25)
        Label1.TabIndex = 15
        Label1.Text = "اسم المسار التعليمي :"
        ' 
        ' btn_Init
        ' 
        btn_Init.Enabled = False
        btn_Init.Location = New Point(331, 127)
        btn_Init.Name = "btn_Init"
        btn_Init.Size = New Size(76, 34)
        btn_Init.TabIndex = 12
        btn_Init.Text = "تهيئة"
        btn_Init.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(411, 127)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(76, 34)
        btnEdit.TabIndex = 14
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Enabled = False
        btn_Delete.Location = New Point(129, 127)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(83, 34)
        btn_Delete.TabIndex = 11
        btn_Delete.Text = "حذف"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_New
        ' 
        btn_New.Location = New Point(492, 127)
        btn_New.Name = "btn_New"
        btn_New.Size = New Size(75, 34)
        btn_New.TabIndex = 13
        btn_New.Text = "جديد"
        btn_New.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.Enabled = False
        btn_Save.Location = New Point(218, 127)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(77, 34)
        btn_Save.TabIndex = 10
        btn_Save.Text = "حفظ"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgv_ProjectData)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 217)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(715, 423)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' dgv_ProjectData
        ' 
        dgv_ProjectData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_ProjectData.Dock = DockStyle.Fill
        dgv_ProjectData.Location = New Point(3, 29)
        dgv_ProjectData.Name = "dgv_ProjectData"
        dgv_ProjectData.Size = New Size(709, 391)
        dgv_ProjectData.TabIndex = 0
        ' 
        ' frmCourse
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(715, 640)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmCourse"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        Text = "frmCourse"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgv_ProjectData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tatile As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Init As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents cb_IsTheoretical As CheckBox
    Friend WithEvents cb_IsProject As CheckBox
    Friend WithEvents txt_NumberOfHours As TextBox
    Friend WithEvents txt_CourseName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_ProjectData As DataGridView
End Class
