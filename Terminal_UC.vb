
Imports DataSet_Builder

Public Class Terminal_UC
    Inherits System.Windows.Forms.UserControl

    Private _termType As String 'terminal, table, wall
    Private _index As Integer
    Friend tempWall As New Wall
    Friend tempTerminal As New Terminal
    Friend tempTable As New PhysicalTable
    Private _isNewTerminal As Boolean
    Private _term_table_Num As Integer
    Private _floorPlanID As Integer
    Private _isNewTable As Boolean
    Private _isActive As Boolean
    ' Private _tableNum As Integer

    Friend Property TermType() As String
        Get
            Return _termType
        End Get
        Set(ByVal Value As String)
            _termType = Value
        End Set
    End Property

    Friend Property Index() As Integer
        Get
            Return _index
        End Get
        Set(ByVal Value As Integer)
            _index = Value
        End Set
    End Property

    Friend Property IsNewTerminal() As Boolean
        Get
            Return _isNewTerminal
        End Get
        Set(ByVal Value As Boolean)
            _isNewTerminal = Value
        End Set
    End Property

    Friend Property Term_Table_Num() As Integer
        Get
            Return _term_table_Num
        End Get
        Set(ByVal Value As Integer)
            _term_table_Num = Value
        End Set
    End Property

    Friend Property FloorPlanID() As Integer
        Get
            Return _floorPlanID
        End Get
        Set(ByVal Value As Integer)
            _floorPlanID = Value
        End Set
    End Property

    Friend Property IsNewTable() As Boolean
        Get
            Return _isNewTable
        End Get
        Set(ByVal Value As Boolean)
            _isNewTable = Value
        End Set
    End Property

    Friend Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal Value As Boolean)
            _isActive = Value
        End Set
    End Property

    '   Friend Property TableNum() As Integer
    '   '       Get
    '           Return _tableNum
    '       End Get
    '       Set(ByVal Value As Integer)
    '           _tableNum = Value
    '       End Set
    '  End Property


    Dim xCorrection As Integer
    Dim yCorrection As Integer



    '    Private indexOfItemUnderMouseToDrag As Integer
    '   Private indexOfItemUnderMouseToDrop As Integer

    Private dragBoxFromMouseDown As Rectangle
    Private screenOffset As Point
    Event GridMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event GridMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
    '   Event GridDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
    '  Event GridDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
    ' Event GridQueryContinueDrag(ByVal sender As Object, ByVal e As QueryContinueDragEventArgs)
    Event TerminalMoved(ByVal i As Integer)
    Event TerminalInfoReview(ByVal i As Integer)
    Event TerminalNewInfoNeeded() 'ByVal i As Integer)

    Event TableMoved(ByVal i As Integer)
    Event TableInfoReview(ByVal i As Integer)
    Event TableNewInfoNeeded() 'ByVal i As Integer)

    Event WallMoved(ByVal i As Integer)
    Event WallInfoReview(ByVal i As Integer)
    Event WallNewInfoNeeded() 'ByVal i As Integer)



