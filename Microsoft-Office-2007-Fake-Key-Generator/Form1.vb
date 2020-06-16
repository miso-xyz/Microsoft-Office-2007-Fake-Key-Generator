Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rng As New Random
        Dim keys As New List(Of String)({"VM98J-C9X4C-MM7YX-93G64-BJMK3", "WM6RD-JWXJ8-MP2CM-29X2X-VX9QQ", "MP8MB-R8D3D-XPMPY-X727Q-X62HD", "JD76P-XB7GK-47XGG-RQ3KD-HM63Q", "H8MMM-YQ6QH-26KBQ-9YMCC-RVBK3", "FQ8QY-KDQGT-JH4H6-37KRX-CR9QQ", "BMMQ8-WX4BC-4PGWR-T7BYM-6CQ93", "F39GW-RPPRC-F37XD-FX2F6-MWXQQ", "QVYCB-TRPCY-C4HMR-63WVY-7CF7D", "FDMDG-239W6-CXPGD-2R496-Y99QQ", "DBXYD-TF477-46YM4-W74MH-6YDQ8"})
        TextBox1.Text = keys(rng.Next(0, 10))
    End Sub
End Class
