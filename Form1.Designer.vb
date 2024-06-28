<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PanelCabecera = New Panel()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        PanelCabecera.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(203, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 23)
        Label1.TabIndex = 4
        Label1.Text = "inicio de sesion"
        ' 
        ' PanelCabecera
        ' 
        PanelCabecera.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        PanelCabecera.Controls.Add(Label1)
        PanelCabecera.Dock = DockStyle.Top
        PanelCabecera.Location = New Point(0, 0)
        PanelCabecera.Name = "PanelCabecera"
        PanelCabecera.Size = New Size(564, 30)
        PanelCabecera.TabIndex = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image
        PictureBox1.Location = New Point(263, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(301, 235)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 5
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(135, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 35)
        Button1.TabIndex = 0
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.AllowDrop = True
        TextBox1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(61, 133)
        TextBox1.Name = "TextBox1"
        TextBox1.ShortcutsEnabled = False
        TextBox1.Size = New Size(141, 22)
        TextBox1.TabIndex = 1
        TextBox1.UseSystemPasswordChar = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(61, 69)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(141, 22)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(61, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 16)
        Label2.TabIndex = 4
        Label2.Text = "USUARIO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(61, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 16)
        Label3.TabIndex = 4
        Label3.Text = "CONTRASEÑA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(67, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 6
        Label5.Text = "error"
        Label5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(67, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 15)
        Label6.TabIndex = 6
        Label6.Text = "error"
        Label6.Visible = False
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = My.Resources.Resources.eye_slash_visible_hide_hidden_show_icon_145987__3_
        Button2.Location = New Point(204, 130)
        Button2.Name = "Button2"
        Button2.Size = New Size(26, 23)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.eye_visible_hide_hidden_show_icon_145988__1_
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(203, 128)
        Button3.Name = "Button3"
        Button3.Size = New Size(31, 25)
        Button3.TabIndex = 8
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatAppearance.BorderSize = 5
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(50, 173)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 35)
        Button4.TabIndex = 9
        Button4.Text = "Registrar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(564, 238)
        Controls.Add(PanelCabecera)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(1000, 600)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TransparencyKey = SystemColors.ActiveBorder
        PanelCabecera.ResumeLayout(False)
        PanelCabecera.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
