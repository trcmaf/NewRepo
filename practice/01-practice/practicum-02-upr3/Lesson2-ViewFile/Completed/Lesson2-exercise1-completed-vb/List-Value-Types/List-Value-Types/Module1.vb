Module Module1

    Sub Main()
        Dim a As SByte = 0
        Dim b As Byte = 0
        Dim c As Int16 = 0
        Dim d As Int32 = 0
        Dim e As Int64 = 0
        Dim s As String = ""
        Dim ex As Exception = New Exception

        Dim types As Object() = {a, b, c, d, e, s, ex}

        For Each o As Object In types
            Dim type As String
            If o.GetType.IsValueType Then
                type = "Value type"
            Else
                type = "Reference Type"
            End If
            Console.WriteLine("{0}: {1}", o.GetType, type)
        Next
    End Sub

End Module
