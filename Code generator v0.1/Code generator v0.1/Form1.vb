Public Class Form1

    Public Const String_Version As String = "v 0.7"
    Public Const String_Project_Start As String = "24th August 2012"
    Public Const String_Version_Release As String = "4th September 2012"

    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'This subroutine is used when GLOSSARY IS ENDED
        Lessons.Height = 82
        Button1.Show()
        Button2.Show()
        Label2.Show()
        Steps.Show()

        RadioButton1.Show()
        RadioButton2.Show()
        RadioButton3.Show()
        RadioButton4.Show()
        RadioButton5.Show()
        RadioButton6.Show()
        Button3.Hide()
        Button4.Hide()
        Label1.Text = "List Of Lessons"
        AddLessons()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "C Programming Made A Game " & String_Version
        Current_Display.Text = "How to use this software"
        Display.Text = String_Start
        Label1.Text = "List of Lessons"
        Label2.Text = "List of Steps"
        Label3.Text = "What is being Displayed"
        Label1.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        Label2.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        Label3.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        Button3.Hide()
        Button4.Hide()
        AddLessons()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label3.Text = "The Goal Of this lesson is to"
        RadioButton6.Select()
        RadioButton1.Select()
    End Sub
    Private Sub KeywordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeywordsToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "Keywords Glossary"
        Display.Clear()
        ShowGlossary()
        Label1.Text = "Keywords List"
        AddKeywords()
    End Sub
    Private Sub LibrariesAndFunctionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibrariesAndFunctionsToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "Libraries And Function Glossary"
        Display.Clear()
        ShowGlossary()
        Label1.Text = "Libraries And Functions List"
        AddLibraries()
    End Sub
    Public Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "How to use this software"
        Display.Text = String_Start
    End Sub
    Public Sub WhyThisSoftwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhyThisSoftwareToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "Why you should use this software"
        Display.Text = String_Why_Use_This_Software
    End Sub
    Public Sub GlossaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlossaryToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "About Glossary"
        Display.Text = String_Glossary
    End Sub

    'YOU NEED TO LEAVE THINGS FROM HERE ALONE
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1_Clicked() 'Leave this alone
    End Sub
    Public Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1_Checked() 'Leave this alone
    End Sub
    Public Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton2_Checked() 'Leave this alone
    End Sub
    Public Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        RadioButton3_Checked() 'Leave this alone
    End Sub
    Public Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton4_Checked() 'Leave this alone
    End Sub
    Public Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton5_Checked() 'Leave this alone
    End Sub
    Public Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        RadioButton6_Checked() 'Leave this alone
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3_Clicked() 'Leave this alone
    End Sub
    'LEAVE ALONE TILL HERE

    Private Sub AboutTheAuthorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutTheAuthorToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "About this software"
        Display.Text = String_About
    End Sub
    Private Sub TechnicalDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TechnicalDetailsToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "Technical Details"
        Display.Text = String_Technical
    End Sub
    Private Sub ContactInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactInformationToolStripMenuItem.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "Help"
        Display.Text = String_Help
    End Sub
    Private Sub UpdateToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem1.Click
        Label3.Text = "What is being Displayed"
        Current_Display.Text = "Updating this software"
        Display.Text = String_Update
    End Sub
End Class