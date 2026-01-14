<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        GroupBox1 = New GroupBox()
        rbtnJuniorCashier = New RadioButton()
        rbtnSeniorCashier = New RadioButton()
        GroupBox2 = New GroupBox()
        rbtnGroupStage = New RadioButton()
        rbtnQuarterFinals = New RadioButton()
        rbtnSemiFinals = New RadioButton()
        rbtnFinals = New RadioButton()
        btnClear = New Button()
        btnCalculate = New Button()
        btnPrintTicket = New Button()
        txtAdults = New TextBox()
        txtChildren = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblTotal = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnJuniorCashier)
        GroupBox1.Controls.Add(rbtnSeniorCashier)
        GroupBox1.Location = New Point(319, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(166, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cashier Type"
        ' 
        ' rbtnJuniorCashier
        ' 
        rbtnJuniorCashier.AutoSize = True
        rbtnJuniorCashier.Location = New Point(33, 60)
        rbtnJuniorCashier.Name = "rbtnJuniorCashier"
        rbtnJuniorCashier.Size = New Size(99, 19)
        rbtnJuniorCashier.TabIndex = 3
        rbtnJuniorCashier.TabStop = True
        rbtnJuniorCashier.Text = "Junior Cashier"
        rbtnJuniorCashier.UseVisualStyleBackColor = True
        ' 
        ' rbtnSeniorCashier
        ' 
        rbtnSeniorCashier.AutoSize = True
        rbtnSeniorCashier.Location = New Point(33, 22)
        rbtnSeniorCashier.Name = "rbtnSeniorCashier"
        rbtnSeniorCashier.Size = New Size(100, 19)
        rbtnSeniorCashier.TabIndex = 2
        rbtnSeniorCashier.TabStop = True
        rbtnSeniorCashier.Text = "Senior Cashier"
        rbtnSeniorCashier.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbtnGroupStage)
        GroupBox2.Controls.Add(rbtnQuarterFinals)
        GroupBox2.Controls.Add(rbtnSemiFinals)
        GroupBox2.Controls.Add(rbtnFinals)
        GroupBox2.Location = New Point(530, 58)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(183, 180)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Stages"
        ' 
        ' rbtnGroupStage
        ' 
        rbtnGroupStage.AutoSize = True
        rbtnGroupStage.Location = New Point(36, 32)
        rbtnGroupStage.Name = "rbtnGroupStage"
        rbtnGroupStage.Size = New Size(95, 19)
        rbtnGroupStage.TabIndex = 4
        rbtnGroupStage.TabStop = True
        rbtnGroupStage.Text = "Group Stages"
        rbtnGroupStage.UseVisualStyleBackColor = True
        ' 
        ' rbtnQuarterFinals
        ' 
        rbtnQuarterFinals.AutoSize = True
        rbtnQuarterFinals.Location = New Point(36, 69)
        rbtnQuarterFinals.Name = "rbtnQuarterFinals"
        rbtnQuarterFinals.Size = New Size(98, 19)
        rbtnQuarterFinals.TabIndex = 5
        rbtnQuarterFinals.TabStop = True
        rbtnQuarterFinals.Text = "Quarter Finals"
        rbtnQuarterFinals.UseVisualStyleBackColor = True
        ' 
        ' rbtnSemiFinals
        ' 
        rbtnSemiFinals.AutoSize = True
        rbtnSemiFinals.Location = New Point(36, 107)
        rbtnSemiFinals.Name = "rbtnSemiFinals"
        rbtnSemiFinals.Size = New Size(84, 19)
        rbtnSemiFinals.TabIndex = 6
        rbtnSemiFinals.TabStop = True
        rbtnSemiFinals.Text = "Semi Finals"
        rbtnSemiFinals.UseVisualStyleBackColor = True
        ' 
        ' rbtnFinals
        ' 
        rbtnFinals.AutoSize = True
        rbtnFinals.Location = New Point(36, 143)
        rbtnFinals.Name = "rbtnFinals"
        rbtnFinals.Size = New Size(55, 19)
        rbtnFinals.TabIndex = 7
        rbtnFinals.TabStop = True
        rbtnFinals.Text = "Finals"
        rbtnFinals.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(62, 201)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(161, 201)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnPrintTicket
        ' 
        btnPrintTicket.Location = New Point(255, 201)
        btnPrintTicket.Name = "btnPrintTicket"
        btnPrintTicket.Size = New Size(75, 23)
        btnPrintTicket.TabIndex = 4
        btnPrintTicket.Text = "Print Ticket"
        btnPrintTicket.UseVisualStyleBackColor = True
        ' 
        ' txtAdults
        ' 
        txtAdults.Location = New Point(62, 64)
        txtAdults.Name = "txtAdults"
        txtAdults.Size = New Size(100, 23)
        txtAdults.TabIndex = 5
        ' 
        ' txtChildren
        ' 
        txtChildren.Location = New Point(62, 114)
        txtChildren.Name = "txtChildren"
        txtChildren.Size = New Size(100, 23)
        txtChildren.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(195, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 7
        Label1.Text = "Adults"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(195, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 8
        Label2.Text = "Children"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(62, 154)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(32, 15)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtChildren)
        Controls.Add(txtAdults)
        Controls.Add(btnPrintTicket)
        Controls.Add(btnCalculate)
        Controls.Add(btnClear)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnSeniorCashier As RadioButton
    Friend WithEvents rbtnGroupStage As RadioButton
    Friend WithEvents rbtnQuarterFinals As RadioButton
    Friend WithEvents rbtnSemiFinals As RadioButton
    Friend WithEvents rbtnFinals As RadioButton
    Friend WithEvents rbtnJuniorCashier As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPrintTicket As Button
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents txtChildren As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
End Class
