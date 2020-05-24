Public Class Alarma
    Implements IComparable
    Public Property Titulo As String
    Public Property Hora As Integer
    Public Property Minutos As Integer
    Public Property Segundos As Integer
    Public Property Semana As Boolean()
    Public Property FicheroSonido As String
    Public Property proximaEjecucion As Date

    Public Sub New(Titulo As String, hora As Integer, minutos As Integer, segundos As Integer, semana() As Boolean, ficheroSonido As String)
        Me.Titulo = Titulo
        Me.Hora = hora
        Me.Minutos = minutos
        Me.Segundos = segundos
        If Not semana Is Nothing AndAlso Not semana(0) AndAlso Not semana(1) AndAlso Not semana(2) _
            AndAlso Not semana(3) AndAlso Not semana(4) AndAlso Not semana(5) AndAlso Not semana(6) Then

            Me.Semana = Nothing
        Else
            Me.Semana = semana
        End If

        If Not ficheroSonido Is Nothing AndAlso ficheroSonido.Equals("") Then
            Me.FicheroSonido = Nothing
        Else
            Me.FicheroSonido = ficheroSonido
        End If

        Me.ActualizarSiguienteEjecucion()
    End Sub

    Public Sub New(titulo As String, hora As Integer, minutos As Integer, segundos As Integer, semana() As Boolean)
        Me.New(titulo, hora, minutos, segundos, semana, Nothing)
    End Sub

    Public Sub New(titulo As String, hora As Integer, minutos As Integer, segundos As Integer)
        Me.New(titulo, hora, minutos, segundos, Nothing)
    End Sub

    Public Sub New(hora As Integer, minutos As Integer, segundos As Integer, semana() As Boolean)
        Me.New(Nothing, hora, minutos, segundos, semana)
    End Sub

    Public Sub New(hora As Integer, minutos As Integer, segundos As Integer)
        Me.New(Nothing, hora, minutos, segundos, Nothing)
    End Sub

    Public Sub New()
        Me.New(Now.Hour, Now.Minute, Now.Second)
    End Sub

    Private Function DayOfWeekToSemanaIndex(day As Integer)
        Select Case day
            Case System.DayOfWeek.Monday
                Return 0
            Case System.DayOfWeek.Tuesday
                Return 1
            Case System.DayOfWeek.Wednesday
                Return 2
            Case System.DayOfWeek.Thursday
                Return 3
            Case System.DayOfWeek.Friday
                Return 4
            Case System.DayOfWeek.Saturday
                Return 5
            Case Else
                Return 6
        End Select
    End Function

    Public Sub ActualizarSiguienteEjecucion()
        Dim dayOfWeekHoy As Integer = Now.DayOfWeek
        Dim ahora As Date = Now
        Dim fecha As Date = New Date(Now.Year, Now.Month, Now.Day, Me.Hora, Me.Minutos, Me.Segundos)
        Dim i As Integer = 1
        Dim flag As Boolean = False

        If Not Me.Semana Is Nothing Then
            While i <= 7 AndAlso Not flag
                If Semana(DayOfWeekToSemanaIndex(fecha.DayOfWeek)) _
                    AndAlso fecha.CompareTo(ahora) >= 0 Then

                    flag = True
                Else
                    fecha = fecha.AddDays(1)
                End If

                i += 1
            End While
        Else
            If fecha.CompareTo(ahora) < 0 Then
                fecha = fecha.AddDays(1)
            End If
        End If

        Me.proximaEjecucion = fecha
    End Sub

    Public Function CompareTo(ByVal otro As Object) As Integer Implements IComparable.CompareTo
        Dim otraAlarma As Alarma = CType(otro, Alarma)

        Return Me.proximaEjecucion.CompareTo(otraAlarma.proximaEjecucion)
    End Function

    Public Overrides Function ToString() As String
        Dim out As String = ""

        If Not Me.Titulo Is Nothing AndAlso Me.Titulo.Length > 0 Then
            out &= Me.Titulo
            out &= " - "
        End If

        If Not Semana Is Nothing Then
            If Semana(0) Then out &= "L "
            If Semana(1) Then out &= "M "
            If Semana(2) Then out &= "X "
            If Semana(3) Then out &= "J "
            If Semana(4) Then out &= "V "
            If Semana(5) Then out &= "S "
            If Semana(6) Then out &= "D"

            If out.Length > 0 Then out &= " - "
        End If

        'TODO: Quitar esto...

        out &= "próxima ejecución el "
        out &= Me.proximaEjecucion.ToString("dd/MM/yyyy")
        out &= " a las "
        out &= Me.proximaEjecucion.ToString("HH:mm:ss")

        Return out
    End Function
End Class
