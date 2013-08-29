Public Class Form1

    Public Const String_Version As String = "v 0.9"
    Public Const String_Project_Start As String = "24th August 2012"
    Public Const String_Version_Release As String = "Not Yet"
    Public Selected_Lesson As String = ""
    Public Selected_Step As String = ""



    'Subroutine For deciding what happens when Form1 Loads
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "C Programming Made A Game " & String_Version 'Places Name of the Form

        ChangeDisplays("How to use this software", String_Start) 'Initialize Home Displays
        RadioButton9.Select() 'Initialize Glossary Display

        Label3.Font = New Font("Microsoft Sans Serif", 9.5, FontStyle.Regular)
        Display.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        Display2.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        Current_Display.Font = New Font("Microsoft Sans Serif", 9.5, FontStyle.Regular)
    End Sub
    'Subroutine For deciding what happens when Form1 Loads END



    'SUBROUTINES FOR GLOSSARY
    Private Sub Lessons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lessons.SelectedIndexChanged
        Glossary_Button_Clicked()
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        ShowGlossaryOfKeywords()
    End Sub
    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        ShowGlossaryOfLibrariesAndFunctions()
    End Sub
    Public Sub GlossaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlossaryToolStripMenuItem.Click
        TabControl1.SelectTab(1)
        Display2.Text = String_Glossary
    End Sub
    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Display2.Text = String_Glossary
        Label1.Text = ""
        Lessons.Items.Clear()
    End Sub
    'SUBROUTINES FOR GLOSSARY



    'SUBROUTINES FOR SIMPLE MENU ITEMS
    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        ChangeDisplays("How to use this software", String_Start)
    End Sub
    Public Sub WhyThisSoftwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhyUseThisSoftwareToolStripMenuItem.Click
        ChangeDisplays("Why you should use this software", String_Why_Use_This_Software)
    End Sub
    Private Sub AboutTheAuthorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTheAuthorToolStripMenuItem.Click
        ChangeDisplays("About the author", String_About)
    End Sub
    Private Sub TechnicalDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TechnicalDetailsToolStripMenuItem.Click
        ChangeDisplays("Technical Details", String_Technical)
    End Sub
    Private Sub ContactInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactInformationToolStripMenuItem.Click
        ChangeDisplays("Help", String_Help)
    End Sub
    Private Sub UpdateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem1.Click
        ChangeDisplays("Updating this software", String_Update)
    End Sub
    'SUBROUTINES FOR SIMPLE MENU ITEMS END



    'SUBROUTINES FOR RADIO BUTTONS
    'The actual subroutines are in FILE Control_Content
    Public Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1_Checked()
    End Sub
    Public Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton2_Checked()
    End Sub
    Public Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        RadioButton3_Checked()
    End Sub
    Public Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton4_Checked()
    End Sub
    Public Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton5_Checked()
    End Sub
    'SUBROUTINES FOR RADIO BUTTONS END



    'SUBROUTINES FOR CONTEXT MENU STRIP 1
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        System.Windows.Forms.Clipboard.SetText(Display.Text)
    End Sub
    'SUBROUTINES FOR CONTEXT MENU STRIP 1 END



    'SUBROUTINES OF LESSON 1
    Private Sub Step1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Step1ToolStripMenuItem.Click
        L1_S1()
    End Sub
    Private Sub Step2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Step2ToolStripMenuItem.Click
        L1_S2()
    End Sub
    Private Sub Step3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Step3ToolStripMenuItem.Click
        L1_S3()
    End Sub
    Private Sub Step4ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Step4ToolStripMenuItem.Click
        L1_S4()
    End Sub
    Private Sub Lesson1ToolStripMenuItem_DropDownOpened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lesson1ToolStripMenuItem.DropDownOpened
        L1()
    End Sub
    'SUBROUTINES OF LESSON 1 END HERE



    'SUBROUTINES OF LESSON 2
    Private Sub Lesson2ToolStripMenuItem_DropDownOpened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lesson2ToolStripMenuItem.DropDownOpened
        L2()
    End Sub
    Private Sub Step1ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Step1ToolStripMenuItem1.Click
        L2_S1()
    End Sub
    'SUBROUTINES OF LESSON 2 END
End Class