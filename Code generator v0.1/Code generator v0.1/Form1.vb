Public Class Form1

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("How can this app help you:-" &
               Chr(13) &
               "It can give you the C codes that you are looking for" &
               Chr(13) & Chr(13) &
               "Developer :" &
               Chr(13) &
               "Aseem Bansal" &
               Chr(13) & Chr(13) &
               "Project Started on:-" &
               Chr(13) &
               "24th August 2012",
               "About"
               )
    End Sub

    Private Sub VersionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionToolStripMenuItem.Click
        MessageBox.Show("This is still a work in progress so" &
               Chr(13) &
               "If you want more features JUST send an me an e-mail about what you want " &
               Chr(13) &
               "and I will add them as soon as I can" &
               Chr(13) & Chr(13) &
               "NOTE:-" &
               Chr(13) &
               "Please write" &
               Chr(13) &
               "[C Code generator v0.1]" &
               Chr(13) &
               "in the title of the e-mail" &
               Chr(13) & Chr(13) &
               "CONTACT:-" &
               Chr(13) &
               "aseembansal@ymail.com",
               "Adding more features to this")
    End Sub

    Private Sub TechnicalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TechnicalToolStripMenuItem.Click
        MessageBox.Show("Tool on which the Codes have been tested" &
               Chr(13) &
               "1. Code:Blocks (An Open Source C/C++ IDE)  http://www.codeblocks.org/", "Technical Detials"
               )
    End Sub

End Class
