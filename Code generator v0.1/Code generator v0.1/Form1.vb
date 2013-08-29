Public Class Form1

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Display.Text = "How can this app help YOU??" &
               Chr(13) & Chr(13) &
               "            It can teach you C language without Books" &
               Chr(13) & Chr(13) &
               "                In 15 MINUTES AT A TIME" &
                Chr(13) & Chr(13) &
               "Developer           =>   Aseem Bansal" &
               Chr(13) & Chr(13) &
               "Project Started on  =>   24th August 2012" &
               Chr(13) & Chr(13) &
               "Current Version     =>   0.2"

    End Sub

    Private Sub VersionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionToolStripMenuItem.Click
        Display.Text = "This is still a work in progress so" &
               Chr(13) &
               "If you want more features JUST send an me an e-mail about what you want " &
               Chr(13) &
               "and I will add them as soon as I can" &
               Chr(13) & Chr(13) &
               "NOTE:-" &
               Chr(13) &
               "Please write" &
               Chr(13) &
               "[C Programming Made A Game]" &
               Chr(13) &
               "in the title of the e-mail" &
               Chr(13) & Chr(13) &
               "CONTACT:-" &
               Chr(13) &
               "aseembansal@ymail.com"
    End Sub

    Private Sub TechnicalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TechnicalToolStripMenuItem.Click
        Display.Text = "Tool on which the Codes have been tested" &
               Chr(13) &
               "1. Code:Blocks (An Open Source C/C++ IDE)  http://www.codeblocks.org/"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Lessons.SelectedItem
            Case "Lesson 01"
                Me.Steps.Items.Clear()
                Me.Steps.Items.Add("Step 01")
            Case "Lesson 02"
                Me.Steps.Items.Clear()
                Me.Steps.Items.Add("No Steps Added Here")
            Case "Lesson 03"
                Me.Steps.Items.Clear()
                Me.Steps.Items.Add("No Steps Added Here")
            Case "Lesson 04"
                Me.Steps.Items.Clear()
                Me.Steps.Items.Add("No Steps Added Here")
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case Lessons.SelectedItem
            Case "Lesson 01"
                Select Case Steps.SelectedItem
                    Case "Step 01"

                        Display.Text = "Aseem Bansal"
                End Select
            Case "Lesson 02"
        End Select
    End Sub

End Class
