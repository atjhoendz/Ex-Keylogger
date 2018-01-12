Module Key_Module
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short

    Public Function getCapslock() As Boolean
        'return or set the caps lock toggle
        getCapslock = CBool(GetKeyState(System.Windows.Forms.Keys.Capital) And 1)
    End Function

    Public Function getShift() As Boolean
        'check to see if the shift key is pressed
        getShift = CBool(GetAsyncKeyState(System.Windows.Forms.Keys.ShiftKey))
    End Function

End Module
