<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
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
        PanelCabecera = New Panel()
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        Button5 = New Button()
        MenuStrip1 = New MenuStrip()
        PanelCabecera.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCabecera
        ' 
        PanelCabecera.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        PanelCabecera.Controls.Add(PictureBox2)
        PanelCabecera.Controls.Add(Label7)
        PanelCabecera.Controls.Add(Button5)
        PanelCabecera.Dock = DockStyle.Top
        PanelCabecera.Location = New Point(126, 0)
        PanelCabecera.Name = "PanelCabecera"
        PanelCabecera.Size = New Size(306, 30)
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
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Image = My.Resources.Resources.Icono_cerrar_FN
        Button5.Location = New Point(369, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(30, 24)
        Button5.TabIndex = 0
        Button5.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(126, 450)
        MenuStrip1.TabIndex = 12
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' App
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 450)
        Controls.Add(PanelCabecera)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "App"
        Text = "App"
        PanelCabecera.ResumeLayout(False)
        PanelCabecera.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
