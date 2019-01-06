Imports DataSet_Builder

Public Class SetupTerminals
    Inherits System.Windows.Forms.UserControl

    Public currentFloorPlanID As Integer
    Dim changedTable As Boolean
    Dim changedTerminal As Boolean
    '   Dim changedTable As Boolean
    Dim lblWall As Label
    Dim lblTerminal As Label
    Dim lblTableSquare As Label

    Dim WithEvents currentWallInfo As WallInfo_UC
    Dim WithEvents currentTermInfo As TerminalInfo_UC
    Dim WithEvents currentTableInfo As TableInfo_UC
    Dim WithEvents terminalGroupPanel As TerminalGroup_UC
    Dim terminalPanel(200) As Terminal_UC
    Dim numberOfTerms As Integer = 200
    Dim i As Integer = 9

    Dim FloorPlanFirst As Integer
    Dim FloorPlanSecond As Integer


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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FloorPlan1 As System.Windows.Forms.TabPage
    Friend WithEvents FloorPlan2 As System.Windows.Forms.TabPage
    Friend WithEvents pnlFloorPlan1 As System.Windows.Forms.Panel
    Friend WithEvents pnlFloorPlan2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.FloorPlan1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlFloorPlan1 = New System.Windows.Forms.Panel
        Me.FloorPlan2 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlFloorPlan2 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.FloorPlan1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FloorPlan2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.FloorPlan1)
        Me.TabControl1.Controls.Add(Me.FloorPlan2)
        Me.TabControl1.Location = New System.Drawing.Point(24, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 544)
        Me.TabControl1.TabIndex = 0
        '
        'FloorPlan1
        '
        Me.FloorPlan1.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.FloorPlan1.Controls.Add(Me.Panel1)
        Me.FloorPlan1.Location = New System.Drawing.Point(4, 22)
        Me.FloorPlan1.Name = "FloorPlan1"
        Me.FloorPlan1.Size = New System.Drawing.Size(736, 518)
        Me.FloorPlan1.TabIndex = 0
        Me.FloorPlan1.Text = "Floor Plan 1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.pnlFloorPlan1)
        Me.Panel1.Location = New System.Drawing.Point(80, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 336)
        Me.Panel1.TabIndex = 1
        '
        'pnlFloorPlan1
        '
        Me.pnlFloorPlan1.BackColor = System.Drawing.Color.Black
        Me.pnlFloorPlan1.Location = New System.Drawing.Point(8, 8)
        Me.pnlFloorPlan1.Name = "pnlFloorPlan1"
        Me.pnlFloorPlan1.Size = New System.Drawing.Size(488, 320)
        Me.pnlFloorPlan1.TabIndex = 0
        '
        'FloorPlan2
        '
        Me.FloorPlan2.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.FloorPlan2.Controls.Add(Me.Panel2)
        Me.FloorPlan2.Location = New System.Drawing.Point(4, 22)
        Me.FloorPlan2.Name = "FloorPlan2"
        Me.FloorPlan2.Size = New System.Drawing.Size(736, 518)
        Me.FloorPlan2.TabIndex = 1
        Me.FloorPlan2.Text = "Floor Plan 2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.pnlFloorPlan2)
        Me.Panel2.Location = New System.Drawing.Point(104, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 344)
        Me.Panel2.TabIndex = 2
        '
        'pnlFloorPlan2
        '
        Me.pnlFloorPlan2.BackColor = System.Drawing.Color.Black
        Me.pnlFloorPlan2.Location = New System.Drawing.Point(8, 8)
        Me.pnlFloorPlan2.Name = "pnlFloorPlan2"
        Me.pnlFloorPlan2.Size = New System.Drawing.Size(528, 328)
        Me.pnlFloorPlan2.TabIndex = 0
        '
        'SetupTerminals
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(78, Byte), CType(152, Byte))
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "SetupTerminals"
        Me.Size = New System.Drawing.Size(792, 696)
        Me.TabControl1.ResumeLayout(False)
        Me.FloorPlan1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FloorPlan2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub




