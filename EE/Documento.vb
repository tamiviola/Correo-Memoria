Public Class Documento
    Inherits Adjunto

    Private vCantidadLetras As String
    Public Property CantidadLetras() As String
        Get
            Return vCantidadLetras
        End Get
        Set(ByVal value As String)
            vCantidadLetras = value
        End Set
    End Property

    Public Overrides Function CalcularTamaño() As Double
        Return vCantidadLetras
    End Function
End Class
