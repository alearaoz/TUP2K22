Imports System.Data.OleDb

Public Class Alumnos
    Dim dba As New DBAdmin
    Dim da As New DAlumnos
    Dim dsc As New DCursos
    Dim dm As New DMaterias

    ' Constantes para la configuracion del Panel de Control y Control del Formulario de Alumnos

    Private Const Buscar As String = "Buscar"

    Private Const Modificar As String = "Modificar"
    Private Const Mostrar As String = "Mostrar"
    Private Const Nuevo As String = "Nuevo"
    Private Const DatoRegular As String = "DatoRegular"
    Private Const DatoObligatorio As String = "DatoObligatorio"

    ' Constantes para la configuracion del Panel de Control y Control del Formulario del Libro de Alumnos
    Private Const Inicial As String = "Inicial"
    Private Const AlumnoNoInscripto As String = "AlumnoNoInscripto"
    Private Const InscripcionAlumno As String = "InscripcionAlumno"
    Private Const ModificacionMateriaNotaAbierta As String = "ModificacionMateriaNotaAbierta"
    Private Const SeleccionNotaAbierta As String = "SeleccionNotaAbierta"
    Private Const SeleccionNotaCerrada As String = "SeleccionNotaCerrada"


    ' ---------------------------------------------- FUNCIONES/SUBS PARA CONFIGURAR VISTAS ----------------------------------------------


    ' Carga del formulario Alumnos con la vista de los alumnos existentes
    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Crea los DataGridView vacios en el inicio

        DGVAlumnos.DataSource = Nothing
        ' Configura el panel de Control (botones) y los objetos (textboxes, combos, etc) de la seccion Alumnos

        PanelControlAlumnos(Buscar)
        ControlFormularioAlumnos(Buscar)
        dsc.CrearComboCursosBuscar(combo_Bcurso, Nothing)

        ' Crea los mensajes de ayuda de los botones (mostrando el texto al pasar sobre el boton) de la seccion Alumnos

        ToolTip_Alumnos.SetToolTip(Btn_NuevoAlumno, "Crear Nuevo Alumno")
        ToolTip_Alumnos.SetToolTip(Btn_ModificarAlumno, "Modificar Alumno")
        ToolTip_Alumnos.SetToolTip(Btn_CancelarAlumno, "Cancelar Accion")
        ToolTip_Alumnos.SetToolTip(Btn_GuardarAlumno, "Guardar Alumno")
        ToolTip_Alumnos.SetToolTip(Btn_EliminarAlumno, "Eliminar Alumno")


        ' Configura el panel de Control (botones) y los objetos (textboxes, combos, etc) de la seccion Libro
        ' de Alumnos (Quedo nombre inicial de Materias)

        Materias_Load()

        ' Crea los mensajes de ayuda de los botones (mostrando el texto al pasar sobre el boton) de la seccion Alumnos


        ToolTip_Alumnos.SetToolTip(Btn_AgregarMateria, "Inscribir Alumno")
        ToolTip_Alumnos.SetToolTip(Btn_ModificarMateria, "Modificar Notas")
        ToolTip_Alumnos.SetToolTip(Btn_GuardarMateria, "Guardar Notas")
        ToolTip_Alumnos.SetToolTip(Btn_CancelarMateria, "Cancelar")
        ToolTip_Alumnos.SetToolTip(Btn_CerrarNotas, "Cerrar Notas")

    End Sub


    ' Carga/actualiza la seccion Alumnos del formulario cuando otras funciones lo requieren
    Private Sub Alumnos_Reload()

        LimpiarDatosAlumno()
        PanelControlAlumnos(Buscar)
        ControlFormularioAlumnos(Buscar)

        Materias_Load()

    End Sub


    ' Carga/actualiza la seccion Libro de Alumnos del formulario cuando otras funciones lo requieren
    Private Sub Materias_Load()

        dm.cargarDGVMaterias(DGVMaterias, Nothing)
        PanelControlMateriasAlumno(Inicial)
        ControlFormularioMaterias(Inicial)
        LimpiarDatosMaterias()

    End Sub


    ' Realiza el formateo de las Labels del formulario Alumnos (cuando se requieren datos obligatorios)
    Public Sub FormatearLabel(estiloLabel As String, label As Label)

        Select Case estiloLabel
            Case DatoRegular
                label.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                label.Font = New Font(label.Font, FontStyle.Regular)

            Case DatoObligatorio
                label.ForeColor = Color.Red
                label.Font = New Font(label.Font, FontStyle.Bold)

        End Select

    End Sub


    ' Activa o desactiva los botones de la seccion Alumnos de acuerdo al perfil seleccionado
    Private Sub PanelControlAlumnos(modoPanel As String)

        Select Case modoPanel
            Case Buscar
                Btn_BuscarAlumno.Enabled = True
                Btn_NuevoAlumno.Enabled = True
                Btn_ModificarAlumno.Enabled = False
                Btn_GuardarAlumno.Enabled = False
                Btn_CancelarAlumno.Enabled = False
                Btn_EliminarAlumno.Enabled = False

            Case Modificar
                Btn_BuscarAlumno.Enabled = False
                Btn_NuevoAlumno.Enabled = False
                Btn_ModificarAlumno.Enabled = False
                Btn_GuardarAlumno.Enabled = True
                Btn_CancelarAlumno.Enabled = True
                Btn_EliminarAlumno.Enabled = True

            Case Mostrar
                Btn_BuscarAlumno.Enabled = True
                Btn_NuevoAlumno.Enabled = True
                Btn_ModificarAlumno.Enabled = True
                Btn_GuardarAlumno.Enabled = False
                Btn_CancelarAlumno.Enabled = False
                Btn_EliminarAlumno.Enabled = False

            Case Nuevo
                Btn_BuscarAlumno.Enabled = False
                Btn_NuevoAlumno.Enabled = False
                Btn_ModificarAlumno.Enabled = False
                Btn_GuardarAlumno.Enabled = True
                Btn_CancelarAlumno.Enabled = True
                Btn_EliminarAlumno.Enabled = False

        End Select

    End Sub


    ' Activa o desactiva los elementos del formulario de la seccion Alumnos de acuerdo al perfil seleccionado
    Private Sub ControlFormularioAlumnos(modoFormulario As String)

        Select Case modoFormulario
            Case Buscar
                tBox_legajo.Enabled = True
                FormatearLabel(DatoRegular, Lbl_dni)
                tBox_dni.Enabled = True
                FormatearLabel(DatoRegular, Lbl_nombre)
                tBox_nombre.Enabled = True
                FormatearLabel(DatoRegular, Lbl_apellido)
                tBox_apellido.Enabled = True
                FormatearLabel(DatoRegular, Lbl_fechanac)
                Lbl_fechanac.Visible = False
                dTime_fnac.Visible = False
                dTime_fnac.Enabled = False
                Lbl_Bcurso.Visible = True
                combo_Bcurso.Visible = True
                combo_Bcurso.Enabled = True
                Lbl_datosObligatorios.Visible = False

            Case Modificar
                tBox_legajo.Enabled = False
                FormatearLabel(DatoObligatorio, Lbl_dni)
                tBox_dni.Enabled = True
                FormatearLabel(DatoObligatorio, Lbl_nombre)
                tBox_nombre.Enabled = True
                FormatearLabel(DatoObligatorio, Lbl_apellido)
                tBox_apellido.Enabled = True
                FormatearLabel(DatoObligatorio, Lbl_fechanac)
                Lbl_fechanac.Visible = True
                dTime_fnac.Visible = True
                dTime_fnac.Enabled = True
                Lbl_Bcurso.Visible = False
                combo_Bcurso.Visible = False
                combo_Bcurso.Enabled = False
                Lbl_datosObligatorios.Visible = True

            Case Mostrar
                tBox_legajo.Enabled = False
                FormatearLabel(DatoRegular, Lbl_dni)
                tBox_dni.Enabled = False
                FormatearLabel(DatoRegular, Lbl_nombre)
                tBox_nombre.Enabled = False
                FormatearLabel(DatoRegular, Lbl_apellido)
                tBox_apellido.Enabled = False
                FormatearLabel(DatoRegular, Lbl_fechanac)
                Lbl_fechanac.Visible = True
                dTime_fnac.Visible = True
                dTime_fnac.Enabled = False
                Lbl_Bcurso.Visible = False
                combo_Bcurso.Visible = False
                combo_Bcurso.Enabled = False
                Lbl_datosObligatorios.Visible = False

            Case Nuevo
                tBox_legajo.Enabled = False
                FormatearLabel(DatoObligatorio, Lbl_dni)
                tBox_dni.Enabled = True
                FormatearLabel(DatoObligatorio, Lbl_nombre)
                tBox_nombre.Enabled = True
                FormatearLabel(DatoObligatorio, Lbl_apellido)
                tBox_apellido.Enabled = True
                FormatearLabel(DatoObligatorio, Lbl_fechanac)
                Lbl_fechanac.Visible = True
                dTime_fnac.Visible = True
                dTime_fnac.Enabled = True
                Lbl_Bcurso.Visible = False
                combo_Bcurso.Visible = False
                combo_Bcurso.Enabled = False
                Lbl_datosObligatorios.Visible = True

        End Select

    End Sub


    ' Restablece los componentes del formulario de la seccion Alumnos a su estado inicial
    Private Sub LimpiarDatosAlumno()

        tBox_legajo.Clear()
        tBox_dni.Clear()
        tBox_nombre.Clear()
        tBox_apellido.Clear()
        dTime_fnac.Value = Date.Today.ToShortDateString
        dsc.CrearComboCursosBuscar(combo_Bcurso, Nothing)

    End Sub


    ' Activa o desactiva los botones de la seccion Libro de Alumnos de acuerdo al perfil seleccionado
    Private Sub PanelControlMateriasAlumno(modoPanel As String)

        Select Case modoPanel
            Case Inicial
                Btn_AgregarMateria.Enabled = False
                Btn_ModificarMateria.Enabled = False
                Btn_GuardarMateria.Enabled = False
                Btn_CancelarMateria.Enabled = False
                Btn_CerrarNotas.Enabled = False

            Case AlumnoNoInscripto
                Btn_AgregarMateria.Enabled = True
                Btn_ModificarMateria.Enabled = False
                Btn_GuardarMateria.Enabled = False
                Btn_CancelarMateria.Enabled = False
                Btn_CerrarNotas.Enabled = False

            Case InscripcionAlumno
                Btn_AgregarMateria.Enabled = False
                Btn_ModificarMateria.Enabled = True
                Btn_GuardarMateria.Enabled = True
                Btn_CancelarMateria.Enabled = True
                Btn_CerrarNotas.Enabled = False

            Case ModificacionMateriaNotaAbierta
                Btn_AgregarMateria.Enabled = False
                Btn_ModificarMateria.Enabled = False
                Btn_GuardarMateria.Enabled = True
                Btn_CancelarMateria.Enabled = True
                Btn_CerrarNotas.Enabled = True

            Case SeleccionNotaAbierta
                Btn_AgregarMateria.Enabled = False
                Btn_ModificarMateria.Enabled = True
                Btn_GuardarMateria.Enabled = False
                Btn_CancelarMateria.Enabled = False
                Btn_CerrarNotas.Enabled = False

            Case SeleccionNotaCerrada
                Btn_AgregarMateria.Enabled = False
                Btn_ModificarMateria.Enabled = False
                Btn_GuardarMateria.Enabled = False
                Btn_CancelarMateria.Enabled = False
                Btn_CerrarNotas.Enabled = False

        End Select

    End Sub


    ' Activa o desactiva los elementos del formulario de la seccion Libro de Alumnos de acuerdo al perfil seleccionado
    Private Sub ControlFormularioMaterias(modoFormulario As String)

        Select Case modoFormulario
            Case Inicial
                combo_curso.Enabled = False
                combo_materia.Enabled = False
                tBox_nota_t1.Enabled = False
                tBox_nota_t2.Enabled = False
                tBox_nota_t3.Enabled = False

            Case AlumnoNoInscripto
                combo_curso.Enabled = False
                combo_materia.Enabled = False
                tBox_nota_t1.Enabled = False
                tBox_nota_t2.Enabled = False
                tBox_nota_t3.Enabled = False

            Case InscripcionAlumno
                combo_curso.Enabled = True
                combo_materia.Enabled = False
                tBox_nota_t1.Enabled = False
                tBox_nota_t2.Enabled = False
                tBox_nota_t3.Enabled = False

            Case ModificacionMateriaNotaAbierta
                combo_curso.Enabled = False
                combo_materia.Enabled = False
                tBox_nota_t1.Enabled = True
                tBox_nota_t2.Enabled = True
                tBox_nota_t3.Enabled = True

            Case SeleccionNotaAbierta
                combo_curso.Enabled = False
                combo_materia.Enabled = False
                tBox_nota_t1.Enabled = False
                tBox_nota_t2.Enabled = False
                tBox_nota_t3.Enabled = False

            Case SeleccionNotaCerrada
                combo_curso.Enabled = False
                combo_materia.Enabled = False
                tBox_nota_t1.Enabled = False
                tBox_nota_t2.Enabled = False
                tBox_nota_t3.Enabled = False

        End Select

    End Sub


    ' Restablece los componentes del formulario de la seccion Libro de Alumnos a su estado inicial
    Private Sub LimpiarDatosMaterias()

        dsc.CrearComboCursos(combo_curso, Nothing)
        dm.CrearComboMaterias(combo_materia, Nothing)
        tBox_nota_t1.Clear()
        tBox_nota_t2.Clear()
        tBox_nota_t3.Clear()

    End Sub


    ' Controla el comportamiento del DataGridView de Alumnos
    Private Sub DGVAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAlumnos.CellContentClick

        Dim legajo As Integer
        Dim dni As Integer
        Dim nombre As String
        Dim apellido As String
        Dim fnac As Date
        Dim cod_curso As Integer
        Dim cod_materia As Integer
        Dim nota_t1 As Double
        Dim nota_t2 As Double
        Dim nota_t3 As Double
        Dim promedio As Double

        LimpiarDatosAlumno()

        legajo = DGVAlumnos.Rows(e.RowIndex).Cells(0).Value
        dni = DGVAlumnos.Rows(e.RowIndex).Cells(1).Value
        nombre = DGVAlumnos.Rows(e.RowIndex).Cells(2).Value
        apellido = DGVAlumnos.Rows(e.RowIndex).Cells(3).Value
        fnac = DGVAlumnos.Rows(e.RowIndex).Cells(4).Value

        da.MostrarAlumnoSeleccionado(legajo, dni, nombre, apellido, fnac)

        PanelControlAlumnos(Mostrar)
        ControlFormularioAlumnos(Mostrar)

        LimpiarDatosMaterias()
        dm.cargarDGVMaterias(DGVMaterias, legajo)

        If DGVMaterias.DataSource Is Nothing Then

            cod_curso = Nothing
            promedio = Nothing

            ControlFormularioMaterias(AlumnoNoInscripto)
            PanelControlMateriasAlumno(AlumnoNoInscripto)
        Else

            cod_curso = DGVMaterias.Rows(0).Cells(0).Value
            cod_materia = DGVMaterias.Rows(0).Cells(1).Value
            nota_t1 = DGVMaterias.Rows(0).Cells(3).Value
            nota_t2 = DGVMaterias.Rows(0).Cells(4).Value
            nota_t3 = DGVMaterias.Rows(0).Cells(5).Value

            If IsDBNull(DGVMaterias.Rows(0).Cells(6).Value) Then
                promedio = 0
            Else
                Double.TryParse(DGVMaterias.Rows(0).Cells(6).Value, promedio)
            End If

            dm.MostrarMateriaSeleccionada(cod_curso, cod_materia, nota_t1, nota_t2, nota_t3, promedio)

            If promedio > 0 Then
                ControlFormularioMaterias(SeleccionNotaCerrada)
                PanelControlMateriasAlumno(SeleccionNotaCerrada)
            Else
                ControlFormularioMaterias(SeleccionNotaAbierta)
                PanelControlMateriasAlumno(SeleccionNotaAbierta)
            End If
        End If

        dsc.CrearComboCursos(combo_curso, cod_curso)

    End Sub


    ' Controla el comportamiento del DataGridView de Materias
    Private Sub DGVMaterias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMaterias.CellContentClick

        Dim cod_curso As Integer
        Dim cod_materia As Integer
        Dim nota_t1 As Double
        Dim nota_t2 As Double
        Dim nota_t3 As Double
        Dim promedio As Double

        LimpiarDatosMaterias()

        If DGVMaterias.DataSource Is Nothing Then
            cod_curso = Nothing
            promedio = Nothing

            ControlFormularioMaterias(Inicial)
            PanelControlMateriasAlumno(Inicial)
        Else

            cod_curso = DGVMaterias.Rows(e.RowIndex).Cells(0).Value
            cod_materia = DGVMaterias.Rows(e.RowIndex).Cells(1).Value
            nota_t1 = DGVMaterias.Rows(e.RowIndex).Cells(3).Value
            nota_t2 = DGVMaterias.Rows(e.RowIndex).Cells(4).Value
            nota_t3 = DGVMaterias.Rows(e.RowIndex).Cells(5).Value

            If IsDBNull(DGVMaterias.Rows(e.RowIndex).Cells(6).Value) Then
                promedio = Nothing
            Else
                Double.TryParse(DGVMaterias.Rows(e.RowIndex).Cells(6).Value, promedio)
            End If

            dm.MostrarMateriaSeleccionada(cod_curso, cod_materia, nota_t1, nota_t2, nota_t3, promedio)

            If promedio > 0 Then
                ControlFormularioMaterias(SeleccionNotaCerrada)
                PanelControlMateriasAlumno(SeleccionNotaCerrada)
            Else
                ControlFormularioMaterias(SeleccionNotaAbierta)
                PanelControlMateriasAlumno(SeleccionNotaAbierta)
            End If
        End If

        dsc.CrearComboCursos(combo_curso, cod_curso)

    End Sub


    ' Funcion auxiliar para manejar la conversion de contenido de los TextBoxes de String a Integer
    Public Function ConversorStringToInteger(txt As TextBox) As Integer

        If txt.Text = "" Then
            Return 0
        Else
            Return Int(txt.Text)
        End If

    End Function


    ' Funcion auxiliar para manejar la conversion de contenido de los ComboBoxes de String a Integer
    Public Function ConversorComboToInteger(cmb As ComboBox) As Integer

        If cmb.Text = "" Then
            Return 0
        Else
            Return Int(cmb.Text)
        End If

    End Function


    ' ------------------------------------------- SUBS DE CONTROL DE BOTONES SECCION ALUMNOS -------------------------------------------


    ' Logica del boton Buscar de la seccion Alumnos
    Private Sub Btn_BuscarAlumno_Click(sender As Object, e As EventArgs) Handles Btn_BuscarAlumno.Click

        Dim legajo As Integer = ConversorStringToInteger(tBox_legajo)
        Dim dni As Integer = ConversorStringToInteger(tBox_dni)
        Dim nombre As String = tBox_nombre.Text
        Dim apellido As String = tBox_apellido.Text
        Dim curso As Integer = combo_Bcurso.SelectedIndex

        LimpiarDatosAlumno()
        LimpiarDatosMaterias()
        ControlFormularioAlumnos(Buscar)
        da.BuscarAlumnos(DGVAlumnos, legajo, dni, nombre, apellido, curso)

    End Sub


    ' Logica del boton Crear/Nuevo de la seccion Alumnos
    Private Sub Btn_NuevoAlumno_Click(sender As Object, e As EventArgs) Handles Btn_NuevoAlumno.Click

        LimpiarDatosAlumno()
        PanelControlAlumnos(Nuevo)
        ControlFormularioAlumnos(Nuevo)

    End Sub


    ' Logica del boton Modificar de la seccion Alumnos
    Private Sub Btn_ModificarAlumno_Click(sender As Object, e As EventArgs) Handles Btn_ModificarAlumno.Click

        ControlFormularioAlumnos(Modificar)
        PanelControlAlumnos(Modificar)

    End Sub


    ' Logica del boton Guardar de la seccion Alumnos
    Private Sub Btn_GuardarAlumno_Click(sender As Object, e As EventArgs) Handles Btn_GuardarAlumno.Click

        Dim nlegajo As Integer
        Dim ndni As Integer
        Dim nom As String
        Dim ape As String
        Dim fnac As Date

        Dim idVerificacionDNI As Integer
        Dim mostrarDatosDNI As Integer
        Dim idNuevoAlumno As Integer

        If tBox_dni.Text IsNot "" And tBox_nombre.Text IsNot "" And tBox_apellido.Text IsNot "" And
            dTime_fnac.Value.ToShortDateString IsNot "" Then

            If tBox_legajo.Text.Length = 0 Then
                nlegajo = Nothing
            Else
                nlegajo = Int(tBox_legajo.Text)
            End If

            ndni = Int(tBox_dni.Text)
            nom = tBox_nombre.Text
            ape = tBox_apellido.Text
            fnac = dTime_fnac.Value.ToShortDateString

            ' Si el numero de legajo esta vacio, se trata de un nuevo Alumno y se sigue con la creacion
            If nlegajo = Nothing Then

                Try
                    ' Busco el DNI del Alumno para evitar duplicar este dato o un error de tipeo
                    idVerificacionDNI = da.BuscarDNIAlumno(ndni)

                    ' Si el DNI NO existe
                    If idVerificacionDNI = Nothing Then

                        da = New DAlumnos(ndni, nom, ape, fnac)

                        idNuevoAlumno = da.CrearAlumno(da)
                        If idNuevoAlumno <> 0 Then

                            MsgBox("El Alumno " & da.nombreAlumno & " " & da.apellidoAlumno & " (" & idNuevoAlumno & ") fue creado exitosamente.", vbInformation, "Felicitaciones!")
                            Dim alumnoEncontrado() As String = da.BuscarDatosAlumno(idNuevoAlumno)

                            nlegajo = Int(alumnoEncontrado(0))
                            ndni = Int(alumnoEncontrado(1))
                            nom = alumnoEncontrado(2)
                            ape = alumnoEncontrado(3)
                            fnac = alumnoEncontrado(4)

                            da.MostrarAlumnoSeleccionado(nlegajo, ndni, nom, ape, fnac)
                            da.cargarDGVAlumnos(DGVAlumnos)
                            ControlFormularioAlumnos(Mostrar)
                            PanelControlAlumnos(Mostrar)
                        Else
                            Alumnos_Reload()
                        End If
                    Else
                        ' Si el DNI EXISTE
                        mostrarDatosDNI = MsgBox("El DNI ingresado ya existe. Desea ver los datos del Alumno?", vbQuestion + vbYesNo + vbDefaultButton2, "Atencion!")

                        If mostrarDatosDNI = vbYes Then
                            Dim alumnoEncontrado() As String = da.BuscarDatosAlumno(idVerificacionDNI)

                            nlegajo = Int(alumnoEncontrado(0))
                            ndni = Int(alumnoEncontrado(1))
                            nom = alumnoEncontrado(2)
                            ape = alumnoEncontrado(3)
                            fnac = alumnoEncontrado(4)

                            da.MostrarAlumnoSeleccionado(nlegajo, ndni, nom, ape, fnac)
                            ControlFormularioAlumnos(Mostrar)
                            PanelControlAlumnos(Mostrar)
                        Else
                            Alumnos_Reload()
                        End If
                    End If

                Catch ex As Exception
                    MsgBox("Se produjo un error en la creacion del Alumno" & vbNewLine & ex.Message)
                End Try
            Else

                ' Si el numero legajo tiene un valor, se trata de una modificacion y se sigue con el proceso

                Try
                    da = New DAlumnos(nlegajo, ndni, nom, ape, fnac)

                    If da.ModificarAlumno(da) Then

                        MsgBox("El Alumno " & da.nombreAlumno & " " & da.apellidoAlumno & " (" & da.legajoAlumno & ") fue modificado exitosamente.", vbInformation, "Felicitaciones!")

                        Dim alumnoEncontrado() As String = da.BuscarDatosAlumno(nlegajo)

                        nlegajo = Int(alumnoEncontrado(0))
                        ndni = Int(alumnoEncontrado(1))
                        nom = alumnoEncontrado(2)
                        ape = alumnoEncontrado(3)
                        fnac = alumnoEncontrado(4)

                        da.MostrarAlumnoSeleccionado(nlegajo, ndni, nom, ape, fnac)
                        ControlFormularioAlumnos(Mostrar)
                        PanelControlAlumnos(Mostrar)
                    Else
                        Alumnos_Reload()
                    End If
                Catch ex As Exception
                    MsgBox("Se produjo un error al modificar el Alumno.", MsgBoxStyle.Exclamation)
                End Try

            End If
        Else

            MsgBox("Los campos obligatorios no pueden estar vacios")

        End If
    End Sub


    ' Logica del boton Cancelar de la seccion Alumnos
    Private Sub Btn_CancelarAlumno_Click(sender As Object, e As EventArgs) Handles Btn_CancelarAlumno.Click

        Alumnos_Reload()

    End Sub


    ' Logica del boton Eliminar de la seccion Alumnos
    Private Sub Btn_EliminarAlumno_Click(sender As Object, e As EventArgs) Handles Btn_EliminarAlumno.Click

        Dim nlegajo As Integer
        Dim ndni As Integer
        Dim nom As String
        Dim ape As String
        Dim fnac As Date
        Dim codcurso As Integer

        nlegajo = Int(tBox_legajo.Text)
        ndni = Int(tBox_dni.Text)
        nom = tBox_nombre.Text
        ape = tBox_apellido.Text
        fnac = dTime_fnac.Value.ToShortDateString
        codcurso = Int(combo_curso.SelectedValue)

        da = New DAlumnos(nlegajo, ndni, nom, ape, fnac)

        If tBox_legajo.Text <> "" Then
            If da.EliminarAlumno(da) Then
                Alumnos_Reload()
            End If
        Else
            MsgBox("Debe seleccionar un Alumno antes de eliminar.", MsgBoxStyle.Exclamation)
        End If

    End Sub


    ' -------------------------------------- SUBS DE CONTROL DE BOTONES SECCION LIBRO DE ALUMNOS --------------------------------------


    ' Logica del boton Inscribir de la seccion Libro de Alumnos
    Private Sub Btn_AgregarMateria_Click(sender As Object, e As EventArgs) Handles Btn_AgregarMateria.Click

        PanelControlMateriasAlumno(InscripcionAlumno)
        ControlFormularioMaterias(InscripcionAlumno)

    End Sub


    ' Logica del boton Modificar de la seccion Libro de Alumnos
    Private Sub Btn_ModificarMateria_Click(sender As Object, e As EventArgs) Handles Btn_ModificarMateria.Click

        ControlFormularioMaterias(ModificacionMateriaNotaAbierta)
        PanelControlMateriasAlumno(ModificacionMateriaNotaAbierta)

    End Sub


    ' Logica del boton Guardar de la seccion Libro de Alumnos
    Private Sub Btn_GuardarMateria_Click(sender As Object, e As EventArgs) Handles Btn_GuardarMateria.Click

        Dim nlegajo As Integer
        Dim codcurso As Integer
        Dim codmateria As Integer
        Dim notat1 As Double
        Dim notat2 As Double
        Dim notat3 As Double
        Dim promedio As Double
        Dim verificarInscripcion As Boolean

        promedio = dm.BuscarPromedioMateria(nlegajo, codcurso, codmateria)

        nlegajo = Int(tBox_legajo.Text)
        codcurso = combo_curso.SelectedValue
        codmateria = combo_materia.SelectedValue

        If nlegajo <> Nothing And codcurso > 0 And codmateria <> Nothing Then

            verificarInscripcion = dm.BuscarInscripcionAlumno(nlegajo, codcurso)

            ' Verifica si el legajo y curso existen en el libro de alumnos (esta inscripto en ese curso)
            If verificarInscripcion And promedio = Nothing Then

                Try
                    Double.TryParse(tBox_nota_t1.Text, notat1)
                    Double.TryParse(tBox_nota_t2.Text, notat2)
                    Double.TryParse(tBox_nota_t3.Text, notat3)

                    If dm.ModificarNota(nlegajo, codcurso, codmateria, notat1, notat2, notat3) Then

                        MsgBox("La nota fue modificada exitosamente")


                        dm.MostrarMateriaSeleccionada(codcurso, codmateria, notat1, notat2, notat3, promedio)
                        PanelControlMateriasAlumno(SeleccionNotaAbierta)
                        ControlFormularioMaterias(SeleccionNotaAbierta)
                        dm.cargarDGVMaterias(DGVMaterias, nlegajo)
                    Else
                        PanelControlMateriasAlumno(SeleccionNotaAbierta)
                        ControlFormularioMaterias(SeleccionNotaAbierta)
                    End If
                Catch ex As Exception
                    MsgBox("Se produjo un error en la modificacion de la Nota" & vbNewLine & vbNewLine & ex.Message, vbExclamation, "Modificar Nota")
                End Try


            Else
                ' Si no existe se trata de una inscripcion

                Try
                    notat1 = 0
                    notat2 = 0
                    notat3 = 0
                    promedio = 0

                    If dm.InscribirAlumno(nlegajo, codcurso, notat1, notat2, notat3, promedio) Then

                        MsgBox("El Alumno fue inscripto exitosamente")

                        Dim materiaEncontrada() As String = dm.BuscarDatosMateria(nlegajo, codcurso, codmateria)

                        notat1 = materiaEncontrada(0)
                        notat2 = materiaEncontrada(1)
                        notat3 = materiaEncontrada(2)
                        promedio = materiaEncontrada(3)

                        dm.MostrarMateriaSeleccionada(codcurso, codmateria, notat1, notat2, notat3, promedio)
                        PanelControlMateriasAlumno(SeleccionNotaAbierta)
                        ControlFormularioMaterias(SeleccionNotaAbierta)
                        dm.cargarDGVMaterias(DGVMaterias, nlegajo)
                    End If

                Catch ex As Exception
                    MsgBox("Se produjo un error en la inscripcion del Alumno")
                End Try

            End If

        Else
            MsgBox("Los campos no pueden estar vacios")
        End If

    End Sub


    ' Logica del boton Cancelar de la seccion Libro de Alumnos
    Private Sub Btn_CancelarMateria_Click(sender As Object, e As EventArgs) Handles Btn_CancelarMateria.Click

        ControlFormularioMaterias(SeleccionNotaAbierta)
        PanelControlMateriasAlumno(SeleccionNotaAbierta)

    End Sub


    ' Logica del boton Cerrar Notas de la seccion Libro de Alumnos
    Private Sub Btn_CerrarNotas_Click(sender As Object, e As EventArgs) Handles Btn_CerrarNotas.Click

        Dim nro_legajo As Integer = Int(tBox_legajo.Text)
        Dim cod_curso As Integer = combo_curso.SelectedValue
        Dim cod_materia As Integer = combo_materia.SelectedValue
        Dim nota_t1 As Double
        Dim nota_t2 As Double
        Dim nota_t3 As Double
        Dim promedio As Double

        Double.TryParse(tBox_nota_t1.Text, nota_t1)
        Double.TryParse(tBox_nota_t2.Text, nota_t2)
        Double.TryParse(tBox_nota_t3.Text, nota_t3)

        If dm.CalcularPromedioMaterias(nro_legajo, cod_curso) Then
            MsgBox("La nota de la materia fue cerrada exitosamente")
            LimpiarDatosMaterias()
            dm.cargarDGVMaterias(DGVMaterias, nro_legajo)
            promedio = dm.BuscarPromedioMateria(nro_legajo, cod_curso, cod_materia)
        Else
            promedio = Nothing
        End If

        dm.MostrarMateriaSeleccionada(cod_curso, cod_materia, nota_t1, nota_t2, nota_t3, promedio)
        ControlFormularioMaterias(SeleccionNotaCerrada)
        PanelControlMateriasAlumno(SeleccionNotaCerrada)

    End Sub

    ' ------------------------------------- SUBS DE CONTROL DE BOTONES PRINCIPALES DEL FORMULARIO -------------------------------------

    'Logica del boton Volver del formulario (cierra el formulario)
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click

        Me.Close()
        EduCADPro.Show()

    End Sub

End Class