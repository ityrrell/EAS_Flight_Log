
Imports FSUIPC


Module Main_Routines

    ' Public Variables
    Public Version As String = "Version: 0.0.0.1"

    Public Function Connect_FSUIPC()

        ' Try to connect 
        Dim A As Integer
        A = 10
        If FSUIPCConnection.IsOpen Then
            ' Connection is open so stop the timer and close the connection
            FSUIPCConnection.Close()
        End If

        Try
            FSUIPCConnection.Open()

        Catch ex As FSUIPCException
            ' Error occured so alert the user
            MessageBox.Show("Connection Failed. " & ex.Message)
        End Try

        If FSUIPCConnection.IsOpen Then
            ' connection opened okay so start the timer
            MessageBox.Show("Connected")
        End If
        Return A
    End Function

End Module
