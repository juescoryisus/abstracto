Public Class Abstracta2
    Inherits abstracta1

    Public Numero1 As Integer
    Public Numero2 As Integer

    Public Overrides Function Multiplicar() As Object
        Return Numero1 * Numero2
    End Function

    Public Overrides Function Sumar() As Object
        Return Numero1 + Numero2
    End Function

End Class
