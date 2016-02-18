Public Class MSAgent
    Private mSpk As AgentObjects.IAgentCtlCharacter
    Private lastAnimationState As AgentObjects.IAgentCtlRequest

    Public Sub Load(ByVal AxAgent1 As AxAgentObjects.AxAgent, ByVal caractere As String, ByVal path As String)
        AxAgent1.Characters.Load(caractere, path)

        mSpk = AxAgent1.Characters(caractere)

        mSpk.Balloon.Style = &H232000B
        mSpk.Balloon.FontName = "Rockwell Condensed"
        mSpk.Balloon.FontSize = 14

        mSpk.TTSModeID = "{0879A4E1-A92C-11D1-B17B-0020AFED142E}"
        mSpk.Width = 256
        mSpk.Height = 256
    End Sub

    Public Sub Show()
        mSpk.Show(0)
    End Sub

    Public Sub StopIt()
        mSpk.Stop()
    End Sub

    Public Sub Hide()
        mSpk.Play("Hide")
        mSpk.Hide()
    End Sub

    Public Sub Wait()
        While lastAnimationState.Status <> 4
            Application.DoEvents()
        End While
    End Sub

    Public Sub Animate(ByVal move As String)
        'Stop the previous action to start new one
        'mSpk.Stop()

        'Play the new action
        lastAnimationState = mSpk.Play(move)

        'Turn to rest position
        'mSpk.Play("RestPose")
    End Sub

    Public Sub Talk(ByVal text As String)
        'Stop the previous action to start new one
        'mSpk.Stop()
        'Speak the text
        lastAnimationState = mSpk.Speak("\Pit=60\\Spd=150\" + text)
    End Sub

    Public Sub TalkFast(ByVal text As String)
        lastAnimationState = mSpk.Speak("\Pit=60\\Spd=225\" + text)
    End Sub

    Public Sub MoveTo(ByVal x As Short, ByVal y As Short)
        'Stop the previous action to start new one
        mSpk.Stop()
        'Let the character to move to the position of current mouse pointer
        mSpk.MoveTo(x, y)
    End Sub

End Class
