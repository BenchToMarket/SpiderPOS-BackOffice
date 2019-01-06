Public Class PromoCombo
    Inherits System.Windows.Forms.UserControl


    '********************************************
    ' this is NOT correct
    '   we need to do similiar to Coupon and BSGS
    '
    '********************************************

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
    Friend WithEvents lblPromoComboPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtComboPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo6 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo7 As System.Windows.Forms.TextBox
    Friend WithEvents txtCombo8 As System.Windows.Forms.TextBox
    Friend WithEvents catboxCombo1 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo2 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo3 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo4 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo5 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo6 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo7 As Tahsc_server.PromoCategoryBox
    Friend WithEvents catboxCombo8 As Tahsc_server.PromoCategoryBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtComboPrice = New System.Windows.Forms.TextBox
        Me.lblPromoComboPrice = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCombo1 = New System.Windows.Forms.TextBox
        Me.txtCombo2 = New System.Windows.Forms.TextBox
        Me.txtCombo3 = New System.Windows.Forms.TextBox
        Me.txtCombo4 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCombo5 = New System.Windows.Forms.TextBox
        Me.txtCombo6 = New System.Windows.Forms.TextBox
        Me.txtCombo7 = New System.Windows.Forms.TextBox
        Me.txtCombo8 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.catboxCombo1 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo2 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo3 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo4 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo5 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo6 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo7 = New Tahsc_server.PromoCategoryBox
        Me.catboxCombo8 = New Tahsc_server.PromoCategoryBox
        Me.SuspendLayout()
        '
        'txtComboPrice
        '
        Me.txtComboPrice.Location = New System.Drawing.Point(336, 16)
        Me.txtComboPrice.Name = "txtComboPrice"
        Me.txtComboPrice.Size = New System.Drawing.Size(72, 20)
        Me.txtComboPrice.TabIndex = 0
        Me.txtComboPrice.Text = ""
        '
        'lblPromoComboPrice
        '
        Me.lblPromoComboPrice.Location = New System.Drawing.Point(280, 16)
        Me.lblPromoComboPrice.Name = "lblPromoComboPrice"
        Me.lblPromoComboPrice.Size = New System.Drawing.Size(56, 16)
        Me.lblPromoComboPrice.TabIndex = 1
        Me.lblPromoComboPrice.Text = "Price:"
        Me.lblPromoComboPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Max"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCombo1
        '
        Me.txtCombo1.Location = New System.Drawing.Point(168, 104)
        Me.txtCombo1.Name = "txtCombo1"
        Me.txtCombo1.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo1.TabIndex = 8
        Me.txtCombo1.Text = ""
        '
        'txtCombo2
        '
        Me.txtCombo2.Location = New System.Drawing.Point(168, 136)
        Me.txtCombo2.Name = "txtCombo2"
        Me.txtCombo2.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo2.TabIndex = 9
        Me.txtCombo2.Text = ""
        '
        'txtCombo3
        '
        Me.txtCombo3.Location = New System.Drawing.Point(168, 168)
        Me.txtCombo3.Name = "txtCombo3"
        Me.txtCombo3.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo3.TabIndex = 10
        Me.txtCombo3.Text = ""
        '
        'txtCombo4
        '
        Me.txtCombo4.Location = New System.Drawing.Point(168, 200)
        Me.txtCombo4.Name = "txtCombo4"
        Me.txtCombo4.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo4.TabIndex = 11
        Me.txtCombo4.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Category"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Max"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCombo5
        '
        Me.txtCombo5.Location = New System.Drawing.Point(392, 104)
        Me.txtCombo5.Name = "txtCombo5"
        Me.txtCombo5.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo5.TabIndex = 18
        Me.txtCombo5.Text = ""
        '
        'txtCombo6
        '
        Me.txtCombo6.Location = New System.Drawing.Point(392, 136)
        Me.txtCombo6.Name = "txtCombo6"
        Me.txtCombo6.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo6.TabIndex = 19
        Me.txtCombo6.Text = ""
        '
        'txtCombo7
        '
        Me.txtCombo7.Location = New System.Drawing.Point(392, 168)
        Me.txtCombo7.Name = "txtCombo7"
        Me.txtCombo7.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo7.TabIndex = 20
        Me.txtCombo7.Text = ""
        '
        'txtCombo8
        '
        Me.txtCombo8.Location = New System.Drawing.Point(392, 200)
        Me.txtCombo8.Name = "txtCombo8"
        Me.txtCombo8.Size = New System.Drawing.Size(32, 20)
        Me.txtCombo8.TabIndex = 21
        Me.txtCombo8.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 32)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Combo Promotion"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'catboxCombo1
        '
        Me.catboxCombo1.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo1.Location = New System.Drawing.Point(8, 104)
        Me.catboxCombo1.Name = "catboxCombo1"
        Me.catboxCombo1.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo1.TabIndex = 23
        '
        'catboxCombo2
        '
        Me.catboxCombo2.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo2.Location = New System.Drawing.Point(8, 136)
        Me.catboxCombo2.Name = "catboxCombo2"
        Me.catboxCombo2.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo2.TabIndex = 24
        '
        'catboxCombo3
        '
        Me.catboxCombo3.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo3.Location = New System.Drawing.Point(8, 168)
        Me.catboxCombo3.Name = "catboxCombo3"
        Me.catboxCombo3.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo3.TabIndex = 25
        '
        'catboxCombo4
        '
        Me.catboxCombo4.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo4.Location = New System.Drawing.Point(8, 200)
        Me.catboxCombo4.Name = "catboxCombo4"
        Me.catboxCombo4.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo4.TabIndex = 26
        '
        'catboxCombo5
        '
        Me.catboxCombo5.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo5.Location = New System.Drawing.Point(232, 104)
        Me.catboxCombo5.Name = "catboxCombo5"
        Me.catboxCombo5.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo5.TabIndex = 27
        '
        'catboxCombo6
        '
        Me.catboxCombo6.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo6.Location = New System.Drawing.Point(232, 136)
        Me.catboxCombo6.Name = "catboxCombo6"
        Me.catboxCombo6.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo6.TabIndex = 28
        '
        'catboxCombo7
        '
        Me.catboxCombo7.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo7.Location = New System.Drawing.Point(232, 168)
        Me.catboxCombo7.Name = "catboxCombo7"
        Me.catboxCombo7.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo7.TabIndex = 29
        '
        'catboxCombo8
        '
        Me.catboxCombo8.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.catboxCombo8.Location = New System.Drawing.Point(232, 200)
        Me.catboxCombo8.Name = "catboxCombo8"
        Me.catboxCombo8.Size = New System.Drawing.Size(160, 24)
        Me.catboxCombo8.TabIndex = 30
        '
        'PromoCombo
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.Controls.Add(Me.catboxCombo8)
        Me.Controls.Add(Me.catboxCombo7)
        Me.Controls.Add(Me.catboxCombo6)
        Me.Controls.Add(Me.catboxCombo5)
        Me.Controls.Add(Me.catboxCombo4)
        Me.Controls.Add(Me.catboxCombo3)
        Me.Controls.Add(Me.catboxCombo2)
        Me.Controls.Add(Me.catboxCombo1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCombo8)
        Me.Controls.Add(Me.txtCombo7)
        Me.Controls.Add(Me.txtCombo6)
        Me.Controls.Add(Me.txtCombo5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCombo4)
        Me.Controls.Add(Me.txtCombo3)
        Me.Controls.Add(Me.txtCombo2)
        Me.Controls.Add(Me.txtCombo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPromoComboPrice)
        Me.Controls.Add(Me.txtComboPrice)
        Me.Name = "PromoCombo"
        Me.Size = New System.Drawing.Size(432, 256)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther(ByVal promoID As Integer)
        Dim oRow As DataRow
        Dim catboxIndex As Integer      'starts at 1
        Dim bindingIndex As Integer     'starts as 0

        For Each oRow In dsSetup.Tables("PromoCombo").Rows
            If oRow("PromoID") = promoID Then
                catboxIndex += 1

                Select Case catboxIndex
                    Case Is = 1
                        InitializeComboBox(Me.catboxCombo1, bindingIndex, promoID)
                    Case Is = 2
                        InitializeComboBox(Me.catboxCombo2, bindingIndex, promoID)
                    Case Is = 3
                        InitializeComboBox(Me.catboxCombo3, bindingIndex, promoID)
                    Case Is = 4
                        InitializeComboBox(Me.catboxCombo4, bindingIndex, promoID)
                    Case Is = 5
                        InitializeComboBox(Me.catboxCombo5, bindingIndex, promoID)
                    Case Is = 6
                        InitializeComboBox(Me.catboxCombo6, bindingIndex, promoID)
                    Case Is = 7
                        InitializeComboBox(Me.catboxCombo7, bindingIndex, promoID)
                    Case Is = 8
                        InitializeComboBox(Me.catboxCombo8, bindingIndex, promoID)
                    
                End Select
            End If
            bindingIndex += 1
        Next

        If catboxIndex < 1 Then
            InitializeEmptyComboBox(Me.catboxCombo1, promoID)
        End If
        If catboxIndex < 2 Then
            InitializeEmptyComboBox(Me.catboxCombo2, promoID)
        End If
        If catboxIndex < 3 Then
            InitializeEmptyComboBox(Me.catboxCombo3, promoID)
        End If
        If catboxIndex < 4 Then
            InitializeEmptyComboBox(Me.catboxCombo4, promoID)
        End If
        If catboxIndex < 5 Then
            InitializeEmptyComboBox(Me.catboxCombo5, promoID)
        End If
        If catboxIndex < 6 Then
            InitializeEmptyComboBox(Me.catboxCombo6, promoID)
        End If
        If catboxIndex < 7 Then
            InitializeEmptyComboBox(Me.catboxCombo7, promoID)
        End If
        If catboxIndex < 8 Then
            InitializeEmptyComboBox(Me.catboxCombo8, promoID)
        End If


        BindData()

    End Sub

    Private Sub InitializeComboBox(ByRef comboBox As PromoCategoryBox, ByVal bindingIndex As Integer, ByVal promoID As Integer)
        If dsSetup.Tables("PromoCombo").Rows(bindingIndex)("ComboFD_flag") = "F" Then
            comboBox.FoodDrink_Flag = "F"
        ElseIf dsSetup.Tables("PromoCombo").Rows(bindingIndex)("ComboFD_flag") = "D" Then
            comboBox.FoodDrink_Flag = "D"
        End If

        comboBox.PositionIndex = bindingIndex
        comboBox.PromoID = promoID
        comboBox.PrimaryTable = dsSetup.Tables("PromoCombo")
        comboBox.SupportingTable = dsSetup.Tables("PromoCombo")
        comboBox.PrimaryColumn = "Combo"
        comboBox.InitializeUserControl()

    End Sub

    Private Sub InitializeEmptyComboBox(ByRef comboBox As PromoCategoryBox, ByVal promoID As Integer)

        comboBox.PositionIndex = -1
        comboBox.FoodDrink_Flag = "F"
        comboBox.PromoID = promoID
        comboBox.PrimaryTable = dsSetup.Tables("PromoCombo")
        comboBox.SupportingTable = dsSetup.Tables("PromoCombo")
        comboBox.PrimaryColumn = "Combo"
        comboBox.NewRowFlag = True
        comboBox.InitializeUserControl()

    End Sub
    Private Sub BindData()

        Exit Sub

        '*******************************
        'we need to add this back
        '********************************

        Me.txtComboPrice.DataBindings.Add("Text", dsSetup.Tables("PromoComboDetail"), "ComboPrice")

    End Sub

End Class
