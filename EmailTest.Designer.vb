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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReceiveBox = New System.Windows.Forms.TextBox()
        Me.SenderBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.SubjectBox = New System.Windows.Forms.TextBox()
        Me.BodyBox = New System.Windows.Forms.RichTextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HostBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subject"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Message"
        '
        'ReceiveBox
        '
        Me.ReceiveBox.Location = New System.Drawing.Point(83, 6)
        Me.ReceiveBox.Name = "ReceiveBox"
        Me.ReceiveBox.Size = New System.Drawing.Size(737, 20)
        Me.ReceiveBox.TabIndex = 5
        '
        'SenderBox
        '
        Me.SenderBox.Location = New System.Drawing.Point(83, 33)
        Me.SenderBox.Name = "SenderBox"
        Me.SenderBox.Size = New System.Drawing.Size(737, 20)
        Me.SenderBox.TabIndex = 6
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(83, 64)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(340, 20)
        Me.PassBox.TabIndex = 7
        '
        'SubjectBox
        '
        Me.SubjectBox.Location = New System.Drawing.Point(83, 95)
        Me.SubjectBox.Name = "SubjectBox"
        Me.SubjectBox.Size = New System.Drawing.Size(737, 20)
        Me.SubjectBox.TabIndex = 8
        '
        'BodyBox
        '
        Me.BodyBox.Location = New System.Drawing.Point(83, 127)
        Me.BodyBox.Name = "BodyBox"
        Me.BodyBox.Size = New System.Drawing.Size(737, 179)
        Me.BodyBox.TabIndex = 9
        Me.BodyBox.Text = "Sample Message"
        '
        'SendButton
        '
        Me.SendButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendButton.Location = New System.Drawing.Point(83, 323)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(737, 23)
        Me.SendButton.TabIndex = 10
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Host Address"
        '
        'HostBox
        '
        Me.HostBox.Location = New System.Drawing.Point(505, 64)
        Me.HostBox.Name = "HostBox"
        Me.HostBox.Size = New System.Drawing.Size(315, 20)
        Me.HostBox.TabIndex = 12
        Me.HostBox.Text = "smtp.office365.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 358)
        Me.Controls.Add(Me.HostBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.BodyBox)
        Me.Controls.Add(Me.SubjectBox)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.SenderBox)
        Me.Controls.Add(Me.ReceiveBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ReceiveBox As TextBox
    Friend WithEvents SenderBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents SubjectBox As TextBox
    Friend WithEvents BodyBox As RichTextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents HostBox As TextBox
End Class
