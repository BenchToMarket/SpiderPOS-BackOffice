
Structure Check

    Private _orderNumber As Integer
    Private _checkNumber As Integer
    Private _tableNumber As Integer
    Private _customerNumber As Integer
    Private _lastSIN As Integer
    Private _referenceSIN As Integer
    Private _subtotal As Single

    Public Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
        Set(ByVal Value As Integer)
            _orderNumber = Value
        End Set
    End Property

    Public Property Check() As Integer
        Get
            Return _checkNumber
        End Get
        Set(ByVal Value As Integer)
            _checkNumber = Value
        End Set
    End Property

    Public Property Table() As Integer
        Get
            Return _tableNumber
        End Get
        Set(ByVal Value As Integer)
            _tableNumber = Value
        End Set
    End Property

    Public Property Customer() As Integer
        Get
            Return _customerNumber
        End Get
        Set(ByVal Value As Integer)
            _customerNumber = Value
        End Set
    End Property

    Public Property SIN() As Integer
        Get
            Return _lastSIN
        End Get
        Set(ByVal Value As Integer)
            _lastSIN = Value
        End Set
    End Property

    Public Property ReferenceSIN() As Integer
        Get
            Return _referenceSIN
        End Get
        Set(ByVal Value As Integer)
            _referenceSIN = Value
        End Set
    End Property

    Public Property SubTotal() As Single
        Get
            Return _subtotal
        End Get
        Set(ByVal Value As Single)
            _subtotal = Value
        End Set
    End Property

End Structure


Public Class Ordering
    Inherits System.Windows.Forms.Form

    '   *** I do not think we use
    '   *** it comes from Ordering, but we never get here
    '   222

    Friend WithEvents custPanel As New Panel
    Friend customerButton(9) As custButton
    Friend WithEvents customerbuttonMain As custButton

    '   ***********************************************************
    '   Defines the names, and values which will determine location
    '   and size of all panels
    '   ***********************************************************


    '************************************************************************
    '   For both Main and MainModifier Panels
    '   (allow user to choose initial foods and modifiers)
    '************************************************************************

    '   Define both main and mainModifer panels
    Friend WithEvents pnlMain As New Panel
    Friend WithEvents pnlMainModifier As New Panel

    '********************************************************************************
    '   For Both Order Panel and OrderModifier Panel
    '********************************************************************************

    Friend WithEvents pnlOrder As New Panel
    Friend WithEvents pnlOrderModifier As New Panel
    Friend WithEvents pnlDescription As New Panel

    '   position and size of Order Panel (op)
    Dim opLocationX As Double = ssX * 0.02
    Dim opLocationY As Double = ssY * 0.01
    Dim opWidth As Double = ssX * 0.78
    Dim opHeight As Double = ssY * 0.75
    Dim opButtonWidth As Double = (opWidth - (3 * buttonSpace)) / 4
    Dim opButtonHeight As Double = (opHeight - (10 * buttonSpace)) / 8

    '   position and size of modifier panel (mp)
    Dim mpLocationX As Double = ssX * 0.15
    Dim mpLocationY As Double = ssY * 0.38
    Dim mpWidth As Double = ssX * 0.65
    Dim mpHeight As Double = ssY * 0.42
    Dim mpButtonWidth As Double = (mpWidth - (3 * buttonSpace)) / 4
    Dim mpButtonHeight As Double = (mpHeight - (5 * buttonSpace)) / 4

    '   position and size of description panel
    Dim dpLocationX As Double = ssX * 0.02
    Dim dpLocationY As Double = ssY * 0.01
    Dim dpWidth As Double = ssX * 0.78
    Dim dpHeight As Double = ssY * 0.35

    '   Buttons for the order(op) and modifier(mp) panel
    Private btnMain() As OrderButton
    Private btnModifier() As OrderButton
    Private btnOrder() As OrderButton
    Private btnOrderModifier() As OrderButton

    Friend WithEvents gridViewOrder As New DataGrid





    Private totalOrderLabel As New Label
    Private WithEvents totalOrder As New Label
    '    Private subTotal As Single = 33.22

    Friend WithEvents tableStatusView As New ListView
    Friend WithEvents byServerView As New ListView

    '   descriptions of all status categories
    Friend statusName(10) As String



    Private kitchenCommands As New Panel
    Private WithEvents btnSend As Button
    Private WithEvents btnHold As Button
    Private WithEvents btnVoid As Button
    Private WithEvents btnModify As Button
    Private WithEvents btnStatus As Button
    Private WithEvents btnLeave As Button

    Private WithEvents ViewStatus As New Panel
    Private WithEvents btnStatus1 As Button
    Private WithEvents btnStatus2 As Button
    Private WithEvents btnStatus3 As Button
    Private WithEvents btnStatus4 As Button
    Private WithEvents btnStatus5 As Button
    Private WithEvents btnStatus6 As Button

    Friend WithEvents modifyComboBox As ListBox


    Friend numberFree() As Integer
    Private openCheck As Check





#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther()


    End Sub

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'Ordering
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Name = "Ordering"
        Me.Text = "Ordering"

    End Sub

#End Region

    Private Sub InitializeOther()


        '     PopulateTables(1)   'either 1 for lunch or 2 for dinner
        '                    or any other number disired




    End Sub

    
End Class
