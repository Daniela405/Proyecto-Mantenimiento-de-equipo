Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source = DESKTOP-HT00A5J\SQLEXPRESS; Initial Catalog = mantenimiento; Integrated Security = True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()

        End Try
    End Sub
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
