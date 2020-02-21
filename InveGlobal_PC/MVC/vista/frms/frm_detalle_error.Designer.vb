<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detalle_error
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
        Me.txt_detalles = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_confirmados = New System.Windows.Forms.Label()
        Me.lbl_cant_art = New System.Windows.Forms.Label()
        Me.lbl_cant_conf = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_cant_error = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_detalles
        '
        Me.txt_detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detalles.Location = New System.Drawing.Point(9, 25)
        Me.txt_detalles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_detalles.Multiline = True
        Me.txt_detalles.Name = "txt_detalles"
        Me.txt_detalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_detalles.Size = New System.Drawing.Size(775, 391)
        Me.txt_detalles.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_detalles)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(792, 428)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Errores"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_cant_error)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_cant_conf)
        Me.GroupBox2.Controls.Add(Me.lbl_cant_art)
        Me.GroupBox2.Controls.Add(Me.lbl_confirmados)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 458)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 74)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de Articulos:"
        '
        'lbl_confirmados
        '
        Me.lbl_confirmados.AutoSize = True
        Me.lbl_confirmados.Location = New System.Drawing.Point(333, 31)
        Me.lbl_confirmados.Name = "lbl_confirmados"
        Me.lbl_confirmados.Size = New System.Drawing.Size(103, 20)
        Me.lbl_confirmados.TabIndex = 1
        Me.lbl_confirmados.Text = "Confirmados:"
        '
        'lbl_cant_art
        '
        Me.lbl_cant_art.AutoSize = True
        Me.lbl_cant_art.Location = New System.Drawing.Point(191, 31)
        Me.lbl_cant_art.Name = "lbl_cant_art"
        Me.lbl_cant_art.Size = New System.Drawing.Size(18, 20)
        Me.lbl_cant_art.TabIndex = 2
        Me.lbl_cant_art.Text = "0"
        '
        'lbl_cant_conf
        '
        Me.lbl_cant_conf.AutoSize = True
        Me.lbl_cant_conf.Location = New System.Drawing.Point(442, 31)
        Me.lbl_cant_conf.Name = "lbl_cant_conf"
        Me.lbl_cant_conf.Size = New System.Drawing.Size(18, 20)
        Me.lbl_cant_conf.TabIndex = 3
        Me.lbl_cant_conf.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(626, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Errores:"
        '
        'lbl_cant_error
        '
        Me.lbl_cant_error.AutoSize = True
        Me.lbl_cant_error.Location = New System.Drawing.Point(697, 31)
        Me.lbl_cant_error.Name = "lbl_cant_error"
        Me.lbl_cant_error.Size = New System.Drawing.Size(18, 20)
        Me.lbl_cant_error.TabIndex = 5
        Me.lbl_cant_error.Text = "0"
        '
        'frm_detalle_error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(831, 582)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(831, 582)
        Me.Name = "frm_detalle_error"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_detalles As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_cant_error As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_cant_conf As Label
    Friend WithEvents lbl_cant_art As Label
    Friend WithEvents lbl_confirmados As Label
    Friend WithEvents Label1 As Label
End Class
