<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label8 = New Label()
        TextBox2 = New TextBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 8.25F)
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(64, 337)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 16)
        Label9.TabIndex = 30
        Label9.Text = "Label9"
        Label9.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 8.25F)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(64, 168)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 16)
        Label7.TabIndex = 28
        Label7.Text = "Label7"
        Label7.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 8.25F)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(64, 104)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 16)
        Label6.TabIndex = 27
        Label6.Text = "Label6"
        Label6.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Century Gothic", 8.25F)
        Button2.Location = New Point(55, 364)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 26
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century Gothic", 8.25F)
        Button1.Location = New Point(136, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 25
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 8.25F)
        TextBox4.Location = New Point(64, 78)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(136, 21)
        TextBox4.TabIndex = 24
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 8.25F)
        TextBox3.Location = New Point(64, 142)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 21)
        TextBox3.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 8.25F)
        Label5.Location = New Point(64, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 16)
        Label5.TabIndex = 18
        Label5.Text = "Ubicación"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 8.25F)
        Label4.Location = New Point(64, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 16)
        Label4.TabIndex = 19
        Label4.Text = "Género"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 8.25F)
        Label3.Location = New Point(64, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 16)
        Label3.TabIndex = 20
        Label3.Text = "Nombre del Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 8.25F)
        Label2.Location = New Point(64, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 16)
        Label2.TabIndex = 21
        Label2.Text = "ID del Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 25)
        Label1.TabIndex = 17
        Label1.Text = "Agregar Clientes"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 8.25F)
        TextBox1.Location = New Point(64, 314)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(136, 21)
        TextBox1.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 8.25F)
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(64, 271)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 16)
        Label8.TabIndex = 29
        Label8.Text = "Label8"
        Label8.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 8.25F)
        TextBox2.Location = New Point(268, 185)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(127, 21)
        TextBox2.TabIndex = 22
        TextBox2.Visible = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Button3
        ' 
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(64, 204)
        Button3.Name = "Button3"
        Button3.Size = New Size(64, 64)
        Button3.TabIndex = 31
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(134, 204)
        Button4.Name = "Button4"
        Button4.Size = New Size(66, 64)
        Button4.TabIndex = 32
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(268, 409)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Clientes"
        Text = "Clientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
