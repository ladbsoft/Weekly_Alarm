Imports System.Windows.Forms
Imports System.IO

Public Class SonadorAlarma
    Private alm As Alarma
    Private emergencia As Boolean

    Public Sub New(alm As Alarma)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.alm = alm
        If Not alm.Titulo Is Nothing AndAlso alm.Titulo.Length > 0 Then
            Me.Text = alm.Titulo
            Me.lblTitulo.Text = alm.Titulo
        Else
            Me.Text = "¡Alarma!"
            Me.lblTitulo.Text = "Sin título"
        End If

        lblHora.Text = alm.Hora.ToString("00") & ":" & alm.Minutos.ToString("00") & ":" & alm.Segundos.ToString("00")

        player.uiMode = "invisible"
        player.settings.autoStart = True
        player.settings.volume = 100
        player.settings.setMode("loop", True)

        play()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label5.Visible = Not Label5.Visible
        If emergencia Then Beep()
    End Sub

    Private Sub SonadorAlarma_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        player.Ctlcontrols.stop()
        Timer1.Enabled = False
    End Sub

    Private Sub SonadorAlarma_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            Me.Close()
        End If
    End Sub

    Private Sub play()
        Dim rutaPredeterminada = My.Application.Info.DirectoryPath & "\Alarm.mp3"

        If Not alm.FicheroSonido Is Nothing Then
            If File.Exists(alm.FicheroSonido) Then
                player.URL = alm.FicheroSonido
            ElseIf File.Exists(rutaPredeterminada) Then
                player.URL = rutaPredeterminada
            Else
                emergencia = True
            End If
        Else
            If File.Exists(rutaPredeterminada) Then
                player.URL = rutaPredeterminada
            Else
                emergencia = True
            End If
        End If
    End Sub

    Private Sub player_ErrorEvent(sender As System.Object, e As System.EventArgs) Handles player.ErrorEvent
        emergencia = True
    End Sub
End Class
