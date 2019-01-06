Imports DataSet_Builder

Public Class SetupEmploy
    Inherits System.Windows.Forms.UserControl

    Dim EmployeeCurrencyMan As CurrencyManager
    Dim JobCodeCurrencyMan As CurrencyManager
    Friend WithEvents btnSwipeCode As System.Windows.Forms.Button
    Dim WithEvents readSwipe As DataSet_Builder.ReadCredit_DSB
    Friend WithEvents Label10 As System.Windows.Forms.Label

    '   Dim didNotAddEmployee As Boolean

    Dim availEmpID As New ArrayList


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeOther()

        '  tmrCardRead_DSB = New Timer
        readSwipe = New ReadCredit_DSB
       
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
    Friend WithEvents grdActiveEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents lblEmpLast As System.Windows.Forms.Label
    Friend WithEvents lblEmpFirst As System.Windows.Forms.Label
    Friend WithEvents lblEmpAddress1 As System.Windows.Forms.Label
    Friend WithEvents lblEmpAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblEmpZip As System.Windows.Forms.Label
    Friend WithEvents lblEmpState As System.Windows.Forms.Label
    Friend WithEvents lblEmpCity As System.Windows.Forms.Label
    Friend WithEvents lblEmpPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmpCell As System.Windows.Forms.Label
    Friend WithEvents lblEmpBirth As System.Windows.Forms.Label
    Friend WithEvents lblEmpHire As System.Windows.Forms.Label
    Friend WithEvents lblEmpReportsTo As System.Windows.Forms.Label
    Friend WithEvents txtEmpLast As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpMiddle As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpCity As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpState As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpZip As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpHome As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpCell As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpBirth As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpHire As System.Windows.Forms.TextBox
    Friend WithEvents chkEmpTerminated As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmpTraining As System.Windows.Forms.CheckBox
    Friend WithEvents cbxEmpReportsTo As System.Windows.Forms.ComboBox
    Friend WithEvents pnlJobPayRates As System.Windows.Forms.Panel
    Friend WithEvents cbxEmpJob1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEmpJob2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpRate1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpRate2 As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpJobCodes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxEmpJob3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEmpJob4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEmpJob5 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEmpJob6 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEmpJob7 As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpRate7 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpRate6 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpRate5 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpRate4 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpRate3 As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateEmployee As System.Windows.Forms.Button
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents cbxEmpID As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpInstruct As System.Windows.Forms.Label
    Friend WithEvents pnlEmpTax As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxEmpFiling As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpDependents As System.Windows.Forms.Label
    Friend WithEvents txtEmpDependent As System.Windows.Forms.TextBox
    Friend WithEvents tabEmpDetail As System.Windows.Forms.TabPage
    Friend WithEvents TabJobCodeDetail As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxJobCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpNick As System.Windows.Forms.Label
    Friend WithEvents txtEmpNick As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents btnOverrides As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOPverrideClose As System.Windows.Forms.Button
    Friend WithEvents pnlOverrides As System.Windows.Forms.Panel
    Friend WithEvents chkOperationLimited As System.Windows.Forms.CheckBox
    Friend WithEvents chkOperationAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkReportLimited As System.Windows.Forms.CheckBox
    Friend WithEvents chkReportAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmployeeLimited As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmployeeAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystemLimited As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystemAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnCreateJobCode As System.Windows.Forms.Button
    Friend WithEvents chkJobManager As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobHost As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobShareTips As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobReportTips As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobClock As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobPassword As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobCashDrawer As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobServer As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobBar As System.Windows.Forms.CheckBox
    Friend WithEvents chkJobCashier As System.Windows.Forms.CheckBox
    Friend WithEvents btnJobCodeUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtUpdateJobCode As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNewJobCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPasscode As System.Windows.Forms.TextBox
    Friend WithEvents chkClockInReqFirst As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabEmpDetail = New System.Windows.Forms.TabPage
        Me.btnSwipeCode = New System.Windows.Forms.Button
        Me.txtPasscode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.pnlOverrides = New System.Windows.Forms.Panel
        Me.chkClockInReqFirst = New System.Windows.Forms.CheckBox
        Me.btnOPverrideClose = New System.Windows.Forms.Button
        Me.chkEmployeeLimited = New System.Windows.Forms.CheckBox
        Me.chkEmployeeAll = New System.Windows.Forms.CheckBox
        Me.chkSystemLimited = New System.Windows.Forms.CheckBox
        Me.chkSystemAll = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkOperationLimited = New System.Windows.Forms.CheckBox
        Me.chkOperationAll = New System.Windows.Forms.CheckBox
        Me.chkReportLimited = New System.Windows.Forms.CheckBox
        Me.chkReportAll = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOverrides = New System.Windows.Forms.Button
        Me.txtEmpID = New System.Windows.Forms.TextBox
        Me.txtEmpNick = New System.Windows.Forms.TextBox
        Me.pnlEmpTax = New System.Windows.Forms.Panel
        Me.txtEmpDependent = New System.Windows.Forms.TextBox
        Me.lblEmpDependents = New System.Windows.Forms.Label
        Me.cbxEmpFiling = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSSN = New System.Windows.Forms.Label
        Me.txtSSN = New System.Windows.Forms.TextBox
        Me.pnlJobPayRates = New System.Windows.Forms.Panel
        Me.txtEmpRate7 = New System.Windows.Forms.TextBox
        Me.txtEmpRate6 = New System.Windows.Forms.TextBox
        Me.txtEmpRate5 = New System.Windows.Forms.TextBox
        Me.txtEmpRate4 = New System.Windows.Forms.TextBox
        Me.txtEmpRate3 = New System.Windows.Forms.TextBox
        Me.cbxEmpJob7 = New System.Windows.Forms.ComboBox
        Me.cbxEmpJob6 = New System.Windows.Forms.ComboBox
        Me.cbxEmpJob5 = New System.Windows.Forms.ComboBox
        Me.cbxEmpJob4 = New System.Windows.Forms.ComboBox
        Me.cbxEmpJob3 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblEmpJobCodes = New System.Windows.Forms.Label
        Me.txtEmpRate2 = New System.Windows.Forms.TextBox
        Me.txtEmpRate1 = New System.Windows.Forms.TextBox
        Me.cbxEmpJob2 = New System.Windows.Forms.ComboBox
        Me.cbxEmpJob1 = New System.Windows.Forms.ComboBox
        Me.chkEmpTerminated = New System.Windows.Forms.CheckBox
        Me.chkEmpTraining = New System.Windows.Forms.CheckBox
        Me.cbxEmpReportsTo = New System.Windows.Forms.ComboBox
        Me.txtEmpHire = New System.Windows.Forms.TextBox
        Me.txtEmpBirth = New System.Windows.Forms.TextBox
        Me.txtEmpCell = New System.Windows.Forms.TextBox
        Me.txtEmpHome = New System.Windows.Forms.TextBox
        Me.txtEmpZip = New System.Windows.Forms.TextBox
        Me.txtEmpState = New System.Windows.Forms.TextBox
        Me.txtEmpCity = New System.Windows.Forms.TextBox
        Me.txtEmpAddress2 = New System.Windows.Forms.TextBox
        Me.txtEmpAddress1 = New System.Windows.Forms.TextBox
        Me.txtEmpMiddle = New System.Windows.Forms.TextBox
        Me.txtEmpFirst = New System.Windows.Forms.TextBox
        Me.txtEmpLast = New System.Windows.Forms.TextBox
        Me.lblEmpReportsTo = New System.Windows.Forms.Label
        Me.lblEmpHire = New System.Windows.Forms.Label
        Me.lblEmpBirth = New System.Windows.Forms.Label
        Me.lblEmpCell = New System.Windows.Forms.Label
        Me.lblEmpPhone = New System.Windows.Forms.Label
        Me.lblEmpZip = New System.Windows.Forms.Label
        Me.lblEmpState = New System.Windows.Forms.Label
        Me.lblEmpCity = New System.Windows.Forms.Label
        Me.lblEmpAddress2 = New System.Windows.Forms.Label
        Me.lblEmpAddress1 = New System.Windows.Forms.Label
        Me.lblEmpNick = New System.Windows.Forms.Label
        Me.lblEmpFirst = New System.Windows.Forms.Label
        Me.lblEmpLast = New System.Windows.Forms.Label
        Me.lblEmpID = New System.Windows.Forms.Label
        Me.grdActiveEmployee = New System.Windows.Forms.DataGrid
        Me.btnUpdateEmployee = New System.Windows.Forms.Button
        Me.TabJobCodeDetail = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnJobCodeUpdate = New System.Windows.Forms.Button
        Me.txtUpdateJobCode = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNewJobCode = New System.Windows.Forms.TextBox
        Me.btnCreateJobCode = New System.Windows.Forms.Button
        Me.chkJobManager = New System.Windows.Forms.CheckBox
        Me.cbxJobCode = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkJobHost = New System.Windows.Forms.CheckBox
        Me.chkJobShareTips = New System.Windows.Forms.CheckBox
        Me.chkJobReportTips = New System.Windows.Forms.CheckBox
        Me.chkJobClock = New System.Windows.Forms.CheckBox
        Me.chkJobPassword = New System.Windows.Forms.CheckBox
        Me.chkJobCashDrawer = New System.Windows.Forms.CheckBox
        Me.chkJobServer = New System.Windows.Forms.CheckBox
        Me.chkJobBar = New System.Windows.Forms.CheckBox
        Me.chkJobCashier = New System.Windows.Forms.CheckBox
        Me.lblEmpInstruct = New System.Windows.Forms.Label
        Me.cbxEmpID = New System.Windows.Forms.ComboBox
        Me.TabControl1.SuspendLayout()
        Me.tabEmpDetail.SuspendLayout()
        Me.pnlOverrides.SuspendLayout()
        Me.pnlEmpTax.SuspendLayout()
        Me.pnlJobPayRates.SuspendLayout()
        CType(Me.grdActiveEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabJobCodeDetail.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabEmpDetail)
        Me.TabControl1.Controls.Add(Me.TabJobCodeDetail)
        Me.TabControl1.Location = New System.Drawing.Point(24, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 544)
        Me.TabControl1.TabIndex = 1
        '
        'tabEmpDetail
        '
        Me.tabEmpDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.tabEmpDetail.Controls.Add(Me.btnSwipeCode)
        Me.tabEmpDetail.Controls.Add(Me.txtPasscode)
        Me.tabEmpDetail.Controls.Add(Me.Label9)
        Me.tabEmpDetail.Controls.Add(Me.pnlOverrides)
        Me.tabEmpDetail.Controls.Add(Me.btnOverrides)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpID)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpNick)
        Me.tabEmpDetail.Controls.Add(Me.pnlEmpTax)
        Me.tabEmpDetail.Controls.Add(Me.lblSSN)
        Me.tabEmpDetail.Controls.Add(Me.txtSSN)
        Me.tabEmpDetail.Controls.Add(Me.pnlJobPayRates)
        Me.tabEmpDetail.Controls.Add(Me.chkEmpTerminated)
        Me.tabEmpDetail.Controls.Add(Me.chkEmpTraining)
        Me.tabEmpDetail.Controls.Add(Me.cbxEmpReportsTo)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpHire)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpBirth)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpCell)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpHome)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpZip)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpState)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpCity)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpAddress2)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpAddress1)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpMiddle)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpFirst)
        Me.tabEmpDetail.Controls.Add(Me.txtEmpLast)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpReportsTo)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpHire)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpBirth)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpCell)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpPhone)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpZip)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpState)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpCity)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpAddress2)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpAddress1)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpNick)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpFirst)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpLast)
        Me.tabEmpDetail.Controls.Add(Me.lblEmpID)
        Me.tabEmpDetail.Controls.Add(Me.grdActiveEmployee)
        Me.tabEmpDetail.Controls.Add(Me.btnUpdateEmployee)
        Me.tabEmpDetail.Location = New System.Drawing.Point(4, 22)
        Me.tabEmpDetail.Name = "tabEmpDetail"
        Me.tabEmpDetail.Size = New System.Drawing.Size(736, 518)
        Me.tabEmpDetail.TabIndex = 0
        Me.tabEmpDetail.Text = "Employee Detail"
        '
        'btnSwipeCode
        '
        Me.btnSwipeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSwipeCode.ForeColor = System.Drawing.Color.White
        Me.btnSwipeCode.Location = New System.Drawing.Point(405, 462)
        Me.btnSwipeCode.Name = "btnSwipeCode"
        Me.btnSwipeCode.Size = New System.Drawing.Size(75, 50)
        Me.btnSwipeCode.TabIndex = 45
        Me.btnSwipeCode.Text = "Swipe Code"
        Me.btnSwipeCode.UseVisualStyleBackColor = False
        '
        'txtPasscode
        '
        Me.txtPasscode.Location = New System.Drawing.Point(328, 464)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.Size = New System.Drawing.Size(64, 20)
        Me.txtPasscode.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(248, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Passcode:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlOverrides
        '
        Me.pnlOverrides.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOverrides.Controls.Add(Me.chkClockInReqFirst)
        Me.pnlOverrides.Controls.Add(Me.btnOPverrideClose)
        Me.pnlOverrides.Controls.Add(Me.chkEmployeeLimited)
        Me.pnlOverrides.Controls.Add(Me.chkEmployeeAll)
        Me.pnlOverrides.Controls.Add(Me.chkSystemLimited)
        Me.pnlOverrides.Controls.Add(Me.chkSystemAll)
        Me.pnlOverrides.Controls.Add(Me.Label6)
        Me.pnlOverrides.Controls.Add(Me.Label5)
        Me.pnlOverrides.Controls.Add(Me.chkOperationLimited)
        Me.pnlOverrides.Controls.Add(Me.chkOperationAll)
        Me.pnlOverrides.Controls.Add(Me.chkReportLimited)
        Me.pnlOverrides.Controls.Add(Me.chkReportAll)
        Me.pnlOverrides.Controls.Add(Me.Label4)
        Me.pnlOverrides.Controls.Add(Me.Label3)
        Me.pnlOverrides.Location = New System.Drawing.Point(548, 464)
        Me.pnlOverrides.Name = "pnlOverrides"
        Me.pnlOverrides.Size = New System.Drawing.Size(464, 312)
        Me.pnlOverrides.TabIndex = 43
        Me.pnlOverrides.Visible = False
        '
        'chkClockInReqFirst
        '
        Me.chkClockInReqFirst.Location = New System.Drawing.Point(280, 264)
        Me.chkClockInReqFirst.Name = "chkClockInReqFirst"
        Me.chkClockInReqFirst.Size = New System.Drawing.Size(128, 24)
        Me.chkClockInReqFirst.TabIndex = 30
        Me.chkClockInReqFirst.Text = "Clock In Required"
        '
        'btnOPverrideClose
        '
        Me.btnOPverrideClose.Location = New System.Drawing.Point(72, 248)
        Me.btnOPverrideClose.Name = "btnOPverrideClose"
        Me.btnOPverrideClose.Size = New System.Drawing.Size(112, 40)
        Me.btnOPverrideClose.TabIndex = 29
        Me.btnOPverrideClose.Text = "Close Window"
        '
        'chkEmployeeLimited
        '
        Me.chkEmployeeLimited.Location = New System.Drawing.Point(280, 192)
        Me.chkEmployeeLimited.Name = "chkEmployeeLimited"
        Me.chkEmployeeLimited.Size = New System.Drawing.Size(104, 24)
        Me.chkEmployeeLimited.TabIndex = 28
        Me.chkEmployeeLimited.Text = "Limited Access"
        '
        'chkEmployeeAll
        '
        Me.chkEmployeeAll.Location = New System.Drawing.Point(280, 160)
        Me.chkEmployeeAll.Name = "chkEmployeeAll"
        Me.chkEmployeeAll.Size = New System.Drawing.Size(104, 24)
        Me.chkEmployeeAll.TabIndex = 27
        Me.chkEmployeeAll.Text = "All Access"
        '
        'chkSystemLimited
        '
        Me.chkSystemLimited.Location = New System.Drawing.Point(280, 88)
        Me.chkSystemLimited.Name = "chkSystemLimited"
        Me.chkSystemLimited.Size = New System.Drawing.Size(104, 24)
        Me.chkSystemLimited.TabIndex = 26
        Me.chkSystemLimited.Text = "Limited Access"
        '
        'chkSystemAll
        '
        Me.chkSystemAll.Location = New System.Drawing.Point(280, 56)
        Me.chkSystemAll.Name = "chkSystemAll"
        Me.chkSystemAll.Size = New System.Drawing.Size(104, 24)
        Me.chkSystemAll.TabIndex = 25
        Me.chkSystemAll.Text = "All Access"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Employee Management"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "System Management"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkOperationLimited
        '
        Me.chkOperationLimited.Location = New System.Drawing.Point(80, 200)
        Me.chkOperationLimited.Name = "chkOperationLimited"
        Me.chkOperationLimited.Size = New System.Drawing.Size(104, 24)
        Me.chkOperationLimited.TabIndex = 22
        Me.chkOperationLimited.Text = "Limited Access"
        '
        'chkOperationAll
        '
        Me.chkOperationAll.Location = New System.Drawing.Point(80, 160)
        Me.chkOperationAll.Name = "chkOperationAll"
        Me.chkOperationAll.Size = New System.Drawing.Size(104, 24)
        Me.chkOperationAll.TabIndex = 21
        Me.chkOperationAll.Text = "All Access"
        '
        'chkReportLimited
        '
        Me.chkReportLimited.Location = New System.Drawing.Point(72, 88)
        Me.chkReportLimited.Name = "chkReportLimited"
        Me.chkReportLimited.Size = New System.Drawing.Size(104, 24)
        Me.chkReportLimited.TabIndex = 20
        Me.chkReportLimited.Text = "Limited Access"
        '
        'chkReportAll
        '
        Me.chkReportAll.Location = New System.Drawing.Point(72, 56)
        Me.chkReportAll.Name = "chkReportAll"
        Me.chkReportAll.Size = New System.Drawing.Size(104, 24)
        Me.chkReportAll.TabIndex = 19
        Me.chkReportAll.Text = "All Access"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Operation Management"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Report Management"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOverrides
        '
        Me.btnOverrides.Location = New System.Drawing.Point(520, 464)
        Me.btnOverrides.Name = "btnOverrides"
        Me.btnOverrides.Size = New System.Drawing.Size(176, 32)
        Me.btnOverrides.TabIndex = 42
        Me.btnOverrides.Text = "Override Options"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(328, 16)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpID.TabIndex = 41
        '
        'txtEmpNick
        '
        Me.txtEmpNick.Location = New System.Drawing.Point(328, 112)
        Me.txtEmpNick.Name = "txtEmpNick"
        Me.txtEmpNick.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpNick.TabIndex = 4
        Me.txtEmpNick.TabStop = False
        '
        'pnlEmpTax
        '
        Me.pnlEmpTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEmpTax.Controls.Add(Me.txtEmpDependent)
        Me.pnlEmpTax.Controls.Add(Me.lblEmpDependents)
        Me.pnlEmpTax.Controls.Add(Me.cbxEmpFiling)
        Me.pnlEmpTax.Controls.Add(Me.Label2)
        Me.pnlEmpTax.Location = New System.Drawing.Point(496, 336)
        Me.pnlEmpTax.Name = "pnlEmpTax"
        Me.pnlEmpTax.Size = New System.Drawing.Size(224, 104)
        Me.pnlEmpTax.TabIndex = 40
        '
        'txtEmpDependent
        '
        Me.txtEmpDependent.Location = New System.Drawing.Point(128, 64)
        Me.txtEmpDependent.Name = "txtEmpDependent"
        Me.txtEmpDependent.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpDependent.TabIndex = 3
        '
        'lblEmpDependents
        '
        Me.lblEmpDependents.Location = New System.Drawing.Point(24, 64)
        Me.lblEmpDependents.Name = "lblEmpDependents"
        Me.lblEmpDependents.Size = New System.Drawing.Size(88, 24)
        Me.lblEmpDependents.TabIndex = 2
        Me.lblEmpDependents.Text = "# Dependents:"
        Me.lblEmpDependents.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxEmpFiling
        '
        Me.cbxEmpFiling.Location = New System.Drawing.Point(32, 32)
        Me.cbxEmpFiling.Name = "cbxEmpFiling"
        Me.cbxEmpFiling.Size = New System.Drawing.Size(160, 21)
        Me.cbxEmpFiling.TabIndex = 1
        Me.cbxEmpFiling.Text = "Filing Status"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Payroll Tax Info"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSSN
        '
        Me.lblSSN.Location = New System.Drawing.Point(248, 152)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(80, 16)
        Me.lblSSN.TabIndex = 37
        Me.lblSSN.Text = "SS#:"
        Me.lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(328, 144)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(152, 20)
        Me.txtSSN.TabIndex = 4
        '
        'pnlJobPayRates
        '
        Me.pnlJobPayRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate7)
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate6)
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate5)
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate4)
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate3)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob7)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob6)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob5)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob4)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob3)
        Me.pnlJobPayRates.Controls.Add(Me.Label1)
        Me.pnlJobPayRates.Controls.Add(Me.lblEmpJobCodes)
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate2)
        Me.pnlJobPayRates.Controls.Add(Me.txtEmpRate1)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob2)
        Me.pnlJobPayRates.Controls.Add(Me.cbxEmpJob1)
        Me.pnlJobPayRates.Location = New System.Drawing.Point(496, 64)
        Me.pnlJobPayRates.Name = "pnlJobPayRates"
        Me.pnlJobPayRates.Size = New System.Drawing.Size(224, 264)
        Me.pnlJobPayRates.TabIndex = 34
        '
        'txtEmpRate7
        '
        Me.txtEmpRate7.Location = New System.Drawing.Point(152, 232)
        Me.txtEmpRate7.Name = "txtEmpRate7"
        Me.txtEmpRate7.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate7.TabIndex = 28
        '
        'txtEmpRate6
        '
        Me.txtEmpRate6.Location = New System.Drawing.Point(152, 200)
        Me.txtEmpRate6.Name = "txtEmpRate6"
        Me.txtEmpRate6.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate6.TabIndex = 26
        '
        'txtEmpRate5
        '
        Me.txtEmpRate5.Location = New System.Drawing.Point(152, 168)
        Me.txtEmpRate5.Name = "txtEmpRate5"
        Me.txtEmpRate5.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate5.TabIndex = 24
        '
        'txtEmpRate4
        '
        Me.txtEmpRate4.Location = New System.Drawing.Point(152, 136)
        Me.txtEmpRate4.Name = "txtEmpRate4"
        Me.txtEmpRate4.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate4.TabIndex = 22
        '
        'txtEmpRate3
        '
        Me.txtEmpRate3.Location = New System.Drawing.Point(152, 104)
        Me.txtEmpRate3.Name = "txtEmpRate3"
        Me.txtEmpRate3.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate3.TabIndex = 20
        '
        'cbxEmpJob7
        '
        Me.cbxEmpJob7.Location = New System.Drawing.Point(8, 232)
        Me.cbxEmpJob7.MaxDropDownItems = 20
        Me.cbxEmpJob7.Name = "cbxEmpJob7"
        Me.cbxEmpJob7.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob7.TabIndex = 27
        '
        'cbxEmpJob6
        '
        Me.cbxEmpJob6.Location = New System.Drawing.Point(8, 200)
        Me.cbxEmpJob6.MaxDropDownItems = 20
        Me.cbxEmpJob6.Name = "cbxEmpJob6"
        Me.cbxEmpJob6.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob6.TabIndex = 25
        '
        'cbxEmpJob5
        '
        Me.cbxEmpJob5.Location = New System.Drawing.Point(8, 168)
        Me.cbxEmpJob5.MaxDropDownItems = 20
        Me.cbxEmpJob5.Name = "cbxEmpJob5"
        Me.cbxEmpJob5.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob5.TabIndex = 23
        '
        'cbxEmpJob4
        '
        Me.cbxEmpJob4.Location = New System.Drawing.Point(8, 136)
        Me.cbxEmpJob4.MaxDropDownItems = 20
        Me.cbxEmpJob4.Name = "cbxEmpJob4"
        Me.cbxEmpJob4.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob4.TabIndex = 21
        '
        'cbxEmpJob3
        '
        Me.cbxEmpJob3.Location = New System.Drawing.Point(8, 104)
        Me.cbxEmpJob3.MaxDropDownItems = 20
        Me.cbxEmpJob3.Name = "cbxEmpJob3"
        Me.cbxEmpJob3.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob3.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpJobCodes
        '
        Me.lblEmpJobCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpJobCodes.Location = New System.Drawing.Point(16, 8)
        Me.lblEmpJobCodes.Name = "lblEmpJobCodes"
        Me.lblEmpJobCodes.Size = New System.Drawing.Size(112, 24)
        Me.lblEmpJobCodes.TabIndex = 4
        Me.lblEmpJobCodes.Text = "Job Codes"
        Me.lblEmpJobCodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmpRate2
        '
        Me.txtEmpRate2.Location = New System.Drawing.Point(152, 72)
        Me.txtEmpRate2.Name = "txtEmpRate2"
        Me.txtEmpRate2.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate2.TabIndex = 18
        '
        'txtEmpRate1
        '
        Me.txtEmpRate1.Location = New System.Drawing.Point(152, 40)
        Me.txtEmpRate1.Name = "txtEmpRate1"
        Me.txtEmpRate1.Size = New System.Drawing.Size(64, 20)
        Me.txtEmpRate1.TabIndex = 16
        '
        'cbxEmpJob2
        '
        Me.cbxEmpJob2.Location = New System.Drawing.Point(8, 72)
        Me.cbxEmpJob2.MaxDropDownItems = 20
        Me.cbxEmpJob2.Name = "cbxEmpJob2"
        Me.cbxEmpJob2.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob2.TabIndex = 17
        '
        'cbxEmpJob1
        '
        Me.cbxEmpJob1.Location = New System.Drawing.Point(8, 40)
        Me.cbxEmpJob1.MaxDropDownItems = 20
        Me.cbxEmpJob1.Name = "cbxEmpJob1"
        Me.cbxEmpJob1.Size = New System.Drawing.Size(136, 21)
        Me.cbxEmpJob1.TabIndex = 15
        '
        'chkEmpTerminated
        '
        Me.chkEmpTerminated.Location = New System.Drawing.Point(305, 490)
        Me.chkEmpTerminated.Name = "chkEmpTerminated"
        Me.chkEmpTerminated.Size = New System.Drawing.Size(87, 24)
        Me.chkEmpTerminated.TabIndex = 33
        Me.chkEmpTerminated.TabStop = False
        Me.chkEmpTerminated.Text = "Terminated"
        '
        'chkEmpTraining
        '
        Me.chkEmpTraining.Location = New System.Drawing.Point(235, 488)
        Me.chkEmpTraining.Name = "chkEmpTraining"
        Me.chkEmpTraining.Size = New System.Drawing.Size(64, 24)
        Me.chkEmpTraining.TabIndex = 32
        Me.chkEmpTraining.TabStop = False
        Me.chkEmpTraining.Text = "Training"
        '
        'cbxEmpReportsTo
        '
        Me.cbxEmpReportsTo.Location = New System.Drawing.Point(328, 432)
        Me.cbxEmpReportsTo.Name = "cbxEmpReportsTo"
        Me.cbxEmpReportsTo.Size = New System.Drawing.Size(160, 21)
        Me.cbxEmpReportsTo.TabIndex = 14
        '
        'txtEmpHire
        '
        Me.txtEmpHire.Location = New System.Drawing.Point(328, 400)
        Me.txtEmpHire.Name = "txtEmpHire"
        Me.txtEmpHire.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpHire.TabIndex = 13
        '
        'txtEmpBirth
        '
        Me.txtEmpBirth.Location = New System.Drawing.Point(328, 368)
        Me.txtEmpBirth.Name = "txtEmpBirth"
        Me.txtEmpBirth.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpBirth.TabIndex = 12
        '
        'txtEmpCell
        '
        Me.txtEmpCell.Location = New System.Drawing.Point(328, 336)
        Me.txtEmpCell.Name = "txtEmpCell"
        Me.txtEmpCell.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpCell.TabIndex = 11
        '
        'txtEmpHome
        '
        Me.txtEmpHome.Location = New System.Drawing.Point(328, 304)
        Me.txtEmpHome.Name = "txtEmpHome"
        Me.txtEmpHome.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpHome.TabIndex = 10
        '
        'txtEmpZip
        '
        Me.txtEmpZip.Location = New System.Drawing.Point(328, 272)
        Me.txtEmpZip.Name = "txtEmpZip"
        Me.txtEmpZip.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpZip.TabIndex = 9
        '
        'txtEmpState
        '
        Me.txtEmpState.Location = New System.Drawing.Point(448, 240)
        Me.txtEmpState.Name = "txtEmpState"
        Me.txtEmpState.Size = New System.Drawing.Size(32, 20)
        Me.txtEmpState.TabIndex = 8
        '
        'txtEmpCity
        '
        Me.txtEmpCity.Location = New System.Drawing.Point(328, 240)
        Me.txtEmpCity.Name = "txtEmpCity"
        Me.txtEmpCity.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpCity.TabIndex = 7
        '
        'txtEmpAddress2
        '
        Me.txtEmpAddress2.Location = New System.Drawing.Point(328, 208)
        Me.txtEmpAddress2.Name = "txtEmpAddress2"
        Me.txtEmpAddress2.Size = New System.Drawing.Size(152, 20)
        Me.txtEmpAddress2.TabIndex = 6
        '
        'txtEmpAddress1
        '
        Me.txtEmpAddress1.Location = New System.Drawing.Point(328, 176)
        Me.txtEmpAddress1.Name = "txtEmpAddress1"
        Me.txtEmpAddress1.Size = New System.Drawing.Size(152, 20)
        Me.txtEmpAddress1.TabIndex = 5
        '
        'txtEmpMiddle
        '
        Me.txtEmpMiddle.Location = New System.Drawing.Point(424, 80)
        Me.txtEmpMiddle.Name = "txtEmpMiddle"
        Me.txtEmpMiddle.Size = New System.Drawing.Size(56, 20)
        Me.txtEmpMiddle.TabIndex = 3
        '
        'txtEmpFirst
        '
        Me.txtEmpFirst.Location = New System.Drawing.Point(328, 80)
        Me.txtEmpFirst.Name = "txtEmpFirst"
        Me.txtEmpFirst.Size = New System.Drawing.Size(96, 20)
        Me.txtEmpFirst.TabIndex = 2
        '
        'txtEmpLast
        '
        Me.txtEmpLast.Location = New System.Drawing.Point(328, 48)
        Me.txtEmpLast.Name = "txtEmpLast"
        Me.txtEmpLast.Size = New System.Drawing.Size(152, 20)
        Me.txtEmpLast.TabIndex = 1
        '
        'lblEmpReportsTo
        '
        Me.lblEmpReportsTo.Location = New System.Drawing.Point(248, 432)
        Me.lblEmpReportsTo.Name = "lblEmpReportsTo"
        Me.lblEmpReportsTo.Size = New System.Drawing.Size(80, 24)
        Me.lblEmpReportsTo.TabIndex = 15
        Me.lblEmpReportsTo.Text = "Reports To:"
        Me.lblEmpReportsTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpHire
        '
        Me.lblEmpHire.Location = New System.Drawing.Point(248, 400)
        Me.lblEmpHire.Name = "lblEmpHire"
        Me.lblEmpHire.Size = New System.Drawing.Size(80, 24)
        Me.lblEmpHire.TabIndex = 14
        Me.lblEmpHire.Text = "Hire Date:"
        Me.lblEmpHire.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpBirth
        '
        Me.lblEmpBirth.Location = New System.Drawing.Point(240, 368)
        Me.lblEmpBirth.Name = "lblEmpBirth"
        Me.lblEmpBirth.Size = New System.Drawing.Size(88, 24)
        Me.lblEmpBirth.TabIndex = 13
        Me.lblEmpBirth.Text = "Birth Date:"
        Me.lblEmpBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpCell
        '
        Me.lblEmpCell.Location = New System.Drawing.Point(240, 336)
        Me.lblEmpCell.Name = "lblEmpCell"
        Me.lblEmpCell.Size = New System.Drawing.Size(88, 24)
        Me.lblEmpCell.TabIndex = 12
        Me.lblEmpCell.Text = "Cell Phone:"
        Me.lblEmpCell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpPhone
        '
        Me.lblEmpPhone.Location = New System.Drawing.Point(232, 304)
        Me.lblEmpPhone.Name = "lblEmpPhone"
        Me.lblEmpPhone.Size = New System.Drawing.Size(96, 24)
        Me.lblEmpPhone.TabIndex = 11
        Me.lblEmpPhone.Text = "Home Phone:"
        Me.lblEmpPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpZip
        '
        Me.lblEmpZip.Location = New System.Drawing.Point(248, 280)
        Me.lblEmpZip.Name = "lblEmpZip"
        Me.lblEmpZip.Size = New System.Drawing.Size(80, 16)
        Me.lblEmpZip.TabIndex = 10
        Me.lblEmpZip.Text = "Zip:"
        Me.lblEmpZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpState
        '
        Me.lblEmpState.Location = New System.Drawing.Point(424, 240)
        Me.lblEmpState.Name = "lblEmpState"
        Me.lblEmpState.Size = New System.Drawing.Size(24, 24)
        Me.lblEmpState.TabIndex = 9
        Me.lblEmpState.Text = "St:"
        Me.lblEmpState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpCity
        '
        Me.lblEmpCity.Location = New System.Drawing.Point(240, 248)
        Me.lblEmpCity.Name = "lblEmpCity"
        Me.lblEmpCity.Size = New System.Drawing.Size(88, 16)
        Me.lblEmpCity.TabIndex = 8
        Me.lblEmpCity.Text = "City:"
        Me.lblEmpCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpAddress2
        '
        Me.lblEmpAddress2.Location = New System.Drawing.Point(232, 208)
        Me.lblEmpAddress2.Name = "lblEmpAddress2"
        Me.lblEmpAddress2.Size = New System.Drawing.Size(96, 24)
        Me.lblEmpAddress2.TabIndex = 7
        Me.lblEmpAddress2.Text = "Address 2:"
        Me.lblEmpAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpAddress1
        '
        Me.lblEmpAddress1.Location = New System.Drawing.Point(232, 176)
        Me.lblEmpAddress1.Name = "lblEmpAddress1"
        Me.lblEmpAddress1.Size = New System.Drawing.Size(96, 24)
        Me.lblEmpAddress1.TabIndex = 6
        Me.lblEmpAddress1.Text = "Address 1:"
        Me.lblEmpAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpNick
        '
        Me.lblEmpNick.Location = New System.Drawing.Point(232, 120)
        Me.lblEmpNick.Name = "lblEmpNick"
        Me.lblEmpNick.Size = New System.Drawing.Size(96, 16)
        Me.lblEmpNick.TabIndex = 5
        Me.lblEmpNick.Text = "NickName:"
        Me.lblEmpNick.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpFirst
        '
        Me.lblEmpFirst.Location = New System.Drawing.Point(232, 88)
        Me.lblEmpFirst.Name = "lblEmpFirst"
        Me.lblEmpFirst.Size = New System.Drawing.Size(96, 16)
        Me.lblEmpFirst.TabIndex = 4
        Me.lblEmpFirst.Text = "First / Middle:"
        Me.lblEmpFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpLast
        '
        Me.lblEmpLast.Location = New System.Drawing.Point(232, 48)
        Me.lblEmpLast.Name = "lblEmpLast"
        Me.lblEmpLast.Size = New System.Drawing.Size(96, 24)
        Me.lblEmpLast.TabIndex = 3
        Me.lblEmpLast.Text = "Last Name:"
        Me.lblEmpLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpID
        '
        Me.lblEmpID.Location = New System.Drawing.Point(232, 16)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(96, 16)
        Me.lblEmpID.TabIndex = 2
        Me.lblEmpID.Text = "Employee ID:"
        Me.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdActiveEmployee
        '
        Me.grdActiveEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdActiveEmployee.ColumnHeadersVisible = False
        Me.grdActiveEmployee.DataMember = ""
        Me.grdActiveEmployee.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grdActiveEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdActiveEmployee.Location = New System.Drawing.Point(18, 31)
        Me.grdActiveEmployee.Name = "grdActiveEmployee"
        Me.grdActiveEmployee.ReadOnly = True
        Me.grdActiveEmployee.RowHeadersVisible = False
        Me.grdActiveEmployee.Size = New System.Drawing.Size(208, 453)
        Me.grdActiveEmployee.TabIndex = 0
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.BackColor = System.Drawing.Color.Red
        Me.btnUpdateEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(536, 16)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(160, 32)
        Me.btnUpdateEmployee.TabIndex = 29
        Me.btnUpdateEmployee.Text = "Update"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = False
        Me.btnUpdateEmployee.Visible = False
        '
        'TabJobCodeDetail
        '
        Me.TabJobCodeDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TabJobCodeDetail.Controls.Add(Me.Label10)
        Me.TabJobCodeDetail.Controls.Add(Me.Panel3)
        Me.TabJobCodeDetail.Controls.Add(Me.Panel2)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobManager)
        Me.TabJobCodeDetail.Controls.Add(Me.cbxJobCode)
        Me.TabJobCodeDetail.Controls.Add(Me.Label8)
        Me.TabJobCodeDetail.Controls.Add(Me.Label7)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobHost)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobShareTips)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobReportTips)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobClock)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobPassword)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobCashDrawer)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobServer)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobBar)
        Me.TabJobCodeDetail.Controls.Add(Me.chkJobCashier)
        Me.TabJobCodeDetail.Location = New System.Drawing.Point(4, 22)
        Me.TabJobCodeDetail.Name = "TabJobCodeDetail"
        Me.TabJobCodeDetail.Size = New System.Drawing.Size(736, 518)
        Me.TabJobCodeDetail.TabIndex = 1
        Me.TabJobCodeDetail.Text = "Jobcode Detail"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 156)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Function only defines which screens flows for this Jobcode. For example, Manageme" & _
            "nt will go directly to Management screen. List override options in each Employee" & _
            " under Override Options."
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnJobCodeUpdate)
        Me.Panel3.Controls.Add(Me.txtUpdateJobCode)
        Me.Panel3.Location = New System.Drawing.Point(360, 384)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 112)
        Me.Panel3.TabIndex = 29
        '
        'btnJobCodeUpdate
        '
        Me.btnJobCodeUpdate.BackColor = System.Drawing.Color.Red
        Me.btnJobCodeUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobCodeUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnJobCodeUpdate.Location = New System.Drawing.Point(8, 8)
        Me.btnJobCodeUpdate.Name = "btnJobCodeUpdate"
        Me.btnJobCodeUpdate.Size = New System.Drawing.Size(144, 40)
        Me.btnJobCodeUpdate.TabIndex = 27
        Me.btnJobCodeUpdate.Text = "Update"
        Me.btnJobCodeUpdate.UseVisualStyleBackColor = False
        '
        'txtUpdateJobCode
        '
        Me.txtUpdateJobCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateJobCode.Location = New System.Drawing.Point(16, 72)
        Me.txtUpdateJobCode.Name = "txtUpdateJobCode"
        Me.txtUpdateJobCode.Size = New System.Drawing.Size(128, 22)
        Me.txtUpdateJobCode.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNewJobCode)
        Me.Panel2.Controls.Add(Me.btnCreateJobCode)
        Me.Panel2.Location = New System.Drawing.Point(536, 384)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 112)
        Me.Panel2.TabIndex = 28
        '
        'txtNewJobCode
        '
        Me.txtNewJobCode.Location = New System.Drawing.Point(16, 72)
        Me.txtNewJobCode.Name = "txtNewJobCode"
        Me.txtNewJobCode.Size = New System.Drawing.Size(128, 20)
        Me.txtNewJobCode.TabIndex = 26
        '
        'btnCreateJobCode
        '
        Me.btnCreateJobCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateJobCode.Location = New System.Drawing.Point(8, 8)
        Me.btnCreateJobCode.Name = "btnCreateJobCode"
        Me.btnCreateJobCode.Size = New System.Drawing.Size(144, 40)
        Me.btnCreateJobCode.TabIndex = 25
        Me.btnCreateJobCode.Text = "Create New"
        '
        'chkJobManager
        '
        Me.chkJobManager.Location = New System.Drawing.Point(240, 144)
        Me.chkJobManager.Name = "chkJobManager"
        Me.chkJobManager.Size = New System.Drawing.Size(104, 24)
        Me.chkJobManager.TabIndex = 24
        Me.chkJobManager.Text = "Manager"
        '
        'cbxJobCode
        '
        Me.cbxJobCode.Location = New System.Drawing.Point(296, 40)
        Me.cbxJobCode.Name = "cbxJobCode"
        Me.cbxJobCode.Size = New System.Drawing.Size(176, 21)
        Me.cbxJobCode.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Requirements"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Functions"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkJobHost
        '
        Me.chkJobHost.Location = New System.Drawing.Point(240, 304)
        Me.chkJobHost.Name = "chkJobHost"
        Me.chkJobHost.Size = New System.Drawing.Size(104, 24)
        Me.chkJobHost.TabIndex = 12
        Me.chkJobHost.Text = "Host / Hostess"
        '
        'chkJobShareTips
        '
        Me.chkJobShareTips.Location = New System.Drawing.Point(520, 272)
        Me.chkJobShareTips.Name = "chkJobShareTips"
        Me.chkJobShareTips.Size = New System.Drawing.Size(112, 24)
        Me.chkJobShareTips.TabIndex = 7
        Me.chkJobShareTips.Text = "Share Tips Req'd"
        Me.chkJobShareTips.Visible = False
        '
        'chkJobReportTips
        '
        Me.chkJobReportTips.Location = New System.Drawing.Point(520, 232)
        Me.chkJobReportTips.Name = "chkJobReportTips"
        Me.chkJobReportTips.Size = New System.Drawing.Size(120, 24)
        Me.chkJobReportTips.TabIndex = 6
        Me.chkJobReportTips.Text = "Report Tips Req'd"
        Me.chkJobReportTips.Visible = False
        '
        'chkJobClock
        '
        Me.chkJobClock.Checked = True
        Me.chkJobClock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJobClock.Location = New System.Drawing.Point(520, 192)
        Me.chkJobClock.Name = "chkJobClock"
        Me.chkJobClock.Size = New System.Drawing.Size(104, 24)
        Me.chkJobClock.TabIndex = 5
        Me.chkJobClock.Text = "Clock-in Req'd"
        Me.chkJobClock.Visible = False
        '
        'chkJobPassword
        '
        Me.chkJobPassword.Location = New System.Drawing.Point(520, 152)
        Me.chkJobPassword.Name = "chkJobPassword"
        Me.chkJobPassword.Size = New System.Drawing.Size(112, 24)
        Me.chkJobPassword.TabIndex = 4
        Me.chkJobPassword.Text = "Password Req'd"
        '
        'chkJobCashDrawer
        '
        Me.chkJobCashDrawer.Location = New System.Drawing.Point(240, 352)
        Me.chkJobCashDrawer.Name = "chkJobCashDrawer"
        Me.chkJobCashDrawer.Size = New System.Drawing.Size(104, 24)
        Me.chkJobCashDrawer.TabIndex = 3
        Me.chkJobCashDrawer.Text = "Cash Drawer"
        '
        'chkJobServer
        '
        Me.chkJobServer.Location = New System.Drawing.Point(240, 224)
        Me.chkJobServer.Name = "chkJobServer"
        Me.chkJobServer.Size = New System.Drawing.Size(104, 24)
        Me.chkJobServer.TabIndex = 2
        Me.chkJobServer.Text = "Server"
        '
        'chkJobBar
        '
        Me.chkJobBar.Location = New System.Drawing.Point(240, 184)
        Me.chkJobBar.Name = "chkJobBar"
        Me.chkJobBar.Size = New System.Drawing.Size(104, 24)
        Me.chkJobBar.TabIndex = 1
        Me.chkJobBar.Text = "Bartender"
        '
        'chkJobCashier
        '
        Me.chkJobCashier.Location = New System.Drawing.Point(240, 264)
        Me.chkJobCashier.Name = "chkJobCashier"
        Me.chkJobCashier.Size = New System.Drawing.Size(104, 24)
        Me.chkJobCashier.TabIndex = 0
        Me.chkJobCashier.Text = "Cashier"
        '
        'lblEmpInstruct
        '
        Me.lblEmpInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpInstruct.ForeColor = System.Drawing.Color.White
        Me.lblEmpInstruct.Location = New System.Drawing.Point(487, 35)
        Me.lblEmpInstruct.Name = "lblEmpInstruct"
        Me.lblEmpInstruct.Size = New System.Drawing.Size(198, 57)
        Me.lblEmpInstruct.TabIndex = 39
        Me.lblEmpInstruct.Text = "Select New Employee ID from Drop Down Box ONLY to add New Employee"
        Me.lblEmpInstruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxEmpID
        '
        Me.cbxEmpID.Location = New System.Drawing.Point(544, 95)
        Me.cbxEmpID.MaxDropDownItems = 50
        Me.cbxEmpID.Name = "cbxEmpID"
        Me.cbxEmpID.Size = New System.Drawing.Size(88, 21)
        Me.cbxEmpID.TabIndex = 0
        '
        'SetupEmploy
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblEmpInstruct)
        Me.Controls.Add(Me.cbxEmpID)
        Me.Name = "SetupEmploy"
        Me.Size = New System.Drawing.Size(792, 704)
        Me.TabControl1.ResumeLayout(False)
        Me.tabEmpDetail.ResumeLayout(False)
        Me.tabEmpDetail.PerformLayout()
        Me.pnlOverrides.ResumeLayout(False)
        Me.pnlEmpTax.ResumeLayout(False)
        Me.pnlEmpTax.PerformLayout()
        Me.pnlJobPayRates.ResumeLayout(False)
        Me.pnlJobPayRates.PerformLayout()
        CType(Me.grdActiveEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabJobCodeDetail.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            GenerateEmployeeDataSets()
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

        CreateEmpIDArray()
        UpdateEmpIDArray()

        DisplayEmployeeListTab()

        RePositionOverridePanel()

        BindData()

        BindJobCodeNameComboBoxes222()

    End Sub


    Private Sub BindData()
        Dim oRow As DataRow

        EmployeeCurrencyMan = BindingContext(dsSetup.Tables("ActiveEmployee"))
        JobCodeCurrencyMan = BindingContext(dsSetup.Tables("JobCodes"))


        '   *****************************
        '   EmployList
        Dim empID As Integer
        For Each empID In availEmpID
            Me.cbxEmpID.Items.Add(empID)
        Next

        Me.grdActiveEmployee.DataSource = dsSetup.Tables("ActiveEmployee")
        Me.cbxJobCode.DataSource = dsSetup.Tables("JobCodes")
        Me.cbxJobCode.DisplayMember = "JobCodeName"

        '   *****must add one back
        '       Me.cbxEmpID.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "EmployeeID")
        Me.txtEmpID.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "EmployeeNumber")
        Me.txtEmpLast.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "LastName")
        Me.txtEmpFirst.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "FirstName")
        Me.txtEmpMiddle.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "MiddleName")
        Me.txtEmpNick.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "NickName")
        Me.txtSSN.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "SSN")
        Me.txtEmpAddress1.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Address1")
        Me.txtEmpAddress2.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Address2")
        Me.txtEmpCity.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "City")
        Me.txtEmpState.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "State")
        Me.txtEmpZip.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Zip")
        Me.txtEmpHome.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "HomePhone")
        Me.txtEmpCell.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "CellPhone")
        Me.txtEmpBirth.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "BirthDate")
        Me.txtEmpHire.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "HireDate")
        Me.txtPasscode.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Passcode")



        '        Me.cbxEmpReportsTo.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "ReportsTo")
        Me.chkEmpTraining.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "Training")
        Me.chkEmpTerminated.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "Terminated")

        Me.chkOperationAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "OperationMgmtAll")
        Me.chkOperationLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "OperationMgmtLimited")
        Me.chkReportAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "ReportMgmtAll")
        Me.chkReportLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "ReportMgmtLimited")
        Me.chkSystemAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "SystemMgmtAll")
        Me.chkSystemLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "SystemMgmtLimited")
        Me.chkEmployeeAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "EmployeeMgmtAll")
        Me.chkEmployeeLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "EmployeeMgmtLimited")
        Me.chkClockInReqFirst.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "ClockInReq")

        For Each oRow In dsSetup.Tables("ActiveEmployee").Rows
            If oRow("EmployeeMgmtAll") = True Or oRow("EmployeeMgmtLimited") = True Then
                Me.cbxEmpReportsTo.Items.Add(oRow("LastName") & ", " & oRow("FirstName"))
            End If
        Next
        Me.cbxEmpReportsTo.Items.Add("** Delete Supervisor **")

        BindJobCodeNames()

        For Each oRow In dsSetup.Tables("TaxFilingStatus").Rows
            Me.cbxEmpFiling.Items.Add(oRow("FilingStatusName"))
        Next

        Me.txtEmpRate1.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate1")
        Me.txtEmpRate2.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate2")
        Me.txtEmpRate3.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate3")
        Me.txtEmpRate4.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate4")
        Me.txtEmpRate5.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate5")
        Me.txtEmpRate6.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate6")
        Me.txtEmpRate7.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate7")

        Me.cbxEmpJob1.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName1")
        Me.cbxEmpJob2.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName2")
        Me.cbxEmpJob3.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName3")
        Me.cbxEmpJob4.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName4")
        Me.cbxEmpJob5.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName5")
        Me.cbxEmpJob6.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName6")
        Me.cbxEmpJob7.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName7")



        Me.cbxJobCode.DataBindings.Add("Text", dsSetup.Tables("JobCodes"), "JobCodeName")
        Me.txtUpdateJobCode.DataBindings.Add("Text", dsSetup.Tables("JobCodes"), "JobCodeName")
        Me.chkJobManager.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Manager")
        Me.chkJobBar.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Bartender")
        Me.chkJobServer.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Server")
        Me.chkJobCashier.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Cashier")
        Me.chkJobHost.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Hostess")
        Me.chkJobPassword.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "PasswordReq")
        Me.chkJobClock.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "ClockInReq")
        Me.chkJobReportTips.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "ReportTipsReq")
        Me.chkJobShareTips.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "ShareTipsReq")

    End Sub

    Private Sub RePopulateJobCodeData()

        dsSetup.Tables("JobCodes").Clear()
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@CompanyID").Value = corpID
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@LocationID").Value = corpPhysicalLocation

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlEmployeeJobCodes.Fill(dsSetup.Tables("JobCodes"))
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
        End Try

    End Sub

    Private Sub BindJobCodeNames()
        Dim oRow As DataRow

        Me.cbxEmpJob1.Items.Clear()
        Me.cbxEmpJob2.Items.Clear()
        Me.cbxEmpJob3.Items.Clear()
        Me.cbxEmpJob4.Items.Clear()
        Me.cbxEmpJob5.Items.Clear()
        Me.cbxEmpJob6.Items.Clear()
        Me.cbxEmpJob7.Items.Clear()

        For Each oRow In dsSetup.Tables("JobCodes").Rows
            Me.cbxEmpJob1.Items.Add(oRow("JobCodeName"))
            Me.cbxEmpJob2.Items.Add(oRow("JobCodeName"))
            Me.cbxEmpJob3.Items.Add(oRow("JobCodeName"))
            Me.cbxEmpJob4.Items.Add(oRow("JobCodeName"))
            Me.cbxEmpJob5.Items.Add(oRow("JobCodeName"))
            Me.cbxEmpJob6.Items.Add(oRow("JobCodeName"))
            Me.cbxEmpJob7.Items.Add(oRow("JobCodeName"))
            '   this is on 2nd page
            '           Me.cbxJobCode.Items.Add(oRow("JobCodeName"))
        Next

        Me.cbxEmpJob1.Items.Add("** Delete Job Code **")
        Me.cbxEmpJob2.Items.Add("** Delete Job Code **")
        Me.cbxEmpJob3.Items.Add("** Delete Job Code **")
        Me.cbxEmpJob4.Items.Add("** Delete Job Code **")
        Me.cbxEmpJob5.Items.Add("** Delete Job Code **")
        Me.cbxEmpJob6.Items.Add("** Delete Job Code **")
        Me.cbxEmpJob7.Items.Add("** Delete Job Code **")

    End Sub

    Private Sub RePositionOverridePanel()

        Me.pnlOverrides.Location = New Point((Me.Width - Me.pnlOverrides.Width) / 2, (Me.Height - Me.pnlOverrides.Height) / 2)

    End Sub

    Private Sub DisplayEmployeeListTab()
        Dim tsActiveEmployee As New DataGridTableStyle
        tsActiveEmployee.MappingName = "ActiveEmployee"
        tsActiveEmployee.RowHeadersVisible = False
        tsActiveEmployee.GridLineStyle = DataGridLineStyle.None

        Dim csLastName As New DataGridTextBoxColumn
        csLastName.MappingName = "LastName"
        csLastName.Width = 100

        Dim csFirstName As New DataGridTextBoxColumn
        csFirstName.MappingName = "FirstName"
        csFirstName.Width = 50

        Dim csEmpID As New DataGridTextBoxColumn
        csEmpID.MappingName = "EmployeeNumber"
        csEmpID.Width = 50

        tsActiveEmployee.GridColumnStyles.Add(csLastName)
        tsActiveEmployee.GridColumnStyles.Add(csFirstName)
        tsActiveEmployee.GridColumnStyles.Add(csEmpID)
        Me.grdActiveEmployee.TableStyles.Add(tsActiveEmployee)

    End Sub

    Private Sub UpdateDatabaseEmployee()

        '      If didNotAddEmployee = True Then
        '         If Me.txtEmpLast.TextLength = 0 Then
        '          dsSetup.Tables("ActiveEmployee").RejectChanges()
        '     Exit Sub 'this is if we start to add emp but don't put a last name
        '    End If

        If Not dsSetup.HasChanges Then Exit Sub
        MakeSureAllSelectedJobCodesNoNULLS222()

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlEmployeeActiveEmployee.Update(dsSetup, "ActiveEmployee")
            sql.cn.Close()
            dsSetup.Tables("ActiveEmployee").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub MakeSureAllSelectedJobCodesNoNULLS222()

        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID1") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate1") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate1") = 0
            End If
        End If
        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID2") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate2") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate2") = 0
            End If
        End If
        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID3") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate3") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate3") = 0
            End If
        End If
        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID4") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate4") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate4") = 0
            End If
        End If
        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID5") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate5") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate5") = 0
            End If
        End If
        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID6") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate6") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate6") = 0
            End If
        End If
        If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID7") Is DBNull.Value Then
            If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate7") Is DBNull.Value Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate7") = 0
            End If
        End If

    End Sub

    Private Sub btnUpdateEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateEmployee.Click

        If Me.EmployeeCurrencyMan.Position = 0 Then
            EmployeeCurrencyMan.Position += 1
            EmployeeCurrencyMan.Position -= 1
        Else
            EmployeeCurrencyMan.Position -= 1
            EmployeeCurrencyMan.Position += 1
        End If

        UpdateDatabaseEmployee()

    End Sub

    Private Sub cbxEmpID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpID.SelectedIndexChanged

        Dim oRow As DataRow

        oRow = dsSetup.Tables("ActiveEmployee").NewRow

        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation   'selectedLocation
        oRow("EmployeeNumber") = CType(Me.cbxEmpID.Text, Integer)
        availEmpID.Remove(CInt(Me.cbxEmpID.Text))
        oRow("LastName") = "Enter Last Name"
        oRow("FirstName") = ""
        oRow("MiddleName") = ""
        oRow("NickName") = ""
        oRow("Passcode") = CType(Format(Int((9999 * Rnd()) + 1), "0000"), String)
        oRow("BirthDate") = DBNull.Value
        oRow("HireDate") = Format(Date.Now, "M/d/yyyy")
        oRow("Address1") = ""
        oRow("Address2") = ""
        oRow("City") = ""
        oRow("State") = ""
        oRow("Zip") = ""
        oRow("HomePhone") = ""
        oRow("CellPhone") = ""

        oRow("ReportsTo") = DBNull.Value
        oRow("Training") = 0
        oRow("Terminated") = 0
        oRow("ClockInReq") = 1

        oRow("ReportMgmtAll") = 0
        oRow("ReportMgmtLimited") = 0
        oRow("OperationMgmtAll") = 0
        oRow("OperationMgmtLimited") = 0
        oRow("SystemMgmtAll") = 0
        oRow("SystemMgmtLimited") = 0
        oRow("EmployeeMgmtAll") = 0
        oRow("EmployeeMgmtLimited") = 0

        oRow("JobCodeID1") = DBNull.Value
        oRow("JobRate1") = 0 'DBNull.Value
        oRow("JobCodeID2") = DBNull.Value
        oRow("JobRate2") = 0 'DBNull.Value
        oRow("JobCodeID3") = DBNull.Value
        oRow("JobRate3") = 0 'DBNull.Value
        oRow("JobCodeID4") = DBNull.Value
        oRow("JobRate4") = 0 'DBNull.Value
        oRow("JobCodeID5") = DBNull.Value
        oRow("JobRate5") = 0 'DBNull.Value
        oRow("JobCodeID6") = DBNull.Value
        oRow("JobRate6") = 0 'DBNull.Value
        oRow("JobCodeID7") = DBNull.Value
        oRow("JobRate7") = 0 'DBNull.Value
        oRow("Lefty") = 0 'DBNull.Value

        dsSetup.Tables("ActiveEmployee").Rows.Add(oRow)

        EmployeeCurrencyMan.Position = EmployeeCurrencyMan.Count - 1
        Me.txtEmpLast.Focus()
        '      didNotAddEmployee = True

    End Sub

    '   Private Sub txtEmpLast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpLast.TextChanged
    '      If Me.txtEmpLast.TextLength = 1 Then
    '         didNotAddEmployee = False
    '    End If
    '    End Sub

    Private Sub CreateEmpIDArray()
        Dim index As Integer
        Dim oRow As DataRow
        Dim addID As Boolean

        For index = 1000 To 9999
            availEmpID.Add(index)
        Next

        For Each oRow In dsSetup.Tables("ActiveEmployee").Rows
            availEmpID.Remove(CInt(oRow("EmployeeNumber")))
        Next
        availEmpID.Remove(6986) 'me

    End Sub

    Private Sub UpdateEmpIDArray()
        Dim oRow As DataRow

        For Each oRow In dsSetup.Tables("UsedEmployeeNumber").Rows
            availEmpID.Remove(oRow("EmployeeNumber"))
        Next

    End Sub

    Private Sub txtEmpFirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpFirst.TextChanged
        '    If Me.txtEmpNick.Text.Length = 0 Then
        Me.txtEmpNick.Text = Me.txtEmpFirst.Text
        'End If

    End Sub


    Private Sub BindJobCodeNameComboBoxes222()
        Dim oRow As DataRow
        Exit Sub

        Me.cbxEmpJob1.SelectedIndex = -1
        Me.cbxEmpJob2.SelectedIndex = -1
        Me.cbxEmpJob3.SelectedIndex = -1
        Me.cbxEmpJob4.SelectedIndex = -1
        Me.cbxEmpJob5.SelectedIndex = -1
        Me.cbxEmpJob6.SelectedIndex = -1
        Me.cbxEmpJob7.SelectedIndex = -1

        If dsSetup.Tables("ActiveEmployee").Rows.Count = 0 Or EmployeeCurrencyMan.Position = -1 Then
            Exit Sub
        End If

        For Each oRow In dsSetup.Tables("JobCodes").Rows
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID1") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID1") Then
                    Me.cbxEmpJob1.SelectedItem = oRow("JobCodeName")
                End If
            End If
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID2") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID2") Then
                    Me.cbxEmpJob2.SelectedItem = oRow("JobCodeName")
                End If
            End If
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID3") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID3") Then
                    Me.cbxEmpJob3.SelectedItem = oRow("JobCodeName")
                End If
            End If
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID4") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID4") Then
                    Me.cbxEmpJob4.SelectedItem = oRow("JobCodeName")
                End If
            End If
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID5") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID5") Then
                    Me.cbxEmpJob5.SelectedItem = oRow("JobCodeName")
                End If
            End If

            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID6") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID6") Then
                    Me.cbxEmpJob6.SelectedItem = oRow("JobCodeName")
                End If
            End If
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID7") Is DBNull.Value Then
                If oRow("JobCodeID") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID7") Then
                    Me.cbxEmpJob7.SelectedItem = oRow("JobCodeName")
                End If
            End If
        Next

        Me.cbxEmpReportsTo.SelectedIndex = -1
        For Each oRow In dsSetup.Tables("ActiveEmployee").Rows
            If Not dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("ReportsTo") Is DBNull.Value Then
                If oRow("EmployeeNumber") = dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("ReportsTo") Then
                    Me.cbxEmpReportsTo.SelectedItem = (oRow("LastName") & ", " & oRow("FirstName"))
                End If
            End If
        Next


    End Sub

    Private Sub cbxEmpJob1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob1.SelectedIndexChanged
        If Me.cbxEmpJob1.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob1.Text = "** Delete Job Code **" Or Me.cbxEmpJob1.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName1") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID1") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate1") = 0 'DBNull.Value
            Me.cbxEmpJob1.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob1.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob1.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID1") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName1") = valueCatName

    End Sub

    Private Sub cbxEmpJob2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob2.SelectedIndexChanged
        If Me.cbxEmpJob2.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob2.Text = "** Delete Job Code **" Or Me.cbxEmpJob2.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName2") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID2") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate2") = 0 'DBNull.Value
            Me.cbxEmpJob2.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob2.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob2.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID2") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName2") = valueCatName

    End Sub

    Private Sub cbxEmpJob3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob3.SelectedIndexChanged
        If Me.cbxEmpJob3.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob3.Text = "** Delete Job Code **" Or Me.cbxEmpJob3.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName3") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID3") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate3") = 0 'DBNull.Value
            Me.cbxEmpJob3.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob3.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob3.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID3") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName3") = valueCatName

    End Sub

    Private Sub cbxEmpJob4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob4.SelectedIndexChanged
        If Me.cbxEmpJob4.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob4.Text = "** Delete Job Code **" Or Me.cbxEmpJob4.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName4") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID4") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate4") = 0 'DBNull.Value
            Me.cbxEmpJob4.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob4.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob4.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID4") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName4") = valueCatName

    End Sub

    Private Sub cbxEmpJob5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob5.SelectedIndexChanged
        If Me.cbxEmpJob5.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob5.Text = "** Delete Job Code **" Or Me.cbxEmpJob5.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName5") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID5") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate5") = 0 'DBNull.Value
            Me.cbxEmpJob5.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob5.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob5.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID5") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName5") = valueCatName

    End Sub

    Private Sub cbxEmpJob6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob6.SelectedIndexChanged
        If Me.cbxEmpJob6.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob6.Text = "** Delete Job Code **" Or Me.cbxEmpJob6.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName6") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID6") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate6") = 0 'DBNull.Value
            Me.cbxEmpJob6.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob6.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob6.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID6") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName6") = valueCatName

    End Sub

    Private Sub cbxEmpJob7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpJob7.SelectedIndexChanged
        If Me.cbxEmpJob7.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim valueCatName As String

        If Me.cbxEmpJob7.Text = "** Delete Job Code **" Or Me.cbxEmpJob7.Text = "" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName7") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID7") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobRate7") = 0 'DBNull.Value
            Me.cbxEmpJob7.SelectedIndex = -1
            Exit Sub
        Else

            valueCatID = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob7.SelectedIndex)("JobCodeID")
            valueCatName = dsSetup.Tables("JobCodes").Rows(Me.cbxEmpJob7.SelectedIndex)("JobCodeName")
        End If

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobCodeID7") = valueCatID
        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("JobName7") = valueCatName

    End Sub

    Private Sub cbxEmpReportsTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpReportsTo.SelectedIndexChanged
        If Me.cbxEmpReportsTo.SelectedIndex = -1 Then Exit Sub

        Dim valueCatID As Integer
        Dim index As Integer = 0
        Dim oRow As DataRow

        If Me.cbxEmpReportsTo.Text = "** Delete Supervisor **" Then
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("ReportsTo") = DBNull.Value
            dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("ReportsTo") = DBNull.Value
            Me.cbxEmpReportsTo.SelectedIndex = -1
            Exit Sub

        Else
            valueCatID = Me.cbxEmpReportsTo.SelectedIndex

            For Each oRow In dsSetup.Tables("ActiveEmployee").Rows
                If oRow("EmployeeMgmtAll") = True Or oRow("EmployeeMgmtLimited") = True Then
                    If valueCatID = index Then
                        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("ReportsTo") = valueCatID
                        Exit For
                    End If
                    index += 1
                End If
            Next
        End If

    End Sub

    Private Sub btnOPverrideClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOPverrideClose.Click
        Me.pnlOverrides.Visible = False

    End Sub

    Private Sub btnOverrides_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverrides.Click
        Me.pnlOverrides.Visible = True
        Me.pnlOverrides.BringToFront()

    End Sub

    Private Sub btnCreateJobCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateJobCode.Click

        If Me.txtNewJobCode.Text.Length = 0 Then
            MsgBox("Please Enter New Job Code Name.")
            Exit Sub
        End If

        Dim oRow As DataRow
        Dim existingJobCode As Boolean = False

        For Each oRow In dsSetup.Tables("JobCodes").Rows
            If String.Compare(oRow("JobCodeName"), Me.txtNewJobCode.Text, True) = 0 Then '(oRow("JobCodeName") = Me.txtNewJobCode.Text Then
                existingJobCode = True
                Exit For
            End If
        Next

        If existingJobCode = True Then
            MsgBox((Me.txtNewJobCode.Text) & " already exists")
            Exit Sub
        End If

        oRow = dsSetup.Tables("JobCodes").NewRow

        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation   'selectedLocation
        oRow("JobCodeName") = Me.txtNewJobCode.Text
        oRow("Manager") = Me.chkJobManager.Checked
        oRow("Cashier") = Me.chkJobCashier.Checked
        oRow("Bartender") = Me.chkJobBar.Checked
        oRow("Server") = Me.chkJobServer.Checked
        oRow("Hostess") = Me.chkJobHost.Checked
        oRow("PasswordReq") = Me.chkJobPassword.Checked
        oRow("ClockInReq") = Me.chkJobClock.Checked
        oRow("ReportTipsReq") = Me.chkJobReportTips.Checked
        oRow("ShareTipsReq") = Me.chkJobShareTips.Checked

        dsSetup.Tables("JobCodes").Rows.Add(oRow)

        Me.JobCodeCurrencyMan.Position = dsSetup.Tables("JobCodes").Rows.Count - 1
        Me.txtNewJobCode.Text = ""

    End Sub

    Private Sub UpdateJobCodeDatabase()
        If Not dsSetup.HasChanges Then Exit Sub

        Try
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlEmployeeJobCodes.Update(dsSetup, "JobCodes")
            sql.cn.Close()

            dsSetup.Tables("JobCodes").AcceptChanges()
        Catch ex As Exception
            CloseConnection()
        End Try

        Me.cbxJobCode.Invalidate()

        RePopulateJobCodeData()
        BindJobCodeNames()

    End Sub

    Private Sub tabEmpDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabEmpDetail.Leave

        If Me.EmployeeCurrencyMan.Position = 0 Then
            EmployeeCurrencyMan.Position += 1
            EmployeeCurrencyMan.Position -= 1
        Else
            EmployeeCurrencyMan.Position -= 1
            EmployeeCurrencyMan.Position += 1
        End If

        UpdateDatabaseEmployee()

    End Sub

    Private Sub TabJobCodeDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabJobCodeDetail.Leave

        If Me.JobCodeCurrencyMan.Position = 0 Then
            Me.JobCodeCurrencyMan.Position += 1
            Me.JobCodeCurrencyMan.Position -= 1
        Else
            Me.JobCodeCurrencyMan.Position -= 1
            Me.JobCodeCurrencyMan.Position += 1
        End If

        UpdateJobCodeDatabase()

    End Sub


    Private Sub btnJobCodeUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobCodeUpdate.Click

        If Me.JobCodeCurrencyMan.Position = 0 Then
            Me.JobCodeCurrencyMan.Position += 1
            Me.JobCodeCurrencyMan.Position -= 1
        Else
            Me.JobCodeCurrencyMan.Position -= 1
            Me.JobCodeCurrencyMan.Position += 1
        End If
        UpdateJobCodeDatabase()

        Exit Sub

        '   we don't need below because everything is bound

        If Me.JobCodeCurrencyMan.Position = -1 Then
            MsgBox("Please Select a Job Code.")
            Exit Sub
        End If

        Dim oRow As DataRow

        oRow = dsSetup.Tables("JobCodes").Rows(Me.JobCodeCurrencyMan.Position)

        oRow("CompanyID") = corpID
        oRow("LocationID") = corpPhysicalLocation   'selectedLocation
        oRow("JobCodeName") = Me.txtUpdateJobCode.Text
        oRow("Manager") = Me.chkJobManager.Checked
        oRow("Cashier") = Me.chkJobCashier.Checked
        oRow("Bartender") = Me.chkJobBar.Checked
        oRow("Server") = Me.chkJobServer.Checked
        oRow("Hostess") = Me.chkJobHost.Checked
        oRow("PasswordReq") = Me.chkJobPassword.Checked
        oRow("ClockInReq") = Me.chkJobClock.Checked
        oRow("ReportTipsReq") = Me.chkJobReportTips.Checked
        oRow("ShareTipsReq") = Me.chkJobShareTips.Checked

        RePopulateJobCodeData()

    End Sub

    Private Sub grdActiveEmployee_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdActiveEmployee.CurrentCellChanged

        If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("SwipeCode") Is DBNull.Value Then
            btnSwipeCode.Text = "Inactive Swipe Code"
        Else
            btnSwipeCode.Text = "Swipe Code"
        End If
       
    End Sub

    Private Sub CardJustSwiped(ByRef newPayment As Payment) Handles readSwipe.CardReadSuccessful

        dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("SwipeCode") = newPayment.SwipeCode
        btnSwipeCode.Text = "Swipe Code"

    End Sub

    Private Sub btnSwipeCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwipeCode.Click


        If dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("SwipeCode") Is DBNull.Value Then
            MsgBox("Swipe Card Now to Add Swipe Code")

        Else
            If MsgBox("Would you like to remove Swipe Code?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                dsSetup.Tables("ActiveEmployee").Rows(Me.EmployeeCurrencyMan.Position)("SwipeCode") = DBNull.Value
                btnSwipeCode.Text = "Inactive Swipe Code"
            Else
                MsgBox("Swipe Card Now to Replace Swipe Code")
            End If
        End If
        '   AddCardHandler()

    End Sub

    Friend Sub AddCardHandler()

        '999
        '  Exit Sub
        Try
            'because if Swipe is not connected this won't work
            tmrCardRead_DSB.Start()
            AddHandler tmrCardRead_DSB.Tick, AddressOf readSwipe.tmrCardRead_Tick

        Catch ex As Exception

        End Try

    End Sub

    Friend Sub RemoveCardHandler()
        '999
        'Exit Sub
        Try
            tmrCardRead_DSB.Stop()
            RemoveHandler tmrCardRead_DSB.Tick, AddressOf readSwipe.tmrCardRead_Tick

        Catch ex As Exception

        End Try


    End Sub
End Class
