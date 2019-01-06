Imports DataSet_Builder

Public Class TableInfo_UC
    Inherits System.Windows.Forms.UserControl

    Dim _isNewTable As Boolean
    Dim _currentTable As PhysicalTable
  
    Friend Property IsNewTable() As Boolean
        Get
            Return _isNewTable
        End Get
        Set(ByVal Value As Boolean)
            _isNewTable = Value
        End Set
    End Property

    Friend Property CurrentTable() As PhysicalTable
        Get
            Return _currentTable
        End Get
        Set(ByVal Value As PhysicalTable)
            _currentTable = Value
        End Set
    End Property

    Event NewTableAccepted()
    Event UpdateOldTable()
    Event TableCancel()


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal isNT As Boolean, ByVal tempTable As PhysicalTable)
        MyBase.New()

        _isNewTable = isNT
        _currentTable = tempTable
     
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTableNumber As System.Windows.Forms.Label
    Friend WithEvents btnNewTable As System.Windows.Forms.Button
    Friend WithEvents txtTableNum As System.Windows.Forms.TextBox
    Friend WithEvents lblSeats As System.Windows.Forms.Label
    Friend WithEvents txtSeats As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chbAvailable As System.Windows.Forms.CheckBox
    Friend WithEvents chbActive As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chbActive = New System.Windows.Forms.CheckBox
        Me.chbAvailable = New System.Windows.Forms.CheckBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.lblWidth = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.Label
        Me.txtSeats = New System.Windows.Forms.TextBox
        Me.lblSeats = New System.Windows.Forms.Label
        Me.txtTableNum = New System.Windows.Forms.TextBox
        Me.btnNewTable = New System.Windows.Forms.Button
        Me.lblTableNumber = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.chbActive)
        Me.Panel1.Controls.Add(Me.chbAvailable)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.txtWidth)
        Me.Panel1.Controls.Add(Me.txtHeight)
        Me.Panel1.Controls.Add(Me.lblWidth)
        Me.Panel1.Controls.Add(Me.lblHeight)
        Me.Panel1.Controls.Add(Me.txtSeats)
        Me.Panel1.Controls.Add(Me.lblSeats)
        Me.Panel1.Controls.Add(Me.txtTableNum)
        Me.Panel1.Controls.Add(Me.btnNewTable)
        Me.Panel1.Controls.Add(Me.lblTableNumber)
        Me.Panel1.Location = New System.Drawing.Point(8, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 320)
        Me.Panel1.TabIndex = 0
        '
        'chbActive
        '
        Me.chbActive.Location = New System.Drawing.Point(32, 208)
        Me.chbActive.Name = "chbActive"
        Me.chbActive.TabIndex = 5
        Me.chbActive.Text = "Display on POS"
        '
        'chbAvailable
        '
        Me.chbAvailable.Location = New System.Drawing.Point(32, 176)
        Me.chbAvailable.Name = "chbAvailable"
        Me.chbAvailable.Size = New System.Drawing.Size(168, 24)
        Me.chbAvailable.TabIndex = 4
        Me.chbAvailable.Text = "Available at Open"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(128, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(112, 88)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(56, 20)
        Me.txtWidth.TabIndex = 2
        Me.txtWidth.Text = ""
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(112, 120)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(56, 20)
        Me.txtHeight.TabIndex = 3
        Me.txtHeight.Text = ""
        '
        'lblWidth
        '
        Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWidth.Location = New System.Drawing.Point(24, 88)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(64, 16)
        Me.lblWidth.TabIndex = 6
        Me.lblWidth.Text = "Width"
        '
        'lblHeight
        '
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblHeight.Location = New System.Drawing.Point(24, 120)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(64, 16)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Height"
        '
        'txtSeats
        '
        Me.txtSeats.Location = New System.Drawing.Point(112, 56)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(56, 20)
        Me.txtSeats.TabIndex = 1
        Me.txtSeats.Text = ""
        '
        'lblSeats
        '
        Me.lblSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSeats.Location = New System.Drawing.Point(24, 56)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(64, 16)
        Me.lblSeats.TabIndex = 3
        Me.lblSeats.Text = "Seats"
        '
        'txtTableNum
        '
        Me.txtTableNum.Location = New System.Drawing.Point(112, 16)
        Me.txtTableNum.Name = "txtTableNum"
        Me.txtTableNum.Size = New System.Drawing.Size(56, 20)
        Me.txtTableNum.TabIndex = 0
        Me.txtTableNum.Text = ""
        '
        'btnNewTable
        '
        Me.btnNewTable.Location = New System.Drawing.Point(24, 264)
        Me.btnNewTable.Name = "btnNewTable"
        Me.btnNewTable.Size = New System.Drawing.Size(80, 40)
        Me.btnNewTable.TabIndex = 1
        Me.btnNewTable.TabStop = False
        Me.btnNewTable.Text = "Create New"
        '
        'lblTableNumber
        '
        Me.lblTableNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTableNumber.Location = New System.Drawing.Point(24, 8)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(136, 32)
        Me.lblTableNumber.TabIndex = 0
        Me.lblTableNumber.Text = "Table #"
        Me.lblTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TableInfo_UC
        '
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TableInfo_UC"
        Me.Size = New System.Drawing.Size(248, 344)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        If Me.IsNewTable = False Then
            Me.btnNewTable.Text = "Update"
        End If

        BindData()

    End Sub
    Private Sub BindData()

        Me.txtTableNum.Text = CurrentTable.PhysicalTableNumber
        Me.txtSeats.Text = CurrentTable.Seats
        Me.txtWidth.Text = CurrentTable.myWidth
        Me.txtHeight.Text = CurrentTable.myHeight
        Me.chbAvailable.Checked = CurrentTable.Available
        Me.chbActive.Checked = CurrentTable.Active

    End Sub

    Private Sub txtTableNum_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTableNum.Validating
        ValidateNumeric(Me.txtTableNum)
    End Sub

    Private Sub txtSeats_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSeats.Validating
        ValidateNumeric(Me.txtSeats)
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

    Private Sub btnNewTTableAccepted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTable.Click

        If ErrorProvider1.GetError(Me.txtTableNum).Length = 0 And ErrorProvider1.GetError(Me.txtSeats).Length = 0 And ErrorProvider1.GetError(Me.txtWidth).Length = 0 And ErrorProvider1.GetError(Me.txtHeight).Length = 0 Then
            CurrentTable.PhysicalTableNumber = CInt(Me.txtTableNum.Text)
            CurrentTable.Seats = CInt(Me.txtSeats.Text)
            CurrentTable.myWidth = CInt(Me.txtWidth.Text)
            CurrentTable.myHeight = CInt(Me.txtHeight.Text)
            CurrentTable.Available = Me.chbAvailable.Checked
            CurrentTable.Active = Me.chbActive.Checked

            If IsNewTable = True Then
                RaiseEvent NewTableAccepted()
            Else
                RaiseEvent UpdateOldTable()
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        RaiseEvent TableCancel()

    End Sub

End Class
