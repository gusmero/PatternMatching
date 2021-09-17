Public Class Form1
    Private Sub PatternMatching_Click(sender As Object, e As EventArgs) Handles PatternMatching.Click
        Dim text As String = TextBox.Text
        Dim pattern As String = PatterntBox.Text
        Dim m As Integer = Len(pattern)
        Dim phi() As Integer
        phi = ComputePrefixFunction(pattern)
        For i = 0 To phi.Length - 1
            TextBoxphi.AppendText(phi(i))
        Next
        KMP(pattern, text, phi)
    End Sub

    Function ComputePrefixFunction(pattern) As Integer()
        Dim m As Integer = Len(pattern)
        Dim phi(m) As Integer
        Dim k As Integer
        Dim clausola As Boolean
        phi(0) = -1
        phi(1) = 0
        For j = 2 To m
            k = phi(j - 1)
            ComputeClausola(pattern, k, clausola, j)

            Do While clausola
                k = phi(k)
                ComputeClausola(pattern, k, clausola, j)
            Loop
            phi(j) = k + 1
        Next
        Return phi
    End Function

    Private Shared Sub ComputeClausola(pattern As Object, ByRef k As Integer, ByRef clausola As Boolean, j As Integer)
        If k < 0 Then
            clausola = False
        ElseIf pattern.Chars(k) <> pattern.Chars(j - 1) Then
            clausola = True
        End If
    End Sub

    Private Shared Sub ComputeClausola(pattern As Object, text As Object, ByRef j As Integer, ByRef clausola As Boolean, q As Integer)
        If j < 0 Then
            clausola = False
        ElseIf pattern.Chars(j) <> text.Chars(q - 1) Then
            clausola = True
        End If
    End Sub

    Function KMP(pattern, text, phi)
        Dim m As Integer = Len(pattern)
        Dim n As Integer = Len(text)
        Dim j As Integer
        Dim clausola As Boolean
        For q = 1 To n
            ComputeClausola(pattern, text, j, clausola, q)
            Do While clausola
                j = phi(j)
                ComputeClausola(pattern, text, j, clausola, q)
            Loop
            j = j + 1
            If j = m Then
                MsgBox("occorrenza in :" & q - m + 1)
            End If
        Next
    End Function

End Class
