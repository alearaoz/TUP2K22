Public Class DEstadisticas

    Dim dsc As New DCursos
    Dim dm As New DMaterias


    ' -------------------------------------- FUNCIONES/SUBS DE BUSQUEDA/CALCULO DE ESTADISTICAS ----------------------------------------


    ' Busca los promedios de los alumnos por curso y materia para confeccionar las estadisticas
    Public Sub CalcularPromediosPorCursoMateria(DGVPromediosPorCursoMateria As DataGridView)

        Dim totalAlumnosCursoMateria As Integer
        Dim totalAlumnosAprobados As Integer = 0
        Dim totalAlumnosRegulares As Integer = 0
        Dim totalAlumnosDesaprobados As Integer = 0
        Dim totalAlumnosSinCalificar As Integer = 0
        Dim totalNotasCerradasMateria As Integer
        Dim totalNotasCerradasCurso As Integer
        Dim porcentajeNotasCerradas As Double
        Dim promedioCursoMateria As Double
        Dim promedioCurso As Double
        Dim mejorPromedio As Double
        Dim cursoConMejorPromedio As Integer
        Dim promediosPorCursoMateria = New List(Of String())()
        Dim DTPromediosPorCursoMateria As New DataTable()
        Dim cursosEncontrados As List(Of Integer) = dsc.BuscarCursosActivos()

        DTPromediosPorCursoMateria.TableName = "PromediosPorCursoMateria"
        DTPromediosPorCursoMateria.Columns.Add("Curso", GetType(String))
        DTPromediosPorCursoMateria.Columns.Add("Materia", GetType(String))
        DTPromediosPorCursoMateria.Columns.Add("# Alumnos", GetType(Integer))
        DTPromediosPorCursoMateria.Columns.Add("# Notas Cerradas", GetType(Integer))
        DTPromediosPorCursoMateria.Columns.Add("% Notas Cerradas", GetType(Double))
        DTPromediosPorCursoMateria.Columns.Add("Promedio", GetType(Double))

        promedioCurso = 0
        mejorPromedio = 0

        ' Recorre la lista de cursos
        For Each cod_curso As Integer In cursosEncontrados

            Dim materiasEncontradas As List(Of Integer) = dm.BuscarMateriasPorCurso(cod_curso) ' Devuelve lista de cod_materia para ese curso

            totalNotasCerradasCurso = 0
            promedioCurso = 0

            ' Recorre la lista de materias asignadas al cod_curso
            For Each cod_materia As Integer In materiasEncontradas

                Dim promediosEncontrados As List(Of Double) = dm.BuscarPromedioAlumnoPorCurso(cod_curso, cod_materia)

                Dim curso As String = dsc.BuscarCurso(cod_curso)
                Dim materia As String = dm.BuscarMateria(cod_materia)

                totalNotasCerradasMateria = 0
                promedioCursoMateria = 0
                totalAlumnosCursoMateria = 0

                ' Valido si existen promedios para mostrar, caso contrario muestro la linea correspondiente al curso/materia con valores 0
                If promediosEncontrados.Count > 0 Then

                    ' Recorre LibrodeAlumnos para traer los promedios por cod_curso y cod_materia
                    For Each promedio As Double In promediosEncontrados

                        totalAlumnosCursoMateria += 1

                        ' De acuerdo al promedio obtenido, se incrementa el contador
                        If promedio > 0.0 Then
                            totalNotasCerradasMateria += 1
                            promedioCursoMateria += promedio
                            promedioCurso += promedio

                            If promedio >= 6.0 Then
                                totalAlumnosAprobados += 1
                            End If
                            If promedio >= 4.0 And promedio < 6.0 Then
                                totalAlumnosRegulares += 1
                            End If
                            If promedio >= 1.0 And promedio < 4.0 Then
                                totalAlumnosDesaprobados += 1
                            End If

                        Else
                            totalAlumnosSinCalificar += 1
                        End If

                    Next

                    porcentajeNotasCerradas = (totalNotasCerradasMateria / totalAlumnosCursoMateria) * 100
                    promedioCursoMateria = promedioCursoMateria / totalNotasCerradasMateria

                    DTPromediosPorCursoMateria.Rows.Add(curso, materia, totalAlumnosCursoMateria, totalNotasCerradasMateria, Math.Round(porcentajeNotasCerradas, 2), Math.Round(promedioCursoMateria, 2))

                Else

                    DTPromediosPorCursoMateria.Rows.Add(curso, materia, "0", "0", "0", "0")

                End If

                ' Incrementa la cantidad de materias del curso luego de evaluar todos los alumnos de cada materia
                totalNotasCerradasCurso += totalNotasCerradasMateria

            Next

            ' Calculo el promedio general del curso considerando las notas cerradas
            promedioCurso = promedioCurso / totalNotasCerradasCurso

            If promedioCurso > mejorPromedio Then
                cursoConMejorPromedio = cod_curso
                mejorPromedio = promedioCurso
            End If


        Next

        EduCADPro.Lbl_cursoMejorPromedio.Text = dsc.BuscarCurso(cursoConMejorPromedio)
        EduCADPro.Lbl_mejorPromedio.Text = Math.Round(mejorPromedio, 2)
        EduCADPro.Lbl_totalAlumnosAprobados.Text = totalAlumnosAprobados
        EduCADPro.Lbl_totalAlumnosRegulares.Text = totalAlumnosRegulares
        EduCADPro.Lbl_totalAlumnosDesaprobados.Text = totalAlumnosDesaprobados
        EduCADPro.Lbl_totalAlumnosSinCalificar.Text = totalAlumnosSinCalificar
        DGVPromediosPorCursoMateria.DataSource = DTPromediosPorCursoMateria
        DGVPromediosPorCursoMateria.Columns("% Notas Cerradas").DefaultCellStyle.Format = "0.0 \%"

    End Sub


    ' Muestra los resultados de las estadisticas en el DataGridView del formulario de Estadisticas
    Public Sub MostrarAlumnosCursoMateriaPromedio(DGVListadoEstadisticasAlumnos As DataGridView, cod_curso As Integer, cod_materia As Integer, condicion As Integer)

        Dim alumnosEncontrados = New List(Of String())()
        Dim DTListadoEstadisticasAlumnos As New DataTable()

        ' Vacio el DataGridView antes de mostrar los datos
        DGVListadoEstadisticasAlumnos = Nothing

        DTListadoEstadisticasAlumnos.TableName = "ListadoEstadisticaAlumno"

        DTListadoEstadisticasAlumnos.Columns.Add("Legajo", GetType(Integer))
        DTListadoEstadisticasAlumnos.Columns.Add("Nombre", GetType(String))
        DTListadoEstadisticasAlumnos.Columns.Add("Apellido", GetType(String))
        DTListadoEstadisticasAlumnos.Columns.Add("Curso", GetType(String))
        DTListadoEstadisticasAlumnos.Columns.Add("Materia", GetType(String))
        DTListadoEstadisticasAlumnos.Columns.Add("Promedio", GetType(Double))

        alumnosEncontrados = dm.ListarAlumnosCursoMateriaPromedio(cod_curso, cod_materia, condicion)

        ' Valido que la lista de alumnos tenga datos, caso contrario muestro un mensaje y cargo el DataGridView vacio
        If alumnosEncontrados IsNot Nothing Then

            ' Recorre la lista de materias asignadas al cod_curso
            For Each alumno() As String In alumnosEncontrados


                Dim legajo As String = alumno(0)
                Dim nombre As String = alumno(1)
                Dim apellido As String = alumno(2)
                Dim curso As String = alumno(3)
                Dim materia As String = alumno(4)
                Dim promedio As Double

                Double.TryParse(alumno(5), promedio)

                DTListadoEstadisticasAlumnos.Rows.Add(legajo, nombre, apellido, curso, materia, Math.Round(promedio, 2))

            Next

            Estadisticas.DGVListadoEstadisticasAlumnos.DataSource = DTListadoEstadisticasAlumnos
            Estadisticas.DGVListadoEstadisticasAlumnos.Columns("Promedio").DefaultCellStyle.Format = " 0.0"
            Estadisticas.DGVListadoEstadisticasAlumnos.Refresh()
        Else
            MsgBox("No se encontraron datos para mostrar", vbInformation, "Panel de Estadisticas")
            Estadisticas.DGVListadoEstadisticasAlumnos.DataSource = Nothing
            Estadisticas.DGVListadoEstadisticasAlumnos.Refresh()
        End If

    End Sub

End Class