#Region " Windows Form Designer generated code "

    Public Sub New(ByVal tt As String, ByVal i As Integer, ByVal x As Single, ByVal y As Single, ByVal w As Single, ByVal h As Single, ByVal tn As Integer, ByVal fp As Integer, ByVal isAct As Boolean)
        MyBase.New()

        _termType = tt
        _index = i
        Me.Location = New System.Drawing.Point(x, y)
        _floorPlanID = fp
        Me.Width = w
        Me.Height = h
        _term_table_Num = tn    'this is index for walls
        _isActive = isAct

        Select Case TermType

            Case "Terminal"
                Me.BackColor = Color.IndianRed
                Me.ForeColor = Color.White

            Case "Table"
                '         _tableNum = tn
                Me.BackColor = Color.DarkBlue
                Me.ForeColor = Color.White

            Case "Wall"
                Me.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
                Me.ForeColor = Color.White
        End Select



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
    Friend WithEvents lblTermNum As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTermNum = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTermNum
        '
        Me.lblTermNum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTermNum.ForeColor = System.Drawing.Color.White
        Me.lblTermNum.Location = New System.Drawing.Point(0, 8)
        Me.lblTermNum.Name = "lblTermNum"
        Me.lblTermNum.Size = New System.Drawing.Size(30, 16)
        Me.lblTermNum.TabIndex = 0
        Me.lblTermNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Terminal_UC
        '
        Me.Controls.Add(Me.lblTermNum)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Terminal_UC"
        Me.Size = New System.Drawing.Size(30, 30)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        If Not Term_Table_Num = 0 And Not TermType = "Wall" Then
            Me.lblTermNum.Text = Term_Table_Num
        End If


    End Sub

    Friend Sub AssignSizeValues()
        Select Case TermType

            Case "Terminal"

            Case "Table"
                tempTable.myWidth = Me.Width
                tempTable.myHeight = Me.Height
                tempTable.Index = Me.Index
                tempTable.OldWidth = Me.Width
                tempTable.OldHeight = Me.Height
                tempTable.Active = Me.IsActive

            Case "Wall"
                tempWall.xLoc = Me.Location.X
                tempWall.yLoc = Me.Location.Y
                tempWall.myWidth = Me.Width
                tempWall.myHeight = Me.Height
                tempWall.OldWidth = Me.Width
                tempWall.OldHeight = Me.Height
                tempWall.IndexTableNumber = Me.Index

        End Select

    End Sub
    Private Sub ListDragSource_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, lblTermNum.MouseDown

        Try
            ' Remember the point where the mouse down occurred. The DragSize indicates
            ' the size that the mouse can move before a drag event should be started.                
            Dim dragSize As Size = SystemInformation.DragSize

            ' Create a rectangle using the DragSize, with the mouse position being
            ' at the center of the rectangle.
            dragBoxFromMouseDown = New Rectangle(0 - Me.Location.X, 0 - Me.Location.Y, Me.Parent.Width, Me.Parent.Height)
            xCorrection = e.X
            yCorrection = e.Y

            If Me.Term_Table_Num = 0 Then
                IsNewTerminal = True
            End If

            RaiseEvent GridMouseDown(sender, e)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ListDragSource_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, lblTermNum.MouseUp

        If e.X = xCorrection And e.Y = yCorrection Then
            'panel did not move
            Exit Sub
        End If

        Dim xLoc As Integer = Me.Location.X
        Dim yLoc As Integer = Me.Location.Y

        Select Case TermType

            Case "Terminal"

                If IsNewTerminal = True Then
                    tempTerminal.xLoc = e.X - 60 '- 96
                    tempTerminal.yLoc = e.Y - 90 '- 24

                    ' define new terminal
                    tempTerminal.TermID = DetermineNextAvailTermNumber()
                    tempTerminal.TermGroupID = 0
                    tempTerminal.TermMethod = "Table"       'just the defaults
                    '   tempTerminal.FloorPlanID = _floorPlanID

                    RaiseEvent TerminalNewInfoNeeded() 'Index) 'index?
                    tempTerminal.TermName = ""
                Else
                    tempTerminal.xLoc = e.X + xLoc - xCorrection
                    tempTerminal.yLoc = e.Y + yLoc - yCorrection

                    Me.Location = New Point(tempTerminal.xLoc, tempTerminal.yLoc)
                    RaiseEvent TerminalMoved(Index)
                End If

            Case "Table"

                If IsNewTerminal = True Then
                    tempTable.xLoc = e.X
                    tempTable.yLoc = e.Y

                    ' define new table
                    tempTable.Seats = 4
                    tempTable.Available = 1
                    tempTable.IsRound = 0
                    tempTable.myWidth = 40
                    tempTable.myHeight = 40
                    tempTable.Index = Me.Index
                    tempTable.OldWidth = 40
                    tempTable.OldHeight = 40
                    tempTable.Active = 1

                    '     tempTable.TableNumber = DetermineNextAvailTermNumber()
                    '        tempTable.FloorPlanID = _floorPlanID

                    RaiseEvent TableNewInfoNeeded() '1)
                Else
                    tempTable.xLoc = e.X + xLoc - xCorrection
                    tempTable.yLoc = e.Y + yLoc - yCorrection

                    Me.Location = New Point(tempTable.xLoc, tempTable.yLoc)
                    RaiseEvent TableMoved(Index)
                End If

            Case "Wall"

                If IsNewTerminal = True Then
                    tempWall.xLoc = e.X
                    tempWall.yLoc = e.Y

                    tempWall.IsRound = 0
                    tempWall.myWidth = 150
                    tempWall.myHeight = 20

                    RaiseEvent WallNewInfoNeeded() '2)
                Else
                    tempWall.xLoc = e.X + xLoc - xCorrection
                    tempWall.yLoc = e.Y + yLoc - yCorrection

                    Me.Location = New Point(tempWall.xLoc, tempWall.yLoc)
                    RaiseEvent WallMoved(Index)
                End If

        End Select



    End Sub

    Private Function DetermineNextAvailTermNumber()
        Dim oRow As DataRow
        Dim openTermNum As Integer = 1

        For Each oRow In dsSetup.Tables("terminals").Rows
            If Not oRow("TerminalID") < 1 Then 'in case there is a number zero screwing up our routine
                If Not oRow("TerminalID") = openTermNum Then
                    ' this is our first open terminal number
                    tempTerminal.TermID = openTermNum
                Else : openTermNum += 1

                End If
            End If
        Next

        Return openTermNum

    End Function
    Private Sub ListDragSource_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, lblTermNum.MouseMove

        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then

            ' If the mouse moves outside the rectangle, start the drag.
            If (Rectangle.op_Inequality(dragBoxFromMouseDown, Rectangle.Empty) And _
                Not dragBoxFromMouseDown.Contains(e.X, e.Y)) Then

                ' The screenOffset is used to account for any desktop bands 
                ' that may be at the top or left side of the screen when 
                ' determining when to cancel the drag drop operation.
                screenOffset = SystemInformation.WorkingArea.Location

                ' Proceed with the drag and drop, passing in the list item.                    
                Dim dropEffect As DragDropEffects = Me.DoDragDrop(Me, DragDropEffects.All Or DragDropEffects.Link)

            End If
        End If

        RaiseEvent GridMouseMove(sender, e)
    End Sub

    Private Sub ChangeInfo_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DoubleClick, lblTermNum.DoubleClick

        If Index > 0 Then
            Select Case TermType

                Case "Terminal"
                    RaiseEvent TerminalInfoReview(Index)

                Case "Table"
                    RaiseEvent TableInfoReview(Index)

                Case "Wall"
                    RaiseEvent WallInfoReview(Index)

            End Select
        End If

    End Sub
End Class
