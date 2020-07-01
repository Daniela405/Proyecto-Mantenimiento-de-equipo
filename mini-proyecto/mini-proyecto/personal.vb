
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class personal
    Dim conexion As conexion = New conexion()
    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodigopc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigopc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsexo_TextChanged(sender As Object, e As EventArgs) Handles txtsexo.TextChanged

    End Sub

    Private Sub txtsexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsexo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtsexo_Validating(sender As Object, e As CancelEventArgs) Handles txtsexo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtpuesto_Validating(sender As Object, e As CancelEventArgs) Handles txtpuesto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtcodigopc_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigopc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        tmensaje.SetToolTip(txtnombre, "Ingrese su nombre")
        tmensaje.ToolTipTitle = "Nombre"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs) Handles txtdireccion.TextChanged

    End Sub

    Private Sub txtdireccion_MouseHover(sender As Object, e As EventArgs) Handles txtdireccion.MouseHover
        tmensaje.SetToolTip(txtdireccion, "Ingrese su direccion")
        tmensaje.ToolTipTitle = "Direccion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        tmensaje.SetToolTip(txtedad, "Ingrese su edad ")
        tmensaje.ToolTipTitle = "Edad"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtsexo_MouseHover(sender As Object, e As EventArgs) Handles txtsexo.MouseHover
        tmensaje.SetToolTip(txtsexo, "Ingrese su sexo ")
        tmensaje.ToolTipTitle = "Sexo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtpuesto_TextChanged(sender As Object, e As EventArgs) Handles txtpuesto.TextChanged

    End Sub

    Private Sub txtpuesto_MouseHover(sender As Object, e As EventArgs) Handles txtpuesto.MouseHover
        tmensaje.SetToolTip(txtpuesto, "Ingrese su puesto dentro de la empresa ")
        tmensaje.ToolTipTitle = "Puesto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtcodigopc_MouseHover(sender As Object, e As EventArgs) Handles txtcodigopc.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo de la PC")
        tmensaje.ToolTipTitle = "Codigo PC"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click


        Dim agregar As String = "insert into persona  values ('" + txtcodigo.Text + "','" + MaskedTextBox1.Text + "','" + txtnombre.Text + "','" + txtdireccion.Text + "','" + txtedad.Text + "','" + txtsexo.Text + "','" + txtpuesto.Text + "','" + txtcodigopc.Text + "')"

        If (conexion.insertar(agregar)) Then
            MessageBox.Show("Datos Agregados Correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al agregar")

        End If





    End Sub

    Private Sub btnagregar_MouseHover(sender As Object, e As EventArgs) Handles btnagregar.MouseHover
        tmensaje.SetToolTip(btnagregar, "Click para agregar una nueva PC ")
        tmensaje.ToolTipTitle = "Agregar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnnuevo_MouseHover(sender As Object, e As EventArgs) Handles btnnuevo.MouseHover
        tmensaje.SetToolTip(btnnuevo, "Click para un nuevo PC ")
        tmensaje.ToolTipTitle = "Nuevo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

    End Sub

    Private Sub btnbuscar_MouseHover(sender As Object, e As EventArgs) Handles btnbuscar.MouseHover
        tmensaje.SetToolTip(btnbuscar, "Click para un buscar un campo en el DataGridView")
        tmensaje.ToolTipTitle = "Buscar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btndetalle_Click(sender As Object, e As EventArgs) Handles btndetalle.Click
        reportepersonal.ShowDialog()

    End Sub

    Private Sub btndetalle_MouseHover(sender As Object, e As EventArgs) Handles btndetalle.MouseHover
        tmensaje.SetToolTip(btndetalle, "Click para ir al detalle ")
        tmensaje.ToolTipTitle = "Detalle"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim actualizar As String = "idempleado= '" + MaskedTextBox1.Text + "' ,nombre='" + txtnombre.Text + "', direccion='" + txtdireccion.Text + "',edad='" + txtedad.Text + "',sexo='" + txtsexo.Text + "',puesto='" + txtpuesto.Text + "',codigopc='" + txtcodigopc.Text + "'"
        'If (conexion.actualizar("persona", actualizar, "codigo=" + txtcodigo.Text)) Then
        '    MessageBox.Show("datos actualizados correctamente")
        '    mostrardatos()
        'Else
        '    MessageBox.Show("error al actualizar")

        'End If
    End Sub

    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs) Handles btnmodificar.MouseHover
        tmensaje.SetToolTip(btnmodificar, "Click para modificar")
        tmensaje.ToolTipTitle = "Modificar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        tmensaje.SetToolTip(btnsalir, "Click para salir del formulario ")
        tmensaje.ToolTipTitle = "Salir"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtcodigo.Text = dgv.Cells(0).Value.ToString()
        MaskedTextBox1.Text = dgv.Cells(1).Value.ToString()
        txtnombre.Text = dgv.Cells(2).Value.ToString()
        txtdireccion.Text = dgv.Cells(3).Value.ToString()
        txtedad.Text = dgv.Cells(4).Value.ToString()
        txtsexo.Text = dgv.Cells(5).Value.ToString()
        txtpuesto.Text = dgv.Cells(6).Value.ToString()
        txtcodigopc.Text = dgv.Cells(7).Value.ToString()

    End Sub

    Private Sub personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()

        mostrardatos()

    End Sub
    Public Sub mostrardatos()
        conexion.consulta("select * from persona", "persona")

        DataGridView1.DataSource = conexion.ds.Tables("persona")

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (conexion.eliminar("persona", "codigo = " + txtcodigo.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub
End Class