Imports System.Windows.Forms

Public Class Question
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.DialogResult = System.Windows.Forms.DialogResult.No
    End Sub
End Class
