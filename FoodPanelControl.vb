Public Class FoodPanelControl
    Inherits System.Windows.Forms.Button

    Friend foodNamePanel As Label
    Friend foodPricePanel As Label

    Private _position As Integer
    Private _menuJoinID As Integer
    Private _foodName As String
    Private _foodPrice As Decimal
    Private _menuIndex As Integer
    Private _isStaging As Integer
    Private _updatingTable As String
    Private _foodID As Integer
    Private _surcharge As Decimal
    Private _routingID As Integer
    Private _drinkID As Integer
    Private _generalMenuID As Integer
    Private _currentMenu As Integer
    Private _bColor As Color
    Private _fColor As Color

    Friend Property Position() As Integer
        Get
            Return _position
        End Get
        Set(ByVal Value As Integer)
            _position = Value
        End Set
    End Property
    Friend Property MenuJoinID() As Integer
        Get
            Return _menuJoinID
        End Get
        Set(ByVal Value As Integer)
            _menuJoinID = Value
        End Set
    End Property

    Friend Property FoodName() As String
        Get
            Return _foodName
        End Get
        Set(ByVal Value As String)
            _foodName = Value
        End Set
    End Property

    Friend Property FoodPrice() As Decimal
        Get
            Return _foodPrice
        End Get
        Set(ByVal Value As Decimal)
            _foodPrice = Value
        End Set
    End Property

    Friend Property MenuIndex() As Integer
        Get
            Return _menuIndex
        End Get
        Set(ByVal Value As Integer)
            _menuIndex = Value
        End Set
    End Property

    Friend Property StagingPanel() As Boolean
        Get
            Return _isStaging
        End Get
        Set(ByVal Value As Boolean)
            _isStaging = Value
        End Set
    End Property

    Friend Property UpdatingTable() As String
        Get
            Return _updatingTable
        End Get
        Set(ByVal Value As String)
            _updatingTable = Value
        End Set
    End Property

    Friend Property FoodID() As Integer
        Get
            Return _foodID
        End Get
        Set(ByVal Value As Integer)
            _foodID = Value
        End Set
    End Property

    Friend Property Surcharge() As Decimal
        Get
            Return _surcharge
        End Get
        Set(ByVal Value As Decimal)
            _surcharge = Value
        End Set
    End Property

    Friend Property RoutingID() As Integer
        Get
            Return _routingID
        End Get
        Set(ByVal Value As Integer)
            _routingID = Value
        End Set
    End Property

    Friend Property DrinkID() As Integer
        Get
            Return _drinkID
        End Get
        Set(ByVal Value As Integer)
            _drinkID = Value
        End Set
    End Property

    Friend Property GeneralMenuID() As Integer
        Get
            Return _generalMenuID
        End Get
        Set(ByVal Value As Integer)
            _generalMenuID = Value
        End Set
    End Property

    Friend Property CurrentMenu() As Integer
        Get
            Return _currentMenu
        End Get
        Set(ByVal Value As Integer)
            _currentMenu = Value
        End Set
    End Property

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal bColor As Color, ByVal fColor As Color, ByVal foodOrderNumber As Integer, ByVal index As Integer, ByVal menuJoinID As Integer, ByVal name As String, ByVal price As Decimal, ByVal w As Single, ByVal h As Single, ByVal isStaging As Boolean, ByVal dTable As String, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)
        MyBase.New()

        '    Me.BackColor = bColor
        '   Me.ForeColor = fColor

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Position = foodOrderNumber
        Me.MenuJoinID = menuJoinID
        Me.MenuIndex = index
        Me.StagingPanel = isStaging
        Me.FoodName = name
        Me.FoodPrice = price
        Me.UpdatingTable = dTable

        Me.FoodID = fID
        Me.Surcharge = sur
        Me.RoutingID = rout
        Me.DrinkID = dID
        Me.GeneralMenuID = GenMenuID
        Me.CurrentMenu = cm
        Me._bColor = bColor
        Me._fColor = fColor

        InitializeOther(w, h)

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region

    Private Sub InitializeOther(ByVal width As Single, ByVal height As Single)
        foodNamePanel = New Label
        foodPricePanel = New Label

        Me.Size = New Size(width, height)
        Me.Text = FoodName
        Me.AllowDrop = True

        foodNamePanel.Size = New Size(width, height / 2)
        foodNamePanel.Location = New Point(0, 0)
        foodNamePanel.Text = FoodName

        foodPricePanel.Size = New Size(width, height / 2)
        foodPricePanel.Location = New Point(0, height / 2)
        foodPricePanel.Text = "$ " & FoodPrice
        '      If _bColor = Nothing Then
        '     foodNamePanel.BackColor = Color.PowderBlue
        '    foodPricePanel.BackColor = Color.PowderBlue
        '   Else
            foodNamePanel.BackColor = _bColor
            foodPricePanel.BackColor = _bColor
            foodNamePanel.ForeColor = _fColor
            foodPricePanel.ForeColor = _fColor
        '  End If
        Me.foodPricePanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        '      Me.Controls.Add(foodNamePanel)
        '     Me.Controls.Add(foodPricePanel)

    End Sub



End Class
