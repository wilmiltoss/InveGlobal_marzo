Imports CdgPersistencia.ClasesBases
Imports CdgPersistencia.Componentes
Public Class InventarioSoportesSQLiteTBL
    Inherits TBLbase

#Region "ATRIBUTOS"


    Public Const NOMBRE_CLASE As String = "InventarioSopotesSQLiteTBL"
    Public Shadows Const NOMBRE_TABLA As String = "INVENTARIO_SOPORTE"

    ''' <summary>
    ''' Comando de eliminacion de la tabla
    ''' </summary>
    ''' <remarks></remarks>
    Public Const SQL_DROP_TABLA As String = "DROP TABLE IF EXISTS INVENTARIO_SOPORTE"
    ''' <summary>
    ''' Comando de creacion de la tabla
    ''' </summary>
    ''' <remarks></remarks>
    Public Const SQL_CREAR_TABLA As String = "CREATE TABLE INVENTARIO_SOPORTE ([ID_INVENTARIO_SOPORTE] INT(11),[ID_INVENTARIO] _
                                              INT(11),[ID_CLAVE] INT(11),[ID_SOPORTE] INT(11),[NRO_SOPORTE] INT(11), _
                                              [NRO_TIPO_SOPORTE] INT(11),[DESCRIPCION_SOPORTE] STRING(200),[CONTEO1] _
                                              INT(11),[CONTEO2] INT(11),[CONTEO3] INT(11),[ID_LOCACIONES] INT(11))"

    'nombres de campos
    Public Shared ID_INVENTARIO_SOPORTE As New Campo("ID_INVENTARIO_SOPORTE", 0, False, GetType(Integer))
    Public Shared ID_INVENTARIO As New Campo("ID_INVENTARIO", 0, False, GetType(Integer))
    Public Shared ID_CLAVE As New Campo("ID_CLAVE", 1, False, GetType(Integer))
    Public Shared ID_SOPORTE As New Campo("ID_SOPORTE", 1, False, GetType(Integer))
    Public Shared NRO_SOPORTE As New Campo("NRO_SOPORTE", 0, False, GetType(Integer))
    Public Shared NRO_TIPO_SOPORTE As New Campo("NRO_TIPO_SOPORTE", 1, False, GetType(Integer))
    Public Shared DESCRIPCION_SOPORTE As New Campo("DESCRIPCION_SOPORTE", 0, False, GetType(String))
    Public Shared CONTEO1 As New Campo("CONTEO1", 1, False, GetType(Integer))
    Public Shared CONTEO2 As New Campo("CONTEO2", 0, False, GetType(Integer))
    Public Shared CONTEO3 As New Campo("CONTEO3", 1, False, GetType(Integer))
    Public Shared ID_LOCACIONES As New Campo("ID_LOCACIONES", 0, False, GetType(Integer))



#End Region


#Region "CONSTRUCTORES"

    ''' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        'asignamos la coleccion de campos
        CAMPOS = New Campo() {ID_INVENTARIO_SOPORTE, ID_INVENTARIO, ID_CLAVE, ID_SOPORTE, NRO_SOPORTE, NRO_TIPO_SOPORTE, DESCRIPCION_SOPORTE, CONTEO1, CONTEO2, CONTEO3, ID_LOCACIONES}

    End Sub



#End Region


    Public Overrides Function Get_nombre_tabla() As String
        Return NOMBRE_TABLA
    End Function

End Class
