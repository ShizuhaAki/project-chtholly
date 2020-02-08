'    project-chtholly, a tool for randomly selecting students in Chinese classes
'    Copyright(C) 2020 Ravenclaw_OIer

'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.

'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.

'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see < https: //www.gnu.org/licenses/>.

Public Class Form1
    Const N As Integer = 200
    Dim vis As New HashSet(Of Integer)
    Dim used As New ArrayList
    Dim total As Integer
    Public Shared hasclosed As Boolean
    Dim Randomizer As New Random
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim id, res As Integer
        If (vis.Count() = 0) Then
            Dim reply = MessageBox.Show("已经全部抽取过一遍。" + vbCrLf + "您想要继续吗？", "学号抽取", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If reply = DialogResult.Yes Then
                Init()
            Else
                Close()
            End If
        End If
        id = Randomizer.Next(0, vis.Count())
        res = vis.ElementAt(id)
        vis.Remove(res)
        used.Add(res)
        Label5.Text = res
        Label2.Text = (Val(Label2.Text) + 1).ToString
    End Sub
    Private Sub Init()
        For i As Integer = 1 To total
            vis.Add(i)
        Next
        used.Clear() : Button5.Enabled = True
    End Sub
    Private Sub 新建ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新建ToolStripMenuItem.Click
        Try
            vis.Clear() : used.Clear()
            Label2.Text = "0" : Label5.Text = "0"
            Dim userin As String = InputBox("请输入学生数量", "学号抽取", "32")
            Dim value As Integer = Val(userin)
            If (value <= 0) Then
                Dim throwe As New InvalidInputException
                Throw throwe
            End If
            total = value
            Init()
        Catch exDiv As InvalidInputException
            MessageBox.Show("学生数量应该是正整数", "学号抽取")
            Button5.Enabled = False
        Catch ex As Exception
            MessageBox.Show("出现错误，请重新输入", "学号抽取")
            Button5.Enabled = False
        End Try
    End Sub



    Private Sub 打开OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开OToolStripMenuItem.Click
        Try
            Dim reader = My.Computer.FileSystem.OpenTextFileReader("log.chtholly")
            total = Val(reader.ReadLine())
            Init()
            Dim usedCount = Val(reader.ReadLine())
            Label2.Text = usedCount.ToString()
            For i As Integer = 1 To usedCount
                Dim usedNext = Val(reader.ReadLine())
                vis.RemoveWhere(Function(num As Integer) As Boolean
                                    Return num = usedNext
                                End Function)
                used.Add(usedNext)
            Next
            reader.Close()
        Catch exFile As IO.IOException
            MessageBox.Show("读取文件时出现错误", "学号抽取")
            MessageBox.Show(exFile.Message)
        Catch ex As Exception
            MessageBox.Show("出现错误。文件可能已经损坏", "学号抽取")
        End Try
    End Sub

    Private Sub SaveLog()
        Try
            Dim writer = My.Computer.FileSystem.OpenTextFileWriter("log.chtholly", False)
            writer.WriteLine(total)
            writer.WriteLine(used.Count)
            For i = 1 To used.Count
                writer.WriteLine(used.Item(i - 1))
            Next
            writer.Close()
        Catch exFile As IO.IOException
            MessageBox.Show("写入文件时出现错误", "学号抽取")
        Catch ex As Exception
            MessageBox.Show("出现错误。文件可能已经损坏。", "学号抽取")
        End Try
    End Sub
    Private Sub 另存为AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为AToolStripMenuItem.Click
        '   SaveFileDialog1.ShowDialog()
        '  Dim reply = SaveFileDialog1.FileName
        SaveLog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initiallize Timer
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (自动保存ToolStripMenuItem.Checked = True) Then
            SaveLog()
        End If
    End Sub
End Class
Public Class InvalidInputException
    Inherits System.Exception

    Private ReadOnly _Message As String = "错误的格式"

    Public Overrides ReadOnly Property Message As String
        Get
            Return _Message
        End Get
    End Property
End Class