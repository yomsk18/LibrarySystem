Public Class C_Barrower
    Inherits C_User
    Public ReadOnly Property BarrowerId() As Integer
        Get
            Return Me.UserID
        End Get
    End Property
    Public Property TotalFines() As Decimal
    Public Property Contact() As String
End Class
