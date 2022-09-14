Module mod_Sonidos

    Sub Sonido_OK()

        My.Computer.Audio.Play(Application.StartupPath & "\OK.wav", AudioPlayMode.WaitToComplete)

    End Sub

    Sub Sonido_KO()

        My.Computer.Audio.Play(Application.StartupPath & "\KO.wav", AudioPlayMode.WaitToComplete)

    End Sub
End Module
