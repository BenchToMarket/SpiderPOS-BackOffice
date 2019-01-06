Module ControlConstants

    '   Public oExcel As New SkySof.Excel

    Public Const ssX As Double = 800
    Public Const ssY As Double = 600
    Friend wa As Rectangle = Screen.PrimaryScreen.WorkingArea
    '    Public Const ssX As Double = 800 * 0.8
    '    Public Const ssY As Double = 480 * 0.8

    Public Const orderPanelWidth As Double = ssX * 0.6
    Public Const orderPanelHeight As Double = ssY * 0.7
    Public Const viewOrderWidth As Double = ssX * 0.98
    Public Const viewOrderHeight As Double = ssY * 0.7

    '    Public Const entreeCategoryID As Integer = 3
    Public Const buttonSpace As Integer = 4
    Public Const totalPanelButtons As Integer = 15
    Public totalOrderLabelString As String = "Check Sub Total"

    Public c1 As Color = Color.PowderBlue
    Public c2 As Color = Color.AliceBlue
    Friend c3 As Color = Color.White

    Friend c6 As Color = Color.FromArgb(100, 149, 237)
    Friend c16 As Color = Color.FromArgb(59, 96, 141)  'Drinks 

    Public corpID As String '     = "001111"
    Public selectedLocation As String   ' = "000001"
    Public corpPhysicalLocation As String
    Public usingDefaults As Boolean '= True
    Public endOfWeek As DayOfWeek


End Module
