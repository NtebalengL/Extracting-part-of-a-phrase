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
        btnExtract = New Button()
        lblPhrase = New Label()
        lblStart = New Label()
        lblNum = New Label()
        lblText = New Label()
        txtPhrase = New TextBox()
        txtPosition = New TextBox()
        txtCharacter = New TextBox()
        SuspendLayout()
        ' 
        ' btnExtract
        ' 
        btnExtract.Location = New Point(221, 330)
        btnExtract.Name = "btnExtract"
        btnExtract.Size = New Size(322, 34)
        btnExtract.TabIndex = 0
        btnExtract.Text = "Extract"
        btnExtract.UseVisualStyleBackColor = True
        ' 
        ' lblPhrase
        ' 
        lblPhrase.AutoSize = True
        lblPhrase.ForeColor = Color.MediumVioletRed
        lblPhrase.Location = New Point(173, 58)
        lblPhrase.Name = "lblPhrase"
        lblPhrase.Size = New Size(124, 25)
        lblPhrase.TabIndex = 1
        lblPhrase.Text = "Enter a phrase"
        ' 
        ' lblStart
        ' 
        lblStart.AutoSize = True
        lblStart.ForeColor = Color.ForestGreen
        lblStart.Location = New Point(173, 110)
        lblStart.Name = "lblStart"
        lblStart.Size = New Size(217, 25)
        lblStart.TabIndex = 1
        lblStart.Text = "Enter the starting position"
        ' 
        ' lblNum
        ' 
        lblNum.AutoSize = True
        lblNum.ForeColor = Color.ForestGreen
        lblNum.Location = New Point(173, 162)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(262, 25)
        lblNum.TabIndex = 1
        lblNum.Text = "Number of characters to extract"
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.ForeColor = Color.ForestGreen
        lblText.Location = New Point(173, 215)
        lblText.Name = "lblText"
        lblText.Size = New Size(119, 25)
        lblText.TabIndex = 1
        lblText.Text = "Text Extracted"
        ' 
        ' txtPhrase
        ' 
        txtPhrase.Location = New Point(534, 65)
        txtPhrase.Name = "txtPhrase"
        txtPhrase.Size = New Size(150, 31)
        txtPhrase.TabIndex = 2
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(534, 110)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(150, 31)
        txtPosition.TabIndex = 2
        ' 
        ' txtCharacter
        ' 
        txtCharacter.Location = New Point(534, 159)
        txtCharacter.Name = "txtCharacter"
        txtCharacter.Size = New Size(150, 31)
        txtCharacter.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(txtCharacter)
        Controls.Add(txtPosition)
        Controls.Add(txtPhrase)
        Controls.Add(lblText)
        Controls.Add(lblNum)
        Controls.Add(lblStart)
        Controls.Add(lblPhrase)
        Controls.Add(btnExtract)
        ForeColor = Color.Coral
        Name = "Form1"
        Text = "String Manipulation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExtract As Button
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblText As Label
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtCharacter As TextBox
End Class
