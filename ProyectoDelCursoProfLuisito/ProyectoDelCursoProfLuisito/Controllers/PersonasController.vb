Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonasController
        Inherits Controller

        ' GET: Personas
        Function Index() As ActionResult
            Return View()
        End Function

        Function listarPersonas As JsonResult
            Dim db As New BDveterinariaDataContext
            Dim listadoPersonas = From personas In db.Persona
                                  Where personas.BHABILITADO=1
                                  Select New With {
                                    personas.IIDPERSONA,
                                    .NOMBRECOMPLETO = personas.NOMBRE+ " " + personas.APPATERNO+ " " + personas.APMATERNO,
                                    personas.TELEFONO,
                                    personas.CORREO,  
                                    .NOMBREFECHA=Personas.FECHANACIMIENTO.Value.ToShortDateString()                                                              
                                    }

            Return New JsonResult With {.Data = listadoPersonas,
                .JsonRequestBehavior= JsonRequestBehavior.AllowGet}
                
        End Function

        Function ListarComboSexo As JsonResult
            Dim db As New BDveterinariaDataContext 
            Dim listado= From sexo In db.Sexo
                         Where Sexo.BHABILITADO = 1
                         Select New With {
                             .Id=sexo.IIDSEXO,
                             .Nombre = sexo.NOMBRE
                                         }

             Return New JsonResult With {.Data = listado,
                .JsonRequestBehavior= JsonRequestBehavior.AllowGet}
        End Function

        Function filtrarPersonaPorSexo(iidsexo As Int32)
            Dim db As New BDveterinariaDataContext
            Dim listadoPersonas = From personas In db.Persona
                                  Where personas.BHABILITADO = 1 And personas.IIDSEXO = iidsexo
                                  Select New With {
                                    personas.IIDPERSONA,
                                    .NOMBRECOMPLETO = personas.NOMBRE + " " + personas.APPATERNO + " " + personas.APMATERNO,
                                    personas.TELEFONO,
                                    personas.CORREO,
                                    .NOMBREFECHA = personas.FECHANACIMIENTO.Value.ToShortDateString()
                                    }

            Return New JsonResult With {.Data = listadoPersonas,
                .JsonRequestBehavior = JsonRequestBehavior.AllowGet}
        End Function

    End Class
End Namespace