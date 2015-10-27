Public Class Correo
    Inherits Archivo

    Private vCuerpo As String
    Public Property Cuerpo() As String
        Get
            Return vCuerpo
        End Get
        Set(ByVal value As String)
            vCuerpo = value
        End Set
    End Property

    Private vListaAdjuntos As New List(Of Adjunto)
    Public Property ListaAdjuntos() As List(Of Adjunto)
        Get
            Return vListaAdjuntos
        End Get
        Set(ByVal value As List(Of Adjunto))
            vListaAdjuntos = value
        End Set
    End Property

    Public Overrides Function CalcularTamaño() As Double
        Dim tamaño As Double = Me.vCuerpo.Length
        For Each a As Adjunto In Me.ListaAdjuntos
            tamaño = tamaño + a.CalcularTamaño()
        Next
        Return tamaño
    End Function
End Class
