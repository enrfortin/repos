Imports MySql.Data.MySqlClient
Public Class Conexion
Public shared myconn As New MySqlConnection

    Public Shared Function Myconectar() As Boolean
        Dim cadenadeconexion=("server=127.0.0.1; database=cursovb; user id=newuser; password=123; port=3306;")
        Try 
             myconn.ConnectionString= cadenadeconexion
            If myconn.State = ConnectionState.Open
                myconectar=True
                Else
                myconn.Open()
                myconectar=True
                'MsgBox("Conexion Exitosa")
            End If
        Catch ex As Exception
            myconectar=false
            MsgBox(ex.ToString + "Conexion Fallo")
        End Try
    End Function

    Public shared sub Cerrar_MYBD()
        If myconn.State = ConnectionState.Closed Then
         Else
            Try
                myconn.Close()
            Catch ex As Exception
            End Try
        End If
    End sub

        Public shared sub Abrir_MYBD()
        If myconn.State = ConnectionState.Open Then
         Else
            Try
                myconn.Open()
            Catch ex As Exception
            End Try
        End If
    End sub


End Class
