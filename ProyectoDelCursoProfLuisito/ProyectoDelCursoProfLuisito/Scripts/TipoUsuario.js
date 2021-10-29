listar();
function listar() {

    $.get("TipoUsuario/ListarTipoUsuario", function (data) {

        crearListado(data);
    })
}

function crearListado(data) {

    var contenido = "";
    contenido += "<table id='tabla' 'class='table'>";
    //las cabeceras
    contenido += "<thead>";
    contenido += "<tr>";
    contenido += "<td>ID Tipo Usuario </td>";
    contenido += "<td>Nombre tipo Usuario </td>";
    contenido += "<td>Descripcion </td>";
    contenido += "<td>Operaciones </td>";
    contenido += "</tr>";
    contenido += "</thead>";

    contenido += "<tbody>";
    var fila;
    for (var i = 0; i < data.length; i++) {
        fila = data[i];
        contenido += "<tr>";
        contenido += "<td>" + fila.IIDTIPOUSUARIO + "</td>";
        contenido += "<td>" + fila.NOMBRE + "</td>";
        contenido += "<td>" + fila.DESCRIPCION + "</td>";
        contenido += `
                     <td>
                        <button data-toggle="modal" data-target="#exampleModal" class=' btn btn-primary glyphicon glyphicon-edit '></button>
                        <button onclick='eliminar(${fila.IIDTIPOUSUARIO})' class=' btn btn-danger glyphicon glyphicon-trash '></button>
                     </td>
                    `
                      
        contenido += "</tr>";

    }

    contenido += "</tbody>";

    
    contenido += "</table>";
    document.getElementById("divTipoUsuario").innerHTML = contenido;
    $('#tabla').DataTable({
    searching:false
    });


}

function BuscarTipoUsuario() {
    var nombreTipoUsu = document.getElementById("txtnombreTipoUsu").value;
    alert(nombreTipoUsu);
    $.get("TipoUsuario/FiltrarTipoUsuario/?NombreTipoUsuario=" + nombreTipoUsu, function (data) {
        crearListado(data);
    })

}

function Guardar() {
    var idTipo = document.getElementById("txtIDTipoUsuario").value;
    var NombreTipo = document.getElementById("txtNombreTipoUsuario").value;
    var DescripcionTipo = document.getElementById("txtDescripcionTipoUsuario").value;

    var frm = new FormData();
    frm.append("IIDTIPOUSUARIO", idTipo);
    frm.append("NOMBRE", NombreTipo);
    frm.append("DESCRIPCION", DescripcionTipo);
    frm.append("BHABILITADO", 1);

    $.ajax({
        type: "POST",
        url: "TipoUsuario/InsertarTipoUsuario",
        contentType: false,
        processData: false,
        data: frm,
        success: function (data) {
            if (data == 0) {
                alert("Ocurrio un error");
            } else {
                alert("Se registro correctamente");
                listar();
                document.getElementById("btnCerrar").click();
            }
        }
    })


}

function eliminar(id) {
    alert (id);
}