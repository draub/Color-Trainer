Public Module modColor

    Public rgbColorR, rgbColorG, rgbColorB As Int32
    Public rgbUi As Int32 = 90

    Public Function rgbContrast(ByVal rgbRed As Int32, rgbGreen As Int32, rgbBlue As Int32) As Int32
        Dim contrast As Int32

        contrast = (Math.Round(rgbRed * 299) + Math.Round(rgbGreen * 587) + Math.Round(rgbBlue * 114)) / 1000

        If contrast < 64 Then
            Return 255
        ElseIf contrast > 192 Then
            Return 0
        Else
            Return rgbInvert(contrast)
        End If
    End Function


    Public Function rgbInvert(ByVal rgbVal As Int32) As Int32
        If rgbVal < 128 Then
            Return rgbVal + 128
        Else
            Return rgbVal - 128
        End If
    End Function

End Module
