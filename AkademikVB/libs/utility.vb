Module utility
    Public Function GetRandom(myGenerator As System.Random, ByVal Min As Integer, ByVal Max As Integer) As Integer
        'min is inclusive, max is exclusive (dah!)
        Return myGenerator.Next(Min, Max + 1)
    End Function

End Module
