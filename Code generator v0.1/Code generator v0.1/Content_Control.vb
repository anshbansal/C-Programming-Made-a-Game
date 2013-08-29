Module Content_Control

    Public Sub AddLessons()
        'This Adds Lessons to the List of Lessons
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Form1.Lessons.Items.Clear()
        Form1.Lessons.Items.Add("Lesson 01")
        Form1.Lessons.Items.Add("Lesson 02")
    End Sub

    Public Sub Button1_Clicked()
        'This is used to ADD STEPS TO THE LIST OF STEPS After Selecting Lesson Number
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Select Case Form1.Lessons.SelectedItem
            Case "Lesson 01"
                Form1.Current_Display.Clear()
                Form1.Current_Display.Text = String_Lesson01_Goal
                Form1.Steps.Items.Clear()
                Form1.Steps.Items.Add("Step 01")
                Form1.Steps.Items.Add("Step 02")
                Form1.Steps.Items.Add("Step 03")
                Form1.Steps.Items.Add("Step 04")
            Case "Lesson 02"
                Form1.Current_Display.Clear()
                Form1.Current_Display.Text = String_Lesson02_Goal
                Form1.Display.Clear()
                Form1.Steps.Items.Clear()
                Form1.Steps.Items.Add("Step 01")
        End Select
    End Sub

    Public Sub RadioButton1_Checked()
        'This is used to set content of GOALS section
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Select Case Form1.Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson01_Step01_Goal
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson01_Step02_Goal
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson01_Step03_Goal
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson01_Step04_Goal
                End Select
            Case "Lesson 02"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson02_Step01_Goal
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson02_Step02_Goal
                End Select
        End Select
    End Sub

    Public Sub RadioButton2_Checked()
        'This is used to set content of INSTRUCTIONS section
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Select Case Form1.Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson01_Step01_Instructions
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson01_Step02_Instructions
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson01_Step03_Instructions
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson01_Step04_Instructions
                End Select
            Case "Lesson 02"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson02_Step01_Instructions
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson02_Step02_Instructions
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson02_Step03_Instructions
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson02_Step04_Instructions
                End Select
        End Select
    End Sub

    Public Sub RadioButton3_Checked()
        'This is used to set content of CODE TO BE COPIED section
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Select Case Form1.Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson01_Step01_Code_To_Be_Copied
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson01_Step02_Code_To_Be_Copied
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson01_Step03_Code_To_Be_Copied
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson01_Step04_Code_To_Be_Copied
                End Select
            Case "Lesson 02"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson02_Step01_Code_To_Be_Copied
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson02_Step02_Code_To_Be_Copied
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson02_Step03_Code_To_Be_Copied
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson02_Step04_Code_To_Be_Copied
                End Select
        End Select
    End Sub

    Public Sub RadioButton4_Checked()
        'This is used to set content of DETAILS OF THE CODE section
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Select Case Form1.Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson01_Step01_Details_Of_The_Code
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson01_Step02_Details_Of_The_Code
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson01_Step03_Details_Of_The_Code
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson01_Step04_Details_Of_The_Code
                End Select
            Case "Lesson 02"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson02_Step01_Details_Of_The_Code
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson02_Step02_Details_Of_The_Code
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson02_Step03_Details_Of_The_Code
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson02_Step04_Details_Of_The_Code
                End Select
        End Select
    End Sub

    Public Sub RadioButton5_Checked()
        'This is used to set content of FURTHER DETAILS section
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Select Case Form1.Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson01_Step01_Further_Technical_Details
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson01_Step02_Further_Technical_Details
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson01_Step03_Further_Technical_Details
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson01_Step04_Further_Technical_Details
                End Select
            Case "Lesson 02"
                Select Case Form1.Steps.SelectedItem
                    Case "Step 01"
                        Form1.Display.Text = String_Lesson02_Step01_Further_Technical_Details
                    Case "Step 02"
                        Form1.Display.Text = String_Lesson02_Step02_Further_Technical_Details
                    Case "Step 03"
                        Form1.Display.Text = String_Lesson02_Step03_Further_Technical_Details
                    Case "Step 04"
                        Form1.Display.Text = String_Lesson02_Step04_Further_Technical_Details
                End Select
        End Select
    End Sub

    Public Sub RadioButton6_Checked()
        'This is used to set content of NONE section
        Form1.Label3.Text = "The Goal Of this lesson is to"
        Form1.Display.Clear()
    End Sub

End Module
