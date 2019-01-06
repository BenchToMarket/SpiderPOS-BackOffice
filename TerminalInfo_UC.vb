Imports DataSet_Builder

Public Class TerminalInfo_UC
    Inherits System.Windows.Forms.UserControl

    Dim _isNewTerminal As Boolean
    Dim _changesMade As Boolean
    Dim _newIndex As Integer
    Dim StandardOrdering As Boolean = True

    Dim _currentTerminal As Terminal
    Friend dvUseOrder As DataView
    Friend priority1 As Boolean = False
    Friend priority2 As Boolean = False
    Friend priority3 As Boolean = False


    Friend Property IsNewTerminal() As Boolean
        Get
            Return _isNewTerminal
        End Get
        Set(ByVal Value As Boolean)
            _isNewTerminal = Value
        End Set
    End Property

    Friend Property CurrentTerminal() As Terminal
        Get
            Return _currentTerminal
        End Get
        Set(ByVal Value As Terminal)
            _currentTerminal = Value
        End Set
    End Property

    Event NewTerminalAccepted()
    Event UpdateOldTerminal()
    Event TerminalCancel()
    Event NewUseOrderRow(ByVal useOrder As Integer, ByVal newUse As String)

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal isNT As Boolean, ByVal tempTerminal As Terminal)
        MyBase.New()

        _isNewTerminal = isNT
        _currentTerminal = tempTerminal

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
    Friend WithEvents btnNewTerminalAccepted As System.Windows.Forms.Button
    Friend WithEvents lblTermNum As System.Windows.Forms.Label
    Friend WithEvents txtTermName As System.Windows.Forms.TextBox
    Friend WithEvents cbxTermMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTermGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnStdOrdering As System.Windows.Forms.Button
    Friend WithEvents cbxPriority1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPriority2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPriority3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlPriority As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnNewTerminalAccepted = New System.Windows.Forms.Button
        Me.lblTermNum = New System.Windows.Forms.Label
        Me.txtTermName = New System.Windows.Forms.TextBox
        Me.cbxTermMethod = New System.Windows.Forms.ComboBox
        Me.cbxTermGroup = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.btnStdOrdering = New System.Windows.Forms.Button
        Me.cbxPriority1 = New System.Windows.Forms.ComboBox
        Me.cbxPriority2 = New System.Windows.Forms.ComboBox
        Me.cbxPriority3 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlPriority = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnlPriority.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewTerminalAccepted
        '
        Me.btnNewTerminalAccepted.Location = New System.Drawing.Point(24, 288)
        Me.btnNewTerminalAccepted.Name = "btnNewTerminalAccepted"
        Me.btnNewTerminalAccepted.Size = New System.Drawing.Size(88, 40)
        Me.btnNewTerminalAccepted.TabIndex = 0
        Me.btnNewTerminalAccepted.TabStop = False
        Me.btnNewTerminalAccepted.Text = "Create New"
        '
        'lblTermNum
        '
        Me.lblTermNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermNum.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTermNum.Location = New System.Drawing.Point(16, 16)
        Me.lblTermNum.Name = "lblTermNum"
        Me.lblTermNum.Size = New System.Drawing.Size(216, 24)
        Me.lblTermNum.TabIndex = 1
        Me.lblTermNum.Text = "Terminal #   "
        Me.lblTermNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTermName
        '
        Me.txtTermName.Location = New System.Drawing.Point(56, 64)
        Me.txtTermName.Name = "txtTermName"
        Me.txtTermName.Size = New System.Drawing.Size(176, 20)
        Me.txtTermName.TabIndex = 0
        Me.txtTermName.Text = ""
        '
        'cbxTermMethod
        '
        Me.cbxTermMethod.Location = New System.Drawing.Point(56, 96)
        Me.cbxTermMethod.Name = "cbxTermMethod"
        Me.cbxTermMethod.Size = New System.Drawing.Size(176, 21)
        Me.cbxTermMethod.TabIndex = 1
        '
        'cbxTermGroup
        '
        Me.cbxTermGroup.Location = New System.Drawing.Point(56, 128)
        Me.cbxTermGroup.Name = "cbxTermGroup"
        Me.cbxTermGroup.Size = New System.Drawing.Size(176, 21)
        Me.cbxTermGroup.TabIndex = 2
        Me.cbxTermGroup.Text = "No Terminal Group"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name (case sensitive)"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(136, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Close"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnStdOrdering
        '
        Me.btnStdOrdering.Location = New System.Drawing.Point(16, 160)
        Me.btnStdOrdering.Name = "btnStdOrdering"
        Me.btnStdOrdering.Size = New System.Drawing.Size(136, 24)
        Me.btnStdOrdering.TabIndex = 7
        Me.btnStdOrdering.Text = "Standard Ordering"
        '
        'cbxPriority1
        '
        Me.cbxPriority1.Items.AddRange(New Object() {"None", "Dine In", "Take Out", "Delivery"})
        Me.cbxPriority1.Location = New System.Drawing.Point(104, 8)
        Me.cbxPriority1.Name = "cbxPriority1"
        Me.cbxPriority1.Size = New System.Drawing.Size(121, 21)
        Me.cbxPriority1.TabIndex = 8
        Me.cbxPriority1.Text = "None"
        '
        'cbxPriority2
        '
        Me.cbxPriority2.Items.AddRange(New Object() {"None", "Dine In", "Take Out", "Delivery"})
        Me.cbxPriority2.Location = New System.Drawing.Point(104, 40)
        Me.cbxPriority2.Name = "cbxPriority2"
        Me.cbxPriority2.Size = New System.Drawing.Size(121, 21)
        Me.cbxPriority2.TabIndex = 9
        Me.cbxPriority2.Text = "None"
        '
        'cbxPriority3
        '
        Me.cbxPriority3.Items.AddRange(New Object() {"None", "Dine In", "Take Out", "Delivery"})
        Me.cbxPriority3.Location = New System.Drawing.Point(104, 72)
        Me.cbxPriority3.Name = "cbxPriority3"
        Me.cbxPriority3.Size = New System.Drawing.Size(121, 21)
        Me.cbxPriority3.TabIndex = 10
        Me.cbxPriority3.Text = "None"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Priority 1"
        '
        'pnlPriority
        '
        Me.pnlPriority.Controls.Add(Me.Label4)
        Me.pnlPriority.Controls.Add(Me.Label3)
        Me.pnlPriority.Controls.Add(Me.Label2)
        Me.pnlPriority.Controls.Add(Me.cbxPriority3)
        Me.pnlPriority.Controls.Add(Me.cbxPriority2)
        Me.pnlPriority.Controls.Add(Me.cbxPriority1)
        Me.pnlPriority.Location = New System.Drawing.Point(8, 184)
        Me.pnlPriority.Name = "pnlPriority"
        Me.pnlPriority.Size = New System.Drawing.Size(232, 96)
        Me.pnlPriority.TabIndex = 12
        Me.pnlPriority.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Priority 3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Priority 2"
        '
        'TerminalInfo_UC
        '
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.pnlPriority)
        Me.Controls.Add(Me.btnStdOrdering)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxTermGroup)
        Me.Controls.Add(Me.cbxTermMethod)
        Me.Controls.Add(Me.txtTermName)
        Me.Controls.Add(Me.lblTermNum)
        Me.Controls.Add(Me.btnNewTerminalAccepted)
        Me.Name = "TerminalInfo_UC"
        Me.Size = New System.Drawing.Size(248, 344)
        Me.pnlPriority.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitializeOther()

        If Me.IsNewTerminal = False Then
            Me.btnNewTerminalAccepted.Text = "Update"
        End If

        BindData()

    End Sub

    Private Sub BindData()

        Dim oRow As DataRow

        Me.cbxTermMethod.Items.Add("Table")
        Me.cbxTermMethod.Items.Add("Bar")
        Me.cbxTermMethod.Items.Add("Quick")

        Me.cbxTermGroup.Items.Add("No Terminal Group")
        For Each oRow In dsSetup.Tables("TermGroups").Rows
            Me.cbxTermGroup.Items.Add(oRow("TerminalsGroupName"))
        Next

        Me.lblTermNum.Text = "Terminal #  " & CurrentTerminal.TermID
        Me.txtTermName.Text = CurrentTerminal.TermName
        Me.cbxTermMethod.SelectedText = CurrentTerminal.TermMethod
        If CurrentTerminal.TermGroupID = 0 Then
            Me.cbxTermGroup.Text = "No Terminal Group"
        Else
            Me.cbxTermGroup.Text = CurrentTerminal.TermGroupName
        End If

        dvUseOrder = New DataView
        If Me.IsNewTerminal = False Then
            With dvUseOrder
                .Table = dsSetup.Tables("TerminalsUseOrder")
                .RowFilter = "TerminalsPrimaryKey = " & CurrentTerminal.TermPrimaryKey
                .RowStateFilter = DataViewRowState.CurrentRows
                .Sort = "UsePriority ASC"
            End With

            Dim vRow As DataRowView

            For Each vRow In dvUseOrder
                Me.pnlPriority.Visible = True
                Me.btnStdOrdering.Text = "Priority Ordering"
                Me.StandardOrdering = False
                Select Case vRow("UsePriority")
                    Case 1
                        priority1 = True    'this only says there is a row
                        If vRow("Active") = True Then
                            Me.cbxPriority1.Text = vRow("MethodUse")
                        End If
                    Case 2
                        priority2 = True
                        If vRow("Active") = True Then
                            Me.cbxPriority2.Text = vRow("MethodUse")
                        End If
                    Case 3
                        priority3 = True
                        If vRow("Active") = True Then
                            Me.cbxPriority3.Text = vRow("MethodUse")
                        End If
                End Select
            Next
        End If

    End Sub

    Private Sub cbxTermMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTermMethod.SelectedIndexChanged

        Me.CurrentTerminal.TermMethod = Me.cbxTermMethod.SelectedItem

    End Sub

    Private Sub cbxTermGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTermGroup.SelectedIndexChanged
        Dim oRow As DataRow

        If Me.cbxTermGroup.SelectedItem = "No Terminal Group" Then
            Me.CurrentTerminal.TermGroupID = 0
        Else
            For Each oRow In dsSetup.Tables("TermGroups").Rows
                If Me.cbxTermGroup.SelectedItem = oRow("TerminalsGroupName") Then
                    Me.CurrentTerminal.TermGroupID = oRow("TerminalsGroupID")
                End If
            Next
        End If

    End Sub

    Private Sub txtTermName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTermName.Validating
        ValidateNumeric(Me.txtTermName)
    End Sub

    Private Sub ValidateNumeric(ByRef txtValNumeric As TextBox)

        If txtValNumeric.Text = "" Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This TextBox can not be Blank.")
            txtValNumeric.Focus()
            Beep()
        ElseIf Not TypeName(txtValNumeric.Text) = "String" Then
            Me.ErrorProvider1.SetError(txtValNumeric, "This must be a String value.")
            txtValNumeric.Focus()
            Beep()
        Else
            '   cancels the error
            Me.ErrorProvider1.Dispose()
        End If

    End Sub

    Private Sub btnNewTerminalAccepted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTerminalAccepted.Click

        If ErrorProvider1.GetError(Me.txtTermName).Length = 0 Then
            Dim vRow As DataRowView
            '       Dim vCount As Integer = 1
            '       CurrentTerminal.TermName = Me.txtTermName.Text
            If Me.StandardOrdering = True Then
                If dvUseOrder.Count > 0 Then
                    For Each vRow In dvUseOrder
                        vRow("Active") = 0
                    Next
                End If
            End If
           
            If IsNewTerminal = True Then
               RaiseEvent NewTerminalAccepted()
                Me.Dispose()
            Else
                RaiseEvent UpdateOldTerminal()
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        RaiseEvent TerminalCancel()

    End Sub

    Private Sub btnStdOrdering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStdOrdering.Click
        If Me.StandardOrdering = True Then
            'switching to Priority Ordering
            Me.pnlPriority.Visible = True
            Me.StandardOrdering = False
            Me.btnStdOrdering.Text = "Priority Ordering"
        Else
            Me.pnlPriority.Visible = False
            Me.StandardOrdering = True
            Me.btnStdOrdering.Text = "Standard Ordering"
        End If

    End Sub

    Private Sub cbxPriority1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPriority1.SelectedIndexChanged
        If priority1 = False And Not cbxPriority1.SelectedItem = "None" Then
            'this means we need to add a new row to TerminalsUseOrder
            If IsNewTerminal = True Then
                Me.CurrentTerminal.TermName = Me.txtTermName.Text
                RaiseEvent NewTerminalAccepted()
                IsNewTerminal = False
            End If

            RaiseEvent NewUseOrderRow(1, cbxPriority1.SelectedItem)
            priority1 = True
        ElseIf priority1 = True Then
            ChangeUseOrderData(1, cbxPriority1.SelectedItem)
        End If
    End Sub

    Private Sub cbxPriority2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPriority2.SelectedIndexChanged
        If priority2 = False And Not cbxPriority2.SelectedItem = "None" Then
            'this means we need to add a new row to TerminalsUseOrder
            If IsNewTerminal = True Then
                Me.CurrentTerminal.TermName = Me.txtTermName.Text
                RaiseEvent NewTerminalAccepted()
                IsNewTerminal = False
            End If
            RaiseEvent NewUseOrderRow(2, cbxPriority1.SelectedItem)
            priority2 = True
        ElseIf priority2 = True Then
            ChangeUseOrderData(2, cbxPriority2.SelectedItem)
        End If
    End Sub

    Private Sub cbxPriority3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPriority3.SelectedIndexChanged
        If priority3 = False And Not cbxPriority3.SelectedItem = "None" Then
            'this means we need to add a new row to TerminalsUseOrder
            If IsNewTerminal = True Then
                Me.CurrentTerminal.TermName = Me.txtTermName.Text
                RaiseEvent NewTerminalAccepted()
                IsNewTerminal = False
            End If
            RaiseEvent NewUseOrderRow(3, cbxPriority1.SelectedItem)
            priority3 = True
        ElseIf priority3 = True Then
            ChangeUseOrderData(3, cbxPriority3.SelectedItem)
        End If
    End Sub

    Private Sub ChangeUseOrderData(ByVal useOrder As Integer, ByVal newUse As String)
        Dim vRow As DataRowView

        For Each vRow In dvUseOrder
            If vRow("UsePriority") = useOrder Then
                If Not newUse = "None" Then
                    vRow("MethodUse") = newUse
                    vRow("Active") = 1
                Else
                    vRow("MethodUse") = newUse
                    vRow("Active") = 0
                End If
            End If
        Next
    End Sub
End Class
