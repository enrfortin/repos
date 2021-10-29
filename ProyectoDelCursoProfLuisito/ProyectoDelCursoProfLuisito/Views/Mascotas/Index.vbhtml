@Code
    ViewData("Title") = "Index"
End Code

<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.25/css/jquery.dataTables.css">

<div style="display:grid; grid-template-columns: 180px 180px; margin-top:1em">
    <label>Ingrese Tipo Mascota</label>
    <select id="cboTipoMascota" onchange="filtarMascoraPorTipo()" class="form-control"></select>
</div>
<div id="DivMascota">

</div>

@Scripts.Render("~/bundles/jquery")
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.25/js/jquery.dataTables.js"></script>
<script src="~/Scripts/Mascota.js"></script>

