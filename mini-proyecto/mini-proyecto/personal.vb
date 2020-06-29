Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class personal


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


    Private Sub btnbuscar_MouseHover(sender As Object, e As EventArgs) Handles btnbuscar.MouseHover
        tmensaje.SetToolTip(btnbuscar, "Click para un buscar un campo en el DataGridView")
        tmensaje.ToolTipTitle = "Buscar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btndetalle_Click(sender As Object, e As EventArgs) Handles btndetalle.Click

    End Sub

    Private Sub btndetalle_MouseHover(sender As Object, e As EventArgs) Handles btndetalle.MouseHover
        tmensaje.SetToolTip(btndetalle, "Click para ir al detalle ")
        tmensaje.ToolTipTitle = "Detalle"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub

    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs) Handles btnmodificar.MouseHover
        tmensaje.SetToolTip(btnmodificar, "Click para modificar")
        tmensaje.ToolTipTitle = "Modificar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        menus.Show()
        Me.Hide()
    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        tmensaje.SetToolTip(btnsalir, "Click para salir del formulario ")
        tmensaje.ToolTipTitle = "Salir"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub
End Class