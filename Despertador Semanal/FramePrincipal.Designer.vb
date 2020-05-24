<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FramePrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FramePrincipal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstAlarmas = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.barraMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarAlarmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarAlarmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dialogoAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.dialogoGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.tooltipProvider = New System.Windows.Forms.ToolTip(Me.components)
        Me.iconoNotificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.menuIconoNotif = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelojDigital1 = New Despertador_Semanal.RelojDigital()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.barraMenu.SuspendLayout()
        Me.menuIconoNotif.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.lstAlarmas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alarmas:"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(330, 74)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(24, 23)
        Me.btnModificar.TabIndex = 2
        Me.tooltipProvider.SetToolTip(Me.btnModificar, "Modificar la alarma seleccionada")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(330, 45)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(24, 23)
        Me.btnEliminar.TabIndex = 2
        Me.tooltipProvider.SetToolTip(Me.btnEliminar, "Eliminar la alarma seleccionada")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(330, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(24, 23)
        Me.btnAgregar.TabIndex = 2
        Me.tooltipProvider.SetToolTip(Me.btnAgregar, "Agregar nueva alarma")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstAlarmas
        '
        Me.lstAlarmas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAlarmas.FormattingEnabled = True
        Me.lstAlarmas.IntegralHeight = False
        Me.lstAlarmas.Location = New System.Drawing.Point(6, 16)
        Me.lstAlarmas.Name = "lstAlarmas"
        Me.lstAlarmas.Size = New System.Drawing.Size(321, 122)
        Me.lstAlarmas.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RelojDigital1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 24)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.9345!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.06551!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(366, 229)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'barraMenu
        '
        Me.barraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.barraMenu.Location = New System.Drawing.Point(0, 0)
        Me.barraMenu.Name = "barraMenu"
        Me.barraMenu.Size = New System.Drawing.Size(384, 24)
        Me.barraMenu.TabIndex = 3
        Me.barraMenu.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarAlarmasToolStripMenuItem, Me.GuardarAlarmasToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CargarAlarmasToolStripMenuItem
        '
        Me.CargarAlarmasToolStripMenuItem.Name = "CargarAlarmasToolStripMenuItem"
        Me.CargarAlarmasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.CargarAlarmasToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.CargarAlarmasToolStripMenuItem.Text = "Abrir lista de alarmas"
        '
        'GuardarAlarmasToolStripMenuItem
        '
        Me.GuardarAlarmasToolStripMenuItem.Name = "GuardarAlarmasToolStripMenuItem"
        Me.GuardarAlarmasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarAlarmasToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.GuardarAlarmasToolStripMenuItem.Text = "Guardar lista de alarmas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(239, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'dialogoAbrir
        '
        Me.dialogoAbrir.FileName = "*.alm"
        Me.dialogoAbrir.Filter = "Archivos de lista de alarmas|*.alm"
        Me.dialogoAbrir.RestoreDirectory = True
        Me.dialogoAbrir.Title = "Abrir lista de alarmas"
        '
        'dialogoGuardar
        '
        Me.dialogoGuardar.FileName = "*.alm"
        Me.dialogoGuardar.Filter = "Archivos de lista de alarmas|*.alm"
        Me.dialogoGuardar.RestoreDirectory = True
        Me.dialogoGuardar.Title = "Guardar lista de alarmas"
        '
        'iconoNotificacion
        '
        Me.iconoNotificacion.ContextMenuStrip = Me.menuIconoNotif
        Me.iconoNotificacion.Icon = CType(resources.GetObject("iconoNotificacion.Icon"), System.Drawing.Icon)
        Me.iconoNotificacion.Text = "Despertador semanal"
        '
        'menuIconoNotif
        '
        Me.menuIconoNotif.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarToolStripMenuItem, Me.ToolStripSeparator2, Me.SalirToolStripMenuItem1})
        Me.menuIconoNotif.Name = "menuIconoNotif"
        Me.menuIconoNotif.Size = New System.Drawing.Size(153, 76)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'RelojDigital1
        '
        Me.RelojDigital1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RelojDigital1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RelojDigital1.Location = New System.Drawing.Point(3, 3)
        Me.RelojDigital1.Name = "RelojDigital1"
        Me.RelojDigital1.Size = New System.Drawing.Size(360, 73)
        Me.RelojDigital1.TabIndex = 0
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'FramePrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.barraMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "FramePrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despertador Semanal"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.barraMenu.ResumeLayout(False)
        Me.barraMenu.PerformLayout()
        Me.menuIconoNotif.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RelojDigital1 As Despertador_Semanal.RelojDigital
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstAlarmas As System.Windows.Forms.ListBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents barraMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarAlarmasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarAlarmasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dialogoAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dialogoGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tooltipProvider As System.Windows.Forms.ToolTip
    Friend WithEvents iconoNotificacion As System.Windows.Forms.NotifyIcon
    Friend WithEvents menuIconoNotif As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
