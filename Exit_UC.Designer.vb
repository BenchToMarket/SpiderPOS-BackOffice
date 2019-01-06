<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exit_UC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlExitUC = New System.Windows.Forms.Panel
        Me.btnExitCancel = New System.Windows.Forms.Button
        Me.btnForceMenu = New System.Windows.Forms.Button
        Me.btnExitNoForce = New System.Windows.Forms.Button
        Me.DateTimePickerMenu = New System.Windows.Forms.DateTimePicker
        Me.pnlExitUC.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlExitUC
        '
        Me.pnlExitUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlExitUC.Controls.Add(Me.btnExitCancel)
        Me.pnlExitUC.Controls.Add(Me.btnForceMenu)
        Me.pnlExitUC.Controls.Add(Me.btnExitNoForce)
        Me.pnlExitUC.Controls.Add(Me.DateTimePickerMenu)
        Me.pnlExitUC.Location = New System.Drawing.Point(12, 14)
        Me.pnlExitUC.Name = "pnlExitUC"
        Me.pnlExitUC.Size = New System.Drawing.Size(354, 244)
        Me.pnlExitUC.TabIndex = 0
        '
        'btnExitCancel
        '
        Me.btnExitCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnExitCancel.Location = New System.Drawing.Point(29, 193)
        Me.btnExitCancel.Name = "btnExitCancel"
        Me.btnExitCancel.Size = New System.Drawing.Size(80, 26)
        Me.btnExitCancel.TabIndex = 3
        Me.btnExitCancel.Text = "Cancel"
        Me.btnExitCancel.UseVisualStyleBackColor = False
        '
        'btnForceMenu
        '
        Me.btnForceMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnForceMenu.Location = New System.Drawing.Point(29, 19)
        Me.btnForceMenu.Name = "btnForceMenu"
        Me.btnForceMenu.Size = New System.Drawing.Size(80, 80)
        Me.btnForceMenu.TabIndex = 2
        Me.btnForceMenu.Text = "Force Menu Reload on New Daily"
        Me.btnForceMenu.UseVisualStyleBackColor = False
        '
        'btnExitNoForce
        '
        Me.btnExitNoForce.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnExitNoForce.Location = New System.Drawing.Point(29, 115)
        Me.btnExitNoForce.Name = "btnExitNoForce"
        Me.btnExitNoForce.Size = New System.Drawing.Size(80, 57)
        Me.btnExitNoForce.TabIndex = 1
        Me.btnExitNoForce.Text = "Exit with Forcing"
        Me.btnExitNoForce.UseVisualStyleBackColor = False
        Me.btnExitNoForce.Visible = False
        '
        'DateTimePickerMenu
        '
        Me.DateTimePickerMenu.Location = New System.Drawing.Point(133, 19)
        Me.DateTimePickerMenu.Name = "DateTimePickerMenu"
        Me.DateTimePickerMenu.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerMenu.TabIndex = 0
        '
        'Exit_UC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.pnlExitUC)
        Me.Name = "Exit_UC"
        Me.Size = New System.Drawing.Size(381, 272)
        Me.pnlExitUC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlExitUC As System.Windows.Forms.Panel
    Friend WithEvents btnForceMenu As System.Windows.Forms.Button
    Friend WithEvents btnExitNoForce As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerMenu As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExitCancel As System.Windows.Forms.Button

End Class
