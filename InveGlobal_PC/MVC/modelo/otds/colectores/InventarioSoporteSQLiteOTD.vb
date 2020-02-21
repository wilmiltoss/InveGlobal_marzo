Imports CdgPersistencia.ClasesBases
Public Class InventarioSoporteSQLiteOTD
    Inherits OTDbase

    Public Shadows Const NOMBRE_CLASE As String = "InventarioSoporteSQLiteOTD"


    Public nIdInventarioSoporte As Integer
    Public nIdInventario As Integer
    Public nIdClave As Integer
    Public nIdSoporte As Integer
    Public nNroSoporte As Integer
    Public nNroTipoSoporte As Integer
    Public cDescripcionSoporte As String
    Public nConteo1 As Integer
    Public nConteo2 As Integer
    Public nConteo3 As Integer
    Public nIdLocaciones As Integer


#Region "CONSTRUCTORES"

    ''' <summary>
    ''' Construtor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New(0, NOMBRE_CLASE)

        nIdInventarioSoporte = 0
        nIdInventario = 0
        nIdClave = 0
        nIdSoporte = 0
        nNroSoporte = 0
        nNroTipoSoporte = 0
        cDescripcionSoporte = String.Empty
        nConteo1 = 0
        nConteo2 = 0
        nConteo3 = 0
        nIdLocaciones = 0

    End Sub


    Public Sub New(ByVal nIdInventarioSoporteParam As Integer _
                 , ByVal nIdInventarioParam As Integer _
                 , ByVal nIdClaveParam As Integer _
                 , ByVal nIdSoporteParam As Integer _
                 , ByVal nNroSoporteParam As Integer _
                 , ByVal nNroTipoSoporteParam As Integer _
                 , ByVal cDescripcionSoporteParam As String _
                 , ByVal nConteo1Param As Integer _
                 , ByVal nConteo2Param As Integer _
                 , ByVal nConteo3Param As Integer _
                 , ByVal nIdLocacionesParam As Integer
                    )
        MyBase.New(0, NOMBRE_CLASE)

        nIdInventarioSoporte = nIdInventarioSoporteParam
        nIdInventario = nIdInventarioParam
        nIdClave = nIdClaveParam
        nIdSoporte = nIdSoporteParam
        nNroSoporte = nNroSoporteParam
        nNroTipoSoporte = nNroTipoSoporteParam
        cDescripcionSoporte = cDescripcionSoporteParam
        nConteo1 = nConteo1Param
        nConteo2 = nConteo2Param
        nConteo3 = nConteo3Param
        nIdLocaciones = nIdLocacionesParam

    End Sub

#End Region
End Class
