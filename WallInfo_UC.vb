Imports DataSet_Builder

Public Class WallInfo_UC
    Inherits System.Windows.Forms.UserControl

    Dim _isNewWall As Boolean
    Dim _currentWall As Wall
    Public locationHasChanged As Boolean

    Dim _newWall As Wall

    Public Property IsNewWall() As Boolean
        Get
            Return _isNewWall
        End Get
        Set(ByVal Value As Boolean)
            _isNewWall = Value
        End Set
    End Property

    Public Property CurrentWall() As Wall
        Get
            Return _currentWall
        End Get
        Set(ByVal Value As Wall)
            _currentWall = Value
        End Set
    End Property

    Public Property NewWall() As Wall
        Get
            Return _newWall
        End Get
        Set(ByVal Value As Wall)
            _newWall = Value
        End Set
    End Property


    Event NewWallAccepted()
    Event UpdateOldWall()
    Event WallCancel()

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal isNT As Boolean, ByVal tempWall As Wall)
        MyBase.New()

        _isNewWall = isNT
        _currentWall = tempWall
        _newWall = tempWall

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther()

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

    Friend WithEvents lblToEnd As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox

    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnBottom As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNewWall As System.Windows.Forms.Button
    Friend WithEvents lblWall As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnFlip As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.lblWidth = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.Label
        Me.lblToEnd = New System.Windows.Forms.Label
        Me.btnTop = New System.Windows.Forms.Button
        Me.btnLeft = New System.Windows.Forms.Button
        Me.btnRight = New System.Windows.Forms.Button
        Me.btnBottom = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNewWall = New System.Windows.Forms.Button
        Me.lblWall = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.btnFlip = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(96, 64)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(56, 20)
        Me.txtWidth.TabIndex = 10
        Me.txtWidth.Text = ""
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(96, 96)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(56, 20)
        Me.txtHeight.TabIndex = 11
        Me.txtHeight.Text = ""
        '
        'lblWidth
        '
        Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWidth.Location = New System.Drawing.Point(24, 64)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(64, 16)
        Me.lblWidth.TabIndex = 13
        Me.lblWidth.Text = "Width"
        '
        'lblHeight
        '
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblHeight.Location = New System.Drawing.Point(24, 96)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(64, 16)
        Me.lblHeight.TabIndex = 12
        Me.lblHeight.Text = "Height"
        '
        'lblToEnd
        '
        Me.lblToEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToEnd.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblToEnd.Location = New System.Drawing.Point(96, 128)
        Me.lblToEnd.Name = "lblToEnd"
        Me.lblToEnd.Size = New System.Drawing.Size(64, 16)
        Me.lblToEnd.TabIndex = 14
        Me.lblToEnd.Text = "To End"
        '
        'btnTop
        '
        Me.btnTop.Location = New System.Drawing.Point(80, 152)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(80, 32)
        Me.btnTop.TabIndex = 15
        Me.btnTop.Text = "Top"
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(24, 192)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 32)
        Me.btnLeft.TabIndex = 16
        Me.btnLeft.Text = "Left"
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(144, 192)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 32)
        Me.btnRight.TabIndex = 17
        Me.btnRight.Text = "Right"
        '
        'btnBottom
        '
        Me.btnBottom.Location = New System.Drawing.Point(80, 232)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(80, 32)
        Me.btnBottom.TabIndex = 18
        Me.btnBottom.Text = "Bottom"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(136, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Close"
        '
        'btnNewWall
        '
        Me.btnNewWall.Location = New System.Drawing.Point(24, 288)
        Me.btnNewWall.Name = "btnNewWall"
        Me.btnNewWall.Size = New System.Drawing.Size(88, 40)
        Me.btnNewWall.TabIndex = 19
        Me.btnNewWall.TabStop = False
        Me.btnNewWall.Text = "Create New"
        '
        'lblWall
        '
        Me.lblWall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWall.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWall.Location = New System.Drawing.Point(16, 8)
        Me.lblWall.Name = "lblWall"
        Me.lblWall.Size = New System.Drawing.Size(216, 32)
        Me.lblWall.TabIndex = 21
        Me.lblWall.Text = "Physical Structure"
        Me.lblWall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnFlip
        '
        Me.btnFlip.Location = New System.Drawing.Point(176, 72)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(48, 40)
        Me.btnFlip.TabIndex = 22
        Me.btnFlip.Text = "Flip"
        '
        'WallInfo_UC
        '
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.lblWall)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNewWall)
        Me.Controls.Add(Me.btnBottom)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.lblToEnd)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblHeight)
        Me.Name = "WallInfo_UC"
        Me.Size = New System.Drawing.Size(248, 344)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        If Me.IsNewWall = False Then
            Me.btnNewWall.Text = "Update"
        End If

        BindData()

    End Sub
    Private Sub BindData()

        Me.txtWidth.Text = Me.CurrentWall.myWidth
        Me.txtHeight.Text = Me.CurrentWall.myHeight

    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Me.NewWall.myWidth = Me.Parent.Width - Me.CurrentWall.xLoc
        Me.txtWidth.Text = Me.NewWall.myWidth

    End Sub
    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Me.NewWall.myWidth = Me.CurrentWall.xLoc + Me.CurrentWall.myWidth
        Me.txtWidth.Text = Me.NewWall.myWidth
        Me.NewWall.xLoc = 0
        locationHasChanged = True

    End Sub
    Private Sub btnBottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        Me.NewWall.myHeight = Me.Parent.Height - Me.CurrentWall.yLoc
        Me.txtHeight.Text = Me.NewWall.myHeight

    End Sub
    Private Sub btnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop.Click
        Me.NewWall.myHeight = Me.CurrentWall.yLoc + Me.CurrentWall.myHeight
        Me.txtHeight.Text = Me.NewWall.myHeight
        Me.NewWall.yLoc = 0
        locationHasChanged = True

    End Sub
    Private Sub btnFlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlip.Click
        Me.NewWall.myWidth = CInt(Me.txtHeight.Text)
        Me.NewWall.myHeight = CInt(Me.txtWidth.Text)

        Me.txtWidth.Text = Me.NewWall.myWidth
        Me.txtHeight.Text = Me.NewWall.myHeight
    End Sub
    Private Sub txtWidth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtWidth.Validating
        ValidateNumeric(Me.txtWidth)

    End Sub

    Private Sub txtHeight_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHeight.Validating
        ValidateNumeric(Me.txtHeight)

    End Sub

    Private Sub ValidateNumeric(ByRef txtValNumeric As TextBox)

        If txtValNumeric.Text = "" Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This TextBox can not be Blank.")
            txtValNumeric.Focus()
            Beep()

        ElseIf Not IsNumeric(txtValNumeric.Text) Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a numeric value.")
            txtValNumeric.Focus()
            Beep()

        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
            '            Me.ErrorProvider1.SetError(txtValNumeric, "")
        End If
    End Sub

    Private Sub btnNewWall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewWall.Click
        If ErrorProvider1.GetError(Me.txtWidth).Length = 0 And ErrorProvider1.GetError(Me.txtHeight).Length = 0 Then
            NewWall.myWidth = CInt(Me.txtWidth.Text)
            NewWall.myHeight = CInt(Me.txtHeight.Text)

            If IsNewWall = True Then
                RaiseEvent NewWallAccepted()
            Else
                RaiseEvent UpdateOldWall()
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        RaiseEvent WallCancel()

    End Sub

End Class
