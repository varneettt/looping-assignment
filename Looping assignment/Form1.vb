Imports System.Reflection

Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim formsurface As Graphics = CreateGraphics()
        formsurface.Clear(BackColor)
        For y = 0 To 490 Step 10
            formsurface.DrawLine(Pens.Green, 0, 0, 940, y)
        Next

        For y = 0 To 460 Step 10
            formsurface.DrawLine(Pens.Blue, 900, 0, 0, y)
        Next

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim g As Graphics = CreateGraphics()
        g.Clear(BackColor)
        For x = 0 To 600 Step 10
            g.DrawLine(Pens.Red, 300, 0, x, 250)
        Next

        For x = 0 To 600 Step 10
            g.DrawLine(Pens.Red, 300, 500, x, 250)
        Next

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim g As Graphics = CreateGraphics()
        Dim y, x As Integer
        g.Clear(BackColor)
        Do While y <= 900

            g.DrawLine(Pens.DarkOrchid, 0, y, 900, y)
            y = y + 20
        Loop

        Do While x <= 900

            g.DrawLine(Pens.DarkOrchid, x, 0, x, 900)
            x = x + 20
        Loop

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim g As Graphics = CreateGraphics()

        Dim x, width, height As Integer
        g.Clear(BackColor)
        For x = 0 To 560 Step 15
            width = x
            height = x

            g.DrawEllipse(Pens.DarkViolet, 0, 0, width, height)

        Next



        'Dim x, y As Integer

        'For x = 0 To 100 Step 20
        '    For y = 0 To 100 Step 20
        '        g.DrawEllipse(Pens.DarkViolet, 0, 0, 100 - x, 100 - y)

        '    Next

        'Next




    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim g As Graphics = CreateGraphics()
        Dim x, y As Integer
        g.Clear(BackColor)
        Do While x <= 800
            g.DrawEllipse(Pens.DarkTurquoise, x, 0, 200, 200)
            x = x + 100
        Loop

        Do While y <= 800
            g.DrawEllipse(Pens.DarkTurquoise, y, 400, 200, 200)
            y = y + 100
        Loop
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim g As Graphics = CreateGraphics()
        g.Clear(BackColor)
    End Sub

    Private Sub GridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridToolStripMenuItem.Click
        Dim g As Graphics = CreateGraphics()

        Dim x, width, height As Integer

        For x = 0 To 560 Step 15
            width = x
            height = x

            g.DrawEllipse(Pens.DarkViolet, 0, 0, width, height)

        Next
    End Sub

    Private Sub LinesOvlpdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinesOvlpdToolStripMenuItem.Click

        Dim formsurface As Graphics = CreateGraphics()

        For y = 0 To 490 Step 10
            formsurface.DrawLine(Pens.Green, 0, 0, 940, y)
        Next

        For y = 0 To 460 Step 10
            formsurface.DrawLine(Pens.Blue, 900, 0, 0, y)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub




    'g.DrawLine(Pens.Purple, 0, 0, 20, 500)
    'g.DrawLine(Pens.Purple, 0, 20, 40, 500)
    'g.DrawLine(Pens.Purple, 0, 40, 60, 500)
    'g.DrawLine(Pens.Purple, 0, 60, 80, 500)
    'g.DrawLine(Pens.Purple, 0, 80, 100, 500)
    'g.DrawLine(Pens.Purple, 0, 100, 120, 500)
    'g.DrawLine(Pens.Purple, 0, 120, 140, 500)

    'Do While x <= 880
    'Do While y <= 480
    '            g.DrawLine(Pens.Purple, 0, y, x, 500)
    '            x = x + 20
    '            y = y + 20
    '        Loop
    '    Loop
    'End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim g As Graphics = CreateGraphics()
        Dim x, y, x1, y2 As Integer
        Dim rand As New Random()
        'For x1 = -15 To 900 Step 50
        '    g.DrawRectangle(Pens.Purple, x * 500, -15, 30, 30)

        For x = 10 To 900 Step 50
            For y = 10 To 500 Step 50
                g.DrawRectangle(Pens.Purple, x, y, 30, 30)
            Next

        Next

        'For x1 = 20 To 900 Step 50
        '    g.Clear(BackColor)
        For x = -15 To 900 Step 50
                For y = -15 To 500 Step 50
                    Dim r As Integer = rand.Next(0, 256)
                    Dim gr As Integer = rand.Next(0, 256)
                    Dim b As Integer = rand.Next(0, 256)
                    Dim brush As New Pen(Color.FromArgb(r, gr, b))
                    g.DrawRectangle(brush, x, y, 30, 30)
                Next
            Next



    End Sub
End Class