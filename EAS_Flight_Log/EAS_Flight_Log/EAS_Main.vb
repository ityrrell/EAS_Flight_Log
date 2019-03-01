Public Class EAS_Main
    Private Sub StartFlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartFlightToolStripMenuItem.Click
        Dim FS_Open As Integer
        FS_Open = Connect_FSUIPC()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    Private Sub EAS_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class