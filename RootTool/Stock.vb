Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            Threading.Thread.Sleep(10000)
            Tool.check()
            If Tool.states = "0" Then
                MsgBox("Device Not Detected" & vbNewLine& & vbNewLine& + "Install Lenovo Drivers")
            End If
        End If

        If Tool.states = "2" Then
            Dim stockboot As New Process
            stockboot.StartInfo.FileName = "fastboot.exe"
            stockboot.StartInfo.Arguments = "flash boot boot.img"
            stockboot.StartInfo.UseShellExecute = False
            stockboot.StartInfo.CreateNoWindow = True
            stockboot.Start()
            stockboot.WaitForExit()
            MsgBox("Stock Boot Image Flashed")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
            Threading.Thread.Sleep(10000)
            Tool.check()
            If Tool.states = "0" Then
                MsgBox("Device Not Detected" & vbNewLine& & vbNewLine& + "Install Lenovo Drivers")
            End If
        End If

        If Tool.states = "2" Then
            Dim stockrec As New Process
            stockrec.StartInfo.FileName = "fastboot.exe"
            stockrec.StartInfo.Arguments = "flash recovery recovery.img"
            stockrec.StartInfo.UseShellExecute = False
            stockrec.StartInfo.CreateNoWindow = True
            stockrec.Start()
            stockrec.WaitForExit()
        End If

        If Tool.states = "2" Then
            Dim bootstockrec As New Process
            bootstockrec.StartInfo.FileName = "fastboot.exe"
            bootstockrec.StartInfo.Arguments = "boot recovery.img"
            bootstockrec.StartInfo.UseShellExecute = False
            bootstockrec.StartInfo.CreateNoWindow = True
            bootstockrec.Start()
            bootstockrec.WaitForExit()
            MsgBox("Stock Recovery Image Flashed")
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Tool.Show()

    End Sub
End Class