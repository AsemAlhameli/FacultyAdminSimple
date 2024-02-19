<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        lbl_tatile = New Label()
        lbl_Close = New Label()
        Panel1.SuspendLayout()
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
        Panel1.Size = New Size(648, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_tatile
        ' 
        lbl_tatile.AutoSize = True
        lbl_tatile.ForeColor = Color.White
        lbl_tatile.Location = New Point(297, 9)
        lbl_tatile.Name = "lbl_tatile"
        lbl_tatile.Size = New Size(56, 25)
        lbl_tatile.TabIndex = 1
        lbl_tatile.Text = "Tatile"
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
        ' frmBase
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(648, 550)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmBase"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        Text = "frmBase"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tatile As Label
    Friend WithEvents lbl_Close As Label
End Class
