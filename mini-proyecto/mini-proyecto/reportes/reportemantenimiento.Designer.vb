<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eportemantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eportemantenimiento))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetReparacion = New mini_proyecto.DataSetReparacion()
        Me.pcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pcTableAdapter = New mini_proyecto.DataSetReparacionTableAdapters.pcTableAdapter()
        CType(Me.DataSetReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsMantenimiento"
        ReportDataSource1.Value = Me.pcBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "mini_proyecto.ReportMantenimiento.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(966, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetReparacion
        '
        Me.DataSetReparacion.DataSetName = "DataSetReparacion"
        Me.DataSetReparacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pcBindingSource
        '
        Me.pcBindingSource.DataMember = "pc"
        Me.pcBindingSource.DataSource = Me.DataSetReparacion
        '
        'pcTableAdapter
        '
        Me.pcTableAdapter.ClearBeforeFill = True
        '
        'eportemantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "eportemantenimiento"
        Me.Text = "Reporte Mantenimiento"
        CType(Me.DataSetReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pcBindingSource As BindingSource
    Friend WithEvents DataSetReparacion As DataSetReparacion
    Friend WithEvents pcTableAdapter As DataSetReparacionTableAdapters.pcTableAdapter
End Class
