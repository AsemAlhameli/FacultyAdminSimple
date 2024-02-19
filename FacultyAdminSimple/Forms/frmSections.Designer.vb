<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSections
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
        cb_Section = New CheckBox()
        txt_SectionName = New TextBox()
        btn_Init = New Button()
        btnEdit = New Button()
        btn_Delete = New Button()
        btn_New = New Button()
        btn_Save = New Button()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dgv_SectionData = New DataGridView()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgv_SectionData, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(688, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_tatile
        ' 
        lbl_tatile.AutoSize = True
        lbl_tatile.ForeColor = Color.White
        lbl_tatile.Location = New Point(319, 9)
        lbl_tatile.Name = "lbl_tatile"
        lbl_tatile.Size = New Size(70, 25)
        lbl_tatile.TabIndex = 1
        lbl_tatile.Text = "الاقسام"
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
        GroupBox1.Controls.Add(cb_Section)
        GroupBox1.Controls.Add(txt_SectionName)
        GroupBox1.Controls.Add(btn_Init)
        GroupBox1.Controls.Add(btnEdit)
        GroupBox1.Controls.Add(btn_Delete)
        GroupBox1.Controls.Add(btn_New)
        GroupBox1.Controls.Add(btn_Save)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(688, 125)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات"
        ' 
        ' cb_Section
        ' 
        cb_Section.AutoSize = True
        cb_Section.Checked = True
        cb_Section.CheckState = CheckState.Checked
        cb_Section.Enabled = False
        cb_Section.Location = New Point(31, 27)
        cb_Section.Name = "cb_Section"
        cb_Section.Size = New Size(128, 29)
        cb_Section.TabIndex = 16
        cb_Section.Text = "القسم علمي"
        cb_Section.UseVisualStyleBackColor = True
        ' 
        ' txt_SectionName
        ' 
        txt_SectionName.Enabled = False
        txt_SectionName.Location = New Point(185, 23)
        txt_SectionName.Name = "txt_SectionName"
        txt_SectionName.Size = New Size(370, 33)
        txt_SectionName.TabIndex = 15
        ' 
        ' btn_Init
        ' 
        btn_Init.Enabled = False
        btn_Init.Location = New Point(319, 73)
        btn_Init.Name = "btn_Init"
        btn_Init.Size = New Size(76, 34)
        btn_Init.TabIndex = 12
        btn_Init.Text = "تهيئة"
        btn_Init.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(399, 73)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(76, 34)
        btnEdit.TabIndex = 14
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Enabled = False
        btn_Delete.Location = New Point(117, 73)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(83, 34)
        btn_Delete.TabIndex = 11
        btn_Delete.Text = "حذف"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_New
        ' 
        btn_New.Location = New Point(480, 73)
        btn_New.Name = "btn_New"
        btn_New.Size = New Size(75, 34)
        btn_New.TabIndex = 13
        btn_New.Text = "جديد"
        btn_New.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.Enabled = False
        btn_Save.Location = New Point(206, 73)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(77, 34)
        btn_Save.TabIndex = 10
        btn_Save.Text = "حفظ"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(570, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 0
        Label1.Text = "اسم القسم: "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgv_SectionData)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 170)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(688, 460)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' dgv_SectionData
        ' 
        dgv_SectionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_SectionData.Dock = DockStyle.Fill
        dgv_SectionData.Location = New Point(3, 29)
        dgv_SectionData.Name = "dgv_SectionData"
        dgv_SectionData.Size = New Size(682, 428)
        dgv_SectionData.TabIndex = 0
        ' 
        ' frmSections
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(688, 630)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmSections"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterParent
        Text = "frmSections"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgv_SectionData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tatile As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_Section As CheckBox
    Friend WithEvents txt_SectionName As TextBox
    Friend WithEvents btn_Init As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents dgv_SectionData As DataGridView
End Class
