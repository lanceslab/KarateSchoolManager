Public Class AllMembersForm

    Private Sub AllMembersForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButtonGo_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonGo.Click

        '--------------------- working -----------------------------
        Try
            Me.MembersTableAdapter.FindMember(KarateDataSet.Members, ToolStripTextBoxSearch.Text)
        Catch ex As Exception
            MessageBox.Show("Last Name can not be Numeric")
        End Try

    End Sub

End Class