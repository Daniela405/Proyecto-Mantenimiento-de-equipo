Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class mantenimiento

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo de la PC")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtmarca_MouseHover(sender As Object, e As EventArgs) Handles txtmarca.MouseHover
        tmensaje.SetToolTip(txtmarca, "Ingrese la marca de la Pc")
        tmensaje.ToolTipTitle = "Marca"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtmodelo_MouseHover(sender As Object, e As EventArgs) Handles txtmodelo.MouseHover
        tmensaje.SetToolTip(txtmodelo, "Ingrese el modelo de la PC")
        tmensaje.ToolTipTitle = "Modelo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtserie_MouseHover(sender As Object, e As EventArgs) Handles txtserie.MouseHover
        tmensaje.SetToolTip(txtserie, "Ingrese la serie de la Pc")
        tmensaje.ToolTipTitle = "Serie"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtproblema_MouseHover(sender As Object, e As EventArgs) Handles txtproblema.MouseHover
        tmensaje.SetToolTip(txtproblema, "Ingrese el problema de la PC")
        tmensaje.ToolTipTitle = "Problema"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbestado_MouseHover(sender As Object, e As EventArgs) Handles cmbestado.MouseHover
        tmensaje.SetToolTip(cmbestado, "Seleccione el estado de la reparacion de la PC")
        tmensaje.ToolTipTitle = "Estado"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtreparacion_MouseHover(sender As Object, e As EventArgs) Handles txtreparacion.MouseHover
        tmensaje.SetToolTip(txtreparacion, "Ingrese la reparacion que se le hizo a la PC")
        tmensaje.ToolTipTitle = "Reparacion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnagregar_MouseHover(sender As Object, e As EventArgs) Handles btnagregar.MouseHover
        tmensaje.SetToolTip(btnagregar, "Click para agregar una nueva Pc")
        tmensaje.ToolTipTitle = "Agregar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub btnnuevo_MouseHover(sender As Object, e As EventArgs) Handles btnnuevo.MouseHover
        tmensaje.SetToolTip(btnnuevo, "Click para una nueva PC")
        tmensaje.ToolTipTitle = "Nuevo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtcodigoempleado_MouseHover(sender As Object, e As EventArgs) Handles txtcodigoempleado.MouseHover
        tmensaje.SetToolTip(txtcodigoempleado, "Ingrese el codigo del empleado")
        tmensaje.ToolTipTitle = "Codigo "
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombremepleado_MouseHover(sender As Object, e As EventArgs) Handles txtnombremepleado.MouseHover
        tmensaje.SetToolTip(txtnombremepleado, "Mostrara el nombre del empleado")
        tmensaje.ToolTipTitle = "Nombre Empleado"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub btnbuscar_MouseHover(sender As Object, e As EventArgs) Handles btnbuscar.MouseHover
        tmensaje.SetToolTip(btnbuscar, "Click para buscar una pc en el DataGridView")
        tmensaje.ToolTipTitle = "Buscar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub btndetalle_MouseHover(sender As Object, e As EventArgs) Handles btndetalle.MouseHover
        tmensaje.SetToolTip(btndetalle, "Dar click para ver el reporte")
        tmensaje.ToolTipTitle = "Reporte"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs) Handles btnmodificar.MouseHover
        tmensaje.SetToolTip(btnmodificar, "Dar click para modificar")
        tmensaje.ToolTipTitle = "Modificar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        tmensaje.SetToolTip(btnsalir, "Click para salir del Formulario")
        tmensaje.ToolTipTitle = "Salir"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtmarca_Validating(sender As Object, e As CancelEventArgs) Handles txtmarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtmodelo_Validating(sender As Object, e As CancelEventArgs) Handles txtmodelo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtserie_Validating(sender As Object, e As CancelEventArgs) Handles txtserie.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtproblema_Validating(sender As Object, e As CancelEventArgs) Handles txtproblema.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub txtreparacion_Validating(sender As Object, e As CancelEventArgs) Handles txtreparacion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub txtcodigoempleado_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigoempleado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


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

    Private Sub txtcodigoempleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoempleado.KeyPress
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

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        menus.Show()
        Me.Hide()
    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub
End Class