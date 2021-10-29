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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Label8.Location = New System.Drawing.Point(753, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 36)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(235, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 39)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Registro de usuarios"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.GroupBox1.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 215)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(232, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña"
        Me.Label3.Visible = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(193, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de usuario"
        Me.Label2.Visible = false
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = ""
        Me.BunifuMaterialTextbox2.isPassword = false
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox2.LineThickness = 4
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(51, 119)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(462, 54)
        Me.BunifuMaterialTextbox2.TabIndex = 3
        Me.BunifuMaterialTextbox2.Text = "Contraseña"
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = false
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox1.LineThickness = 4
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(38, 21)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(462, 54)
        Me.BunifuMaterialTextbox1.TabIndex = 2
        Me.BunifuMaterialTextbox1.Text = "Nombre de usuario"
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(22, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(754, 289)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = false
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Actualizar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = true
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = true
        Me.BunifuFlatButton1.IconZoom = 90R
        Me.BunifuFlatButton1.IsTab = false
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(497, 615)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = false
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton1.TabIndex = 22
        Me.BunifuFlatButton1.Text = "Actualizar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToResizeColumns = false
        Me.DataGridView1.AllowUserToResizeRows = false
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(22, 354)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = false
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(754, 230)
        Me.DataGridView1.TabIndex = 24
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Eliminar"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = true
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = true
        Me.BunifuFlatButton2.IconZoom = 90R
        Me.BunifuFlatButton2.IsTab = false
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(76, 615)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = false
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton2.TabIndex = 25
        Me.BunifuFlatButton2.Text = "Eliminar"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 746)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
End Class
