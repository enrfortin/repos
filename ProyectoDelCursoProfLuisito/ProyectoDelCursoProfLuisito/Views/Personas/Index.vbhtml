@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.25/css/jquery.dataTables.css">


<div style="display:grid; grid-template-columns: 150px 300px 150px">

    <label>Seleccione Sexo</label>
    <select id="cbosexo" class="form-control"></select>
    <button id="btn-buscar" onclick="BuscarSexoPorNombre()" class="btn btn-primary">Buscar</button>
</div>

<div id="divPersonas">

</div>
@Scripts.Render("~/bundles/jquery")
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.25/js/jquery.dataTables.js"></script>
<script src="~/Scripts/personas.js"></script>