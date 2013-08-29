<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhyThisSoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlossaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeywordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrariesAndFunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lessons = New System.Windows.Forms.ListBox()
        Me.Steps = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Display = New System.Windows.Forms.RichTextBox()
        Me.Current_Display = New System.Windows.Forms.RichTextBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.TechnicalToolStripMenuItem1, Me.HelToolStripMenuItem, Me.WhyThisSoftwareToolStripMenuItem, Me.GlossaryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'TechnicalToolStripMenuItem1
        '
        Me.TechnicalToolStripMenuItem1.Name = "TechnicalToolStripMenuItem1"
        Me.TechnicalToolStripMenuItem1.Size = New System.Drawing.Size(108, 20)
        Me.TechnicalToolStripMenuItem1.Text = "Technical Details"
        '
        'HelToolStripMenuItem
        '
        Me.HelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.HelToolStripMenuItem.Name = "HelToolStripMenuItem"
        Me.HelToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelToolStripMenuItem.Text = "Help"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'WhyThisSoftwareToolStripMenuItem
        '
        Me.WhyThisSoftwareToolStripMenuItem.Name = "WhyThisSoftwareToolStripMenuItem"
        Me.WhyThisSoftwareToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.WhyThisSoftwareToolStripMenuItem.Text = "Why Use This Software?"
        '
        'GlossaryToolStripMenuItem
        '
        Me.GlossaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeywordsToolStripMenuItem, Me.LibrariesAndFunctionsToolStripMenuItem})
        Me.GlossaryToolStripMenuItem.Name = "GlossaryToolStripMenuItem"
        Me.GlossaryToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.GlossaryToolStripMenuItem.Text = "Glossary"
        '
        'KeywordsToolStripMenuItem
        '
        Me.KeywordsToolStripMenuItem.Name = "KeywordsToolStripMenuItem"
        Me.KeywordsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.KeywordsToolStripMenuItem.Text = "Keywords"
        '
        'LibrariesAndFunctionsToolStripMenuItem
        '
        Me.LibrariesAndFunctionsToolStripMenuItem.Name = "LibrariesAndFunctionsToolStripMenuItem"
        Me.LibrariesAndFunctionsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LibrariesAndFunctionsToolStripMenuItem.Text = "Libraries And Functions"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lesson Selected"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lessons
        '
        Me.Lessons.FormattingEnabled = True
        Me.Lessons.Location = New System.Drawing.Point(6, 47)
        Me.Lessons.Name = "Lessons"
        Me.Lessons.Size = New System.Drawing.Size(152, 82)
        Me.Lessons.TabIndex = 6
        '
        'Steps
        '
        Me.Steps.FormattingEnabled = True
        Me.Steps.Location = New System.Drawing.Point(6, 195)
        Me.Steps.Name = "Steps"
        Me.Steps.Size = New System.Drawing.Size(152, 121)
        Me.Steps.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 28)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Step Selected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(656, 254)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Goals"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(656, 276)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Instructions"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(656, 299)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(113, 17)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Code to be Copied"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(656, 322)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton4.TabIndex = 15
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Details of the Code"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(656, 345)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(143, 17)
        Me.RadioButton5.TabIndex = 16
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Further Technical Details"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Display
        '
        Me.Display.AutoWordSelection = True
        Me.Display.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Display.Location = New System.Drawing.Point(164, 23)
        Me.Display.Name = "Display"
        Me.Display.ReadOnly = True
        Me.Display.Size = New System.Drawing.Size(454, 350)
        Me.Display.TabIndex = 17
        Me.Display.Text = ""
        '
        'Current_Display
        '
        Me.Current_Display.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Current_Display.Location = New System.Drawing.Point(624, 56)
        Me.Current_Display.Name = "Current_Display"
        Me.Current_Display.ReadOnly = True
        Me.Current_Display.Size = New System.Drawing.Size(199, 169)
        Me.Current_Display.TabIndex = 19
        Me.Current_Display.Text = ""
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(656, 231)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton6.TabIndex = 21
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "None"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(624, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 27)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 45)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(713, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 39)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(827, 381)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.Current_Display)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Steps)
        Me.Controls.Add(Me.Lessons)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C Programming Made A Game "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lessons As System.Windows.Forms.ListBox
    Friend WithEvents Steps As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Display As System.Windows.Forms.RichTextBox
    Friend WithEvents Current_Display As System.Windows.Forms.RichTextBox
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TechnicalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhyThisSoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GlossaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeywordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibrariesAndFunctionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
