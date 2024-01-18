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
        lblNum1 = New Label()
        lblNum2 = New Label()
        btnMaximum = New Button()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        txtMaximum = New TextBox()
        SuspendLayout()
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.Location = New Point(260, 40)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(94, 20)
        lblNum1.TabIndex = 0
        lblNum1.Text = "First Number"
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.Location = New Point(233, 161)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(116, 20)
        lblNum2.TabIndex = 1
        lblNum2.Text = "Second Number"
        ' 
        ' btnMaximum
        ' 
        btnMaximum.Location = New Point(233, 254)
        btnMaximum.Name = "btnMaximum"
        btnMaximum.Size = New Size(94, 29)
        btnMaximum.TabIndex = 2
        btnMaximum.Text = "Maximum"
        btnMaximum.UseVisualStyleBackColor = True
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(411, 40)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(125, 27)
        txtNum1.TabIndex = 3
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(411, 158)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(125, 27)
        txtNum2.TabIndex = 4
        ' 
        ' txtMaximum
        ' 
        txtMaximum.BackColor = Color.White
        txtMaximum.Location = New Point(411, 256)
        txtMaximum.Name = "txtMaximum"
        txtMaximum.Size = New Size(125, 27)
        txtMaximum.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(txtMaximum)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(btnMaximum)
        Controls.Add(lblNum2)
        Controls.Add(lblNum1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents btnMaximum As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtMaximum As TextBox

End Class
