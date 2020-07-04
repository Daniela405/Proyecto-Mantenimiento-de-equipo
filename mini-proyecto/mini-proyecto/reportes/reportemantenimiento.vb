Public Class reportemantenimiento
    Private Sub reportemantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSistema.pc' Puede moverla o quitarla según sea necesario.
        Me.pcTableAdapter.Fill(Me.DataSistema.pc)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class