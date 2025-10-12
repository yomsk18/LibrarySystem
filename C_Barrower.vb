Public Class C_Barrower
    Inherits C_User
    Private _user As C_User
    Private _barrowerId As Integer
    Public Property BarrowerId() As Integer
        Get
            Return _barrowerId
        End Get
        Set(value As Integer)
            _barrowerId = _user.UserID()
        End Set
    End Property
    Public Property TotalFines() As Decimal
    Public Property Contact() As String
End Class
