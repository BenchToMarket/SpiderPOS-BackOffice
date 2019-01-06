Public Class FoodOrderPanel
    Inherits System.Windows.Forms.UserControl

    Friend WithEvents foodPanel As FoodPanelControl

    Private indexOfItemUnderMouseToDrag As Integer
    Private indexOfItemUnderMouseToDrop As Integer

    Private dragBoxFromMouseDown As Rectangle
    Private screenOffset As Point

    Event GridMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
    Event GridDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
    Event GridQueryContinueDrag(ByVal sender As Object, ByVal e As QueryContinueDragEventArgs)
    Event MyPanelClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Event BlankOldModifierPanel(ByVal sender As Object, ByVal e As System.EventArgs)

  
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal bColor As Color, ByVal fColor As Color, ByVal foodOrderNumber As Integer, ByVal w As Single, ByVal h As Single, ByVal foodIndex As Integer, ByVal menuJoinID As Integer, ByVal foodName As String, ByVal price As String, ByVal isStaging As Boolean, ByVal dTable As String, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther(bColor, fColor, foodOrderNumber, w, h, foodIndex, menuJoinID, foodName, price, isStaging, dTable, fID, sur, rout, dID, GenMenuID, cm)

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


    Private Sub InitializeOther(ByVal bColor As Color, ByVal fColor As Color, ByVal foodOrderNumber As Integer, ByVal w As Single, ByVal h As Single, ByVal foodindex As Integer, ByVal menuJoinID As Integer, ByVal foodName As String, ByVal price As Decimal, ByVal isStaging As Boolean, ByVal dTable As String, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)


        '   w and h are the width and height of the parent panel
        Dim width As Single = w
        Dim height As Single = h
        Dim panelSpace As Single = 3
        Dim x As Single
        Dim y As Single

        foodPanel = New FoodPanelControl(bColor, fColor, foodOrderNumber, foodindex, menuJoinID, foodName, price, width, height, isStaging, dTable, fID, sur, rout, dID, GenMenuID, cm)
     
        If foodPanel.UpdatingTable = "OrderCategoryDetail" Then
            If foodOrderNumber < 5 Then
                If isStaging = True Then
                    x = panelSpace
                    y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
                Else
                    x = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * width)
                    y = panelSpace
                End If
            ElseIf foodOrderNumber < 9 Then
                If isStaging = True Then
                    x = panelSpace
                    y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
                Else
                    x = (panelSpace * (foodOrderNumber - 4)) + ((foodOrderNumber - 5) * width)
                    y = ((2 * panelSpace) + height)
                End If
            ElseIf foodOrderNumber < 13 Then
                If isStaging = True Then
                    x = panelSpace
                    y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
                Else
                    x = (panelSpace * (foodOrderNumber - 8)) + ((foodOrderNumber - 9) * width)
                    y = ((3 * panelSpace) + (2 * height))
                End If
            ElseIf foodOrderNumber < 17 Then
                x = (panelSpace * (foodOrderNumber - 12)) + ((foodOrderNumber - 13) * width)
                y = ((4 * panelSpace) + (3 * height))
            ElseIf foodOrderNumber < 21 Then
                x = (panelSpace * (foodOrderNumber - 16)) + ((foodOrderNumber - 17) * width)
                y = ((5 * panelSpace) + (4 * height))
            ElseIf foodOrderNumber < 25 Then
                x = (panelSpace * (foodOrderNumber - 20)) + ((foodOrderNumber - 21) * width)
                y = ((6 * panelSpace) + (5 * height))
            ElseIf foodOrderNumber < 29 Then
                x = (panelSpace * (foodOrderNumber - 24)) + ((foodOrderNumber - 25) * width)
                y = ((7 * panelSpace) + (6 * height))
            ElseIf foodOrderNumber < 33 Then
                x = (panelSpace * (foodOrderNumber - 28)) + ((foodOrderNumber - 29) * width)
                y = ((8 * panelSpace) + (7 * height))
            ElseIf foodOrderNumber < 37 Then
                x = (panelSpace * (foodOrderNumber - 32)) + ((foodOrderNumber - 33) * width)
                y = ((9 * panelSpace) + (8 * height))
            ElseIf foodOrderNumber < 41 Then
                x = (panelSpace * (foodOrderNumber - 36)) + ((foodOrderNumber - 37) * width)
                y = ((10 * panelSpace) + (9 * height))

            End If
            If foodOrderNumber <= 24 Then
                foodPanel.BackColor = Color.PowderBlue
            Else
                foodPanel.BackColor = Color.Lavender
            End If
        ElseIf foodPanel.UpdatingTable = "Quick" Or foodPanel.UpdatingTable = "Drinks" Then
            If foodOrderNumber < 7 Then
                If isStaging = True Then
                    x = panelSpace
                    y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
                Else
                    x = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * width)
                    y = panelSpace
                End If
            ElseIf foodOrderNumber < 13 Then
                If isStaging = True Then
                    x = panelSpace
                    y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
                Else
                    x = (panelSpace * (foodOrderNumber - 6)) + ((foodOrderNumber - 7) * width)
                    y = ((2 * panelSpace) + height)
                End If
            ElseIf foodOrderNumber < 19 Then
                If isStaging = True Then
                    x = panelSpace
                    y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
                Else
                    x = (panelSpace * (foodOrderNumber - 12)) + ((foodOrderNumber - 13) * width)
                    y = ((3 * panelSpace) + (2 * height))
                End If
            ElseIf foodOrderNumber < 25 Then
                x = (panelSpace * (foodOrderNumber - 18)) + ((foodOrderNumber - 19) * width)
                y = ((4 * panelSpace) + (3 * height))
            ElseIf foodOrderNumber < 31 Then
                x = (panelSpace * (foodOrderNumber - 24)) + ((foodOrderNumber - 25) * width)
                y = ((5 * panelSpace) + (4 * height))
            ElseIf foodOrderNumber < 37 Then
                x = (panelSpace * (foodOrderNumber - 30)) + ((foodOrderNumber - 31) * width)
                y = ((6 * panelSpace) + (5 * height))
            ElseIf foodOrderNumber < 43 Then
                x = (panelSpace * (foodOrderNumber - 36)) + ((foodOrderNumber - 37) * width)
                y = ((7 * panelSpace) + (6 * height))
            ElseIf foodOrderNumber < 49 Then
                x = (panelSpace * (foodOrderNumber - 42)) + ((foodOrderNumber - 43) * width)
                y = ((8 * panelSpace) + (7 * height))
            ElseIf foodOrderNumber < 55 Then
                x = (panelSpace * (foodOrderNumber - 48)) + ((foodOrderNumber - 49) * width)
                y = ((9 * panelSpace) + (8 * height))
            ElseIf foodOrderNumber < 61 Then
                x = (panelSpace * (foodOrderNumber - 54)) + ((foodOrderNumber - 55) * width)
                y = ((10 * panelSpace) + (9 * height))

            End If

            '   foodPanel.BackColor = bColor
            '  foodPanel.ForeColor = fColor
            foodPanel.BackColor = Color.PowderBlue

        ElseIf foodPanel.UpdatingTable = "Modifiers" Then
        If isStaging = True Then
            '   for staging modifiers
            If foodOrderNumber < 3 Then
                x = panelSpace
                y = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * height)
            ElseIf foodOrderNumber < 5 Then
                x = ((2 * panelSpace) + width)
                y = (panelSpace * (foodOrderNumber - 2)) + ((foodOrderNumber - 3) * height)
            ElseIf foodOrderNumber < 7 Then
                x = ((3 * panelSpace) + (2 * width))
                y = (panelSpace * (foodOrderNumber - 4)) + ((foodOrderNumber - 5) * height)
            Else
                x = ((4 * panelSpace) + (3 * width))
                y = (panelSpace * (foodOrderNumber - 6)) + ((foodOrderNumber - 7) * height)
            End If
                foodPanel.BackColor = bColor
                foodPanel.ForeColor = fColor

        Else
            '   for regular modifiers
            If foodOrderNumber < 5 Then
                x = (panelSpace * foodOrderNumber) + ((foodOrderNumber - 1) * width)
                y = panelSpace
            ElseIf foodOrderNumber < 9 Then
                x = (panelSpace * (foodOrderNumber - 4)) + ((foodOrderNumber - 5) * width)
                y = ((2 * panelSpace) + height)
            ElseIf foodOrderNumber < 13 Then
                x = (panelSpace * (foodOrderNumber - 8)) + ((foodOrderNumber - 9) * width)
                y = ((3 * panelSpace) + (2 * height))
            ElseIf foodOrderNumber < 17 Then
                x = (panelSpace * (foodOrderNumber - 12)) + ((foodOrderNumber - 13) * width)
                y = ((4 * panelSpace) + (3 * height))
            ElseIf foodOrderNumber < 21 Then
                x = (panelSpace * (foodOrderNumber - 16)) + ((foodOrderNumber - 17) * width)
                y = ((5 * panelSpace) + (4 * height))
            Else
                x = (panelSpace * (foodOrderNumber - 20)) + ((foodOrderNumber - 21) * width)
                y = ((6 * panelSpace) + (5 * height))
                End If
                foodPanel.BackColor = bColor
                foodPanel.ForeColor = fColor

            End If





        End If


        Me.Size = New Size(width, height)
        Me.Location = New Point(x, y)
        Me.AllowDrop = True


        foodPanel.Size = New Size(width, height)
        foodPanel.Location = New Point(0, 0)

        '**************
        ' the below is resetting all colors
        '      If foodOrderNumber <= 24 Then
        '     foodPanel.BackColor = Color.PowderBlue
        '    Else
        '       foodPanel.BackColor = Color.Lavender
        '  End If
        foodPanel.AllowDrop = True

        '      Me.foodPanel.Controls.Add(foodNamePanel)
        '     Me.foodPanel.Controls.Add(foodPricePanel)
        Me.Controls.Add(foodPanel)

    End Sub

    Private Sub ListDragSource_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles foodPanel.MouseDown

        menuJoinDragSource = Me.foodPanel.MenuJoinID
        indexDragSource = Me.foodPanel.MenuIndex
        nameDragSource = Me.foodPanel.FoodName
        priceDragSource = Me.foodPanel.FoodPrice
        foodIDDragSource = Me.foodPanel.FoodID
        surchargeDragSource = Me.foodPanel.Surcharge
        routingIDDragSource = Me.foodPanel.RoutingID
        drinkIDDragSource = Me.foodPanel.DrinkID
        generalMenuIDDragSource = Me.foodPanel.GeneralMenuID
        currentMenuDragSource = Me.foodPanel.CurrentMenu

        ' Remember the point where the mouse down occurred. The DragSize indicates
        ' the size that the mouse can move before a drag event should be started.                
        Dim dragSize As Size = SystemInformation.DragSize

        ' Create a rectangle using the DragSize, with the mouse position being
        ' at the center of the rectangle.
        dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                                        e.Y - (dragSize.Height / 2)), dragSize)

        RaiseEvent GridMouseDown(sender, e)

    End Sub


    Private Sub ListDragSource_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles foodPanel.MouseMove
        If foodPanel.MenuJoinID = -1 Or foodPanel.MenuJoinID = -2 Then
            Return
        End If

        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then

            ' If the mouse moves outside the rectangle, start the drag.
            If (Rectangle.op_Inequality(dragBoxFromMouseDown, Rectangle.Empty) And _
                Not dragBoxFromMouseDown.Contains(e.X, e.Y)) Then

                ' The screenOffset is used to account for any desktop bands 
                ' that may be at the top or left side of the screen when 
                ' determining when to cancel the drag drop operation.
                screenOffset = SystemInformation.WorkingArea.Location

                ' Proceed with the drag and drop, passing in the list item.                    

                Dim data As String
                data = foodPanel.Text

                Dim dropEffect As DragDropEffects = Me.DoDragDrop(data, DragDropEffects.Move)

                ' If the drag operation was a move then remove the item.
                If (dropEffect = DragDropEffects.Move) Then

                    '        If foodPanel.MenuIndex = 0 Then
                    '   when 0 item came from staging so readjust all sraging buttons

                    If foodPanel.UpdatingTable = "Drinks" Then
                        RaiseEvent BlankOldModifierPanel(sender, e)
                        '     Else
                    End If

                    foodPanel.Text = ""
                    '   'old         foodPanel.MenuIndex = Nothing
                    foodPanel.FoodName = Nothing
                    foodPanel.FoodPrice = Nothing
                    '      foodPanel.MenuJoinID = Nothing
                    foodPanel.MenuJoinID = 0

                End If
            End If
        End If

        RaiseEvent GridMouseMove(sender, e)
    End Sub

    Private Sub ListDragTarget_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles foodPanel.DragOver
        If foodPanel.MenuJoinID = -1 Or foodPanel.MenuJoinID = -2 Then
            e.Effect = DragDropEffects.None
            Return
        End If

        ' Determine whether string data exists in the drop data. If not, then
        ' the drop effect reflects that the drop cannot occur.
        If Not (e.Data.GetDataPresent(GetType(System.String))) Then

            e.Effect = DragDropEffects.None
            '            DropLocationLabel.Text = "None - no string data."
            Return
        End If

        ' Set the effect based upon the KeyState.
        If ((e.KeyState And (8 + 32)) = (8 + 32) And _
            (e.AllowedEffect And DragDropEffects.Link) = DragDropEffects.Link) Then
            ' KeyState 8 + 32 = CTL + ALT

            ' Link drag and drop effect.
            e.Effect = DragDropEffects.Link

        ElseIf ((e.KeyState And 32) = 32 And _
            (e.AllowedEffect And DragDropEffects.Link) = DragDropEffects.Link) Then

            ' ALT KeyState for link.
            e.Effect = DragDropEffects.Link

        ElseIf ((e.KeyState And 4) = 4 And _
            (e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move) Then

            ' SHIFT KeyState for move.
            e.Effect = DragDropEffects.Move

        ElseIf ((e.KeyState And 8) = 8 And _
            (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy) Then

            ' CTL KeyState for copy.
            e.Effect = DragDropEffects.Copy

        ElseIf ((e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move) Then

            ' By default, the drop action should be move, if allowed.
            e.Effect = DragDropEffects.Move

        Else
            e.Effect = DragDropEffects.None
        End If


        RaiseEvent GridDragOver(sender, e)
    End Sub

    Private Sub ListDragTarget_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles foodPanel.DragDrop

        Dim newPosition As Integer
        newPosition = foodPanel.MenuIndex

        '   test to see if panel is empty
        '   if not makes e.effects = none
        If foodPanel.MenuJoinID = 0 Then

            If (e.Data.GetDataPresent(GetType(System.String))) Then

                Dim item As Object = CType(e.Data.GetData(GetType(System.String)), System.Object)

                ' Perform drag and drop, depending upon the effect.
                If (e.Effect = DragDropEffects.Copy Or _
                 e.Effect = DragDropEffects.Move) Then

                    foodPanel.Text = nameDragSource
                    foodPanel.MenuJoinID = menuJoinDragSource
                    foodPanel.FoodName = nameDragSource
                    foodPanel.FoodPrice = priceDragSource

                    Me.foodPanel.FoodID = foodIDDragSource
                    Me.foodPanel.Surcharge = surchargeDragSource
                    Me.foodPanel.RoutingID = routingIDDragSource
                    Me.foodPanel.DrinkID = drinkIDDragSource
                    Me.foodPanel.GeneralMenuID = generalMenuIDDragSource
                    Me.foodPanel.CurrentMenu = currentMenuDragSource

                    If foodPanel.StagingPanel = True Then
                        foodPanel.MenuIndex = 0
                    Else
                        foodPanel.MenuIndex = newPosition
                    End If

                    If foodPanel.UpdatingTable = "OrderCategoryDetail" Or foodPanel.UpdatingTable = "Quick" Then
                        UpdateMenuJoinIndex(menuJoinDragSource, foodPanel.MenuIndex)
                        RaiseEvent BlankOldModifierPanel(sender, e) 'also saves
                    ElseIf foodPanel.UpdatingTable = "Modifiers" Then
                        '     UpdateMenuJoinIndex(menuJoinDragSource, foodPanel.MenuIndex)
                        UpdateModifierIndex(menuJoinDragSource, foodPanel.MenuIndex)
                        RaiseEvent BlankOldModifierPanel(sender, e)
                    ElseIf foodPanel.UpdatingTable = "Drinks" Then
                        UpdateDrinkIndex(drinkIDDragSource, foodPanel.MenuIndex)
                        '444      RaiseEvent BlankOldModifierPanel(sender, e)


                    End If
                End If
            End If
        Else

            e.Effect = DragDropEffects.None
            RaiseEvent GridDragDrop(sender, e)
        End If
    End Sub

    Private Sub ListDragSource_QueryContinueDrag(ByVal sender As Object, ByVal e As QueryContinueDragEventArgs) Handles foodPanel.QueryContinueDrag
        ' Cancel the drag if the mouse moves off the form.
        Dim lb As ListBox = CType(sender, System.Windows.Forms.ListBox)

        If Not (lb Is Nothing) Then

            Dim f As Form = lb.FindForm()

            ' Cancel the drag if the mouse moves off the form. The screenOffset
            ' takes into account any desktop bands that may be at the top or left
            ' side of the screen.
            If (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) Or _
                ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) Or _
                ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) Or _
                ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom)) Then

                e.Action = DragAction.Cancel
            End If
        End If

        RaiseEvent GridQueryContinueDrag(sender, e)
    End Sub

    Private Sub UpdateMenuJoinIndex(ByVal mji As Integer, ByVal newIndex As Integer)
        Dim menuJoinRow As DataRow
        Dim oRow As DataRow
        Dim needToAddItemOnMenuJoin As Boolean = True

        Try
            If foodPanel.GeneralMenuID > 0 Then
                For Each oRow In dsSetup.Tables("OrderCategoryDetail").Rows
                    If oRow("MenuJoinID") = foodPanel.MenuJoinID Then 'mji (same thing)
                        If Not oRow("GeneralMenuID") Is DBNull.Value Then   'just in case
                            '     If oRow("GeneralMenuID") = foodPanel.GeneralMenuID Then
                            oRow("MenuIndex") = newIndex
                            '       End If
                            needToAddItemOnMenuJoin = False
                            Exit Sub
                        End If
                    End If
                Next
            Else
                For Each oRow In dsSetup.Tables("OrderCategoryDetail").Rows
                    If oRow("MenuJoinID") = foodPanel.MenuJoinID Then
                        oRow("MenuIndex") = newIndex
                        needToAddItemOnMenuJoin = False
                        Exit Sub
                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'never need to add index for food, we add index when we add food
        '*** we may need to add a drink
        Try
            If needToAddItemOnMenuJoin = True Then
                ' add item to MenuJoin
                Dim newRowDatabase As DataRow

                ' *********** we need to do this like terminal add 
                '    so we can load the menuJoinIndex
                SaveUpdatedMenuOrderCategoryDetail()

                newRowDatabase = dsSetup.Tables("OrderCategoryDetail").NewRow
                newRowDatabase("CompanyID") = corpID
                newRowDatabase("LocationID") = selectedLocation
                newRowDatabase("FoodID") = foodPanel.FoodID
                newRowDatabase("DrinkID") = foodPanel.DrinkID

                'insert AbrevFoodName and DrinkName here
                '          If foodPanel.FoodID > 0 Then
                '         newRowDatabase("AbrevFoodName") = foodPanel.FoodName
                '    Else
                '       newRowDatabase("DrinkName") = foodPanel.FoodName
                '  End If
                newRowDatabase("MenuID") = foodPanel.CurrentMenu
                newRowDatabase("GeneralMenuID") = foodPanel.GeneralMenuID
                newRowDatabase("Price") = foodPanel.FoodPrice
                newRowDatabase("Surcharge") = foodPanel.Surcharge
                newRowDatabase("RoutingID") = foodPanel.RoutingID
                newRowDatabase("MenuIndex") = newIndex
                newRowDatabase("Active") = True
                dsSetup.Tables("OrderCategoryDetail").Rows.Add(newRowDatabase)
                '  dsSetup.Tables("MenuJoin").Rows.Add(newRowDatabase)

                newRowDatabase("MenuJoinID") = InsertingNewMenuJoin(newRowDatabase)
                foodPanel.MenuJoinID = newRowDatabase("MenuJoinID")
                dsSetup.Tables("OrderCategoryDetail").AcceptChanges()
                '    dsSetup.Tables("MenuJoin").AcceptChanges()

            Else
                For Each menuJoinRow In dsSetup.Tables("OrderCategoryDetail").Rows
                    If menuJoinRow("MenuJoinID") = mji Then
                        menuJoinRow("MenuIndex") = newIndex
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '      MsgBox(foodPanel.Text)
        '      MsgBox(foodPanel.MenuJoinID)
        '      MsgBox(foodPanel.FoodName)
        '     MsgBox(foodPanel.FoodPrice)
        '      MsgBox(foodPanel.FoodID)
        '     MsgBox(foodPanel.Surcharge)
        '     MsgBox(foodPanel.RoutingID)
        '     MsgBox(foodPanel.DrinkID)
        '     MsgBox(foodPanel.GeneralMenuID)
        ''     MsgBox(foodPanel.CurrentMenu)

    End Sub

    Private Function InsertingNewMenuJoin(ByRef oRow As DataRow)
        Dim newMenuJoinID As Integer

        sql.SqlInsertMenuOrderCategory.Parameters("@CompanyID").Value = oRow("CompanyID")
        sql.SqlInsertMenuOrderCategory.Parameters("@LocationID").Value = oRow("LocationID")
        sql.SqlInsertMenuOrderCategory.Parameters("@FoodID").Value = oRow("FoodID")
        sql.SqlInsertMenuOrderCategory.Parameters("@DrinkID").Value = oRow("DrinkID")
        sql.SqlInsertMenuOrderCategory.Parameters("@MenuID").Value = oRow("MenuID")
        sql.SqlInsertMenuOrderCategory.Parameters("@GeneralMenuID").Value = oRow("GeneralMenuID")
        sql.SqlInsertMenuOrderCategory.Parameters("@Price").Value = oRow("Price")
        sql.SqlInsertMenuOrderCategory.Parameters("@Surcharge").Value = oRow("Surcharge")
        sql.SqlInsertMenuOrderCategory.Parameters("@RoutingID").Value = oRow("RoutingID")
        sql.SqlInsertMenuOrderCategory.Parameters("@MenuIndex").Value = oRow("MenuIndex")
        sql.SqlInsertMenuOrderCategory.Parameters("@Active").Value = oRow("Active")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newMenuJoinID = CType(sql.SqlInsertMenuOrderCategory.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        Return newMenuJoinID

    End Function

    Private Sub UpdateModifierIndex(ByVal mji As Integer, ByVal newIndex As Integer)
        Dim modifierRow As DataRow

        For Each modifierRow In dsSetup.Tables("Modifiers").Rows
            If modifierRow("FoodID") = mji Then
                modifierRow("MenuIndex") = newIndex
                Exit For
            End If
        Next

    End Sub

    Private Sub UpdateDrinkIndex(ByVal mji As Integer, ByVal newIndex As Integer)
        Dim drinkRow As DataRow

        For Each drinkRow In dsSetup.Tables("Drinks").Rows
            If drinkRow("DrinkID") = mji Then
                drinkRow("DrinkIndex") = newIndex
                Exit For
            End If
        Next

    End Sub

    Friend Sub UpdateStagingPanel(ByVal menujoinID As Integer, ByVal name As String, ByVal price As Decimal, ByVal fID As Integer, ByVal sur As Decimal, ByVal rout As Integer, ByVal dID As Integer, ByVal GenMenuID As Integer, ByVal cm As Integer)

        foodPanel.Text = name
        foodPanel.MenuJoinID = menujoinID
        foodPanel.FoodName = name
        foodPanel.FoodPrice = price
        foodPanel.FoodID = fID
        foodPanel.Surcharge = sur
        foodPanel.RoutingID = rout
        foodPanel.DrinkID = dID
        foodPanel.GeneralMenuID = GenMenuID
        foodPanel.CurrentMenu = cm

    End Sub

    Private Sub PanelClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles foodPanel.Click
        RaiseEvent MyPanelClick(sender, e)

    End Sub

End Class


