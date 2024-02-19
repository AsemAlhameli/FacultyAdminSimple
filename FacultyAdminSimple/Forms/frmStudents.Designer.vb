<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
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
        com_SectionsId = New ComboBox()
        txt_AcademicNumber = New TextBox()
        txt_StudentName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        btn_Init = New Button()
        btnEdit = New Button()
        btn_Delete = New Button()
        btn_New = New Button()
        btn_Save = New Button()
        GroupBox2 = New GroupBox()
        dgv_StudentsData = New DataGridView()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgv_StudentsData, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(738, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_tatile
        ' 
        lbl_tatile.AutoSize = True
        lbl_tatile.ForeColor = Color.White
        lbl_tatile.Location = New Point(336, 11)
        lbl_tatile.Name = "lbl_tatile"
        lbl_tatile.Size = New Size(67, 25)
        lbl_tatile.TabIndex = 1
        lbl_tatile.Text = "الطلاب"
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
        GroupBox1.Controls.Add(com_SectionsId)
        GroupBox1.Controls.Add(txt_AcademicNumber)
        GroupBox1.Controls.Add(txt_StudentName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btn_Init)
        GroupBox1.Controls.Add(btnEdit)
        GroupBox1.Controls.Add(btn_Delete)
        GroupBox1.Controls.Add(btn_New)
        GroupBox1.Controls.Add(btn_Save)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(738, 202)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات"
        ' 
        ' com_SectionsId
        ' 
        com_SectionsId.AllowDrop = True
        com_SectionsId.Enabled = False
        com_SectionsId.FormattingEnabled = True
        com_SectionsId.Location = New Point(12, 112)
        com_SectionsId.Name = "com_SectionsId"
        com_SectionsId.Size = New Size(547, 33)
        com_SectionsId.TabIndex = 17
        ' 
        ' txt_AcademicNumber
        ' 
        txt_AcademicNumber.Enabled = False
        txt_AcademicNumber.Location = New Point(13, 73)
        txt_AcademicNumber.Name = "txt_AcademicNumber"
        txt_AcademicNumber.Size = New Size(547, 33)
        txt_AcademicNumber.TabIndex = 16
        ' 
        ' txt_StudentName
        ' 
        txt_StudentName.Enabled = False
        txt_StudentName.Location = New Point(12, 29)
        txt_StudentName.Name = "txt_StudentName"
        txt_StudentName.Size = New Size(547, 33)
        txt_StudentName.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(566, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 25)
        Label2.TabIndex = 15
        Label2.Text = "الرقم الجامعي:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(566, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 25)
        Label3.TabIndex = 15
        Label3.Text = "القسم:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(565, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 15
        Label1.Text = "اسم الطالب/ ــة:"
        ' 
        ' btn_Init
        ' 
        btn_Init.Enabled = False
        btn_Init.Location = New Point(340, 156)
        btn_Init.Name = "btn_Init"
        btn_Init.Size = New Size(76, 34)
        btn_Init.TabIndex = 12
        btn_Init.Text = "تهيئة"
        btn_Init.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(420, 156)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(76, 34)
        btnEdit.TabIndex = 14
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Enabled = False
        btn_Delete.Location = New Point(9, 156)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(83, 34)
        btn_Delete.TabIndex = 11
        btn_Delete.Text = "حذف"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_New
        ' 
        btn_New.Location = New Point(501, 156)
        btn_New.Name = "btn_New"
        btn_New.Size = New Size(75, 34)
        btn_New.TabIndex = 13
        btn_New.Text = "جديد"
        btn_New.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.Enabled = False
        btn_Save.Location = New Point(98, 156)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(77, 34)
        btn_Save.TabIndex = 10
        btn_Save.Text = "حفظ"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgv_StudentsData)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 247)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(738, 411)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' dgv_StudentsData
        ' 
        dgv_StudentsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_StudentsData.Dock = DockStyle.Fill
        dgv_StudentsData.Location = New Point(3, 29)
        dgv_StudentsData.Name = "dgv_StudentsData"
        dgv_StudentsData.Size = New Size(732, 379)
        dgv_StudentsData.TabIndex = 0
        ' 
        ' frmStudents
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(738, 658)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmStudents"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterParent
        Text = "frmStudents"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgv_StudentsData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tatile As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Init As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents com_SectionsId As ComboBox
    Friend WithEvents txt_AcademicNumber As TextBox
    Friend WithEvents txt_StudentName As TextBox
    Friend WithEvents dgv_StudentsData As DataGridView
End Class
