Imports System.Data.OleDb

Public Class DCursos
    Inherits DBAdmin

    Private cod_curso As Integer
    Private curso As String

    Private dbCmd As OleDbCommand


    ' Constructores del objeto DCursos
    Public Sub New(nomcurso As String)
        curso = nomcurso
    End Sub

    Public Sub New()

    End Sub


    ' Propiedades de la clase accesibles/configurables mediante Get/Set
    Public Property codigoCurso As Integer
        Get
            Return cod_curso
        End Get
        Set(value As Integer)
            cod_curso = value
        End Set
    End Property

    Public Property nombreCurso As Integer
        Get
            Return curso
        End Get
        Set(value As Integer)
            curso = value
        End Set
    End Property


    ' ---------------------------------------------- FUNCIONES/SUBS PARA CONFIGURAR VISTAS ----------------------------------------------


    ' Crea el combo de Cursos para la inscripcion de un alumno
    Public Sub CrearComboCursos(combo_curso As ComboBox, cod_curso As Integer)

        Dim datosCursos As OleDbDataAdapter
        Dim dsCursos As DataSet
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM Cursos"

        Try
            datosCursos = New OleDb.OleDbDataAdapter(sqlQuery, con)
            dsCursos = New DataSet

            datosCursos.Fill(dsCursos, "Cursos")

            If dsCursos.Tables("Cursos").Rows.Count > -1 Then
                combo_curso.DataSource = dsCursos.Tables("Cursos")
                combo_curso.ValueMember = "cod_curso"
                combo_curso.DisplayMember = "curso"

                If cod_curso <> Nothing Then
                    combo_curso.SelectedValue = cod_curso
                End If
            Else
                combo_curso.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' Crea el combo de Cursos para mostrar estadisticas
    Public Sub CrearComboCursosEstadisticas(combo_curso As ComboBox, cod_curso As Integer)

        Dim datosCursos As OleDbDataAdapter
        Dim dsCursos As DataSet
        Dim dtCursos As DataTable
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM Cursos"

        Try
            datosCursos = New OleDb.OleDbDataAdapter(sqlQuery, con)
            dsCursos = New DataSet
            dtCursos = New DataTable

            dtCursos.TableName = "Cursos"

            dtCursos.Columns.Add("cod_curso", GetType(Integer))
            dtCursos.Columns.Add("curso", GetType(String))

            dsCursos.Tables.Add(dtCursos)

            dsCursos.Tables("Cursos").Rows.Add(0, "TODOS")

            datosCursos.Fill(dsCursos, "Cursos")

            If dsCursos.Tables("Cursos").Rows.Count > -1 Then
                combo_curso.DataSource = dsCursos.Tables("Cursos")
                combo_curso.ValueMember = "cod_curso"
                combo_curso.DisplayMember = "curso"

                If cod_curso <> Nothing Then
                    combo_curso.SelectedValue = cod_curso
                    combo_curso.DisplayMember = BuscarCurso(cod_curso)
                End If
            Else
                combo_curso.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' Crea el combo de Cursos para mostrar en las busquedas
    Public Sub CrearComboCursosBuscar(combo_curso As ComboBox, cod_curso As Integer)

        Dim datosCursos As OleDbDataAdapter
        Dim dtCursos As DataTable
        Dim dsCursos As DataSet
        Dim sqlQuery As String

        sqlQuery = "SELECT distinct Cursos.curso
                    FROM LibrodeAlumnos
                    LEFT JOIN Cursos ON LibrodeAlumnos.cod_curso = Cursos.cod_curso"

        Try
            datosCursos = New OleDb.OleDbDataAdapter(sqlQuery, con)
            dsCursos = New DataSet
            dtCursos = New DataTable

            dtCursos.TableName = "Cursos"

            dtCursos.Columns.Add("cod_curso", GetType(Integer))
            dtCursos.Columns.Add("curso", GetType(String))

            dsCursos.Tables.Add(dtCursos)

            dsCursos.Tables("Cursos").Rows.Add(0, "TODOS")

            datosCursos.Fill(dsCursos, "Cursos")

            If dsCursos.Tables("Cursos").Rows.Count > -1 Then
                combo_curso.DataSource = dsCursos.Tables("Cursos")
                combo_curso.ValueMember = "cod_curso"
                combo_curso.DisplayMember = "curso"

                If cod_curso <> Nothing Then
                    combo_curso.SelectedIndex = cod_curso
                End If

            Else
                combo_curso.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' ----------------------------------------- FUNCIONES/SUBS DE CREACION/MODIFICACION/BAJA ------------------------------------------


    ' Crea el registro del nuevo curso en la tabla Cursos de la BD
    Public Function CrearCurso(dc As DCursos) As Boolean

        Dim sqlQuery = "INSERT INTO Cursos(curso) VALUES('" & dc.nombreCurso & "')"

        Try

            dbConectar()

            dbCmd = New OleDbCommand(sqlQuery, con)

            If dbCmd.ExecuteNonQuery() Then
                MsgBox("El Curso fue creado exitosamente")
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            dbDesconectar()
        End Try

    End Function


    ' ---------------------------------------------------- FUNCIONES/SUBS DE BUSQUEDA ----------------------------------------------------


    ' Obtiene el nombre del curso
    Public Function BuscarCurso(cod_curso As Integer) As String

        Dim caQuery As String
        Dim rsCursoQuery As String
        caQuery = "SELECT curso FROM Cursos WHERE cod_curso = " & cod_curso

        Try
            dbConectar()
            Dim dbCmd = New OleDbCommand(caQuery, con)

            rsCursoQuery = dbCmd.ExecuteScalar()

            If rsCursoQuery IsNot Nothing Then
                Return rsCursoQuery
            Else
                Return Nothing
            End If
        Catch
            MsgBox("No se encontro el curso")

            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Obtiene un listado de cursos
    Public Function BuscarCursosActivos() As List(Of Integer)

        Dim bcaQuery As String
        Dim bcaDataReader As OleDbDataReader

        Dim cursosEncontrados As New List(Of Integer)

        bcaQuery = "SELECT cod_curso FROM Cursos"

        Try
            dbConectar()
            dbCmd = New OleDbCommand(bcaQuery, con)

            bcaDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If bcaDataReader.HasRows() Then

                While bcaDataReader.Read()
                    cursosEncontrados.Add(Int(bcaDataReader(0)))
                End While

                bcaDataReader.Close()
                Return cursosEncontrados

            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error al crear la lista de cursos" & vbNewLine & ex.Message, vbExclamation, "Buscar Cursos Activos")
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function

End Class