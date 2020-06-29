Imports System.ComponentModel
Public Class registrarse

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If TextBox4.Text = TextBox3.Text Then
            My.Settings.usuario = TextBox1.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.email = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.clave = TextBox3.Text
            My.Settings.Save()
            My.Settings.Reload()

            Label5.Visible = False
            Label6.Visible = True
            btnRegresar.Enabled = True
        Else
            Label5.Visible = True
            btnRegresar.Enabled = False
        End If

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub
    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As CancelEventArgs) Handles TextBox3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox4_Validating(sender As Object, e As CancelEventArgs) Handles TextBox4.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tmensaje.SetToolTip(TextBox1, "Ingrese su nombre de Usuario")
        tmensaje.ToolTipTitle = "Nombre de usuario"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        tmensaje.SetToolTip(TextBox2, "Ingrese su Email")
        tmensaje.ToolTipTitle = "Email"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles TextBox3.MouseHover
        tmensaje.SetToolTip(TextBox3, "Ingrese su contraseña")
        tmensaje.ToolTipTitle = "Contraseña"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox4_MouseHover(sender As Object, e As EventArgs) Handles TextBox4.MouseHover
        tmensaje.SetToolTip(TextBox4, "Confirma tu contraseña")
        tmensaje.ToolTipTitle = "Confirma tu contraseña"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub btnMinimizar_Click_1(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub pOcultar_Click(sender As Object, e As EventArgs) Handles pOcultar.Click
        TextBox3.PasswordChar = "*"
        pMostrar.Visible = True
        pOcultar.Visible = False
    End Sub

    Private Sub pictureBloquear_Click(sender As Object, e As EventArgs) Handles pictureBloquear.Click
        TextBox4.PasswordChar = "*"
        picturDesbloquear.Visible = True
        pictureBloquear.Visible = False
    End Sub

    Private Sub pMostrar_Click(sender As Object, e As EventArgs) Handles pMostrar.Click
        TextBox3.PasswordChar = ""
        pMostrar.Visible = False
        pOcultar.Visible = True
    End Sub

    Private Sub picturDesbloquear_Click(sender As Object, e As EventArgs) Handles picturDesbloquear.Click
        TextBox4.PasswordChar = ""
        picturDesbloquear.Visible = False
        pictureBloquear.Visible = True
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class