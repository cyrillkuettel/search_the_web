<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt_path_to_script = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSearch.Location = New System.Drawing.Point(378, 220)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(172, 62)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Crawl The Web"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtsearch.Location = New System.Drawing.Point(12, 130)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(599, 32)
        Me.txtsearch.TabIndex = 2
        Me.txtsearch.Text = "neural networks natural image processsing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Options:"
        '
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.Location = New System.Drawing.Point(12, 193)
        Me.lb1.Name = "lb1"
        Me.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lb1.Size = New System.Drawing.Size(255, 121)
        Me.lb1.TabIndex = 4
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 450)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(610, 298)
        Me.txtResult.TabIndex = 6
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(16, 434)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(45, 13)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Results:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 26)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(599, 20)
        Me.txtPath.TabIndex = 8
        Me.txtPath.Text = "C:\Users\Cyrill\AppData\Local\Programs\Python\Python38-32\python.exe"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(16, 10)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(98, 13)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "Python executable:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(17, 55)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(142, 13)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Python Googlesearch Script:"
        '
        'txt_path_to_script
        '
        Me.txt_path_to_script.Location = New System.Drawing.Point(13, 71)
        Me.txt_path_to_script.Name = "txt_path_to_script"
        Me.txt_path_to_script.Size = New System.Drawing.Size(599, 20)
        Me.txt_path_to_script.TabIndex = 10
        Me.txt_path_to_script.Text = "C:\Users\Cyrill\Desktop\search_the_web-master\Search _The_Web\search_the_web_prin" &
    "t.py"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(378, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Get Modules"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 760)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txt_path_to_script)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Advanced Web Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lb1 As ListBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txt_path_to_script As TextBox
    Friend WithEvents Button1 As Button
End Class
