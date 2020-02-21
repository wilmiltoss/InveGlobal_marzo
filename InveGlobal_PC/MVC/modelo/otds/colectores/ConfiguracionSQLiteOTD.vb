Imports CdgPersistencia.ClasesBases


Public Class ConfiguracionSQLiteOTD
    Inherits OTDbase


    Public Shadows Const NOMBRE_CLASE As String = "ConfiguracionSQLiteOTD"

    Public nCantidadMaxima As Double
    Public nConDecimales As Integer
    Public nIdInventario As Integer
    Public nIpSqlServer As String



#Region "CONSTRUCTORES"

    ''' <summary>
    ''' Construtor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New(0, NOMBRE_CLASE)

        nCantidadMaxima = 0D
        nConDecimales = 0
        nIdInventario = 0
        nIpSqlServer = 0

    End Sub


    ' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <param name="nCantidadMaximaParam">Cantidad maxima para conteos</param>
    ''' <param name="nConDecimalesParam">Si se permiten decimales o no [0|1]</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal nCantidadMaximaParam As Double _
                   , ByVal nConDecimalesParam As Integer _
                   , ByVal nIdInventarioParam As Integer _
                   , ByVal nIpSqlServerParam As String
                    )
        MyBase.New(0, String.Empty)

        nCantidadMaxima = nCantidadMaximaParam
        nConDecimales = nConDecimalesParam
        nIdInventario = nIdInventarioParam
        nIpSqlServer = nIpSqlServerParam

    End Sub

#End Region


End Class
