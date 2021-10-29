@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.25/css/jquery.dataTables.css">
<h2>Medicamentos</h2>

<div style="margin-top:1em">
    <label>Ingrese el nombre del Medicamento</label>
    <input type="text" id="txtnombremedicamento" onkeyup="filtrarMedicamentos()"/>
</div>

<div id="DivMedicamento">

</div>

@Scripts.Render("~/bundles/jquery")
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.25/js/jquery.dataTables.js"></script>
<script src="~/Scripts/medicamento.js"></script>