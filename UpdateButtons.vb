Public Class UpdateButtons222
    Inherits System.Windows.Forms.UserControl

    Private _activeButton As Integer
    Private _activeText As String
    Private _activeAbrevText As String
    Private _activeFunction As Integer


    Public Property ActiveButton() As Integer
        Get
            Return _activeButton
        End Get
        Set(ByVal Value As Integer)
            _activeButton = Value
        End Set
    End Property

    Public Property ActiveText() As String
        Get
            Return _activeText
        End Get
        Set(ByVal Value As String)
            _activeText = Value
        End Set
    End Property

    Public Property ActiveAbrevText() As String
        Get
            Return _activeAbrevText
        End Get
        Set(ByVal Value As String)
            _activeAbrevText = Value
        End Set
    End Property

    Public Property ActiveFunction() As Integer
        Get
            Return _activeFunction
        End Get
        Set(ByVal Value As Integer)
            _activeFunction = Value
        End Set
    End Property


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnUpdate.Location = New System.Drawing.Point(16, 8)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 32)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnRemove.Location = New System.Drawing.Point(16, 56)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(160, 32)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        '
        'UpdateButtons
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "UpdateButtons"
        Me.Size = New System.Drawing.Size(192, 96)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnUpdate_Click222(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        '      Dim sm As SetupMenu

        If _activeButton = 0 Then MsgBox("You must first select a Button to update")
        If _activeFunction = 0 Then MsgBox("You must select a Function")

        Dim adt As New SqlClient.SqlDataAdapter("SELECT CategoryID, CategoryName, CategoryAbrev, CategoryOrder, FunctionID From Category", sql.cn)
        Dim cbd As New SqlClient.SqlCommandBuilder(adt)
        Dim oRow As DataRow

        '   if test is successful then row is update then sub exited
        '   if failed then new row is created
        For Each oRow In dsSetup.Tables("MainCategory").Rows
            If oRow("CategoryID") = _activeButton Then

                oRow("CategoryName") = _activeText
                oRow("CategoryAbrev") = _activeAbrevText
                oRow("FunctionID") = _activeFunction

                sql.cn.Open()
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
                adt.Update(dsSetup, "MainCategory")
                sql.cn.Close()
                '        SetupMenu.DisplayMainCategoryPanel()

                Exit Sub
            End If
        Next

        oRow = dsSetup.Tables("MainCategory").NewRow

        oRow("CategoryName") = _activeText
        oRow("CategoryAbrev") = _activeAbrevText
        oRow("FunctionID") = _activeFunction

        dsSetup.Tables("MainCategory").Rows.Add(oRow)

        sql.cn.Open()
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        adt.Update(dsSetup, "MainCategory")
        sql.cn.Close()

    End Sub

End Class
