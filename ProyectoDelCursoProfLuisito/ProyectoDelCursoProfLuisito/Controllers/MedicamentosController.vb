Imports System.Web.Mvc

Namespace Controllers
    Public Class MedicamentosController
        Inherits Controller

        ' GET: Medicamentos
        Function Index() As ActionResult
            Return View()
        End Function

        Function ListarMedicamentos As JsonResult
            Dim db As New BDveterinariaDataContext
            Dim listado = From medicamento In db.Medicamento
                          Where medicamento.BHABILITADO = 1
                          Select New With {
                                medicamento.IIDMEDICAMENTO,
                                medicamento.NOMBRE,
                                medicamento.CONCENTRACION,
                                medicamento.PRECIO,
                                medicamento.STOCK
            }
                          Return New JsonResult With {.Data= listado,
                          .JsonRequestBehavior = JsonRequestBehavior.AllowGet}

        End Function
        Function filtrarMedicamentos(nombreMedicamento As string) As JsonResult 
              Dim db As New BDveterinariaDataContext
              Dim listado
            If nombreMedicamento = "" Then
                  listado = From medicamento In db.Medicamento
                          Where medicamento.BHABILITADO = 1
                          Select New With {
                                medicamento.IIDMEDICAMENTO,
                                medicamento.NOMBRE,
                                medicamento.CONCENTRACION,
                                medicamento.PRECIO,
                                medicamento.STOCK
            }

                Else              
                   listado = From medicamento In db.Medicamento
                          Where medicamento.BHABILITADO = 1 And medicamento.NOMBRE.Contains(nombreMedicamento)
                          Select New With {
                                medicamento.IIDMEDICAMENTO,
                                medicamento.NOMBRE,
                                medicamento.CONCENTRACION,
                                medicamento.PRECIO,
                                medicamento.STOCK
            }
            End If
            Return New JsonResult With {.Data= listado,
                          .JsonRequestBehavior = JsonRequestBehavior.AllowGet}
        End Function

    End Class
End Namespace