Public Class EAS_Main
    Private Sub NewFlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFlightToolStripMenuItem.Click
        Dim FS_Open As Integer
        FS_Open = Connect_FSUIPC()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub


End Class