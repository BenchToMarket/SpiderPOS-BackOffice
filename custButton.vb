Public Class custButton

    Inherits Button

    Private _backcolor As Color
    Private _xlocation As Integer
    Private _ylocation As Integer
    Private _custNumber As Integer
    Private _text As String

    Private bStyle As BorderStyle = BorderStyle.FixedSingle

    Sub New(ByVal cn As Integer)
        _custNumber = cn
        _text = cn.ToString

        Width = 15
        Height = 15


        _xlocation = (cn * Width) - Width
        _ylocation = 0
        Location = New Point(_xlocation, _ylocation)

        If cn = 11 Then Width = 30 '****  just temporary

    End Sub

    Public Property custNumber() As Integer
        Get
            Return _custNumber
        End Get
        Set(ByVal Value As Integer)
            _custNumber = Value
        End Set
    End Property


    Public Property BorderStyle() As BorderStyle
        Get
            Return bStyle
        End Get
        Set(ByVal Value As BorderStyle)
            bStyle = Value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal Value As String)
            _text = Value
        End Set
    End Property



End Class
