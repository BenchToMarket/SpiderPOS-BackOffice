Public Class PromoCategoryBox
    Inherits System.Windows.Forms.UserControl

    Dim PromoCatBoxCurrencyMan As CurrencyManager
    '   Dim promoDataHelper As New DataSet_Builder.SQLHelper

    Private _fdFlag As String
    Private _promoID As Integer
    Private _positionIndex As Integer
    Private _primaryTable As DataTable
    Private _supportingTable As DataTable
    Private _primaryColumn As String
    Private _newRowFlag As Boolean


    Friend Property FoodDrink_Flag() As String
        Get
            Return _fdFlag
        End Get
        Set(ByVal Value As String)
            _fdFlag = Value
        End Set
    End Property

    Friend Property PromoID() As Integer
        Get
            Return _promoID
        End Get
        Set(ByVal Value As Integer)
            _promoID = Value
        End Set
    End Property

    Friend Property PositionIndex() As Integer
        Get
            Return _positionIndex
        End Get
        Set(ByVal Value As Integer)
            _positionIndex = Value
        End Set
    End Property

    Friend Property PrimaryTable() As DataTable
        Get
            Return _primaryTable
        End Get
        Set(ByVal Value As DataTable)
            _primaryTable = Value
        End Set
    End Property

    Friend Property SupportingTable() As DataTable
        Get
            Return _supportingTable
        End Get
        Set(ByVal Value As DataTable)
            _supportingTable = Value
        End Set
    End Property

    Friend Property PrimaryColumn() As String
        Get
            Return _primaryColumn
        End Get
        Set(ByVal Value As String)
            _primaryColumn = Value
        End Set
    End Property

    Friend Property NewRowFlag() As Boolean
        Get
            Return _newRowFlag
        End Get
        Set(ByVal Value As Boolean)
            _newRowFlag = Value
        End Set
    End Property

    Event AddingPromoRow(ByRef oRow As DataRow)


