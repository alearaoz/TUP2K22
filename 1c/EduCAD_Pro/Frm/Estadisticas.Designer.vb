<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estadisticas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.DGVListadoEstadisticasAlumnos = New System.Windows.Forms.DataGridView()
        Me.gpBox_Lista = New System.Windows.Forms.GroupBox()
        Me.bpBox_Filtros = New System.Windows.Forms.GroupBox()
        Me.Lbl_filtroEstado = New System.Windows.Forms.Label()
        Me.Lbl_filtroMateria = New System.Windows.Forms.Label()
        Me.Lbl_filtroCurso = New System.Windows.Forms.Label()
        Me.combo_Econdicion = New System.Windows.Forms.ComboBox()
        Me.combo_Emateria = New System.Windows.Forms.ComboBox()
        Me.combo_Ecurso = New System.Windows.Forms.ComboBox()
        Me.Btn_AplicarFiltro = New System.Windows.Forms.Button()
        CType(Me.DGVListadoEstadisticasAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBox_Lista.SuspendLayout()
        Me.bpBox_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Location = New System.Drawing.Point(864, 473)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "VOLVER"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'DGVListadoEstadisticasAlumnos
        '
        Me.DGVListadoEstadisticasAlumnos.AllowUserToAddRows = False
        Me.DGVListadoEstadisticasAlumnos.AllowUserToDeleteRows = False
        Me.DGVListadoEstadisticasAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListadoEstadisticasAlumnos.Location = New System.Drawing.Point(21, 53)
        Me.DGVListadoEstadisticasAlumnos.Name = "DGVListadoEstadisticasAlumnos"
        Me.DGVListadoEstadisticasAlumnos.ReadOnly = True
        Me.DGVListadoEstadisticasAlumnos.Size = New System.Drawing.Size(691, 340)
        Me.DGVListadoEstadisticasAlumnos.TabIndex = 2
        '
        'gpBox_Lista
        '
        Me.gpBox_Lista.Controls.Add(Me.DGVListadoEstadisticasAlumnos)
        Me.gpBox_Lista.Location = New System.Drawing.Point(208, 51)
        Me.gpBox_Lista.Name = "gpBox_Lista"
        Me.gpBox_Lista.Size = New System.Drawing.Size(729, 416)
        Me.gpBox_Lista.TabIndex = 3
        Me.gpBox_Lista.TabStop = False
        Me.gpBox_Lista.Text = "Alumnos"
        '
        'bpBox_Filtros
        '
        Me.bpBox_Filtros.Controls.Add(Me.Lbl_filtroEstado)
        Me.bpBox_Filtros.Controls.Add(Me.Lbl_filtroMateria)
        Me.bpBox_Filtros.Controls.Add(Me.Lbl_filtroCurso)
        Me.bpBox_Filtros.Controls.Add(Me.combo_Econdicion)
        Me.bpBox_Filtros.Controls.Add(Me.combo_Emateria)
        Me.bpBox_Filtros.Controls.Add(Me.combo_Ecurso)
        Me.bpBox_Filtros.Location = New System.Drawing.Point(12, 51)
        Me.bpBox_Filtros.Name = "bpBox_Filtros"
        Me.bpBox_Filtros.Size = New System.Drawing.Size(190, 202)
        Me.bpBox_Filtros.TabIndex = 4
        Me.bpBox_Filtros.TabStop = False
        Me.bpBox_Filtros.Text = "Filtros"
        '
        'Lbl_filtroEstado
        '
        Me.Lbl_filtroEstado.AutoSize = True
        Me.Lbl_filtroEstado.Location = New System.Drawing.Point(19, 145)
        Me.Lbl_filtroEstado.Name = "Lbl_filtroEstado"
        Me.Lbl_filtroEstado.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_filtroEstado.TabIndex = 5
        Me.Lbl_filtroEstado.Text = "Condicion"
        '
        'Lbl_filtroMateria
        '
        Me.Lbl_filtroMateria.AutoSize = True
        Me.Lbl_filtroMateria.Location = New System.Drawing.Point(18, 93)
        Me.Lbl_filtroMateria.Name = "Lbl_filtroMateria"
        Me.Lbl_filtroMateria.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_filtroMateria.TabIndex = 4
        Me.Lbl_filtroMateria.Text = "Materia:"
        '
        'Lbl_filtroCurso
        '
        Me.Lbl_filtroCurso.AutoSize = True
        Me.Lbl_filtroCurso.Location = New System.Drawing.Point(18, 37)
        Me.Lbl_filtroCurso.Name = "Lbl_filtroCurso"
        Me.Lbl_filtroCurso.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_filtroCurso.TabIndex = 3
        Me.Lbl_filtroCurso.Text = "Curso"
        '
        'combo_Econdicion
        '
        Me.combo_Econdicion.FormattingEnabled = True
        Me.combo_Econdicion.Location = New System.Drawing.Point(22, 161)
        Me.combo_Econdicion.Name = "combo_Econdicion"
        Me.combo_Econdicion.Size = New System.Drawing.Size(134, 21)
        Me.combo_Econdicion.TabIndex = 2
        '
        'combo_Emateria
        '
        Me.combo_Emateria.FormattingEnabled = True
        Me.combo_Emateria.Location = New System.Drawing.Point(22, 109)
        Me.combo_Emateria.Name = "combo_Emateria"
        Me.combo_Emateria.Size = New System.Drawing.Size(134, 21)
        Me.combo_Emateria.TabIndex = 1
        '
        'combo_Ecurso
        '
        Me.combo_Ecurso.FormattingEnabled = True
        Me.combo_Ecurso.Location = New System.Drawing.Point(21, 53)
        Me.combo_Ecurso.Name = "combo_Ecurso"
        Me.combo_Ecurso.Size = New System.Drawing.Size(135, 21)
        Me.combo_Ecurso.TabIndex = 0
        '
        'Btn_AplicarFiltro
        '
        Me.Btn_AplicarFiltro.Location = New System.Drawing.Point(34, 271)
        Me.Btn_AplicarFiltro.Name = "Btn_AplicarFiltro"
        Me.Btn_AplicarFiltro.Size = New System.Drawing.Size(134, 23)
        Me.Btn_AplicarFiltro.TabIndex = 5
        Me.Btn_AplicarFiltro.Text = "Aplicar Filtros"
        Me.Btn_AplicarFiltro.UseVisualStyleBackColor = True
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 508)
        Me.Controls.Add(Me.Btn_AplicarFiltro)
        Me.Controls.Add(Me.bpBox_Filtros)
        Me.Controls.Add(Me.gpBox_Lista)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.DGVListadoEstadisticasAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBox_Lista.ResumeLayout(False)
        Me.bpBox_Filtros.ResumeLayout(False)
        Me.bpBox_Filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents DGVListadoEstadisticasAlumnos As DataGridView
    Friend WithEvents gpBox_Lista As GroupBox
    Friend WithEvents bpBox_Filtros As GroupBox
    Friend WithEvents Lbl_filtroEstado As Label
    Friend WithEvents Lbl_filtroMateria As Label
    Friend WithEvents Lbl_filtroCurso As Label
    Friend WithEvents combo_Econdicion As ComboBox
    Friend WithEvents combo_Emateria As ComboBox
    Friend WithEvents combo_Ecurso As ComboBox
    Friend WithEvents Btn_AplicarFiltro As Button
End Class
