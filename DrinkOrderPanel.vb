Public Class DrinkOrderPanel
    Inherits System.Windows.Forms.UserControl
    Private dragBoxFromMouseDown As Rectangle
    Private screenOffset As Point



    Event GridMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
    Event GridDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
    Event GridQueryContinueDrag(ByVal sender As Object, ByVal e As QueryContinueDragEventArgs)

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region


    Private Sub ListDragSource_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        menuJoinDragSource = Me.ID
        indexDragSource = Me.Position
        nameDragSource = Me.Text
        priceDragSource = Me.DrinkPrice

        ' Remember the point where the mouse down occurred. The DragSize indicates
        ' the size that the mouse can move before a drag event should be started.                
        Dim dragSize As Size = SystemInformation.DragSize

        ' Create a rectangle using the DragSize, with the mouse position being
        ' at the center of the rectangle.
        dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                                        e.Y - (dragSize.Height / 2)), dragSize)

        RaiseEvent GridMouseDown(sender, e)

    End Sub

    Private Sub ListDragSource_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

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
                data = Me.Text

                Dim dropEffect As DragDropEffects = Me.DoDragDrop(data, DragDropEffects.Move)

                ' If the drag operation was a move then remove the item.
                If (dropEffect = DragDropEffects.Move) Then

                    '        If foodPanel.MenuIndex = 0 Then
                    '   when 0 item came from staging so readjust all sraging buttons

                    Me.Text = ""
                    Me.MenuIndex = Nothing
                    Me.Text = Nothing
                    Me.DrinkPrice = Nothing
                    Me.ID = Nothing

                End If

            End If
        End If

        RaiseEvent GridMouseMove(sender, e)
    End Sub


    Private Sub ListDragTarget_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles MyBase.DragOver

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


    Private Sub ListDragTarget_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles MyBase.DragDrop

        Dim newPosition As Integer
        newPosition = Me.Position

        '   test to see if panel is empty
        '   if not makes e.effects = none
        If Me.ID = 0 Then

            If (e.Data.GetDataPresent(GetType(System.String))) Then

                Dim item As Object = CType(e.Data.GetData(GetType(System.String)), System.Object)

                ' Perform drag and drop, depending upon the effect.
                If (e.Effect = DragDropEffects.Copy Or _
                 e.Effect = DragDropEffects.Move) Then

                    Me.Text = nameDragSource
                    Me.ID = menuJoinDragSource
                    '   foodPanel.FoodName = nameDragSource
                    Me.DrinkPrice = priceDragSource

                    UpdateDrinkIndex(menuJoinDragSource, Me.Position)

                End If
            End If
        Else

            e.Effect = DragDropEffects.None

            RaiseEvent GridDragDrop(sender, e)
        End If
    End Sub


    Private Sub ListDragSource_QueryContinueDrag(ByVal sender As Object, ByVal e As QueryContinueDragEventArgs) Handles MyBase.QueryContinueDrag
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

    Private Sub UpdateDrinkIndex(ByVal mji As Integer, ByVal newIndex As Integer)
        Dim updatingRow As DataRow

        For Each updatingRow In dsSetup.Tables("OrderCategoryDetail").Rows
            If updatingRow("DrinkID") = mji Then
                updatingRow("DrinkIndex") = newIndex
                Exit For
            End If
        Next

    End Sub
End Class
