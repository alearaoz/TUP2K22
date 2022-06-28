Imports System.Data.OleDb

Public Class DBAdmin

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\src\tup2k22\1c\EduCADPro.accdb")


    ' Funcion para conectar la BD
    Public Function dbConectar() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


    ' Funcion para desconectar de la BD
    Public Function dbDesconectar() As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class