Module Glossary_Content_Control
    Public Sub AddKeywords()
        'First Batch of Glossary Keywords
        Form1.Lessons.Items.Clear()
        Form1.Lessons.Items.Add("Tool")
        Form1.Lessons.Items.Add("Open Source")
        Form1.Lessons.Items.Add("IDE")
        Form1.Lessons.Items.Add("Glossary")
        Form1.Lessons.Items.Add("Keywords")
        Form1.Lessons.Items.Add("Libraries")
        Form1.Lessons.Items.Add("Functions")
        Form1.Lessons.Items.Add("Code:Blocks")
        Form1.Lessons.Items.Add("Tooltip")
        Form1.Lessons.Items.Add("Code:Blocks Shortcuts")
        Form1.Lessons.Items.Add("Programming")
        Form1.Lessons.Items.Add("C Language")
        Form1.Lessons.Items.Add("Use of C Language")
        Form1.Lessons.Items.Add("Integrated Development Environment")
        Form1.Lessons.Items.Add("C Software")
        Form1.Lessons.Items.Add("Compiler")
        Form1.Lessons.Items.Add("Code")
        Form1.Lessons.Items.Add("C Code")
        Form1.Lessons.Items.Add("Source Code")
        Form1.Lessons.Items.Add("Escape Identifiers")
        Form1.Lessons.Items.Add("New Line")
        Form1.Lessons.Items.Add("Line Break")
        Form1.Lessons.Items.Add("Tab Feed")
        Form1.Lessons.Items.Add("Comments")

        'Second Batch of Glossary Keywords

    End Sub


    Public Sub AddLibraries()
        Form1.Lessons.Items.Clear()
        Form1.Lessons.Items.Add("None Added")
    End Sub

    'The reason that I am using strings for all the keywords is because
    'Many of them are synonyms and will display the same thing
    Public Sub Button3_Clicked()
        Select Case Form1.Lessons.SelectedItem
            'First Batch of Glossary Keywords
            Case "Tool"
                Form1.Display.Text = String_Tool
            Case "Open Source"
                Form1.Display.Text = String_Open_Source
            Case "IDE"
                Form1.Display.Text = String_Tool
            Case "Glossary"
                Form1.Display.Text = String_Glossarys
            Case "Keywords"
                Form1.Display.Text = String_Glossarys
            Case "Libraries"
                Form1.Display.Text = String_Libraries
            Case "Functions"
                Form1.Display.Text = String_Libraries
            Case "Code:Blocks"
                Form1.Display.Text = String_Tool
            Case "Tooltip"
                Form1.Display.Text = String_Tooltip
            Case "Code:Blocks Shortcuts"
                Form1.Display.Text = String_Code_Blocks_Shortcuts
            Case "Programming"
                Form1.Display.Text = String_Programming
            Case "C Language"
                Form1.Display.Text = String_C_Language
            Case "Use of C Language"
                Form1.Display.Text = String_C_Language
            Case "Integrated Development Environment"
                Form1.Display.Text = String_Tool
            Case "C Software"
                Form1.Display.Text = String_Tool
            Case "Compiler"
                Form1.Display.Text = String_Tool
            Case "Code"
                Form1.Display.Text = String_Code
            Case "C Code"
                Form1.Display.Text = String_Code
            Case "Source Code"
                Form1.Display.Text = String_Code
            Case "Escape Identifiers"
                Form1.Display.Text = String_Escape_Identifiers
            Case "New Line"
                Form1.Display.Text = String_Escape_Identifiers
            Case "Line Break"
                Form1.Display.Text = String_Escape_Identifiers
            Case "Tab Feed"
                Form1.Display.Text = String_Escape_Identifiers
            Case "Comments"
                Form1.Display.Text = String_Comments

                'Second Batch of Glossary Keywords

        End Select
    End Sub
End Module
