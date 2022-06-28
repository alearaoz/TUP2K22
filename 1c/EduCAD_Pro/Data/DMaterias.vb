Imports System.Data.OleDb

Public Class DMaterias

    Inherits DBAdmin

    Private nro_legajo As Integer
    Private cod_curso As Integer
    Private cod_materia As Integer
    Private nota_t1 As Double
    Private nota_t2 As Double
    Private nota_t3 As Double
    Private dsc As DCursos
    Private dbCmd As OleDbCommand
    Private mpcDataReader As OleDbDataReader

    ' Constructores del objeto DMaterias
    Public Sub New(nlegajo As Integer, codcurso As Integer, codmateria As Integer, nt1 As Double, nt2 As Double, nt3 As Double)
        nro_legajo = nlegajo
        cod_curso = codcurso
        cod_materia = codmateria
        nota_t1 = nt1
        nota_t2 = nt2
        nota_t3 = nt3

    End Sub

    Public Sub New(nlegajo As Integer, codcurso As Integer)
        nro_legajo = nlegajo
        cod_curso = codcurso
        cod_materia = vbNull
        nota_t1 = ""
        nota_t2 = ""
        nota_t3 = ""

    End Sub

    Public Sub New()

    End Sub


    ' Propiedades de la clase accesibles/configurables mediante Get/Set
    Public Property legajoAlumno As Integer
        Get
            Return nro_legajo
        End Get
        Set(value As Integer)
            nro_legajo = value
        End Set
    End Property

    Public Property codigoCursoAlumno As Integer
        Get
            Return cod_curso
        End Get
        Set(value As Integer)
            cod_curso = value
        End Set
    End Property

    Public Property codigoMateria As Integer
        Get
            Return cod_materia
        End Get
        Set(value As Integer)
            cod_materia = value
        End Set
    End Property

    Public Property notaTrimestre1 As String
        Get
            Return nota_t1
        End Get
        Set(value As String)
            nota_t1 = value
        End Set
    End Property

    Public Property notaTrimestre2 As String
        Get
            Return nota_t2
        End Get
        Set(value As String)
            nota_t2 = value
        End Set
    End Property

    Public Property notaTrimestre3 As String
        Get
            Return nota_t3
        End Get
        Set(value As String)
            nota_t3 = value
        End Set
    End Property

    ' ---------------------------------------------- FUNCIONES/SUBS PARA CONFIGURAR VISTAS ----------------------------------------------


    ' Funcion que busca los datos de las materias y crea el ComboBox con todas las materias disponibles
    Public Sub CrearComboMaterias(combo_materia As ComboBox, cod_materia As Integer)

        Dim datosMaterias As OleDbDataAdapter
        Dim dsMaterias As DataSet
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM Materias"

        Try
            datosMaterias = New OleDb.OleDbDataAdapter(sqlQuery, con)
            dsMaterias = New DataSet

            datosMaterias.Fill(dsMaterias, "Materias")

            If dsMaterias.Tables("Materias").Rows.Count > -1 Then
                combo_materia.DataSource = dsMaterias.Tables("Materias")
                combo_materia.ValueMember = "cod_materia"
                combo_materia.DisplayMember = "materia"

                If cod_materia <> Nothing Then
                    combo_materia.SelectedValue = cod_materia
                End If

            Else
                combo_materia.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' Funcion que busca los datos de las materias y crea el ComboBox con todas las materias disponibles
    Public Sub CrearComboMateriasEstadisticas(combo_materia As ComboBox, cod_materia As Integer)

        Dim datosMaterias As OleDbDataAdapter
        Dim dtMaterias As DataTable
        Dim dsMaterias As DataSet
        Dim sqlQuery As String

        sqlQuery = "SELECT DISTINCT LibrodeAlumnos.cod_materia, Materias.materia
                    FROM LibrodeAlumnos
                    LEFT JOIN Materias ON LibrodeAlumnos.cod_materia = Materias.cod_materia"

        Try
            datosMaterias = New OleDb.OleDbDataAdapter(sqlQuery, con)
            dsMaterias = New DataSet
            dtMaterias = New DataTable

            dtMaterias.TableName = "Materias"

            dtMaterias.Columns.Add("cod_materia", GetType(Integer))
            dtMaterias.Columns.Add("materia", GetType(String))

            dsMaterias.Tables.Add(dtMaterias)

            dsMaterias.Tables("Materias").Rows.Add(0, "TODAS")

            datosMaterias.Fill(dsMaterias, "Materias")

            If dsMaterias.Tables("Materias").Rows.Count > -1 Then
                combo_materia.DataSource = dsMaterias.Tables("Materias")
                combo_materia.ValueMember = "cod_materia"
                combo_materia.DisplayMember = "materia"

                If cod_materia <> Nothing Then
                    combo_materia.SelectedValue = cod_materia
                    combo_materia.DisplayMember = BuscarMateria(cod_materia)
                End If

            Else
                combo_materia.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' Funcion que crea el DataGridView de los Alumnos
    Public Sub cargarDGVMaterias(DGVMaterias As DataGridView, nro_legajo As Integer)

        Dim dmQuery As String
        Dim datosMaterias As New OleDb.OleDbDataAdapter
        Dim dsMaterias As New DataSet

        dmQuery = "SELECT LibrodeAlumnos.cod_curso AS [Curso],Materias.cod_materia, Materias.materia AS Materia, LibrodeAlumnos.nota_t1 AS [1° Trimestre], 
            LibrodeAlumnos.nota_t2 AS [2° Trimestre], LibrodeAlumnos.nota_t3 AS [3° Trimestre], promedio AS Promedio
            FROM LibrodeAlumnos
            INNER JOIN Materias ON Materias.cod_materia = LibrodeAlumnos.cod_materia
            WHERE LibrodeAlumnos.nro_legajo = " & nro_legajo

        Try
            If nro_legajo <> 0 Then

                datosMaterias = New OleDbDataAdapter(dmQuery, con)

                datosMaterias.Fill(dsMaterias)
                If dsMaterias.Tables(0).Rows.Count > 0 Then
                    DGVMaterias.DataSource = dsMaterias.Tables(0)
                    DGVMaterias.Columns(0).Visible = False
                    DGVMaterias.Columns(1).Visible = False
                    DGVMaterias.Columns(6).Visible = False
                    DGVMaterias.AutoResizeColumns()
                Else
                    DGVMaterias.DataSource = Nothing
                End If
            Else
                DGVMaterias.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al crear la vista de Materias" & vbNewLine & vbNewLine & ex.Message & vbExclamation, "Carga DGVMaterias")
        End Try

    End Sub


    ' Funcion que carga los datos de la materia seleccionada en el formulario de Libro de Alumnos
    Public Sub MostrarMateriaSeleccionada(cod_curso As Integer, cod_materia As Integer, nota_t1 As Double, nota_t2 As Double,
    nota_t3 As Double, promedio As Double)

        Try
            CrearComboMaterias(Alumnos.combo_materia, cod_materia)
            Alumnos.tBox_nota_t1.Text = nota_t1
            Alumnos.tBox_nota_t2.Text = nota_t2
            Alumnos.tBox_nota_t3.Text = nota_t3

            If promedio <> Nothing Then
                Alumnos.gpBox_promedio.Text = "Promedio Definitivo"
                Alumnos.Lbl_promedio.Text = Math.Round(promedio, 2)
            Else
                Alumnos.gpBox_promedio.Text = "Promedio Preliminar"
                Alumnos.Lbl_promedio.Text = Math.Round(CalcularPromedioMateria(nota_t1, nota_t2, nota_t3), 2)
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar mostrar los datos de la Materia")
        End Try

    End Sub


    ' ----------------------------------------- FUNCIONES/SUBS DE CREACION/MODIFICACION/BAJA ------------------------------------------


    ' Funcion que Inscribe el Alumno en un curso. Al momento de la inscripcion se crean todos los registros de las materias
    ' asignadas para cada curso en la tabla Materias_por_Curso en la BD
    Public Function InscribirAlumno(nro_legajo As Integer, cod_curso As Integer, notat1 As Integer, notat2 As Integer,
        notat3 As Integer, promedio As Integer) As Boolean

        Dim niQuery As String

        Try
            If nro_legajo <> Nothing And cod_curso <> Nothing Then
                ' Busca la lista de materias asignadas a cada Curso

                Dim materiasEncontradas As List(Of Integer) = BuscarMateriasPorCurso(cod_curso)


                ' Si existen materias asignadas a ese curso
                If materiasEncontradas.Count > 0 Then
                    niQuery = ""
                    dbConectar()

                    dbCmd = New OleDbCommand(niQuery, con)

                    ' Por cada materia, crea un registro en el libro de alumnos, donde se cargaran las notas 
                    For Each cod_materia As Integer In materiasEncontradas

                        niQuery = "INSERT INTO LibrodeAlumnos(nro_legajo, cod_curso, cod_materia, nota_t1, nota_t2, nota_t3, promedio) 
                        VALUES('" & nro_legajo & "','" & cod_curso & "','" & cod_materia & "','" & notat1 & "','" & notat2 & "','" &
                        notat3 & "','" & promedio & "')"

                        dbCmd.CommandText = niQuery
                        dbCmd.ExecuteNonQuery()

                    Next
                    Return True
                Else
                    MsgBox("No existen materias para el curso seleccionado")
                    Return False
                End If
            Else

                Return False
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error al inscribir al Alumno" & vbNewLine & vbNewLine & ex.Message)
            Return False
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Funcion que modifica los datos de las notas de las materias del alumno en el libro de alumnos
    Public Function ModificarNota(nro_legajo As Integer, cod_curso As Integer, cod_materia As Integer, nota_t1 As Double,
        nota_t2 As Double, nota_t3 As Double) As Boolean

        Dim mnQuery As String
        Dim dbCmd As New OleDbCommand

        ' Valida que los datos del alumno a modificar no esten vacios
        If nro_legajo <> 0 And cod_curso <> 0 And cod_materia <> 0 And nota_t1 <> Nothing And nota_t2 <> Nothing And
            nota_t3 <> Nothing Then

            mnQuery = "UPDATE LibrodeAlumnos SET nota_t1=" & nota_t1 & ", nota_t2=" & nota_t2 & ", nota_t3=" &
                    nota_t3 &
                    " WHERE nro_legajo =" & nro_legajo &
                    " AND cod_curso=" & cod_curso &
                    " AND cod_materia=" & cod_materia

            Try
                dbConectar()
                dbCmd = New OleDbCommand(mnQuery, con)

                If dbCmd.ExecuteNonQuery() Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox("Se produjo un error al modificar la nota del Alumno:" & vbNewLine & vbNewLine & ex.Message, vbExclamation, "Modificar Notas")
                Return False
            Finally
                dbDesconectar()
            End Try

        Else
            MsgBox("Los Campos Obligatorios no pueden estar vacios")
            Return False
        End If

    End Function

    ' Funcion que calcula la nota promedio de una materias dada
    Public Function CalcularPromedioMaterias(nro_legajo As Integer, cod_curso As Integer) As Boolean

        Dim codmateria As Integer
        Dim notat1 As Double
        Dim notat2 As Double
        Dim notat3 As Double
        Dim promedio As Double

        Dim cpmQuery As String

        Dim notasEncontradas As List(Of Double()) = BuscarNotasPorAlumno(nro_legajo, cod_curso)


        ' Si existen materias asignadas a ese curso
        If notasEncontradas.Count > 0 Then

            Try
                cpmQuery = ""
                dbConectar()

                dbCmd = New OleDbCommand(cpmQuery, con)

                ' Por cada materia, obtengo las notas para calcular el promedio 
                For Each notaMateria() As Double In notasEncontradas


                    codmateria = notaMateria(0)
                    Double.TryParse(notaMateria(1), notat1)
                    Double.TryParse(notaMateria(2), notat2)
                    Double.TryParse(notaMateria(3), notat3)

                    If notat1 <> 0 And notat2 <> 0 And notat3 <> 0 Then
                        promedio = Math.Round(CalcularPromedioMateria(notat1, notat2, notat3), 2)

                        cpmQuery = "UPDATE LibrodeAlumnos SET promedio ='" & promedio &
                            "' WHERE nro_legajo =" & nro_legajo &
                            " AND cod_curso =" & cod_curso &
                            " AND cod_materia =" & codmateria

                        dbCmd.CommandText = cpmQuery
                        dbCmd.ExecuteNonQuery()
                    Else
                        MsgBox("No puede haber notas con valor 0 al momento del cierre de Notas", vbExclamation, "Cierre de Notas")
                        Return False
                    End If
                Next
                Return True
            Catch ex As Exception
                MsgBox("Se produjo un error al guardar el promedio" & vbNewLine & vbNewLine & ex.Message, vbExclamation, "Guardar Promedio Materia")
                Return False
            Finally
                dbDesconectar()
            End Try

        Else
            MsgBox("No existen materias para el curso seleccionado")
            Return False
        End If

    End Function


    ' Funcion que calcula la nota promedio segun las notas proporcionadas
    Public Function CalcularPromedioMateria(nota_t1 As Double, nota_t2 As Double, nota_t3 As Double) As Double

        Dim promedioMateria As Double
        Dim Contador As Double

        Try
            If nota_t1 <> 0 Then
                Contador += 1
                promedioMateria += nota_t1
            End If

            If nota_t2 <> 0 Then
                Contador += 1
                promedioMateria += nota_t2
            End If

            If nota_t3 <> 0 Then
                Contador += 1
                promedioMateria += nota_t3
            End If

            If promedioMateria > 0 Then
                promedioMateria = promedioMateria / Contador
                Return Math.Round(promedioMateria, 2)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error al calcular el promedio: " & vbNewLine & vbNewLine & ex.Message, vbExclamation, "Calcular Promedio Materia")
            Return Nothing
        End Try

    End Function


    ' ---------------------------------------------------- FUNCIONES/SUBS DE BUSQUEDA ----------------------------------------------------


    ' Funcion que busca el legajo y el curso en la tabla LibrodeAlumnos y devuelve True si la encuentra y False en caso contrario.
    Public Function BuscarInscripcionAlumno(nro_legajo As Integer, cod_curso As Integer) As Boolean

        Dim biaQuery As String
        Dim rsIAQuery As String

        biaQuery = "SELECT * FROM LibrodeAlumnos WHERE nro_legajo = " & nro_legajo &
            " AND cod_curso = " & cod_curso

        Try
            dbConectar()
            dbCmd = New OleDbCommand(biaQuery, con)

            rsIAQuery = dbCmd.ExecuteScalar()
            If rsIAQuery IsNot Nothing Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Funcion que busca las materias asignadas a cada curso en la tabla Materias_por_Curso en la BD
    Public Function BuscarMateriasPorCurso(cod_curso As Integer) As List(Of Integer)

        Dim mpcQuery As String
        Dim materiasEncontradas As New List(Of Integer)

        mpcQuery = "SELECT cod_materia FROM Materias_por_Curso WHERE cod_curso =" & cod_curso

        Try
            dbConectar()
            dbCmd = New OleDbCommand(mpcQuery, con)

            mpcDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If mpcDataReader.HasRows() Then

                While mpcDataReader.Read()
                    materiasEncontradas.Add(Int(mpcDataReader(0)))
                End While

                mpcDataReader.Close()
                Return materiasEncontradas

            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error en la busqueda de materias por curso" & vbNewLine & ex.Message)
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Funcion que busca los datos de la primer materia encontrada de un alumno en la tabla LibrodeAlumnos seleccionando por legajo y curso
    Public Function BuscarDatosMateria(legajo As Integer, cod_curso As Integer, cod_materia As Integer) As String()

        Dim aQuery As String

        aQuery = "SELECT nota_t1, nota_t2, nota_t3, promedio FROM LibrodeAlumnos WHERE 
        nro_legajo =" & legajo & "AND cod_curso =" & cod_curso & "AND cod_materia =" & cod_materia

        Try
            dbConectar()
            dbCmd = New OleDbCommand(aQuery, con)

            mpcDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If mpcDataReader.Read() Then
                Dim materia = New String() {mpcDataReader.Item("nota_t1"), mpcDataReader.Item("nota_t2"), mpcDataReader.Item("nota_t3"),
                    mpcDataReader.Item("promedio")}

                Return materia
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error en la busqueda de los datos del Alumno" & vbNewLine & ex.Message)
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function

    ' Funcion que busca las notas de materias de un alumno asignadas a cada curso en la tabla Materias_por_Curso en la BD
    Public Function BuscarNotasPorAlumno(nro_legajo As Integer, cod_curso As Integer) As List(Of Double())

        Dim mpcQuery As String
        Dim notasEncontradas As New List(Of Double())

        Dim codmateria As Double
        Dim notat1 As Double
        Dim notat2 As Double
        Dim notat3 As Double

        mpcQuery = "SELECT cod_materia, nota_t1, nota_t2, nota_t3 FROM LibrodeAlumnos WHERE nro_legajo =" & nro_legajo &
            " AND cod_curso =" & cod_curso

        Try
            dbConectar()
            dbCmd = New OleDbCommand(mpcQuery, con)

            mpcDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If mpcDataReader.HasRows() Then

                While mpcDataReader.Read()

                    Double.TryParse(mpcDataReader.Item("cod_materia"), codmateria)
                    Double.TryParse(mpcDataReader.Item("nota_t1"), notat1)
                    Double.TryParse(mpcDataReader.Item("nota_t2"), notat2)
                    Double.TryParse(mpcDataReader.Item("nota_t3"), notat3)

                    notasEncontradas.Add({codmateria, notat1, notat2, notat3})

                End While

                mpcDataReader.Close()
                Return notasEncontradas

            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error en la busqueda de materias por curso" & vbNewLine & ex.Message)
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function

    ' Funcion que busca el promedio de las materias de todos los alumnos por curso en la tabla Materias_por_Curso en la BD
    Public Function BuscarPromedioAlumnoPorCurso(cod_curso As Integer, cod_materia As Integer) As List(Of Double)

        Dim nacQuery As String
        Dim nacDataReader As OleDbDataReader
        Dim promediosEncontrados As New List(Of Double)()

        nacQuery = "SELECT promedio FROM LibrodeAlumnos WHERE cod_curso =" & cod_curso &
            " AND cod_materia =" & cod_materia

        Try
            dbConectar()
            dbCmd = New OleDbCommand(nacQuery, con)

            nacDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If nacDataReader.HasRows() Then

                While nacDataReader.Read()

                    promediosEncontrados.Add(nacDataReader.Item("promedio"))

                End While

            End If

            Return promediosEncontrados

        Catch ex As Exception
            MsgBox("Se produjo un error en la busqueda de materias por curso" & vbNewLine & vbNewLine & ex.Message)
            Return promediosEncontrados
        Finally
            dbDesconectar()
        End Try

    End Function

    ' Funcion que busca el nombre de la materia segun su codigo en la tabla Materias
    Public Function BuscarMateria(cod_materia As Integer) As String

        Dim sqlQuery As String

        sqlQuery = "SELECT materia FROM Materias WHERE cod_materia = " & cod_materia

        Try
            dbConectar()
            Dim dbCmd = New OleDbCommand(sqlQuery, con)
            Dim rsQuery As String

            rsQuery = dbCmd.ExecuteScalar()
            dbDesconectar()
            If rsQuery IsNot Nothing Then
                Return rsQuery
            Else
                Return Nothing
            End If
        Catch
            MsgBox("No se encontro la materia")
            dbDesconectar()
            Return Nothing
        End Try

    End Function

    Public Function BuscarPromedioMateria(legajo As Integer, cod_curso As Integer, cod_materia As Integer) As Double

        Dim bpmQuery As String
        Dim rsPromQuery As Double

        bpmQuery = "SELECT promedio FROM LibrodeAlumnos WHERE nro_legajo = " & legajo &
            " AND cod_curso=" & cod_curso &
            " AND cod_materia=" & cod_materia

        Try
            dbConectar()
            dbCmd = New OleDbCommand(bpmQuery, con)


            If Not IsDBNull(dbCmd.ExecuteScalar()) Then

                Double.TryParse(Math.Round(dbCmd.ExecuteScalar(), 2), rsPromQuery)

                Return rsPromQuery
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error al consultar el promedio" & ex.Message)
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function

    Public Function ListarAlumnosCursoMateriaPromedio(cod_curso As Integer, cod_materia As Integer, condicion As Integer) As List(Of String())

        Dim lacmQuery As String
        Dim alumnosEncontrados As New List(Of String())
        Dim lacmDataReader As OleDbDataReader

        lacmQuery = "SELECT Alumnos.nro_legajo AS Legajo, Alumnos.nombre AS Nombre, Alumnos.apellido AS Apellido,Cursos.curso AS Curso, Materias.materia AS Materia, 
                        LibrodeAlumnos.promedio AS Promedio
                        FROM (
                               (
                                 (
                                  LibrodeAlumnos LEFT JOIN Alumnos ON LibrodeAlumnos.nro_legajo = Alumnos.nro_legajo
                                 ) LEFT JOIN Cursos ON Cursos.cod_curso = LibrodeAlumnos.cod_curso
                               ) LEFT JOIN Materias ON LibrodeAlumnos.cod_materia = Materias.cod_materia
                             )"

        If cod_curso <> 0 Or cod_materia <> 0 Or condicion <> 0 Then

            lacmQuery &= " WHERE "

            If cod_curso <> 0 Then
                lacmQuery &= "LibrodeAlumnos.cod_curso = " & cod_curso
            End If

            If cod_materia <> 0 Then

                If cod_curso <> 0 Then
                    lacmQuery &= " AND "
                End If
                lacmQuery &= "LibrodeAlumnos.cod_materia = " & cod_materia
            End If

            If condicion <> 0 Then

                If cod_curso <> 0 Or cod_materia <> 0 Then
                    lacmQuery &= " AND "
                End If

                Select Case condicion
                    Case 1
                        lacmQuery &= "LibrodeAlumnos.promedio >= 6.0"
                    Case 2
                        lacmQuery &= "(LibrodeAlumnos.promedio BETWEEN 4.0 AND 6.0)"
                    Case 3
                        lacmQuery &= "(LibrodeAlumnos.promedio BETWEEN 1.0 AND 4.0)"
                    Case 4
                        lacmQuery &= "LibrodeAlumnos.promedio = 0"
                End Select

            End If

        End If

        Try
            dbConectar()
            dbCmd = New OleDbCommand(lacmQuery, con)

            lacmDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If lacmDataReader.HasRows() Then

                While lacmDataReader.Read()

                    alumnosEncontrados.Add({lacmDataReader.Item("Legajo"), lacmDataReader.Item("Nombre"), lacmDataReader.Item("Apellido"),
                                           lacmDataReader.Item("Curso"), lacmDataReader.Item("Materia"), lacmDataReader.Item("Promedio")})

                End While

                Return alumnosEncontrados
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error al consultar los datos de los alumnos." & vbNewLine & vbNewLine & ex.Message, vbExclamation, "Busqueda de datos de Alumnos")
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function

End Class