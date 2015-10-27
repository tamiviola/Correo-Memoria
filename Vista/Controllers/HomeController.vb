Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult
        Dim cuenta As New EE.Cuenta
        cuenta.NombreUsuario = "tamiviola@gmail.com"

        Dim correo As New EE.Correo
        correo.Nombre = "Consulta"
        correo.Cuerpo = "Parcial TFI"

        Dim documento As New EE.Documento
        documento.CantidadLetras = 200
        correo.ListaAdjuntos.Add(documento)

        Dim imagen As New EE.Imagen
        imagen.Alto = 20
        imagen.Ancho = 20
        imagen.Profundidad = 20
        correo.ListaAdjuntos.Add(imagen)

        Dim carpeta As New EE.Carpeta
        carpeta.Nombre = "Contenedora"
        carpeta.ListaArchivos.Add(correo)

        cuenta.ListaArchivos.Add(carpeta)

        Return View(cuenta)
    End Function


End Class