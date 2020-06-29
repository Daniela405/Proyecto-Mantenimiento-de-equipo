Imports System.ComponentModel
Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox6.Text = My.Settings.usuario And TextBox5.Text = My.Settings.clave Then
            Me.Hide()
            Dim formwelcome As New Bienvenida()
            formwelcome.ShowDialog()
            menus.Show()
        Else
            MsgBox("No puede continuar")
            Label9.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub


    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub TextBox3_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub TextBox4_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox6_Validating(sender As Object, e As CancelEventArgs) Handles TextBox6.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub TextBox5_Validating(sender As Object, e As CancelEventArgs) Handles TextBox5.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        registrarse.Show()
        Me.Hide()
    End Sub


    Private Sub TextBox6_MouseHover(sender As Object, e As EventArgs) Handles TextBox6.MouseHover
        tmensaje.SetToolTip(TextBox6, "Ingrese su nombre de Usuario")
        tmensaje.ToolTipTitle = "Nombre de usuario"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub TextBox5_MouseHover(sender As Object, e As EventArgs) Handles TextBox5.MouseHover
        tmensaje.SetToolTip(TextBox5, "Ingrese su contraseña")
        tmensaje.ToolTipTitle = "Contraseña"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pictureBloqueado_Click(sender As Object, e As EventArgs) Handles pictureBloqueado.Click
        TextBox5.PasswordChar = "*"
        picturDesbloqueado.Visible = True
        pictureBloqueado.Visible = False
    End Sub

    Private Sub picturDesbloqueado_Click(sender As Object, e As EventArgs)
        TextBox5.PasswordChar = ""
        picturDesbloqueado.Visible = False
        pictureBloqueado.Visible = True
    End Sub

    Private Sub picturDesbloqueado_Click_1(sender As Object, e As EventArgs) Handles picturDesbloqueado.Click
        TextBox5.PasswordChar = ""
        picturDesbloqueado.Visible = False
        pictureBloqueado.Visible = True
    End Sub

End Class
