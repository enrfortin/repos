listarMascotas();

function listarMascotas() {
    $.get("Mascotas/ListarMascoras", function (data) {

        crearListado(["ID MASCOTA", "NOMBRE", "ALTURA", "ANCHO", "NOMBRE SEXO", "TIPO DE MASCOTA"], data
            , "DivMascota")

    })

}

function crearCombo(data, comboId) {
    var contenido = "";

    contenido += "<option value=''>--Seleccione</option>"
    for (var i = 0; i < data.length; i++) {
        contenido += "<option value='" + data[i].Id + "'>" + data[i].Nombre + "</option>"
    }
    document.getElementById(comboId).innerHTML = contenido;
}

$.get("Mascotas/listarTipoMascotas", function (data) {

    crearCombo(data, "cboTipoMascota");
})

function crearListado(cabeceras, data, DivId) {

    var contenido = "";
    contenido += "<table id='tabla' 'class='table'>";
    //las cabeceras
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i = 0; i < cabeceras.length; i++) {
        contenido += "<td>" + cabeceras[i] + "</td>"

    }

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

            contenido += "</tr>";

        }

        contenido += "</tbody>";
    }

    contenido += "</table>";
    document.getElementById(DivId).innerHTML = contenido;
    $('#tabla').DataTable();


    function crearCombo(data, comboId) {
        var contenido = "";

        contenido += "<option value=''>--Seleccione</option>"
        for (var i = 0; i < data.length; i++) {
            contenido += "<option value='" + data[i].Id + "'>" + data[i].Nombre + "</option>"
        }
        document.getElementById(comboId).innerHTML = contenido;
    }


}

function filtarMascoraPorTipo() {
    var idTipo = document.getElementById("cboTipoMascota").value;
    if (idTipo == "") {
        listarMascotas();

    }else {
        $.get("Mascotas/filtrarMascotaPorTipo/?iidTipoMascota=" + idTipo, function (data) {

            crearListado(["ID MASCOTA", "NOMBRE", "ALTURA", "ANCHO", "NOMBRE SEXO", "TIPO DE MASCOTA"], data
                , "DivMascota")
        })

    }

}