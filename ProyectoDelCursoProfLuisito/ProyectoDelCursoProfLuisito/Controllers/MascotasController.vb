Imports System.Web.Mvc

Namespace Controllers
    Public Class MascotasController
        Inherits Controller

        ' GET: Mascotas
        Function Index() As ActionResult
            Return View()
        End Function

        Function ListarMascoras As JsonResult

            Dim db As New BDveterinariaDataContext
            Dim listado = From mascotas In db.Mascota
                          Join sexo In db.Sexo
                              On mascotas.IIDSEXO Equals sexo.IIDSEXO
                          Join tipoMascota In db.TipoMascota
                              On mascotas.IIDTIPOMASCOTA Equals tipoMascota.IIDTIPOMASCOTA
                          Where mascotas.BHABILITADO = 1
                          Select New with {
                              mascotas.IIDMASCOTA,
                              mascotas.NOMBRE,
                              mascotas.ALTURA,
                              mascotas.ANCHO,
                              .NOMBRESEXO=sexo.NOMBRE,
                              .NOMBREMASCOTA=tipoMascota.NOMBRE                                  
            }

            Return New JsonResult With {.Data=listado , 
                .JsonRequestBehavior=JsonRequestBehavior.AllowGet              
            }
        End Function

        Function listarTipoMascotas() As JsonResult
               Dim db As New BDveterinariaDataContext
               Dim listado = From tipomascota In db.TipoMascota
                             Where tipomascota.BHABILITADO=1
                             Select New With {                                   
                                .Id = TipoMascota.IIDTIPOMASCOTA,
                                .Nombre = tipomascota.NOMBRE
                                 }

             Return New JsonResult With {.Data=listado , 
                .JsonRequestBehavior=JsonRequestBehavior.AllowGet              
            }

        End Function

        Function filtrarMascotaPorTipo(iidTipoMascota As Int32) As JsonResult
            Dim db As New BDveterinariaDataContext
            Dim listado = From mascotas In db.Mascota
                          Join sexo In db.Sexo
                              On mascotas.IIDSEXO Equals sexo.IIDSEXO
                          Join tipoMascota In db.TipoMascota
                              On mascotas.IIDTIPOMASCOTA Equals tipoMascota.IIDTIPOMASCOTA
                          Where mascotas.BHABILITADO = 1 And mascotas.IIDTIPOMASCOTA = iidTipoMascota
                          Select New With {
                              mascotas.IIDMASCOTA,
                              mascotas.NOMBRE,
                              mascotas.ALTURA,
                              mascotas.ANCHO,
                              .NOMBRESEXO = sexo.NOMBRE,
                              .NOMBREMASCOTA = tipoMascota.NOMBRE
            }

            Return New JsonResult With {.Data = listado,
                .JsonRequestBehavior = JsonRequestBehavior.AllowGet
            }
        End Function



    End Class
End Namespace