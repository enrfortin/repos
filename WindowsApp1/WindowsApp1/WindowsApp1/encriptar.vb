Imports System.Security.Cryptography
Imports System.Text
Module encriptar
    Private des As New TripleDESCryptoServiceProvider
    Private hashmd5 As New MD5CryptoServiceProvider
    Private mkey As String = "mi clave"

    Public Function Encriptar(ByVal texto As string) As String
        If Trim(texto) ="" Then
            Encriptar=""
            Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(mkey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() as Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar= Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
           
        End If
        Return Encriptar
    End Function


    
    Public Function Desencriptar(ByVal texto As string) As String
        If Trim(texto) ="" Then
            Desencriptar=""
            Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(mkey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() as Byte = Convert.FromBase64String(texto)
            Desencriptar= UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))           
        End If
        
        Return Desencriptar
    End Function





End Module
