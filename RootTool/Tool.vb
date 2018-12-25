Public Class Tool
    Dim state As String
    Public states As Integer

    ' 0 not connected
    ' 1 device connected
    ' 2 device connected (fastboot)
    ' 3 device connected (recovery)
    ' 4 device connected (sideload)
    ' 5 device connected (unauthorised)
    ' 6 device connected (unknown)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Reboot.Show()
    End Sub

    Public Sub check()
        Dim check As New Process
        check.StartInfo.FileName = "adb.exe"
        check.StartInfo.Arguments = "get-state"
        check.StartInfo.UseShellExecute = False
        check.StartInfo.CreateNoWindow = True
        check.StartInfo.RedirectStandardOutput = True
        check.Start()
        state = check.StandardOutput.ReadToEnd
        check.WaitForExit()

        states = "0"

        If String.Compare(state, "device", StringComparison.InvariantCultureIgnoreCase) = 1 Then
            states = "1"
        End If

        If String.Compare(state, "recovery", StringComparison.InvariantCultureIgnoreCase) = 1 Then
            states = "3"
        End If

        If String.Compare(state, "sideload", StringComparison.InvariantCultureIgnoreCase) = 1 Then
            states = "4"
        End If

        If states = "0" Then
            Dim fcheck As New Process
            fcheck.StartInfo.FileName = "fastboot.exe"
            fcheck.StartInfo.Arguments = "devices"
            fcheck.StartInfo.UseShellExecute = False
            fcheck.StartInfo.CreateNoWindow = True
            fcheck.StartInfo.RedirectStandardOutput = True
            fcheck.Start()
            state = fcheck.StandardOutput.ReadToEnd
            fcheck.WaitForExit()

            If String.Compare(state, "fastboot", StringComparison.InvariantCultureIgnoreCase) = 1 Then
                states = "2"
            End If

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("drivers.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Root.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        check()
        If states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If states = "1" Or states = "3" Then
            Dim reboot As New Process
            reboot.StartInfo.FileName = "adb.exe"
            reboot.StartInfo.Arguments = "reboot bootloader"
            reboot.StartInfo.UseShellExecute = False
            reboot.StartInfo.CreateNoWindow = True
            reboot.Start()
            reboot.WaitForExit()
            Threading.Thread.Sleep(10000)
            check()
            If states = "0" Then
                MsgBox("Device Not Detected" & vbNewLine& & vbNewLine& + "Install Lenovo Drivers")
            End If
        End If

        If states = "2" Then
            Dim flashtwrp As New Process
            flashtwrp.StartInfo.FileName = "fastboot.exe"
            flashtwrp.StartInfo.Arguments = "flash recovery twrp.img"
            flashtwrp.StartInfo.UseShellExecute = False
            flashtwrp.StartInfo.CreateNoWindow = True
            flashtwrp.Start()
            flashtwrp.WaitForExit()

        End If

        If states = "2" Then
            Dim boottwrp As New Process
            boottwrp.StartInfo.FileName = "fastboot.exe"
            boottwrp.StartInfo.Arguments = "boot twrp.img"
            boottwrp.StartInfo.UseShellExecute = False
            boottwrp.StartInfo.CreateNoWindow = True
            boottwrp.Start()
            boottwrp.WaitForExit()
            MsgBox("TWRP 3.2.3.0 Flashed")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        check()
        If states = "0" Then
            MsgBox("Device Not Connected")
        End If

        If states = "1" Or states = "3" Then
            Dim reboot As New Process
            reboot.StartInfo.FileName = "adb.exe"
            reboot.StartInfo.Arguments = "reboot bootloader"
            reboot.StartInfo.UseShellExecute = False
            reboot.StartInfo.CreateNoWindow = True
            reboot.Start()
            reboot.WaitForExit()
            Threading.Thread.Sleep(10000)
            check()
            If states = "0" Then
                MsgBox("Device Not Detected" & vbNewLine& & vbNewLine& + "Install Lenovo Drivers")
            End If
        End If

        If states = "2" Then
            Dim flashtwrp As New Process
            flashtwrp.StartInfo.FileName = "fastboot.exe"
            flashtwrp.StartInfo.Arguments = "oem unlock"
            flashtwrp.StartInfo.UseShellExecute = False
            flashtwrp.StartInfo.CreateNoWindow = True
            flashtwrp.Start()
            flashtwrp.WaitForExit()
            MsgBox("OEM (Bootloder) Unlocked")

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Stock.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.youtube.com/channel/UCyq7mspndOnlqR41axhhT8A")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://t.me/VarunSaiTeja")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("http://tiny.cc/varunpaytm")
    End Sub

    Private Sub Tool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Select()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.paypal.me/varunsaiteja")
    End Sub
End Class