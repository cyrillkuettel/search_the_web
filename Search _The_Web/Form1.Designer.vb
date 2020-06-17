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
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.checkbox_all = New System.Windows.Forms.CheckBox()
        Me.checkbox_simple = New System.Windows.Forms.CheckBox()
        Me.checkbox_non_programming = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtsearch.Location = New System.Drawing.Point(13, 307)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(538, 39)
        Me.txtsearch.TabIndex = 2
        Me.txtsearch.Text = "neural networks natural image processsing"
        '
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.Location = New System.Drawing.Point(133, 391)
        Me.lb1.Name = "lb1"
        Me.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lb1.Size = New System.Drawing.Size(216, 121)
        Me.lb1.TabIndex = 4
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 542)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(610, 298)
        Me.txtResult.TabIndex = 6
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(14, 41)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(98, 13)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "Python executable:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(14, 110)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(142, 13)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Python Googlesearch Script:"
        '
        'cb1
        '
        Me.cb1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(13, 57)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(600, 39)
        Me.cb1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(79, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 52)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Advanced Web  Search"
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.Location = New System.Drawing.Point(555, 307)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(67, 39)
        Me.btnsearch.TabIndex = 15
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(13, 126)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(600, 39)
        Me.cb2.TabIndex = 16
        '
        'checkbox_all
        '
        Me.checkbox_all.AutoSize = True
        Me.checkbox_all.Location = New System.Drawing.Point(15, 391)
        Me.checkbox_all.Name = "checkbox_all"
        Me.checkbox_all.Size = New System.Drawing.Size(37, 17)
        Me.checkbox_all.TabIndex = 17
        Me.checkbox_all.Text = "All"
        Me.checkbox_all.UseVisualStyleBackColor = True
        '
        'checkbox_simple
        '
        Me.checkbox_simple.AutoSize = True
        Me.checkbox_simple.Location = New System.Drawing.Point(15, 414)
        Me.checkbox_simple.Name = "checkbox_simple"
        Me.checkbox_simple.Size = New System.Drawing.Size(57, 17)
        Me.checkbox_simple.TabIndex = 18
        Me.checkbox_simple.Text = "Simple"
        Me.checkbox_simple.UseVisualStyleBackColor = True
        '
        'checkbox_non_programming
        '
        Me.checkbox_non_programming.AutoSize = True
        Me.checkbox_non_programming.Location = New System.Drawing.Point(15, 437)
        Me.checkbox_non_programming.Name = "checkbox_non_programming"
        Me.checkbox_non_programming.Size = New System.Drawing.Size(110, 17)
        Me.checkbox_non_programming.TabIndex = 19
        Me.checkbox_non_programming.Text = "Non-Programming"
        Me.checkbox_non_programming.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(636, 853)
        Me.Controls.Add(Me.checkbox_non_programming)
        Me.Controls.Add(Me.checkbox_simple)
        Me.Controls.Add(Me.checkbox_all)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.txtsearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Advanced Web Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lb1 As ListBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents cb2 As ComboBox
    Friend WithEvents checkbox_all As CheckBox
    Friend WithEvents checkbox_simple As CheckBox
    Friend WithEvents checkbox_non_programming As CheckBox
End Class
