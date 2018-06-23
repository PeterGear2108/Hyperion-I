<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingScreen))
        Me.LoadingLbl = New System.Windows.Forms.Label()
        Me.InitalizingProcess = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarTick = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LoadingLbl
        '
        resources.ApplyResources(Me.LoadingLbl, "LoadingLbl")
        Me.LoadingLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadingLbl.Name = "LoadingLbl"
        '
        'InitalizingProcess
        '
        resources.ApplyResources(Me.InitalizingProcess, "InitalizingProcess")
        Me.InitalizingProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.InitalizingProcess.MarqueeAnimationSpeed = 10000
        Me.InitalizingProcess.Name = "InitalizingProcess"
        Me.InitalizingProcess.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ProgressBarTick
        '
        Me.ProgressBarTick.Interval = 1000
        '
        'LoadingScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ControlBox = False
        Me.Controls.Add(Me.InitalizingProcess)
        Me.Controls.Add(Me.LoadingLbl)
        Me.Name = "LoadingScreen"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingLbl As Label
    Friend WithEvents InitalizingProcess As ProgressBar
    Friend WithEvents ProgressBarTick As Timer
End Class
