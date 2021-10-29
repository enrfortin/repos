$.get("Medicamentos/ListarMedicamentos", function(data) {
    crearListado(["ID MEDICAMENTO", "NOMBRE", "CONCENTRACION", "PRECIO", "STOCK"], data, "DivMedicamento");
    
})

function crearListado(cabeceras, data, DivId) {

    var contenido = "";
    contenido += "<table id='tabla' 'class='table'>";
    //las cabeceras
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i=0; i< cabeceras.length; i++){
        contenido+= "<td>"+cabeceras[i]+"</td>"

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


}

function filtrarMedicamentos() {
    var nombreMedicamento = document.getElementById("txtnombremedicamento").value;
    
    $.get("Medicamentos/filtrarMedicamentos/?nombreMedicamento=" + nombreMedicamento, function (data) {
        crearListado(["ID MEDICAMENTO", "NOMBRE", "CONCENTRACION", "PRECIO", "STOCK"], data, "DivMedicamento");
    })
}
