<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarClientes))
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(27, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 17)
        Label5.TabIndex = 36
        Label5.Text = "Precio por unidad ($)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F)
        Label4.Location = New Point(27, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 35
        Label4.Text = "Cantidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F)
        Label3.Location = New Point(27, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 17)
        Label3.TabIndex = 34
        Label3.Text = "Nombre del Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F)
        Label2.Location = New Point(27, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 17)
        Label2.TabIndex = 33
        Label2.Text = "ID"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 9F)
        TextBox4.Location = New Point(27, 281)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 22)
        TextBox4.TabIndex = 32
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 9F)
        TextBox3.Location = New Point(27, 210)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 22)
        TextBox3.TabIndex = 31
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 9F)
        TextBox2.Location = New Point(27, 141)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 22)
        TextBox2.TabIndex = 30
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 9F)
        TextBox1.Location = New Point(27, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 22)
        TextBox1.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(277, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 25)
        Label1.TabIndex = 28
        Label1.Text = "Lista de Clientes"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(246, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(430, 231)
        DataGridView1.TabIndex = 27
        ' 
        ' listarClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(710, 340)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "listarClientes"
        Text = "Lista de Clientes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
