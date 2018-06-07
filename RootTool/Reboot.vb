Public Class Reboot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim reboot As New Process
            reboot.StartInfo.FileName = "adb.exe"
            reboot.StartInfo.Arguments = "reboot"
            reboot.StartInfo.UseShellExecute = False
            reboot.StartInfo.CreateNoWindow = True
            reboot.Start()
            reboot.WaitForExit()
            MsgBox("Device Rebooted")
        End If

        If Tool.states = "2" Then
            Dim reboot As New Process
            reboot.StartInfo.FileName = "fastboot.exe"
            reboot.StartInfo.Arguments = "reboot"
            reboot.StartInfo.UseShellExecute = False
            reboot.StartInfo.CreateNoWindow = True
            reboot.Start()
            reboot.WaitForExit()
            MsgBox("Device Rebooted")
        End If

        If Tool.states = "4" Then
            MsgBox("Can't Reboot, Exit sideload mode")
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Close()

        Tool.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim reboot As New Process
            reboot.StartInfo.FileName = "adb.exe"
            reboot.StartInfo.Arguments = "reboot recovery"
            reboot.StartInfo.UseShellExecute = False
            reboot.StartInfo.CreateNoWindow = True
            reboot.Start()
            reboot.WaitForExit()
            MsgBox("Device Rebooted to Recovery")
        End If

        If Tool.states = "2" Then
            MsgBox("     Device in fastboot mode" & vbNewLine& + "Can't reboot to recovery mode directly")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim reboot As New Process
            reboot.StartInfo.FileName = "adb.exe"
            reboot.StartInfo.Arguments = "reboot bootloader"
            reboot.StartInfo.UseShellExecute = False
            reboot.StartInfo.CreateNoWindow = True
            reboot.Start()
            reboot.WaitForExit()
            MsgBox("Device Rebooted to Bootloader")
        End If

        If Tool.states = "2" Then
            MsgBox("Device already in fastboot mode")
        End If

    End Sub

    Private Sub Reboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Select()

    End Sub
End Class