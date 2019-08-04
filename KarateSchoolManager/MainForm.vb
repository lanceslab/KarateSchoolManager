Public Class MainForm


    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListAllToolStripMenuItem.Click
        AllMembersForm.ShowDialog()
    End Sub

End Class
