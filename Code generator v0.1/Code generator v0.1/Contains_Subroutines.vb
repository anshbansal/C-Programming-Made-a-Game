Module Contains_Subroutines

    Public Sub ShowGlossary()
        'This subroutine is used to show the GLOSSARY
        Form1.Button1.Hide()
        Form1.Button2.Hide()
        Form1.Label2.Hide()
        Form1.Steps.Hide()

        Form1.RadioButton1.Hide()
        Form1.RadioButton2.Hide()
        Form1.RadioButton3.Hide()
        Form1.RadioButton4.Hide()
        Form1.RadioButton5.Hide()
        Form1.RadioButton6.Hide()
        Form1.Button3.Text = "Keyword Selected" & Chr(13) & " Show Details"
        Form1.Button4.Text = "Using Glossary Complete"
        Form1.Button3.Show()
        Form1.Button4.Show()
        Form1.Lessons.Height = 200
    End Sub

End Module
