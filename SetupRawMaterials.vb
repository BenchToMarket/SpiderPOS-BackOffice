Public Class SetupRawMaterials
    Inherits System.Windows.Forms.UserControl

    ' Dim sql As New DataSet_Builder.SQLHelper
    '   Dim sqlrm As New DataSet_Builder.SQLHelperRaw

    Dim RawCurrencyMan As CurrencyManager
    Dim RawIngredientCurrencyMan As CurrencyManager
    Dim RawFoodCurrencyMan As CurrencyManager
    '   Dim RawAddingIngredientCurrencyMan As CurrencyManager
  
    Dim searchFoodID As Integer
    Dim searchFoodName As String
    Dim dvRawUsageByItem As DataView = New DataView
    Dim dvRawMaterials As DataView = New DataView
    Dim usageCount As Integer
    Dim rawUsageChanged As Boolean
    Dim itemCost As Decimal
    Dim removingFromCurrentIngredients As Boolean
    Dim rawUsageFunFlag As String

    Friend WithEvents cbxNewRawMatExistingCat As System.Windows.Forms.ComboBox
    Friend WithEvents grdRawDrinkNames As System.Windows.Forms.DataGrid
    Dim tsRawDrinkNames As New DataGridTableStyle
    Friend WithEvents grdRawDrinkList As System.Windows.Forms.DataGrid
    Friend WithEvents tsRawDrinksItems As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsFoodList As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dcRawFoodID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dcRawFoodName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblRawDirections As System.Windows.Forms.Label

    Dim newRawCategoryID As Integer



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
    Friend WithEvents TabRawMaterials As System.Windows.Forms.TabPage
    Friend WithEvents grdRawMaterialList As System.Windows.Forms.DataGrid
    Friend WithEvents btnRawMatUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRawMatDelete As System.Windows.Forms.Button
    Friend WithEvents TabRawIngredients As System.Windows.Forms.TabPage
    Friend WithEvents grdRawFoodList As System.Windows.Forms.DataGrid
    Friend WithEvents lblRawFoodName As System.Windows.Forms.Label
    Friend WithEvents grdRawMaterielListIngredients As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyleRawIngredMat As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgRawIngMatID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngMatName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngBreakPercent As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngCost As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pnlRawUsageList As System.Windows.Forms.Panel
    Friend WithEvents btnRawMatRemove As System.Windows.Forms.Button
    Friend WithEvents btnRawAdd As System.Windows.Forms.Button
    Friend WithEvents txtRawAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblRawMatLabel As System.Windows.Forms.Label
    Friend WithEvents lblRawMatCost As System.Windows.Forms.Label
    Friend WithEvents btnShowAllFood As System.Windows.Forms.Button
    Friend WithEvents cbxFoodFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cbxRawMaterialCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblRawPurchasing As System.Windows.Forms.Label
    Friend WithEvents lblRawRecipe As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlNewRawMaterial As System.Windows.Forms.Panel
    Friend WithEvents pnlNewRawQuestion As System.Windows.Forms.Panel
    Friend WithEvents btnNewRawCopy As System.Windows.Forms.Button
    Friend WithEvents btnRawCancel As System.Windows.Forms.Button
    Friend WithEvents btnRawCreate As System.Windows.Forms.Button
    Friend WithEvents btnRawNew As System.Windows.Forms.Button
    Friend WithEvents btnNewRawReset As System.Windows.Forms.Button
    Friend WithEvents pnlRawInfo As System.Windows.Forms.Panel
    Friend WithEvents lblRawName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchaseCost As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtRecipeConversion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRecipeUnits As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtPhysicalConversion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPhysicalUnits As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRawName As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbxNewCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPhysicalOnHand As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyleRawIngredients As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgRawIngName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngUsageAmount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngRecipeUnit As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngUnitCost As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawIngExtCost As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grdRawIngredients As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyleRawMaterials As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgRawMatName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawPurchaseUnit As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRawPurchaseUnitPrice As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgBlank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRecipeUnits As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRecipeConversion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRecipeUnitCost As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgBlank2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPhysicalUnit As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPhysicalConversion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPhysicalUnitCost As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPhysicalOnHand As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPhysicalTotalAmount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cbxRawMatIngredients As System.Windows.Forms.ComboBox
    Friend WithEvents dgRawItemID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnShowAllRaw2 As System.Windows.Forms.Button
    Friend WithEvents btnShowAllRaw1 As System.Windows.Forms.Button
    Friend WithEvents btnRawMatChange As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgRecipeNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRecipeExtra As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRecipeExtraDollar As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chkRecipeSelectNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtRecipeSelectNo As System.Windows.Forms.TextBox
    Friend WithEvents lblRecipeUnitCost As System.Windows.Forms.Label
    Friend WithEvents txtRecipeUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents txtRecipeSelectExtra As System.Windows.Forms.TextBox
    Friend WithEvents chkRecipeSelectExtra As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhysicalTrack As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhysicalReport As System.Windows.Forms.CheckBox
    Friend WithEvents txtPhysicalWarning As System.Windows.Forms.TextBox
    Friend WithEvents chkPhysicalWarning As System.Windows.Forms.CheckBox
    Friend WithEvents btnRawAccept As System.Windows.Forms.Button
    Friend WithEvents chkAvailForExtra As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabRawMaterials = New System.Windows.Forms.TabPage
        Me.btnShowAllRaw1 = New System.Windows.Forms.Button
        Me.pnlNewRawMaterial = New System.Windows.Forms.Panel
        Me.lblRawDirections = New System.Windows.Forms.Label
        Me.grdRawDrinkNames = New System.Windows.Forms.DataGrid
        Me.cbxNewRawMatExistingCat = New System.Windows.Forms.ComboBox
        Me.pnlRawInfo = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cbxNewCategory = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtPhysicalWarning = New System.Windows.Forms.TextBox
        Me.chkPhysicalWarning = New System.Windows.Forms.CheckBox
        Me.chkPhysicalReport = New System.Windows.Forms.CheckBox
        Me.chkPhysicalTrack = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPhysicalOnHand = New System.Windows.Forms.TextBox
        Me.txtPhysicalConversion = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPhysicalUnits = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtRecipeSelectExtra = New System.Windows.Forms.TextBox
        Me.chkRecipeSelectExtra = New System.Windows.Forms.CheckBox
        Me.lblRecipeUnitCost = New System.Windows.Forms.Label
        Me.txtRecipeUnitCost = New System.Windows.Forms.TextBox
        Me.txtRecipeSelectNo = New System.Windows.Forms.TextBox
        Me.chkRecipeSelectNo = New System.Windows.Forms.CheckBox
        Me.txtRecipeConversion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRecipeUnits = New System.Windows.Forms.TextBox
        Me.txtRawName = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtPurchaseCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPurchaseUnits = New System.Windows.Forms.TextBox
        Me.lblRawName = New System.Windows.Forms.Label
        Me.pnlNewRawQuestion = New System.Windows.Forms.Panel
        Me.btnRawAccept = New System.Windows.Forms.Button
        Me.btnNewRawReset = New System.Windows.Forms.Button
        Me.btnNewRawCopy = New System.Windows.Forms.Button
        Me.btnRawCreate = New System.Windows.Forms.Button
        Me.btnRawCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRawRecipe = New System.Windows.Forms.Label
        Me.lblRawPurchasing = New System.Windows.Forms.Label
        Me.cbxRawMaterialCategory = New System.Windows.Forms.ComboBox
        Me.grdRawMaterialList = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyleRawMaterials = New System.Windows.Forms.DataGridTableStyle
        Me.dgRawMatName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawPurchaseUnit = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawPurchaseUnitPrice = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgBlank = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecipeUnits = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecipeConversion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecipeUnitCost = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecipeNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecipeExtra = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecipeExtraDollar = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgBlank2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPhysicalUnit = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPhysicalConversion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPhysicalUnitCost = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPhysicalOnHand = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPhysicalTotalAmount = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabRawIngredients = New System.Windows.Forms.TabPage
        Me.grdRawDrinkList = New System.Windows.Forms.DataGrid
        Me.tsRawDrinksItems = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.chkAvailForExtra = New System.Windows.Forms.CheckBox
        Me.btnShowAllRaw2 = New System.Windows.Forms.Button
        Me.cbxRawMatIngredients = New System.Windows.Forms.ComboBox
        Me.grdRawIngredients = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyleRawIngredients = New System.Windows.Forms.DataGridTableStyle
        Me.dgRawItemID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngUsageAmount = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngRecipeUnit = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngUnitCost = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngExtCost = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnShowAllFood = New System.Windows.Forms.Button
        Me.cbxFoodFilter = New System.Windows.Forms.ComboBox
        Me.lblRawMatCost = New System.Windows.Forms.Label
        Me.lblRawMatLabel = New System.Windows.Forms.Label
        Me.txtRawAdd = New System.Windows.Forms.TextBox
        Me.btnRawAdd = New System.Windows.Forms.Button
        Me.btnRawMatRemove = New System.Windows.Forms.Button
        Me.grdRawMaterielListIngredients = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyleRawIngredMat = New System.Windows.Forms.DataGridTableStyle
        Me.dgRawIngMatID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngBreakPercent = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngCost = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRawIngMatName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lblRawFoodName = New System.Windows.Forms.Label
        Me.grdRawFoodList = New System.Windows.Forms.DataGrid
        Me.tsFoodList = New System.Windows.Forms.DataGridTableStyle
        Me.dcRawFoodID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dcRawFoodName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.pnlRawUsageList = New System.Windows.Forms.Panel
        Me.btnRawMatDelete = New System.Windows.Forms.Button
        Me.btnRawMatUpdate = New System.Windows.Forms.Button
        Me.btnRawNew = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnRawMatChange = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.TabRawMaterials.SuspendLayout()
        Me.pnlNewRawMaterial.SuspendLayout()
        CType(Me.grdRawDrinkNames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRawInfo.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNewRawQuestion.SuspendLayout()
        CType(Me.grdRawMaterialList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRawIngredients.SuspendLayout()
        CType(Me.grdRawDrinkList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRawIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRawMaterielListIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRawFoodList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabRawMaterials)
        Me.TabControl1.Controls.Add(Me.TabRawIngredients)
        Me.TabControl1.Location = New System.Drawing.Point(24, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 544)
        Me.TabControl1.TabIndex = 0
        '
        'TabRawMaterials
        '
        Me.TabRawMaterials.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabRawMaterials.Controls.Add(Me.btnShowAllRaw1)
        Me.TabRawMaterials.Controls.Add(Me.pnlNewRawMaterial)
        Me.TabRawMaterials.Controls.Add(Me.Label1)
        Me.TabRawMaterials.Controls.Add(Me.lblRawRecipe)
        Me.TabRawMaterials.Controls.Add(Me.lblRawPurchasing)
        Me.TabRawMaterials.Controls.Add(Me.cbxRawMaterialCategory)
        Me.TabRawMaterials.Controls.Add(Me.grdRawMaterialList)
        Me.TabRawMaterials.Location = New System.Drawing.Point(4, 22)
        Me.TabRawMaterials.Name = "TabRawMaterials"
        Me.TabRawMaterials.Size = New System.Drawing.Size(840, 518)
        Me.TabRawMaterials.TabIndex = 0
        Me.TabRawMaterials.Text = "Raw Materials"
        '
        'btnShowAllRaw1
        '
        Me.btnShowAllRaw1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShowAllRaw1.Location = New System.Drawing.Point(80, 32)
        Me.btnShowAllRaw1.Name = "btnShowAllRaw1"
        Me.btnShowAllRaw1.Size = New System.Drawing.Size(96, 24)
        Me.btnShowAllRaw1.TabIndex = 19
        Me.btnShowAllRaw1.Text = "Show All"
        Me.btnShowAllRaw1.UseVisualStyleBackColor = False
        '
        'pnlNewRawMaterial
        '
        Me.pnlNewRawMaterial.BackColor = System.Drawing.Color.LightGray
        Me.pnlNewRawMaterial.Controls.Add(Me.lblRawDirections)
        Me.pnlNewRawMaterial.Controls.Add(Me.grdRawDrinkNames)
        Me.pnlNewRawMaterial.Controls.Add(Me.cbxNewRawMatExistingCat)
        Me.pnlNewRawMaterial.Controls.Add(Me.pnlRawInfo)
        Me.pnlNewRawMaterial.Controls.Add(Me.pnlNewRawQuestion)
        Me.pnlNewRawMaterial.Location = New System.Drawing.Point(157, 72)
        Me.pnlNewRawMaterial.Name = "pnlNewRawMaterial"
        Me.pnlNewRawMaterial.Size = New System.Drawing.Size(625, 416)
        Me.pnlNewRawMaterial.TabIndex = 5
        Me.pnlNewRawMaterial.Visible = False
        '
        'lblRawDirections
        '
        Me.lblRawDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawDirections.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblRawDirections.Location = New System.Drawing.Point(303, 352)
        Me.lblRawDirections.Name = "lblRawDirections"
        Me.lblRawDirections.Size = New System.Drawing.Size(139, 49)
        Me.lblRawDirections.TabIndex = 4
        Me.lblRawDirections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdRawDrinkNames
        '
        Me.grdRawDrinkNames.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.grdRawDrinkNames.CaptionText = "           Drink Names"
        Me.grdRawDrinkNames.ColumnHeadersVisible = False
        Me.grdRawDrinkNames.DataMember = ""
        Me.grdRawDrinkNames.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRawDrinkNames.Location = New System.Drawing.Point(470, 48)
        Me.grdRawDrinkNames.Name = "grdRawDrinkNames"
        Me.grdRawDrinkNames.ReadOnly = True
        Me.grdRawDrinkNames.Size = New System.Drawing.Size(151, 353)
        Me.grdRawDrinkNames.TabIndex = 3
        '
        'cbxNewRawMatExistingCat
        '
        Me.cbxNewRawMatExistingCat.Location = New System.Drawing.Point(470, 16)
        Me.cbxNewRawMatExistingCat.MaxDropDownItems = 25
        Me.cbxNewRawMatExistingCat.Name = "cbxNewRawMatExistingCat"
        Me.cbxNewRawMatExistingCat.Size = New System.Drawing.Size(151, 21)
        Me.cbxNewRawMatExistingCat.TabIndex = 2
        '
        'pnlRawInfo
        '
        Me.pnlRawInfo.Controls.Add(Me.Panel4)
        Me.pnlRawInfo.Controls.Add(Me.Panel3)
        Me.pnlRawInfo.Controls.Add(Me.Panel2)
        Me.pnlRawInfo.Controls.Add(Me.txtRawName)
        Me.pnlRawInfo.Controls.Add(Me.Panel1)
        Me.pnlRawInfo.Controls.Add(Me.lblRawName)
        Me.pnlRawInfo.Location = New System.Drawing.Point(8, 8)
        Me.pnlRawInfo.Name = "pnlRawInfo"
        Me.pnlRawInfo.Size = New System.Drawing.Size(456, 328)
        Me.pnlRawInfo.TabIndex = 1
        Me.pnlRawInfo.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.cbxNewCategory)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(16, 232)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(272, 88)
        Me.Panel4.TabIndex = 7
        '
        'cbxNewCategory
        '
        Me.cbxNewCategory.Location = New System.Drawing.Point(8, 24)
        Me.cbxNewCategory.Name = "cbxNewCategory"
        Me.cbxNewCategory.Size = New System.Drawing.Size(160, 21)
        Me.cbxNewCategory.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(24, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(224, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Category"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtPhysicalWarning)
        Me.Panel3.Controls.Add(Me.chkPhysicalWarning)
        Me.Panel3.Controls.Add(Me.chkPhysicalReport)
        Me.Panel3.Controls.Add(Me.chkPhysicalTrack)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtPhysicalOnHand)
        Me.Panel3.Controls.Add(Me.txtPhysicalConversion)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtPhysicalUnits)
        Me.Panel3.Location = New System.Drawing.Point(16, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(432, 88)
        Me.Panel3.TabIndex = 6
        '
        'txtPhysicalWarning
        '
        Me.txtPhysicalWarning.Location = New System.Drawing.Point(256, 56)
        Me.txtPhysicalWarning.Name = "txtPhysicalWarning"
        Me.txtPhysicalWarning.Size = New System.Drawing.Size(48, 20)
        Me.txtPhysicalWarning.TabIndex = 16
        '
        'chkPhysicalWarning
        '
        Me.chkPhysicalWarning.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkPhysicalWarning.Location = New System.Drawing.Point(176, 56)
        Me.chkPhysicalWarning.Name = "chkPhysicalWarning"
        Me.chkPhysicalWarning.Size = New System.Drawing.Size(80, 24)
        Me.chkPhysicalWarning.TabIndex = 15
        Me.chkPhysicalWarning.Text = "Warning"
        '
        'chkPhysicalReport
        '
        Me.chkPhysicalReport.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkPhysicalReport.Location = New System.Drawing.Point(176, 32)
        Me.chkPhysicalReport.Name = "chkPhysicalReport"
        Me.chkPhysicalReport.Size = New System.Drawing.Size(80, 24)
        Me.chkPhysicalReport.TabIndex = 13
        Me.chkPhysicalReport.Text = "Report"
        '
        'chkPhysicalTrack
        '
        Me.chkPhysicalTrack.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkPhysicalTrack.Location = New System.Drawing.Point(176, 8)
        Me.chkPhysicalTrack.Name = "chkPhysicalTrack"
        Me.chkPhysicalTrack.Size = New System.Drawing.Size(80, 24)
        Me.chkPhysicalTrack.TabIndex = 11
        Me.chkPhysicalTrack.Text = "Track"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(304, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 23)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Initial   on hand"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhysicalOnHand
        '
        Me.txtPhysicalOnHand.Location = New System.Drawing.Point(360, 8)
        Me.txtPhysicalOnHand.Name = "txtPhysicalOnHand"
        Me.txtPhysicalOnHand.Size = New System.Drawing.Size(56, 20)
        Me.txtPhysicalOnHand.TabIndex = 10
        Me.txtPhysicalOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPhysicalConversion
        '
        Me.txtPhysicalConversion.Location = New System.Drawing.Point(80, 56)
        Me.txtPhysicalConversion.Name = "txtPhysicalConversion"
        Me.txtPhysicalConversion.Size = New System.Drawing.Size(56, 20)
        Me.txtPhysicalConversion.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(24, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Physical Inventory"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(24, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Units:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(0, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Conversion:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhysicalUnits
        '
        Me.txtPhysicalUnits.Location = New System.Drawing.Point(80, 32)
        Me.txtPhysicalUnits.Name = "txtPhysicalUnits"
        Me.txtPhysicalUnits.Size = New System.Drawing.Size(56, 20)
        Me.txtPhysicalUnits.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtRecipeSelectExtra)
        Me.Panel2.Controls.Add(Me.chkRecipeSelectExtra)
        Me.Panel2.Controls.Add(Me.lblRecipeUnitCost)
        Me.Panel2.Controls.Add(Me.txtRecipeUnitCost)
        Me.Panel2.Controls.Add(Me.txtRecipeSelectNo)
        Me.Panel2.Controls.Add(Me.chkRecipeSelectNo)
        Me.Panel2.Controls.Add(Me.txtRecipeConversion)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtRecipeUnits)
        Me.Panel2.Location = New System.Drawing.Point(144, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 88)
        Me.Panel2.TabIndex = 5
        '
        'txtRecipeSelectExtra
        '
        Me.txtRecipeSelectExtra.Location = New System.Drawing.Point(240, 56)
        Me.txtRecipeSelectExtra.Name = "txtRecipeSelectExtra"
        Me.txtRecipeSelectExtra.Size = New System.Drawing.Size(48, 20)
        Me.txtRecipeSelectExtra.TabIndex = 13
        Me.txtRecipeSelectExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkRecipeSelectExtra
        '
        Me.chkRecipeSelectExtra.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkRecipeSelectExtra.Location = New System.Drawing.Point(152, 56)
        Me.chkRecipeSelectExtra.Name = "chkRecipeSelectExtra"
        Me.chkRecipeSelectExtra.Size = New System.Drawing.Size(88, 24)
        Me.chkRecipeSelectExtra.TabIndex = 12
        Me.chkRecipeSelectExtra.Text = "Select Extra"
        '
        'lblRecipeUnitCost
        '
        Me.lblRecipeUnitCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeUnitCost.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblRecipeUnitCost.Location = New System.Drawing.Point(160, 8)
        Me.lblRecipeUnitCost.Name = "lblRecipeUnitCost"
        Me.lblRecipeUnitCost.Size = New System.Drawing.Size(64, 23)
        Me.lblRecipeUnitCost.TabIndex = 10
        Me.lblRecipeUnitCost.Text = "Unit Cost:"
        Me.lblRecipeUnitCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecipeUnitCost
        '
        Me.txtRecipeUnitCost.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecipeUnitCost.Location = New System.Drawing.Point(240, 8)
        Me.txtRecipeUnitCost.Name = "txtRecipeUnitCost"
        Me.txtRecipeUnitCost.ReadOnly = True
        Me.txtRecipeUnitCost.Size = New System.Drawing.Size(48, 20)
        Me.txtRecipeUnitCost.TabIndex = 11
        Me.txtRecipeUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRecipeSelectNo
        '
        Me.txtRecipeSelectNo.Location = New System.Drawing.Point(240, 32)
        Me.txtRecipeSelectNo.Name = "txtRecipeSelectNo"
        Me.txtRecipeSelectNo.Size = New System.Drawing.Size(48, 20)
        Me.txtRecipeSelectNo.TabIndex = 9
        Me.txtRecipeSelectNo.Text = ".00"
        Me.txtRecipeSelectNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkRecipeSelectNo
        '
        Me.chkRecipeSelectNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkRecipeSelectNo.Location = New System.Drawing.Point(152, 32)
        Me.chkRecipeSelectNo.Name = "chkRecipeSelectNo"
        Me.chkRecipeSelectNo.Size = New System.Drawing.Size(88, 24)
        Me.chkRecipeSelectNo.TabIndex = 8
        Me.chkRecipeSelectNo.Text = "Select No"
        '
        'txtRecipeConversion
        '
        Me.txtRecipeConversion.Location = New System.Drawing.Point(80, 56)
        Me.txtRecipeConversion.Name = "txtRecipeConversion"
        Me.txtRecipeConversion.Size = New System.Drawing.Size(56, 20)
        Me.txtRecipeConversion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(32, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Recipe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(32, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Units:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(0, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Conversion:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecipeUnits
        '
        Me.txtRecipeUnits.Location = New System.Drawing.Point(80, 32)
        Me.txtRecipeUnits.Name = "txtRecipeUnits"
        Me.txtRecipeUnits.Size = New System.Drawing.Size(56, 20)
        Me.txtRecipeUnits.TabIndex = 6
        '
        'txtRawName
        '
        Me.txtRawName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawName.Location = New System.Drawing.Point(184, 8)
        Me.txtRawName.Name = "txtRawName"
        Me.txtRawName.Size = New System.Drawing.Size(136, 22)
        Me.txtRawName.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtPurchaseCost)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPurchaseUnits)
        Me.Panel1.Location = New System.Drawing.Point(16, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 88)
        Me.Panel1.TabIndex = 3
        '
        'txtPurchaseCost
        '
        Me.txtPurchaseCost.Location = New System.Drawing.Point(48, 56)
        Me.txtPurchaseCost.Name = "txtPurchaseCost"
        Me.txtPurchaseCost.Size = New System.Drawing.Size(56, 20)
        Me.txtPurchaseCost.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Purchase"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(0, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Units:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(0, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPurchaseUnits
        '
        Me.txtPurchaseUnits.Location = New System.Drawing.Point(48, 32)
        Me.txtPurchaseUnits.Name = "txtPurchaseUnits"
        Me.txtPurchaseUnits.Size = New System.Drawing.Size(56, 20)
        Me.txtPurchaseUnits.TabIndex = 4
        '
        'lblRawName
        '
        Me.lblRawName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblRawName.Location = New System.Drawing.Point(128, 8)
        Me.lblRawName.Name = "lblRawName"
        Me.lblRawName.Size = New System.Drawing.Size(48, 23)
        Me.lblRawName.TabIndex = 0
        Me.lblRawName.Text = "Name:"
        Me.lblRawName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlNewRawQuestion
        '
        Me.pnlNewRawQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNewRawQuestion.Controls.Add(Me.btnRawAccept)
        Me.pnlNewRawQuestion.Controls.Add(Me.btnNewRawReset)
        Me.pnlNewRawQuestion.Controls.Add(Me.btnNewRawCopy)
        Me.pnlNewRawQuestion.Controls.Add(Me.btnRawCreate)
        Me.pnlNewRawQuestion.Controls.Add(Me.btnRawCancel)
        Me.pnlNewRawQuestion.Location = New System.Drawing.Point(48, 344)
        Me.pnlNewRawQuestion.Name = "pnlNewRawQuestion"
        Me.pnlNewRawQuestion.Size = New System.Drawing.Size(224, 64)
        Me.pnlNewRawQuestion.TabIndex = 0
        '
        'btnRawAccept
        '
        Me.btnRawAccept.Location = New System.Drawing.Point(8, 7)
        Me.btnRawAccept.Name = "btnRawAccept"
        Me.btnRawAccept.Size = New System.Drawing.Size(96, 48)
        Me.btnRawAccept.TabIndex = 3
        Me.btnRawAccept.Text = "Accept"
        '
        'btnNewRawReset
        '
        Me.btnNewRawReset.Location = New System.Drawing.Point(120, 8)
        Me.btnNewRawReset.Name = "btnNewRawReset"
        Me.btnNewRawReset.Size = New System.Drawing.Size(96, 48)
        Me.btnNewRawReset.TabIndex = 2
        Me.btnNewRawReset.Text = "Reset Info"
        '
        'btnNewRawCopy
        '
        Me.btnNewRawCopy.Location = New System.Drawing.Point(8, 8)
        Me.btnNewRawCopy.Name = "btnNewRawCopy"
        Me.btnNewRawCopy.Size = New System.Drawing.Size(96, 48)
        Me.btnNewRawCopy.TabIndex = 1
        Me.btnNewRawCopy.Text = "Copy "
        '
        'btnRawCreate
        '
        Me.btnRawCreate.Location = New System.Drawing.Point(8, 8)
        Me.btnRawCreate.Name = "btnRawCreate"
        Me.btnRawCreate.Size = New System.Drawing.Size(96, 48)
        Me.btnRawCreate.TabIndex = 0
        Me.btnRawCreate.Text = "Create New"
        Me.btnRawCreate.Visible = False
        '
        'btnRawCancel
        '
        Me.btnRawCancel.Location = New System.Drawing.Point(120, 8)
        Me.btnRawCancel.Name = "btnRawCancel"
        Me.btnRawCancel.Size = New System.Drawing.Size(96, 48)
        Me.btnRawCancel.TabIndex = 1
        Me.btnRawCancel.Text = "Cancel"
        Me.btnRawCancel.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label1.Location = New System.Drawing.Point(489, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PHYSICAL INVENTORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblRawRecipe
        '
        Me.lblRawRecipe.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblRawRecipe.Location = New System.Drawing.Point(320, 32)
        Me.lblRawRecipe.Name = "lblRawRecipe"
        Me.lblRawRecipe.Size = New System.Drawing.Size(165, 20)
        Me.lblRawRecipe.TabIndex = 3
        Me.lblRawRecipe.Text = "RECIPE"
        Me.lblRawRecipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblRawPurchasing
        '
        Me.lblRawPurchasing.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblRawPurchasing.Location = New System.Drawing.Point(208, 32)
        Me.lblRawPurchasing.Name = "lblRawPurchasing"
        Me.lblRawPurchasing.Size = New System.Drawing.Size(110, 20)
        Me.lblRawPurchasing.TabIndex = 2
        Me.lblRawPurchasing.Text = "PURCHASING"
        Me.lblRawPurchasing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cbxRawMaterialCategory
        '
        Me.cbxRawMaterialCategory.Location = New System.Drawing.Point(56, 8)
        Me.cbxRawMaterialCategory.MaxDropDownItems = 25
        Me.cbxRawMaterialCategory.Name = "cbxRawMaterialCategory"
        Me.cbxRawMaterialCategory.Size = New System.Drawing.Size(150, 21)
        Me.cbxRawMaterialCategory.TabIndex = 0
        '
        'grdRawMaterialList
        '
        Me.grdRawMaterialList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.grdRawMaterialList.CaptionVisible = False
        Me.grdRawMaterialList.DataMember = ""
        Me.grdRawMaterialList.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdRawMaterialList.Location = New System.Drawing.Point(56, 52)
        Me.grdRawMaterialList.Name = "grdRawMaterialList"
        Me.grdRawMaterialList.RowHeadersVisible = False
        Me.grdRawMaterialList.RowHeaderWidth = 0
        Me.grdRawMaterialList.Size = New System.Drawing.Size(735, 450)
        Me.grdRawMaterialList.TabIndex = 0
        Me.grdRawMaterialList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyleRawMaterials})
        '
        'DataGridTableStyleRawMaterials
        '
        Me.DataGridTableStyleRawMaterials.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyleRawMaterials.DataGrid = Me.grdRawMaterialList
        Me.DataGridTableStyleRawMaterials.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgRawMatName, Me.dgRawPurchaseUnit, Me.dgRawPurchaseUnitPrice, Me.dgBlank, Me.dgRecipeUnits, Me.dgRecipeConversion, Me.dgRecipeUnitCost, Me.dgRecipeNo, Me.dgRecipeExtra, Me.dgRecipeExtraDollar, Me.dgBlank2, Me.dgPhysicalUnit, Me.dgPhysicalConversion, Me.dgPhysicalUnitCost, Me.dgPhysicalOnHand, Me.dgPhysicalTotalAmount})
        Me.DataGridTableStyleRawMaterials.HeaderBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridTableStyleRawMaterials.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyleRawMaterials.MappingName = "RawMaterials"
        Me.DataGridTableStyleRawMaterials.RowHeadersVisible = False
        '
        'dgRawMatName
        '
        Me.dgRawMatName.Format = ""
        Me.dgRawMatName.FormatInfo = Nothing
        Me.dgRawMatName.HeaderText = "Raw Material Name"
        Me.dgRawMatName.MappingName = "RawItemName"
        Me.dgRawMatName.NullText = ""
        Me.dgRawMatName.Width = 150
        '
        'dgRawPurchaseUnit
        '
        Me.dgRawPurchaseUnit.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgRawPurchaseUnit.Format = ""
        Me.dgRawPurchaseUnit.FormatInfo = Nothing
        Me.dgRawPurchaseUnit.HeaderText = "Unit"
        Me.dgRawPurchaseUnit.MappingName = "PurchaseUnits"
        Me.dgRawPurchaseUnit.NullText = ""
        Me.dgRawPurchaseUnit.Width = 55
        '
        'dgRawPurchaseUnitPrice
        '
        Me.dgRawPurchaseUnitPrice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgRawPurchaseUnitPrice.Format = "##,###.00"
        Me.dgRawPurchaseUnitPrice.FormatInfo = Nothing
        Me.dgRawPurchaseUnitPrice.HeaderText = "Cost $"
        Me.dgRawPurchaseUnitPrice.MappingName = "PurchaseCost"
        Me.dgRawPurchaseUnitPrice.NullText = ""
        Me.dgRawPurchaseUnitPrice.Width = 55
        '
        'dgBlank
        '
        Me.dgBlank.Format = ""
        Me.dgBlank.FormatInfo = Nothing
        Me.dgBlank.MappingName = "Blank"
        Me.dgBlank.NullText = ""
        Me.dgBlank.Width = 5
        '
        'dgRecipeUnits
        '
        Me.dgRecipeUnits.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgRecipeUnits.Format = ""
        Me.dgRecipeUnits.FormatInfo = Nothing
        Me.dgRecipeUnits.HeaderText = "Unit"
        Me.dgRecipeUnits.MappingName = "RecipeUnit"
        Me.dgRecipeUnits.NullText = ""
        Me.dgRecipeUnits.Width = 55
        '
        'dgRecipeConversion
        '
        Me.dgRecipeConversion.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgRecipeConversion.Format = ""
        Me.dgRecipeConversion.FormatInfo = Nothing
        Me.dgRecipeConversion.HeaderText = "Break"
        Me.dgRecipeConversion.MappingName = "RecipeConversion"
        Me.dgRecipeConversion.NullText = ""
        Me.dgRecipeConversion.Width = 55
        '
        'dgRecipeUnitCost
        '
        Me.dgRecipeUnitCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgRecipeUnitCost.Format = "##,###.00"
        Me.dgRecipeUnitCost.FormatInfo = Nothing
        Me.dgRecipeUnitCost.HeaderText = "Unit Cost $"
        Me.dgRecipeUnitCost.MappingName = "UnitCost"
        Me.dgRecipeUnitCost.NullText = ""
        Me.dgRecipeUnitCost.ReadOnly = True
        Me.dgRecipeUnitCost.Width = 55
        '
        'dgRecipeNo
        '
        Me.dgRecipeNo.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgRecipeNo.Format = ""
        Me.dgRecipeNo.FormatInfo = Nothing
        Me.dgRecipeNo.MappingName = "SelectNo"
        Me.dgRecipeNo.NullText = ""
        Me.dgRecipeNo.Width = 0
        '
        'dgRecipeExtra
        '
        Me.dgRecipeExtra.Format = ""
        Me.dgRecipeExtra.FormatInfo = Nothing
        Me.dgRecipeExtra.MappingName = "SelectExtra"
        Me.dgRecipeExtra.NullText = ""
        Me.dgRecipeExtra.Width = 0
        '
        'dgRecipeExtraDollar
        '
        Me.dgRecipeExtraDollar.Format = ""
        Me.dgRecipeExtraDollar.FormatInfo = Nothing
        Me.dgRecipeExtraDollar.NullText = ""
        Me.dgRecipeExtraDollar.Width = 0
        '
        'dgBlank2
        '
        Me.dgBlank2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgBlank2.Format = ""
        Me.dgBlank2.FormatInfo = Nothing
        Me.dgBlank2.MappingName = "Blank2"
        Me.dgBlank2.NullText = ""
        Me.dgBlank2.Width = 5
        '
        'dgPhysicalUnit
        '
        Me.dgPhysicalUnit.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgPhysicalUnit.Format = ""
        Me.dgPhysicalUnit.FormatInfo = Nothing
        Me.dgPhysicalUnit.HeaderText = "Inv Unit"
        Me.dgPhysicalUnit.MappingName = "PhysicalUnit"
        Me.dgPhysicalUnit.NullText = ""
        Me.dgPhysicalUnit.Width = 55
        '
        'dgPhysicalConversion
        '
        Me.dgPhysicalConversion.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgPhysicalConversion.Format = ""
        Me.dgPhysicalConversion.FormatInfo = Nothing
        Me.dgPhysicalConversion.HeaderText = "Break"
        Me.dgPhysicalConversion.MappingName = "PhysicalConversion"
        Me.dgPhysicalConversion.NullText = ""
        Me.dgPhysicalConversion.Width = 55
        '
        'dgPhysicalUnitCost
        '
        Me.dgPhysicalUnitCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgPhysicalUnitCost.Format = "##,###.00"
        Me.dgPhysicalUnitCost.FormatInfo = Nothing
        Me.dgPhysicalUnitCost.HeaderText = "Cost $"
        Me.dgPhysicalUnitCost.MappingName = "PhysicalUnitCost"
        Me.dgPhysicalUnitCost.NullText = ""
        Me.dgPhysicalUnitCost.ReadOnly = True
        Me.dgPhysicalUnitCost.Width = 55
        '
        'dgPhysicalOnHand
        '
        Me.dgPhysicalOnHand.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgPhysicalOnHand.Format = ""
        Me.dgPhysicalOnHand.FormatInfo = Nothing
        Me.dgPhysicalOnHand.MappingName = "InvQuantity"
        Me.dgPhysicalOnHand.NullText = ""
        Me.dgPhysicalOnHand.Width = 0
        '
        'dgPhysicalTotalAmount
        '
        Me.dgPhysicalTotalAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgPhysicalTotalAmount.Format = "##,###.00"
        Me.dgPhysicalTotalAmount.FormatInfo = Nothing
        Me.dgPhysicalTotalAmount.MappingName = "InvDollarAmount"
        Me.dgPhysicalTotalAmount.NullText = ""
        Me.dgPhysicalTotalAmount.ReadOnly = True
        Me.dgPhysicalTotalAmount.Width = 0
        '
        'TabRawIngredients
        '
        Me.TabRawIngredients.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabRawIngredients.Controls.Add(Me.grdRawDrinkList)
        Me.TabRawIngredients.Controls.Add(Me.chkAvailForExtra)
        Me.TabRawIngredients.Controls.Add(Me.btnShowAllRaw2)
        Me.TabRawIngredients.Controls.Add(Me.cbxRawMatIngredients)
        Me.TabRawIngredients.Controls.Add(Me.grdRawIngredients)
        Me.TabRawIngredients.Controls.Add(Me.btnShowAllFood)
        Me.TabRawIngredients.Controls.Add(Me.cbxFoodFilter)
        Me.TabRawIngredients.Controls.Add(Me.lblRawMatCost)
        Me.TabRawIngredients.Controls.Add(Me.lblRawMatLabel)
        Me.TabRawIngredients.Controls.Add(Me.txtRawAdd)
        Me.TabRawIngredients.Controls.Add(Me.btnRawAdd)
        Me.TabRawIngredients.Controls.Add(Me.btnRawMatRemove)
        Me.TabRawIngredients.Controls.Add(Me.grdRawMaterielListIngredients)
        Me.TabRawIngredients.Controls.Add(Me.lblRawFoodName)
        Me.TabRawIngredients.Controls.Add(Me.grdRawFoodList)
        Me.TabRawIngredients.Location = New System.Drawing.Point(4, 22)
        Me.TabRawIngredients.Name = "TabRawIngredients"
        Me.TabRawIngredients.Size = New System.Drawing.Size(840, 518)
        Me.TabRawIngredients.TabIndex = 1
        Me.TabRawIngredients.Text = "Raw Ingredients"
        '
        'grdRawDrinkList
        '
        Me.grdRawDrinkList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdRawDrinkList.CaptionText = "            Choose Drink Item"
        Me.grdRawDrinkList.ColumnHeadersVisible = False
        Me.grdRawDrinkList.DataMember = ""
        Me.grdRawDrinkList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdRawDrinkList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRawDrinkList.Location = New System.Drawing.Point(66, 86)
        Me.grdRawDrinkList.Name = "grdRawDrinkList"
        Me.grdRawDrinkList.RowHeadersVisible = False
        Me.grdRawDrinkList.Size = New System.Drawing.Size(184, 448)
        Me.grdRawDrinkList.TabIndex = 23
        Me.grdRawDrinkList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsRawDrinksItems})
        Me.grdRawDrinkList.Visible = False
        '
        'tsRawDrinksItems
        '
        Me.tsRawDrinksItems.DataGrid = Me.grdRawDrinkList
        Me.tsRawDrinksItems.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.tsRawDrinksItems.GridLineColor = System.Drawing.SystemColors.Window
        Me.tsRawDrinksItems.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsRawDrinksItems.MappingName = "Drinks"
        Me.tsRawDrinksItems.ReadOnly = True
        Me.tsRawDrinksItems.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "DrinkID"
        Me.DataGridTextBoxColumn1.NullText = " "
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "DrinkName"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'chkAvailForExtra
        '
        Me.chkAvailForExtra.Location = New System.Drawing.Point(280, 392)
        Me.chkAvailForExtra.Name = "chkAvailForExtra"
        Me.chkAvailForExtra.Size = New System.Drawing.Size(104, 32)
        Me.chkAvailForExtra.TabIndex = 22
        Me.chkAvailForExtra.Text = "Track as Extra in Inventory"
        Me.chkAvailForExtra.Visible = False
        '
        'btnShowAllRaw2
        '
        Me.btnShowAllRaw2.Location = New System.Drawing.Point(696, 40)
        Me.btnShowAllRaw2.Name = "btnShowAllRaw2"
        Me.btnShowAllRaw2.Size = New System.Drawing.Size(96, 24)
        Me.btnShowAllRaw2.TabIndex = 21
        Me.btnShowAllRaw2.Text = "Show All"
        '
        'cbxRawMatIngredients
        '
        Me.cbxRawMatIngredients.Location = New System.Drawing.Point(656, 16)
        Me.cbxRawMatIngredients.MaxDropDownItems = 20
        Me.cbxRawMatIngredients.Name = "cbxRawMatIngredients"
        Me.cbxRawMatIngredients.Size = New System.Drawing.Size(160, 21)
        Me.cbxRawMatIngredients.TabIndex = 20
        '
        'grdRawIngredients
        '
        Me.grdRawIngredients.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.grdRawIngredients.CaptionVisible = False
        Me.grdRawIngredients.DataMember = ""
        Me.grdRawIngredients.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRawIngredients.Location = New System.Drawing.Point(208, 56)
        Me.grdRawIngredients.Name = "grdRawIngredients"
        Me.grdRawIngredients.Size = New System.Drawing.Size(424, 304)
        Me.grdRawIngredients.TabIndex = 19
        Me.grdRawIngredients.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyleRawIngredients})
        '
        'DataGridTableStyleRawIngredients
        '
        Me.DataGridTableStyleRawIngredients.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyleRawIngredients.DataGrid = Me.grdRawIngredients
        Me.DataGridTableStyleRawIngredients.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgRawItemID, Me.dgRawIngName, Me.dgRawIngUsageAmount, Me.dgRawIngRecipeUnit, Me.dgRawIngUnitCost, Me.dgRawIngExtCost})
        Me.DataGridTableStyleRawIngredients.HeaderBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridTableStyleRawIngredients.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyleRawIngredients.MappingName = "RawUsageByItem"
        Me.DataGridTableStyleRawIngredients.ReadOnly = True
        Me.DataGridTableStyleRawIngredients.RowHeadersVisible = False
        '
        'dgRawItemID
        '
        Me.dgRawItemID.Format = ""
        Me.dgRawItemID.FormatInfo = Nothing
        Me.dgRawItemID.MappingName = "RawItemID"
        Me.dgRawItemID.Width = 0
        '
        'dgRawIngName
        '
        Me.dgRawIngName.Format = ""
        Me.dgRawIngName.FormatInfo = Nothing
        Me.dgRawIngName.HeaderText = "      Ingredients"
        Me.dgRawIngName.MappingName = "RawItemName"
        Me.dgRawIngName.NullText = ""
        Me.dgRawIngName.Width = 135
        '
        'dgRawIngUsageAmount
        '
        Me.dgRawIngUsageAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgRawIngUsageAmount.Format = "##,###.##"
        Me.dgRawIngUsageAmount.FormatInfo = Nothing
        Me.dgRawIngUsageAmount.HeaderText = "No. Units"
        Me.dgRawIngUsageAmount.MappingName = "RawUsageAmount"
        Me.dgRawIngUsageAmount.NullText = ""
        Me.dgRawIngUsageAmount.Width = 67
        '
        'dgRawIngRecipeUnit
        '
        Me.dgRawIngRecipeUnit.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgRawIngRecipeUnit.Format = ""
        Me.dgRawIngRecipeUnit.FormatInfo = Nothing
        Me.dgRawIngRecipeUnit.HeaderText = "Type Unit"
        Me.dgRawIngRecipeUnit.MappingName = "RecipeUnit"
        Me.dgRawIngRecipeUnit.NullText = ""
        Me.dgRawIngRecipeUnit.Width = 67
        '
        'dgRawIngUnitCost
        '
        Me.dgRawIngUnitCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgRawIngUnitCost.Format = "##,###.00"
        Me.dgRawIngUnitCost.FormatInfo = Nothing
        Me.dgRawIngUnitCost.HeaderText = "Unit Cost"
        Me.dgRawIngUnitCost.MappingName = "UnitCost"
        Me.dgRawIngUnitCost.NullText = ""
        Me.dgRawIngUnitCost.Width = 67
        '
        'dgRawIngExtCost
        '
        Me.dgRawIngExtCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgRawIngExtCost.Format = "##,###.00"
        Me.dgRawIngExtCost.FormatInfo = Nothing
        Me.dgRawIngExtCost.HeaderText = "Ext Cost"
        Me.dgRawIngExtCost.MappingName = "ExtendedCost"
        Me.dgRawIngExtCost.NullText = ""
        Me.dgRawIngExtCost.Width = 67
        '
        'btnShowAllFood
        '
        Me.btnShowAllFood.Location = New System.Drawing.Point(56, 40)
        Me.btnShowAllFood.Name = "btnShowAllFood"
        Me.btnShowAllFood.Size = New System.Drawing.Size(96, 24)
        Me.btnShowAllFood.TabIndex = 18
        Me.btnShowAllFood.Text = "Show All"
        '
        'cbxFoodFilter
        '
        Me.cbxFoodFilter.Location = New System.Drawing.Point(8, 16)
        Me.cbxFoodFilter.MaxDropDownItems = 25
        Me.cbxFoodFilter.Name = "cbxFoodFilter"
        Me.cbxFoodFilter.Size = New System.Drawing.Size(184, 21)
        Me.cbxFoodFilter.TabIndex = 17
        Me.cbxFoodFilter.Text = "Select Food Category"
        '
        'lblRawMatCost
        '
        Me.lblRawMatCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawMatCost.Location = New System.Drawing.Point(568, 368)
        Me.lblRawMatCost.Name = "lblRawMatCost"
        Me.lblRawMatCost.Size = New System.Drawing.Size(48, 24)
        Me.lblRawMatCost.TabIndex = 8
        Me.lblRawMatCost.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblRawMatLabel
        '
        Me.lblRawMatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawMatLabel.Location = New System.Drawing.Point(440, 368)
        Me.lblRawMatLabel.Name = "lblRawMatLabel"
        Me.lblRawMatLabel.Size = New System.Drawing.Size(112, 16)
        Me.lblRawMatLabel.TabIndex = 7
        Me.lblRawMatLabel.Text = "Cost of Item:  $ "
        Me.lblRawMatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtRawAdd
        '
        Me.txtRawAdd.Location = New System.Drawing.Point(568, 440)
        Me.txtRawAdd.Name = "txtRawAdd"
        Me.txtRawAdd.Size = New System.Drawing.Size(40, 20)
        Me.txtRawAdd.TabIndex = 6
        Me.txtRawAdd.Text = "1"
        Me.txtRawAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRawAdd
        '
        Me.btnRawAdd.Location = New System.Drawing.Point(448, 408)
        Me.btnRawAdd.Name = "btnRawAdd"
        Me.btnRawAdd.Size = New System.Drawing.Size(96, 40)
        Me.btnRawAdd.TabIndex = 5
        Me.btnRawAdd.Text = "Add"
        '
        'btnRawMatRemove
        '
        Me.btnRawMatRemove.Location = New System.Drawing.Point(448, 456)
        Me.btnRawMatRemove.Name = "btnRawMatRemove"
        Me.btnRawMatRemove.Size = New System.Drawing.Size(96, 40)
        Me.btnRawMatRemove.TabIndex = 4
        Me.btnRawMatRemove.Text = "Remove"
        '
        'grdRawMaterielListIngredients
        '
        Me.grdRawMaterielListIngredients.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdRawMaterielListIngredients.CaptionText = "              Raw Materials"
        Me.grdRawMaterielListIngredients.ColumnHeadersVisible = False
        Me.grdRawMaterielListIngredients.DataMember = ""
        Me.grdRawMaterielListIngredients.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRawMaterielListIngredients.Location = New System.Drawing.Point(648, 64)
        Me.grdRawMaterielListIngredients.Name = "grdRawMaterielListIngredients"
        Me.grdRawMaterielListIngredients.RowHeadersVisible = False
        Me.grdRawMaterielListIngredients.Size = New System.Drawing.Size(176, 448)
        Me.grdRawMaterielListIngredients.TabIndex = 2
        Me.grdRawMaterielListIngredients.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyleRawIngredMat})
        '
        'DataGridTableStyleRawIngredMat
        '
        Me.DataGridTableStyleRawIngredMat.ColumnHeadersVisible = False
        Me.DataGridTableStyleRawIngredMat.DataGrid = Me.grdRawMaterielListIngredients
        Me.DataGridTableStyleRawIngredMat.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgRawIngMatID, Me.dgRawIngBreakPercent, Me.dgRawIngCost, Me.dgRawIngMatName})
        Me.DataGridTableStyleRawIngredMat.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyleRawIngredMat.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyleRawIngredMat.MappingName = "RawMaterials"
        Me.DataGridTableStyleRawIngredMat.ReadOnly = True
        Me.DataGridTableStyleRawIngredMat.RowHeadersVisible = False
        '
        'dgRawIngMatID
        '
        Me.dgRawIngMatID.Format = ""
        Me.dgRawIngMatID.FormatInfo = Nothing
        Me.dgRawIngMatID.MappingName = "RawItemID"
        Me.dgRawIngMatID.NullText = ""
        Me.dgRawIngMatID.Width = 0
        '
        'dgRawIngBreakPercent
        '
        Me.dgRawIngBreakPercent.Format = ""
        Me.dgRawIngBreakPercent.FormatInfo = Nothing
        Me.dgRawIngBreakPercent.MappingName = "RecipeUnit"
        Me.dgRawIngBreakPercent.NullText = ""
        Me.dgRawIngBreakPercent.ReadOnly = True
        Me.dgRawIngBreakPercent.Width = 30
        '
        'dgRawIngCost
        '
        Me.dgRawIngCost.Format = ""
        Me.dgRawIngCost.FormatInfo = Nothing
        Me.dgRawIngCost.MappingName = "UnitCost"
        Me.dgRawIngCost.NullText = ""
        Me.dgRawIngCost.ReadOnly = True
        Me.dgRawIngCost.Width = 0
        '
        'dgRawIngMatName
        '
        Me.dgRawIngMatName.Format = ""
        Me.dgRawIngMatName.FormatInfo = Nothing
        Me.dgRawIngMatName.MappingName = "RawItemName"
        Me.dgRawIngMatName.NullText = ""
        Me.dgRawIngMatName.Width = 125
        '
        'lblRawFoodName
        '
        Me.lblRawFoodName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawFoodName.ForeColor = System.Drawing.Color.White
        Me.lblRawFoodName.Location = New System.Drawing.Point(232, 16)
        Me.lblRawFoodName.Name = "lblRawFoodName"
        Me.lblRawFoodName.Size = New System.Drawing.Size(364, 32)
        Me.lblRawFoodName.TabIndex = 1
        Me.lblRawFoodName.Text = "Food Item"
        Me.lblRawFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdRawFoodList
        '
        Me.grdRawFoodList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdRawFoodList.CaptionText = "            Choose Food Item"
        Me.grdRawFoodList.ColumnHeadersVisible = False
        Me.grdRawFoodList.DataMember = ""
        Me.grdRawFoodList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdRawFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRawFoodList.Location = New System.Drawing.Point(8, 64)
        Me.grdRawFoodList.Name = "grdRawFoodList"
        Me.grdRawFoodList.RowHeadersVisible = False
        Me.grdRawFoodList.Size = New System.Drawing.Size(184, 448)
        Me.grdRawFoodList.TabIndex = 0
        Me.grdRawFoodList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsFoodList})
        '
        'tsFoodList
        '
        Me.tsFoodList.DataGrid = Me.grdRawFoodList
        Me.tsFoodList.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dcRawFoodID, Me.dcRawFoodName})
        Me.tsFoodList.GridLineColor = System.Drawing.SystemColors.Window
        Me.tsFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsFoodList.MappingName = "FoodTable"
        Me.tsFoodList.ReadOnly = True
        Me.tsFoodList.RowHeadersVisible = False
        '
        'dcRawFoodID
        '
        Me.dcRawFoodID.Format = ""
        Me.dcRawFoodID.FormatInfo = Nothing
        Me.dcRawFoodID.MappingName = "FoodID"
        Me.dcRawFoodID.NullText = " "
        Me.dcRawFoodID.Width = 0
        '
        'dcRawFoodName
        '
        Me.dcRawFoodName.Format = ""
        Me.dcRawFoodName.FormatInfo = Nothing
        Me.dcRawFoodName.MappingName = "FoodName"
        Me.dcRawFoodName.NullText = ""
        Me.dcRawFoodName.Width = 150
        '
        'pnlRawUsageList
        '
        Me.pnlRawUsageList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRawUsageList.Location = New System.Drawing.Point(688, 24)
        Me.pnlRawUsageList.Name = "pnlRawUsageList"
        Me.pnlRawUsageList.Size = New System.Drawing.Size(176, 104)
        Me.pnlRawUsageList.TabIndex = 3
        '
        'btnRawMatDelete
        '
        Me.btnRawMatDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawMatDelete.ForeColor = System.Drawing.Color.White
        Me.btnRawMatDelete.Location = New System.Drawing.Point(248, 32)
        Me.btnRawMatDelete.Name = "btnRawMatDelete"
        Me.btnRawMatDelete.Size = New System.Drawing.Size(96, 48)
        Me.btnRawMatDelete.TabIndex = 2
        Me.btnRawMatDelete.Text = "Delete"
        '
        'btnRawMatUpdate
        '
        Me.btnRawMatUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRawMatUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawMatUpdate.ForeColor = System.Drawing.Color.White
        Me.btnRawMatUpdate.Location = New System.Drawing.Point(368, 32)
        Me.btnRawMatUpdate.Name = "btnRawMatUpdate"
        Me.btnRawMatUpdate.Size = New System.Drawing.Size(96, 48)
        Me.btnRawMatUpdate.TabIndex = 1
        Me.btnRawMatUpdate.Text = "Calculate"
        Me.btnRawMatUpdate.UseVisualStyleBackColor = False
        '
        'btnRawNew
        '
        Me.btnRawNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawNew.ForeColor = System.Drawing.Color.White
        Me.btnRawNew.Location = New System.Drawing.Point(16, 32)
        Me.btnRawNew.Name = "btnRawNew"
        Me.btnRawNew.Size = New System.Drawing.Size(96, 48)
        Me.btnRawNew.TabIndex = 3
        Me.btnRawNew.Text = "New"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnRawMatChange
        '
        Me.btnRawMatChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawMatChange.ForeColor = System.Drawing.Color.White
        Me.btnRawMatChange.Location = New System.Drawing.Point(128, 32)
        Me.btnRawMatChange.Name = "btnRawMatChange"
        Me.btnRawMatChange.Size = New System.Drawing.Size(96, 48)
        Me.btnRawMatChange.TabIndex = 4
        Me.btnRawMatChange.Text = "Change"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnRawNew)
        Me.Panel5.Controls.Add(Me.btnRawMatChange)
        Me.Panel5.Controls.Add(Me.btnRawMatDelete)
        Me.Panel5.Controls.Add(Me.btnRawMatUpdate)
        Me.Panel5.Location = New System.Drawing.Point(208, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(480, 100)
        Me.Panel5.TabIndex = 5
        '
        'SetupRawMaterials
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlRawUsageList)
        Me.Name = "SetupRawMaterials"
        Me.Size = New System.Drawing.Size(888, 696)
        Me.TabControl1.ResumeLayout(False)
        Me.TabRawMaterials.ResumeLayout(False)
        Me.pnlNewRawMaterial.ResumeLayout(False)
        CType(Me.grdRawDrinkNames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRawInfo.ResumeLayout(False)
        Me.pnlRawInfo.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNewRawQuestion.ResumeLayout(False)
        CType(Me.grdRawMaterialList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRawIngredients.ResumeLayout(False)
        Me.TabRawIngredients.PerformLayout()
        CType(Me.grdRawDrinkList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRawIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRawMaterielListIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRawFoodList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        Me.grdRawDrinkList.Location = New Point(8, 64)
        BindData()

    End Sub

    Private Sub CreateDrinkGrid()


    End Sub

    Friend Sub StartRaw()

        PopulateRawCategory()
        PopulateRawMaterialData()
        PopulateRawUsageData()
        PopulateFoodTable()     '???? put all same place
        '444  BindData()

    End Sub
    Private Sub PopulateRawCategory()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlRawCategory.Fill(dsSetup.Tables("RawCategories"))
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PopulateRawMaterialData()

        dsSetup.Tables("RawMaterials").Clear()
        sql.SqlSelectCommandRawMat.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandRawMat.Parameters("@LocationID").Value = corpPhysicalLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlRawMat.Fill(dsSetup.Tables("RawMaterials"))
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '     dvRawMaterials = New DataView
        With dvRawMaterials
            .Table = dsSetup.Tables("RawMaterials")
            .RowFilter = "RawCategoryID > 0"
        End With

    End Sub

    Private Sub PopulateRawUsageData()

        sql.SqlSelectCommandRawUsageByItem.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandRawUsageByItem.Parameters("@LocationID").Value = corpPhysicalLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlRawUsageByItem.Fill(dsSetup.Tables("RawUsageByItem"))
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        With dvRawUsageByItem
            .Table = dsSetup.Tables("RawUsageByItem")
            .RowFilter = "FoodID = 0"
        End With

    End Sub

    Private Sub PopulateFoodTable()

        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "FunctionFlag = 'F'"
        End With
        Exit Sub
        '444

        dsSetup.Tables("FoodTable").Clear()

        sql.SqlSelectCommandFoodsByFunction.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandFoodsByFunction.Parameters("@LocationID").Value = selectedLocation
        '      sql.SqlSelectCommandFoodsByFunction.Parameters("@CategoryID").Value = 100

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlDataAdapterFoodsByFunction.Fill(dsSetup.Tables("FoodTable"))
        sql.cn.Close()

    End Sub

    Private Sub BindData()


        PopulateRawComboBoxes()

        RawCurrencyMan = Me.BindingContext(dvRawMaterials) '(dsSetup.Tables("RawMaterials"))
        RawIngredientCurrencyMan = Me.BindingContext(dvRawUsageByItem)
        '      RawAddingIngredientCurrencyMan = Me.BindingContext(Me.dvRawMaterials)

        Me.grdRawMaterialList.DataSource = dvRawMaterials   '  dsSetup.Tables("RawMaterials")
        Me.grdRawMaterielListIngredients.DataSource = dvRawMaterials    'dsSetup.Tables("RawMaterials")
        Me.grdRawIngredients.DataSource = dvRawUsageByItem

        RawFoodCurrencyMan = Me.BindingContext(dvFoods) 'dsSetup.Tables("FoodTable"))
        Me.grdRawFoodList.DataSource = dvFoods  'dsSetup.Tables("FoodTable")
        Me.grdRawDrinkList.DataSource = dvDrinks

        '     Me.lblRawFoodName.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "FoodName")
        ' below is giving erro, so just temp got rid of 
        'because not much value
        '444    Me.chkAvailForExtra.DataBindings.Add("Checked", dvFoods, "AvailForExtraNo")

        Me.grdRawDrinkNames.DataSource = dvDrinksByCategory



        Dim csRawDrinkName As New DataGridTextBoxColumn
        '   tsRawDrinkNames.MappingName = "DrinkName" '"Modifiers2"
        tsRawDrinkNames.RowHeadersVisible = False
        tsRawDrinkNames.GridLineColor = Color.White

        csRawDrinkName.MappingName = "DrinkName"
        csRawDrinkName.Width = Me.grdRawDrinkNames.Width * 0.85

        tsRawDrinkNames.GridColumnStyles.Add(csRawDrinkName)
        grdRawDrinkNames.TableStyles.Add(tsRawDrinkNames)

    End Sub

    Private Sub PopulateRawComboBoxes()
        Dim oRow As DataRow
        Dim vRow As DataRowView
        Dim rawCatName As String

        cbxFoodFilter.Items.Clear()
        cbxRawMatIngredients.Items.Clear()

        For Each oRow In dsSetup.Tables("RawCategories").Rows
            If oRow("RawCategoryID") = oRow("RawSubCategory") Then
                rawCatName = oRow("RawCategoryName")
            Else
                rawCatName = " " & oRow("RawCategoryName")
            End If
            Me.cbxRawMaterialCategory.Items.Add(rawCatName) 'Material Tab
            Me.cbxNewCategory.Items.Add(rawCatName)         'Material Tab
            Me.cbxRawMatIngredients.Items.Add(rawCatName)
        Next


        With dvMainCategory
            .Table = dsSetup.Tables("MainCategory")
            .RowFilter = "FunctionFlag = 'F' OR FunctionFlag = 'O' AND Active = True" ' AND CategoryOrder < 11"
            '       .Sort = "CategoryOrder"
        End With

        For Each vRow In dvMainCategory     'dsSetup.Tables("MainCategory").Rows
            cbxFoodFilter.Items.Add(vRow("CategoryName"))
        Next

        If dsSetup.Tables("DrinkCategory").Rows.Count > 0 Then
            For Each oRow In dsSetup.Tables("DrinkCategory").Rows
                If Not oRow("DrinkCategoryName") Is DBNull.Value Then
                    Me.cbxFoodFilter.Items.Add(oRow("DrinkCategoryName"))
                End If
            Next
        End If


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
            '        sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "G"
            '       sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            '        sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "F"
            '       sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            '      sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "O"
            '     sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Me.cbxNewRawMatExistingCat.Items.Clear()
        ' dtDrinkCateogy is "DrinkCategory" Table
        If dsSetup.Tables("DrinkCategory").Rows.Count > 0 Then
            For Each oRow In dsSetup.Tables("DrinkCategory").Rows
                If Not oRow("DrinkCategoryName") Is DBNull.Value Then
                    Me.cbxNewRawMatExistingCat.Items.Add(oRow("DrinkCategoryName"))
                End If
            Next
        End If

        For Each oRow In dsSetup.Tables("OrderMenuDetail").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                'not pulling food right now

            End If
        Next

        '      For Each oRow In dsSetup.Tables("ModifierCategory").Rows
        '     If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
        '    If oRow("Active") = True Then
        '             Me.cbxFoodFilter.Items.Add(oRow("CategoryName"))
        '            Me.cbxRawMatIngredients.Items.Add(oRow("CategoryName"))
        '   End If
        '  End If
        ' Next

    End Sub

    Private Sub cbxRawMaterialCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRawMaterialCategory.SelectedIndexChanged

        Dim valueRawID As Integer
        Dim valueSubID As Integer
        Dim filterString As String

        valueRawID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMaterialCategory.SelectedIndex)("RawCategoryID")
        valueSubID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMaterialCategory.SelectedIndex)("RawSubCategory")

        If valueRawID = valueSubID Then
            filterString = "RawCategoryID = " & valueRawID
            Dim oRow As DataRow
            For Each oRow In dsSetup.Tables("RawCategories").Rows
                If oRow("RawSubCategory") = valueRawID Then
                    filterString = filterString & " OR RawCategoryID = " & oRow("RawCategoryID").ToString
                End If
            Next

        Else
            filterString = "RawCategoryID = " & valueRawID
        End If

        dvRawMaterials.RowFilter = filterString

    End Sub

    Private Sub cbxRawMatIngredients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRawMatIngredients.SelectedIndexChanged

        Dim valueRawID As Integer
        Dim valueSubID As Integer
        Dim filterString As String

        valueRawID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMatIngredients.SelectedIndex)("RawCategoryID")
        valueSubID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMatIngredients.SelectedIndex)("RawSubCategory")

        If valueRawID = valueSubID Then
            filterString = "RawCategoryID = " & valueRawID
            Dim oRow As DataRow
            For Each oRow In dsSetup.Tables("RawCategories").Rows
                If oRow("RawSubCategory") = valueRawID Then
                    filterString = filterString & " OR RawCategoryID = " & oRow("RawCategoryID").ToString
                End If
            Next

        Else
            filterString = "RawCategoryID = " & valueRawID
        End If

        dvRawMaterials.RowFilter = filterString

    End Sub

    Private Sub TabRawMaterial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabRawMaterials.Leave

        If dsSetup.HasChanges Then
            UpdateRawMaterials()
            '   UpdateRawUsageData()

            '        If MsgBox("Are you sure you want to leave Raw Materials without saving?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '       Me.Focus()
            '  Else
            '     Exit Sub
            'End If
        End If

    End Sub

    Private Sub TabRawIngredients_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabRawIngredients.Leave

        If dsSetup.HasChanges Then
            UpdateRawUsageData()
            UpdateDatabaseFoods()

        End If

    End Sub

    Private Sub UpdateRawMaterials()
        Dim oRow As DataRow
        Dim corpIDTable As New DataSet

        Try
            corpIDTable = dsSetup.GetChanges

            If corpIDTable.Tables("RawMaterials").Rows.Count > 0 Then
                For Each oRow In corpIDTable.Tables("RawMaterials").Rows    'dsSetup.Tables("RawMaterials").Rows
                    If oRow("CompanyID") Is DBNull.Value Then
                        oRow("CompanyID") = corpID
                    End If
                Next

                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                sql.SqlRawMat.Update(corpIDTable.Tables("RawMaterials"))
                sql.cn.Close()
            End If

            dsSetup.Tables("RawMaterials").AcceptChanges()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnRawMatUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawMatUpdate.Click

        If TabRawMaterials.Focus.ToString = True Then
            UpdateRawMaterials()
            PopulateRawMaterialData()
        ElseIf TabRawIngredients.Focus.ToString = True Then
            UpdateRawUsageData()
        End If

    End Sub

    Private Sub btnRawMatDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawMatDelete.Click

        Exit Sub
        'will not work yet b/c CurrencyMan is on dataview

        Dim oRow As DataRow

        UpdateRawMaterials()

        oRow = dsSetup.Tables("RawMaterials").Rows(Me.RawCurrencyMan.Position)
        oRow.Delete()

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlRawMat.Update(dsSetup.Tables("RawMaterials"))
        sql.cn.Close()

    End Sub





    '*****************************************



    Private Sub grdRawFoodList_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdRawFoodList.CurrentCellChanged

        '      UpdateRawUsageData()
        '     grdRawIngredients.ResetBackColor()

        '    Dim valueFoodID As Integer
        '   Dim valueFoodName As String
        If rawUsageChanged = True Then
            UpdateRawUsageData()
        End If

        searchFoodID = DetermineID(grdRawFoodList, 0)
        searchFoodName = DetermineString(grdRawFoodList, 1)
        Me.lblRawFoodName.Text = searchFoodName

        With dvRawUsageByItem
            .Table = dsSetup.Tables("RawUsageByItem")
            .RowFilter = "FoodID = " & searchFoodID
        End With
        '    dvRawUsageByItem.RowFilter = "FoodID = " & searchFoodID

        '444     If dvRawUsageByItem.Count = 1 Then
        '      chkAvailForExtra.Enabled = True
        '     Else
        '    chkAvailForExtra.Enabled = False
        '   End If

        DisplayCostofItem()

    End Sub

    Private Sub grdRawDrinkList_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdRawDrinkList.CurrentCellChanged

        If rawUsageChanged = True Then
            UpdateRawUsageData()
        End If

        searchFoodID = DetermineID(grdRawDrinkList, 0)
        searchFoodName = DetermineString(grdRawDrinkList, 1)
        Me.lblRawFoodName.Text = searchFoodName

        With dvRawUsageByItem
            .Table = dsSetup.Tables("RawUsageByItem")
            .RowFilter = "DrinkID = " & searchFoodID
        End With

        Exit Sub
        '999   below needs change

        If dvRawUsageByItem.Count = 1 Then
            chkAvailForExtra.Enabled = True
        Else
            chkAvailForExtra.Enabled = False
        End If

        '    DisplayCostofItem()

    End Sub


    Private Sub UpdateRawUsageData()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlRawUsageByItemUpdate.Update(dsSetup, "RawUsageByItem")
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        UpdateFoodCostInFoodTable()
        dsSetup.AcceptChanges()
        rawUsageChanged = False

    End Sub

    Private Sub UpdateFoodCostInFoodTable()
        Dim vRow As DataRowView
        For Each vRow In dvFoods
            If Not vRow("FoodID") Is DBNull.Value Then
                If vRow("FoodID") = searchFoodID Then
                    If vRow("FoodCostManual") = False Then
                        vRow("FoodCost") = Format(itemCost, "#,###.00")
                        Exit For
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Next

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlMenuFoods.Update(dsSetup, "FoodTable")
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DisplayCostofItem()
        Dim vrow As DataRowView
        itemCost = 0

        For Each vrow In dvRawUsageByItem
            If Not vrow("UnitCost") Is DBNull.Value And Not vrow("RawUsageAmount") Is DBNull.Value Then
                itemCost += (vrow("UnitCost") * vrow("RawUsageAmount"))
                vrow("ExtendedCost") = vrow("UnitCost") * vrow("RawUsageAmount")
            End If
        Next

        Me.lblRawMatCost.Text = Format(itemCost, "#,###.00")

    End Sub


    Private Sub btnRawAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawAdd.Click

        Dim searchRawID As Integer
        '        Dim searchRawName As String
        '     MsgBox(DetermineString(Me.grdRawMaterielListIngredients, 3))

        If removingFromCurrentIngredients = True Then
            If Me.grdRawIngredients.CurrentRowIndex = -1 Then
                MsgBox("Please select a Ingredient to Add")
                Exit Sub
            End If
            searchRawID = Me.grdRawIngredients.Item(Me.grdRawIngredients.CurrentRowIndex, 0)
        Else
            searchRawID = Me.grdRawMaterielListIngredients.Item(Me.grdRawMaterielListIngredients.CurrentRowIndex, 0)
        End If

        Dim oRow As DataRow
        Dim vRow As DataRowView

        '   this is if selection is already an ingredient
        For Each vRow In Me.dvRawUsageByItem
            If vRow("RawItemID") = searchRawID Then
                vRow("RawUsageAmount") += CType(Me.txtRawAdd.Text, Decimal)
                rawUsageChanged = True
                DisplayCostofItem()
                '    FilterRawUsageData()
                Exit Sub
            End If
        Next

        UpdateRawUsageData()
        oRow = dsSetup.Tables("RawUsageByItem").NewRow '

        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        If rawUsageFunFlag = "D" Then
            oRow("FoodID") = 0
            oRow("DrinkID") = searchFoodID
        Else
            oRow("FoodID") = searchFoodID
            oRow("DrinkID") = 0
        End If
        oRow("RawItemID") = Me.grdRawMaterielListIngredients.Item(Me.grdRawMaterielListIngredients.CurrentRowIndex, 0)
        oRow("RawUsageAmount") = CType(Me.txtRawAdd.Text, Decimal)
        oRow("RawItemName") = Me.grdRawMaterielListIngredients.Item(Me.grdRawMaterielListIngredients.CurrentRowIndex, 3)
        oRow("RecipeUnit") = Me.grdRawMaterielListIngredients.Item(Me.grdRawMaterielListIngredients.CurrentRowIndex, 1)
        oRow("UnitCost") = Me.grdRawMaterielListIngredients.Item(Me.grdRawMaterielListIngredients.CurrentRowIndex, 2)
        If Not oRow("UnitCost") Is DBNull.Value And Not oRow("RawUsageAmount") Is DBNull.Value Then
            oRow("ExtendedCost") = oRow("UnitCost") * oRow("RawUsageAmount")
        End If

        dsSetup.Tables("RawUsageByItem").Rows.Add(oRow)
        oRow("RawUsageID") = InsertingNewRawUsageByItem(oRow)
        dsSetup.Tables("RawUsageByItem").AcceptChanges()

        If dvRawUsageByItem.Count = 1 And oRow("FoodID") > 0 Then
            '       MsgBox(String.Compare(searchFoodName, oRow("RawItemName"), True))
            If String.Compare(searchFoodName, oRow("RawItemName"), True) = 0 Then
                chkAvailForExtra.Checked = True
            End If
            chkAvailForExtra.Enabled = True
        Else
            chkAvailForExtra.Checked = False
            chkAvailForExtra.Enabled = False
        End If

        DisplayCostofItem()

        '       rawUsageChanged = True
        '        FilterRawUsageData()

    End Sub

    Private Function InsertingNewRawUsageByItem(ByRef oRow As DataRow)
        Dim newRawUsageID As Integer

        sql.SqlInsertCommandRawUsageByItem.Parameters("@CompanyID").Value = corpID
        sql.SqlInsertCommandRawUsageByItem.Parameters("@LocationID").Value = corpPhysicalLocation
        sql.SqlInsertCommandRawUsageByItem.Parameters("@FoodID").Value = oRow("FoodID")
        sql.SqlInsertCommandRawUsageByItem.Parameters("@DrinkID").Value = oRow("DrinkID")
        sql.SqlInsertCommandRawUsageByItem.Parameters("@RawItemID").Value = oRow("RawItemID")
        sql.SqlInsertCommandRawUsageByItem.Parameters("@RawUsageAmount").Value = oRow("RawUsageAmount")
        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newRawUsageID = CType(sql.SqlInsertCommandRawUsageByItem.ExecuteScalar, Integer)
            sql.cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return newRawUsageID

    End Function

    Private Sub btnRawMatRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawMatRemove.Click
        Dim searchRawID As Integer

        If removingFromCurrentIngredients = True Then
            If Me.grdRawIngredients.CurrentRowIndex = -1 Then
                Exit Sub
            End If
            searchRawID = Me.grdRawIngredients.Item(Me.grdRawIngredients.CurrentRowIndex, 0)
        Else
            searchRawID = Me.grdRawMaterielListIngredients.Item(Me.grdRawMaterielListIngredients.CurrentRowIndex, 0)
        End If

        Dim vRow As DataRowView

        For Each vRow In Me.dvRawUsageByItem
            If vRow("RawItemID") = searchRawID Then
                vRow("RawUsageAmount") -= CType(Me.txtRawAdd.Text, Decimal)
                rawUsageChanged = True
                DisplayCostofItem()
                If vRow("RawUsageAmount") <= 0 Then
                    vRow.Delete()
                    Exit For
                End If
                Exit For
            End If
        Next

        If dvRawUsageByItem.Count = 1 Then
            chkAvailForExtra.Enabled = True
        Else
            chkAvailForExtra.Checked = False
            chkAvailForExtra.Enabled = False
        End If
        '    FilterRawUsageData()
        '   UpdateRawUsageData()
    End Sub


    Private Sub btnRawNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawNew.Click
        Me.pnlRawInfo.Visible = False
        Me.btnNewRawCopy.Visible = True
        Me.btnNewRawReset.Visible = True
        Me.btnRawAccept.Visible = False
        Me.btnRawCreate.Visible = False
        Me.btnRawCancel.Visible = False
        Me.pnlNewRawMaterial.Visible = True

    End Sub


    Private Sub btnNewRawCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRawCopy.Click
        ' we are copying last raw materia
        Me.btnNewRawCopy.Visible = False
        Me.btnNewRawReset.Visible = False
        Me.btnRawCreate.Visible = True
        Me.btnRawCancel.Visible = True
        Me.txtRawName.Text = ""

        InsertRawMatData(True)

        Me.pnlRawInfo.Visible = True
        Me.txtRawName.Focus()

    End Sub



    Private Sub btnRawMatChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawMatChange.Click

        ' we are copying last raw materia
        Me.btnNewRawCopy.Visible = False
        Me.btnNewRawReset.Visible = False
        Me.btnRawCreate.Visible = False
        Me.btnRawAccept.Visible = True
        Me.btnRawCancel.Visible = True

        InsertRawMatData(False)

        Me.pnlNewRawMaterial.Visible = True
        Me.pnlRawInfo.Visible = True
        Me.txtRawName.Focus()

    End Sub

    Private Sub InsertRawMatData(ByVal isNew As Boolean)

        Dim vRow As DataRowView
        If Me.RawCurrencyMan.Position = -1 Then
            Me.cbxNewCategory.SelectedIndex = cbxRawMaterialCategory.SelectedIndex
            newRawCategoryID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMaterialCategory.SelectedIndex)("RawCategoryID")
            Exit Sub
        End If

        vRow = dvRawMaterials(Me.RawCurrencyMan.Position)

        If isNew = False Then
            If Not vRow("RawItemName") Is DBNull.Value Then
                Me.txtRawName.Text = vRow("RawItemName")
            Else
                Me.txtRawName.Text = ""
            End If
        End If

        If Not vRow("PurchaseUnits") Is DBNull.Value Then
            Me.txtPurchaseUnits.Text = vRow("PurchaseUnits")
        Else
            Me.txtPurchaseUnits.Text = ""
        End If
        If Not vRow("PurchaseCost") Is DBNull.Value Then
            Me.txtPurchaseCost.Text = vRow("PurchaseCost")
        Else
            Me.txtPurchaseCost.Text = ""
        End If

        '#### Recipe
        If Not vRow("RecipeUnit") Is DBNull.Value Then
            Me.txtRecipeUnits.Text = vRow("RecipeUnit")
        Else
            Me.txtRecipeUnits.Text = ""
        End If
        If Not vRow("RecipeConversion") Is DBNull.Value Then
            Me.txtRecipeConversion.Text = vRow("RecipeConversion")
        Else
            Me.txtRecipeConversion.Text = ""
        End If

        Me.txtRecipeUnitCost.Text = Format((vRow("PurchaseCost") / vRow("RecipeConversion")), "###.00")
        Me.chkRecipeSelectNo.Checked = vRow("SelectNo")

        Me.chkRecipeSelectExtra.Checked = vRow("SelectExtra")
        Me.txtRecipeSelectExtra.Text = Format(vRow("ExtraPrice"), "###.00")


        '#### Physical Inventory
        If Not vRow("PhysicalUnit") Is DBNull.Value Then
            Me.txtPhysicalUnits.Text = vRow("PhysicalUnit")
        Else
            Me.txtPhysicalUnits.Text = ""
        End If
        If Not vRow("PhysicalConversion") Is DBNull.Value Then
            Me.txtPhysicalConversion.Text = vRow("PhysicalConversion")
        Else
            Me.txtPhysicalConversion.Text = ""
        End If
        If Not vRow("InvQuantity") Is DBNull.Value Then
            Me.txtPhysicalOnHand.Text = Format(vRow("InvQuantity"), "##,##0.0#")
        Else
            Me.txtPhysicalOnHand.Text = ""
        End If
        Me.chkPhysicalTrack.Checked = vRow("TrackInvLevels")
        Me.chkPhysicalReport.Checked = vRow("PrintInReport")
        Me.chkPhysicalWarning.Checked = vRow("Warning")
        Me.txtPhysicalWarning.Text = vRow("WarningLevel")

        If Not vRow("RawCategoryID") Is DBNull.Value Then
            AssignNewRawCategoryComboBox(vRow)
            '  Else
            '   Me.cbxNewCategory.SelectedIndex = -1
        End If

    End Sub

    Private Sub txtPurchaseCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurchaseCost.Leave
        DetermineRecipeUnitCost()

    End Sub

    Private Sub txtRecipeConversion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecipeConversion.Leave
        DetermineRecipeUnitCost()

    End Sub

    Private Sub DetermineRecipeUnitCost()

        If Me.txtPurchaseCost.Text = "" Or Me.txtRecipeConversion.Text = "" Then
            ' we do not calculate this value without both parts
            Exit Sub
        End If

        If CType(Me.txtRecipeConversion.Text, Integer) > 0 Then
            Me.txtRecipeUnitCost.Text = Format((CType(Me.txtPurchaseCost.Text, Decimal) / CType(Me.txtRecipeConversion.Text, Integer)), "###.00")

        End If

    End Sub


    Private Sub btnNewRawReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRawReset.Click
        ' all entrys are blank
        Me.btnNewRawCopy.Visible = False
        Me.btnNewRawReset.Visible = False
        Me.btnRawCreate.Visible = True
        Me.btnRawAccept.Visible = False
        Me.btnRawCancel.Visible = True

        Me.txtPhysicalConversion.Text = ""
        Me.txtPhysicalOnHand.Text = ""
        Me.txtPhysicalUnits.Text = ""
        Me.txtPurchaseCost.Text = ""
        Me.txtPurchaseUnits.Text = ""
        Me.txtRawName.Text = ""
        Me.txtRecipeConversion.Text = ""
        Me.txtRecipeUnits.Text = ""

        Me.chkRecipeSelectNo.Checked = True
        Me.chkRecipeSelectExtra.Checked = True
        Me.chkPhysicalTrack.Checked = True
        Me.chkPhysicalReport.Checked = True
        Me.chkPhysicalWarning.Checked = False
        Me.txtPhysicalWarning.Text = ""

        Me.pnlRawInfo.Visible = True

    End Sub

    Private Function ValidateAll() As Boolean

        ValidateAlpha(Me.txtRawName)
        If Me.ErrorProvider1.GetError(txtRawName).Length > 0 Then
            Return False
        End If
        ValidateAlpha(Me.txtPurchaseUnits)
        If Me.ErrorProvider1.GetError(txtPurchaseUnits).Length > 0 Then
            Return False
        End If
        ValidateAlpha(Me.txtRecipeUnits)
        If Me.ErrorProvider1.GetError(txtRecipeUnits).Length > 0 Then
            Return False
        End If
        ValidateAlpha(Me.txtPhysicalUnits)
        If Me.ErrorProvider1.GetError(txtPhysicalUnits).Length > 0 Then
            Return False
        End If

        ValidateNumeric(Me.txtPurchaseCost)
        If Me.ErrorProvider1.GetError(txtPurchaseCost).Length > 0 Then
            Return False
        End If
        ValidateNumeric(Me.txtRecipeConversion)
        If Me.ErrorProvider1.GetError(txtRecipeConversion).Length > 0 Then
            Return False
        End If
        ValidateNumeric(Me.txtPhysicalConversion)
        If Me.ErrorProvider1.GetError(txtPhysicalConversion).Length > 0 Then
            Return False
        End If
        ValidateNumeric(Me.txtPhysicalOnHand)
        If Me.ErrorProvider1.GetError(txtPhysicalOnHand).Length > 0 Then
            Return False
        End If
        ValidateNumeric(Me.txtRecipeSelectExtra)
        If Me.ErrorProvider1.GetError(txtRecipeSelectExtra).Length > 0 Then
            Return False
        End If
        ValidateNumeric(Me.txtPhysicalWarning)
        If Me.ErrorProvider1.GetError(txtPhysicalWarning).Length > 0 Then
            Return False
        End If

        Return True

    End Function

    Private Sub btnRawCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawCreate.Click


        If ValidateAll() = False Then Exit Sub

        Dim oRow As DataRow
        Dim initialOnHandQuantity As Decimal

        Me.UpdateRawMaterials()
        'need to accept changes

        oRow = dsSetup.Tables("RawMaterials").NewRow
        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        oRow("RawCategoryID") = Me.newRawCategoryID
        oRow("RawItemName") = Me.txtRawName.Text
        oRow("PurchaseUnits") = (Me.txtPurchaseUnits.Text)
        oRow("PurchaseCost") = CType(Me.txtPurchaseCost.Text, Decimal)
        oRow("Blank") = ""
        oRow("RecipeUnit") = Me.txtRecipeUnits.Text

        If Me.txtRecipeConversion.Text = "" Then
            oRow("RecipeConversion") = 1
            oRow("UnitCost") = oRow("PurchaseCost")
        Else
            oRow("RecipeConversion") = CType(Me.txtRecipeConversion.Text, Integer)
            If oRow("RecipeConversion") > 0 Then
                oRow("UnitCost") = oRow("PurchaseCost") / oRow("RecipeConversion")
            Else
                oRow("UnitCost") = oRow("PurchaseCost")
            End If
        End If
        oRow("SelectNo") = Me.chkRecipeSelectNo.Checked
        oRow("NoPrice") = 0
        oRow("SelectExtra") = Me.chkRecipeSelectExtra.Checked
        oRow("ExtraPrice") = CType(Me.txtRecipeSelectExtra.Text, Decimal)

        oRow("PhysicalUnit") = Me.txtPhysicalUnits.Text

        If Me.txtPhysicalConversion.Text = "" Then
            oRow("PhysicalConversion") = DBNull.Value
            oRow("PhysicalUnitCost") = DBNull.Value
        Else
            oRow("PhysicalConversion") = CType(Me.txtPhysicalConversion.Text, Integer)
            If oRow("PhysicalConversion") > 0 Then
                oRow("PhysicalUnitCost") = oRow("PurchaseCost") / oRow("PhysicalConversion")
            Else
                oRow("PhysicalUnitCost") = DBNull.Value
            End If
        End If

        oRow("InvDate") = DBNull.Value
        If Me.txtPhysicalOnHand.Text = "" Then
            oRow("InvQuantity") = 0
            initialOnHandQuantity = 0
        Else
            oRow("InvQuantity") = Format(CType(Me.txtPhysicalOnHand.Text, Decimal), "##,##0.0#") 'DBNull.Value
            oRow("InvDollarAmount") = oRow("PurchaseCost") * oRow("InvQuantity")
            initialOnHandQuantity = oRow("InvQuantity") * oRow("RecipeConversion")
        End If

        oRow("TrackInvLevels") = Me.chkPhysicalTrack.Checked
        oRow("PrintInReport") = Me.chkPhysicalReport.Checked
        oRow("Warning") = Me.chkPhysicalWarning.Checked
        oRow("WarningLevel") = CType(Me.txtRecipeSelectExtra.Text, Integer)

        dsSetup.Tables("RawMaterials").Rows.Add(oRow)
        oRow("RawItemID") = InsertNewRawMaterial(oRow)
        dsSetup.Tables("RawMaterials").AcceptChanges()

        DataSet_Builder.GenerateReportData.InsertNewRawMaterialInitialInventory(oRow("RawItemID"), initialOnHandQuantity, oRow("PhysicalUnitCost"), corpID, corpPhysicalLocation)

        '444    Me.pnlNewRawMaterial.Visible = False

        RawCurrencyMan.Position += 1
        Me.txtRawName.Text = ""
        InsertRawMatData(True)

    End Sub



    Private Sub btnRawAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawAccept.Click

        '      Me.UpdateRawMaterials()
        '???need to accept changes
        If ValidateAll() = False Then Exit Sub

        Dim oRow As DataRowView

        oRow = dvRawMaterials(Me.RawCurrencyMan.Position)

        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation
        oRow("RawCategoryID") = Me.newRawCategoryID
        oRow("RawItemName") = Me.txtRawName.Text
        oRow("PurchaseUnits") = (Me.txtPurchaseUnits.Text)
        oRow("PurchaseCost") = CType(Me.txtPurchaseCost.Text, Decimal)
        oRow("Blank") = ""
        oRow("RecipeUnit") = Me.txtRecipeUnits.Text

        '??    DetermineRecipeUnitCost()
        If Me.txtRecipeConversion.Text = "" Then
            oRow("RecipeConversion") = 1
            oRow("UnitCost") = oRow("PurchaseCost")
        Else
            oRow("RecipeConversion") = CType(Me.txtRecipeConversion.Text, Integer)
            If oRow("RecipeConversion") > 0 Then
                oRow("UnitCost") = oRow("PurchaseCost") / oRow("RecipeConversion")
            Else
                oRow("UnitCost") = oRow("PurchaseCost")
            End If
        End If
        oRow("SelectNo") = Me.chkRecipeSelectNo.Checked
        oRow("NoPrice") = 0
        oRow("SelectExtra") = Me.chkRecipeSelectExtra.Checked
        oRow("ExtraPrice") = CType(Me.txtRecipeSelectExtra.Text, Decimal)

        oRow("PhysicalUnit") = Me.txtPhysicalUnits.Text

        If Me.txtPhysicalConversion.Text = "" Then
            oRow("PhysicalConversion") = DBNull.Value
            oRow("PhysicalUnitCost") = DBNull.Value
        Else
            oRow("PhysicalConversion") = CType(Me.txtPhysicalConversion.Text, Integer)
            If oRow("PhysicalConversion") > 0 Then
                oRow("PhysicalUnitCost") = oRow("PurchaseCost") / oRow("PhysicalConversion")
            Else
                oRow("PhysicalUnitCost") = DBNull.Value
            End If
        End If

        oRow("InvDate") = DBNull.Value
        If Me.txtPhysicalOnHand.Text = "" Then
            oRow("InvQuantity") = DBNull.Value
        Else
            oRow("InvQuantity") = Format(CType(Me.txtPhysicalOnHand.Text, Decimal), "##,##0.0#") 'DBNull.Value
            oRow("InvDollarAmount") = oRow("PurchaseCost") * oRow("InvQuantity")
        End If

        oRow("TrackInvLevels") = Me.chkPhysicalTrack.Checked
        oRow("PrintInReport") = Me.chkPhysicalReport.Checked
        oRow("Warning") = Me.chkPhysicalWarning.Checked
        oRow("WarningLevel") = CType(Me.txtRecipeSelectExtra.Text, Integer)

        If Me.RawCurrencyMan.Position < dvRawMaterials.Count Then
            If Me.RawCurrencyMan.Position = (dvRawMaterials.Count - 1) Then
                ' this is the last row
                '    Me.RawCurrencyMan.Position += 1
                '   InsertRawMatData(False)
                Me.pnlNewRawMaterial.Visible = False
            Else
                Me.RawCurrencyMan.Position += 1
                InsertRawMatData(False)
            End If
        Else
            Me.pnlRawInfo.Visible = False
            Me.pnlNewRawMaterial.Visible = False
        End If

    End Sub

    Private Function InsertNewRawMaterial(ByRef oRow As DataRow)
        Dim newRawItemID As Integer

        sql.SqlInsertCommandRawMat.Parameters("@CompanyID").Value = corpID
        sql.SqlInsertCommandRawMat.Parameters("@LocationID").Value = corpPhysicalLocation
        sql.SqlInsertCommandRawMat.Parameters("@RawCategoryID").Value = oRow("RawCategoryID")
        sql.SqlInsertCommandRawMat.Parameters("@RawItemName").Value = oRow("RawItemName")
        sql.SqlInsertCommandRawMat.Parameters("@PurchaseUnits").Value = oRow("PurchaseUnits")
        sql.SqlInsertCommandRawMat.Parameters("@PurchaseCost").Value = oRow("PurchaseCost")
        sql.SqlInsertCommandRawMat.Parameters("@Blank").Value = oRow("Blank")
        sql.SqlInsertCommandRawMat.Parameters("@RecipeUnit").Value = oRow("RecipeUnit")
        sql.SqlInsertCommandRawMat.Parameters("@RecipeConversion").Value = oRow("RecipeConversion")

        sql.SqlInsertCommandRawMat.Parameters("@SelectNo").Value = oRow("SelectNo")
        sql.SqlInsertCommandRawMat.Parameters("@NoPrice").Value = oRow("NoPrice")
        sql.SqlInsertCommandRawMat.Parameters("@SelectExtra").Value = oRow("SelectExtra")
        sql.SqlInsertCommandRawMat.Parameters("@ExtraPrice").Value = oRow("ExtraPrice")
        sql.SqlInsertCommandRawMat.Parameters("@PhysicalUnit").Value = oRow("PhysicalUnit")
        sql.SqlInsertCommandRawMat.Parameters("@PhysicalConversion").Value = oRow("PhysicalConversion")
        sql.SqlInsertCommandRawMat.Parameters("@InvDate").Value = oRow("InvDate")
        '   sql.SqlInsertCommandRawMat.Parameters("@InvQuantity").Value = oRow("InvQuantity")

        sql.SqlInsertCommandRawMat.Parameters("@CalculatedBegInvWeek").Value = 0
        sql.SqlInsertCommandRawMat.Parameters("@RecipeQuantity").Value = 0 'Do not use here
        '      sql.SqlInsertCommandRawMat.Parameters("@TrackAs").Value = DBNull.Value
        sql.SqlInsertCommandRawMat.Parameters("@TrackInvLevels").Value = oRow("TrackInvLevels")
        sql.SqlInsertCommandRawMat.Parameters("@PrintInReport").Value = oRow("PrintInReport")
        sql.SqlInsertCommandRawMat.Parameters("@Warning").Value = oRow("Warning")
        sql.SqlInsertCommandRawMat.Parameters("@WarningLevel").Value = oRow("WarningLevel")
        sql.SqlInsertCommandRawMat.Parameters("@TempRecipeQuantity").Value = 0

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newRawItemID = sql.SqlInsertCommandRawMat.ExecuteScalar
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try

        Return newRawItemID

    End Function



    '    Private Sub txtPurchaseCost_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPurchaseCost.Validating
    '        ValidateNumeric(Me.txtPurchaseCost)
    '    End Sub
    '    Private Sub txtRecipeConversion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecipeConversion.Validating
    '        ValidateNumeric(Me.txtRecipeConversion)
    '    End Sub
    '   Private Sub txtPhysicalConversion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalConversion.Validating
    '       ValidateNumeric(Me.txtPhysicalConversion)
    '   End Sub
    ''   Private Sub txtPhysicalOnHand_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalOnHand.Validating
    '       ValidateNumeric(Me.txtPhysicalOnHand)
    '   End Sub
    '   Private Sub txtRecipeSelectExtra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecipeSelectExtra.Validating
    '       ValidateNumeric(Me.txtRecipeSelectExtra)
    '  End Sub
    '  Private Sub txtPhysicalWarning_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalWarning.Validating
    '      ValidateNumeric(Me.txtPhysicalWarning)
    ' End Sub

    Private Sub ValidateNumeric(ByRef txtValNumeric As TextBox)

        If txtValNumeric.Text = "" Then
            If txtValNumeric Is txtRecipeConversion Or txtValNumeric Is txtPhysicalConversion Then
                Me.ErrorProvider1.SetError(txtValNumeric, "This must be a non-zero numeric value.")
                Me.ErrorProvider1.SetIconAlignment(txtValNumeric, ErrorIconAlignment.TopLeft)

                '      txtValNumeric.Text = "1"
                txtValNumeric.Focus()
                Beep()
            Else
                'they should default to Null.value
                txtValNumeric.Text = "0"

            End If

            '       ElseIf CInt(txtValNumeric.Text) = 0 Then
            '          If txtValNumeric Is txtPurchaseCost Then
            '        Else
            '           txtValNumeric.Text = ""
            '        End If

        ElseIf Not IsNumeric(txtValNumeric.Text) Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a numeric value.")
            Me.ErrorProvider1.SetIconAlignment(txtValNumeric, ErrorIconAlignment.TopLeft)
            txtValNumeric.Focus()
            Beep()

        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    '    Private Sub txtRawName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRawName.Validating
    '        ValidateAlpha(Me.txtRawName)
    '   End Sub
    '   Private Sub txtPurchaseUnits_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPurchaseUnits.Validating
    '       ValidateAlpha(Me.txtPurchaseUnits)
    ''   End Sub
    '   Private Sub txtRecipeUnits_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecipeUnits.Validating
    '       ValidateAlpha(Me.txtRecipeUnits)
    '   End Sub
    '  Private Sub txtPhysicalUnits_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalUnits.Validating
    ''      ValidateAlpha(Me.txtPhysicalUnits)
    ' End Sub

    Private Sub ValidateAlpha(ByRef txtValAlpha As TextBox)

        If txtValAlpha.Text = "" Then
            If txtValAlpha Is txtRawName Or txtValAlpha Is txtPurchaseUnits Then
                Me.ErrorProvider1.SetError(txtValAlpha, "This TextBox can not be Blank.")
                Me.ErrorProvider1.SetIconAlignment(txtValAlpha, ErrorIconAlignment.TopLeft)

                txtValAlpha.Focus()
                Beep()
            Else
                'this should default to NULL.value
            End If

        ElseIf Not TypeName(txtValAlpha.Text) = "String" Then
            Me.ErrorProvider1.SetError(txtValAlpha, "This must be a String value.")
            Me.ErrorProvider1.SetIconAlignment(txtValAlpha, ErrorIconAlignment.TopLeft)
            txtValAlpha.Focus()
            Beep()

        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
        End If

    End Sub



    Private Sub btnRawCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawCancel.Click
        'reset all new raw info
        '      Me.btnNewRawCopy.Visible = True
        '      Me.btnNewRawReset.Visible = True
        '      Me.btnRawAccept.Visible = False
        '      Me.btnRawCreate.Visible = False
        '     Me.btnRawCancel.Visible = False

        Me.pnlRawInfo.Visible = False
        Me.pnlNewRawMaterial.Visible = False

    End Sub

    Private Sub grdRawIngredients_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdRawIngredients.Enter

        removingFromCurrentIngredients = True

    End Sub
    Private Sub grdRawMaterielListIngredients_Enter(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles grdRawMaterielListIngredients.MouseUp 'grdRawMaterielListIngredients.Enter

        removingFromCurrentIngredients = False

    End Sub

    Private Sub AssignNewRawCategoryComboBox(ByRef vRow As DataRowView)
        Dim oRow As DataRow
        Dim i As Integer

        For Each oRow In dsSetup.Tables("RawCategories").Rows
            If oRow("RawCategoryID") = vRow("RawCategoryID") Then
                Me.cbxNewCategory.SelectedIndex = i 'oRow("RawCategoryName")
                newRawCategoryID = vRow("RawCategoryID")
                Exit For
            End If
            i += 1
        Next

    End Sub

    Private Sub cbxNewCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNewCategory.SelectedIndexChanged
        Dim valueRawID As Integer
        '     Dim valueSubID As Integer
        '    Dim filterString As String

        valueRawID = dsSetup.Tables("RawCategories").Rows(Me.cbxNewCategory.SelectedIndex)("RawCategoryID")
        '      valueSubID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMaterialCategory.SelectedIndex)("RawSubCategory")

        newRawCategoryID = valueRawID

        ' make text and catid = to values

    End Sub

    Private Sub cbxFoodFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFoodFilter.SelectedIndexChanged

        UpdateRawUsageData()
        Dim funFlag As String
        Dim valueCatID As Integer
        Dim oRow As DataRow
        Dim index As Integer

        '"OrderMenuDetail" needs to include drink categories too??????
        If Me.cbxFoodFilter.SelectedIndex > dvMainCategory.Count - 1 Then '(dsSetup.Tables("OrderMenuDetail").Rows.Count - 1) Then
            '         newFoodOrder.CatIsDrink = True
            index = dvMainCategory.Count
            For Each oRow In dsSetup.Tables("DrinkCategory").Rows
                If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                    If Not oRow("DrinkCategoryName") Is DBNull.Value Then
                        If index = cbxFoodFilter.SelectedIndex Then
                            valueCatID = oRow("DrinkCategoryID")
                            funFlag = "D"
                            Exit For
                        End If
                        index += 1
                    End If
                End If
            Next
        Else
            '     newFoodOrder.CatIsDrink = False
            valueCatID = dvMainCategory(Me.cbxFoodFilter.SelectedIndex)("CategoryID")
            funFlag = dvMainCategory(Me.cbxFoodFilter.SelectedIndex)("FunctionFlag")

        End If

        rawUsageFunFlag = funFlag

        If funFlag = "D" Then
            With dvDrinks
                .Table = dsSetup.Tables("Drinks")
                .RowFilter = "DrinkCategoryID = " & valueCatID
                .Sort = "DrinkName"
            End With

            Me.grdRawFoodList.Visible = False
            Me.grdRawDrinkList.Visible = True
        Else
            With dvFoods
                .Table = dsSetup.Tables("FoodTable")
                .RowFilter = "CategoryID = " & valueCatID
                .Sort = "FoodName"
            End With

            Me.grdRawDrinkList.Visible = False
            Me.grdRawFoodList.Visible = True
        End If

    End Sub

    Private Sub btnShowAllFood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAllFood.Click

        With dvFoods
            .Table = dsSetup.Tables("FoodTable")
            .RowFilter = "FunctionFlag = 'F'"
        End With
        Exit Sub

        dsSetup.Tables("FoodTable").Clear()

        '   want to keep this from sql 
        sql.SqlSelectCommandFoodsByFunction.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandFoodsByFunction.Parameters("@LocationID").Value = selectedLocation
        '      sql.SqlSelectCommandFoodsByFunction.Parameters("@CategoryID").Value = 100

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlDataAdapterFoodsByFunction.Fill(dsSetup.Tables("FoodTable"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try
    End Sub
    Private Sub btnShowAllRaw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAllRaw1.Click
        ReSetRawMatData()

    End Sub

    Private Sub btnShowAllRaw2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAllRaw2.Click
        ReSetRawMatData()

    End Sub

    Private Sub ReSetRawMatData()
        '   dvRawMaterials = New DataView

        With dvRawMaterials
            .Table = dsSetup.Tables("RawMaterials")
            .RowFilter = "RawCategoryID > 0"
        End With

        '     Me.grdRawMaterialList.DataSource = dvRawMaterials   '  dsSetup.Tables("RawMaterials")
        '    Me.grdRawMaterielListIngredients.DataSource = dvRawMaterials    'dsSetup.Tables("RawMaterials")

    End Sub










    '*********************************
    '   old     old     old 

    Private Sub lblRawFoodName_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRawFoodName.TextChanged

        Exit Sub

        If lblRawFoodName.Text = "Food Item" Then Exit Sub

        If rawUsageChanged = True Then
            UpdateRawUsageData()
        End If

        FilterRawUsageData()

    End Sub


    Private Sub FilterRawUsageData()

        searchFoodID = Me.grdRawFoodList.Item(Me.grdRawFoodList.CurrentRowIndex, 0) 'Me.RawFoodCurrencyMan.Position, 0)
        Me.pnlRawUsageList.Controls.Clear()
        usageCount = 0
        itemCost = 0

        Dim vRow As DataRowView

        dvRawUsageByItem = New DataView
        With dvRawUsageByItem
            .Table = dsSetup.Tables("RawUsageByItem")
            .RowFilter = "FoodID = " & searchFoodID
            '            .Sort = "CategoryID"
        End With

        For Each vRow In dvRawUsageByItem
            PopulateRawUsageLabels(vRow)
            itemCost += ((vRow("BreakdownPercent") * vRow("CostPerItem")) * vRow("RawUsageAmount"))
            usageCount += 1
        Next

        DisplayCostofItem()

    End Sub

    Private Sub PopulateRawUsageLabels(ByRef usageRow As DataRowView)
        Dim lblRawUsageName As New Label
        Dim lblRawUsageAmount As New Label
        Dim lblRawUsageQuanity As New Label
        Dim xPosForName As Integer
        Dim xPosForAmount As Integer
        Dim xPosForQuanity As Integer
        Dim yPos As Integer

        yPos = 25 * usageCount
        lblRawUsageQuanity.Size = New Size(40, 23)
        lblRawUsageQuanity.Location = New Point(5, yPos)
        lblRawUsageQuanity.TextAlign = ContentAlignment.TopLeft
        lblRawUsageQuanity.Text = Format(usageRow("RawUsageAmount"), "###.##")

        lblRawUsageAmount.Size = New Size(80, 23)
        lblRawUsageAmount.Location = New Point(45, yPos)
        lblRawUsageAmount.Text = usageRow("BreakdownAmount")

        lblRawUsageName.Size = New Size(100, 23)
        lblRawUsageName.Location = New Point(130, yPos)
        lblRawUsageName.Text = usageRow("RawItemName")


        Me.pnlRawUsageList.Controls.Add(lblRawUsageName)
        Me.pnlRawUsageList.Controls.Add(lblRawUsageAmount)
        Me.pnlRawUsageList.Controls.Add(lblRawUsageQuanity)

    End Sub


    Private Sub cbxNewRawMatExistingCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNewRawMatExistingCat.SelectedIndexChanged
        Dim valueCatID As Integer
        Dim valueFunFlag As String
        Dim oRow As DataRow
        Dim index As Integer

        For Each oRow In dsSetup.Tables("DrinkCategory").Rows
            If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                If Not oRow("DrinkCategoryName") Is DBNull.Value Then
                    If index = cbxNewRawMatExistingCat.SelectedIndex Then
                        valueCatID = oRow("DrinkCategoryID")
                        Exit For
                    End If
                    index += 1
                End If
            End If
        Next

        '     valueCatID = dsSetup.Tables("DinkCategory").Rows(cbxNewRawMatExistingCat.SelectedIndex)("DrinkCategoryID")
        '     valueFunFlag = dsSetup.Tables("DinkCategory").Rows(cbxNewRawMatExistingCat.SelectedIndex)("FunctionFlag")
        '     valueCatID = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("CategoryID")
        '    valueFunFlag = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("FunctionFlag")

        '       If valueFunFlag = "D" Then 
        '     tsJoinIndividualModifiers.MappingName = "Drinks"
        tsRawDrinkNames.MappingName = "Drinks"

        With dvDrinksByCategory
            .Table = dsSetup.Tables("Drinks")
            .RowFilter = "DrinkCategoryID = '" & valueCatID & "'"
            .Sort = "DrinkName" '"CategoryID, DrinkName"
        End With
        '       Else
        '          tsJoinIndividualModifiers.MappingName = "FoodTable"
        '         With dvModifiers2
        '        .Table = dsSetup.Tables("FoodTable")
        '       .RowFilter = "CategoryID = '" & valueCatID & "'" ' AND FunctionFlag = 'O'"
        '      .Sort = "CategoryID, FoodName"
        '     End With
        '        End If

    End Sub

    Private Sub grdRawDrinkNames_Clicked(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles grdRawDrinkNames.MouseUp

        '    Dim valueModID As Integer
        Dim valueDrinkName As String

        '     valueModID = DetermineID(grdJoinIndividualModifiers, 0)
        valueDrinkName = DetermineString(grdRawDrinkNames, 0)

        txtRawName.Text = valueDrinkName

    End Sub



    Private Sub pnlRawInfo_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlRawInfo.Click
        Me.lblRawDirections.Text = ""
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        RecipeText()
    End Sub

    Private Sub txtRecipeConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecipeConversion.Click
        RecipeText()
    End Sub

    Private Sub RecipeText()
        Me.lblRawDirections.Text = "Recipe conversion is the number of recipe units in one(1) purchase unit."
    End Sub


  
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        PhysicalConversionText()
    End Sub

    Private Sub txtPhysicalConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhysicalConversion.Click
        PhysicalConversionText()
    End Sub

    Private Sub PhysicalConversionText()
        Me.lblRawDirections.Text = "Physical conversion is the number of physical units in one(1) purchase unit. Usually 1"
    End Sub


End Class
