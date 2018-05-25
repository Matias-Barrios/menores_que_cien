Public Class Form1
    Dim numeros(9) As Integer

    Private Sub calculo(sender As Object, e As EventArgs) Handles calcular.Click
        For Each numero In numeros
            numero = Val(InputBox(" Ingrese un numero cualquera... "))
            If numero < 100 Then
                lblResultado.Text = Val(lblResultado.Text) + 1
            End If
        Next
    End Sub

End Class
