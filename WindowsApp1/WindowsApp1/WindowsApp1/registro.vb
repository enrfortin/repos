Imports MySql.Data.MySqlClient
Public Class registro
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BunifuMaterialTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Enter
        If BunifuMaterialTextbox1.Text= "Nombre de usuario" then
            BunifuMaterialTextbox1.Text= ""
            Label2.Visible=true
        End If
    End Sub

     Private Sub BunifuMaterialTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Leave
        If BunifuMaterialTextbox1.Text= "" then
            BunifuMaterialTextbox1.Text= "Nombre de usuario"
            Label2.Visible=false
        End If
    End Sub

        Private Sub BunifuMaterialTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Enter
        If BunifuMaterialTextbox2.Text= "Contraseña" then
            BunifuMaterialTextbox2.Text= ""
            Label3.Visible=true
        End If
    End Sub

     Private Sub BunifuMaterialTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Leave
        If BunifuMaterialTextbox2.Text= "" then
            BunifuMaterialTextbox2.Text= "Contraseña"
            Label3.Visible=false
        End If
    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        BunifuMaterialTextbox1.Text=""
        BunifuMaterialTextbox2.Text=""
    End Sub

   Sub  insertar()

       Dim conecta As New MySqlConnection
        Dim comm As New MySqlCommand

        If BunifuMaterialTextbox1.Text="" Or  BunifuMaterialTextbox1.Text="Nombre de usuario" Or BunifuMaterialTextbox2.Text="" Or BunifuMaterialTextbox2.Text="Contraseña" Then
            MsgBox("Las casillas no pueden quedar en blanco o con sus valores por defecto")
            Else
            Try
               conecta.ConnectionString=("server=127.0.0.1; database=cursovb; user id=newuser; password=123; port=3306;")
               conecta.Open()
                comm.Connection=conecta
                comm.CommandType = CommandType.Text
                comm.CommandText="Insert into usuario (nombre, fecha_ingreso, pass) values(@nombre, @fecha_ingreso, @pass)"                         
                comm.parameters.Add(New MySqlParameter ("@nombre", BunifuMaterialTextbox1.text))
                comm.parameters.Add(New MySqlParameter ("@fecha_ingreso", Today.date))
                comm.parameters.Add(New MySqlParameter ("@pass", encriptar.Encriptar(BunifuMaterialTextbox2.text)))
                comm.ExecuteNonQuery()
                MsgBox("Usuario agregado")
                limpiar()

            Catch ex As Exception
                MsgBox(ex.ToString+"Error no se pudo ingresar")
            End Try



        End If


     end Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        insertar()
    End Sub
End Class