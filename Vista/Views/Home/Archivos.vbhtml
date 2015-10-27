@modeltype IEnumerable(Of EE.Archivo)

<h2>Archivos</h2>

@code
    @<ul>
        @For Each a As EE.Archivo In Model
            @<li>
                Nombre: @a.Nombre
                <br />
                Tamaño: @a.CalcularTamaño()
                <br />
                @If a.GetType() = GetType(EE.Carpeta) Then
                    @:Cantidad de correos = @DirectCast(a, EE.Carpeta).CalcularCantidadCorreos()
                    @Html.Partial("Archivos", DirectCast(a, EE.Carpeta).ListaArchivos)
                End If
            </li>
        Next
    </ul>
End Code


