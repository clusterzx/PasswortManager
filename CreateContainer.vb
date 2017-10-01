Public Class CreateContainer
    Private Sub VisualStudioButton1_Click(sender As Object, e As EventArgs) Handles VisualStudioButton1.Click
        Try
            If txt_password.Text = txt_repassword.Text Then
                Form1.containerPassword = txt_password.Text
                Form1.containerUnsaved = True
                If fd_save.ShowDialog = DialogResult.OK Then
                    Dim file As New IO.StreamWriter(fd_save.FileName)
                    file.WriteLine(txt_name.Text & "++")
                    file.Close()
                    Form1.openedContainerPath = fd_save.FileName
                    Form1.statusbar.FirstLabelText = fd_save.FileName
                    Form1.statusbar.SecondLabelText = "Container name : " & Split(System.IO.File.ReadLines(Form1.openedContainerPath)(0), "++")(0)
                    Form1.statusbar.Refresh()
                    Form1.containerName = System.IO.Path.GetFileNameWithoutExtension(fd_save.FileName)
                End If
                Me.Close()
            Else
                MsgBox("Your passwords do not match", vbExclamation, "Warning!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cmd_close_Click(sender As Object, e As EventArgs) Handles cmd_close.Click
        Me.Close()
        txt_name.Text = ""
        txt_password.Text = ""
        txt_repassword.Text = ""
    End Sub
End Class