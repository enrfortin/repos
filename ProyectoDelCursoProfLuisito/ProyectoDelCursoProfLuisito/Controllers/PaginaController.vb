Imports System.Web.Mvc

Namespace Controllers
    Public Class PaginaController
        Inherits Controller

        ' GET: Pagina
        Function Index() As ActionResult
            Return View()
        End Function


        Function listarpaginas() As JsonResult
            Dim db As New BDveterinariaDataContext
            Dim listado = From pagina In db.Pagina
                          Where pagina.BHABILITADO = 1
                          Select New With {
                              pagina.IIDPAGINA,
                              pagina.MENSAJE,
                              pagina.ACCION,
                              pagina.CONTROLADOR
            }

            Return New JsonResult With {.Data = listado,
            .JsonRequestBehavior = JsonRequestBehavior.AllowGet}

        End Function

        Function guardarDatos(oPagina As Pagina) As Int32
            Dim respuesta = 0
            Try
                Dim db As New BDveterinariaDataContext
                db.Pagina.InsertOnSubmit(oPagina)
                db.SubmitChanges()
                respuesta = 1

            Catch ex As Exception
                respuesta = 0
            End Try
            Return respuesta
        End Function


        Function eliminar(id As Int32)
            Dim rpt = 0

            Try
                Dim db As New BDveterinariaDataContext
                Dim registro = (From pag In db.Pagina
                                Where pag.IIDPAGINA = id
                                Select pag).First()
                registro.BHABILITADO = 0
                db.SubmitChanges()
                rpt = 1
            Catch ex As Exception
                rpt = 0
            End Try
            Return rpt
        End Function

    End Class
End Namespace