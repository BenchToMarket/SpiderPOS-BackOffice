Public Class SetupPayment
    Inherits System.Windows.Forms.UserControl

    Dim PromotionCurrencyMan As CurrencyManager
    Dim dvPromo As DataView

    '  Dim promoDataHelper As New DataSet_Builder.SQLHelper

    Dim currentBSGS As PromoBSGS
    Dim currentCombo As PromoCombo
    Dim currentCoupon As PromoCoupon
    Dim typeOfPromo As String
    Dim justForAdjusting As Boolean


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
    Friend WithEvents TabCreditCards As System.Windows.Forms.TabPage
    Friend WithEvents TabPromos As System.Windows.Forms.TabPage
    Friend WithEvents btnPromoAdd As System.Windows.Forms.Button
    Friend WithEvents txtPromoName As System.Windows.Forms.TextBox
    Friend WithEvents lblPromoStart As System.Windows.Forms.Label
    Friend WithEvents lblPromoEnd As System.Windows.Forms.Label
    Friend WithEvents lblPromoMaxDollar As System.Windows.Forms.Label
    Friend WithEvents lblPromoMax As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPromoTax As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPromoTaxPromo As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPromoTaxFood As System.Windows.Forms.CheckBox
    Friend WithEvents lblPromoFoodEst As System.Windows.Forms.Label
    Friend WithEvents cbxPromoGuestPay As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lblPromoSelect As System.Windows.Forms.Label
    Friend WithEvents lblPromoName As System.Windows.Forms.Label
    Friend WithEvents grpPromoType As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents pnlPromoDetail As System.Windows.Forms.Panel
    Friend WithEvents btnPromoUpdate As System.Windows.Forms.Button
    Friend WithEvents cbxPromoSelect As System.Windows.Forms.ComboBox
    Friend WithEvents chkPromoActive As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPromoManLevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtPromoMaxCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtPromoMaxDollar As System.Windows.Forms.TextBox
    Friend WithEvents txtPromoEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtPromoStart As System.Windows.Forms.TextBox
    Friend WithEvents rdbPromoCombo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPromoCoupon As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPromoBSGS As System.Windows.Forms.RadioButton
    Friend WithEvents txtPromoMaxTable As System.Windows.Forms.TextBox
    Friend WithEvents chkPromoTip As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAcceptNewPromo As System.Windows.Forms.Button
    Friend WithEvents btnCancelNewPromo As System.Windows.Forms.Button
    Friend WithEvents txtPromoType As System.Windows.Forms.TextBox
    Friend WithEvents pnlNewPromo As System.Windows.Forms.Panel
    Friend WithEvents txtNewEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewStart As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlPromotionMain As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabCreditCards = New System.Windows.Forms.TabPage
        Me.TabPromos = New System.Windows.Forms.TabPage
        Me.pnlNewPromo = New System.Windows.Forms.Panel
        Me.btnCancelNewPromo = New System.Windows.Forms.Button
        Me.btnAcceptNewPromo = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNewEnd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNewStart = New System.Windows.Forms.TextBox
        Me.grpPromoType = New System.Windows.Forms.GroupBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.rdbPromoCombo = New System.Windows.Forms.RadioButton
        Me.rdbPromoCoupon = New System.Windows.Forms.RadioButton
        Me.rdbPromoBSGS = New System.Windows.Forms.RadioButton
        Me.pnlPromoDetail = New System.Windows.Forms.Panel
        Me.pnlPromotionMain = New System.Windows.Forms.Panel
        Me.btnPromoAdd = New System.Windows.Forms.Button
        Me.btnPromoUpdate = New System.Windows.Forms.Button
        Me.lblPromoName = New System.Windows.Forms.Label
        Me.txtPromoName = New System.Windows.Forms.TextBox
        Me.lblPromoSelect = New System.Windows.Forms.Label
        Me.cbxPromoSelect = New System.Windows.Forms.ComboBox
        Me.lblPromoStart = New System.Windows.Forms.Label
        Me.txtPromoStart = New System.Windows.Forms.TextBox
        Me.txtPromoEnd = New System.Windows.Forms.TextBox
        Me.lblPromoEnd = New System.Windows.Forms.Label
        Me.chkPromoActive = New System.Windows.Forms.CheckBox
        Me.txtPromoType = New System.Windows.Forms.TextBox
        Me.txtPromoMaxCheck = New System.Windows.Forms.TextBox
        Me.txtPromoMaxDollar = New System.Windows.Forms.TextBox
        Me.lblPromoMax = New System.Windows.Forms.Label
        Me.lblPromoMaxDollar = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkPromoTip = New System.Windows.Forms.CheckBox
        Me.cbxPromoManLevel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPromoMaxTable = New System.Windows.Forms.TextBox
        Me.grpPromoTax = New System.Windows.Forms.GroupBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.cbxPromoGuestPay = New System.Windows.Forms.CheckBox
        Me.lblPromoFoodEst = New System.Windows.Forms.Label
        Me.cbxPromoTaxFood = New System.Windows.Forms.CheckBox
        Me.cbxPromoTaxPromo = New System.Windows.Forms.CheckBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPromos.SuspendLayout()
        Me.pnlNewPromo.SuspendLayout()
        Me.grpPromoType.SuspendLayout()
        Me.pnlPromotionMain.SuspendLayout()
        Me.grpPromoTax.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCreditCards)
        Me.TabControl1.Controls.Add(Me.TabPromos)
        Me.TabControl1.Location = New System.Drawing.Point(24, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 544)
        Me.TabControl1.TabIndex = 0
        '
        'TabCreditCards
        '
        Me.TabCreditCards.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.TabCreditCards.Location = New System.Drawing.Point(4, 22)
        Me.TabCreditCards.Name = "TabCreditCards"
        Me.TabCreditCards.Size = New System.Drawing.Size(736, 518)
        Me.TabCreditCards.TabIndex = 0
        Me.TabCreditCards.Text = "Credit Cards"
        '
        'TabPromos
        '
        Me.TabPromos.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.TabPromos.Controls.Add(Me.pnlNewPromo)
        Me.TabPromos.Controls.Add(Me.pnlPromoDetail)
        Me.TabPromos.Controls.Add(Me.pnlPromotionMain)
        Me.TabPromos.Controls.Add(Me.grpPromoTax)
        Me.TabPromos.Location = New System.Drawing.Point(4, 22)
        Me.TabPromos.Name = "TabPromos"
        Me.TabPromos.Size = New System.Drawing.Size(736, 518)
        Me.TabPromos.TabIndex = 1
        Me.TabPromos.Text = "Promotions"
        '
        'pnlNewPromo
        '
        Me.pnlNewPromo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNewPromo.Controls.Add(Me.btnCancelNewPromo)
        Me.pnlNewPromo.Controls.Add(Me.btnAcceptNewPromo)
        Me.pnlNewPromo.Controls.Add(Me.Label5)
        Me.pnlNewPromo.Controls.Add(Me.txtNewEnd)
        Me.pnlNewPromo.Controls.Add(Me.Label3)
        Me.pnlNewPromo.Controls.Add(Me.Label4)
        Me.pnlNewPromo.Controls.Add(Me.txtNewStart)
        Me.pnlNewPromo.Controls.Add(Me.grpPromoType)
        Me.pnlNewPromo.Location = New System.Drawing.Point(256, 152)
        Me.pnlNewPromo.Name = "pnlNewPromo"
        Me.pnlNewPromo.Size = New System.Drawing.Size(288, 352)
        Me.pnlNewPromo.TabIndex = 27
        Me.pnlNewPromo.Visible = False
        '
        'btnCancelNewPromo
        '
        Me.btnCancelNewPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelNewPromo.ForeColor = System.Drawing.Color.White
        Me.btnCancelNewPromo.Location = New System.Drawing.Point(24, 312)
        Me.btnCancelNewPromo.Name = "btnCancelNewPromo"
        Me.btnCancelNewPromo.Size = New System.Drawing.Size(104, 32)
        Me.btnCancelNewPromo.TabIndex = 31
        Me.btnCancelNewPromo.Text = "Cancel"
        '
        'btnAcceptNewPromo
        '
        Me.btnAcceptNewPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptNewPromo.ForeColor = System.Drawing.Color.White
        Me.btnAcceptNewPromo.Location = New System.Drawing.Point(160, 312)
        Me.btnAcceptNewPromo.Name = "btnAcceptNewPromo"
        Me.btnAcceptNewPromo.Size = New System.Drawing.Size(104, 32)
        Me.btnAcceptNewPromo.TabIndex = 30
        Me.btnAcceptNewPromo.Text = "Accept"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 32)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Select Promotion Type"
        '
        'txtNewEnd
        '
        Me.txtNewEnd.Location = New System.Drawing.Point(112, 272)
        Me.txtNewEnd.Name = "txtNewEnd"
        Me.txtNewEnd.Size = New System.Drawing.Size(112, 20)
        Me.txtNewEnd.TabIndex = 28
        Me.txtNewEnd.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "End Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Start Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewStart
        '
        Me.txtNewStart.Location = New System.Drawing.Point(112, 240)
        Me.txtNewStart.Name = "txtNewStart"
        Me.txtNewStart.Size = New System.Drawing.Size(112, 20)
        Me.txtNewStart.TabIndex = 25
        Me.txtNewStart.Text = ""
        '
        'grpPromoType
        '
        Me.grpPromoType.Controls.Add(Me.RadioButton6)
        Me.grpPromoType.Controls.Add(Me.RadioButton5)
        Me.grpPromoType.Controls.Add(Me.RadioButton4)
        Me.grpPromoType.Controls.Add(Me.rdbPromoCombo)
        Me.grpPromoType.Controls.Add(Me.rdbPromoCoupon)
        Me.grpPromoType.Controls.Add(Me.rdbPromoBSGS)
        Me.grpPromoType.Location = New System.Drawing.Point(32, 56)
        Me.grpPromoType.Name = "grpPromoType"
        Me.grpPromoType.Size = New System.Drawing.Size(200, 168)
        Me.grpPromoType.TabIndex = 24
        Me.grpPromoType.TabStop = False
        Me.grpPromoType.Text = "Promo Type"
        '
        'RadioButton6
        '
        Me.RadioButton6.Enabled = False
        Me.RadioButton6.Location = New System.Drawing.Point(32, 144)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(128, 16)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Open"
        '
        'RadioButton5
        '
        Me.RadioButton5.Enabled = False
        Me.RadioButton5.Location = New System.Drawing.Point(32, 120)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(128, 16)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Open"
        '
        'RadioButton4
        '
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Location = New System.Drawing.Point(32, 96)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(128, 16)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Open"
        '
        'rdbPromoCombo
        '
        Me.rdbPromoCombo.Enabled = False
        Me.rdbPromoCombo.Location = New System.Drawing.Point(32, 72)
        Me.rdbPromoCombo.Name = "rdbPromoCombo"
        Me.rdbPromoCombo.Size = New System.Drawing.Size(128, 16)
        Me.rdbPromoCombo.TabIndex = 2
        Me.rdbPromoCombo.Text = "Combo"
        '
        'rdbPromoCoupon
        '
        Me.rdbPromoCoupon.Location = New System.Drawing.Point(32, 48)
        Me.rdbPromoCoupon.Name = "rdbPromoCoupon"
        Me.rdbPromoCoupon.Size = New System.Drawing.Size(128, 16)
        Me.rdbPromoCoupon.TabIndex = 1
        Me.rdbPromoCoupon.Text = "Coupon"
        '
        'rdbPromoBSGS
        '
        Me.rdbPromoBSGS.Location = New System.Drawing.Point(32, 24)
        Me.rdbPromoBSGS.Name = "rdbPromoBSGS"
        Me.rdbPromoBSGS.Size = New System.Drawing.Size(136, 16)
        Me.rdbPromoBSGS.TabIndex = 0
        Me.rdbPromoBSGS.Text = "Buy Some Get Some"
        '
        'pnlPromoDetail
        '
        Me.pnlPromoDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPromoDetail.Location = New System.Drawing.Point(280, 16)
        Me.pnlPromoDetail.Name = "pnlPromoDetail"
        Me.pnlPromoDetail.Size = New System.Drawing.Size(432, 256)
        Me.pnlPromoDetail.TabIndex = 25
        '
        'pnlPromotionMain
        '
        Me.pnlPromotionMain.Controls.Add(Me.Label6)
        Me.pnlPromotionMain.Controls.Add(Me.btnPromoAdd)
        Me.pnlPromotionMain.Controls.Add(Me.btnPromoUpdate)
        Me.pnlPromotionMain.Controls.Add(Me.lblPromoName)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoName)
        Me.pnlPromotionMain.Controls.Add(Me.lblPromoSelect)
        Me.pnlPromotionMain.Controls.Add(Me.cbxPromoSelect)
        Me.pnlPromotionMain.Controls.Add(Me.lblPromoStart)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoStart)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoEnd)
        Me.pnlPromotionMain.Controls.Add(Me.lblPromoEnd)
        Me.pnlPromotionMain.Controls.Add(Me.chkPromoActive)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoType)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoMaxCheck)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoMaxDollar)
        Me.pnlPromotionMain.Controls.Add(Me.lblPromoMax)
        Me.pnlPromotionMain.Controls.Add(Me.lblPromoMaxDollar)
        Me.pnlPromotionMain.Controls.Add(Me.Label1)
        Me.pnlPromotionMain.Controls.Add(Me.chkPromoTip)
        Me.pnlPromotionMain.Controls.Add(Me.cbxPromoManLevel)
        Me.pnlPromotionMain.Controls.Add(Me.Label2)
        Me.pnlPromotionMain.Controls.Add(Me.txtPromoMaxTable)
        Me.pnlPromotionMain.Location = New System.Drawing.Point(8, 24)
        Me.pnlPromotionMain.Name = "pnlPromotionMain"
        Me.pnlPromotionMain.Size = New System.Drawing.Size(248, 480)
        Me.pnlPromotionMain.TabIndex = 30
        '
        'btnPromoAdd
        '
        Me.btnPromoAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromoAdd.Location = New System.Drawing.Point(16, 8)
        Me.btnPromoAdd.Name = "btnPromoAdd"
        Me.btnPromoAdd.Size = New System.Drawing.Size(72, 40)
        Me.btnPromoAdd.TabIndex = 1
        Me.btnPromoAdd.Text = "Add New"
        '
        'btnPromoUpdate
        '
        Me.btnPromoUpdate.BackColor = System.Drawing.Color.Red
        Me.btnPromoUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromoUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPromoUpdate.Location = New System.Drawing.Point(104, 8)
        Me.btnPromoUpdate.Name = "btnPromoUpdate"
        Me.btnPromoUpdate.Size = New System.Drawing.Size(120, 40)
        Me.btnPromoUpdate.TabIndex = 26
        Me.btnPromoUpdate.Text = "Update"
        '
        'lblPromoName
        '
        Me.lblPromoName.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(96, Byte), CType(141, Byte))
        Me.lblPromoName.Location = New System.Drawing.Point(16, 144)
        Me.lblPromoName.Name = "lblPromoName"
        Me.lblPromoName.Size = New System.Drawing.Size(64, 16)
        Me.lblPromoName.TabIndex = 3
        Me.lblPromoName.Text = "Name:"
        Me.lblPromoName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPromoName
        '
        Me.txtPromoName.Location = New System.Drawing.Point(88, 136)
        Me.txtPromoName.Name = "txtPromoName"
        Me.txtPromoName.Size = New System.Drawing.Size(136, 20)
        Me.txtPromoName.TabIndex = 2
        Me.txtPromoName.Text = ""
        '
        'lblPromoSelect
        '
        Me.lblPromoSelect.Location = New System.Drawing.Point(8, 72)
        Me.lblPromoSelect.Name = "lblPromoSelect"
        Me.lblPromoSelect.Size = New System.Drawing.Size(80, 16)
        Me.lblPromoSelect.TabIndex = 23
        Me.lblPromoSelect.Text = "Select Promo:"
        Me.lblPromoSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxPromoSelect
        '
        Me.cbxPromoSelect.Location = New System.Drawing.Point(88, 72)
        Me.cbxPromoSelect.Name = "cbxPromoSelect"
        Me.cbxPromoSelect.Size = New System.Drawing.Size(136, 21)
        Me.cbxPromoSelect.TabIndex = 22
        '
        'lblPromoStart
        '
        Me.lblPromoStart.Location = New System.Drawing.Point(16, 168)
        Me.lblPromoStart.Name = "lblPromoStart"
        Me.lblPromoStart.Size = New System.Drawing.Size(72, 24)
        Me.lblPromoStart.TabIndex = 8
        Me.lblPromoStart.Text = "Start Date:"
        Me.lblPromoStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPromoStart
        '
        Me.txtPromoStart.Location = New System.Drawing.Point(88, 168)
        Me.txtPromoStart.Name = "txtPromoStart"
        Me.txtPromoStart.Size = New System.Drawing.Size(128, 20)
        Me.txtPromoStart.TabIndex = 6
        Me.txtPromoStart.Text = ""
        '
        'txtPromoEnd
        '
        Me.txtPromoEnd.Location = New System.Drawing.Point(88, 200)
        Me.txtPromoEnd.Name = "txtPromoEnd"
        Me.txtPromoEnd.Size = New System.Drawing.Size(128, 20)
        Me.txtPromoEnd.TabIndex = 10
        Me.txtPromoEnd.Text = ""
        '
        'lblPromoEnd
        '
        Me.lblPromoEnd.Location = New System.Drawing.Point(16, 200)
        Me.lblPromoEnd.Name = "lblPromoEnd"
        Me.lblPromoEnd.Size = New System.Drawing.Size(72, 24)
        Me.lblPromoEnd.TabIndex = 9
        Me.lblPromoEnd.Text = "End Date:"
        Me.lblPromoEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkPromoActive
        '
        Me.chkPromoActive.Location = New System.Drawing.Point(48, 232)
        Me.chkPromoActive.Name = "chkPromoActive"
        Me.chkPromoActive.Size = New System.Drawing.Size(144, 16)
        Me.chkPromoActive.TabIndex = 20
        Me.chkPromoActive.Text = "Active"
        '
        'txtPromoType
        '
        Me.txtPromoType.Location = New System.Drawing.Point(8, 104)
        Me.txtPromoType.Name = "txtPromoType"
        Me.txtPromoType.Size = New System.Drawing.Size(216, 20)
        Me.txtPromoType.TabIndex = 28
        Me.txtPromoType.Text = ""
        '
        'txtPromoMaxCheck
        '
        Me.txtPromoMaxCheck.Location = New System.Drawing.Point(112, 336)
        Me.txtPromoMaxCheck.Name = "txtPromoMaxCheck"
        Me.txtPromoMaxCheck.Size = New System.Drawing.Size(104, 20)
        Me.txtPromoMaxCheck.TabIndex = 15
        Me.txtPromoMaxCheck.Text = ""
        '
        'txtPromoMaxDollar
        '
        Me.txtPromoMaxDollar.Location = New System.Drawing.Point(112, 304)
        Me.txtPromoMaxDollar.Name = "txtPromoMaxDollar"
        Me.txtPromoMaxDollar.Size = New System.Drawing.Size(104, 20)
        Me.txtPromoMaxDollar.TabIndex = 14
        Me.txtPromoMaxDollar.Text = ""
        '
        'lblPromoMax
        '
        Me.lblPromoMax.Location = New System.Drawing.Point(8, 344)
        Me.lblPromoMax.Name = "lblPromoMax"
        Me.lblPromoMax.Size = New System.Drawing.Size(96, 16)
        Me.lblPromoMax.TabIndex = 12
        Me.lblPromoMax.Text = "Check Maximum:"
        Me.lblPromoMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromoMaxDollar
        '
        Me.lblPromoMaxDollar.Location = New System.Drawing.Point(24, 304)
        Me.lblPromoMaxDollar.Name = "lblPromoMaxDollar"
        Me.lblPromoMaxDollar.Size = New System.Drawing.Size(80, 24)
        Me.lblPromoMaxDollar.TabIndex = 11
        Me.lblPromoMaxDollar.Text = "Max $ Amount:"
        Me.lblPromoMaxDollar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Table Maximum:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkPromoTip
        '
        Me.chkPromoTip.Location = New System.Drawing.Point(56, 440)
        Me.chkPromoTip.Name = "chkPromoTip"
        Me.chkPromoTip.Size = New System.Drawing.Size(128, 24)
        Me.chkPromoTip.TabIndex = 19
        Me.chkPromoTip.Text = "Tip Promo Amount"
        '
        'cbxPromoManLevel
        '
        Me.cbxPromoManLevel.Location = New System.Drawing.Point(112, 400)
        Me.cbxPromoManLevel.Name = "cbxPromoManLevel"
        Me.cbxPromoManLevel.Size = New System.Drawing.Size(104, 21)
        Me.cbxPromoManLevel.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Manager Level:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPromoMaxTable
        '
        Me.txtPromoMaxTable.Location = New System.Drawing.Point(112, 368)
        Me.txtPromoMaxTable.Name = "txtPromoMaxTable"
        Me.txtPromoMaxTable.Size = New System.Drawing.Size(104, 20)
        Me.txtPromoMaxTable.TabIndex = 16
        Me.txtPromoMaxTable.Text = ""
        '
        'grpPromoTax
        '
        Me.grpPromoTax.Controls.Add(Me.TextBox6)
        Me.grpPromoTax.Controls.Add(Me.cbxPromoGuestPay)
        Me.grpPromoTax.Controls.Add(Me.lblPromoFoodEst)
        Me.grpPromoTax.Controls.Add(Me.cbxPromoTaxFood)
        Me.grpPromoTax.Controls.Add(Me.cbxPromoTaxPromo)
        Me.grpPromoTax.Location = New System.Drawing.Point(280, 328)
        Me.grpPromoTax.Name = "grpPromoTax"
        Me.grpPromoTax.Size = New System.Drawing.Size(192, 176)
        Me.grpPromoTax.TabIndex = 21
        Me.grpPromoTax.TabStop = False
        Me.grpPromoTax.Text = "Tax"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(96, 112)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(80, 20)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.Text = ""
        '
        'cbxPromoGuestPay
        '
        Me.cbxPromoGuestPay.Location = New System.Drawing.Point(16, 144)
        Me.cbxPromoGuestPay.Name = "cbxPromoGuestPay"
        Me.cbxPromoGuestPay.Size = New System.Drawing.Size(160, 24)
        Me.cbxPromoGuestPay.TabIndex = 3
        Me.cbxPromoGuestPay.Text = "Guest Pay Tax"
        '
        'lblPromoFoodEst
        '
        Me.lblPromoFoodEst.Location = New System.Drawing.Point(16, 104)
        Me.lblPromoFoodEst.Name = "lblPromoFoodEst"
        Me.lblPromoFoodEst.Size = New System.Drawing.Size(72, 32)
        Me.lblPromoFoodEst.TabIndex = 2
        Me.lblPromoFoodEst.Text = "Food Cost Est. Percent:"
        Me.lblPromoFoodEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxPromoTaxFood
        '
        Me.cbxPromoTaxFood.Location = New System.Drawing.Point(16, 72)
        Me.cbxPromoTaxFood.Name = "cbxPromoTaxFood"
        Me.cbxPromoTaxFood.Size = New System.Drawing.Size(160, 24)
        Me.cbxPromoTaxFood.TabIndex = 1
        Me.cbxPromoTaxFood.Text = "Tax Food Amount"
        '
        'cbxPromoTaxPromo
        '
        Me.cbxPromoTaxPromo.Location = New System.Drawing.Point(16, 32)
        Me.cbxPromoTaxPromo.Name = "cbxPromoTaxPromo"
        Me.cbxPromoTaxPromo.Size = New System.Drawing.Size(160, 24)
        Me.cbxPromoTaxPromo.TabIndex = 0
        Me.cbxPromoTaxPromo.Text = "Tax Promo Amount"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 32)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Promotion is Active if either active is checked OR between dates"
        '
        'SetupPayment
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(78, Byte), CType(152, Byte))
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "SetupPayment"
        Me.Size = New System.Drawing.Size(792, 696)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPromos.ResumeLayout(False)
        Me.pnlNewPromo.ResumeLayout(False)
        Me.grpPromoType.ResumeLayout(False)
        Me.pnlPromotionMain.ResumeLayout(False)
        Me.grpPromoTax.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        BindData()
        PopulatePromotionTables()

        If dsSetup.Tables("Promotion").Rows.Count > 0 Then
            PopulatePromoType(dsSetup.Tables("Promotion").Rows(0))
        End If

    End Sub

    Private Sub BindData()
        Dim oRow As DataRow

        PromotionCurrencyMan = BindingContext(dsSetup.Tables("Promotion"))

        For Each oRow In dsSetup.Tables("Promotion").Rows
            cbxPromoSelect.Items.Add(oRow("PromoName"))
        Next
        Me.cbxPromoSelect.DataSource = dsSetup.Tables("Promotion")
        Me.cbxPromoSelect.DisplayMember = "PromoName"
        '    cbxPromoSelect.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "PromoName")


        txtPromoName.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "PromoName")
        '      rdbPromoBSGS.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "BSGS")
        '      rdbPromoCoupon.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "Coupon")
        '     rdbPromoCombo.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "Combo")


        txtPromoStart.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "StartDate")
        txtPromoEnd.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "EndDate")
        chkPromoActive.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "Active")
        txtPromoMaxDollar.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "MaxAmount")
        txtPromoMaxCheck.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "MaxCheck")
        txtPromoMaxTable.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "MaxTable")
        ''      '           cbxPromoManlevel.DataBindings.Add(
        chkPromoTip.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "TipPromo")



    End Sub

    Private Sub PopulatePromotionTables()

        dsSetup.Tables("PromoBSGSBuy").Clear()
        dsSetup.Tables("PromoBSGSGet").Clear()
        dsSetup.Tables("PromoBSGS").Clear()
        dsSetup.Tables("PromoCombo").Clear()
        dsSetup.Tables("PromoComboDetail").Clear()
        dsSetup.Tables("PromoCoupon").Clear()
        dsSetup.Tables("PromoCouponDiscount").Clear()
        dsSetup.Tables("PromoCouponAtleast").Clear()

        sql.SqlSelectCommandPromoBSGS.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandPromoBSGS.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandBSGSBuy.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandBSGSBuy.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandBSGSGet.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandBSGSGet.Parameters("@LocationID").Value = selectedLocation

        sql.SqlSelectCommandCombo.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCombo.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandComboDetail.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandComboDetail.Parameters("@LocationID").Value = selectedLocation

        sql.SqlSelectCommandCoupon.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCoupon.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandCouponDiscount.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCouponDiscount.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandCouponAtleast.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCouponAtleast.Parameters("@LocationID").Value = selectedLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlPromoBSGSBuy.Fill(dsSetup.Tables("PromoBSGSBuy"))
            sql.SqlPromoBSGSGet.Fill(dsSetup.Tables("PromoBSGSGet"))
            sql.SqlPromoBSGS.Fill(dsSetup.Tables("PromoBSGS"))

            sql.SqlPromoCombo.Fill(dsSetup.Tables("PromoCombo"))
            sql.SqlPromoComboDetail.Fill(dsSetup.Tables("PromoComboDetail"))

            sql.SqlPromoCoupon.Fill(dsSetup.Tables("PromoCoupon"))
            sql.SqlPromoCouponDiscount.Fill(dsSetup.Tables("PromoCouponDiscount"))
            sql.SqlPromoCouponAtleast.Fill(dsSetup.Tables("PromoCouponAtleast"))

            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub rbdPromoBSGS_CheckedChanged222(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles rdbPromoBSGS.CheckedChanged
        ClearPromoDetailPanel()

        If rdbPromoBSGS.Checked = True Then
            dvPromo = New DataView

            With dvPromo
                .Table = dsSetup.Tables("PromoBSGS")
                .RowFilter = "PromoID = '" & PromotionCurrencyMan.Current("PromoID") & "'"
            End With

            If dvPromo.Count = 50 Then
                Dim oRow As DataRow

                oRow = dsSetup.Tables("PromoBSGS").NewRow

                oRow("CompanyID") = corpID
                oRow("LocationID") = selectedLocation
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID")
                oRow("BuyFD_flag") = "F"
                oRow("GetFD_flag") = "F"
                '         oRow("BuyCategoryID") = DBNull.Value
                '         oRow("BuyCategoryAmount") = Nothing
                '         oRow("BuyDrinkCategoryID") = Nothing
                '        oRow("BuyDrinkCategoryAmount") = Nothing
                ''        oRow("GetCategoryID") = Nothing
                '        oRow("GetCategoryAmount") = Nothing
                '        oRow("GetDrinkCategoryID") = Nothing
                '       oRow("GetDrinkCategoryAmount") = Nothing

                dsSetup.Tables("PromoBSGS").Rows.Add(oRow)
                UpdateBSGSData()

            End If

            '   could add: UpdateDataPromotion
            '   this would make anychanges to radio button automatic
            currentBSGS = New PromoBSGS(PromotionCurrencyMan.Current("PromoID"))
            currentBSGS.Location = New Point(0, 0)
            Me.pnlPromoDetail.Controls.Add(currentBSGS)

        End If


    End Sub

    Private Sub UpdateBSGSData()
        '   used when adding new datarow to PromoBSGS
        dsSetup.Tables("PromoBSGSBuy").Clear()
        dsSetup.Tables("PromoBSGSGet").Clear()

        sql.SqlSelectCommandBSGSBuy.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandBSGSBuy.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandBSGSGet.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandBSGSGet.Parameters("@LocationID").Value = selectedLocation

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlPromoBSGS.Update(dsSetup.Tables("PromoBSGS"))
        sql.SqlPromoBSGSBuy.Fill(dsSetup.Tables("PromoBSGSBuy"))
        sql.SqlPromoBSGSGet.Fill(dsSetup.Tables("PromoBSGSGet"))
        sql.cn.Close()



    End Sub

    Private Sub rdbPromoCoupon_CheckedChanged222(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles rdbPromoCoupon.CheckedChanged
        ClearPromoDetailPanel()
        If rdbPromoCoupon.Checked = True Then
            dvPromo = New DataView

            With dvPromo
                .Table = dsSetup.Tables("PromoCoupon")
                .RowFilter = "PromoID = '" & PromotionCurrencyMan.Current("PromoID") & "'"
            End With

            If dvPromo.Count = 50 Then
                '               Me.PromotionCurrencyMan.Position += 1
                '              UpdateDatabasePromotion()
                '             Me.PromotionCurrencyMan.Position -= 1

                Dim oRow As DataRow

                oRow = dsSetup.Tables("PromoCoupon").NewRow

                oRow("CompanyID") = corpID
                oRow("LocationID") = selectedLocation
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID")
                oRow("DiscountFD_flag") = "F"
                oRow("AtleastFD_flag") = "F"
                '           oRow("DiscountCategoryID") = 0 'DBNull.Value
                '           oRow("DiscountCategoryAmount") = 0 ' DBNull.Value
                '           oRow("DiscountDrinkCategoryID") = 0 'DBNull.Value
                '          oRow("AtleastCategoryID") = 0 'DBNull.Value
                ''          oRow("AtleastCategoryAmount") = 0 ' DBNull.Value
                '         oRow("AtleastDrinkCategoryID") = 0 ' DBNull.Value

                '        oRow("CouponDollarFlag") = 0
                '        oRow("CouponDollarAmount") = 0
                ''       oRow("CouponPercentFlag") = 0
                '       oRow("CouponPercentAmount") = 0


                dsSetup.Tables("PromoCoupon").Rows.Add(oRow)
                UpdateCouponData()

            End If


            currentCoupon = New PromoCoupon(PromotionCurrencyMan.Current("PromoID"))
            currentCoupon.Location = New Point(0, 0)
            Me.pnlPromoDetail.Controls.Add(currentCoupon)

        End If


    End Sub

    Private Sub UpdateCouponData()
        dsSetup.Tables("PromoCouponDiscount").Clear()
        dsSetup.Tables("PromoCouponAtleast").Clear()

        sql.SqlSelectCommandCouponDiscount.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCouponDiscount.Parameters("@LocationID").Value = selectedLocation
        sql.SqlSelectCommandCouponAtleast.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandCouponAtleast.Parameters("@LocationID").Value = selectedLocation

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        sql.SqlPromoCoupon.Update(dsSetup.Tables("PromoCoupon"))
        sql.SqlPromoCouponDiscount.Fill(dsSetup.Tables("PromoCouponDiscount"))
        sql.SqlPromoCouponAtleast.Fill(dsSetup.Tables("PromoCouponAtleast"))
        sql.cn.Close()

    End Sub

    Private Sub rdbPromoCombo_CheckedChanged222(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles rdbPromoCombo.CheckedChanged
        ClearPromoDetailPanel()
        If rdbPromoCombo.Checked = True Then
            dvPromo = New DataView

            With dvPromo
                .Table = dsSetup.Tables("PromoCombo")
                .RowFilter = "PromoID = '" & PromotionCurrencyMan.Current("PromoID") & "'"
            End With

            If dvPromo.Count = 50 Then
                Dim oRow As DataRow

                oRow = dsSetup.Tables("PromoCombo").NewRow

                oRow("CompanyID") = corpID
                oRow("LocationID") = selectedLocation
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID")
                oRow("ComboFD_flag") = "F"
                '         oRow("BuyCategoryID") = DBNull.Value
                '         oRow("BuyCategoryAmount") = Nothing
                '         oRow("BuyDrinkCategoryID") = Nothing
                '        oRow("BuyDrinkCategoryAmount") = Nothing
                ''        oRow("GetCategoryID") = Nothing
                '        oRow("GetCategoryAmount") = Nothing
                '        oRow("GetDrinkCategoryID") = Nothing
                '       oRow("GetDrinkCategoryAmount") = Nothing

                dsSetup.Tables("PromoCombo").Rows.Add(oRow)

                oRow = dsSetup.Tables("PromoComboDetail").NewRow
                oRow("CompanyID") = corpID
                oRow("LocationID") = selectedLocation
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID")
                oRow("ComboPrice") = 0
                dsSetup.Tables("PromoComboDetail").Rows.Add(oRow)

                UpdateCombo()

            End If

            currentCombo = New PromoCombo(PromotionCurrencyMan.Current("PromoID"))
            currentCombo.Location = New Point(0, 0)
            Me.pnlPromoDetail.Controls.Add(currentCombo)

        End If

    End Sub

    Private Sub ClearPromoDetailPanel()

        pnlPromoDetail.Controls.Clear()

    End Sub


    Private Sub btnPromoAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromoAdd.Click

        Me.pnlNewPromo.Visible = True
        Me.pnlPromoDetail.Enabled = True
        Me.pnlPromotionMain.Enabled = True

    End Sub

    Private Sub CreateNewPromo()

        Dim oRow As DataRow

        UpdateDatabasePromotion()
        oRow = dsSetup.Tables("Promotion").NewRow

        oRow("CompanyID") = corpID
        oRow("LocationID") = selectedLocation
        oRow("PromoName") = "  ** Enter New Promo"
        oRow("BSGS") = 0
        oRow("Combo") = 0
        oRow("Coupon") = 0
        If Me.rdbPromoBSGS.Checked = True Then
            oRow("BSGS") = 1
        ElseIf Me.rdbPromoCombo.Checked = True Then
            oRow("Combo") = 1
        ElseIf Me.rdbPromoCoupon.Checked = True Then
            oRow("Coupon") = 1
        End If

        If txtNewStart.Text = "" Then
            oRow("StartDate") = DBNull.Value
        Else
            oRow("StartDate") = Format(CType(txtNewStart.Text, Date), "M/d/yyyy")
        End If
        If txtNewEnd.Text = "" Then
            oRow("EndDate") = DBNull.Value
        Else
            oRow("EndDate") = Format(CType(txtNewEnd.Text, Date), "M/d/yyyy")
        End If
        oRow("MaxAmount") = DBNull.Value
        oRow("MaxCheck") = DBNull.Value
        oRow("MaxTable") = DBNull.Value
        oRow("TaxPromoAmount") = 0
        oRow("TaxFoodCost") = 0
        oRow("EstFoodCost") = DBNull.Value
        oRow("GuestPayTax") = 0
        oRow("ManagerLevel") = DBNull.Value
        oRow("TipPromo") = 0
        oRow("Active") = 1

        dsSetup.Tables("Promotion").Rows.Add(oRow)
        oRow("PromoID") = InsertingNewDrink(oRow)
        dsSetup.Tables("Promotion").AcceptChanges()

        PromotionCurrencyMan.Position = PromotionCurrencyMan.Count - 1
        Me.txtPromoName.Focus()

    End Sub

    Private Function InsertingNewDrink(ByRef orow As DataRow)

        Dim newPromoID As Integer

        sql.SqlInsertCommandPromoPromotion.Parameters("@CompanyID").Value = orow("CompanyID")
        sql.SqlInsertCommandPromoPromotion.Parameters("@LocationID").Value = orow("LocationID")
        sql.SqlInsertCommandPromoPromotion.Parameters("@PromoName").Value = orow("PromoName")
        sql.SqlInsertCommandPromoPromotion.Parameters("@BSGS").Value = orow("BSGS")
        sql.SqlInsertCommandPromoPromotion.Parameters("@Combo").Value = orow("Combo")
        sql.SqlInsertCommandPromoPromotion.Parameters("@Coupon").Value = orow("Coupon")
        sql.SqlInsertCommandPromoPromotion.Parameters("@StartDate").Value = orow("StartDate")
        sql.SqlInsertCommandPromoPromotion.Parameters("@EndDate").Value = orow("EndDate")
        sql.SqlInsertCommandPromoPromotion.Parameters("@MaxAmount").Value = orow("MaxAmount")
        sql.SqlInsertCommandPromoPromotion.Parameters("@MaxCheck").Value = orow("MaxCheck")
        sql.SqlInsertCommandMenuDrinks.Parameters("@MaxTable").Value = orow("MaxTable")
        sql.SqlInsertCommandPromoPromotion.Parameters("@TaxPromoAmount").Value = orow("TaxPromoAmount")
        sql.SqlInsertCommandPromoPromotion.Parameters("@TaxFoodCost").Value = orow("TaxFoodCost")
        sql.SqlInsertCommandPromoPromotion.Parameters("@EstFoodCost").Value = orow("EstFoodCost")
        sql.SqlInsertCommandPromoPromotion.Parameters("@GuestPayTax").Value = orow("GuestPayTax")
        sql.SqlInsertCommandPromoPromotion.Parameters("@ManagerLevel").Value = orow("ManagerLevel")
        sql.SqlInsertCommandMenuDrinks.Parameters("@TipPromo").Value = orow("TipPromo")
        sql.SqlInsertCommandPromoPromotion.Parameters("@Active").Value = orow("Active")

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            newPromoID = CType(sql.SqlInsertCommandPromoPromotion.ExecuteScalar(), Integer)
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        Return newPromoID

    End Function

    Private Sub btnPromoUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromoUpdate.Click

        justForAdjusting = True

        If PromotionCurrencyMan.Position < PromotionCurrencyMan.Count - 1 Then
            PromotionCurrencyMan.Position += 1
            PromotionCurrencyMan.Position -= 1
        Else
            PromotionCurrencyMan.Position -= 1
            PromotionCurrencyMan.Position += 1
        End If

        UpdateDatabasePromotion()
        UpdatePromotionDetail()

        PopulatePromotionTables()  'this repopulated
        justForAdjusting = False

    End Sub


    Private Sub UpdateDatabasePromotion()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlPromoPromotion.Update(dsSetup, "Promotion")
            sql.cn.Close()
            dsSetup.Tables("Promotion").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub UpdatePromotionDetail()

        Dim oRow As DataRow

        '     oRow = dsSetup.Tables("Promotion").Rows(cbxPromoSelect.SelectedIndex)

        If typeOfPromo = "BSGS" Then
            UpdateBSGS()
        ElseIf typeOfPromo = "Coupon" Then
            UpdateCoupon()
        ElseIf typeOfPromo = "Combo" Then
            UpdateCombo()
        End If

    End Sub

    Private Sub UpdateBSGS()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            '       sql.SqlPromoBSGSBuy.Update(dsSetup.Tables("PromoBSGSBuy"))
            '      sql.SqlPromoBSGSGet.Update(dsSetup.Tables("PromoBSGSGet"))
            sql.SqlPromoBSGS.Update(dsSetup.Tables("PromoBSGS"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub UpdateCombo()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlPromoCombo.Update(dsSetup.Tables("PromoCombo"))
            sql.SqlPromoComboDetail.Update(dsSetup.Tables("PromoComboDetail"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub UpdateCoupon()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            '      sql.SqlPromoCouponDiscount.Update(dsSetup.Tables("PromoCouponDiscount"))
            '     sql.SqlPromoCouponAtleast.Update(dsSetup.Tables("PromoCouponAtleast"))
            sql.SqlPromoCoupon.Update(dsSetup.Tables("PromoCoupon"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub cbxPromoSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPromoSelect.SelectedIndexChanged
        Dim oRow As DataRow

        If justForAdjusting = True Then Exit Sub

        oRow = dsSetup.Tables("Promotion").Rows(cbxPromoSelect.SelectedIndex)
        PopulatePromoType(oRow)

    End Sub

    Private Sub PopulatePromoType(ByRef oRow As DataRow)

        ClearPromoDetailPanel()

        If oRow("BSGS") = True Then
            Me.txtPromoType.Text = "Buy Something, Get Something"
            currentBSGS = New PromoBSGS(oRow("PromoID"))    'PromotionCurrencyMan.Current("PromoID"))
            currentBSGS.Location = New Point(0, 0)
            Me.pnlPromoDetail.Controls.Add(currentBSGS)
            typeOfPromo = "BSGS"

        ElseIf oRow("Coupon") = True Then
            Me.txtPromoType.Text = "Coupon"
            currentCoupon = New PromoCoupon(oRow("PromoID"))
            currentCoupon.Location = New Point(0, 0)
            Me.pnlPromoDetail.Controls.Add(currentCoupon)
            typeOfPromo = "Coupon"

        ElseIf oRow("Combo") = True Then
            Me.txtPromoType.Text = "Combo"
            currentCombo = New PromoCombo(oRow("PromoID"))
            currentCombo.Location = New Point(0, 0)
            Me.pnlPromoDetail.Controls.Add(currentCombo)
            typeOfPromo = "Combo"

        End If

    End Sub

    Private Sub btnCancelNewPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelNewPromo.Click

        ResetNewPromoValues()

    End Sub

    Private Sub btnAcceptNewPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptNewPromo.Click

        If Me.rdbPromoBSGS.Checked = False And Me.rdbPromoCombo.Checked = False And Me.rdbPromoCoupon.Checked = False Then
            MsgBox("You must select a Promotion Type.")
            Exit Sub
        End If

        CreateNewPromo()
        ResetNewPromoValues()

    End Sub

    Private Sub ResetNewPromoValues()

        Me.pnlNewPromo.Visible = False
        rdbPromoBSGS.Checked = False
        rdbPromoBSGS.Checked = False
        rdbPromoBSGS.Checked = False
        txtNewStart.Text = ""
        txtNewEnd.Text = ""
        Me.pnlPromoDetail.Enabled = True
        Me.pnlPromotionMain.Enabled = True

    End Sub

    Private Sub ValidateDate(ByRef txtValNumeric As TextBox)

        If txtValNumeric.Text = "" Then
            '   cancels the error
            Me.ErrorProvider1.Dispose()

        ElseIf Not IsDate(txtValNumeric.Text) Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a Date or Blank.")
            txtValNumeric.Focus()
            Beep()
        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub txtNewStart_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewStart.Validating
        ValidateDate(txtNewStart)
    End Sub

    Private Sub txtNewEnd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewEnd.Validating
        ValidateDate(txtNewEnd)
    End Sub

    Private Sub txtPromoStart_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPromoStart.Validating
        ValidateDate(txtPromoStart)
    End Sub

    Private Sub txtPromoEnd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPromoEnd.Validating
        ValidateDate(txtPromoEnd)
    End Sub
End Class
