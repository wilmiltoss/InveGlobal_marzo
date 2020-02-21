Imports System.Data.OleDb
Imports System.IO
Imports InveStock_PC_2

Public Class frm_importar_carga
#Region "ATRIBUTOS"

    Private oBoolean As Boolean = False
    Private oTotal As Integer = 0
    Public Const NOMBRE_CLASE As String = "frm_importar_carga"

    Public __oApControlador As ApControlador
    Private oRespuesta As String = String.Empty
    Private oConf As Integer = 0
    Private oError As Integer = 0

    Private __lLocaciones As List(Of LocacionOTD)
    Private __lSoportes As List(Of SoporteOTD)

    Private __oCargaManual As CargaManualOTD

    Private __oLocacion As LocacionOTD
    Private __oSoporte As SoporteOTD

#End Region

#Region "CONTRUCTORES "

    Public Sub New(ByRef oApControladorParam As ApControlador)
        __oApControlador = oApControladorParam

        InitializeComponent()
    End Sub

#End Region




#Region "METODOS"

    Private Function __bDatos_validos() As Boolean

        'resultado por defecto
        Dim bResultado As Boolean = False

        If __oLocacion Is Nothing Or __oSoporte Is Nothing Then
            __oLocacion = CType(cmb_locaciones.SelectedItem, LocacionOTD)
            __oSoporte = CType(cmb_soportes.SelectedItem, SoporteOTD)

        End If

        'si hay una locacion seleccionada
        If __oLocacion.nId > 0 Then
            'si hay un soporte seleccionado
            If __oSoporte.nId > 0 Then
                bResultado = True
            Else
                'sino, mensaje de notificacion
                __oApControlador.notificar_stop("Seleccione un Soporte válido!", "Carga manual")
            End If
        Else
            'sino, mensaje de notificacion
            __oApControlador.notificar_stop("Seleccione una Locación válida!", "Carga manual")
        End If

        'devolvemos el resultado del metodo
        Return bResultado

    End Function
    Public Function GetData(ByVal FileName As String) As List(Of List(Of String))
        Dim List As New List(Of List(Of String))
        Try
            Using cn As New OleDbConnection With
            {
                .ConnectionString = ConnectionString(FileName)
            }
                cn.Open()
                Dim myTableName = cn.GetSchema("Tables").Rows(0)("TABLE_NAME")
                Dim cmd As OleDbCommand = New OleDbCommand(String.Format("SELECT codigo,sum(depodevol),descripcion FROM [{0}] Group by codigo, descripcion", myTableName), cn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read
                    Dim valueList As New List(Of String)
                    valueList.Add(reader.GetValue(0).ToString())
                    valueList.Add(reader.GetValue(1).ToString())
                    valueList.Add(reader.GetValue(2).ToString())
                    List.Add(valueList)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString() _
                                        , "GetData", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return List
    End Function
    Public Function ConnectionString(ByVal FileName As String) As String
        Dim Builder As New OleDbConnectionStringBuilder
        If IO.Path.GetExtension(FileName).ToUpper = ".XLS" Then
            Builder.Provider = "Microsoft.Jet.OLEDB.4.0"
            Builder.Add("Extended Properties", "Excel 8.0;IMEX=1;HDR=Yes;")
        Else
            Builder.Provider = "Microsoft.ACE.OLEDB.12.0"
            Builder.Add("Extended Properties", "Excel 12.0;IMEX=1;HDR=Yes;")
        End If

        Builder.DataSource = FileName

        Return Builder.ConnectionString

    End Function

    Private Sub __cargar_combos()

        Dim lResultado As List(Of Object)

        'recuperamos la lista de locaciones disponibles
        lResultado = __oApControlador.oApModelo.Locaciones_ADM().lGet_elementos(String.Empty)

        'si se ejecuto crrectamente, tomamos la lista devuelta
        If lResultado(0).Equals(1) Then __lLocaciones = CType(lResultado(1), List(Of LocacionOTD))

        'recuperamos la lista de soportes disponibles
        lResultado = __oApControlador.oApModelo.Soportes_ADM().lGet_elementos(String.Empty)

        'si se ejecuto correctamente, tomamos la lista devuelta
        If lResultado(0).Equals(1) Then __lSoportes = CType(lResultado(1), List(Of SoporteOTD))

        'asignamos los origenes de datos de los combos
        cmb_locaciones.DataSource = __lLocaciones
        cmb_soportes.DataSource = __lSoportes
        cmb_locaciones.DisplayMember = "cDescripcion"
        cmb_soportes.DisplayMember = "cDescripcion"

        'mostramos los elementos de la primera posicion de cada lista
        cmb_locaciones.SelectedIndex = 0
        cmb_soportes.SelectedIndex = 0


    End Sub

    Private Sub __guardar_conteo(ByVal scanning As String, ByVal nombre As String, ByVal cantidad As String)

        Dim NOMBRE_METODO As String = NOMBRE_CLASE & ".__guardar_conteo()"

        Try
            'si la cantidad ingresada supera el limite
            If Val(cantidad) > __oApControlador.Inventario_OTD.Configuracion_OTD.nConteoMaximo Then

                If Not __oApControlador.Inventario_OTD.Configuracion_OTD.nConteoMaximo.Equals(0) Then
                    'mensaje de notificacion
                    oBoolean = True
                    oError = oError + 1
                    oRespuesta &= scanning & ",  " & nombre & ", La Cantidad:" & cantidad & " Supera el Limite Establecido" & vbCrLf
                    Exit Sub
                End If
            End If
            __oCargaManual = New CargaManualOTD()
            'asignamos los atributos del conteo
            __oCargaManual.nIdInventario = __oApControlador.Inventario_OTD.nId
            __oCargaManual.cColector = __oApControlador.cNombrePc
            __oCargaManual.nIdLocacion = __oLocacion.nId
            __oCargaManual.nNroConteo = Integer.Parse(num_conteo.Value)

            __oCargaManual.nIdSoporte = __oSoporte.nId
            __oCargaManual.nNroSoporte = Integer.Parse(num_nro_soporte.Value)
            __oCargaManual.nIdLetraSoporte = 1
            __oCargaManual.nNivel = Integer.Parse(num_nivel.Value)

            __oCargaManual.nMetro = Integer.Parse(num_metro.Value)
            __oCargaManual.nIdInventario = __oApControlador.Inventario_OTD.nId
            __oCargaManual.cColector = __oApControlador.cNombrePc
            __oCargaManual.cScanning = scanning
            __oCargaManual.nCantidad = Val(cantidad)
            __oCargaManual.nIdUsuario = __oApControlador.Usuario_OTD.nId

            'variable para resultados
            Dim lResultado As New List(Of Object)

            'llamamos al metodo de ejecucion de insercion de registro nuevo
            lResultado = __oApControlador.oApModelo.CargasManuales_ADM().lAgregar(__oCargaManual)


            'si NO se ejecuto correctamente
            If Not lResultado(0).Equals(1) Then
                'mensaje de notificacion
                oBoolean = True
                oRespuesta &= scanning & ",  " & nombre & ", " & lResultado(1).ToString() & vbCrLf
                oError = oError + 1

            Else
                oConf = oConf + 1

            End If

        Catch Ex As Exception
            'en caso de error, mensaje de notificacion
            oBoolean = True
            oError = oError + 1
            oRespuesta &= scanning & ",  " & nombre & ", " & Ex.Message.ToString() & vbCrLf

        End Try


    End Sub

    Private Sub __validar_conteos()

        Dim NOMBRE_METODO As String = NOMBRE_CLASE & ".__validar_conteos()"

        Try
            'ejecutamos llamamos al metodo de toma de datos de conteos manuales
            Dim lResultado As List(Of Object) = __oApControlador.oApModelo.CargasManuales_ADM().lTomar_conteos(__oApControlador.Inventario_OTD _
                                                                                                               , __oApControlador.cNombrePc)

            'si se ejecuto correctamente
            If lResultado(0).Equals(1) Then
                'mensaje de notificacion de exito
                __oApControlador.notificar_exito("Conteos Manuales validados correctamente!", ApControlador.NOMBRE_APLICACION)

            Else
                'sino, mensaje de notificacion
                __oApControlador.notificar_error(lResultado(1).ToString(), NOMBRE_METODO)

            End If

        Catch ex As Exception
            'en caso de error, mensaje de notificacion
            __oApControlador.notificar_error(NOMBRE_METODO & " Error: " & ex.Message, "Cargas Manuales")

        End Try


    End Sub

#End Region

#Region "EVENTOS"



#Region "FORMULARIO"
    Private Sub Frm_importar_carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prg_conteo.Visible = False
        __cargar_combos()

    End Sub



    Private Sub Btn_importar_Click(sender As Object, e As EventArgs) Handles btn_importar.Click

        __bDatos_validos()
        If __bDatos_validos() Then
            oBoolean = False
            oError = 0
            oConf = 0
            prg_conteo.Value = 0
            oRespuesta = String.Empty
            Dim Dialog As OpenFileDialog
            Dialog = OpenFileDialog1
            Dialog.Filter = "Excel files(*.xls)|*.xls|All files (*.*)|*.*"
            Dialog.FileName = ""
            Dim result As DialogResult = Dialog.ShowDialog()

            ' Test result.
            If result = Windows.Forms.DialogResult.OK Then

                ' Get the file name.
                Dim path As String = OpenFileDialog1.FileName
                Try
                    Dim valueList As List(Of List(Of String)) = GetData(path)

                    oTotal = valueList.Count
                    prg_conteo.Visible = True
                    prg_conteo.Maximum = oTotal
                    For Each value As List(Of String) In valueList
                        __guardar_conteo(value(0), value(2), value(1))
                        prg_conteo.Value += 1
                        Refresh()


                    Next
                    If oBoolean Then
                        Dim frm_error As frm_detalle_error = New frm_detalle_error()
                        frm_error.oRespuesta = oRespuesta
                        frm_error.oCant = oTotal
                        frm_error.oConf = oConf
                        frm_error.oError = oError
                        frm_error.ShowDialog()

                    Else
                        MessageBox.Show("Se importaron en total: " & oTotal & " Aticulos " _
                                        , "Importacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    If oConf > 0 Then
                        __validar_conteos()
                    End If
                    prg_conteo.Visible = False
                Catch ex As Exception
                    prg_conteo.Visible = False
                    MessageBox.Show(ex.Message.ToString() _
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If


    End Sub

#End Region

#End Region


End Class