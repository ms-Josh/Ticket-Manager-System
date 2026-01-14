<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Username_entry = New TextBox()
        Password_entry = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Username_entry
        ' 
        Username_entry.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Username_entry.ForeColor = SystemColors.ActiveBorder
        Username_entry.Location = New Point(350, 73)
        Username_entry.Name = "Username_entry"
        Username_entry.Size = New Size(100, 23)
        Username_entry.TabIndex = 0
        Username_entry.Text = "Username"
        ' 
        ' Password_entry
        ' 
        Password_entry.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Password_entry.ForeColor = SystemColors.ActiveBorder
        Password_entry.Location = New Point(350, 133)
        Password_entry.Name = "Password_entry"
        Password_entry.Size = New Size(100, 23)
        Password_entry.TabIndex = 1
        Password_entry.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(350, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(460, 198)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(576, 198)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 4
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Password_entry)
        Controls.Add(Username_entry)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Username_entry As TextBox
    Friend WithEvents Password_entry As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
