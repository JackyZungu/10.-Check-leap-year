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
        btnCheck = New Button()
        lbYear = New Label()
        txtYear = New TextBox()
        lbResult = New Label()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(262, 176)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(94, 29)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Check Year"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' lbYear
        ' 
        lbYear.AutoSize = True
        lbYear.Location = New Point(214, 53)
        lbYear.Name = "lbYear"
        lbYear.Size = New Size(37, 20)
        lbYear.TabIndex = 1
        lbYear.Text = "Year"
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(282, 53)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(125, 27)
        txtYear.TabIndex = 2
        ' 
        ' lbResult
        ' 
        lbResult.AutoSize = True
        lbResult.Location = New Point(307, 104)
        lbResult.Name = "lbResult"
        lbResult.Size = New Size(49, 20)
        lbResult.TabIndex = 3
        lbResult.Text = "Rusult"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbResult)
        Controls.Add(txtYear)
        Controls.Add(lbYear)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents lbYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lbResult As Label
End Class
