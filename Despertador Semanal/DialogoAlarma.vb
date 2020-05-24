Imports System.Windows.Forms
Imports System.IO

Public Class DialogoAlarma
    Public Property alarma As Alarma

    Public Sub New(alm As Alarma)
        'Llamada al constructor por defecto
        Me.New()

        Me.alarma = alm
        Me.txtTitulo.Text = Me.alarma.Titulo

        Dim d As New Date(Now.Year, Now.Month, Now.Day, alm.Hora, alm.Minutos, alm.Segundos)
        Me.DateTimePicker1.Value = d

        If alm.Semana Is Nothing Then
            radNoRepetir.Checked = True
        Else
            If alm.Semana(0) Then chkL.Checked = True
            If alm.Semana(1) Then chkM.Checked = True
            If alm.Semana(2) Then chkX.Checked = True
            If alm.Semana(3) Then chkJ.Checked = True
            If alm.Semana(4) Then chkV.Checked = True
            If alm.Semana(5) Then chkS.Checked = True
            If alm.Semana(6) Then chkD.Checked = True
        End If

        If Not alm.FicheroSonido Is Nothing Then
            radSeleccionar.Checked = True
            txtFichero.Text = alarma.FicheroSonido
        End If

        Me.Text = "Editar alarma"
    End Sub

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Dim d As New Date(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
        d = d.AddMinutes(5)
        Me.DateTimePicker1.Value = d
        Me.Text = "Nueva alarma"
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If alarma Is Nothing Then
            alarma = New Alarma(Me.DateTimePicker1.Value.Hour, _
                             Me.DateTimePicker1.Value.Minute, _
                             Me.DateTimePicker1.Value.Second)
        Else
            alarma.Hora = Me.DateTimePicker1.Value.Hour
            alarma.Minutos = Me.DateTimePicker1.Value.Minute
            alarma.Segundos = Me.DateTimePicker1.Value.Second
        End If

        alarma.Titulo = txtTitulo.Text

        If radRepetir.Checked Then 'Si hay repetición
            If Not chkL.Checked AndAlso Not chkM.Checked _
                AndAlso Not chkX.Checked AndAlso Not chkJ.Checked _
                AndAlso Not chkV.Checked AndAlso Not chkS.Checked _
                AndAlso Not chkD.Checked Then 'si no hay ningun dia seleccionado, considerar que no hay repetición

                alarma.Semana = Nothing
            Else
                Dim semana(6) As Boolean
                semana(0) = chkL.Checked
                semana(1) = chkM.Checked
                semana(2) = chkX.Checked
                semana(3) = chkJ.Checked
                semana(4) = chkV.Checked
                semana(5) = chkS.Checked
                semana(6) = chkD.Checked

                alarma.Semana = semana
            End If
        Else 'Sino
            alarma.Semana = Nothing
        End If

        If radSeleccionar.Checked AndAlso txtFichero.Text.Length > 0 Then
            alarma.FicheroSonido = txtFichero.Text
        Else
            alarma.FicheroSonido = Nothing
        End If

        alarma.ActualizarSiguienteEjecucion()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radRepetir.CheckedChanged
        If radRepetir.Checked Then
            chkL.Enabled = True
            chkM.Enabled = True
            chkX.Enabled = True
            chkJ.Enabled = True
            chkV.Enabled = True
            chkS.Enabled = True
            chkD.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radNoRepetir.CheckedChanged
        If radNoRepetir.Checked Then
            chkL.Enabled = False
            chkM.Enabled = False
            chkX.Enabled = False
            chkJ.Enabled = False
            chkV.Enabled = False
            chkS.Enabled = False
            chkD.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPredeterminado.CheckedChanged
        If radPredeterminado.Checked Then
            txtFichero.Enabled = False
            ctnExaminar.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSeleccionar.CheckedChanged
        If radSeleccionar.Checked Then
            txtFichero.Enabled = True
            ctnExaminar.Enabled = True
        End If
    End Sub

    Private Sub ctnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles ctnExaminar.Click
        If diaFicheroSonido.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFichero.Text = diaFicheroSonido.FileName
        End If
    End Sub
End Class
