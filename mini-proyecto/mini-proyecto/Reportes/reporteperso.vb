Public Class reporteperso
    Private Sub reporteperso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSistema.persona' Puede moverla o quitarla según sea necesario.
        Me.personaTableAdapter.Fill(Me.DataSistema.persona)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class