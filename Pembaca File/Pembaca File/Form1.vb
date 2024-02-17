Imports System.IO
'Nama : Muhammad Habib Hidayatulloh
'Nim  : 230401010097
'Prodi: S1 - PJJ Informatika
'Kelas: IT102
Public Class Form1
    ' Event handler untuk membuka dialog pemilihan folder
    Private Sub Button_Browse_Click(sender As Object, e As EventArgs) Handles Button_pencarian.Click
        ' Tampilkan dialog pemilihan folder
        Dim folderDialog As New FolderBrowserDialog()
        Dim result As DialogResult = folderDialog.ShowDialog()

        ' Periksa apakah pengguna telah memilih folder
        If result = DialogResult.OK Then
            ' Panggil fungsi untuk menampilkan struktur folder pada TreeView
            DisplayFolderStructure(folderDialog.SelectedPath)
        End If
    End Sub

    ' Fungsi untuk menampilkan struktur folder pada TreeView
    Private Sub DisplayFolderStructure(folderPath As String)
        ' Bersihkan TreeView_tampilanfolder sebelum menampilkan struktur folder baru
        TreeView_tampilanfolder.Nodes.Clear()

        ' Tambahkan node root untuk folder yang dipilih
        Dim rootNode As TreeNode = TreeView_tampilanfolder.Nodes.Add(folderPath)
        ' Panggil fungsi untuk menambahkan subfolder dan file ke TreeView
        AddSubfoldersAndFiles(rootNode, folderPath)

        ' Periksa apakah folder dapat diakses
        If Directory.Exists(folderPath) Then
            Label_status.Text = "Folder Ditemukan"
        Else
            Label_status.Text = "Folder Tidak Ditemukan"
        End If
    End Sub

    ' Fungsi rekursif untuk menambahkan subfolder dan file ke TreeView
    Private Sub AddSubfoldersAndFiles(parentNode As TreeNode, folderPath As String)
        ' Periksa apakah folder yang dipilih ada
        If Directory.Exists(folderPath) Then
            ' Ambil daftar subfolder dari folder yang dipilih
            Dim subfolders As String() = Directory.GetDirectories(folderPath)
            ' Tambahkan setiap subfolder sebagai node ke TreeView
            For Each subfolder As String In subfolders
                Dim subfolderNode As TreeNode = parentNode.Nodes.Add(Path.GetFileName(subfolder))
                ' Panggil fungsi rekursif untuk menambahkan sub-subfolder dan file
                AddSubfoldersAndFiles(subfolderNode, subfolder)
            Next
            ' Ambil daftar file dari folder yang dipilih
            Dim files As String() = Directory.GetFiles(folderPath)
            ' Tambahkan setiap file sebagai node ke TreeView
            For Each file As String In files
                Dim fileNode As TreeNode = parentNode.Nodes.Add(Path.GetFileName(file))
            Next
        End If
    End Sub

    ' Event handler untuk menampilkan path file yang dipilih di TextBox
    Private Sub TreeView_tampilanfolder_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_tampilanfolder.AfterSelect
        ' Jika yang dipilih adalah node file, tampilkan path-nya di TextBox
        If Not e.Node.Nodes.Count > 0 Then
            TextBox_tampilanfolder.Text = e.Node.FullPath
        End If
    End Sub
End Class
