<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinTools
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.系统ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.隐藏盘符ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.定时关机ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.美化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardDrivesList = New System.Windows.Forms.CheckedListBox()
        Me.HideDriveButton = New System.Windows.Forms.Button()
        Me.RecDrivesButton = New System.Windows.Forms.Button()
        Me.HideArrow = New System.Windows.Forms.Button()
        Me.RecArrow = New System.Windows.Forms.Button()
        Me.InputTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reboot = New System.Windows.Forms.Button()
        Me.Shutdown = New System.Windows.Forms.Button()
        Me.CancelAll = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.系统ToolStripMenuItem, Me.美化ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(364, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '系统ToolStripMenuItem
        '
        Me.系统ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.隐藏盘符ToolStripMenuItem, Me.定时关机ToolStripMenuItem})
        Me.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem"
        Me.系统ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.系统ToolStripMenuItem.Text = "系统"
        '
        '隐藏盘符ToolStripMenuItem
        '
        Me.隐藏盘符ToolStripMenuItem.Name = "隐藏盘符ToolStripMenuItem"
        Me.隐藏盘符ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.隐藏盘符ToolStripMenuItem.Text = "隐藏盘符"
        '
        '定时关机ToolStripMenuItem
        '
        Me.定时关机ToolStripMenuItem.Name = "定时关机ToolStripMenuItem"
        Me.定时关机ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.定时关机ToolStripMenuItem.Text = "定时关机"
        '
        '美化ToolStripMenuItem
        '
        Me.美化ToolStripMenuItem.Name = "美化ToolStripMenuItem"
        Me.美化ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.美化ToolStripMenuItem.Text = "美化"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'HardDrivesList
        '
        Me.HardDrivesList.BackColor = System.Drawing.SystemColors.MenuBar
        Me.HardDrivesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HardDrivesList.FormattingEnabled = True
        Me.HardDrivesList.Location = New System.Drawing.Point(55, 96)
        Me.HardDrivesList.Name = "HardDrivesList"
        Me.HardDrivesList.Size = New System.Drawing.Size(121, 146)
        Me.HardDrivesList.TabIndex = 2
        '
        'HideDriveButton
        '
        Me.HideDriveButton.Location = New System.Drawing.Point(236, 122)
        Me.HideDriveButton.Name = "HideDriveButton"
        Me.HideDriveButton.Size = New System.Drawing.Size(75, 23)
        Me.HideDriveButton.TabIndex = 3
        Me.HideDriveButton.Text = "隐藏盘符"
        Me.HideDriveButton.UseVisualStyleBackColor = True
        '
        'RecDrivesButton
        '
        Me.RecDrivesButton.Location = New System.Drawing.Point(236, 185)
        Me.RecDrivesButton.Name = "RecDrivesButton"
        Me.RecDrivesButton.Size = New System.Drawing.Size(75, 23)
        Me.RecDrivesButton.TabIndex = 4
        Me.RecDrivesButton.Text = "恢复盘符"
        Me.RecDrivesButton.UseVisualStyleBackColor = True
        '
        'HideArrow
        '
        Me.HideArrow.Location = New System.Drawing.Point(13, 84)
        Me.HideArrow.Name = "HideArrow"
        Me.HideArrow.Size = New System.Drawing.Size(129, 26)
        Me.HideArrow.TabIndex = 1
        Me.HideArrow.Text = "隐藏快捷方式小箭头"
        Me.HideArrow.UseVisualStyleBackColor = True
        '
        'RecArrow
        '
        Me.RecArrow.Location = New System.Drawing.Point(13, 137)
        Me.RecArrow.Name = "RecArrow"
        Me.RecArrow.Size = New System.Drawing.Size(129, 23)
        Me.RecArrow.TabIndex = 2
        Me.RecArrow.Text = "恢复快捷方式小箭头"
        Me.RecArrow.UseVisualStyleBackColor = True
        '
        'InputTime
        '
        Me.InputTime.Location = New System.Drawing.Point(81, 133)
        Me.InputTime.Name = "InputTime"
        Me.InputTime.Size = New System.Drawing.Size(65, 21)
        Me.InputTime.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "分后"
        '
        'Reboot
        '
        Me.Reboot.Location = New System.Drawing.Point(190, 132)
        Me.Reboot.Name = "Reboot"
        Me.Reboot.Size = New System.Drawing.Size(40, 23)
        Me.Reboot.TabIndex = 3
        Me.Reboot.Text = "重启"
        Me.Reboot.UseVisualStyleBackColor = True
        '
        'Shutdown
        '
        Me.Shutdown.Location = New System.Drawing.Point(236, 132)
        Me.Shutdown.Name = "Shutdown"
        Me.Shutdown.Size = New System.Drawing.Size(43, 23)
        Me.Shutdown.TabIndex = 4
        Me.Shutdown.Text = "关机"
        Me.Shutdown.UseVisualStyleBackColor = True
        '
        'CancelAll
        '
        Me.CancelAll.Location = New System.Drawing.Point(144, 171)
        Me.CancelAll.Name = "CancelAll"
        Me.CancelAll.Size = New System.Drawing.Size(56, 23)
        Me.CancelAll.TabIndex = 5
        Me.CancelAll.Text = "重置"
        Me.CancelAll.UseVisualStyleBackColor = True
        '
        'WinTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 346)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WinTools"
        Me.Text = "WinTools"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 系统ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 隐藏盘符ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 美化ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardDrivesList As CheckedListBox
    Friend WithEvents HideDriveButton As Button
    Friend WithEvents RecDrivesButton As Button
    Friend WithEvents HideArrow As Button
    Friend WithEvents RecArrow As Button
    Friend WithEvents 定时关机ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Reboot As Button
    Friend WithEvents Shutdown As Button
    Friend WithEvents CancelAll As Button
End Class
