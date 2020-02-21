Public Class frm_inventario_soporte

#Region "ATRIBUTOS"

    Public Const NOMBRE_CLASE As String = "frm_inventario_soporte"

    Private Const EN_PROCESO As String = "EN PROCESO"
    Private Const NO_INICIADO As String = "NO INICIADO"
    Private Const TERMINADO As String = "TERMINADO"

    Private AMARILLO As Color = ColorTranslator.FromHtml("#F2F5A9")
    Private VERDE As Color = ColorTranslator.FromHtml("#BCF5A9")




    Private __oApControlador As ApControlador

#End Region

#Region "VARIABLES"
    Dim cSentenciaCargaListaSoportes As String = String.Empty
    Dim cSentenciaCargaSoportes As String = String.Empty
    Dim cID_INVENTARIO As Integer = Integer.MinValue
    Dim cId_clave As Integer = Integer.MinValue
    Dim cId_soporte As Integer = Integer.MinValue
    Dim cNro_soporte As Integer = Integer.MinValue
    Dim cNro_tipo_soporte As Integer = Integer.MinValue
    Dim cDescripcion_soporte As String = Integer.MinValue
    Dim cIndice As Integer = Integer.MinValue
    Dim cMenu As ContextMenuStrip
#End Region


#Region "CONSTRUCTORES"

    ''' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <param name="oApControladorParam">Instancia del controlador de la aplicacion</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef oApControladorParam As ApControlador)

        'tomamos la instancia del controlador
        __oApControlador = oApControladorParam

        InitializeComponent()

    End Sub


#End Region



#Region "METODOS"

    ''' <summary>
    ''' CARGA LOS DATOS DE SOPORTES EN EL COMBO
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pCargar_CmbLocaciones()
        'ensamblamos la Consulta SQL
        cSentenciaCargaListaSoportes = "SELECT ID_LOCACION, DESCRIPCION  FROM [VW_LOCACIONES]"

        Try
            'llamamos a funcion de ejecucion de Consulta SQL y cargamos el combobox de Soporte
            Me.cmb_locacion.DataSource = principal.dtEjecutar_ConsultaSQL(cSentenciaCargaListaSoportes)
            Me.cmb_locacion.DisplayMember = "DESCRIPCION"
            Me.cmb_locacion.ValueMember = "ID_LOCACION"
        Catch Ex As Exception
            'mensaje de notificacion
            MessageBox.Show("Error obteniendo Lista de Locaciones.." _
                                    & Chr(13) & Ex.Message, "Datos de Locaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'salimos del sub
            Exit Sub

        End Try

    End Sub

    ''' <summary>
    ''' CARGA LOS DATOS DE SOPORTES EN EL COMBO
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pCargar_CmbSoportes()
        'ensamblamos la Consulta SQL
        cSentenciaCargaListaSoportes = "SELECT ID_SOPORTE, DESCRIPCION  FROM [VW_SOPORTES_ABM]"

        Try
            'llamamos a funcion de ejecucion de Consulta SQL y cargamos el combobox de Soporte
            Me.cmb_soportes.DataSource = principal.dtEjecutar_ConsultaSQL(cSentenciaCargaListaSoportes)
            Me.cmb_soportes.DisplayMember = "DESCRIPCION"
            Me.cmb_soportes.ValueMember = "ID_SOPORTE"
        Catch Ex As Exception
            'mensaje de notificacion
            MessageBox.Show("Error obteniendo Lista de Soportes.." _
                                    & Chr(13) & Ex.Message, "Datos de Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'salimos del sub
            Exit Sub

        End Try

    End Sub
    ''' <summary>
    ''' INSERTA LOS DATOS DE SOPORTES
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pInsertar_Grid(ByVal cId_clave As Integer,
                               ByVal cId_soporte As Integer,
                               ByVal cNro_soporte As Integer,
                               ByVal cNro_tipo_soporte As Integer,
                               ByVal cDescripcion_soporte As String,
                               ByVal CId_locaciones As Integer
                               )
        Try
            cSentenciaSQL = "EXECUTE [SP_INSERTAR_INVENTARIO_SOPORTE] " _
                                                  & "@id_inventario = " & cID_INVENTARIO _
                                                  & ",@id_clave = " & cId_clave _
                                                  & ",@id_soporte = " & cId_soporte _
                                                  & ",@NRO_soporte = " & cNro_soporte _
                                                  & ",@NRO_tipo_soporte = " & cNro_tipo_soporte _
                                                  & ",@descripcion_soporte = '" & UCase(cDescripcion_soporte) & "'" _
                                                  & ",@id_locaciones = " & CId_locaciones

            'llamamos a funcion de Ejecucion de Sentencia SQL
            If principal.bEjecutar_SentenciaSQL(cSentenciaSQL) Then
            End If
            Me.grd_soportes.DataSource = principal.dtEjecutar_ConsultaSQL(cSentenciaCargaSoportes)
            pSolo_Lectura()
            pColorear_Grid()
            pActualizar_Porcentaje()
        Catch Ex As Exception
            'mensaje de notificacion
            MessageBox.Show("Error Insertando Soportes.." _
                                    & Chr(13) & Ex.Message, "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'salimos del sub
            Exit Sub

        End Try

    End Sub

    ''' <summary>
    ''' Pone de Solo Lectura algunos Campos del GRID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pSolo_Lectura()
        Me.grd_soportes.Columns("#").ReadOnly = True
        Me.grd_soportes.Columns("Soporte").ReadOnly = True
        Me.grd_soportes.Columns("Locacion").ReadOnly = True
        Me.grd_soportes.Columns("Conteo1").ReadOnly = True
        Me.grd_soportes.Columns("Conteo2").ReadOnly = True
        Me.grd_soportes.Columns("Conteo3").ReadOnly = True
    End Sub

    Private Sub pNo_Sortable()
        grd_soportes.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        grd_soportes.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        grd_soportes.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        grd_soportes.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        grd_soportes.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        grd_soportes.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        grd_soportes.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub


    ''' <summary>
    ''' Colorea la Grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pColorear_Grid()
        For Each Fila As DataGridViewRow In Me.grd_soportes.Rows
            Dim conteo1 = Fila.Cells(4).Value
            Dim conteo2 = Fila.Cells(5).Value
            Dim conteo3 = Fila.Cells(6).Value
            Dim a = 0
            If conteo1 = EN_PROCESO Then
                Fila.Cells(4).Style.BackColor = AMARILLO
                a = 1
            ElseIf conteo1 = TERMINADO Then
                Fila.Cells(4).Style.BackColor = VERDE
                a = 1
            End If
            If conteo2 = EN_PROCESO Then
                Fila.Cells(5).Style.BackColor = AMARILLO
                a = 1
            ElseIf conteo2 = TERMINADO Then
                Fila.Cells(5).Style.BackColor = VERDE
                a = 1
            End If
            If conteo3 = EN_PROCESO Then
                Fila.Cells(6).Style.BackColor = AMARILLO
                a = 1
            ElseIf conteo3 = TERMINADO Then
                Fila.Cells(6).Style.BackColor = VERDE
                a = 1
            End If
            If a = 1 Then
                Fila.Cells(3).ReadOnly = True
            End If
        Next

    End Sub

    Private Sub pActualizar_Porcentaje()
        Dim conteo1 As Integer
        Dim conteo2 As Integer
        Dim conteo3 As Integer
        Dim cantidad As Integer = grd_soportes.Rows.Count
        For Each Fila As DataGridViewRow In Me.grd_soportes.Rows
            conteo1 += If(Fila.Cells(4).Value = TERMINADO, 1, 0)
            conteo2 += If(Fila.Cells(5).Value = TERMINADO, 1, 0)
            conteo3 += If(Fila.Cells(6).Value = TERMINADO, 1, 0)
        Next
        lbl_conteo1.Text = CInt((conteo1 * 100) / cantidad) & "%"
        lbl_conteo2.Text = CInt((conteo2 * 100) / cantidad) & "%"
        lbl_conteo3.Text = CInt((conteo3 * 100) / cantidad) & "%"

    End Sub


    ''' <summary>
    ''' CARGA LOS DATOS DE SOPORTES EN EL COMBO
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pCargar_Grid()
        'ensamblamos la Consulta SQL
        cSentenciaCargaSoportes = "SELECT Numero as #, Soporte, Locacion, Descripcion, Conteo1, Conteo2, Conteo3  FROM [VW_Inventario_Soporte] where ID_INVENTARIO = " & cID_INVENTARIO & " order by Numero"

        Try
            Dim dt As DataTable = principal.dtEjecutar_ConsultaSQL(cSentenciaCargaSoportes)
            If dt.Rows.Count > 0 Then
                Me.grd_soportes.DataSource = dt
                pNo_Sortable()
            Else
                'ensamblamos la Sentencia SQL
                pInsertar_Grid(cID_INVENTARIO & 111,
                               1,
                               1,
                               1,
                               "POR DEFECTO",
                               1)
                pNo_Sortable()
            End If
            pSolo_Lectura()
            pColorear_Grid()


        Catch Ex As Exception
            'mensaje de notificacion
            MessageBox.Show("Error obteniendo Lista de Soportes.." _
                                    & Chr(13) & Ex.Message, "Datos de Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'salimos del sub
            Exit Sub

        End Try

    End Sub

    ''' <summary>
    ''' Actualiza la descripcion de los soportes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pActualizar_soporte(ByVal id_inventario_soporte As Integer,
                                    ByVal descripcion As String)

        If descripcion.Trim().Length < 1 Then
            MessageBox.Show("La Descripcion no puede estar vacia" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'salimos del sub
            Exit Sub
        End If
        Try
            cSentenciaSQL = "EXECUTE [SP_ACTUALIZAR_INVENTARIO_SOPORTE] " _
                                                  & "@id_inventario = " & cID_INVENTARIO _
                                                  & ",@id_soporte_inventario= " & id_inventario_soporte _
                                                  & ",@descripcion_soporte = '" & UCase(descripcion) & "'"

            'llamamos a funcion de Ejecucion de Sentencia SQL
            If principal.bEjecutar_SentenciaSQL(cSentenciaSQL) Then
            End If
            pActualizar_Porcentaje()

        Catch Ex As Exception
            'mensaje de notificacion
            MessageBox.Show("Error Actualizando Soportes.." _
                                    & Chr(13) & Ex.Message, "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'salimos del sub
            Exit Sub

        End Try

    End Sub


    Private Function Estado_Soporte(ByVal estado As String) As Boolean
        If estado = EN_PROCESO Or estado = TERMINADO Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Elimina una fila de los soportes creados
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EliminarFila()
        Try
            If Me.grd_soportes.Rows(cIndice).Cells(0).Value = 1 Then
                MessageBox.Show("El soporte 1 no puede ser eliminado" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Estado_Soporte(Me.grd_soportes.Rows(cIndice).Cells(4).Value) Then
                MessageBox.Show("El soporte no puede ser eliminado" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Estado_Soporte(Me.grd_soportes.Rows(cIndice).Cells(5).Value) Then
                MessageBox.Show("El soporte no puede ser eliminado" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Estado_Soporte(Me.grd_soportes.Rows(cIndice).Cells(6).Value) Then
                MessageBox.Show("El soporte no puede ser eliminado" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim id As Integer = Me.grd_soportes.Rows(cIndice).Cells(0).Value

            cSentenciaSQL = "EXECUTE [SP_ELIMINAR_INVENTARIO_SOPORTE] " _
                                                  & "@id_inventario_soporte = " & id

            'llamamos a funcion de Ejecucion de Sentencia SQL
            If principal.bEjecutar_SentenciaSQL(cSentenciaSQL) Then
            End If
            Me.grd_soportes.DataSource = principal.dtEjecutar_ConsultaSQL(cSentenciaCargaSoportes)
            pSolo_Lectura()
            pColorear_Grid()
            pActualizar_Porcentaje()
        Catch Ex As Exception
            'mensaje de notificacion
            MessageBox.Show("Error eliminado Soportes.." _
                                    & Chr(13) & Ex.Message, "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'salimos del sub
            Exit Sub

        End Try

    End Sub

#End Region


#Region "EVENTOS"

    Private Sub Frm_inventario_soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cID_INVENTARIO = __oApControlador.Inventario_OTD.nId
        lbl_Idinventario.Text = cID_INVENTARIO.ToString()
        pCargar_CmbSoportes()
        tmr_colorear.Enabled = True
    End Sub

    Private Sub btn_guardar_grid_Click(sender As Object, e As EventArgs) Handles btn_guardar_grid.Click
        Dim Bandera = 0
        For Each Fila As DataGridViewRow In Me.grd_soportes.Rows
            Dim id = Fila.Cells(0).Value
            Dim valor = Fila.Cells(3).Value
            If IsDBNull(valor) Then
                Bandera = 1
            Else
                pActualizar_soporte(id, valor)
            End If

        Next
        If Bandera = 1 Then
            MessageBox.Show("La Fila Con la Descripcion Vacia no fue actualizada" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.grd_soportes.DataSource = principal.dtEjecutar_ConsultaSQL(cSentenciaCargaSoportes)
        pSolo_Lectura()
        pColorear_Grid()
    End Sub

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        cDescripcion_soporte = txt_descripcion.Text.Trim()
        If cDescripcion_soporte.Length < 1 Then
            MessageBox.Show("La Descripcion no puede estar vacia" _
                                    , "Soportes", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'salimos del sub
            Exit Sub
        End If
        cId_soporte = cmb_soportes.SelectedValue
        Dim CId_locaciones As Integer = cmb_locacion.SelectedValue
        Dim cantidad = Me.grd_soportes.Rows.Count + 1
        cId_clave = cID_INVENTARIO & cId_soporte & cantidad & cantidad
        pInsertar_Grid(
            cId_clave,
            cId_soporte,
            cantidad,
            cantidad,
            cDescripcion_soporte,
            CId_locaciones)
        txt_descripcion.Text = ""

    End Sub

    Private Sub grd_soportes_MouseDown(sender As Object, e As MouseEventArgs) Handles grd_soportes.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim Mi_Test As DataGridView.HitTestInfo = Me.grd_soportes.HitTest(e.X, e.Y)
            If Mi_Test.Type = DataGridViewHitTestType.Cell Then
                If Mi_Test.RowIndex >= 0 Then
                    cIndice = Mi_Test.RowIndex
                    Me.grd_soportes.CurrentCell = Me.grd_soportes.Rows(Mi_Test.RowIndex).Cells(Mi_Test.ColumnIndex)
                    Me.grd_soportes.Rows(Mi_Test.RowIndex).Selected = True
                    cMenu = New ContextMenuStrip()
                    cMenu.Items.Add("Eliminar", Nothing, New EventHandler(AddressOf EliminarFila))
                    Me.grd_soportes.ContextMenuStrip = cMenu
                End If
            End If
        End If
    End Sub

    Private Sub Tmr_colorear_Tick(sender As Object, e As EventArgs) Handles tmr_colorear.Tick
        pCargar_Grid()
        pCargar_CmbLocaciones()
        pActualizar_Porcentaje()
        tmr_colorear.Enabled = False
    End Sub

    Private Sub Btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        pCargar_Grid()
        pActualizar_Porcentaje()
    End Sub


#End Region


End Class