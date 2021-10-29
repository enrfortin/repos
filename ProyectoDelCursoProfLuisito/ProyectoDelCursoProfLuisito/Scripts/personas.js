listar();

function listar() {
    $.get("Personas/listarPersonas", function (data) {

        crearListado(data);
    })

}

$.get("Personas/ListarComboSexo", function (data) {

    crearCombo(data, "cbosexo");
})


function crearCombo(data, comboId) {
    var contenido = "";

    contenido += "<option value=''>--Seleccione</option>"
    for (var i = 0; i < data.length; i++) {
        contenido += "<option value='" + data[i].Id + "'>" + data[i].Nombre + "</option>"
    }
    document.getElementById(comboId).innerHTML = contenido;
}

function crearListado(data) {
    var contenido = "<table id='listado' class='table'>";
    contenido += `
        <thead>
        <tr>
        <td>ID PERSONAS</td>
        <td>NOMBRE COMPLETO</td>
        <td>TELEFONO</td>
        <td>CORREO</td>
        <td>FECHA DE NACIMIENTO</td>
        </tr>
        </thead> 
        `;
           
    contenido += "<tbody>";
    var fila;
    for (var i = 0; i < data.length; i++) {
        fila = data[i];
        contenido += `
            <tr>
            <td>${fila.IIDPERSONA}</td>
            <td>${fila.NOMBRECOMPLETO}</td>
            <td>${fila.TELEFONO}</td>
            <td>${fila.CORREO}</td>
            <td>${fila.NOMBREFECHA}</td>
            </tr>
            `;
        contenido += "</tbody>";

   }


    contenido += "</table>";
    document.getElementById("divPersonas").innerHTML = contenido;
    $('#listado').DataTable();

}

function BuscarSexoPorNombre() {
    var idSexo = document.getElementById("cbosexo").value;
     if (idSexo == "") {
            listar();
        } else {
            $.get("Personas/filtrarPersonaPorSexo/?iidsexo=" + idSexo, function (data) {


               crearListado(data);
                
            })
        }
    }
