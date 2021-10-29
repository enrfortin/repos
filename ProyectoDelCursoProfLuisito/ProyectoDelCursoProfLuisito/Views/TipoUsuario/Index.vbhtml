@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.25/css/jquery.dataTables.css">
<link href="~/Content/bootstrap.css" rel="stylesheet" />


<h2>Index</h2>

<div style="margin-top:10px">
    <label>Ingrese el nombre del tipo usuario</label>
    <input type="text" id="txtnombreTipoUsu" />
    <button class="btn btn-primary" onclick="BuscarTipoUsuario()">Buscar</button>

</div>

<!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
    Agregar
</button>
<div id="divTipoUsuario">

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
                    <label>ID Tipo Usuario</label>
                    <input type="text" readonly id="txtIDTipoUsuario" class="form-control" />
                    <div class="form-group">
                        <label>Nombre Tipo Usuario</label>
                        <input type="text" id="txtNombreTipoUsuario" class="form-control" />
                        <div class="form-group">
                            <label>Descripcion Tipo Usuario</label>
                            <input type="text" id="txtDescripcionTipoUsuario" class="form-control" />
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
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.25/js/jquery.dataTables.js"></script>
<script src="~/Scripts/TipoUsuario.js"></script>
<script src="~/Scripts/bootstrap.js"></script>
