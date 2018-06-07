Public Class Root
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Tool.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim zippush As New Process
            zippush.StartInfo.FileName = "adb.exe"
            zippush.StartInfo.Arguments = "push supersu.zip /sdcard/"
            zippush.StartInfo.UseShellExecute = False
            zippush.StartInfo.CreateNoWindow = True
            zippush.Start()
            zippush.WaitForExit()
            MsgBox("SuperSu.Zip sended to device" & vbNewLine& & vbNewLine& + "Install SuperSu.zip from twrp")
        End If

        If Tool.states = "2" Or Tool.states = "4" Then
            MsgBox("Device must be in recovery or normal mode")
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim zippush As New Process
            zippush.StartInfo.FileName = "adb.exe"
            zippush.StartInfo.Arguments = "push magisk.zip /sdcard/"
            zippush.StartInfo.UseShellExecute = False
            zippush.StartInfo.CreateNoWindow = True
            zippush.Start()
            zippush.WaitForExit()
            MsgBox("Magisk.Zip sended to device" & vbNewLine& & vbNewLine& + "Install Magisk.zip from twrp")
        End If

        If Tool.states = "2" Or Tool.states = "4" Then
            MsgBox("Device must be in recovery or normal mode")
        End If
    End Sub

    Private Sub Root_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox3.Select()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim zippush As New Process
            zippush.StartInfo.FileName = "adb.exe"
            zippush.StartInfo.Arguments = "push magisk.zip /sdcard/"
            zippush.StartInfo.UseShellExecute = False
            zippush.StartInfo.CreateNoWindow = True
            zippush.Start()
            zippush.WaitForExit()
            MsgBox("Magisk.Zip sended to device" & vbNewLine& & vbNewLine& + "Install Magisk.zip from twrp")
        End If

        If Tool.states = "2" Or Tool.states = "4" Then
            MsgBox("Device must be in recovery or normal mode")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tool.check()
        If Tool.states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If Tool.states = "1" Or Tool.states = "3" Then
            Dim zippush As New Process
            zippush.StartInfo.FileName = "adb.exe"
            zippush.StartInfo.Arguments = "push supersu.zip /sdcard/"
            zippush.StartInfo.UseShellExecute = False
            zippush.StartInfo.CreateNoWindow = True
            zippush.Start()
            zippush.WaitForExit()
            MsgBox("SuperSu.Zip sended to device" & vbNewLine& & vbNewLine& + "Install SuperSu.zip from twrp")
        End If

        If Tool.states = "2" Or Tool.states = "4" Then
            MsgBox("Device must be in recovery or normal mode")
        End If
    End Sub
End Class