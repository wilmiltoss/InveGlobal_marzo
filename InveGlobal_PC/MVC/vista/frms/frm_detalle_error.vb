Imports InveStock_PC_2

Public Class frm_detalle_error
    Public oRespuesta As String = String.Empty
    Public oCant As Integer = 0
    Public oConf As Integer = 0
    Public oError As Integer = 0

    Private Sub Txt_detalles_TextChanged(sender As Object, e As EventArgs) Handles txt_detalles.TextChanged

    End Sub

    Private Sub Frm_detalle_error_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_detalles.Text = oRespuesta
        lbl_cant_art.Text = oCant
        lbl_cant_conf.Text = oConf
        lbl_cant_error.Text = oError
    End Sub
End Class