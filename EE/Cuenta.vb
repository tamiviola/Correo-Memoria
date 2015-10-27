Public Class Cuenta

    Private vNombreUsuario As String
    Public Property NombreUsuario() As String
        Get
            Return vNombreUsuario
        End Get
        Set(ByVal value As String)
            vNombreUsuario = value
        End Set
    End Property

    Private vListaArchivos As New List(Of Archivo)
    Public Property ListaArchivos() As List(Of Archivo)
        Get
            Return vListaArchivos
        End Get
        Set(ByVal value As List(Of Archivo))
            vListaArchivos = value
        End Set
    End Property

    Public Function CalcularTamaño() As Double
        Dim tamaño As Double = 0
        For Each a As Archivo In Me.ListaArchivos
            tamaño = tamaño + a.CalcularTamaño()
        Next
        Return tamaño
    End Function
End Class
