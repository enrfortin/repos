Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            Dim comando As New MySqlcommand("select * from usuario", Conexion.myconn)
            Dim mytable1 As New DataTable()
            Dim myadapter As New MySqlDataAdapter(comando)

            myadapter.Fill(mytable1)
            If mytable1.Rows.Count() <= 0 Then
                MsgBox("No hay usuarios a mostrar")
                Else
                columna1="*"
                tabla1="usuario"
                data1= DataGridView1
                carga_data()
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "Error al cargar datos")
           Finally
            Conexion.Cerrar_MYBD()
        End Try



    End Sub

   Public sub carga_data()
        Try
            Conexion.Abrir_MYBD()
            Dim consulta As string
            consulta=("SELECT " & columna1 & "FROM " & tabla1 & "")
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(consulta, Conexion.myconn)
            Dim table As New DataTable
            da.Fill(table)
            Conexion.Cerrar_MYBD()
            data1.DataSource=table
        Catch ex As Exception
            MsgBox("Error al cargar datos")
        End Try


   End sub


    Public columna1 As String
    Public tabla1 As String
    Public data1 As New DataGridView

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
       actualizar()
    End Sub

    sub actualizar()
        
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
                comm.CommandText="Update usuario set nombre=@nombre, pass=@pass where id_usuario=@id"                         
                comm.parameters.Add(New MySqlParameter ("@nombre", BunifuMaterialTextbox1.text))
                comm.parameters.Add(New MySqlParameter ("@id", valor_del_celclik))
                comm.parameters.Add(New MySqlParameter ("@pass", encriptar.Encriptar(BunifuMaterialTextbox2.text)))
                comm.ExecuteNonQuery()
                MsgBox("Usuario actualizado")
                

            Catch ex As Exception
                MsgBox(ex.ToString+"Error no se pudo ingresar")
            End Try



        End If


    End sub


    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded
      e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim row As DataGridViewrow = DataGridView1.CurrentRow
            valor_del_celclik = CInt(row.Cells(0).value)
            Dim commando As New MySqlcommand("Select * from usuario", Conexion.myconn)
            Dim table As New DataTable()
            Dim adapter As New mysqldataadapter(commando)
            adapter.Fill(table)
            BunifuMaterialTextbox1.Text=CStr(row.Cells(1).value)
            BunifuMaterialTextbox2.Text=CStr(row.Cells(3).value)
        Catch ex As Exception
            MsgBox("Error al cargar los datos")
            Finally
            Conexion.Cerrar_MYBD()
        End Try



    End Sub
    Public valor_del_celclik As Integer

    Private Sub BunifuMaterialTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Enter
        If BunifuMaterialTextbox1.Text="Nombre de usuario" then
            BunifuMaterialTextbox1.Text=""
            Label2.Visible=True
        End If
    End Sub

        Private Sub BunifuMaterialTextbox1_L(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Leave
        If BunifuMaterialTextbox1.Text="" then
            BunifuMaterialTextbox1.Text="Nombre de usuario"
            Label2.Visible=false
        End If
    End Sub


        Private Sub BunifuMaterialTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Enter
        If BunifuMaterialTextbox2.Text="Contraseña" then
            BunifuMaterialTextbox2.Text=""
            Label3.Visible=True
        End If
    End Sub

        Private Sub BunifuMaterialTextbox2_L(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Leave
        If BunifuMaterialTextbox2.Text="" then
            BunifuMaterialTextbox2.Text="Contraseña"
            Label3.Visible=false
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        eliminar()
    End Sub


    sub eliminar()
               Dim conecta As New MySqlConnection
        Dim comm As New MySqlCommand
            
           
            Try
               conecta.ConnectionString=("server=127.0.0.1; database=cursovb; user id=newuser; password=123; port=3306;")
               conecta.Open()
                comm.Connection=conecta
                comm.CommandType = CommandType.Text
                comm.CommandText="delete from usuario where id_usuario=@id"                       
                comm.parameters.Add(New MySqlParameter ("@id", valor_del_celclik))                
                comm.ExecuteNonQuery()
                MsgBox("Usuario eliminado")
                

            Catch ex As Exception
                MsgBox(ex.ToString+"Error no se pudo ingresar")
            End Try

    End sub
End Class