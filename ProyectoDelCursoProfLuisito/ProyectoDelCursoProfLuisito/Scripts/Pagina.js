listar();

function listar() {
    $.get("Pagina/listarpaginas", function (data) {
        crearListado(["ID Pagina","MENSAJE","ACCION","CONTROLADOR"], data, "DivPagina");
    })
}
function crearListado(cabeceras, data, DivId) {

    var contenido = "";
    contenido += "<table id='tabla' 'class='table'>";
    //las cabeceras
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i = 0; i < cabeceras.length; i++) {
        contenido += "<td>" + cabeceras[i] + "</td>"

    }
    contenido += "<td>Operaciones</td>";

    contenido += "</tr>";
    contenido += "</thead>";
    if (data.length > 0) {
        var propiedadesObjeto = Object.keys(data[0]);
        contenido += "<tbody>";
        var fila;
        for (var i = 0; i < data.length; i++) {
            fila = data[i];
            
            contenido += "<tr>";            
            for (var j = 0; j < propiedadesObjeto.length; j++) {
                var nombrePropiedad = propiedadesObjeto[j]
                contenido += "<td>" + fila[nombrePropiedad] + "</td>"

            }
            contenido += "<td>";
            contenido += "<button class=' btn btn-primary glyphicon glyphicon-edit'></button> ";
            contenido += "<button class=' btn btn-danger glyphicon glyphicon-trash' onclick='eliminar("+fila.IIDPAGINA+")'></button>";
            contenido += "</td>";

            contenido += "</tr>";

        }

        contenido += "</tbody>";
    }

    contenido += "</table>";
    document.getElementById(DivId).innerHTML = contenido;
    $('#tabla').DataTable();


}

function Guardar(){

    var idpagina = document.getElementById("txtIdPagina").value;
    var mensaje = document.getElementById("txtMensaje").value;
    var accion = document.getElementById("txtAccion").value;
    var controlador = document.getElementById("txtControlador").value;
    var frm = new FormData();
    frm.append("IIDPAGINA", idpagina);
    frm.append("MENSAJE", mensaje);
    frm.append("ACCION", accion);
    frm.append("CONTROLADOR", controlador);
    frm.append("BHABILITADO", 1);

    $.ajax({
        type: "POST",
        url: "Pagina/guardarDatos",
        contentType: false,
        processData: false,
        data: frm,
        success: function (data) {
            if(data == 0) {
                alert("Ocurrio un error");
            }else {
                alert("Se registro correctamente");
                listar();
                document.getElementById("btnCerrar").click();
        }
        }
    })
}

function eliminar(id) {
    $.get("Pagina/eliminar?id=" + id, function (rpt) {
        if (rpt == 0) {
            alert("Ocurrio un Error")
        } else {
            alert("Se elimino correctamente")
            listar();
        }

    })
}