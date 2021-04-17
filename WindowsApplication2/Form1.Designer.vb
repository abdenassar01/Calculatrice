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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nb1 = New System.Windows.Forms.TextBox()
        Me.nb2 = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Addition"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nb1
        '
        Me.nb1.Location = New System.Drawing.Point(113, 39)
        Me.nb1.Name = "nb1"
        Me.nb1.Size = New System.Drawing.Size(100, 20)
        Me.nb1.TabIndex = 1
        '
        'nb2
        '
        Me.nb2.Location = New System.Drawing.Point(426, 37)
        Me.nb2.Name = "nb2"
        Me.nb2.Size = New System.Drawing.Size(100, 20)
        Me.nb2.TabIndex = 2
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(251, 156)
        Me.result.Multiline = True
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(116, 41)
        Me.result.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(257, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RESULT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 46)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Substraction"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(316, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 46)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Multplication"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(454, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 46)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Division"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(679, 307)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.nb2)
        Me.Controls.Add(Me.nb1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nb1 As System.Windows.Forms.TextBox
    Friend WithEvents nb2 As System.Windows.Forms.TextBox
    Friend WithEvents result As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
