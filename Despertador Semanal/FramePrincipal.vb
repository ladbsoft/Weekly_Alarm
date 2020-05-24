Imports System.IO

Public Class FramePrincipal
    Private alarmas As AutoSortableList(Of Alarma)

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        alarmas = New AutoSortableList(Of Alarma)
    End Sub

    Private Sub rellenarListBoxAlarmas()
        Me.lstAlarmas.Items.Clear()

        For Each a As Alarma In alarmas
            Me.lstAlarmas.Items.Add(a)
        Next
    End Sub

    Private Sub guardarListaAlarmas(ruta As String)
        Dim str As FileStream = Nothing
        Dim writer As BinaryWriter = Nothing
        Dim size As Integer = 8 '4 bytes cabecera + 4 bytes tamaño

        Try
            str = New FileStream(ruta, FileMode.Create)
            writer = New BinaryWriter(str, System.Text.Encoding.GetEncoding("ISO8859-1"))

            For Each a As Alarma In alarmas
                size += a.Titulo.Length + 1

                size += 12 '4 bytes de hora, 4 de minutos y 4 de segundos
                size += 7 '7 bytes de semana

                If a.FicheroSonido Is Nothing Then
                    size += 1
                Else
                    size += a.FicheroSonido.Length + 1 'tamaño de la ruta del fichero + 1 byte de longitud
                End If
            Next

            writer.Write(&H4C4D4C41) 'Cabecera "ALML"
            writer.Write(size)
            For Each a As Alarma In alarmas
                writer.Write(a.Titulo)
                writer.Write(a.Hora)
                writer.Write(a.Minutos)
                writer.Write(a.Segundos)

                If a.Semana Is Nothing Then
                    For i As Integer = 1 To 7
                        writer.Write(CByte(0))
                    Next
                Else
                    For Each b As Boolean In a.Semana
                        If b Then
                            writer.Write(CByte(1))
                        Else
                            writer.Write(CByte(0))
                        End If
                    Next
                End If

                writer.Write(IIf(a.FicheroSonido Is Nothing, "", a.FicheroSonido))
            Next
        Catch ex As Exception
            Throw New Exception("Hubo un error al guardar la lista de alarmas.")
        Finally
            Try
                If Not writer Is Nothing Then writer.Close()
                If Not str Is Nothing Then str.Close()
            Catch ex As Exception

            End Try
        End Try
    End Sub

    Private Sub guardarListaAlarmas()
        guardarListaAlarmas(My.Application.Info.DirectoryPath & "\alarmas.alm")
    End Sub

    Private Sub cargarListaAlarmas(ruta As String)
        Dim str As FileStream = Nothing
        Dim reader As BinaryReader = Nothing
        Dim titulo As String
        Dim hora As Integer
        Dim minutos As Integer
        Dim segundos As Integer
        Dim semana(6) As Boolean
        Dim ficheroSonido As String

        Try
            str = New FileStream(ruta, FileMode.OpenOrCreate)
            reader = New BinaryReader(str, System.Text.Encoding.GetEncoding("ISO8859-1"))

            If str.Length > 0 Then
                If reader.ReadInt32 = &H4C4D4C41 Then
                    If str.Length = reader.ReadInt32 Then
                        While str.Position <> str.Length
                            titulo = reader.ReadString
                            hora = reader.ReadInt32
                            minutos = reader.ReadInt32
                            segundos = reader.ReadInt32

                            For i As Integer = 0 To 6
                                semana(i) = IIf(reader.ReadByte = CByte(1), True, False)
                            Next

                            ficheroSonido = reader.ReadString

                            alarmas.Add(New Alarma(titulo.Clone, hora, minutos, segundos, semana.Clone, ficheroSonido.Clone))
                        End While

                        rellenarListBoxAlarmas()
                    Else
                        Throw New InvalidDataException("El archivo de lista de alarmas está corrupto o ha sido modificado externamente, se ignorará.")
                    End If
                Else
                    Throw New InvalidDataException("El archivo de lista de alarmas no tiene una estructura válida, se ignorará.")
                End If
            End If
        Catch ex As Exception
            Throw New Exception("Hubo un error al cargar la lista de alarmas.")
        Finally
            Try
                If Not reader Is Nothing Then reader.Close()
                If Not str Is Nothing Then str.Close()
            Catch ex As Exception

            End Try
        End Try
    End Sub

    Private Sub cargarListaAlarmas()
        cargarListaAlarmas(My.Application.Info.DirectoryPath & "\alarmas.alm")
    End Sub

    Private Sub Ocultar()
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()
        iconoNotificacion.Visible = True
    End Sub

    Private Sub Mostrar()
        If Me.WindowState = FormWindowState.Minimized Then
            iconoNotificacion.Visible = False
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub


    '--------------------------------------------------------------------------
    '--------------------------------------------------------------------------
    '-----         M A N E J A D O R E S   D E   E V E N T O S            -----
    '--------------------------------------------------------------------------
    '--------------------------------------------------------------------------

    Private Sub FPrincipal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            guardarListaAlarmas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        iconoNotificacion.Visible = False
    End Sub

    Private Sub FPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cargarListaAlarmas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarAlarmasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CargarAlarmasToolStripMenuItem.Click
        If alarmas.Count > 0 AndAlso _
            MessageBox.Show("Si abre otra lista de alarmas, la actual se perderá, ¿Desea continuar?", _
                            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                            = Windows.Forms.DialogResult.No Then Return

        If dialogoAbrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            alarmas.Clear()
            cargarListaAlarmas(dialogoAbrir.FileName)
        End If
    End Sub

    Private Sub GuardarAlarmasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarAlarmasToolStripMenuItem.Click
        If dialogoGuardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            guardarListaAlarmas(dialogoGuardar.FileName)
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.ShowDialog()
    End Sub

    Private Sub FramePrincipal_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Ocultar()
        End If
    End Sub

    Private Sub iconoNotificacion_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles iconoNotificacion.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Mostrar()
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim d As New DialogoAlarma

        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            alarmas.Add(d.alarma)
            rellenarListBoxAlarmas()
            guardarListaAlarmas()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If Me.lstAlarmas.SelectedIndex >= 0 Then
            If MessageBox.Show("¿Está seguro de querer eliminar la alarma seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                alarmas.Remove(lstAlarmas.SelectedItem)
                rellenarListBoxAlarmas()
                guardarListaAlarmas()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        If Me.lstAlarmas.SelectedIndex >= 0 Then
            Dim alarmaSeleccionada As Alarma = CType(Me.lstAlarmas.SelectedItem, Alarma)
            Dim d As New DialogoAlarma(alarmaSeleccionada)

            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                alarmaSeleccionada.Titulo = d.alarma.Titulo
                alarmaSeleccionada.Hora = d.alarma.Hora
                alarmaSeleccionada.Minutos = d.alarma.Minutos
                alarmaSeleccionada.Segundos = d.alarma.Segundos
                alarmaSeleccionada.Semana = d.alarma.Semana
                alarmaSeleccionada.FicheroSonido = d.alarma.FicheroSonido
                alarmaSeleccionada.ActualizarSiguienteEjecucion()

                alarmas.Sort()
                rellenarListBoxAlarmas()
                guardarListaAlarmas()
            End If
        End If
    End Sub

    Private Sub RelojDigital1_Tick(sender As RelojDigital) Handles RelojDigital1.Tick
        If alarmas.Count = 0 Then Return

        If alarmas(0).proximaEjecucion.Day <= Now.Day Then
            If sender.Horas >= alarmas(0).Hora Then
                If sender.Minutos >= alarmas(0).Minutos Then
                    If sender.Segundos >= alarmas(0).Segundos Then
                        Dim s As New SonadorAlarma(alarmas(0))

                        If alarmas(0).Semana Is Nothing Then
                            alarmas.RemoveAt(0)
                        End If

                        If alarmas.Count > 0 Then
                            alarmas(0).ActualizarSiguienteEjecucion()
                            alarmas.Sort()
                        End If

                        rellenarListBoxAlarmas()

                        If Me.WindowState = FormWindowState.Minimized Then
                            Mostrar()
                            s.ShowDialog()
                            Ocultar()
                        Else
                            s.ShowDialog()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
