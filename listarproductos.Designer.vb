<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarproductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarproductos))
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(282, 67)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(430, 231)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(313, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 25)
        Label1.TabIndex = 18
        Label1.Text = "Lista de Productos"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 9F)
        TextBox1.Location = New Point(63, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 22)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 9F)
        TextBox2.Location = New Point(63, 136)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 22)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 9F)
        TextBox3.Location = New Point(63, 205)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 22)
        TextBox3.TabIndex = 21
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 9F)
        TextBox4.Location = New Point(63, 276)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 22)
        TextBox4.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F)
        Label2.Location = New Point(63, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 17)
        Label2.TabIndex = 23
        Label2.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F)
        Label3.Location = New Point(63, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 17)
        Label3.TabIndex = 24
        Label3.Text = "Nombre del Producto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F)
        Label4.Location = New Point(63, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 25
        Label4.Text = "Cantidad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(63, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 17)
        Label5.TabIndex = 26
        Label5.Text = "Precio por unidad ($)"
        ' 
        ' listarproductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(786, 343)
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
        Name = "listarproductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lista de Productos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
