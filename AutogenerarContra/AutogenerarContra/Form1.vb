Public Class Form1
    Private Function GenerarCadena(ByVal numeroCaracteres As Integer) As String

        ' Dimensionamos un array para almacenar tanto las 
        ' letras mayúsculas como minúsculas (52 letras). 
        ' 
        Dim letras(51) As String

        ' Rellenamos el array. 
        ' 
        Dim n As Integer
        For item As Int32 = 65 To 90
            letras(n) = Chr(item)
            letras(n + 1) = letras(n).ToLower
            n += 2
        Next

        Dim cadenaAleatoria As String = String.Empty

        ' Iniciamos el generador de números aleatorios 
        ' 
        Dim rnd As New Random(DateTime.Now.Millisecond)

        For n = 0 To numeroCaracteres

            Dim numero As Integer = rnd.Next(0, 51)

            cadenaAleatoria &= letras(numero)

        Next

        Return cadenaAleatoria

    End Function

    Private Sub BtnContra_Click(sender As Object, e As EventArgs) Handles BtnContra.Click
        TxtCambio.Text = GenerarCadena(24)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NuevaContraseña.Show()
    End Sub
End Class
