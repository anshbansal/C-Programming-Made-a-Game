Module Control_Glossary

    'First Batch of Glossary of Keywords
    Public Const String_Tool As String = "Keywords:-" & Chr(13) & "Tool, IDE, Code:Blocks, Integrated Development Environment, C Software, Compiler" & Chr(13) & "" & Chr(13) & "Introduction:-" & Chr(13) & "When making softwares using C Language a software called IDE(Integrated Development Environment) is generally used. It is the most common type of C software used. It is actually a collection of various softwares which are needed to properly convert a C code into an executable program." & Chr(13) & "" & Chr(13) & "Code:Blocks, the software that you are using is also an IDE. It is a free software and there are various versions for different Operating Systems like Windows, Linux, Mac." & Chr(13) & "" & Chr(13) & "This is not the only IDE present. There are many different IDEs. Some of them are free but there are many for which you have to pay money to use them." & Chr(13) & "" & Chr(13) & "There are many parts of an IDE. " & Chr(13) & "The two main parts that we usually deal with are the text editor and the compiler. The text editor is the part in which you type the code. Notepad is a simple example of a text editor. The other one - ""compiler"" is a type of software that you will mostly see when doing programming. It is a software that converts the code written in C language into instructions for the computer in the computer's ""machine language""." & Chr(13) & "" & Chr(13) & "When we press F9 in codeblocks we are actually starting the compile process. Compiler runs, converts C language into machine language and then we get our program."
    Public Const String_Open_Source As String = "Keywords:-" & Chr(13) & "Open Source" & Chr(13) & "" & Chr(13) & "About:-" & Chr(13) & "On the internet you can find many softwares that are free to download. There are also some softwares known as open-source softwares that are free to download and their source code is also available freely." & Chr(13) & "" & Chr(13) & "" & Chr(13) & "You may think that there are free softwares available everwhere so why should you know about open-source?" & Chr(13) & "The answer is: " & Chr(13) & "1. As programmers getting the source code of a software can be very useful. By spending some time to understand how the source code is making the software work you can learn to make different types of softwares free of cost. " & Chr(13) & "2. Open source softwares allow you to modify the Source code (with some restrictions) to make something different. So, if you are using a software and learn how it works you can add new features."
    Public Const String_Glossarys As String = "Keywords:-" & Chr(13) & "Glossary, Keywords" & Chr(13) & "" & Chr(13) & "Meaning:-" & Chr(13) & "Keywords are those words that are seen mostly in a particular field. For example you will come across the word IDE most of the times when you are programming. So, IDE is a keyword related to programming" & Chr(13) & "" & Chr(13) & "Glossary means a list of terms in a particular field. A glossary is generally alphabetically arranged. For example this software has two glossaries:-" & Chr(13) & "1. Glossary of Keywords" & Chr(13) & "	It contains an alphabetical list of keywords related to general programming, C language and the software used for making C software. Some other keywords are also present in it." & Chr(13) & "2. Glossary of Libraries And Functions" & Chr(13) & "	It contains an alphabetical list of libraries and functions used in C lnaguage."
    Public Const String_Libraries As String = "Keywords:-" & Chr(13) & "Libraries, Functions" & Chr(13) & "" & Chr(13) & "Simple about:-" & Chr(13) & "In the top lines of any C code there is a line like" & Chr(13) & "#include<stdio.h>" & Chr(13) & "The name inside the braces could be some other than this name. The name here is stdio.h. This stdio.h is a ""header file"". It is used to teach functions how to do their work. These header are also sometimes called libraries." & Chr(13) & "" & Chr(13) & "Technical:-" & Chr(13) & "The header files contain definitions of many functions. These function definitions give exact instructions about how the function works. These definitions are like any other function definition. The difference is that the functions in the standard libraries are generally tested and they work properly most of the time. User-made functions are generally not that extensively tested and contain comparatively more mistakes." & Chr(13) & "" & Chr(13) & "Libraries have the extension .h or .a"
    Public Const String_Tooltip As String = "Keywords:-" & Chr(13) & "Tooltip" & Chr(13) & "" & Chr(13) & "Where is this thing?" & Chr(13) & "When you start CodeBlocks you must have seen a windows that opens everytime. It has the heading 'ToolTip'. " & Chr(13) & "If it does not start when you start CodeBlocks then you can start it by going to Help Menu->Tips and then Tick the box ""Show Tips at Startup""." & Chr(13) & "" & Chr(13) & "So what is this tooltip?" & Chr(13) & "Tooltip is an a group of advices that the software shows you everytime. These tips contain information about how software works, about the shortcuts that you can use. In short tooltips display things that can make it easier for you to use the software."
    Public Const String_Code_Blocks_Shortcuts As String = "Keywords:-" & Chr(13) & "Code:Blocks Shortcuts" & Chr(13) & "" & Chr(13) & "1. Ctrl + Shift + N" & Chr(13) & "It can be used to create a new empty file" & Chr(13) & "" & Chr(13) & "2. Ctrl + D" & Chr(13) & "A. If used without selecting anything then the text of current line gets copied and pasted as-it-is in the next line" & Chr(13) & "B. If used after selecting some text then the selected text is copied and pasted where the selection ends" & Chr(13) & "" & Chr(13) & "3. Hold Ctrl and press Tab" & Chr(13) & "Is used to shift quickly between different files inside Code:blocks when more than one Source Codes are open." & Chr(13) & "" & Chr(13) & "4. F9" & Chr(13) & "Build And Run. Press this and if your Source Code has no syntax errors then your program will run"
    Public Const String_Programming As String = "Keywords:-" & Chr(13) & "Programming" & Chr(13) & "" & Chr(13) & "About:-" & Chr(13) & "Writing C Code is programming. " & Chr(13) & "Writing Codes in any computer language is programming." & Chr(13) & "" & Chr(13) & "Have you seen the apps on facebbok or the apps in android market?" & Chr(13) & "They are also made by programming. They were made by writing codes."
    Public Const String_C_Language As String = "Keywords:-" & Chr(13) & "C Language, Use of C Language" & Chr(13) & "" & Chr(13) & "About:-" & Chr(13) & "C Language is a general purpose programming language. It is widely used. Its main application areas include Operating System implementation and Embedded Systems. One of the main reasons of C language's popularity is its high-speed."
    Public Const String_Code As String = "Keywords:-" & Chr(13) & "Code, C Code, Source Code" & Chr(13) & "" & Chr(13) & "Introduction:-" & Chr(13) & "To make a software we need to write something in some computer language. That ""something"" which is written is called the code of the software or the Source Code." & Chr(13) & "" & Chr(13) & "While making C softwares you write codes in C Language. That is the ""C Code"" which will be used to make your program." & Chr(13) & "" & Chr(13) & "The following is an example of a source code." & Chr(13) & "/*-----------------------------------------" & Chr(13) & "#include<stdio.h>" & Chr(13) & "" & Chr(13) & "void main()" & Chr(13) & "{" & Chr(13) & "	printf(""AsD"");" & Chr(13) & "}" & Chr(13) & "------------------------------------------*/"
    Public Const String_Escape_Identifiers As String = "Keywords:-" & Chr(13) & "Escape Identifiers, New Line, Line Break, Tab Feed" & Chr(13) & "" & Chr(13) & "About:-" & Chr(13) & "When displaying something on the screen we have to use a function. The most common example is printf function. Inside such function there is a string of characters starting and ending with a quote(""). Whatever we wish to display can be written between the quotes. " & Chr(13) & "But if want something else to happen. Something like going into the next line or introducing a tab we have to use some special characters. These special characters are called escape identifiers. They start with backslash(\). Two examples are \n and \t." & Chr(13) & "" & Chr(13) & "\n (New Line or Line Break)" & Chr(13) & "When we write this inside a printing statement the characters appearing after this are dislayed in the next line." & Chr(13) & "" & Chr(13) & "\t(Tab Feed)" & Chr(13) & "When we write this inside a printing statement the characters appearing after this are dislayed after a tab."
    Public Const String_Comments As String = "Keywords:-" & Chr(13) & "Comments" & Chr(13) & "" & Chr(13) & "Comments are used in programming languages for many things:-" & Chr(13) & "1. Make the Code easy to read. " & Chr(13) & "This is done by entering comments with every different logic implemented. Simply writing what a particular piece of code does makes the code easier to read." & Chr(13) & "2. Commenting Out part of the Code. " & Chr(13) & "Any Code placed inside comments does not affect the program. It becomes inactive. So it is possible to let some code remain in your Source Code which is actually inactive. This is called commenting out part of the code. The part of the code inside the comments is OUT OF WORKING."

    'Second Batch of Glossary of Keywords

    'First Batch of Glossary of Libraries And Functions



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
    Public Sub Glossary_Button_Clicked()
        'This subroutine contains case statements for both Glossary of Keywords and Glossary of Libraries And Functions
        Select Case Form1.Lessons.SelectedItem
            'First Batch of Glossary of Keywords
            Case "Tool"
                Form1.Display2.Text = String_Tool
            Case "Open Source"
                Form1.Display2.Text = String_Open_Source
            Case "IDE"
                Form1.Display2.Text = String_Tool
            Case "Glossary"
                Form1.Display2.Text = String_Glossarys
            Case "Keywords"
                Form1.Display2.Text = String_Glossarys
            Case "Libraries"
                Form1.Display2.Text = String_Libraries
            Case "Functions"
                Form1.Display2.Text = String_Libraries
            Case "Code:Blocks"
                Form1.Display2.Text = String_Tool
            Case "Tooltip"
                Form1.Display2.Text = String_Tooltip
            Case "Code:Blocks Shortcuts"
                Form1.Display2.Text = String_Code_Blocks_Shortcuts
            Case "Programming"
                Form1.Display2.Text = String_Programming
            Case "C Language"
                Form1.Display2.Text = String_C_Language
            Case "Use of C Language"
                Form1.Display2.Text = String_C_Language
            Case "Integrated Development Environment"
                Form1.Display2.Text = String_Tool
            Case "C Software"
                Form1.Display2.Text = String_Tool
            Case "Compiler"
                Form1.Display2.Text = String_Tool
            Case "Code"
                Form1.Display2.Text = String_Code
            Case "C Code"
                Form1.Display2.Text = String_Code
            Case "Source Code"
                Form1.Display2.Text = String_Code
            Case "Escape Identifiers"
                Form1.Display2.Text = String_Escape_Identifiers
            Case "New Line"
                Form1.Display2.Text = String_Escape_Identifiers
            Case "Line Break"
                Form1.Display2.Text = String_Escape_Identifiers
            Case "Tab Feed"
                Form1.Display2.Text = String_Escape_Identifiers
            Case "Comments"
                Form1.Display2.Text = String_Comments

                'Second Batch of Glossary Keywords

        End Select
    End Sub
End Module
