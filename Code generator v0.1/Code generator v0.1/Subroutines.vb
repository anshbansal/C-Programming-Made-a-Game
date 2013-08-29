Module Subroutines

    Public Sub ShowGlossaryOfKeywords()
        Form1.Label1.Text = "Keywords List"
        AddKeywords()
    End Sub

    Public Sub ShowGlossaryOfLibrariesAndFunctions()
        Form1.Label1.Text = "Libraries And Functions List"
        AddLibraries()
    End Sub

    Public Sub ChangeDisplays(ByVal Current As String, ByVal Disp As String)
        'This Subroutine is for CHANGING DISPLAYS WHEN CLICK ON MENUS
        'First Argument = smaller display's Text
        'Second Argment = bigger display's Text
        Form1.Current_Display.Text = Current
        Form1.Display.Text = Disp
        Form1.Label3.Text = "What is being Displayed"
        Form1.ToolStripStatusLabel1.Text = ""
        Form1.Selected_Lesson = ""
        Form1.Selected_Step = ""
    End Sub

    Public Sub ShowWhenClickOnLesson(ByVal LessonNumber As String, ByVal LessonGoal As String)
        'This Subroutine is for WHEN USER CLICKS ON ANY LESSON
        'First argument = Lesson Number ("001")
        'Second argument =  String containing LESSON GOAL
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Form1.Current_Display.Text = LessonGoal
        Form1.ToolStripStatusLabel1.Text = "Lesson " & LessonNumber
    End Sub

    Public Sub WhenClickOnStep(ByVal LessonNumber As String, ByVal StepNumber As String)
        'This Subroutine Changes variables when a step is selected
        'Enter the vaiables as "001", "001"
        Form1.Selected_Lesson = "Lesson " & LessonNumber
        Form1.Selected_Step = "Step " & StepNumber
        Form1.ToolStripStatusLabel1.Text = "Lesson " & LessonNumber & " Step " & StepNumber
        Form1.Display.Clear()
        Form1.RadioButton6.Select()
        Form1.RadioButton1.Select()
    End Sub

End Module
