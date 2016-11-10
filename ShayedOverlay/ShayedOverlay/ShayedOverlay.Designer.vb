<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShayed
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShayed))
        Me.cmdLeft = New System.Windows.Forms.Button()
        Me.cmdRight = New System.Windows.Forms.Button()
        Me.txtReticle = New System.Windows.Forms.TextBox()
        Me.picReticle = New System.Windows.Forms.PictureBox()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.txtOnOff = New System.Windows.Forms.TextBox()
        Me.txtPixel = New System.Windows.Forms.TextBox()
        CType(Me.picReticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLeft
        '
        Me.cmdLeft.Location = New System.Drawing.Point(19, 12)
        Me.cmdLeft.Name = "cmdLeft"
        Me.cmdLeft.Size = New System.Drawing.Size(75, 38)
        Me.cmdLeft.TabIndex = 0
        Me.cmdLeft.Text = "Left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monitor"
        Me.cmdLeft.UseVisualStyleBackColor = True
        '
        'cmdRight
        '
        Me.cmdRight.Location = New System.Drawing.Point(100, 12)
        Me.cmdRight.Name = "cmdRight"
        Me.cmdRight.Size = New System.Drawing.Size(75, 38)
        Me.cmdRight.TabIndex = 1
        Me.cmdRight.Text = "Right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monitor"
        Me.cmdRight.UseVisualStyleBackColor = True
        '
        'txtReticle
        '
        Me.txtReticle.Enabled = False
        Me.txtReticle.Location = New System.Drawing.Point(19, 94)
        Me.txtReticle.Name = "txtReticle"
        Me.txtReticle.Size = New System.Drawing.Size(75, 20)
        Me.txtReticle.TabIndex = 260
        Me.txtReticle.Text = "0"
        '
        'picReticle
        '
        Me.picReticle.BackColor = System.Drawing.Color.Aqua
        Me.picReticle.Location = New System.Drawing.Point(19, 68)
        Me.picReticle.Name = "picReticle"
        Me.picReticle.Size = New System.Drawing.Size(75, 20)
        Me.picReticle.TabIndex = 259
        Me.picReticle.TabStop = False
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 300
        '
        'txtOnOff
        '
        Me.txtOnOff.Enabled = False
        Me.txtOnOff.Location = New System.Drawing.Point(100, 94)
        Me.txtOnOff.Name = "txtOnOff"
        Me.txtOnOff.Size = New System.Drawing.Size(75, 20)
        Me.txtOnOff.TabIndex = 261
        Me.txtOnOff.Text = "Off"
        '
        'txtPixel
        '
        Me.txtPixel.Location = New System.Drawing.Point(100, 68)
        Me.txtPixel.Name = "txtPixel"
        Me.txtPixel.Size = New System.Drawing.Size(75, 20)
        Me.txtPixel.TabIndex = 262
        Me.txtPixel.Text = "ffff33ff"
        '
        'frmShayed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 136)
        Me.Controls.Add(Me.txtPixel)
        Me.Controls.Add(Me.txtOnOff)
        Me.Controls.Add(Me.txtReticle)
        Me.Controls.Add(Me.picReticle)
        Me.Controls.Add(Me.cmdRight)
        Me.Controls.Add(Me.cmdLeft)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmShayed"
        Me.Text = "Shayed Overlay"
        CType(Me.picReticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLeft As Button
    Friend WithEvents cmdRight As Button
    Friend WithEvents txtReticle As TextBox
    Friend WithEvents picReticle As PictureBox
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents txtOnOff As TextBox
    Friend WithEvents txtPixel As TextBox
End Class
