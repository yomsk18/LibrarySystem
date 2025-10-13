Public Class C_Transaction
    Public Property TransactionID() As Integer
    Public Property BarrowedDate() As Date
    Public Property DueDate() As Date
    Public Property ReturnedDate() As Date
    Public Property status() As String
    Public Property barrower As C_Barrower
    Public Property book As C_Book

End Class
