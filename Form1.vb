Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCheckUpdate_Click(sender As Object, e As EventArgs) Handles BtnCheckUpdate.Click

        If UpdateManager.IsUpdateAvailable() Then
            MessageBox.Show("Update Available")
        Else
            MessageBox.Show("No Update")
        End If

    End Sub

    Private Sub BtnCheckUpdate_Click_1(sender As Object, e As EventArgs) Handles BtnCheckUpdate.Click

    End Sub
End Class
