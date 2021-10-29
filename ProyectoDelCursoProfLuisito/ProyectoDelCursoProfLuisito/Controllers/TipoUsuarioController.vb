Imports System.Web.Mvc

Namespace Controllers
    Public Class TipoUsuarioController
        Inherits Controller

        ' GET: TipoUsuario
        Function Index() As ActionResult
            Return View()
        End Function

        Function ListarTipoUsuario As JsonResult
            Dim db As New BDveterinariaDataContext
            Dim listarTipoUsu = From tipoUsuario In db.TipoUsuario
                                Where tipoUsuario.BHABILITADO=1
                                Select New With {
                                tipoUsuario.IIDTIPOUSUARIO,
                                tipoUsuario.NOMBRE,
                                tipoUsuario.DESCRIPCION
            }

            Return New JsonResult With {
                .Data=listarTipoUsu,
                .JsonRequestBehavior = JsonRequestBehavior.AllowGet
                }
        End Function

        Function FiltrarTipoUsuario(NombreTipoUsuario As String) As JsonResult
            Dim db As New BDveterinariaDataContext
            Dim listarTipoUsu
            If NombreTipoUsuario = "" Then
                listarTipoUsu = From tipoUsuario In db.TipoUsuario
                                Where tipoUsuario.BHABILITADO = 1
                                Select New With {
                                tipoUsuario.IIDTIPOUSUARIO,
                                tipoUsuario.NOMBRE,
                                tipoUsuario.DESCRIPCION
            }

            Else

                listarTipoUsu = From tipoUsuario In db.TipoUsuario
                                Where tipoUsuario.BHABILITADO = 1 And tipoUsuario.NOMBRE.Contains(NombreTipoUsuario)
                                Select New With {
                                tipoUsuario.IIDTIPOUSUARIO,
                                tipoUsuario.NOMBRE,
                                tipoUsuario.DESCRIPCION
            }
            End If
            Return New JsonResult With {
                .Data = listarTipoUsu,
                .JsonRequestBehavior = JsonRequestBehavior.AllowGet
                }


        End Function

        Function InsertarTipoUsuario(oTipousuario As TipoUsuario)
            Dim respuest = 0

            Try
                Dim db As New BDveterinariaDataContext
                db.TipoUsuario.InsertOnSubmit(oTipousuario)
                db.SubmitChanges()
                respuest = 1
            Catch ex As Exception
                respuest = 0
            End Try
            Return respuest
        End Function

    End Class
End Namespace