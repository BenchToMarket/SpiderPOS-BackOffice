Friend Module GenerateTables

    '    Friend numberOfMainCategories As Integer
    '   Friend numberOfDrinkCategories As Integer
    '    Friend numberOfModifierCategories As Integer
    '   Friend numberOfCategories As Integer
    '  Friend maximumCategories As Integer
    Friend numberOfMenuSelections As Integer

    Friend dsSetup As DataSet = New DataSet("Menu")
    '   Friend tmrCardRead_DSB As Timer

    Friend cs1 As Color = Color.PowderBlue
    Friend cs2 As Color = Color.Black

    '    Friend WithEvents sql.cn As New System.Data.SqlClient.SqlConnection("integrated security=SSPI;data source=VAIO;initial catalog=Restaurant_Server") ';User ID=VAIO\Administrator;Password=;") '("Data Source=\SC_Restaurant.sdf")

    Friend sql As New DataSet_Builder.SQLHelper
    Friend ds As DataSet = New DataSet("Menu")
    '    Friend dtCategory As DataTable = dsSetup.Tables.Add("Category")
    Friend dtLocationOpening As DataTable = dsSetup.Tables.Add("LocationOpening")
    Friend dtMainCategory As DataTable = dsSetup.Tables.Add("MainCategory")
    Friend dtModifierCategory As DataTable = dsSetup.Tables.Add("ModifierCategory")
    '   Friend dtMainModifierCategory As DataTable = dsSetup.Tables.Add("Main_ModifierCategory")
    Friend dtFunctions As DataTable = dsSetup.Tables.Add("Functions")
    Friend dtPromotion As DataTable = dsSetup.Tables.Add("Promotion")
    Friend dtPromoBSGS As DataTable = dsSetup.Tables.Add("PromoBSGS")
    Friend dtPromoBSGSBuy As DataTable = dsSetup.Tables.Add("PromoBSGSBuy")
    Friend dtPromoBSGSGet As DataTable = dsSetup.Tables.Add("PromoBSGSGet")
    Friend dtPromoComboDetail As DataTable = dsSetup.Tables.Add("PromoComboDetail")
    Friend dtPromoCombo As DataTable = dsSetup.Tables.Add("PromoCombo")
    Friend dtPromoCoupon As DataTable = dsSetup.Tables.Add("PromoCoupon")
    Friend dtPromoCouponDiscount As DataTable = dsSetup.Tables.Add("PromoCouponDiscount")
    Friend dtPromoCouponAtleast As DataTable = dsSetup.Tables.Add("PromoCouponAtleast")

    Friend dtOrderMenuDetail As DataTable = dsSetup.Tables.Add("OrderMenuDetail")
    Friend dtOrderMenuDetailSecond As DataTable = dsSetup.Tables.Add("OrderMenuDetailSecond")
    Friend dtOrderCategoryDetail As DataTable = dsSetup.Tables.Add("OrderCategoryDetail")
    Friend dtOrderAllMenuDetail As DataTable = dsSetup.Tables.Add("OrderAllMenuDetail")

    Friend dtDrinkCategory As DataTable = dsSetup.Tables.Add("DrinkCategory")
    Friend dtDrink As DataTable = dsSetup.Tables.Add("Drinks")
    Friend dtDrinkAdds As DataTable = dsSetup.Tables.Add("DrinkAdds")
    Friend dtDrinkModifiers As DataTable = dsSetup.Tables.Add("DrinkModifiers")
    Friend dtWineParring As DataTable = dsSetup.Tables.Add("WineParring")
    Friend dtLiquorTypes As DataTable = dsSetup.Tables.Add("LiquorTypes")
    Friend dtDrinkPrep As DataTable = dsSetup.Tables.Add("DrinkPrep")
    Friend dtDrinkPrepLocation As DataTable = dsSetup.Tables.Add("DrinkPrepLocation")

    Friend dtActiveEmployee As DataTable = dsSetup.Tables.Add("ActiveEmployee")
    Friend dtJobCodes As DataTable = dsSetup.Tables.Add("JobCodes")

    Friend dtRawCategories As DataTable = dsSetup.Tables.Add("RawCategories")
    Friend dtRawMaterials As DataTable = dsSetup.Tables.Add("RawMaterials")
    Friend dtRawUsageByItem As DataTable = dsSetup.Tables.Add("RawUsageByItem")

    Friend dtTermGroups As DataTable = dsSetup.Tables.Add("TermGroups")
    Friend dtTerminals As DataTable = dsSetup.Tables.Add("Terminals")
    Friend dtTerminalsUseOrder As DataTable = dsSetup.Tables.Add("TerminalsUseOrder")
    Friend dtTermsFloor As DataTable = dsSetup.Tables.Add("TermsFloor")
    Friend dtTermsTables As DataTable = dsSetup.Tables.Add("TermsTables")
    Friend dtTermsWalls As DataTable = dsSetup.Tables.Add("TermsWalls")



    Friend dcTempFoodJoinIndex As DataColumn
    Friend dcTempFoodCategoryJoinIndex As DataColumn
    Friend dcTempFoodModifierJoinIndex As DataColumn


    Friend dtFoods As DataTable = dsSetup.Tables.Add("FoodTable")
    Friend dtModifiers As DataTable = dsSetup.Tables.Add("Modifiers")
    Friend dtFoodJoin As DataTable = dsSetup.Tables.Add("FoodJoin")
    Friend dtJoinFoodCategoryJoins As DataTable = dsSetup.Tables.Add("JoinFoodCategoryJoins")
    Friend dtJoinFoodModiferJoins As DataTable = dsSetup.Tables.Add("JoinFoodModifierJoins")
    Friend dtMenuJoin As DataTable = dsSetup.Tables.Add("MenuJoin")
    Friend dtMenus As DataTable = dsSetup.Tables.Add("Menus")
    Friend dtMenuDetail As DataTable = dsSetup.Tables.Add("MenuDetail")


    Friend lastSelectedRouting As Integer

    Friend dvFoods As New DataView
    Friend dvFoodsJoins As New DataView
    Friend dvMainCategory As DataView = New DataView
    Friend dvMainCategoryFoodJoin As DataView = New DataView
    Friend dvDrinksByCategory As DataView = New DataView
    Friend dvDrinks As New DataView
    '  Friend dvModifierCategory As DataView = New DataView
    '   Friend dvModifierJoins As DataView = New DataView

    Friend menuJoinDragSource As Integer
    Friend indexDragSource As Integer
    Friend nameDragSource As String
    Friend priceDragSource As Decimal
    '.............
    Friend foodIDDragSource As Integer
    Friend surchargeDragSource As Decimal
    Friend routingIDDragSource As Integer
    Friend drinkIDDragSource As Integer
    Friend generalMenuIDDragSource As Integer
    Friend currentMenuDragSource As Integer

    '    Friend dvFood As DataView = New DataView
    '    Friend dvModifier As DataView = New DataView
    '    Friend dvAdjustment As DataView = New DataView
    '    Friend dvDrink As DataView = New DataView
    '    Friend dvFoodJoin As DataView = New DataView
    '   Friend dvFreeFood As DataView = New DataView




    Friend Sub GenerateCategoryDataSets(ByRef corpID As String, ByRef locID As String)

        Dim sqlStatement As String
        Dim tableCreating As String
        Dim bindingColumn As String


        tableCreating = "LocationOverview"
        sqlStatement = "SELECT CompanyID, LocationID, City, State, UsingDefaults FROM LocationOverview WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        ' we are just creating the table in order to create its structure
        tableCreating = "MenuDetail"
        sqlStatement = "SELECT MenuDetail.MenuDetailID, MenuDetail.CompanyID, MenuDetail.LocationID, MenuDetail.MenuID, MenuDetail.CategoryID, MenuDetail.DrinkCategoryID, MenuDetail.OrderIndex, Category.CategoryName, DrinkCategory.DrinkCategoryName FROM MenuDetail LEFT OUTER JOIN Category ON MenuDetail.CategoryID = Category.CategoryID LEFT OUTER JOIN DrinkCategory ON MenuDetail.DrinkCategoryID = DrinkCategory.DrinkCategoryID"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '   *** must figure out what to do with functions
        '   no need to repeat them for every location
        '   just repeat the taxID for each function ?????
        tableCreating = "Functions"
        sqlStatement = "SELECT FunctionID, CompanyID, LocationID, FunctionGroupID, FunctionName, FunctionFlag, TaxID, DrinkRoutingID, AlwaysReport, ReportOrder, Active FROM AABFunctions WHERE (FunctionFlag = 'F' OR FunctionFlag = 'M' OR FunctionFlag = 'O' OR FunctionFlag = 'G') AND CompanyID = '" & corpID & "' AND AABFunctions.LocationID = '" & selectedLocation & "' ORDER BY ReportOrder"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "DrinkFunctions"
        sqlStatement = "SELECT FunctionID, CompanyID, LocationID, FunctionGroupID, FunctionName, FunctionFlag, TaxID, DrinkRoutingID, AlwaysReport, ReportOrder, Active FROM AABFunctions WHERE FunctionFlag = 'D' AND CompanyID = '" & corpID & "' AND AABFunctions.LocationID = '" & selectedLocation & "' ORDER BY ReportOrder"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "RoutingChoice"
        sqlStatement = "SELECT RoutingID, CompanyID, LocationID, RoutingName FROM RoutingChoice WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' AND (RoutingName = 'Do Not Route' OR IsServicePrinter = '1')"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        If dsSetup.Tables("RoutingChoice").Rows.Count > 0 Then
            lastSelectedRouting = dsSetup.Tables("RoutingChoice").Rows(0)("RoutingID")
        Else
            lastSelectedRouting = -1
        End If

        '   do not need to do by Company, the same codes for all
        tableCreating = "PrintPriority"
        sqlStatement = "SELECT PrintPriorityID, PrintPriorityName FROM PrintPriority"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "TaxTable"
        sqlStatement = "SELECT TaxID, TaxName, TaxPercent FROM AABTaxTable"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '       numberOfMainCategories = GetButtonCount("Main")
        '      numberOfDrinkCategories = GetButtonCount("Drink")
        '     numberOfModifierCategories = GetButtonCount("Modifier")
        '    numberOfCategories = (numberOfMainCategories) + numberOfDrinkCategories + numberOfModifierCategories
        '    maximumCategories = GetCategoryMaximum("CategoryID", "Category")


        '     bindingColumn = "CategoryAbrev"
        '      tableCreating = "MainCategory"
        '     sqlStatement = "SELECT Category.CompanyID, Category.LocationID, Category.CategoryID, Category.CategoryName, Category.CategoryAbrev, Category.CategoryOrder, Category.FunctionID, Category.Priority, Category.ButtonColor, Category.ButtonForeColor, Category.HalfSplit, Category.Active, Functions.FunctionGroupID, Functions.FunctionFlag FROM Category LEFT OUTER JOIN Functions ON Category.FunctionID = Functions.FunctionID WHERE (Functions.FunctionFlag = 'F' OR Functions.FunctionFlag = 'O' OR Functions.FunctionFlag = 'G') AND Category.CompanyID = '" & corpID & "' AND Category.LocationID = '" & selectedLocation & "' ORDER BY Category.Active DESC, Category.CategoryID"
        '   dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '        tableCreating = "ModifierCategory"
        '       sqlStatement = "SELECT Category.CompanyID, Category.LocationID, Category.CategoryID, Category.CategoryName, Category.CategoryAbrev, Category.CategoryOrder, Category.FunctionID, Category.Priority, Category.ButtonColor, Category.ButtonForeColor, Category.HalfSplit, Category.Active, Functions.FunctionGroupID, Functions.FunctionFlag FROM Category LEFT OUTER JOIN Functions ON Category.FunctionID = Functions.FunctionID WHERE Functions.FunctionFlag = 'M' AND Category.CompanyID = '" & corpID & "' AND Category.LocationID = '" & selectedLocation & "' ORDER BY Category.Active DESC, Category.CategoryID"
        '      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '       tableCreating = "Main_ModifierCategory"     ' for join tables
        '      sqlStatement = "SELECT CategoryID, CategoryName FROM Category ORDER BY FunctionID"   'Panel = 'Modifier'"
        '     dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '   *** need to update  currently pulling functionID > 1
        '444     tableCreating = "Main_ModifierCategory2"     ' for grdJoinPossibleCategories
        '      sqlStatement = "SELECT Category.CompanyID, Category.LocationID, Category.CategoryID, Category.CategoryName, Category.CategoryAbrev, Category.CategoryOrder, Category.FunctionID, Category.Priority, Category.ButtonColor, Category.ButtonForeColor, Category.HalfSplit, Category.Active, AABFunctions.FunctionGroupID, AABFunctions.FunctionFlag FROM Category LEFT OUTER JOIN AABFunctions ON Category.FunctionID = AABFunctions.FunctionID WHERE Category.Active = '1' AND Category.CompanyID = '" & corpID & "' AND Category.LocationID = '" & selectedLocation & "'" 'CompanyID, LocationID, CategoryID, CategoryName, FunctionID, Active FROM Category WHERE FunctionID > 1 ORDER BY FunctionID"   'Panel = 'Modifier'"
        '     dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '        tableCreating = "WineParring"
        '       sqlStatement = "SELECT CompanyID, LocationID, DrinkID, DrinkName FROM Drinks WHERE IsWineParring = 1 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkName"
        '      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '       tableCreating = "LiquorTypes"
        '      sqlStatement = "SELECT CompanyID, LocationID, DrinkCategoryID, DrinkCategoryName, DrinkCategoryOrder FROM DrinkCategory WHERE IsALiquorType = 1 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        '     dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '444        tableCreating = "FoodTable"
        '     sqlStatement = "SELECT CompanyID, LocationID, FoodID, FoodName, AbrevFoodName, ChitFoodName, CategoryID, FoodCost, TaxID, Foods.FoodDesc, Foods.WineParringID, PrintPriorityID, Active, PrepareTime FROM Foods WHERE CompanyID = '" & corpID & "' AND LocationID = '" & locID & "'"
        ''''''     '      sqlStatement = "SELECT Foods.FoodID, Foods.FoodName, Foods.AbrevFoodName, Foods.ChitFoodName, Foods.CategoryID, Foods.FoodCost, Foods.FoodDesc, Foods.RoutingID, Foods.TaxID, Foods.Surcharge, Foods.PrintPriorityID, Foods.Active, Category.CategoryName, RoutingChoice.RoutingName, PrintPriority.PrintPriorityName FROM Foods LEFT OUTER JOIN Category ON Foods.CategoryID = Category.CategoryID LEFT OUTER JOIN RoutingChoice ON Foods.RoutingID = RoutingChoice.RoutingID LEFT OUTER JOIN PrintPriority ON Foods.PrintPriorityID = PrintPriority.PrintPriorityID"
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '     tableCreating = "FoodTableSupplement"
        '     sqlStatement = "SELECT Foods.FoodID, Foods.RoutingID, Foods.PrintPriorityID, RoutingChoice.RoutingName, PrintPriority.PrintPriorityName FROM Foods LEFT OUTER JOIN RoutingChoice ON Foods.RoutingID = RoutingChoice.RoutingID LEFT OUTER JOIN PrintPriority ON Foods.PrintPriorityID = PrintPriority.PrintPriorityID"
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '444       tableCreating = "Menus"
        '     sqlStatement = "SELECT MenuID, CompanyID, LocationID, MenuName, Active FROM MenuChoice WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '      tableCreating = "MenuJoin"
        '     sqlStatement = "SELECT MenuJoinID, CompanyID, LocationID, FoodID, DrinkID, MenuID, GeneralMenuID, Price, Surcharge, RoutingID, MenuIndex, Active FROM MenuJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '444        tableCreating = "Modifiers"
        '    sqlStatement = "SELECT Foods.CompanyID, Foods.LocationID, Foods.FoodID, Foods.CategoryID, Foods.FoodName, Foods.AbrevFoodName, Foods.ChitFoodName, Foods.TaxID, Foods.Surcharge, Foods.FoodDesc, Foods.PrintPriorityID, Foods.RoutingID, Foods.PrepareTime, Foods.MenuIndex, Category.FunctionID, AABFunctions.FunctionID, AABFunctions.FunctionGroupID, AABFunctions.FunctionFlag FROM Foods LEFT OUTER JOIN Category ON Foods.CategoryID = Category.CategoryID LEFT OUTER JOIN AABFunctions ON Category.FunctionID = AABFunctions.FunctionID WHERE AABFunctions.FunctionFlag = 'M' AND (Foods.CompanyID = '" & corpID & "') AND (Foods.LocationID = '" & selectedLocation & "')"
        '   dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '   this is for individual modifier join 
        '444      tableCreating = "Modifiers2"
        '    sqlStatement = "SELECT Foods.CompanyID, Foods.LocationID, Foods.FoodID, Foods.CategoryID, Foods.FoodName, Foods.AbrevFoodName, Foods.ChitFoodName, Foods.TaxID, Foods.Surcharge, Foods.FoodDesc, Foods.PrintPriorityID, Foods.RoutingID, Foods.PrepareTime, Foods.MenuIndex, Category.FunctionID, AABFunctions.FunctionID, AABFunctions.FunctionGroupID, AABFunctions.FunctionFlag FROM Foods LEFT OUTER JOIN Category ON Foods.CategoryID = Category.CategoryID LEFT OUTER JOIN AABFunctions ON Category.FunctionID = AABFunctions.FunctionID WHERE AABFunctions.FunctionFlag = 'M' AND (Foods.CompanyID = '" & corpID & "') AND (Foods.LocationID = '" & selectedLocation & "')"
        '   dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '444        tableCreating = "FoodJoin"
        '444      sqlStatement = "SELECT CompanyID, LocationID, FoodJoinID, FoodID, CategoryID, ModifierID, NumberFree, FreeFlag, GroupFlag, GTCFlag FROM FoodJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        '444      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        '     dcTempFoodJoinIndex = dsSetup.Tables("FoodJoin").Columns("TempFoodJoinIndex")
        '    dsSetup.Tables("FoodJoin").Columns.Add("TempFoodJoinIndex")

        '444       tableCreating = "JoinFoodCategoryJoins"
        '444       sqlStatement = "SELECT FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.CategoryID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.GTCFlag, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & selectedLocation & "'"
        '444      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        '      dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodCategoryJoins").Columns("TempFoodJoinIndex")
        '     dsSetup.Tables("JoinFoodCategoryJoins").Columns.Add("TempFoodJoinIndex")

        '444       tableCreating = "JoinFoodModifierJoins"
        '444      sqlStatement = "SELECT FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.ModifierID, Foods.FoodID, Foods.CategoryID, Foods.FoodName FROM FoodJoin LEFT OUTER JOIN Foods ON FoodJoin.ModifierID = Foods.FoodID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & selectedLocation & "'"
        '444       dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        '     dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodModifierJoins").Columns("TempFoodJoinIndex")
        '    dsSetup.Tables("JoinFoodModifierJoins").Columns.Add("TempFoodJoinIndex")

        'currently DrinkCategoryOrder is nothing
        '        tableCreating = "DrinkCategory"
        '       sqlStatement = "SELECT DrinkCategoryID, CompanyID, LocationID, DrinkCategoryNumber, DrinkCategoryName, DrinkCategoryOrder, ButtonColor, ButtonForeColor, IsALiquorType FROM DrinkCategory WHERE DrinkCategoryNumber > 0 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkCategoryNumber"
        '      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '       tableCreating = "DrinkModifiers"
        '      sqlStatement = "SELECT DrinkModifierPrimaryKey, CompanyID, LocationID, DrinkModifierID, DrinkID, DrinkName, DrinkPrice FROM DrinkModifiers WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        '     '   ***     ***    ***   need to change
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '      tableCreating = "Promotion"
        '     sqlStatement = "SELECT PromoID, CompanyID, LocationID, PromoName, BSGS, Combo, Coupon, StartDate, EndDate, MaxAmount, MaxCheck, MaxTable, TaxPromoAmount, TaxFoodCost, EstFoodCost, GuestPayTax, ManagerLevel, TipPromo, Active FROM Promotion WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '444
        '     tableCreating = "Drink"
        '   sqlStatement = "SELECT DrinkID, CompanyID, LocationID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, CallPrice, AddOnPrice, Active FROM Drinks WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkIndex"
        '    sqlStatement = "SELECT DrinkID, CompanyID, LocationID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, TaxID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, AddOnPrice, CallPrice, Active, DrinkInvOn, DrinkInv FROM Drinks WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkIndex"
        '   dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '      tableCreating = "DrinkAdds"
        '      sqlStatement = "SELECT DrinkAddID, DrinkAddName, DrinkAddCost FROM DrinkAdds"
        ''      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '      tableCreating = "FreeFood"
        '      sqlStatement = "SELECT FreeFoodID, FoodID, CategoryID, ModifierID, NumberFree FROM FreeFood"
        '      ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)

        '   will remove
        '      tableCreating = "FoodJoinModifier"
        '      sqlStatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.CategoryID, Modifiers.ModifierID, Modifiers.CategoryID, Modifiers.ModifierName, Modifiers.ModifierCost, Modifiers.ModifierDesc, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Modifiers ON FoodJoin.ModifierID = Modifiers.ModifierID LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID"
        '      ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)

        '   will remove
        '       tableCreating = "FreeFoodJoin"
        '       sqlStatement = "SELECT FreeFood.FreeFoodID, FreeFood.FoodID, FreeFood.CategoryID, FreeFood.ModifierID, FreeFood.NumberFree, Modifiers.ModifierName, Category.CategoryName FROM FreeFood LEFT OUTER JOIN Category ON FreeFood.CategoryID = Category.CategoryID LEFT OUTER JOIN Modifiers ON FreeFood.ModifierID = Modifiers.ModifierID"
        '       ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)


        '        tableCreating = "JoinFreeFoodsCategory"
        '        sqlStatement = "SELECT FreeFood.FreeFoodID, FreeFood.FoodID, FreeFood.CategoryID, FreeFood.NumberFree, Category.CategoryName FROM FreeFood RIGHT OUTER JOIN Category ON FreeFood.CategoryID = Category.CategoryID"
        '        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)
        '
        '       tableCreating = "JoinFreeFoodsModifier"
        '       sqlStatement = "SELECT FreeFood.FreeFoodID, FreeFood.FoodID, FreeFood.ModifierID, FreeFood.NumberFree, Modifiers.ModifierName FROM FreeFood RIGHT OUTER JOIN Modifiers ON FreeFood.ModifierID = Modifiers.ModifierID"
        '       ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)


        '      tableCreating = "PromoBSGS"
        '     sqlStatement = "SELECT PromoBSGS.PromoBSGSID, PromoBSGS.CateogryID, PromoBSGS.BSGSCategoryAmount, PromoBSGS.DrinkCategoryID, PromoBSGS.BSGSDrinkCategoryAmount, Category.CategoryName, DrinkCategory.DrinkCategoryName FROM PromoBSGS"
        '    dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '       numberOfMainCategories = dsSetup.Tables("MainCategory").Rows.Count
        '      numberOfDrinkCategories = dsSetup.Tables("DrinkCategory").Rows.Count
        '     numberOfModifierCategories = dsSetup.Tables("ModifierCategory").Rows.Count
        '    numberOfCategories = (numberOfMainCategories) + numberOfDrinkCategories + numberOfModifierCategories

    End Sub

    Friend Sub AddColumnsToJoinTables()

        dcTempFoodJoinIndex = dsSetup.Tables("FoodJoin").Columns("TempFoodJoinIndex")
        dsSetup.Tables("FoodJoin").Columns.Add("TempFoodJoinIndex")

        dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodCategoryJoins").Columns("TempFoodJoinIndex")
        dsSetup.Tables("JoinFoodCategoryJoins").Columns.Add("TempFoodJoinIndex")

        dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodModifierJoins").Columns("TempFoodJoinIndex")
        dsSetup.Tables("JoinFoodModifierJoins").Columns.Add("TempFoodJoinIndex")

    End Sub

    Friend Sub ClearingDataToRepopulate()

        dsSetup.Tables("Menus").Clear()
        dsSetup.Tables("MenuJoin").Clear()
        dsSetup.Tables("FoodJoin").Clear()
        dsSetup.Tables("JoinFoodCategoryJoins").Clear()
        dsSetup.Tables("JoinFoodModifierJoins").Clear()

    End Sub

    Friend Sub RepopulateDataSets(ByRef locID As String)

        dsSetup.Tables("Menus").Clear()
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@LocationID").Value = locID

        dsSetup.Tables("MenuJoin").Clear()
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@LocationID").Value = locID

        dsSetup.Tables("FoodJoin").Clear()
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@LocationID").Value = locID
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@FoodID").Value = 0

        dsSetup.Tables("JoinFoodCategoryJoins").Clear()
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@LocationID").Value = locID
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@FoodID").Value = 0

        dsSetup.Tables("JoinFoodModifierJoins").Clear()
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@LocationID").Value = locID
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@FoodID").Value = 0

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuMenuChoice.Fill(dsSetup.Tables("Menus"))
            sql.SqlMenuMenuJoin.Fill(dsSetup.Tables("MenuJoin"))
            sql.SqlJoinFoodJoin.Fill(dsSetup.Tables("FoodJoin"))
            sql.SqlJoinFoodCategoryJoins.Fill(dsSetup.Tables("JoinFoodCategoryJoins"))
            sql.SqlJoinFoodModiferJoins.Fill(dsSetup.Tables("JoinFoodModifierJoins"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        ' ****
        'below is old, but not sure about FoodID = 0  (above)
        Exit Sub

        Dim sqlStatement As String
        Dim tableCreating As String

        tableCreating = "Menus"
        sqlStatement = "SELECT MenuID, CompanyID, LocationID, MenuName, Active FROM MenuChoice WHERE CompanyID = '" & corpID & "' AND LocationID = '" & locID & "'"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "MenuJoin"
        sqlStatement = "SELECT MenuJoinID, CompanyID, LocationID, FoodID, DrinkID, MenuID, GeneralMenuID, Price, Surcharge, RoutingID, MenuIndex, Active FROM MenuJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & locID & "'"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "FoodJoin"
        sqlStatement = "SELECT FoodJoinID, CompanyID, LocationID, FoodID, CategoryID, ModifierID, NumberFree, FreeFlag, GroupFlag FROM FoodJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & locID & "'"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "JoinFoodCategoryJoins"
        sqlStatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodID, FoodJoin.CategoryID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & locID & "'"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "JoinFoodModifierJoins"
        sqlStatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.ModifierID, Foods.FoodID, Foods.CategoryID, Foods.FoodName FROM FoodJoin LEFT OUTER JOIN Foods ON FoodJoin.ModifierID = Foods.FoodID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & locID & "'"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

    End Sub

    Friend Sub GenerateEmployeeDataSets()
        Dim sqlStatement As String
        Dim tableCreating As String

        tableCreating = "UsedEmployeeNumber"
        sqlStatement = "SELECT EmployeeNumber FROM AAAEmployee WHERE CompanyID = '" & corpID & "' AND LocationID = '" & corpPhysicalLocation & "' ORDER BY EmployeeNumber"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        tableCreating = "TaxFilingStatus"
        sqlStatement = "SELECT FilingStatusName FROM TaxFilingStatus"
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        dsSetup.Tables("ActiveEmployee").Clear()
        sql.SqlSelectCommandEmployeeActiveEmployee.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandEmployeeActiveEmployee.Parameters("@LocationID").Value = corpPhysicalLocation

        dsSetup.Tables("JobCodes").Clear()
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@LocationID").Value = corpPhysicalLocation

        sql.SqlEmployeeActiveEmployee.Fill(dsSetup.Tables("ActiveEmployee"))
        sql.SqlEmployeeJobCodes.Fill(dsSetup.Tables("JobCodes"))


        '   we need to join this table with Job Code Table (for Job Names)
        '      tableCreating = "ActiveEmployee"
        '      sqlStatement = "SELECT EmployeeID, CompanyID, LocationID, EmployeeNumber, LastName, FirstName, MiddleName, NickName, SSN, Passcode, BirthDate, HireDate, Address1, Address2, City, State, Zip, HomePhone, CellPhone, Notes, ReportsTo, Training, Terminated, ClockInReq, ReportMgmtAll, ReportMgmtLimited, OperationMgmtAll, OperationMgmtLimited, SystemMgmtAll, SystemMgmtLimited, EmployeeMgmtAll, EmployeeMgmtLimited, JobCodeID1, JobRate1, JobCodeID2, JobRate2, JobCodeID3, JobRate3, JobCodeID4, JobRate4, JobCodeID5, JobRate5, JobCodeID6, JobRate6, JobCodeID7, JobRate7 FROM AAAEmployee WHERE Terminated = 0 AND CompanyID = '" & corpID & "' AND LocationID = '" & corpPhysicalLocation & "' ORDER BY LastName"
        '      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        '     tableCreating = "JobCodes"
        '     sqlStatement = "SELECT JobCodeID, CompanyID, LocationID, JobCodeName, Manager, Cashier, Bartender, Server, Hostess, PasswordReq, ClockInReq, ReportTipsReq, ShareTipsReq FROM AABJobCodes WHERE CompanyID = '" & corpID & "' AND LocationID = '" & corpPhysicalLocation & "' ORDER BY JobCodeName"
        '     dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '       tableCreating = "JobCodeEmployee"
        '       sqlStatement = "SELECT JobCodeEmployee.EmployeeID, JobCodeEmployee.JobCodeID, JobCodes.JobCodeName FROM JobCodeEmployee LEFT OUTER JOIN JobCodes ON JobCodeEmployee.JobCodeID = JobCodes.JobCodeID ORDER BY EmployeeID"
        '       dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        '      Dim index As Integer
        '     tableCreating = "JobCodesIndividualEmployee"
        '     For index = 1 To 7
        '    sqlStatement = "SELECT Employee.EmployeeID, Employee.JobID" & index & ", Employee.Rate" & index & ", JobCodes.JobCodeName FROM Employee LEFT OUTER JOIN JobCodes ON Employee.JobID" & index & " = JobCodes.JobCodeID WHERE Employee.EmployeeID = 1234"
        '   dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        '  Next


    End Sub

    Friend Sub SetUpPrimaryKeys()

        '      dsSetup.Tables("FoodTable").PrimaryKey = New DataColumn() {dsSetup.Tables("FoodTable").Columns("FoodID")}
        '    dsSetup.Tables("Modifiers").PrimaryKey = New DataColumn() {dsSetup.Tables("Modifiers").Columns("FoodID")}
        dsSetup.Tables("RoutingChoice").PrimaryKey = New DataColumn() {dsSetup.Tables("RoutingChoice").Columns("RoutingID")}

        '     dsSetup.Tables("LocationOverview").PrimaryKey = New DataColumn() {dsSetup.Tables("LocationOverview").Columns("LocationID")}


    End Sub



    Friend Function GetButtonCount(ByRef categoryType As String)

        '      Dim cn As System.Data.SqlClient.SqlConnection
        Dim cmd As System.Data.SqlClient.SqlCommand
        Dim dtr As System.Data.SqlClient.SqlDataReader
        Dim _numberofbuttons As Integer

        '***************** provider removed
        '       cn = New SqlClient.SqlConnection("Data Source=\SC_Restaurant.sdf")
        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        If categoryType Is "Menus" Then
            cmd = New SqlClient.SqlCommand("SELECT COUNT(MenuID) panel_count From MenuChoice WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'", sql.cn)
        ElseIf categoryType Is "ActiveMenus" Then
            cmd = New SqlClient.SqlCommand("SELECT COUNT(MenuID) panel_count From MenuChoice WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' AND Active = 1", sql.cn)
        End If
        '     cmd = New SqlServerCe.SqlCeCommand("SELECT COUNT(Panel) panel_count From Category WHERE Panel ='" & categoryType & "'", cn)
        dtr = cmd.ExecuteReader()

        dtr.Read()

        _numberofbuttons = (dtr("panel_count"))

        dtr.Close()
        sql.cn.Close()

        Return _numberofbuttons

    End Function

    Friend Function GetCategoryMaximum222(ByVal idName As String, ByVal tn As String)

        '      Dim cn As System.Data.SqlClient.SqlConnection
        Dim cmd As System.Data.SqlClient.SqlCommand
        Dim dtr As System.Data.SqlClient.SqlDataReader
        Dim _maxCategory As Integer

        ' until database is set
        _maxCategory = 7
        Return _maxCategory

        '***************** provider removed
        '     cn = New SqlClient.SqlConnection("Data Source=\SC_Restaurant.sdf")
        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()

        cmd = New SqlClient.SqlCommand("SELECT MAX('" & idName & "') max_category From '" & tn & "'", sql.cn)
        '    cmd = New SqlClient.SqlCommand("SELECT MAX(CategoryID) max_category From Modifiers", sql.cn)
        dtr = cmd.ExecuteReader()

        dtr.Read()

        _maxCategory = (dtr("max_category"))

        dtr.Close()
        sql.cn.Close()

        Return _maxCategory

    End Function

    Friend Function GetMaximumID(ByVal idName As String, ByVal tn As String)

        Dim cmd As System.Data.SqlClient.SqlCommand
        Dim dtr As System.Data.SqlClient.SqlDataReader
        Dim _maxCategory As Integer

        '***************** provider removed
        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()

            cmd = New SqlClient.SqlCommand("SELECT MAX(" & idName & ") max_category From " & tn, sql.cn)
            dtr = cmd.ExecuteReader()

            dtr.Read()

            _maxCategory = (dtr("max_category"))

            dtr.Close()
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return _maxCategory


    End Function

    Function PopulateSelectedItemTable(ByVal strSelectedCategoy As String, ByVal sqlString As String, ByRef dsItem As DataSet) As DataSet

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        Dim itemAdapter As New SqlClient.SqlDataAdapter

        itemAdapter.TableMappings.Add("Table", strSelectedCategoy)
        Dim cmdItemTable As SqlClient.SqlCommand = New SqlClient.SqlCommand(sqlString, sql.cn)

        itemAdapter.SelectCommand = cmdItemTable
        itemAdapter.Fill(dsItem)

        sql.cn.Close()

        Return dsItem


    End Function

    Friend Sub CloseConnection()
        If sql.cn.State = ConnectionState.Open Then
            sql.cn.Close()
        End If
    End Sub

    Public Sub ReInitializeSQLConnection(ByVal leusername As String)
        Dim connectserver As String
        If leusername = "e" Or leusername = "eGlobal" Then
            leusername = "eglobalmain"
        End If

        If System.Windows.Forms.SystemInformation.ComputerName = "EGLOBALMAIN" Then
            If leusername = "eglobal" Then
                '   below makes me able to access data base on demo
                connectserver = "eglobalmain\eglobalmain"
            Else
                '   below makes me able to access every account from my computer
                connectserver = "Phoenix\Phoenix"
            End If

        Else
            If leusername = "rasoi2" Then
                connectserver = "rasoi2\rasoi2"
            Else
                connectserver = "Phoenix\Phoenix"
            End If
        End If
       
        '444     sql.cn.ConnectionString = "packet size=4096;integrated security=SSPI;Pooling=False;data source='" & connectserver & "';initial catalog=Restaurant_Server"
        sql.cn.ConnectionString = "packet size=4096;integrated security=SSPI;data source='" & connectserver & "';pe" & _
              "rsist security info=False;Pooling=False;initial catalog=Restaurant_Server"

    End Sub

    Friend Function DetermineID(ByVal grdUsed As DataGrid, ByVal colNum As Integer)
        Dim rowNum As Integer = grdUsed.CurrentCell.RowNumber

        If grdUsed.CurrentRowIndex = -1 Then Exit Function
        If grdUsed.Item(rowNum, colNum) Is DBNull.Value Then Exit Function
        Dim valueID As Integer

        Try
            valueID = CType(grdUsed.Item(rowNum, colNum), Integer)
        Catch ex As Exception

        End Try

        Return valueID

    End Function

    Friend Function DetermineString(ByVal grdUsed As DataGrid, ByVal colNum As Integer)
        Dim rowNum As Integer = grdUsed.CurrentCell.RowNumber

        If grdUsed.CurrentRowIndex = -1 Then Exit Function
        If grdUsed.Item(rowNum, colNum) Is DBNull.Value Then Exit Function
        Dim valueName As String

        Try
            valueName = CType(grdUsed.Item(rowNum, colNum), String)
        Catch ex As Exception

        End Try

        Return valueName
    End Function


    Public Sub UpdateDatabaseFoods()
        Dim oRow As DataRow
        Dim dsChangedData As DataSet

        If dsSetup.HasChanges Then
            Try
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlMenuFoods.Update(dsSetup, "FoodTable")
                sql.cn.Close()

                dsSetup.Tables("FoodTable").AcceptChanges()
            Catch ex As Exception
                '        MsgBox(ex.Message)
                CloseConnection()
            End Try
        End If

    End Sub


    Friend Sub SaveUpdatedMenuOrderCategoryDetail()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuOrderCategory.Update(dsSetup, "OrderCategoryDetail")
            sql.cn.Close()
            dsSetup.Tables("OrderCategoryDetail").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    '    Friend Function PadQuotes(ByVal stringIn As String) As String
    '        Try
    '            PadQuotes = stringIn.Replace("'", "''")
    '       Catch ex As Exception
    ''
    '        End Try
    '    End Function


    '

End Module
