Public Class Tab_Category
    Inherits System.Windows.Forms.Form

    Dim btnMain() As OrderButton


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther()

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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Add_Main_Category As System.Windows.Forms.Button
    Friend WithEvents MainCategoryPanel As System.Windows.Forms.Panel
    Friend WithEvents txtNewCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewCategoryAbrev As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoryName As System.Windows.Forms.Label
    Friend WithEvents lblCategoryAbrev As System.Windows.Forms.Label
    Friend WithEvents lblCategoryFunction As System.Windows.Forms.Label
    Friend WithEvents cbxCategoryFunction As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdateCategory As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCategory As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Add_Main_Category = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.MainCategoryPanel = New System.Windows.Forms.Panel
        Me.btnUpdateCategory = New System.Windows.Forms.Button
        Me.btnRemoveCategory = New System.Windows.Forms.Button
        Me.txtNewCategoryName = New System.Windows.Forms.TextBox
        Me.cbxCategoryFunction = New System.Windows.Forms.ComboBox
        Me.txtNewCategoryAbrev = New System.Windows.Forms.TextBox
        Me.lblCategoryName = New System.Windows.Forms.Label
        Me.lblCategoryAbrev = New System.Windows.Forms.Label
        Me.lblCategoryFunction = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Add_Main_Category
        '
        Me.Add_Main_Category.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Add_Main_Category.Location = New System.Drawing.Point(8, 8)
        Me.Add_Main_Category.Name = "Add_Main_Category"
        Me.Add_Main_Category.Size = New System.Drawing.Size(200, 32)
        Me.Add_Main_Category.TabIndex = 0
        Me.Add_Main_Category.Text = "Add Main Category"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Location = New System.Drawing.Point(8, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add Secondary Category"
        '
        'MainCategoryPanel
        '
        Me.MainCategoryPanel.BackColor = System.Drawing.Color.White
        Me.MainCategoryPanel.Location = New System.Drawing.Point(360, 104)
        Me.MainCategoryPanel.Name = "MainCategoryPanel"
        Me.MainCategoryPanel.Size = New System.Drawing.Size(160, 184)
        Me.MainCategoryPanel.TabIndex = 2
        '
        'btnUpdateCategory
        '
        Me.btnUpdateCategory.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUpdateCategory.Location = New System.Drawing.Point(88, 384)
        Me.btnUpdateCategory.Name = "btnUpdateCategory"
        Me.btnUpdateCategory.Size = New System.Drawing.Size(200, 32)
        Me.btnUpdateCategory.TabIndex = 3
        Me.btnUpdateCategory.Text = "Update Category"
        '
        'btnRemoveCategory
        '
        Me.btnRemoveCategory.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRemoveCategory.Location = New System.Drawing.Point(88, 432)
        Me.btnRemoveCategory.Name = "btnRemoveCategory"
        Me.btnRemoveCategory.Size = New System.Drawing.Size(200, 32)
        Me.btnRemoveCategory.TabIndex = 4
        Me.btnRemoveCategory.Text = "Remove Category"
        '
        'txtNewCategoryName
        '
        Me.txtNewCategoryName.Location = New System.Drawing.Point(88, 136)
        Me.txtNewCategoryName.Name = "txtNewCategoryName"
        Me.txtNewCategoryName.Size = New System.Drawing.Size(208, 20)
        Me.txtNewCategoryName.TabIndex = 5
        Me.txtNewCategoryName.Text = "TextBox1"
        '
        'cbxCategoryFunction
        '
        Me.cbxCategoryFunction.Location = New System.Drawing.Point(88, 264)
        Me.cbxCategoryFunction.Name = "cbxCategoryFunction"
        Me.cbxCategoryFunction.Size = New System.Drawing.Size(208, 21)
        Me.cbxCategoryFunction.TabIndex = 6
        Me.cbxCategoryFunction.Text = "ComboBox1"
        '
        'txtNewCategoryAbrev
        '
        Me.txtNewCategoryAbrev.Location = New System.Drawing.Point(88, 192)
        Me.txtNewCategoryAbrev.Name = "txtNewCategoryAbrev"
        Me.txtNewCategoryAbrev.Size = New System.Drawing.Size(208, 20)
        Me.txtNewCategoryAbrev.TabIndex = 7
        Me.txtNewCategoryAbrev.Text = "TextBox2"
        '
        'lblCategoryName
        '
        Me.lblCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryName.Location = New System.Drawing.Point(88, 112)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(208, 16)
        Me.lblCategoryName.TabIndex = 8
        Me.lblCategoryName.Text = "Category Name"
        '
        'lblCategoryAbrev
        '
        Me.lblCategoryAbrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryAbrev.Location = New System.Drawing.Point(88, 168)
        Me.lblCategoryAbrev.Name = "lblCategoryAbrev"
        Me.lblCategoryAbrev.Size = New System.Drawing.Size(216, 16)
        Me.lblCategoryAbrev.TabIndex = 9
        Me.lblCategoryAbrev.Text = "Category Abreviation"
        '
        'lblCategoryFunction
        '
        Me.lblCategoryFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryFunction.Location = New System.Drawing.Point(88, 232)
        Me.lblCategoryFunction.Name = "lblCategoryFunction"
        Me.lblCategoryFunction.Size = New System.Drawing.Size(200, 24)
        Me.lblCategoryFunction.TabIndex = 10
        Me.lblCategoryFunction.Text = "Category Function"
        '
        'Tab_Category
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCategoryFunction)
        Me.Controls.Add(Me.lblCategoryAbrev)
        Me.Controls.Add(Me.lblCategoryName)
        Me.Controls.Add(Me.txtNewCategoryAbrev)
        Me.Controls.Add(Me.cbxCategoryFunction)
        Me.Controls.Add(Me.txtNewCategoryName)
        Me.Controls.Add(Me.btnRemoveCategory)
        Me.Controls.Add(Me.btnUpdateCategory)
        Me.Controls.Add(Me.MainCategoryPanel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Add_Main_Category)
        Me.Name = "Tab_Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tab_Category"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub InitializeOther()

        GenerateCategoryDataSets()

        BindData()

        DisplayMainCategoryPanel()


    End Sub

   

    Private Sub GenerateCategoryDataSets()

        Dim sqlStatement As String
        Dim tableCreating As String
        Dim bindingColumn As String

        numberOfMainCategories = GetButtonCount("Main")
        numberOfDrinkCategories = GetButtonCount("Drink")
        numberOfModifierCategories = GetButtonCount("Modifier")
        numberOfCategories = (numberOfMainCategories) + numberOfDrinkCategories + numberOfModifierCategories
        maximumCategories = GetCategoryMaximum()

        bindingColumn = "CategoryAbrev"
        tableCreating = "MainCategory"
        sqlStatement = "SELECT CategoryID, CategoryName, CategoryAbrev, CategoryOrder, FunctionID FROM Category WHERE FunctionID = 1 OR FunctionID = 2"     'Panel = 'Main'"
        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)

        bindingColumn = "CategoryName"
        tableCreating = "ModifierCategory"
        sqlStatement = "SELECT CategoryID, CategoryName, CategoryAbrev, CategoryOrder, FunctionID FROM Category WHERE FunctionID > 2"   'Panel = 'Modifier'"
        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)

        bindingColumn = "CategoryName"
        tableCreating = "Functions"
        sqlStatement = "SELECT FunctionID, FunctionName FROM Functions"
        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)



    End Sub

    Private Sub BindData()

        cbxCategoryFunction.DataSource = ds.Tables("Functions")
        cbxCategoryFunction.DisplayMember = "FunctionName"


    End Sub

    Private Sub DisplayMainCategoryPanel()

        ' readjust size of panel
        If numberOfMainCategories = 0 Then
            '        MainCategoryPanel.Size = New Size(ssX * 0.1, ssY * 0.2)


        End If
        ' at this point keeping the same
        MainCategoryPanel.Size = New System.Drawing.Size(160, 184)
        Dim btnWidth As Integer = 150
        Dim btnheight As Integer = 40





        ReDim btnMain(numberOfMainCategories + numberOfDrinkCategories + numberOfModifierCategories)
        Dim index As Integer
        Dim x As Integer = buttonSpace
        Dim y As Integer = buttonSpace

        For index = 0 To (numberOfMainCategories + numberOfDrinkCategories)
            btnMain(index) = New OrderButton
            With btnMain(index)
                .Size = New Size(btnWidth, btnheight)
                .Location = New Point(x, y)
                Try
                    .ID = dtMainCategory.Rows(index)("CategoryID")
                    .Name = dtMainCategory.Rows(index)("CategoryName")
                    .Text = dtMainCategory.Rows(index)("CategoryAbrev")
                Catch
                    .Text = ""
                End Try
                .BackColor = Color.AliceBlue
                MainCategoryPanel.Controls.Add(btnMain(index))

                AddHandler btnMain(index).Click, AddressOf UpdateCategory

            End With
            y = y + btnheight + buttonSpace

        Next



    End Sub

    Private Sub UpdateCategory(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainCategoryPanel.Click

        Try
            Dim objButton As OrderButton = CType(sender, OrderButton)

            txtNewCategoryName.Text = objButton.Name
            txtNewCategoryAbrev.Text = objButton.Text

        Catch
            Exit Sub
        End Try



    End Sub



    Private Sub Add_Main_Category_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Main_Category.Click

        ' determine how many main categories

        ' determine the size of the panel


        ' determine the size of the button


        ' determine the size of the button space

        ' determine the location of the next button


    End Sub


  
    Private Sub btnUpdateCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCategory.Click



    End Sub


End Class