#Region " Windows Form Designer generated code "

    Public Sub New() '(ByVal fd As String, ByRef primTable As DataTable, ByRef secTable As DataTable)
        MyBase.New()

        '     _fdFlag = fd
        '    _primaryTable = primTable
        '   _secondaryTable = secTable

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        '     InitializeOther()

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
    Friend WithEvents cbxPromoCatBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnPromoCatBox As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbxPromoCatBox = New System.Windows.Forms.ComboBox
        Me.btnPromoCatBox = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cbxPromoCatBox
        '
        Me.cbxPromoCatBox.Location = New System.Drawing.Point(0, 0)
        Me.cbxPromoCatBox.Name = "cbxPromoCatBox"
        Me.cbxPromoCatBox.Size = New System.Drawing.Size(136, 21)
        Me.cbxPromoCatBox.TabIndex = 0
        '
        'btnPromoCatBox
        '
        Me.btnPromoCatBox.Location = New System.Drawing.Point(136, 0)
        Me.btnPromoCatBox.Name = "btnPromoCatBox"
        Me.btnPromoCatBox.Size = New System.Drawing.Size(24, 24)
        Me.btnPromoCatBox.TabIndex = 1
        '
        'PromoCategoryBox
        '
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.Controls.Add(Me.btnPromoCatBox)
        Me.Controls.Add(Me.cbxPromoCatBox)
        Me.Name = "PromoCategoryBox"
        Me.Size = New System.Drawing.Size(160, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Friend Sub InitializeUserControl()

        PromoCatBoxCurrencyMan = BindingContext(PrimaryTable)
        PromoCatBoxCurrencyMan.Position = PositionIndex

        If FoodDrink_Flag = "F" Then
            PopulateForFood()

        ElseIf FoodDrink_Flag = "D" Then
            PopulateForDrink()

        End If

    End Sub

    Private Sub PopulateForFood()
        Dim oRow As DataRow

        Me.btnPromoCatBox.Text = "F"

        Me.cbxPromoCatBox.Items.Clear()
        For Each oRow In dsSetup.Tables("MainCategory").Rows
            cbxPromoCatBox.Items.Add(oRow("CategoryName"))
        Next

        If Me.NewRowFlag = False Then
            If Not SupportingTable.Rows(Me.PromoCatBoxCurrencyMan.Position)("CategoryName") Is DBNull.Value Then
                Me.cbxPromoCatBox.Text = SupportingTable.Rows(Me.PromoCatBoxCurrencyMan.Position)("CategoryName") 'CurrentRow("CategoryName")
            Else
                Me.cbxPromoCatBox.SelectedIndex = -1
            End If
        End If
        '    Me.cbxPromoCatBox.DataBindings.Clear()
        '   Me.cbxPromoCatBox.DataBindings.Add("Text", PrimaryTable, "CategoryName")

    End Sub

    Private Sub PopulateForDrink()
        Dim oRow As DataRow

        Me.btnPromoCatBox.Text = "D"

        Me.cbxPromoCatBox.Items.Clear()
        For Each oRow In dsSetup.Tables("DrinkCategory").Rows
            cbxPromoCatBox.Items.Add(oRow("DrinkCategoryName"))
        Next

        If Me.NewRowFlag = False Then
            If Not SupportingTable.Rows(Me.PromoCatBoxCurrencyMan.Position)("CategoryName") Is DBNull.Value Then
                Me.cbxPromoCatBox.Text = SupportingTable.Rows(Me.PromoCatBoxCurrencyMan.Position)("CategoryName") 'CurrentRow("DrinkCategoryName")
            Else
                Me.cbxPromoCatBox.SelectedIndex = -1
            End If
        End If
        '    Me.cbxPromoCatBox.DataBindings.Clear()
        '   Me.cbxPromoCatBox.DataBindings.Add("Text", PrimaryTable, "DrinkCategoryName")

    End Sub

    Private Sub btnPromoCatBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromoCatBox.Click
        If FoodDrink_Flag = "F" Then
            PopulateForDrink()

            _fdFlag = "D"

        ElseIf FoodDrink_Flag = "D" Then
            PopulateForFood()

            _fdFlag = "F"

        End If

    End Sub

    Private Sub cbxPromoCatBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPromoCatBox.SelectionChangeCommitted
        Dim valueCatID As Integer
        Dim valueCatName As String

        If NewRowFlag = True Then
            Dim oRow As DataRow

            oRow = PrimaryTable.NewRow

            oRow("CompanyID") = corpID
            oRow("LocationID") = selectedLocation
            oRow("PromoID") = PromoID

            If Me.FoodDrink_Flag = "F" Then
                valueCatID = dsSetup.Tables("MainCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("CategoryID")
                valueCatName = dsSetup.Tables("MainCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("CategoryName")

                oRow(PrimaryColumn & "FD_flag") = "F"
                '        oRow("CategoryName") = valueCatName
                oRow(PrimaryColumn & "CategoryID") = valueCatID
            Else
                valueCatID = dsSetup.Tables("DrinkCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("DrinkCategoryID")
                valueCatName = dsSetup.Tables("DrinkCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("DrinkCategoryName")

                '     oRow(PrimaryColumn & "FD_flag") = "D"
                oRow("DrinkCategoryName") = valueCatName
                oRow(PrimaryColumn & "DrinkCategoryID") = valueCatID
            End If
            '      PrimaryTable.Rows.Add(oRow)
            '        UpdatePromoData(oRow)
            RaiseEvent AddingPromoRow(oRow)
            NewRowFlag = False

        Else

            If Me.FoodDrink_Flag = "F" Then
                valueCatID = dsSetup.Tables("MainCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("CategoryID")
                valueCatName = dsSetup.Tables("MainCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("CategoryName")

                '        PrimaryTable.Rows(PositionIndex)("CategoryName") = valueCatName
                PrimaryTable.Rows(PositionIndex)(PrimaryColumn & "CategoryID") = valueCatID
                PrimaryTable.Rows(PositionIndex)(PrimaryColumn & "FD_flag") = "F"
            Else
                valueCatID = dsSetup.Tables("DrinkCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("DrinkCategoryID")
                valueCatName = dsSetup.Tables("DrinkCategory").Rows(Me.cbxPromoCatBox.SelectedIndex)("DrinkCategoryName")

                '       PrimaryTable.Rows(PositionIndex)("DrinkCategoryName") = valueCatName
                PrimaryTable.Rows(PositionIndex)(PrimaryColumn & "DrinkCategoryID") = valueCatID
                PrimaryTable.Rows(PositionIndex)(PrimaryColumn & "FD_flag") = "D"
            End If

        End If

    End Sub



    Private Sub UpdatePromoData(ByRef oRow As DataRow)

        If PrimaryTable Is dsSetup.Tables("PromoCombo") Then
            Try
                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlPromoCombo.Update(PrimaryTable)
                sql.cn.Close()
            Catch ex As Exception
                CloseConnection()
            End Try

        End If

    End Sub

End Class
