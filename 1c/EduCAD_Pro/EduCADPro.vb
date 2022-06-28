Public Class EduCADPro


    Dim de As New DEstadisticas


    ' ---------------------------------------------- FUNCIONES/SUBS PARA CONFIGURAR VISTAS ----------------------------------------------


    Private Sub EduCADPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        de.CalcularPromediosPorCursoMateria(DGVTopPromedios)

        DGVTopPromedios.Refresh()

    End Sub


    ' ------------------------------------------------ SUBS DE CONTROL DEL FORMULARIO -------------------------------------------------


    ' Logica del boton Alumnos
    Private Sub Btn_Alumnos_Click(sender As Object, e As EventArgs) Handles Btn_Alumnos.Click
        Alumnos.Show()
        Me.Hide()

    End Sub


    ' Logicas del boton Estadisticas
    Private Sub Btn_Estadisticas_Click(sender As Object, e As EventArgs) Handles Btn_Estadisticas.Click
        Estadisticas.Show()
        Me.Hide()
    End Sub


    ' ------------------------------------- SUBS DE CONTROL DE BOTONES PRINCIPALES DEL FORMULARIO -------------------------------------


    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Application.Exit()
    End Sub

End Class