Imports CdgPersistencia.ClasesBases
Imports CdgPersistencia.Componentes
Public Class InventarioSoportesTBL
    Inherits TBLbase

#Region "ATRIBUTOS"

    Public Const NOMBRE_CLASE As String = "InventariosSoporteTBL"
    Public Shadows Const NOMBRE_TABLA As String = "INVENTARIO_SOPORTE"

    'nombres de campos
    Public Shared ID_INVENTARIO_SOPORTES As New Campo("ID_INVENTARIO_SOPORTES", 0, False, GetType(Integer))
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

    ''' <summary>
    ''' Devuelve el comando se ejecucion de Asignacion de todos los sectores
    ''' al inventario parametro "@id_inventario = {0}"
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared SP_OBTENER_INVENTARIO_SOPORTE As String = "EXEC [dbo].[SP_OBTENER_INVENTARIO_SOPORTE] @id_inventario = {0}"

#End Region


#Region "CONSTRUCTORES"

    ''' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        'asignamos la coleccion de campos
        CAMPOS = New Campo() {ID_INVENTARIO_SOPORTES, ID_INVENTARIO, ID_CLAVE, ID_SOPORTE, NRO_SOPORTE, NRO_TIPO_SOPORTE, DESCRIPCION_SOPORTE, CONTEO1, CONTEO2, CONTEO3, ID_LOCACIONES}

    End Sub



#End Region


    Public Overrides Function Get_nombre_tabla() As String
        Return NOMBRE_TABLA
    End Function

End Class
