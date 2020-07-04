Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class mantenimiento
    Dim antigua, actual As String

    Dim conexion As conexion = New conexion()
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

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        actual = (mskFecha.Text)
        Dim random As New Random()
        Dim opcion As Integer = random.Next(1, 10)

        If Mid(antigua, 4, 2) = Mid(actual, 4, 2) Then
            MsgBox("HAS TRAIDO LA PC DOS VECES EN MENOS DE UN MES", vbInformation)

            Select Case opcion
                Case 1
                    MsgBox("Recuerda no descargar software de dudosa procedencia ", vbInformation)

                Case 2
                    MsgBox("Recuerda no sobre cargar la computadora para evitar daños a la bateria", vbInformation)
                Case 3
                    MsgBox("Evita golpes a la computadora ", vbInformation)

                Case 4
                    MsgBox("Recuerda actualizar el antivirus", vbInformation)
                Case 5
                    MsgBox("Evita tener alimentos y bebidad cerca del equipo ", vbInformation)

                Case 6
                    MsgBox("Elimina los archivos temporales de la memoria ram para mayor rendimiento", vbInformation)
                Case 7
                    MsgBox("No utilices perifericos que no sean apropiados para el equipo", vbInformation)

                Case 8
                    MsgBox("Recuerda No Descargar video juegos que la computadora no pueda soportar", vbInformation)
                Case 9
                    MsgBox("Ten cuidado al desenchufar el cargador d la laptop ", vbInformation)


                Case 10
                    MsgBox("Al llegar al 100% la bateria desconecta el cargador cuidadosamente ", vbInformation)

            End Select
        Else

        End If

        If txtcodigoempleado.Text = "" Then
            MessageBox.Show("Por favor Realice una busqueda por codigo de empleado para poder modificar")

        Else
            Dim actualizar As String = "marca= '" + txtmarca.Text + "' ,modelo='" + txtmodelo.Text + "', serie='" + txtserie.Text + "',problema='" + txtproblema.Text + "',estado='" + cmbestado.Text + "',fechaingreso'" + mskFecha.Text + "',reparacion='" + txtreparacion.Text + "')"
                    Dim sql As String = String.Format("update pc set  marca='{0}', modelo='{1}', serie='{2}', problema='{3}', [estado]='{4}', [fechaingreso]='{5}', 
[reparacion]='{6}', [codigoempleado]={7} where codigo={8}", txtmarca.Text, txtmodelo.Text, txtserie.Text, txtproblema.Text, cmbestado.SelectedText, mskFecha.Text, txtreparacion.Text, txtcodigoempleado.Text, txtcodigo.Text)
            If (conexion.actualizar(sql)) Then
                MessageBox.Show("datos actualizados correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al actualizar")

            End If
        End If


    End Sub

    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs) Handles btnmodificar.MouseHover
        tmensaje.SetToolTip(btnmodificar, "Click para modificar")
        tmensaje.ToolTipTitle = "Modificar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            menus.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        tmensaje.SetToolTip(btnsalir, "Click para salir del formulario ")
        tmensaje.ToolTipTitle = "Salir"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()




    End Sub
    Public Sub mostrardatos()
        conexion.consulta("select * from pc", "pc")

        DataGridView1.DataSource = conexion.ds.Tables("pc")

    End Sub
    Public Sub mostrarnombre(ByVal condicion)
        conexion.consulta("Select nombre from persona " + "where" + condicion, "persona")
        txtnombremepleado.Text = conexion.ds.Tables("persona").Rows(0)(0)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (conexion.eliminar("pc", "codigo = " + txtcodigo.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        Try
            Dim agregar As String = "insert into pc  values ('" + txtcodigo.Text + "','" + txtmarca.Text + "','" + txtmodelo.Text + "','" + txtserie.Text + "','" + txtproblema.Text + "','" + cmbestado.SelectedItem + "','" + mskFecha.Text + "','" + txtreparacion.Text + "','" + txtcodi.Text + "')"

            If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al agregar")

            End If
        Catch ex As Exception
            MessageBox.Show("Registro existente")
        End Try




    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtcodigo.Text = dgv.Cells(0).Value.ToString()
        txtmarca.Text = dgv.Cells(1).Value.ToString()
        txtmodelo.Text = dgv.Cells(2).Value.ToString()
        txtserie.Text = dgv.Cells(3).Value.ToString()
        txtproblema.Text = dgv.Cells(4).Value.ToString()
        cmbestado.Text = dgv.Cells(5).Value.ToString()
        mskFecha.Text = dgv.Cells(6).Value.ToString()
        txtreparacion.Text = dgv.Cells(7).Value.ToString()
        txtcodi.Text = dgv.Cells(8).Value.ToString()

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            txtcodi.Enabled = False
            Dim conexion As String
            conexion = "data source =DESKTOP-HT00A5J \ SQLEXPRESS;initial catalog=mantenimiento;integrated security =true"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlDataAdapter("select * from pc where codigoempleado=" & txtcodigoempleado.Text & " ", cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")
            If ds.Tables("datos").Rows.Count > 0 Then
                txtcodigo.Text = ds.Tables("datos").Rows(0).Item(0).ToString
                txtmarca.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtmodelo.Text = ds.Tables("datos").Rows(0).Item(2).ToString
                txtserie.Text = ds.Tables("datos").Rows(0).Item(3).ToString
                txtproblema.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                cmbestado.Text = ds.Tables("datos").Rows(0).Item(5).ToString
                mskFecha.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                txtreparacion.Text = ds.Tables("datos").Rows(0).Item(7).ToString
                DataGridView1.DataSource = ds.Tables("datos")

                mostrarnombre(String.Format(" codigo={0} ", txtcodigoempleado.Text))

                antigua = mskFecha.Text
            Else
                MsgBox("Usuario no existe")
            End If

        Catch ex As Exception
            MessageBox.Show("Esta computadora aun no ha sido asignada a un empleado")
        End Try
    End Sub

    Private Sub btndetalle_Click(sender As Object, e As EventArgs) Handles btndetalle.Click
        reportemantenimiento.ShowDialog()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        If txtcodi.Enabled = False Then
            txtcodi.Enabled = True
        End If
        txtcodigo.Clear()
        txtmarca.Clear()
        txtmodelo.Clear()
        txtserie.Clear()
        txtproblema.Clear()
        txtcodi.Clear()
        txtreparacion.Clear()
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        tmensaje.SetToolTip(txtserie, "Click para eliminar un registro")
        tmensaje.ToolTipTitle = "Eliminar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub cmbestado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbestado.KeyPress
        e.Handled = True
    End Sub
End Class