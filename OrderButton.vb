Friend Class OrderButton

    Inherits Button

    Private _drinkCategory As Boolean
    Private _subCategory As Boolean
    Private _drinkAdds As Boolean
    Private _text As String
    Private _name As String
    Private _id As Integer
    Private _foodID As Integer      ' carries food id to modifier selection
    Private _numberFree As Integer
    Private _functions As Integer

    Private _btnNumber As Integer
    Private _btnIndex As Integer
    Private _dataViewIndex As Integer
    Private _priority As Int16
    Private _colorInt As Integer
    Private _colorForeInt As Integer
    Private _halfSplit As Boolean
    Private _isActive As Boolean

    Private bStyle As BorderStyle = BorderStyle.FixedSingle


    Public Property DrinkCategory() As Boolean
        Get
            Return _drinkCategory
        End Get
        Set(ByVal Value As Boolean)
            _drinkCategory = Value
        End Set
    End Property

    Public Property SubCategory() As Boolean
        Get
            Return _subCategory
        End Get
        Set(ByVal Value As Boolean)
            _subCategory = Value
        End Set
    End Property

    Public Property DrinkAdds() As Boolean
        Get
            Return _drinkAdds
        End Get
        Set(ByVal Value As Boolean)
            _drinkAdds = Value
        End Set
    End Property

    Public Property ItemName() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property FoodID() As Integer
        Get
            Return _foodID
        End Get
        Set(ByVal Value As Integer)
            _foodID = Value
        End Set
    End Property

    Public Property NumberFree() As Integer
        Get
            Return _numberFree
        End Get
        Set(ByVal Value As Integer)
            _numberFree = Value
        End Set
    End Property

    Public Property Functions() As Integer
        Get
            Return _functions
        End Get
        Set(ByVal Value As Integer)
            _functions = Value
        End Set
    End Property

    Public Property BtnNumber() As Integer
        Get
            Return _btnNumber
        End Get
        Set(ByVal Value As Integer)
            _btnNumber = Value
        End Set
    End Property

    Public Property BtnIndex() As Integer
        Get
            Return _btnIndex
        End Get
        Set(ByVal Value As Integer)
            _btnIndex = Value
        End Set
    End Property

    Public Property DataViewIndex() As Integer
        Get
            Return _dataViewIndex
        End Get
        Set(ByVal Value As Integer)
            _dataViewIndex = Value
        End Set
    End Property

    Public Property BorderStyle() As BorderStyle
        Get
            Return bStyle
        End Get
        Set(ByVal Value As BorderStyle)
            bStyle = Value
        End Set
    End Property

    Public Property Priority() As Int16
        Get
            Return _priority
        End Get
        Set(ByVal Value As Int16)
            _priority = Value
        End Set
    End Property

    Public Property ColorInt() As Integer
        Get
            Return _colorInt
        End Get
        Set(ByVal Value As Integer)
            _colorInt = Value
        End Set
    End Property

    Public Property ColorForeInt() As Integer
        Get
            Return _colorForeInt
        End Get
        Set(ByVal Value As Integer)
            _colorForeInt = Value
        End Set
    End Property

    Public Property HalfSplit() As Boolean
        Get
            Return _halfSplit
        End Get
        Set(ByVal Value As Boolean)
            _halfSplit = Value
        End Set
    End Property

    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property


End Class
