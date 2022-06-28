<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumnos
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
        Me.components = New System.ComponentModel.Container()
        Me.DGVAlumnos = New System.Windows.Forms.DataGridView()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.tBox_legajo = New System.Windows.Forms.TextBox()
        Me.tBox_dni = New System.Windows.Forms.TextBox()
        Me.tBox_nombre = New System.Windows.Forms.TextBox()
        Me.tBox_apellido = New System.Windows.Forms.TextBox()
        Me.dTime_fnac = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_legajo = New System.Windows.Forms.Label()
        Me.Lbl_dni = New System.Windows.Forms.Label()
        Me.Lbl_apellido = New System.Windows.Forms.Label()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.Lbl_fechanac = New System.Windows.Forms.Label()
        Me.gp_datosalumno = New System.Windows.Forms.GroupBox()
        Me.Lbl_datosObligatorios = New System.Windows.Forms.Label()
        Me.Lbl_Bcurso = New System.Windows.Forms.Label()
        Me.combo_Bcurso = New System.Windows.Forms.ComboBox()
        Me.Lbl_curso = New System.Windows.Forms.Label()
        Me.combo_curso = New System.Windows.Forms.ComboBox()
        Me.DGVMaterias = New System.Windows.Forms.DataGridView()
        Me.ToolTip_Alumnos = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_materia = New System.Windows.Forms.ComboBox()
        Me.Lbl_materia = New System.Windows.Forms.Label()
        Me.tBox_nota_t3 = New System.Windows.Forms.TextBox()
        Me.tBox_nota_t1 = New System.Windows.Forms.TextBox()
        Me.Lbl_nota_t1 = New System.Windows.Forms.Label()
        Me.tBox_nota_t2 = New System.Windows.Forms.TextBox()
        Me.Lbl_nota_t2 = New System.Windows.Forms.Label()
        Me.Lbl_nota_t3 = New System.Windows.Forms.Label()
        Me.gpBox_promedio = New System.Windows.Forms.GroupBox()
        Me.Lbl_promedio = New System.Windows.Forms.Label()
        Me.Btn_CerrarNotas = New System.Windows.Forms.Button()
        Me.Btn_CancelarMateria = New System.Windows.Forms.Button()
        Me.Btn_ModificarMateria = New System.Windows.Forms.Button()
        Me.Btn_GuardarMateria = New System.Windows.Forms.Button()
        Me.Btn_AgregarMateria = New System.Windows.Forms.Button()
        Me.Btn_EliminarAlumno = New System.Windows.Forms.Button()
        Me.Btn_CancelarAlumno = New System.Windows.Forms.Button()
        Me.Btn_BuscarAlumno = New System.Windows.Forms.Button()
        Me.Btn_ModificarAlumno = New System.Windows.Forms.Button()
        Me.Btn_GuardarAlumno = New System.Windows.Forms.Button()
        Me.Btn_NuevoAlumno = New System.Windows.Forms.Button()
        CType(Me.DGVAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_datosalumno.SuspendLayout()
        CType(Me.DGVMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gpBox_promedio.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVAlumnos
        '
        Me.DGVAlumnos.AllowUserToAddRows = False
        Me.DGVAlumnos.AllowUserToDeleteRows = False
        Me.DGVAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAlumnos.Location = New System.Drawing.Point(387, 27)
        Me.DGVAlumnos.Name = "DGVAlumnos"
        Me.DGVAlumnos.ReadOnly = True
        Me.DGVAlumnos.Size = New System.Drawing.Size(512, 465)
        Me.DGVAlumnos.TabIndex = 0
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Location = New System.Drawing.Point(824, 498)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "VOLVER"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'tBox_legajo
        '
        Me.tBox_legajo.Location = New System.Drawing.Point(6, 43)
        Me.tBox_legajo.Name = "tBox_legajo"
        Me.tBox_legajo.Size = New System.Drawing.Size(79, 20)
        Me.tBox_legajo.TabIndex = 0
        '
        'tBox_dni
        '
        Me.tBox_dni.Location = New System.Drawing.Point(6, 95)
        Me.tBox_dni.Name = "tBox_dni"
        Me.tBox_dni.Size = New System.Drawing.Size(71, 20)
        Me.tBox_dni.TabIndex = 3
        '
        'tBox_nombre
        '
        Me.tBox_nombre.Location = New System.Drawing.Point(91, 43)
        Me.tBox_nombre.Name = "tBox_nombre"
        Me.tBox_nombre.Size = New System.Drawing.Size(119, 20)
        Me.tBox_nombre.TabIndex = 1
        '
        'tBox_apellido
        '
        Me.tBox_apellido.Location = New System.Drawing.Point(216, 43)
        Me.tBox_apellido.Name = "tBox_apellido"
        Me.tBox_apellido.Size = New System.Drawing.Size(147, 20)
        Me.tBox_apellido.TabIndex = 2
        '
        'dTime_fnac
        '
        Me.dTime_fnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTime_fnac.Location = New System.Drawing.Point(83, 95)
        Me.dTime_fnac.Name = "dTime_fnac"
        Me.dTime_fnac.Size = New System.Drawing.Size(84, 20)
        Me.dTime_fnac.TabIndex = 4
        '
        'Lbl_legajo
        '
        Me.Lbl_legajo.AutoSize = True
        Me.Lbl_legajo.Location = New System.Drawing.Point(2, 27)
        Me.Lbl_legajo.Name = "Lbl_legajo"
        Me.Lbl_legajo.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_legajo.TabIndex = 18
        Me.Lbl_legajo.Text = "Legajo:"
        '
        'Lbl_dni
        '
        Me.Lbl_dni.AutoSize = True
        Me.Lbl_dni.Location = New System.Drawing.Point(3, 79)
        Me.Lbl_dni.Name = "Lbl_dni"
        Me.Lbl_dni.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_dni.TabIndex = 19
        Me.Lbl_dni.Text = "DNI:"
        '
        'Lbl_apellido
        '
        Me.Lbl_apellido.AutoSize = True
        Me.Lbl_apellido.Location = New System.Drawing.Point(213, 27)
        Me.Lbl_apellido.Name = "Lbl_apellido"
        Me.Lbl_apellido.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_apellido.TabIndex = 20
        Me.Lbl_apellido.Text = "Apellidos:"
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Location = New System.Drawing.Point(88, 27)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_nombre.TabIndex = 21
        Me.Lbl_nombre.Text = "Nombres:"
        '
        'Lbl_fechanac
        '
        Me.Lbl_fechanac.AutoSize = True
        Me.Lbl_fechanac.Location = New System.Drawing.Point(82, 79)
        Me.Lbl_fechanac.Name = "Lbl_fechanac"
        Me.Lbl_fechanac.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_fechanac.TabIndex = 23
        Me.Lbl_fechanac.Text = "F Nacimiento:"
        '
        'gp_datosalumno
        '
        Me.gp_datosalumno.Controls.Add(Me.Lbl_datosObligatorios)
        Me.gp_datosalumno.Controls.Add(Me.Lbl_Bcurso)
        Me.gp_datosalumno.Controls.Add(Me.Lbl_legajo)
        Me.gp_datosalumno.Controls.Add(Me.combo_Bcurso)
        Me.gp_datosalumno.Controls.Add(Me.tBox_legajo)
        Me.gp_datosalumno.Controls.Add(Me.Lbl_fechanac)
        Me.gp_datosalumno.Controls.Add(Me.tBox_dni)
        Me.gp_datosalumno.Controls.Add(Me.tBox_nombre)
        Me.gp_datosalumno.Controls.Add(Me.Lbl_nombre)
        Me.gp_datosalumno.Controls.Add(Me.tBox_apellido)
        Me.gp_datosalumno.Controls.Add(Me.Lbl_apellido)
        Me.gp_datosalumno.Controls.Add(Me.dTime_fnac)
        Me.gp_datosalumno.Controls.Add(Me.Lbl_dni)
        Me.gp_datosalumno.Location = New System.Drawing.Point(12, 27)
        Me.gp_datosalumno.Name = "gp_datosalumno"
        Me.gp_datosalumno.Size = New System.Drawing.Size(369, 122)
        Me.gp_datosalumno.TabIndex = 30
        Me.gp_datosalumno.TabStop = False
        Me.gp_datosalumno.Text = "Datos del Alumno"
        '
        'Lbl_datosObligatorios
        '
        Me.Lbl_datosObligatorios.AutoSize = True
        Me.Lbl_datosObligatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_datosObligatorios.ForeColor = System.Drawing.Color.Red
        Me.Lbl_datosObligatorios.Location = New System.Drawing.Point(247, 98)
        Me.Lbl_datosObligatorios.Name = "Lbl_datosObligatorios"
        Me.Lbl_datosObligatorios.Size = New System.Drawing.Size(111, 13)
        Me.Lbl_datosObligatorios.TabIndex = 36
        Me.Lbl_datosObligatorios.Text = "Datos Obligatorios"
        Me.Lbl_datosObligatorios.Visible = False
        '
        'Lbl_Bcurso
        '
        Me.Lbl_Bcurso.AutoSize = True
        Me.Lbl_Bcurso.Location = New System.Drawing.Point(170, 80)
        Me.Lbl_Bcurso.Name = "Lbl_Bcurso"
        Me.Lbl_Bcurso.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Bcurso.TabIndex = 35
        Me.Lbl_Bcurso.Text = "Curso:"
        '
        'combo_Bcurso
        '
        Me.combo_Bcurso.FormattingEnabled = True
        Me.combo_Bcurso.Location = New System.Drawing.Point(173, 95)
        Me.combo_Bcurso.Name = "combo_Bcurso"
        Me.combo_Bcurso.Size = New System.Drawing.Size(68, 21)
        Me.combo_Bcurso.TabIndex = 34
        '
        'Lbl_curso
        '
        Me.Lbl_curso.AutoSize = True
        Me.Lbl_curso.Location = New System.Drawing.Point(7, 27)
        Me.Lbl_curso.Name = "Lbl_curso"
        Me.Lbl_curso.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_curso.TabIndex = 25
        Me.Lbl_curso.Text = "Curso:"
        '
        'combo_curso
        '
        Me.combo_curso.FormattingEnabled = True
        Me.combo_curso.Location = New System.Drawing.Point(10, 42)
        Me.combo_curso.Name = "combo_curso"
        Me.combo_curso.Size = New System.Drawing.Size(41, 21)
        Me.combo_curso.TabIndex = 5
        '
        'DGVMaterias
        '
        Me.DGVMaterias.AllowUserToAddRows = False
        Me.DGVMaterias.AllowUserToDeleteRows = False
        Me.DGVMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaterias.Location = New System.Drawing.Point(17, 317)
        Me.DGVMaterias.Name = "DGVMaterias"
        Me.DGVMaterias.ReadOnly = True
        Me.DGVMaterias.Size = New System.Drawing.Size(353, 175)
        Me.DGVMaterias.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_curso)
        Me.GroupBox1.Controls.Add(Me.combo_materia)
        Me.GroupBox1.Controls.Add(Me.combo_curso)
        Me.GroupBox1.Controls.Add(Me.Lbl_materia)
        Me.GroupBox1.Controls.Add(Me.tBox_nota_t3)
        Me.GroupBox1.Controls.Add(Me.tBox_nota_t1)
        Me.GroupBox1.Controls.Add(Me.Lbl_nota_t1)
        Me.GroupBox1.Controls.Add(Me.tBox_nota_t2)
        Me.GroupBox1.Controls.Add(Me.Lbl_nota_t2)
        Me.GroupBox1.Controls.Add(Me.Lbl_nota_t3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 79)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Libro de Alumnos"
        '
        'combo_materia
        '
        Me.combo_materia.FormattingEnabled = True
        Me.combo_materia.Location = New System.Drawing.Point(57, 42)
        Me.combo_materia.Name = "combo_materia"
        Me.combo_materia.Size = New System.Drawing.Size(89, 21)
        Me.combo_materia.TabIndex = 33
        '
        'Lbl_materia
        '
        Me.Lbl_materia.AutoSize = True
        Me.Lbl_materia.Location = New System.Drawing.Point(54, 26)
        Me.Lbl_materia.Name = "Lbl_materia"
        Me.Lbl_materia.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_materia.TabIndex = 18
        Me.Lbl_materia.Text = "Materia:"
        '
        'tBox_nota_t3
        '
        Me.tBox_nota_t3.Location = New System.Drawing.Point(295, 43)
        Me.tBox_nota_t3.Name = "tBox_nota_t3"
        Me.tBox_nota_t3.Size = New System.Drawing.Size(66, 20)
        Me.tBox_nota_t3.TabIndex = 3
        '
        'tBox_nota_t1
        '
        Me.tBox_nota_t1.Location = New System.Drawing.Point(152, 43)
        Me.tBox_nota_t1.Name = "tBox_nota_t1"
        Me.tBox_nota_t1.Size = New System.Drawing.Size(66, 20)
        Me.tBox_nota_t1.TabIndex = 1
        '
        'Lbl_nota_t1
        '
        Me.Lbl_nota_t1.AutoSize = True
        Me.Lbl_nota_t1.Location = New System.Drawing.Point(149, 27)
        Me.Lbl_nota_t1.Name = "Lbl_nota_t1"
        Me.Lbl_nota_t1.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_nota_t1.TabIndex = 21
        Me.Lbl_nota_t1.Text = "1° Trimestre:"
        '
        'tBox_nota_t2
        '
        Me.tBox_nota_t2.Location = New System.Drawing.Point(224, 43)
        Me.tBox_nota_t2.Name = "tBox_nota_t2"
        Me.tBox_nota_t2.Size = New System.Drawing.Size(66, 20)
        Me.tBox_nota_t2.TabIndex = 2
        '
        'Lbl_nota_t2
        '
        Me.Lbl_nota_t2.AutoSize = True
        Me.Lbl_nota_t2.Location = New System.Drawing.Point(221, 27)
        Me.Lbl_nota_t2.Name = "Lbl_nota_t2"
        Me.Lbl_nota_t2.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_nota_t2.TabIndex = 20
        Me.Lbl_nota_t2.Text = "2° Trimestre:"
        '
        'Lbl_nota_t3
        '
        Me.Lbl_nota_t3.AutoSize = True
        Me.Lbl_nota_t3.Location = New System.Drawing.Point(292, 27)
        Me.Lbl_nota_t3.Name = "Lbl_nota_t3"
        Me.Lbl_nota_t3.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_nota_t3.TabIndex = 19
        Me.Lbl_nota_t3.Text = "3° Trimestre:"
        '
        'gpBox_promedio
        '
        Me.gpBox_promedio.Controls.Add(Me.Lbl_promedio)
        Me.gpBox_promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox_promedio.Location = New System.Drawing.Point(14, 268)
        Me.gpBox_promedio.Name = "gpBox_promedio"
        Me.gpBox_promedio.Size = New System.Drawing.Size(185, 43)
        Me.gpBox_promedio.TabIndex = 38
        Me.gpBox_promedio.TabStop = False
        Me.gpBox_promedio.Text = "Promedio"
        '
        'Lbl_promedio
        '
        Me.Lbl_promedio.AutoSize = True
        Me.Lbl_promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_promedio.Location = New System.Drawing.Point(72, 16)
        Me.Lbl_promedio.Name = "Lbl_promedio"
        Me.Lbl_promedio.Size = New System.Drawing.Size(107, 17)
        Me.Lbl_promedio.TabIndex = 0
        Me.Lbl_promedio.Text = "No disponible"
        '
        'Btn_CerrarNotas
        '
        Me.Btn_CerrarNotas.Image = Global.EduCAD_Pro.My.Resources.Resources.FolderClosedLightBlue
        Me.Btn_CerrarNotas.Location = New System.Drawing.Point(342, 278)
        Me.Btn_CerrarNotas.Name = "Btn_CerrarNotas"
        Me.Btn_CerrarNotas.Size = New System.Drawing.Size(28, 28)
        Me.Btn_CerrarNotas.TabIndex = 35
        Me.Btn_CerrarNotas.UseVisualStyleBackColor = True
        '
        'Btn_CancelarMateria
        '
        Me.Btn_CancelarMateria.Image = Global.EduCAD_Pro.My.Resources.Resources.Cancel
        Me.Btn_CancelarMateria.Location = New System.Drawing.Point(308, 278)
        Me.Btn_CancelarMateria.Name = "Btn_CancelarMateria"
        Me.Btn_CancelarMateria.Size = New System.Drawing.Size(28, 28)
        Me.Btn_CancelarMateria.TabIndex = 37
        Me.Btn_CancelarMateria.UseVisualStyleBackColor = True
        '
        'Btn_ModificarMateria
        '
        Me.Btn_ModificarMateria.Image = Global.EduCAD_Pro.My.Resources.Resources.EditNotebook
        Me.Btn_ModificarMateria.Location = New System.Drawing.Point(240, 278)
        Me.Btn_ModificarMateria.Name = "Btn_ModificarMateria"
        Me.Btn_ModificarMateria.Size = New System.Drawing.Size(28, 28)
        Me.Btn_ModificarMateria.TabIndex = 34
        Me.Btn_ModificarMateria.UseVisualStyleBackColor = True
        '
        'Btn_GuardarMateria
        '
        Me.Btn_GuardarMateria.Image = Global.EduCAD_Pro.My.Resources.Resources.Save
        Me.Btn_GuardarMateria.Location = New System.Drawing.Point(274, 278)
        Me.Btn_GuardarMateria.Name = "Btn_GuardarMateria"
        Me.Btn_GuardarMateria.Size = New System.Drawing.Size(28, 28)
        Me.Btn_GuardarMateria.TabIndex = 36
        Me.Btn_GuardarMateria.UseVisualStyleBackColor = True
        '
        'Btn_AgregarMateria
        '
        Me.Btn_AgregarMateria.Image = Global.EduCAD_Pro.My.Resources.Resources.AddEvent
        Me.Btn_AgregarMateria.Location = New System.Drawing.Point(206, 278)
        Me.Btn_AgregarMateria.Name = "Btn_AgregarMateria"
        Me.Btn_AgregarMateria.Size = New System.Drawing.Size(28, 28)
        Me.Btn_AgregarMateria.TabIndex = 33
        Me.Btn_AgregarMateria.UseVisualStyleBackColor = True
        '
        'Btn_EliminarAlumno
        '
        Me.Btn_EliminarAlumno.Image = Global.EduCAD_Pro.My.Resources.Resources.Delete
        Me.Btn_EliminarAlumno.Location = New System.Drawing.Point(342, 150)
        Me.Btn_EliminarAlumno.Name = "Btn_EliminarAlumno"
        Me.Btn_EliminarAlumno.Size = New System.Drawing.Size(28, 28)
        Me.Btn_EliminarAlumno.TabIndex = 8
        Me.Btn_EliminarAlumno.UseVisualStyleBackColor = True
        '
        'Btn_CancelarAlumno
        '
        Me.Btn_CancelarAlumno.Image = Global.EduCAD_Pro.My.Resources.Resources.Cancel
        Me.Btn_CancelarAlumno.Location = New System.Drawing.Point(308, 150)
        Me.Btn_CancelarAlumno.Name = "Btn_CancelarAlumno"
        Me.Btn_CancelarAlumno.Size = New System.Drawing.Size(28, 28)
        Me.Btn_CancelarAlumno.TabIndex = 27
        Me.Btn_CancelarAlumno.UseVisualStyleBackColor = True
        '
        'Btn_BuscarAlumno
        '
        Me.Btn_BuscarAlumno.Image = Global.EduCAD_Pro.My.Resources.Resources.Search
        Me.Btn_BuscarAlumno.Location = New System.Drawing.Point(172, 150)
        Me.Btn_BuscarAlumno.Name = "Btn_BuscarAlumno"
        Me.Btn_BuscarAlumno.Size = New System.Drawing.Size(28, 28)
        Me.Btn_BuscarAlumno.TabIndex = 32
        Me.Btn_BuscarAlumno.UseVisualStyleBackColor = True
        '
        'Btn_ModificarAlumno
        '
        Me.Btn_ModificarAlumno.Image = Global.EduCAD_Pro.My.Resources.Resources.Edit
        Me.Btn_ModificarAlumno.Location = New System.Drawing.Point(240, 150)
        Me.Btn_ModificarAlumno.Name = "Btn_ModificarAlumno"
        Me.Btn_ModificarAlumno.Size = New System.Drawing.Size(28, 28)
        Me.Btn_ModificarAlumno.TabIndex = 7
        Me.Btn_ModificarAlumno.UseVisualStyleBackColor = True
        '
        'Btn_GuardarAlumno
        '
        Me.Btn_GuardarAlumno.Image = Global.EduCAD_Pro.My.Resources.Resources.Save
        Me.Btn_GuardarAlumno.Location = New System.Drawing.Point(274, 150)
        Me.Btn_GuardarAlumno.Name = "Btn_GuardarAlumno"
        Me.Btn_GuardarAlumno.Size = New System.Drawing.Size(28, 28)
        Me.Btn_GuardarAlumno.TabIndex = 26
        Me.Btn_GuardarAlumno.UseVisualStyleBackColor = True
        '
        'Btn_NuevoAlumno
        '
        Me.Btn_NuevoAlumno.Image = Global.EduCAD_Pro.My.Resources.Resources.AddUser
        Me.Btn_NuevoAlumno.Location = New System.Drawing.Point(206, 150)
        Me.Btn_NuevoAlumno.Name = "Btn_NuevoAlumno"
        Me.Btn_NuevoAlumno.Size = New System.Drawing.Size(28, 28)
        Me.Btn_NuevoAlumno.TabIndex = 6
        Me.Btn_NuevoAlumno.UseVisualStyleBackColor = True
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 533)
        Me.Controls.Add(Me.gpBox_promedio)
        Me.Controls.Add(Me.Btn_CerrarNotas)
        Me.Controls.Add(Me.Btn_CancelarMateria)
        Me.Controls.Add(Me.Btn_ModificarMateria)
        Me.Controls.Add(Me.Btn_GuardarMateria)
        Me.Controls.Add(Me.Btn_AgregarMateria)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_EliminarAlumno)
        Me.Controls.Add(Me.Btn_CancelarAlumno)
        Me.Controls.Add(Me.Btn_BuscarAlumno)
        Me.Controls.Add(Me.Btn_ModificarAlumno)
        Me.Controls.Add(Me.Btn_GuardarAlumno)
        Me.Controls.Add(Me.Btn_NuevoAlumno)
        Me.Controls.Add(Me.DGVMaterias)
        Me.Controls.Add(Me.gp_datosalumno)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.DGVAlumnos)
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        CType(Me.DGVAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_datosalumno.ResumeLayout(False)
        Me.gp_datosalumno.PerformLayout()
        CType(Me.DGVMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpBox_promedio.ResumeLayout(False)
        Me.gpBox_promedio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVAlumnos As DataGridView
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents tBox_legajo As TextBox
    Friend WithEvents tBox_dni As TextBox
    Friend WithEvents tBox_nombre As TextBox
    Friend WithEvents tBox_apellido As TextBox
    Friend WithEvents dTime_fnac As DateTimePicker
    Friend WithEvents Lbl_legajo As Label
    Friend WithEvents Lbl_dni As Label
    Friend WithEvents Lbl_apellido As Label
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents Lbl_fechanac As Label
    Friend WithEvents gp_datosalumno As GroupBox
    Friend WithEvents Lbl_curso As Label
    Friend WithEvents combo_curso As ComboBox
    Friend WithEvents DGVMaterias As DataGridView
    Friend WithEvents Btn_NuevoAlumno As Button
    Friend WithEvents Btn_ModificarAlumno As Button
    Friend WithEvents Btn_EliminarAlumno As Button
    Friend WithEvents Btn_BuscarAlumno As Button
    Friend WithEvents Btn_GuardarAlumno As Button
    Friend WithEvents Btn_CancelarAlumno As Button
    Friend WithEvents ToolTip_Alumnos As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lbl_materia As Label
    Friend WithEvents tBox_nota_t3 As TextBox
    Friend WithEvents tBox_nota_t1 As TextBox
    Friend WithEvents Lbl_nota_t1 As Label
    Friend WithEvents tBox_nota_t2 As TextBox
    Friend WithEvents Lbl_nota_t2 As Label
    Friend WithEvents Lbl_nota_t3 As Label
    Friend WithEvents combo_materia As ComboBox
    Friend WithEvents Btn_CerrarNotas As Button
    Friend WithEvents Btn_CancelarMateria As Button
    Friend WithEvents Btn_ModificarMateria As Button
    Friend WithEvents Btn_GuardarMateria As Button
    Friend WithEvents Btn_AgregarMateria As Button
    Friend WithEvents Lbl_Bcurso As Label
    Friend WithEvents combo_Bcurso As ComboBox
    Friend WithEvents Lbl_datosObligatorios As Label
    Friend WithEvents gpBox_promedio As GroupBox
    Friend WithEvents Lbl_promedio As Label
End Class
