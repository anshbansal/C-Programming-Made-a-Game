Module Lesson002
    Public Const String_Lesson02_Goal As String = ""

    Public Const String_Lesson02_Step01_Goal As String = "THE GOALS OF STEP 1:-" & Chr(13) & "" & Chr(13) & "[ALL OF THE FOLLOWING IS DONE BY USING C LANGUAGE]" & Chr(13) & "1. Learn how to log off the computer" & Chr(13) & "2. Learn how to fast log off the computer" & Chr(13) & "3. Learn how to shutdown computer and set some time for shutting computer down" & Chr(13) & "4. Learn how to abort a shutdown" & Chr(13) & "5. Learn how to restart computer"
    Public Const String_Lesson02_Step01_Instructions As String = "1. Open the software Codeblocks" & Chr(13) & "" & Chr(13) & "2. Copy code 2.1 into a new file. Before running it you should know that when you run this code it will LOG OFF the computer(current user account).  After you login again read the Details of the Code section point 1 for explanation. Run it to see that this works." & Chr(13) & "" & Chr(13) & "3. Change ""-l"" in the Code to ""-f"". This is for FAST LOG OFF. Before running the new program you should know that this will immediately close ALL open programs and will not save anything. Run the program. " & Chr(13) & "" & Chr(13) & "4. Now see the list of commands in ""Details of the Code"". Try out the different commands." & Chr(13) & "" & Chr(13) & "5. After you are done with all the commands then read ""Further Technical Details"" section."
    Public Const String_Lesson02_Step01_Code_To_Be_Copied As String = "/*	<=START COPYING FROM THIS LINE" & Chr(13) & "CODE 2.1" & Chr(13) & "*/" & Chr(13) & "#include <stdlib.h>" & Chr(13) & "" & Chr(13) & "int main()" & Chr(13) & "{" & Chr(13) & "    system(""C:\\WINDOWS\\System32\\shutdown -l"");" & Chr(13) & "" & Chr(13) & "    return 0;" & Chr(13) & "}" & Chr(13) & "" & Chr(13) & "/*" & Chr(13) & "END OF CODE 2.1" & Chr(13) & "	<=COPY TILL THIS LINE ----------------------*/"
    Public Const String_Lesson02_Step01_Details_Of_The_Code As String = "ABOUT LOG OFF PROGRAM" & Chr(13) & "Remeber the function system() that we used earlier to clear the screen? The function used here is the same function. But this time its argument is different. Argument is the thing inside the brackets. The argument this time is:" & Chr(13) & """C:\\WINDOWS\\System32\\shutdown -l""" & Chr(13) & "" & Chr(13) & "The starting words from C:\ to the word System31\ is actually a path in the computer where a program is always present in Windows. The program is ""shutdown.exe"". We are starting that program using this system call function system(). After that we added -l. That is a L in small letters not 1. The L stands for log off. " & Chr(13) & "" & Chr(13) & "In the next programs only this L needs to be changed and a few more words added to do everything from shut down to restart." & Chr(13) & "" & Chr(13) & "LIST OF COMMANDS:-" & Chr(13) & "-l = Log Off" & Chr(13) & "-f = Fast Log Off" & Chr(13) & "-s = Shutdown Computer" & Chr(13) & "-s -t 60 = Shutdown Computer after 60 seconds" & Chr(13) & "-s -t x = Shutdown computer after x seconds (Place any number in place of x)" & Chr(13) & "-r = Restart computer" & Chr(13) & "-r -t 60 = Restart Computer after 60 seconds" & Chr(13) & "-r -t x = Restart Computer after x seconds (Place any number in place of x)" & Chr(13) & "-a = Abort Shutdown or Restart" & Chr(13) & "-? = See this list of commands. Do not press any button when the new windows of commands opens."
    Public Const String_Lesson02_Step01_Further_Technical_Details As String = "1. The system( ) function used is called system call. It can be used for MANY things. A LOT of things." & Chr(13) & "" & Chr(13) & "2. The ""-a = Abort Shutdown"" can be used to stop a shutdown or restart that has been started with some time. For example assume that you have started a shutdown with a time of 3600 seconds so that computer shuts down after 1 hour automatically. Then you can cancel this by using the abort program."

    Public Const String_Lesson02_Step02_Goal As String = "No Content Added Yet"
    Public Const String_Lesson02_Step02_Instructions As String = ""
    Public Const String_Lesson02_Step02_Code_To_Be_Copied As String = ""
    Public Const String_Lesson02_Step02_Details_Of_The_Code As String = ""
    Public Const String_Lesson02_Step02_Further_Technical_Details As String = ""

    Public Const String_Lesson02_Step03_Goal As String = "No Content Added Yet"
    Public Const String_Lesson02_Step03_Instructions As String = ""
    Public Const String_Lesson02_Step03_Code_To_Be_Copied As String = ""
    Public Const String_Lesson02_Step03_Details_Of_The_Code As String = ""
    Public Const String_Lesson02_Step03_Further_Technical_Details As String = ""

    Public Const String_Lesson02_Step04_Goal As String = "No Content Added Yet"
    Public Const String_Lesson02_Step04_Instructions As String = ""
    Public Const String_Lesson02_Step04_Code_To_Be_Copied As String = ""
    Public Const String_Lesson02_Step04_Details_Of_The_Code As String = ""
    Public Const String_Lesson02_Step04_Further_Technical_Details As String = ""

    Public Sub L2()
        ShowWhenClickOnLesson("002", String_Lesson02_Goal)
    End Sub

    Public Sub L2_S1()
        WhenClickOnStep("002", "001")
    End Sub

    Public Sub L2_S2()
        WhenClickOnStep("002", "002")
    End Sub

    Public Sub L2_S3()
        WhenClickOnStep("002", "003")
    End Sub

    Public Sub L2_S4()
        WhenClickOnStep("002", "004")
    End Sub

End Module
