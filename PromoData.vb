Public Class PromoData
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        ReInitializeSQLConnection()

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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=VAIO;packet size=4096;integrated security=SSPI;data source=VAIO;pe" & _
        "rsist security info=False;initial catalog=Restaurant_Server"
        '
        'PromoData
        '
        Me.Name = "PromoData"

    End Sub

    Private Sub ReInitializeSQLConnection()
        Dim connectserver As String

        '       connectServer = "localhost"
        connectServer = "LABMAIN\labmain"
        '      connectServer = "vaio"
        '       connectServer = "Phoenix"
        If System.Windows.Forms.SystemInformation.ComputerName = "VAIO" Then
            connectServer = "vaio"
        End If
        '
        'SqlConnection1
        '

        Me.SqlConnection1.ConnectionString = "packet size=4096;integrated security=SSPI;data source='" & connectserver & "';pe" & _
   "rsist security info=False;initial catalog=Restaurant_Server"

    End Sub

#End Region

  
    
End Class
