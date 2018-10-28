Imports AIMLbot


Public Class Form1

    Dim mybot As New Bot
    Dim myuser As New User("CurrentUser", mybot)


    Public Function GetReply(ByVal ques As String)

        Dim req As New Request(ques, myuser, mybot)
        Dim res As New Result(myuser, mybot, req)
        res = mybot.Chat(req)

        Return res.Output

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim q As String = InputTxt.Text

        OutputTxt.AppendText("You > " & q & vbCrLf)
        OutputTxt.AppendText("Bot > " & GetReply(q) & vbCrLf)

        InputTxt.Clear()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            mybot.isAcceptingUserInput = False
            mybot.loadSettings()
            mybot.loadAIMLFromFiles()
            mybot.isAcceptingUserInput = True


        Catch ex As Exception

            MsgBox("Error : Can't Load AIML Scripts")

        End Try

    End Sub

End Class
