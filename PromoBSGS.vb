Public Class PromoBSGS
    Inherits System.Windows.Forms.UserControl

    '  Friend BSGSBuyCurrencyMan As CurrencyManager
    ' Friend BSGSGetCurrencyMan As CurrencyManager
    Friend updatedData As Boolean
    Friend bsgsPromoID As Integer
    Friend NewRowFlag As Boolean

  
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal PromoID As Integer)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther(PromoID)

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrBuy As System.Windows.Forms.TextBox
    Friend WithEvents txtPrGet As System.Windows.Forms.TextBox
    Friend WithEvents PromoCategoryBoxBuy As Tahsc_server.PromoCategoryBox
    Friend WithEvents PromoCategoryBoxGet As Tahsc_server.PromoCategoryBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPrBuy = New System.Windows.Forms.TextBox
        Me.txtPrGet = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PromoCategoryBoxBuy = New Tahsc_server.PromoCategoryBox
        Me.PromoCategoryBoxGet = New Tahsc_server.PromoCategoryBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buy Something:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Get Something Free:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrBuy
        '
        Me.txtPrBuy.Location = New System.Drawing.Point(352, 120)
        Me.txtPrBuy.Name = "txtPrBuy"
        Me.txtPrBuy.Size = New System.Drawing.Size(48, 20)
        Me.txtPrBuy.TabIndex = 4
        Me.txtPrBuy.Text = ""
        '
        'txtPrGet
        '
        Me.txtPrGet.Location = New System.Drawing.Point(352, 168)
        Me.txtPrGet.Name = "txtPrGet"
        Me.txtPrGet.Size = New System.Drawing.Size(48, 20)
        Me.txtPrGet.TabIndex = 5
        Me.txtPrGet.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 32)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Buy Something Get Something Free"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Category"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PromoCategoryBoxBuy
        '
        Me.PromoCategoryBoxBuy.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.PromoCategoryBoxBuy.Location = New System.Drawing.Point(184, 120)
        Me.PromoCategoryBoxBuy.Name = "PromoCategoryBoxBuy"
        Me.PromoCategoryBoxBuy.Size = New System.Drawing.Size(160, 24)
        Me.PromoCategoryBoxBuy.TabIndex = 27
        '
        'PromoCategoryBoxGet
        '
        Me.PromoCategoryBoxGet.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.PromoCategoryBoxGet.Location = New System.Drawing.Point(184, 168)
        Me.PromoCategoryBoxGet.Name = "PromoCategoryBoxGet"
        Me.PromoCategoryBoxGet.Size = New System.Drawing.Size(160, 24)
        Me.PromoCategoryBoxGet.TabIndex = 28
        '
        'PromoBSGS
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.Controls.Add(Me.PromoCategoryBoxGet)
        Me.Controls.Add(Me.PromoCategoryBoxBuy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrGet)
        Me.Controls.Add(Me.txtPrBuy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PromoBSGS"
        Me.Size = New System.Drawing.Size(432, 256)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther(ByVal promoID As Integer)

        Dim index As Integer
        Dim oRow As DataRow
        bsgsPromoID = promoID

        If dsSetup.Tables("PromoBSGS").Rows.Count > 0 Then
            For Each oRow In dsSetup.Tables("PromoBSGSBuy").Rows
                If oRow("PromoID") = promoID Then Exit For
                index += 1
            Next

            '   my concern is can you ever get here without a PromoID
            '   need some kind of defense for this something like:
            '   If index > dssetup.tables("PromoBSGS").count then ????
            If index < dsSetup.Tables("PromoBSGS").Rows.Count And NewRowFlag = False Then
                'newrowflag = true means we already initalized a new row (kind of)
                If dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyFD_flag") = "F" Then
                    Me.PromoCategoryBoxBuy.FoodDrink_Flag = "F"
                ElseIf dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyFD_flag") = "D" Then
                    Me.PromoCategoryBoxBuy.FoodDrink_Flag = "D"
                End If
                If Not dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyCategoryAmount") Is DBNull.Value Then
                    txtPrBuy.Text = (dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyCategoryAmount"))
                End If

                Me.PromoCategoryBoxBuy.PositionIndex = index
                Me.PromoCategoryBoxBuy.PromoID = promoID
                Me.PromoCategoryBoxBuy.PrimaryTable = dsSetup.Tables("PromoBSGS")
                Me.PromoCategoryBoxBuy.SupportingTable = dsSetup.Tables("PromoBSGSBuy")
                Me.PromoCategoryBoxBuy.PrimaryColumn = "Buy"
                Me.PromoCategoryBoxBuy.InitializeUserControl()
            Else
                Me.InitializeEmptyBSGSBoxBuy(promoID)
            End If

            index = 0
            For Each oRow In dsSetup.Tables("PromoBSGSGet").Rows
                If oRow("PromoID") = promoID Then Exit For
                index += 1
            Next
            If index < dsSetup.Tables("PromoBSGS").Rows.Count And NewRowFlag = False Then
                'newrowflag = true means we already initalized a new row (kind of)
                If dsSetup.Tables("PromoBSGSGet").Rows(index)("GetFD_flag") = "F" Then
                    Me.PromoCategoryBoxGet.FoodDrink_Flag = "F"
                ElseIf dsSetup.Tables("PromoBSGSGet").Rows(index)("GetFD_flag") = "D" Then
                    Me.PromoCategoryBoxGet.FoodDrink_Flag = "D"
                End If
                If Not dsSetup.Tables("PromoBSGSGet").Rows(index)("GetCategoryAmount") Is DBNull.Value Then
                    txtPrGet.Text = (dsSetup.Tables("PromoBSGSGet").Rows(index)("GetCategoryAmount"))
                End If
                Me.PromoCategoryBoxGet.PositionIndex = index
                Me.PromoCategoryBoxGet.PromoID = promoID
                Me.PromoCategoryBoxGet.PrimaryTable = dsSetup.Tables("PromoBSGS")
                Me.PromoCategoryBoxGet.SupportingTable = dsSetup.Tables("PromoBSGSGet")
                Me.PromoCategoryBoxGet.PrimaryColumn = "Get"
                Me.PromoCategoryBoxGet.InitializeUserControl()
            Else
                InitializeEmptyBSGSBoxGet(promoID)
            End If

        Else

            InitializeEmptyBSGSBoxBuy(promoID)
            InitializeEmptyBSGSBoxGet(promoID)
        End If
       
    End Sub

    Private Sub InitializeEmptyBSGSBoxBuy(ByVal promoID As Integer)
        Me.PromoCategoryBoxBuy.FoodDrink_Flag = "F"
        Me.PromoCategoryBoxBuy.PositionIndex = -1
        Me.PromoCategoryBoxBuy.PromoID = promoID
        Me.PromoCategoryBoxBuy.PrimaryTable = dsSetup.Tables("PromoBSGSBuy")
        Me.PromoCategoryBoxBuy.PrimaryColumn = "Buy"
        Me.PromoCategoryBoxBuy.NewRowFlag = True
        Me.NewRowFlag = True
        Me.PromoCategoryBoxBuy.InitializeUserControl()

    End Sub

    Private Sub InitializeEmptyBSGSBoxGet(ByVal promoID As Integer)
        Me.PromoCategoryBoxGet.FoodDrink_Flag = "F"
        Me.PromoCategoryBoxGet.PositionIndex = -1
        Me.PromoCategoryBoxGet.PromoID = promoID
        Me.PromoCategoryBoxGet.PrimaryTable = dsSetup.Tables("PromoBSGSGet")
        Me.PromoCategoryBoxGet.PrimaryColumn = "Get"
        Me.PromoCategoryBoxGet.NewRowFlag = True
        Me.NewRowFlag = True
        Me.PromoCategoryBoxGet.InitializeUserControl()


    End Sub


    Private Sub AddFromBSGSBox(ByRef oRow As DataRow) Handles PromoCategoryBoxBuy.AddingPromoRow, PromoCategoryBoxGet.AddingPromoRow

        If NewRowFlag = True Then
            NewRowFlag = False
            oRow("PromoBSGSID") = InsertIntoBSGSPromo(oRow)
        End If

    End Sub

    Private Function InsertIntoBSGSPromo(ByRef oRow As DataRow)

        Dim newPromoID As Integer

        sql.SqlInsertCommandPromoBSGS.Parameters("@CompanyID").Value = oRow("CompanyID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@LocationID").Value = oRow("LocationID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@PromoID").Value = oRow("PromoID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyFD_flag").Value = oRow("BuyFD_flag")
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyCategoryID").Value = oRow("BuyCategoryID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyCategoryAmount").Value = oRow("BuyCategoryAmount")
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyDrinkCategoryID").Value = oRow("BuyDrinkCategoryID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetFD_flag").Value = oRow("GetFD_flag")
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetCategoryID").Value = oRow("GetCategoryID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetCategoryAmount").Value = oRow("GetCategoryAmount")
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetQuantityDiscount").Value = oRow("GetQuantityDiscount")
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetDrinkCategoryID").Value = oRow("GetDrinkCategoryID")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newPromoID = CType(sql.SqlInsertCommandPromoBSGS.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newPromoID

    End Function



    Private Sub txtPrBuy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrBuy.TextChanged

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("PromoBSGS").Rows
            If oRow("PromoID") = bsgsPromoID Then
                oRow("BuyCategoryAmount") = txtPrBuy.Text
                Exit For
            End If
        Next

    End Sub

    Private Sub txtPrGet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrGet.TextChanged

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("PromoBSGS").Rows
            If oRow("PromoID") = bsgsPromoID Then
                oRow("BuyCategoryAmount") = txtPrBuy.Text
                Exit For
            End If
        Next

    End Sub


End Class
