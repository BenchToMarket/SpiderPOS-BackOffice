Public Class CustomCheckBox
    Inherits CheckBox


    Private _id As Integer

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

End Class
