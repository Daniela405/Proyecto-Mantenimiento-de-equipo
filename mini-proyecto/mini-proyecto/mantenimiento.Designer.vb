<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mantenimiento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndetalle = New System.Windows.Forms.Button()
        Me.txtnombremepleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoempleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.txtreparacion = New System.Windows.Forms.TextBox()
        Me.txtproblema = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.tmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btndetalle)
        Me.GroupBox1.Controls.Add(Me.txtnombremepleado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigoempleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(515, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 522)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Equipo"
        '
        'btndetalle
        '
        Me.btndetalle.BackColor = System.Drawing.Color.Gray
        Me.btndetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndetalle.Location = New System.Drawing.Point(255, 368)
        Me.btndetalle.Name = "btndetalle"
        Me.btndetalle.Size = New System.Drawing.Size(181, 38)
        Me.btndetalle.TabIndex = 8
        Me.btndetalle.Text = "Ver detalle"
        Me.btndetalle.UseVisualStyleBackColor = False
        '
        'txtnombremepleado
        '
        Me.txtnombremepleado.Location = New System.Drawing.Point(619, 45)
        Me.txtnombremepleado.Name = "txtnombremepleado"
        Me.txtnombremepleado.Size = New System.Drawing.Size(122, 30)
        Me.txtnombremepleado.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(407, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Empleado"
        '
        'txtcodigoempleado
        '
        Me.txtcodigoempleado.Location = New System.Drawing.Point(268, 45)
        Me.txtcodigoempleado.Name = "txtcodigoempleado"
        Me.txtcodigoempleado.Size = New System.Drawing.Size(122, 30)
        Me.txtcodigoempleado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código Empleado"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(698, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Controls.Add(Me.btnagregar)
        Me.GroupBox2.Controls.Add(Me.btnmodificar)
        Me.GroupBox2.Controls.Add(Me.cmbestado)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.dt1)
        Me.GroupBox2.Controls.Add(Me.txtreparacion)
        Me.GroupBox2.Controls.Add(Me.txtproblema)
        Me.GroupBox2.Controls.Add(Me.txtmodelo)
        Me.GroupBox2.Controls.Add(Me.txtserie)
        Me.GroupBox2.Controls.Add(Me.txtmarca)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 550)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso equipo al almacen"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Gray
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnnuevo.Location = New System.Drawing.Point(237, 434)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(116, 38)
        Me.btnnuevo.TabIndex = 17
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.Gray
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnagregar.Location = New System.Drawing.Point(99, 434)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(116, 38)
        Me.btnagregar.TabIndex = 16
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.Gray
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificar.Location = New System.Drawing.Point(316, 481)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(108, 38)
        Me.btnmodificar.TabIndex = 6
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'cmbestado
        '
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Mantenimiento Preventivo ", "Mantenimiento Correctivo"})
        Me.cmbestado.Location = New System.Drawing.Point(200, 282)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(200, 33)
        Me.cmbestado.TabIndex = 15
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Gray
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(35, 485)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(100, 38)
        Me.btnbuscar.TabIndex = 5
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(200, 328)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(200, 30)
        Me.dt1.TabIndex = 14
        '
        'txtreparacion
        '
        Me.txtreparacion.Location = New System.Drawing.Point(200, 363)
        Me.txtreparacion.Name = "txtreparacion"
        Me.txtreparacion.Size = New System.Drawing.Size(200, 30)
        Me.txtreparacion.TabIndex = 13
        '
        'txtproblema
        '
        Me.txtproblema.Location = New System.Drawing.Point(200, 238)
        Me.txtproblema.Name = "txtproblema"
        Me.txtproblema.Size = New System.Drawing.Size(200, 30)
        Me.txtproblema.TabIndex = 12
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(200, 151)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(200, 30)
        Me.txtmodelo.TabIndex = 11
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(200, 194)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(200, 30)
        Me.txtserie.TabIndex = 10
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(200, 109)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(200, 30)
        Me.txtmarca.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 369)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Reparación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Fecha Ingreso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Problema"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Marca"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(200, 55)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(200, 30)
        Me.txtcodigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Gray
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Location = New System.Drawing.Point(1118, 550)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(108, 38)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1418, 634)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mantenimiento"
        Me.Text = "Mantenimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndetalle As Button
    Friend WithEvents txtnombremepleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigoempleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents txtreparacion As TextBox
    Friend WithEvents txtproblema As TextBox
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents tmensaje As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
End Class
