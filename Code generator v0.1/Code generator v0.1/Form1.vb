Public Class Form1

    Const String_Version As String =
        "v 0.4"
    Const String_Project_Start As String =
        "24th August 2012"
    Const String_Version_Release As String =
        "28th August 2012"

    Const String_Start As String =
        "           Lesson 00" &
        Chr(13) & Chr(13) &
        "How to start using this Software?" &
        Chr(13) & Chr(13) &
        "1. Click on Lesson 01 in the list of Lessons. " &
        Chr(13) &
        "2. Click on the button =>Lesson Selected<= " &
        Chr(13) & Chr(13) &
        "    Some Steps are displayed in the List of Steps" &
        Chr(13) & Chr(13) &
        "3. Click on Step 01 in the List of Steps" &
        Chr(13) & Chr(13) &
        "   After following the instruction in 4th point the text displayed on this screen will change" &
        Chr(13) &
        "   Just read the instructions given there and follow them" &
        Chr(13) & Chr(13) &
        "4. Click on the button =>Step Selected<="
    Const String_About As String =
        "Developer           ==>   Aseem Bansal" &
        Chr(13) & Chr(13) &
        "Project Started on  ==> " & String_Project_Start &
        Chr(13) & Chr(13) &
        String_Version & " released  on  ==> " & String_Version_Release
    Const String_Contact_Me As String =
        "This is still a work in progress so if you want more features JUST send an me an" &
        "e-mail about what you want and I will add them as soon as I can" &
        Chr(13) & Chr(13) &
        "CONTACT:-" &
        Chr(13) &
        "aseembansal@ymail.com" &
        Chr(13) & Chr(13) &
        "Please write [C Programming Made A Game] in the title of the e-mail"
    Const String_Technical As String =
        "Tool on which the Codes have been tested" &
        Chr(13) &
        "1. Code:Blocks (An Open Source C/C++ IDE)  http://www.codeblocks.org/"
    Const String_Update As String =
        "https://programmingmadeagame.wordpress.com/download-links/" &
        Chr(13) & Chr(13) &
        "The above link is the website at which the latest version of this software will always be posted at the top" &
        Chr(13) & Chr(13) &
        "If you have downloaded a new version of this software then you do not need to uninstall this version. The Setup of the new version will automatically update the software."
    Const String_Why_Use_This_Software As String =
        "You may be thinking ""Why should I use this Software?""" &
        Chr(13) & Chr(13) &
        "   The answer is" &
        Chr(13) &
        "       1. Because it can teach you to make softwares easily" &
        Chr(13) &
        "       2. Because it is simple to learn by using this software" &
        Chr(13) &
        "       3. Because this software will be updated regularly and you will get new content frequently"
    Const String_Lesson01_Goal As String =
                "1. Use a software to make a simple software"
    Const String_Lesson01_Step01_Goal As String =
        "THE GOALS" &
        Chr(13) & Chr(13) &
        "1. Getting a software for making software" &
        Chr(13) &
        "2. Installing the software" &
        Chr(13) &
        "3. Starting the software" &
        Chr(13) &
        "4. Copying something into the software" &
        Chr(13) &
        "5. Making a simple software" &
        Chr(13) & Chr(13) & Chr(13) &
        "What SHOULD NOT BE THE GOAL" &
        Chr(13) & Chr(13) &
        "To know how the things are happening when we are following the instructions given next. Just follow the step-by-step instructions. Things will be explained later." &
        Chr(13) & Chr(13) &
        "DO NOT BE AFRAID TO FOLLOW THE INSTRUCTIONS" &
        Chr(13) & Chr(13) &
        "There are 12 instructions given next BUT they are EASY TO USE step-by-step instructions. So now click on instructions button"
    Const String_Lesson01_Step01_Instructions As String =
        "1. If you have Code:Blocks 10.05 mingw already installed on your computer then you can go to point 5." &
        Chr(13) & Chr(13) &
        "   If you do not understand what is written in the above line go to the next point" &
        Chr(13) & Chr(13) &
        "2. Open this website http://www.codeblocks.org/downloads/26#windows in your web browser(e.g. Internet Explorer, Google Chrome etc.)" &
        Chr(13) & Chr(13) &
        "3. Now Click on either of the 2 download links of codeblocks-10.05mingw-setup.exe" &
        Chr(13) & Chr(13) &
        " -> When the software is downloaded we completed the first goal" &
        Chr(13) & Chr(13) &
        "4. Now install it. For installing it double click and keep on clicking all the 'yes' and 'next' that come in installation" &
        Chr(13) & Chr(13) &
        "5. An option appears for starting the software. You need to start the software and end the installation" &
        Chr(13) & Chr(13) &
        " -> We completed the 2nd goal now" &
        Chr(13) & Chr(13) &
        "6. When the software starts there is a thing called tooltip. Close it." &
        Chr(13) & Chr(13) &
        " -> We completed the 3rd goal now" &
        Chr(13) & Chr(13) &
        "7. Now you will have a white space with 'Start Here' Written near the top left" &
        Chr(13) & Chr(13) &
        "8. Press Ctrl+Shift+N. That means that you to press all three of these together. If that is tough then go to File Menu => New => Click on Empty File" &
        Chr(13) & Chr(13) &
        "9. A new tab would appear with the name *Untitled1 near the 'Start Here' at the top of white space" &
        Chr(13) & Chr(13) &
        "10. Now Copy the words given in 'Code to be Copied' section in the white space" &
        Chr(13) & Chr(13) &
        " -> We completed the second last goal" &
        Chr(13) & Chr(13) &
        "11. Press Ctrl+S to Save the file. Name it 1.1 which stands for Lesson01 Step01" &
        Chr(13) & Chr(13) &
        "12. Now Press F9. Wait a moment and a screen will appear. There is 'I just made a software' written on it and some other things also written in the next lines." &
        Chr(13) & Chr(13) & Chr(13) &
        "So that is the simple software running. So we completed our last goal also. Also the first main goal of this lesson has also been completed" &
        Chr(13) & Chr(13) &
        "That was not difficult. Was it? Remember that you will not have to download the software again. It will be installed in your computer so you just need to copy some words into it, press F9 and your software will be made"
    Const String_Lesson01_Step01_Code_To_Be_Copied As String =
        "#include<stdio.h>" &
        Chr(13) & Chr(13) &
        "void main()" &
        Chr(13) &
        "{" &
        Chr(13) &
        "	printf(""\n\n\nI just made a software\n\n\n\n"");""" &
        Chr(13) &
        "}"
    Const String_Lesson01_Step01_Details_Of_The_Code As String =
        "SUGGESTED:-" &
        Chr(13) & Chr(13) &
        "When Reading this section feel free to switch between the section ""Code to be Copied"" and this section." &
        " I would advise to switch when you do not know any word that we are talking about." &
        " Switch to ""Code to be copied"" section and find where the word is in the Code." &
        " Switch back to this section and read the explanation of the word." &
        " Do this again and again until you think you understand." &
        " If you face any problem understanding then Contact Me." &
        Chr(13) & Chr(13) & Chr(13) &
        "EXPLANATION" &
        Chr(13) & Chr(13) &
        "1. #include<stdio.h>" &
        Chr(13) &
        "   A. This is the thing written in the first line." &
        Chr(13) &
        "   B. You will see this line in ALMOST ALL softwares made using C language." &
        Chr(13) &
        "   C. For now it is enough to know that this is known as a ""LIBRARY"" " &
        Chr(13) &
        "   D. It is used in this software to teach ""printf"" (explained later) to display on the screen" &
        Chr(13) & Chr(13) &
        "2. void main()" &
        Chr(13) &
        "   A. This is second thing that is in the Code" &
        Chr(13) &
        "   B. This is present in ALL softwares made by C Language" &
        Chr(13) &
        "   C. For now it is enough to know that this is known as a ""FUNCTION""" &
        Chr(13) &
        "   D. Without this a software made in C Language CANNOT DO ANYTHING" &
        Chr(13) & Chr(13) &
        "3. printf(""\n\n\nI just made a software\n\n\n\n"");" &
        Chr(13) &
        "   A. This is the thing that displays ""I just made a software"" on the screen" &
        Chr(13) &
        "   B. It is also a ""FUNCTION""" &
        Chr(13) &
        "   C. It is used in MANY places where we want to display something on the screen" &
        Chr(13) &
        "   D. In C language displaying on the screen is called printing on the screen so this FUNCTION which does the displaying is named printf. If you are worrying about the f we will explain that later" &
        Chr(13) & Chr(13) &
        "4. {  } -The Braces Used" &
        Chr(13) &
        "   A. These braces are used for containing all the code" &
        Chr(13) &
        "   B. After every void main() these braces are a MUST" &
        Chr(13) &
        "   C. Most of the code is written inside it. Like printf statement" &
        Chr(13) & Chr(13) &
        "Now, Click on the next section ""Further Technical Details"""
    Const String_Lesson01_Step01_Further_Technical_Details As String =
        "Till now you have followed many steps and been introduced to many new things. If you wish to take a rest it is suggested that you take it now. These details are meant for the time when you want to know even more. If you wish to skip this step then do it. If want to know more then here is more things for you to know." &
        Chr(13) & Chr(13) & Chr(13) &
        "TERMS RELATED TO MAKING SOFTWARE" &
        Chr(13) &
        "Explained Simply" &
        Chr(13) & Chr(13) &
        "1. C Software/IDE/Integrated Development Environment" &
        Chr(13) &
        "The goal of Step01 was to get a software for making softwares. Now, what is this software? In Technical terms it is known as an ""IDE"" or Integrated Development Environment. It is a combination of many softwares that are all needed to make a software." &
        Chr(13) & Chr(13) &
        "2. Code/C Code/Source Code" &
        Chr(13) &
        "We copied a Code into the IDE and made a software using that code. It is also known as Source code or C Souce Code or C Code. Now, what is this code? Code is group of instructions that computer can understand. These instructions tell computer what to do, how to do it and when to do it. For example,  printf is an instruction for displaying things on the screen. " &
        Chr(13) & Chr(13) &
        "3. Programming" &
        Chr(13) &
        " For making software we need to write codes in a language that computer can understand. Writing this language is known as programming." &
        Chr(13) & Chr(13) &
        "4. C Language" &
        Chr(13) &
  "The software's name is ""C Programming Made A Game"". So what is this C language? C is a famous programming language that is used for all different kinds of things. Its capacity goes from displaying things on the screen to making a complete Operating System(e.g. Windows, Linux etc.)" &
        Chr(13) & Chr(13) & Chr(13) &
        "SOME QUESTIONS ANSWERED" &
        Chr(13) &
        "1. How can I change the thing displayed on the screen in the software that I made?" &
        Chr(13) &
        "A. Just place the thing that you want to display between the stating "" and the ending "" in printf." &
        Chr(13) & Chr(13) & Chr(13) &
        "This Step is done. Now you can select Step02 from the list of steps"
    Const String_Lesson02_Goal As String =
        ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "C Programming Made A Game " & String_Version
        Current_Display.Text = "->Use this software"
        Display.Text = String_Start
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Current_Display.Text = "->Use this software"
        Display.Text = String_Start
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Current_Display.Clear()
        Display.Text = String_About
    End Sub

    Private Sub TechnicalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TechnicalToolStripMenuItem1.Click
        Current_Display.Clear()
        Display.Text = String_Technical
    End Sub

    Private Sub ContactMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactMeToolStripMenuItem.Click
        Current_Display.Clear()
        Display.Text = String_Contact_Me
    End Sub

    Private Sub HelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelToolStripMenuItem.Click
        Current_Display.Clear()
        Display.Text = String_Update
    End Sub

    Private Sub WhyThisSoftwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhyThisSoftwareToolStripMenuItem.Click
        Current_Display.Clear()
        Display.Text = String_Why_Use_This_Software
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Lessons.SelectedItem
            Case "Lesson 01"
                Current_Display.Clear()
                Current_Display.Text = String_Lesson01_Goal
                Me.Steps.Items.Clear()
                Me.Steps.Items.Add("Step 01")
                Me.Steps.Items.Add("Step 02")
            Case "Lesson 02"
                Current_Display.Clear()
                Current_Display.Text = String_Lesson02_Goal
                Display.Clear()
                Me.Steps.Items.Clear()
                Me.Steps.Items.Add("Step 01")
                Me.Steps.Items.Add("Step 02")
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RadioButton6.Select()
        RadioButton1.Select()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Select Case Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = String_Lesson01_Step01_Goal
                    Case "Step 02"
                        Display.Text = ""
                End Select
            Case "Lesson 02"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = ""
                    Case "Step 02"
                        Display.Text = ""
                End Select
        End Select
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Select Case Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = String_Lesson01_Step01_Instructions
                    Case "Step 02"
                        Display.Text = ""
                End Select
            Case "Lesson 02"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = ""
                    Case "Step 02"
                        Display.Text = ""
                End Select
        End Select
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Select Case Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = String_Lesson01_Step01_Code_To_Be_Copied
                    Case "Step 02"
                        Display.Text = ""
                End Select
            Case "Lesson 02"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = ""
                    Case "Step 02"
                        Display.Text = ""
                End Select
        End Select
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Select Case Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = String_Lesson01_Step01_Details_Of_The_Code
                    Case "Step 02"
                        Display.Text = ""
                End Select
            Case "Lesson 02"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = ""
                    Case "Step 02"
                        Display.Text = ""
                End Select
        End Select
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Select Case Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = String_Lesson01_Step01_Further_Technical_Details
                    Case "Step 02"
                        Display.Text = ""
                End Select
            Case "Lesson 02"
                Select Case Steps.SelectedItem
                    Case "Step 01"
                        Display.Text = ""
                    Case "Step 02"
                        Display.Text = ""
                End Select
        End Select
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Display.Clear()
    End Sub

End Class

