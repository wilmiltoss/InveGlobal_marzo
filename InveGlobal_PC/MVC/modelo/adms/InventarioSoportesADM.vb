Imports CdgPersistencia.ClasesBases

Public Class InventarioSoportesADM
    Inherits ADMbase

#Region "ATRIBUTOS"

    Public Const NOMBRE_CLASE As String = "InventarioSoportesADM"

    Private __oApModelo As ApModelo


#End Region


#Region "CONSTRUCTORES"

    Public Sub New(ByVal ApModeloParam As ApModelo)
        MyBase.New(ApModeloParam.Get_conector())

        __oApModelo = ApModelo.Get_instancia()
        Set_tabla(New InventarioSoportesTBL())

    End Sub

#End Region


#Region "Miembros de ADMbase"

    Public Overrides Function lAgregar(ByVal oOTDbase As OTDbase) As List(Of Object)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function lActualizar(ByVal oOTDbase As OTDbase) As List(Of Object)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function lEliminar(ByVal oOTDbase As OTDbase) As List(Of Object)

    End Function

    Public Overrides Function lGet_elemento(ByVal oInvetarioParam As OTDbase) As List(Of Object)

        Dim NOMBRE_METODO As String = NOMBRE_CLASE + ".lGet_elemento()"

        'resultado por defecto del metodo
        Dim lResultado As New List(Of Object)(New Object() {0, NOMBRE_METODO & " No Ejecutado!"})

        'intentamos recuperar los datos
        Try
            'casteamos el parametro a su tipo
            Dim oInvetario As InventarioSoporteOTD = CType(oInvetarioParam, InventarioSoporteOTD)

            'establecemos la sentencia de filtrado de registros
            Dim cFiltroWhere As String = String.Format(" WHERE {0}.{1} = {2} AND {0}.{3} = {4}" _
                                                       , InventariosSectoresTBL.NOMBRE_TABLA _
                                                       , InventariosSectoresTBL.ID_INVENTARIO.cNombre _
                                                       , oInvetario.nIdInventario
                                                       )

            'ejecutamos la busqueda filtrada
            lResultado = lGet_elementos(cFiltroWhere)

            'si se ejecuto correctamente
            If lResultado(0).Equals(1) Then
                'establecemos el resultado del metodo
                lResultado = New List(Of Object)(New Object() {1, CType(lResultado(1), List(Of InventarioSoporteOTD))(0)})

            End If

        Catch ex As Exception

            'en caso de error
            lResultado = New List(Of Object)(New Object() {-1, NOMBRE_METODO & " Error: " & ex.Message})

        End Try

        'devolvemos el resultado del metodo
        Return lResultado


    End Function

    Public Overrides Function lGet_elementos(ByVal cFiltroWhere As String) As List(Of Object)

        Dim NOMBRE_METODO As String = NOMBRE_CLASE + ".lGet_elementos()"

        'resultado por defecto del metodo
        Dim lResultado As New List(Of Object)(New Object() {0, NOMBRE_METODO & " No Ejecutado!"})

        'intentamos recuperar los datos
        Try
            'ensamblamos la consulta sql
            Dim cConsulta As String = String.Format(_Select_sql & cFiltroWhere)

            'busqueda filtrada
            lResultado = _oConector.lEjecutar_consulta(cConsulta)

            'si se ejecuto correctamente
            If lResultado(0).Equals(1) Then
                'instancias auxiliares
                Dim lInveSoporte As New List(Of InventarioSoporteOTD)()
                Dim dtResultado As DataTable = CType(lResultado(1), DataTable)

                'recorremos las filas devueltas
                For Each dr As DataRow In dtResultado.Rows
                    'lo agregamos a la lista
                    lInveSoporte.Add(New InventarioSoporteOTD(Integer.Parse(dr(InventarioSoportesTBL.ID_INVENTARIO_SOPORTES.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.ID_INVENTARIO.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.ID_CLAVE.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.ID_SOPORTE.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.NRO_SOPORTE.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.NRO_TIPO_SOPORTE.cCampoParametro).ToString()) _
                                            , dr(InventarioSoportesTBL.DESCRIPCION_SOPORTE.cCampoParametro).ToString() _
                                            , Integer.Parse(dr(InventarioSoportesTBL.CONTEO1.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.CONTEO2.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.CONTEO3.cCampoParametro).ToString()) _
                                            , Integer.Parse(dr(InventarioSoportesTBL.ID_LOCACIONES.cCampoParametro).ToString())
                                           ))

                Next

                'establecemos el resultado del metodo
                lResultado = New List(Of Object)(New Object() {1, lInveSoporte})

            End If

        Catch ex As Exception

            'en caso de error
            lResultado = New List(Of Object)(New Object() {-1, NOMBRE_METODO & " Error: " & ex.Message})

        End Try

        'devolvemos el resultado del metodo
        Return lResultado

    End Function

#End Region


#Region "ESPECIFICOS"


#End Region

End Class
