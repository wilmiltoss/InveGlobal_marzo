<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventario_soporte
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_locacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cmb_soportes = New System.Windows.Forms.ComboBox()
        Me.tmr_colorear = New System.Windows.Forms.Timer(Me.components)
        Me.grd_soportes = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_conteo1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_conteo2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_conteo3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Idinventario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_guardar_grid = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_soportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_locacion)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.cmb_soportes)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(701, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Locacion"
        '
        'cmb_locacion
        '
        Me.cmb_locacion.FormattingEnabled = True
        Me.cmb_locacion.Location = New System.Drawing.Point(337, 38)
        Me.cmb_locacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_locacion.Name = "cmb_locacion"
        Me.cmb_locacion.Size = New System.Drawing.Size(285, 23)
        Me.cmb_locacion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Soporte"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(27, 82)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(595, 21)
        Me.txt_descripcion.TabIndex = 1
        '
        'cmb_soportes
        '
        Me.cmb_soportes.FormattingEnabled = True
        Me.cmb_soportes.Location = New System.Drawing.Point(27, 38)
        Me.cmb_soportes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_soportes.Name = "cmb_soportes"
        Me.cmb_soportes.Size = New System.Drawing.Size(285, 23)
        Me.cmb_soportes.TabIndex = 0
        '
        'tmr_colorear
        '
        '
        'grd_soportes
        '
        Me.grd_soportes.AllowUserToAddRows = False
        Me.grd_soportes.AllowUserToDeleteRows = False
        Me.grd_soportes.AllowUserToResizeRows = False
        Me.grd_soportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_soportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.grd_soportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_soportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grd_soportes.Location = New System.Drawing.Point(17, 23)
        Me.grd_soportes.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_soportes.Name = "grd_soportes"
        Me.grd_soportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grd_soportes.Size = New System.Drawing.Size(663, 308)
        Me.grd_soportes.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 354)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CONTEO 1:"
        '
        'lbl_conteo1
        '
        Me.lbl_conteo1.AutoSize = True
        Me.lbl_conteo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conteo1.Location = New System.Drawing.Point(163, 352)
        Me.lbl_conteo1.Name = "lbl_conteo1"
        Me.lbl_conteo1.Size = New System.Drawing.Size(54, 20)
        Me.lbl_conteo1.TabIndex = 5
        Me.lbl_conteo1.Text = "000%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(225, 354)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "CONTEO 2:"
        '
        'lbl_conteo2
        '
        Me.lbl_conteo2.AutoSize = True
        Me.lbl_conteo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conteo2.Location = New System.Drawing.Point(309, 352)
        Me.lbl_conteo2.Name = "lbl_conteo2"
        Me.lbl_conteo2.Size = New System.Drawing.Size(54, 20)
        Me.lbl_conteo2.TabIndex = 7
        Me.lbl_conteo2.Text = "000%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(371, 354)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "CONTEO 3:"
        '
        'lbl_conteo3
        '
        Me.lbl_conteo3.AutoSize = True
        Me.lbl_conteo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conteo3.Location = New System.Drawing.Point(455, 352)
        Me.lbl_conteo3.Name = "lbl_conteo3"
        Me.lbl_conteo3.Size = New System.Drawing.Size(54, 20)
        Me.lbl_conteo3.TabIndex = 9
        Me.lbl_conteo3.Text = "000%"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_refresh)
        Me.GroupBox2.Controls.Add(Me.lbl_conteo3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lbl_conteo2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbl_conteo1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btn_guardar_grid)
        Me.GroupBox2.Controls.Add(Me.grd_soportes)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 158)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(701, 398)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lbl_Idinventario
        '
        Me.lbl_Idinventario.AutoSize = True
        Me.lbl_Idinventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Idinventario.Location = New System.Drawing.Point(666, 2)
        Me.lbl_Idinventario.Name = "lbl_Idinventario"
        Me.lbl_Idinventario.Size = New System.Drawing.Size(54, 24)
        Me.lbl_Idinventario.TabIndex = 5
        Me.lbl_Idinventario.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(566, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "INVENTARIO:"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.SystemColors.Control
        Me.btn_refresh.BackgroundImage = Global.InveStock_PC_2.My.Resources.Resources.refresh
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh.Location = New System.Drawing.Point(572, 337)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(50, 49)
        Me.btn_refresh.TabIndex = 10
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_guardar_grid
        '
        Me.btn_guardar_grid.BackColor = System.Drawing.SystemColors.Control
        Me.btn_guardar_grid.BackgroundImage = Global.InveStock_PC_2.My.Resources.Resources.guardar
        Me.btn_guardar_grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar_grid.Location = New System.Drawing.Point(630, 337)
        Me.btn_guardar_grid.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar_grid.Name = "btn_guardar_grid"
        Me.btn_guardar_grid.Size = New System.Drawing.Size(50, 49)
        Me.btn_guardar_grid.TabIndex = 1
        Me.btn_guardar_grid.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = Global.InveStock_PC_2.My.Resources.Resources.agregar
        Me.btn_agregar.Location = New System.Drawing.Point(639, 53)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(41, 38)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'frm_inventario_soporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 569)
        Me.Controls.Add(Me.lbl_Idinventario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(744, 608)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(744, 608)
        Me.Name = "frm_inventario_soporte"
        Me.Text = "Soporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_soportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents cmb_soportes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_locacion As ComboBox
    Friend WithEvents tmr_colorear As Timer
    Friend WithEvents grd_soportes As DataGridView
    Friend WithEvents btn_guardar_grid As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_conteo1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_conteo2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_conteo3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents lbl_Idinventario As Label
    Friend WithEvents Label3 As Label
End Class
