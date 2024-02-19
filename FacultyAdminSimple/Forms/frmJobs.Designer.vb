<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobs
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
        btn_Init = New Button()
        btnEdit = New Button()
        btn_Delete = New Button()
        btn_New = New Button()
        btn_Save = New Button()
        txt_jobName = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dgv_jobData = New DataGridView()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgv_jobData, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(380, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_tatile
        ' 
        lbl_tatile.AutoSize = True
        lbl_tatile.ForeColor = Color.White
        lbl_tatile.Location = New Point(157, 9)
        lbl_tatile.Name = "lbl_tatile"
        lbl_tatile.Size = New Size(65, 25)
        lbl_tatile.TabIndex = 1
        lbl_tatile.Text = "المهام "
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
        GroupBox1.Controls.Add(btn_Init)
        GroupBox1.Controls.Add(btnEdit)
        GroupBox1.Controls.Add(btn_Delete)
        GroupBox1.Controls.Add(btn_New)
        GroupBox1.Controls.Add(btn_Save)
        GroupBox1.Controls.Add(txt_jobName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.ForeColor = Color.SeaGreen
        GroupBox1.Location = New Point(0, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(380, 161)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات"
        ' 
        ' btn_Init
        ' 
        btn_Init.Enabled = False
        btn_Init.Location = New Point(3, 79)
        btn_Init.Name = "btn_Init"
        btn_Init.Size = New Size(76, 34)
        btn_Init.TabIndex = 3
        btn_Init.Text = "تهيئة"
        btn_Init.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(149, 79)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(76, 34)
        btnEdit.TabIndex = 4
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Enabled = False
        btn_Delete.Location = New Point(30, 119)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(145, 34)
        btn_Delete.TabIndex = 5
        btn_Delete.Text = "حذف"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_New
        ' 
        btn_New.Location = New Point(302, 79)
        btn_New.Name = "btn_New"
        btn_New.Size = New Size(75, 34)
        btn_New.TabIndex = 6
        btn_New.Text = "جديد"
        btn_New.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.Enabled = False
        btn_Save.Location = New Point(181, 119)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(159, 34)
        btn_Save.TabIndex = 7
        btn_Save.Text = "حفظ"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' txt_jobName
        ' 
        txt_jobName.Enabled = False
        txt_jobName.Location = New Point(6, 30)
        txt_jobName.Name = "txt_jobName"
        txt_jobName.Size = New Size(230, 33)
        txt_jobName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(242, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 0
        Label1.Text = "اسم الوظيفة : "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgv_jobData)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.ForeColor = Color.SeaGreen
        GroupBox2.Location = New Point(0, 206)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(380, 192)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' dgv_jobData
        ' 
        dgv_jobData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_jobData.Dock = DockStyle.Fill
        dgv_jobData.Location = New Point(3, 29)
        dgv_jobData.Name = "dgv_jobData"
        dgv_jobData.Size = New Size(374, 160)
        dgv_jobData.TabIndex = 0
        ' 
        ' frmJobs
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(380, 398)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmJobs"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterParent
        Text = "frmJobs"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgv_jobData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tatile As Label
    Friend WithEvents lbl_Close As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_jobName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_jobData As DataGridView
    Friend WithEvents btn_Init As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Save As Button
End Class
