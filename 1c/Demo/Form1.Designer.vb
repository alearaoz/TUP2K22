<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Crear = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.TextBox_nroCliente = New System.Windows.Forms.TextBox()
        Me.TextBox_dniCliente = New System.Windows.Forms.TextBox()
        Me.TextBox_nombreCliente = New System.Windows.Forms.TextBox()
        Me.TextBox_apellidoCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Crear
        '
        Me.Btn_Crear.Location = New System.Drawing.Point(93, 114)
        Me.Btn_Crear.Name = "Btn_Crear"
        Me.Btn_Crear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Crear.TabIndex = 0
        Me.Btn_Crear.Text = "Crear"
        Me.Btn_Crear.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Location = New System.Drawing.Point(174, 114)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Modificar.TabIndex = 1
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(255, 114)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 2
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(382, 114)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 3
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'TextBox_nroCliente
        '
        Me.TextBox_nroCliente.Location = New System.Drawing.Point(12, 55)
        Me.TextBox_nroCliente.Name = "TextBox_nroCliente"
        Me.TextBox_nroCliente.Size = New System.Drawing.Size(80, 20)
        Me.TextBox_nroCliente.TabIndex = 4
        '
        'TextBox_dniCliente
        '
        Me.TextBox_dniCliente.Location = New System.Drawing.Point(105, 55)
        Me.TextBox_dniCliente.Name = "TextBox_dniCliente"
        Me.TextBox_dniCliente.Size = New System.Drawing.Size(80, 20)
        Me.TextBox_dniCliente.TabIndex = 5
        '
        'TextBox_nombreCliente
        '
        Me.TextBox_nombreCliente.Location = New System.Drawing.Point(201, 55)
        Me.TextBox_nombreCliente.Name = "TextBox_nombreCliente"
        Me.TextBox_nombreCliente.Size = New System.Drawing.Size(120, 20)
        Me.TextBox_nombreCliente.TabIndex = 6
        '
        'TextBox_apellidoCliente
        '
        Me.TextBox_apellidoCliente.Location = New System.Drawing.Point(337, 55)
        Me.TextBox_apellidoCliente.Name = "TextBox_apellidoCliente"
        Me.TextBox_apellidoCliente.Size = New System.Drawing.Size(120, 20)
        Me.TextBox_apellidoCliente.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nro de Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apellido"
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Location = New System.Drawing.Point(12, 114)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Buscar.TabIndex = 12
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 149)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_apellidoCliente)
        Me.Controls.Add(Me.TextBox_nombreCliente)
        Me.Controls.Add(Me.TextBox_dniCliente)
        Me.Controls.Add(Me.TextBox_nroCliente)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.Btn_Crear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Crear As Button
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents TextBox_nroCliente As TextBox
    Friend WithEvents TextBox_dniCliente As TextBox
    Friend WithEvents TextBox_nombreCliente As TextBox
    Friend WithEvents TextBox_apellidoCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Buscar As Button
End Class
