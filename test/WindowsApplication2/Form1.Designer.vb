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
        Me.OutputTxt = New System.Windows.Forms.TextBox()
        Me.InputTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputTxt
        '
        Me.OutputTxt.Location = New System.Drawing.Point(12, 12)
        Me.OutputTxt.Multiline = True
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.Size = New System.Drawing.Size(260, 198)
        Me.OutputTxt.TabIndex = 0
        '
        'InputTxt
        '
        Me.InputTxt.Location = New System.Drawing.Point(12, 229)
        Me.InputTxt.Name = "InputTxt"
        Me.InputTxt.Size = New System.Drawing.Size(204, 20)
        Me.InputTxt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 19)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InputTxt)
        Me.Controls.Add(Me.OutputTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputTxt As System.Windows.Forms.TextBox
    Friend WithEvents InputTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
