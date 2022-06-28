Imports System.Data.OleDb

Public Class Estadisticas

    Dim dsc As New DCursos
    Dim dm As New DMaterias
    Dim de As New DEstadisticas


    ' ---------------------------------------------- FUNCIONES/SUBS PARA CONFIGURAR VISTAS ----------------------------------------------


    ' Carga del formulario Estadisticas con la vista de las estadisticas de los alumnos existentes
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        de.MostrarAlumnosCursoMateriaPromedio(DGVListadoEstadisticasAlumnos, 0, 0, 0)
        DGVListadoEstadisticasAlumnos.Refresh()
        dsc.CrearComboCursosEstadisticas(combo_Ecurso, 0)
        dm.CrearComboMateriasEstadisticas(combo_Emateria, 0)
        CrearComboCondicion(combo_Econdicion, 0)

    End Sub


    ' Crea el combo de Condicion de aprobacion de alumnos para mostrar estadisticas
    Public Sub CrearComboCondicion(combo_curso As ComboBox, condicion As Integer)

        Dim dsCondiciones As DataSet
        Dim dtCondiciones As DataTable

        Try
            dsCondiciones = New DataSet
            dtCondiciones = New DataTable

            dtCondiciones.TableName = "Condiciones"

            dtCondiciones.Columns.Add("condicion", GetType(Integer))
            dtCondiciones.Columns.Add("nombre", GetType(String))

            dsCondiciones.Tables.Add(dtCondiciones)

            dsCondiciones.Tables("Condiciones").Rows.Add(0, "TODOS")
            dsCondiciones.Tables("Condiciones").Rows.Add(1, "Aprobados")
            dsCondiciones.Tables("Condiciones").Rows.Add(2, "Regulares")
            dsCondiciones.Tables("Condiciones").Rows.Add(3, "Desaprobados")
            dsCondiciones.Tables("Condiciones").Rows.Add(4, "Sin Calificar")

            If dsCondiciones.Tables("Condiciones").Rows.Count > -1 Then
                combo_Econdicion.DataSource = dsCondiciones.Tables("Condiciones")
                combo_Econdicion.ValueMember = "condicion"
                combo_Econdicion.DisplayMember = "nombre"

                If condicion <> Nothing Then
                    combo_Econdicion.SelectedIndex = condicion
                End If

            Else
                combo_Econdicion.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' ------------------------------------------- SUBS DE CONTROL DE BOTONES DEL FORMULARIO -------------------------------------------


    ' Logica del ComboBox de la Condicion de aprobacion del alumno del formulario de estadisticas
    Private Sub combo_Econdicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_Econdicion.SelectedIndexChanged

        combo_Econdicion.SelectedIndex = combo_Econdicion.FindStringExact(combo_Econdicion.Text)
        'MsgBox("condicion: " & combo_Econdicion.SelectedValue)

    End Sub


    ' Logica del boton Aplicar Fintros del formulario de estadisticas
    Private Sub Btn_AplicarFiltro_Click(sender As Object, e As EventArgs) Handles Btn_AplicarFiltro.Click

        Dim curso As Integer
        Dim materia As Integer
        Dim condicion As Integer

        curso = combo_Ecurso.SelectedValue
        materia = combo_Emateria.SelectedValue
        condicion = combo_Econdicion.SelectedValue

        de.MostrarAlumnosCursoMateriaPromedio(DGVListadoEstadisticasAlumnos, curso, materia, condicion)

    End Sub


    ' ------------------------------------- SUBS DE CONTROL DE BOTONES PRINCIPALES DEL FORMULARIO -------------------------------------


    ' Logica del boton Volver del formulario de estadisticas
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        EduCADPro.Show()
        Me.Close()
    End Sub

End Class