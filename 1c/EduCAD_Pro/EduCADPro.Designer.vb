<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EduCADPro
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Btn_Alumnos = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Estadisticas = New System.Windows.Forms.Button()
        Me.gpBox_SinCalificar = New System.Windows.Forms.GroupBox()
        Me.Lbl_totalAlumnosSinCalificar = New System.Windows.Forms.Label()
        Me.gpBox_Desaprobados = New System.Windows.Forms.GroupBox()
        Me.Lbl_totalAlumnosDesaprobados = New System.Windows.Forms.Label()
        Me.gpBox_Regulares = New System.Windows.Forms.GroupBox()
        Me.Lbl_totalAlumnosRegulares = New System.Windows.Forms.Label()
        Me.gpBox_Aprobados = New System.Windows.Forms.GroupBox()
        Me.Lbl_totalAlumnosAprobados = New System.Windows.Forms.Label()
        Me.DGVTopPromedios = New System.Windows.Forms.DataGridView()
        Me.gpBox_mejorPromedio = New System.Windows.Forms.GroupBox()
        Me.Lbl_cursoMejorPromedio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_mejorPromedio = New System.Windows.Forms.Label()
        Me.gpBox_Opciones = New System.Windows.Forms.GroupBox()
        Me.gpBox_SinCalificar.SuspendLayout()
        Me.gpBox_Desaprobados.SuspendLayout()
        Me.gpBox_Regulares.SuspendLayout()
        Me.gpBox_Aprobados.SuspendLayout()
        CType(Me.DGVTopPromedios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBox_mejorPromedio.SuspendLayout()
        Me.gpBox_Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Alumnos
        '
        Me.Btn_Alumnos.Location = New System.Drawing.Point(9, 34)
        Me.Btn_Alumnos.Name = "Btn_Alumnos"
        Me.Btn_Alumnos.Size = New System.Drawing.Size(120, 23)
        Me.Btn_Alumnos.TabIndex = 0
        Me.Btn_Alumnos.Text = "Alumnos"
        Me.Btn_Alumnos.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(737, 314)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 61)
        Me.Btn_Salir.TabIndex = 1
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Estadisticas
        '
        Me.Btn_Estadisticas.Location = New System.Drawing.Point(9, 63)
        Me.Btn_Estadisticas.Name = "Btn_Estadisticas"
        Me.Btn_Estadisticas.Size = New System.Drawing.Size(120, 23)
        Me.Btn_Estadisticas.TabIndex = 3
        Me.Btn_Estadisticas.Text = "Estadisticas"
        Me.Btn_Estadisticas.UseVisualStyleBackColor = True
        '
        'gpBox_SinCalificar
        '
        Me.gpBox_SinCalificar.Controls.Add(Me.Lbl_totalAlumnosSinCalificar)
        Me.gpBox_SinCalificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox_SinCalificar.ForeColor = System.Drawing.Color.DimGray
        Me.gpBox_SinCalificar.Location = New System.Drawing.Point(12, 314)
        Me.gpBox_SinCalificar.Name = "gpBox_SinCalificar"
        Me.gpBox_SinCalificar.Size = New System.Drawing.Size(145, 61)
        Me.gpBox_SinCalificar.TabIndex = 11
        Me.gpBox_SinCalificar.TabStop = False
        Me.gpBox_SinCalificar.Text = "Sin Calificar"
        '
        'Lbl_totalAlumnosSinCalificar
        '
        Me.Lbl_totalAlumnosSinCalificar.AutoSize = True
        Me.Lbl_totalAlumnosSinCalificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_totalAlumnosSinCalificar.Location = New System.Drawing.Point(67, 28)
        Me.Lbl_totalAlumnosSinCalificar.Name = "Lbl_totalAlumnosSinCalificar"
        Me.Lbl_totalAlumnosSinCalificar.Size = New System.Drawing.Size(49, 20)
        Me.Lbl_totalAlumnosSinCalificar.TabIndex = 2
        Me.Lbl_totalAlumnosSinCalificar.Text = "0000"
        '
        'gpBox_Desaprobados
        '
        Me.gpBox_Desaprobados.Controls.Add(Me.Lbl_totalAlumnosDesaprobados)
        Me.gpBox_Desaprobados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox_Desaprobados.ForeColor = System.Drawing.Color.DarkRed
        Me.gpBox_Desaprobados.Location = New System.Drawing.Point(493, 314)
        Me.gpBox_Desaprobados.Name = "gpBox_Desaprobados"
        Me.gpBox_Desaprobados.Size = New System.Drawing.Size(181, 61)
        Me.gpBox_Desaprobados.TabIndex = 10
        Me.gpBox_Desaprobados.TabStop = False
        Me.gpBox_Desaprobados.Text = "Desaprobados (1 a 3)"
        '
        'Lbl_totalAlumnosDesaprobados
        '
        Me.Lbl_totalAlumnosDesaprobados.AutoSize = True
        Me.Lbl_totalAlumnosDesaprobados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_totalAlumnosDesaprobados.Location = New System.Drawing.Point(114, 28)
        Me.Lbl_totalAlumnosDesaprobados.Name = "Lbl_totalAlumnosDesaprobados"
        Me.Lbl_totalAlumnosDesaprobados.Size = New System.Drawing.Size(49, 20)
        Me.Lbl_totalAlumnosDesaprobados.TabIndex = 2
        Me.Lbl_totalAlumnosDesaprobados.Text = "0000"
        '
        'gpBox_Regulares
        '
        Me.gpBox_Regulares.Controls.Add(Me.Lbl_totalAlumnosRegulares)
        Me.gpBox_Regulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox_Regulares.ForeColor = System.Drawing.Color.Chocolate
        Me.gpBox_Regulares.Location = New System.Drawing.Point(304, 314)
        Me.gpBox_Regulares.Name = "gpBox_Regulares"
        Me.gpBox_Regulares.Size = New System.Drawing.Size(183, 61)
        Me.gpBox_Regulares.TabIndex = 9
        Me.gpBox_Regulares.TabStop = False
        Me.gpBox_Regulares.Text = "Regulares (4 y 5)"
        '
        'Lbl_totalAlumnosRegulares
        '
        Me.Lbl_totalAlumnosRegulares.AutoSize = True
        Me.Lbl_totalAlumnosRegulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_totalAlumnosRegulares.Location = New System.Drawing.Point(119, 28)
        Me.Lbl_totalAlumnosRegulares.Name = "Lbl_totalAlumnosRegulares"
        Me.Lbl_totalAlumnosRegulares.Size = New System.Drawing.Size(49, 20)
        Me.Lbl_totalAlumnosRegulares.TabIndex = 2
        Me.Lbl_totalAlumnosRegulares.Text = "0000"
        '
        'gpBox_Aprobados
        '
        Me.gpBox_Aprobados.Controls.Add(Me.Lbl_totalAlumnosAprobados)
        Me.gpBox_Aprobados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox_Aprobados.ForeColor = System.Drawing.Color.Green
        Me.gpBox_Aprobados.Location = New System.Drawing.Point(163, 314)
        Me.gpBox_Aprobados.Name = "gpBox_Aprobados"
        Me.gpBox_Aprobados.Size = New System.Drawing.Size(135, 61)
        Me.gpBox_Aprobados.TabIndex = 8
        Me.gpBox_Aprobados.TabStop = False
        Me.gpBox_Aprobados.Text = "Aprobados (6+)"
        '
        'Lbl_totalAlumnosAprobados
        '
        Me.Lbl_totalAlumnosAprobados.AutoSize = True
        Me.Lbl_totalAlumnosAprobados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_totalAlumnosAprobados.Location = New System.Drawing.Point(69, 28)
        Me.Lbl_totalAlumnosAprobados.Name = "Lbl_totalAlumnosAprobados"
        Me.Lbl_totalAlumnosAprobados.Size = New System.Drawing.Size(49, 20)
        Me.Lbl_totalAlumnosAprobados.TabIndex = 2
        Me.Lbl_totalAlumnosAprobados.Text = "0000"
        '
        'DGVTopPromedios
        '
        Me.DGVTopPromedios.AllowUserToAddRows = False
        Me.DGVTopPromedios.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTopPromedios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVTopPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTopPromedios.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVTopPromedios.Location = New System.Drawing.Point(163, 12)
        Me.DGVTopPromedios.Name = "DGVTopPromedios"
        Me.DGVTopPromedios.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTopPromedios.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVTopPromedios.Size = New System.Drawing.Size(649, 285)
        Me.DGVTopPromedios.TabIndex = 7
        '
        'gpBox_mejorPromedio
        '
        Me.gpBox_mejorPromedio.Controls.Add(Me.Lbl_cursoMejorPromedio)
        Me.gpBox_mejorPromedio.Controls.Add(Me.Label2)
        Me.gpBox_mejorPromedio.Controls.Add(Me.Label1)
        Me.gpBox_mejorPromedio.Controls.Add(Me.Lbl_mejorPromedio)
        Me.gpBox_mejorPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox_mejorPromedio.ForeColor = System.Drawing.Color.Green
        Me.gpBox_mejorPromedio.Location = New System.Drawing.Point(12, 168)
        Me.gpBox_mejorPromedio.Name = "gpBox_mejorPromedio"
        Me.gpBox_mejorPromedio.Size = New System.Drawing.Size(145, 129)
        Me.gpBox_mejorPromedio.TabIndex = 12
        Me.gpBox_mejorPromedio.TabStop = False
        Me.gpBox_mejorPromedio.Text = "Mejor Promedio"
        '
        'Lbl_cursoMejorPromedio
        '
        Me.Lbl_cursoMejorPromedio.AutoSize = True
        Me.Lbl_cursoMejorPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cursoMejorPromedio.Location = New System.Drawing.Point(71, 26)
        Me.Lbl_cursoMejorPromedio.Name = "Lbl_cursoMejorPromedio"
        Me.Lbl_cursoMejorPromedio.Size = New System.Drawing.Size(49, 20)
        Me.Lbl_cursoMejorPromedio.TabIndex = 14
        Me.Lbl_cursoMejorPromedio.Text = "0000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Promedio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Curso"
        '
        'Lbl_mejorPromedio
        '
        Me.Lbl_mejorPromedio.AutoSize = True
        Me.Lbl_mejorPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mejorPromedio.Location = New System.Drawing.Point(90, 65)
        Me.Lbl_mejorPromedio.Name = "Lbl_mejorPromedio"
        Me.Lbl_mejorPromedio.Size = New System.Drawing.Size(49, 20)
        Me.Lbl_mejorPromedio.TabIndex = 2
        Me.Lbl_mejorPromedio.Text = "0000"
        '
        'gpBox_Opciones
        '
        Me.gpBox_Opciones.Controls.Add(Me.Btn_Estadisticas)
        Me.gpBox_Opciones.Controls.Add(Me.Btn_Alumnos)
        Me.gpBox_Opciones.Location = New System.Drawing.Point(12, 12)
        Me.gpBox_Opciones.Name = "gpBox_Opciones"
        Me.gpBox_Opciones.Size = New System.Drawing.Size(145, 103)
        Me.gpBox_Opciones.TabIndex = 13
        Me.gpBox_Opciones.TabStop = False
        Me.gpBox_Opciones.Text = "Opciones"
        '
        'EduCADPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 389)
        Me.Controls.Add(Me.gpBox_Opciones)
        Me.Controls.Add(Me.gpBox_mejorPromedio)
        Me.Controls.Add(Me.gpBox_SinCalificar)
        Me.Controls.Add(Me.gpBox_Desaprobados)
        Me.Controls.Add(Me.gpBox_Regulares)
        Me.Controls.Add(Me.gpBox_Aprobados)
        Me.Controls.Add(Me.DGVTopPromedios)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Name = "EduCADPro"
        Me.Text = "Panel de Control"
        Me.gpBox_SinCalificar.ResumeLayout(False)
        Me.gpBox_SinCalificar.PerformLayout()
        Me.gpBox_Desaprobados.ResumeLayout(False)
        Me.gpBox_Desaprobados.PerformLayout()
        Me.gpBox_Regulares.ResumeLayout(False)
        Me.gpBox_Regulares.PerformLayout()
        Me.gpBox_Aprobados.ResumeLayout(False)
        Me.gpBox_Aprobados.PerformLayout()
        CType(Me.DGVTopPromedios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBox_mejorPromedio.ResumeLayout(False)
        Me.gpBox_mejorPromedio.PerformLayout()
        Me.gpBox_Opciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Alumnos As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Estadisticas As Button
    Friend WithEvents gpBox_SinCalificar As GroupBox
    Friend WithEvents Lbl_totalAlumnosSinCalificar As Label
    Friend WithEvents gpBox_Desaprobados As GroupBox
    Friend WithEvents Lbl_totalAlumnosDesaprobados As Label
    Friend WithEvents gpBox_Regulares As GroupBox
    Friend WithEvents Lbl_totalAlumnosRegulares As Label
    Friend WithEvents gpBox_Aprobados As GroupBox
    Friend WithEvents Lbl_totalAlumnosAprobados As Label
    Friend WithEvents DGVTopPromedios As DataGridView
    Friend WithEvents gpBox_mejorPromedio As GroupBox
    Friend WithEvents Lbl_cursoMejorPromedio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_mejorPromedio As Label
    Friend WithEvents gpBox_Opciones As GroupBox
End Class
