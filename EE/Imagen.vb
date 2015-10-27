Public Class Imagen
    Inherits Adjunto

    Private vAlto As Double
    Public Property Alto() As Double
        Get
            Return vAlto
        End Get
        Set(ByVal value As Double)
            vAlto = value
        End Set
    End Property

    Private vAncho As Double
    Public Property Ancho() As Double
        Get
            Return vAncho
        End Get
        Set(ByVal value As Double)
            vAncho = value
        End Set
    End Property

    Private vProfundidad As Double
    Public Property Profundidad() As Double
        Get
            Return vProfundidad
        End Get
        Set(ByVal value As Double)
            vProfundidad = value
        End Set
    End Property

    Public Overrides Function CalcularTamaño() As Double
        Return Me.Alto * Me.Ancho * Me.Profundidad
    End Function
End Class
