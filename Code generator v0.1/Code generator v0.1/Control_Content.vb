Module Control_Content

    Public Sub RadioButton1_Checked()
        'This is used to set content of GOALS section
        If Form1.Selected_Lesson <> "" Then
            Form1.Label3.Text = "The Goal Of this lesson is to"
            Select Case Form1.Selected_Lesson
                Case "Lesson 001"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson01_Step01_Goal
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson01_Step02_Goal
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson01_Step03_Goal
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson01_Step04_Goal
                    End Select
                Case "Lesson 002"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson02_Step01_Goal
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson02_Step02_Goal
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson02_Step03_Goal
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson02_Step04_Goal
                    End Select
            End Select
        End If
    End Sub

    Public Sub RadioButton2_Checked()
        'This is used to set content of INSTRUCTIONS section
        If Form1.Selected_Lesson <> "" Then
            Form1.Label3.Text = "The Goal Of this lesson is to"
            Select Case Form1.Selected_Lesson
                Case "Lesson 001"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson01_Step01_Instructions
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson01_Step02_Instructions
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson01_Step03_Instructions
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson01_Step04_Instructions
                    End Select
                Case "Lesson 002"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson02_Step01_Instructions
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson02_Step02_Instructions
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson02_Step03_Instructions
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson02_Step04_Instructions
                    End Select
            End Select
        End If
    End Sub

    Public Sub RadioButton3_Checked()
        'This is used to set content of CODE TO BE COPIED section
        If Form1.Selected_Lesson <> "" Then
            Form1.Label3.Text = "The Goal Of this lesson is to"
            Select Case Form1.Selected_Lesson
                Case "Lesson 001"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson01_Step01_Code_To_Be_Copied
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson01_Step02_Code_To_Be_Copied
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson01_Step03_Code_To_Be_Copied
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson01_Step04_Code_To_Be_Copied
                    End Select
                Case "Lesson 002"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson02_Step01_Code_To_Be_Copied
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson02_Step02_Code_To_Be_Copied
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson02_Step03_Code_To_Be_Copied
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson02_Step04_Code_To_Be_Copied
                    End Select
            End Select
        End If
    End Sub

    Public Sub RadioButton4_Checked()
        'This is used to set content of DETAILS OF THE CODE section
        If Form1.Selected_Lesson <> "" Then
            Form1.Label3.Text = "The Goal Of this lesson is to"
            Select Case Form1.Selected_Lesson
                Case "Lesson 001"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson01_Step01_Details_Of_The_Code
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson01_Step02_Details_Of_The_Code
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson01_Step03_Details_Of_The_Code
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson01_Step04_Details_Of_The_Code
                    End Select
                Case "Lesson 002"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson02_Step01_Details_Of_The_Code
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson02_Step02_Details_Of_The_Code
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson02_Step03_Details_Of_The_Code
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson02_Step04_Details_Of_The_Code
                    End Select
            End Select
        End If
    End Sub

    Public Sub RadioButton5_Checked()
        'This is used to set content of FURTHER DETAILS section
        If Form1.Selected_Lesson <> "" Then
            Form1.Label3.Text = "The Goal Of this lesson is to"
            Select Case Form1.Selected_Lesson
                Case "Lesson 001"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson01_Step01_Further_Technical_Details
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson01_Step02_Further_Technical_Details
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson01_Step03_Further_Technical_Details
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson01_Step04_Further_Technical_Details
                    End Select
                Case "Lesson 002"
                    Select Case Form1.Selected_Step
                        Case "Step 001"
                            Form1.Display.Text = String_Lesson02_Step01_Further_Technical_Details
                        Case "Step 002"
                            Form1.Display.Text = String_Lesson02_Step02_Further_Technical_Details
                        Case "Step 003"
                            Form1.Display.Text = String_Lesson02_Step03_Further_Technical_Details
                        Case "Step 004"
                            Form1.Display.Text = String_Lesson02_Step04_Further_Technical_Details
                    End Select
            End Select
        End If
    End Sub

End Module
