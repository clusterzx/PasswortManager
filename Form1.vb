Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml

Public Class Form1
    Public openedContainerPath As String = ""
    Public containerName As String = ""
    Public containerPassword As String = ""
    Public containerUnsaved As Boolean = False
#Region "Listview Functions"
    Function ListViewSave(ByRef LstVw As ListView, ByVal Path As String, ByVal encpw As String)
        Try
            File.Delete(Path)
            If Not lv_data.Items.Count = 0 Then
                Dim file As New IO.StreamWriter(Path)
                Dim completestring As New StringBuilder
                For Each myItem As ListViewItem In lv_data.Items
                    Dim text As String = myItem.Text & "##" & myItem.SubItems(1).Text & "##" & myItem.SubItems(2).Text
                    completestring.AppendLine(text)
                Next
                Dim enctext As String = containerName & "+" & vbNewLine & completestring.ToString
                file.WriteLine(Aes256.AES_Encrypt(enctext, containerPassword))
                file.Close()
                MsgBox("Container saved", vbInformation, "Done!")
            Else
                MsgBox("You don't have a cointainer opened", vbExclamation, "Warning!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error" & ex.HResult)
        End Try
    End Function
    Function ListViewLoad(ByVal Path As String)
        Try
            Dim a As String
            Dim enctext As String = IO.File.ReadAllText(Path)
            Dim dectext As String = Aes256.AES_Decrypt(enctext, containerPassword)
            If dectext.Length = 0 Then
                MsgBox("Wrong password", vbCritical, "Error")
                Exit Function
            End If
            IO.File.WriteAllText(Path, dectext)

            Dim lines As String() = IO.File.ReadAllLines(Path)
            containerName = Split(lines(0), "+")(0)
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(openedContainerPath)
            Do
                Try
                    a = reader.ReadLine
                    Dim website As String = (Split(a, "##")(0))
                    Dim username As String = (Split(a, "##")(1))
                    Dim password As String = (Split(a, "##")(2))


                    With lv_data.Items.Add(website)
                        .SubItems.Add(username)
                        .SubItems.Add(password)
                    End With

                Catch ex As Exception
                End Try
            Loop Until a Is Nothing
            reader.Close()

            For Each myItem As ListViewItem In lv_data.Items

                Dim baseurl = myItem.Text

                imglist.Images.Add(Image.FromFile(My.Computer.FileSystem.CurrentDirectory & "\key.ico"))
                myItem.ImageIndex = imglist.Images.Count - 1

            Next

            'For Each myItem As ListViewItem In lv_data.Items
            '    Try

            '        Try

            '            Dim baseurl = myItem.Text
            '            Dim url As Uri = New Uri(baseurl)

            '            If url.HostNameType = UriHostNameType.Basic Then
            '                Dim iconURL = "http://" & url.Host & "/favicon.ico"
            '                Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
            '                Dim response As System.Net.HttpWebResponse = request.GetResponse()
            '                Dim stream As System.IO.Stream = response.GetResponseStream()
            '                'Dim wbc As New WebClient
            '                'wbc.DownloadFile(iconURL, My.Computer.FileSystem.CurrentDirectory & "\" & myItem.Index & ".ico")
            '                imglist.Images.Add(Image.FromStream(stream))
            '                myItem.ImageIndex = imglist.Images.Count - 1
            '            End If

            '        Catch Ex As WebException

            '        End Try
            '    Catch ex As Exception

            '    End Try
            'Next
        Catch ex As Exception

        End Try
    End Function
    Private Sub cmd_Create_Click(sender As Object, e As EventArgs) Handles cmd_Create.Click
        CreateContainer.Show()
    End Sub
    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        If openedContainerPath = "" Then
            MsgBox("You have no container loaded", vbExclamation, "Warning!")
        Else
            ListViewSave(lv_data, openedContainerPath, containerPassword)
        End If
    End Sub

    Private Sub cmd_close_Click(sender As Object, e As EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    Private Sub cmd_Load_Click(sender As Object, e As EventArgs) Handles cmd_Load.Click
        If lv_data.Items.Count > 1 Then
            ListViewSave(lv_data, openedContainerPath, containerPassword)
        End If
        lv_data.Items.Clear()
        If fd_open.ShowDialog = DialogResult.OK Then
            openedContainerPath = fd_open.FileName
            containerPassword = InputBox("Enter password to encrypt container", "Security check")
            ListViewLoad(fd_open.FileName)
            statusbar.FirstLabelText = "Loaded : " & fd_open.FileName
            'statusbar.SecondLabelText = "Container name : " & Split(System.IO.File.ReadLines(openedContainerPath)(0), "++")(0)
            statusbar.Refresh()
        End If
    End Sub

    Private Sub mi_add_Click(sender As Object, e As EventArgs) Handles mi_add.Click
        If openedContainerPath = "" Then
            MsgBox("Please open or create a container first", vbExclamation, "Warning")
        Else

            Dim website As String = InputBox("Enter the Website adress (http://mysite.com/")
            Dim username As String = InputBox("Enter your Username / E-Mail")
            Dim password As String = InputBox("Enter your Password")
            With lv_data.Items.Add(website)
                .SubItems.Add(username)
                .SubItems.Add(password)
            End With
        End If
    End Sub

    Private Sub mi_Remove_Click(sender As Object, e As EventArgs) Handles mi_Remove.Click
        Try
            If lv_data.Items.Count < 1 Then
                MsgBox("Error no container opened", vbExclamation, "Warning!")
            Else
                lv_data.SelectedItems.Item(0).Remove()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not lv_data.Items.Count = 0 Then
            ListViewSave(lv_data, openedContainerPath, containerPassword)
        End If
    End Sub

    Private Sub cmd_minimize_Click(sender As Object, e As EventArgs) Handles cmd_minimize.Click
        Me.Visible = False
        notify_tray.Visible = True
        notify_tray.ShowBalloonTip(0)
    End Sub

    Private Sub notify_tray_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notify_tray.MouseDoubleClick
        Me.Visible = True
        notify_tray.Visible = False
    End Sub
    Private Sub cmd_Settings_Click(sender As Object, e As EventArgs) Handles cmd_Settings.Click
        If openedContainerPath = "" Then
            MsgBox("You have to open or create a container to import your Chrome passwords.", vbExclamation, "Warning!")
        Else
            gssdghsss()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim searchText = Me.txt_search.Text

        If searchText = String.Empty Then
            MessageBox.Show("Please enter search text.")
        Else
            Dim i As Integer = 0
            For i = i To lv_data.Items.Count - 1
                If lv_data.Items.Item(i).Text.Contains(searchText) = True Then
                    lv_data.Items.Item(i).Selected = True
                    lv_data.Items.Item(i).EnsureVisible()
                    Me.lv_data.Select()
                    i = lv_data.Items.Item(i).Index
                End If
            Next
        End If
    End Sub
#End Region
End Class
