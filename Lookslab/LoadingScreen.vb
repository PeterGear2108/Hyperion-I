Public Class LoadingScreen
    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBarTick.Start()
    End Sub

    Private Sub ProgressBarTick_Disposed(sender As Object, e As EventArgs) Handles ProgressBarTick.Disposed
        Me.Dispose()
    End Sub

    Private Sub ProgressBarTick_Tick(sender As Object, e As EventArgs) Handles ProgressBarTick.Tick
        Do Until InitalizingProcess.Value = 100
            InitalizingProcess.Increment(1)
        Loop
        If InitalizingProcess.Value = 100 Then
            ProgressBarTick.Dispose()
        End If
    End Sub

End Class