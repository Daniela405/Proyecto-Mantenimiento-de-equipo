Public Class reportepersonal
    Private Sub reportepersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReparacion.persona' Puede moverla o quitarla según sea necesario.
        Me.personaTableAdapter.Fill(Me.DataSetReparacion.persona)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class