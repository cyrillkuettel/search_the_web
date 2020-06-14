
Imports System.IO
' ideas for this program
' Pass more parameters to script: how many pages to search
' Web Crawling: get all the links for each link and visualize in a tree


Public Class Form1

    Dim query As String = ""
    Dim websites() As String = {"en.wikipedia.org", "stackoverflow.com", "quora.com", "reddit.com", "sitepoint.com",
    "https://www.codeproject.com/",
    "https://news.ycombinator.com/",
    "github.com", "https://www.dotnetperls.com/"}

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtsearch.Text <> "" Then
            query = Chr(34) & txtsearch.Text & Chr(34)
        ElseIf txtsearch.Text = "" Then
            MessageBox.Show("Can't search for 'nothing'")
            Exit Sub
        End If
        Dim list As New List(Of String)
        Dim s As String = ""

        If lb1.SelectedIndex >= 0 Then
            'something is selected
        Else
            'Nothing is selected
            MessageBox.Show("please select a Website to search")
            Exit Sub
        End If

        For x = 0 To lb1.SelectedItems.Count() - 1
            If lb1.SelectedItems.Count() > 0 Then
                ' List of Websites to search
                list.Add(Chr(34) & lb1.SelectedItems(x) & Chr(34))
            End If
        Next x


        'Es müssen sowhol der Search Text als auch die Liste der Websiten als Parameter zum Python Script übergeben werden
        ' Das Format muss folgendermassen aussehen: 
        'search_the_web_print.py "neural networks" "stackoverflow.com" "quora.com"

        ' the usual problems if the path contains whitespace. For simplicity, just store the python script in the C: directory
        'pyhton executable
        Dim cmd As String = txtPath.Text


        Dim sWebsites As String = String.Join(" ", list.ToArray())
        Dim final As String = String.Join(" ", query, sWebsites)

        'Dim argss As String = "C:\Programme\ILZrwx\search_the_web_print.py " & final
        Dim argss As String = Chr(34) & txt_path_to_script.Text & Chr(34) & " " & final

        txtResult.Text = argss & vbCrLf
        Dim start As ProcessStartInfo = New ProcessStartInfo()
        start.FileName = cmd
        start.Arguments = argss
        start.UseShellExecute = False
        start.WindowStyle = ProcessWindowStyle.Hidden 'don't show command prompt
        start.RedirectStandardOutput = True

        Using process As Process = Process.Start(start)
            Using reader As StreamReader = process.StandardOutput
                Dim result As String = reader.ReadToEnd()
                txtResult.Text += result
            End Using
        End Using

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To websites.Length - 1
            lb1.Items.Add(websites(i))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cmd As String = txtPath.Text 'python path
        Dim argss As String = "python" & " " & "help(""modules"")".ToString()
        MsgBox(argss)
        txtResult.Text = argss

        Dim start As ProcessStartInfo = New ProcessStartInfo()
        start.FileName = cmd
        start.Arguments = argss
        start.UseShellExecute = False
        start.WindowStyle = ProcessWindowStyle.Normal 'don't show command prompt
        start.RedirectStandardOutput = True

        Using process As Process = Process.Start(start)
            Using reader As StreamReader = process.StandardOutput
                Dim result As String = reader.ReadToEnd()
                txtResult.Text += result
            End Using
        End Using

    End Sub


End Class






