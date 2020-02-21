<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_importar_carga
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.num_conteo = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.num_nro_soporte = New System.Windows.Forms.NumericUpDown()
        Me.cmb_soportes = New System.Windows.Forms.ComboBox()
        Me.num_metro = New System.Windows.Forms.NumericUpDown()
        Me.num_nivel = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_locaciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_importar = New System.Windows.Forms.Button()
        Me.prg_conteo = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.num_conteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_nro_soporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_metro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_nivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prg_conteo)
        Me.GroupBox1.Controls.Add(Me.num_conteo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.num_nro_soporte)
        Me.GroupBox1.Controls.Add(Me.cmb_soportes)
        Me.GroupBox1.Controls.Add(Me.num_metro)
        Me.GroupBox1.Controls.Add(Me.num_nivel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_locaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localización a Importar"
        '
        'num_conteo
        '
        Me.num_conteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_conteo.Location = New System.Drawing.Point(126, 41)
        Me.num_conteo.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.num_conteo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_conteo.Name = "num_conteo"
        Me.num_conteo.Size = New System.Drawing.Size(48, 35)
        Me.num_conteo.TabIndex = 14
        Me.num_conteo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 25)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Conteo : "
        '
        'num_nro_soporte
        '
        Me.num_nro_soporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_nro_soporte.Location = New System.Drawing.Point(346, 86)
        Me.num_nro_soporte.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_nro_soporte.Name = "num_nro_soporte"
        Me.num_nro_soporte.Size = New System.Drawing.Size(70, 35)
        Me.num_nro_soporte.TabIndex = 17
        Me.num_nro_soporte.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmb_soportes
        '
        Me.cmb_soportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_soportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_soportes.FormattingEnabled = True
        Me.cmb_soportes.Location = New System.Drawing.Point(126, 86)
        Me.cmb_soportes.Name = "cmb_soportes"
        Me.cmb_soportes.Size = New System.Drawing.Size(220, 37)
        Me.cmb_soportes.TabIndex = 15
        '
        'num_metro
        '
        Me.num_metro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_metro.Location = New System.Drawing.Point(524, 86)
        Me.num_metro.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.num_metro.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_metro.Name = "num_metro"
        Me.num_metro.Size = New System.Drawing.Size(80, 35)
        Me.num_metro.TabIndex = 20
        Me.num_metro.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_nivel
        '
        Me.num_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_nivel.Location = New System.Drawing.Point(685, 84)
        Me.num_nivel.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.num_nivel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_nivel.Name = "num_nivel"
        Me.num_nivel.Size = New System.Drawing.Size(80, 35)
        Me.num_nivel.TabIndex = 19
        Me.num_nivel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(444, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Metro : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(615, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nivel : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Soporte : "
        '
        'cmb_locaciones
        '
        Me.cmb_locaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_locaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_locaciones.FormattingEnabled = True
        Me.cmb_locaciones.Location = New System.Drawing.Point(306, 39)
        Me.cmb_locaciones.Name = "cmb_locaciones"
        Me.cmb_locaciones.Size = New System.Drawing.Size(298, 37)
        Me.cmb_locaciones.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Locación : "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_importar
        '
        Me.btn_importar.BackgroundImage = Global.InveStock_PC_2.My.Resources.Resources.excel
        Me.btn_importar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_importar.Location = New System.Drawing.Point(825, 74)
        Me.btn_importar.Name = "btn_importar"
        Me.btn_importar.Size = New System.Drawing.Size(63, 61)
        Me.btn_importar.TabIndex = 1
        Me.btn_importar.UseVisualStyleBackColor = True
        '
        'prg_conteo
        '
        Me.prg_conteo.Location = New System.Drawing.Point(10, 129)
        Me.prg_conteo.Name = "prg_conteo"
        Me.prg_conteo.Size = New System.Drawing.Size(787, 23)
        Me.prg_conteo.TabIndex = 2
        '
        'frm_importar_carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 208)
        Me.Controls.Add(Me.btn_importar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(910, 247)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(910, 247)
        Me.Name = "frm_importar_carga"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Conteos desde Excel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.num_conteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_nro_soporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_metro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_nivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents num_conteo As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents num_nro_soporte As NumericUpDown
    Friend WithEvents cmb_soportes As ComboBox
    Friend WithEvents num_metro As NumericUpDown
    Friend WithEvents num_nivel As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_locaciones As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_importar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents prg_conteo As ProgressBar
End Class
