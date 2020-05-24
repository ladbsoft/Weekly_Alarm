Public Class RelojDigital
    Private _Horas As Integer
    Private _Minutos As Integer
    Private _Segundos As Integer
    Private numeros() As Bitmap
    Private puntos() As Bitmap
    Private buffer As Bitmap
    Event Tick(sender As RelojDigital)

#Region "### PROPIEDADES ###"
    Public ReadOnly Property Horas As Integer
        Get
            Return _Horas
        End Get
    End Property

    Public ReadOnly Property Minutos As Integer
        Get
            Return _Minutos
        End Get
    End Property

    Public ReadOnly Property Segundos As Integer
        Get
            Return _Segundos
        End Get
    End Property
#End Region

    Public Sub New(horas As Integer, minutos As Integer, segundos As Integer, autoSincronizar As Boolean)
        InitializeComponent()

        cargarImagenes()
        Me._Horas = horas
        Me._Minutos = minutos
        Me._Segundos = segundos

        Render()
        tmrSegundos.Enabled = True
    End Sub

    Public Sub New(horas As Integer, minutos As Integer, segundos As Integer)
        Me.new(horas, minutos, segundos, False)
    End Sub

    Public Sub New()
        Me.new(Now.Hour, Now.Minute, Now.Second)
    End Sub

    Private Sub cargarImagenes()
        Dim img As Bitmap = My.Resources.green
        Dim ancho As Integer = CInt(img.Width \ 4)
        Dim alto As Integer = CInt(img.Height \ 3)
        ReDim numeros(9)
        ReDim puntos(1)

        Dim k As Integer = 0
        For i As Integer = 0 To (3 - 1)
            For j As Integer = 0 To (4 - 1)
                If k <= 9 Then
                    numeros(k) = New Bitmap(ancho, alto, Imaging.PixelFormat.Format32bppArgb)
                    Graphics.FromImage(numeros(k)).DrawImage(img, -(ancho * j), -(alto * i), img.Width, img.Height)
                ElseIf k = 10 Then
                    puntos(0) = New Bitmap(ancho \ 2, alto, Imaging.PixelFormat.Format32bppArgb)
                    Graphics.FromImage(puntos(0)).DrawImage(img, -(ancho * j), -(alto * i), img.Width, img.Height)
                    puntos(1) = New Bitmap(ancho \ 2, alto, Imaging.PixelFormat.Format32bppArgb)
                    Graphics.FromImage(puntos(1)).DrawImage(img, -((ancho * j) + (ancho \ 2)), -(alto * i), img.Width, img.Height)
                End If

                k += 1
            Next
        Next

        buffer = New Bitmap(((numeros(0).Width * 6) + (puntos(0).Width * 2)), numeros(0).Height, Imaging.PixelFormat.Format32bppArgb)
        Graphics.FromImage(buffer).Clear(Color.Black)
        lienzo.Image = buffer
    End Sub

    Private Sub tmrSegundos_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSegundos.Tick
        Me._Segundos += 1
        If Me._Segundos = 60 Then
            Me._Segundos = 0
            Me._Minutos += 1
        End If
        If Me._Minutos = 60 Then
            Me._Minutos = 0
            Me._Horas += 1
        End If
        If Me._Horas = 24 Then
            Me._Horas = 0
        End If

        'TODO: Solo pintar cuando se esté mostrando, no cuando esté oculta la ventana
        Render()
        RaiseEvent Tick(Me)
    End Sub

    Private Sub Render()
        Dim g As Graphics = Graphics.FromImage(buffer)
        Dim anchoNumero As Integer = numeros(0).Width
        Dim anchoPunto As Integer = puntos(0).Width
        Dim x As Integer = 0

        If _Horas > 9 Then
            g.DrawImage(numeros(_Horas \ 10), x, 0)
        Else
            g.DrawImage(numeros(0), x, 0)
        End If

        x += anchoNumero

        g.DrawImage(numeros(_Horas Mod 10), x, 0)

        x += anchoNumero

        If _Segundos Mod 2 = 0 Then
            g.DrawImage(puntos(0), x, 0)
        Else
            g.DrawImage(puntos(1), x, 0)
        End If

        x += anchoPunto



        If _Minutos > 9 Then
            g.DrawImage(numeros(_Minutos \ 10), x, 0)
        Else
            g.DrawImage(numeros(0), x, 0)
        End If

        x += anchoNumero

        g.DrawImage(numeros(_Minutos Mod 10), x, 0)

        x += anchoNumero

        If _Segundos Mod 2 = 0 Then
            g.DrawImage(puntos(0), x, 0)
        Else
            g.DrawImage(puntos(1), x, 0)
        End If

        x += anchoPunto



        If _Segundos > 9 Then
            g.DrawImage(numeros(_Segundos \ 10), x, 0)
        Else
            g.DrawImage(numeros(0), x, 0)
        End If

        x += anchoNumero

        g.DrawImage(numeros(_Segundos Mod 10), x, 0)

        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSincronia.Tick
        Me._Horas = Now.Hour
        Me._Minutos = Now.Minute
        Me._Segundos = Now.Second
    End Sub
End Class
