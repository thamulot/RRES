Public Class Probleme
    Dim faits As System.Collections.Generic.List(Of Reagan.Data.Fact)

    Public Function ChargerListe(ByVal liste As System.Collections.Generic.List(Of Reagan.Data.Fact)) As Reagan.Data.Fact
        faits = liste

        Dim fait As Reagan.Data.Fact
        Me.ListBox1.Items.Clear()
        For Each fait In liste
            Me.ListBox1.Items.Add(fait.Name)
        Next

        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedItem = ListBox1.Items.Item(0)

            If (ListBox1.Items.Count < 2) Then
                Return faits(ListBox1.SelectedIndex())
            End If
        End If

        Return Nothing

    End Function

    Public Function getProbleme() As Reagan.Data.Fact
        Return faits(ListBox1.SelectedIndex())
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Probleme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class