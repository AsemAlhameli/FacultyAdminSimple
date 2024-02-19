<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        lbl_close = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        btn_Login = New Button()
        txt_Password = New TextBox()
        txt_UserName = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lbl_close)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(745, 41)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(322, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 30)
        Label2.TabIndex = 1
        Label2.Text = "تسجيل الدخول"
        ' 
        ' lbl_close
        ' 
        lbl_close.AutoSize = True
        lbl_close.ForeColor = Color.White
        lbl_close.Location = New Point(12, 5)
        lbl_close.Name = "lbl_close"
        lbl_close.Size = New Size(27, 30)
        lbl_close.TabIndex = 0
        lbl_close.Text = "X"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btn_Login)
        Panel2.Controls.Add(txt_Password)
        Panel2.Controls.Add(txt_UserName)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 41)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(745, 203)
        Panel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.ForestGreen
        Label4.Location = New Point(629, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 30)
        Label4.TabIndex = 2
        Label4.Text = "كلمة السر :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(588, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 30)
        Label3.TabIndex = 2
        Label3.Text = "اسم المستخدم: "
        ' 
        ' btn_Login
        ' 
        btn_Login.ForeColor = Color.ForestGreen
        btn_Login.Location = New Point(45, 149)
        btn_Login.Name = "btn_Login"
        btn_Login.Size = New Size(528, 45)
        btn_Login.TabIndex = 2
        btn_Login.Text = "دخول"
        btn_Login.UseVisualStyleBackColor = True
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(45, 99)
        txt_Password.Name = "txt_Password"
        txt_Password.PasswordChar = "*"c
        txt_Password.Size = New Size(528, 35)
        txt_Password.TabIndex = 1
        ' 
        ' txt_UserName
        ' 
        txt_UserName.Location = New Point(45, 45)
        txt_UserName.Name = "txt_UserName"
        txt_UserName.Size = New Size(528, 35)
        txt_UserName.TabIndex = 0
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(745, 244)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6)
        Name = "frmLogin"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterParent
        Text = "frmLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_close As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_UserName As TextBox
End Class
