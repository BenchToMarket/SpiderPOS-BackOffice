Public Class ButtonColor_UC
    Inherits System.Windows.Forms.UserControl

    Dim cc As Integer
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Dim foreCC As Integer

    Event ChangeButtonColor(ByVal cc As Integer, ByVal foreCC As Integer)

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnCatColorCancel As System.Windows.Forms.Button
    Friend WithEvents btnCatColorAccept As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCatColorCancel = New System.Windows.Forms.Button
        Me.btnCatColorAccept = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button35)
        Me.Panel1.Controls.Add(Me.Button34)
        Me.Panel1.Controls.Add(Me.Button33)
        Me.Panel1.Controls.Add(Me.Button32)
        Me.Panel1.Controls.Add(Me.Button31)
        Me.Panel1.Controls.Add(Me.Button30)
        Me.Panel1.Controls.Add(Me.Button29)
        Me.Panel1.Controls.Add(Me.Button28)
        Me.Panel1.Controls.Add(Me.Button27)
        Me.Panel1.Controls.Add(Me.Button26)
        Me.Panel1.Controls.Add(Me.Button25)
        Me.Panel1.Controls.Add(Me.Button24)
        Me.Panel1.Controls.Add(Me.Button23)
        Me.Panel1.Controls.Add(Me.Button22)
        Me.Panel1.Controls.Add(Me.Button21)
        Me.Panel1.Controls.Add(Me.Button20)
        Me.Panel1.Controls.Add(Me.Button19)
        Me.Panel1.Controls.Add(Me.Button18)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 208)
        Me.Panel1.TabIndex = 0
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button25.Location = New System.Drawing.Point(204, 166)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(32, 32)
        Me.Button25.TabIndex = 24
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button24.Location = New System.Drawing.Point(166, 128)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(32, 32)
        Me.Button24.TabIndex = 23
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button23.Location = New System.Drawing.Point(166, 88)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(32, 32)
        Me.Button23.TabIndex = 22
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Button22.Location = New System.Drawing.Point(166, 48)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(32, 32)
        Me.Button22.TabIndex = 21
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button21.Location = New System.Drawing.Point(166, 8)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(32, 32)
        Me.Button21.TabIndex = 20
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Gray
        Me.Button20.Location = New System.Drawing.Point(128, 168)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(32, 32)
        Me.Button20.TabIndex = 19
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button19.Location = New System.Drawing.Point(128, 48)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(32, 32)
        Me.Button19.TabIndex = 18
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button18.Location = New System.Drawing.Point(8, 8)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(32, 32)
        Me.Button18.TabIndex = 17
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button17.Location = New System.Drawing.Point(48, 48)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(32, 32)
        Me.Button17.TabIndex = 16
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button16.Location = New System.Drawing.Point(8, 48)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(32, 32)
        Me.Button16.TabIndex = 15
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Button15.Location = New System.Drawing.Point(90, 128)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(32, 32)
        Me.Button15.TabIndex = 14
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button14.Location = New System.Drawing.Point(88, 168)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(32, 32)
        Me.Button14.TabIndex = 13
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(8, 128)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 32)
        Me.Button13.TabIndex = 12
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(128, 128)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(32, 32)
        Me.Button12.TabIndex = 11
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.IndianRed
        Me.Button11.Location = New System.Drawing.Point(48, 128)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(32, 32)
        Me.Button11.TabIndex = 10
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DarkGray
        Me.Button10.Location = New System.Drawing.Point(241, 48)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(32, 32)
        Me.Button10.TabIndex = 9
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.SlateGray
        Me.Button9.Location = New System.Drawing.Point(241, 10)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 32)
        Me.Button9.TabIndex = 8
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(128, 88)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 32)
        Me.Button8.TabIndex = 7
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(8, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 32)
        Me.Button7.TabIndex = 6
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(88, 48)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 32)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(48, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.Location = New System.Drawing.Point(128, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Location = New System.Drawing.Point(88, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(48, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(88, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCatColorCancel
        '
        Me.btnCatColorCancel.Location = New System.Drawing.Point(53, 230)
        Me.btnCatColorCancel.Name = "btnCatColorCancel"
        Me.btnCatColorCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCatColorCancel.TabIndex = 5
        Me.btnCatColorCancel.Text = "Cancel"
        '
        'btnCatColorAccept
        '
        Me.btnCatColorAccept.Location = New System.Drawing.Point(171, 230)
        Me.btnCatColorAccept.Name = "btnCatColorAccept"
        Me.btnCatColorAccept.Size = New System.Drawing.Size(72, 32)
        Me.btnCatColorAccept.TabIndex = 4
        Me.btnCatColorAccept.Text = "Accept"
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button26.Location = New System.Drawing.Point(241, 88)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(32, 32)
        Me.Button26.TabIndex = 25
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Button27.Location = New System.Drawing.Point(204, 88)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(32, 32)
        Me.Button27.TabIndex = 26
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.DarkSalmon
        Me.Button28.Location = New System.Drawing.Point(204, 128)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(32, 32)
        Me.Button28.TabIndex = 27
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.Moccasin
        Me.Button29.Location = New System.Drawing.Point(241, 126)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(32, 32)
        Me.Button29.TabIndex = 28
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button30.Location = New System.Drawing.Point(166, 166)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(32, 32)
        Me.Button30.TabIndex = 29
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button31.Location = New System.Drawing.Point(242, 166)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(32, 32)
        Me.Button31.TabIndex = 30
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Button32.Location = New System.Drawing.Point(204, 48)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(32, 32)
        Me.Button32.TabIndex = 31
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button33.Location = New System.Drawing.Point(204, 8)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(32, 32)
        Me.Button33.TabIndex = 32
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button34.Location = New System.Drawing.Point(8, 166)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(32, 32)
        Me.Button34.TabIndex = 33
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button35.Location = New System.Drawing.Point(50, 166)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(32, 32)
        Me.Button35.TabIndex = 34
        Me.Button35.UseVisualStyleBackColor = False
        '
        'ButtonColor_UC
        '
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCatColorCancel)
        Me.Controls.Add(Me.btnCatColorAccept)
        Me.Name = "ButtonColor_UC"
        Me.Size = New System.Drawing.Size(295, 272)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub
    Private Sub ChangeButtonAcceptColor(ByVal cc As Integer, ByVal foreCC As Integer)
        Me.btnCatColorAccept.BackColor = Color.FromArgb(cc)
        Me.btnCatColorAccept.ForeColor = Color.FromArgb(foreCC)
        '    MsgBox(btnCatColorAccept.BackColor.ToString)
        '   MsgBox(btnCatColorAccept.ForeColor.ToString)

    End Sub

    Private Sub btnCatColorAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatColorAccept.Click
        RaiseEvent ChangeButtonColor(cc, foreCC)
        Me.Dispose()

    End Sub

    Private Sub btnCatColorCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatColorCancel.Click
        Me.Dispose()

    End Sub




    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.Black.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        cc = sender.backcolor.ToArgb
        foreCC = Color.White.ToArgb
        ChangeButtonAcceptColor(cc, foreCC)

    End Sub
End Class
