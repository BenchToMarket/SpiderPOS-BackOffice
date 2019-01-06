Public Class PromoCoupon
    Inherits System.Windows.Forms.UserControl

    Friend updatedData As Boolean
    Friend couponPromoID As Integer
    Friend NewRowFlag As Boolean
    Dim justCheckingBoxes As Boolean


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal promoID As Integer)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther(promoID)

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdbCouponDollar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCouponPercent As System.Windows.Forms.RadioButton
    Friend WithEvents txtCouponDollar As System.Windows.Forms.TextBox
    Friend WithEvents txtCouponPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtCouponNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCouponMin As System.Windows.Forms.TextBox
    Friend WithEvents PromoCategoryBoxCouponDiscount As Tahsc_server.PromoCategoryBox
    Friend WithEvents PromoCategoryBoxCouponAtleast As Tahsc_server.PromoCategoryBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCouponPercent = New System.Windows.Forms.TextBox
        Me.txtCouponDollar = New System.Windows.Forms.TextBox
        Me.rdbCouponPercent = New System.Windows.Forms.RadioButton
        Me.rdbCouponDollar = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCouponNumber = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCouponMin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PromoCategoryBoxCouponDiscount = New Tahsc_server.PromoCategoryBox
        Me.PromoCategoryBoxCouponAtleast = New Tahsc_server.PromoCategoryBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCouponPercent)
        Me.GroupBox1.Controls.Add(Me.txtCouponDollar)
        Me.GroupBox1.Controls.Add(Me.rdbCouponPercent)
        Me.GroupBox1.Controls.Add(Me.rdbCouponDollar)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Type"
        '
        'txtCouponPercent
        '
        Me.txtCouponPercent.Location = New System.Drawing.Point(80, 40)
        Me.txtCouponPercent.Name = "txtCouponPercent"
        Me.txtCouponPercent.Size = New System.Drawing.Size(56, 20)
        Me.txtCouponPercent.TabIndex = 3
        Me.txtCouponPercent.Text = ""
        '
        'txtCouponDollar
        '
        Me.txtCouponDollar.Location = New System.Drawing.Point(80, 16)
        Me.txtCouponDollar.Name = "txtCouponDollar"
        Me.txtCouponDollar.Size = New System.Drawing.Size(56, 20)
        Me.txtCouponDollar.TabIndex = 2
        Me.txtCouponDollar.Text = ""
        '
        'rdbCouponPercent
        '
        Me.rdbCouponPercent.Location = New System.Drawing.Point(8, 48)
        Me.rdbCouponPercent.Name = "rdbCouponPercent"
        Me.rdbCouponPercent.Size = New System.Drawing.Size(72, 16)
        Me.rdbCouponPercent.TabIndex = 1
        Me.rdbCouponPercent.Text = "Percent"
        '
        'rdbCouponDollar
        '
        Me.rdbCouponDollar.Location = New System.Drawing.Point(8, 24)
        Me.rdbCouponDollar.Name = "rdbCouponDollar"
        Me.rdbCouponDollar.Size = New System.Drawing.Size(72, 16)
        Me.rdbCouponDollar.TabIndex = 0
        Me.rdbCouponDollar.Text = "Dollar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(64, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Discount upto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCouponNumber
        '
        Me.txtCouponNumber.Location = New System.Drawing.Point(176, 144)
        Me.txtCouponNumber.Name = "txtCouponNumber"
        Me.txtCouponNumber.Size = New System.Drawing.Size(40, 20)
        Me.txtCouponNumber.TabIndex = 4
        Me.txtCouponNumber.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Must Order at Least:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCouponMin
        '
        Me.txtCouponMin.Location = New System.Drawing.Point(176, 184)
        Me.txtCouponMin.Name = "txtCouponMin"
        Me.txtCouponMin.Size = New System.Drawing.Size(40, 20)
        Me.txtCouponMin.TabIndex = 6
        Me.txtCouponMin.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Category"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "(optional)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 32)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Coupon Promotion"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PromoCategoryBoxCouponDiscount
        '
        Me.PromoCategoryBoxCouponDiscount.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.PromoCategoryBoxCouponDiscount.Location = New System.Drawing.Point(232, 144)
        Me.PromoCategoryBoxCouponDiscount.Name = "PromoCategoryBoxCouponDiscount"
        Me.PromoCategoryBoxCouponDiscount.Size = New System.Drawing.Size(160, 24)
        Me.PromoCategoryBoxCouponDiscount.TabIndex = 24
        '
        'PromoCategoryBoxCouponAtleast
        '
        Me.PromoCategoryBoxCouponAtleast.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.PromoCategoryBoxCouponAtleast.Location = New System.Drawing.Point(232, 184)
        Me.PromoCategoryBoxCouponAtleast.Name = "PromoCategoryBoxCouponAtleast"
        Me.PromoCategoryBoxCouponAtleast.Size = New System.Drawing.Size(160, 24)
        Me.PromoCategoryBoxCouponAtleast.TabIndex = 25
        '
        'PromoCoupon
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.Controls.Add(Me.PromoCategoryBoxCouponAtleast)
        Me.Controls.Add(Me.PromoCategoryBoxCouponDiscount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCouponMin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCouponNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PromoCoupon"
        Me.Size = New System.Drawing.Size(432, 256)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther(ByVal promoID As Integer)

        Dim index As Integer
        Dim oRow As DataRow
        couponPromoID = promoID

        If dsSetup.Tables("PromoCoupon").Rows.Count > 0 Then
            For Each oRow In dsSetup.Tables("PromoCouponDiscount").Rows
                If oRow("PromoID") = promoID Then Exit For
                index += 1
            Next

            If index < dsSetup.Tables("PromoCoupon").Rows.Count Then
                If Not dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarFlag") Is DBNull.Value Then
                    rdbCouponDollar.Checked = (dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarFlag"))
                End If
                If Not dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentFlag") Is DBNull.Value Then
                    rdbCouponPercent.Checked = (dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentFlag"))
                End If

                If Not dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarAmount") Is DBNull.Value Then
                    txtCouponDollar.Text = (dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarAmount"))
                End If
                If Not dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentAmount") Is DBNull.Value Then
                    txtCouponPercent.Text = (dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentAmount"))
                End If

            End If
             '   my concern is can you ever get here without a PromoID
            '   need some kind of defense for this something like:
            '   If index > dssetup.tables("PromoBSGS").count then ????
            If index < dsSetup.Tables("PromoCoupon").Rows.Count And NewRowFlag = False Then
                If dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountFD_flag") = "F" Then
                    Me.PromoCategoryBoxCouponDiscount.FoodDrink_Flag = "F"
                ElseIf dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountFD_flag") = "D" Then
                    Me.PromoCategoryBoxCouponDiscount.FoodDrink_Flag = "D"
                End If
                If Not dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountCategoryAmount") Is DBNull.Value Then
                    txtCouponNumber.Text = (dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountCategoryAmount"))
                End If
                Me.PromoCategoryBoxCouponDiscount.PositionIndex = index
                Me.PromoCategoryBoxCouponDiscount.PromoID = promoID
                Me.PromoCategoryBoxCouponDiscount.PrimaryTable = dsSetup.Tables("PromoCoupon")
                Me.PromoCategoryBoxCouponDiscount.SupportingTable = dsSetup.Tables("PromoCouponDiscount")
                Me.PromoCategoryBoxCouponDiscount.PrimaryColumn = "Discount"
                Me.PromoCategoryBoxCouponDiscount.InitializeUserControl()
            Else
                InitializeEmptyCouponBoxDiscount(promoID)

            End If

            index = 0
            For Each oRow In dsSetup.Tables("PromoCouponAtleast").Rows
                If oRow("PromoID") = promoID Then Exit For
                index += 1
            Next

            If index < dsSetup.Tables("PromoCoupon").Rows.Count And NewRowFlag = False Then
                If dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastFD_flag") = "F" Then
                    Me.PromoCategoryBoxCouponAtleast.FoodDrink_Flag = "F"
                ElseIf dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastFD_flag") = "D" Then
                    Me.PromoCategoryBoxCouponAtleast.FoodDrink_Flag = "D"
                End If
                If Not dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastCategoryAmount") Is DBNull.Value Then
                    txtCouponMin.Text = (dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastCategoryAmount"))
                End If
                Me.PromoCategoryBoxCouponAtleast.PositionIndex = index
                Me.PromoCategoryBoxCouponAtleast.PromoID = promoID
                Me.PromoCategoryBoxCouponAtleast.PrimaryTable = dsSetup.Tables("PromoCoupon")
                Me.PromoCategoryBoxCouponAtleast.SupportingTable = dsSetup.Tables("PromoCouponAtleast")
                Me.PromoCategoryBoxCouponAtleast.PrimaryColumn = "Atleast"
                Me.PromoCategoryBoxCouponAtleast.InitializeUserControl()
            Else
                InitializeEmptyCouponBoxAtleast(promoID)

            End If

        Else
            InitializeEmptyCouponBoxDiscount(promoID)
            InitializeEmptyCouponBoxAtleast(promoID)
        End If

    End Sub

    Private Sub AddFromBSGSBox(ByRef oRow As DataRow) Handles PromoCategoryBoxCouponAtleast.AddingPromoRow, PromoCategoryBoxCouponDiscount.AddingPromoRow

        If NewRowFlag = True Then
            NewRowFlag = False
            oRow("PromoCouponID") = InsertIntoCouponPromo(oRow)
        End If

    End Sub

    Private Function InsertIntoCouponPromo(ByRef oRow As DataRow)

        Dim newPromoID As Integer

        sql.SqlInsertCommandCoupon.Parameters("@CompanyID").Value = oRow("CompanyID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@LocationID").Value = oRow("LocationID")
        sql.SqlInsertCommandPromoBSGS.Parameters("@PromoID").Value = oRow("PromoID")
        sql.SqlInsertCommandCoupon.Parameters("@DiscountFD_flag").Value = oRow("DiscountFD_flag")
        sql.SqlInsertCommandCoupon.Parameters("@DiscountCategoryID").Value = oRow("DiscountCategoryID")
        sql.SqlInsertCommandCoupon.Parameters("@DiscountCategoryAmount").Value = oRow("DiscountCategoryAmount")
        sql.SqlInsertCommandCoupon.Parameters("@DiscountDrinkCategoryID").Value = oRow("DiscountDrinkCategoryID")
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastFD_flag").Value = oRow("AtLeastFD_flag")
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastCategoryID").Value = oRow("AtLeastCategoryID")
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastCategoryAmount").Value = oRow("AtLeastCategoryAmount")
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastDrinkCategoryID").Value = oRow("AtLeastDrinkCategoryID")
        sql.SqlInsertCommandCoupon.Parameters("@CouponDollarFlag").Value = oRow("CouponDollarFlag")
        sql.SqlInsertCommandCoupon.Parameters("@CouponDollarAmount").Value = oRow("CouponDollarAmount")
        sql.SqlInsertCommandCoupon.Parameters("@CouponPercentFlag").Value = oRow("CouponPercentFlag")
        sql.SqlInsertCommandCoupon.Parameters("@CouponPercentAmount").Value = oRow("CouponPercentAmount")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newPromoID = CType(sql.SqlInsertCommandCoupon.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newPromoID

    End Function



    Private Sub InitializeEmptyCouponBoxDiscount(ByVal promoID As Integer)
        Me.PromoCategoryBoxCouponDiscount.PositionIndex = -1
        Me.PromoCategoryBoxCouponDiscount.FoodDrink_Flag = "F"
        Me.PromoCategoryBoxCouponDiscount.PromoID = promoID
        Me.PromoCategoryBoxCouponDiscount.PrimaryTable = dsSetup.Tables("PromoCoupon")
        Me.PromoCategoryBoxCouponDiscount.SupportingTable = dsSetup.Tables("PromoCouponDiscount")
        Me.PromoCategoryBoxCouponDiscount.PrimaryColumn = "Discount"
        Me.PromoCategoryBoxCouponDiscount.NewRowFlag = True
        Me.NewRowFlag = True
        Me.PromoCategoryBoxCouponDiscount.InitializeUserControl()
    End Sub

    Private Sub InitializeEmptyCouponBoxAtleast(ByVal promoID As Integer)
        Me.PromoCategoryBoxCouponAtleast.PositionIndex = -1
        Me.PromoCategoryBoxCouponAtleast.FoodDrink_Flag = "F"
        Me.PromoCategoryBoxCouponAtleast.PromoID = promoID
        Me.PromoCategoryBoxCouponAtleast.PrimaryTable = dsSetup.Tables("PromoCoupon")
        Me.PromoCategoryBoxCouponAtleast.SupportingTable = dsSetup.Tables("PromoCouponAtleast")
        Me.PromoCategoryBoxCouponAtleast.PrimaryColumn = "Atleast"
        Me.PromoCategoryBoxCouponAtleast.NewRowFlag = True
        Me.NewRowFlag = True
        Me.PromoCategoryBoxCouponAtleast.InitializeUserControl()
    End Sub


    Private Sub rdbCouponDollar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCouponDollar.CheckedChanged

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("PromoCoupon").Rows
            If oRow("PromoID") = couponPromoID Then
                oRow("CouponDollarFlag") = rdbCouponDollar.Checked
            End If
        Next

    End Sub

    Private Sub rdbCouponPercent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCouponPercent.CheckedChanged

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("PromoCoupon").Rows
            If oRow("PromoID") = couponPromoID Then
                oRow("CouponPercentFlag") = rdbCouponPercent.Checked
                Exit For
            End If
        Next

    End Sub


    Private Sub txtCouponDollar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCouponDollar.TextChanged

        Dim oRow As DataRow
        Dim newDollar As Decimal

        For Each oRow In dsSetup.Tables("PromoCoupon").Rows
            If oRow("PromoID") = couponPromoID Then
                If txtCouponDollar.Text = "" Then
                    oRow("CouponDollarAmount") = DBNull.Value
                Else
                    Try
                        newDollar = (CType(txtCouponDollar.Text, Decimal))
                        oRow("CouponDollarAmount") = Format(newDollar, "###.00")
                    Catch ex As Exception
                        oRow("CouponDollarAmount") = DBNull.Value
                    End Try

                End If
                Exit For
            End If
        Next

    End Sub

    Private Sub txtCouponPercent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCouponPercent.TextChanged

        Dim oRow As DataRow
        Dim newPercent As Decimal

        For Each oRow In dsSetup.Tables("PromoCoupon").Rows
            If oRow("PromoID") = couponPromoID Then
                If txtCouponDollar.Text = "" Then
                    oRow("CouponPercentAmount") = DBNull.Value
                Else
                    Try
                        newPercent = CType(txtCouponPercent.Text, Decimal)
                        If newPercent > 1 Then
                            newPercent = (newPercent / 100)
                        End If
                        Format(newPercent, "###.00")
                        oRow("CouponPercentAmount") = newPercent
                    Catch ex As Exception
                        oRow("CouponPercentAmount") = DBNull.Value
                    End Try

                End If
                Exit For
            End If
        Next

    End Sub

    Private Sub txtCouponNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCouponNumber.TextChanged

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("PromoCoupon").Rows
            If oRow("PromoID") = couponPromoID Then
                oRow("DiscountCategoryAmount") = txtCouponNumber.Text
                Exit For
            End If
        Next

    End Sub


    Private Sub txtCouponMin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCouponMin.TextChanged

        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("PromoCoupon").Rows
            If oRow("PromoID") = couponPromoID Then
                oRow("AtleastCategoryAmount") = txtCouponMin.Text
                Exit For
            End If
        Next

    End Sub
End Class
