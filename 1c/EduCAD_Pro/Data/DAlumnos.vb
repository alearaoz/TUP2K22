Imports System.Data.OleDb

Public Class DAlumnos

    Inherits DBAdmin

    Private nro_legajo As Integer
    Private dni As Integer
    Private nombre As String
    Private apellido As String
    Private fnac As Date

    Private sqlCmd As OleDbCommand
    Private dbCmd As OleDbCommand
    Private aDataReader As OleDbDataReader


    ' Constructores del objeto DAlumnos
    Public Sub New(nlegajo As Integer, ndni As Integer, nom As String, ape As String, fn As Date)
        nro_legajo = nlegajo
        dni = ndni
        nombre = nom
        apellido = ape
        fnac = fn
    End Sub


    Public Sub New(ndni As Integer, nom As String, ape As String, fn As Date)
        dni = ndni
        nombre = nom
        apellido = ape
        fnac = fn
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

    Public Property dniAlumno As Integer
        Get
            Return dni
        End Get
        Set(value As Integer)
            dni = value
        End Set
    End Property

    Public Property nombreAlumno As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property apellidoAlumno As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property fnacimientoAlumno As Date
        Get
            Return fnac
        End Get
        Set(value As Date)
            fnac = value
        End Set
    End Property


    ' --------------------------------------------- FUNCIONES/SUBS PARA CONFIGURAR VISTAS ---------------------------------------------


    ' Obtiene los datos que seran mostrados en el DataGridView de la seccion de Alumnos
    Public Sub cargarDGVAlumnos(dgVista As DataGridView)

        Dim caQuery As String
        Dim datosAlumnos As OleDbDataAdapter
        Dim dsAlumnos As New DataSet

        caQuery = "SELECT nro_legajo as Legajo, dni as DNI, nombre as Nombres, 
            apellido as Apellidos, fecha_nacimiento as [Fecha Nacimiento] FROM Alumnos"

        Try
            datosAlumnos = New OleDbDataAdapter(caQuery, con)

            datosAlumnos.Fill(dsAlumnos)

            If dsAlumnos.Tables(0).Rows.Count > 0 Then
                dgVista.DataSource = dsAlumnos.Tables(0)
                dgVista.AutoResizeColumns()
            Else
                dgVista.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al crear la vista de Alumnos" & vbNewLine & vbNewLine & ex.Message & vbExclamation, "Carga DGVAlumnos")
        End Try

    End Sub


    ' ---------------------------------------------- FUNCIONES/SUBS PARA ABM de Alumnos -----------------------------------------------


    ' Crea el registro del nuevo alumno en la tabla Alumnos de la BD
    Public Function CrearAlumno(da As DAlumnos) As Integer

        Dim rsNuevoAlumno As Integer
        Dim lcAlumnoID As Integer
        Dim naQuery As String
        Dim dbCmd As OleDbCommand


        ' Valida que los datos del alumno a crear no esten vacios
        If da.dniAlumno <> 0 And da.nombreAlumno IsNot "" And da.apellidoAlumno IsNot "" And da.fnacimientoAlumno.ToShortDateString <> "" Then

            naQuery = "INSERT INTO Alumnos(dni, nombre, apellido, fecha_nacimiento) VALUES('" & da.dniAlumno & "','" &
                da.nombreAlumno & "','" & da.apellidoAlumno & "','" & da.fnacimientoAlumno.ToShortDateString & "')"

            Try
                dbConectar()
                dbCmd = New OleDbCommand(naQuery, con)
                rsNuevoAlumno = dbCmd.ExecuteNonQuery()

                ' Valida si la ejecucion de la query devolvio al menos una fila creada
                If rsNuevoAlumno > 0 Then
                    'Ejecuta la query para obtener el ultimo ID creado en la tabla, contenido en @@IDENTITY
                    dbCmd.CommandText = "SELECT @@IDENTITY"
                    lcAlumnoID = dbCmd.ExecuteScalar()
                    Return lcAlumnoID
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Se produjo un error al crear el alumno: " & vbNewLine & ex.Message, "Crear Alumno")
                Return Nothing
            Finally
                dbDesconectar()
            End Try
        Else
            MsgBox("Los Campos Obligatorios no pueden estar vacios")
            Return Nothing
        End If

    End Function


    ' Modifica los datos del alumno seleccionado en la tabla Alumnos de la BD
    Public Function ModificarAlumno(da As DAlumnos) As Boolean

        Dim maQuery As String
        Dim dbCmd As OleDbCommand

        ' Valida que los datos del alumno a modificar no esten vacios
        If da.legajoAlumno <> 0 And da.dniAlumno <> 0 And da.nombreAlumno IsNot "" And da.apellidoAlumno IsNot "" And da.fnacimientoAlumno.ToShortDateString <> "" Then

            maQuery = "UPDATE Alumnos SET dni='" & da.dniAlumno & "', nombre='" & da.nombreAlumno & "', apellido='" &
                    da.apellidoAlumno & "', fecha_nacimiento='" & da.fnacimientoAlumno.ToShortDateString &
                    "' WHERE nro_legajo =" & da.legajoAlumno

            Try
                dbConectar()
                dbCmd = New OleDbCommand(maQuery, con)

                If dbCmd.ExecuteNonQuery() Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox("Se produjo un error al modificar el alumno:" & vbNewLine & vbNewLine & ex.Message, "Modificar Alumno")
                Return False
            Finally
                dbDesconectar()
            End Try

        Else
            MsgBox("Los Campos Obligatorios no pueden estar vacios")
            Return False
        End If

    End Function


    ' Elimina los datos del alumno seleccionado en la tabla Alumnos de la BD
    Public Function EliminarAlumno(da As DAlumnos) As Boolean

        Dim confirmacion As Integer

        Try
            Dim sqlQuery = "DELETE * FROM Alumnos WHERE nro_legajo =" & da.legajoAlumno

            dbConectar()

            sqlCmd = New OleDbCommand(sqlQuery, con)

            confirmacion = MsgBox("Se va a eliminar el Alumno " & da.nombreAlumno & " " & da.apellidoAlumno & " (" & da.legajoAlumno &
                                  "). Desea continuar?", vbQuestion + vbYesNo + vbDefaultButton2, "Atencion!")
            If confirmacion = vbYes Then
                If sqlCmd.ExecuteNonQuery() Then
                    MsgBox("El Alumno " & da.nombreAlumno & " " & da.apellidoAlumno & " (" & da.legajoAlumno & ") fue eliminado exitosamente")
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar el Alumno." & vbNewLine & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        Finally
            dbDesconectar()
        End Try

    End Function


    ' -------------------------------------- FUNCIONES/SUBS PARA BUSCAR/MOSTRAR DATOS DE ALUMNOS --------------------------------------


    ' Verifica si el numero de DNI existe en la BD
    Public Function BuscarDNIAlumno(ndni As Integer) As Integer

        Dim dniQuery As String
        Dim rsDNIQuery As String

        dniQuery = "SELECT nro_legajo FROM Alumnos WHERE dni = " & ndni

        Try
            dbConectar()
            dbCmd = New OleDbCommand(dniQuery, con)

            rsDNIQuery = dbCmd.ExecuteScalar()
            If rsDNIQuery <> Nothing Then
                Return Int(rsDNIQuery)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error al consultar el DNI" & ex.Message)
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Busca los datos de un alumno en la BD a partir del numero de legajo
    Public Function BuscarDatosAlumno(legajo As Integer) As String()

        Dim aQuery As String

        aQuery = "SELECT nro_legajo, dni, nombre, apellido, fecha_nacimiento FROM Alumnos WHERE nro_legajo =" & legajo

        Try
            dbConectar()
            dbCmd = New OleDbCommand(aQuery, con)

            aDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If aDataReader.Read() Then
                Dim alumno = New String() {aDataReader.Item("nro_legajo"), aDataReader.Item("dni"),
                    aDataReader.Item("nombre"), aDataReader.Item("apellido"), aDataReader.Item("fecha_nacimiento")}

                Return alumno
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error en la busqueda de los datos del Alumno" & vbNewLine & ex.Message)
            dbDesconectar()
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Busqueda Principal de Alumnos
    Public Function BuscarAlumno(legajo As Integer, dni As Integer, nombre As String, apellido As String, curso As Integer) As List(Of String())

        Dim baQuery As String
        Dim alumnosEncontrados As New List(Of String())
        Dim baDataReader As OleDbDataReader
        Dim nom As String
        Dim ape As String
        Dim fnac As String
        Dim cur As String

        baQuery = "SELECT Alumnos.nro_legajo as Legajo, Alumnos.dni as DNI, Alumnos.nombre as Nombres, 
                        Alumnos.apellido as Apellidos, Alumnos.fecha_nacimiento as [Fecha Nacimiento], Cursos.curso
                        FROM (
                                (
                                    Alumnos LEFT JOIN LibrodeAlumnos ON Alumnos.nro_legajo = LibrodeAlumnos.nro_legajo
                                ) LEFT JOIN Cursos ON Cursos.cod_curso = LibrodeAlumnos.cod_curso
                             )"


        ' Si se definio un criterio de busqueda, se configura cada condicion y se agrega a la consulta SQL
        If legajo <> 0 Or dni <> 0 Or nombre <> "" Or apellido <> "" Or curso <> 0 Then

            baQuery &= " WHERE "

            If legajo <> 0 Then
                baQuery &= "Alumnos.nro_legajo = " & legajo
            End If

            If dni <> 0 Then

                If legajo <> 0 Then
                    baQuery &= " AND "
                End If
                baQuery &= "Alumnos.dni = " & dni
            End If

            If nombre <> "" Then

                If legajo <> 0 Or dni <> 0 Then
                    baQuery &= " AND "
                End If
                baQuery &= "Alumnos.nombre LIKE """ & nombre & Chr(37) & """"
            End If

            If apellido <> "" Then

                If legajo <> 0 Or dni <> 0 Or nombre <> Nothing Then
                    baQuery &= " AND "
                End If
                baQuery &= "Alumnos.apellido LIKE """ & apellido & Chr(37) & """"
            End If

            If curso <> 0 Then

                If legajo <> 0 Or dni <> 0 Or nombre <> Nothing Or apellido <> Nothing Then
                    baQuery &= " AND "
                End If
                baQuery &= "LibrodeAlumnos.cod_curso = " & curso
            End If

        End If

        Try
            dbConectar()
            dbCmd = New OleDbCommand(baQuery, con)

            baDataReader = dbCmd.ExecuteReader(CommandBehavior.CloseConnection)

            If baDataReader.HasRows() Then

                While baDataReader.Read()


                    If IsDBNull(baDataReader.Item("Nombres")) Then
                        nom = ""
                    Else
                        nom = baDataReader.Item("Nombres")
                    End If

                    If IsDBNull(baDataReader.Item("Apellidos")) Then
                        ape = ""
                    Else
                        ape = baDataReader.Item("Apellidos")
                    End If

                    If IsDBNull(baDataReader.Item(4)) Then
                        fnac = ""
                    Else
                        fnac = baDataReader.Item(4)
                    End If

                    If IsDBNull(baDataReader.Item("Curso")) Then
                        cur = ""
                    Else
                        cur = baDataReader.Item("Curso")
                    End If

                    alumnosEncontrados.Add({baDataReader.Item("Legajo"), baDataReader.Item("DNI"), nom, ape, fnac, cur})
                    'alumnosEncontrados.Add({baDataReader.Item("Legajo"), baDataReader.Item("DNI"), nom, ape, fnac})
                End While

                Return alumnosEncontrados
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Se produjo un error al buscar el alumno." & vbNewLine & vbNewLine & ex.Message, vbExclamation, "Buscar Alumno")
            Return Nothing
        Finally
            dbDesconectar()
        End Try

    End Function


    ' Procesa y muestra el resultado de la busqueda de un alumno en el DataGridView del formulario Alumnos
    Public Sub MostrarResultadosBusqueda(DGVAlumnos As DataGridView, alumnosEncontrados As List(Of String()))

        Dim DTBAlumnos As New DataTable()

        DTBAlumnos.TableName = "ListadoEstadisticaAlumno"

        DTBAlumnos.Columns.Add("Legajo", GetType(Integer))
        DTBAlumnos.Columns.Add("DNI", GetType(Integer))
        DTBAlumnos.Columns.Add("Nombre", GetType(String))
        DTBAlumnos.Columns.Add("Apellido", GetType(String))
        DTBAlumnos.Columns.Add("Fecha Nacimiento", GetType(Date))
        DTBAlumnos.Columns.Add("Curso", GetType(String))

        ' Valido que la lista de alumnos tenga datos, caso contrario muestro un mensaje y cargo el DataGridView vacio
        If alumnosEncontrados IsNot Nothing Then

            ' Recorre la lista de materias asignadas al cod_curso
            For Each alumno() As String In alumnosEncontrados


                Dim leg As String = Int(alumno(0))
                Dim ndni As String = Int(alumno(1))
                Dim nom As String = alumno(2)
                Dim ape As String = alumno(3)
                Dim fnac As String = alumno(4)
                Dim cur As String = alumno(5)

                DTBAlumnos.Rows.Add(leg, ndni, nom, ape, fnac, cur)
                'DTBAlumnos.Rows.Add(leg, ndni, nom, ape, fnac)

            Next

            Alumnos.DGVAlumnos.DataSource = DTBAlumnos
            Alumnos.DGVAlumnos.Columns("Curso").Visible = False

        Else

            MsgBox("No se obtuvo resultados para mostrar", vbInformation, "Mostrar Resultado de Busqueda")
            Alumnos.DGVAlumnos.DataSource = Nothing
            Alumnos.DGVAlumnos.Refresh()

        End If

    End Sub


    ' Gestiona los modos de busqueda de un alumno en la BD
    Public Sub BuscarAlumnos(DGVAlumnos As DataGridView, legajo As Integer, dni As Integer, nombre As String, apellido As String,
                                        curso As Integer)

        Dim alumnosEncontrados = New List(Of String())()


        ' Si todos los campos de busqueda estan vacios pregunto si deseo ver todos los alumnos, caso contrario queda todo como esta
        If legajo = 0 And dni = 0 And nombre Is "" And apellido Is "" And curso = 0 Then

            Dim seguir As String

            seguir = MsgBox("No se indico ningun criterio de busqueda. Desea continuar y ver todos los alumnos?", vbQuestion + vbYesNo + vbDefaultButton2, "Atencion!")

            If seguir = vbYes Then

                alumnosEncontrados = BuscarAlumno(legajo, dni, nombre, apellido, curso)
                MostrarResultadosBusqueda(DGVAlumnos, alumnosEncontrados)

            End If

        Else

            alumnosEncontrados = BuscarAlumno(legajo, dni, nombre, apellido, curso)
            MostrarResultadosBusqueda(DGVAlumnos, alumnosEncontrados)

        End If

    End Sub


    ' Muestra los datos de un alumno seleccionado en la BD
    Public Sub MostrarAlumnoSeleccionado(legajo As Integer, dni As Integer, nombre As String, apellido As String, fnac As Date)

        Try
            Alumnos.tBox_legajo.Text = legajo
            Alumnos.tBox_dni.Text = dni
            Alumnos.tBox_nombre.Text = nombre
            Alumnos.tBox_apellido.Text = apellido
            Alumnos.dTime_fnac.Value = fnac
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar mostrar los datos del Alumno")
        End Try

    End Sub

End Class