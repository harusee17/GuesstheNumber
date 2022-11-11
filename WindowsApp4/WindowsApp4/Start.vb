Public Class Start
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Draggable Borderless Form'
    Private Sub Start_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Start_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Start_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    'Back Button'
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Close()
    End Sub
    'Minimize Button
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Exit Button'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    'Button Clicks (EASY-AVERAGE-DIFFICULT)'
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Game.Location = Me.Location
        Game.btn1clicked = True
        Game.Show()
        Me.Close()
    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        Game.Location = Me.Location
        Game.btn2clicked = True
        Game.Show()
        Me.Close()
    End Sub

    Private Sub btnDiff_Click(sender As Object, e As EventArgs) Handles btnDiff.Click
        Game.Location = Me.Location
        Game.btn3clicked = True
        Game.Show()
        Me.Close()
    End Sub

    'Mouse Hover Animation
    Private Sub btnEasy_MouseHover(sender As Object, e As EventArgs) Handles btnEasy.MouseHover
        labelEasy.Text = "(1-100, 5 trials)"
    End Sub

    Private Sub btnEasy_MouseLeave(sender As Object, e As EventArgs) Handles btnEasy.MouseLeave
        labelEasy.Text = ""
    End Sub

    Private Sub btnAvg_MouseHover(sender As Object, e As EventArgs) Handles btnAvg.MouseHover
        labelAvg.Text = "(1-300, 5 trials)"
    End Sub

    Private Sub btnAvg_MouseLeave(sender As Object, e As EventArgs) Handles btnAvg.MouseLeave
        labelAvg.Text = ""
    End Sub

    Private Sub btnDiff_MouseHover(sender As Object, e As EventArgs) Handles btnDiff.MouseHover
        labelDiff.Text = "(1-500, 5 trials)"
    End Sub

    Private Sub btnDiff_MouseLeave(sender As Object, e As EventArgs) Handles btnDiff.MouseLeave
        labelDiff.Text = ""
    End Sub
End Class