Public Class WinTools
    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        MsgBox("反馈：2457431994@qq.com")

    End Sub

    Private Sub clear()
        Me.Controls.Remove(Me.HardDrivesList)
        Me.Controls.Remove(Me.RecDrivesButton)
        Me.Controls.Remove(Me.HideDriveButton)
        Me.Controls.Remove(Me.RecArrow)
        Me.Controls.Remove(Me.HideArrow)
        Me.Controls.Remove(Me.CancelAll)
        Me.Controls.Remove(Me.Shutdown)
        Me.Controls.Remove(Me.Reboot)
        Me.Controls.Remove(Me.Label1)
        Me.Controls.Remove(Me.InputTime)
    End Sub

    Private Sub 隐藏盘符ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 隐藏盘符ToolStripMenuItem.Click
        clear()
        Me.Controls.Add(Me.RecDrivesButton)
        Me.Controls.Add(Me.HideDriveButton)
        Me.Controls.Add(Me.HardDrivesList)
    End Sub


    Private Sub WinTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '读取当前系统的盘符写入列表中
        Dim numOfDrives As Integer
        numOfDrives = My.Computer.FileSystem.Drives.Count
        Dim temp As String
        Dim i As Integer
        i = 0
        Do While i < numOfDrives
            temp = My.Computer.FileSystem.Drives.Item(i).ToString
            Me.HardDrivesList.Items.Add(temp)
            i = i + 1
        Loop
    End Sub

    Private Sub 美化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 美化ToolStripMenuItem.Click
        clear()
        Me.Controls.Add(Me.RecArrow)
        Me.Controls.Add(Me.HideArrow)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles HideDriveButton.Click
        Dim numOfChecked As Integer
        Dim i As Integer
        Dim j As Integer
        Dim drivesum As Integer
        Dim temp As Char
        numOfChecked = HardDrivesList.CheckedItems.Count
        'drivesum 的计算方式
        Do While i < numOfChecked
            temp = HardDrivesList.CheckedItems.Item(i)
            j = Asc(temp) - Asc("A")
            drivesum = drivesum + 2 ^ j
            i = i + 1
        Loop
        Shell("cmd /c reg add HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v Nodrives /t REG_DWORD /d " & drivesum & " /f")
        Shell("cmd /c taskkill /f /im explorer.exe")
        System.Threading.Thread.Sleep(1000)
        Shell("C:\Windows\explorer.exe")
    End Sub

    Private Sub RecDrivesButton_Click(sender As Object, e As EventArgs) Handles RecDrivesButton.Click
        Shell("cmd /c reg delete HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v Nodrives /f"）
        Shell("cmd /c taskkill /f /im explorer.exe")
        System.Threading.Thread.Sleep(1000)
        Shell("C:\Windows\explorer.exe")
    End Sub

    Private Sub HideArrow_Click(sender As Object, e As EventArgs) Handles HideArrow.Click
        Shell("reg delete HKEY_CLASSES_ROOT\lnkfile /v IsShortcut /f")
        Shell("reg delete HKEY_CLASSES_ROOT\piffile /v IsShortcut /f")
        Shell("cmd /c taskkill /f /im explorer.exe")
        System.Threading.Thread.Sleep(1000)
        Shell("C:\Windows\explorer.exe")
    End Sub

    Private Sub RecArrow_Click(sender As Object, e As EventArgs) Handles RecArrow.Click
        Shell("reg add HKEY_CLASSES_ROOT\lnkfile /v IsShortcut /f")
        Shell("reg add HKEY_CLASSES_ROOT\piffile /v IsShortcut /f")
        Shell("cmd /c taskkill /f /im explorer.exe")
        System.Threading.Thread.Sleep(1000)
        Shell("C:\Windows\explorer.exe")
    End Sub

    Private Sub Reboot_Click(sender As Object, e As EventArgs) Handles Reboot.Click
        Dim time As Integer
        Dim temp As Integer

        If InputTime.Text = "" Then
            temp = MsgBox("马上重启吗", vbOKCancel, "提示")
            If temp = 1 Then
                Shell("shutdown /r /t 0")
            End If
        Else
            time = Val(InputTime.Text) * 60
            Shell("shutdown /r /t " & time)
            MsgBox(time / 60 & "分钟后重启", vbOKOnly, "提示")
        End If
    End Sub

    Private Sub Shutdown_Click(sender As Object, e As EventArgs) Handles Shutdown.Click
        Dim time As Integer
        Dim temp As Integer
        If InputTime.Text = "" Then
            temp = MsgBox("马上关机吗", vbOKCancel, "提示")
            If temp = 1 Then
                Shell("shutdown /s /t 0")
            End If
        Else
            time = Val(InputTime.Text) * 60
            Shell("shutdown /s /t " & time)
            MsgBox(time / 60 & "分钟后关机", vbOKOnly, "提示")
        End If

    End Sub

    Private Sub CancelAll_Click(sender As Object, e As EventArgs) Handles CancelAll.Click
        Shell("shutdown /a")
        MsgBox("已取消所有计划", vbOKOnly, "提示")
    End Sub

    Private Sub 定时关机ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 定时关机ToolStripMenuItem.Click
        clear()
        Me.Controls.Add(Me.CancelAll)
        Me.Controls.Add(Me.Shutdown)
        Me.Controls.Add(Me.Reboot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputTime)
    End Sub
End Class