Public Class Carpeta
    Inherits Archivo

    Private vListaArchivos As New List(Of Archivo)
    Public Property ListaArchivos() As List(Of Archivo)
        Get
            Return vListaArchivos
        End Get
        Set(ByVal value As List(Of Archivo))
            vListaArchivos = value
        End Set
    End Property

    Public Overrides Function CalcularTamaño() As Double
        Dim tamaño As Double = 0
        For Each a As Archivo In Me.ListaArchivos
            tamaño = tamaño + a.CalcularTamaño()
        Next
        Return tamaño
    End Function

    Public Function CalcularCantidadCorreos() As Integer
        Dim tamaño As Integer = 0
        For Each a As Archivo In Me.ListaArchivos
            If a.GetType() = GetType(Carpeta) Then
                tamaño = tamaño + DirectCast(a, Carpeta).CalcularCantidadCorreos()
            Else
                tamaño = tamaño + 1
            End If
        Next
        Return tamaño
    End Function
End Class
