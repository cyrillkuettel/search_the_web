Imports System.IO
' ideas for this program

' python path programmatically:
'>>> import sys
'>>> print(sys.executable)



' Web Crawling: get all the links for each link and visualize in a tree
' Make it so that the initial search windows disappears and a new window open which displays the results
' also change checkbox: should unselect everythign first

' store all searches in a file. 
' then display it somehow showing a history after button click

Public Class Form1

    Dim query As String = ""
    Dim websites() As String = {"en.wikipedia.org", "stackoverflow.com", "quora.com", "reddit.com", "sitepoint.com",
    "https://www.codeproject.com/",
    "https://news.ycombinator.com/",
    "github.com", "https://www.dotnetperls.com/"}

    Dim path_to_script As String
    Dim path_to_pyton As String

    Private Sub btnsearch_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
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

        ' List of Websites to search -> Save everything in list list

        For x = 0 To lb1.SelectedItems.Count() - 1
            If lb1.SelectedItems.Count() > 0 Then

                list.Add(Chr(34) & lb1.SelectedItems(x) & Chr(34))
            End If
        Next x


        'Es müssen sowhol der Search Text als auch die Liste der Websiten als Parameter zum Python Script übergeben werden
        ' Das Format muss folgendermassen aussehen: 
        'search_the_web_print.py "neural networks" "stackoverflow.com" "quora.com"

        ' the usual problems if the path contains whitespace. For simplicity, just store the python script in the C: directory
        'pyhton executable
        path_to_pyton = cb1.SelectedItem
        path_to_script = cb2.SelectedItem

        Dim sWebsites As String = String.Join(" ", list.ToArray())
        Dim final As String = String.Join(" ", query, sWebsites)


        Dim argss As String = Chr(34) & path_to_script & Chr(34) & " " & final


        Dim start As ProcessStartInfo = New ProcessStartInfo()
        start.FileName = path_to_pyton
        start.Arguments = argss
        start.UseShellExecute = False
        start.WindowStyle = ProcessWindowStyle.Hidden 'don't show command prompt
        start.RedirectStandardOutput = True
        'Dim result As String

        Using process As Process = Process.Start(start)
            Using reader As StreamReader = process.StandardOutput

                While (reader.EndOfStream = False)
                    Dim result As String = reader.ReadToEnd()
                    txtResult.Text += result
                    txtResult.Refresh()
                End While

            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResult.ScrollBars = ScrollBars.Vertical
        'Me.StartPosition = FormStartPosition.CenterScreen
        AddItems()
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub AddItems()
        'simply add necessary absolute paths to form

        For i As Integer = 0 To websites.Length - 1
            lb1.Items.Add(websites(i))
        Next

        cb1.Items.Add("C:\Users\Cyrill\AppData\Local\Programs\Python\Python38-32\python.exe")
        cb1.Items.Add("C:\Program Files (x86)\Python38-32\python.exe")
        cb2.Items.Add("C:\Users\Cyrill\Desktop\search_the_web-master\Search _The_Web\search_the_web_print.py")
        cb2.Items.Add("C:\Users\ilz1071\Documents\search_the_web-master\Search _The_Web\bin\Debug\search_the_web_print.py")
        If cb1.Items.Count > 0 Then
            cb1.SelectedIndex = 1    ' The first item has index 0 '
        End If
        If cb2.Items.Count > 0 Then
            cb2.SelectedIndex = 1    ' The first item has index 0 '
        End If
        ' set button.image property
        Dim pathsearchbutton As String = "C:\Users\ilz1071\Documents\search_the_web-master\Search-button.png"
        btnsearch.Image = Image.FromFile(pathsearchbutton).GetThumbnailImage(67, 40, Nothing, IntPtr.Zero)
    End Sub

    Private Sub checkbox_all_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_all.CheckedChanged
        For i As Integer = 0 To lb1.Items.Count - 1
            lb1.SetSelected(i, True)
        Next
    End Sub

    Private Sub checkbox_simple_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_simple.CheckedChanged
        For i As Integer = 0 To 3

            lb1.SetSelected(i, True)
        Next
    End Sub

    Private Sub checkbox_non_programming_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_non_programming.CheckedChanged
        ' reddit
        ' wikipedia
        For i As Integer = 0 To lb1.Items.Count - 1
            If lb1.Items.Item(i).ToString() = "reddit.com" Then
                lb1.SetSelected(i, True)
            ElseIf lb1.Items.Item(i).ToString() = "en.wikipedia.org" Then
                lb1.SetSelected(i, True)
            ElseIf lb1.Items.Item(i).ToString() = "quora.com" Then
                lb1.SetSelected(i, True)
            End If
        Next
        MsgBox(lb1.Items.Item(1).ToString())
    End Sub
End Class






