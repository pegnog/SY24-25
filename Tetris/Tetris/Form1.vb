Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If GrimReaper.Location.Y > Biden.Location.Y Then
            move(GrimReaper, 0, -5)
        Else
            move(GrimReaper, 0, 5)
        End If
        If GrimReaper.Location.X > Biden.Location.X Then
            move(GrimReaper, -5, 0)
        Else
            move(GrimReaper, 5, 0)
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Biden, -5, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Biden, 5, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Biden, 0, 15)
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.E Then
            Biden.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            move(Biden, 0, -5)
        End If
        Biden.Refresh()
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If p.Bounds.IntersectsWith(Icecream.Bounds) Then
            Icecream.Visible = False
        End If
    End Sub

End Class
