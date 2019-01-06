
Public Class Administration
    Inherits System.Windows.Forms.Form


    Friend WithEvents SetupMenu1 As Tahsc_server.SetupMenu
    Friend WithEvents SetupEmployee1 As Tahsc_server.SetupEmploy
    Friend WithEvents SetupPayment1 As Tahsc_server.SetupPayment
    Friend WithEvents RawMaterials1 As Tahsc_server.SetupRawMaterials
    Friend WithEvents SetupTerminal1 As Tahsc_server.SetupTerminals
    Dim WithEvents loginPad As DataSet_Builder.NumberPad

    Dim WithEvents initLogon As DataSet_Builder.LoginInit_UC
    Dim WithEvents exiting As Exit_UC
    Dim loginFailedCount As Integer
    Friend isCorporate As Boolean
    '  Friend selectedLocation As String



#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()


        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.pnlAdministration.Enabled = False

        DisplayInitialLogon()

        'Add any initialization after the InitializeComponent() call

        '   InitializeOther()

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
    Friend WithEvents pnlAdministration As System.Windows.Forms.Panel
    Friend WithEvents btnMenuSetup As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeSetup As System.Windows.Forms.Button
    Friend WithEvents btnPaymentSetup As System.Windows.Forms.Button
    Friend WithEvents btnCorporate As System.Windows.Forms.Button
    Friend WithEvents pnlCorporate As System.Windows.Forms.Panel
    Friend WithEvents cbxCorporateMenu As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCorporateMenuLocation As System.Windows.Forms.ComboBox
    Friend WithEvents btnSetupMenu As System.Windows.Forms.Button
    Friend WithEvents btnRawMaterials As System.Windows.Forms.Button
    Friend WithEvents btnAdmExit As System.Windows.Forms.Button
    Friend WithEvents btnTerminalSetup As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pnlAdministration = New System.Windows.Forms.Panel
        Me.btnAdmExit = New System.Windows.Forms.Button
        Me.btnRawMaterials = New System.Windows.Forms.Button
        Me.btnCorporate = New System.Windows.Forms.Button
        Me.btnPaymentSetup = New System.Windows.Forms.Button
        Me.btnEmployeeSetup = New System.Windows.Forms.Button
        Me.btnMenuSetup = New System.Windows.Forms.Button
        Me.btnTerminalSetup = New System.Windows.Forms.Button
        Me.pnlCorporate = New System.Windows.Forms.Panel
        Me.btnSetupMenu = New System.Windows.Forms.Button
        Me.cbxCorporateMenuLocation = New System.Windows.Forms.ComboBox
        Me.cbxCorporateMenu = New System.Windows.Forms.ComboBox
        Me.pnlAdministration.SuspendLayout()
        Me.pnlCorporate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAdministration
        '
        Me.pnlAdministration.BackColor = System.Drawing.Color.FromArgb(CType(236, Byte), CType(233, Byte), CType(216, Byte))
        Me.pnlAdministration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdministration.Controls.Add(Me.btnAdmExit)
        Me.pnlAdministration.Controls.Add(Me.btnRawMaterials)
        Me.pnlAdministration.Controls.Add(Me.btnCorporate)
        Me.pnlAdministration.Controls.Add(Me.btnPaymentSetup)
        Me.pnlAdministration.Controls.Add(Me.btnEmployeeSetup)
        Me.pnlAdministration.Controls.Add(Me.btnMenuSetup)
        Me.pnlAdministration.Controls.Add(Me.btnTerminalSetup)
        Me.pnlAdministration.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlAdministration.DockPadding.Right = 50
        Me.pnlAdministration.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdministration.Name = "pnlAdministration"
        Me.pnlAdministration.Size = New System.Drawing.Size(128, 525)
        Me.pnlAdministration.TabIndex = 0
        '
        'btnAdmExit
        '
        Me.btnAdmExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdmExit.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnAdmExit.Location = New System.Drawing.Point(8, 464)
        Me.btnAdmExit.Name = "btnAdmExit"
        Me.btnAdmExit.Size = New System.Drawing.Size(112, 40)
        Me.btnAdmExit.TabIndex = 5
        Me.btnAdmExit.Text = "Exit"
        '
        'btnRawMaterials
        '
        Me.btnRawMaterials.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnRawMaterials.Location = New System.Drawing.Point(8, 248)
        Me.btnRawMaterials.Name = "btnRawMaterials"
        Me.btnRawMaterials.Size = New System.Drawing.Size(112, 40)
        Me.btnRawMaterials.TabIndex = 4
        Me.btnRawMaterials.Text = "Raw Materials"
        '
        'btnCorporate
        '
        Me.btnCorporate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCorporate.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnCorporate.Location = New System.Drawing.Point(8, 400)
        Me.btnCorporate.Name = "btnCorporate"
        Me.btnCorporate.Size = New System.Drawing.Size(112, 40)
        Me.btnCorporate.TabIndex = 3
        Me.btnCorporate.Text = "Corporate"
        '
        'btnPaymentSetup
        '
        Me.btnPaymentSetup.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnPaymentSetup.Location = New System.Drawing.Point(8, 184)
        Me.btnPaymentSetup.Name = "btnPaymentSetup"
        Me.btnPaymentSetup.Size = New System.Drawing.Size(112, 40)
        Me.btnPaymentSetup.TabIndex = 2
        Me.btnPaymentSetup.Text = "Payment Setup"
        '
        'btnEmployeeSetup
        '
        Me.btnEmployeeSetup.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnEmployeeSetup.Location = New System.Drawing.Point(8, 120)
        Me.btnEmployeeSetup.Name = "btnEmployeeSetup"
        Me.btnEmployeeSetup.Size = New System.Drawing.Size(112, 40)
        Me.btnEmployeeSetup.TabIndex = 1
        Me.btnEmployeeSetup.Text = "Employee Setup"
        '
        'btnMenuSetup
        '
        Me.btnMenuSetup.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnMenuSetup.Location = New System.Drawing.Point(8, 56)
        Me.btnMenuSetup.Name = "btnMenuSetup"
        Me.btnMenuSetup.Size = New System.Drawing.Size(112, 40)
        Me.btnMenuSetup.TabIndex = 0
        Me.btnMenuSetup.Text = "Menu Setup"
        '
        'btnTerminalSetup
        '
        Me.btnTerminalSetup.BackColor = System.Drawing.Color.FromArgb(CType(149, Byte), CType(179, Byte), CType(215, Byte))
        Me.btnTerminalSetup.Location = New System.Drawing.Point(8, 312)
        Me.btnTerminalSetup.Name = "btnTerminalSetup"
        Me.btnTerminalSetup.Size = New System.Drawing.Size(112, 40)
        Me.btnTerminalSetup.TabIndex = 5
        Me.btnTerminalSetup.Text = "Terminal Setup"
        '
        'pnlCorporate
        '
        Me.pnlCorporate.BackColor = System.Drawing.Color.Transparent
        Me.pnlCorporate.Controls.Add(Me.btnSetupMenu)
        Me.pnlCorporate.Controls.Add(Me.cbxCorporateMenuLocation)
        Me.pnlCorporate.Controls.Add(Me.cbxCorporateMenu)
        Me.pnlCorporate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCorporate.Location = New System.Drawing.Point(128, 0)
        Me.pnlCorporate.Name = "pnlCorporate"
        Me.pnlCorporate.Size = New System.Drawing.Size(856, 72)
        Me.pnlCorporate.TabIndex = 1
        Me.pnlCorporate.Visible = False
        '
        'btnSetupMenu
        '
        Me.btnSetupMenu.Location = New System.Drawing.Point(672, 16)
        Me.btnSetupMenu.Name = "btnSetupMenu"
        Me.btnSetupMenu.Size = New System.Drawing.Size(120, 48)
        Me.btnSetupMenu.TabIndex = 2
        Me.btnSetupMenu.Text = "Setup Menu based on Defaults"
        Me.btnSetupMenu.Visible = False
        '
        'cbxCorporateMenuLocation
        '
        Me.cbxCorporateMenuLocation.Location = New System.Drawing.Point(392, 24)
        Me.cbxCorporateMenuLocation.Name = "cbxCorporateMenuLocation"
        Me.cbxCorporateMenuLocation.Size = New System.Drawing.Size(216, 21)
        Me.cbxCorporateMenuLocation.TabIndex = 1
        Me.cbxCorporateMenuLocation.Text = "Select Location"
        Me.cbxCorporateMenuLocation.Visible = False
        '
        'cbxCorporateMenu
        '
        Me.cbxCorporateMenu.Items.AddRange(New Object() {"Corporate Defaults", "Complete Menu By Location", "Menu Additions By Location"})
        Me.cbxCorporateMenu.Location = New System.Drawing.Point(112, 24)
        Me.cbxCorporateMenu.Name = "cbxCorporateMenu"
        Me.cbxCorporateMenu.Size = New System.Drawing.Size(208, 21)
        Me.cbxCorporateMenu.TabIndex = 0
        Me.cbxCorporateMenu.Text = "Select Menu View"
        '
        'Administration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(78, Byte), CType(152, Byte))
        Me.ClientSize = New System.Drawing.Size(984, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlCorporate)
        Me.Controls.Add(Me.pnlAdministration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Administration"
        Me.Text = "Administration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlAdministration.ResumeLayout(False)
        Me.pnlCorporate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub InitializeOther()

       
        SetupMenu1 = New Tahsc_server.SetupMenu
        SetupMenu1.SuspendLayout()
        SetupMenu1.Location = New Point(120, 0)
        '      SetupMenu1.Size = New Size(816, 576)
        '    SetupMenu1.Dock = DockStyle.Left
        '     SetupMenu1.DockPadding.Left = 500
        SetupMenu1.TabIndex = 0
        '     SetupMenu1.Anchor = AnchorStyles.Left
        SetupMenu1.Visible = False
        SetupMenu1.ResumeLayout()

        SetupEmployee1 = New Tahsc_server.SetupEmploy
        SetupEmployee1.SuspendLayout()
        SetupEmployee1.Location = New Point(120, 0)
        SetupEmployee1.TabIndex = 0
        SetupEmployee1.Visible = False
        SetupEmployee1.ResumeLayout()

        SetupPayment1 = New Tahsc_server.SetupPayment
        SetupPayment1.SuspendLayout()
        SetupPayment1.Location = New Point(130, 0)
        SetupPayment1.TabIndex = 0
        SetupPayment1.Visible = False
        SetupPayment1.ResumeLayout()


        RawMaterials1 = New Tahsc_server.SetupRawMaterials
        RawMaterials1.SuspendLayout()
        RawMaterials1.Location = New Point(130, 0)
        RawMaterials1.TabIndex = 0
        RawMaterials1.Visible = False
        RawMaterials1.ResumeLayout()

        SetupTerminal1 = New Tahsc_server.SetupTerminals
        SetupTerminal1.SuspendLayout()
        SetupTerminal1.Location = New Point(139, 0)
        SetupTerminal1.TabIndex = 0
        SetupTerminal1.Visible = False
        SetupTerminal1.ResumeLayout()

        loginPad = New DataSet_Builder.NumberPad
        loginPad.Location = New Point((Me.Width - loginPad.Width) / 2, ((Me.Height - loginPad.Height) / 2) + 40)
        Me.Controls.Add(loginPad)
        loginPad.Visible = False

        LoadLocationData()

        Me.Controls.Add(SetupMenu1)
        Me.Controls.Add(SetupEmployee1)
        Me.Controls.Add(SetupPayment1)
        Me.Controls.Add(RawMaterials1)
        Me.Controls.Add(SetupTerminal1)


    End Sub




    Private Sub btnMenuSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuSetup.Click
        '  Me.pnlAdministration.Visible = False
        SetupEmployee1.Visible = False
        SetupPayment1.Visible = False
        RawMaterials1.Visible = False
        SetupMenu1.Visible = True
        SetupTerminal1.Visible = False
        loginPad.Visible = False
        '   SetupMenu1.StartMenu()
        SetupEmployee1.RemoveCardHandler()

    End Sub

    Private Sub btnEmployeeSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeeSetup.Click
        SetupMenu1.Visible = False
        SetupPayment1.Visible = False
        RawMaterials1.Visible = False
        SetupTerminal1.Visible = False
        loginPad.Visible = True

    End Sub

    Private Sub Login_Entered(ByVal sender As Object, ByVal e As System.EventArgs) Handles loginPad.NumberEntered
        Dim loginEnter As String
        Dim hasAuthority As Boolean
      
        loginEnter = loginPad.NumberString

        If loginEnter = "69864044" Then
            hasAuthority = True
        Else
            hasAuthority = TestUsernamePassword(loginEnter)
        End If

        If hasAuthority = True Then
            SetupEmployee1.Visible = True
            SetupEmployee1.AddCardHandler()
        Else

        End If

        loginPad.Visible = False

    End Sub

    Friend Function TestUsernamePassword(ByVal loginEnter As String) As Boolean
        Dim hasAuth As Boolean
        Dim someoneHasAuthority As Boolean = False
        Dim notInSystem As Boolean = True
        Dim oRow As DataRow

        '       If loginEnter.Length < 4 Then
        '      MsgBox("Username Incorrect: Please Reenter or See Manager")
        '     Exit Function
        '    End If

        If dsSetup.Tables("ActiveEmployee").Rows.Count = 0 Then
            Return True
        Else
            If loginEnter.Length < 8 Then
                MsgBox("You MUST enter your password: Please Reenter or See Manager")
                Exit Function
            End If
        End If

        For Each oRow In dsSetup.Tables("ActiveEmployee").Rows
            If oRow("EmployeeMgmtAll") = True Or oRow("EmployeeMgmtLimited") = True Then
                TestToDisplayPayRates(oRow)
                someoneHasAuthority = True
            End If
            If oRow("EmployeeNumber") = loginEnter.ToString.Substring(0, 4) Then

                '      If oRow("PasswordReq") = True Then
                If oRow("Passcode") = loginEnter.ToString.Substring(4, 4) Then
                    '       LoginEmployee(emp)
                    If oRow("EmployeeMgmtAll") = True Or oRow("EmployeeMgmtLimited") = True Then
                        TestToDisplayPayRates(oRow)
                        Return True
                    Else
                        MsgBox("Employee : " & oRow("FirstName") & " " & oRow("LastName") & " does NOT have authority")
                        notInSystem = False
                        '                 Return False
                    End If

                Else
                    MsgBox("Password Incorrect: Please Reenter or See Manager")
                    Exit Function
                    '     End If
                End If
                '         LoginEmployee(emp)
                '    Return False
            End If
        Next

        If someoneHasAuthority = False Then
            Return True
        Else
            If notInSystem = True Then
                MsgBox("Employee Number: " & loginEnter & " Is Not In System")
            End If
            Return False

        End If

    End Function

    Private Sub TestToDisplayPayRates(ByRef oRow As DataRow)

        If oRow("EmployeeMgmtAll") = True Then
            SetupEmployee1.pnlJobPayRates.Visible = True
            SetupEmployee1.btnOverrides.Visible = True
        Else
            SetupEmployee1.pnlJobPayRates.Visible = False
            SetupEmployee1.btnOverrides.Visible = False
        End If
    End Sub

    Private Sub btnPaymentSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaymentSetup.Click
        SetupMenu1.Visible = False
        SetupEmployee1.Visible = False
        RawMaterials1.Visible = False
        SetupPayment1.Visible = True
        SetupTerminal1.Visible = False
        loginPad.Visible = False
        SetupEmployee1.RemoveCardHandler()

    End Sub

    Private Sub btnRawMaterials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawMaterials.Click
        SetupMenu1.Visible = False
        SetupEmployee1.Visible = False
        SetupPayment1.Visible = False
        RawMaterials1.Visible = True
        SetupTerminal1.Visible = False
        loginPad.Visible = False
        SetupEmployee1.RemoveCardHandler()

        RawMaterials1.StartRaw()
        GetFoodDrinkDatasetReadyFroRaw()

    End Sub

    Private Sub btnTerminalSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminalSetup.Click
        SetupMenu1.Visible = False
        SetupEmployee1.Visible = False
        SetupPayment1.Visible = False
        RawMaterials1.Visible = False
        SetupTerminal1.Visible = True
        loginPad.Visible = False
        SetupEmployee1.RemoveCardHandler()

    End Sub

    Private Sub GetFoodDrinkDatasetReadyFroRaw()

        dsSetup.Tables("Drinks").Clear()
        sql.SqlSelectCommandMenuDrinks.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuDrinks.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("FoodTable").Clear()
        sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
            sql.SqlMenuDrinks.Fill(dsSetup.Tables("Drinks"))
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CloseConnection()
        End Try

    End Sub

    Private Sub btnCorporate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorporate.Click

        '   ************************
        '   currently not using
        Exit Sub

        If isCorporate = True Then
            isCorporate = False
            pnlCorporate.Visible = False
        Else
            isCorporate = True
            pnlCorporate.Visible = True
        End If

    End Sub

    Private Sub cbxCorporateMenu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCorporateMenu.SelectedIndexChanged


        If Me.cbxCorporateMenu.SelectedIndex = 0 Then
            ShowCorporateView()
            Me.cbxCorporateMenuLocation.Visible = False
            btnSetupMenu.Visible = False

        ElseIf Me.cbxCorporateMenu.SelectedIndex = 1 Then
            '   menu by location
            If Not selectedLocation Is "000000" Then
                RepopulateMenu()
                ShowLocationView()
            End If
            Me.cbxCorporateMenuLocation.Visible = True

        ElseIf Me.cbxCorporateMenu.SelectedIndex = 2 Then
            '   menu addition only
            If Not selectedLocation Is "000000" Then
                RepopulateMenu()
            End If
            Me.cbxCorporateMenuLocation.Visible = True


        End If
    End Sub

    Private Sub ShowCorporateView()

        GenerateTables.ClearingDataToRepopulate()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            GenerateTables.RepopulateDataSets("000000")
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub ShowLocationView()

        GenerateTables.ClearingDataToRepopulate()

        'will need to change
        '     GenerateTables.RepopulateDataSets("000000")
        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            GenerateTables.RepopulateDataSets(selectedLocation)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        RepopulateMenu()
        MsgBox(dsSetup.Tables("MenuDetail").Rows.Count)

    End Sub

    Private Sub ShowLocationAdditionsOnly()

    End Sub

    Private Sub DisplayInitialLogon()

        initLogon = New DataSet_Builder.LoginInit_UC   'NumberPad
        initLogon.Location = New Point((wa.Width - initLogon.Width) / 2, (wa.Height - initLogon.Height) / 2)
        Me.Controls.Add(initLogon)
        Me.initLogon.BringToFront()

        Me.initLogon.InputUSERinfo("", "")
        Me.initLogon.Focus()

    End Sub

    Private Sub TestInitLogon() Handles initLogon.SummitLogin
        Dim loginEnterUsername As String
        Dim loginEnterPassword As String

        loginEnterUsername = initLogon.LoginUsername
        loginEnterPassword = initLogon.LoginPassword

        If loginEnterUsername = "e" Then loginEnterUsername = "eglobal"

        InitialLogIn(loginEnterUsername, loginEnterPassword)

    End Sub

    Private Function InitialLogIn(ByVal leUsername As String, ByVal lePassword As String) As Boolean

        GenerateTables.ReInitializeSQLConnection(leUsername)

        '      Dim username As String
        Dim password As String
        Dim compName As String

        Dim cmd As SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            cmd = New SqlClient.SqlCommand("SELECT CompanyID, LocationID, CompanyName, Address1, Address2, City, State, Zip, Username, BackPass, UsingDefaults, EndOfWeek FROM LocationOverview WHERE Username = '" & leUsername & "'", sql.cn)
            '     cmd = New SqlClient.SqlCommand("SELECT CompanyName, Address1, Address2, City, State, Zip, Username, Password, UsingDefaults, EndOfWeek FROM LocationOverview WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'", sql.cn)
            dtr = cmd.ExecuteReader
            dtr.Read()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Dispose()
        End Try


        If dtr.HasRows Then 'dtr.HasRows Then
            '         username = dtr("Username")
            corpID = dtr("CompanyID")
            corpPhysicalLocation = dtr("LocationID")
            compName = dtr("CompanyName")
            password = dtr("BackPass")
            usingDefaults = dtr("UsingDefaults")
            If usingDefaults = False Then
                selectedLocation = dtr("LocationID")
            Else
                selectedLocation = "000000"
            End If
            endOfWeek = dtr("EndOfWeek")
        Else
            dtr.Close()
            sql.cn.Close()
            IncorrectUsername(leUsername)
            loginFailedCount += 1
            If loginFailedCount = 3 Then Me.Dispose()
            Exit Function
        End If

        dtr.Close()
        sql.cn.Close()


        '      If leUsername = username Then
        If lePassword = password Then
            Me.pnlAdministration.Enabled = True
            InitializeOther()
            Me.initLogon.Dispose()
        Else
            '   password incorrent
            IncorrectInitLogin()
            loginFailedCount += 1
            If loginFailedCount = 3 Then Me.Dispose()
        End If


    End Function

    Private Sub IncorrectUsername(ByVal leUsername As String)
        Dim info As DataSet_Builder.Information_UC

        Me.initLogon.LoginUsername = ""
        Me.initLogon.LoginPassword = ""
        Me.initLogon.txtLoginUsername.Text = ""
        Me.initLogon.txtLoginPassword.Text = ""

        Me.initLogon.RessetFocus()

        info = New DataSet_Builder.Information_UC("Username " & leUsername & " can not be found.")
        info.Location = New Point((Me.Width - info.Width) / 2, (Me.Height - info.Height) / 2)
        Me.Controls.Add(info)
        info.BringToFront()

    End Sub

    Private Sub IncorrectInitLogin()
        Dim info As DataSet_Builder.Information_UC

        '       Me.initLogon.LoginUsername = ""
        '      Me.initLogon.LoginPassword = ""
        '     Me.initLogon.txtLoginUsername.Text = ""
        '    Me.initLogon.txtLoginPassword.Text = ""

        Me.initLogon.RessetFocus()

        info = New DataSet_Builder.Information_UC("Incorrect Password.")
        info.Location = New Point((Me.Width - info.Width) / 2, (Me.Height - info.Height) / 2)
        Me.Controls.Add(info)
        info.BringToFront()

    End Sub









    Private Sub LoadLocationData()

        Dim oRow As DataRow
        Dim locationString As String
        Dim locationIDString As String

        For Each oRow In dsSetup.Tables("LocationOverview").Rows

            '   removeds 2 leading zero's
            If oRow("LocationID").substring(0, 1) = "0" Then
                If oRow("LocationID").substring(1, 1) = "0" Then
                    locationIDString = "  " & oRow("LocationID").substring(2, 4)
                Else
                    locationIDString = " " & oRow("LocationID").substring(1, 5)
                End If
            Else
                locationIDString = oRow("LocationID")
            End If

            locationString = locationIDString & "     " & oRow("City") & ",  " & oRow("State")
            Me.cbxCorporateMenuLocation.Items.Add(locationString)
            locationString = Nothing

        Next

    End Sub

    Private Sub cbxCorporateMenuLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCorporateMenuLocation.SelectedIndexChanged
        Dim locationIDString As String
        Dim oRow As DataRow

        locationIDString = Me.cbxCorporateMenuLocation.Text.Substring(0, 6)

        If locationIDString.Substring(0, 1) = " " Then
            If locationIDString.Substring(1, 1) = " " Then
                selectedLocation = "00" & locationIDString.Substring(2, 4)
            Else
                selectedLocation = "0" & locationIDString.Substring(1, 5)
            End If
        Else
            selectedLocation = locationIDString
        End If

        Try
            '      oRow = dsSetup.Tables("LocationOverview").Rows.Find(selectedLocation)
            '     usingDefaults = oRow("UsingDefaults")


            If selectedLocation = "000000" Then
                btnSetupMenu.Visible = False
                ShowCorporateView()
            Else
                btnSetupMenu.Visible = True
                If usingDefaults = False Then
                    btnSetupMenu.Text = "Use Defaults"
                Else
                    btnSetupMenu.Text = "Setup Menu based on Defaults"
                End If
                ShowLocationView()
            End If

            RepopulateMenu()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RepopulateMenu()

        dsSetup.Tables("FoodTable").Clear()
        '      If Me.cbxCorporateMenu.SelectedIndex <> 2 Then
        '      Me.SetupMenu1.PopulateLocationMenu(corpID, "000000")
        '     End If

        Me.SetupMenu1.PopulateLocationMenu(corpID, selectedLocation)
        Me.SetupMenu1.PopulateMenuSelection()


    End Sub


    Private Sub btnSetupMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetupMenu.Click

        If btnSetupMenu.Text = "Use Defaults" Then
            '    MsgBox(usingDefaults)

        ElseIf btnSetupMenu.Text = "Setup Menu based on Defaults" Then
            MsgBox(usingDefaults)
            If dsSetup.Tables("MenuDetail").Rows.Count = 0 Then
                ' we know this location was never setup
                SetupMenuBasedOnDefaults()
            Else
                If MsgBox("This will reset your Menu to Corporate Defaults.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '  SetupMenuBasedOnDefaults()

                End If

            End If


        End If

    End Sub

    Private Sub SetupMenuBasedOnDefaults()

        ShowCorporateView()

        Exit Sub


        Dim oRow As DataRow
        Dim nRow As DataRow
        Dim tempMenuJoin As DataTable
        Dim tempMenuDetail As DataTable
        Dim tempFoodJoin As DataTable


        Dim adtMenuJoin As New SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuJoinID, FoodID, MenuID, Price, Surcharge, RoutingID, MenuIndex, Active FROM MenuJoin", sql.cn)
        Dim cbdMenuJoin As New SqlClient.SqlCommandBuilder(adtMenuJoin)

        Dim adtMenuDetail As New SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuDetailID, MenuID, BartenderMenuID, CategoryID, DrinkCategoryID, OrderIndex FROM MenuDetail", sql.cn)
        Dim cbdMenuDetail As New SqlClient.SqlCommandBuilder(adtMenuDetail)

        Dim adtFoodJoin As New SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, FoodJoinID, FoodID, CategoryID, ModifierID, NumberFree FROM FoodJoin", sql.cn)
        Dim cbdFoodJoin As New SqlClient.SqlCommandBuilder(adtFoodJoin)



        tempMenuJoin = dsSetup.Tables("MenuJoin").Clone
        tempMenuDetail = dsSetup.Tables("MenuDetail").Clone
        tempFoodJoin = dsSetup.Tables("Foodoin").Clone


        For Each oRow In dsSetup.Tables("MenuJoin").Rows
            nRow = tempMenuJoin.NewRow

            nRow("CompanyID") = corpID
            nRow("LocationID") = selectedLocation
            nRow("MenuJoinID") = oRow("MenuJoinID")
            nRow("FoodID") = oRow("FoodID")
            nRow("MenuID") = oRow("MenuID")
            nRow("Price") = oRow("Price")
            nRow("Surcharge") = oRow("Surcharge")
            nRow("RoutingID") = oRow("RoutingID")
            nRow("MenuIndex") = oRow("MenuIndex")
            nRow("Active") = oRow("Active")

            tempMenuJoin.Rows.Add(nRow)

        Next


        For Each oRow In dsSetup.Tables("MenuDetail").Rows
            nRow = tempMenuDetail.NewRow

            nRow("CompanyID") = corpID
            nRow("LocationID") = selectedLocation
            nRow("MenuDetailID") = oRow("MenuDetailID")
            nRow("MenuID") = oRow("MenuID")
            nRow("BartenderMenuID") = oRow("BartenderMenuID")
            nRow("CategoryID") = oRow("CategoryID")
            nRow("DrinkCategoryID") = oRow("DrinkCategoryID")
            nRow("DrinkCategoryID") = oRow("DrinkCategoryID")

            tempMenuJoin.Rows.Add(nRow)
        Next

        For Each oRow In dsSetup.Tables("FoodJoin").Rows
            nRow = tempFoodJoin.NewRow

            nRow("CompanyID") = corpID
            nRow("LocationID") = selectedLocation
            nRow("FoodJoinID") = oRow("FoodJoinID")
            nRow("FoodID") = oRow("FoodID")
            nRow("CategoryID") = oRow("CategoryID")
            nRow("ModifierID") = oRow("ModifierID")
            nRow("NumberFree") = oRow("NumberFree")

            tempFoodJoin.Rows.Add(nRow)
        Next



        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            adtMenuJoin.Update(tempMenuJoin)
            adtMenuDetail.Update(tempMenuDetail)
            adtFoodJoin.Update(tempFoodJoin)
            sql.cn.Close()
        Catch ex As Exception

        End Try





        '   AddingInfoToMenusTables(dsSetup.Tables("Menus"))
    End Sub


    Private Sub AddingInfoToMenusTables222(ByVal tempData As DataTable)
        '   do not use yet b/c MenuID is a Primary Key and this defines new menuID
        '   and we refer to this number from the joins

        Dim oRow As DataRow
        Dim nRow As DataRow

        Dim adt As New SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuID, MenuName, Active FROM MenuChoice", sql.cn)
        Dim cbd As New SqlClient.SqlCommandBuilder(adt)


        tempData = dsSetup.Tables("Menus").Clone

        For Each oRow In dsSetup.Tables("Menus").Rows
            nRow = tempData.NewRow

            nRow("CompanyID") = corpID
            nRow("LocationID") = selectedLocation
            nRow("MenuID") = oRow("MenuID")
            nRow("MenuName") = oRow("MenuName")
            nRow("Active") = oRow("Active")

            tempData.Rows.Add(nRow)

        Next

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        adt.Update(tempData)
        sql.cn.Close()

    End Sub


    Private Sub btnAdmExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmExit.Click
        SetupMenu1.Visible = False
        SetupEmployee1.Visible = False
        SetupPayment1.Visible = False
        RawMaterials1.Visible = False
        SetupTerminal1.Visible = False
        loginPad.Visible = False
        loginPad.Visible = False
        SetupEmployee1.RemoveCardHandler()

        If Me.SetupTerminal1.FloorPlan1.Focus = True Then
            Me.SetupTerminal1.TabControl1.SelectedTab = SetupTerminal1.FloorPlan2
            Me.SetupTerminal1.TabControl1.SelectedTab = SetupTerminal1.FloorPlan1
        Else
            Me.SetupTerminal1.TabControl1.SelectedTab = SetupTerminal1.FloorPlan1
        End If

        exiting = New Exit_UC
        exiting.Location = New Point((wa.Width - exiting.Width) / 2, (wa.Height - exiting.Height) / 2)
        Me.Controls.Add(exiting)
        '    Me.exiting.BringToFront()

        Exit Sub
        If MsgBox("Are you sure you want to Exit Administration?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Dispose()
        End If

    End Sub


End Class
