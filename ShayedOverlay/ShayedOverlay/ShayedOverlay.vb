Public Class frmShayed

    Dim Monitor As Integer
    Dim Pixel As String
    Private Sub frmShayed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
        Monitor = My.Settings.Monitor
        Pixel = My.Settings.Pixel
        txtPixel.Text = Pixel
    End Sub
    Private Sub frmShayed_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Monitor = Monitor
        My.Settings.Pixel = Pixel
    End Sub
    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        'Checking 1 pixel for Reticle
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(Monitor, 540), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticle.BackColor = c
        txtReticle.Text = picReticle.BackColor.Name

        If txtReticle.Text = Pixel Then
            If txtOnOff.Text = "Off" Then
                'send on
                SendKeys.Send("^{F5}") ' //  Hotkey to make Overlay visiable
                txtOnOff.Text = "On"
                'System.Threading.Thread.Sleep(1000)
            End If
        Else
            If txtOnOff.Text = "On" Then
                'send off
                SendKeys.Send("%{F5}") ' //  Hotkey to make Overlay invisiable
                txtOnOff.Text = "Off"
            End If
        End If
    End Sub

    Private Sub cmdLeft_Click(sender As Object, e As EventArgs) Handles cmdLeft.Click
        Monitor = 960
    End Sub
    Private Sub cmdRight_Click(sender As Object, e As EventArgs) Handles cmdRight.Click
        Monitor = 2880

    End Sub
    Private Sub txtPixel_TextChanged(sender As Object, e As EventArgs) Handles txtPixel.TextChanged
        Pixel = txtPixel.Text
    End Sub
End Class
