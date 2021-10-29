@Code
    ViewData("Title") = "Index"
End Code


<h2>Index</h2>

<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.25/css/jquery.dataTables.css">
<link href="~/Content/bootstrap.min.css" rel="stylesheet" />

<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
    Agregar
</button>


<div id="DivPagina">

</div>

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <div class="form-group">
                    <label>ID Pagina</label>
                    <input id="txtIdPagina" readonly class="form-control" />
                    <div class="form-group">
                        <label>Mensaje</label>
                        <input id="txtMensaje" class="form-control" />
                        <div class="form-group">
                            <label>Accion</label>
                            <input id="txtAccion" class="form-control" />
                            <div class="form-group">
                                <label>Controlador</label>
                                <input id="txtControlador" class="form-control" />
                            </div>
                        </div>
                    </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button id="btnCerrar" type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                    <button type="button" onclick="Guardar()" class="btn btn-primary">Guardar</button>
                </div>
            </div>
    </div>
</div>

@Scripts.Render("~/bundles/jquery")
<script src="~/Scripts/bootstrap.min.js"></script>
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.25/js/jquery.dataTables.js"></script>
<script src="~/Scripts/Pagina.js"></script>
