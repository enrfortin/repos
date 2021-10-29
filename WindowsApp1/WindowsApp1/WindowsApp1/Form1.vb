Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private shared sub Releasecapture()

    End sub

     <DllImport("user32.dll", EntryPoint:="SendMessage")>
        Private shared sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lparam As Integer)

        End sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Releasecapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        WindowState =FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            label4.Text = WebBrowser1.Document.GetElementById("wob_loc").InnerText
            label6.Text = WebBrowser1.Document.GetElementById("wob_tm").InnerText
            Label5.Text = WebBrowser1.Document.GetElementById("wob_dc").InnerText

            PictureBox4.ImageLocation = WebBrowser1.Document.GetElementById("wob_tci").GetAttribute("src")

            label4.Visible = True
            label6.Visible = True
            label5.Visible = True
            PictureBox4.Visible = True
            label7.Visible = True


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.google.com/?gws_rd=ssl#q=clima+")
        Conexion.Myconectar()
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        if TextBox1.Text="USUARIO" then
            TextBox1.Text=""
            Label2.Visible=true
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
              if TextBox1.Text="" then
            TextBox1.Text="USUARIO"
            Label2.Visible=false
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text="CONTRASEÑA" Then
            TextBox2.Text=""
            Label3.Visible=true
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
               If TextBox2.Text="" Then
            TextBox2.Text="CONTRASEÑA"
              Label3.Visible=false
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text="CONTRASEÑA" Then
        textbox2.PasswordChar=""
            Else
             textbox2.PasswordChar="*"
       End if
    End Sub

    Private Sub BunifuiOSSwitch1_OnValueChange(sender As Object, e As EventArgs) Handles BunifuiOSSwitch1.OnValueChange
        If BunifuiOSSwitch1.Value=True Then
            TextBox2.PasswordChar=""
            Else
            TextBox2.PasswordChar="*"
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
       validacion()
   End Sub

    Public sub validacion()

        Try             
        If TextBox1.Text=Nothing Or TextBox2.Text= Nothing Then
           MsgBox("Debe ingresar datos, No dejar espacios en blanco")
            TextBox1.Text=""
            TextBox2.Text=""
            Else
            ingresar(textbox1.text, encriptar.Encriptar(TextBox2.Text))
        End If
        Catch ex As Exception

         End Try
        End sub


       Public sub  ingresar(byval user as string, byval pass as string)
    
        Try
            Conexion.Abrir_MYBD()
            Dim consulta As String= ("select nombre, pass from usuario where nombre = lower('" & user & "') and pass ='" & pass & "'")
            Dim datard As MySqlDataReader
            Dim comando As New MySqlCommand(consulta, Conexion.myconn)
            datard= comando.ExecuteReader            
            If datard.Read Then
                datard.Close()
                'MsgBox("Si, conectado")
                Me.Hide()
                Form2.show()
                else
                datard.Close()
                MsgBox("Nombre de usuario o contraseña invalida")
            End If
            Me.TextBox1.Text=""
            Me.TextBox2.Text=""
        Catch ex As Exception
            MsgBox("Conexion no realizada "+ex.ToString)

        Finally
            Conexion.Cerrar_MYBD()
        End Try

       End sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select e.KeyData
            Case Keys.Enter
                validacion()
        end select
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        registro.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.show
    End Sub
End Class


