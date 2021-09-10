<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.PatterntBox = New System.Windows.Forms.TextBox()
        Me.Text = New System.Windows.Forms.Label()
        Me.Pattern = New System.Windows.Forms.Label()
        Me.PatternMatching = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(1227, 129)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(241, 39)
        Me.TextBox.TabIndex = 0
        '
        'PatterntBox
        '
        Me.PatterntBox.Location = New System.Drawing.Point(1227, 194)
        Me.PatterntBox.Name = "PatterntBox"
        Me.PatterntBox.Size = New System.Drawing.Size(241, 39)
        Me.PatterntBox.TabIndex = 1
        '
        'Text
        '
        Me.Text.AutoSize = True
        Me.Text.Location = New System.Drawing.Point(1161, 136)
        Me.Text.Name = "Text"
        Me.Text.Size = New System.Drawing.Size(57, 32)
        Me.Text.TabIndex = 2
        Me.Text.Text = "Text"
        '
        'Pattern
        '
        Me.Pattern.AutoSize = True
        Me.Pattern.Location = New System.Drawing.Point(1129, 201)
        Me.Pattern.Name = "Pattern"
        Me.Pattern.Size = New System.Drawing.Size(89, 32)
        Me.Pattern.TabIndex = 3
        Me.Pattern.Text = "Pattern"
        '
        'PatternMatching
        '
        Me.PatternMatching.Location = New System.Drawing.Point(1227, 266)
        Me.PatternMatching.Name = "PatternMatching"
        Me.PatternMatching.Size = New System.Drawing.Size(241, 50)
        Me.PatternMatching.TabIndex = 4
        Me.PatternMatching.Text = "Pattern Matching"
        Me.PatternMatching.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1518, 698)
        Me.Controls.Add(Me.PatternMatching)
        Me.Controls.Add(Me.Pattern)
        Me.Controls.Add(Me.Text)
        Me.Controls.Add(Me.PatterntBox)
        Me.Controls.Add(Me.TextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents PatterntBox As TextBox
    Friend WithEvents Text As Label
    Friend WithEvents Pattern As Label
    Friend WithEvents PatternMatching As Button
End Class
