<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PanelCabecera = New Panel()
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        MenuStrip1 = New MenuStrip()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        ExistenteToolStripMenuItem = New ToolStripMenuItem()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        ListarToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem1 = New ToolStripMenuItem()
        ListarToolStripMenuItem1 = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        ListarToolStripMenuItem3 = New ToolStripMenuItem()
        VenderToolStripMenuItem = New ToolStripMenuItem()
        VenderUnProductoToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PanelCabecera.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCabecera
        ' 
        PanelCabecera.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        PanelCabecera.Controls.Add(PictureBox2)
        PanelCabecera.Controls.Add(Label7)
        PanelCabecera.Dock = DockStyle.Top
        PanelCabecera.Location = New Point(123, 0)
        PanelCabecera.Name = "PanelCabecera"
        PanelCabecera.Size = New Size(252, 30)
        PanelCabecera.TabIndex = 11
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.image__1_
        PictureBox2.Location = New Point(0, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 31)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(39, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 17)
        Label7.TabIndex = 1
        Label7.Text = "Mr White Pharma"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProductosToolStripMenuItem, ClientesToolStripMenuItem, UsuariosToolStripMenuItem, VenderToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(123, 227)
        MenuStrip1.TabIndex = 19
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem, ListarToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(116, 19)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' AgregarToolStripMenuItem
        ' 
        AgregarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExistenteToolStripMenuItem, NuevoToolStripMenuItem})
        AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        AgregarToolStripMenuItem.Size = New Size(116, 22)
        AgregarToolStripMenuItem.Text = "Agregar"
        ' 
        ' ExistenteToolStripMenuItem
        ' 
        ExistenteToolStripMenuItem.Name = "ExistenteToolStripMenuItem"
        ExistenteToolStripMenuItem.Size = New Size(121, 22)
        ExistenteToolStripMenuItem.Text = "Existente"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.Size = New Size(121, 22)
        NuevoToolStripMenuItem.Text = "Nuevo"
        ' 
        ' ListarToolStripMenuItem
        ' 
        ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        ListarToolStripMenuItem.Size = New Size(116, 22)
        ListarToolStripMenuItem.Text = "Listar"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem1, ListarToolStripMenuItem1})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(116, 19)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AgregarToolStripMenuItem1
        ' 
        AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        AgregarToolStripMenuItem1.Size = New Size(116, 22)
        AgregarToolStripMenuItem1.Text = "Agregar"
        ' 
        ' ListarToolStripMenuItem1
        ' 
        ListarToolStripMenuItem1.Name = "ListarToolStripMenuItem1"
        ListarToolStripMenuItem1.Size = New Size(116, 22)
        ListarToolStripMenuItem1.Text = "Listar"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListarToolStripMenuItem3})
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(116, 19)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' ListarToolStripMenuItem3
        ' 
        ListarToolStripMenuItem3.Name = "ListarToolStripMenuItem3"
        ListarToolStripMenuItem3.Size = New Size(180, 22)
        ListarToolStripMenuItem3.Text = "Listar"
        ' 
        ' VenderToolStripMenuItem
        ' 
        VenderToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VenderUnProductoToolStripMenuItem})
        VenderToolStripMenuItem.Name = "VenderToolStripMenuItem"
        VenderToolStripMenuItem.Size = New Size(116, 19)
        VenderToolStripMenuItem.Text = "Vender"
        ' 
        ' VenderUnProductoToolStripMenuItem
        ' 
        VenderUnProductoToolStripMenuItem.Name = "VenderUnProductoToolStripMenuItem"
        VenderUnProductoToolStripMenuItem.Size = New Size(182, 22)
        VenderUnProductoToolStripMenuItem.Text = "Vender un producto "
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(116, 19)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image
        PictureBox1.Location = New Point(76, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(301, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(375, 227)
        Controls.Add(PanelCabecera)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        PanelCabecera.ResumeLayout(False)
        PanelCabecera.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VenderUnProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExistenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem3 As ToolStripMenuItem
End Class
