<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportepersonal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetReparacion = New mini_proyecto.DataSetReparacion()
        Me.personaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.personaTableAdapter = New mini_proyecto.DataSetReparacionTableAdapters.personaTableAdapter()
        CType(Me.DataSetReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetpersonal"
        ReportDataSource1.Value = Me.personaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "mini_proyecto.Reportpersonal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1086, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetReparacion
        '
        Me.DataSetReparacion.DataSetName = "DataSetReparacion"
        Me.DataSetReparacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'personaBindingSource
        '
        Me.personaBindingSource.DataMember = "persona"
        Me.personaBindingSource.DataSource = Me.DataSetReparacion
        '
        'personaTableAdapter
        '
        Me.personaTableAdapter.ClearBeforeFill = True
        '
        'reportepersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportepersonal"
        Me.Text = "reportepersonal"
        CType(Me.DataSetReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents personaBindingSource As BindingSource
    Friend WithEvents DataSetReparacion As DataSetReparacion
    Friend WithEvents personaTableAdapter As DataSetReparacionTableAdapters.personaTableAdapter
End Class
