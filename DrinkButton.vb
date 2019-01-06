Public Class DrinkButton
    Inherits Button

    Private _id As Integer
    Private _categoryName As String
    Private _drinkCategoryID As Integer
    Private _dRowNumber As Integer
    Private _drinkIndex As Integer
    Private _drinkPrice As Single
    Private _callPrice As Decimal
    Private _addOnPrice As Decimal
    Private _drinkFunctionID As Integer
    Private _drinkDesc As String
    Private _drinkAddOnChoice As Boolean
    Private _isDrinkAdd As Boolean
    Private _isALiquorType As Boolean
    Private _isWineParring As Boolean
    Private _liquorTypeID As Integer
    Private _position As Integer
    Private _menuIndex As Integer
    Private _bStyle As BorderStyle = BorderStyle.FixedSingle

    Friend Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Friend Property CategoryName() As String
        Get
            Return _categoryName
        End Get
        Set(ByVal Value As String)
            _categoryName = Value
        End Set
    End Property

    Friend Property DrinkCategoryID() As Integer
        Get
            Return _drinkCategoryID
        End Get
        Set(ByVal Value As Integer)
            _drinkCategoryID = Value
        End Set
    End Property

    Friend Property dRowNumber() As Integer
        Get
            Return _dRowNumber
        End Get
        Set(ByVal Value As Integer)
            _dRowNumber = Value
        End Set
    End Property

    Friend Property DrinkIndex() As Integer
        Get
            Return _drinkIndex
        End Get
        Set(ByVal Value As Integer)
            _drinkIndex = Value
        End Set
    End Property

    Friend Property DrinkPrice() As Single
        Get
            Return _drinkPrice
        End Get
        Set(ByVal Value As Single)
            _drinkPrice = Value
        End Set
    End Property

    Friend Property CallPrice() As Decimal
        Get
            Return _callPrice
        End Get
        Set(ByVal Value As Decimal)
            _callPrice = Value
        End Set
    End Property

    Friend Property AddOnPrice() As Decimal
        Get
            Return _addOnPrice
        End Get
        Set(ByVal Value As Decimal)
            _addOnPrice = Value
        End Set
    End Property

    Friend Property DrinkFunctionID() As Integer
        Get
            Return _drinkFunctionID
        End Get
        Set(ByVal Value As Integer)
            _drinkFunctionID = Value
        End Set
    End Property

    Friend Property DrinkDesc() As String
        Get
            Return _drinkDesc
        End Get
        Set(ByVal Value As String)
            _drinkDesc = Value
        End Set
    End Property

    Friend Property DrinkAddOnChoice() As Boolean
        Get
            Return _drinkAddOnChoice
        End Get
        Set(ByVal Value As Boolean)
            _drinkAddOnChoice = Value
        End Set
    End Property

    Friend Property IsDrinkAdd() As Boolean
        Get
            Return _isDrinkAdd
        End Get
        Set(ByVal Value As Boolean)
            _isDrinkAdd = Value
        End Set
    End Property

    Friend Property IsALiquorType() As Boolean
        Get
            Return _isALiquorType
        End Get
        Set(ByVal Value As Boolean)
            _isALiquorType = Value
        End Set
    End Property

    Friend Property IsWineParring() As Boolean
        Get
            Return _isWineParring
        End Get
        Set(ByVal Value As Boolean)
            _isWineParring = Value
        End Set
    End Property

    Friend Property LiquorTypeID() As Integer
        Get
            Return _liquorTypeID
        End Get
        Set(ByVal Value As Integer)
            _liquorTypeID = Value
        End Set
    End Property

    Friend Property Position() As Integer
        Get
            Return _position
        End Get
        Set(ByVal Value As Integer)
            _position = Value
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

    Friend Property BorderStyle() As BorderStyle
        Get
            Return _bStyle
        End Get
        Set(ByVal Value As BorderStyle)
            _bStyle = Value
        End Set
    End Property




End Class
