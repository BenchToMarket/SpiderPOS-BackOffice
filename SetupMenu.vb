
Structure ActiveCategory
    Private _activeID As Integer
    Private _dataViewIndex As Integer
    Private _activeText As String
    Private _activeAbrevText As String
    Private _activeFunction As Integer
    Private _activeCategoryType As String
    Private _activeButton As Integer
    Private _activePosition As Integer
    Private _categoryIndexMore As Integer
    Private _categoryIndexModifier As Integer
    Private _categoryIsActive As Integer
    Private _updated As Boolean
    Private _halfSplit As Boolean
    '   Private _updatedModifier As Boolean
    Private _colorInt As Integer
    Private _colorForeInt As Integer
    Private _priority As Int16


    Friend Property ActiveID() As Integer
        Get
            Return _activeID
        End Get
        Set(ByVal Value As Integer)
            _activeID = Value
        End Set
    End Property

    Friend Property DataViewIndex() As Integer
        Get
            Return _dataViewIndex
        End Get
        Set(ByVal Value As Integer)
            _dataViewIndex = Value
        End Set
    End Property

    Friend Property ActiveText() As String
        Get
            Return _activeText
        End Get
        Set(ByVal Value As String)
            _activeText = Value
        End Set
    End Property

    Friend Property ActiveAbrevText() As String
        Get
            Return _activeAbrevText
        End Get
        Set(ByVal Value As String)
            _activeAbrevText = Value
        End Set
    End Property

    Friend Property ActiveFunction() As Integer
        Get
            Return _activeFunction
        End Get
        Set(ByVal Value As Integer)
            _activeFunction = Value
        End Set
    End Property

    Friend Property ActiveCategoryType() As String
        Get
            Return _activeCategoryType
        End Get
        Set(ByVal Value As String)
            _activeCategoryType = Value
        End Set
    End Property

    Friend Property ActiveButton() As Integer
        Get
            Return _activeButton
        End Get
        Set(ByVal Value As Integer)
            _activeButton = Value
        End Set
    End Property

    Friend Property ActivePosition() As Integer
        Get
            Return _activePosition
        End Get
        Set(ByVal Value As Integer)
            _activePosition = Value
        End Set
    End Property

    Friend Property CategoryIndexMore() As Integer
        Get
            Return _categoryIndexMore
        End Get
        Set(ByVal Value As Integer)
            _categoryIndexMore = Value
        End Set
    End Property

    Friend Property CategoryIndexModifier() As Integer
        Get
            Return _categoryIndexModifier
        End Get
        Set(ByVal Value As Integer)
            _categoryIndexModifier = Value
        End Set
    End Property

    Friend Property CategoryIsActive() As Boolean
        Get
            Return _categoryIsActive
        End Get
        Set(ByVal Value As Boolean)
            _categoryIsActive = Value
        End Set
    End Property

    Friend Property Updated() As Boolean
        Get
            Return _updated
        End Get
        Set(ByVal Value As Boolean)
            _updated = Value
        End Set
    End Property

    Friend Property HalfSplit() As Boolean
        Get
            Return _halfSplit
        End Get
        Set(ByVal Value As Boolean)
            _halfSplit = Value
        End Set
    End Property
    '    Friend Property UpdatedModifier() As Boolean
    '        Get
    '            Return _updatedModifier
    ''       End Get
    '       Set(ByVal Value As Boolean)
    '           _updatedModifier = Value
    '      End Set
    ' End Property

    Friend Property ColorInt() As Integer
        Get
            Return _colorInt
        End Get
        Set(ByVal Value As Integer)
            _colorInt = Value
        End Set
    End Property

    Friend Property ColorForeInt() As Integer
        Get
            Return _colorForeInt
        End Get
        Set(ByVal Value As Integer)
            _colorForeInt = Value
        End Set
    End Property

    Friend Property Priority() As Int16
        Get
            Return _priority
        End Get
        Set(ByVal Value As Int16)
            _priority = Value
        End Set
    End Property

End Structure

Structure ActiveMenu

    Private _activeMenuID As Integer
    Private _activeMenuName As String
    Private _activeMenuCategoryID As Integer
    Private _activeMenuDrinkCategoryID As Integer
    Private _activeMenuOrderIndex As Integer
    Private _activeDetailID As Integer
    '   Private _dRow As DataRow

    Friend Property ActiveMenuID() As Integer
        Get
            Return _activeMenuID
        End Get
        Set(ByVal Value As Integer)
            _activeMenuID = Value
        End Set
    End Property
    Friend Property ActiveMenuName() As String
        Get
            Return _activeMenuName
        End Get
        Set(ByVal Value As String)
            _activeMenuName = Value
        End Set
    End Property

    Friend Property ActiveMenuCategoryID() As Integer
        Get
            Return _activeMenuCategoryID
        End Get
        Set(ByVal Value As Integer)
            _activeMenuCategoryID = Value
        End Set
    End Property

    Friend Property ActiveMenuDrinkCategoryID() As Integer
        Get
            Return _activeMenuDrinkCategoryID
        End Get
        Set(ByVal Value As Integer)
            _activeMenuDrinkCategoryID = Value
        End Set
    End Property

    Friend Property ActiveMenuOrderIndex() As Integer
        Get
            Return _activeMenuOrderIndex
        End Get
        Set(ByVal Value As Integer)
            _activeMenuOrderIndex = Value
        End Set
    End Property

    Friend Property ActiveDetialID() As Integer
        Get
            Return _activeDetailID
        End Get
        Set(ByVal Value As Integer)
            _activeDetailID = Value
        End Set
    End Property
    '   Friend Property dRow() As DataRow
    '      Get
    '         Return _dRow
    '    End Get
    '   Set(ByVal Value As DataRow)
    '      _dRow = Value
    ' End Set
    ' End Property

End Structure

Structure ActiveFood

    Private _functionID As Integer
    Private _FoodRoutingID As Integer
    Private _foodRoutingName As String
    Private _PrintPriorityID As Integer
    Private _printPriorityName As String
    Private _FoodTaxID As Integer
    Private _foodTaxName As String
    Private _isMainFood As Boolean
    Private _activeFoodID As Integer
    Private _previousPosition As Integer
    Private _gotoPrevious As Boolean
    Private _menuCostChanged As Boolean


    Friend Property FunctionID() As Integer
        Get
            Return _functionID
        End Get
        Set(ByVal Value As Integer)
            _functionID = Value
        End Set
    End Property

    Friend Property IsMainFood() As Boolean
        Get
            Return _isMainFood
        End Get
        Set(ByVal Value As Boolean)
            _isMainFood = Value
        End Set
    End Property

    Friend Property FoodRoutingID() As Integer
        Get
            Return _FoodRoutingID
        End Get
        Set(ByVal Value As Integer)
            _FoodRoutingID = Value
        End Set
    End Property

    Friend Property FoodRoutingName() As String
        Get
            Return _foodRoutingName
        End Get
        Set(ByVal Value As String)
            _foodRoutingName = Value
        End Set
    End Property

    Friend Property PrintPriorityID() As Integer
        Get
            Return _PrintPriorityID
        End Get
        Set(ByVal Value As Integer)
            _PrintPriorityID = Value
        End Set
    End Property

    Friend Property PrintPriorityName() As String
        Get
            Return _printPriorityName
        End Get
        Set(ByVal Value As String)
            _printPriorityName = Value
        End Set
    End Property

    Friend Property FoodTaxID() As Integer
        Get
            Return _FoodTaxID
        End Get
        Set(ByVal Value As Integer)
            _FoodTaxID = Value
        End Set
    End Property

    Friend Property FoodTaxName() As String
        Get
            Return _foodTaxName
        End Get
        Set(ByVal Value As String)
            _foodTaxName = Value
        End Set
    End Property

    Friend Property ActiveFoodID() As Integer
        Get
            Return _activeFoodID
        End Get
        Set(ByVal Value As Integer)
            _activeFoodID = Value
        End Set
    End Property

    Friend Property PreviousPosition() As Integer
        Get
            Return _previousPosition
        End Get
        Set(ByVal Value As Integer)
            _previousPosition = Value
        End Set
    End Property

    Friend Property GotoPrevious() As Boolean
        Get
            Return _gotoPrevious
        End Get
        Set(ByVal Value As Boolean)
            _gotoPrevious = Value
        End Set
    End Property

    Friend Property MenuCostChanged() As Boolean
        Get
            Return _menuCostChanged
        End Get
        Set(ByVal Value As Boolean)
            _menuCostChanged = Value
        End Set
    End Property

End Structure

Structure ActiveModifier
    Private _activeModifierID As Integer
    Private _activeModifierName As String
    Private _activeAbrevText As String
    Private _activeModifierCategoryID As Integer
    Private _pageIndex As Integer
    Private _maxIndex As Integer
    Private _menuIndex As Integer
    Private _changesMade As Boolean
    Private _changingPanel As FoodPanelControl

    Private _activeModifierDesc As String


    Friend Property ActiveModifierID() As Integer
        Get
            Return _activeModifierID
        End Get
        Set(ByVal Value As Integer)
            _activeModifierID = Value
        End Set
    End Property

    Friend Property ActiveModifierName() As String
        Get
            Return _activeModifierName
        End Get
        Set(ByVal Value As String)
            _activeModifierName = Value
        End Set
    End Property

    Friend Property ActiveAbrevText() As String
        Get
            Return _activeAbrevText
        End Get
        Set(ByVal Value As String)
            _activeAbrevText = Value
        End Set
    End Property

    Friend Property PageIndex() As Integer
        Get
            Return _pageIndex
        End Get
        Set(ByVal Value As Integer)
            _pageIndex = Value
        End Set
    End Property

    Friend Property MaxIndex() As Integer
        Get
            Return _maxIndex
        End Get
        Set(ByVal Value As Integer)
            _maxIndex = Value
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

    Friend Property ChangesMade() As Boolean
        Get
            Return _changesMade
        End Get
        Set(ByVal Value As Boolean)
            _changesMade = Value
        End Set
    End Property

    Friend Property ChangingPanel() As FoodPanelControl
        Get
            Return _changingPanel
        End Get
        Set(ByVal Value As FoodPanelControl)
            _changingPanel = Value
        End Set
    End Property

    Friend Property ActiveModifierCategoryID() As Integer
        Get
            Return _activeModifierCategoryID
        End Get
        Set(ByVal Value As Integer)
            _activeModifierCategoryID = Value
        End Set
    End Property


End Structure

Structure ActiveFoodJoin

    Private _activeJoinFoodID As Integer
    Private _activeTempIndex As Integer
    Private _activeCategoryRow As Integer
    Private _activeModifierRow As Integer

    Friend Property ActiveJoinFoodID() As Integer
        Get
            Return _activeJoinFoodID
        End Get
        Set(ByVal Value As Integer)
            _activeJoinFoodID = Value
        End Set
    End Property

    Friend Property ActiveTempIndex() As Integer
        Get
            Return _activeTempIndex
        End Get
        Set(ByVal Value As Integer)
            _activeTempIndex = Value
        End Set
    End Property

    Friend Property ActiveCategoryRow() As Integer
        Get
            Return _activeCategoryRow
        End Get
        Set(ByVal Value As Integer)
            _activeCategoryRow = Value
        End Set
    End Property

    Friend Property ActiveModifierRow() As Integer
        Get
            Return _activeModifierRow
        End Get
        Set(ByVal Value As Integer)
            _activeModifierRow = Value
        End Set
    End Property


End Structure

Structure ActiveDrink

    Private _drinkName As String
    Private _drinkCategoryID As Integer
    Private _drinkCategoryIndex As Integer
    Private _drinkNameIndex As Integer
    Private _drinkNameID As Integer
    Private _dRowNumber As Integer
    Private _changesMade As Boolean
    Private _LiquorType As Integer
    Private _drinkFunctionID As Integer
    Private _drinkPrice As Decimal
    Private _drinkHappyPrice As Decimal
    Private _callPrice As Decimal
    Private _addOnPrice As Decimal
    Private _drinkDesc As String
    Private _drinkAddOnChoice As Boolean
    Private _isDrinkAdd As Boolean
    Private _isWineParring As Boolean

    Friend Property DrinkName() As String
        Get
            Return _drinkName
        End Get
        Set(ByVal Value As String)
            _drinkName = Value
        End Set
    End Property

    Friend Property DrinkCategoryID()
        Get
            Return _drinkCategoryID
        End Get
        Set(ByVal Value)
            _drinkCategoryID = Value
        End Set
    End Property

    Friend Property DrinkCategoryIndex()
        Get
            Return _drinkCategoryIndex
        End Get
        Set(ByVal Value)
            _drinkCategoryIndex = Value
        End Set
    End Property

    Friend Property DrinkNameIndex()
        Get
            Return _drinkNameIndex
        End Get
        Set(ByVal Value)
            _drinkNameIndex = Value
        End Set
    End Property

    Friend Property DrinkNameID()
        Get
            Return _drinkNameID
        End Get
        Set(ByVal Value)
            _drinkNameID = Value
        End Set
    End Property

    Friend Property dRowNumber() As Integer
        Get
            Return (_dRowNumber)
        End Get
        Set(ByVal Value As Integer)
            _dRowNumber = Value
        End Set
    End Property
    Friend Property ChangesMade() As Boolean
        Get
            Return _changesMade
        End Get
        Set(ByVal Value As Boolean)
            _changesMade = Value
        End Set
    End Property
    Friend Property LiquorType() As Integer
        Get
            Return _LiquorType
        End Get
        Set(ByVal Value As Integer)
            _LiquorType = Value
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

    Friend Property DrinkPrice() As Decimal
        Get
            Return _drinkPrice
        End Get
        Set(ByVal Value As Decimal)
            _drinkPrice = Value
        End Set
    End Property

    Friend Property DrinkHappyPrice() As Decimal
        Get
            Return _drinkHappyPrice
        End Get
        Set(ByVal value As Decimal)
            _drinkHappyPrice = value
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

    Friend Property IsWineParring() As Boolean
        Get
            Return _isWineParring
        End Get
        Set(ByVal Value As Boolean)
            _isWineParring = Value
        End Set
    End Property

End Structure

Structure ActiveFoodOrder
    Private _currentMenu As Integer
    Private _currentCategory As Integer
    Private _funFlag As String
    Private _catIsDrink As Boolean
    Private _currentCategorySub As Integer
    Private _funFlagSub As String
    Private _pageIndex As Integer
    '   Private _stagingIndex As Integer
    Private _maxIndex As Integer
    Private _morePanels As Integer
    Private _extendedDisplay As Boolean

    Friend Property CurrentMenu() As Integer
        Get
            Return _currentMenu
        End Get
        Set(ByVal Value As Integer)
            _currentMenu = Value
        End Set
    End Property

    Friend Property CurrentCategory() As Integer
        Get
            Return _currentCategory
        End Get
        Set(ByVal Value As Integer)
            _currentCategory = Value
        End Set
    End Property

    Friend Property FunFlag() As String
        Get
            Return _funFlag
        End Get
        Set(ByVal Value As String)
            _funFlag = Value
        End Set
    End Property

    Friend Property CatIsDrink() As Boolean
        Get
            Return _catIsDrink
        End Get
        Set(ByVal Value As Boolean)
            _catIsDrink = Value
        End Set
    End Property

    Friend Property CurrentCategorySub() As Integer
        Get
            Return _currentCategorySub
        End Get
        Set(ByVal Value As Integer)
            _currentCategorySub = Value
        End Set
    End Property

    Friend Property FunFlagsub() As String
        Get
            Return _funFlagSub
        End Get
        Set(ByVal Value As String)
            _funFlagSub = Value
        End Set
    End Property

    Friend Property PageIndex() As Integer
        Get
            Return _pageIndex
        End Get
        Set(ByVal Value As Integer)
            _pageIndex = Value
        End Set
    End Property

    '    Friend Property StagingIndex() As Integer
    '       Get
    '          Return _stagingIndex
    '     End Get
    '    Set(ByVal Value As Integer)
    '       _stagingIndex = Value
    '        End Set
    '   End Property

    Friend Property MaxIndex() As Integer
        Get
            Return _maxIndex
        End Get
        Set(ByVal Value As Integer)
            _maxIndex = Value
        End Set
    End Property

    Friend Property MorePanels() As Integer
        Get
            Return _morePanels
        End Get
        Set(ByVal Value As Integer)
            _morePanels = Value
        End Set
    End Property

    Friend Property ExtendedDisplay() As Boolean
        Get
            Return _extendedDisplay
        End Get
        Set(ByVal value As Boolean)
            _extendedDisplay = value
        End Set
    End Property

End Structure


Public Class SetupMenu
    Inherits System.Windows.Forms.UserControl
    Implements ICollection

    '   Friend sql As New DataSet_Builder.SQLHelper

    Dim btnMain(200) As OrderButton
    Dim btnModifier(20) As OrderButton
    Dim menuActive(10) As CustomCheckBox
    Dim menuCheckBox(10) As CheckBox
    Dim menuCostText(10) As TextBox
    Dim menuBoxUpdated As Boolean
    Dim MenuCostChanged As Boolean
    Dim menuSurchargeText(10) As TextBox
    Dim menuRouting(10) As ComboBox
    Dim WithEvents txtMenuUpdate As New TextBox
    Dim WithEvents btnMenuAdd As New Button
    Dim WithEvents ColorChoice As ButtonColor_UC
    Dim WithEvents ColorChoiceNew As ButtonColor_UC
    Dim WithEvents DrinkColorChoice As ButtonColor_UC

    Dim prepCheckBox(100) As CheckBox
    '   Dim prepNameText(100) As Label
    Dim prepMethod(100) As Label
    Dim prepPriceText(100) As TextBox
    Dim prepOrderByText(100) As TextBox
    Dim prepInvMultiplier(100) As TextBox
    Dim prepDrinkUpdated As Boolean

    '   Public Shared btnMainCollection As New ControlBindingsCollection

    '    Dim WithEvents btnMainMore As New Button
    '   Dim WithEvents btnModifierMore As New Button

    Dim btnCategory(32) As DrinkButton
    Dim btnCategory2(32) As DrinkButton
    Dim btnDrinks(60) As DrinkButton
    Dim addingNewDrinkTest As Boolean
    Dim drinkDisplaying As Boolean
    Dim currentDrinkPanel As FoodPanelControl
    Dim currentDrinkPanelLast As FoodPanelControl


    Dim btnMenu(20) As OrderButton

    Dim newCategory As New ActiveCategory
    Dim newMenu As New ActiveMenu
    Dim newFood As New ActiveFood
    Dim newModifier As New ActiveModifier
    Dim newFoodJoin As New ActiveFoodJoin
    Dim newDrink As ActiveDrink
    Dim oldDrink As ActiveDrink
    Dim newFoodOrder As New ActiveFoodOrder

    Dim newModifierChangesMade As Boolean
    Dim newDrinkChangesMade As Boolean
    Dim newFoodOrderStagingIndex As Integer 'Boolean

    Dim updatedMenu As Boolean
    Dim updatedMenuDetail As Boolean
    Dim updatedCategory As Boolean
    Dim updatedDrink As Boolean
    Dim currentDrinkCategoryID As Integer
    Dim updatedWPI As Boolean
    Dim updatedFoodJoin As Boolean
    Dim filledFirstFood As Boolean
    Dim isOrderQuickService As Boolean
    Dim justAdjustingPosition As Boolean

    Dim FoodCurrencyMan As CurrencyManager
    Dim ModifierCurrencyMan As CurrencyManager
    Dim JoinIndividualMan As CurrencyManager
    Dim mainCatCurrencyMan As CurrencyManager
    Dim globalJoinValueCategoryID As Integer

    '   Friend dvMainCategory As DataView = New DataView
    Friend dvActiveMenu As DataView = New DataView
    Friend dvMenuJoin As DataView = New DataView
    Friend dvModifiers As DataView = New DataView
    Friend dvModifiers2 As New DataView
    Friend dvMainFoodsCategory As DataView
    Friend dvModifierCategory As DataView '= New DataView
    Friend dvFoodJoinMainFoodsCagtegory As DataView
    Friend dvFoodJoinCategory As DataView

    Dim tsJoinIndividualModifiers As New DataGridTableStyle

    '   Friend dvFoods As New DataView
    '   Friend dvJoinFoodCategoryJoins As DataView
    '  Friend dvJoinFoodModifierJoins As DataView
    Dim bartnerderMenuMode As String
    Dim valueMenuID As Integer
    Dim valueMenuName As String
    Dim valueMenuActive As Boolean
    Dim generalDrinkCategoryID As Integer = -1
    Dim lastPrepMethod As String = "USdol"

    Friend dvCategory As New DataView
    Friend dvSubCategory As New DataView
    Friend dvDrinkCats As New DataView
    Friend dvOrderMenu As New DataView
    Friend dvOrderStaging As New DataView
    Friend dvModifierStaging As New DataView

    Dim foodMenuJoinID(65) As Integer
    Dim foodName(65) As String
    Dim foodPrice(65) As Decimal
    Dim foodIndex(65) As Integer
    Dim foodFoodID(65) As Integer
    Dim foodSurcharge(65) As Decimal
    Dim foodRoutingID(65) As Integer
    Dim foodDrinkID(65) As Integer
    Dim foodGeneralMenuID(65) As Integer
    Dim foodCurrentMenu(65) As Integer
    Dim foodBackColor(65) As Color
    Dim foodForeColor(65) As Color

    Dim modifierID(32) As Integer
    Dim modifierName(32) As String
    Dim modifierIndex(32) As Integer
    '    Dim modifierDataViewIndex(32) As Integer


    Dim WithEvents foodOrderPanel1 As FoodOrderPanel
    Dim WithEvents foodOrderPanel2 As FoodOrderPanel
    Dim WithEvents foodOrderPanel3 As FoodOrderPanel
    Dim WithEvents foodOrderPanel4 As FoodOrderPanel
    Dim WithEvents foodOrderPanel5 As FoodOrderPanel
    Dim WithEvents foodOrderPanel6 As FoodOrderPanel
    Dim WithEvents foodOrderPanel7 As FoodOrderPanel
    Dim WithEvents foodOrderPanel8 As FoodOrderPanel
    Dim WithEvents foodOrderPanel9 As FoodOrderPanel
    Dim WithEvents foodOrderPanel10 As FoodOrderPanel
    Dim WithEvents foodOrderPanel11 As FoodOrderPanel
    Dim WithEvents foodOrderPanel12 As FoodOrderPanel
    Dim WithEvents foodOrderPanel13 As FoodOrderPanel
    Dim WithEvents foodOrderPanel14 As FoodOrderPanel
    Dim WithEvents foodOrderPanel15 As FoodOrderPanel
    Dim WithEvents foodOrderPanel16 As FoodOrderPanel
    Dim WithEvents foodOrderPanel17 As FoodOrderPanel
    Dim WithEvents foodOrderPanel18 As FoodOrderPanel
    Dim WithEvents foodOrderPanel19 As FoodOrderPanel
    Dim WithEvents foodOrderPanel20 As FoodOrderPanel
    Dim WithEvents foodOrderPanel21 As FoodOrderPanel
    Dim WithEvents foodOrderPanel22 As FoodOrderPanel
    Dim WithEvents foodOrderPanel23 As FoodOrderPanel
    Dim WithEvents foodOrderPanel24 As FoodOrderPanel
    Dim WithEvents foodOrderPanel25 As FoodOrderPanel
    Dim WithEvents foodOrderPanel26 As FoodOrderPanel
    Dim WithEvents foodOrderPanel27 As FoodOrderPanel
    Dim WithEvents foodOrderPanel28 As FoodOrderPanel
    Dim WithEvents foodOrderPanel29 As FoodOrderPanel
    Dim WithEvents foodOrderPanel30 As FoodOrderPanel
    Dim WithEvents foodOrderPanel31 As FoodOrderPanel
    Dim WithEvents foodOrderPanel32 As FoodOrderPanel
    Dim WithEvents foodOrderPanel33 As FoodOrderPanel
    Dim WithEvents foodOrderPanel34 As FoodOrderPanel
    Dim WithEvents foodOrderPanel35 As FoodOrderPanel
    Dim WithEvents foodOrderPanel36 As FoodOrderPanel
    Dim WithEvents foodOrderPanel37 As FoodOrderPanel
    Dim WithEvents foodOrderPanel38 As FoodOrderPanel
    Dim WithEvents foodOrderPanel39 As FoodOrderPanel
    Dim WithEvents foodOrderPanel40 As FoodOrderPanel
    Dim WithEvents foodOrderPanel41 As FoodOrderPanel
    Dim WithEvents foodOrderPanel42 As FoodOrderPanel
    Dim WithEvents foodOrderPanel43 As FoodOrderPanel
    Dim WithEvents foodOrderPanel44 As FoodOrderPanel
    Dim WithEvents foodOrderPanel45 As FoodOrderPanel
    Dim WithEvents foodOrderPanel46 As FoodOrderPanel
    Dim WithEvents foodOrderPanel47 As FoodOrderPanel
    Dim WithEvents foodOrderPanel48 As FoodOrderPanel
    Dim WithEvents foodOrderPanel49 As FoodOrderPanel
    Dim WithEvents foodOrderPanel50 As FoodOrderPanel
    Dim WithEvents foodOrderPanel51 As FoodOrderPanel
    Dim WithEvents foodOrderPanel52 As FoodOrderPanel
    Dim WithEvents foodOrderPanel53 As FoodOrderPanel
    Dim WithEvents foodOrderPanel54 As FoodOrderPanel
    Dim WithEvents foodOrderPanel55 As FoodOrderPanel
    Dim WithEvents foodOrderPanel56 As FoodOrderPanel
    Dim WithEvents foodOrderPanel57 As FoodOrderPanel
    Dim WithEvents foodOrderPanel58 As FoodOrderPanel
    Dim WithEvents foodOrderPanel59 As FoodOrderPanel
    Dim WithEvents foodOrderPanel60 As FoodOrderPanel

    Dim WithEvents modifierOrderPanel1 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel2 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel3 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel4 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel5 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel6 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel7 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel8 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel9 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel10 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel11 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel12 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel13 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel14 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel15 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel16 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel17 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel18 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel19 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel20 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel21 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel22 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel23 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel24 As FoodOrderPanel
    Dim WithEvents modifierOrderPanel25 As FoodOrderPanel


    Dim WithEvents DrinkOrderPanel1 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel2 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel3 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel4 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel5 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel6 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel7 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel8 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel9 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel10 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel11 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel12 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel13 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel14 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel15 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel16 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel17 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel18 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel19 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel20 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel21 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel22 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel23 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel24 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel25 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel26 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel27 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel28 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel29 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel30 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel31 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel32 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel33 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel34 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel35 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel36 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel37 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel38 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel39 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel40 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel41 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel42 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel43 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel44 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel45 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel46 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel47 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel48 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel49 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel50 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel51 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel52 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel53 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel54 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel55 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel56 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel57 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel58 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel59 As FoodOrderPanel
    Dim WithEvents DrinkOrderPanel60 As FoodOrderPanel

    Dim WithEvents modifierOrderStaging1 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging2 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging3 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging4 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging5 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging6 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging7 As FoodOrderPanel
    Dim WithEvents modifierOrderStaging8 As FoodOrderPanel

    '   **** not using the following ten
    '    Dim WithEvents FoodOrderStaging1 As FoodOrderPanel
    '    Dim WithEvents FoodOrderStaging2 As FoodOrderPanel
    '    Dim WithEvents FoodOrderStaging3 As FoodOrderPanel
    '    Dim WithEvents FoodOrderStaging4 As FoodOrderPanel
    '   Dim WithEvents FoodOrderStaging5 As FoodOrderPanel
    '   Dim WithEvents FoodOrderStaging6 As FoodOrderPanel
    '   Dim WithEvents FoodOrderStaging7 As FoodOrderPanel
    '   Dim WithEvents FoodOrderStaging8 As FoodOrderPanel
    '   Dim WithEvents FoodOrderStaging9 As FoodOrderPanel
    '  Dim WithEvents FoodOrderStaging10 As FoodOrderPanel

    Dim WithEvents dummyPanel As Panel
    Friend WithEvents chkExtendedDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewExtendedDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents btnJoinReq As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtFoodInvMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents cbxFoodFilterModifiers As System.Windows.Forms.ComboBox
    Friend WithEvents pnlOrderPage As System.Windows.Forms.Panel
    Friend WithEvents pnlModifierPage As System.Windows.Forms.Panel
    Friend WithEvents chkNewDisplayWithAdds As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisplayWithAdd As System.Windows.Forms.CheckBox
    Friend WithEvents lblDrinkHappyPrice As System.Windows.Forms.Label
    Friend WithEvents txtDrinkHappyPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label

    Dim foodOrderStaging(10) As FoodOrderPanel
    '   Dim modifierOrderStaging(8) As FoodOrderPanel

    '    Dim stagingIndex As Integer = 0




#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents tabCategory As System.Windows.Forms.TabPage
    Friend WithEvents lblCategoryName As System.Windows.Forms.Label
    Friend WithEvents MainCategoryPanel As System.Windows.Forms.Panel
    Friend WithEvents lblCategoryAbrev As System.Windows.Forms.Label
    Friend WithEvents ModifierCategoryPanel As System.Windows.Forms.Panel
    Friend WithEvents TabModifiers As System.Windows.Forms.TabPage
    Friend WithEvents LblModDescLabel As System.Windows.Forms.Label
    Friend WithEvents lblSelectModifierFilter As System.Windows.Forms.Label
    Friend WithEvents cbxModifierFilter As System.Windows.Forms.ComboBox
    Friend WithEvents pnlUpdateModifiers As System.Windows.Forms.Panel
    Friend WithEvents btnRemoveModifier As System.Windows.Forms.Button
    Friend WithEvents txtModifierCost As System.Windows.Forms.TextBox
    Friend WithEvents txtModifierName As System.Windows.Forms.TextBox
    Friend WithEvents TabMainFood As System.Windows.Forms.TabPage
    Friend WithEvents btnEnterNewFood As System.Windows.Forms.Button
    Friend WithEvents menuCostGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents grdFoodList As System.Windows.Forms.DataGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRemoveFood As System.Windows.Forms.Button
    Friend WithEvents cbxFoodCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtFoodName As System.Windows.Forms.TextBox
    Friend WithEvents TabFoodJoin As System.Windows.Forms.TabPage
    Friend WithEvents grdJoinFoodModifierJoins As System.Windows.Forms.DataGrid
    Friend WithEvents grdJoinFoodChoice As System.Windows.Forms.DataGrid
    Friend WithEvents cbxJoinCategorySelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblJoinFoodSelected As System.Windows.Forms.Label
    Friend WithEvents grdJoinFoodCategoryJoins As System.Windows.Forms.DataGrid
    Friend WithEvents cbxJoinIndividualModifierSelect As System.Windows.Forms.ComboBox
    Friend WithEvents grdJoinIndividualModifiers As System.Windows.Forms.DataGrid
    Friend WithEvents grdJoinPossibleCategories As System.Windows.Forms.DataGrid
    Friend WithEvents lblSelectFoodFilter As System.Windows.Forms.Label
    Friend WithEvents btnShowAllFood As System.Windows.Forms.Button
    Friend WithEvents txtAbrevFoodName As System.Windows.Forms.TextBox
    Friend WithEvents txtChitFoodName As System.Windows.Forms.TextBox
    Friend WithEvents lblFoodName As System.Windows.Forms.Label
    Friend WithEvents cbxPrintPriority As System.Windows.Forms.ComboBox
    Friend WithEvents txtFoodCost As System.Windows.Forms.TextBox
    Friend WithEvents btnFoodRecipe As System.Windows.Forms.Button
    Friend WithEvents cbxFoodFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblAbrevFoodName As System.Windows.Forms.Label
    Friend WithEvents lblChitFoodName As System.Windows.Forms.Label
    Friend WithEvents lblSelectFoodCategory As System.Windows.Forms.Label
    Friend WithEvents lblPrintPriority As System.Windows.Forms.Label
    Friend WithEvents lblFoodCost As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabDrinkCategory As System.Windows.Forms.TabPage
    Friend WithEvents pnlDrinkCategory As System.Windows.Forms.Panel
    Friend WithEvents txtDrinkCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents btnDrinkCategoryName As System.Windows.Forms.Button
    Friend WithEvents TabDrinks As System.Windows.Forms.TabPage
    Friend WithEvents pnlDrinks As System.Windows.Forms.Panel
    Friend WithEvents pnlDrinkByCategory As System.Windows.Forms.Panel
    Friend WithEvents lblDrinkName As System.Windows.Forms.Label
    Friend WithEvents txtDrinkName As System.Windows.Forms.TextBox
    Friend WithEvents pnlDrinkUpdate As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteDrink As System.Windows.Forms.Button
    Friend WithEvents lblDrinkCost As System.Windows.Forms.Label
    Friend WithEvents lblDrinkDescLabel As System.Windows.Forms.Label
    Friend WithEvents chkIsAddOn As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectAddOn As System.Windows.Forms.CheckBox
    Friend WithEvents txtDrinkPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDrinkDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDrinkCategoryName As System.Windows.Forms.Label
    Friend WithEvents btnBackToCategory As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCallPrice As System.Windows.Forms.Label
    Friend WithEvents txtCallPrice As System.Windows.Forms.TextBox
    Friend WithEvents cbxLiquorType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCallLiquor As System.Windows.Forms.Label
    Friend WithEvents txtAddOnPrice As System.Windows.Forms.TextBox
    Friend WithEvents pnlIsLiquorType As System.Windows.Forms.Panel
    Friend WithEvents chkLiquorType As System.Windows.Forms.CheckBox
    Friend WithEvents lblIsLiquorType As System.Windows.Forms.Label
    Friend WithEvents TabMenuSetup As System.Windows.Forms.TabPage
    Friend WithEvents cbxMenuSelection As System.Windows.Forms.ComboBox
    Friend WithEvents pnlMenuPage1 As System.Windows.Forms.Panel
    Friend WithEvents pnlMenuPage2 As System.Windows.Forms.Panel
    Friend WithEvents cbxMenuMainFood As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMenuDrink As System.Windows.Forms.ComboBox
    Friend WithEvents lblMenuSelectButtonText As System.Windows.Forms.Label
    Friend WithEvents btnMenuGeneralDrink As System.Windows.Forms.Button
    Friend WithEvents menuActiveBox As System.Windows.Forms.GroupBox
    Friend WithEvents pnlMenuUpdate As System.Windows.Forms.Panel
    Friend WithEvents btnRemoveMenuChoices As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateMenuChoices As System.Windows.Forms.Button
    Friend WithEvents lblMenuPage1 As System.Windows.Forms.Label
    Friend WithEvents lblMenuPage2 As System.Windows.Forms.Label
    Friend WithEvents lstModifierJoin As System.Windows.Forms.ListBox
    Friend WithEvents pnlDrinkModifiers As System.Windows.Forms.Panel
    Friend WithEvents lblDrinkSplash As System.Windows.Forms.Label
    Friend WithEvents lblDrinkTall As System.Windows.Forms.Label
    Friend WithEvents lblDrinkUp As System.Windows.Forms.Label
    Friend WithEvents lblDrinkRocks As System.Windows.Forms.Label
    Friend WithEvents lblDrinkDouble As System.Windows.Forms.Label
    Friend WithEvents txtDrinkRocks As System.Windows.Forms.TextBox
    Friend WithEvents txtDrinkUp As System.Windows.Forms.TextBox
    Friend WithEvents txtDrinkTall As System.Windows.Forms.TextBox
    Friend WithEvents txtDrinkSplash As System.Windows.Forms.TextBox
    Friend WithEvents txtDrinkDouble As System.Windows.Forms.TextBox
    Friend WithEvents btnDrinkPrices As System.Windows.Forms.Button
    Friend WithEvents TabFoodOrder As System.Windows.Forms.TabPage
    Friend WithEvents cbxOrderMenuSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrderMenuName As System.Windows.Forms.Label
    Friend WithEvents pnlOrderFoodItems As System.Windows.Forms.Panel
    Friend WithEvents pnlOrderFoodStaging As System.Windows.Forms.Panel
    Friend WithEvents cbxOrderCategorySelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrderCategoryName As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnOrderUp As System.Windows.Forms.Button
    Friend WithEvents btnOrderDown As System.Windows.Forms.Button
    Friend WithEvents lblOrderDesc1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtModifierAbrev As System.Windows.Forms.TextBox
    Friend WithEvents txtModifierChit As System.Windows.Forms.TextBox
    Friend WithEvents cbxModifierRouting As System.Windows.Forms.ComboBox
    Friend WithEvents txtModifierSurcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblModifierAbrev As System.Windows.Forms.Label
    Friend WithEvents lblModifierChit As System.Windows.Forms.Label
    Friend WithEvents lblModifierSurcharge As System.Windows.Forms.Label
    Friend WithEvents lblModifierRouting As System.Windows.Forms.Label
    Friend WithEvents pnlModifierItems As System.Windows.Forms.Panel
    Friend WithEvents pnlOrderModifierStaging As System.Windows.Forms.Panel
    Friend WithEvents btnModifierAddPage As System.Windows.Forms.Button
    Friend WithEvents btnJoinFoodRemoveCategory As System.Windows.Forms.Button
    Friend WithEvents btnJoinFoodRemoveIndividual As System.Windows.Forms.Button
    Friend WithEvents lblCategoryMain As System.Windows.Forms.Label
    Friend WithEvents lblCategoryModifiers As System.Windows.Forms.Label
    Friend WithEvents btnMainPrevious As System.Windows.Forms.Button
    Friend WithEvents btnModifierPrevious As System.Windows.Forms.Button
    Friend WithEvents btnMainMore As System.Windows.Forms.Button
    Friend WithEvents btnModifierMore As System.Windows.Forms.Button
    Friend WithEvents btnFoodJoinLink As System.Windows.Forms.Button
    Friend WithEvents lblMenuSetup As System.Windows.Forms.Label
    Friend WithEvents btnModifierRemovePage As System.Windows.Forms.Button
    Friend WithEvents btnOrderAdd As System.Windows.Forms.Button
    Friend WithEvents btnOrderRemove As System.Windows.Forms.Button
    Friend WithEvents btnOrderUpdateStaging As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkWineParring As System.Windows.Forms.CheckBox
    Friend WithEvents cbxWineParring As System.Windows.Forms.ComboBox
    Friend WithEvents lblWineParring As System.Windows.Forms.Label
    Friend WithEvents btnMenuBartender As System.Windows.Forms.Button
    Friend WithEvents cbxDrinkFunction As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRecipe As System.Windows.Forms.TextBox
    Friend WithEvents btnJoinFree As System.Windows.Forms.Button
    Friend WithEvents txtModifierDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnJoinGroup As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnJoinGTC As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cbxCategoryFunction As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCategroyPriority As System.Windows.Forms.ComboBox
    Friend WithEvents chkCategoryActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnCategoryColor As System.Windows.Forms.Button
    Friend WithEvents cbxOrderSubCategroy As System.Windows.Forms.ComboBox
    Friend WithEvents btnDrinkCategoryColor As System.Windows.Forms.Button
    Friend WithEvents chkHalfSplit As System.Windows.Forms.CheckBox
    Friend WithEvents pnlNewFood As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNewChitFoodName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewAbrevFoodName As System.Windows.Forms.TextBox
    Friend WithEvents cbxNewFoodCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewFoodName As System.Windows.Forms.TextBox
    Friend WithEvents btnNewFoodAccept As System.Windows.Forms.Button
    Friend WithEvents btnNewFoodCancel As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNewFoodPrepare As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnNewCategoryAccept As System.Windows.Forms.Button
    Friend WithEvents btnNewCategoryCancel As System.Windows.Forms.Button
    Friend WithEvents txtCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoryAbrev As System.Windows.Forms.TextBox
    Friend WithEvents pnlNewCategory As System.Windows.Forms.Panel
    Friend WithEvents chkNewHalfSplit As System.Windows.Forms.CheckBox
    Friend WithEvents btnNewCategoryColor As System.Windows.Forms.Button
    Friend WithEvents cbxNewCategroyPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cbxNewCategoryFunction As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewCategoryAbrev As System.Windows.Forms.TextBox
    Friend WithEvents txtNewCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNewModifierSurcharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNewModifierChit As System.Windows.Forms.TextBox
    Friend WithEvents txtNewModifierAbrev As System.Windows.Forms.TextBox
    Friend WithEvents txtNewModifierName As System.Windows.Forms.TextBox
    Friend WithEvents cbxNewModifierRouting As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewModifierDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtNewModifierCost As System.Windows.Forms.TextBox
    Friend WithEvents btnAcceptModifier As System.Windows.Forms.Button
    Friend WithEvents btnCancelModifier As System.Windows.Forms.Button
    Friend WithEvents pnlNewModifier As System.Windows.Forms.Panel
    Friend WithEvents btnModCancelNew As System.Windows.Forms.Button
    Friend WithEvents chkManual As System.Windows.Forms.CheckBox
    Friend WithEvents TabDrinkPrep As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tabCategory = New System.Windows.Forms.TabPage
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.pnlNewCategory = New System.Windows.Forms.Panel
        Me.chkNewDisplayWithAdds = New System.Windows.Forms.CheckBox
        Me.chkNewExtendedDisplay = New System.Windows.Forms.CheckBox
        Me.btnNewCategoryCancel = New System.Windows.Forms.Button
        Me.btnNewCategoryAccept = New System.Windows.Forms.Button
        Me.chkNewHalfSplit = New System.Windows.Forms.CheckBox
        Me.btnNewCategoryColor = New System.Windows.Forms.Button
        Me.cbxNewCategroyPriority = New System.Windows.Forms.ComboBox
        Me.cbxNewCategoryFunction = New System.Windows.Forms.ComboBox
        Me.txtNewCategoryAbrev = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNewCategoryName = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.chkDisplayWithAdd = New System.Windows.Forms.CheckBox
        Me.chkExtendedDisplay = New System.Windows.Forms.CheckBox
        Me.chkHalfSplit = New System.Windows.Forms.CheckBox
        Me.btnCategoryColor = New System.Windows.Forms.Button
        Me.chkCategoryActive = New System.Windows.Forms.CheckBox
        Me.cbxCategroyPriority = New System.Windows.Forms.ComboBox
        Me.cbxCategoryFunction = New System.Windows.Forms.ComboBox
        Me.txtCategoryAbrev = New System.Windows.Forms.TextBox
        Me.lblCategoryAbrev = New System.Windows.Forms.Label
        Me.lblCategoryName = New System.Windows.Forms.Label
        Me.txtCategoryName = New System.Windows.Forms.TextBox
        Me.btnModifierMore = New System.Windows.Forms.Button
        Me.btnMainMore = New System.Windows.Forms.Button
        Me.btnModifierPrevious = New System.Windows.Forms.Button
        Me.btnMainPrevious = New System.Windows.Forms.Button
        Me.lblCategoryModifiers = New System.Windows.Forms.Label
        Me.lblCategoryMain = New System.Windows.Forms.Label
        Me.MainCategoryPanel = New System.Windows.Forms.Panel
        Me.ModifierCategoryPanel = New System.Windows.Forms.Panel
        Me.TabModifiers = New System.Windows.Forms.TabPage
        Me.pnlModifierPage = New System.Windows.Forms.Panel
        Me.btnModifierAddPage = New System.Windows.Forms.Button
        Me.btnModifierRemovePage = New System.Windows.Forms.Button
        Me.pnlNewModifier = New System.Windows.Forms.Panel
        Me.btnCancelModifier = New System.Windows.Forms.Button
        Me.btnAcceptModifier = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtNewModifierSurcharge = New System.Windows.Forms.TextBox
        Me.txtNewModifierChit = New System.Windows.Forms.TextBox
        Me.txtNewModifierAbrev = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtNewModifierName = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbxNewModifierRouting = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtNewModifierDescription = New System.Windows.Forms.TextBox
        Me.txtNewModifierCost = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnModCancelNew = New System.Windows.Forms.Button
        Me.lblModifierSurcharge = New System.Windows.Forms.Label
        Me.lblModifierChit = New System.Windows.Forms.Label
        Me.lblModifierAbrev = New System.Windows.Forms.Label
        Me.txtModifierSurcharge = New System.Windows.Forms.TextBox
        Me.txtModifierChit = New System.Windows.Forms.TextBox
        Me.txtModifierAbrev = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSelectModifierFilter = New System.Windows.Forms.Label
        Me.txtModifierName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbxModifierRouting = New System.Windows.Forms.ComboBox
        Me.LblModDescLabel = New System.Windows.Forms.Label
        Me.txtModifierDescription = New System.Windows.Forms.TextBox
        Me.txtModifierCost = New System.Windows.Forms.TextBox
        Me.lblModifierRouting = New System.Windows.Forms.Label
        Me.pnlOrderModifierStaging = New System.Windows.Forms.Panel
        Me.pnlModifierItems = New System.Windows.Forms.Panel
        Me.cbxModifierFilter = New System.Windows.Forms.ComboBox
        Me.pnlUpdateModifiers = New System.Windows.Forms.Panel
        Me.btnRemoveModifier = New System.Windows.Forms.Button
        Me.TabMainFood = New System.Windows.Forms.TabPage
        Me.cbxFoodFilterModifiers = New System.Windows.Forms.ComboBox
        Me.btnFoodRecipe = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtFoodInvMultiplier = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtFoodCost = New System.Windows.Forms.TextBox
        Me.lblFoodCost = New System.Windows.Forms.Label
        Me.chkManual = New System.Windows.Forms.CheckBox
        Me.pnlNewFood = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNewFoodPrepare = New System.Windows.Forms.TextBox
        Me.btnNewFoodCancel = New System.Windows.Forms.Button
        Me.btnNewFoodAccept = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNewChitFoodName = New System.Windows.Forms.TextBox
        Me.txtNewAbrevFoodName = New System.Windows.Forms.TextBox
        Me.cbxNewFoodCategory = New System.Windows.Forms.ComboBox
        Me.txtNewFoodName = New System.Windows.Forms.TextBox
        Me.txtRecipe = New System.Windows.Forms.TextBox
        Me.lblWineParring = New System.Windows.Forms.Label
        Me.cbxWineParring = New System.Windows.Forms.ComboBox
        Me.lstModifierJoin = New System.Windows.Forms.ListBox
        Me.lblPrintPriority = New System.Windows.Forms.Label
        Me.lblSelectFoodCategory = New System.Windows.Forms.Label
        Me.lblChitFoodName = New System.Windows.Forms.Label
        Me.lblAbrevFoodName = New System.Windows.Forms.Label
        Me.cbxPrintPriority = New System.Windows.Forms.ComboBox
        Me.lblFoodName = New System.Windows.Forms.Label
        Me.txtChitFoodName = New System.Windows.Forms.TextBox
        Me.txtAbrevFoodName = New System.Windows.Forms.TextBox
        Me.btnShowAllFood = New System.Windows.Forms.Button
        Me.cbxFoodFilter = New System.Windows.Forms.ComboBox
        Me.lblSelectFoodFilter = New System.Windows.Forms.Label
        Me.btnFoodJoinLink = New System.Windows.Forms.Button
        Me.btnEnterNewFood = New System.Windows.Forms.Button
        Me.menuCostGroupBox = New System.Windows.Forms.GroupBox
        Me.grdFoodList = New System.Windows.Forms.DataGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnRemoveFood = New System.Windows.Forms.Button
        Me.cbxFoodCategory = New System.Windows.Forms.ComboBox
        Me.txtFoodName = New System.Windows.Forms.TextBox
        Me.TabFoodJoin = New System.Windows.Forms.TabPage
        Me.btnJoinReq = New System.Windows.Forms.Button
        Me.btnJoinGTC = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnJoinGroup = New System.Windows.Forms.Button
        Me.btnJoinFoodRemoveIndividual = New System.Windows.Forms.Button
        Me.btnJoinFoodRemoveCategory = New System.Windows.Forms.Button
        Me.grdJoinFoodModifierJoins = New System.Windows.Forms.DataGrid
        Me.btnJoinFree = New System.Windows.Forms.Button
        Me.grdJoinFoodChoice = New System.Windows.Forms.DataGrid
        Me.cbxJoinCategorySelect = New System.Windows.Forms.ComboBox
        Me.lblJoinFoodSelected = New System.Windows.Forms.Label
        Me.grdJoinFoodCategoryJoins = New System.Windows.Forms.DataGrid
        Me.cbxJoinIndividualModifierSelect = New System.Windows.Forms.ComboBox
        Me.grdJoinIndividualModifiers = New System.Windows.Forms.DataGrid
        Me.grdJoinPossibleCategories = New System.Windows.Forms.DataGrid
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabDrinkCategory = New System.Windows.Forms.TabPage
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnDrinkCategoryColor = New System.Windows.Forms.Button
        Me.pnlDrinkModifiers = New System.Windows.Forms.Panel
        Me.btnDrinkPrices = New System.Windows.Forms.Button
        Me.txtDrinkSplash = New System.Windows.Forms.TextBox
        Me.txtDrinkTall = New System.Windows.Forms.TextBox
        Me.txtDrinkUp = New System.Windows.Forms.TextBox
        Me.txtDrinkRocks = New System.Windows.Forms.TextBox
        Me.txtDrinkDouble = New System.Windows.Forms.TextBox
        Me.lblDrinkSplash = New System.Windows.Forms.Label
        Me.lblDrinkTall = New System.Windows.Forms.Label
        Me.lblDrinkUp = New System.Windows.Forms.Label
        Me.lblDrinkRocks = New System.Windows.Forms.Label
        Me.lblDrinkDouble = New System.Windows.Forms.Label
        Me.pnlIsLiquorType = New System.Windows.Forms.Panel
        Me.lblIsLiquorType = New System.Windows.Forms.Label
        Me.chkLiquorType = New System.Windows.Forms.CheckBox
        Me.lblDrinkCategoryName = New System.Windows.Forms.Label
        Me.btnDrinkCategoryName = New System.Windows.Forms.Button
        Me.txtDrinkCategoryName = New System.Windows.Forms.TextBox
        Me.pnlDrinkCategory = New System.Windows.Forms.Panel
        Me.TabDrinks = New System.Windows.Forms.TabPage
        Me.lblDrinkHappyPrice = New System.Windows.Forms.Label
        Me.txtDrinkHappyPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbxDrinkFunction = New System.Windows.Forms.ComboBox
        Me.chkWineParring = New System.Windows.Forms.CheckBox
        Me.txtAddOnPrice = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblCallLiquor = New System.Windows.Forms.Label
        Me.cbxLiquorType = New System.Windows.Forms.ComboBox
        Me.txtCallPrice = New System.Windows.Forms.TextBox
        Me.lblCallPrice = New System.Windows.Forms.Label
        Me.btnBackToCategory = New System.Windows.Forms.Button
        Me.txtDrinkDesc = New System.Windows.Forms.RichTextBox
        Me.chkIsAddOn = New System.Windows.Forms.CheckBox
        Me.chkSelectAddOn = New System.Windows.Forms.CheckBox
        Me.lblDrinkDescLabel = New System.Windows.Forms.Label
        Me.lblDrinkCost = New System.Windows.Forms.Label
        Me.txtDrinkPrice = New System.Windows.Forms.TextBox
        Me.txtDrinkName = New System.Windows.Forms.TextBox
        Me.lblDrinkName = New System.Windows.Forms.Label
        Me.pnlDrinks = New System.Windows.Forms.Panel
        Me.pnlDrinkByCategory = New System.Windows.Forms.Panel
        Me.TabDrinkPrep = New System.Windows.Forms.TabPage
        Me.Label25 = New System.Windows.Forms.Label
        Me.TabMenuSetup = New System.Windows.Forms.TabPage
        Me.btnMenuBartender = New System.Windows.Forms.Button
        Me.lblMenuSetup = New System.Windows.Forms.Label
        Me.lblMenuPage2 = New System.Windows.Forms.Label
        Me.lblMenuPage1 = New System.Windows.Forms.Label
        Me.pnlMenuUpdate = New System.Windows.Forms.Panel
        Me.btnRemoveMenuChoices = New System.Windows.Forms.Button
        Me.BtnUpdateMenuChoices = New System.Windows.Forms.Button
        Me.menuActiveBox = New System.Windows.Forms.GroupBox
        Me.btnMenuGeneralDrink = New System.Windows.Forms.Button
        Me.lblMenuSelectButtonText = New System.Windows.Forms.Label
        Me.cbxMenuDrink = New System.Windows.Forms.ComboBox
        Me.cbxMenuMainFood = New System.Windows.Forms.ComboBox
        Me.pnlMenuPage2 = New System.Windows.Forms.Panel
        Me.pnlMenuPage1 = New System.Windows.Forms.Panel
        Me.cbxMenuSelection = New System.Windows.Forms.ComboBox
        Me.TabFoodOrder = New System.Windows.Forms.TabPage
        Me.pnlOrderPage = New System.Windows.Forms.Panel
        Me.btnOrderAdd = New System.Windows.Forms.Button
        Me.btnOrderRemove = New System.Windows.Forms.Button
        Me.cbxOrderSubCategroy = New System.Windows.Forms.ComboBox
        Me.lblOrderDesc1 = New System.Windows.Forms.Label
        Me.btnOrderDown = New System.Windows.Forms.Button
        Me.btnOrderUp = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnOrderUpdateStaging = New System.Windows.Forms.Button
        Me.lblOrderCategoryName = New System.Windows.Forms.Label
        Me.cbxOrderCategorySelection = New System.Windows.Forms.ComboBox
        Me.pnlOrderFoodStaging = New System.Windows.Forms.Panel
        Me.pnlOrderFoodItems = New System.Windows.Forms.Panel
        Me.lblOrderMenuName = New System.Windows.Forms.Label
        Me.cbxOrderMenuSelection = New System.Windows.Forms.ComboBox
        Me.pnlDrinkUpdate = New System.Windows.Forms.Panel
        Me.btnDeleteDrink = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tabCategory.SuspendLayout()
        Me.pnlNewCategory.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabModifiers.SuspendLayout()
        Me.pnlModifierPage.SuspendLayout()
        Me.pnlNewModifier.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnlUpdateModifiers.SuspendLayout()
        Me.TabMainFood.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNewFood.SuspendLayout()
        CType(Me.grdFoodList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabFoodJoin.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grdJoinFoodModifierJoins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdJoinFoodChoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdJoinFoodCategoryJoins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdJoinIndividualModifiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdJoinPossibleCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabDrinkCategory.SuspendLayout()
        Me.pnlDrinkModifiers.SuspendLayout()
        Me.pnlIsLiquorType.SuspendLayout()
        Me.TabDrinks.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabDrinkPrep.SuspendLayout()
        Me.TabMenuSetup.SuspendLayout()
        Me.pnlMenuUpdate.SuspendLayout()
        Me.TabFoodOrder.SuspendLayout()
        Me.pnlOrderPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlDrinkUpdate.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCategory
        '
        Me.tabCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.tabCategory.Controls.Add(Me.Label29)
        Me.tabCategory.Controls.Add(Me.Label28)
        Me.tabCategory.Controls.Add(Me.pnlNewCategory)
        Me.tabCategory.Controls.Add(Me.Panel6)
        Me.tabCategory.Controls.Add(Me.btnModifierMore)
        Me.tabCategory.Controls.Add(Me.btnMainMore)
        Me.tabCategory.Controls.Add(Me.btnModifierPrevious)
        Me.tabCategory.Controls.Add(Me.btnMainPrevious)
        Me.tabCategory.Controls.Add(Me.lblCategoryModifiers)
        Me.tabCategory.Controls.Add(Me.lblCategoryMain)
        Me.tabCategory.Controls.Add(Me.MainCategoryPanel)
        Me.tabCategory.Controls.Add(Me.ModifierCategoryPanel)
        Me.tabCategory.Location = New System.Drawing.Point(4, 22)
        Me.tabCategory.Name = "tabCategory"
        Me.tabCategory.Size = New System.Drawing.Size(840, 550)
        Me.tabCategory.TabIndex = 0
        Me.tabCategory.Text = "Category"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(517, 50)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(157, 70)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "Only place items that are the same for every menu and will never have a modifier " & _
            "to them. For example temperature and kitchen commands."
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(333, 51)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(140, 44)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "General Menu is a Shell Category. Main Food Items is to distinguish Covers."
        '
        'pnlNewCategory
        '
        Me.pnlNewCategory.BackColor = System.Drawing.Color.Moccasin
        Me.pnlNewCategory.Controls.Add(Me.chkNewDisplayWithAdds)
        Me.pnlNewCategory.Controls.Add(Me.chkNewExtendedDisplay)
        Me.pnlNewCategory.Controls.Add(Me.btnNewCategoryCancel)
        Me.pnlNewCategory.Controls.Add(Me.btnNewCategoryAccept)
        Me.pnlNewCategory.Controls.Add(Me.chkNewHalfSplit)
        Me.pnlNewCategory.Controls.Add(Me.btnNewCategoryColor)
        Me.pnlNewCategory.Controls.Add(Me.cbxNewCategroyPriority)
        Me.pnlNewCategory.Controls.Add(Me.cbxNewCategoryFunction)
        Me.pnlNewCategory.Controls.Add(Me.txtNewCategoryAbrev)
        Me.pnlNewCategory.Controls.Add(Me.Label15)
        Me.pnlNewCategory.Controls.Add(Me.Label16)
        Me.pnlNewCategory.Controls.Add(Me.txtNewCategoryName)
        Me.pnlNewCategory.Location = New System.Drawing.Point(654, 134)
        Me.pnlNewCategory.Name = "pnlNewCategory"
        Me.pnlNewCategory.Size = New System.Drawing.Size(256, 344)
        Me.pnlNewCategory.TabIndex = 27
        Me.pnlNewCategory.Visible = False
        '
        'chkNewDisplayWithAdds
        '
        Me.chkNewDisplayWithAdds.Location = New System.Drawing.Point(16, 258)
        Me.chkNewDisplayWithAdds.Name = "chkNewDisplayWithAdds"
        Me.chkNewDisplayWithAdds.Size = New System.Drawing.Size(133, 24)
        Me.chkNewDisplayWithAdds.TabIndex = 34
        Me.chkNewDisplayWithAdds.Text = "Display With Add / No"
        '
        'chkNewExtendedDisplay
        '
        Me.chkNewExtendedDisplay.Location = New System.Drawing.Point(16, 230)
        Me.chkNewExtendedDisplay.Name = "chkNewExtendedDisplay"
        Me.chkNewExtendedDisplay.Size = New System.Drawing.Size(104, 24)
        Me.chkNewExtendedDisplay.TabIndex = 33
        Me.chkNewExtendedDisplay.Text = "Extended Display"
        '
        'btnNewCategoryCancel
        '
        Me.btnNewCategoryCancel.Location = New System.Drawing.Point(144, 288)
        Me.btnNewCategoryCancel.Name = "btnNewCategoryCancel"
        Me.btnNewCategoryCancel.Size = New System.Drawing.Size(80, 40)
        Me.btnNewCategoryCancel.TabIndex = 32
        Me.btnNewCategoryCancel.Text = "Cancel"
        '
        'btnNewCategoryAccept
        '
        Me.btnNewCategoryAccept.Location = New System.Drawing.Point(32, 288)
        Me.btnNewCategoryAccept.Name = "btnNewCategoryAccept"
        Me.btnNewCategoryAccept.Size = New System.Drawing.Size(80, 40)
        Me.btnNewCategoryAccept.TabIndex = 31
        Me.btnNewCategoryAccept.Text = "New Category"
        '
        'chkNewHalfSplit
        '
        Me.chkNewHalfSplit.Location = New System.Drawing.Point(16, 200)
        Me.chkNewHalfSplit.Name = "chkNewHalfSplit"
        Me.chkNewHalfSplit.Size = New System.Drawing.Size(104, 24)
        Me.chkNewHalfSplit.TabIndex = 30
        Me.chkNewHalfSplit.Text = "Half Splits"
        '
        'btnNewCategoryColor
        '
        Me.btnNewCategoryColor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNewCategoryColor.Location = New System.Drawing.Point(144, 192)
        Me.btnNewCategoryColor.Name = "btnNewCategoryColor"
        Me.btnNewCategoryColor.Size = New System.Drawing.Size(88, 32)
        Me.btnNewCategoryColor.TabIndex = 29
        Me.btnNewCategoryColor.Text = "Button Color"
        Me.btnNewCategoryColor.UseVisualStyleBackColor = False
        '
        'cbxNewCategroyPriority
        '
        Me.cbxNewCategroyPriority.Location = New System.Drawing.Point(16, 160)
        Me.cbxNewCategroyPriority.Name = "cbxNewCategroyPriority"
        Me.cbxNewCategroyPriority.Size = New System.Drawing.Size(121, 21)
        Me.cbxNewCategroyPriority.TabIndex = 27
        '
        'cbxNewCategoryFunction
        '
        Me.cbxNewCategoryFunction.Location = New System.Drawing.Point(16, 120)
        Me.cbxNewCategoryFunction.Name = "cbxNewCategoryFunction"
        Me.cbxNewCategoryFunction.Size = New System.Drawing.Size(208, 21)
        Me.cbxNewCategoryFunction.TabIndex = 26
        '
        'txtNewCategoryAbrev
        '
        Me.txtNewCategoryAbrev.Location = New System.Drawing.Point(16, 72)
        Me.txtNewCategoryAbrev.Name = "txtNewCategoryAbrev"
        Me.txtNewCategoryAbrev.Size = New System.Drawing.Size(208, 20)
        Me.txtNewCategoryAbrev.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(216, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Category Abreviation"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Category Name"
        '
        'txtNewCategoryName
        '
        Me.txtNewCategoryName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNewCategoryName.Location = New System.Drawing.Point(16, 24)
        Me.txtNewCategoryName.Name = "txtNewCategoryName"
        Me.txtNewCategoryName.Size = New System.Drawing.Size(208, 20)
        Me.txtNewCategoryName.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Moccasin
        Me.Panel6.Controls.Add(Me.chkDisplayWithAdd)
        Me.Panel6.Controls.Add(Me.chkExtendedDisplay)
        Me.Panel6.Controls.Add(Me.chkHalfSplit)
        Me.Panel6.Controls.Add(Me.btnCategoryColor)
        Me.Panel6.Controls.Add(Me.chkCategoryActive)
        Me.Panel6.Controls.Add(Me.cbxCategroyPriority)
        Me.Panel6.Controls.Add(Me.cbxCategoryFunction)
        Me.Panel6.Controls.Add(Me.txtCategoryAbrev)
        Me.Panel6.Controls.Add(Me.lblCategoryAbrev)
        Me.Panel6.Controls.Add(Me.lblCategoryName)
        Me.Panel6.Controls.Add(Me.txtCategoryName)
        Me.Panel6.Location = New System.Drawing.Point(32, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(256, 344)
        Me.Panel6.TabIndex = 26
        '
        'chkDisplayWithAdd
        '
        Me.chkDisplayWithAdd.Location = New System.Drawing.Point(16, 294)
        Me.chkDisplayWithAdd.Name = "chkDisplayWithAdd"
        Me.chkDisplayWithAdd.Size = New System.Drawing.Size(133, 24)
        Me.chkDisplayWithAdd.TabIndex = 32
        Me.chkDisplayWithAdd.Text = "Display With Add / No"
        '
        'chkExtendedDisplay
        '
        Me.chkExtendedDisplay.Location = New System.Drawing.Point(16, 262)
        Me.chkExtendedDisplay.Name = "chkExtendedDisplay"
        Me.chkExtendedDisplay.Size = New System.Drawing.Size(133, 24)
        Me.chkExtendedDisplay.TabIndex = 31
        Me.chkExtendedDisplay.Text = "Extended Display"
        '
        'chkHalfSplit
        '
        Me.chkHalfSplit.Location = New System.Drawing.Point(16, 200)
        Me.chkHalfSplit.Name = "chkHalfSplit"
        Me.chkHalfSplit.Size = New System.Drawing.Size(104, 24)
        Me.chkHalfSplit.TabIndex = 30
        Me.chkHalfSplit.Text = "Half Splits"
        '
        'btnCategoryColor
        '
        Me.btnCategoryColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCategoryColor.ForeColor = System.Drawing.Color.White
        Me.btnCategoryColor.Location = New System.Drawing.Point(144, 192)
        Me.btnCategoryColor.Name = "btnCategoryColor"
        Me.btnCategoryColor.Size = New System.Drawing.Size(88, 32)
        Me.btnCategoryColor.TabIndex = 29
        Me.btnCategoryColor.Text = "Button Color"
        Me.btnCategoryColor.UseVisualStyleBackColor = False
        '
        'chkCategoryActive
        '
        Me.chkCategoryActive.Location = New System.Drawing.Point(16, 232)
        Me.chkCategoryActive.Name = "chkCategoryActive"
        Me.chkCategoryActive.Size = New System.Drawing.Size(104, 24)
        Me.chkCategoryActive.TabIndex = 28
        Me.chkCategoryActive.Text = "Active"
        '
        'cbxCategroyPriority
        '
        Me.cbxCategroyPriority.Location = New System.Drawing.Point(16, 160)
        Me.cbxCategroyPriority.Name = "cbxCategroyPriority"
        Me.cbxCategroyPriority.Size = New System.Drawing.Size(121, 21)
        Me.cbxCategroyPriority.TabIndex = 27
        '
        'cbxCategoryFunction
        '
        Me.cbxCategoryFunction.Location = New System.Drawing.Point(16, 120)
        Me.cbxCategoryFunction.Name = "cbxCategoryFunction"
        Me.cbxCategoryFunction.Size = New System.Drawing.Size(208, 21)
        Me.cbxCategoryFunction.TabIndex = 26
        '
        'txtCategoryAbrev
        '
        Me.txtCategoryAbrev.Location = New System.Drawing.Point(16, 72)
        Me.txtCategoryAbrev.Name = "txtCategoryAbrev"
        Me.txtCategoryAbrev.Size = New System.Drawing.Size(208, 20)
        Me.txtCategoryAbrev.TabIndex = 1
        '
        'lblCategoryAbrev
        '
        Me.lblCategoryAbrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryAbrev.Location = New System.Drawing.Point(8, 56)
        Me.lblCategoryAbrev.Name = "lblCategoryAbrev"
        Me.lblCategoryAbrev.Size = New System.Drawing.Size(216, 16)
        Me.lblCategoryAbrev.TabIndex = 9
        Me.lblCategoryAbrev.Text = "Category Abreviation"
        '
        'lblCategoryName
        '
        Me.lblCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryName.Location = New System.Drawing.Point(8, 8)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(208, 16)
        Me.lblCategoryName.TabIndex = 8
        Me.lblCategoryName.Text = "Category Name"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCategoryName.Location = New System.Drawing.Point(16, 24)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(208, 20)
        Me.txtCategoryName.TabIndex = 0
        '
        'btnModifierMore
        '
        Me.btnModifierMore.Location = New System.Drawing.Point(520, 464)
        Me.btnModifierMore.Name = "btnModifierMore"
        Me.btnModifierMore.Size = New System.Drawing.Size(128, 32)
        Me.btnModifierMore.TabIndex = 23
        Me.btnModifierMore.Text = "More"
        '
        'btnMainMore
        '
        Me.btnMainMore.Location = New System.Drawing.Point(336, 464)
        Me.btnMainMore.Name = "btnMainMore"
        Me.btnMainMore.Size = New System.Drawing.Size(128, 32)
        Me.btnMainMore.TabIndex = 22
        Me.btnMainMore.Text = "More"
        '
        'btnModifierPrevious
        '
        Me.btnModifierPrevious.Location = New System.Drawing.Point(520, 126)
        Me.btnModifierPrevious.Name = "btnModifierPrevious"
        Me.btnModifierPrevious.Size = New System.Drawing.Size(128, 32)
        Me.btnModifierPrevious.TabIndex = 21
        Me.btnModifierPrevious.Text = "Previous"
        '
        'btnMainPrevious
        '
        Me.btnMainPrevious.Location = New System.Drawing.Point(336, 126)
        Me.btnMainPrevious.Name = "btnMainPrevious"
        Me.btnMainPrevious.Size = New System.Drawing.Size(128, 32)
        Me.btnMainPrevious.TabIndex = 20
        Me.btnMainPrevious.Text = "Previous"
        '
        'lblCategoryModifiers
        '
        Me.lblCategoryModifiers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryModifiers.ForeColor = System.Drawing.Color.Silver
        Me.lblCategoryModifiers.Location = New System.Drawing.Point(528, 19)
        Me.lblCategoryModifiers.Name = "lblCategoryModifiers"
        Me.lblCategoryModifiers.Size = New System.Drawing.Size(120, 32)
        Me.lblCategoryModifiers.TabIndex = 15
        Me.lblCategoryModifiers.Text = "Modifiers"
        Me.lblCategoryModifiers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategoryMain
        '
        Me.lblCategoryMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryMain.ForeColor = System.Drawing.Color.Silver
        Me.lblCategoryMain.Location = New System.Drawing.Point(320, 19)
        Me.lblCategoryMain.Name = "lblCategoryMain"
        Me.lblCategoryMain.Size = New System.Drawing.Size(153, 32)
        Me.lblCategoryMain.TabIndex = 14
        Me.lblCategoryMain.Text = "Foods && General"
        Me.lblCategoryMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainCategoryPanel
        '
        Me.MainCategoryPanel.BackColor = System.Drawing.Color.White
        Me.MainCategoryPanel.Location = New System.Drawing.Point(336, 160)
        Me.MainCategoryPanel.Name = "MainCategoryPanel"
        Me.MainCategoryPanel.Size = New System.Drawing.Size(128, 304)
        Me.MainCategoryPanel.TabIndex = 2
        '
        'ModifierCategoryPanel
        '
        Me.ModifierCategoryPanel.BackColor = System.Drawing.Color.White
        Me.ModifierCategoryPanel.Location = New System.Drawing.Point(520, 160)
        Me.ModifierCategoryPanel.Name = "ModifierCategoryPanel"
        Me.ModifierCategoryPanel.Size = New System.Drawing.Size(128, 304)
        Me.ModifierCategoryPanel.TabIndex = 12
        '
        'TabModifiers
        '
        Me.TabModifiers.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabModifiers.Controls.Add(Me.pnlModifierPage)
        Me.TabModifiers.Controls.Add(Me.pnlNewModifier)
        Me.TabModifiers.Controls.Add(Me.Panel7)
        Me.TabModifiers.Controls.Add(Me.pnlOrderModifierStaging)
        Me.TabModifiers.Controls.Add(Me.pnlModifierItems)
        Me.TabModifiers.Controls.Add(Me.cbxModifierFilter)
        Me.TabModifiers.Controls.Add(Me.pnlUpdateModifiers)
        Me.TabModifiers.Location = New System.Drawing.Point(4, 22)
        Me.TabModifiers.Name = "TabModifiers"
        Me.TabModifiers.Size = New System.Drawing.Size(840, 550)
        Me.TabModifiers.TabIndex = 2
        Me.TabModifiers.Text = "Modifiers"
        '
        'pnlModifierPage
        '
        Me.pnlModifierPage.Controls.Add(Me.btnModifierAddPage)
        Me.pnlModifierPage.Controls.Add(Me.btnModifierRemovePage)
        Me.pnlModifierPage.Location = New System.Drawing.Point(382, 432)
        Me.pnlModifierPage.Name = "pnlModifierPage"
        Me.pnlModifierPage.Size = New System.Drawing.Size(100, 108)
        Me.pnlModifierPage.TabIndex = 46
        Me.pnlModifierPage.Visible = False
        '
        'btnModifierAddPage
        '
        Me.btnModifierAddPage.Location = New System.Drawing.Point(15, 10)
        Me.btnModifierAddPage.Name = "btnModifierAddPage"
        Me.btnModifierAddPage.Size = New System.Drawing.Size(72, 40)
        Me.btnModifierAddPage.TabIndex = 41
        Me.btnModifierAddPage.Text = "Add Page"
        '
        'btnModifierRemovePage
        '
        Me.btnModifierRemovePage.Location = New System.Drawing.Point(15, 56)
        Me.btnModifierRemovePage.Name = "btnModifierRemovePage"
        Me.btnModifierRemovePage.Size = New System.Drawing.Size(72, 40)
        Me.btnModifierRemovePage.TabIndex = 42
        Me.btnModifierRemovePage.Text = "Remove Page"
        '
        'pnlNewModifier
        '
        Me.pnlNewModifier.Controls.Add(Me.btnCancelModifier)
        Me.pnlNewModifier.Controls.Add(Me.btnAcceptModifier)
        Me.pnlNewModifier.Controls.Add(Me.Label17)
        Me.pnlNewModifier.Controls.Add(Me.Label18)
        Me.pnlNewModifier.Controls.Add(Me.Label19)
        Me.pnlNewModifier.Controls.Add(Me.txtNewModifierSurcharge)
        Me.pnlNewModifier.Controls.Add(Me.txtNewModifierChit)
        Me.pnlNewModifier.Controls.Add(Me.txtNewModifierAbrev)
        Me.pnlNewModifier.Controls.Add(Me.Label20)
        Me.pnlNewModifier.Controls.Add(Me.Label21)
        Me.pnlNewModifier.Controls.Add(Me.txtNewModifierName)
        Me.pnlNewModifier.Controls.Add(Me.Label22)
        Me.pnlNewModifier.Controls.Add(Me.cbxNewModifierRouting)
        Me.pnlNewModifier.Controls.Add(Me.Label23)
        Me.pnlNewModifier.Controls.Add(Me.txtNewModifierDescription)
        Me.pnlNewModifier.Controls.Add(Me.txtNewModifierCost)
        Me.pnlNewModifier.Controls.Add(Me.Label24)
        Me.pnlNewModifier.Location = New System.Drawing.Point(744, 448)
        Me.pnlNewModifier.Name = "pnlNewModifier"
        Me.pnlNewModifier.Size = New System.Drawing.Size(360, 400)
        Me.pnlNewModifier.TabIndex = 45
        Me.pnlNewModifier.Visible = False
        '
        'btnCancelModifier
        '
        Me.btnCancelModifier.Location = New System.Drawing.Point(16, 312)
        Me.btnCancelModifier.Name = "btnCancelModifier"
        Me.btnCancelModifier.Size = New System.Drawing.Size(64, 40)
        Me.btnCancelModifier.TabIndex = 45
        Me.btnCancelModifier.Text = "Cancel"
        '
        'btnAcceptModifier
        '
        Me.btnAcceptModifier.Location = New System.Drawing.Point(8, 248)
        Me.btnAcceptModifier.Name = "btnAcceptModifier"
        Me.btnAcceptModifier.Size = New System.Drawing.Size(80, 48)
        Me.btnAcceptModifier.TabIndex = 44
        Me.btnAcceptModifier.Text = "Accept Modifier"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(184, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Surcharge:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(56, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Kitchen:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(56, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Button:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewModifierSurcharge
        '
        Me.txtNewModifierSurcharge.Location = New System.Drawing.Point(272, 144)
        Me.txtNewModifierSurcharge.Name = "txtNewModifierSurcharge"
        Me.txtNewModifierSurcharge.Size = New System.Drawing.Size(64, 20)
        Me.txtNewModifierSurcharge.TabIndex = 4
        '
        'txtNewModifierChit
        '
        Me.txtNewModifierChit.Location = New System.Drawing.Point(136, 112)
        Me.txtNewModifierChit.Name = "txtNewModifierChit"
        Me.txtNewModifierChit.Size = New System.Drawing.Size(200, 20)
        Me.txtNewModifierChit.TabIndex = 3
        Me.txtNewModifierChit.Text = "Enter Chit Name"
        '
        'txtNewModifierAbrev
        '
        Me.txtNewModifierAbrev.Location = New System.Drawing.Point(136, 80)
        Me.txtNewModifierAbrev.Name = "txtNewModifierAbrev"
        Me.txtNewModifierAbrev.Size = New System.Drawing.Size(200, 20)
        Me.txtNewModifierAbrev.TabIndex = 2
        Me.txtNewModifierAbrev.Text = "Enter Abrev Name"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(56, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Full Name:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(64, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(248, 24)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Add New Modifier"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNewModifierName
        '
        Me.txtNewModifierName.Location = New System.Drawing.Point(136, 48)
        Me.txtNewModifierName.Name = "txtNewModifierName"
        Me.txtNewModifierName.Size = New System.Drawing.Size(200, 20)
        Me.txtNewModifierName.TabIndex = 1
        Me.txtNewModifierName.Text = "Enter Modifier Name"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(128, 256)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 24)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Food Cost:           (for accounting only)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxNewModifierRouting
        '
        Me.cbxNewModifierRouting.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cbxNewModifierRouting.Location = New System.Drawing.Point(136, 224)
        Me.cbxNewModifierRouting.Name = "cbxNewModifierRouting"
        Me.cbxNewModifierRouting.Size = New System.Drawing.Size(200, 21)
        Me.cbxNewModifierRouting.TabIndex = 6
        Me.cbxNewModifierRouting.Text = "Route w/ Food"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(112, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(216, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Description"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNewModifierDescription
        '
        Me.txtNewModifierDescription.Location = New System.Drawing.Point(96, 304)
        Me.txtNewModifierDescription.Multiline = True
        Me.txtNewModifierDescription.Name = "txtNewModifierDescription"
        Me.txtNewModifierDescription.Size = New System.Drawing.Size(248, 88)
        Me.txtNewModifierDescription.TabIndex = 43
        '
        'txtNewModifierCost
        '
        Me.txtNewModifierCost.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNewModifierCost.Location = New System.Drawing.Point(240, 256)
        Me.txtNewModifierCost.Name = "txtNewModifierCost"
        Me.txtNewModifierCost.Size = New System.Drawing.Size(96, 20)
        Me.txtNewModifierCost.TabIndex = 7
        Me.txtNewModifierCost.Text = "Enter Cost"
        Me.txtNewModifierCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(128, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(208, 24)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "Routing (only if seperate from Food):"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnModCancelNew)
        Me.Panel7.Controls.Add(Me.lblModifierSurcharge)
        Me.Panel7.Controls.Add(Me.lblModifierChit)
        Me.Panel7.Controls.Add(Me.lblModifierAbrev)
        Me.Panel7.Controls.Add(Me.txtModifierSurcharge)
        Me.Panel7.Controls.Add(Me.txtModifierChit)
        Me.Panel7.Controls.Add(Me.txtModifierAbrev)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.lblSelectModifierFilter)
        Me.Panel7.Controls.Add(Me.txtModifierName)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.cbxModifierRouting)
        Me.Panel7.Controls.Add(Me.LblModDescLabel)
        Me.Panel7.Controls.Add(Me.txtModifierDescription)
        Me.Panel7.Controls.Add(Me.txtModifierCost)
        Me.Panel7.Controls.Add(Me.lblModifierRouting)
        Me.Panel7.Location = New System.Drawing.Point(424, 16)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(360, 400)
        Me.Panel7.TabIndex = 44
        '
        'btnModCancelNew
        '
        Me.btnModCancelNew.Location = New System.Drawing.Point(24, 328)
        Me.btnModCancelNew.Name = "btnModCancelNew"
        Me.btnModCancelNew.Size = New System.Drawing.Size(56, 48)
        Me.btnModCancelNew.TabIndex = 44
        Me.btnModCancelNew.Text = "Cancel"
        Me.btnModCancelNew.Visible = False
        '
        'lblModifierSurcharge
        '
        Me.lblModifierSurcharge.Location = New System.Drawing.Point(184, 167)
        Me.lblModifierSurcharge.Name = "lblModifierSurcharge"
        Me.lblModifierSurcharge.Size = New System.Drawing.Size(80, 16)
        Me.lblModifierSurcharge.TabIndex = 36
        Me.lblModifierSurcharge.Text = "Surcharge:"
        Me.lblModifierSurcharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModifierChit
        '
        Me.lblModifierChit.Location = New System.Drawing.Point(56, 135)
        Me.lblModifierChit.Name = "lblModifierChit"
        Me.lblModifierChit.Size = New System.Drawing.Size(72, 16)
        Me.lblModifierChit.TabIndex = 35
        Me.lblModifierChit.Text = "Kitchen:"
        Me.lblModifierChit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModifierAbrev
        '
        Me.lblModifierAbrev.Location = New System.Drawing.Point(56, 103)
        Me.lblModifierAbrev.Name = "lblModifierAbrev"
        Me.lblModifierAbrev.Size = New System.Drawing.Size(72, 16)
        Me.lblModifierAbrev.TabIndex = 34
        Me.lblModifierAbrev.Text = "Button:"
        Me.lblModifierAbrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModifierSurcharge
        '
        Me.txtModifierSurcharge.Location = New System.Drawing.Point(272, 167)
        Me.txtModifierSurcharge.Name = "txtModifierSurcharge"
        Me.txtModifierSurcharge.Size = New System.Drawing.Size(64, 20)
        Me.txtModifierSurcharge.TabIndex = 4
        '
        'txtModifierChit
        '
        Me.txtModifierChit.Location = New System.Drawing.Point(136, 135)
        Me.txtModifierChit.Name = "txtModifierChit"
        Me.txtModifierChit.Size = New System.Drawing.Size(200, 20)
        Me.txtModifierChit.TabIndex = 3
        Me.txtModifierChit.Text = "Enter Chit Name"
        '
        'txtModifierAbrev
        '
        Me.txtModifierAbrev.Location = New System.Drawing.Point(136, 103)
        Me.txtModifierAbrev.Name = "txtModifierAbrev"
        Me.txtModifierAbrev.Size = New System.Drawing.Size(200, 20)
        Me.txtModifierAbrev.TabIndex = 2
        Me.txtModifierAbrev.Text = "Enter Abrev Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Full Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSelectModifierFilter
        '
        Me.lblSelectModifierFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectModifierFilter.ForeColor = System.Drawing.Color.Silver
        Me.lblSelectModifierFilter.Location = New System.Drawing.Point(64, 16)
        Me.lblSelectModifierFilter.Name = "lblSelectModifierFilter"
        Me.lblSelectModifierFilter.Size = New System.Drawing.Size(248, 24)
        Me.lblSelectModifierFilter.TabIndex = 7
        Me.lblSelectModifierFilter.Text = "Modifier Display for ALL Menus"
        Me.lblSelectModifierFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtModifierName
        '
        Me.txtModifierName.Location = New System.Drawing.Point(136, 71)
        Me.txtModifierName.Name = "txtModifierName"
        Me.txtModifierName.Size = New System.Drawing.Size(200, 20)
        Me.txtModifierName.TabIndex = 1
        Me.txtModifierName.Text = "Enter Modifier Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(128, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Food Cost:           (for accounting only)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxModifierRouting
        '
        Me.cbxModifierRouting.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cbxModifierRouting.Location = New System.Drawing.Point(136, 224)
        Me.cbxModifierRouting.Name = "cbxModifierRouting"
        Me.cbxModifierRouting.Size = New System.Drawing.Size(200, 21)
        Me.cbxModifierRouting.TabIndex = 6
        Me.cbxModifierRouting.Text = "Route w/ Food"
        '
        'LblModDescLabel
        '
        Me.LblModDescLabel.Location = New System.Drawing.Point(112, 288)
        Me.LblModDescLabel.Name = "LblModDescLabel"
        Me.LblModDescLabel.Size = New System.Drawing.Size(216, 16)
        Me.LblModDescLabel.TabIndex = 11
        Me.LblModDescLabel.Text = "Description"
        Me.LblModDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtModifierDescription
        '
        Me.txtModifierDescription.Location = New System.Drawing.Point(96, 304)
        Me.txtModifierDescription.Multiline = True
        Me.txtModifierDescription.Name = "txtModifierDescription"
        Me.txtModifierDescription.Size = New System.Drawing.Size(248, 88)
        Me.txtModifierDescription.TabIndex = 43
        '
        'txtModifierCost
        '
        Me.txtModifierCost.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtModifierCost.Location = New System.Drawing.Point(240, 256)
        Me.txtModifierCost.Name = "txtModifierCost"
        Me.txtModifierCost.Size = New System.Drawing.Size(96, 20)
        Me.txtModifierCost.TabIndex = 7
        Me.txtModifierCost.Text = "Enter Cost"
        Me.txtModifierCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblModifierRouting
        '
        Me.lblModifierRouting.Location = New System.Drawing.Point(128, 200)
        Me.lblModifierRouting.Name = "lblModifierRouting"
        Me.lblModifierRouting.Size = New System.Drawing.Size(208, 24)
        Me.lblModifierRouting.TabIndex = 38
        Me.lblModifierRouting.Text = "Routing (only if seperate from Food):"
        Me.lblModifierRouting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlOrderModifierStaging
        '
        Me.pnlOrderModifierStaging.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlOrderModifierStaging.Location = New System.Drawing.Point(24, 432)
        Me.pnlOrderModifierStaging.Name = "pnlOrderModifierStaging"
        Me.pnlOrderModifierStaging.Size = New System.Drawing.Size(328, 80)
        Me.pnlOrderModifierStaging.TabIndex = 40
        '
        'pnlModifierItems
        '
        Me.pnlModifierItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlModifierItems.Location = New System.Drawing.Point(16, 48)
        Me.pnlModifierItems.Name = "pnlModifierItems"
        Me.pnlModifierItems.Size = New System.Drawing.Size(344, 368)
        Me.pnlModifierItems.TabIndex = 39
        '
        'cbxModifierFilter
        '
        Me.cbxModifierFilter.Location = New System.Drawing.Point(88, 16)
        Me.cbxModifierFilter.MaxDropDownItems = 16
        Me.cbxModifierFilter.Name = "cbxModifierFilter"
        Me.cbxModifierFilter.Size = New System.Drawing.Size(192, 21)
        Me.cbxModifierFilter.TabIndex = 6
        Me.cbxModifierFilter.Text = "Select Modifier Category"
        '
        'pnlUpdateModifiers
        '
        Me.pnlUpdateModifiers.BackColor = System.Drawing.SystemColors.Control
        Me.pnlUpdateModifiers.Controls.Add(Me.btnRemoveModifier)
        Me.pnlUpdateModifiers.Location = New System.Drawing.Point(560, 448)
        Me.pnlUpdateModifiers.Name = "pnlUpdateModifiers"
        Me.pnlUpdateModifiers.Size = New System.Drawing.Size(128, 52)
        Me.pnlUpdateModifiers.TabIndex = 5
        '
        'btnRemoveModifier
        '
        Me.btnRemoveModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnRemoveModifier.Location = New System.Drawing.Point(4, 4)
        Me.btnRemoveModifier.Name = "btnRemoveModifier"
        Me.btnRemoveModifier.Size = New System.Drawing.Size(120, 43)
        Me.btnRemoveModifier.TabIndex = 1
        Me.btnRemoveModifier.Text = "Remove Modifier From Display"
        Me.btnRemoveModifier.UseVisualStyleBackColor = False
        '
        'TabMainFood
        '
        Me.TabMainFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabMainFood.Controls.Add(Me.cbxFoodFilterModifiers)
        Me.TabMainFood.Controls.Add(Me.btnFoodRecipe)
        Me.TabMainFood.Controls.Add(Me.Panel1)
        Me.TabMainFood.Controls.Add(Me.pnlNewFood)
        Me.TabMainFood.Controls.Add(Me.txtRecipe)
        Me.TabMainFood.Controls.Add(Me.lblWineParring)
        Me.TabMainFood.Controls.Add(Me.cbxWineParring)
        Me.TabMainFood.Controls.Add(Me.lstModifierJoin)
        Me.TabMainFood.Controls.Add(Me.lblPrintPriority)
        Me.TabMainFood.Controls.Add(Me.lblSelectFoodCategory)
        Me.TabMainFood.Controls.Add(Me.lblChitFoodName)
        Me.TabMainFood.Controls.Add(Me.lblAbrevFoodName)
        Me.TabMainFood.Controls.Add(Me.cbxPrintPriority)
        Me.TabMainFood.Controls.Add(Me.lblFoodName)
        Me.TabMainFood.Controls.Add(Me.txtChitFoodName)
        Me.TabMainFood.Controls.Add(Me.txtAbrevFoodName)
        Me.TabMainFood.Controls.Add(Me.btnShowAllFood)
        Me.TabMainFood.Controls.Add(Me.cbxFoodFilter)
        Me.TabMainFood.Controls.Add(Me.lblSelectFoodFilter)
        Me.TabMainFood.Controls.Add(Me.btnFoodJoinLink)
        Me.TabMainFood.Controls.Add(Me.btnEnterNewFood)
        Me.TabMainFood.Controls.Add(Me.menuCostGroupBox)
        Me.TabMainFood.Controls.Add(Me.grdFoodList)
        Me.TabMainFood.Controls.Add(Me.Panel2)
        Me.TabMainFood.Controls.Add(Me.cbxFoodCategory)
        Me.TabMainFood.Controls.Add(Me.txtFoodName)
        Me.TabMainFood.Location = New System.Drawing.Point(4, 22)
        Me.TabMainFood.Name = "TabMainFood"
        Me.TabMainFood.Size = New System.Drawing.Size(840, 550)
        Me.TabMainFood.TabIndex = 1
        Me.TabMainFood.Text = "Kitchen"
        '
        'cbxFoodFilterModifiers
        '
        Me.cbxFoodFilterModifiers.Location = New System.Drawing.Point(16, 67)
        Me.cbxFoodFilterModifiers.MaxDropDownItems = 16
        Me.cbxFoodFilterModifiers.Name = "cbxFoodFilterModifiers"
        Me.cbxFoodFilterModifiers.Size = New System.Drawing.Size(192, 21)
        Me.cbxFoodFilterModifiers.TabIndex = 41
        Me.cbxFoodFilterModifiers.Text = "Select Modifier Category"
        '
        'btnFoodRecipe
        '
        Me.btnFoodRecipe.Location = New System.Drawing.Point(279, 351)
        Me.btnFoodRecipe.Name = "btnFoodRecipe"
        Me.btnFoodRecipe.Size = New System.Drawing.Size(152, 24)
        Me.btnFoodRecipe.TabIndex = 10
        Me.btnFoodRecipe.Text = "Recipe / Description"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtFoodInvMultiplier)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtFoodCost)
        Me.Panel1.Controls.Add(Me.lblFoodCost)
        Me.Panel1.Controls.Add(Me.chkManual)
        Me.Panel1.Location = New System.Drawing.Point(227, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 68)
        Me.Panel1.TabIndex = 40
        '
        'txtFoodInvMultiplier
        '
        Me.txtFoodInvMultiplier.Location = New System.Drawing.Point(71, 33)
        Me.txtFoodInvMultiplier.Name = "txtFoodInvMultiplier"
        Me.txtFoodInvMultiplier.Size = New System.Drawing.Size(88, 20)
        Me.txtFoodInvMultiplier.TabIndex = 41
        Me.txtFoodInvMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 39)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Inv Multiply"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFoodCost
        '
        Me.txtFoodCost.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtFoodCost.Location = New System.Drawing.Point(71, 7)
        Me.txtFoodCost.Name = "txtFoodCost"
        Me.txtFoodCost.Size = New System.Drawing.Size(88, 20)
        Me.txtFoodCost.TabIndex = 9
        Me.txtFoodCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFoodCost
        '
        Me.lblFoodCost.Location = New System.Drawing.Point(-1, 7)
        Me.lblFoodCost.Name = "lblFoodCost"
        Me.lblFoodCost.Size = New System.Drawing.Size(72, 16)
        Me.lblFoodCost.TabIndex = 32
        Me.lblFoodCost.Text = "Food Cost: "
        Me.lblFoodCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkManual
        '
        Me.chkManual.Location = New System.Drawing.Point(183, 7)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(64, 24)
        Me.chkManual.TabIndex = 39
        Me.chkManual.Text = "Manual"
        '
        'pnlNewFood
        '
        Me.pnlNewFood.BackColor = System.Drawing.Color.Moccasin
        Me.pnlNewFood.Controls.Add(Me.Label14)
        Me.pnlNewFood.Controls.Add(Me.txtNewFoodPrepare)
        Me.pnlNewFood.Controls.Add(Me.btnNewFoodCancel)
        Me.pnlNewFood.Controls.Add(Me.btnNewFoodAccept)
        Me.pnlNewFood.Controls.Add(Me.Label9)
        Me.pnlNewFood.Controls.Add(Me.ComboBox1)
        Me.pnlNewFood.Controls.Add(Me.Label10)
        Me.pnlNewFood.Controls.Add(Me.Label11)
        Me.pnlNewFood.Controls.Add(Me.Label12)
        Me.pnlNewFood.Controls.Add(Me.Label13)
        Me.pnlNewFood.Controls.Add(Me.txtNewChitFoodName)
        Me.pnlNewFood.Controls.Add(Me.txtNewAbrevFoodName)
        Me.pnlNewFood.Controls.Add(Me.cbxNewFoodCategory)
        Me.pnlNewFood.Controls.Add(Me.txtNewFoodName)
        Me.pnlNewFood.Location = New System.Drawing.Point(596, 194)
        Me.pnlNewFood.Name = "pnlNewFood"
        Me.pnlNewFood.Size = New System.Drawing.Size(280, 360)
        Me.pnlNewFood.TabIndex = 38
        Me.pnlNewFood.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(104, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 23)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Prepare Time:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewFoodPrepare
        '
        Me.txtNewFoodPrepare.Location = New System.Drawing.Point(200, 216)
        Me.txtNewFoodPrepare.Name = "txtNewFoodPrepare"
        Me.txtNewFoodPrepare.Size = New System.Drawing.Size(56, 20)
        Me.txtNewFoodPrepare.TabIndex = 48
        '
        'btnNewFoodCancel
        '
        Me.btnNewFoodCancel.Location = New System.Drawing.Point(160, 304)
        Me.btnNewFoodCancel.Name = "btnNewFoodCancel"
        Me.btnNewFoodCancel.Size = New System.Drawing.Size(75, 40)
        Me.btnNewFoodCancel.TabIndex = 47
        Me.btnNewFoodCancel.Text = "Cancel"
        '
        'btnNewFoodAccept
        '
        Me.btnNewFoodAccept.Location = New System.Drawing.Point(40, 304)
        Me.btnNewFoodAccept.Name = "btnNewFoodAccept"
        Me.btnNewFoodAccept.Size = New System.Drawing.Size(75, 40)
        Me.btnNewFoodAccept.TabIndex = 46
        Me.btnNewFoodAccept.Text = "Accept"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Wine Parring:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(80, 184)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Category:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Kitchen:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Button:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Full Name:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewChitFoodName
        '
        Me.txtNewChitFoodName.Location = New System.Drawing.Point(80, 112)
        Me.txtNewChitFoodName.Name = "txtNewChitFoodName"
        Me.txtNewChitFoodName.Size = New System.Drawing.Size(176, 20)
        Me.txtNewChitFoodName.TabIndex = 38
        '
        'txtNewAbrevFoodName
        '
        Me.txtNewAbrevFoodName.Location = New System.Drawing.Point(80, 80)
        Me.txtNewAbrevFoodName.Name = "txtNewAbrevFoodName"
        Me.txtNewAbrevFoodName.Size = New System.Drawing.Size(176, 20)
        Me.txtNewAbrevFoodName.TabIndex = 37
        '
        'cbxNewFoodCategory
        '
        Me.cbxNewFoodCategory.Location = New System.Drawing.Point(80, 152)
        Me.cbxNewFoodCategory.Name = "cbxNewFoodCategory"
        Me.cbxNewFoodCategory.Size = New System.Drawing.Size(176, 21)
        Me.cbxNewFoodCategory.TabIndex = 39
        '
        'txtNewFoodName
        '
        Me.txtNewFoodName.Location = New System.Drawing.Point(80, 48)
        Me.txtNewFoodName.Name = "txtNewFoodName"
        Me.txtNewFoodName.Size = New System.Drawing.Size(176, 20)
        Me.txtNewFoodName.TabIndex = 36
        '
        'txtRecipe
        '
        Me.txtRecipe.Location = New System.Drawing.Point(206, 381)
        Me.txtRecipe.Multiline = True
        Me.txtRecipe.Name = "txtRecipe"
        Me.txtRecipe.Size = New System.Drawing.Size(320, 128)
        Me.txtRecipe.TabIndex = 37
        Me.txtRecipe.Visible = False
        '
        'lblWineParring
        '
        Me.lblWineParring.Location = New System.Drawing.Point(216, 200)
        Me.lblWineParring.Name = "lblWineParring"
        Me.lblWineParring.Size = New System.Drawing.Size(80, 16)
        Me.lblWineParring.TabIndex = 35
        Me.lblWineParring.Text = "Wine Parring:"
        Me.lblWineParring.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxWineParring
        '
        Me.cbxWineParring.Location = New System.Drawing.Point(296, 200)
        Me.cbxWineParring.Name = "cbxWineParring"
        Me.cbxWineParring.Size = New System.Drawing.Size(176, 21)
        Me.cbxWineParring.TabIndex = 34
        '
        'lstModifierJoin
        '
        Me.lstModifierJoin.Location = New System.Drawing.Point(624, 56)
        Me.lstModifierJoin.Name = "lstModifierJoin"
        Me.lstModifierJoin.Size = New System.Drawing.Size(160, 160)
        Me.lstModifierJoin.TabIndex = 33
        '
        'lblPrintPriority
        '
        Me.lblPrintPriority.Location = New System.Drawing.Point(216, 232)
        Me.lblPrintPriority.Name = "lblPrintPriority"
        Me.lblPrintPriority.Size = New System.Drawing.Size(80, 16)
        Me.lblPrintPriority.TabIndex = 29
        Me.lblPrintPriority.Text = "Print Priority:"
        Me.lblPrintPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSelectFoodCategory
        '
        Me.lblSelectFoodCategory.Location = New System.Drawing.Point(224, 168)
        Me.lblSelectFoodCategory.Name = "lblSelectFoodCategory"
        Me.lblSelectFoodCategory.Size = New System.Drawing.Size(72, 16)
        Me.lblSelectFoodCategory.TabIndex = 27
        Me.lblSelectFoodCategory.Text = "Category:"
        Me.lblSelectFoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChitFoodName
        '
        Me.lblChitFoodName.Location = New System.Drawing.Point(224, 128)
        Me.lblChitFoodName.Name = "lblChitFoodName"
        Me.lblChitFoodName.Size = New System.Drawing.Size(72, 16)
        Me.lblChitFoodName.TabIndex = 26
        Me.lblChitFoodName.Text = "Kitchen:"
        Me.lblChitFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAbrevFoodName
        '
        Me.lblAbrevFoodName.Location = New System.Drawing.Point(224, 96)
        Me.lblAbrevFoodName.Name = "lblAbrevFoodName"
        Me.lblAbrevFoodName.Size = New System.Drawing.Size(72, 16)
        Me.lblAbrevFoodName.TabIndex = 25
        Me.lblAbrevFoodName.Text = "Button:"
        Me.lblAbrevFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxPrintPriority
        '
        Me.cbxPrintPriority.BackColor = System.Drawing.Color.White
        Me.cbxPrintPriority.Location = New System.Drawing.Point(296, 232)
        Me.cbxPrintPriority.Name = "cbxPrintPriority"
        Me.cbxPrintPriority.Size = New System.Drawing.Size(120, 21)
        Me.cbxPrintPriority.TabIndex = 6
        '
        'lblFoodName
        '
        Me.lblFoodName.Location = New System.Drawing.Point(224, 64)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(72, 16)
        Me.lblFoodName.TabIndex = 19
        Me.lblFoodName.Text = "Full Name:"
        Me.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChitFoodName
        '
        Me.txtChitFoodName.Location = New System.Drawing.Point(296, 128)
        Me.txtChitFoodName.Name = "txtChitFoodName"
        Me.txtChitFoodName.Size = New System.Drawing.Size(176, 20)
        Me.txtChitFoodName.TabIndex = 3
        '
        'txtAbrevFoodName
        '
        Me.txtAbrevFoodName.Location = New System.Drawing.Point(296, 96)
        Me.txtAbrevFoodName.Name = "txtAbrevFoodName"
        Me.txtAbrevFoodName.Size = New System.Drawing.Size(176, 20)
        Me.txtAbrevFoodName.TabIndex = 2
        '
        'btnShowAllFood
        '
        Me.btnShowAllFood.Location = New System.Drawing.Point(56, 515)
        Me.btnShowAllFood.Name = "btnShowAllFood"
        Me.btnShowAllFood.Size = New System.Drawing.Size(96, 24)
        Me.btnShowAllFood.TabIndex = 16
        Me.btnShowAllFood.Text = "Show All"
        '
        'cbxFoodFilter
        '
        Me.cbxFoodFilter.Location = New System.Drawing.Point(16, 40)
        Me.cbxFoodFilter.MaxDropDownItems = 16
        Me.cbxFoodFilter.Name = "cbxFoodFilter"
        Me.cbxFoodFilter.Size = New System.Drawing.Size(192, 21)
        Me.cbxFoodFilter.TabIndex = 15
        Me.cbxFoodFilter.Text = "Select Food Category"
        '
        'lblSelectFoodFilter
        '
        Me.lblSelectFoodFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectFoodFilter.ForeColor = System.Drawing.Color.Silver
        Me.lblSelectFoodFilter.Location = New System.Drawing.Point(264, 16)
        Me.lblSelectFoodFilter.Name = "lblSelectFoodFilter"
        Me.lblSelectFoodFilter.Size = New System.Drawing.Size(232, 32)
        Me.lblSelectFoodFilter.TabIndex = 14
        Me.lblSelectFoodFilter.Text = "Select Category"
        Me.lblSelectFoodFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFoodJoinLink
        '
        Me.btnFoodJoinLink.ForeColor = System.Drawing.Color.White
        Me.btnFoodJoinLink.Location = New System.Drawing.Point(656, 16)
        Me.btnFoodJoinLink.Name = "btnFoodJoinLink"
        Me.btnFoodJoinLink.Size = New System.Drawing.Size(104, 32)
        Me.btnFoodJoinLink.TabIndex = 13
        Me.btnFoodJoinLink.Text = "Update Joins"
        '
        'btnEnterNewFood
        '
        Me.btnEnterNewFood.ForeColor = System.Drawing.Color.White
        Me.btnEnterNewFood.Location = New System.Drawing.Point(56, 8)
        Me.btnEnterNewFood.Name = "btnEnterNewFood"
        Me.btnEnterNewFood.Size = New System.Drawing.Size(120, 32)
        Me.btnEnterNewFood.TabIndex = 11
        Me.btnEnterNewFood.Text = "Enter New Food"
        '
        'menuCostGroupBox
        '
        Me.menuCostGroupBox.Location = New System.Drawing.Point(552, 232)
        Me.menuCostGroupBox.Name = "menuCostGroupBox"
        Me.menuCostGroupBox.Size = New System.Drawing.Size(280, 192)
        Me.menuCostGroupBox.TabIndex = 14
        Me.menuCostGroupBox.TabStop = False
        Me.menuCostGroupBox.Text = "Price per Menu"
        '
        'grdFoodList
        '
        Me.grdFoodList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdFoodList.CaptionText = "               Food Items"
        Me.grdFoodList.ColumnHeadersVisible = False
        Me.grdFoodList.DataMember = ""
        Me.grdFoodList.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdFoodList.Location = New System.Drawing.Point(24, 104)
        Me.grdFoodList.Name = "grdFoodList"
        Me.grdFoodList.ReadOnly = True
        Me.grdFoodList.RowHeadersVisible = False
        Me.grdFoodList.RowHeaderWidth = 0
        Me.grdFoodList.Size = New System.Drawing.Size(176, 405)
        Me.grdFoodList.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnRemoveFood)
        Me.Panel2.Location = New System.Drawing.Point(38, 566)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 48)
        Me.Panel2.TabIndex = 6
        '
        'btnRemoveFood
        '
        Me.btnRemoveFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnRemoveFood.Location = New System.Drawing.Point(8, 8)
        Me.btnRemoveFood.Name = "btnRemoveFood"
        Me.btnRemoveFood.Size = New System.Drawing.Size(136, 32)
        Me.btnRemoveFood.TabIndex = 12
        Me.btnRemoveFood.Text = "Remove Food Item"
        Me.btnRemoveFood.UseVisualStyleBackColor = False
        '
        'cbxFoodCategory
        '
        Me.cbxFoodCategory.BackColor = System.Drawing.Color.White
        Me.cbxFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxFoodCategory.Location = New System.Drawing.Point(296, 168)
        Me.cbxFoodCategory.MaxDropDownItems = 16
        Me.cbxFoodCategory.Name = "cbxFoodCategory"
        Me.cbxFoodCategory.Size = New System.Drawing.Size(176, 21)
        Me.cbxFoodCategory.TabIndex = 4
        '
        'txtFoodName
        '
        Me.txtFoodName.Location = New System.Drawing.Point(296, 64)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(176, 20)
        Me.txtFoodName.TabIndex = 1
        '
        'TabFoodJoin
        '
        Me.TabFoodJoin.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabFoodJoin.Controls.Add(Me.btnJoinReq)
        Me.TabFoodJoin.Controls.Add(Me.btnJoinGTC)
        Me.TabFoodJoin.Controls.Add(Me.Panel5)
        Me.TabFoodJoin.Controls.Add(Me.btnJoinGroup)
        Me.TabFoodJoin.Controls.Add(Me.btnJoinFoodRemoveIndividual)
        Me.TabFoodJoin.Controls.Add(Me.btnJoinFoodRemoveCategory)
        Me.TabFoodJoin.Controls.Add(Me.grdJoinFoodModifierJoins)
        Me.TabFoodJoin.Controls.Add(Me.btnJoinFree)
        Me.TabFoodJoin.Controls.Add(Me.grdJoinFoodChoice)
        Me.TabFoodJoin.Controls.Add(Me.cbxJoinCategorySelect)
        Me.TabFoodJoin.Controls.Add(Me.lblJoinFoodSelected)
        Me.TabFoodJoin.Controls.Add(Me.grdJoinFoodCategoryJoins)
        Me.TabFoodJoin.Controls.Add(Me.cbxJoinIndividualModifierSelect)
        Me.TabFoodJoin.Controls.Add(Me.grdJoinIndividualModifiers)
        Me.TabFoodJoin.Controls.Add(Me.grdJoinPossibleCategories)
        Me.TabFoodJoin.Location = New System.Drawing.Point(4, 22)
        Me.TabFoodJoin.Name = "TabFoodJoin"
        Me.TabFoodJoin.Size = New System.Drawing.Size(840, 550)
        Me.TabFoodJoin.TabIndex = 3
        Me.TabFoodJoin.Text = "Food Join"
        '
        'btnJoinReq
        '
        Me.btnJoinReq.ForeColor = System.Drawing.Color.White
        Me.btnJoinReq.Location = New System.Drawing.Point(293, 456)
        Me.btnJoinReq.Name = "btnJoinReq"
        Me.btnJoinReq.Size = New System.Drawing.Size(75, 48)
        Me.btnJoinReq.TabIndex = 22
        Me.btnJoinReq.Text = "Required"
        '
        'btnJoinGTC
        '
        Me.btnJoinGTC.ForeColor = System.Drawing.Color.White
        Me.btnJoinGTC.Location = New System.Drawing.Point(208, 456)
        Me.btnJoinGTC.Name = "btnJoinGTC"
        Me.btnJoinGTC.Size = New System.Drawing.Size(75, 48)
        Me.btnJoinGTC.TabIndex = 21
        Me.btnJoinGTC.Text = "GTC"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(240, 304)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(272, 136)
        Me.Panel5.TabIndex = 20
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.Silver
        Me.Label26.Location = New System.Drawing.Point(8, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(248, 23)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "R - Required to Order"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(8, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "C - GTC, Category is Good til Cancelled"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(8, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "G - Item must be selected within Category Group"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "A - Item automatically attach to Food"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "S - Item carrys Surcharge listed in Main Foods"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "F - Item is always free"
        '
        'btnJoinGroup
        '
        Me.btnJoinGroup.ForeColor = System.Drawing.Color.White
        Me.btnJoinGroup.Location = New System.Drawing.Point(466, 456)
        Me.btnJoinGroup.Name = "btnJoinGroup"
        Me.btnJoinGroup.Size = New System.Drawing.Size(72, 48)
        Me.btnJoinGroup.TabIndex = 19
        Me.btnJoinGroup.Text = "Auto / Group"
        '
        'btnJoinFoodRemoveIndividual
        '
        Me.btnJoinFoodRemoveIndividual.ForeColor = System.Drawing.Color.Silver
        Me.btnJoinFoodRemoveIndividual.Location = New System.Drawing.Point(400, 48)
        Me.btnJoinFoodRemoveIndividual.Name = "btnJoinFoodRemoveIndividual"
        Me.btnJoinFoodRemoveIndividual.Size = New System.Drawing.Size(88, 40)
        Me.btnJoinFoodRemoveIndividual.TabIndex = 17
        Me.btnJoinFoodRemoveIndividual.Text = "Remove"
        '
        'btnJoinFoodRemoveCategory
        '
        Me.btnJoinFoodRemoveCategory.ForeColor = System.Drawing.Color.Silver
        Me.btnJoinFoodRemoveCategory.Location = New System.Drawing.Point(256, 48)
        Me.btnJoinFoodRemoveCategory.Name = "btnJoinFoodRemoveCategory"
        Me.btnJoinFoodRemoveCategory.Size = New System.Drawing.Size(88, 40)
        Me.btnJoinFoodRemoveCategory.TabIndex = 16
        Me.btnJoinFoodRemoveCategory.Text = "Remove"
        '
        'grdJoinFoodModifierJoins
        '
        Me.grdJoinFoodModifierJoins.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdJoinFoodModifierJoins.CaptionText = "     Individual Modifiers"
        Me.grdJoinFoodModifierJoins.ColumnHeadersVisible = False
        Me.grdJoinFoodModifierJoins.DataMember = ""
        Me.grdJoinFoodModifierJoins.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdJoinFoodModifierJoins.Location = New System.Drawing.Point(376, 88)
        Me.grdJoinFoodModifierJoins.Name = "grdJoinFoodModifierJoins"
        Me.grdJoinFoodModifierJoins.ReadOnly = True
        Me.grdJoinFoodModifierJoins.Size = New System.Drawing.Size(152, 200)
        Me.grdJoinFoodModifierJoins.TabIndex = 15
        '
        'btnJoinFree
        '
        Me.btnJoinFree.ForeColor = System.Drawing.Color.White
        Me.btnJoinFree.Location = New System.Drawing.Point(379, 456)
        Me.btnJoinFree.Name = "btnJoinFree"
        Me.btnJoinFree.Size = New System.Drawing.Size(76, 48)
        Me.btnJoinFree.TabIndex = 14
        Me.btnJoinFree.Text = "Free / Surcharge"
        '
        'grdJoinFoodChoice
        '
        Me.grdJoinFoodChoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdJoinFoodChoice.CaptionText = "             Food Choices"
        Me.grdJoinFoodChoice.ColumnHeadersVisible = False
        Me.grdJoinFoodChoice.DataMember = ""
        Me.grdJoinFoodChoice.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdJoinFoodChoice.Location = New System.Drawing.Point(24, 88)
        Me.grdJoinFoodChoice.Name = "grdJoinFoodChoice"
        Me.grdJoinFoodChoice.ReadOnly = True
        Me.grdJoinFoodChoice.Size = New System.Drawing.Size(176, 344)
        Me.grdJoinFoodChoice.TabIndex = 13
        '
        'cbxJoinCategorySelect
        '
        Me.cbxJoinCategorySelect.Location = New System.Drawing.Point(24, 56)
        Me.cbxJoinCategorySelect.MaxDropDownItems = 16
        Me.cbxJoinCategorySelect.Name = "cbxJoinCategorySelect"
        Me.cbxJoinCategorySelect.Size = New System.Drawing.Size(176, 21)
        Me.cbxJoinCategorySelect.TabIndex = 12
        Me.cbxJoinCategorySelect.Text = "Select Food Category"
        '
        'lblJoinFoodSelected
        '
        Me.lblJoinFoodSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoinFoodSelected.ForeColor = System.Drawing.Color.Silver
        Me.lblJoinFoodSelected.Location = New System.Drawing.Point(224, 8)
        Me.lblJoinFoodSelected.Name = "lblJoinFoodSelected"
        Me.lblJoinFoodSelected.Size = New System.Drawing.Size(304, 40)
        Me.lblJoinFoodSelected.TabIndex = 11
        Me.lblJoinFoodSelected.Text = "Please Select A Food Item"
        Me.lblJoinFoodSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdJoinFoodCategoryJoins
        '
        Me.grdJoinFoodCategoryJoins.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdJoinFoodCategoryJoins.CaptionText = "           Categories"
        Me.grdJoinFoodCategoryJoins.ColumnHeadersVisible = False
        Me.grdJoinFoodCategoryJoins.DataMember = ""
        Me.grdJoinFoodCategoryJoins.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdJoinFoodCategoryJoins.Location = New System.Drawing.Point(224, 88)
        Me.grdJoinFoodCategoryJoins.Name = "grdJoinFoodCategoryJoins"
        Me.grdJoinFoodCategoryJoins.ReadOnly = True
        Me.grdJoinFoodCategoryJoins.Size = New System.Drawing.Size(144, 200)
        Me.grdJoinFoodCategoryJoins.TabIndex = 3
        '
        'cbxJoinIndividualModifierSelect
        '
        Me.cbxJoinIndividualModifierSelect.Location = New System.Drawing.Point(552, 280)
        Me.cbxJoinIndividualModifierSelect.MaxDropDownItems = 16
        Me.cbxJoinIndividualModifierSelect.Name = "cbxJoinIndividualModifierSelect"
        Me.cbxJoinIndividualModifierSelect.Size = New System.Drawing.Size(168, 21)
        Me.cbxJoinIndividualModifierSelect.TabIndex = 2
        Me.cbxJoinIndividualModifierSelect.Text = "Select Modifier Category"
        '
        'grdJoinIndividualModifiers
        '
        Me.grdJoinIndividualModifiers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdJoinIndividualModifiers.CaptionText = "           Individual Items"
        Me.grdJoinIndividualModifiers.ColumnHeadersVisible = False
        Me.grdJoinIndividualModifiers.DataMember = ""
        Me.grdJoinIndividualModifiers.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdJoinIndividualModifiers.Location = New System.Drawing.Point(552, 304)
        Me.grdJoinIndividualModifiers.Name = "grdJoinIndividualModifiers"
        Me.grdJoinIndividualModifiers.ReadOnly = True
        Me.grdJoinIndividualModifiers.Size = New System.Drawing.Size(168, 200)
        Me.grdJoinIndividualModifiers.TabIndex = 1
        '
        'grdJoinPossibleCategories
        '
        Me.grdJoinPossibleCategories.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdJoinPossibleCategories.CaptionText = "       Possible Categories"
        Me.grdJoinPossibleCategories.ColumnHeadersVisible = False
        Me.grdJoinPossibleCategories.DataMember = ""
        Me.grdJoinPossibleCategories.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdJoinPossibleCategories.Location = New System.Drawing.Point(552, 8)
        Me.grdJoinPossibleCategories.Name = "grdJoinPossibleCategories"
        Me.grdJoinPossibleCategories.ReadOnly = True
        Me.grdJoinPossibleCategories.Size = New System.Drawing.Size(168, 264)
        Me.grdJoinPossibleCategories.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCategory)
        Me.TabControl1.Controls.Add(Me.TabMainFood)
        Me.TabControl1.Controls.Add(Me.TabModifiers)
        Me.TabControl1.Controls.Add(Me.TabFoodJoin)
        Me.TabControl1.Controls.Add(Me.TabDrinkCategory)
        Me.TabControl1.Controls.Add(Me.TabDrinks)
        Me.TabControl1.Controls.Add(Me.TabDrinkPrep)
        Me.TabControl1.Controls.Add(Me.TabMenuSetup)
        Me.TabControl1.Controls.Add(Me.TabFoodOrder)
        Me.TabControl1.ItemSize = New System.Drawing.Size(54, 18)
        Me.TabControl1.Location = New System.Drawing.Point(24, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 576)
        Me.TabControl1.TabIndex = 11
        Me.TabControl1.TabStop = False
        '
        'TabDrinkCategory
        '
        Me.TabDrinkCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabDrinkCategory.Controls.Add(Me.Label30)
        Me.TabDrinkCategory.Controls.Add(Me.btnDrinkCategoryColor)
        Me.TabDrinkCategory.Controls.Add(Me.pnlDrinkModifiers)
        Me.TabDrinkCategory.Controls.Add(Me.pnlIsLiquorType)
        Me.TabDrinkCategory.Controls.Add(Me.lblDrinkCategoryName)
        Me.TabDrinkCategory.Controls.Add(Me.btnDrinkCategoryName)
        Me.TabDrinkCategory.Controls.Add(Me.txtDrinkCategoryName)
        Me.TabDrinkCategory.Controls.Add(Me.pnlDrinkCategory)
        Me.TabDrinkCategory.Location = New System.Drawing.Point(4, 22)
        Me.TabDrinkCategory.Name = "TabDrinkCategory"
        Me.TabDrinkCategory.Size = New System.Drawing.Size(840, 550)
        Me.TabDrinkCategory.TabIndex = 4
        Me.TabDrinkCategory.Text = "Bar Category"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(131, 13)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(160, 43)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "Only use if you have a Full Bar. Otherwise place drinks in the Kitchen && Food Ca" & _
            "tegory."
        '
        'btnDrinkCategoryColor
        '
        Me.btnDrinkCategoryColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDrinkCategoryColor.ForeColor = System.Drawing.Color.White
        Me.btnDrinkCategoryColor.Location = New System.Drawing.Point(328, 16)
        Me.btnDrinkCategoryColor.Name = "btnDrinkCategoryColor"
        Me.btnDrinkCategoryColor.Size = New System.Drawing.Size(88, 40)
        Me.btnDrinkCategoryColor.TabIndex = 30
        Me.btnDrinkCategoryColor.Text = "Button Color"
        Me.btnDrinkCategoryColor.UseVisualStyleBackColor = False
        '
        'pnlDrinkModifiers
        '
        Me.pnlDrinkModifiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDrinkModifiers.Controls.Add(Me.btnDrinkPrices)
        Me.pnlDrinkModifiers.Controls.Add(Me.txtDrinkSplash)
        Me.pnlDrinkModifiers.Controls.Add(Me.txtDrinkTall)
        Me.pnlDrinkModifiers.Controls.Add(Me.txtDrinkUp)
        Me.pnlDrinkModifiers.Controls.Add(Me.txtDrinkRocks)
        Me.pnlDrinkModifiers.Controls.Add(Me.txtDrinkDouble)
        Me.pnlDrinkModifiers.Controls.Add(Me.lblDrinkSplash)
        Me.pnlDrinkModifiers.Controls.Add(Me.lblDrinkTall)
        Me.pnlDrinkModifiers.Controls.Add(Me.lblDrinkUp)
        Me.pnlDrinkModifiers.Controls.Add(Me.lblDrinkRocks)
        Me.pnlDrinkModifiers.Controls.Add(Me.lblDrinkDouble)
        Me.pnlDrinkModifiers.Location = New System.Drawing.Point(504, 272)
        Me.pnlDrinkModifiers.Name = "pnlDrinkModifiers"
        Me.pnlDrinkModifiers.Size = New System.Drawing.Size(208, 224)
        Me.pnlDrinkModifiers.TabIndex = 6
        Me.pnlDrinkModifiers.Visible = False
        '
        'btnDrinkPrices
        '
        Me.btnDrinkPrices.Location = New System.Drawing.Point(48, 184)
        Me.btnDrinkPrices.Name = "btnDrinkPrices"
        Me.btnDrinkPrices.Size = New System.Drawing.Size(128, 32)
        Me.btnDrinkPrices.TabIndex = 10
        Me.btnDrinkPrices.Text = "Update Prices"
        '
        'txtDrinkSplash
        '
        Me.txtDrinkSplash.Location = New System.Drawing.Point(128, 152)
        Me.txtDrinkSplash.Name = "txtDrinkSplash"
        Me.txtDrinkSplash.Size = New System.Drawing.Size(48, 20)
        Me.txtDrinkSplash.TabIndex = 9
        '
        'txtDrinkTall
        '
        Me.txtDrinkTall.Location = New System.Drawing.Point(128, 120)
        Me.txtDrinkTall.Name = "txtDrinkTall"
        Me.txtDrinkTall.Size = New System.Drawing.Size(48, 20)
        Me.txtDrinkTall.TabIndex = 8
        '
        'txtDrinkUp
        '
        Me.txtDrinkUp.Location = New System.Drawing.Point(128, 88)
        Me.txtDrinkUp.Name = "txtDrinkUp"
        Me.txtDrinkUp.Size = New System.Drawing.Size(48, 20)
        Me.txtDrinkUp.TabIndex = 7
        '
        'txtDrinkRocks
        '
        Me.txtDrinkRocks.Location = New System.Drawing.Point(128, 56)
        Me.txtDrinkRocks.Name = "txtDrinkRocks"
        Me.txtDrinkRocks.Size = New System.Drawing.Size(48, 20)
        Me.txtDrinkRocks.TabIndex = 6
        '
        'txtDrinkDouble
        '
        Me.txtDrinkDouble.Location = New System.Drawing.Point(128, 24)
        Me.txtDrinkDouble.Name = "txtDrinkDouble"
        Me.txtDrinkDouble.Size = New System.Drawing.Size(48, 20)
        Me.txtDrinkDouble.TabIndex = 5
        '
        'lblDrinkSplash
        '
        Me.lblDrinkSplash.Location = New System.Drawing.Point(24, 152)
        Me.lblDrinkSplash.Name = "lblDrinkSplash"
        Me.lblDrinkSplash.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkSplash.TabIndex = 4
        Me.lblDrinkSplash.Text = "Splash:"
        Me.lblDrinkSplash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDrinkTall
        '
        Me.lblDrinkTall.Location = New System.Drawing.Point(16, 120)
        Me.lblDrinkTall.Name = "lblDrinkTall"
        Me.lblDrinkTall.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkTall.TabIndex = 3
        Me.lblDrinkTall.Text = "Tall:"
        Me.lblDrinkTall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDrinkUp
        '
        Me.lblDrinkUp.Location = New System.Drawing.Point(16, 88)
        Me.lblDrinkUp.Name = "lblDrinkUp"
        Me.lblDrinkUp.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkUp.TabIndex = 2
        Me.lblDrinkUp.Text = "Up:"
        Me.lblDrinkUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDrinkRocks
        '
        Me.lblDrinkRocks.Location = New System.Drawing.Point(16, 56)
        Me.lblDrinkRocks.Name = "lblDrinkRocks"
        Me.lblDrinkRocks.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkRocks.TabIndex = 1
        Me.lblDrinkRocks.Text = "Rocks:"
        Me.lblDrinkRocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDrinkDouble
        '
        Me.lblDrinkDouble.Location = New System.Drawing.Point(16, 24)
        Me.lblDrinkDouble.Name = "lblDrinkDouble"
        Me.lblDrinkDouble.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkDouble.TabIndex = 0
        Me.lblDrinkDouble.Text = "Double:"
        Me.lblDrinkDouble.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlIsLiquorType
        '
        Me.pnlIsLiquorType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIsLiquorType.Controls.Add(Me.lblIsLiquorType)
        Me.pnlIsLiquorType.Controls.Add(Me.chkLiquorType)
        Me.pnlIsLiquorType.Location = New System.Drawing.Point(504, 104)
        Me.pnlIsLiquorType.Name = "pnlIsLiquorType"
        Me.pnlIsLiquorType.Size = New System.Drawing.Size(200, 88)
        Me.pnlIsLiquorType.TabIndex = 5
        '
        'lblIsLiquorType
        '
        Me.lblIsLiquorType.Location = New System.Drawing.Point(16, 40)
        Me.lblIsLiquorType.Name = "lblIsLiquorType"
        Me.lblIsLiquorType.Size = New System.Drawing.Size(168, 40)
        Me.lblIsLiquorType.TabIndex = 5
        Me.lblIsLiquorType.Text = "If checked, only place Brand Names under Category.          (ie. Vodka is a Liqou" & _
            "r Type)"
        Me.lblIsLiquorType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkLiquorType
        '
        Me.chkLiquorType.Location = New System.Drawing.Point(40, 8)
        Me.chkLiquorType.Name = "chkLiquorType"
        Me.chkLiquorType.Size = New System.Drawing.Size(120, 24)
        Me.chkLiquorType.TabIndex = 4
        Me.chkLiquorType.Text = "Is a Liquor Type?"
        '
        'lblDrinkCategoryName
        '
        Me.lblDrinkCategoryName.Location = New System.Drawing.Point(544, 40)
        Me.lblDrinkCategoryName.Name = "lblDrinkCategoryName"
        Me.lblDrinkCategoryName.Size = New System.Drawing.Size(120, 16)
        Me.lblDrinkCategoryName.TabIndex = 4
        Me.lblDrinkCategoryName.Text = "Category Name:"
        '
        'btnDrinkCategoryName
        '
        Me.btnDrinkCategoryName.Location = New System.Drawing.Point(552, 208)
        Me.btnDrinkCategoryName.Name = "btnDrinkCategoryName"
        Me.btnDrinkCategoryName.Size = New System.Drawing.Size(112, 40)
        Me.btnDrinkCategoryName.TabIndex = 2
        Me.btnDrinkCategoryName.Text = "Remove Category"
        Me.btnDrinkCategoryName.Visible = False
        '
        'txtDrinkCategoryName
        '
        Me.txtDrinkCategoryName.Location = New System.Drawing.Point(488, 64)
        Me.txtDrinkCategoryName.Name = "txtDrinkCategoryName"
        Me.txtDrinkCategoryName.Size = New System.Drawing.Size(232, 20)
        Me.txtDrinkCategoryName.TabIndex = 1
        '
        'pnlDrinkCategory
        '
        Me.pnlDrinkCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlDrinkCategory.Location = New System.Drawing.Point(16, 64)
        Me.pnlDrinkCategory.Name = "pnlDrinkCategory"
        Me.pnlDrinkCategory.Size = New System.Drawing.Size(448, 440)
        Me.pnlDrinkCategory.TabIndex = 0
        '
        'TabDrinks
        '
        Me.TabDrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabDrinks.Controls.Add(Me.lblDrinkHappyPrice)
        Me.TabDrinks.Controls.Add(Me.txtDrinkHappyPrice)
        Me.TabDrinks.Controls.Add(Me.Label3)
        Me.TabDrinks.Controls.Add(Me.cbxDrinkFunction)
        Me.TabDrinks.Controls.Add(Me.chkWineParring)
        Me.TabDrinks.Controls.Add(Me.txtAddOnPrice)
        Me.TabDrinks.Controls.Add(Me.Panel3)
        Me.TabDrinks.Controls.Add(Me.btnBackToCategory)
        Me.TabDrinks.Controls.Add(Me.txtDrinkDesc)
        Me.TabDrinks.Controls.Add(Me.chkIsAddOn)
        Me.TabDrinks.Controls.Add(Me.chkSelectAddOn)
        Me.TabDrinks.Controls.Add(Me.lblDrinkDescLabel)
        Me.TabDrinks.Controls.Add(Me.lblDrinkCost)
        Me.TabDrinks.Controls.Add(Me.txtDrinkPrice)
        Me.TabDrinks.Controls.Add(Me.txtDrinkName)
        Me.TabDrinks.Controls.Add(Me.lblDrinkName)
        Me.TabDrinks.Controls.Add(Me.pnlDrinks)
        Me.TabDrinks.Controls.Add(Me.pnlDrinkByCategory)
        Me.TabDrinks.Location = New System.Drawing.Point(4, 22)
        Me.TabDrinks.Name = "TabDrinks"
        Me.TabDrinks.Size = New System.Drawing.Size(840, 550)
        Me.TabDrinks.TabIndex = 5
        Me.TabDrinks.Text = "Bar Drinks"
        '
        'lblDrinkHappyPrice
        '
        Me.lblDrinkHappyPrice.Location = New System.Drawing.Point(488, 433)
        Me.lblDrinkHappyPrice.Name = "lblDrinkHappyPrice"
        Me.lblDrinkHappyPrice.Size = New System.Drawing.Size(120, 16)
        Me.lblDrinkHappyPrice.TabIndex = 22
        Me.lblDrinkHappyPrice.Text = "Happy Hour Price:"
        Me.lblDrinkHappyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDrinkHappyPrice
        '
        Me.txtDrinkHappyPrice.Location = New System.Drawing.Point(632, 433)
        Me.txtDrinkHappyPrice.Name = "txtDrinkHappyPrice"
        Me.txtDrinkHappyPrice.Size = New System.Drawing.Size(88, 20)
        Me.txtDrinkHappyPrice.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(496, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Tax Category:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxDrinkFunction
        '
        Me.cbxDrinkFunction.Location = New System.Drawing.Point(584, 80)
        Me.cbxDrinkFunction.Name = "cbxDrinkFunction"
        Me.cbxDrinkFunction.Size = New System.Drawing.Size(136, 21)
        Me.cbxDrinkFunction.TabIndex = 3
        '
        'chkWineParring
        '
        Me.chkWineParring.Location = New System.Drawing.Point(488, 288)
        Me.chkWineParring.Name = "chkWineParring"
        Me.chkWineParring.Size = New System.Drawing.Size(152, 24)
        Me.chkWineParring.TabIndex = 18
        Me.chkWineParring.TabStop = False
        Me.chkWineParring.Text = "Used as Wine Parring"
        '
        'txtAddOnPrice
        '
        Me.txtAddOnPrice.Location = New System.Drawing.Point(608, 256)
        Me.txtAddOnPrice.Name = "txtAddOnPrice"
        Me.txtAddOnPrice.Size = New System.Drawing.Size(112, 20)
        Me.txtAddOnPrice.TabIndex = 5
        Me.txtAddOnPrice.Text = "Add-on Price"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCallLiquor)
        Me.Panel3.Controls.Add(Me.cbxLiquorType)
        Me.Panel3.Controls.Add(Me.txtCallPrice)
        Me.Panel3.Controls.Add(Me.lblCallPrice)
        Me.Panel3.Location = New System.Drawing.Point(480, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 96)
        Me.Panel3.TabIndex = 16
        '
        'lblCallLiquor
        '
        Me.lblCallLiquor.Location = New System.Drawing.Point(24, 8)
        Me.lblCallLiquor.Name = "lblCallLiquor"
        Me.lblCallLiquor.Size = New System.Drawing.Size(192, 16)
        Me.lblCallLiquor.TabIndex = 19
        Me.lblCallLiquor.Text = "For Call Liquor Requests Only:"
        Me.lblCallLiquor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxLiquorType
        '
        Me.cbxLiquorType.Location = New System.Drawing.Point(24, 32)
        Me.cbxLiquorType.Name = "cbxLiquorType"
        Me.cbxLiquorType.Size = New System.Drawing.Size(196, 21)
        Me.cbxLiquorType.TabIndex = 18
        Me.cbxLiquorType.TabStop = False
        Me.cbxLiquorType.Text = "Liquor Type"
        '
        'txtCallPrice
        '
        Me.txtCallPrice.Location = New System.Drawing.Point(120, 64)
        Me.txtCallPrice.Name = "txtCallPrice"
        Me.txtCallPrice.Size = New System.Drawing.Size(96, 20)
        Me.txtCallPrice.TabIndex = 17
        Me.txtCallPrice.TabStop = False
        '
        'lblCallPrice
        '
        Me.lblCallPrice.Location = New System.Drawing.Point(16, 64)
        Me.lblCallPrice.Name = "lblCallPrice"
        Me.lblCallPrice.Size = New System.Drawing.Size(96, 16)
        Me.lblCallPrice.TabIndex = 16
        Me.lblCallPrice.Text = "Brand Surcharge:"
        Me.lblCallPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBackToCategory
        '
        Me.btnBackToCategory.ForeColor = System.Drawing.Color.White
        Me.btnBackToCategory.Location = New System.Drawing.Point(80, 16)
        Me.btnBackToCategory.Name = "btnBackToCategory"
        Me.btnBackToCategory.Size = New System.Drawing.Size(112, 40)
        Me.btnBackToCategory.TabIndex = 13
        Me.btnBackToCategory.Text = "Back To Category"
        '
        'txtDrinkDesc
        '
        Me.txtDrinkDesc.Location = New System.Drawing.Point(480, 120)
        Me.txtDrinkDesc.Name = "txtDrinkDesc"
        Me.txtDrinkDesc.Size = New System.Drawing.Size(240, 96)
        Me.txtDrinkDesc.TabIndex = 4
        Me.txtDrinkDesc.Text = ""
        '
        'chkIsAddOn
        '
        Me.chkIsAddOn.Location = New System.Drawing.Point(488, 256)
        Me.chkIsAddOn.Name = "chkIsAddOn"
        Me.chkIsAddOn.Size = New System.Drawing.Size(112, 24)
        Me.chkIsAddOn.TabIndex = 10
        Me.chkIsAddOn.TabStop = False
        Me.chkIsAddOn.Text = "Used as Add-On"
        '
        'chkSelectAddOn
        '
        Me.chkSelectAddOn.Location = New System.Drawing.Point(488, 224)
        Me.chkSelectAddOn.Name = "chkSelectAddOn"
        Me.chkSelectAddOn.Size = New System.Drawing.Size(120, 24)
        Me.chkSelectAddOn.TabIndex = 9
        Me.chkSelectAddOn.TabStop = False
        Me.chkSelectAddOn.Text = "Select Add-On"
        '
        'lblDrinkDescLabel
        '
        Me.lblDrinkDescLabel.Location = New System.Drawing.Point(488, 104)
        Me.lblDrinkDescLabel.Name = "lblDrinkDescLabel"
        Me.lblDrinkDescLabel.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkDescLabel.TabIndex = 8
        Me.lblDrinkDescLabel.Text = "Description:"
        Me.lblDrinkDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDrinkCost
        '
        Me.lblDrinkCost.Location = New System.Drawing.Point(488, 48)
        Me.lblDrinkCost.Name = "lblDrinkCost"
        Me.lblDrinkCost.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkCost.TabIndex = 6
        Me.lblDrinkCost.Text = "Drink Price:"
        Me.lblDrinkCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDrinkPrice
        '
        Me.txtDrinkPrice.Location = New System.Drawing.Point(632, 48)
        Me.txtDrinkPrice.Name = "txtDrinkPrice"
        Me.txtDrinkPrice.Size = New System.Drawing.Size(88, 20)
        Me.txtDrinkPrice.TabIndex = 2
        '
        'txtDrinkName
        '
        Me.txtDrinkName.Location = New System.Drawing.Point(584, 16)
        Me.txtDrinkName.Name = "txtDrinkName"
        Me.txtDrinkName.Size = New System.Drawing.Size(136, 20)
        Me.txtDrinkName.TabIndex = 1
        '
        'lblDrinkName
        '
        Me.lblDrinkName.Location = New System.Drawing.Point(488, 16)
        Me.lblDrinkName.Name = "lblDrinkName"
        Me.lblDrinkName.Size = New System.Drawing.Size(88, 16)
        Me.lblDrinkName.TabIndex = 2
        Me.lblDrinkName.Text = "Drink Name:"
        Me.lblDrinkName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlDrinks
        '
        Me.pnlDrinks.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlDrinks.Location = New System.Drawing.Point(16, 64)
        Me.pnlDrinks.Name = "pnlDrinks"
        Me.pnlDrinks.Size = New System.Drawing.Size(360, 344)
        Me.pnlDrinks.TabIndex = 1
        '
        'pnlDrinkByCategory
        '
        Me.pnlDrinkByCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlDrinkByCategory.Location = New System.Drawing.Point(16, 64)
        Me.pnlDrinkByCategory.Name = "pnlDrinkByCategory"
        Me.pnlDrinkByCategory.Size = New System.Drawing.Size(448, 440)
        Me.pnlDrinkByCategory.TabIndex = 0
        Me.pnlDrinkByCategory.Visible = False
        '
        'TabDrinkPrep
        '
        Me.TabDrinkPrep.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabDrinkPrep.Controls.Add(Me.Label25)
        Me.TabDrinkPrep.Location = New System.Drawing.Point(4, 22)
        Me.TabDrinkPrep.Name = "TabDrinkPrep"
        Me.TabDrinkPrep.Size = New System.Drawing.Size(840, 550)
        Me.TabDrinkPrep.TabIndex = 8
        Me.TabDrinkPrep.Text = "Drink Prep"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(672, 384)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(152, 120)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Only selected Drink Preps will display alphabetically. Place a number under Order" & _
            " ONLY if you want to prioritze higher (otherwise leave blank). "
        '
        'TabMenuSetup
        '
        Me.TabMenuSetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabMenuSetup.Controls.Add(Me.btnMenuBartender)
        Me.TabMenuSetup.Controls.Add(Me.lblMenuSetup)
        Me.TabMenuSetup.Controls.Add(Me.lblMenuPage2)
        Me.TabMenuSetup.Controls.Add(Me.lblMenuPage1)
        Me.TabMenuSetup.Controls.Add(Me.pnlMenuUpdate)
        Me.TabMenuSetup.Controls.Add(Me.menuActiveBox)
        Me.TabMenuSetup.Controls.Add(Me.btnMenuGeneralDrink)
        Me.TabMenuSetup.Controls.Add(Me.lblMenuSelectButtonText)
        Me.TabMenuSetup.Controls.Add(Me.cbxMenuDrink)
        Me.TabMenuSetup.Controls.Add(Me.cbxMenuMainFood)
        Me.TabMenuSetup.Controls.Add(Me.pnlMenuPage2)
        Me.TabMenuSetup.Controls.Add(Me.pnlMenuPage1)
        Me.TabMenuSetup.Controls.Add(Me.cbxMenuSelection)
        Me.TabMenuSetup.ForeColor = System.Drawing.Color.White
        Me.TabMenuSetup.Location = New System.Drawing.Point(4, 22)
        Me.TabMenuSetup.Name = "TabMenuSetup"
        Me.TabMenuSetup.Size = New System.Drawing.Size(840, 550)
        Me.TabMenuSetup.TabIndex = 6
        Me.TabMenuSetup.Text = "Menu Setup"
        '
        'btnMenuBartender
        '
        Me.btnMenuBartender.BackColor = System.Drawing.Color.Firebrick
        Me.btnMenuBartender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuBartender.Location = New System.Drawing.Point(30, 75)
        Me.btnMenuBartender.Name = "btnMenuBartender"
        Me.btnMenuBartender.Size = New System.Drawing.Size(136, 40)
        Me.btnMenuBartender.TabIndex = 20
        Me.btnMenuBartender.Text = "Table Service"
        Me.btnMenuBartender.UseVisualStyleBackColor = False
        '
        'lblMenuSetup
        '
        Me.lblMenuSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuSetup.ForeColor = System.Drawing.Color.Silver
        Me.lblMenuSetup.Location = New System.Drawing.Point(264, 16)
        Me.lblMenuSetup.Name = "lblMenuSetup"
        Me.lblMenuSetup.Size = New System.Drawing.Size(248, 32)
        Me.lblMenuSetup.TabIndex = 19
        Me.lblMenuSetup.Text = "Select Menu && Service"
        Me.lblMenuSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenuPage2
        '
        Me.lblMenuPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuPage2.ForeColor = System.Drawing.Color.Silver
        Me.lblMenuPage2.Location = New System.Drawing.Point(408, 64)
        Me.lblMenuPage2.Name = "lblMenuPage2"
        Me.lblMenuPage2.Size = New System.Drawing.Size(112, 24)
        Me.lblMenuPage2.TabIndex = 18
        Me.lblMenuPage2.Text = "Page 2"
        Me.lblMenuPage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenuPage1
        '
        Me.lblMenuPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuPage1.ForeColor = System.Drawing.Color.Silver
        Me.lblMenuPage1.Location = New System.Drawing.Point(248, 64)
        Me.lblMenuPage1.Name = "lblMenuPage1"
        Me.lblMenuPage1.Size = New System.Drawing.Size(112, 24)
        Me.lblMenuPage1.TabIndex = 17
        Me.lblMenuPage1.Text = "Page 1"
        Me.lblMenuPage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMenuUpdate
        '
        Me.pnlMenuUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.pnlMenuUpdate.Controls.Add(Me.btnRemoveMenuChoices)
        Me.pnlMenuUpdate.Controls.Add(Me.BtnUpdateMenuChoices)
        Me.pnlMenuUpdate.Location = New System.Drawing.Point(568, 432)
        Me.pnlMenuUpdate.Name = "pnlMenuUpdate"
        Me.pnlMenuUpdate.Size = New System.Drawing.Size(136, 72)
        Me.pnlMenuUpdate.TabIndex = 16
        Me.pnlMenuUpdate.Visible = False
        '
        'btnRemoveMenuChoices
        '
        Me.btnRemoveMenuChoices.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnRemoveMenuChoices.Location = New System.Drawing.Point(8, 40)
        Me.btnRemoveMenuChoices.Name = "btnRemoveMenuChoices"
        Me.btnRemoveMenuChoices.Size = New System.Drawing.Size(120, 24)
        Me.btnRemoveMenuChoices.TabIndex = 1
        Me.btnRemoveMenuChoices.Text = "Remove Category"
        Me.btnRemoveMenuChoices.UseVisualStyleBackColor = False
        '
        'BtnUpdateMenuChoices
        '
        Me.BtnUpdateMenuChoices.BackColor = System.Drawing.SystemColors.Desktop
        Me.BtnUpdateMenuChoices.Location = New System.Drawing.Point(8, 8)
        Me.BtnUpdateMenuChoices.Name = "BtnUpdateMenuChoices"
        Me.BtnUpdateMenuChoices.Size = New System.Drawing.Size(120, 24)
        Me.BtnUpdateMenuChoices.TabIndex = 0
        Me.BtnUpdateMenuChoices.Text = "Update Menu"
        Me.BtnUpdateMenuChoices.UseVisualStyleBackColor = False
        '
        'menuActiveBox
        '
        Me.menuActiveBox.Location = New System.Drawing.Point(46, 152)
        Me.menuActiveBox.Name = "menuActiveBox"
        Me.menuActiveBox.Size = New System.Drawing.Size(120, 136)
        Me.menuActiveBox.TabIndex = 15
        Me.menuActiveBox.TabStop = False
        Me.menuActiveBox.Text = "Active Menus"
        '
        'btnMenuGeneralDrink
        '
        Me.btnMenuGeneralDrink.Location = New System.Drawing.Point(568, 192)
        Me.btnMenuGeneralDrink.Name = "btnMenuGeneralDrink"
        Me.btnMenuGeneralDrink.Size = New System.Drawing.Size(136, 24)
        Me.btnMenuGeneralDrink.TabIndex = 6
        Me.btnMenuGeneralDrink.Text = "General Drink Button"
        '
        'lblMenuSelectButtonText
        '
        Me.lblMenuSelectButtonText.Location = New System.Drawing.Point(544, 64)
        Me.lblMenuSelectButtonText.Name = "lblMenuSelectButtonText"
        Me.lblMenuSelectButtonText.Size = New System.Drawing.Size(168, 32)
        Me.lblMenuSelectButtonText.TabIndex = 5
        Me.lblMenuSelectButtonText.Text = "Select Either a Main Food or Drink Category"
        Me.lblMenuSelectButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxMenuDrink
        '
        Me.cbxMenuDrink.Location = New System.Drawing.Point(544, 152)
        Me.cbxMenuDrink.MaxDropDownItems = 16
        Me.cbxMenuDrink.Name = "cbxMenuDrink"
        Me.cbxMenuDrink.Size = New System.Drawing.Size(176, 21)
        Me.cbxMenuDrink.TabIndex = 4
        Me.cbxMenuDrink.Text = "Select Drink Category"
        '
        'cbxMenuMainFood
        '
        Me.cbxMenuMainFood.Location = New System.Drawing.Point(544, 112)
        Me.cbxMenuMainFood.MaxDropDownItems = 16
        Me.cbxMenuMainFood.Name = "cbxMenuMainFood"
        Me.cbxMenuMainFood.Size = New System.Drawing.Size(176, 21)
        Me.cbxMenuMainFood.TabIndex = 3
        Me.cbxMenuMainFood.Text = "Select Main Food"
        '
        'pnlMenuPage2
        '
        Me.pnlMenuPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlMenuPage2.ForeColor = System.Drawing.Color.Black
        Me.pnlMenuPage2.Location = New System.Drawing.Point(400, 96)
        Me.pnlMenuPage2.Name = "pnlMenuPage2"
        Me.pnlMenuPage2.Size = New System.Drawing.Size(128, 336)
        Me.pnlMenuPage2.TabIndex = 2
        '
        'pnlMenuPage1
        '
        Me.pnlMenuPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlMenuPage1.ForeColor = System.Drawing.Color.Black
        Me.pnlMenuPage1.Location = New System.Drawing.Point(240, 96)
        Me.pnlMenuPage1.Name = "pnlMenuPage1"
        Me.pnlMenuPage1.Size = New System.Drawing.Size(128, 336)
        Me.pnlMenuPage1.TabIndex = 1
        '
        'cbxMenuSelection
        '
        Me.cbxMenuSelection.Location = New System.Drawing.Point(21, 37)
        Me.cbxMenuSelection.Name = "cbxMenuSelection"
        Me.cbxMenuSelection.Size = New System.Drawing.Size(168, 21)
        Me.cbxMenuSelection.TabIndex = 0
        Me.cbxMenuSelection.Text = "Choose Menu"
        '
        'TabFoodOrder
        '
        Me.TabFoodOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabFoodOrder.Controls.Add(Me.pnlOrderPage)
        Me.TabFoodOrder.Controls.Add(Me.cbxOrderSubCategroy)
        Me.TabFoodOrder.Controls.Add(Me.lblOrderDesc1)
        Me.TabFoodOrder.Controls.Add(Me.btnOrderDown)
        Me.TabFoodOrder.Controls.Add(Me.btnOrderUp)
        Me.TabFoodOrder.Controls.Add(Me.Panel4)
        Me.TabFoodOrder.Controls.Add(Me.lblOrderCategoryName)
        Me.TabFoodOrder.Controls.Add(Me.cbxOrderCategorySelection)
        Me.TabFoodOrder.Controls.Add(Me.pnlOrderFoodStaging)
        Me.TabFoodOrder.Controls.Add(Me.pnlOrderFoodItems)
        Me.TabFoodOrder.Controls.Add(Me.lblOrderMenuName)
        Me.TabFoodOrder.Controls.Add(Me.cbxOrderMenuSelection)
        Me.TabFoodOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabFoodOrder.Location = New System.Drawing.Point(4, 22)
        Me.TabFoodOrder.Name = "TabFoodOrder"
        Me.TabFoodOrder.Size = New System.Drawing.Size(840, 550)
        Me.TabFoodOrder.TabIndex = 7
        Me.TabFoodOrder.Text = "Menu Display"
        '
        'pnlOrderPage
        '
        Me.pnlOrderPage.Controls.Add(Me.btnOrderAdd)
        Me.pnlOrderPage.Controls.Add(Me.btnOrderRemove)
        Me.pnlOrderPage.Location = New System.Drawing.Point(41, 384)
        Me.pnlOrderPage.Name = "pnlOrderPage"
        Me.pnlOrderPage.Size = New System.Drawing.Size(107, 120)
        Me.pnlOrderPage.TabIndex = 16
        Me.pnlOrderPage.Visible = False
        '
        'btnOrderAdd
        '
        Me.btnOrderAdd.Location = New System.Drawing.Point(13, 13)
        Me.btnOrderAdd.Name = "btnOrderAdd"
        Me.btnOrderAdd.Size = New System.Drawing.Size(80, 40)
        Me.btnOrderAdd.TabIndex = 13
        Me.btnOrderAdd.Text = "Add Page"
        '
        'btnOrderRemove
        '
        Me.btnOrderRemove.Location = New System.Drawing.Point(13, 68)
        Me.btnOrderRemove.Name = "btnOrderRemove"
        Me.btnOrderRemove.Size = New System.Drawing.Size(80, 40)
        Me.btnOrderRemove.TabIndex = 12
        Me.btnOrderRemove.Text = "Remove Page"
        '
        'cbxOrderSubCategroy
        '
        Me.cbxOrderSubCategroy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrderSubCategroy.Location = New System.Drawing.Point(24, 152)
        Me.cbxOrderSubCategroy.MaxDropDownItems = 16
        Me.cbxOrderSubCategroy.Name = "cbxOrderSubCategroy"
        Me.cbxOrderSubCategroy.Size = New System.Drawing.Size(160, 21)
        Me.cbxOrderSubCategroy.TabIndex = 15
        Me.cbxOrderSubCategroy.Visible = False
        '
        'lblOrderDesc1
        '
        Me.lblOrderDesc1.ForeColor = System.Drawing.Color.White
        Me.lblOrderDesc1.Location = New System.Drawing.Point(704, 13)
        Me.lblOrderDesc1.Name = "lblOrderDesc1"
        Me.lblOrderDesc1.Size = New System.Drawing.Size(104, 32)
        Me.lblOrderDesc1.TabIndex = 11
        Me.lblOrderDesc1.Text = "2 panels left blank intentionally"
        Me.lblOrderDesc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrderDown
        '
        Me.btnOrderDown.ForeColor = System.Drawing.Color.White
        Me.btnOrderDown.Location = New System.Drawing.Point(707, 472)
        Me.btnOrderDown.Name = "btnOrderDown"
        Me.btnOrderDown.Size = New System.Drawing.Size(104, 32)
        Me.btnOrderDown.TabIndex = 10
        Me.btnOrderDown.Text = "Down"
        '
        'btnOrderUp
        '
        Me.btnOrderUp.ForeColor = System.Drawing.Color.White
        Me.btnOrderUp.Location = New System.Drawing.Point(707, 48)
        Me.btnOrderUp.Name = "btnOrderUp"
        Me.btnOrderUp.Size = New System.Drawing.Size(104, 32)
        Me.btnOrderUp.TabIndex = 9
        Me.btnOrderUp.Text = "Up"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.btnOrderUpdateStaging)
        Me.Panel4.Location = New System.Drawing.Point(690, 507)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(136, 40)
        Me.Panel4.TabIndex = 8
        '
        'btnOrderUpdateStaging
        '
        Me.btnOrderUpdateStaging.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnOrderUpdateStaging.ForeColor = System.Drawing.Color.White
        Me.btnOrderUpdateStaging.Location = New System.Drawing.Point(8, 8)
        Me.btnOrderUpdateStaging.Name = "btnOrderUpdateStaging"
        Me.btnOrderUpdateStaging.Size = New System.Drawing.Size(120, 24)
        Me.btnOrderUpdateStaging.TabIndex = 0
        Me.btnOrderUpdateStaging.Text = "Update Staging"
        Me.btnOrderUpdateStaging.UseVisualStyleBackColor = False
        '
        'lblOrderCategoryName
        '
        Me.lblOrderCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderCategoryName.ForeColor = System.Drawing.Color.IndianRed
        Me.lblOrderCategoryName.Location = New System.Drawing.Point(304, 40)
        Me.lblOrderCategoryName.Name = "lblOrderCategoryName"
        Me.lblOrderCategoryName.Size = New System.Drawing.Size(280, 24)
        Me.lblOrderCategoryName.TabIndex = 7
        Me.lblOrderCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxOrderCategorySelection
        '
        Me.cbxOrderCategorySelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrderCategorySelection.Location = New System.Drawing.Point(24, 104)
        Me.cbxOrderCategorySelection.MaxDropDownItems = 16
        Me.cbxOrderCategorySelection.Name = "cbxOrderCategorySelection"
        Me.cbxOrderCategorySelection.Size = New System.Drawing.Size(160, 21)
        Me.cbxOrderCategorySelection.TabIndex = 6
        '
        'pnlOrderFoodStaging
        '
        Me.pnlOrderFoodStaging.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlOrderFoodStaging.Location = New System.Drawing.Point(707, 80)
        Me.pnlOrderFoodStaging.Name = "pnlOrderFoodStaging"
        Me.pnlOrderFoodStaging.Size = New System.Drawing.Size(104, 392)
        Me.pnlOrderFoodStaging.TabIndex = 5
        '
        'pnlOrderFoodItems
        '
        Me.pnlOrderFoodItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlOrderFoodItems.Location = New System.Drawing.Point(200, 80)
        Me.pnlOrderFoodItems.Name = "pnlOrderFoodItems"
        Me.pnlOrderFoodItems.Size = New System.Drawing.Size(456, 392)
        Me.pnlOrderFoodItems.TabIndex = 3
        '
        'lblOrderMenuName
        '
        Me.lblOrderMenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMenuName.ForeColor = System.Drawing.Color.IndianRed
        Me.lblOrderMenuName.Location = New System.Drawing.Point(304, 16)
        Me.lblOrderMenuName.Name = "lblOrderMenuName"
        Me.lblOrderMenuName.Size = New System.Drawing.Size(256, 24)
        Me.lblOrderMenuName.TabIndex = 1
        Me.lblOrderMenuName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbxOrderMenuSelection
        '
        Me.cbxOrderMenuSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrderMenuSelection.Location = New System.Drawing.Point(24, 56)
        Me.cbxOrderMenuSelection.Name = "cbxOrderMenuSelection"
        Me.cbxOrderMenuSelection.Size = New System.Drawing.Size(160, 21)
        Me.cbxOrderMenuSelection.TabIndex = 0
        Me.cbxOrderMenuSelection.Text = "Select Menu"
        '
        'pnlDrinkUpdate
        '
        Me.pnlDrinkUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDrinkUpdate.Controls.Add(Me.btnDeleteDrink)
        Me.pnlDrinkUpdate.Location = New System.Drawing.Point(804, 85)
        Me.pnlDrinkUpdate.Name = "pnlDrinkUpdate"
        Me.pnlDrinkUpdate.Size = New System.Drawing.Size(50, 49)
        Me.pnlDrinkUpdate.TabIndex = 4
        Me.pnlDrinkUpdate.Visible = False
        '
        'btnDeleteDrink
        '
        Me.btnDeleteDrink.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnDeleteDrink.Location = New System.Drawing.Point(16, 8)
        Me.btnDeleteDrink.Name = "btnDeleteDrink"
        Me.btnDeleteDrink.Size = New System.Drawing.Size(74, 38)
        Me.btnDeleteDrink.TabIndex = 1
        Me.btnDeleteDrink.Text = "Delete Drink"
        Me.btnDeleteDrink.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SetupMenu
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlDrinkUpdate)
        Me.Name = "SetupMenu"
        Me.Size = New System.Drawing.Size(888, 720)
        Me.tabCategory.ResumeLayout(False)
        Me.pnlNewCategory.ResumeLayout(False)
        Me.pnlNewCategory.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabModifiers.ResumeLayout(False)
        Me.pnlModifierPage.ResumeLayout(False)
        Me.pnlNewModifier.ResumeLayout(False)
        Me.pnlNewModifier.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnlUpdateModifiers.ResumeLayout(False)
        Me.TabMainFood.ResumeLayout(False)
        Me.TabMainFood.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNewFood.ResumeLayout(False)
        Me.pnlNewFood.PerformLayout()
        CType(Me.grdFoodList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabFoodJoin.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.grdJoinFoodModifierJoins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdJoinFoodChoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdJoinFoodCategoryJoins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdJoinIndividualModifiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdJoinPossibleCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabDrinkCategory.ResumeLayout(False)
        Me.TabDrinkCategory.PerformLayout()
        Me.pnlDrinkModifiers.ResumeLayout(False)
        Me.pnlDrinkModifiers.PerformLayout()
        Me.pnlIsLiquorType.ResumeLayout(False)
        Me.TabDrinks.ResumeLayout(False)
        Me.TabDrinks.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabDrinkPrep.ResumeLayout(False)
        Me.TabMenuSetup.ResumeLayout(False)
        Me.pnlMenuUpdate.ResumeLayout(False)
        Me.TabFoodOrder.ResumeLayout(False)
        Me.pnlOrderPage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlDrinkUpdate.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()
        '       ReInitializeSQLConnection()

        bartnerderMenuMode = "Table Service"

        dsSetup.Tables("LocationOpening").Clear()
        sql.SqlSelectLocationOpening.Parameters("@LocationID").Value = corpPhysicalLocation 'selectedLocation


        dsSetup.Tables("FoodTable").Clear()
        '   PopulateLocationMenu(corpID, selectedLocation)
        sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation
        'Category
        sql.SqlSelectCommandCategoryMain.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCategoryMain.Parameters("@LocationID").Value = selectedLocation
        '      sql.SqlSelectCommandCategoryModifier.Parameters("@CompanyID").Value = corpID
        '     sql.SqlSelectCommandCategoryModifier.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("MenuJoin").Clear()
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("Menus").Clear()
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("Modifiers").Clear()
        sql.SqlSelectCommandModifiers.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandModifiers.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("Drinks").Clear()
        sql.SqlSelectCommandMenuDrinks.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuDrinks.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("DrinkCategory").Clear()
        sql.SqlSelectCommandMenuDrinkCategory.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuDrinkCategory.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("DrinkModifiers").Clear()
        sql.SqlSelectCommandMenuDrinkModifiers.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuDrinkModifiers.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("WineParring").Clear()
        sql.SqlSelectCommandMenuWineParring.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuWineParring.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("LiquorTypes").Clear()
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("DrinkPrep").Clear()
        
        dsSetup.Tables("DrinkPrepLocation").Clear()
        sql.SqlSelectCommandMenuDrinkPrepLocation.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuDrinkPrepLocation.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("FoodJoin").Clear()
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@FoodID").Value = 0

        dsSetup.Tables("JoinFoodCategoryJoins").Clear()
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@FoodID").Value = 0

        dsSetup.Tables("JoinFoodModifierJoins").Clear()
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@FoodID").Value = 0

        dsSetup.Tables("Promotion").Clear()
        sql.SqlSelectCommandPromoPromotion.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandPromoPromotion.Parameters("@LocationID").Value = selectedLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            GenerateCategoryDataSets(corpID, selectedLocation)
            sql.SqlLocationOpening.Fill(dsSetup.Tables("LocationOpening"))
            sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
            sql.SqlMenuCategoryMain.Fill(dsSetup.Tables("MainCategory"))
            sql.SqlMenuMenuJoin.Fill(dsSetup.Tables("MenuJoin"))
            sql.SqlMenuMenuChoice.Fill(dsSetup.Tables("Menus"))
            '        sql.SqlMenuCategoryModifier.Fill(dsSetup.Tables("ModifierCategory"))
            sql.SqlMenuModifiers.Fill(dsSetup.Tables("Modifiers"))
            sql.SqlMenuDrinks.Fill(dsSetup.Tables("Drinks"))
            sql.SqlMenuDrinkCategory.Fill(dsSetup.Tables("DrinkCategory"))
            sql.SqlMenuDrinkModifiers.Fill(dsSetup.Tables("DrinkModifiers"))
            sql.SqlMenuWineParring.Fill(dsSetup.Tables("WineParring"))
            sql.SqlMenuLiquorTypes.Fill(dsSetup.Tables("LiquorTypes"))
            sql.SqlMenuDrinkPrep.Fill(dsSetup.Tables("DrinkPrep"))
            sql.SqlMenuDrinkPrepLocation.Fill(dsSetup.Tables("DrinkPrepLocation"))
            sql.SqlJoinFoodJoin.Fill(dsSetup.Tables("FoodJoin"))
            sql.SqlJoinFoodCategoryJoins.Fill(dsSetup.Tables("JoinFoodCategoryJoins"))
            sql.SqlJoinFoodModiferJoins.Fill(dsSetup.Tables("JoinFoodModifierJoins"))
            sql.SqlPromoPromotion.Fill(dsSetup.Tables("Promotion"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        SetUpPrimaryKeys()
        StartMenu()

    End Sub

    Friend Sub StartMenu()

        CreateDataViews()

        BindData()

        newCategory.CategoryIndexMore = 1
        DisplayMainCategoryPanel(newCategory.CategoryIndexMore)

        newCategory.CategoryIndexModifier = 1
        DisplayModifierCategoryPanel(newCategory.CategoryIndexModifier)

        DisplayMenuSelectionPanel()

        DisplayFoodTab()

        DisplayFoodJoinGrids()
        newFoodJoin.ActiveCategoryRow = -1
        newFoodJoin.ActiveModifierRow = -1

        DisplayMenuCostGroupBox()

        PopulateMenuCostGroupBox()

        DisplayDrinkCategoryPanel()

        DisplayDrinkCategoryPanel2()

        DisplayDrinkByCategoryPanel()

        '444    DisplayDrinkModifiers()

        DisplayDrinkPrep()

        DisplayMenuPages()

        CreateStagingPanel()

        Me.pnlNewFood.Location = New Point(240, 64)
        Me.pnlNewModifier.Location = New Point(424, 16)

    End Sub


    Friend Sub PopulateLocationMenu(ByRef corpID As String, ByRef locID As String)

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
            sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = locID
            '         sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = 0   '1000
            sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub CreateDataViews()


        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "(FunctionFlag = 'O' OR FunctionFlag = 'F')"
        End With

        With dvFoodsJoins
            .Table = dsSetup.Tables("FoodTable")
        End With

        With dvModifiers
            .Table = dsSetup.Tables("Modifiers")
            .AllowEdit = True
            .RowFilter = "CategoryID > 0"
            .RowStateFilter = DataViewRowState.CurrentRows
            .Sort = "CategoryID, FoodName"
        End With

        '444     With dvMainCategory
        '444    .Table = dsSetup.Tables("MainCategory")
        'old      .RowFilter = "FunctionFlag = 'F' OR FunctionFlag = 'O'" ' AND CategoryOrder < 11"
        'old       .Sort = "CategoryOrder"
        '444    End With

        '      With dvModifierCategory
        '     .Table = dsSetup.Tables("MainCategory")
        '    .RowFilter = "FunctionFlag = 'M'"
        '   '       .Sort = "CategoryOrder"
        '  End With



    End Sub
    Private Sub BindData()
        Dim oRow As DataRow

        '*********************
        ' this may work for auto binding
        '    Me.BindingContext(myobj).EndCurrentEdit

        'category
        Me.cbxNewCategoryFunction.Items.Add("Choose Function")

        '       For Each oRow In dsSetup.Tables("Functions").Rows
        '      If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
        '     If oRow("FunctionFlag") = "F" Or oRow("FunctionFlag") = "M" Or oRow("FunctionFlag") = "O" Then
        '                 Me.cbxCategoryFunction.Items.Add(oRow("FunctionName"))
        '                Me.cbxNewCategoryFunction.Items.Add(oRow("FunctionName"))
        '      End If
        '     End If
        '    Next

        Me.cbxCategroyPriority.Items.Add("Highest")
        Me.cbxCategroyPriority.Items.Add("High")
        Me.cbxCategroyPriority.Items.Add("Medium")
        Me.cbxCategroyPriority.Items.Add("Low")
        Me.cbxCategroyPriority.Items.Add("Lowest")

        Me.cbxNewCategroyPriority.Items.Add("Highest")
        Me.cbxNewCategroyPriority.Items.Add("High")
        Me.cbxNewCategroyPriority.Items.Add("Medium")
        Me.cbxNewCategroyPriority.Items.Add("Low")
        Me.cbxNewCategroyPriority.Items.Add("Lowest")

        ' binds food data
        '      grdFoodList.DataSource = dsSetup.Tables("FoodTable")

        For Each oRow In dsSetup.Tables("RoutingChoice").Rows
            '     cbxFoodRouting.Items.Add(oRow("RoutingName"))
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                Me.cbxModifierRouting.Items.Add(oRow("RoutingName"))
            End If

        Next
        Me.cbxModifierRouting.Items.Add("Route w/ Food")

        For Each oRow In dsSetup.Tables("PrintPriority").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                cbxPrintPriority.Items.Add(oRow("PrintPriorityName"))
            End If
        Next

        For Each oRow In dsSetup.Tables("WineParring").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                cbxWineParring.Items.Add(oRow("DrinkName"))
            End If
        Next

        '444       For Each oRow In dsSetup.Tables("TaxTable").Rows
        '       If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
        'cbxFoodTax.Items.Add(oRow("TaxName"))
        '      End If
        '     Next

        txtFoodName.DataBindings.Add("Text", dvFoods, "FoodName")
        txtAbrevFoodName.DataBindings.Add("Text", dvFoods, "AbrevFoodName")
        txtChitFoodName.DataBindings.Add("Text", dvFoods, "ChitFoodName")
        cbxFoodCategory.DataBindings.Add("Text", dvFoods, "CategoryName")
        '     cbxFoodRouting.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "RoutingName")
        cbxPrintPriority.DataBindings.Add("Text", dvFoods, "PrintPriorityName")
        cbxWineParring.DataBindings.Add("Text", dvFoods, "DrinkName")
        '      lblRecipe.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "FoodDesc")
        txtRecipe.DataBindings.Add("Text", dvFoods, "FoodDesc")

        '    txtSurcharge.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "Surcharge")
        '      cbxFoodTax.DataBindings.Add("Text", dvFoods, "TaxName")
        txtFoodCost.DataBindings.Add("Text", dvFoods, "FoodCost")
        txtFoodInvMultiplier.DataBindings.Add("Text", dvFoods, "InvMultiplier")
        chkManual.DataBindings.Add("Checked", dvFoods, "FoodCostManual")
        '   lblSelectFoodFilter.DataBindings.Add("Text", dvFoods, "FoodName")

        FoodCurrencyMan = Me.BindingContext(dvFoods) 'dsSetup.Tables("FoodTable"))
        grdFoodList.DataSource = dvFoods ' dsSetup.Tables("FoodTable")


        '       txtCategoryName.DataBindings.Add("Text", dvMainCategory, "CategoryName")
        '       Me.txtCategoryAbrev.DataBindings.Add("Text", dvMainCategory, "CategoryAbrev")
        '      Me.cbxCategoryFunction.DataBindings.Add("Text", dvMainCategory, "FunctionName")
        '      cbxCategroyPriority.DataBindings.Add("Text", dvMainCategory, "PrintPriorityName")
        '      chkHalfSplit.DataBindings.Add("Checked", dvMainCategory, "HalfSplit")
        '      chkCategoryActive.DataBindings.Add("Checked", dvMainCategory, "Active")
        '      chkExtendedDisplay.DataBindings.Add("Checked", dvMainCategory, "Extended")
        '      chkDisplayWithAdd.DataBindings.Add("Checked", dvMainCategory, "DisplayWithAdd")
        '      mainCatCurrencyMan = Me.BindingContext(dvMainCategory)
        '      above(wrong(wrong))

        txtCategoryName.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "CategoryName")
        Me.txtCategoryAbrev.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "CategoryAbrev")
        Me.cbxCategoryFunction.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "FunctionName")
        cbxCategroyPriority.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "PrintPriorityName")
        chkHalfSplit.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "HalfSplit")
        chkCategoryActive.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "Active")
        chkExtendedDisplay.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "Extended")
        chkDisplayWithAdd.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "DisplayWithAdd")
        mainCatCurrencyMan = Me.BindingContext(dsSetup.Tables("MainCategory"))

        'Category Buttons


        '********  Modifiers


        '   routingName populated in food

        txtModifierName.DataBindings.Add("Text", dvModifiers, "FoodName")
        Me.txtModifierAbrev.DataBindings.Add("Text", dvModifiers, "AbrevFoodName")
        Me.txtModifierChit.DataBindings.Add("Text", dvModifiers, "ChitFoodName")
        txtModifierCost.DataBindings.Add("Text", dvModifiers, "FoodCost")
        Me.txtModifierSurcharge.DataBindings.Add("Text", dvModifiers, "Surcharge")
        '     'old        cbxModifierFilter.DataBindings.Add("Text", dsSetup.Tables("ModifierCategory"), "CategoryName") 'dsSetup.Tables("Modifiers"), "CategoryName")
        Me.cbxModifierRouting.DataBindings.Add("Text", dvModifiers, "RoutingName")
        '    'old temp remv.    Me.lblSelectModifierFilter.DataBindings.Add("Text", dsSetup.Tables("Modifiers"), "CategoryName") 'dsSetup.Tables("Modifiers"), "FoodName")
        Me.txtModifierDescription.DataBindings.Add("Text", dvModifiers, "FoodDesc")

        ModifierCurrencyMan = Me.BindingContext(dvModifiers)    '(dsSetup.Tables("Modifiers"))
        JoinIndividualMan = Me.BindingContext(dsSetup.Tables("FoodJoin"))

        '    grdModifiers.DataSource = dsSetup.Tables("Modifiers") 'dvModifiers


        '**********************
        '   Food / Modifier Link

        grdJoinFoodChoice.DataSource = dvFoodsJoins 'dvFoods  ' dsSetup.Tables("FoodTable")
        grdJoinFoodCategoryJoins.DataSource = dsSetup.Tables("JoinFoodCategoryJoins")
        grdJoinFoodModifierJoins.DataSource = dsSetup.Tables("JoinFoodModifierJoins")
        '   grdJoinFoodModifierJoins.DataBindings =

        grdJoinPossibleCategories.DataSource = dvMainCategoryFoodJoin 'dsSetup.Tables("Main_ModifierCategory2") '("ModifierCategory")
        grdJoinIndividualModifiers.DataSource = dvModifiers2 'dsSetup.Tables("Modifiers2")
        '     Me.grdJoinFoodCategoryJoins.SetDataBinding(dsSetup.Tables("JoinFoodCategoryJoins"), "dvJoinFoodCategoryJoins")


        '      cbxJoinCategorySelect.DataSource = dsSetup.Tables("MainCategory")
        '      cbxJoinCategorySelect.DisplayMember = "CategoryName"
        '      cbxJoinCategorySelect.SelectedIndex = -1



        '    For Each oRow In dsSetup.Tables("ModifierCategory").Rows
        '   cbxJoinIndividualModifierSelect.Items.Add(oRow("CategoryName"))
        '  Next
        '        cbxJoinIndividualModifierSelect.DataSource = dsSetup.Tables("ModifierCategory")
        '        cbxJoinIndividualModifierSelect.DisplayMember = "CategoryName"
        '        cbxJoinIndividualModifierSelect.SelectedIndex = -1

        '********************************
        '   Drinks

        '      txtDrinkName.DataBindings.Add("Text", dvDrinksByCategory, "CategoryName")
        '      Me.txtDrinkPrice.DataBindings.Add("Text", dvDrinksByCategory, "CategoryAbrev")
        '      Me.txtDrinkDesc.DataBindings.Add("Text", dvDrinksByCategory, "FunctionName")
        '     Me.txtCallPrice.DataBindings.Add("Text", dvDrinksByCategory, "PrintPriorityName")
        '     Me.txtAddOnPrice.DataBindings.Add("Checked", dvDrinksByCategory, "HalfSplit")
        ''     Me.chkSelectAddOn.DataBindings.Add("Checked", dvDrinksByCategory, "Active")
        '     Me.chkIsAddOn.DataBindings.Add("Checked", dvDrinksByCategory, "Active")
        '     Me.chkWineParring.DataBindings.Add("Checked", dvDrinksByCategory, "Active")
        ''
        '       Me.cbxDrinkFunction.DataBindings.Add("Text", dvDrinksByCategory, "RoutingName")


        PopulateDrinkCategoriesNames()
        For Each oRow In dsSetup.Tables("DrinkFunctions").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                Me.cbxDrinkFunction.Items.Add(oRow("FunctionName"))
            End If
        Next


        '      txtDrinkDouble.DataBindings.Add("Text", dsSetup.Tables("DrinkModifiers"), "DrinkPrice")
        '**********************************
        '   Menu

        PopulateMenuSelectionComboBox()

        For Each oRow In dsSetup.Tables("DrinkCategory").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If Not oRow("DrinkCategoryName") Is DBNull.Value Then
                    Me.cbxMenuDrink.Items.Add(oRow("DrinkCategoryName"))
                End If
            End If
        Next

        '**************************************
        '   Food Order

        For Each oRow In dsSetup.Tables("Menus").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                Me.cbxOrderMenuSelection.Items.Add(oRow("MenuName"))
            End If
        Next


    End Sub

    Private Sub PopulateMenuSelectionComboBox()
        Dim oRow As DataRow
        Me.cbxMenuSelection.Items.Clear()

        For Each oRow In dsSetup.Tables("Menus").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                cbxMenuSelection.Items.Add(oRow("MenuName"))
            End If
        Next

    End Sub

    Private Sub PopulateDrinkCategoriesNames()
        Dim oRow As DataRow
        Me.cbxLiquorType.Items.Clear()

        dsSetup.Tables("LiquorTypes").Clear()
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@LocationID").Value = selectedLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuLiquorTypes.Fill(dsSetup.Tables("LiquorTypes"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Me.cbxLiquorType.Items.Add("No Liquor Type")
        For Each oRow In dsSetup.Tables("LiquorTypes").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                cbxLiquorType.Items.Add(oRow("DrinkCategoryName"))
            End If
        Next

    End Sub


    '*****************************************************************
    '   Category
    '*****************************************************************

    Friend Sub DisplayMainCategoryPanel(ByVal startIndex As Integer)


        '      newCategory = New ActiveCategory
        '     newCategory.CategoryIndexMore = 1
        '    newCategory.CategoryIndexModifier = 1
        Me.pnlNewCategory.Location = New Point(32, 40)

        Dim newCategoryID As Integer

        ' readjust size of panel
        If dsSetup.Tables("MainCategory").Rows.Count = 0 Then
            '        MainCategoryPanel.Size = New Size(ssX * 0.1, ssY * 0.2)
        End If

        ' at this point keeping the same
        Dim btnWidth As Integer = Me.MainCategoryPanel.Width - (2 * buttonSpace)
        Dim btnheight As Integer = (Me.MainCategoryPanel.Height - (11 * buttonSpace)) / 10
        '      MainCategoryPanel.Size = New System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace)

        Dim index As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace

        For index = 1 To 10
            btnMain(index) = New OrderButton
            With btnMain(index)
                .BtnNumber = index
                .Size = New Size(btnWidth, btnheight)
                .Location = New Point(x, y)
                .TabStop = False
                '           .BtnIndex = index
                .IsActive = True

                '      btnMainCollection.Add(btnMain(index))
                MainCategoryPanel.Controls.Add(btnMain(index))

                AddHandler btnMain(index).Click, AddressOf UpdateMainCategory

            End With
            y = y + btnheight + buttonSpace
        Next

        PopulateMainCategoryPanel(1)

    End Sub

    Private Sub PopulateMainCategoryPanel(ByVal startIndex As Integer)
        Dim index As Integer
        Dim position As Integer
        Dim vRow As DataRow
        Dim dataViewCount As Integer
        Dim wasPopulated As Boolean

        For position = 1 To 10
            With btnMain(position)
                .ID = Nothing
                .Name = Nothing
                .Text = Nothing
                .Functions = Nothing
                .BackColor = Color.White
            End With
        Next
        position = 1

        '   *** may be a problem with positio if ther is a deleted row  ??????
        For index = startIndex To (startIndex + 9) '(dsSetup.Tables("MainCategory").Rows.Count))
            dataViewCount = 0
            'vRow = dvMainCategory(index)
            For Each vRow In dsSetup.Tables("MainCategory").Rows ' dvMainCategory 
                If vRow("FunctionFlag") = "F" Or vRow("FunctionFlag") = "O" Or vRow("FunctionFlag") = "G" Then
                    If vRow("CategoryOrder") = index Then

                        With btnMain(position)
                            .DataViewIndex = dataViewCount
                            .ID = vRow("CategoryID")
                            .BtnIndex = index
                            .Name = vRow("CategoryName")
                            .Text = vRow("CategoryAbrev")
                            .Functions = vRow("FunctionID")
                            .HalfSplit = vRow("HalfSplit")
                            .IsActive = vRow("Active")
                            .Priority = vRow("Priority")
                            If Not vRow("ButtonColor") Is DBNull.Value Then
                                .ColorInt = vRow("ButtonColor")
                            Else
                                .ColorInt = -9404272    'slateGray
                            End If
                            If Not vRow("ButtonForeColor") Is DBNull.Value Then
                                .ColorForeInt = vRow("ButtonForeColor")
                            Else
                                .ColorForeInt = -16777216    'Black
                            End If
                            .BackColor = Color.FromArgb(.ColorInt)
                            .ForeColor = Color.FromArgb(.ColorForeInt)
                        End With
                        wasPopulated = True
                    End If
                End If
                '      If Not vRow.RowState = DataRowState.Deleted And Not vRow.RowState = DataRowState.Detached Then
                dataViewCount += 1
                '     End If
            Next
            If wasPopulated = False Then
                btnMain(position).BtnIndex = index
            Else
                wasPopulated = False
            End If

            position += 1
        Next

    End Sub

    Private Sub DisplayModifierCategoryPanel(ByVal startIndex As Integer)

        Dim btnWidth As Integer = Me.ModifierCategoryPanel.Width - (2 * buttonSpace)
        Dim btnheight As Integer = (Me.ModifierCategoryPanel.Height - (11 * buttonSpace)) / 10
        '     ModifierCategoryPanel.Size = New System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace)

        Dim index As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace

        For index = 1 To 10
            btnModifier(index) = New OrderButton
            With btnModifier(index)
                .BtnNumber = index
                .Size = New Size(btnWidth, btnheight)
                .Location = New Point(x, y)
                .TabStop = False
                '         .BtnIndex = index
                .IsActive = True

                ModifierCategoryPanel.Controls.Add(btnModifier(index))

                AddHandler btnModifier(index).Click, AddressOf UpdateMainCategory   'UpdateModifierCategory

            End With
            y = y + btnheight + buttonSpace
        Next

        PopulateModifierCategoryPanel(1)

    End Sub

    Private Sub PopulateModifierCategoryPanel(ByVal startIndex As Integer)
        Dim index As Integer
        Dim position As Integer
        Dim vRow As DataRow
        Dim dataViewCount As Integer
        Dim wasPopulated As Boolean

        For position = 1 To 10
            With btnModifier(position)
                .ID = Nothing
                .Name = Nothing
                .Text = Nothing
                .Functions = Nothing
                .BackColor = Color.White
            End With
        Next
        position = 1

        For index = startIndex To (startIndex + 9) '(dsSetup.Tables("ModifierCategory").Rows.Count))
            dataViewCount = 0

            For Each vRow In dsSetup.Tables("MainCategory").Rows ' dvMainCategory '
                If vRow("FunctionFlag") = "M" Then
                    '        If Not vRow.RowState = DataRowState.Deleted And Not vRow.RowState = DataRowState.Detached Then
                    If vRow("CategoryOrder") = index Then
                        With btnModifier(position)
                            .DataViewIndex = dataViewCount
                            .ID = vRow("CategoryID")
                            .BtnIndex = index
                            .Name = vRow("CategoryName")
                            .Text = vRow("CategoryAbrev")
                            .Functions = vRow("FunctionID")
                            .HalfSplit = vRow("HalfSplit")
                            .IsActive = vRow("Active")
                            .Priority = vRow("Priority")
                            If Not vRow("ButtonColor") Is DBNull.Value Then
                                .ColorInt = vRow("ButtonColor")
                            Else
                                .ColorInt = -9404272    'slateGray
                            End If
                            If Not vRow("ButtonForeColor") Is DBNull.Value Then
                                .ColorForeInt = vRow("ButtonForeColor")
                            Else
                                .ColorForeInt = -16777216    'Black
                            End If

                            .BackColor = Color.FromArgb(.ColorInt)
                            .ForeColor = Color.FromArgb(.ColorForeInt)

                        End With
                        wasPopulated = True
                    End If
                End If
                dataViewCount += 1
                '       End If
            Next
            If wasPopulated = False Then
                btnModifier(position).BtnIndex = index
            Else
                wasPopulated = False
            End If
            position += 1
        Next

    End Sub
    Private Sub btnMainMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMore.Click
        If newCategory.CategoryIndexMore < 91 Then
            newCategory.CategoryIndexMore += 10
            PopulateMainCategoryPanel(newCategory.CategoryIndexMore)
        End If
    End Sub

    Private Sub btnMainPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainPrevious.Click
        If newCategory.CategoryIndexMore > 1 Then
            newCategory.CategoryIndexMore -= 10
            PopulateMainCategoryPanel(newCategory.CategoryIndexMore)
        End If
    End Sub
    Private Sub btnModifierMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifierMore.Click
        If newCategory.CategoryIndexModifier < 91 Then
            newCategory.CategoryIndexModifier += 10
            PopulateModifierCategoryPanel(newCategory.CategoryIndexModifier)
        End If
    End Sub

    Private Sub btnModifierPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifierPrevious.Click
        If newCategory.CategoryIndexModifier > 1 Then
            newCategory.CategoryIndexModifier -= 10
            PopulateModifierCategoryPanel(newCategory.CategoryIndexModifier)
        End If
    End Sub

    Private Sub ButtonCatColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoryColor.Click
        Me.ColorChoice = New ButtonColor_UC
        Me.ColorChoice.Location = New Point(480, 25)
        Me.Controls.Add(ColorChoice)
        ColorChoice.BringToFront()

    End Sub

    Private Sub ChangingButtonColor(ByVal cc As Integer, ByVal foreCC As Integer) Handles ColorChoice.ChangeButtonColor


        Me.btnCategoryColor.BackColor = Color.FromArgb(cc)
        Me.btnCategoryColor.ForeColor = Color.FromArgb(foreCC)

        'old    dvMainCategory(newCategory.DataViewIndex)("ButtonColor") = cc
        'old   dvMainCategory(newCategory.DataViewIndex)("ButtonForeColor") = foreCC
        dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("ButtonColor") = cc
        dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("ButtonForeColor") = foreCC
        Exit Sub

        '*****************
        'below is getting a concurrency violation
        'w/o it changes color, but not showing immediately

        If newCategory.ActiveCategoryType = "Main" Then
            btnMain(newCategory.ActiveButton).BackColor = Color.FromArgb(cc)
            btnMain(newCategory.ActiveButton).ForeColor = Color.FromArgb(foreCC)

        ElseIf newCategory.ActiveCategoryType = "Modifier" Then
            btnModifier(newCategory.ActiveButton).BackColor = Color.FromArgb(cc)
            btnModifier(newCategory.ActiveButton).ForeColor = Color.FromArgb(foreCC)

        End If

    End Sub


    Private Sub UpdateMainCategory(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles MainCategoryPanel.Click
        Dim oRow As DataRow

        Try
            Dim objButton As OrderButton = CType(sender, OrderButton)
            '    MsgBox(sender.name)

            If objButton.ID = 0 Then
                'this means we have everything blank
                '   ready for new category

                '         SaveUpdatedCategory()
                Me.cbxNewCategoryFunction.Items.Clear()
                For Each oRow In dsSetup.Tables("Functions").Rows
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If objButton.Parent Is Me.MainCategoryPanel Then
                            If oRow("FunctionGroupID") = "1" Or oRow("FunctionGroupID") = "10" Or oRow("FunctionGroupID") = "99" Then
                                '1 is Main Food Item          10 is Food Item -Other 
                                Me.cbxNewCategoryFunction.Items.Add(oRow("FunctionName"))
                            End If
                        Else
                            If oRow("FunctionGroupID") = "9" Then '9 is Modifier
                                Me.cbxNewCategoryFunction.Items.Add(oRow("FunctionName"))
                            End If
                        End If

                    End If
                Next

                Try
                    'we may not have all the row for index 0 or 1
                    If objButton.Parent Is Me.MainCategoryPanel Then
                        newCategory.ActiveCategoryType = "Main"
                        cbxNewCategoryFunction.SelectedIndex = 1
                    Else
                        newCategory.ActiveCategoryType = "Modifier"
                        cbxNewCategoryFunction.SelectedValue = 0
                    End If
                    Me.cbxNewCategroyPriority.SelectedIndex = 2
                Catch ex As Exception

                End Try

                Me.pnlNewCategory.Visible = True
                Me.txtNewCategoryName.Text = ""
                Me.txtNewCategoryAbrev.Text = ""

                Me.chkNewHalfSplit.Checked = False
                chkNewExtendedDisplay.Checked = False
                If objButton.Parent Is Me.MainCategoryPanel Then
                    chkNewDisplayWithAdds.Checked = False
                Else
                    chkNewDisplayWithAdds.Checked = True
                End If

                newCategory.ActiveButton = objButton.BtnNumber
                newCategory.ActivePosition = objButton.BtnIndex
                '      newCategory.Priority = 3

                Me.btnNewCategoryColor.BackColor = Color.CornflowerBlue
                Me.btnNewCategoryColor.ForeColor = Color.Black
                Me.txtNewCategoryName.Focus()

            Else

                newCategory.ActiveButton = objButton.BtnNumber
                newCategory.ActivePosition = objButton.BtnIndex
                newCategory.DataViewIndex = objButton.DataViewIndex

                'we may not have all the row for index 0 or 1
                If objButton.Parent Is Me.MainCategoryPanel Then
                    newCategory.ActiveCategoryType = "Main"
                Else
                    newCategory.ActiveCategoryType = "Modifier"
                End If

                Me.cbxCategoryFunction.Items.Clear()
                For Each oRow In dsSetup.Tables("Functions").Rows
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If objButton.Parent Is Me.MainCategoryPanel Then
                            If oRow("FunctionGroupID") = "1" Or oRow("FunctionGroupID") = "10" Or oRow("FunctionGroupID") = "99" Then
                                '1 is Main Food Item          10 is Food Item -Other 
                                Me.cbxCategoryFunction.Items.Add(oRow("FunctionName"))
                            End If
                        Else
                            If oRow("FunctionGroupID") = "9" Then '9 is Modifier
                                Me.cbxCategoryFunction.Items.Add(oRow("FunctionName"))
                            End If
                        End If

                    End If
                Next


                Me.btnCategoryColor.BackColor = objButton.BackColor
                Me.btnCategoryColor.ForeColor = objButton.ForeColor

                mainCatCurrencyMan.Position = objButton.DataViewIndex
                Me.txtCategoryName.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCategoryAbrev_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategoryAbrev.TextChanged

        If newCategory.ActiveCategoryType = "Main" Then
            btnMain(newCategory.ActiveButton).Text = txtCategoryAbrev.Text
        ElseIf newCategory.ActiveCategoryType = "Modifier" Then
            btnModifier(newCategory.ActiveButton).Text = txtCategoryAbrev.Text
        End If
    End Sub

    Private Sub txtNewCategoryAbrev_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewCategoryAbrev.Enter
        If txtNewCategoryAbrev.Text.Length = 0 Then
            txtNewCategoryAbrev.Text = Me.txtNewCategoryName.Text
        End If

    End Sub

    Private Sub cbxCategoryFunction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategoryFunction.SelectedIndexChanged
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("Functions").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("FunctionName") = sender.text Then
                    If Not dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("FunctionID") = oRow("FunctionID") Then
                        dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("FunctionID") = oRow("FunctionID")
                    End If
                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub cbxCategroyPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategroyPriority.SelectedIndexChanged

        Dim newPriority As Integer

        Select Case sender.text
            Case "Highest"
                newPriority = 1
            Case "High"
                newPriority = 2
            Case "Medium"
                newPriority = 3
            Case "Low"
                newPriority = 4
            Case "Lowest"
                newPriority = 5
        End Select

        If Not dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("Priority") = newPriority Then
            dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("Priority") = newPriority
        End If

    End Sub

    Private Sub chkCategoryActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCategoryActive.Click

        Dim tempCategoryName As String

        If Me.chkCategoryActive.Checked = False Then
            'this is the new state
            '444      Me.txtCategoryName.Text = newCategory.ActiveText
            tempCategoryName = "**Inactive**"

        Else
            '      Me.txtCategoryName.Text = newCategory.ActiveText
            If txtCategoryName.Text.Length > 15 Then
                tempCategoryName = txtCategoryName.Text.Substring(0, 15)
            Else
                tempCategoryName = txtCategoryName.Text
            End If

        End If

        Me.txtCategoryAbrev.Text = tempCategoryName

        If newCategory.ActiveCategoryType = "Main" Then
            btnMain(newCategory.ActiveButton).Text = tempCategoryName 'txtCategoryAbrev.Text
        ElseIf newCategory.ActiveCategoryType = "Modifier" Then
            btnModifier(newCategory.ActiveButton).Text = tempCategoryName 'txtCategoryAbrev.Text
        End If

    End Sub


    '**************************
    '   new category

    Private Sub cbxNewCategoryFunction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNewCategoryFunction.SelectedIndexChanged
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("Functions").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("FunctionName") = sender.text Then
                    newCategory.ActiveFunction = oRow("FunctionID")
                    Exit For
                End If
            End If
        Next
        newCategory.Updated = True

    End Sub

    Private Sub cbxNewCategroyPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNewCategroyPriority.SelectedIndexChanged
        Select Case sender.text
            Case "Highest"
                newCategory.Priority = 1
            Case "High"
                newCategory.Priority = 2
            Case "Medium"
                newCategory.Priority = 3
            Case "Low"
                newCategory.Priority = 4
            Case "Lowest"
                newCategory.Priority = 5
        End Select

    End Sub

    Private Sub btnNewCategoryColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCategoryColor.Click
        Me.ColorChoiceNew = New ButtonColor_UC
        Me.ColorChoiceNew.Location = New Point(480, 25)
        Me.Controls.Add(ColorChoiceNew)
        ColorChoiceNew.BringToFront()

    End Sub
    Private Sub ChangingNewButtonColor(ByVal cc As Integer, ByVal foreCC As Integer) Handles ColorChoiceNew.ChangeButtonColor

        Me.btnNewCategoryColor.BackColor = Color.FromArgb(cc)
        Me.btnNewCategoryColor.ForeColor = Color.FromArgb(foreCC)
        newCategory.ColorInt = cc
        newCategory.ColorForeInt = foreCC
        newCategory.Updated = True

        '   dvMainCategory(newCategory.DataViewIndex)("ButtonColor") = cc
        '  dvMainCategory(newCategory.DataViewIndex)("ButtonForeColor") = foreCC

    End Sub

    Private Sub txtNewCategoryName_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewCategoryName.Validating
        ValidateString(Me.txtNewCategoryName)
    End Sub
    Private Sub txtNewCategoryAbrev_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewCategoryAbrev.Validating
        ValidateString(Me.txtNewCategoryAbrev)
    End Sub
    Private Sub cbxFunction_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxNewCategoryFunction.Validating
        ValidateNotBlank(Me.cbxNewCategoryFunction)
    End Sub

    Private Sub ValidateString(ByRef txtValNumeric As TextBox)

        If txtValNumeric.Text = "" Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This TextBox can not be Blank.")
            txtValNumeric.Focus()
            Beep()
        ElseIf Not TypeName(txtValNumeric.Text) = "String" Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a String value.")
            txtValNumeric.Focus()
            Beep()
        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
        End If

    End Sub

    Private Sub ValidateStringAcceptBlanks(ByRef txtValNumeric As TextBox)

        If TypeName(txtValNumeric.Text) = "String" Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a String value.")
            txtValNumeric.Focus()
            Beep()
        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
        End If

    End Sub
    Private Sub btnNewCategoryAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCategoryAccept.Click

        If cbxNewCategoryFunction.SelectedIndex = -1 Then
            MsgBox("You must select a function.")
            Exit Sub
        End If
        UpdateCategory()
        newCategory.Updated = False
        Me.pnlNewCategory.Visible = False

    End Sub

    Private Sub btnNewCategoryCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCategoryCancel.Click

        'all info reset when pulls up again
        newCategory.Updated = False
        Me.pnlNewCategory.Visible = False

    End Sub

    Private Sub UpdateCategory()
        Dim oRow As DataRow
        Dim fRow As DataRow
        Dim catType As String
        Dim newCatID
        Dim newFunFlag As String
        Dim newFunName As String
        Dim ppName As String

        '     If Me.txtNewCategoryName.Text.Length = 0 Then Exit Sub
        If Me.ErrorProvider1.GetError(Me.txtNewCategoryAbrev).Length > 0 Or Me.ErrorProvider1.GetError(Me.txtNewCategoryName).Length > 0 Or Me.ErrorProvider1.GetError(Me.cbxCategoryFunction).Length > 0 Then
            Me.ErrorProvider1.Dispose()
            Me.pnlNewCategory.Visible = False
            Exit Sub
        Else
            newCategory.Updated = False
        End If

        If newCategory.ActiveCategoryType = "Main" Then
            catType = "MainCategory"
        ElseIf newCategory.ActiveCategoryType = "Modifier" Then
            catType = "ModifierCategory"
        Else
            Exit Sub
        End If

        For Each fRow In dsSetup.Tables("Functions").Rows
            If Not fRow.RowState = DataRowState.Deleted And Not fRow.RowState = DataRowState.Detached Then
                If fRow("FunctionID") = newCategory.ActiveFunction Then    '1 Then
                    'Main Food Item
                    newFunFlag = "F"
                    newFunName = fRow("FunctionName")
                    Exit For
                ElseIf fRow("FunctionID") = newCategory.ActiveFunction Then '10 Then
                    newFunFlag = "O"
                    newFunName = fRow("FunctionName")
                    Exit For
                ElseIf fRow("FunctionID") = newCategory.ActiveFunction Then '9 Then
                    newFunFlag = "M"
                    newFunName = fRow("FunctionName")
                    Exit For
                End If
            End If
        Next
        For Each fRow In dsSetup.Tables("PrintPriority").Rows
            If Not fRow.RowState = DataRowState.Deleted And Not fRow.RowState = DataRowState.Detached Then
                If fRow("PrintPriorityID") = newCategory.Priority Then
                    ppName = fRow("PrintPriorityName")
                End If
            End If
        Next

        newCategory.ActiveText = Me.txtNewCategoryName.Text '
        newCategory.ActiveAbrevText = Me.txtNewCategoryAbrev.Text '

        SaveUpdatedCategory()
        oRow = dsSetup.Tables("MainCategory").NewRow 'catType).NewRow

        '   *** will have to change the way we get category ID
        '      newCategory.ActiveID = GetMaximumID("CategoryID", "Category") + 1
        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        '      oRow("CategoryID") = newCategory.ActiveID
        oRow("CategoryName") = newCategory.ActiveText  ' Me.txtNewCategoryName.Text 
        oRow("CategoryAbrev") = newCategory.ActiveAbrevText    'Me.txtNewCategoryAbrev.Text 
        oRow("CategoryOrder") = newCategory.ActivePosition
        oRow("FunctionID") = newCategory.ActiveFunction
        oRow("FunctionName") = newFunName
        oRow("FunctionFlag") = newFunFlag
        ' we could also put FunctionGroupID here ??/

        oRow("Priority") = newCategory.Priority
        oRow("PrintPriorityName") = ppName

        oRow("ButtonColor") = Me.btnNewCategoryColor.BackColor.ToArgb
        oRow("ButtonForeColor") = Me.btnNewCategoryColor.ForeColor.ToArgb
        oRow("HalfSplit") = Me.chkNewHalfSplit.Checked 'newCategory.HalfSplit
        oRow("Extended") = chkNewExtendedDisplay.Checked
        oRow("DisplayWithAdd") = chkNewDisplayWithAdds.Checked
        oRow("Active") = True 'newCategory.CategoryIsActive

        dsSetup.Tables("MainCategory").Rows.Add(oRow)   'catType).Rows.Add(oRow)
        oRow("CategoryID") = InsertingNewCategory(oRow)
        dsSetup.Tables("MainCategory").AcceptChanges() 'catType).AcceptChanges()
        '444     oRow("SubCategoryID") = CInt(oRow("CategoryID"))
        '    SaveUpdatedCategory()
     

        If newCategory.ActiveCategoryType = "Main" Then
            btnMain(newCategory.ActiveButton).ID = oRow("CategoryID")
            btnMain(newCategory.ActiveButton).Text = txtNewCategoryAbrev.Text
            btnMain(newCategory.ActiveButton).BtnIndex = newCategory.ActivePosition
            btnMain(newCategory.ActiveButton).DataViewIndex = dvMainCategory.Count - 1
            btnMain(newCategory.ActiveButton).BackColor = Me.btnNewCategoryColor.BackColor
            btnMain(newCategory.ActiveButton).ForeColor = Me.btnNewCategoryColor.ForeColor

        ElseIf newCategory.ActiveCategoryType = "Modifier" Then
            btnModifier(newCategory.ActiveButton).ID = oRow("CategoryID")
            btnModifier(newCategory.ActiveButton).Text = txtNewCategoryAbrev.Text
            btnModifier(newCategory.ActiveButton).BtnIndex = newCategory.ActivePosition
            btnModifier(newCategory.ActiveButton).DataViewIndex = dvMainCategory.Count - 1
            btnModifier(newCategory.ActiveButton).BackColor = Me.btnNewCategoryColor.BackColor
            btnModifier(newCategory.ActiveButton).ForeColor = Me.btnNewCategoryColor.ForeColor

        End If

    End Sub

    Private Function InsertingNewCategory(ByRef oRow As DataRow)
        Dim newCategoryID As Integer

        sql.SqlInsertCommandCategoryMain.Parameters("@CompanyID").Value = oRow("CompanyID")
        sql.SqlInsertCommandCategoryMain.Parameters("@LocationID").Value = oRow("LocationID")
        sql.SqlInsertCommandCategoryMain.Parameters("@CategoryName").Value = oRow("CategoryName")
        sql.SqlInsertCommandCategoryMain.Parameters("@CategoryAbrev").Value = oRow("CategoryAbrev")
        sql.SqlInsertCommandCategoryMain.Parameters("@CategoryOrder").Value = oRow("CategoryOrder")
        sql.SqlInsertCommandCategoryMain.Parameters("@FunctionID").Value = oRow("FunctionID")
        sql.SqlInsertCommandCategoryMain.Parameters("@SubCategoryID").Value = 0 'oRow("SubCategoryID")
        sql.SqlInsertCommandCategoryMain.Parameters("@Priority").Value = oRow("Priority")
        sql.SqlInsertCommandCategoryMain.Parameters("@ButtonColor").Value = oRow("ButtonColor")
        sql.SqlInsertCommandCategoryMain.Parameters("@ButtonForeColor").Value = oRow("ButtonForeColor")
        sql.SqlInsertCommandCategoryMain.Parameters("@HalfSplit").Value = oRow("HalfSplit")
        sql.SqlInsertCommandCategoryMain.Parameters("@Extended").Value = oRow("Extended")
        sql.SqlInsertCommandCategoryMain.Parameters("@DisplayWithAdd").Value = oRow("DisplayWithAdd")
        sql.SqlInsertCommandCategoryMain.Parameters("@Active").Value = oRow("Active")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newCategoryID = CType(sql.SqlInsertCommandCategoryMain.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        Return newCategoryID

    End Function

    Private Sub AdjustCategoryPosition()

        'this moves the currency manager up then back
        '   in order for the dataset to read changes but not move position
        If mainCatCurrencyMan.Position < mainCatCurrencyMan.Count - 1 Then
            mainCatCurrencyMan.Position += 1
            mainCatCurrencyMan.Position -= 1
        Else
            mainCatCurrencyMan.Position -= 1
            mainCatCurrencyMan.Position += 1
        End If

    End Sub

    Private Sub SaveUpdatedCategory()
        AdjustCategoryPosition()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuCategoryMain.Update(dsSetup, "MainCategory")
            sql.cn.Close()
            dsSetup.Tables("MainCategory").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tabCategory_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabCategory.Leave

        '      If newCategory.Updated = True Then 'Or newCategory.UpdatedModifier = True Then
        '        UpdateCategory()

        SaveUpdatedCategory()

    End Sub


    'old below

    Private Sub UpdateNewCategoryPanel222(ByVal nc As ActiveCategory, ByVal ab As String)
        Dim vRow As DataRowView
        If dvMainCategory.Count < 1 Then Exit Sub
        If nc.ActiveButton = 0 Then Exit Sub

        vRow = dvMainCategory(newCategory.DataViewIndex)

        If ab = "MainCategory" Then
            With btnMain(nc.ActiveButton)
                .DataViewIndex = dvMainCategory.Count - 1
                .Name = nc.ActiveText
                .Text = nc.ActiveAbrevText
                .ID = nc.ActiveID
                .Priority = nc.Priority
                .Functions = nc.ActiveFunction
                .HalfSplit = nc.HalfSplit
                .IsActive = nc.CategoryIsActive
                If Not vRow("ButtonColor") Is DBNull.Value Then
                    .BackColor = Color.FromArgb(vRow("ButtonColor"))
                Else
                    .BackColor = Color.FromArgb(-9404272)
                End If
                If Not vRow("ButtonForeColor") Is DBNull.Value Then
                    .ForeColor = Color.FromArgb(vRow("ButtonForeColor"))
                Else
                    .ForeColor = Color.FromArgb(-16777216)
                End If

            End With
            '444      AddHandler btnMain(nc.ActiveButton).Click, AddressOf UpdateMainCategory
        ElseIf ab = "ModifierCategory" Then
            With btnModifier(nc.ActiveButton)
                .DataViewIndex = dvMainCategory.Count - 1
                .Name = nc.ActiveText
                .Text = nc.ActiveAbrevText
                .ID = nc.ActiveID
                .Priority = nc.Priority
                .Functions = nc.ActiveFunction
                .HalfSplit = nc.HalfSplit
                .IsActive = nc.CategoryIsActive
                If Not vRow("ButtonColor") Is DBNull.Value Then
                    .BackColor = Color.FromArgb(vRow("ButtonColor"))
                Else
                    .BackColor = Color.FromArgb(-9404272)
                End If
                If Not vRow("ButtonForeColor") Is DBNull.Value Then
                    .ForeColor = Color.FromArgb(vRow("ButtonForeColor"))
                Else
                    .ForeColor = Color.FromArgb(-16777216)
                End If
            End With
            '444          AddHandler btnModifier(nc.ActiveButton).Click, AddressOf UpdateMainCategory 'UpdateModifierCategory
        End If

    End Sub

    Private Sub UpdateCategoryPanel222(ByVal nc As ActiveCategory, ByVal ab As String)

        If nc.ActiveCategoryType = "Main" Then
            btnMain(nc.ActiveButton).Name = nc.ActiveText
            btnMain(nc.ActiveButton).Text = nc.ActiveAbrevText
            btnMain(nc.ActiveButton).Functions = nc.ActiveFunction
            btnMain(nc.ActiveButton).Priority = nc.Priority
            btnMain(nc.ActiveButton).ColorInt = nc.ColorInt
            btnMain(nc.ActiveButton).BackColor = Color.FromArgb(nc.ColorInt)
            btnMain(nc.ActiveButton).ForeColor = Color.FromArgb(nc.ColorForeInt)
            btnMain(nc.ActiveButton).HalfSplit = nc.HalfSplit
            btnMain(nc.ActiveButton).IsActive = nc.CategoryIsActive
        Else
            btnModifier(nc.ActiveButton).Name = nc.ActiveText
            btnModifier(nc.ActiveButton).Text = nc.ActiveAbrevText
            btnModifier(nc.ActiveButton).Functions = nc.ActiveFunction
            btnModifier(nc.ActiveButton).Priority = nc.Priority
            btnModifier(nc.ActiveButton).ColorInt = nc.ColorInt
            btnModifier(nc.ActiveButton).BackColor = Color.FromArgb(nc.ColorInt)
            btnModifier(nc.ActiveButton).ForeColor = Color.FromArgb(nc.ColorForeInt)
            btnModifier(nc.ActiveButton).HalfSplit = nc.HalfSplit
            btnModifier(nc.ActiveButton).IsActive = nc.CategoryIsActive
        End If

    End Sub


    '****************************************************************
    '   Foods
    '****************************************************************

    Private Sub DisplayFoodTab()
        Dim tsFood As New DataGridTableStyle
        tsFood.MappingName = "FoodTable"
        tsFood.RowHeadersVisible = False
        tsFood.GridLineColor = Color.White

        Dim csFoodID As New DataGridTextBoxColumn
        csFoodID.MappingName = "FoodID"
        csFoodID.Width = 0

        Dim csFoodName As New DataGridTextBoxColumn
        csFoodName.MappingName = "FoodName"
        csFoodName.Width = Me.grdFoodList.Width * 0.85

        tsFood.GridColumnStyles.Add(csFoodID)
        tsFood.GridColumnStyles.Add(csFoodName)
        grdFoodList.TableStyles.Add(tsFood)

    End Sub

    Private Sub DisplayMenuCostGroupBox()

        Dim numberOfActiveMenuSelections As Integer
        '       Dim numberOfMenuSelections As Integer
        Dim index As Integer
        Dim vRow As DataRowView
        Dim oRow As DataRow

        '     dvActiveMenu = New DataView
        With dvActiveMenu
            .Table = dsSetup.Tables("Menus")
            .AllowEdit = True
            .RowFilter = "Active = 1"
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        numberOfActiveMenuSelections = GetButtonCount("ActiveMenus")
        '      numberOfMenuSelections = GetButtonCount("Menus")
        If numberOfActiveMenuSelections > 10 Then
            ReDim menuCheckBox(20)
            ReDim menuCostText(20)
            ReDim menuSurchargeText(20)
            ReDim menuRouting(20)
        End If
        Dim xMenu As Integer = 70   '96
        Dim xMenu2 As Integer = 50  '60  '66
        Dim yMenu As Integer = 24
        Dim xMenuLocation As Integer = 75
        Dim yMenuLocation As Integer = (3 * buttonSpace)
        Dim priceLabel As New Label
        Dim surLabel As New Label
        Dim routingLabel As New Label

        menuCostGroupBox.Size = New Size((xMenu * 4) + 10, ((yMenu + buttonSpace) * numberOfActiveMenuSelections + (3 * buttonSpace) + 15))

        priceLabel.Text = " Price"
        priceLabel.Size = New Size(xMenu2, 15)
        priceLabel.Location = New Point(xMenuLocation, yMenuLocation)
        priceLabel.TextAlign = ContentAlignment.TopLeft
        surLabel.Text = "Surcharge"
        surLabel.Size = New Size(xMenu2 + 15, 15)
        surLabel.Location = New Point(xMenuLocation + xMenu2, yMenuLocation)
        surLabel.TextAlign = ContentAlignment.TopLeft
        routingLabel.Text = "Routing"
        routingLabel.Size = New Size(xMenu2, 15)
        routingLabel.Location = New Point(xMenuLocation + 130, yMenuLocation)
        routingLabel.TextAlign = ContentAlignment.TopLeft

        menuCostGroupBox.Controls.Add(priceLabel)
        menuCostGroupBox.Controls.Add(surLabel)
        menuCostGroupBox.Controls.Add(routingLabel)

        yMenuLocation = yMenuLocation + 15 + buttonSpace

        For Each vRow In dvActiveMenu
            menuCheckBox(index) = New CheckBox
            With menuCheckBox(index)
                .Text = dsSetup.Tables("Menus").Rows(index)("MenuName")
                .Size = New Size(xMenu, yMenu)
                .Location = New Point(buttonSpace, yMenuLocation)
                menuCostGroupBox.Controls.Add(menuCheckBox(index))
            End With
            AddHandler menuCheckBox(index).Enter, AddressOf menuCheckBox_Changed

            menuCostText(index) = New TextBox
            With menuCostText(index)
                .Size = New Size(xMenu2, yMenu)
                .Location = New Point(xMenuLocation, yMenuLocation)
                .TextAlign = HorizontalAlignment.Right

                menuCostGroupBox.Controls.Add(menuCostText(index))
                xMenuLocation += (xMenu2 + buttonSpace)
            End With
            AddHandler menuCostText(index).Validating, AddressOf menuCostBoxes_Validating
            '   AddHandler menuCostText(index).Enter, AddressOf menuCostText_Changed


            menuSurchargeText(index) = New TextBox
            With menuSurchargeText(index)
                .Size = New Size(xMenu2, yMenu)
                .Location = New Point(xMenuLocation, yMenuLocation)
                .TextAlign = HorizontalAlignment.Right

                menuCostGroupBox.Controls.Add(menuSurchargeText(index))
                xMenuLocation += (xMenu2 + buttonSpace)
            End With
            AddHandler menuSurchargeText(index).Validating, AddressOf menuCostBoxes_Validating
            '     AddHandler menuSurchargeText(index).Enter, AddressOf menuSurchargeText_Changed


            menuRouting(index) = New ComboBox
            With menuRouting(index)
                .Size = New Size(xMenu2 * 2, yMenu)
                .Location = New Point(xMenuLocation, yMenuLocation)
                '    .TextAlign = HorizontalAlignment.Right
                menuCostGroupBox.Controls.Add(menuRouting(index))
            End With
            '       AddHandler menuRouting(index).Validating, AddressOf menuCostBoxes_Validating
            '      AddHandler menuRouting(index).SelectedIndexChanged, AddressOf menuRouting_Changed


            For Each oRow In dsSetup.Tables("RoutingChoice").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    menuRouting(index).Items.Add(oRow("RoutingName"))
                End If
            Next

            xMenuLocation = 75
            yMenuLocation = yMenuLocation + yMenu + buttonSpace
            index += 1

        Next

    End Sub

    Private Sub MenuCostGroupBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuCostGroupBox.Enter

        '     AdjustPosition()

        If dsSetup.HasChanges(DataRowState.Modified Or DataRowState.Added) Then
            '         UpdateDatabaseFoods()
        End If

        MenuCostChanged = True

    End Sub

    Private Sub grdFoodList_Mouse(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles grdFoodList.MouseDown

        If cbxFoodCategory.Text = Nothing Then
            MsgBox("Please select a Category")
            newFood.GotoPrevious = True
            Exit Sub
        End If
        '       If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        '           MsgBox("Please Select a Food Routing")
        '          newFood.GotoPrevious = True
        '         Exit Sub
        'End If
        '      If cbxFoodTax.Text = Nothing Then
        '           MsgBox("Please Select a Tax")
        '          newFood.GotoPrevious = True
        '         Exit Sub
        '    End If

    End Sub

    Private Sub grdFoodList_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdFoodList.CurrentCellChanged

        If newFood.GotoPrevious = True Then
            newFood.GotoPrevious = False
            Me.grdFoodList.CurrentRowIndex = newFood.PreviousPosition
            Exit Sub
        End If


        '    AdjustPosition()       this does not work b/c it puts us in a loop
        '     Me.TabMainFood.Update()

        If chkManual.Checked = True Then
            Me.txtFoodCost.BackColor = System.Drawing.Color.White
        Else
            Me.txtFoodCost.BackColor = System.Drawing.Color.LightSteelBlue
        End If

        If justAdjustingPosition = False Then

            UpdateMenuJoin()    ' will only update if it was entered
            '      UpdateDatabaseFoods()

            PopulateMenuCostGroupBox()
            PopulateModifierListBox()
            newFood.PreviousPosition = FoodCurrencyMan.Position     'this actually records the new position used later

        End If


    End Sub

    Private Sub PopulateModifierListBox()
        Dim oRow As DataRow
        Me.lstModifierJoin.Items.Clear()

        PopulateFoodJoinData(Me.grdFoodList)

        For Each oRow In dsSetup.Tables("JoinFoodCategoryJoins").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                lstModifierJoin.Items.Add(oRow("CategoryName"))
            End If
        Next
        For Each oRow In dsSetup.Tables("JoinFoodModifierJoins").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                lstModifierJoin.Items.Add(oRow("FoodName"))
            End If
        Next

    End Sub

    Private Sub PopulateMenuCostGroupBox()
        Dim rowNum As Integer = grdFoodList.CurrentCell.RowNumber
        FoodCurrencyMan.Position = rowNum

        Dim valueFoodID As Integer
        Dim index As Integer
        Dim vRow As DataRowView
        Dim vRowNested As DataRowView
        '        Dim valueCatID As Integer
        Dim valueCatName As String
        Dim oRow As DataRow

        Try
            If FoodCurrencyMan.Position = -1 Then
                valueFoodID = 0
            Else
                valueFoodID = dvFoods(FoodCurrencyMan.Position)("FoodID") 'dsSetup.Tables("FoodTable").Rows(FoodCurrencyMan.Position)("FoodID")
            End If

        Catch ex As Exception
            valueFoodID = 0
        End Try
        newFood.ActiveFoodID = valueFoodID

        With dvMenuJoin
            .Table = dsSetup.Tables("MenuJoin")
            .RowFilter = "FoodID = '" & valueFoodID & "' AND GeneralMenuID IS NULL"
            .Sort = "MenuID"
        End With
        ' dvMenuJoin = New DataView(dsSetup.Tables("MenuJoin"), "FoodID ='" & valueFoodID & "'", "MenuID", DataViewRowState.CurrentRows)

        index = 0
        Dim nestedIndex As Integer
        For Each vRow In dvActiveMenu
            menuCostText(index).Clear()
            menuSurchargeText(index).Clear()
            menuCheckBox(index).Checked = False
            '            menuRouting(index).SelectedIndex = -1    'Nothing

            menuRouting(index).Text = Nothing
            For Each vRowNested In dvMenuJoin
                If dvActiveMenu(index)("MenuID") = dvMenuJoin(nestedIndex)("MenuID") Then
                    menuCostText(index).Text = dvMenuJoin(nestedIndex)("Price")
                    menuSurchargeText(index).Text = dvMenuJoin(nestedIndex)("Surcharge")
                    ' valueCatID = dvMenuJoin(nestedIndex)("RoutingID")
                    '        valueCatName = dsSetup.Tables("RoutingChoice").Rows(dvMenuJoin(nestedIndex)("RoutingName")).ToString
                    If dvMenuJoin(nestedIndex)("RoutingID") > 0 Then
                        oRow = dsSetup.Tables("RoutingChoice").Rows.Find(dvMenuJoin(nestedIndex)("RoutingID"))
                        menuRouting(index).SelectedText = oRow("RoutingName") '(dsSetup.Tables("RoutingChoice").Rows(dvMenuJoin(nestedIndex)("RoutingID"))("RoutingName"))
                    End If
                    If dvMenuJoin(nestedIndex)("Active") = True Then
                        menuCheckBox(index).Checked = True
                    Else
                        menuCheckBox(index).Checked = False
                    End If
                    If cbxFoodCategory.SelectedIndex > -1 Then
                        Me.newFood.FunctionID = dsSetup.Tables("MainCategory").Rows(cbxFoodCategory.SelectedIndex)("FunctionID")
                        If newFood.FunctionID <> 1 Then
                            menuRouting(index).BackColor = Color.LightSteelBlue
                        Else
                            menuRouting(index).BackColor = Color.White
                        End If
                    End If

                End If
                nestedIndex += 1
            Next
            nestedIndex = 0
            index += 1
        Next

    End Sub

    Private Sub btnEnterNewFood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterNewFood.Click
        If TestRoutingInfo() = True Then
            UpdateMenuJoin()
            StartNewFood()
        End If

    End Sub

    Private Function TestRoutingInfo() As Boolean

        Dim vRow As DataRowView
        Dim index As Integer

        For Each vRow In dvActiveMenu
            If menuCheckBox(index).Checked = True Then
                If menuRouting(index).Text = "" Then
                    MsgBox("You must Select a Routing for " & vRow("MenuName"))
                    Return False
                End If
            End If
        Next

        Return True

    End Function

    Private Sub MoveLast()
        FoodCurrencyMan.Position = FoodCurrencyMan.Count - 1
        '   the following has to be add .. just like in OrderGrid
        '     Me.grdFoodList.ScrollToRow(FoodCurrencyMan.Position)

    End Sub

    Private Sub AdjustPosition()

        'this moves the currency manager up then back
        '   in order for the dataset to read changes but not move position
        If FoodCurrencyMan.Position < FoodCurrencyMan.Count - 1 Then
            FoodCurrencyMan.Position += 1
            FoodCurrencyMan.Position -= 1
        Else
            FoodCurrencyMan.Position -= 1
            FoodCurrencyMan.Position += 1
        End If

    End Sub

    Private Sub PopulateNewFoodInfo()

        '     Me.cbxPrintPriority.Text = newFood.PrintPriorityName
        '    Me.cbxFoodRouting.Text = newFood.FoodRoutingName
        '   Me.cbxFoodTax.Text = newFood.FoodTaxName

    End Sub

    Private Sub ClearMenuCostGroupBox()
        Dim vRow As DataRowView
        Dim index As Integer

        '   clears menu cost group box
        For Each vRow In dvActiveMenu
            menuCheckBox(index).CheckState = False
            menuCostText(index).Text = Nothing
            menuSurchargeText(index).Text = Nothing
            menuRouting(index).SelectedIndex = -1   'Nothing
            index += 1
        Next

    End Sub

    Private Sub btnUpdateFood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cbxFoodCategory.Text = Nothing Then
            MsgBox("Please select a Category")
            Exit Sub
        End If
        '       If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        '           MsgBox("Please Select a Food Routing")
        '          Exit Sub
        '      End If
        '     If cbxFoodTax.Text = Nothing Then
        '         MsgBox("Please Select a Tax")
        '        Exit Sub
        '     End If

        justAdjustingPosition = True
        AdjustPosition()
        justAdjustingPosition = False

        UpdateMenuJoin()
        If dsSetup.HasChanges(DataRowState.Modified Or DataRowState.Added) Then
            UpdateDatabaseFoods()
        End If

    End Sub

    Private Sub btnRemoveFood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFood.Click
        Dim oRow As DataRow

        If MsgBox("Are you sure you want to remove the " & Me.txtFoodName.Text & " and all its Joins?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            Dim upFoodJoin As Boolean

            UpdateDatabaseFoodJoin()
            UpdateMenuJoinDatabase()
            UpdateDatabaseFoods()

            For Each oRow In dsSetup.Tables("FoodJoin").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FoodID") = newFood.ActiveFoodID Then
                        oRow.Delete()
                        upFoodJoin = True
                    End If
                End If
            Next

            For Each oRow In dsSetup.Tables("MenuJoin").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FoodID") = newFood.ActiveFoodID Then
                        oRow.Delete()
                        menuBoxUpdated = True
                    End If
                End If
            Next

            For Each oRow In dsSetup.Tables("FoodTable").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FoodID") = newFood.ActiveFoodID Then
                        oRow.Delete()
                    End If
                End If
            Next

            newFood.ActiveFoodID = Nothing

            Me.justAdjustingPosition = True
            If FoodCurrencyMan.Position > 0 Then
                FoodCurrencyMan.Position -= 1
            Else
                FoodCurrencyMan.Position += 1
            End If
            Me.justAdjustingPosition = False


            If upFoodJoin = True Then
                UpdateDatabaseFoodJoin()
            End If
            If menuBoxUpdated = True Then
                UpdateMenuJoinDatabase()
            End If
            UpdateDatabaseFoods()
            PopulateMenuCostGroupBox()
            PopulateModifierListBox()
        End If

    End Sub

    Private Sub cbxFoodFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFoodFilter.SelectedIndexChanged
        If cbxFoodFilter.SelectedIndex = -1 Then Exit Sub

        '  FoodCurrencyMan.Position = 0
        '    grdFoodList.CurrentCell.RowNumber()
        '   Dim rowNum As Integer = grdFoodList.CurrentCell.RowNumber
        '  FoodCurrencyMan.Position = rowNum
        '      FoodCurrencyMan.Position = -1

        If cbxFoodCategory.Text = Nothing Then
            '          MsgBox("Please select a Category")
            '         Exit Sub
        End If
        '       If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        '          MsgBox("Please Select a Food Routing")
        '         Exit Sub
        '     End If
        '     If cbxFoodTax.Text = Nothing Then
        '        MsgBox("Please Select a Tax")
        '       Exit Sub
        '     End If

        '     AdjustPosition()
        '    UpdateDatabaseFoods()

        Dim vRow As DataRowView

        cbxNewFoodCategory.Items.Clear()
        cbxFoodFilterModifiers.SelectedIndex = -1  'this define it is NOT modifier


        For Each vRow In dvMainFoodsCategory
            cbxNewFoodCategory.Items.Add(vRow("CategoryName"))
        Next

        UpdateMenuJoin()

        Dim valueCatID As Integer
        '      valueCatID = dsSetup.Tables("MainCategory").Rows(cbxFoodFilter.SelectedIndex)("CategoryID")
        '  Me.newFood.FunctionID = dsSetup.Tables("MainCategory").Rows(cbxFoodFilter.SelectedIndex)("FunctionID")

        valueCatID = dvMainFoodsCategory(cbxFoodFilter.SelectedIndex)("CategoryID")
        lblSelectFoodFilter.Text = dvMainFoodsCategory(cbxFoodFilter.SelectedIndex)("CategoryName")
        globalJoinValueCategoryID = valueCatID

        '       dsSetup.Tables("FoodTable").Clear()

        '     sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
        '    sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation
        '   sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = valueCatID

        '        Try
        '        sql.cn.Open()
        '              sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        '       sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
        ''       sql.cn.Close()
        '       Catch ex As Exception
        '       MsgBox(ex.Message)
        '       CloseConnection()
        '      End Try

        '

        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID = " & valueCatID
        End With


        With dvFoodsJoins
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID = " & valueCatID
        End With

        grdFoodList.CurrentRowIndex = 1
        '   FoodCurrencyMan.Position = grdFoodList.CurrentRowIndex

        '   Dim rowNum As Integer = grdFoodList.CurrentCell.RowNumber
        '  FoodCurrencyMan.Position = rowNum

        If dsSetup.Tables("FoodTable").Rows.Count = 0 Then
            Me.cbxFoodCategory.SelectedIndex = Me.cbxFoodFilter.SelectedIndex
            PopulateNewFoodInfo()
        End If


    End Sub

    Private Sub cbxFoodFilterModifiers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFoodFilterModifiers.SelectedIndexChanged
        '666
        If cbxFoodFilterModifiers.SelectedIndex = -1 Then Exit Sub
        Dim vRow As DataRowView

        cbxNewFoodCategory.Items.Clear()
        cbxFoodFilter.SelectedIndex = -1

        For Each vRow In dvModifierCategory
            cbxNewFoodCategory.Items.Add(vRow("CategoryName"))
        Next

        UpdateMenuJoin()

        Dim valueCatID As Integer

        valueCatID = dvModifierCategory(cbxFoodFilterModifiers.SelectedIndex)("CategoryID")
        lblSelectFoodFilter.Text = dvMainFoodsCategory(cbxFoodFilterModifiers.SelectedIndex)("CategoryName")
        globalJoinValueCategoryID = valueCatID

        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID = " & valueCatID
        End With

        With dvFoodsJoins
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID = " & valueCatID
        End With

        grdFoodList.CurrentRowIndex = 1

        If dsSetup.Tables("FoodTable").Rows.Count = 0 Then
            Me.cbxFoodCategory.SelectedIndex = Me.cbxFoodFilter.SelectedIndex
            PopulateNewFoodInfo()
        End If


    End Sub

    Private Sub btnShowAllFood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAllFood.Click

        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID > 0 AND (FunctionFlag = 'O' OR FunctionFlag = 'F')"
        End With
        globalJoinValueCategoryID = 0


    End Sub
    Private Sub txtFoodName_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFoodName.MouseDown
        If txtFoodName.Text.Length = 0 Then
            If TestRoutingInfo() = True Then
                '        StartNewFood()
                '        EnteringNewFood()
            End If
        End If

    End Sub
    Private Sub txtAbrevFoodName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbrevFoodName.Enter
        If txtAbrevFoodName.Text.Length = 0 Then
            txtAbrevFoodName.Text = Me.txtFoodName.Text
        End If

    End Sub

    Private Sub txtChitFoodName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChitFoodName.Enter
        If txtChitFoodName.Text.Length = 0 Then
            txtChitFoodName.Text = Me.txtFoodName.Text
        End If

    End Sub

    Private Sub cbxFoodCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFoodCategory.SelectedIndexChanged, cbxFoodCategory.Leave

        '*** currently not allowing us to change category of food item
        Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String
        Dim valueFoodID As Integer
        Dim valueFunFlag As String
        Dim vRow As DataRowView

        If FoodCurrencyMan.Position = -1 Then Exit Sub

        Try
            valueFoodID = dvFoods(FoodCurrencyMan.Position)("FoodID")
            valueCatID = dvMainFoodsCategory(cbxFoodCategory.SelectedIndex)("CategoryID")
            valueCatName = dvMainFoodsCategory(cbxFoodCategory.SelectedIndex)("CategoryName")
            valueFunFlag = dvMainFoodsCategory(cbxFoodCategory.SelectedIndex)("FunctionFlag")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each vRow In dvFoods    'dsSetup.Tables("FoodTable").Rows
            If vRow("FoodID") = valueFoodID Then
                vRow("CategoryID") = valueCatID
                vRow("CategoryName") = valueCatName
                vRow("FunctionFlag") = valueFunFlag
            End If
            Exit For
        Next

    End Sub

    Private Sub cbxWineParring_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxWineParring.SelectedIndexChanged
        '444      If newDrink.DrinkNameIndex = 0 Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If FoodCurrencyMan.Position = -1 Then Exit Sub

        valueCatID = dsSetup.Tables("WineParring").Rows(cbxWineParring.SelectedIndex)("DrinkID")
        valueCatName = dsSetup.Tables("WineParring").Rows(cbxWineParring.SelectedIndex)("DrinkName")

        If dvFoods.Count > 0 Then
            If Not dvFoods(Me.FoodCurrencyMan.Position)("WineParringID") = valueCatID Then
                newDrinkChangesMade = True
                dvFoods(Me.FoodCurrencyMan.Position)("WineParringID") = valueCatID
                dvFoods(Me.FoodCurrencyMan.Position)("DrinkName") = valueCatName
            End If
        End If

    End Sub

    Private Sub cbxPrintPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPrintPriority.SelectedIndexChanged
        Dim valueCatID As Integer
        Dim valueCatName As String
        If FoodCurrencyMan.Position = -1 Then Exit Sub

        valueCatID = dsSetup.Tables("PrintPriority").Rows(cbxPrintPriority.SelectedIndex)("PrintPriorityID")
        valueCatName = dsSetup.Tables("PrintPriority").Rows(cbxPrintPriority.SelectedIndex)("PrintPriorityName")

        If dvFoods.Count > 0 Then
            If Not dvFoods(Me.FoodCurrencyMan.Position)("PrintPriorityID") = valueCatID Then
                dvFoods(Me.FoodCurrencyMan.Position)("PrintPriorityName") = valueCatName
                dvFoods(Me.FoodCurrencyMan.Position)("PrintPriorityID") = valueCatID
            End If
        End If

    End Sub

    Private Sub btnFoodRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoodRecipe.Click
        If txtRecipe.Visible = False Then
            txtRecipe.Visible = True
            txtRecipe.BringToFront()
        Else
            txtRecipe.Visible = False
        End If

    End Sub

    Private Sub UpdateMenuJoin()

        If MenuCostChanged = False Then
            Exit Sub
        Else
            '   resets
            MenuCostChanged = False
        End If

        Dim vRow As DataRowView
        Dim vRowDatabase As DataRowView
        Dim newRowDatabase As DataRow
        Dim menuIndex As Integer
        Dim newEntry As Boolean = True
        Dim valueCatID As Integer
        Dim valueCatName As String
        Dim oRow As DataRow

        With dvMenuJoin
            .Table = dsSetup.Tables("MenuJoin")
            .RowFilter = "FoodID = '" & newFood.ActiveFoodID & "' AND GeneralMenuID IS NULL"
            .Sort = "MenuID"
        End With

        For Each vRow In dvActiveMenu

            If menuCheckBox(menuIndex).Checked = True Then
                For Each vRowDatabase In dvMenuJoin
                    '   passing test means menujoin already exists so just verify cost
                    If vRowDatabase("MenuID") = vRow("MenuID") Then
                        vRowDatabase("Price") = CType(menuCostText(menuIndex).Text, Decimal)
                        vRowDatabase("Surcharge") = CType(menuSurchargeText(menuIndex).Text, Decimal)
                        valueCatID = -1
                        For Each oRow In dsSetup.Tables("RoutingChoice").Rows
                            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                                If oRow("RoutingName") = menuRouting(menuIndex).Text Then
                                    valueCatID = oRow("RoutingID")
                                    Exit For
                                End If
                            End If
                        Next
                        vRowDatabase("RoutingID") = valueCatID
                        vRowDatabase("Active") = menuCheckBox(menuIndex).Checked
                        newEntry = False
                    End If
                Next
                If newEntry = True Then
                    newRowDatabase = dsSetup.Tables("MenuJoin").NewRow
                    newRowDatabase("CompanyID") = corpID
                    newRowDatabase("LocationID") = selectedLocation
                    newRowDatabase("FoodID") = newFood.ActiveFoodID
                    newRowDatabase("DrinkID") = DBNull.Value
                    newRowDatabase("MenuID") = dvActiveMenu(menuIndex)("MenuID")
                    newRowDatabase("GeneralMenuID") = DBNull.Value
                    If menuCostText(menuIndex).Text = "" Then
                        newRowDatabase("Price") = 0
                    Else
                        newRowDatabase("Price") = CType(menuCostText(menuIndex).Text, Decimal)
                    End If
                    If menuSurchargeText(menuIndex).Text = "" Then
                        newRowDatabase("Surcharge") = 0
                    Else
                        newRowDatabase("Surcharge") = CType(menuSurchargeText(menuIndex).Text, Decimal)
                    End If
                    '***
                    If menuRouting(menuIndex).SelectedIndex = -1 Then
                        valueCatID = lastSelectedRouting
                    Else
                        valueCatID = dsSetup.Tables("RoutingChoice").Rows(menuRouting(menuIndex).SelectedIndex)("RoutingID")
                        lastSelectedRouting = valueCatID
                    End If
                    newRowDatabase("RoutingID") = valueCatID
                    newRowDatabase("MenuIndex") = 0
                    newRowDatabase("Active") = menuCheckBox(menuIndex).Checked
                    dsSetup.Tables("MenuJoin").Rows.Add(newRowDatabase)
                End If
                newEntry = True

            ElseIf menuCheckBox(menuIndex).Checked = False Then


                '   vRowDatabase("Active") = menuCheckBox(menuIndex).Checked
            End If
            menuIndex += 1
        Next

        menuBoxUpdated = True
        '444    UpdateMenuJoinDatabase()

    End Sub

    Private Sub UpdateMenuJoinDatabase()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuMenuJoin.Update(dsSetup, "MenuJoin")
            sql.cn.Close()
            dsSetup.Tables("MenuJoin").AcceptChanges()
            menuBoxUpdated = False
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub ButtonFoodJoinLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoodJoinLink.Click
        If cbxFoodCategory.Text = Nothing Then
            MsgBox("Please select a Category")
            Exit Sub
        End If
        '       If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        '          MsgBox("Please Select a Food Routing")
        '         Exit Sub
        '      End If
        '     If cbxFoodTax.Text = Nothing Then
        '          MsgBox("Please Select a Tax")
        '         Exit Sub
        '    End If

        TabControl1.SelectedTab = TabFoodJoin

    End Sub

    Private Sub tabFood_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMainFood.Enter
        Dim vRow As DataRowView

        dvMainFoodsCategory = New DataView

        With dvMainFoodsCategory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "Active = True AND (FunctionFlag = 'F' OR FunctionFlag = 'O')"
            .Sort = "FunctionID, CategoryOrder"
        End With


        cbxNewFoodCategory.Items.Clear()
        cbxFoodCategory.Items.Clear()
        cbxFoodFilter.Items.Clear()
        cbxFoodFilterModifiers.Items.Clear()

        For Each vRow In dvMainFoodsCategory
            cbxNewFoodCategory.Items.Add(vRow("CategoryName"))
            cbxFoodCategory.Items.Add(vRow("CategoryName"))
            cbxFoodFilter.Items.Add(vRow("CategoryName"))
        Next

        '666 
        dvModifierCategory = New DataView

        With dvModifierCategory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "Active = True AND (FunctionFlag = 'M')"
            .Sort = "FunctionID, CategoryOrder"
        End With
        For Each vRow In dvModifierCategory
            '444         cbxNewFoodCategory.Items.Add(vRow("CategoryName"))
            '     cbxFoodCategory.Items.Add(vRow("CategoryName"))
            cbxFoodFilterModifiers.Items.Add(vRow("CategoryName"))
        Next


        '      With dvFoods
        '     .Table = dsSetup.Tables("FoodTable")
        '    .RowFilter = "CategoryID = " & Me.globalJoinValueCategoryID
        '   End With

        '     Me.cbxFoodFilter.SelectedIndex = -1

        '      grdJoinFoodChoice.DataSource = Nothing
        '      grdFoodList.DataSource = dsSetup.Tables("FoodTable")

        '    Me.grdJoinFoodChoice.Enabled = False
        '    grdFoodList.Enabled = True

        '    Me.grdFoodList.CurrentRowIndex = FoodCurrencyMan.Position
        '   AdjustPosition()
        '      FoodCurrencyMan.ResumeBinding()
        '     JoinCurrencyMan.SuspendBinding()

        '   grdJoinFoodChoice.SuspendLayout()
        '  grdFoodList.ResumeLayout()


    End Sub
    '  Private Sub tabFoodJoin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFoodJoin.Enter

    '      GenerateTables.ClearingDataToRepopulate()
    '        GenerateTables.RepopulateDataSets(selectedLocation)

    '      grdFoodList.DataSource = Nothing
    '      grdJoinFoodChoice.DataSource = dsSetup.Tables("FoodTable")

    '   grdFoodList.Enabled = False
    '     Me.grdJoinFoodChoice.Enabled = True

    '    Me.grdJoinFoodChoice.CurrentRowIndex = FoodCurrencyMan.Position
    '   adjustposition

    '     JoinCurrencyMan.ResumeBinding()
    '    FoodCurrencyMan.SuspendBinding()
    '    grdFoodList.ResumeLayout()
    '   grdJoinFoodChoice.SuspendLayout()

    '  End Sub

    '***********************
    '   new food
    Private Sub StartNewFood()

        Me.pnlNewFood.Visible = True
        Me.pnlNewFood.BringToFront()
        Me.txtNewFoodName.Focus()
        Dim valueID As Integer
        Dim valueName As String
        Dim oRow As DataRow

        Try
            If Not Me.cbxFoodFilter.SelectedIndex = -1 Then
                Me.cbxNewFoodCategory.SelectedIndex = cbxFoodFilter.SelectedIndex
            ElseIf Not Me.cbxFoodFilterModifiers.SelectedIndex = -1 Then '666
                Me.cbxNewFoodCategory.SelectedIndex = cbxFoodFilterModifiers.SelectedIndex
            Else
                Me.cbxNewFoodCategory.SelectedIndex = cbxFoodCategory.SelectedIndex
            End If
        Catch ex As Exception
        End Try

        ClearMenuCostGroupBox()
        Me.lstModifierJoin.Items.Clear()


    End Sub

    Private Sub txtNewAbrevFoodName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewAbrevFoodName.Enter
        If txtNewAbrevFoodName.Text.Length = 0 Then
            txtNewAbrevFoodName.Text = Me.txtNewFoodName.Text
        End If

    End Sub

    Private Sub txtNewChitFoodName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewChitFoodName.Enter
        If txtNewChitFoodName.Text.Length = 0 Then
            txtNewChitFoodName.Text = Me.txtNewFoodName.Text
        End If

    End Sub


    Private Sub txtNewFoodName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewFoodName.Validating
    End Sub

    Private Sub txtNewAbrevFoodName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewAbrevFoodName.Validating
    End Sub

    Private Sub txtNewChitFoodName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewChitFoodName.Validating
    End Sub


    Private Sub txtNewFoodPrepare_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewFoodPrepare.Validating

    End Sub

    Private Sub btnNewFoodAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFoodAccept.Click
        ValidateString(Me.txtNewFoodName)
        ValidateString(Me.txtNewAbrevFoodName)
        ValidateString(Me.txtNewChitFoodName)
        ValidateNumeric(txtNewFoodPrepare, False)


        If ErrorProvider1.GetError(Me.txtNewFoodName).Length > 0 Then
            Exit Sub
        End If
        If ErrorProvider1.GetError(Me.txtNewAbrevFoodName).Length > 0 Then
            txtNewAbrevFoodName.Text = Me.txtNewFoodName.Text
        End If
        If ErrorProvider1.GetError(Me.txtNewChitFoodName).Length > 0 Then
            Me.txtNewChitFoodName.Text = Me.txtNewAbrevFoodName.Text
        End If
        If ErrorProvider1.GetError(Me.txtNewFoodPrepare).Length > 0 Then
            MsgBox("Prepare time must be a numeric value.")
            Exit Sub
            '            Me.txtNewFoodPrepare.Text = 0
        End If
        '       If cbxFoodCategory.Text = Nothing Then
        '      MsgBox("Please select a Category")
        '     Exit Sub
        '    End If
        If Me.cbxNewFoodCategory.SelectedIndex = -1 Then
            MsgBox("You must choose a Category")
            Exit Sub
        End If
        EnteringNewFood()

    End Sub

    Private Sub btnNewFoodCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFoodCancel.Click

        Me.pnlNewFood.Visible = False
        Me.PopulateMenuCostGroupBox()
        Me.PopulateModifierListBox()

    End Sub

    Private Sub EnteringNewFood()

        '      If filledFirstFood = True Then
        justAdjustingPosition = True
        AdjustPosition()
        justAdjustingPosition = False
        UpdateDatabaseFoods()
        '444     UpdateMenuJoin()
        '     End If

        Dim valueID As Integer
        Dim valueName As String
        Dim oRow As DataRow
        Try
            '444      If Not Me.cbxNewFoodCategory.SelectedIndex = -1 Then
            If Not cbxFoodFilter.SelectedIndex = -1 Then
                valueID = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryID")
                valueName = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryName")
            ElseIf Not cbxFoodFilterModifiers.SelectedIndex = -1 Then
                valueID = dvModifierCategory(cbxNewFoodCategory.SelectedIndex)("CategoryID")
                valueName = dvModifierCategory(cbxNewFoodCategory.SelectedIndex)("CategoryName")
            Else
                ' just fallback
                valueID = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryID")
                valueName = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryName")
            End If

        Catch ex As Exception
            valueID = 0
            valueName = ""
            MsgBox(ex.Message)
            Exit Sub
        End Try

        '   ClearFoodInput()             'clears menu info
        Dim newFoodId As Integer

        oRow = dsSetup.Tables("FoodTable").NewRow

        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("FoodName") = Me.txtNewFoodName.Text ' "   ** Empty Food **"
        oRow("AbrevFoodName") = Me.txtNewAbrevFoodName.Text '""
        oRow("ChitFoodName") = Me.txtNewChitFoodName.Text '""
        oRow("FoodDesc") = ""
        oRow("CategoryID") = valueID
        oRow("CategoryName") = valueName
        oRow("FoodCost") = 0
        oRow("InvMultiplier") = 1
        oRow("FoodCostManual") = 0  'Me.chkManual.Checked  
        oRow("WineParringID") = 0
        oRow("PrintPriorityID") = 3
        oRow("Active") = 1
        If Me.txtNewFoodPrepare.TextLength = 0 Then
            oRow("PrepareTime") = 0
        Else
            oRow("PrepareTime") = CInt(Me.txtNewFoodPrepare.Text)
        End If


        dsSetup.Tables("FoodTable").Rows.Add(oRow)
        oRow("FoodID") = InsertingNewFood(oRow)
        '     UpdateDatabaseFoods()

        dsSetup.Tables("FoodTable").AcceptChanges()

        '     Me.pnlNewFood.Visible = False
        txtNewFoodName.Text = ""
        Me.txtNewAbrevFoodName.Text = ""
        Me.txtNewChitFoodName.Text = ""

        '     Me.PopulateMenuCostGroupBox()
        '    Me.PopulateModifierListBox()

        newFood.ActiveFoodID = oRow("FoodID")
        MenuCostChanged = True
        UpdateMenuJoin()

        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID = " & valueID
        End With

        Me.grdFoodList.CurrentRowIndex = dvFoods.Count - 1
        txtNewFoodName.Focus()

    End Sub

    Private Function InsertingNewFood(ByRef orow As DataRow)
        Dim newFoodID As Integer

        sql.SqlInsertCommandMenuFoods.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandMenuFoods.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodName").Value = orow("FoodName")
        sql.SqlInsertCommandMenuFoods.Parameters("@AbrevFoodName").Value = orow("AbrevFoodName")
        sql.SqlInsertCommandMenuFoods.Parameters("@ChitFoodName").Value = orow("ChitFoodName")
        sql.SqlInsertCommandMenuFoods.Parameters("@CategoryID").Value = orow("CategoryID")
        sql.SqlInsertCommandMenuFoods.Parameters("@NoPortions").Value = 1
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodCost").Value = orow("FoodCost")
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodCostManual").Value = orow("FoodCostManual")
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodDesc").Value = orow("FoodDesc")
        sql.SqlInsertCommandMenuFoods.Parameters("@WineParringID").Value = orow("WineParringID")
        sql.SqlInsertCommandMenuFoods.Parameters("@PrintPriorityID").Value = orow("PrintPriorityID")
        sql.SqlInsertCommandMenuFoods.Parameters("@Active").Value = 1
        sql.SqlInsertCommandMenuFoods.Parameters("@PrepareTime").Value = orow("PrepareTime")
        sql.SqlInsertCommandMenuFoods.Parameters("@InvMultiplier").Value = orow("InvMultiplier")
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodInvOn").Value = 0
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodInv").Value = 0
        sql.SqlInsertCommandMenuFoods.Parameters("@AvailForExtraNo").Value = 0

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newFoodID = CType(sql.SqlInsertCommandMenuFoods.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        Return newFoodID

    End Function

    Private Sub ResetNewFoodPanel()



    End Sub




    Private Sub tabFood_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMainFood.Leave
        If cbxFoodCategory.Text = Nothing Then
            MsgBox("Please select a Category")
            Exit Sub
        End If
        '     If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        '          MsgBox("Please Select a Food Routing")
        '         Exit Sub
        '      End If
        '     If cbxFoodTax.Text = Nothing Then
        '         MsgBox("Please Select a Tax")
        '        Exit Sub
        '     End If

        justAdjustingPosition = True
        AdjustPosition()
        justAdjustingPosition = False

        UpdateMenuJoin()
        If menuBoxUpdated = True Then
            UpdateMenuJoinDatabase()
        End If

        If dsSetup.HasChanges(DataRowState.Modified Or DataRowState.Added) Then
            UpdateDatabaseFoods()
            Me.ResetNewFoodPanel()
            Me.pnlNewFood.Visible = False
            dvMainFoodsCategory.Dispose()
            '        GenerateTables.ClearingDataToRepopulate()
            '       GenerateTables.RepopulateDataSets(selectedLocation)
        End If

    End Sub

    '******************************************************************
    '   Modifiers
    '******************************************************************

    Private Sub tabModifier_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabModifiers.Enter

        Dim vRow As DataRowView

        dvModifierCategory = New DataView

        With dvModifierCategory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "Active = True AND (FunctionFlag = 'M')"
            .Sort = "FunctionID, CategoryOrder"
        End With

        cbxModifierFilter.Items.Clear()

        For Each vRow In dvModifierCategory
            cbxModifierFilter.Items.Add(vRow("CategoryName"))
        Next

    End Sub

    Private Sub tabModifier_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabModifiers.Leave
        Me.UpdateDatabaseModifiers()
        SaveModifierChanges()
        Me.ResetNewModifier()
        Me.pnlNewModifier.Visible = False
        dvModifierCategory.Dispose()

    End Sub

    Private Sub cbxModifierFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModifierFilter.SelectedIndexChanged

        ClearNewModifier()

        Dim valueCatID As Integer
        valueCatID = dvModifierCategory(cbxModifierFilter.SelectedIndex)("CategoryID")
        newModifier.ActiveModifierCategoryID = valueCatID
        newModifier.ActiveModifierID = -1

        Me.lblSelectModifierFilter.Text = cbxModifierFilter.Text

        PopulateModifierDetail()

    End Sub

    Private Sub PopulateModifierDetail()

        With dvModifiers
            .Table = dsSetup.Tables("Modifiers")
            .RowFilter = "CategoryID = '" & newModifier.ActiveModifierCategoryID & "'"
            .Sort = "MenuIndex"
        End With

        With dvModifierStaging
            .Table = dsSetup.Tables("Modifiers")
            .RowFilter = "CategoryID = '" & newModifier.ActiveModifierCategoryID & "' AND MenuIndex = 0"
        End With

        newModifier.PageIndex = 1
        If dvModifiers.Count > 0 Then
            newModifier.MaxIndex = dvModifiers(dvModifiers.Count - 1)("MenuIndex")
        Else
            newModifier.MaxIndex = 0
        End If

        ReDim modifierID(newModifier.MaxIndex + 48)
        ReDim modifierName(newModifier.MaxIndex + 48)
        ReDim modifierIndex(newModifier.MaxIndex + 48)
        '        ReDim modifierDataViewIndex(newModifier.MaxIndex + 32)

        PopulateModifierDataFromTable()
        DisplayModifierPage(newModifier.PageIndex)
        DisplayModifierStagingPage()

        Exit Sub
        '222

        Dim tempCommandString As String = sql.SqlSelectCommandModifiers.CommandText

        dsSetup.Tables("Modifiers").Clear()
        '       Me.SqlInsertCommandModifiers.Parameters("@CategoryID").Value = newModifier.ActiveModifierCategoryID
        sql.SqlSelectCommandModifiers.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandModifiers.Parameters("@LocationID").Value = selectedLocation

        sql.SqlSelectCommandModifiers.CommandText = sql.SqlSelectCommandModifiers.CommandText & " AND Foods.CategoryID = '" & newModifier.ActiveModifierCategoryID & "'"
        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlMenuModifiers.Fill(dsSetup.Tables("Modifiers"))
        sql.cn.Close()
        sql.SqlSelectCommandModifiers.CommandText = tempCommandString

        newModifier.PageIndex = 1
        Try
            newModifier.MaxIndex = dsSetup.Tables("Modifiers").Compute("Max(MenuIndex)", "")
        Catch ex As Exception
            newModifier.MaxIndex = 0
        End Try

        ReDim modifierID(newModifier.MaxIndex + 48)
        ReDim modifierName(newModifier.MaxIndex + 48)
        ReDim modifierIndex(newModifier.MaxIndex + 48)

        PopulateModifierDataFromTable()
        '      CreateModifierStagingDataView()
        DisplayModifierPage(newModifier.PageIndex)
        DisplayModifierStagingPage()


    End Sub

    Private Sub PopulateModifierDataFromTable()

        Dim vRow As DataRowView
        Dim dataViewCount As Integer = 0

        For Each vRow In dvModifiers    'dsSetup.Tables("Modifiers").Rows
            Me.modifierID(vRow("MenuIndex")) = vRow("FoodID")
            Me.modifierName(vRow("MenuIndex")) = vRow("FoodName")
            If vRow("MenuIndex") > 0 Then
                '   we need this b/c a zero is still staging
                Me.modifierIndex(vRow("MenuIndex")) = vRow("MenuIndex")
            End If
            '          Me.modifierDataViewIndex(vRow("MenuIndex")) = dataViewCount
            dataViewCount += 1
        Next

    End Sub

    Private Sub DisplayModifierPage(ByVal pageNumber As Integer)
        Dim index As Integer
        Dim startPosition As Integer
        Dim stopPosition As Integer
        Dim position As Integer = 1

        '   do not need this for modifiers b/c only the same 8 staging panels always
        '        Me.pnlOrderModifierStaging.Controls.Clear()

        '444    Me.ModifierCurrencyMan.SuspendBinding()
        Me.pnlModifierItems.Controls.Clear()

        If pageNumber = 1 Then
            startPosition = 1
            stopPosition = startPosition + 23
        ElseIf pageNumber > 1 Then
            startPosition = ((pageNumber - 1) * 24) + 1     'this increases it by 14 every page
            stopPosition = startPosition + 23
        End If

        Me.pnlModifierItems.SuspendLayout()
        Dim mi As Integer
        Dim vRow As DataRowView

        For index = startPosition To stopPosition
            '          For Each vRow In dvModifiers
            '         If vRow("MenuIndex") = index Then
            mi = ((newModifier.PageIndex - 1) * 24) + position
            If pageNumber > 1 And index = startPosition Then
                DisplayOrderModifiers(1, mi, -1, "Previous", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            ElseIf index = stopPosition And newModifier.MaxIndex > index Then
                ' this is the last panel on page 
                'must add 1 b/c the 1st of next page is the same as the last of this page
                DisplayOrderModifiers(24, mi, -2, "Next", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Else
                '        MsgBox(modifierIndex(index))
                '         If modifierIndex(index) > 0 Then
                DisplayOrderModifiers(position, mi, modifierID(index), modifierName(index), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                '        Else
                '   this might be the same as above : foodname is nothing if foodindex = 0
                '           DisplayOrderModifiers(position, mi, Nothing, "")
                '      End If
            End If
            position += 1
            '       End If
            '        Exit For
            '  Next
        Next

        Me.pnlModifierItems.ResumeLayout()
        newModifierChangesMade = False

    End Sub

    Private Sub DisplayOrderModifiers(ByVal position As Integer, ByVal Index As Integer, ByVal menuJoinId As Integer, ByVal name As String, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)
        Dim w As Single = ((Me.pnlModifierItems.Width - 15) / 4)
        Dim h As Single = ((Me.pnlModifierItems.Height - 23) / 6)
        Dim dTable As String = "Modifiers"
        Dim price = Nothing     'keep in case we want to add

        Select Case position
            Case 1
                modifierOrderPanel1 = New FoodOrderPanel(cs1, cs2, 1, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel1)
            Case 2
                modifierOrderPanel2 = New FoodOrderPanel(cs1, cs2, 2, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel2)
            Case 3
                modifierOrderPanel3 = New FoodOrderPanel(cs1, cs2, 3, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel3)
            Case 4
                modifierOrderPanel4 = New FoodOrderPanel(cs1, cs2, 4, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel4)
            Case 5
                modifierOrderPanel5 = New FoodOrderPanel(cs1, cs2, 5, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel5)
            Case 6
                modifierOrderPanel6 = New FoodOrderPanel(cs1, cs2, 6, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel6)
            Case 7
                modifierOrderPanel7 = New FoodOrderPanel(cs1, cs2, 7, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel7)
            Case 8
                modifierOrderPanel8 = New FoodOrderPanel(cs1, cs2, 8, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel8)
            Case 9
                modifierOrderPanel9 = New FoodOrderPanel(cs1, cs2, 9, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel9)
            Case 10
                modifierOrderPanel10 = New FoodOrderPanel(cs1, cs2, 10, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel10)
            Case 11
                modifierOrderPanel11 = New FoodOrderPanel(cs1, cs2, 11, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel11)
            Case 12
                modifierOrderPanel12 = New FoodOrderPanel(cs1, cs2, 12, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel12)
            Case 13
                modifierOrderPanel13 = New FoodOrderPanel(cs1, cs2, 13, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel13)
            Case 14
                modifierOrderPanel14 = New FoodOrderPanel(cs1, cs2, 14, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel14)
            Case 15
                modifierOrderPanel15 = New FoodOrderPanel(cs1, cs2, 15, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel15)
            Case 16
                modifierOrderPanel16 = New FoodOrderPanel(cs1, cs2, 16, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel16)
            Case 17
                modifierOrderPanel17 = New FoodOrderPanel(cs1, cs2, 17, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel17)
            Case 18
                modifierOrderPanel18 = New FoodOrderPanel(cs1, cs2, 18, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel18)
            Case 19
                modifierOrderPanel19 = New FoodOrderPanel(cs1, cs2, 19, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel19)
            Case 20
                modifierOrderPanel20 = New FoodOrderPanel(cs1, cs2, 20, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel20)
            Case 21
                modifierOrderPanel21 = New FoodOrderPanel(cs1, cs2, 21, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel21)
            Case 22
                modifierOrderPanel22 = New FoodOrderPanel(cs1, cs2, 22, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel22)
            Case 23
                modifierOrderPanel23 = New FoodOrderPanel(cs1, cs2, 23, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel23)
            Case 24
                modifierOrderPanel24 = New FoodOrderPanel(cs1, cs2, 24, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlModifierItems.Controls.Add(modifierOrderPanel24)
                '        Case 25
                '           modifierOrderPanel25 = New FoodOrderPanel(cs1, cs2, 25, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                '          Me.pnlModifierItems.Controls.Add(modifierOrderPanel25)
        End Select

    End Sub

    Private Sub DisplayModifierStagingPage()
        Dim index As Integer = 1
        Dim counter As Integer = 1
        Dim vRow As DataRowView
        Me.pnlOrderModifierStaging.Controls.Clear()

        For Each vRow In dvModifierStaging
            DisplayStagingPanelForModifierItem(counter, 0, vRow("FoodID"), vRow("FoodName"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            counter += 1
        Next
        For index = counter To 8
            DisplayStagingPanelForModifierItem(index, 0, Nothing, "", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Next

    End Sub

    Private Sub DisplayStagingPanelForModifierItem(ByVal position As Integer, ByVal Index As Integer, ByVal menuJoinID As Integer, ByVal name As String, ByVal price As Decimal, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)
        Dim w As Single = (Me.pnlOrderModifierStaging.Width - 15) / 4    '   spacing is 3 
        Dim h As Single = ((Me.pnlOrderModifierStaging.Height - 9) / 2) '3 times #of panels + 3(extra space)
        Dim dTable As String = "Modifiers"

        Select Case position
            Case 1
                modifierOrderStaging1 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging1)
            Case 2
                modifierOrderStaging2 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging2)
            Case 3
                modifierOrderStaging3 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging3)
            Case 4
                modifierOrderStaging4 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging4)
            Case 5
                modifierOrderStaging5 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging5)
            Case 6
                modifierOrderStaging6 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging6)
            Case 7
                modifierOrderStaging7 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging7)
            Case 8
                modifierOrderStaging8 = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging8)
        End Select

        '        modifierOrderStaging(position) = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable)
        '       Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging(position))

    End Sub

    Private Sub ModifierPanelClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles modifierOrderPanel1.MyPanelClick, modifierOrderPanel2.MyPanelClick, modifierOrderPanel3.MyPanelClick, modifierOrderPanel4.MyPanelClick, modifierOrderPanel5.MyPanelClick, modifierOrderPanel6.MyPanelClick, modifierOrderPanel7.MyPanelClick, modifierOrderPanel8.MyPanelClick, modifierOrderPanel9.MyPanelClick, modifierOrderPanel10.MyPanelClick, modifierOrderPanel11.MyPanelClick, modifierOrderPanel12.MyPanelClick, modifierOrderPanel13.MyPanelClick, modifierOrderPanel14.MyPanelClick, modifierOrderPanel15.MyPanelClick, modifierOrderPanel16.MyPanelClick, modifierOrderPanel17.MyPanelClick, modifierOrderPanel18.MyPanelClick, modifierOrderPanel19.MyPanelClick, modifierOrderPanel20.MyPanelClick, modifierOrderPanel21.MyPanelClick, modifierOrderPanel22.MyPanelClick, modifierOrderPanel23.MyPanelClick, modifierOrderPanel24.MyPanelClick, modifierOrderStaging1.MyPanelClick, modifierOrderStaging2.MyPanelClick, modifierOrderStaging3.MyPanelClick, modifierOrderStaging4.MyPanelClick, modifierOrderStaging5.MyPanelClick, modifierOrderStaging6.MyPanelClick, modifierOrderStaging7.MyPanelClick, modifierOrderStaging8.MyPanelClick
        Dim currentOrderPanel As FoodPanelControl
        currentOrderPanel = CType(sender, FoodPanelControl)
        Dim oRow As DataRow
        Dim vRow As DataRowView
        Dim index As Integer = -1
        Dim counter As Integer

        '    Me.ModifierCurrencyMan.ResumeBinding()

        'do not know why the following does not work?????
        If currentOrderPanel.MenuJoinID = -1 Then
            'Previous
            newModifier.PageIndex -= 1
            PopulateModifierDataFromTable()
            DisplayModifierPage(newModifier.PageIndex)
            Exit Sub
        End If

        If currentOrderPanel.MenuJoinID = -2 Then
            'Next
            newModifier.PageIndex += 1
            PopulateModifierDataFromTable()
            DisplayModifierPage(newModifier.PageIndex)
            Exit Sub
        End If

        TestForModifierChanges()



        '       If currentOrderPanel.MenuJoinID > 0 Then

        '         For Each vRow In dvModifiers
        '         If vRow("FoodID") = currentOrderPanel.MenuJoinID Then
        '         txtModifierName.Text = vRow("FoodName")
        '         txtModifierAbrev.Text = vRow("AbrevFoodName")
        '        txtModifierChit.Text = vRow("ChitFoodName")
        '        If Not vRow("FoodCost") Is DBNull.Value Then
        ''        txtModifierCost.Text = vRow("FoodCost")
        '    Else
        '        txtModifierCost.Text = "0"
        '    End If
        ''   If Not vRow("Surcharge") Is DBNull.Value Then
        '       txtModifierSurcharge.Text = vRow("Surcharge")
        '   Else
        '          txtModifierSurcharge.Text = "0"
        '      End If
        '      cbxModifierRouting.SelectedIndex = -1
        '     If Not vRow("RoutingName") Is DBNull.Value Then
        ''         For Each oRow In dsSetup.Tables("RoutingChoice").Rows
        '         If oRow("RoutingName") = vRow("RoutingName") Then
        ''        cbxModifierRouting.SelectedText = vRow("RoutingName")
        '    End If
        '      Next
        '   End If
        '       If Not vRow("FoodDesc") Is DBNull.Value Then
        '           txtModifierDescription.Text = vRow("FoodDesc")
        ''      Else
        '          txtModifierDescription.Text = ""
        '      End If
        '
        ''        Exit For
        '        End If
        '           Next

        '      Else
        '        txtModifierName.Text = ""
        '       txtModifierAbrev.Text = ""
        '      txtModifierChit.Text = ""
        '     txtModifierCost.Text = "0"
        '    txtModifierSurcharge.Text = "0"
        '   cbxModifierRouting.SelectedIndex = -1
        '  txtModifierDescription.Text = ""

        '     End If

        For Each vRow In dvModifiers    'dsSetup.Tables("Modifiers").Rows
            '     If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
            If Not vRow("FoodID") Is DBNull.Value Then
                If vRow("FoodID") = currentOrderPanel.MenuJoinID Then
                    index = counter
                    Exit For
                End If
            End If
            counter += 1
            '    End If
        Next

        If index <> -1 Then
            Me.ModifierCurrencyMan.ResumeBinding()
            Me.ModifierCurrencyMan.Position = index
        Else
            '       Me.pnlNewCategory.Visible = True
            Me.ModifierCurrencyMan.SuspendBinding()
        End If

        newModifierChangesMade = False 'keep false until info changes
        RecordLastPanel(currentOrderPanel)
        Me.txtModifierName.Focus()

    End Sub

    Private Sub TestForModifierChanges()

        If newModifierChangesMade = True Then
            If Me.txtModifierName.Text.Length > 0 Then
                If Me.txtModifierAbrev.Text.Length = 0 Then
                    Me.txtModifierAbrev.Text = Me.txtModifierName.Text
                End If
                If Me.txtModifierChit.Text.Length = 0 Then
                    Me.txtModifierChit.Text = Me.txtModifierName.Text
                End If
            End If
            newModifier.ActiveModifierName = Me.txtModifierName.Text
            newModifier.ActiveAbrevText = Me.txtModifierAbrev.Text

            UpdateDatabaseModifiers()
            UpdateNewModifierPanel()

            newModifierChangesMade = False
        End If

    End Sub

    Private Sub UpdateNewModifierPanel()
        '       If newModifier.ActiveModifierID = Nothing Then
        '      newModifier.ActiveModifierID = GetMaximumID("FoodID", "Foods")
        '     End If
        Try
            newModifier.ChangingPanel.MenuJoinID = newModifier.ActiveModifierID 'this is FoodID
            newModifier.ChangingPanel.FoodName = newModifier.ActiveModifierName 'oRow("FoodName")
            newModifier.ChangingPanel.Text = newModifier.ActiveAbrevText 'oRow("FoodName")
            newModifier.ChangingPanel.MenuIndex = newModifier.MenuIndex

            '      SaveNewPanelDisplay()
            '444     KeepModifierPanelBlank()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SaveNewPanelDisplay()
        '   ************ does not work

        Me.modifierID(newModifier.ChangingPanel.Position) = newModifier.ActiveModifierID
        Me.modifierName(newModifier.ChangingPanel.Position) = newModifier.ActiveModifierName
        Me.modifierIndex(newModifier.ChangingPanel.Position) = newModifier.MenuIndex


    End Sub

    Private Sub ModifierMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles modifierOrderPanel1.GridMouseDown, modifierOrderPanel2.GridMouseDown, modifierOrderPanel3.GridMouseDown, modifierOrderPanel4.GridMouseDown, modifierOrderPanel5.GridMouseDown, modifierOrderPanel16.GridMouseDown, modifierOrderPanel7.GridMouseDown, modifierOrderPanel8.GridMouseDown, modifierOrderPanel9.GridMouseDown, modifierOrderPanel10.GridMouseDown, modifierOrderPanel11.GridMouseDown, modifierOrderPanel12.GridMouseDown, modifierOrderPanel13.GridMouseDown, modifierOrderPanel14.GridMouseDown, modifierOrderPanel15.GridMouseDown, modifierOrderPanel16.GridMouseDown

        TestForModifierChanges()
        '      Dim currentOrderPanel As FoodPanelControl
        '     currentOrderPanel = CType(sender, FoodPanelControl)
        '
        '       RecordLastPanel(currentOrderPanel)

    End Sub

    Private Sub ModifierMouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles modifierOrderPanel1.BlankOldModifierPanel, modifierOrderPanel2.BlankOldModifierPanel, modifierOrderPanel3.BlankOldModifierPanel, modifierOrderPanel4.BlankOldModifierPanel, modifierOrderPanel5.BlankOldModifierPanel, modifierOrderPanel6.BlankOldModifierPanel, modifierOrderPanel7.BlankOldModifierPanel, modifierOrderPanel8.BlankOldModifierPanel, modifierOrderPanel9.BlankOldModifierPanel, modifierOrderPanel10.BlankOldModifierPanel, modifierOrderPanel11.BlankOldModifierPanel, modifierOrderPanel12.BlankOldModifierPanel, modifierOrderPanel13.BlankOldModifierPanel, modifierOrderPanel14.BlankOldModifierPanel, modifierOrderPanel15.BlankOldModifierPanel, modifierOrderPanel16.BlankOldModifierPanel, modifierOrderPanel17.BlankOldModifierPanel, modifierOrderPanel18.BlankOldModifierPanel, modifierOrderPanel19.BlankOldModifierPanel, modifierOrderPanel20.BlankOldModifierPanel, modifierOrderPanel21.BlankOldModifierPanel, modifierOrderPanel22.BlankOldModifierPanel, modifierOrderPanel23.BlankOldModifierPanel, modifierOrderPanel24.BlankOldModifierPanel, modifierOrderStaging1.BlankOldModifierPanel, modifierOrderStaging2.BlankOldModifierPanel, modifierOrderStaging3.BlankOldModifierPanel, modifierOrderStaging4.BlankOldModifierPanel, modifierOrderStaging5.BlankOldModifierPanel, modifierOrderStaging6.BlankOldModifierPanel, modifierOrderStaging7.BlankOldModifierPanel, modifierOrderStaging8.BlankOldModifierPanel

        KeepModifierPanelBlank()
        SaveModifierChanges()

    End Sub


    Private Sub RecordLastPanel(ByRef currentOrderPanel As FoodPanelControl)

        newModifier.ActiveModifierID = currentOrderPanel.MenuJoinID
        newModifier.ActiveModifierName = currentOrderPanel.Name
        newModifier.ActiveAbrevText = currentOrderPanel.Text
        newModifier.ChangingPanel = currentOrderPanel

        If newModifier.PageIndex = 1 Then
            newModifier.MenuIndex = currentOrderPanel.Position
        Else
            newModifier.MenuIndex = currentOrderPanel.Position + ((newModifier.PageIndex - 1) * 22) + 1
        End If

    End Sub

    Private Sub KeepModifierPanelBlank()

        Me.modifierID(newModifier.MenuIndex) = Nothing
        Me.modifierName(newModifier.MenuIndex) = Nothing
        Me.modifierIndex(newModifier.MenuIndex) = Nothing

    End Sub

    Private Sub ModifierChangesMade(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifierName.TextChanged, txtModifierAbrev.TextChanged, txtModifierAbrev.TextChanged, txtModifierSurcharge.TextChanged, cbxModifierRouting.SelectedIndexChanged, txtModifierCost.TextChanged, txtModifierDescription.TextChanged

        newModifierChangesMade = True

    End Sub


    Private Sub btnUpdateModifiers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' we must update panel first because
        If newModifierChangesMade = True Then
            newModifier.ActiveModifierName = Me.txtModifierName.Text
            newModifier.ActiveAbrevText = Me.txtModifierAbrev.Text
            UpdateNewModifierPanel()
            UpdateDatabaseModifiers()
            newModifierChangesMade = False
        Else

            '   this must be outside in order to update moving panels
            SaveModifierChanges()
        End If


    End Sub


    Private Sub btnRemoveModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveModifier.Click

        Dim oRow As DataRow
       
        For Each oRow In dsSetup.Tables("Modifiers").Rows
            If oRow("FoodID") = newModifier.ActiveModifierID Then
                oRow("MenuIndex") = 0
                Exit For
            End If
        Next
        KeepModifierPanelBlank()
        SaveModifierChanges()

        Exit Sub
        'below 222

        If MsgBox("Are you sure you want to remove the " & txtModifierName.Text & " Modifier and all its Joins?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            '   Dim oRow As DataRow
            SaveModifierChanges()
            Me.ModifierCurrencyMan.SuspendBinding()

            If Not newModifier.ActiveModifierID = Nothing Then
                For Each oRow In dsSetup.Tables("Modifiers").Rows   'dvModifiers    '
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If oRow("FoodID") = newModifier.ActiveModifierID Then
                            Exit For
                        End If
                    End If
                Next
                '         oRow = dsSetup.Tables("Modifiers").Rows.Find(newModifier.ActiveModifierID)
                If Not oRow.RowState = DataRowState.Deleted Then
                    oRow.Delete()
                End If

                newModifier.ActiveModifierName = ""
                newModifier.ActiveAbrevText = ""
                '       newModifier.MenuIndex = Nothing


                Dim modifierDeleteCommand As New SqlClient.SqlCommand("DELETE FROM FoodJoin WHERE ModifierID = '" & newModifier.ActiveModifierID & "'", sql.cn)
                Try
                    sql.cn.Open()
                    sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                    modifierDeleteCommand.ExecuteNonQuery()
                    sql.cn.Close()
                Catch ex As Exception
                    CloseConnection()
                End Try

                newModifier.ActiveModifierID = Nothing

                UpdateNewModifierPanel()
                SaveModifierChanges()

            End If

        End If

    End Sub

    Private Sub UpdateDatabaseModifiers()

        Dim oRow As DataRow
        Dim vRow As DataRowView

        If newModifier.ActiveModifierID = Nothing Then
            If Me.txtModifierName.Text.Length = 0 Then
                '777  ???            Me.ModifierCurrencyMan.ResumeBinding()
                Exit Sub
            Else

            End If
            '           If ErrorProvider1.GetError(Me.txtNewModifierName).Length > 0 Then
            '          Exit Sub
            '     End If
            '    If ErrorProvider1.GetError(Me.txtNewModifierAbrev).Length > 0 Then
            '       txtNewModifierAbrev.Text = Me.txtNewModifierName.Text
            '  End If
            '' If ErrorProvider1.GetError(Me.txtNewModifierChit).Length > 0 Then
            '      Me.txtNewModifierChit.Text = Me.txtNewModifierAbrev.Text
            ' End If

            EnteringNewModifier()
            '      Me.pnlNewModifier.Visible = True
            '       need to show new modifier panel
        Else
            Exit Sub    '444

            For Each vRow In dvModifiers    'dsSetup.Tables("Modifiers").Rows
                '       If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If vRow("FoodID") = newModifier.ActiveModifierID Then Exit For
                '      End If
            Next
            vRow("CompanyID") = corpID
            vRow("LocationID") = selectedLocation
            vRow("FoodName") = Me.txtModifierName.Text
            vRow("AbrevFoodName") = Me.txtModifierAbrev.Text
            vRow("ChitFoodName") = Me.txtModifierChit.Text
            vRow("CategoryID") = newModifier.ActiveModifierCategoryID
            Try
                vRow("FoodCost") = CType(Me.txtModifierCost.Text, Decimal)
            Catch ex As Exception
                vRow("FoodCost") = 0
            End Try

            Try
                vRow("Surcharge") = CType(Me.txtModifierSurcharge.Text, Decimal)
            Catch ex As Exception
                vRow("Surcharge") = 0
            End Try
            vRow("FoodDesc") = Me.txtModifierDescription.Text
            vRow("MenuIndex") = newModifier.MenuIndex
            Try
                If Me.cbxModifierRouting.SelectedIndex = -1 Then
                    vRow("RoutingID") = DBNull.Value
                Else
                    vRow("RoutingID") = dsSetup.Tables("RoutingChoice").Rows(Me.cbxModifierRouting.SelectedIndex)("RoutingID")
                End If
            Catch ex As Exception
                vRow("RoutingID") = DBNull.Value
            End Try
            vRow("Active") = 1

        End If


        Exit Sub

        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("FoodName") = Me.txtModifierName.Text
        oRow("AbrevFoodName") = Me.txtModifierAbrev.Text
        oRow("ChitFoodName") = Me.txtModifierChit.Text
        oRow("CategoryID") = newModifier.ActiveModifierCategoryID
        Try
            oRow("FoodCost") = CType(Me.txtModifierCost.Text, Decimal)
        Catch ex As Exception
            oRow("FoodCost") = 0
        End Try

        Try
            oRow("Surcharge") = CType(Me.txtModifierSurcharge.Text, Decimal)
        Catch ex As Exception
            oRow("Surcharge") = 0
        End Try
        oRow("FoodDesc") = Me.txtModifierDescription.Text
        oRow("MenuIndex") = newModifier.MenuIndex
        Try
            oRow("RoutingID") = dsSetup.Tables("RoutingChoice").Rows(Me.cbxModifierRouting.SelectedIndex)("RoutingID")
        Catch ex As Exception
            oRow("RoutingID") = DBNull.Value
        End Try

        If newModifier.ActiveModifierID = Nothing Then
            oRow("Active") = 1
            newModifier.ActiveModifierID = oRow("FoodID")
            dsSetup.Tables("Modifiers").Rows.Add(oRow)
        Else
            '777            ModifierCurrencyMan.Position += 1
            '777           ModifierCurrencyMan.Position -= 1
        End If

        SaveModifierChanges()

    End Sub


    Private Sub SaveModifierChanges()
        Dim dsChangedData As DataSet
        Dim oRow As DataRow

        '   cleans up data (needed especially for drag & drop)
        '        For Each oRow In dsSetup.Tables("Modifiers").Rows
        '       If oRow("AbrevFoodName") = "" Or oRow("AbrevFoodName") = Nothing Then
        '      oRow.Delete()
        '     End If
        '    Next

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlMenuModifiers.Update(dsSetup, "Modifiers")  ' or dsSetup
        sql.cn.Close()

        dsSetup.Tables("Modifiers").AcceptChanges()
        newModifierChangesMade = False

        Exit Sub

        If dsSetup.HasChanges Then

            dsChangedData = dsSetup.GetChanges() '(DataRowState.Modified Or DataRowState.Added)

            If dsSetup.HasChanges Then
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlMenuModifiers.Update(dsChangedData, "Modifiers")  ' or dsSetup
                sql.cn.Close()
            End If

            dsSetup.AcceptChanges()
            dsChangedData.Clear()
            newModifierChangesMade = False
            '        ClearNewModifier()
        End If

    End Sub

    Private Sub ClearNewModifier()
        With newModifier
            .ChangesMade = False
            .ActiveModifierID = Nothing
            .ActiveModifierName = Nothing
            .ActiveAbrevText = Nothing
            '           .MenuIndex = Nothing            not sure about(we may need)
        End With
    End Sub

    Private Sub cbxModifierRouting_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModifierRouting.SelectedIndexChanged
        Dim valueCatID As Integer
        Dim valueCatName As String
        Dim vRow As DataRowView

        If Me.cbxModifierRouting.SelectedItem = "Route w/ Food" Then ' dsSetup.Tables("RoutingChoice").Rows.Count Then
            dvModifiers(Me.ModifierCurrencyMan.Position)("RoutingID") = DBNull.Value
            dvModifiers(Me.ModifierCurrencyMan.Position)("RoutingName") = DBNull.Value
            '       Me.cbxModifierRouting.SelectedIndex = -1
            Me.newModifierChangesMade = True
        Else
            valueCatID = dsSetup.Tables("RoutingChoice").Rows(cbxModifierRouting.SelectedIndex)("RoutingID")
            valueCatName = dsSetup.Tables("RoutingChoice").Rows(cbxModifierRouting.SelectedIndex)("RoutingName")

            If Not dvModifiers(Me.ModifierCurrencyMan.Position)("RoutingID") = valueCatID Then
                dvModifiers(Me.ModifierCurrencyMan.Position)("RoutingID") = valueCatID
                dvModifiers(Me.ModifierCurrencyMan.Position)("RoutingName") = valueCatName
            End If

        End If

        '    dsSetup.Tables("Modifiers").Rows(Me.ModifierCurrencyMan.Position)("RoutingID") = valueCatID
        '   dsSetup.Tables("Modifiers").Rows(Me.ModifierCurrencyMan.Position)("RoutingName") = valueCatName

    End Sub

    Private Sub btnModifierAddPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifierAddPage.Click
        If ((newModifier.PageIndex * 24) - 24) > newModifier.MaxIndex Then Exit Sub
        '   this is so we don't create another page unless this one has info

        Dim oRow As DataRow

        '   this should be +1 or +2  ??????
        If Me.modifierOrderPanel24.foodPanel.MenuJoinID > 0 Then
            For Each oRow In dsSetup.Tables("Modifiers").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FoodID") = Me.modifierOrderPanel24.foodPanel.MenuJoinID Then
                        oRow("MenuIndex") = oRow("MenuIndex") + 2
                        Me.modifierIndex(oRow("MenuIndex")) = oRow("MenuIndex")
                        Me.modifierID(oRow("MenuIndex")) = oRow("FoodID")
                        Me.modifierName(oRow("MenuIndex")) = oRow("FoodName")
                        Exit For
                    End If
                End If
            Next
        End If


        newModifier.MaxIndex += 24
        '    UpdateOrderModifiers()
        '     newModifierChangesMade = True
        Me.SaveModifierChanges()

        If (newModifier.PageIndex * 24) > newModifier.MaxIndex Then
            '   this means we are on the last page so we increase the dimension
            ReDim modifierID((newModifier.PageIndex * 24) + 24)
            ReDim modifierName((newModifier.PageIndex * 24) + 24)
            ReDim modifierIndex((newModifier.PageIndex * 24) + 24)
            PopulateModifierDataFromTable()
        End If
        newModifier.PageIndex += 1

        DisplayModifierPage(newModifier.PageIndex)

    End Sub

    Private Sub btnModifierRemovePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifierRemovePage.Click
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("Modifiers").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("MenuIndex") > (newModifier.PageIndex - 1) * 24 Then
                    MsgBox("You can not Remove a Page until all Modifiers are located on Previous Pages or Staging.")
                    Exit Sub
                End If
            End If
        Next
        newModifier.PageIndex -= 1

        '      newModifier.MaxIndex = dsSetup.Tables("Modifiers").Compute("Max(MenuIndex)", "")

        DisplayModifierPage(newModifier.PageIndex)

    End Sub

    Private Sub txtAbrevModifierName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModifierAbrev.Enter
        If txtModifierAbrev.Text.Length = 0 Then
            txtModifierAbrev.Text = Me.txtModifierName.Text
        End If
    End Sub

    Private Sub txtChitModifierName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModifierChit.Enter
        If txtModifierChit.Text.Length = 0 Then
            txtModifierChit.Text = Me.txtModifierName.Text
        End If
    End Sub

    'new modifiers
    Private Sub txtNewAbrevModifierName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewModifierAbrev.Enter
        If txtNewModifierAbrev.Text.Length = 0 Then
            txtNewModifierAbrev.Text = Me.txtNewModifierName.Text
        End If
    End Sub

    Private Sub txtNewChitModifierName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewModifierChit.Enter
        If txtNewModifierChit.Text.Length = 0 Then
            txtNewModifierChit.Text = Me.txtNewModifierName.Text
        End If
    End Sub

    Private Sub txtNewModifierName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewModifierName.Validating
        ValidateString(Me.txtNewModifierName)
    End Sub

    Private Sub txtNewModifierAbrev_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewModifierAbrev.Validating
        ValidateString(Me.txtNewModifierAbrev)
    End Sub

    Private Sub txtNewModifierChit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewModifierChit.Validating
        ValidateString(Me.txtNewModifierChit)
    End Sub

    Private Sub txtNewModifierDescription_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewModifierDescription.Validating
        ValidateStringAcceptBlanks(Me.txtNewModifierDescription)
    End Sub

    Private Sub btnAcceptModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptModifier.Click
        If ErrorProvider1.GetError(Me.txtNewModifierName).Length > 0 Then
            Exit Sub
        End If
        If ErrorProvider1.GetError(Me.txtNewModifierAbrev).Length > 0 Then
            txtNewModifierAbrev.Text = Me.txtNewModifierName.Text
        End If
        If ErrorProvider1.GetError(Me.txtNewModifierChit).Length > 0 Then
            Me.txtNewModifierChit.Text = Me.txtNewModifierAbrev.Text
        End If

        EnteringNewModifier()
        ResetNewModifier()
        Me.pnlNewModifier.Visible = False

    End Sub

    Private Sub EnteringNewModifier()
        '666   ***********************
        'trying something new
        'we will only enter new modifier under Foods
        '******************************

        Dim oRow As DataRow
        Dim newFoodId As Integer

        oRow = dsSetup.Tables("Modifiers").NewRow

        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("FoodName") = Me.txtModifierName.Text ' "   ** Empty Food **"
        oRow("AbrevFoodName") = Me.txtModifierAbrev.Text '""
        oRow("ChitFoodName") = Me.txtModifierChit.Text '""
        oRow("FoodDesc") = Me.txtModifierDescription.Text
        oRow("CategoryID") = newModifier.ActiveModifierCategoryID

        Try
            oRow("FoodCost") = CType(Me.txtModifierCost.Text, Decimal)
        Catch ex As Exception
            oRow("FoodCost") = 0
        End Try

        Try
            oRow("Surcharge") = CType(Me.txtModifierSurcharge.Text, Decimal)
        Catch ex As Exception
            oRow("Surcharge") = 0
        End Try
        oRow("InvMultiplier") = 1
        oRow("FoodDesc") = Me.txtModifierDescription.Text
        oRow("MenuIndex") = newModifier.MenuIndex
        If Me.cbxModifierRouting.SelectedIndex = -1 Then
            oRow("RoutingID") = DBNull.Value
        Else
            oRow("RoutingID") = dsSetup.Tables("RoutingChoice").Rows(Me.cbxModifierRouting.SelectedIndex)("RoutingID")
        End If
        oRow("Active") = 1

        dsSetup.Tables("Modifiers").Rows.Add(oRow)

        oRow("FoodID") = InsertingNewModifier(oRow)

        newModifier.ActiveModifierID = oRow("FoodID")
        UpdateNewModifierPanel()

        dsSetup.Tables("Modifiers").AcceptChanges()

        '???        UpdateModifierPanel(oRow)

        '666
        '    UpdateMenuJoin()

    End Sub
    Private Function InsertingNewModifier(ByRef orow As DataRow)
        Dim newFoodID As Integer

        sql.SqlInsertCommandModifiers.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandModifiers.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandModifiers.Parameters("@FoodName").Value = orow("FoodName")
        sql.SqlInsertCommandModifiers.Parameters("@AbrevFoodName").Value = orow("AbrevFoodName")
        sql.SqlInsertCommandModifiers.Parameters("@ChitFoodName").Value = orow("ChitFoodName")
        sql.SqlInsertCommandModifiers.Parameters("@CategoryID").Value = orow("CategoryID")
        sql.SqlInsertCommandModifiers.Parameters("@FoodCost").Value = orow("FoodCost")
        '      sql.SqlInsertCommandModifiers.Parameters("@TaxID").Value = DBNull.Value 'this is not used
        sql.SqlInsertCommandModifiers.Parameters("@FoodDesc").Value = orow("FoodDesc")
        sql.SqlInsertCommandModifiers.Parameters("@Surcharge").Value = orow("Surcharge")
        sql.SqlInsertCommandModifiers.Parameters("@RoutingID").Value = orow("RoutingID")
        sql.SqlInsertCommandModifiers.Parameters("@Active").Value = 1
        sql.SqlInsertCommandModifiers.Parameters("@MenuIndex").Value = orow("MenuIndex")
        sql.SqlInsertCommandModifiers.Parameters("@InvMultiplier").Value = orow("InvMultiplier")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newFoodID = CType(sql.SqlInsertCommandModifiers.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newFoodID

    End Function

    Private Sub UpdateModifierPanel222(ByRef oRow As DataRow)
        Dim mi As Integer

        mi = ((newModifier.PageIndex - 1) * 24) + newModifier.MenuIndex
        Me.modifierID(newModifier.MenuIndex) = oRow("FoodID")
        Me.modifierName(newModifier.MenuIndex) = oRow("FoodName")
        Me.modifierIndex(newModifier.MenuIndex) = oRow("MenuIndex")
        DisplayOrderModifiers(newModifier.MenuIndex, mi, modifierID(newModifier.MenuIndex), modifierName(newModifier.MenuIndex), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub btnCancelModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelModifier.Click
        ResetNewModifier()
        Me.pnlNewModifier.Visible = False

    End Sub

    Private Sub ResetNewModifier()

        Me.txtNewModifierName.Text = ""
        Me.txtNewModifierAbrev.Text = ""
        Me.txtNewModifierChit.Text = ""
        Me.txtNewModifierSurcharge.Text = "0"
        Me.cbxNewModifierRouting.SelectedIndex = -1
        Me.txtNewModifierCost.Text = "0"
        Me.txtNewModifierDescription.Text = ""

    End Sub


    '************************************************************************************
    '   Food Joins
    '************************************************************************************

    Private Sub DisplayFoodJoinGrids()

     
        '***************************
        '   Join Food Choice
        Dim tsJoinFoodChoice As New DataGridTableStyle
        tsJoinFoodChoice.MappingName = "FoodTable"
        tsJoinFoodChoice.RowHeadersVisible = False
        tsJoinFoodChoice.GridLineColor = Color.White

        Dim csJoinFoodID As New DataGridTextBoxColumn
        csJoinFoodID.MappingName = "FoodID"
        csJoinFoodID.Width = 0

        Dim csJoinFoodName As New DataGridTextBoxColumn
        csJoinFoodName.MappingName = "FoodName"
        csJoinFoodName.Width = Me.grdJoinFoodChoice.Width * 0.85

        tsJoinFoodChoice.GridColumnStyles.Add(csJoinFoodID)
        tsJoinFoodChoice.GridColumnStyles.Add(csJoinFoodName)
        grdJoinFoodChoice.TableStyles.Add(tsJoinFoodChoice)

        '***************************
        '   Join Food Category Joins
        Dim tsJoinFoodCategoryJoins As New DataGridTableStyle
        tsJoinFoodCategoryJoins.MappingName = "JoinFoodCategoryJoins"
        tsJoinFoodCategoryJoins.RowHeadersVisible = False
        tsJoinFoodCategoryJoins.GridLineColor = Color.White

        Dim csJoinFoodJoinID As New DataGridTextBoxColumn
        csJoinFoodJoinID.MappingName = "FoodJoinID"
        csJoinFoodJoinID.Width = 0

        Dim csJoinFoodJoinCategoryName As New DataGridTextBoxColumn
        csJoinFoodJoinCategoryName.MappingName = "CategoryName"
        '     csJoinFoodJoinCategoryName.ReadOnly = True
        csJoinFoodJoinCategoryName.Width = Me.grdJoinFoodCategoryJoins.Width * 0.65
        csJoinFoodJoinCategoryName.NullText = ""

        '     Dim csJoinFoodCost As New DataGridTextBoxColumn 'BoolColumn
        '    csJoinFoodCost.MappingName = "NumberFree"
        '   csJoinFoodCost.Width = Me.grdJoinFoodCategoryJoins.Width * 0.2

        Dim csJoinFoodFree As New DataGridTextBoxColumn 'BoolColumn
        csJoinFoodFree.MappingName = "FreeFlag"
        csJoinFoodFree.Width = Me.grdJoinFoodCategoryJoins.Width * 0.1
        csJoinFoodFree.NullText = ""

        Dim csJoinGTC As New DataGridTextBoxColumn 'BoolColumn
        csJoinGTC.MappingName = "GTCFlag"
        csJoinGTC.Width = Me.grdJoinFoodCategoryJoins.Width * 0.1
        csJoinGTC.NullText = ""

        Dim csJoinFoodReq As New DataGridTextBoxColumn 'BoolColumn
        csJoinFoodReq.MappingName = "ReqFlag"
        csJoinFoodReq.Width = Me.grdJoinFoodCategoryJoins.Width * 0.1
        csJoinFoodReq.NullText = ""

        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodJoinID)
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodJoinCategoryName)
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodFree)
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinGTC)
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodReq)

        grdJoinFoodCategoryJoins.TableStyles.Add(tsJoinFoodCategoryJoins)

        '***************************
        '   Join Food Modifier Joins
        Dim tsJoinFoodModifierJoins As New DataGridTableStyle
        tsJoinFoodModifierJoins.MappingName = "JoinFoodModifierJoins"
        tsJoinFoodModifierJoins.RowHeadersVisible = False
        tsJoinFoodModifierJoins.GridLineColor = Color.White

        Dim csJoinFoodJoinModifierID As New DataGridTextBoxColumn
        csJoinFoodJoinModifierID.MappingName = "FoodJoinID"
        csJoinFoodJoinModifierID.Width = 0

        Dim csJoinFoodJoinModifierName As New DataGridTextBoxColumn
        csJoinFoodJoinModifierName.MappingName = "FoodName"
        '    csJoinFoodJoinModifierName.ReadOnly = True
        csJoinFoodJoinModifierName.Width = Me.grdJoinFoodModifierJoins.Width * 0.75
        csJoinFoodJoinModifierName.NullText = ""

        '      Dim csJoinFoodJoinModifierCost As New DataGridTextBoxColumn 'BoolColumn
        '     csJoinFoodJoinModifierCost.MappingName = "NumberFree"
        '    csJoinFoodJoinModifierCost.Width = Me.grdJoinFoodModifierJoins.Width * 0.2

        Dim csJoinFoodJoinModifierFree As New DataGridTextBoxColumn 'BoolColumn
        csJoinFoodJoinModifierFree.MappingName = "FreeFlag"
        csJoinFoodJoinModifierFree.Width = Me.grdJoinFoodModifierJoins.Width * 0.1
        csJoinFoodJoinModifierFree.NullText = ""

        Dim csJoinFoodJoinModifierGroup As New DataGridTextBoxColumn 'BoolColumn
        csJoinFoodJoinModifierGroup.MappingName = "GroupFlag"
        csJoinFoodJoinModifierGroup.Width = Me.grdJoinFoodModifierJoins.Width * 0.1
        csJoinFoodJoinModifierGroup.NullText = ""

        '      Dim csJoinFoodJoinModifierReq As New DataGridTextBoxColumn 'BoolColumn
        '     csJoinFoodJoinModifierReq.MappingName = "ReqFlag"
        '    csJoinFoodJoinModifierReq.Width = Me.grdJoinFoodModifierJoins.Width * 0.1
        '  csJoinFoodJoinModifierReq.NullText = ""

        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierID)
        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierName)
        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierFree)
        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierGroup)
        '    tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierReq)
        grdJoinFoodModifierJoins.TableStyles.Add(tsJoinFoodModifierJoins)

        '     dsSetup.Tables("JoinFoodCategoryJoins").Clear()
        '    dsSetup.Tables("JoinFoodModifierJoins").Clear()


        '   ************************
        '   Join Possible Categories
        Dim tsJoinPossibleCategories As New DataGridTableStyle
        tsJoinPossibleCategories.MappingName = "MainCategory" '"Main_ModifierCategory2"
        tsJoinPossibleCategories.RowHeadersVisible = False
        tsJoinPossibleCategories.GridLineColor = Color.White

        Dim csJoinCategoryID As New DataGridTextBoxColumn
        csJoinCategoryID.MappingName = "CategoryID"
        csJoinCategoryID.Width = 0

        Dim csJoinCategoryName As New DataGridTextBoxColumn
        csJoinCategoryName.MappingName = "CategoryName"
        csJoinCategoryName.Width = Me.grdJoinPossibleCategories.Width * 0.85

        tsJoinPossibleCategories.GridColumnStyles.Add(csJoinCategoryID)
        tsJoinPossibleCategories.GridColumnStyles.Add(csJoinCategoryName)
        grdJoinPossibleCategories.TableStyles.Add(tsJoinPossibleCategories)


        '   *************************
        '   Join Individual Modifiers
        '      Dim tsJoinIndividualModifiers As New DataGridTableStyle
        tsJoinIndividualModifiers.MappingName = "Modifiers" '"Modifiers2"
        tsJoinIndividualModifiers.RowHeadersVisible = False
        tsJoinIndividualModifiers.GridLineColor = Color.White

        Dim csJoinModifierID As New DataGridTextBoxColumn
        csJoinModifierID.MappingName = "FoodID"
        csJoinModifierID.Width = 0

        Dim csJoinModifierName As New DataGridTextBoxColumn
        csJoinModifierName.MappingName = "FoodName"
        csJoinModifierName.Width = Me.grdJoinIndividualModifiers.Width * 0.85

        tsJoinIndividualModifiers.GridColumnStyles.Add(csJoinModifierID)
        tsJoinIndividualModifiers.GridColumnStyles.Add(csJoinModifierName)
        grdJoinIndividualModifiers.TableStyles.Add(tsJoinIndividualModifiers)

    End Sub

    Private Sub cbxJoinCategorySelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxJoinCategorySelect.SelectedIndexChanged
        Dim valueCatID As Integer

        valueCatID = dvFoodJoinMainFoodsCagtegory(cbxJoinCategorySelect.SelectedIndex)("CategoryID")
        globalJoinValueCategoryID = valueCatID

        '       With dvFoods
        '      .Table = dsSetup.Tables("FoodTable")
        '     .RowFilter = "CategoryID = " & valueCatID
        '    End With

        With dvFoodsJoins
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "CategoryID = " & valueCatID
        End With

        '   this is if we only have one food in category
        If dsSetup.Tables("FoodTable").Rows.Count = 1 Then
            PopulateFoodJoinData(Me.grdJoinFoodChoice)
            '   this resets out choices
            GridFoodJoinJustClicked()
        End If






        ':    dsSetup.Tables("FoodTable").Clear()

        '       sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
        '      sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation
        '     sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = valueCatID

        '        Try
        '        sql.cn.Open()
        '              sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        '        sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
        '        sql.cn.Close()
        '       Catch ex As Exception
        ''       CloseConnection()
        '      End Try




    End Sub

    Private Sub cbxJoinIndividualModifierSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxJoinIndividualModifierSelect.SelectedIndexChanged
        Dim valueCatID As Integer
        Dim valueFunFlag As String
        '      valueCatID = dsSetup.Tables("Main_ModifierCategory2").Rows(cbxJoinIndividualModifierSelect.SelectedIndex)("CategoryID")
        '  valueFunFlag = dsSetup.Tables("Main_ModifierCategory2").Rows(cbxJoinIndividualModifierSelect.SelectedIndex)("FunctionFlag")
        valueCatID = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("CategoryID")
        valueFunFlag = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("FunctionFlag")

        '       Dim tempCommandString As String
        '      sql.SqlSelectCommandModifiers.Parameters("@CompanyID").Value = corpID
        '     sql.SqlSelectCommandModifiers.Parameters("@LocationID").Value = selectedLocation

        If valueFunFlag = "M" Then 'valueCatID > 100 Then
            tsJoinIndividualModifiers.MappingName = "Modifiers"
            With dvModifiers2
                .Table = dsSetup.Tables("Modifiers")
                .RowFilter = "CategoryID = '" & valueCatID & "'"
                .Sort = "CategoryID, FoodName"
            End With

            '           tempCommandString = sql.SqlSelectCommandModifiers.CommandText()
            '         dsSetup.Tables("Modifiers2").Clear()
            '         sql.SqlSelectCommandModifiers.CommandText = sql.SqlSelectCommandModifiers.CommandText & " AND Foods.CategoryID = '" & valueCatID & "'"
            '         sql.cn.Open()
            '              sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            ''        sql.SqlMenuModifiers.Fill(dsSetup.Tables("Modifiers2"))
            '       sql.cn.Close()
            '      sql.SqlSelectCommandModifiers.CommandText = tempCommandString
        Else
            tsJoinIndividualModifiers.MappingName = "FoodTable"
            With dvModifiers2
                .Table = dsSetup.Tables("FoodTable")
                .RowFilter = "CategoryID = '" & valueCatID & "'" ' AND FunctionFlag = 'O'"
                .Sort = "CategoryID, FoodName"
            End With

            '        changed below .. probably need to change above for consistency 
            '         dsSetup.Tables("Modifiers2").Clear()
            '         sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = valueCatID
            '         sql.cn.Open()
            ''              sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            '       sql.SqlMenuFoods.Fill(dsSetup.Tables("Modifiers2"))
            '      sql.cn.Close()
        End If

    End Sub

    Private Sub grdJoinFoodChoice_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdJoinFoodChoice.CurrentCellChanged

        GridFoodJoinJustClicked()

    End Sub

    Private Sub GridFoodJoinJustClicked()


        If updatedFoodJoin = True Then
            UpdateDatabaseFoodJoin()
        End If

        PopulateFoodJoinData(Me.grdJoinFoodChoice)

        newFoodJoin.ActiveCategoryRow = -1
        newFoodJoin.ActiveModifierRow = -1


        '      Me.grdJoinPossibleCategories.CurrentRowIndex = Nothing
        '     Me.grdJoinIndividualModifiers.CurrentRowIndex = Nothing

        '    '    grdJoinFoodModifierJoins.CurrentRowIndex = 0
        '     Me.grdJoinFoodCategoryJoins.CurrentRowIndex = -1
        '    Me.grdJoinFoodModifierJoins.CurrentRowIndex = -1

        '   grdJoinFoodCategoryJoins.Focus()
        '  grdJoinFoodModifierJoins.Focus()

        '   Me.grdJoinFoodChoice.Focus()

    End Sub

    Private Sub PopulateFoodJoinData(ByRef grd As DataGrid)
        Dim rowNum As Integer = grd.CurrentCell.RowNumber

        '  If dvFoods.Count = 0 Then Exit Sub
        If dvFoodsJoins.Count = 0 Then Exit Sub

        If grd.Item(rowNum, 0) Is DBNull.Value Then Exit Sub

        Dim valueFoodID As Integer
        Dim valueFoodName As String

        valueFoodID = DetermineID(grd, 0)
        valueFoodName = DetermineString(grd, 1)

        newFoodJoin.ActiveJoinFoodID = valueFoodID
        lblJoinFoodSelected.Text = valueFoodName

        dsSetup.Tables("FoodJoin").Clear()

        sql.SqlSelectCommandJoinFoodJoin.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@FoodID").Value = newFoodJoin.ActiveJoinFoodID

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlJoinFoodJoin.Fill(dsSetup.Tables("FoodJoin"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        PopulateMinorJoins(valueFoodID)

        If dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveCategoryRow = -1
        Else
            '          newFoodJoin.ActiveCategoryRow = 0
        End If
        If dsSetup.Tables("JoinFoodModifierJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveModifierRow = -1
        Else
            '         newFoodJoin.ActiveModifierRow = 0
        End If


        Exit Sub
        '222


        Dim sqlstatement As String

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sqlstatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.CategoryID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.GTCFlag, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & selectedLocation & "' AND FoodJoin.FoodID ='" & valueFoodID & "' AND FoodJoin.CategoryID <> 0"
            dsSetup = sql.PopulateSelectedItemTable("JoinFoodCategoryJoins", sqlstatement, dsSetup)

            sqlstatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.ModifierID, Foods.FoodID, Foods.CategoryID, Foods.FoodName FROM FoodJoin LEFT OUTER JOIN Foods ON FoodJoin.ModifierID = Foods.FoodID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & selectedLocation & "' AND FoodJoin.FoodID ='" & valueFoodID & "' AND FoodJoin.ModifierID <> 0"
            dsSetup = sql.PopulateSelectedItemTable("JoinFoodModifierJoins", sqlstatement, dsSetup)

            '      Dim sqlstatement As String
            dsSetup.Tables("FoodJoin").Clear()
            '     add this if updating foodjoin gets too expensive
            '    and we must update every time we hit a new food choice
            sqlstatement = "SELECT CompanyID, LocationID, FoodJoinID, FoodID, CategoryID, ModifierID, NumberFree, FreeFlag, GroupFlag, GTCFlag FROM FoodJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' AND FoodID = '" & newFoodJoin.ActiveJoinFoodID & "'"
            dsSetup = sql.PopulateSelectedItemTable("FoodJoin", sqlstatement, dsSetup)

            sql.cn.Close()

        Catch ex As Exception
            CloseConnection()
        End Try



        If dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveCategoryRow = -1
        End If
        If dsSetup.Tables("JoinFoodModifierJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveModifierRow = -1
        End If


    End Sub

    Private Sub PopulateMinorJoins(ByVal valueFoodID As Integer)

        dsSetup.Tables("JoinFoodCategoryJoins").Clear()
        dsSetup.Tables("JoinFoodModifierJoins").Clear()

        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@FoodID").Value = valueFoodID

        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@FoodID").Value = valueFoodID

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlJoinFoodCategoryJoins.Fill(dsSetup.Tables("JoinFoodCategoryJoins"))
            sql.SqlJoinFoodModiferJoins.Fill(dsSetup.Tables("JoinFoodModifierJoins"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        If dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveCategoryRow = -1
        End If
        If dsSetup.Tables("JoinFoodModifierJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveModifierRow = -1
        End If

    End Sub

    Private Sub grdJoinFoodCategoryJoins_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdJoinFoodCategoryJoins.MouseUp

        If dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveCategoryRow = -1
        Else
            newFoodJoin.ActiveCategoryRow = Me.grdJoinFoodCategoryJoins.CurrentRowIndex
        End If
        newFoodJoin.ActiveModifierRow = -1

        '      currentJoinCategoryRow = Me.grdJoinFoodCategoryJoins.CurrentRowIndex
        '     currentJoinModifierRow = -1
    End Sub

    Private Sub grdJoinFoodModifierJoins_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdJoinFoodModifierJoins.MouseUp



        If dsSetup.Tables("JoinFoodModifierJoins").Rows.Count = 0 Then
            newFoodJoin.ActiveModifierRow = -1
        Else
            newFoodJoin.ActiveModifierRow = Me.grdJoinFoodModifierJoins.CurrentRowIndex
        End If
        newFoodJoin.ActiveCategoryRow = -1

        '   currentJoinModifierRow = Me.grdJoinFoodModifierJoins.CurrentRowIndex
        '  currentJoinCategoryRow = -1
    End Sub

    Private Sub btnJoinGTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinGTC.Click
        Dim oRow As DataRow
        '   these tell us row number
        Dim modifierIndex As Integer
        Dim categoryIndex As Integer

        For Each oRow In dsSetup.Tables("FoodJoin").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("CategoryID") Is DBNull.Value Then
                    modifierIndex += 1
                Else
                    ' If currentJoinCategoryRow = categoryIndex Then
                    If newFoodJoin.ActiveCategoryRow = categoryIndex Then
                        If Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "-" Then
                            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "C"
                        Else
                            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "-"
                        End If
                        oRow("GTCFlag") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3)
                        '     oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                    End If
                    categoryIndex += 1
                End If
            End If
        Next

        '    UpdateDatabaseFoodJoin()
        updatedFoodJoin = True


    End Sub

    Private Sub btnJoinReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinReq.Click
        Dim oRow As DataRow
        '   these tell us row number
        '       Dim modifierIndex As Integer
        Dim categoryIndex As Integer

        For Each oRow In dsSetup.Tables("FoodJoin").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                ' not using now.... this means only requiring FULL categories
                '          If oRow("CategoryID") Is DBNull.Value Then
                '           If newFoodJoin.ActiveModifierRow = modifierIndex Then
                'If Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4) = "-" Then
                'Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4) = "R"
                '       Else
                '          Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4) = "-"
                '     End If
                '              oRow("ReqFlag") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4)

                '        End If
                'modifierIndex += 1
                '    End If

                If oRow("ModifierID") Is DBNull.Value Then
                    ' If currentJoinCategoryRow = categoryIndex Then
                    If newFoodJoin.ActiveCategoryRow = categoryIndex Then
                        If Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4) = "-" Then
                            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4) = "R"
                        Else
                            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4) = "-"
                        End If
                        oRow("ReqFlag") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4)
                        '   oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                    End If
                    categoryIndex += 1
                End If
            End If
        Next

        '   UpdateDatabaseFoodJoin()
        updatedFoodJoin = True


    End Sub

    Private Sub btnJoinFree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinFree.Click
        Dim oRow As DataRow
        '   these tell us row number
        Dim modifierIndex As Integer
        Dim categoryIndex As Integer

        For Each oRow In dsSetup.Tables("FoodJoin").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("CategoryID") Is DBNull.Value Then
                    '      If currentJoinModifierRow = modifierIndex Then
                    If newFoodJoin.ActiveModifierRow = modifierIndex Then
                        If Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2) = "F" Then
                            Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2) = "S"
                        Else
                            Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2) = "F"
                        End If
                        oRow("FreeFlag") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2)
                        '     oRow("NumberFree") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2)
                    End If
                    modifierIndex += 1
                End If

                If oRow("ModifierID") Is DBNull.Value Then
                    ' If currentJoinCategoryRow = categoryIndex Then
                    If newFoodJoin.ActiveCategoryRow = categoryIndex Then
                        If Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2) = "F" Then
                            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2) = "S"
                        Else
                            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2) = "F"
                        End If
                        oRow("FreeFlag") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                        '   oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                    End If
                    categoryIndex += 1
                End If
            End If
        Next

        '   UpdateDatabaseFoodJoin()
        updatedFoodJoin = True

    End Sub

    Private Sub btnJoinGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinGroup.Click
        Dim oRow As DataRow
        '   these tell us row number
        Dim modifierIndex As Integer
        '      Dim categoryIndex As Integer

        For Each oRow In dsSetup.Tables("FoodJoin").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("CategoryID") Is DBNull.Value Then
                    '      If currentJoinModifierRow = modifierIndex Then
                    If newFoodJoin.ActiveModifierRow = modifierIndex Then
                        If Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3) = "A" Then
                            Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3) = "G"
                        Else
                            Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3) = "A"
                        End If
                        oRow("GroupFlag") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3)
                        '            oRow("NumberFree") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2)
                    End If
                    modifierIndex += 1
                End If

                '   we don't use this for Category
                '            If oRow("ModifierID") Is DBNull.Value Then
                '            ' If currentJoinCategoryRow = categoryIndex Then
                '            If newFoodJoin.ActiveCategoryRow = categoryIndex Then
                '            If Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "A" Then
                '            Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "G"
                '       Else
                '           Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "A"
                ''       End If
                '       oRow("GroupFlag") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3)
                '       '     oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                ''       End If
                '     categoryIndex += 1
                '    End If
            End If
        Next

        '    UpdateDatabaseFoodJoin()
        updatedFoodJoin = True


    End Sub



    Private Sub grdJoinPossibleCategories_Clicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdJoinPossibleCategories.MouseUp
        If newFoodJoin.ActiveJoinFoodID = Nothing Then
            MsgBox("Please Select A Food Item")
            Exit Sub
        End If

        Dim valueCatID As Integer
        Dim valueCatName As String
        Dim nRow As DataRow
        '   first determine which categoryID is selected
        valueCatID = DetermineID(grdJoinPossibleCategories, 0)
        valueCatName = DetermineString(grdJoinPossibleCategories, 1)

        UpdateDatabaseFoodJoin()

        nRow = dsSetup.Tables("FoodJoin").NewRow
        nRow("CompanyID") = corpID
        nRow("LocationID") = selectedLocation
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID
        nRow("CategoryID") = valueCatID
        nRow("ModifierID") = DBNull.Value
        nRow("NumberFree") = 1          'default
        nRow("FreeFlag") = "S"
        nRow("GroupFlag") = "G" 'will always be grouped
        nRow("GTCFlag") = "-"
        nRow("ReqFlag") = "-"
        '      nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("FoodJoin").Rows.Add(nRow)
        newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count
        newFoodJoin.ActiveModifierRow = -1

        nRow("FoodJoinID") = InsertingNewFoodJoin(nRow)
        dsSetup.Tables("FoodJoin").AcceptChanges()

        PopulateMinorJoins(newFoodJoin.ActiveJoinFoodID)    'valueFoodID)
        Me.grdJoinFoodCategoryJoins.Focus()
        updatedFoodJoin = True

        Exit Sub





        newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count
        newFoodJoin.ActiveModifierRow = -1
        '    currentJoinCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count
        '   currentJoinModifierRow = -1

        nRow = dsSetup.Tables("JoinFoodCategoryJoins").NewRow
        nRow("CompanyID") = corpID
        nRow("LocationID") = selectedLocation
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID
        nRow("CategoryID") = valueCatID
        nRow("CategoryName") = valueCatName
        nRow("NumberFree") = 1          'default
        nRow("FreeFlag") = "S"
        nRow("GroupFlag") = "G"
        nRow("GTCFlag") = "-"
        nRow("ReqFlag") = "-"
        nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("JoinFoodCategoryJoins").Rows.Add(nRow)

        newFoodJoin.ActiveTempIndex += 1

        Me.grdJoinFoodCategoryJoins.Focus()
        updatedFoodJoin = True

        '     UpdateDatabaseFoodJoin()

    End Sub

    Private Sub grdJoinIndividualModifiers_Clicked(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles grdJoinIndividualModifiers.MouseUp

        If newFoodJoin.ActiveJoinFoodID = Nothing Then
            MsgBox("Please Select A Food Item")
            Exit Sub
        End If

        Dim valueModID As Integer
        Dim valueModName As String
        '      Dim sqlStatement As String
        Dim nRow As DataRow
        '   first determine which categoryID is selected
        valueModID = DetermineID(grdJoinIndividualModifiers, 0)
        valueModName = DetermineString(grdJoinIndividualModifiers, 1)


        UpdateDatabaseFoodJoin()

        nRow = dsSetup.Tables("FoodJoin").NewRow
        nRow("CompanyID") = corpID
        nRow("LocationID") = selectedLocation
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID
        nRow("CategoryID") = DBNull.Value
        nRow("ModifierID") = valueModID
        nRow("NumberFree") = 1          'default
        nRow("FreeFlag") = "S"
        nRow("GroupFlag") = "G" 'will always be grouped
        nRow("GTCFlag") = "-"
        nRow("ReqFlag") = "-"
        '      nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("FoodJoin").Rows.Add(nRow)

        newFoodJoin.ActiveModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count
        newFoodJoin.ActiveCategoryRow = -1
        nRow("FoodJoinID") = InsertingNewFoodJoin(nRow)
        dsSetup.Tables("FoodJoin").AcceptChanges()

        PopulateMinorJoins(newFoodJoin.ActiveJoinFoodID)    'valueFoodID)
        updatedFoodJoin = True
        grdJoinFoodModifierJoins.Focus()


        Exit Sub





        nRow = dsSetup.Tables("FoodJoin").NewRow
        nRow("CompanyID") = corpID
        nRow("LocationID") = selectedLocation
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID
        nRow("ModifierID") = valueModID
        nRow("NumberFree") = 1          'default
        nRow("FreeFlag") = "S"
        nRow("GroupFlag") = "G"
        nRow("GTCFlag") = "-"
        nRow("ReqFlag") = "-"
        nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("FoodJoin").Rows.Add(nRow)

        newFoodJoin.ActiveModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count
        newFoodJoin.ActiveCategoryRow = -1
        '      currentJoinModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count
        '     currentJoinCategoryRow = -1

        nRow = dsSetup.Tables("JoinFoodModifierJoins").NewRow
        nRow("CompanyID") = corpID
        nRow("LocationID") = selectedLocation
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID
        nRow("ModifierID") = valueModID
        nRow("FoodName") = valueModName
        nRow("NumberFree") = 1          'default
        nRow("FreeFlag") = "S"
        nRow("GroupFlag") = "G"
        nRow("ReqFlag") = "-"
        nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("JoinFoodModifierJoins").Rows.Add(nRow)

        newFoodJoin.ActiveTempIndex += 1

        Me.grdJoinFoodModifierJoins.Focus()
        '   UpdateDatabaseFoodJoin()
        updatedFoodJoin = True

    End Sub

    Private Function InsertingNewFoodJoin(ByRef orow As DataRow)
        Dim newFoodJoinID As Integer

        sql.SqlInsertCommandJoinFoodJoin.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@FoodID").Value = orow("FoodID")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@CategoryID").Value = orow("CategoryID")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@ModifierID").Value = orow("ModifierID")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@NumberFree").Value = orow("NumberFree")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@FreeFlag").Value = orow("FreeFlag")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@GroupFlag").Value = orow("GroupFlag")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@GTCFlag").Value = orow("GTCFlag")
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@ReqFlag").Value = orow("ReqFlag")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newFoodJoinID = CType(sql.SqlInsertCommandJoinFoodJoin.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newFoodJoinID

    End Function

    Private Sub btnJoinFoodRemoveCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinFoodRemoveCategory.Click

        If newFoodJoin.ActiveCategoryRow = -1 Then Exit Sub

        Dim dRow As DataRow
        Dim valueFoodJoinID As Integer

        valueFoodJoinID = dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("FoodJoinID")
        '   this will take forever with a large food join
        For Each dRow In dsSetup.Tables("FoodJoin").Rows
            If Not dRow.RowState = DataRowState.Deleted And Not dRow.RowState = DataRowState.Detached Then
                If Not dRow("FoodJoinID") Is DBNull.Value Then
                    If dRow("FoodJoinID") = valueFoodJoinID Then
                        dRow.Delete()
                        If newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count - 1 Then
                            newFoodJoin.ActiveCategoryRow -= 1
                        End If
                        Exit For
                    End If
                End If
            End If
        Next

        '   *** there is a concurrecy erro in Update only for Category
        '   anytime we delete a datarow we must update database
        '   otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin()
        PopulateFoodJoinData(Me.grdJoinFoodChoice)
        '    grdJoinFoodCategoryJoins.Focus()
        If newFoodJoin.ActiveCategoryRow >= 0 Then
            grdJoinFoodCategoryJoins.CurrentRowIndex = newFoodJoin.ActiveCategoryRow
        End If


        Exit Sub
        '222


        If Not dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("FoodJoinID") Is DBNull.Value Then
            valueFoodJoinID = dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("FoodJoinID")
            '   this will take forever with a large food join
            For Each dRow In dsSetup.Tables("FoodJoin").Rows
                If Not dRow.RowState = DataRowState.Deleted And Not dRow.RowState = DataRowState.Detached Then
                    If Not dRow("FoodJoinID") Is DBNull.Value Then
                        If dRow("FoodJoinID") = valueFoodJoinID Then
                            dRow.Delete()
                            If newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count - 1 Then
                                newFoodJoin.ActiveCategoryRow -= 1
                            End If
                            Exit For
                        End If
                    End If
                End If

            Next
        Else
            '   ***  for new entries
            valueFoodJoinID = dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("TempFoodJoinIndex")
            '   this will take forever with a large food join
            For Each dRow In dsSetup.Tables("FoodJoin").Rows
                If Not dRow.RowState = DataRowState.Deleted And Not dRow.RowState = DataRowState.Detached Then
                    If Not dRow("TempFoodJoinIndex") Is DBNull.Value Then
                        If dRow("TempFoodJoinIndex") = valueFoodJoinID Then
                            dRow.Delete()
                            If newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count - 1 Then
                                newFoodJoin.ActiveCategoryRow -= 1
                            End If
                            Exit For
                        End If
                    End If
                End If

            Next
        End If

        '   *** there is a concurrecy erro in Update only for Category
        '   anytime we delete a datarow we must update database
        '   otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin()
        PopulateFoodJoinData(Me.grdJoinFoodChoice)

    End Sub


    Private Sub btnJoinFoodRemoveIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinFoodRemoveIndividual.Click

        If newFoodJoin.ActiveModifierRow = -1 Then Exit Sub

        Dim dRow As DataRow
        Dim valueFoodJoinID As Integer

        valueFoodJoinID = dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("FoodJoinID")
        For Each dRow In dsSetup.Tables("FoodJoin").Rows
            If Not dRow.RowState = DataRowState.Deleted And Not dRow.RowState = DataRowState.Detached Then
                If Not dRow("FoodJoinID") Is DBNull.Value Then
                    If dRow("FoodJoinID") = valueFoodJoinID Then
                        dRow.Delete()
                        '       grdJoinFoodModifierJoins.UnSelect(newFoodJoin.ActiveModifierRow)
                        '  If newFoodJoin.ActiveModifierRow > 0 Then
                        If newFoodJoin.ActiveModifierRow Then 'dsSetup.Tables("JoinFoodModifierJoins").Rows.Count - 1 Then
                            newFoodJoin.ActiveModifierRow -= 1
                        End If
                        Exit For
                    End If
                End If
            End If
        Next

        '   anytime we delete a datarow we must update database
        '   otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin()
        PopulateFoodJoinData(Me.grdJoinFoodChoice)
        '       grdJoinFoodModifierJoins.Focus()
        If newFoodJoin.ActiveModifierRow >= 0 Then
            grdJoinFoodModifierJoins.CurrentRowIndex = newFoodJoin.ActiveModifierRow
        End If


        Exit Sub
        '222

        If Not dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("FoodJoinID") Is DBNull.Value Then
            valueFoodJoinID = dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("FoodJoinID")
            For Each dRow In dsSetup.Tables("FoodJoin").Rows
                If Not dRow.RowState = DataRowState.Deleted And Not dRow.RowState = DataRowState.Detached Then
                    If Not dRow("FoodJoinID") Is DBNull.Value Then
                        If dRow("FoodJoinID") = valueFoodJoinID Then
                            dRow.Delete()
                            '       grdJoinFoodModifierJoins.UnSelect(newFoodJoin.ActiveModifierRow)
                            If newFoodJoin.ActiveModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count - 1 Then
                                newFoodJoin.ActiveModifierRow -= 1
                            End If
                            Exit For
                        End If
                    End If
                End If

            Next
        Else
            '   *** for new entries
            valueFoodJoinID = dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("TempFoodJoinIndex")
            For Each dRow In dsSetup.Tables("FoodJoin").Rows
                If Not dRow.RowState = DataRowState.Deleted And Not dRow.RowState = DataRowState.Detached Then
                    If Not dRow("TempFoodJoinIndex") Is DBNull.Value Then
                        If dRow("TempFoodJoinIndex") = valueFoodJoinID Then
                            dRow.Delete()
                            If newFoodJoin.ActiveModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count - 1 Then
                                newFoodJoin.ActiveModifierRow -= 1
                            End If
                            Exit For
                        End If
                    End If
                End If
            Next
        End If


        '   anytime we delete a datarow we must update database
        '   otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin()
        PopulateFoodJoinData(Me.grdJoinFoodChoice)

    End Sub

    Private Sub TabFoodJoin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFoodJoin.Enter

        Dim vRow As DataRowView

        dvFoodJoinCategory = New DataView

        With dvFoodJoinCategory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "Active = True AND (FunctionFlag = 'O' OR FunctionFlag = 'M')"
            .Sort = "FunctionID, CategoryOrder"
        End With

        cbxJoinIndividualModifierSelect.Items.Clear()
        For Each vRow In dvFoodJoinCategory 'dsSetup.Tables("Main_ModifierCategory2").Rows
            cbxJoinIndividualModifierSelect.Items.Add(vRow("CategoryName"))
        Next

        dvFoodJoinMainFoodsCagtegory = New DataView
        With dvFoodJoinMainFoodsCagtegory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "Active = True AND (FunctionFlag = 'F' OR FunctionFlag = 'O')"
            .Sort = "FunctionID, CategoryOrder"
        End With

        Me.cbxJoinCategorySelect.Items.Clear()

        For Each vRow In dvFoodJoinMainFoodsCagtegory 'dsSetup.Tables("MainCategory").Rows
            Me.cbxJoinCategorySelect.Items.Add(vRow("CategoryName"))
        Next

        With dvMainCategoryFoodJoin
            .Table = dsSetup.Tables("MainCategory")
            '  .RowFilter = "FunctionFlag = 'F' OR FunctionFlag = 'O' OR FunctionFlag = 'M' AND Active = True" ' AND CategoryOrder < 11"
            .RowFilter = "Active = True" ' AND CategoryOrder < 11"
            '       .Sort = "CategoryOrder"
        End With

        '    With dvFoodsJoins
        '   .Table = dsSetup.Tables("FoodTable")
        '  .RowFilter = "CategoryID = " & Me.globalJoinValueCategoryID
        ' End With
        '    JoinCurrencyMan.ResumeBinding()
        '     FoodCurrencyMan.SuspendBinding()

    End Sub

    Private Sub TabFoodJoin_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFoodJoin.Leave

        justAdjustingPosition = True
        AdjustPosition()
        justAdjustingPosition = False
        'this is only for updating lstModifiers on MainFoodTab

        If updatedFoodJoin = True Then
            UpdateDatabaseFoodJoin()
        End If

        dvFoodJoinCategory.Dispose()
        dvFoodJoinMainFoodsCagtegory.Dispose()

    End Sub

    Private Sub UpdateDatabaseFoodJoin()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlJoinFoodJoin.Update(dsSetup, "FoodJoin")
            sql.cn.Close()
            dsSetup.Tables("FoodJoin").AcceptChanges()
        Catch ex As Exception
            CloseConnection()

        End Try

        updatedFoodJoin = False

    End Sub






    '*****************************************************************
    '   Drink Category
    '*****************************************************************

    Private Sub DisplayDrinkCategoryPanel()

        If dsSetup.Tables("DrinkCategory").Rows.Count = 0 Then
            Try
                CreateDrinkCategoryDataTable()
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlMenuDrinkCategory.Update(dsSetup, "DrinkCategory")
                dsSetup.Tables("DrinkCategory").AcceptChanges()

                dsSetup.Tables("DrinkCategory").Clear()
                sql.SqlSelectCommandMenuDrinkCategory.Parameters("@CompanyID").Value = corpID
                sql.SqlSelectCommandMenuDrinkCategory.Parameters("@LocationID").Value = selectedLocation
                sql.SqlMenuDrinkCategory.Fill(dsSetup.Tables("DrinkCategory"))
                sql.cn.Close()
                '     dsSetup.Tables("DrinkCategory").Rows(0).Delete()    'this deletes the (-1 Drink Row)
                '    dsSetup.Tables("DrinkCategory").AcceptChanges()
                ReadDrinkCategoryID()
            Catch ex As Exception
                CloseConnection()
            End Try
        Else
            If generalDrinkCategoryID = -1 Then
                ReadDrinkCategoryID()
            End If
        End If

        Dim index As Integer
        Dim count As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace
        Dim btnWidth As Integer
        Dim btnHeight As Integer
        Me.pnlDrinks.Size = New Size(pnlDrinkCategory.Width, pnlDrinkCategory.Height)

        btnWidth = (pnlDrinkCategory.Width - (5 * buttonSpace)) / 4
        btnHeight = (pnlDrinkCategory.Height - (9 * buttonSpace)) / 8

        For index = 1 To 32
            btnCategory(index) = New DrinkButton
            With btnCategory(index)
                .Size = New Size(btnWidth, btnHeight)
                .Location = New Point(x, y)
                .TabStop = False
                .Position = index

                ' dtDrinkCateogy is "DrinkCategory" Table
                If dsSetup.Tables("DrinkCategory").Rows.Count > 0 Then
                    If Not dsSetup.Tables("DrinkCategory").Rows(index - 1)("DrinkCategoryName") Is DBNull.Value Then
                        .Text = dtDrinkCategory.Rows(index - 1)("DrinkCategoryName")
                        If Not dtDrinkCategory.Rows(index - 1)("ButtonColor") Is DBNull.Value Then
                            .BackColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonColor"))
                            .ForeColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonForeColor"))
                        Else
                            .BackColor = c16
                            .ForeColor = c3
                        End If
                    Else
                        .Text = ""
                        .BackColor = c2
                    End If

                    .IsALiquorType = dtDrinkCategory.Rows(index - 1)("IsALiquorType")
                    .ID = dtDrinkCategory.Rows(index - 1)("DrinkCategoryID")  'index
                    .MenuIndex = dtDrinkCategory.Rows(index - 1)("DrinkCategoryNumber")  'index


                    '      Else
                    '         .BackColor = c2
                    '    End If
                Else

                End If

                pnlDrinkCategory.Controls.Add(btnCategory(index))
                '      pnlDrinks.Controls.Add(btnCategory(index))
                AddHandler btnCategory(index).Click, AddressOf pnlDrinkCategory_Click

            End With
            count += 1
            If count < 4 Then
                x = x + buttonSpace + btnWidth
            Else
                x = buttonSpace
                y = y + btnHeight + buttonSpace
                count = 0
            End If
        Next

    End Sub

    Private Sub DisplayDrinkCategoryPanel2()
        '   we use both display panels (1 and 2) b/c buttons are arrays
        Dim index As Integer
        Dim count As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace
        Dim btnWidth As Integer
        Dim btnHeight As Integer
        Me.pnlDrinks.Size = New Size(pnlDrinkCategory.Width, pnlDrinkCategory.Height)

        btnWidth = (pnlDrinkCategory.Width - (5 * buttonSpace)) / 4
        btnHeight = (pnlDrinkCategory.Height - (9 * buttonSpace)) / 8

        For index = 1 To 32
            btnCategory2(index) = New DrinkButton
            With btnCategory2(index)
                .Size = New Size(btnWidth, btnHeight)
                .Location = New Point(x, y)
                .TabStop = False
                .Position = index
                '          .ID = index     'will change if make more possible categories
                If dsSetup.Tables("DrinkCategory").Rows.Count > 0 Then
                    If Not dsSetup.Tables("DrinkCategory").Rows(index - 1)("DrinkCategoryName") Is DBNull.Value Then
                        .Text = dtDrinkCategory.Rows(index - 1)("DrinkCategoryName")
                        If Not dtDrinkCategory.Rows(index - 1)("ButtonColor") Is DBNull.Value Then
                            .BackColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonColor"))
                            .ForeColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonForeColor"))
                        Else
                            .BackColor = c16
                            .ForeColor = c3
                        End If
                    Else
                        .Text = ""
                        .BackColor = c2
                    End If
                    .ID = dtDrinkCategory.Rows(index - 1)("DrinkCategoryID")  'index
                    .IsALiquorType = dtDrinkCategory.Rows(index - 1)("IsALiquorType")
                    .MenuIndex = dtDrinkCategory.Rows(index - 1)("DrinkCategoryNumber") 'index
                    '        Else
                    '           .BackColor = c2
                    '      End If
                Else

                End If

                '        pnlDrinkCategory.Controls.Add(btnCategory(index))
                pnlDrinks.Controls.Add(btnCategory2(index))
                AddHandler btnCategory2(index).Click, AddressOf pnlDrinks_Click

            End With
            count += 1
            If count < 4 Then
                x = x + buttonSpace + btnWidth
            Else
                x = buttonSpace
                y = y + btnHeight + buttonSpace
                count = 0
            End If
        Next

    End Sub


    Private Sub pnlDrinkCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDrinkCategory.Click

        If newDrinkChangesMade = True Then
            UpdateDrinkCategory()
            newDrinkChangesMade = False
        End If
        Try
            Dim objButton As DrinkButton = CType(sender, DrinkButton)
            Me.txtDrinkCategoryName.Text = objButton.Text
            Me.chkLiquorType.Checked = objButton.IsALiquorType

            If objButton.Text = "" Then
                Me.btnDrinkCategoryColor.BackColor = c16
                Me.btnDrinkCategoryColor.ForeColor = c3

            Else
                Me.btnDrinkCategoryColor.BackColor = objButton.BackColor
                Me.btnDrinkCategoryColor.ForeColor = objButton.ForeColor
            End If
            newDrink = New ActiveDrink
            newDrink.DrinkCategoryID = objButton.ID
            newDrink.DrinkCategoryIndex = objButton.MenuIndex
            newDrinkChangesMade = False
            '          txtDrinkCategoryName.Focus()

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub pnlDrinks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDrinks.Click

        Dim objButton As DrinkButton

        Try
            objButton = CType(sender, DrinkButton)

        Catch ex As Exception
            Exit Sub
        End Try

        Me.pnlDrinks.Visible = False
        Me.pnlDrinkByCategory.Visible = True
        newDrink.DrinkCategoryIndex = objButton.MenuIndex  'objButton.Position
        PopulateDrinkByCategoryPanel(objButton.ID)

    End Sub

    Private Sub DrinkCategoryNameChanges(ByVal sender As Object, ByVal e As MouseEventArgs) Handles txtDrinkCategoryName.MouseDown
        newDrinkChangesMade = True

    End Sub

    Private Sub DrinkCategoryLiquorTypeChanges(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkLiquorType.MouseDown
        newDrinkChangesMade = True

    End Sub

    Private Sub LeaveDrinkCategory(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabDrinkCategory.Leave

        If newDrinkChangesMade = True Then
            UpdateDrinkCategory()
        End If

    End Sub

    Private Sub UpdateDrinkCategory()

        If txtDrinkCategoryName.Text = "" Then
            '            Exit Sub
            '   was for removing drinks
            '        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("DrinkCategoryName") = DBNull.Value
            '       dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("IsALiquorType") = 0 'Me.chkLiquorType.Checked
        Else
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("DrinkCategoryName") = txtDrinkCategoryName.Text
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("IsALiquorType") = Me.chkLiquorType.Checked
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonColor") = Me.btnDrinkCategoryColor.BackColor.ToArgb
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonForeColor") = Me.btnDrinkCategoryColor.ForeColor.ToArgb

        End If

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuDrinkCategory.Update(dsSetup, "DrinkCategory")
            sql.cn.Close()
            dsSetup.Tables("DrinkCategory").AcceptChanges()

        Catch ex As Exception
            CloseConnection()
        End Try

        btnCategory(newDrink.DrinkCategoryIndex).Text = txtDrinkCategoryName.Text
        btnCategory(newDrink.DrinkCategoryIndex).IsALiquorType = Me.chkLiquorType.Checked
        btnCategory(newDrink.DrinkCategoryIndex).BackColor = Me.btnDrinkCategoryColor.BackColor
        btnCategory(newDrink.DrinkCategoryIndex).ForeColor = Me.btnDrinkCategoryColor.ForeColor
        btnCategory2(newDrink.DrinkCategoryIndex).Text = txtDrinkCategoryName.Text
        btnCategory2(newDrink.DrinkCategoryIndex).IsALiquorType = Me.chkLiquorType.Checked
        btnCategory2(newDrink.DrinkCategoryIndex).BackColor = Me.btnDrinkCategoryColor.BackColor
        btnCategory2(newDrink.DrinkCategoryIndex).ForeColor = Me.btnDrinkCategoryColor.ForeColor

        PopulateDrinkCategoriesNames()

    End Sub

    Private Sub btnDrinkCategoryName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrinkCategoryName.Click
        '   this was the update buttton
        '   now remove category

        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("DrinkCategoryName") = DBNull.Value
        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonColor") = DBNull.Value
        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonForeColor") = DBNull.Value
        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("IsALiquorType") = 0 'Me.chkLiquorType.Checked

        txtDrinkCategoryName.Text = ""
        Me.chkLiquorType.Checked = False
        Me.btnDrinkCategoryColor.BackColor = c2
        Me.btnDrinkCategoryColor.ForeColor = c3

        '       Try
        '      sql.cn.Open()
        '           sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        '    adt.Update(dsSetup, "DrinkCategory")
        '   sql.cn.Close()
        '  dsSetup.Tables("DrinkCategory").AcceptChanges()
        '     Catch ex As Exception
        '        CloseConnection()
        '       End Try

        btnCategory(newDrink.DrinkCategoryIndex).Text = ""
        btnCategory(newDrink.DrinkCategoryIndex).IsALiquorType = 0
        btnCategory(newDrink.DrinkCategoryIndex).BackColor = c2 'c16
        btnCategory(newDrink.DrinkCategoryIndex).ForeColor = c3

        btnCategory2(newDrink.DrinkCategoryIndex).Text = ""
        btnCategory2(newDrink.DrinkCategoryIndex).IsALiquorType = 0
        btnCategory2(newDrink.DrinkCategoryIndex).BackColor = c2    'c16
        btnCategory2(newDrink.DrinkCategoryIndex).BackColor = c3

        newDrinkChangesMade = True

    End Sub

    Private Sub CreateDrinkCategoryDataTable()
        Dim oRow As DataRow
        Dim i As Integer

        oRow = dsSetup.Tables("DrinkCategory").NewRow
        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("DrinkCategoryNumber") = -1
        oRow("DrinkCategoryName") = "Drinks"
        oRow("DrinkCategoryOrder") = DBNull.Value

        oRow("ButtonColor") = Me.btnDrinkCategoryColor.BackColor.ToArgb '-3318692   ??
        oRow("ButtonForeColor") = Me.btnDrinkCategoryColor.ForeColor.ToArgb '-16777216
        oRow("IsALiquorType") = 0

        dsSetup.Tables("DrinkCategory").Rows.Add(oRow)

        For i = 1 To 32
            oRow = dsSetup.Tables("DrinkCategory").NewRow
            oRow("CompanyID") = corpID
            oRow("LocationID") = selectedLocation
            oRow("DrinkCategoryNumber") = i
            oRow("DrinkCategoryName") = DBNull.Value
            oRow("DrinkCategoryOrder") = DBNull.Value
            oRow("ButtonColor") = DBNull.Value
            oRow("ButtonForeColor") = DBNull.Value

            oRow("IsALiquorType") = 0

            dsSetup.Tables("DrinkCategory").Rows.Add(oRow)
        Next

    End Sub

    Private Sub ReadDrinkCategoryID()

        Dim cmd As SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            cmd = New SqlClient.SqlCommand("SELECT DrinkCategoryID FROM DrinkCategory WHERE DrinkCategoryNumber = -1 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'", sql.cn)
            dtr = cmd.ExecuteReader
            dtr.Read()
            If dtr.HasRows Then
                generalDrinkCategoryID = dtr("DrinkCategoryID")
            End If

            dtr.Close()
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox("Issue with your General Drink Button")
            generalDrinkCategoryID = 0
            Exit Sub
        End Try

    End Sub

    Private Sub CreateDrinkModifierDataTable222()
        Dim oRow As DataRow
        Dim i As Integer
        Dim drinkNameString(6) As String
        drinkNameString(1) = "Double"
        drinkNameString(2) = "Rocks"
        drinkNameString(3) = "Up"
        drinkNameString(4) = "Tall"
        drinkNameString(5) = "Splash"

        For i = 1 To 5
            oRow = dsSetup.Tables("DrinkModifiers").NewRow
            oRow("CompanyID") = corpID
            oRow("LocationID") = selectedLocation
            oRow("DrinkModifierID") = i
            oRow("DrinkID") = -1
            oRow("DrinkName") = drinkNameString(i)
            oRow("DrinkPrice") = 0

            dsSetup.Tables("DrinkModifiers").Rows.Add(oRow)
        Next

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuDrinkModifiers.Update(dsSetup, "DrinkModifiers")
            sql.cn.Close()
            dsSetup.Tables("DrinkModifiers").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub


    Private Sub DisplayDrinkByCategoryPanel()
        Dim index As Integer
        Dim count As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace
        Dim btnWidth As Integer
        Dim btnHeight As Integer


        btnWidth = (pnlDrinkByCategory.Width - (7 * buttonSpace)) / 6
        btnHeight = (pnlDrinkByCategory.Height - (11 * buttonSpace)) / 10

        For index = 1 To 60 '48

            btnDrinks(index) = New DrinkButton
            With btnDrinks(index)
                .Size = New Size(btnWidth, btnHeight)
                .Location = New Point(x, y)
                .TabStop = False
                .Position = index
                .BackColor = c2
                .ID = 0
                '           pnlDrinkByCategory.Controls.Add(btnDrinks(index))
                '             AddHandler btnDrinks(index).Click, AddressOf pnlDrinkByCategory_Click

            End With
            count += 1
            If count < 6 Then
                x = x + buttonSpace + btnWidth
            Else
                x = buttonSpace
                y = y + btnHeight + buttonSpace
                count = 0
            End If
        Next

        '        PopulateDrinkByCategoryPanel(0)

    End Sub

    Private Sub PopulateDrinkByCategoryPanel(ByVal catID As Integer)
        Dim index As Integer
        Dim vRow As DataRowView
        Dim count As Integer
        currentDrinkCategoryID = catID

        With dvDrinksByCategory
            .Table = dsSetup.Tables("Drinks")
            .RowFilter = "DrinkCategoryID = '" & catID & "'"
        End With


        '**********************
        ' btnDrinks are no longer used as buttons
        '   they just hold info to populate foodOrderPanel

        pnlDrinkByCategory.Controls.Clear()
        For index = 1 To 60
            btnDrinks(index).BackColor = Color.White
            '  btnDrinks(index).ForeColor()
            btnDrinks(index).ID = 0
            btnDrinks(index).DrinkIndex = 0
            btnDrinks(index).Text = ""

        Next

        For Each vRow In dvDrinksByCategory

            index = vRow("DrinkIndex")

            btnDrinks(index).Text = vRow("DrinkName")
            If Not vRow("DrinkID") Is DBNull.Value Then
                btnDrinks(index).ID = vRow("DrinkID")
            Else
                btnDrinks(index).ID = 0
            End If

            '      btnDrinks(index).DrinkCategoryID = vRow("DrinkCategoryID")
            btnDrinks(index).DrinkIndex = vRow("DrinkIndex")
            '      btnDrinks(index).dRowNumber = count
            btnDrinks(index).BackColor = c16
            btnDrinks(index).ForeColor = c3
            '    btnDrinks(index).DrinkPrice = vRow("DrinkPrice")
            '    btnDrinks(index).CallPrice = vRow("CallPrice")
            '    btnDrinks(index).AddOnPrice = vRow("AddOnPrice")
            '    btnDrinks(index).DrinkFunctionID = vRow("DrinkFunctionID")
            '    btnDrinks(index).DrinkDesc = vRow("DrinkDesc")
            '    btnDrinks(index).DrinkAddOnChoice = vRow("DrinkAddOnChoice")
            '   btnDrinks(index).IsDrinkAdd = vRow("IsDrinkAdd")
            '   btnDrinks(index).IsWineParring = vRow("IsWineParring")
            '   btnDrinks(index).LiquorTypeID = vRow("LiquorTypeID")

            '    count += 1
        Next


        For index = 1 To 60
            DisplayOrderDrinks(btnDrinks(index).BackColor, btnDrinks(index).ForeColor, index, index, btnDrinks(index).DrinkIndex, btnDrinks(index).Text, Nothing, Nothing, Nothing, btnDrinks(index).ID, Nothing, Nothing)

        Next


    End Sub



    Private Sub DisplayOrderDrinks(ByVal bColor As Color, ByVal fColor As Color, ByVal position As Integer, ByVal Index As Integer, ByVal menuJoinId As Integer, ByVal name As String, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)



        Dim w As Single = (pnlDrinkByCategory.Width - (6 * buttonSpace)) / 6
        Dim h As Single = (pnlDrinkByCategory.Height - (10 * buttonSpace)) / 10
        Dim dTable As String = "Drinks"
        Dim price = Nothing     'keep in case we want to add

        Select Case position
            Case 1
                DrinkOrderPanel1 = New FoodOrderPanel(bColor, fColor, 1, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel1)
            Case 2
                DrinkOrderPanel2 = New FoodOrderPanel(bColor, fColor, 2, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel2)
            Case 3
                DrinkOrderPanel3 = New FoodOrderPanel(bColor, fColor, 3, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel3)
            Case 4
                DrinkOrderPanel4 = New FoodOrderPanel(bColor, fColor, 4, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel4)
            Case 5
                DrinkOrderPanel5 = New FoodOrderPanel(bColor, fColor, 5, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel5)
            Case 6
                DrinkOrderPanel6 = New FoodOrderPanel(bColor, fColor, 6, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel6)
            Case 7
                DrinkOrderPanel7 = New FoodOrderPanel(bColor, fColor, 7, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel7)
            Case 8
                DrinkOrderPanel8 = New FoodOrderPanel(bColor, fColor, 8, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel8)
            Case 9
                DrinkOrderPanel9 = New FoodOrderPanel(bColor, fColor, 9, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel9)
            Case 10
                DrinkOrderPanel10 = New FoodOrderPanel(bColor, fColor, 10, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel10)
            Case 11
                DrinkOrderPanel11 = New FoodOrderPanel(bColor, fColor, 11, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel11)
            Case 12
                DrinkOrderPanel12 = New FoodOrderPanel(bColor, fColor, 12, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel12)
            Case 13
                DrinkOrderPanel13 = New FoodOrderPanel(bColor, fColor, 13, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel13)
            Case 14
                DrinkOrderPanel14 = New FoodOrderPanel(bColor, fColor, 14, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel14)
            Case 15
                DrinkOrderPanel15 = New FoodOrderPanel(bColor, fColor, 15, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel15)
            Case 16
                DrinkOrderPanel16 = New FoodOrderPanel(bColor, fColor, 16, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel16)
            Case 17
                DrinkOrderPanel17 = New FoodOrderPanel(bColor, fColor, 17, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel17)
            Case 18
                DrinkOrderPanel18 = New FoodOrderPanel(bColor, fColor, 18, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel18)
            Case 19
                DrinkOrderPanel19 = New FoodOrderPanel(bColor, fColor, 19, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel19)
            Case 20
                DrinkOrderPanel20 = New FoodOrderPanel(bColor, fColor, 20, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel20)
            Case 21
                DrinkOrderPanel21 = New FoodOrderPanel(bColor, fColor, 21, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel21)
            Case 22
                DrinkOrderPanel22 = New FoodOrderPanel(bColor, fColor, 22, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel22)
            Case 23
                DrinkOrderPanel23 = New FoodOrderPanel(bColor, fColor, 23, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel23)
            Case 24
                DrinkOrderPanel24 = New FoodOrderPanel(bColor, fColor, 24, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel24)
            Case 25
                DrinkOrderPanel25 = New FoodOrderPanel(bColor, fColor, 25, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel25)
            Case 26
                DrinkOrderPanel26 = New FoodOrderPanel(bColor, fColor, 26, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel26)
            Case 27
                DrinkOrderPanel27 = New FoodOrderPanel(bColor, fColor, 27, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel27)
            Case 28
                DrinkOrderPanel28 = New FoodOrderPanel(bColor, fColor, 28, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel28)
            Case 29
                DrinkOrderPanel29 = New FoodOrderPanel(bColor, fColor, 29, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel29)
            Case 30
                DrinkOrderPanel30 = New FoodOrderPanel(bColor, fColor, 30, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel30)
            Case 31
                DrinkOrderPanel31 = New FoodOrderPanel(bColor, fColor, 31, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel31)
            Case 32
                DrinkOrderPanel32 = New FoodOrderPanel(bColor, fColor, 32, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel32)
            Case 33
                DrinkOrderPanel33 = New FoodOrderPanel(bColor, fColor, 33, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel33)
            Case 34
                DrinkOrderPanel34 = New FoodOrderPanel(bColor, fColor, 34, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel34)
            Case 35
                DrinkOrderPanel35 = New FoodOrderPanel(bColor, fColor, 35, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel35)
            Case 36
                DrinkOrderPanel36 = New FoodOrderPanel(bColor, fColor, 36, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel36)
            Case 37
                DrinkOrderPanel37 = New FoodOrderPanel(bColor, fColor, 37, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel37)
            Case 38
                DrinkOrderPanel38 = New FoodOrderPanel(bColor, fColor, 38, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel38)
            Case 39
                DrinkOrderPanel39 = New FoodOrderPanel(bColor, fColor, 39, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel39)
            Case 40
                DrinkOrderPanel40 = New FoodOrderPanel(bColor, fColor, 40, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel40)
            Case 41
                DrinkOrderPanel41 = New FoodOrderPanel(bColor, fColor, 41, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel41)
            Case 42
                DrinkOrderPanel42 = New FoodOrderPanel(bColor, fColor, 42, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel42)
            Case 43
                DrinkOrderPanel43 = New FoodOrderPanel(bColor, fColor, 43, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel43)
            Case 44
                DrinkOrderPanel44 = New FoodOrderPanel(bColor, fColor, 44, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel44)
            Case 45
                DrinkOrderPanel45 = New FoodOrderPanel(bColor, fColor, 45, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel45)
            Case 46
                DrinkOrderPanel46 = New FoodOrderPanel(bColor, fColor, 46, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel46)
            Case 47
                DrinkOrderPanel47 = New FoodOrderPanel(bColor, fColor, 47, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel47)
            Case 48
                DrinkOrderPanel48 = New FoodOrderPanel(bColor, fColor, 48, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel48)
            Case 49
                DrinkOrderPanel49 = New FoodOrderPanel(bColor, fColor, 49, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel49)
            Case 50
                DrinkOrderPanel50 = New FoodOrderPanel(bColor, fColor, 50, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel50)
            Case 51
                DrinkOrderPanel51 = New FoodOrderPanel(bColor, fColor, 51, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel51)
            Case 52
                DrinkOrderPanel52 = New FoodOrderPanel(bColor, fColor, 52, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel52)
            Case 53
                DrinkOrderPanel53 = New FoodOrderPanel(bColor, fColor, 53, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel53)
            Case 54
                DrinkOrderPanel54 = New FoodOrderPanel(bColor, fColor, 54, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel54)
            Case 55
                DrinkOrderPanel55 = New FoodOrderPanel(bColor, fColor, 55, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel55)
            Case 56
                DrinkOrderPanel56 = New FoodOrderPanel(bColor, fColor, 56, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel56)
            Case 57
                DrinkOrderPanel57 = New FoodOrderPanel(bColor, fColor, 57, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel57)
            Case 58
                DrinkOrderPanel58 = New FoodOrderPanel(bColor, fColor, 58, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel58)
            Case 59
                DrinkOrderPanel59 = New FoodOrderPanel(bColor, fColor, 59, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel59)
            Case 60
                DrinkOrderPanel60 = New FoodOrderPanel(bColor, fColor, 60, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel60)

        End Select

    End Sub


    Private Sub DrinkMouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles DrinkOrderPanel1.BlankOldModifierPanel, DrinkOrderPanel2.BlankOldModifierPanel, DrinkOrderPanel3.BlankOldModifierPanel, DrinkOrderPanel4.BlankOldModifierPanel, DrinkOrderPanel5.BlankOldModifierPanel, DrinkOrderPanel6.BlankOldModifierPanel, DrinkOrderPanel7.BlankOldModifierPanel, DrinkOrderPanel8.BlankOldModifierPanel, DrinkOrderPanel9.BlankOldModifierPanel, DrinkOrderPanel10.BlankOldModifierPanel, DrinkOrderPanel11.BlankOldModifierPanel, DrinkOrderPanel12.BlankOldModifierPanel, DrinkOrderPanel13.BlankOldModifierPanel, DrinkOrderPanel14.BlankOldModifierPanel, DrinkOrderPanel15.BlankOldModifierPanel, DrinkOrderPanel16.BlankOldModifierPanel, DrinkOrderPanel17.BlankOldModifierPanel, DrinkOrderPanel18.BlankOldModifierPanel, DrinkOrderPanel19.BlankOldModifierPanel, DrinkOrderPanel20.BlankOldModifierPanel, DrinkOrderPanel21.BlankOldModifierPanel, DrinkOrderPanel22.BlankOldModifierPanel, DrinkOrderPanel23.BlankOldModifierPanel, DrinkOrderPanel24.BlankOldModifierPanel, DrinkOrderPanel25.BlankOldModifierPanel, DrinkOrderPanel26.BlankOldModifierPanel, DrinkOrderPanel27.BlankOldModifierPanel, DrinkOrderPanel28.BlankOldModifierPanel, DrinkOrderPanel29.BlankOldModifierPanel, DrinkOrderPanel30.BlankOldModifierPanel, DrinkOrderPanel31.BlankOldModifierPanel, DrinkOrderPanel32.BlankOldModifierPanel, DrinkOrderPanel33.BlankOldModifierPanel, DrinkOrderPanel34.BlankOldModifierPanel, DrinkOrderPanel35.BlankOldModifierPanel, DrinkOrderPanel36.BlankOldModifierPanel, DrinkOrderPanel37.BlankOldModifierPanel, DrinkOrderPanel38.BlankOldModifierPanel, DrinkOrderPanel39.BlankOldModifierPanel, DrinkOrderPanel40.BlankOldModifierPanel, DrinkOrderPanel41.BlankOldModifierPanel, DrinkOrderPanel42.BlankOldModifierPanel, DrinkOrderPanel43.BlankOldModifierPanel, DrinkOrderPanel44.BlankOldModifierPanel, DrinkOrderPanel45.BlankOldModifierPanel, DrinkOrderPanel46.BlankOldModifierPanel, DrinkOrderPanel47.BlankOldModifierPanel, DrinkOrderPanel48.BlankOldModifierPanel, DrinkOrderPanel49.BlankOldModifierPanel, DrinkOrderPanel50.BlankOldModifierPanel, DrinkOrderPanel51.BlankOldModifierPanel, DrinkOrderPanel52.BlankOldModifierPanel, DrinkOrderPanel53.BlankOldModifierPanel, DrinkOrderPanel54.BlankOldModifierPanel, DrinkOrderPanel55.BlankOldModifierPanel, DrinkOrderPanel56.BlankOldModifierPanel, DrinkOrderPanel57.BlankOldModifierPanel, DrinkOrderPanel58.BlankOldModifierPanel, DrinkOrderPanel59.BlankOldModifierPanel, DrinkOrderPanel60.BlankOldModifierPanel

        currentDrinkPanelLast = CType(sender, FoodPanelControl)

        '   KeepDrinkPanelBlank()
        currentDrinkPanelLast.Text = ""
        currentDrinkPanelLast.DrinkID = 0
        currentDrinkPanelLast.FoodName = ""
        currentDrinkPanelLast.FoodPrice = 0

        updatedDrink = True

        '   SaveDrinkhanges()

    End Sub


    Private Sub RecordLastPanelDrink222(ByRef currentOrderPanel As FoodPanelControl)

        newDrink.DrinkNameIndex = currentOrderPanel.MenuJoinID
        newDrink.DrinkName = currentOrderPanel.Name
        '     newDrink.DrinkName = currentOrderPanel.Text
        '    newDrink.ChangingPane = currentOrderPanel


    End Sub

    Private Sub KeepDrinkPanelBlank()

        '      currentDrinkPanel.Text = ""
        '     currentDrinkPanel.DrinkID = 0

        '        newDrink.DrinkNameID = 0

        '
        Exit Sub


        btnDrinks(newModifier.MenuIndex).ID = Nothing
        Me.btnDrinks(newModifier.MenuIndex).Name = Nothing
        Me.btnDrinks(newModifier.MenuIndex).DrinkIndex = Nothing
        updatedDrink = True 'b/c we changed position

    End Sub

    Private Sub pnlDrinkByCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DrinkOrderPanel1.MyPanelClick, DrinkOrderPanel2.MyPanelClick, DrinkOrderPanel3.MyPanelClick, DrinkOrderPanel4.MyPanelClick, DrinkOrderPanel5.MyPanelClick, DrinkOrderPanel6.MyPanelClick, DrinkOrderPanel7.MyPanelClick, DrinkOrderPanel8.MyPanelClick, DrinkOrderPanel9.MyPanelClick, DrinkOrderPanel10.MyPanelClick, DrinkOrderPanel11.MyPanelClick, DrinkOrderPanel12.MyPanelClick, DrinkOrderPanel13.MyPanelClick, DrinkOrderPanel14.MyPanelClick, DrinkOrderPanel15.MyPanelClick, DrinkOrderPanel16.MyPanelClick, DrinkOrderPanel17.MyPanelClick, DrinkOrderPanel18.MyPanelClick, DrinkOrderPanel19.MyPanelClick, DrinkOrderPanel20.MyPanelClick, DrinkOrderPanel21.MyPanelClick, DrinkOrderPanel22.MyPanelClick, DrinkOrderPanel23.MyPanelClick, DrinkOrderPanel24.MyPanelClick, DrinkOrderPanel25.MyPanelClick, DrinkOrderPanel26.MyPanelClick, DrinkOrderPanel27.MyPanelClick, DrinkOrderPanel28.MyPanelClick, DrinkOrderPanel29.MyPanelClick, DrinkOrderPanel30.MyPanelClick, DrinkOrderPanel31.MyPanelClick, DrinkOrderPanel32.MyPanelClick, DrinkOrderPanel33.MyPanelClick, DrinkOrderPanel34.MyPanelClick, DrinkOrderPanel35.MyPanelClick, DrinkOrderPanel36.MyPanelClick, DrinkOrderPanel37.MyPanelClick, DrinkOrderPanel38.MyPanelClick, DrinkOrderPanel39.MyPanelClick, DrinkOrderPanel40.MyPanelClick, DrinkOrderPanel41.MyPanelClick, DrinkOrderPanel42.MyPanelClick, DrinkOrderPanel43.MyPanelClick, DrinkOrderPanel44.MyPanelClick, DrinkOrderPanel45.MyPanelClick, DrinkOrderPanel46.MyPanelClick, DrinkOrderPanel47.MyPanelClick, DrinkOrderPanel48.MyPanelClick, DrinkOrderPanel49.MyPanelClick, DrinkOrderPanel50.MyPanelClick, DrinkOrderPanel51.MyPanelClick, DrinkOrderPanel52.MyPanelClick, DrinkOrderPanel53.MyPanelClick, DrinkOrderPanel54.MyPanelClick, DrinkOrderPanel55.MyPanelClick, DrinkOrderPanel56.MyPanelClick, DrinkOrderPanel57.MyPanelClick, DrinkOrderPanel58.MyPanelClick, DrinkOrderPanel59.MyPanelClick, DrinkOrderPanel60.MyPanelClick
        '       Dim currentOrderPanel As FoodPanelControl


        drinkDisplaying = True  'this is telling us in the middle of displaying
        Dim oRow As DataRow
        Dim vRow As DataRowView

        'newDrink here is last Drink hit
        '       If Not currentDrinkPanel Is Nothing Then
        If newDrink.DrinkNameIndex = Nothing Then
            CreateOldDrink(newDrink.DrinkNameIndex, Nothing)    'currentDrinkPanel.Position, Nothing)
        Else
            CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber)
        End If
        '     End If


        UpdateDrink()
        currentDrinkPanel = CType(sender, FoodPanelControl)

        ClearDrinkInfo()
        Me.cbxDrinkFunction.Text = ""

        'must init newDrink before Update so for new entrys we can place Index
        newDrink = New ActiveDrink
        newDrink.DrinkNameID = currentDrinkPanel.DrinkID
        newDrink.DrinkCategoryID = currentDrinkCategoryID

        '    MsgBox(newDrink.DrinkNameID)

        If Not newDrink.DrinkNameID = 0 Then
            addingNewDrinkTest = False
            For Each vRow In dvDrinksByCategory
                If vRow("DrinkID") = newDrink.DrinkNameID Then
                    Exit For
                End If
            Next
            newDrink.DrinkNameIndex = vRow("DrinkIndex")
            newDrink.DrinkName = vRow("DrinkName")

            newDrink.DrinkFunctionID = vRow("DrinkFunctionID")
            newDrink.DrinkPrice = vRow("DrinkPrice")
            newDrink.DrinkHappyPrice = vRow("DrinkHappyPrice")
            newDrink.AddOnPrice = vRow("AddOnPrice")
            newDrink.DrinkDesc = vRow("DrinkDesc")
            newDrink.DrinkAddOnChoice = vRow("DrinkAddOnChoice")
            newDrink.IsDrinkAdd = vRow("IsDrinkAdd")
            newDrink.IsWineParring = vRow("IsWineParring")
            newDrink.LiquorType = vRow("LiquorTypeID")
            newDrink.CallPrice = vRow("CallPrice")

            newDrinkChangesMade = False


            txtDrinkName.Text = newDrink.DrinkName
            txtDrinkPrice.Text = Format(newDrink.DrinkPrice, "##,###.00")
            txtDrinkHappyPrice.Text = Format(newDrink.DrinkHappyPrice, "##,###.00")
            txtDrinkDesc.Text = newDrink.DrinkDesc
            txtCallPrice.Text = Format(newDrink.CallPrice, "####.00")
            txtAddOnPrice.Text = Format(newDrink.AddOnPrice, "####.00")
            Me.chkSelectAddOn.Checked = newDrink.DrinkAddOnChoice
            Me.chkIsAddOn.Checked = newDrink.IsDrinkAdd
            Me.chkWineParring.Checked = newDrink.IsWineParring
            For Each oRow In dsSetup.Tables("DrinkFunctions").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FunctionID") = newDrink.DrinkFunctionID Then
                        Me.cbxDrinkFunction.Text = oRow("FunctionName")
                        Exit For
                    End If
                End If
            Next

            If newDrink.LiquorType = 0 Then
                Me.cbxLiquorType.Text = "No Liquor Type"
            Else
                For Each oRow In dsSetup.Tables("LiquorTypes").Rows
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If oRow("DrinkCategoryID") = newDrink.LiquorType Then
                            Me.cbxLiquorType.Text = oRow("DrinkCategoryName")
                            Exit For
                        End If
                    End If
                Next
            End If


            For Each oRow In dsSetup.Tables("DrinkFunctions").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FunctionID") = newDrink.DrinkFunctionID Then
                        Me.cbxDrinkFunction.Text = oRow("FunctionName")
                        Exit For
                    End If
                End If
            Next
        Else

            addingNewDrinkTest = True
            newDrinkChangesMade = False

        End If

        txtDrinkName.Focus()
        drinkDisplaying = False
        '     RecordLastPanelDrink(currentOrderPanel)

    End Sub

    Private Sub pnlDrinkByCategory_Click222(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles pnlDrinkByCategory.Click
        Dim objbutton As DrinkButton
        If Not sender.GetType Is btnDrinks(1).GetType Then
            Exit Sub
        End If
        objbutton = CType(sender, DrinkButton)

        If (newDrink.DrinkNameID > 0) And newDrink.DrinkFunctionID = 0 Then
            '           MsgBox("Please select a Tax Category")
        End If
        drinkDisplaying = True  'this is telling us in the middle of displaying
        Dim oRow As DataRow

        'newDrink here is last Drink hit
        If newDrink.DrinkNameIndex = Nothing Then
            CreateOldDrink(objbutton.Position, objbutton.dRowNumber)
        Else
            CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber)
        End If

        UpdateDrink()
        ClearDrinkInfo()
        Me.cbxDrinkFunction.Text = ""

        'must init newDrink before Update so for new entrys we can place Index
        newDrink = New ActiveDrink
        newDrink.DrinkNameID = objbutton.ID
        newDrink.DrinkNameIndex = objbutton.Position
        newDrink.dRowNumber = objbutton.dRowNumber

        '    If objbutton.ID >= 0 Then
        Try
            '        ClearDrinkInfo()
            txtDrinkName.Text = objbutton.Text
            txtDrinkPrice.Text = Format(objbutton.DrinkPrice, "##,###.00")
            txtDrinkDesc.Text = objbutton.DrinkDesc
            txtCallPrice.Text = Format(objbutton.CallPrice, "####.00")
            txtAddOnPrice.Text = Format(objbutton.AddOnPrice, "####.00")
            Me.chkSelectAddOn.Checked = objbutton.DrinkAddOnChoice
            Me.chkIsAddOn.Checked = objbutton.IsDrinkAdd
            Me.chkWineParring.Checked = objbutton.IsWineParring
            For Each oRow In dsSetup.Tables("DrinkFunctions").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FunctionID") = objbutton.DrinkFunctionID Then
                        Me.cbxDrinkFunction.Text = oRow("FunctionName")
                        Exit For
                    End If
                End If
            Next

            If objbutton.LiquorTypeID = 0 Then
                Me.cbxLiquorType.Text = "No Liquor Type"
            Else
                For Each oRow In dsSetup.Tables("LiquorTypes").Rows
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If oRow("DrinkCategoryID") = objbutton.LiquorTypeID Then
                            Me.cbxLiquorType.Text = oRow("DrinkCategoryName")
                            Exit For
                        End If
                    End If
                Next
            End If


            For Each oRow In dsSetup.Tables("DrinkFunctions").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("FunctionID") = objbutton.DrinkFunctionID Then
                        Me.cbxDrinkFunction.Text = oRow("FunctionName")
                        Exit For
                    End If
                End If
            Next

            newDrink.DrinkName = objbutton.Text
            newDrink.DrinkNameID = objbutton.ID
            newDrink.DrinkFunctionID = objbutton.DrinkFunctionID
            newDrink.DrinkPrice = objbutton.DrinkPrice
            newDrink.CallPrice = objbutton.CallPrice
            newDrink.AddOnPrice = objbutton.AddOnPrice
            newDrink.DrinkDesc = objbutton.DrinkDesc
            newDrink.DrinkAddOnChoice = objbutton.DrinkAddOnChoice
            newDrink.IsDrinkAdd = objbutton.IsDrinkAdd
            newDrink.IsWineParring = objbutton.IsWineParring

            newDrinkChangesMade = False

        Catch ex As Exception
            '     Exit Sub

        End Try
        '      End If

        txtDrinkName.Focus()

        If objbutton.ID = -1 Then
            addingNewDrinkTest = True
        Else
            addingNewDrinkTest = False
        End If

        drinkDisplaying = False
    End Sub

    Private Sub CreateOldDrink(ByVal dni As Integer, ByVal dRowNum As Integer)
        oldDrink = New ActiveDrink
        Dim oRow As DataRow

        '       currentDrinkPanel.Text = Me.txtDrinkName.Text
        '      currentDrinkPanel.DrinkID = newDrink.DrinkNameID

        oldDrink.DrinkName = Me.txtDrinkName.Text
        oldDrink.DrinkNameID = newDrink.DrinkNameID
        oldDrink.DrinkCategoryIndex = currentDrinkCategoryID
        oldDrink.DrinkCategoryID = currentDrinkCategoryID

        oldDrink.ChangesMade = newDrinkChangesMade
        oldDrink.DrinkNameIndex = newDrink.DrinkNameIndex       'dni '
        oldDrink.dRowNumber = dRowNum  'newDrink.dRowNumber
        Try
            If Me.txtDrinkPrice.Text.Length > 0 Then
                oldDrink.DrinkPrice = Format(CType(Me.txtDrinkPrice.Text, Decimal), "#,###.00")
            Else
                oldDrink.DrinkPrice = 0
            End If
        Catch ex As Exception
            oldDrink.DrinkPrice = 0
        End Try
        Try
            If Me.txtDrinkHappyPrice.Text.Length > 0 Then
                oldDrink.DrinkHappyPrice = Format(CType(Me.txtDrinkHappyPrice.Text, Decimal), "#,###.00")
            Else
                oldDrink.DrinkHappyPrice = 0
            End If
        Catch ex As Exception
            oldDrink.DrinkHappyPrice = 0
        End Try
        Try
            If Me.txtCallPrice.Text.Length > 0 Then
                oldDrink.CallPrice = Format(CType(Me.txtCallPrice.Text, Decimal), "###.00")
            Else
                oldDrink.CallPrice = 0
            End If
        Catch ex As Exception
            oldDrink.CallPrice = 0
        End Try
        Try
            If Not Me.txtAddOnPrice.Text = "Add-on Price" Then
                oldDrink.AddOnPrice = Format(CType(Me.txtAddOnPrice.Text, Decimal), "###.00")
            Else
                oldDrink.AddOnPrice = 0
            End If
        Catch ex As Exception
            oldDrink.AddOnPrice = 0
        End Try
        If Me.txtDrinkDesc.Text.Length > 0 Then
            oldDrink.DrinkDesc = Me.txtDrinkDesc.Text
        Else
            oldDrink.DrinkDesc = ""
        End If


        oldDrink.DrinkAddOnChoice = Me.chkSelectAddOn.Checked
        oldDrink.IsDrinkAdd = Me.chkIsAddOn.Checked
        oldDrink.IsWineParring = Me.chkWineParring.Checked

        '   liquor Type is going to be an integer value related to drink Category ?????
        If Not Me.cbxLiquorType.Text = "No Liquor Type" Then
            For Each oRow In dsSetup.Tables("LiquorTypes").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("DrinkCategoryName") = Me.cbxLiquorType.Text Then
                        oldDrink.LiquorType = oRow("DrinkCategoryID")
                        Exit For
                    End If
                End If
            Next
        End If

        For Each oRow In dsSetup.Tables("DrinkFunctions").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("FunctionName") = Me.cbxDrinkFunction.Text Then 'objbutton.DrinkFunctionID Then
                    '        MsgBox(oRow("FunctionID"))
                    oldDrink.DrinkFunctionID = oRow("FunctionID")
                    Exit For
                End If
            End If
        Next

    End Sub



    Private Sub DisplayDrinkByCategoryPanel222()
        Dim index As Integer
        Dim count As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace
        Dim btnWidth As Integer
        Dim btnHeight As Integer

        '     Me.pnlDrinkByCategory.Size = New Size(pnlDrinkCategory.Width, pnlDrinkCategory.Height)
        btnWidth = (pnlDrinkByCategory.Width - (7 * buttonSpace)) / 6
        btnHeight = (pnlDrinkByCategory.Height - (11 * buttonSpace)) / 10

        For index = 1 To 60 '48
            btnDrinks(index) = New DrinkButton
            With btnDrinks(index)
                .Size = New Size(btnWidth, btnHeight)
                .Location = New Point(x, y)
                .TabStop = False
                .Position = index
                .BackColor = c2
                .ID = -1
                pnlDrinkByCategory.Controls.Add(btnDrinks(index))
                AddHandler btnDrinks(index).Click, AddressOf pnlDrinkByCategory_Click

            End With
            count += 1
            If count < 6 Then
                x = x + buttonSpace + btnWidth
            Else
                x = buttonSpace
                y = y + btnHeight + buttonSpace
                count = 0
            End If
        Next

    End Sub

    Private Sub PopulateDrinkByCategoryPanel222(ByVal catID As Integer)
        Dim index As Integer
        Dim vRow As DataRowView
        Dim count As Integer
        currentDrinkCategoryID = catID

        With dvDrinksByCategory
            .Table = dsSetup.Tables("Drinks")
            .RowFilter = "DrinkCategoryID = '" & catID & "'"
        End With

        '     dsSetup.Tables("Drinks").Clear()
        '    dsSetup = sql.PopulateSelectedItemTable("Drinks", "SELECT CompanyID, LocationID, DrinkID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, CallPrice, AddOnPrice, Active FROM Drinks WHERE DrinkCategoryID = '" & catID & "' AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkIndex", dsSetup)

        newDrink = New ActiveDrink

        For Each vRow In dvDrinksByCategory 'dsSetup.Tables("Drinks").Rows
            '   If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
            index = vRow("DrinkIndex")
            '        newDrink.dRow = oRow
            btnDrinks(index).Text = vRow("DrinkName")
            If Not vRow("DrinkID") Is DBNull.Value Then
                btnDrinks(index).ID = vRow("DrinkID")
            Else
                btnDrinks(index).ID = -1
            End If
            btnDrinks(index).ID = vRow("DrinkID")
            btnDrinks(index).DrinkCategoryID = vRow("DrinkCategoryID")
            btnDrinks(index).DrinkIndex = vRow("DrinkIndex")
            btnDrinks(index).dRowNumber = count
            btnDrinks(index).BackColor = c16
            btnDrinks(index).ForeColor = c3
            btnDrinks(index).DrinkPrice = vRow("DrinkPrice")
            btnDrinks(index).CallPrice = vRow("CallPrice")
            btnDrinks(index).AddOnPrice = vRow("AddOnPrice")
            btnDrinks(index).DrinkFunctionID = vRow("DrinkFunctionID")
            btnDrinks(index).DrinkDesc = vRow("DrinkDesc")
            btnDrinks(index).DrinkAddOnChoice = vRow("DrinkAddOnChoice")
            btnDrinks(index).IsDrinkAdd = vRow("IsDrinkAdd")
            btnDrinks(index).IsWineParring = vRow("IsWineParring")
            btnDrinks(index).LiquorTypeID = vRow("LiquorTypeID")

            '      End If
            count += 1
        Next

    End Sub

    '   Private Sub MarkChangesBecauseMouse(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrinkName.MouseEnter
    '
    '       If newDrink.DrinkNameIndex = 0 Or oldDrink.DrinkNameIndex = 0 Then Exit Sub
    '
    '       newDrinkChangesMade = True
    '
    '   End Sub
    '

    '   Private Sub MarkChangesMade(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrinkName.Enter, txtDrinkPrice.Enter, txtDrinkDesc.Enter, txtAddOnPrice.Enter, chkIsAddOn.Enter, chkSelectAddOn.Enter, chkWineParring.Enter, txtCallPrice.Enter

    '      If newDrink.DrinkNameIndex = 0 Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

    '      If drinkDisplaying = False Then
    '         newDrinkChangesMade = True
    '    End If
    '    End Sub

    Private Sub MarkChangesMadeMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles txtDrinkName.MouseDown, txtDrinkPrice.MouseDown, txtDrinkHappyPrice.MouseDown, txtDrinkDesc.MouseDown, txtAddOnPrice.MouseDown, chkIsAddOn.MouseDown, chkSelectAddOn.MouseDown, chkWineParring.MouseDown, txtCallPrice.MouseDown

        If newDrink.DrinkNameID = 0 Then Exit Sub 'Or oldDrink.DrinkNameIndex = 0 Then Exit Sub
        newDrinkChangesMade = True

    End Sub

    Private Sub MarkForWineParringChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkWineParring.Enter
        updatedWPI = True
        updatedDrink = True

    End Sub

    Private Sub ClearDrinkInfo()

        txtDrinkName.Text = ""
        txtDrinkPrice.Text = CType(0, Decimal)
        txtDrinkDesc.Text = Nothing
        txtCallPrice.Text = CType(0, Decimal)
        txtAddOnPrice.Text = CType(0, Decimal)
        Me.chkSelectAddOn.Checked = False
        Me.chkIsAddOn.Checked = False
        Me.chkWineParring.Checked = False
        Me.cbxLiquorType.Text = "No Liquor Type"


    End Sub

    Private Sub ClearDrinkButtons()
        Dim index As Integer
        Dim blankRow As DataRow

        For index = 1 To 60
            btnDrinks(index).Text = ""
            btnDrinks(index).ID = 0
            '      btnDrinks(index).dRow = blankRow
            '   btnDrinks(index).Text = Nothing
            '  btnDrinks(index).ID = Nothing
            ' btnDrinks(index).dRow = Nothing
            btnDrinks(index).BackColor = Color.White
        Next
    End Sub

    Private Sub ButtonDrinkCatColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrinkCategoryColor.Click

        Me.DrinkColorChoice = New ButtonColor_UC
        Me.DrinkColorChoice.Location = New Point(480, 25)
        Me.Controls.Add(DrinkColorChoice)
        DrinkColorChoice.BringToFront()

    End Sub

    Private Sub ChangingDrinkButtonColor(ByVal cc As Integer, ByVal foreCC As Integer) Handles DrinkColorChoice.ChangeButtonColor

        Me.btnDrinkCategoryColor.BackColor = Color.FromArgb(cc)
        Me.btnDrinkCategoryColor.ForeColor = Color.FromArgb(foreCC)
        btnCategory(newDrink.DrinkCategoryIndex).BackColor = Me.btnDrinkCategoryColor.BackColor
        btnCategory(newDrink.DrinkCategoryIndex).ForeColor = Me.btnDrinkCategoryColor.ForeColor

        newDrinkChangesMade = True

        '    newCategory.ColorInt = cc
        '   newCategory.ColorForeInt = foreCC
        '  newCategory.Updated = True

    End Sub


    Private Sub pnlDrinkModifiers_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlDrinkModifiers.Enter

        Me.btnDrinkPrices.ForeColor = Color.White

    End Sub

    Private Sub btnDeleteDrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDrink.Click
        '      If MsgBox("Are you sure you want to remove " & Me.txtDrinkName.Text & " ?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
        Dim oRow As DataRow
        Dim deletedDrink As Boolean

        '   do this so if any added drinks - we have a drinkID
        '        dsSetup.Tables("Drink").Clear()
        '       dsSetup = sql.PopulateSelectedItemTable("Drink", "SELECT CompanyID, LocationID, DrinkID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, CallPrice, AddOnPrice, Active FROM Drinks WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'", dsSetup)

        If Not newDrink.DrinkNameID = Nothing Then
            For Each oRow In dsSetup.Tables("Drinks").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("DrinkID") = newDrink.DrinkNameID Then
                        MsgBox(oRow("DrinkName") & " Deleted")
                        oRow.Delete()
                        deletedDrink = True
                        Exit For
                    End If
                    '            If oRow("DrinkCategoryID") = currentDrinkCategoryID Then
                    '           If oRow("DrinkIndex") = newDrink.DrinkNameIndex Then
                    '          MsgBox(oRow("DrinkName") & " Deleted")
                    '         oRow.Delete()
                    '        deletedDrink = True
                    '       Exit For
                    '  End If
                    '    End If
                End If
            Next
        End If

        If deletedDrink = False Then Exit Sub

        For Each oRow In dsSetup.Tables("FoodTable").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If Not oRow("WineParringID") Is DBNull.Value Then
                    If oRow("WineParringID") = newDrink.DrinkNameID Then
                        oRow("WineParringID") = 0
                        updatedWPI = True
                        '                        Exit For
                    End If
                End If
            End If
        Next

        '    SaveDrink()
        updatedDrink = True
        ClearDrinkInfo()
        currentDrinkPanel.Text = ""
        currentDrinkPanel.DrinkID = 0
        currentDrinkPanel.FoodName = ""
        currentDrinkPanel.FoodPrice = 0

        '        btnDrinks(newDrink.DrinkNameIndex).Text = txtDrinkName.Text
        '       If btnDrinks(newDrink.DrinkNameIndex).Text = "" Then
        '      btnDrinks(newDrink.DrinkNameIndex).BackColor = c2
        '     oldDrink = New ActiveDrink
        '    oldDrink.DrinkNameIndex = newDrink.DrinkNameIndex
        '   '222       UpdateDrinkButton()
        '  End If
        '
        '       newDrink = New ActiveDrink

    End Sub

    Private Sub LeaveDrinkTab(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabDrinks.Leave
        If Not newDrink.DrinkFunctionID > 0 Then
            '         MsgBox("Please select a Tax Category")
        End If
        Dim oRow As DataRow

        '      If Not currentDrinkPanel Is Nothing Then
        CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber)
        '     End If

        UpdateDrink()

        If updatedDrink = True Then
            SaveDrink()
        End If

        oldDrink.ChangesMade = False

    End Sub

    Private Sub AddNewDrink()

        Dim oRow As DataRow
        SaveDrink()

        '     If newDrink.DrinkNameID = Nothing Then
        oRow = dsSetup.Tables("Drinks").NewRow
        '      oRow("DrinkID") = newDrink.DrinkNameIndex       'need to do a get drink ID
        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("DrinkIndex") = currentDrinkPanel.Position      'oldDrink.DrinkNameIndex
        oRow("DrinkName") = oldDrink.DrinkName 'txtDrinkName.Text
        oRow("DrinkCategoryID") = oldDrink.DrinkCategoryID
        oRow("DrinkPrice") = oldDrink.DrinkPrice
        oRow("DrinkHappyPrice") = oldDrink.DrinkHappyPrice
        oRow("DrinkFunctionID") = oldDrink.DrinkFunctionID
        oRow("TaxID") = 0   'i don't think this is anything, we use TAX from funtionID
        oRow("DrinkDesc") = oldDrink.DrinkDesc
        oRow("DrinkAddOnChoice") = oldDrink.DrinkAddOnChoice
        oRow("IsDrinkAdd") = oldDrink.IsDrinkAdd
        oRow("IsWineParring") = oldDrink.IsWineParring
        oRow("LiquorTypeID") = oldDrink.LiquorType

        oRow("AddOnPrice") = oldDrink.AddOnPrice
        oRow("CallPrice") = oldDrink.CallPrice
        oRow("Active") = 1
        oRow("DrinkInvOn") = 0
        oRow("DrinkInv") = 0

        '   we need this count before we add row (b/c zero based)
        oldDrink.dRowNumber = dsSetup.Tables("Drinks").Rows.Count

        dsSetup.Tables("Drinks").Rows.Add(oRow)
        oRow("DrinkID") = InsertingNewDrink(oRow)
        dsSetup.Tables("Drinks").AcceptChanges()

        If Not currentDrinkPanel Is Nothing Then
            currentDrinkPanel.Text = Me.txtDrinkName.Text
            currentDrinkPanel.DrinkID = oRow("DrinkID")
            currentDrinkPanel.FoodName = Me.txtDrinkName.Text
            currentDrinkPanel.FoodPrice = oldDrink.DrinkPrice
        End If

        '     newDrink.dRow = oRow

        '    UpdateDrinkButton()

    End Sub

    Private Function InsertingNewDrink(ByRef orow As DataRow)
        Dim newDrinkID As Integer

        sql.SqlInsertCommandMenuDrinks.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandMenuDrinks.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkIndex").Value = orow("DrinkIndex")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkName").Value = orow("DrinkName")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkCategoryID").Value = orow("DrinkCategoryID")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkPrice").Value = orow("DrinkPrice")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkHappyPrice").Value = orow("DrinkHappyPrice")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkFunctionID").Value = orow("DrinkFunctionID")
        sql.SqlInsertCommandMenuDrinks.Parameters("@TaxID").Value = 0
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkDesc").Value = orow("DrinkDesc")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkAddOnChoice").Value = orow("DrinkAddOnChoice")
        sql.SqlInsertCommandMenuDrinks.Parameters("@IsDrinkAdd").Value = orow("IsDrinkAdd")
        sql.SqlInsertCommandMenuDrinks.Parameters("@IsWineParring").Value = orow("IsWineParring")
        sql.SqlInsertCommandMenuDrinks.Parameters("@LiquorTypeID").Value = orow("LiquorTypeID")
        sql.SqlInsertCommandMenuDrinks.Parameters("@CallPrice").Value = orow("CallPrice")
        sql.SqlInsertCommandMenuDrinks.Parameters("@AddOnPrice").Value = orow("AddOnPrice")
        sql.SqlInsertCommandMenuDrinks.Parameters("@Active").Value = orow("Active")
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkInvOn").Value = 0
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkInv").Value = 0

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newDrinkID = CType(sql.SqlInsertCommandMenuDrinks.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newDrinkID

    End Function

    Private Sub MakeChangesExistingDrink()
        Dim oRow As DataRow

        '   If Not newDrink.DrinkNameIndex = Nothing Then
        For Each oRow In dsSetup.Tables("Drinks").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("DrinkID") = oldDrink.DrinkNameID Then
                    '         MsgBox(oRow("DrinkCategoryID"))
                    '        MsgBox(oRow("DrinkName"))
                    Exit For
                End If
                '          If oRow("DrinkCategoryID") = currentDrinkCategoryID Then
                '         If oRow("DrinkIndex") = newDrink.DrinkNameIndex Then
                '        Exit For
                '   End If
                '  End If
            End If
        Next
        '     End If

        '    oRow = dsSetup.Tables("Drinks").Rows(newDrink.dRowNumber)

        '     oRow("DrinkIndex") = oldDrink.DrinkNameIndex
        oRow("DrinkName") = oldDrink.DrinkName 'txtDrinkName.Text
        oRow("DrinkCategoryID") = oldDrink.DrinkCategoryID
        oRow("DrinkPrice") = oldDrink.DrinkPrice
        oRow("DrinkHappyPrice") = oldDrink.DrinkHappyPrice
        oRow("DrinkFunctionID") = oldDrink.DrinkFunctionID
        '        oRow("TaxID") = 2
        oRow("DrinkDesc") = oldDrink.DrinkDesc
        oRow("DrinkAddOnChoice") = oldDrink.DrinkAddOnChoice
        oRow("IsDrinkAdd") = oldDrink.IsDrinkAdd
        oRow("IsWineParring") = oldDrink.IsWineParring
        oRow("LiquorTypeID") = oldDrink.LiquorType
        oRow("CallPrice") = oldDrink.CallPrice
        oRow("AddOnPrice") = oldDrink.AddOnPrice

        If Not currentDrinkPanel Is Nothing Then
            currentDrinkPanel.Text = oldDrink.DrinkName 'Me.txtDrinkName.Text
            currentDrinkPanel.FoodName = oldDrink.DrinkName
            currentDrinkPanel.FoodPrice = oldDrink.DrinkPrice
            '      currentdrinkpanel.MenuJoinID =
            '           currentDrinkPanel.DrinkID = oRow("DrinkID")
        End If


        'will add 
        'orow("Acitve")
        'orow("DrinkInvOn")
        'oRow("DrinkInv")

        '     newDrink.dRow = oRow  ?????

        '     UpdateDrinkButton()

    End Sub

    Private Sub UpdateDrinkButton222()
        Dim oRow As DataRow
        Dim newDrinkID As Integer
        '      If oldDrink.DrinkNameIndex = 0 Then Exit Sub

        btnDrinks(oldDrink.DrinkNameIndex).Text = oldDrink.DrinkName
        btnDrinks(oldDrink.DrinkNameIndex).DrinkFunctionID = oldDrink.DrinkFunctionID
        btnDrinks(oldDrink.DrinkNameIndex).DrinkCategoryID = oldDrink.DrinkCategoryID
        btnDrinks(oldDrink.DrinkNameIndex).DrinkIndex = oldDrink.DrinkNameIndex
        btnDrinks(oldDrink.DrinkNameIndex).dRowNumber = oldDrink.dRowNumber


        btnDrinks(oldDrink.DrinkNameIndex).DrinkPrice = oldDrink.DrinkPrice
        btnDrinks(oldDrink.DrinkNameIndex).DrinkDesc = oldDrink.DrinkDesc
        btnDrinks(oldDrink.DrinkNameIndex).DrinkAddOnChoice = oldDrink.DrinkAddOnChoice
        btnDrinks(oldDrink.DrinkNameIndex).IsDrinkAdd = oldDrink.IsDrinkAdd
        btnDrinks(oldDrink.DrinkNameIndex).IsWineParring = oldDrink.IsWineParring
        btnDrinks(oldDrink.DrinkNameIndex).CallPrice = oldDrink.CallPrice
        btnDrinks(oldDrink.DrinkNameIndex).AddOnPrice = oldDrink.AddOnPrice
        btnDrinks(oldDrink.DrinkNameIndex).LiquorTypeID = oldDrink.LiquorType

        If btnDrinks(oldDrink.DrinkNameIndex).Text = "" Then
            btnDrinks(oldDrink.DrinkNameIndex).BackColor = c2
        End If


        If addingNewDrinkTest = True Then           'newDrink.DrinkNameID = Nothing Then
            '   just add drink.... just change color
            btnDrinks(oldDrink.DrinkNameIndex).BackColor = c1

            '       newDrinkID = GetMaximumID("DrinkID", "Drinks")
            '       btnDrinks(newDrink.DrinkNameIndex).ID = newDrinkID
            '      btnDrinks(newDrink.DrinkNameIndex).dRow = newDrink.dRow
            '      btnDrinks(newDrink.DrinkNameIndex).DrinkFunctionID = newDrink.DrinkFunctionID
        End If

    End Sub

    Private Sub UpdateDrink()

        If addingNewDrinkTest = True Then
            '   this is when the last drink panel hit was blank
            If txtDrinkName.Text.Length > 0 Then
                AddNewDrink()
                updatedDrink = True
            End If
        Else
            If newDrinkChangesMade = True Then
                MakeChangesExistingDrink()
                newDrinkChangesMade = False
                updatedDrink = True
            Else
                '            ClearDrinkInfo()
            End If
        End If

    End Sub

    Private Sub SaveDrink()
        Dim oRow As DataRow

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuDrinks.Update(dsSetup, "Drinks")
            sql.cn.Close()
            dsSetup.Tables("Drinks").AcceptChanges()
            updatedDrink = False

        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        If updatedWPI = True Then
            UpdateDatabaseFoods()
            dsSetup.Tables("WineParring").Clear()
            sql.SqlSelectCommandMenuWineParring.Parameters("@CompanyID").Value = corpID
            sql.SqlSelectCommandMenuWineParring.Parameters("@LocationID").Value = selectedLocation

            Try
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlMenuWineParring.Fill(dsSetup.Tables("WineParring"))
                sql.cn.Close()
            Catch ex As Exception
                CloseConnection()
            End Try

            cbxWineParring.Items.Clear()
            For Each oRow In dsSetup.Tables("WineParring").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    cbxWineParring.Items.Add(oRow("DrinkName"))
                End If
            Next
            updatedWPI = False
        End If

    End Sub

    Private Sub cbxDrinkFunction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDrinkFunction.SelectedIndexChanged

        If newDrink.DrinkNameIndex = 0 Then Exit Sub 'Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

        Dim valueTypeID As Integer
        valueTypeID = dsSetup.Tables("DrinkFunctions").Rows(Me.cbxDrinkFunction.SelectedIndex)("FunctionID")

        newDrink.DrinkFunctionID = valueTypeID
        newDrinkChangesMade = True

    End Sub

    Private Sub cbxLiquorType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLiquorType.SelectedIndexChanged

        If newDrink.DrinkNameIndex = 0 Then Exit Sub 'Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

        '      MsgBox(newDrink.LiquorType)
        '     MsgBox(newDrink.DrinkName)
        '    MsgBox(oldDrink.DrinkName)

        If Me.cbxLiquorType.SelectedIndex = 0 Then
            newDrink.LiquorType = 0
        Else
            Dim valueTypeID As Integer
            valueTypeID = dsSetup.Tables("LiquorTypes").Rows(cbxLiquorType.SelectedIndex - 1)("DrinkCategoryID")

            '      MsgBox(valueTypeID)
            '     MsgBox(dsSetup.Tables("LiquorTypes").Rows(cbxLiquorType.SelectedIndex)("DrinkCategoryName"))

            newDrink.LiquorType = valueTypeID
        End If

        newDrinkChangesMade = True

    End Sub

    Private Sub btnBackToCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToCategory.Click


        '      If Not currentDrinkPanel Is Nothing Then
        CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber)
        '     End If

        UpdateDrink()

        If updatedDrink = True Then
            SaveDrink()
        End If

        ClearDrinkInfo()
        ClearDrinkButtons()
        addingNewDrinkTest = False
        newDrinkChangesMade = False
        newDrink.DrinkNameID = Nothing
        newDrink.dRowNumber = Nothing

        Me.pnlDrinks.Visible = True
        Me.pnlDrinkByCategory.Visible = False
        newDrink.DrinkNameID = Nothing
        '    newDrink.DrinkCategoryIndex = objButton.Position

    End Sub

    Private Sub DisplayDrinkModifiers222()

        If dsSetup.Tables("DrinkModifiers").Rows.Count = 0 Then
            CreateDrinkModifierDataTable222()
        End If

        txtDrinkDouble.Text = Format(dsSetup.Tables("DrinkModifiers").Rows(0)("DrinkPrice"), "###.00")
        txtDrinkRocks.Text = Format(dsSetup.Tables("DrinkModifiers").Rows(1)("DrinkPrice"), "###.00")
        txtDrinkUp.Text = Format(dsSetup.Tables("DrinkModifiers").Rows(2)("DrinkPrice"), "###.00")
        txtDrinkTall.Text = Format(dsSetup.Tables("DrinkModifiers").Rows(3)("DrinkPrice"), "###.00")
        txtDrinkSplash.Text = Format(dsSetup.Tables("DrinkModifiers").Rows(4)("DrinkPrice"), "###.00")

    End Sub



    '********************************
    '
    '   Drink Prep
    '
    '********************************

    Private Sub DisplayDrinkPrep()

        Dim count As Integer
        Dim index As Integer
        Dim oRow As DataRow
        Dim dRow As DataRow

        'sizes
        Dim xMenu As Integer = 63   'name (check box)
        Dim xMenu2 As Integer = 35  'price & orderBy
         Dim yMenu As Integer = 24
        'locations
        Dim xMenuLocation As Integer = 10
        Dim yMenuLocation As Integer = 50   '(3 * buttonSpace)

        For Each oRow In dsSetup.Tables("DrinkPrep").Rows

            If index = 0 Or index = 15 Or index = 30 Or index = 45 Or index = 60 Then
                Dim priceLabel As New Label
                Dim orderByLabel As New Label
                Dim InvLabel As New Label

                priceLabel.Text = " Price"
                priceLabel.ForeColor = Color.White
                priceLabel.Size = New Size(xMenu2, 15)
                priceLabel.Location = New Point((xMenu + 15 + xMenuLocation), yMenuLocation)
                priceLabel.TextAlign = ContentAlignment.MiddleRight
                orderByLabel.Text = "Ord"
                orderByLabel.ForeColor = Color.White
                orderByLabel.Size = New Size(yMenu, 15)
                orderByLabel.Location = New Point((xMenu + 15 + xMenu2 + xMenuLocation + 2), yMenuLocation)
                orderByLabel.TextAlign = ContentAlignment.MiddleRight
                InvLabel.Text = "Inv"
                InvLabel.ForeColor = Color.White
                InvLabel.Size = New Size(yMenu, 15)
                InvLabel.Location = New Point((xMenu + 15 + xMenu2 + yMenu + xMenuLocation + 4), yMenuLocation)
                InvLabel.TextAlign = ContentAlignment.MiddleRight

                Me.TabDrinkPrep.Controls.Add(priceLabel)
                Me.TabDrinkPrep.Controls.Add(orderByLabel)
                Me.TabDrinkPrep.Controls.Add(InvLabel)
                yMenuLocation = yMenuLocation + 15 + buttonSpace
            End If

            prepCheckBox(index) = New CheckBox
            With prepCheckBox(index)
                '    .Checked = True 
                .ForeColor = Color.White
                .Name = index 'oRow("DrinkPrepID")
                .Text = oRow("DrinkPrepName")
                .Size = New Size(xMenu, yMenu)
                .Location = New Point(xMenuLocation, yMenuLocation)
                Me.TabDrinkPrep.Controls.Add(prepCheckBox(index))
                xMenuLocation += (xMenu + 2)
            End With
            AddHandler prepCheckBox(index).Enter, AddressOf prepCheckBox_Changed

            prepMethod(index) = New Label
            With prepMethod(index)
                .Size = New Size(15, 21)
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(152, Byte), Integer))
                .ForeColor = Color.White
                .Name = index 'oRow("DrinkPrepID")
                .Location = New Point(xMenuLocation, yMenuLocation)
                .TextAlign = HorizontalAlignment.Center
                Me.TabDrinkPrep.Controls.Add(prepMethod(index))
                xMenuLocation += (15)
            End With
            AddHandler prepMethod(index).DoubleClick, AddressOf prepMethod_Clicked

            prepPriceText(index) = New TextBox
            With prepPriceText(index)
                .Size = New Size(xMenu2, yMenu)
                .Name = index 'oRow("DrinkPrepID")
                .Location = New Point(xMenuLocation, yMenuLocation)
                .TextAlign = HorizontalAlignment.Right
                Me.TabDrinkPrep.Controls.Add(prepPriceText(index))
                xMenuLocation += (xMenu2 + buttonSpace)
            End With
            AddHandler prepPriceText(index).Validating, AddressOf prepPriceText_Changed
       
            prepOrderByText(index) = New TextBox
            With prepOrderByText(index)
                .Size = New Size(yMenu, yMenu)
                .Name = index   'oRow("DrinkPrepID")
                .Location = New Point(xMenuLocation, yMenuLocation)
                .TextAlign = HorizontalAlignment.Right
                Me.TabDrinkPrep.Controls.Add(prepOrderByText(index))
                xMenuLocation += (yMenu + buttonSpace)
                '    .TextAlign = HorizontalAlignment.Right
            End With
            AddHandler prepOrderByText(index).Validating, AddressOf prepOrderByText_Changed

            prepInvMultiplier(index) = New TextBox
            With prepInvMultiplier(index)
                .Size = New Size(yMenu, yMenu)
                .Name = index   'oRow("DrinkPrepID")
                .Location = New Point(xMenuLocation, yMenuLocation)
                .TextAlign = HorizontalAlignment.Right
                Me.TabDrinkPrep.Controls.Add(prepInvMultiplier(index))
                '        xMenuLocation += (xMenu2 + buttonSpace)
                '    .TextAlign = HorizontalAlignment.Right
            End With
            AddHandler prepInvMultiplier(index).Validating, AddressOf prepInvMultiplier_Changed

            For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
                If oRow("DrinkPrepID") = dRow("DrinkPrepID") Then
                    ' this restaurant is using this prep
                    If dRow("Active") = True Then
                        prepCheckBox(index).Checked = dRow("Active")
                        prepPriceText(index).Text = dRow("DrinkPrepPrice")
                        If Not dRow("DrinkPrepOrder") = 999999 Then
                            prepOrderByText(index).Text = dRow("DrinkPrepOrder")
                        End If
                        If Not dRow("InvMultiplier") = 1 Then
                            prepInvMultiplier(index).Text = dRow("InvMultiplier")
                        End If
                        If dRow("DrinkPrepMethod") = "USdol" Then
                            prepMethod(index).Text = "$"
                        ElseIf dRow("DrinkPrepMethod") = "percent" Then
                            prepMethod(index).Text = "%"
                        End If
                    End If
                    Exit For
                End If
            Next

            index += 1
            If index = 15 Or index = 30 Or index = 45 Or index = 60 Then
                xMenuLocation += (xMenu2 + 30)
                yMenuLocation = 50
            Else
                xMenuLocation -= (2 + xMenu + 15 + xMenu2 + yMenu + (2 * buttonSpace))
                yMenuLocation = yMenuLocation + yMenu + buttonSpace
            End If
        Next

    End Sub

    Private Sub prepCheckBox_Changed(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim oRow As DataRow
        Dim dRow As DataRow
        Dim currentPrepID As Integer

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID")
        prepDrinkUpdated = True

        ' we ENTER before we change state
        ' this is backwards on purpose, we are changing to Unchecked
        If sender.checked = True Then
            For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
                If dRow("DrinkPrepID") = currentPrepID Then
                    dRow("Active") = False
                    Exit For
                End If
            Next

        Else
            For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
                If dRow("DrinkPrepID") = currentPrepID Then
                    dRow("Active") = True
                    prepPriceText(sender.name).Text = dRow("DrinkPrepPrice")
                    If Not dRow("DrinkPrepOrder") = 999999 Then
                        prepOrderByText(sender.name).Text = dRow("DrinkPrepOrder")
                    End If
                    If Not dRow("InvMultiplier") = 1 Then
                        prepInvMultiplier(sender.name).Text = dRow("InvMultiplier")
                    End If
                    If dRow("DrinkPrepMethod") = "USdol" Then
                        prepMethod(sender.name).Text = "$"
                    ElseIf dRow("DrinkPrepMethod") = "percent" Then
                        prepMethod(sender.name).Text = "%"
                    End If
                    Exit Sub
                End If
            Next

            'we must need to add row to DrinkPrepLocation
            oRow = dsSetup.Tables("DrinkPrepLocation").NewRow

            oRow("CompanyID") = corpID
            oRow("LocationID") = selectedLocation
            oRow("DrinkPrepID") = currentPrepID
            If lastPrepMethod = "USdol" Then
                oRow("DrinkPrepMethod") = "USdol"
                prepMethod(sender.name).Text = "$"
            Else
                oRow("DrinkPrepMethod") = "percent"
                prepMethod(sender.name).Text = "%"
            End If
            If prepPriceText(sender.name).Text = "" Then
                oRow("DrinkPrepPrice") = 0
            Else
                oRow("DrinkPrepPrice") = CType(prepPriceText(sender.name).Text, Decimal)
            End If
            oRow("Active") = 1
            If prepOrderByText(sender.name).Text = "" Then
                oRow("DrinkPrepOrder") = 999999
            Else
                oRow("DrinkPrepOrder") = CType(prepOrderByText(sender.name).Text, Integer)
            End If
            If prepOrderByText(sender.name).Text = "" Then
                oRow("InvMultiplier") = 1
            Else
                oRow("InvMultiplier") = CType(prepInvMultiplier(sender.name).Text, Integer)
            End If

            dsSetup.Tables("DrinkPrepLocation").Rows.Add(oRow)
            oRow("DrinkPrepLocationID") = InsertingNewDrinkPrep(oRow)
            dsSetup.Tables("DrinkPrepLocation").AcceptChanges()

        End If

    End Sub


    Private Sub prepMethod_Clicked(ByVal sender As Object, ByVal e As EventArgs) ' Handles prepMethod.DoubleClick
        Dim currentPrepID As Integer
        Dim dRow As DataRow

        If sender.text = "" Then Exit Sub

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID")
        prepDrinkUpdated = True

        For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
            If dRow("DrinkPrepID") = currentPrepID Then
                If dRow("DrinkPrepMethod") = "USdol" Then
                    dRow("DrinkPrepMethod") = "percent"
                    sender.Text = "%"
                    lastPrepMethod = "percent"
                    '      Format(prepPriceText(sender.name), decimal)
                ElseIf dRow("DrinkPrepMethod") = "percent" Then
                    dRow("DrinkPrepMethod") = "USdol"
                    sender.Text = "$"
                    lastPrepMethod = "USdol"
                End If
                Exit Sub
            End If
        Next

    End Sub


    Private Sub prepPriceText_Changed(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        Dim currentPrepID As Integer
        Dim dRow As DataRow
        Dim isValid As Boolean

        isValid = ValidateNumeric(sender, False)

        If isValid = False Then Exit Sub

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID")
        prepDrinkUpdated = True

        For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
            If dRow("DrinkPrepID") = currentPrepID Then
                dRow("DrinkPrepPrice") = CType(sender.text, Decimal)
                Exit Sub
            End If
        Next

    End Sub

    Private Sub prepOrderByText_Changed(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        Dim currentPrepID As Integer
        Dim dRow As DataRow
        Dim newPrepOrder As Integer

        If IsNumeric(sender.Text) = False Then
            newPrepOrder = 999999
            sender.text = ""
        Else
            sender.text = CInt(sender.text)
            newPrepOrder = sender.text
        End If

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID")
        prepDrinkUpdated = True

        For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
            If dRow("DrinkPrepID") = currentPrepID Then
                dRow("DrinkPrepOrder") = newPrepOrder
                Exit Sub
            End If
        Next

    End Sub

    Private Sub prepInvMultiplier_Changed(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        '**********
        Exit Sub

        Dim currentPrepID As Integer
        Dim dRow As DataRow
        Dim newPrepOrder As Integer

        If IsNumeric(sender.Text) = False Then
            newPrepOrder = 999999
            sender.text = ""
        Else
            sender.text = CInt(sender.text)
            newPrepOrder = sender.text
        End If

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID")
        prepDrinkUpdated = True

        For Each dRow In dsSetup.Tables("DrinkPrepLocation").Rows
            If dRow("DrinkPrepID") = currentPrepID Then
                dRow("DrinkPrepOrder") = newPrepOrder
                Exit Sub
            End If
        Next

    End Sub

    Private Function InsertingNewDrinkPrep(ByRef orow As DataRow)
        Dim newDrinkPrepID As Integer

        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepID").Value = orow("DrinkPrepID")
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepMethod").Value = orow("DrinkPrepMethod")
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepPrice").Value = orow("DrinkPrepPrice")
        '     sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepCost").Value = 0
        '    sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepManual").Value = 0
        '   sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@TaxID").Value = DBNull.Value
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@Active").Value = orow("Active")
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepOrder").Value = orow("DrinkPrepOrder")
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@InvMultiplier").Value = orow("InvMultiplier")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newDrinkPrepID = CType(sql.SqlInsertCommandMenuDrinkPrepLocation.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        Return newDrinkPrepID

    End Function

    Private Sub UpdateDrinkPrep()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuDrinkPrepLocation.Update(dsSetup, "DrinkPrepLocation")
            sql.cn.Close()
            dsSetup.Tables("DrinkPrepLocation").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

        prepDrinkUpdated = False

    End Sub

    Private Sub LeaveDrinkPrepTab(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabDrinkPrep.Leave

        If prepDrinkUpdated = True Then
            UpdateDrinkPrep()
        End If

    End Sub




    Private Sub btnDrinkPrices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrinkPrices.Click

        Try
            dsSetup.Tables("DrinkModifiers").Rows(0)("DrinkPrice") = CType(Me.txtDrinkDouble.Text, Single)
        Catch ex As Exception
            dsSetup.Tables("DrinkModifiers").Rows(0)("DrinkPrice") = 0
        End Try

        Try
            dsSetup.Tables("DrinkModifiers").Rows(1)("DrinkPrice") = CType(Me.txtDrinkRocks.Text, Single)
        Catch ex As Exception
            dsSetup.Tables("DrinkModifiers").Rows(1)("DrinkPrice") = 0
        End Try

        Try
            dsSetup.Tables("DrinkModifiers").Rows(2)("DrinkPrice") = CType(Me.txtDrinkUp.Text, Single)
        Catch ex As Exception
            dsSetup.Tables("DrinkModifiers").Rows(2)("DrinkPrice") = 0
        End Try

        Try
            dsSetup.Tables("DrinkModifiers").Rows(3)("DrinkPrice") = CType(Me.txtDrinkTall.Text, Single)
        Catch ex As Exception
            dsSetup.Tables("DrinkModifiers").Rows(3)("DrinkPrice") = 0
        End Try

        Try
            dsSetup.Tables("DrinkModifiers").Rows(4)("DrinkPrice") = CType(Me.txtDrinkSplash.Text, Single)
        Catch ex As Exception
            dsSetup.Tables("DrinkModifiers").Rows(4)("DrinkPrice") = 0
        End Try

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuDrinkModifiers.Update(dsSetup, "DrinkModifiers")
            sql.cn.Close()
            dsSetup.Tables("DrinkModifiers").AcceptChanges()

        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        Me.btnDrinkPrices.ForeColor = Color.Black
        '444    DisplayDrinkModifiers()

    End Sub


    '********************************************************************
    '   Menu
    '********************************************************************

    Private Sub DisplayMenuSelectionPanel()

        Dim index As Integer
        '      newMenu = New ActiveMenu


        numberOfMenuSelections = GetButtonCount("Menus")
        If numberOfMenuSelections > 10 Then ReDim menuActive(20)
        Dim xMenu As Integer = 96
        Dim yMenu As Integer = 24
        Dim yMenuLocation As Integer = 5 * buttonSpace

        menuActiveBox.Size = New Size(xMenu + 8, ((yMenu + buttonSpace) * (numberOfMenuSelections + 3) + (5 * buttonSpace)))

        If numberOfMenuSelections > 0 Then
            For index = 0 To numberOfMenuSelections - 1
                menuActive(index) = New CustomCheckBox
                With menuActive(index)
                    .Text = dsSetup.Tables("Menus").Rows(index)("MenuName")
                    .ID = dsSetup.Tables("Menus").Rows(index)("MenuID")
                    If dsSetup.Tables("Menus").Rows(index)("Active") = True Then
                        menuActive(index).Checked = True
                    End If
                    .Size = New Size(xMenu, yMenu)
                    .Location = New Point(buttonSpace, yMenuLocation)

                    AddHandler menuActive(index).Click, AddressOf MenuActive_Click

                End With
                menuActiveBox.Controls.Add(menuActive(index))
                yMenuLocation = yMenuLocation + yMenu + buttonSpace
            Next
        End If

        btnMenuAdd.Text = "Enter New Menu"
        btnMenuAdd.Size = New Size(xMenu, (2 * yMenu))
        btnMenuAdd.Location = New Point(buttonSpace, yMenuLocation)
        yMenuLocation = yMenuLocation + (2 * yMenu) + buttonSpace
        txtMenuUpdate.Size = New Size(xMenu, (1.5 * yMenu))
        txtMenuUpdate.Location = New Point(buttonSpace, yMenuLocation)

        menuActiveBox.Controls.Add(btnMenuAdd)
        menuActiveBox.Controls.Add(txtMenuUpdate)

        '        Dim pnlMenuUpdate As Panel
        '        pnlMenuUpdate.Size = New Size(xMenu + 8, yMenu * 2 + 3 * buttonSpace)


    End Sub

    Private Sub ButtonMenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuAdd.Click

        BtnUpdateMenu_Click()
        txtMenuUpdate.Clear()
        newMenu.ActiveMenuID = Nothing
        newMenu.ActiveMenuName = Nothing

    End Sub

    Private Sub MenuActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objBox As Object = CType(sender, Object)

        txtMenuUpdate.Text = objBox.text
        newMenu.ActiveMenuID = objBox.id
        newMenu.ActiveMenuName = objBox.text

        updatedMenu = True

    End Sub

    Private Sub TextMenu_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMenuUpdate.TextChanged
        newMenu.ActiveMenuName = txtMenuUpdate.Text

        updatedMenu = True

    End Sub

    Private Sub BtnUpdateMenu_Click() '(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtMenuUpdate.Text.Length = 0 Then
            Dim info As DataSet_Builder.Information_UC
            info = New DataSet_Builder.Information_UC("Please enter a menu name.")
            info.Location = New Point((Me.Width - info.Width) / 2, (Me.Height - info.Height) / 2)
            Me.Controls.Add(info)
            info.BringToFront()
            Exit Sub
        End If

        Dim oRow As DataRow
        Dim newMenuID As Integer

        If Not newMenu.ActiveMenuID = Nothing Then
            For Each oRow In dsSetup.Tables("Menus").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If oRow("MenuID") = newMenu.ActiveMenuID Then
                        oRow("CompanyID") = corpID
                        oRow("LocationID") = selectedLocation
                        oRow("MenuName") = newMenu.ActiveMenuName
                        oRow("LastOrder") = dsSetup.Tables("Menus").Rows.Count
                        Try
                            sql.cn.Open()
                            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                            sql.SqlMenuMenuChoice.Update(dsSetup, "Menus")
                            sql.cn.Close()
                            dsSetup.Tables("Menus").AcceptChanges()
                        Catch ex As Exception
                            CloseConnection()
                        End Try

                        UpdateMenuPanel()
                        PopulateMenuSelectionComboBox()
                        DisplayMenuCostGroupBox()

                    End If
                End If
            Next
        Else
            oRow = dsSetup.Tables("Menus").NewRow
            oRow("CompanyID") = corpID
            oRow("LocationID") = selectedLocation
            oRow("MenuName") = newMenu.ActiveMenuName
            oRow("LastOrder") = DBNull.Value '  dsSetup.Tables("Menus").Rows.Count
            oRow("AutoChange") = DBNull.Value
            oRow("Active") = 1

            dsSetup.Tables("Menus").Rows.Add(oRow)
            oRow("MenuID") = InsertingNewMenu(oRow)
            dsSetup.Tables("Menus").AcceptChanges()

            DisplayMenuSelectionPanel()
            '      UpdateNewMenuPanel()
            PopulateMenuSelectionComboBox()
            DisplayMenuCostGroupBox()
        End If

    End Sub
    Private Function InsertingNewMenu(ByRef orow As DataRow)
        Dim newMenuID As Integer

        sql.SqlInsertCommandMenuMenuChoice.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@MenuName").Value = orow("MenuName")
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@LastOrder").Value = orow("LastOrder")
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@AutoChange").Value = orow("AutoChange")
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@Active").Value = 1

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newMenuID = CType(sql.SqlInsertCommandMenuMenuChoice.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newMenuID

    End Function

    Private Sub UpdateMenuPanel()
        Dim index As Integer

        For index = 0 To (numberOfMenuSelections - 1)
            If menuActive(index).ID = newMenu.ActiveMenuID Then
                menuActive(index).Text = newMenu.ActiveMenuName
            End If
        Next

    End Sub

    Private Sub DisplayMenuPages()

        Dim btnWidth As Integer = 125
        Dim btnheight As Integer = 35
        pnlMenuPage1.Size = New System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace)
        pnlMenuPage2.Size = New System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace)

        Dim index As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace

        For index = 1 To 10
            btnMenu(index) = New OrderButton
            With btnMenu(index)
                .Size = New Size(btnWidth, btnheight)
                .Location = New Point(x, y)
                .TabStop = False
                .BtnIndex = index
                .Text = Nothing
                pnlMenuPage1.Controls.Add(btnMenu(index))
                AddHandler btnMenu(index).Click, AddressOf UpdateMenuOrderIndex
            End With
            y = y + btnheight + buttonSpace
        Next


        y = buttonSpace
        For index = 11 To 20
            btnMenu(index) = New OrderButton
            With btnMenu(index)
                .Size = New Size(btnWidth, btnheight)
                .Location = New Point(x, y)
                .TabStop = False
                .BtnIndex = index

                pnlMenuPage2.Controls.Add(btnMenu(index))
                AddHandler btnMenu(index).Click, AddressOf UpdateMenuOrderIndex
            End With
            y = y + btnheight + buttonSpace
        Next

    End Sub

    Private Sub btnMenuBartender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuBartender.Click

        If updatedMenu = True Then
            SaveMenuChanges()
            updatedMenu = False
        End If

        If updatedMenuDetail = True Then
            SaveMenuDetail()
            updatedMenuDetail = False
        End If

        If Me.bartnerderMenuMode = "Table Service" Then
            'next is bartender
            '      Me.btnMenuBartender.BackColor = Color.Red
            Me.bartnerderMenuMode = "Bartender"
            Me.btnMenuBartender.Text = "Bartender"

            PopulateMenuSelection()
            AssignNextAvailButton()
        ElseIf Me.bartnerderMenuMode = "Bartender" Then
            'next is Quick Service
            '     Me.btnMenuBartender.BackColor = SystemColors.Desktop
            Me.bartnerderMenuMode = "Quick Service"
            Me.btnMenuBartender.Text = "Quick Service"

            PopulateMenuSelection()
            AssignNextAvailButton()
        ElseIf Me.bartnerderMenuMode = "Quick Service" Then
            'next is Table Service
            Me.bartnerderMenuMode = "Table Service"
            Me.btnMenuBartender.Text = "Table Service"

            PopulateMenuSelection()
            AssignNextAvailButton()
        End If

        '       If Me.bartnerderMenuMode = False Then
        '      Me.btnMenuBartender.BackColor = Color.Red
        '     Me.bartnerderMenuMode = True
        '       PopulateMenuSelection()
        '       AssignNextAvailButton()
        '       Else
        '           Me.btnMenuBartender.BackColor = SystemColors.Desktop
        '           Me.bartnerderMenuMode = False'
        '            PopulateMenuSelection()
        '            AssignNextAvailButton()
        '        End If

    End Sub

    Private Sub cbxMenuSelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMenuSelection.SelectionChangeCommitted

        If updatedMenu = True Then
            SaveMenuChanges()
            updatedMenu = False
        End If

        If updatedMenuDetail = True Then
            SaveMenuDetail()
            updatedMenuDetail = False
        End If

        valueMenuID = dsSetup.Tables("Menus").Rows(cbxMenuSelection.SelectedIndex)("MenuID")
        valueMenuName = dsSetup.Tables("Menus").Rows(cbxMenuSelection.SelectedIndex)("MenuName")
        valueMenuActive = dsSetup.Tables("Menus").Rows(cbxMenuSelection.SelectedIndex)("Active")
        If valueMenuActive = False Then
            valueMenuName = valueMenuName & "  ** INACTIVE **"
        End If

        PopulateMenuSelection()
        AssignNextAvailButton()

    End Sub

    Friend Sub PopulateMenuSelection()


        Dim tempCommandStringFoods As String = sql.SqlSelectCommandMenuMenuFoods.CommandText
        Dim tempCommandStringDrinks As String = sql.SqlSelectCommandMenuMenuDrinks.CommandText

        Dim oRow As DataRow
        Dim index As Integer = 1

        '   not sure about next stmt  ***************
        '       newMenu = New ActiveMenu

        dsSetup.Tables("MenuDetail").Clear()

        '        sql.SqlSelectCommandMenus.Parameters("@CompanyID").Value = corpID
        If usingDefaults = True Then
            sql.SqlSelectCommandMenuMenuFoods.Parameters("@LocationID").Value = "000000"
            sql.SqlSelectCommandMenuMenuDrinks.Parameters("@LocationID").Value = "000000"

        Else
            sql.SqlSelectCommandMenuMenuFoods.Parameters("@LocationID").Value = selectedLocation '"000000"
            sql.SqlSelectCommandMenuMenuDrinks.Parameters("@LocationID").Value = selectedLocation '"000000"

        End If

        If Me.bartnerderMenuMode = "Table Service" Then


            sql.SqlSelectCommandMenuMenuFoods.CommandText = sql.SqlSelectCommandMenuMenuFoods.CommandText + " AND MenuDetail.MenuID = '" & valueMenuID & "' ORDER BY MenuDetail.OrderIndex"
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = sql.SqlSelectCommandMenuMenuDrinks.CommandText + " AND MenuDetail.MenuID = '" & valueMenuID & "' ORDER BY MenuDetail.OrderIndex"

        ElseIf Me.bartnerderMenuMode = "Bartender" Then

            sql.SqlSelectCommandMenuMenuFoods.CommandText = sql.SqlSelectCommandMenuMenuFoods.CommandText + " AND MenuDetail.BartenderMenuID = '" & valueMenuID & "' ORDER BY MenuDetail.OrderIndex"
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = sql.SqlSelectCommandMenuMenuDrinks.CommandText + " AND MenuDetail.BartenderMenuID = '" & valueMenuID & "' ORDER BY MenuDetail.OrderIndex"


        ElseIf Me.bartnerderMenuMode = "Quick Service" Then

            sql.SqlSelectCommandMenuMenuFoods.CommandText = sql.SqlSelectCommandMenuMenuFoods.CommandText + " AND MenuDetail.QuickMenuID = '" & valueMenuID & "' ORDER BY MenuDetail.OrderIndex"
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = sql.SqlSelectCommandMenuMenuDrinks.CommandText + " AND MenuDetail.QuickMenuID = '" & valueMenuID & "' ORDER BY MenuDetail.OrderIndex"

        End If
        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuMenuFoods.Fill(dsSetup.Tables("MenuDetail"))
            sql.SqlMenuMenuDrinks.Fill(dsSetup.Tables("MenuDetail"))

            sql.cn.Close()
            sql.SqlSelectCommandMenuMenuFoods.CommandText = tempCommandStringFoods
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = tempCommandStringDrinks
        Catch ex As Exception
            CloseConnection()
        End Try



        For index = 1 To 20
            btnMenu(index).Text = Nothing
            btnMenu(index).BackColor = Color.AliceBlue
        Next

        For Each oRow In dsSetup.Tables("MenuDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then

                If oRow("CategoryID") > 0 Then
                    btnMenu(oRow("OrderIndex")).Text = oRow("CategoryName").ToString
                ElseIf oRow("DrinkCategoryID") > 0 Then
                    btnMenu(oRow("OrderIndex")).Text = oRow("DrinkCategoryName").ToString
                ElseIf oRow("DrinkCategoryID") = -1 Then
                    btnMenu(oRow("OrderIndex")).Text = "Drinks"
                End If
                btnMenu(oRow("OrderIndex")).ID = oRow("MenuDetailID")
                btnMenu(oRow("OrderIndex")).BackColor = c1
                '          index += 1
            End If
        Next

        newMenu.ActiveMenuID = valueMenuID
        Me.lblMenuSetup.Text = valueMenuName

        '     AssignNextAvailButton()

        '     newMenu.dRow = dsSetup.Tables("MenuDetail").Rows(cbxMenuSelection.SelectedIndex)

    End Sub

    Private Sub AssignNextAvailButton()
        Dim index As Integer

        '   this picks next avail open button
        For index = 1 To 20
            If btnMenu(index).Text.Length = 0 Then
                btnMenu(index).BackColor = c1
                newMenu.ActiveMenuOrderIndex = index
                Exit For
            End If
        Next

        '        AddNewMenuRow(newMenu.ActiveMenuOrderIndex)

    End Sub

    Private Sub UpdateMenuOrderIndex(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlMenuPage1.Click, pnlMenuPage2.Click
        Dim objButton As OrderButton
        Dim oRow As DataRow
        Dim index As Integer

        '   resets color for non-populated buttons
        For index = 1 To 20
            If btnMenu(index).Text.Length = 0 Then
                btnMenu(index).BackColor = Color.AliceBlue
            End If
        Next

        Try
            objButton = CType(sender, OrderButton)

            newMenu.ActiveMenuOrderIndex = objButton.BtnIndex
            newMenu.ActiveDetialID = objButton.ID
            objButton.BackColor = c1

            '              For Each oRow In dsSetup.Tables("MenuDetail").Rows
            '          If oRow("OrderIndex") = objButton.BtnIndex Then
            '          newMenu.dRow = oRow
            '          Exit For
            ''         End If
            '             Next

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub AddNewMenuRow(ByVal index As Integer, ByVal catID As Integer, ByVal drkID As Integer)

        Dim oRow As DataRow

        oRow = dsSetup.Tables("MenuDetail").NewRow
        If Me.bartnerderMenuMode = "Table Service" Then
            oRow("MenuID") = newMenu.ActiveMenuID
            oRow("BartenderMenuID") = DBNull.Value
            oRow("QuickMenuID") = DBNull.Value

        ElseIf Me.bartnerderMenuMode = "Bartender" Then
            oRow("MenuID") = DBNull.Value
            oRow("BartenderMenuID") = newMenu.ActiveMenuID
            oRow("QuickMenuID") = DBNull.Value

        ElseIf Me.bartnerderMenuMode = "Quick Service" Then
            oRow("MenuID") = DBNull.Value
            oRow("BartenderMenuID") = DBNull.Value
            oRow("QuickMenuID") = newMenu.ActiveMenuID
        End If

        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("CategoryID") = catID
        oRow("DrinkCategoryID") = drkID
        oRow("OrderIndex") = index
        dsSetup.Tables("MenuDetail").Rows.Add(oRow)

    End Sub

    Private Sub UpdateMenuRow(ByVal index As Integer, ByVal catID As Integer, ByVal drkID As Integer)

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("MenuDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Or Not oRow.RowState = DataRowState.Added Then
                If oRow("MenuDetailID") = newMenu.ActiveDetialID Then

                    If Me.bartnerderMenuMode = "Table Service" Then
                        oRow("MenuID") = newMenu.ActiveMenuID
                        oRow("BartenderMenuID") = DBNull.Value
                        oRow("QuickMenuID") = DBNull.Value

                    ElseIf Me.bartnerderMenuMode = "Bartender" Then
                        oRow("MenuID") = DBNull.Value
                        oRow("BartenderMenuID") = newMenu.ActiveMenuID
                        oRow("QuickMenuID") = DBNull.Value

                    ElseIf Me.bartnerderMenuMode = "Quick Service" Then
                        oRow("MenuID") = DBNull.Value
                        oRow("BartenderMenuID") = DBNull.Value
                        oRow("QuickMenuID") = newMenu.ActiveMenuID
                    End If
                    oRow("CategoryID") = catID
                    oRow("DrinkCategoryID") = drkID
                    oRow("OrderIndex") = index
                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub cbxMenuMainFood_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMenuMainFood.SelectionChangeCommitted

        If newMenu.ActiveMenuID = Nothing Then
            MsgBox("You must First Select a Menu to Design")
            cbxMenuMainFood.SelectedIndex = -1
            Exit Sub
        End If
        '   ** not using below anymore
        If newMenu.ActiveMenuOrderIndex = Nothing Then
            MsgBox("You must first select a Category Button to Update")
            cbxMenuMainFood.SelectedIndex = -1
            Exit Sub
        End If

        Dim valueCatID As Integer
        Dim valueCatName As String

        valueCatID = dvFoodJoinMainFoodsCagtegory(cbxMenuMainFood.SelectedIndex)("CategoryID")
        valueCatName = dvFoodJoinMainFoodsCagtegory(cbxMenuMainFood.SelectedIndex)("CategoryName")

        If btnMenu(newMenu.ActiveMenuOrderIndex).Text.Length = 0 Then
            AddNewMenuRow(newMenu.ActiveMenuOrderIndex, valueCatID, 0)
        Else
            If valueCatID > 0 Then
                UpdateMenuRow(newMenu.ActiveMenuOrderIndex, valueCatID, 0)
            End If
        End If

        newMenu.ActiveMenuCategoryID = valueCatID
        newMenu.ActiveMenuDrinkCategoryID = 0   'Nothing
        btnMenu(newMenu.ActiveMenuOrderIndex).Text = valueCatName
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = c1

        '      newMenu.dRow("CategoryID") = newMenu.ActiveMenuCategoryID
        '     newMenu.dRow("DrinkCategoryID") = newMenu.ActiveMenuDrinkCategoryID

        updatedMenuDetail = True
        AssignNextAvailButton()

    End Sub

    Private Sub cbxMenuDrink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMenuDrink.SelectionChangeCommitted

        If newMenu.ActiveMenuID = Nothing Then
            MsgBox("You must First Select a Menu to Design")
            cbxMenuDrink.SelectedIndex = -1
            Exit Sub
        End If
        '   *** not using anymore
        If newMenu.ActiveMenuOrderIndex = Nothing Then
            MsgBox("You must first select a Category Button to Update")
            cbxMenuDrink.SelectedIndex = -1
            Exit Sub
        End If

        Dim oRow As DataRow
        Dim valueCatID As Integer
        Dim valueCatName As String
        Dim counter As Integer

        For Each oRow In dsSetup.Tables("DrinkCategory").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If Not oRow("DrinkCategoryName") Is DBNull.Value Then
                    If counter = Me.cbxMenuDrink.SelectedIndex Then
                        valueCatID = oRow("DrinkCategoryID")
                        valueCatName = oRow("DrinkCategoryName")
                        Exit For
                    End If
                    counter += 1
                End If
            End If
        Next

        If btnMenu(newMenu.ActiveMenuOrderIndex).Text.Length = 0 Then
            AddNewMenuRow(newMenu.ActiveMenuOrderIndex, 0, valueCatID)
        Else
            If valueCatID > 0 Then
                UpdateMenuRow(newMenu.ActiveMenuOrderIndex, 0, valueCatID)
            End If
        End If

        newMenu.ActiveMenuDrinkCategoryID = valueCatID
        newMenu.ActiveMenuCategoryID = 0    'Nothing

        btnMenu(newMenu.ActiveMenuOrderIndex).Text = valueCatName
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = c1

        '        newMenu.dRow("CategoryID") = newMenu.ActiveMenuCategoryID
        '       newMenu.dRow("DrinkCategoryID") = newMenu.ActiveMenuDrinkCategoryID

        updatedMenuDetail = True
        AssignNextAvailButton()

    End Sub

    Private Sub btnMenuGeneralDrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuGeneralDrink.Click
        If newMenu.ActiveMenuID = Nothing Then
            MsgBox("You must First Select a Menu to Design")
            Exit Sub
        End If
        If newMenu.ActiveMenuOrderIndex = Nothing Then
            MsgBox("You must first select a Category Button to Update")
            Exit Sub
        End If

        If btnMenu(newMenu.ActiveMenuOrderIndex).Text.Length = 0 Then
            AddNewMenuRow(newMenu.ActiveMenuOrderIndex, 0, generalDrinkCategoryID)
        Else
            UpdateMenuRow(newMenu.ActiveMenuOrderIndex, 0, generalDrinkCategoryID)
        End If

        newMenu.ActiveMenuDrinkCategoryID = generalDrinkCategoryID
        newMenu.ActiveMenuCategoryID = 0    'Nothing
        btnMenu(newMenu.ActiveMenuOrderIndex).Text = "Drink"
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = c1

        '       newMenu.dRow("CategoryID") = newMenu.ActiveMenuCategoryID
        '      newMenu.dRow("DrinkCategoryID") = newMenu.ActiveMenuDrinkCategoryID

        updatedMenuDetail = True
        AssignNextAvailButton()

    End Sub

    Private Sub SaveMenuDetail()

        '*******************************************
        'might have to keep this one setup like this
        'we pull from 2 different tables
        Dim adt As New SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuDetailID, MenuID, BartenderMenuID, QuickMenuID, CategoryID, DrinkCategoryID, OrderIndex FROM MenuDetail", sql.cn) ' WHERE MenuID = '" & newMenu.ActiveMenuID & "'", sql.cn)
        Dim cbd As New SqlClient.SqlCommandBuilder(adt)

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            adt.Update(dsSetup, "MenuDetail")
            sql.cn.Close()

            dsSetup.Tables("MenuDetail").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub btnRemoveMenuChoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveMenuChoices.Click

        If newMenu.ActiveMenuID = Nothing Then
            MsgBox("You must First Select a Menu to Update")
            Exit Sub
        End If
        If newMenu.ActiveMenuOrderIndex = Nothing Then
            MsgBox("You must first select a Category Button to Remove")
            Exit Sub
        End If

        SaveMenuDetail()
        PopulateMenuSelection()

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("MenuDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If Me.bartnerderMenuMode = "Table Service" Then
                    If oRow("MenuID") = newMenu.ActiveMenuID And oRow("OrderIndex") = newMenu.ActiveMenuOrderIndex Then
                        oRow.Delete()
                        Exit For
                    End If
                ElseIf Me.bartnerderMenuMode = "Bartender" Then
                    If oRow("BartenderMenuID") = newMenu.ActiveMenuID And oRow("OrderIndex") = newMenu.ActiveMenuOrderIndex Then
                        oRow.Delete()
                        Exit For
                    End If
                End If
            ElseIf Me.bartnerderMenuMode = "Quick Service" Then

            End If
        Next

        updatedMenuDetail = True

        newMenu.ActiveMenuCategoryID = Nothing
        newMenu.ActiveMenuDrinkCategoryID = Nothing
        btnMenu(newMenu.ActiveMenuOrderIndex).Text = Nothing
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = Color.White

    End Sub

    Private Sub TabMenuSetup_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMenuSetup.Enter

        Dim vRow As DataRowView

        dvFoodJoinMainFoodsCagtegory = New DataView
        With dvFoodJoinMainFoodsCagtegory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "Active = True AND (FunctionFlag = 'F' OR FunctionFlag = 'O' OR FunctionFlag = 'G')"
            .Sort = "FunctionID, CategoryOrder"
        End With

        Me.cbxMenuMainFood.Items.Clear()

        For Each vRow In dvFoodJoinMainFoodsCagtegory   'dsSetup.Tables("MainCategory").Rows
            Me.cbxMenuMainFood.Items.Add(vRow("CategoryName"))
        Next

    End Sub

    Private Sub TabMenuSetup_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMenuSetup.Leave

        If updatedMenu = True Then
            SaveMenuChanges()
            updatedMenu = False
        End If

        If updatedMenuDetail = True Then
            SaveMenuDetail()
            updatedMenuDetail = False
        End If

        dvFoodJoinMainFoodsCagtegory.Dispose()

    End Sub

    Private Sub SaveMenuChanges()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuMenuChoice.Update(dsSetup, "Menus")
            sql.cn.Close()
            dsSetup.Tables("Menus").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    '********************************************************
    '   Order Categories are for the Food Order By Category


    Private Sub CreateStagingPanel()

        Dim index As Integer = 1

        For index = 1 To 10
            DisplayStagingPanelForFoodItem(index, 0, Nothing, "", Nothing)
        Next

    End Sub

    Private Sub TabFoodOrder_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFoodOrder.Enter
        If Not Me.cbxOrderMenuSelection.SelectedIndex = -1 Then
            cbxOrderMenuSelection_SelectedIndexChanged(sender, e)
        End If

    End Sub

    Private Sub cbxOrderMenuSelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOrderMenuSelection.SelectedIndexChanged
        Dim valueMenuActive As Boolean
        Dim valueMenuName As String
      
        ''''   ccccc(newFoodOrder.CurrentCategory)

        newFoodOrder = New ActiveFoodOrder
        If isOrderQuickService = True Then
            newFoodOrder.MorePanels = 60
        Else
            newFoodOrder.MorePanels = 32
        End If

        newFoodOrder.CurrentMenu = dsSetup.Tables("Menus").Rows(Me.cbxOrderMenuSelection.SelectedIndex)("MenuID")
        valueMenuActive = dsSetup.Tables("Menus").Rows(cbxOrderMenuSelection.SelectedIndex)("Active")
        valueMenuName = cbxOrderMenuSelection.Text
        Me.cbxOrderSubCategroy.Visible = False

        If valueMenuActive = False Then
            valueMenuName = valueMenuName & "  ** INACTIVE **"
        End If

        Me.lblOrderMenuName.Text = valueMenuName


        '      Dim tempCommandString As String = sql.SqlSelectCommandMenus.CommandText
        Dim oRow As DataRow
        Dim index As Integer

        dsSetup.Tables("OrderMenuDetail").Clear()
        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlSelectCommandMenuDetail.Parameters("@CompanyID").Value = corpID
            If usingDefaults = True Then
                sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = "000000"
            Else
                sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = selectedLocation
            End If
            sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "G"
            sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "F"
            sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "O"
            sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Me.cbxOrderCategorySelection.Items.Clear()
        For Each oRow In dsSetup.Tables("OrderMenuDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                Me.cbxOrderCategorySelection.Items.Add(oRow("CategoryName"))
            End If
        Next
        Me.cbxOrderCategorySelection.Text = "Select Category"

        Me.lblOrderCategoryName.Text = ""
        Me.pnlOrderFoodItems.Controls.Clear()
        ClearTheRestOfStagingPage(1)


        dsSetup.Tables("OrderCategoryDetail").Clear()
        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlSelectMenuOrderCategory.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectMenuOrderCategory.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectMenuOrderCategory.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        '     sql.SqlSelectCommandCategoryDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategory
        sql.SqlMenuOrderCategory.Fill(dsSetup.Tables("OrderCategoryDetail"))
        sql.cn.Close()

        '       newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")
        '        If newFoodOrder.MaxIndex > 64 Then
        '        ReDim foodMenuJoinID(newFoodOrder.MaxIndex + 64)
        '        ReDim foodName(newFoodOrder.MaxIndex + 64)
        '        ReDim foodPrice(newFoodOrder.MaxIndex + 64)
        '        ReDim foodIndex(newFoodOrder.MaxIndex + 64)
        '       ReDim foodFoodID(newFoodOrder.MaxIndex + 64)
        ''       ReDim foodSurcharge(newFoodOrder.MaxIndex + 64)
        ''       ReDim foodRoutingID(newFoodOrder.MaxIndex + 64)
        '       ReDim foodDrinkID(newFoodOrder.MaxIndex + 64)
        '       ReDim foodGeneralMenuID(newFoodOrder.MaxIndex + 64)
        '       ReDim foodCurrentMenu(newFoodOrder.MaxIndex + 64)
        '      End If

    End Sub

    Private Sub cbxOrderCategorySelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOrderCategorySelection.SelectedIndexChanged
        Me.pnlOrderFoodItems.Controls.Clear()
        Dim oRow As DataRow
        Dim vRow As DataRowView

        If newFoodOrder.CurrentMenu = Nothing Then Exit Sub

        newFoodOrder.CurrentCategory = dsSetup.Tables("OrderMenuDetail").Rows(Me.cbxOrderCategorySelection.SelectedIndex)("CategoryID")
        newFoodOrder.FunFlag = dsSetup.Tables("OrderMenuDetail").Rows(Me.cbxOrderCategorySelection.SelectedIndex)("FunctionFlag")
        newFoodOrder.ExtendedDisplay = dsSetup.Tables("OrderMenuDetail").Rows(Me.cbxOrderCategorySelection.SelectedIndex)("Extended")

        If newFoodOrder.ExtendedDisplay = True Then
            newFoodOrder.MorePanels = 60
        Else
            newFoodOrder.MorePanels = 32
        End If

        If newFoodOrder.FunFlag = "G" Then
            '     dvCategory = New DataView
            '444    newFoodOrder.MorePanels = 60
            '444       Me.pnlOrderFoodItems.Height = 296

            With dvCategory
                .Table = dsSetup.Tables("OrderCategoryDetail")
                .RowFilter = "GeneralMenuID = " & newFoodOrder.CurrentCategory
            End With

            '         dvDrinkCats = New DataView
            With dvDrinkCats
                .Table = dsSetup.Tables("DrinkCategory")
                .RowFilter = "DrinkCategoryName IS NOT NULL"
            End With

            '444      With dvSubCategory
            '     .Table = dsSetup.Tables("OrderMenuDetail")
            '    .RowFilter = "NOT FunctionFlag = 'G'"
            '   End With

            '666
            dsSetup.Tables("OrderMenuDetailSecond").Clear()
            Try
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlSelectCommandMenuDetail.Parameters("@CompanyID").Value = corpID
                If usingDefaults = True Then
                    sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = "000000"
                Else
                    sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = selectedLocation
                End If
                sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "F"
                sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetailSecond"))
                sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "O"
                sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetailSecond"))
                sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "M"
                sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetailSecond"))
                sql.cn.Close()
            Catch ex As Exception
                CloseConnection()
            End Try

            newFoodOrder.FunFlagsub = "G"   'resets
            Me.cbxOrderSubCategroy.Visible = True
            Me.btnOrderAdd.Visible = False
            Me.btnOrderRemove.Visible = False

            Me.cbxOrderSubCategroy.Items.Clear()
            For Each oRow In dsSetup.Tables("OrderMenuDetailSecond").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    Me.cbxOrderSubCategroy.Items.Add(oRow("CategoryName"))
                End If
            Next
            '        For Each vRow In dvSubCategory
            '     Me.cbxOrderSubCategroy.Items.Add(vRow("CategoryName"))
            '    Next
            For Each vRow In dvDrinkCats
                Me.cbxOrderSubCategroy.Items.Add(vRow("DrinkCategoryName"))
            Next

            Me.cbxOrderSubCategroy.Text = "Select Sub Category"

            PopulateCategoryDetail()
            '       PopulateSubOrderDataFromTable()
            '    PopulateSubCategoryDetail()
        Else
            '444    newFoodOrder.MorePanels = 32
            '444         Me.pnlOrderFoodItems.Height = 376
            Me.cbxOrderSubCategroy.Visible = False
            '          Me.btnOrderAdd.Visible = True
            '         Me.btnOrderRemove.Visible = True
            Me.lblOrderCategoryName.Text = cbxOrderCategorySelection.Text
            newFoodOrder.CatIsDrink = False

            PopulateCategoryDetail()
        End If

    End Sub

    Private Sub PopulateCategoryDetail()
        newFoodOrderStagingIndex = 0

        '       dsSetup.Tables("OrderCategoryDetail").Clear()
        '       sql.cn.Open()
        '             sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        '       sql.SqlSelectCommandCategoryDetail.Parameters("@CompanyID").Value = corpID
        '    sql.SqlSelectCommandCategoryDetail.Parameters("@LocationID").Value = selectedLocation
        '       sql.SqlSelectCommandCategoryDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        '       '     sql.SqlSelectCommandCategoryDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategory
        '       sql.SqlMenuCategoryDetail.Fill(dsSetup.Tables("OrderCategoryDetail"))
        '      sql.cn.Close()

        Dim index As Integer
        Dim stagingPosition As Integer = 1
        newFoodOrder.PageIndex = 1
        '      newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")

        '      ReDim foodMenuJoinID(newFoodOrder.MaxIndex + 64)
        '      ReDim foodName(newFoodOrder.MaxIndex + 64)
        '      ReDim foodPrice(newFoodOrder.MaxIndex + 64)
        '      ReDim foodIndex(newFoodOrder.MaxIndex + 64)
        CreateStagingDataView()
        CreateOrderDataViews()

        If dvOrderMenu.Count > 0 Then
            newFoodOrder.MaxIndex = dvOrderMenu(dvOrderMenu.Count - 1)("MenuIndex")
        Else
            newFoodOrder.MaxIndex = 0
        End If

        '     If newFoodOrder.MaxIndex > 64 Then
        ReDim foodMenuJoinID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodName(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodPrice(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodIndex(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodFoodID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodSurcharge(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodRoutingID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodDrinkID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodGeneralMenuID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        ReDim foodCurrentMenu(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
        '    End If

        PopulateOrderDataFromTable()
        DisplayCategoryPage(newFoodOrder.PageIndex)
        DisplayStagingPage(newFoodOrderStagingIndex)       ' 1 is for the start (might be 0)?

    End Sub


    Private Sub cbxOrderSubCategroy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOrderSubCategroy.SelectedIndexChanged
        If newFoodOrder.CurrentMenu = Nothing Then Exit Sub

        '"OrderMenuDetail" needs to include drink categories too
        If Me.cbxOrderSubCategroy.SelectedIndex > dsSetup.Tables("OrderMenuDetailSecond").Rows.Count - 1 Then '(dsSetup.Tables("OrderMenuDetail").Rows.Count - 1) Then
            newFoodOrder.CatIsDrink = True
            newFoodOrder.CurrentCategorySub = dvDrinkCats(Me.cbxOrderSubCategroy.SelectedIndex - dsSetup.Tables("OrderMenuDetailSecond").Rows.Count)("DrinkCategoryID")
            newFoodOrder.FunFlagsub = "D"
        Else
            newFoodOrder.CatIsDrink = False
            newFoodOrder.CurrentCategorySub = dsSetup.Tables("OrderMenuDetailSecond").Rows(Me.cbxOrderSubCategroy.SelectedIndex)("CategoryID")
            newFoodOrder.FunFlagsub = dsSetup.Tables("OrderMenuDetailSecond").Rows(Me.cbxOrderSubCategroy.SelectedIndex)("FunctionFlag")

        End If

        If newFoodOrder.FunFlagsub = "G" Then
            PopulateSubCategoryDetail()
            Exit Sub
        Else
            Me.lblOrderCategoryName.Text = cbxOrderSubCategroy.Text

            PopulateSubCategoryDetail()
        End If

    End Sub


    Private Sub PopulateSubCategoryDetail()

        newFoodOrderStagingIndex = 0

        '      dsSetup.Tables("OrderCategoryDetail").Clear()
        '      dsSetup.Tables("OrderAllMenuDetail").Clear()
        '      sql.cn.Open()
        '            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        '      sql.SqlSelectCommandCategoryDetail.Parameters("@CompanyID").Value = corpID
        '      sql.SqlSelectCommandCategoryDetail.Parameters("@LocationID").Value = selectedLocation
        '      sql.SqlSelectCommandCategoryDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        '      sql.SqlSelectCommandCategoryDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategorySub
        '     sql.SqlMenuCategoryDetail.Fill(dsSetup.Tables("OrderCategoryDetail"))
        '
        '        sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CompanyID").Value = corpID
        '        sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@LocationID").Value = selectedLocation
        '        sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        ''       '     sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategorySub
        '       sql.SqlMenuOrderAllMenuDetail.Fill(dsSetup.Tables("OrderAllMenuDetail"))
        '      sql.cn.Close()

        '    Dim index As Integer
        '   Dim stagingPosition As Integer = 1
        '      newFoodOrder.PageIndex = 1
        '     newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")

        '        ReDim foodMenuJoinID(newFoodOrder.MaxIndex + 64)
        '       ReDim foodName(newFoodOrder.MaxIndex + 64)
        '      ReDim foodPrice(newFoodOrder.MaxIndex + 64)
        '     ReDim foodIndex(newFoodOrder.MaxIndex + 64)


        '    PopulateSubOrderDataFromTable()
     
        CreateStagingDataView()
        '      PopulateOrderDataFromTable()
        '     DisplayCategoryPage(newFoodOrder.PageIndex)
        DisplayStagingPage(newFoodOrderStagingIndex)       ' 1 is for the start (might be 0)?

    End Sub



    Private Sub PopulateOrderDataFromTable()
        Dim oRow As DataRowView
        Dim i As Integer

        'this can be more effiecient
        For i = 0 To newFoodOrder.MaxIndex + newFoodOrder.MorePanels
            foodMenuJoinID(i) = Nothing
            foodName(i) = ""
            foodPrice(i) = Nothing
            foodIndex(i) = Nothing
            foodFoodID(i) = Nothing
            foodSurcharge(i) = Nothing
            foodRoutingID(i) = Nothing
            foodDrinkID(i) = Nothing
            foodGeneralMenuID(i) = Nothing
            foodCurrentMenu(i) = Nothing

        Next


        '   change this to for 1 to 32 type of for stmt, 32 to 62 for 2nd page...
        For Each oRow In dvOrderMenu 'dsSetup.Tables("OrderCategoryDetail").Rows
            '  If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
            foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID")
            foodPrice(oRow("MenuIndex")) = oRow("Price")

            If Not oRow("FoodID") Is DBNull.Value And Not oRow("FoodID") = 0 Then
                '             If oRow("AbrevFoodName") Is DBNull.Value Then
                '            MsgBox(oRow("FoodID"))
                '       End If
                foodName(oRow("MenuIndex")) = oRow("AbrevFoodName")
                foodFoodID(oRow("MenuIndex")) = oRow("FoodID")
                foodDrinkID(oRow("MenuIndex")) = Nothing
            Else
                foodName(oRow("MenuIndex")) = oRow("DrinkName")
                foodFoodID(oRow("MenuIndex")) = Nothing
                foodDrinkID(oRow("MenuIndex")) = oRow("DrinkID")
            End If
            If Not oRow("Surcharge") Is DBNull.Value Then
                foodSurcharge(oRow("MenuIndex")) = oRow("Surcharge")
            Else
                foodSurcharge(oRow("MenuIndex")) = Nothing
            End If
            If Not oRow("RoutingID") Is DBNull.Value Then
                foodRoutingID(oRow("MenuIndex")) = oRow("RoutingID")
            Else
                foodRoutingID(oRow("MenuIndex")) = Nothing
            End If
            If Not oRow("GeneralMenuID") Is DBNull.Value Then
                foodGeneralMenuID(oRow("MenuIndex")) = oRow("GeneralMenuID")
            Else
                foodGeneralMenuID(oRow("MenuIndex")) = Nothing
            End If

            If Not oRow("MenuID") Is DBNull.Value Then
                foodCurrentMenu(oRow("MenuIndex")) = oRow("MenuID")
            Else
                foodCurrentMenu(oRow("MenuIndex")) = Nothing
            End If

            If oRow("MenuIndex") > 0 Then
                foodIndex(oRow("MenuIndex")) = oRow("MenuIndex")
            End If
            ' End If
        Next

    End Sub

    Private Sub PopulateSubOrderDataFromTable()
        Dim dRow As DataRow
        Dim oRow As DataRow
        '   change this to for 1 to 32 type of for stmt, 32 to 62 for 2nd page...

        '      dsSetup.Tables("OrderAllMenuDetail").Clear()
        '      sql.cn.Open()
        '            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        '      sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CompanyID").Value = corpID
        '     sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@LocationID").Value = selectedLocation
        '     sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        ''     '     sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategorySub
        '     sql.SqlMenuOrderAllMenuDetail.Fill(dsSetup.Tables("OrderAllMenuDetail"))
        '    sql.cn.Close()

        For Each oRow In dsSetup.Tables("OrderAllMenuDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID")
                foodName(oRow("MenuIndex")) = oRow("AbrevFoodName")
                foodPrice(oRow("MenuIndex")) = oRow("Price")
                foodBackColor(oRow("MenuIndex")) = oRow("ButtonColor")
                foodForeColor(oRow("MenuIndex")) = oRow("ButtonForeColor")

                If oRow("MenuIndex") > 0 Then
                    foodIndex(oRow("MenuIndex")) = oRow("MenuIndex")
                End If
            End If
        Next

    End Sub

    Private Sub DisplayCategoryPage(ByVal pageNumber As Integer)
        Dim index As Integer
        Dim startPosition As Integer
        Dim stopPosition As Integer
        Dim numPanels As Integer
        Dim position As Integer = 1     'position is actual panel (so always between 1 and 32)
        Me.pnlOrderFoodItems.Controls.Clear()

        '444       If Me.isOrderQuickService = True Then
        '        numPanels = 59
        '       Else
        '          numPanels = 31
        '     End If
        numPanels = newFoodOrder.MorePanels - 1

        If pageNumber = 1 Then
            startPosition = 1
            stopPosition = startPosition + numPanels
        ElseIf pageNumber > 1 Then
            startPosition = ((pageNumber - 1) * (numPanels + 1)) + 1   'this increases it by 30 every page
            stopPosition = startPosition + numPanels
        End If
        'resets any next or previous panels
        '       DisplayOrderCategories(1, 1, Nothing, "", Nothing)
        '      DisplayOrderCategories((numPanels + 1), 1, Nothing, "", Nothing)

        Me.pnlOrderFoodItems.SuspendLayout()
        Dim mi As Integer

        For index = startPosition To stopPosition
            '      If index = 32 Then
            '     MsgBox(index)
            '    End If

            mi = ((newFoodOrder.PageIndex - 1) * (numPanels + 1)) + position
            If pageNumber > 1 And index = startPosition Then
                DisplayOrderCategories(1, mi, -1, "Previous", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            ElseIf index = stopPosition And newFoodOrder.MaxIndex > index And isOrderQuickService = False Then
                ' this is the last panel on page 
                'must add 1 b/c the 1st of next page is the same as the last of this page
                DisplayOrderCategories((numPanels + 1), mi, -2, "Next", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                '         DisplayDummyPanel(32, "Next")

            Else        'will always be this for quick service and full page
                If foodIndex(index) > 0 Then
                    '444   If newFoodOrder.MorePanels = 60 Then
                    If newFoodOrder.FunFlag = "G" Then
                        DisplayOrderCategories(position, mi, foodMenuJoinID(index), foodName(index), foodPrice(index), foodFoodID(index), foodSurcharge(index), foodRoutingID(index), foodDrinkID(index), newFoodOrder.CurrentCategory, foodCurrentMenu(index))
                    Else
                        DisplayOrderCategories(position, mi, foodMenuJoinID(index), foodName(index), foodPrice(index), foodFoodID(index), foodSurcharge(index), foodRoutingID(index), foodDrinkID(index), 0, foodCurrentMenu(index))
                    End If
                Else
                    '   this might be the same as above : foodname is nothing if foodindex = 0
                    DisplayOrderCategories(position, mi, Nothing, "", Nothing, Nothing, Nothing, Nothing, Nothing, newFoodOrder.CurrentCategory, Nothing)
                End If
            End If

            position += 1
        Next

        Me.pnlOrderFoodItems.ResumeLayout()

    End Sub

    Private Sub DisplayOrderCategories(ByVal position As Integer, ByVal Index As Integer, ByVal menuJoinId As Integer, ByVal name As String, ByVal price As Decimal, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)
        Dim w As Single
        Dim h As Single
        Dim dTable As String '= "OrderCategoryDetail"

        '444     If isOrderQuickService = False Then
        '      dTable = "OrderCategoryDetail"
        '     Else
        '    dTable = "Quick"
        '   End If

        If newFoodOrder.MorePanels = 60 Then
            dTable = "Quick"
            w = ((Me.pnlOrderFoodItems.Width - 17) / 6)
            h = ((Me.pnlOrderFoodItems.Height - 33) / 10)
        Else
            dTable = "OrderCategoryDetail"
            w = ((Me.pnlOrderFoodItems.Width - 15) / 4)
            h = ((Me.pnlOrderFoodItems.Height - 27) / 8)
        End If

        Select Case position
            Case 1
                foodOrderPanel1 = New FoodOrderPanel(cs1, cs2, 1, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel1)
            Case 2
                foodOrderPanel2 = New FoodOrderPanel(cs1, cs2, 2, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel2)
            Case 3
                foodOrderPanel3 = New FoodOrderPanel(cs1, cs2, 3, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel3)
            Case 4
                foodOrderPanel4 = New FoodOrderPanel(cs1, cs2, 4, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel4)
            Case 5
                foodOrderPanel5 = New FoodOrderPanel(cs1, cs2, 5, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel5)
            Case 6
                foodOrderPanel6 = New FoodOrderPanel(cs1, cs2, 6, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel6)
            Case 7
                foodOrderPanel7 = New FoodOrderPanel(cs1, cs2, 7, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel7)
            Case 8
                foodOrderPanel8 = New FoodOrderPanel(cs1, cs2, 8, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel8)
            Case 9
                foodOrderPanel9 = New FoodOrderPanel(cs1, cs2, 9, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel9)
            Case 10
                foodOrderPanel10 = New FoodOrderPanel(cs1, cs2, 10, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel10)
            Case 11
                foodOrderPanel11 = New FoodOrderPanel(cs1, cs2, 11, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel11)
            Case 12
                foodOrderPanel12 = New FoodOrderPanel(cs1, cs2, 12, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel12)
            Case 13
                foodOrderPanel13 = New FoodOrderPanel(cs1, cs2, 13, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel13)
            Case 14
                foodOrderPanel14 = New FoodOrderPanel(cs1, cs2, 14, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel14)
            Case 15
                foodOrderPanel15 = New FoodOrderPanel(cs1, cs2, 15, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel15)
            Case 16
                foodOrderPanel16 = New FoodOrderPanel(cs1, cs2, 16, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel16)
            Case 17
                foodOrderPanel17 = New FoodOrderPanel(cs1, cs2, 17, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel17)
            Case 18
                foodOrderPanel18 = New FoodOrderPanel(cs1, cs2, 18, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel18)
            Case 19
                foodOrderPanel19 = New FoodOrderPanel(cs1, cs2, 19, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel19)
            Case 20
                foodOrderPanel20 = New FoodOrderPanel(cs1, cs2, 20, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel20)
            Case 21
                foodOrderPanel21 = New FoodOrderPanel(cs1, cs2, 21, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel21)
            Case 22
                foodOrderPanel22 = New FoodOrderPanel(cs1, cs2, 22, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel22)
            Case 23
                foodOrderPanel23 = New FoodOrderPanel(cs1, cs2, 23, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel23)
            Case 24
                foodOrderPanel24 = New FoodOrderPanel(cs1, cs2, 24, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel24)
            Case 25
                foodOrderPanel25 = New FoodOrderPanel(cs1, cs2, 25, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel25)
            Case 26
                foodOrderPanel26 = New FoodOrderPanel(cs1, cs2, 26, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel26)
            Case 27
                foodOrderPanel27 = New FoodOrderPanel(cs1, cs2, 27, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel27)
            Case 28
                foodOrderPanel28 = New FoodOrderPanel(cs1, cs2, 28, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel28)
            Case 29
                foodOrderPanel29 = New FoodOrderPanel(cs1, cs2, 29, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel29)
            Case 30
                foodOrderPanel30 = New FoodOrderPanel(cs1, cs2, 30, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel30)
            Case 31
                foodOrderPanel31 = New FoodOrderPanel(cs1, cs2, 31, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel31)
            Case 32
                foodOrderPanel32 = New FoodOrderPanel(cs1, cs2, 32, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel32)
            Case 33
                foodOrderPanel33 = New FoodOrderPanel(cs1, cs2, 33, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel33)
            Case 34
                foodOrderPanel34 = New FoodOrderPanel(cs1, cs2, 34, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel34)
            Case 35
                foodOrderPanel35 = New FoodOrderPanel(cs1, cs2, 35, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel35)
            Case 36
                foodOrderPanel36 = New FoodOrderPanel(cs1, cs2, 36, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel36)
            Case 37
                foodOrderPanel37 = New FoodOrderPanel(cs1, cs2, 37, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel37)
            Case 38
                foodOrderPanel38 = New FoodOrderPanel(cs1, cs2, 38, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel38)
            Case 39
                foodOrderPanel39 = New FoodOrderPanel(cs1, cs2, 39, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel39)
            Case 40
                foodOrderPanel40 = New FoodOrderPanel(cs1, cs2, 40, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel40)
            Case 41
                foodOrderPanel41 = New FoodOrderPanel(cs1, cs2, 41, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel41)
            Case 42
                foodOrderPanel42 = New FoodOrderPanel(cs1, cs2, 42, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel42)
            Case 43
                foodOrderPanel43 = New FoodOrderPanel(cs1, cs2, 43, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel43)
            Case 44
                foodOrderPanel44 = New FoodOrderPanel(cs1, cs2, 44, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel44)
            Case 45
                foodOrderPanel45 = New FoodOrderPanel(cs1, cs2, 45, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel45)
            Case 46
                foodOrderPanel46 = New FoodOrderPanel(cs1, cs2, 46, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel46)
            Case 47
                foodOrderPanel47 = New FoodOrderPanel(cs1, cs2, 47, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel47)
            Case 48
                foodOrderPanel48 = New FoodOrderPanel(cs1, cs2, 48, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel48)
            Case 49
                foodOrderPanel49 = New FoodOrderPanel(cs1, cs2, 49, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel49)
            Case 50
                foodOrderPanel50 = New FoodOrderPanel(cs1, cs2, 50, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel50)
            Case 51
                foodOrderPanel51 = New FoodOrderPanel(cs1, cs2, 51, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel51)
            Case 52
                foodOrderPanel52 = New FoodOrderPanel(cs1, cs2, 52, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel52)
            Case 53
                foodOrderPanel53 = New FoodOrderPanel(cs1, cs2, 53, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel53)
            Case 54
                foodOrderPanel54 = New FoodOrderPanel(cs1, cs2, 54, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel54)
            Case 55
                foodOrderPanel55 = New FoodOrderPanel(cs1, cs2, 55, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel55)
            Case 56
                foodOrderPanel56 = New FoodOrderPanel(cs1, cs2, 56, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel56)
            Case 57
                foodOrderPanel57 = New FoodOrderPanel(cs1, cs2, 57, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel57)
            Case 58
                foodOrderPanel58 = New FoodOrderPanel(cs1, cs2, 58, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel58)
            Case 59
                foodOrderPanel59 = New FoodOrderPanel(cs1, cs2, 59, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel59)
            Case 60
                foodOrderPanel60 = New FoodOrderPanel(cs1, cs2, 60, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                Me.pnlOrderFoodItems.Controls.Add(foodOrderPanel60)

        End Select

    End Sub

    Private Sub CreateStagingDataView()

        If newFoodOrder.FunFlag = "G" Then
            If newFoodOrder.FunFlagsub = "G" Then
                'this resets staging or beginning of general menu
                With dvOrderStaging
                    .Table = dsSetup.Tables("OrderCategoryDetail")
                    .RowFilter = "MenuIndex = 0 AND GeneralMenuID = " & newFoodOrder.CurrentCategory
                    .RowStateFilter = DataViewRowState.CurrentRows
                End With
            Else
                'fills staging with current sub category
                With dvOrderStaging

                    If newFoodOrder.CatIsDrink = True Then
                        .Table = dsSetup.Tables("Drinks")
                        .RowFilter = "DrinkCategoryID = " & newFoodOrder.CurrentCategorySub '& " AND (GeneralMenuID IS NULL OR NOT GeneralMenuID = " & newFoodOrder.CurrentCategory & ")"
                    Else
                        If newFoodOrder.FunFlag = "G" Then
                            '
                            .Table = dsSetup.Tables("OrderCategoryDetail")
                            '      .RowFilter = "MenuIndex = 0 AND CategoryID = " & newFoodOrder.CurrentCategorySub
                            '  .RowFilter = "CategoryID = '" & newFoodOrder.CurrentCategorySub & "' AND MenuIndex = 0 AND GeneralMenuID = '" & newFoodOrder.CurrentCategory & "'"
                            .RowFilter = "CategoryID = " & newFoodOrder.CurrentCategorySub & " AND (GeneralMenuID IS NULL OR GeneralMenuID = " & newFoodOrder.CurrentCategory & ")"
                            .Sort = "GeneralMenuID DESC"
                            'we are populating all without MenuIndex, but then later removing any dupolicated
                            'we must sort b/c we need to make sure we are dealing with the General Menu ID first
                            'we may have a foodItem w/o GMI and then we use this, this creates a entry with GMI
                        Else
                            'will never be here, this whole section is Sub under "G" Flag
                            .Table = dsSetup.Tables("OrderCategoryDetail")
                            .RowFilter = "CategoryID = " & newFoodOrder.CurrentCategorySub & " AND (GeneralMenuID IS NULL OR NOT GeneralMenuID = " & newFoodOrder.CurrentCategory & ")"

                        End If
                    End If
                    '        .RowFilter = "NOT GeneralMenuID = " & newFoodOrder.CurrentCategory
                    '    .RowFilter = "MenuIndex = 0 AND CategoryID = " & newFoodOrder.CurrentCategorySub
                    .RowStateFilter = DataViewRowState.CurrentRows
                End With
                '999 new, this is what is already displaying
                With dvCategory
                    .Table = dsSetup.Tables("OrderCategoryDetail")
                    ' .RowFilter = "(MenuIndex > 0 AND GeneralMenuID = " & newFoodOrder.CurrentCategory & ") OR GeneralMenuID IS NULL"
                    .RowFilter = "CategoryID = " & newFoodOrder.CurrentCategorySub & " AND MenuIndex > 0 AND GeneralMenuID = '" & newFoodOrder.CurrentCategory & "'"
                    '.RowFilter = "CategoryID = " & newFoodOrder.CurrentCategorySub & " AND MenuIndex > 0"
                End With
            End If

        Else
            'fills staging with current category
            With dvOrderStaging
                .Table = dsSetup.Tables("OrderCategoryDetail")
                .RowFilter = "MenuIndex = 0 AND GeneralMenuID IS NULL AND CategoryID = " & newFoodOrder.CurrentCategory
                .RowStateFilter = DataViewRowState.CurrentRows
            End With
        End If

    End Sub

    Private Sub CreateOrderDataViews()

        If newFoodOrder.FunFlag = "G" Then
            With dvOrderMenu
                .Table = dsSetup.Tables("OrderCategoryDetail")
                .RowFilter = "MenuIndex > 0 AND GeneralMenuID = " & newFoodOrder.CurrentCategory
                .RowStateFilter = DataViewRowState.CurrentRows
                .Sort = "MenuIndex"
            End With
        Else
            With dvOrderMenu
                .Table = dsSetup.Tables("OrderCategoryDetail")
                .RowFilter = "MenuIndex > 0 AND GeneralMenuID IS NULL AND CategoryID = " & newFoodOrder.CurrentCategory
                .RowStateFilter = DataViewRowState.CurrentRows
                .Sort = "MenuIndex"
            End With
        End If

    End Sub

    Private Sub DisplayStagingPanelForFoodItem(ByVal position As Integer, ByVal Index As Integer, ByVal menuJoinID As Integer, ByVal name As String, ByVal price As Decimal)
        Dim w As Single = Me.pnlOrderFoodStaging.Width - 6      '   spacing is 3 
        Dim h As Single = ((Me.pnlOrderFoodStaging.Height - 33) / 10)
        Dim dTable As String = "OrderCategoryDetail"

        'currently just displaying empty panels??????
        foodOrderStaging(position) = New FoodOrderPanel(cs1, cs2, position, w, h, Index, menuJoinID, name, price, True, dTable, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        AddHandler foodOrderStaging(position).BlankOldModifierPanel, AddressOf OrderMouseMove

        Me.pnlOrderFoodStaging.Controls.Add(foodOrderStaging(position))

    End Sub

    Private Sub DisplayStagingPage(ByVal dvIndex As Integer)

        '   go through each vRow as Dataview
        Dim dvCounter As Integer
        Dim position As Integer = 1
        Dim dvEnd As Integer = dvIndex + 7
        Dim vRow As DataRowView
        Dim cRow As DataRowView
        Dim isAlreadyDisplayed As Boolean
        Dim foodIDIndex As New ArrayList()
        Dim fID As Integer

        If dvIndex > 0 Then
            'this is for GMI, so we don't repeat them,
            'they are sorted with GMI > 0 at top
            For dvCounter = 0 To dvIndex - 1
                'for food only
                If newFoodOrder.CatIsDrink = False Then
                    vRow = dvOrderStaging(dvCounter)
                    foodIDIndex.Add(vRow("FoodID"))
                End If
            Next
        End If

        'dvcouter is zero based
        '444    For dvCounter = dvIndex To dvEnd
        '444If dvCounter + 1 > dvOrderStaging.Count Then Exit For

        For dvCounter = dvIndex To dvOrderStaging.Count - 1 'dvEnd
            If position > 8 Then Exit For


            vRow = dvOrderStaging(dvCounter)
            isAlreadyDisplayed = False

            If newFoodOrder.CatIsDrink = True Then
                If Not vRow("DrinkID") Is DBNull.Value Then
                    If newFoodOrder.FunFlag = "G" Then
                        '    skip if already displayed
                        For Each cRow In dvCategory
                            If Not cRow("DrinkID") Is DBNull.Value Then
                                If vRow("DrinkID") = cRow("DrinkID") Then
                                    isAlreadyDisplayed = True
                                End If
                            End If
                        Next
                    End If

                    If isAlreadyDisplayed = False Then
                        If newFoodOrder.FunFlag = "G" Then
                            foodOrderStaging(position).UpdateStagingPanel(0, vRow("DrinkName"), vRow("DrinkPrice"), Nothing, Nothing, Nothing, vRow("DrinkID"), newFoodOrder.CurrentCategory, newFoodOrder.CurrentMenu)
                        Else
                            foodOrderStaging(position).UpdateStagingPanel(0, vRow("DrinkName"), vRow("DrinkPrice"), Nothing, Nothing, Nothing, vRow("DrinkID"), 0, newFoodOrder.CurrentMenu)
                        End If
                        position += 1
                    End If
                End If

            Else
                If Not vRow("FoodID") Is DBNull.Value Then
                    If newFoodOrder.FunFlag = "G" Then
                        '    skip if already displayed
                        For Each cRow In dvCategory
                            If Not cRow("FoodID") Is DBNull.Value Then
                                If vRow("FoodID") = cRow("FoodID") Then
                                    isAlreadyDisplayed = True
                                End If
                            End If
                        Next
                        'does the same thing, but this one works better 
                        'for General Menu ID (b/c we need to display specific MenuJoinID
                        For Each fID In foodIDIndex
                            If vRow("FoodID") = fID Then
                                isAlreadyDisplayed = True
                            End If
                        Next
                    End If

                    If isAlreadyDisplayed = False Then
                        foodIDIndex.Add(vRow("FoodID"))

                        If newFoodOrder.FunFlag = "G" Then
                            foodOrderStaging(position).UpdateStagingPanel(vRow("MenuJoinID"), vRow("FoodName"), vRow("Price"), vRow("FoodID"), vRow("Surcharge"), vRow("RoutingID"), Nothing, newFoodOrder.CurrentCategory, newFoodOrder.CurrentMenu)
                        Else
                            foodOrderStaging(position).UpdateStagingPanel(vRow("MenuJoinID"), vRow("FoodName"), vRow("Price"), vRow("FoodID"), vRow("Surcharge"), vRow("RoutingID"), Nothing, 0, newFoodOrder.CurrentMenu)
                        End If
                        position += 1
                    End If
                End If
            End If

        Next

        ClearTheRestOfStagingPage(position)

    End Sub

    Private Sub ClearTheRestOfStagingPage(ByVal position As Integer)
        Dim index As Integer

        For index = position To 10
            foodOrderStaging(index).UpdateStagingPanel(Nothing, "", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Next

    End Sub


    Private Sub btnOrderUpdateStaging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderUpdateStaging.Click

        SaveUpdatedMenuOrderCategoryDetail()
        DisplayStagingPage(newFoodOrderStagingIndex)

    End Sub

    Private Sub UpdateOrderDetail222()
        'changed to SaveUpdatedOrderMenuDetail

        '*******************************************
        'might have to keep this one setup like this
        'we pull from 2 different tables

        Dim adt As New SqlClient.SqlDataAdapter("SELECT MenuJoinID, MenuIndex FROM MenuJoin", sql.cn)
        Dim cbd As New SqlClient.SqlCommandBuilder(adt)

        If dsSetup.HasChanges Then
            Try
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                adt.Update(dsSetup, "OrderCategoryDetail")
                sql.cn.Close()
                dsSetup.Tables("OrderCategoryDetail").AcceptChanges()

                '     DisplayStagingPage(newFoodOrder.StagingIndex)
                '         newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")
            Catch ex As Exception
                CloseConnection()
            End Try

        End If

    End Sub

    Private Sub OrderMouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles foodOrderPanel1.BlankOldModifierPanel, foodOrderPanel2.BlankOldModifierPanel, foodOrderPanel3.BlankOldModifierPanel, foodOrderPanel4.BlankOldModifierPanel, foodOrderPanel5.BlankOldModifierPanel, foodOrderPanel6.BlankOldModifierPanel, foodOrderPanel7.BlankOldModifierPanel, foodOrderPanel8.BlankOldModifierPanel, foodOrderPanel9.BlankOldModifierPanel, foodOrderPanel10.BlankOldModifierPanel, foodOrderPanel11.BlankOldModifierPanel, foodOrderPanel12.BlankOldModifierPanel, foodOrderPanel13.BlankOldModifierPanel, foodOrderPanel14.BlankOldModifierPanel, foodOrderPanel15.BlankOldModifierPanel, foodOrderPanel16.BlankOldModifierPanel, foodOrderPanel17.BlankOldModifierPanel, foodOrderPanel18.BlankOldModifierPanel, foodOrderPanel19.BlankOldModifierPanel, foodOrderPanel20.BlankOldModifierPanel, foodOrderPanel21.BlankOldModifierPanel, foodOrderPanel22.BlankOldModifierPanel, foodOrderPanel23.BlankOldModifierPanel, foodOrderPanel24.BlankOldModifierPanel, foodOrderPanel25.BlankOldModifierPanel, foodOrderPanel26.BlankOldModifierPanel, foodOrderPanel27.BlankOldModifierPanel, foodOrderPanel28.BlankOldModifierPanel, foodOrderPanel29.BlankOldModifierPanel, foodOrderPanel30.BlankOldModifierPanel, foodOrderPanel31.BlankOldModifierPanel, foodOrderPanel32.BlankOldModifierPanel, foodOrderPanel33.BlankOldModifierPanel, foodOrderPanel34.BlankOldModifierPanel, foodOrderPanel35.BlankOldModifierPanel, foodOrderPanel36.BlankOldModifierPanel, foodOrderPanel37.BlankOldModifierPanel, foodOrderPanel38.BlankOldModifierPanel, foodOrderPanel39.BlankOldModifierPanel, foodOrderPanel40.BlankOldModifierPanel, foodOrderPanel41.BlankOldModifierPanel, foodOrderPanel42.BlankOldModifierPanel, foodOrderPanel43.BlankOldModifierPanel, foodOrderPanel44.BlankOldModifierPanel, foodOrderPanel45.BlankOldModifierPanel, foodOrderPanel46.BlankOldModifierPanel, foodOrderPanel47.BlankOldModifierPanel, foodOrderPanel48.BlankOldModifierPanel, foodOrderPanel49.BlankOldModifierPanel, foodOrderPanel50.BlankOldModifierPanel, foodOrderPanel51.BlankOldModifierPanel, foodOrderPanel52.BlankOldModifierPanel, foodOrderPanel53.BlankOldModifierPanel, foodOrderPanel54.BlankOldModifierPanel, foodOrderPanel55.BlankOldModifierPanel, foodOrderPanel56.BlankOldModifierPanel, foodOrderPanel57.BlankOldModifierPanel, foodOrderPanel58.BlankOldModifierPanel, foodOrderPanel59.BlankOldModifierPanel, foodOrderPanel60.BlankOldModifierPanel ', FoodOrderStaging1.BlankOldModifierPanel, FoodOrderStaging2.BlankOldModifierPanel, FoodOrderStaging3.BlankOldModifierPanel, FoodOrderStaging4.BlankOldModifierPanel, FoodOrderStaging5.BlankOldModifierPanel, FoodOrderStaging6.BlankOldModifierPanel, FoodOrderStaging7.BlankOldModifierPanel, FoodOrderStaging8.BlankOldModifierPanel, FoodOrderStaging9.BlankOldModifierPanel, FoodOrderStaging10.BlankOldModifierPanel

        SaveUpdatedMenuOrderCategoryDetail()
        '    DisplayStagingPage(newFoodOrder.StagingIndex)

        If sender.DrinkID > 0 Then ' = "Drinks" Then
            currentDrinkPanelLast = CType(sender, FoodPanelControl)
            currentDrinkPanelLast.Text = ""
            currentDrinkPanelLast.DrinkID = 0
            currentDrinkPanelLast.FoodName = ""
            currentDrinkPanelLast.FoodPrice = 0
            updatedDrink = True
        End If

    End Sub

    Private Sub btnOrderUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderUp.Click
        If newFoodOrderStagingIndex > 0 Then
            newFoodOrderStagingIndex -= 1
            DisplayStagingPage(newFoodOrderStagingIndex)
        End If

    End Sub
    Private Sub btnOrderDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderDown.Click
        If newFoodOrderStagingIndex < dvOrderStaging.Count Then
            newFoodOrderStagingIndex += 1
            DisplayStagingPage(newFoodOrderStagingIndex)
        End If

    End Sub

    Private Sub FoodOrderPreviousPanelClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles foodOrderPanel1.MyPanelClick

        Dim currentOrderPanel As FoodPanelControl
        currentOrderPanel = CType(sender, FoodPanelControl)

        If currentOrderPanel.MenuJoinID = -1 Then
            SaveUpdatedMenuOrderCategoryDetail()
            newFoodOrder.PageIndex -= 1
            DisplayCategoryPage(newFoodOrder.PageIndex)
        End If

    End Sub

    Private Sub FoodOrderNextPanelClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles foodOrderPanel32.MyPanelClick ', foodOrderPanel60.MyPanelClick

        Dim currentOrderPanel As FoodPanelControl
        currentOrderPanel = CType(sender, FoodPanelControl)

        If currentOrderPanel.MenuJoinID = -2 Then
            SaveUpdatedMenuOrderCategoryDetail()
            newFoodOrder.PageIndex += 1
            DisplayCategoryPage(newFoodOrder.PageIndex)
        End If

    End Sub

    Private Sub btnOrderRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderRemove.Click
        Dim oRow As DataRow
        If cbxOrderCategorySelection.SelectedIndex = -1 Then
            Exit Sub
        End If
        Exit Sub    'currently not allowing more than one page
        ' so no reason to delete any

        For Each oRow In dsSetup.Tables("OrderCategoryDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If oRow("MenuIndex") > (newFoodOrder.PageIndex - 1) * 32 Then
                    MsgBox("You can not Remove a Page until all Food Items are located on Previous Pages or Staging.")
                    Exit Sub
                End If
            End If
        Next
        newFoodOrder.PageIndex -= 1
        '    newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")

        SaveUpdatedMenuOrderCategoryDetail()
        DisplayCategoryPage(newFoodOrder.PageIndex)

    End Sub

    Private Sub btnOrderAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderAdd.Click
        Dim oRow As DataRow
        '   ***     temp    not letting add more than one page
        '     If newFoodOrder.PageIndex = 2 Then Exit Sub
        If cbxOrderCategorySelection.SelectedIndex = -1 Then
            Exit Sub
        End If
        Exit Sub

        If newFoodOrder.FunFlag = "G" Then
            If foodOrderPanel60.foodPanel.MenuJoinID > 0 Then
                For Each oRow In dsSetup.Tables("OrderCategoryDetail").Rows
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If oRow("MenuJoinID") = Me.foodOrderPanel60.foodPanel.MenuJoinID Then
                            oRow("MenuIndex") = oRow("MenuIndex") + 2
                            Me.foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID")
                            Me.foodName(oRow("MenuIndex")) = oRow("AbrevFoodName")
                            Me.foodIndex(oRow("MenuIndex")) = oRow("MenuIndex")
                            Exit For
                        End If
                    End If
                Next
            End If
        Else
            If foodOrderPanel32.foodPanel.MenuJoinID > 0 Then
                For Each oRow In dsSetup.Tables("OrderCategoryDetail").Rows
                    If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                        If oRow("MenuJoinID") = Me.foodOrderPanel32.foodPanel.MenuJoinID Then
                            oRow("MenuIndex") = oRow("MenuIndex") + 2
                            Me.foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID")
                            Me.foodName(oRow("MenuIndex")) = oRow("AbrevFoodName")
                            Me.foodIndex(oRow("MenuIndex")) = oRow("MenuIndex")
                            Exit For
                        End If
                    End If
                Next
            End If

        End If

        newFoodOrder.MaxIndex += newFoodOrder.MorePanels
        SaveUpdatedMenuOrderCategoryDetail()

        If (newFoodOrder.PageIndex * newFoodOrder.MorePanels) > newFoodOrder.MaxIndex Then
            ReDim foodMenuJoinID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
            ReDim foodName(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
            ReDim foodPrice(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
            ReDim foodIndex(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)
            PopulateOrderDataFromTable()
        End If
        newFoodOrder.PageIndex += 1
        DisplayCategoryPage(newFoodOrder.PageIndex)

    End Sub

















    Private Sub grdJoinFoodModifierJoins_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdJoinFoodModifierJoins.CurrentCellChanged
        '      If dsSetup.HasChanges Then
        '     UpdateDatabaseFoodJoin()
        '    End If

    End Sub

    Private Sub grdJoinFoodCategoryJoins_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdJoinFoodCategoryJoins.CurrentCellChanged
        '      If dsSetup.HasChanges Then
        '     UpdateDatabaseFoodJoin()
        '    End If

    End Sub

    Private Sub menuCheckBox_Changed(ByVal sender As Object, ByVal e As System.EventArgs)

        menuBoxUpdated = True
        Dim menuID As Integer
        ' we ENTER before we change state
        ' this is backwards on purpose, we are changing to Unchecked
        If sender.checked = True Then
            Dim vRowDatabase As DataRow
            Dim vRow As DataRowView

            For Each vRow In dvActiveMenu
                If vRow("MenuName") = sender.text Then
                    menuID = vRow("MenuID")
                    Exit For
                End If
            Next
            For Each vRowDatabase In dsSetup.Tables("MenuJoin").Rows
                If vRowDatabase("MenuID") = menuID And vRowDatabase("FoodID") = newFood.ActiveFoodID Then
                    '444   vRowDatabase("Active") = False  'sender.Checked
                    vRowDatabase("MenuIndex") = 0
                End If
            Next
        End If

        '      UpdateMenuJoinDatabase()
    End Sub

    Private Sub menuCostBoxes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles menuCostGroupBox.Validating
        Dim objTextBox As TextBox

        Try
            objTextBox = CType(sender, TextBox)
        Catch ex As Exception
            Exit Sub
        End Try

        ValidateNumeric(objTextBox, False)

    End Sub

    '    Private Sub txtSurcharge_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) 
    '       ValidateNumeric(txtSurcharge, True)
    '  End Sub

    Private Function ValidateNumeric(ByRef txtValNumeric As TextBox, ByVal isSurcharge As Boolean)

        If txtValNumeric.Text = "" Then
            txtValNumeric.Text = CType(0, Decimal)
            '        Me.ErrorProvider1.SetError(txtValNumeric, "Is this item Free?")

        ElseIf Not IsNumeric(txtValNumeric.Text) Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a numeric value.")
            txtValNumeric.Text = CType(0, Decimal)
            txtValNumeric.Focus()
            Beep()
            If CType(txtValNumeric.Text, Decimal) = 0 Then
                If isSurcharge = True Then
                    '                Me.ErrorProvider1.SetError(txtValNumeric, "There is NO surcharge for this item.")
                Else
                    '               Me.ErrorProvider1.SetError(txtValNumeric, "Is this item Free?")
                End If
            End If
            Return False
        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
            Return True
            '            Me.ErrorProvider1.SetError(txtValNumeric, "")

        End If
    End Function


    Private Sub cbxTax_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        '222     ValidateNotBlank(Me.cbxFoodTax)

    End Sub

    Private Sub cbxCaqtegory_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFoodCategory.Validating

        ValidateNotBlank(Me.cbxFoodCategory)

    End Sub

    Private Sub cbxPrint_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxPrintPriority.Validating

        If Me.cbxPrintPriority.SelectedIndex = -1 Then
            Me.cbxPrintPriority.SelectedIndex = 2
        End If

        '   ValidateNotBlank(Me.cbxPrintPriority)

    End Sub
    Private Sub cbxRouting_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        '222      ValidateNotBlank(Me.cbxFoodRouting)

    End Sub

    Private Sub ValidateNotBlank(ByVal cbxValBlank As ComboBox)

        If cbxValBlank.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbxValBlank, "You must make a selection.")
            cbxValBlank.Focus()
            Beep()
        Else
            ErrorProvider1.Dispose()
            '  ErrorProvider1.SetError(cbxValBlank, "")

        End If

    End Sub

    Private Sub BtnUpdateMenuChoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateMenuChoices.Click
        '   *** don't need anymore
        SaveMenuDetail()

    End Sub







    Private Sub UpdateNewMenuPanel222()
        numberOfMenuSelections = GetButtonCount("Menus")
        Dim xMenu As Integer = 96
        Dim yMenu As Integer = 24
        Dim yMenuLocation As Integer = (2 * buttonSpace) + (yMenu + buttonSpace) * (numberOfMenuSelections - 1)

        menuActiveBox.Size = New Size(xMenu + 8, ((yMenu + buttonSpace) * (numberOfMenuSelections + 3) + (5 * buttonSpace)))
        '   menuActiveBox.Size = New Size(xMenu + 8, ((yMenu + buttonSpace) * (numberOfMenuSelections + 2) + (3 * buttonSpace)))

        menuActive(numberOfMenuSelections - 1) = New CustomCheckBox
        With menuActive(numberOfMenuSelections - 1)
            .Text = dsSetup.Tables("Menus").Rows(numberOfMenuSelections - 1)("MenuName")
            .ID = dsSetup.Tables("Menus").Rows(numberOfMenuSelections - 1)("MenuID")
            If dsSetup.Tables("Menus").Rows(numberOfMenuSelections - 1)("Active") = True Then
                menuActive(numberOfMenuSelections - 1).Checked = True
            End If
            .Size = New Size(xMenu, yMenu)
            .Location = New Point(buttonSpace, yMenuLocation)

            AddHandler menuActive(numberOfMenuSelections - 1).Click, AddressOf MenuActive_Click

        End With
        menuActiveBox.Controls.Add(menuActive(numberOfMenuSelections - 1))

        yMenuLocation = yMenuLocation + yMenu + buttonSpace
        btnMenuAdd.Location = New Point(buttonSpace, yMenuLocation)
        yMenuLocation = yMenuLocation + yMenu + buttonSpace
        txtMenuUpdate.Location = New Point(buttonSpace, yMenuLocation)

    End Sub









    'below is needed for ICollection
    ' i don't know why we have ICollection though

    Public Sub CopyTo(ByVal array As System.Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo

    End Sub

    Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
        Get

        End Get
    End Property

    Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
        Get

        End Get
    End Property

    Public ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
        Get

        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator

    End Function

    'above is needed for ICollection
    ' i don't know why we have ICollection though








End Class

