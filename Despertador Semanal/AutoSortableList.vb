Public Class AutoSortableList(Of T)
    Inherits List(Of T)

    Public Overloads Sub Add(Item As T)
        MyBase.Add(Item)
        Me.Sort()
    End Sub

    Public Overloads Sub RemoveAt(index As Integer)
        MyBase.RemoveAt(index)
        Me.Sort()
    End Sub
End Class
