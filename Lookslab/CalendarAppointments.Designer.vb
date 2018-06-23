<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarAppointments
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
        Me.ChBrowser = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ChBrowser
        '
        Me.ChBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChBrowser.Location = New System.Drawing.Point(0, 0)
        Me.ChBrowser.Name = "ChBrowser"
        Me.ChBrowser.Size = New System.Drawing.Size(730, 326)
        Me.ChBrowser.TabIndex = 0
        '
        'CalendarAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 326)
        Me.Controls.Add(Me.ChBrowser)
        Me.Name = "CalendarAppointments"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "CalendarAppointments"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChBrowser As Panel
End Class
