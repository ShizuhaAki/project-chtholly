<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu Light", 50.0!)
        Me.Label5.Location = New System.Drawing.Point(105, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 77)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "0"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(82, 140)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 31)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "开始"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "已抽取"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.关于AToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建ToolStripMenuItem, Me.打开OToolStripMenuItem, Me.另存为AToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.文件ToolStripMenuItem.Text = "文件(&F)"
        '
        '新建ToolStripMenuItem
        '
        Me.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem"
        Me.新建ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.新建ToolStripMenuItem.Text = "新建(&N)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        '另存为AToolStripMenuItem
        '
        Me.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem"
        Me.另存为AToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.另存为AToolStripMenuItem.Text = "保存(&S)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.关于AToolStripMenuItem.Text = "关于(&A)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button5
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 231)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "学号抽取"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新建ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 另存为AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