#End Region

    Private Sub InitializeOther()

        PopulateTerminalData()

        PopulateFloorPlanData()

        DisplayPermanentUserControls()

        DisplayWalls()

        DisplayTables()

        DisplayTerminals()

    End Sub

    Private Sub PopulateFloorPlanData()
        Dim fpRow As DataRow
        Dim fpCount As Integer = 1

        Me.pnlFloorPlan1.Controls.Clear()
        Me.pnlFloorPlan2.Controls.Clear()

        For Each fpRow In dsSetup.Tables("TermsFloor").Rows
            Select Case fpCount
                Case 1
                    Me.FloorPlan1.Text = fpRow("FloorPlanName") & "   "
                    FloorPlanFirst = fpRow("FloorPlanID")
                    Me.Panel1.Size = New Size(fpRow("meWidth"), fpRow("meHeight"))
                    Me.Panel1.Location = New Point((Me.FloorPlan1.Width - fpRow("meWidth")) / 2, (Me.FloorPlan1.Height - fpRow("meHeight")) / 2)
                    Me.pnlFloorPlan1.Size = New Size(fpRow("meWidth") - 16, fpRow("meHeight") - 16)
                    Me.pnlFloorPlan1.Location = New Point(8, 8)
                    currentFloorPlanID = fpRow("FloorPlanID")
                Case 2
                    Me.FloorPlan2.Text = fpRow("FloorPlanName") & "   "
                    FloorPlanSecond = fpRow("FloorPlanID")
                    Me.Panel2.Size = New Size(fpRow("meWidth"), fpRow("meHeight"))
                    Me.Panel2.Location = New Point((Me.FloorPlan2.Width - fpRow("meWidth")) / 2, (Me.FloorPlan2.Height - fpRow("meHeight")) / 2)
                    Me.pnlFloorPlan2.Size = New Size(fpRow("meWidth") - 16, fpRow("meHeight") - 16)
                    Me.pnlFloorPlan2.Location = New Point(8, 8)
            End Select

            fpCount += 1
        Next

    End Sub

    Private Sub PopulateTerminalData()

        dsSetup.Tables("TermGroups").Clear()
        dsSetup.Tables("Terminals").Clear()
        dsSetup.Tables("TerminalsUseOrder").Clear()

        dsSetup.Tables("TermsFloor").Clear()
        dsSetup.Tables("TermsTables").Clear()
        dsSetup.Tables("TermsWalls").Clear()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlSelectCommandTermGroups.Parameters("@LocationID").Value = corpPhysicalLocation
            sql.SqlSelectCommandTerms.Parameters("@LocationID").Value = corpPhysicalLocation
            sql.SqlSelectCommandTermsUse.Parameters("@LocationID").Value = corpPhysicalLocation

            sql.SqlSelectCommandTermsFloor.Parameters("@LocationID").Value = corpPhysicalLocation
            sql.SqlSelectCommandTermsTables.Parameters("@LocationID").Value = corpPhysicalLocation
            sql.SqlSelectCommandTermsWalls.Parameters("@LocationID").Value = corpPhysicalLocation

            sql.SqlTermGroups.Fill(dsSetup.Tables("TermGroups"))
            sql.SqlTerms.Fill(dsSetup.Tables("Terminals"))
            sql.SqlTermsUse.Fill(dsSetup.Tables("TerminalsUseOrder"))

            sql.SqlTermsFloor.Fill(dsSetup.Tables("TermsFloor"))
            sql.SqlTermsTables.Fill(dsSetup.Tables("TermsTables"))
            sql.SqlTermsWalls.Fill(dsSetup.Tables("TermsWalls"))
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CloseConnection()
        End Try

        TestArray()

    End Sub

    Private Sub TestArray()
        Dim terminalCount As Integer

        terminalCount = (dsSetup.Tables("Terminals").Rows.Count + dsSetup.Tables("TermsTables").Rows.Count + dsSetup.Tables("TermsWalls").Rows.Count + 10)

        If terminalCount > numberOfTerms Then
            numberOfTerms = (terminalCount + 200)
            Try
                'place in try b/c if we start too low we can't dispose of these not yet created panels
                terminalPanel(0).Dispose()
                terminalPanel(1).Dispose()
                terminalPanel(2).Dispose()
            Catch ex As Exception

            End Try
            ReDim terminalPanel(numberOfTerms)
            i = 9

            PopulateFloorPlanData()
            DisplayPermanentUserControls()
            DisplayWalls()
            DisplayTables()
            DisplayTerminals()
        End If

    End Sub

    Private Sub DisplayPermanentUserControls()

        lblWall = New Label
        lblWall.Location = New System.Drawing.Point(250, 64)
        lblWall.Size = New Size(60, 20)
        lblWall.Text = "Wall"
        lblWall.ForeColor = Color.White
        lblWall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        lblTerminal = New Label
        lblTerminal.Location = New System.Drawing.Point(84, 64)
        lblTerminal.Size = New Size(60, 20)
        lblTerminal.Text = "Terminal"
        lblTerminal.ForeColor = Color.White
        lblTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        lblTableSquare = New Label
        lblTableSquare.Location = New System.Drawing.Point(176, 64)
        lblTableSquare.Size = New Size(60, 20)
        lblTableSquare.Text = "Table"
        lblTableSquare.ForeColor = Color.White
        lblTableSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        terminalPanel(0) = New Terminal_UC("Terminal", 0, 96, 24, 30, 30, 0, 0, True)
        Me.terminalPanel(0).Location = New System.Drawing.Point(96, 84)
        Me.terminalPanel(0).Size = New System.Drawing.Size(30, 30)
        Me.terminalPanel(0).BackColor = Color.IndianRed
        Me.terminalPanel(0).ForeColor = Color.White
        '       terminalPanel(0).AssignSizeValues()
        AddHandler terminalPanel(0).TerminalNewInfoNeeded, AddressOf TerminalBeingAdded
        AddHandler terminalPanel(0).TerminalMoved, AddressOf TerminalMoved_Mouse
        AddHandler terminalPanel(0).TerminalInfoReview, AddressOf TerminalBeingReviewed

        terminalPanel(1) = New Terminal_UC("Table", 0, 176, 24, 40, 40, 0, 0, True)
        Me.terminalPanel(1).Location = New System.Drawing.Point(176, 84)
        Me.terminalPanel(1).Size = New System.Drawing.Size(40, 40)
        Me.terminalPanel(1).BackColor = Color.DarkBlue
        Me.terminalPanel(1).ForeColor = Color.White
        terminalPanel(1).AssignSizeValues()
        AddHandler terminalPanel(1).TableNewInfoNeeded, AddressOf TableBeingAdded
        AddHandler terminalPanel(1).TableMoved, AddressOf TableMoved_Mouse
        AddHandler terminalPanel(1).TableInfoReview, AddressOf TableBeingReviewed

        terminalPanel(2) = New Terminal_UC("Wall", 0, 250, 24, 150, 20, 0, 0, True)
        Me.terminalPanel(2).Location = New System.Drawing.Point(250, 84)
        Me.terminalPanel(2).Size = New System.Drawing.Size(150, 20)
        Me.terminalPanel(2).BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.terminalPanel(2).ForeColor = Color.White
        terminalPanel(2).AssignSizeValues()
        AddHandler terminalPanel(2).WallNewInfoNeeded, AddressOf WallBeingAdded
        AddHandler terminalPanel(2).WallMoved, AddressOf WallMoved_Mouse
        AddHandler terminalPanel(2).WallInfoReview, AddressOf WallBeingReviewed

        Me.Controls.Add(lblTerminal)
        Me.Controls.Add(lblTableSquare)
        Me.Controls.Add(lblWall)
        Me.Controls.Add(terminalPanel(0))
        Me.Controls.Add(terminalPanel(1))
        Me.Controls.Add(terminalPanel(2))


    End Sub

    Private Sub DisplayWalls()
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("TermsWalls").Rows
            DisplayEachWall(oRow, i)
            i += 1
        Next

    End Sub

    Private Sub DisplayTables()
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("TermsTables").Rows
            DisplayEachTable(oRow, i)
            i += 1
        Next

    End Sub

    Private Sub DisplayEachWall(ByRef oRow As DataRow, ByVal i As Integer)

        terminalPanel(i) = New Terminal_UC("Wall", i, oRow("xLoc"), oRow("yLoc"), oRow("myWidth"), oRow("myHeight"), i, oRow("FloorPlanID"), oRow("Active"))
        terminalPanel(i).Size = New System.Drawing.Size(oRow("myWidth"), oRow("myHeight"))
        terminalPanel(i).AssignSizeValues()

        terminalPanel(i).tempWall.FloorPlanID = oRow("FloorPlanID")
        terminalPanel(i).tempWall.IsRound = False

        AddHandler terminalPanel(i).WallNewInfoNeeded, AddressOf WallBeingAdded
        AddHandler terminalPanel(i).WallMoved, AddressOf WallMoved_Mouse
        AddHandler terminalPanel(i).WallInfoReview, AddressOf WallBeingReviewed

        Select Case oRow("FloorPlanID")
            Case FloorPlanFirst

                Me.pnlFloorPlan1.Controls.Add(terminalPanel(i))
            Case FloorPlanSecond
                Me.pnlFloorPlan2.Controls.Add(terminalPanel(i))

        End Select
    End Sub

    Private Sub DisplayEachTable(ByRef oRow As DataRow, ByVal i As Integer)

        terminalPanel(i) = New Terminal_UC("Table", i, oRow("xLoc"), oRow("yLoc"), oRow("myWidth"), oRow("myHeight"), oRow("TableNumber"), oRow("FloorPlanID"), True) '(true for active table deleted from sql) oRow("Active"))
        terminalPanel(i).Size = New System.Drawing.Size(oRow("myWidth"), oRow("myHeight"))
        terminalPanel(i).AssignSizeValues()

        With terminalPanel(i).tempTable
            .PhysicalTableNumber = oRow("TableNumber")
            .FloorPlanID = oRow("FloorPlanID")
            .Seats = oRow("Seats")
            .Available = oRow("Available")
            .IsRound = oRow("isRound")
            '.Active = orow("Active")   'not sure if using

        End With

        AddHandler terminalPanel(i).TableNewInfoNeeded, AddressOf TableBeingAdded
        AddHandler terminalPanel(i).TableMoved, AddressOf TableMoved_Mouse
        AddHandler terminalPanel(i).TableInfoReview, AddressOf TableBeingReviewed


        Select Case oRow("FloorPlanID")
            Case FloorPlanFirst

                Me.pnlFloorPlan1.Controls.Add(terminalPanel(i))
            Case FloorPlanSecond
                Me.pnlFloorPlan2.Controls.Add(terminalPanel(i))

        End Select

    End Sub

    Private Sub DisplayTerminals()
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("terminals").Rows
            DisplayEachTerminal(oRow, i)
            i += 1
        Next

    End Sub

    Private Sub DisplayEachTerminal(ByRef oRow As DataRow, ByVal i As Integer)

        terminalPanel(i) = New Terminal_UC("Terminal", i, oRow("TermX"), oRow("TermY"), 30, 30, oRow("TerminalID"), oRow("FloorPlanID"), True)
        terminalPanel(i).Size = New System.Drawing.Size(30, 30)

        With terminalPanel(i).tempTerminal
            .TermID = oRow("TerminalID")
            .FloorPlanID = oRow("FloorPlanID")
            .TermName = oRow("TerminalName")
            .TermMethod = oRow("TerminalMethod")
            .TermGroupID = oRow("TerminalsGroupID")
            .TermPrimaryKey = oRow("TerminalsPrimaryKey")


            If Not oRow("TerminalsGroupID") = 0 Then
                Dim gRow As DataRow
                For Each gRow In dsSetup.Tables("TermGroups").Rows
                    If gRow("TerminalsGroupID") = oRow("TerminalsGroupID") Then
                        .TermGroupName = gRow("TerminalsGroupName")
                    End If
                Next

            End If

        End With

        AddHandler terminalPanel(i).TerminalNewInfoNeeded, AddressOf TerminalBeingAdded
        AddHandler terminalPanel(i).TerminalMoved, AddressOf TerminalMoved_Mouse
        AddHandler terminalPanel(i).TerminalInfoReview, AddressOf TerminalBeingReviewed


        Select Case oRow("FloorPlanID")
            Case FloorPlanFirst

                Me.pnlFloorPlan1.Controls.Add(terminalPanel(i))
            Case FloorPlanSecond
                Me.pnlFloorPlan2.Controls.Add(terminalPanel(i))

        End Select

    End Sub

    Private Sub DisplayGroupPanels()
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("termGroups").Rows
            DisplayEachGroupPanel(oRow)
        Next

    End Sub

    Private Sub DisplayEachGroupPanel(ByRef oRow As DataRow)

        terminalGroupPanel = New TerminalGroup_UC(oRow("GroupX"), oRow("GroupY"), oRow("GroupW"), oRow("GroupH"))
        Me.pnlFloorPlan1.Controls.Add(terminalGroupPanel)

    End Sub

    Private Sub WallMoved_Mouse(ByVal ii As Integer) ' Handles WallMoved
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("TermsWalls").Rows
            If oRow("TableNumber") = terminalPanel(ii).tempWall.IndexTableNumber Then    'Term_Table_Num Then
                oRow("xLoc") = terminalPanel(ii).tempWall.xLoc
                oRow("yLoc") = terminalPanel(ii).tempWall.yLoc
                Exit For
            End If
        Next
        changedTable = True

    End Sub

    Private Sub WallBeingReviewed(ByVal ii As Integer)

        DisposeOfTerminalInfo()
        currentWallInfo = New WallInfo_UC(False, terminalPanel(ii).tempWall)
        DisplayWallInfo(currentWallInfo, ii)

    End Sub

    Private Sub WallBeingAdded() '   ByVal i As Integer)

        DisposeOfTerminalInfo()
        currentWallInfo = New WallInfo_UC(True, terminalPanel(2).tempWall)
        terminalPanel(2).tempWall.IndexTableNumber = i
        terminalPanel(2).tempWall.FloorPlanID = currentFloorPlanID
        DisplayWallInfo(currentWallInfo, 2)

    End Sub

    Private Sub TableMoved_Mouse(ByVal ii As Integer) ' Handles TerminalMoved
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("TermsTables").Rows
            If oRow("TableNumber") = terminalPanel(ii).Term_Table_Num Then
                oRow("xLoc") = terminalPanel(ii).tempTable.xLoc
                oRow("yLoc") = terminalPanel(ii).tempTable.yLoc
                Exit For
            End If
        Next
        changedTable = True

    End Sub

    Private Sub TableBeingReviewed(ByVal ii As Integer)

        DisposeOfTerminalInfo()
        currentTableInfo = New TableInfo_UC(False, terminalPanel(ii).tempTable)
        DisplayTableInfo(currentTableInfo, ii)

    End Sub

    Private Sub TableBeingAdded() ' Handles terminalPanel.TerminalNewInfoNeeded 'ByVal i As Integer) 

        DisposeOfTerminalInfo()
        currentTableInfo = New TableInfo_UC(True, terminalPanel(1).tempTable)
        terminalPanel(1).tempTable.FloorPlanID = currentFloorPlanID
        DisplayTableInfo(currentTableInfo, 1)

    End Sub

    Private Sub TerminalMoved_Mouse(ByVal ii As Integer) ' Handles TerminalMoved
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("terminals").Rows
            If oRow("TerminalID") = terminalPanel(ii).Term_Table_Num Then
                oRow("TermX") = terminalPanel(ii).tempTerminal.xLoc
                oRow("TermY") = terminalPanel(ii).tempTerminal.yLoc
                Exit For
            End If
        Next
        changedTerminal = True

    End Sub

    Private Sub TerminalBeingReviewed(ByVal ii As Integer)
        Dim oRow As DataRow

        DisposeOfTerminalInfo()
        '    If terminalPanel(ii).tempTerminal.TermPrimaryKey.ToString Is DBNull.Value Then
        '   MsgBox("here")
        '       UpdateTerminalData()
        '      changedTerminal = False
        '     PopulateTerminalData()
        '  End If

        currentTermInfo = New TerminalInfo_UC(False, terminalPanel(ii).tempTerminal)

        DisplayTermInfo(currentTermInfo, ii)

    End Sub

    Private Sub TerminalBeingAdded()    'ByVal i As Integer) 'Handles terminalPanel.TerminalNewInfoNeeded

        DisposeOfTerminalInfo()
        currentTermInfo = New TerminalInfo_UC(True, terminalPanel(0).tempTerminal)
        terminalPanel(0).tempTerminal.FloorPlanID = currentFloorPlanID

        DisplayTermInfo(currentTermInfo, 0)

    End Sub

    Private Sub DisposeOfTerminalInfo()

        Try
            If Not currentTermInfo Is Nothing Then
                currentTermInfo.Dispose()
            End If
            If Not currentTableInfo Is Nothing Then
                currentTableInfo.Dispose()
            End If
            If Not currentWallInfo Is Nothing Then
                currentWallInfo.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub NewWallAcceptedFrom_UC() Handles currentWallInfo.NewWallAccepted

        TestArray()

        Dim oRow As DataRow

        oRow = dsSetup.Tables("TermsWalls").NewRow
        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        oRow("TableNumber") = i
        oRow("FloorPlanID") = currentWallInfo.CurrentWall.FloorPlanID
        oRow("isTable") = 0
        oRow("isWall") = 1
        oRow("isOther") = 0
        oRow("isRound") = 0
        oRow("xLoc") = currentWallInfo.CurrentWall.xLoc
        oRow("yLoc") = currentWallInfo.CurrentWall.yLoc
        oRow("myWidth") = currentWallInfo.CurrentWall.myWidth
        oRow("myHeight") = currentWallInfo.CurrentWall.myHeight
        oRow("Active") = 1  'currentWallInfo.CurrentWall.Active

        dsSetup.Tables("TermsWalls").Rows.Add(oRow)

        currentWallInfo.Dispose()
        changedTable = True
        DisplayEachWall(oRow, i)
        i += 1

    End Sub

    Private Sub NewTableAcceptedFrom_UC() Handles currentTableInfo.NewTableAccepted

        Dim oRow As DataRow

        ' do a check to verify table number is not duplicated
        For Each oRow In dsSetup.Tables("TermsTables").Rows
            If oRow("TableNumber") = currentTableInfo.CurrentTable.PhysicalTableNumber Then
                MsgBox("Table " & oRow("TableNumber") & " already exists.")
                Exit Sub
            End If
        Next

        TestArray()

        oRow = dsSetup.Tables("TermsTables").NewRow
        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        oRow("TableNumber") = currentTableInfo.CurrentTable.PhysicalTableNumber
        oRow("FloorPlanID") = currentTableInfo.CurrentTable.FloorPlanID
        oRow("Seats") = currentTableInfo.CurrentTable.Seats
        oRow("Available") = currentTableInfo.CurrentTable.Available
        oRow("isTable") = 1
        oRow("isWall") = 0
        oRow("isOther") = 0
        oRow("isRound") = currentTableInfo.CurrentTable.IsRound
        oRow("xLoc") = currentTableInfo.CurrentTable.xLoc
        oRow("yLoc") = currentTableInfo.CurrentTable.yLoc
        oRow("myWidth") = currentTableInfo.CurrentTable.myWidth
        oRow("myHeight") = currentTableInfo.CurrentTable.myHeight
        '444      oRow("Active") = currentTableInfo.CurrentTable.Active

        dsSetup.Tables("TermsTables").Rows.Add(oRow)

        currentTableInfo.Dispose()
        changedTable = True
        DisplayEachTable(oRow, i)
        i += 1

    End Sub

    Private Sub NewTerminalAcceptedFrom_UC() Handles currentTermInfo.NewTerminalAccepted

        If currentTermInfo.txtTermName.Text = "" Then
            MsgBox("Incorrect Terminal Name")
            Exit Sub
        End If

        Dim oRow As DataRow
        UpdateTerminalData()    'this accepts changes as well
        TestArray()

        oRow = dsSetup.Tables("Terminals").NewRow
        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        oRow("TerminalID") = currentTermInfo.CurrentTerminal.TermID
        oRow("TerminalName") = currentTermInfo.txtTermName.Text     'currentTermInfo.CurrentTerminal.TermName
        oRow("TerminalMethod") = currentTermInfo.CurrentTerminal.TermMethod
        If currentTermInfo.CurrentTerminal.TermGroupID = Nothing Then
            oRow("TerminalsGroupID") = 0
        Else
            oRow("TerminalsGroupID") = currentTermInfo.CurrentTerminal.TermGroupID
        End If
        oRow("FloorPlanID") = currentTermInfo.CurrentTerminal.FloorPlanID
        oRow("TermX") = currentTermInfo.CurrentTerminal.xLoc
        oRow("TermY") = currentTermInfo.CurrentTerminal.yLoc

        dsSetup.Tables("Terminals").Rows.Add(oRow)
        oRow("TerminalsPrimaryKey") = InsertingNewTerminal(oRow)
        currentTermInfo.CurrentTerminal.TermPrimaryKey = oRow("TerminalsPrimaryKey")
        dsSetup.Tables("Terminals").AcceptChanges()

        i += 1
        DisplayEachTerminal(oRow, i)

    End Sub

    Private Function InsertingNewTerminal(ByRef oRow As DataRow)
        Dim newTerminalsPrimaryKey As Integer

        sql.SqlInsertCommandTerms.Parameters("@CompanyID").Value = oRow("CompanyID")
        sql.SqlInsertCommandTerms.Parameters("@LocationID").Value = oRow("LocationID")
        sql.SqlInsertCommandTerms.Parameters("@TerminalID").Value = oRow("TerminalID")
        sql.SqlInsertCommandTerms.Parameters("@TerminalName").Value = oRow("TerminalName")
        sql.SqlInsertCommandTerms.Parameters("@TerminalMethod").Value = oRow("TerminalMethod")
        sql.SqlInsertCommandTerms.Parameters("@TerminalsGroupID").Value = oRow("TerminalsGroupID")
        sql.SqlInsertCommandTerms.Parameters("@FloorPlanID").Value = oRow("FloorPlanID")
        sql.SqlInsertCommandTerms.Parameters("@TermX").Value = oRow("TermX")
        sql.SqlInsertCommandTerms.Parameters("@TermY").Value = oRow("TermY")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newTerminalsPrimaryKey = CType(sql.SqlInsertCommandTerms.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return newTerminalsPrimaryKey

    End Function

    Private Sub NewTerminalUseOrder_UC(ByVal useOrder As Integer, ByVal newUse As String) Handles currentTermInfo.NewUseOrderRow

        Dim oRow As DataRow

        oRow = dsSetup.Tables("TerminalsUseOrder").NewRow
        oRow("TerminalsPrimaryKey") = currentTermInfo.CurrentTerminal.TermPrimaryKey
        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        oRow("MethodUse") = newUse
        oRow("UsePriority") = useOrder
        oRow("Active") = 1

        dsSetup.Tables("TerminalsUseOrder").Rows.Add(oRow)

        changedTerminal = True

        '   currentTermInfo.Dispose()
        '   DisplayEachTerminal(oRow, i)
        '   i += 1

    End Sub


    Private Sub WallUpdatesAccepted() Handles currentWallInfo.UpdateOldWall
        Dim oRow As DataRow
        Dim count As Integer = 0

        For Each oRow In dsSetup.Tables("TermsWalls").Rows
            If oRow("TableNumber") = currentWallInfo.CurrentWall.IndexTableNumber Then
                '       oRow("isRound") = CInt(currentWallInfo..Text)
                oRow("xLoc") = currentWallInfo.NewWall.xLoc
                oRow("yLoc") = currentWallInfo.NewWall.yLoc
                oRow("myWidth") = currentWallInfo.NewWall.myWidth
                oRow("myHeight") = currentWallInfo.NewWall.myHeight
                Exit For
            End If
        Next

        If currentWallInfo.CurrentWall.OldWidth <> currentWallInfo.CurrentWall.myWidth Or currentWallInfo.CurrentWall.OldHeight <> currentWallInfo.CurrentWall.myHeight Then
            terminalPanel(currentWallInfo.NewWall.IndexTableNumber).Size = New System.Drawing.Size(currentWallInfo.NewWall.myWidth, currentWallInfo.NewWall.myHeight)
        End If
        If currentWallInfo.locationHasChanged = True Then
            terminalPanel(currentWallInfo.NewWall.IndexTableNumber).Location = New Point(currentWallInfo.NewWall.xLoc, currentWallInfo.NewWall.yLoc)
        End If

        changedTable = True
        currentWallInfo.Dispose()

    End Sub

    Private Sub TableUpdatesAccepted() Handles currentTableInfo.UpdateOldTable
        Dim oRow As DataRow
        Dim count As Integer = 0

        ' do a check to verify table number is not duplicated
        For Each oRow In dsSetup.Tables("TermsTables").Rows
            If oRow("TableNumber") = currentTableInfo.CurrentTable.PhysicalTableNumber Then
                count += 1
                If count = 2 Then
                    MsgBox("Table " & oRow("TableNumber") & " already exists.")
                    Exit Sub
                End If
            End If
        Next

        For Each oRow In dsSetup.Tables("TermsTables").Rows
            If oRow("TableNumber") = currentTableInfo.CurrentTable.PhysicalTableNumber Then
                oRow("Seats") = currentTableInfo.CurrentTable.Seats 'CInt(currentTableInfo.txtSeats.Text)
                oRow("Available") = (currentTableInfo.chbAvailable.Checked)
                '       oRow("isRound") = CInt(currentTableInfo..Text)
                oRow("myWidth") = currentTableInfo.CurrentTable.myWidth 'CInt(currentTableInfo.txtWidth.Text)
                oRow("myHeight") = currentTableInfo.CurrentTable.myHeight 'CInt(currentTableInfo.txtHeight.Text)
                Exit For

            End If
        Next

        If currentTableInfo.CurrentTable.OldWidth <> currentTableInfo.CurrentTable.myWidth Or currentTableInfo.CurrentTable.OldHeight <> currentTableInfo.CurrentTable.myHeight Then
            terminalPanel(currentTableInfo.CurrentTable.Index).Size = New System.Drawing.Size(currentTableInfo.CurrentTable.myWidth, currentTableInfo.CurrentTable.myHeight)
        End If

        changedTable = True
        currentTableInfo.Dispose()

    End Sub

    Private Sub TerminalUpdatesAccepted() Handles currentTermInfo.UpdateOldTerminal
        Dim oRow As DataRow

        If currentTermInfo.txtTermName.Text = "" Then
            MsgBox("Incorrect Terminal Name")
            Exit Sub
        End If

        For Each oRow In dsSetup.Tables("Terminals").Rows
            If oRow("TerminalID") = currentTermInfo.CurrentTerminal.TermID Then
                oRow("TerminalName") = currentTermInfo.txtTermName.Text
                oRow("TerminalMethod") = currentTermInfo.CurrentTerminal.TermMethod
                oRow("TerminalsGroupID") = currentTermInfo.CurrentTerminal.TermGroupID
                Exit For
            End If
        Next

        changedTerminal = True
        currentTermInfo.Dispose()

    End Sub

    Private Sub WallUpdatesCanceled() Handles currentWallInfo.WallCancel
        DisposeOfTerminalInfo()

    End Sub

    Private Sub TableUpdatesCanceled() Handles currentTableInfo.TableCancel
        DisposeOfTerminalInfo()

    End Sub

    Private Sub TerminalUpdatesCanceled() Handles currentTermInfo.TerminalCancel
        DisposeOfTerminalInfo()

    End Sub

    Private Sub DisplayWallInfo(ByRef currentWallInfo As WallInfo_UC, ByVal ii As Integer)

        Select Case terminalPanel(ii).tempWall.FloorPlanID
            Case FloorPlanFirst
                If terminalPanel(ii).Location.X < (Panel1.Width / 2) Then
                    currentWallInfo.Location = New Point(400, 100)
                Else
                    currentWallInfo.Location = New Point(50, 100)
                End If
                Me.FloorPlan1.Controls.Add(currentWallInfo)
            Case FloorPlanSecond
                If terminalPanel(ii).Location.X < (Panel2.Width / 2) Then
                    currentWallInfo.Location = New Point(400, 100)
                Else
                    currentWallInfo.Location = New Point(50, 100)
                End If
                Me.FloorPlan2.Controls.Add(currentWallInfo)

        End Select

        currentWallInfo.BringToFront()
        currentWallInfo.Focus()

    End Sub

    Private Sub DisplayTableInfo(ByRef currentTableInfo As TableInfo_UC, ByVal ii As Integer)

        Select Case terminalPanel(ii).tempTable.FloorPlanID
            Case FloorPlanFirst
                If terminalPanel(ii).Location.X < (Panel1.Width / 2) Then
                    currentTableInfo.Location = New Point(400, 100)
                Else
                    currentTableInfo.Location = New Point(50, 100)
                End If
                Me.FloorPlan1.Controls.Add(currentTableInfo)
            Case FloorPlanSecond
                If terminalPanel(ii).Location.X < (Panel2.Width / 2) Then
                    currentTableInfo.Location = New Point(400, 100)
                Else
                    currentTableInfo.Location = New Point(50, 100)
                End If
                Me.FloorPlan2.Controls.Add(currentTableInfo)

        End Select

        currentTableInfo.BringToFront()
        currentTableInfo.Focus()

    End Sub

    Private Sub DisplayTermInfo(ByRef currentTermInfo As TerminalInfo_UC, ByVal ii As Integer)

        Select Case terminalPanel(ii).tempTerminal.FloorPlanID
            Case FloorPlanFirst
                If terminalPanel(ii).Location.X < (Panel1.Width / 2) Then
                    currentTermInfo.Location = New Point(400, 100)
                Else
                    currentTermInfo.Location = New Point(50, 100)
                End If
                Me.FloorPlan1.Controls.Add(currentTermInfo)
            Case FloorPlanSecond
                If terminalPanel(ii).Location.X < (Panel2.Width / 2) Then
                    currentTermInfo.Location = New Point(400, 100)
                Else
                    currentTermInfo.Location = New Point(50, 100)
                End If
                Me.FloorPlan2.Controls.Add(currentTermInfo)

        End Select
        currentTermInfo.BringToFront()
        currentTermInfo.Focus()

    End Sub

    Private Sub tabFllorPlan1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorPlan1.Leave

        RunTerminalSavingRoutine()

    End Sub

    Private Sub tabFllorPlan2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorPlan2.Leave

        RunTerminalSavingRoutine()

    End Sub

    Private Sub RunTerminalSavingRoutine()

        If changedTerminal = True Then
            UpdateTerminalData()
            changedTerminal = False
        End If
        If changedTable = True Then
            UpdateTablesData()
            changedTable = False
        End If

    End Sub
    Private Sub UpdateTablesData()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlTermsFloor.Update(dsSetup, "TermsFloor")
            sql.SqlTermsTables.Update(dsSetup, "TermsTables")
            sql.SqlTermsWalls.Update(dsSetup, "TermsWalls")
            sql.cn.Close()

            dsSetup.Tables("TermsFloor").AcceptChanges()
            dsSetup.Tables("TermsTables").AcceptChanges()
            dsSetup.Tables("TermsWalls").AcceptChanges()

        Catch ex As Exception
            MsgBox(ex.Message)

            CloseConnection()
        End Try
    End Sub

    Private Sub UpdateTerminalData()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlTermGroups.Update(dsSetup, "TermGroups")
            sql.SqlTerms.Update(dsSetup, "Terminals")
            sql.SqlTermsUse.Update(dsSetup, "TerminalsUseOrder")
            sql.cn.Close()

            dsSetup.Tables("TermGroups").AcceptChanges()
            dsSetup.Tables("Terminals").AcceptChanges()
            dsSetup.Tables("TerminalsUseOrder").AcceptChanges()

        Catch ex As Exception
            MsgBox(ex.Message)

            CloseConnection()
        End Try
    End Sub

    Private Sub ChangeFloorPlan(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click 'FloorPlan2.MouseEnter

        If FloorPlan1.Focus = True Then
            currentFloorPlanID = 1
        ElseIf FloorPlan2.Focus = True Then
            currentFloorPlanID = 2
        End If

    End Sub

End Class
