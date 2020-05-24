<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogoAlarma
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNoRepetir = New System.Windows.Forms.RadioButton()
        Me.chkD = New System.Windows.Forms.CheckBox()
        Me.chkS = New System.Windows.Forms.CheckBox()
        Me.chkV = New System.Windows.Forms.CheckBox()
        Me.chkJ = New System.Windows.Forms.CheckBox()
        Me.chkX = New System.Windows.Forms.CheckBox()
        Me.chkM = New System.Windows.Forms.CheckBox()
        Me.chkL = New System.Windows.Forms.CheckBox()
        Me.radRepetir = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ctnExaminar = New System.Windows.Forms.Button()
        Me.txtFichero = New System.Windows.Forms.TextBox()
        Me.radSeleccionar = New System.Windows.Forms.RadioButton()
        Me.radPredeterminado = New System.Windows.Forms.RadioButton()
        Me.diaFicheroSonido = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(191, 251)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(61, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(65, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2012, 8, 22, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radNoRepetir)
        Me.GroupBox1.Controls.Add(Me.chkD)
        Me.GroupBox1.Controls.Add(Me.chkS)
        Me.GroupBox1.Controls.Add(Me.chkV)
        Me.GroupBox1.Controls.Add(Me.chkJ)
        Me.GroupBox1.Controls.Add(Me.chkX)
        Me.GroupBox1.Controls.Add(Me.chkM)
        Me.GroupBox1.Controls.Add(Me.chkL)
        Me.GroupBox1.Controls.Add(Me.radRepetir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 97)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repetición"
        '
        'radNoRepetir
        '
        Me.radNoRepetir.AutoSize = True
        Me.radNoRepetir.Location = New System.Drawing.Point(11, 65)
        Me.radNoRepetir.Name = "radNoRepetir"
        Me.radNoRepetir.Size = New System.Drawing.Size(71, 17)
        Me.radNoRepetir.TabIndex = 8
        Me.radNoRepetir.Text = "No repetir"
        Me.radNoRepetir.UseVisualStyleBackColor = True
        '
        'chkD
        '
        Me.chkD.AutoSize = True
        Me.chkD.Location = New System.Drawing.Point(272, 42)
        Me.chkD.Name = "chkD"
        Me.chkD.Size = New System.Drawing.Size(34, 17)
        Me.chkD.TabIndex = 7
        Me.chkD.Text = "D"
        Me.chkD.UseVisualStyleBackColor = True
        '
        'chkS
        '
        Me.chkS.AutoSize = True
        Me.chkS.Location = New System.Drawing.Point(233, 42)
        Me.chkS.Name = "chkS"
        Me.chkS.Size = New System.Drawing.Size(33, 17)
        Me.chkS.TabIndex = 6
        Me.chkS.Text = "S"
        Me.chkS.UseVisualStyleBackColor = True
        '
        'chkV
        '
        Me.chkV.AutoSize = True
        Me.chkV.Location = New System.Drawing.Point(194, 42)
        Me.chkV.Name = "chkV"
        Me.chkV.Size = New System.Drawing.Size(33, 17)
        Me.chkV.TabIndex = 5
        Me.chkV.Text = "V"
        Me.chkV.UseVisualStyleBackColor = True
        '
        'chkJ
        '
        Me.chkJ.AutoSize = True
        Me.chkJ.Location = New System.Drawing.Point(157, 42)
        Me.chkJ.Name = "chkJ"
        Me.chkJ.Size = New System.Drawing.Size(31, 17)
        Me.chkJ.TabIndex = 4
        Me.chkJ.Text = "J"
        Me.chkJ.UseVisualStyleBackColor = True
        '
        'chkX
        '
        Me.chkX.AutoSize = True
        Me.chkX.Location = New System.Drawing.Point(117, 42)
        Me.chkX.Name = "chkX"
        Me.chkX.Size = New System.Drawing.Size(33, 17)
        Me.chkX.TabIndex = 3
        Me.chkX.Text = "X"
        Me.chkX.UseVisualStyleBackColor = True
        '
        'chkM
        '
        Me.chkM.AutoSize = True
        Me.chkM.Location = New System.Drawing.Point(75, 42)
        Me.chkM.Name = "chkM"
        Me.chkM.Size = New System.Drawing.Size(35, 17)
        Me.chkM.TabIndex = 2
        Me.chkM.Text = "M"
        Me.chkM.UseVisualStyleBackColor = True
        '
        'chkL
        '
        Me.chkL.AutoSize = True
        Me.chkL.Location = New System.Drawing.Point(36, 42)
        Me.chkL.Name = "chkL"
        Me.chkL.Size = New System.Drawing.Size(32, 17)
        Me.chkL.TabIndex = 1
        Me.chkL.Text = "L"
        Me.chkL.UseVisualStyleBackColor = True
        '
        'radRepetir
        '
        Me.radRepetir.AutoSize = True
        Me.radRepetir.Checked = True
        Me.radRepetir.Location = New System.Drawing.Point(11, 19)
        Me.radRepetir.Name = "radRepetir"
        Me.radRepetir.Size = New System.Drawing.Size(59, 17)
        Me.radRepetir.TabIndex = 0
        Me.radRepetir.TabStop = True
        Me.radRepetir.Text = "Repetir"
        Me.radRepetir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Título:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(60, 10)
        Me.txtTitulo.MaxLength = 250
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(277, 20)
        Me.txtTitulo.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ctnExaminar)
        Me.GroupBox2.Controls.Add(Me.txtFichero)
        Me.GroupBox2.Controls.Add(Me.radSeleccionar)
        Me.GroupBox2.Controls.Add(Me.radPredeterminado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 80)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fichero de sonido:"
        '
        'ctnExaminar
        '
        Me.ctnExaminar.Enabled = False
        Me.ctnExaminar.Location = New System.Drawing.Point(295, 40)
        Me.ctnExaminar.Name = "ctnExaminar"
        Me.ctnExaminar.Size = New System.Drawing.Size(24, 23)
        Me.ctnExaminar.TabIndex = 3
        Me.ctnExaminar.Text = "..."
        Me.ctnExaminar.UseVisualStyleBackColor = True
        '
        'txtFichero
        '
        Me.txtFichero.BackColor = System.Drawing.Color.White
        Me.txtFichero.Enabled = False
        Me.txtFichero.Location = New System.Drawing.Point(101, 42)
        Me.txtFichero.Name = "txtFichero"
        Me.txtFichero.ReadOnly = True
        Me.txtFichero.Size = New System.Drawing.Size(188, 20)
        Me.txtFichero.TabIndex = 2
        '
        'radSeleccionar
        '
        Me.radSeleccionar.AutoSize = True
        Me.radSeleccionar.Location = New System.Drawing.Point(11, 43)
        Me.radSeleccionar.Name = "radSeleccionar"
        Me.radSeleccionar.Size = New System.Drawing.Size(84, 17)
        Me.radSeleccionar.TabIndex = 1
        Me.radSeleccionar.TabStop = True
        Me.radSeleccionar.Text = "Seleccionar:"
        Me.radSeleccionar.UseVisualStyleBackColor = True
        '
        'radPredeterminado
        '
        Me.radPredeterminado.AutoSize = True
        Me.radPredeterminado.Checked = True
        Me.radPredeterminado.Location = New System.Drawing.Point(11, 20)
        Me.radPredeterminado.Name = "radPredeterminado"
        Me.radPredeterminado.Size = New System.Drawing.Size(99, 17)
        Me.radPredeterminado.TabIndex = 0
        Me.radPredeterminado.TabStop = True
        Me.radPredeterminado.Text = "Predeterminado"
        Me.radPredeterminado.UseVisualStyleBackColor = True
        '
        'diaFicheroSonido
        '
        Me.diaFicheroSonido.Filter = "Ficheros de sonido soportados|*.mp3;*.wma;*.wav;*.mid"
        Me.diaFicheroSonido.RestoreDirectory = True
        Me.diaFicheroSonido.Title = "Seleccionar fichero de sonido"
        '
        'DialogoAlarma
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(349, 292)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogoAlarma"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva/Editar alarma"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radNoRepetir As System.Windows.Forms.RadioButton
    Friend WithEvents chkD As System.Windows.Forms.CheckBox
    Friend WithEvents chkS As System.Windows.Forms.CheckBox
    Friend WithEvents chkV As System.Windows.Forms.CheckBox
    Friend WithEvents chkJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkX As System.Windows.Forms.CheckBox
    Friend WithEvents chkM As System.Windows.Forms.CheckBox
    Friend WithEvents chkL As System.Windows.Forms.CheckBox
    Friend WithEvents radRepetir As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ctnExaminar As System.Windows.Forms.Button
    Friend WithEvents txtFichero As System.Windows.Forms.TextBox
    Friend WithEvents radSeleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents radPredeterminado As System.Windows.Forms.RadioButton
    Friend WithEvents diaFicheroSonido As System.Windows.Forms.OpenFileDialog

End Class
