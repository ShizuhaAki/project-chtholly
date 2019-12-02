'    project-chtholly, a tool for randomly selecting students in Chinese classes
'    Copyright(C) 2019 Ravenclaw_OIer

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
    Dim Randomizer As New Random
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim id, res As Integer
        If (vis.Count() = 0) Then
            Dim reply = MessageBox.Show("已经全部抽取过一遍。" + vbCrLf + "您想要继续吗？", "学号抽取", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If reply = DialogResult.Yes Then
                init()
            Else
                Close()
            End If
        End If
        id = Randomizer.Next(0, vis.Count())
        res = vis.ElementAt(id)
        vis.Remove(res)
        Label5.Text = res
        Label2.Text = (Val(Label2.Text) + 1).ToString
    End Sub
    Private Sub init()
        For i As Integer = 1 To NumericUpDown2.Value
            vis.Add(i)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NumericUpDown2.Value = 0 Then
            NumericUpDown2.Value = 1
        End If
        init()
        NumericUpDown2.Enabled = False
        Button5.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutBox1.Show()
    End Sub
End Class