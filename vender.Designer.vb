<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vender
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
        Label8 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(44, 159)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 38
        Label8.Text = "Label8"
        Label8.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(44, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 37
        Label6.Text = "Label6"
        Label6.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(36, 182)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 36
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(117, 182)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 35
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(44, 69)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(136, 23)
        TextBox4.TabIndex = 34
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(44, 133)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 23)
        TextBox2.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 31
        Label4.Text = "Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(44, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 17)
        Label2.TabIndex = 32
        Label2.Text = "ID del Producto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 25)
        Label1.TabIndex = 30
        Label1.Text = "Vender Productos"
        ' 
        ' vender
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(230, 225)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "vender"
        Text = "vender"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
