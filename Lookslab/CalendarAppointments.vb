Imports CefSharp.WinForms
Imports CefSharp

Public Class CalendarAppointments

    Private WithEvents browser As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        If CefSharp.Cef.IsInitialized = True Then

        Else
            CefSharp.Cef.Initialize(settings)
        End If
        browser = New ChromiumWebBrowser("http://thechriskent.com") With {
                .Dock = DockStyle.Fill
            }
        ChBrowser.Controls.Add(browser)
    End Sub

    Private Sub CalendarAppointments_Load(sender As Object, e As EventArgs) Handles Me.Load
        browser.Load("https://calendar.google.com/calendar/r")

    End Sub
End Class