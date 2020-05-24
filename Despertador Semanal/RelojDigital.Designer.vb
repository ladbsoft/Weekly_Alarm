<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelojDigital
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tmrSegundos = New System.Windows.Forms.Timer(Me.components)
        Me.lienzo = New System.Windows.Forms.PictureBox()
        Me.tmrSincronia = New System.Windows.Forms.Timer(Me.components)
        CType(Me.lienzo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSegundos
        '
        Me.tmrSegundos.Interval = 1000
        '
        'lienzo
        '
        Me.lienzo.BackColor = System.Drawing.Color.Black
        Me.lienzo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lienzo.Location = New System.Drawing.Point(0, 0)
        Me.lienzo.Name = "lienzo"
        Me.lienzo.Size = New System.Drawing.Size(150, 150)
        Me.lienzo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lienzo.TabIndex = 0
        Me.lienzo.TabStop = False
        '
        'tmrSincronia
        '
        Me.tmrSincronia.Interval = 600000
        '
        'RelojDigital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lienzo)
        Me.DoubleBuffered = True
        Me.Name = "RelojDigital"
        CType(Me.lienzo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrSegundos As System.Windows.Forms.Timer
    Friend WithEvents lienzo As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSincronia As System.Windows.Forms.Timer

End Class
