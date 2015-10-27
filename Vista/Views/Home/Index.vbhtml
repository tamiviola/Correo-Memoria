@modeltype EE.Cuenta

<h2>Nombre de la cuenta: @Model.NombreUsuario</h2>
<h2>Tamaño de la cuenta = @Model.CalcularTamaño()</h2>

@Html.Partial("Archivos", Model.ListaArchivos)
