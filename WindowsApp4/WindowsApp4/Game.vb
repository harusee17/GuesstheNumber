Public Class Game
    Public btn1clicked As Boolean = False
    Public btn2clicked As Boolean = False
    Public btn3clicked As Boolean = False
    Dim num As Double
    Dim ctr As Integer
    Dim limit As Integer
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Draggable Borderless Form'
    Private Sub Game_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Game_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Game_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        ctr = 5
        If btn1clicked = True Then
            num = Int(Rnd() * 100) + 1
            limit = 100
            Label1.Text = "EASY"
            Label2.Text = "Enter a number between 1 to 100:"
            Label3.Text = "No. of trials left: " & ctr
        ElseIf btn2clicked = True Then
            num = Int(Rnd() * 300) + 1
            limit = 300
            Label1.Text = "AVERAGE"
            Label2.Text = "Enter a number between 1 to 300:"
            Label3.Text = "No. of trials left: " & ctr
        ElseIf btn3clicked = True Then
            num = Int(Rnd() * 500) + 1
            limit = 500
            Label1.Text = "DIFFICULT"
            Label2.Text = "Enter a number between 1 to 500:"
            Label3.Text = "No. of trials left: " & ctr
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If Val(inputNo.Text) > limit Or Val(inputNo.Text) = 0 Then
            MessageBox.Show("You have entered an invalid number.", "ERROR", MessageBoxButtons.OK)

        Else
            ListBox1.Items.Add(Val(inputNo.Text))
            ctr = ctr - 1
            Label3.Text = "No of trials left: " & ctr

            Select Case Val(inputNo.Text)
                Case Is > num
                    Label5.Text = "LOWER"
                Case Is < num
                    Label5.Text = "HIGHER"
                Case num
                    Label5.Text = "CONGRATULATIONS!"
                    inputNo.Enabled = False
                    btnEnter.Visible = False
            End Select

            If ctr = 0 And Val(inputNo.Text) <> num Then
                Label5.Text = "YOU FAILED! THE NUMBER IS " & num
                inputNo.Enabled = False
                btnEnter.Visible = False

            End If
        End If
        inputNo.Text = ""

    End Sub

    Private Sub inputNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputNo.KeyPress
        If e.KeyChar <> ControlChars.Back And e.KeyChar <> Chr(13) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If

        If inputNo.Enabled = True And e.KeyChar = Chr(13) Then
            btnEnter_Click(Me, EventArgs.Empty)
        End If
    End Sub

    'Home Button'
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Location = Me.Location
        Form1.Show()
        Me.Close()
    End Sub

    'Retry Button'
    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Game_Load(Me, EventArgs.Empty)
        ListBox1.Items.Clear()
        Label5.Text = "GUESS THE NUMBER!"
        inputNo.Enabled = True
        btnEnter.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Start.Location = Me.Location
        Start.Show()
        Me.Close()
    End Sub
End Class