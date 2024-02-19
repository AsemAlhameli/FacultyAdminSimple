<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeachers
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
        btn_UplodePersonalPhoto = New Button()
        dtp_BirthDay = New DateTimePicker()
        pb_PersonalPhoto = New PictureBox()
        txt_BankAccountNumber = New TextBox()
        txt_capacity = New TextBox()
        txt_TeacherAddress = New TextBox()
        txt_EducationalLevel = New TextBox()
        txt_PhoneNumber = New TextBox()
        txt_NationalNumber = New TextBox()
        txt_FullName = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_Init = New Button()
        btnEdit = New Button()
        btn_Delete = New Button()
        btn_New = New Button()
        btn_Save = New Button()
        GroupBox2 = New GroupBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pb_PersonalPhoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(972, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_tatile
        ' 
        lbl_tatile.AutoSize = True
        lbl_tatile.ForeColor = Color.White
        lbl_tatile.Location = New Point(445, 9)
        lbl_tatile.Name = "lbl_tatile"
        lbl_tatile.Size = New Size(81, 25)
        lbl_tatile.TabIndex = 1
        lbl_tatile.Text = "المعلمين"
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
        GroupBox1.Controls.Add(btn_UplodePersonalPhoto)
        GroupBox1.Controls.Add(dtp_BirthDay)
        GroupBox1.Controls.Add(pb_PersonalPhoto)
        GroupBox1.Controls.Add(txt_BankAccountNumber)
        GroupBox1.Controls.Add(txt_capacity)
        GroupBox1.Controls.Add(txt_TeacherAddress)
        GroupBox1.Controls.Add(txt_EducationalLevel)
        GroupBox1.Controls.Add(txt_PhoneNumber)
        GroupBox1.Controls.Add(txt_NationalNumber)
        GroupBox1.Controls.Add(txt_FullName)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label3)
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
        GroupBox1.Size = New Size(972, 382)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات"
        ' 
        ' btn_UplodePersonalPhoto
        ' 
        btn_UplodePersonalPhoto.Enabled = False
        btn_UplodePersonalPhoto.Location = New Point(29, 241)
        btn_UplodePersonalPhoto.Name = "btn_UplodePersonalPhoto"
        btn_UplodePersonalPhoto.Size = New Size(248, 48)
        btn_UplodePersonalPhoto.TabIndex = 10
        btn_UplodePersonalPhoto.Text = "اضغط لرفع الصورة"
        btn_UplodePersonalPhoto.UseVisualStyleBackColor = True
        ' 
        ' dtp_BirthDay
        ' 
        dtp_BirthDay.Enabled = False
        dtp_BirthDay.Location = New Point(291, 141)
        dtp_BirthDay.Name = "dtp_BirthDay"
        dtp_BirthDay.Size = New Size(506, 33)
        dtp_BirthDay.TabIndex = 3
        ' 
        ' pb_PersonalPhoto
        ' 
        pb_PersonalPhoto.Enabled = False
        pb_PersonalPhoto.Location = New Point(29, 21)
        pb_PersonalPhoto.Name = "pb_PersonalPhoto"
        pb_PersonalPhoto.Size = New Size(248, 214)
        pb_PersonalPhoto.TabIndex = 17
        pb_PersonalPhoto.TabStop = False
        ' 
        ' txt_BankAccountNumber
        ' 
        txt_BankAccountNumber.Enabled = False
        txt_BankAccountNumber.Location = New Point(291, 182)
        txt_BankAccountNumber.Name = "txt_BankAccountNumber"
        txt_BankAccountNumber.Size = New Size(456, 33)
        txt_BankAccountNumber.TabIndex = 4
        ' 
        ' txt_capacity
        ' 
        txt_capacity.Enabled = False
        txt_capacity.Location = New Point(283, 299)
        txt_capacity.Name = "txt_capacity"
        txt_capacity.Size = New Size(505, 33)
        txt_capacity.TabIndex = 7
        ' 
        ' txt_TeacherAddress
        ' 
        txt_TeacherAddress.Enabled = False
        txt_TeacherAddress.Location = New Point(283, 261)
        txt_TeacherAddress.Name = "txt_TeacherAddress"
        txt_TeacherAddress.Size = New Size(505, 33)
        txt_TeacherAddress.TabIndex = 6
        ' 
        ' txt_EducationalLevel
        ' 
        txt_EducationalLevel.Enabled = False
        txt_EducationalLevel.Location = New Point(292, 99)
        txt_EducationalLevel.Name = "txt_EducationalLevel"
        txt_EducationalLevel.Size = New Size(505, 33)
        txt_EducationalLevel.TabIndex = 2
        ' 
        ' txt_PhoneNumber
        ' 
        txt_PhoneNumber.Enabled = False
        txt_PhoneNumber.Location = New Point(283, 221)
        txt_PhoneNumber.Name = "txt_PhoneNumber"
        txt_PhoneNumber.Size = New Size(505, 33)
        txt_PhoneNumber.TabIndex = 5
        ' 
        ' txt_NationalNumber
        ' 
        txt_NationalNumber.Enabled = False
        txt_NationalNumber.Location = New Point(291, 59)
        txt_NationalNumber.Name = "txt_NationalNumber"
        txt_NationalNumber.Size = New Size(506, 33)
        txt_NationalNumber.TabIndex = 1
        ' 
        ' txt_FullName
        ' 
        txt_FullName.Enabled = False
        txt_FullName.Location = New Point(291, 21)
        txt_FullName.Name = "txt_FullName"
        txt_FullName.Size = New Size(506, 33)
        txt_FullName.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(802, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 15
        Label4.Text = "تاريخ الميلاد :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(766, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(189, 25)
        Label5.TabIndex = 15
        Label5.Text = "رقم الحساب المصرفي: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(794, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 25)
        Label7.TabIndex = 15
        Label7.Text = "الكفائة :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(794, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 25)
        Label6.TabIndex = 15
        Label6.Text = "العنوان :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(803, 102)
        Label8.Name = "Label8"
        Label8.Size = New Size(161, 25)
        Label8.TabIndex = 15
        Label8.Text = "المستوى التعليمي :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(794, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 25)
        Label3.TabIndex = 15
        Label3.Text = "رقم الهاتف :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(803, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 25)
        Label2.TabIndex = 15
        Label2.Text = "الرقم الوطني :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(803, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 25)
        Label1.TabIndex = 15
        Label1.Text = "الاسم الكامل :"
        ' 
        ' btn_Init
        ' 
        btn_Init.Enabled = False
        btn_Init.Location = New Point(552, 338)
        btn_Init.Name = "btn_Init"
        btn_Init.Size = New Size(76, 34)
        btn_Init.TabIndex = 12
        btn_Init.Text = "تهيئة"
        btn_Init.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(632, 338)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(76, 34)
        btnEdit.TabIndex = 14
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Enabled = False
        btn_Delete.Location = New Point(280, 338)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(83, 34)
        btn_Delete.TabIndex = 11
        btn_Delete.Text = "حذف"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_New
        ' 
        btn_New.Location = New Point(713, 338)
        btn_New.Name = "btn_New"
        btn_New.Size = New Size(75, 34)
        btn_New.TabIndex = 13
        btn_New.Text = "جديد"
        btn_New.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.Enabled = False
        btn_Save.Location = New Point(369, 338)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(77, 34)
        btn_Save.TabIndex = 9
        btn_Save.Text = "حفظ"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 427)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(972, 341)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 29)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(966, 309)
        DataGridView1.TabIndex = 0
        ' 
        ' frmTeachers
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(972, 768)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmTeachers"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        Text = "frmTeachers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pb_PersonalPhoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tatile As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp_BirthDay As DateTimePicker
    Friend WithEvents pb_PersonalPhoto As PictureBox
    Friend WithEvents txt_NationalNumber As TextBox
    Friend WithEvents txt_FullName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Init As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents txt_PhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_UplodePersonalPhoto As Button
    Friend WithEvents txt_BankAccountNumber As TextBox
    Friend WithEvents txt_capacity As TextBox
    Friend WithEvents txt_TeacherAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_EducationalLevel As TextBox
    Friend WithEvents Label8 As Label
End Class
