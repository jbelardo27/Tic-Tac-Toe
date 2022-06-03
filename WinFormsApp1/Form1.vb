Public Class Form1
    Dim checkforXorO As Boolean = False
    Dim AddOneToScore As Byte = 0

    Sub buttonsEnabledFalse()
        space1.Enabled = False
        space2.Enabled = False
        space3.Enabled = False
        space4.Enabled = False
        space5.Enabled = False
        space6.Enabled = False
        space7.Enabled = False
        space8.Enabled = False
        space9.Enabled = False

    End Sub

    Sub checkForWin()
        'X win conditions
        If space1.Text = "X" And space2.Text = "X" And space3.Text = "X" Then
            space1.BackColor = Color.Black
            space2.BackColor = Color.Black
            space3.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space4.Text = "X" And space5.Text = "X" And space6.Text = "X" Then
            space4.BackColor = Color.Black
            space5.BackColor = Color.Black
            space6.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space7.Text = "X" And space8.Text = "X" And space9.Text = "X" Then
            space7.BackColor = Color.Black
            space8.BackColor = Color.Black
            space9.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space1.Text = "X" And space4.Text = "X" And space7.Text = "X" Then
            space1.BackColor = Color.Black
            space4.BackColor = Color.Black
            space7.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space2.Text = "X" And space5.Text = "X" And space8.Text = "X" Then
            space2.BackColor = Color.Black
            space5.BackColor = Color.Black
            space8.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space3.Text = "X" And space6.Text = "X" And space9.Text = "X" Then
            space3.BackColor = Color.Black
            space6.BackColor = Color.Black
            space9.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space1.Text = "X" And space5.Text = "X" And space9.Text = "X" Then
            space1.BackColor = Color.Black
            space5.BackColor = Color.Black
            space9.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space3.Text = "X" And space5.Text = "X" And space7.Text = "X" Then
            space3.BackColor = Color.Black
            space5.BackColor = Color.Black
            space7.BackColor = Color.Black
            MessageBox.Show("PLAYER X WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(xscore.Text)
            xscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        'O win conditions
        If space1.Text = "O" And space2.Text = "O" And space3.Text = "O" Then
            space1.BackColor = Color.Black
            space2.BackColor = Color.Black
            space3.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space4.Text = "O" And space5.Text = "O" And space6.Text = "O" Then
            space4.BackColor = Color.Black
            space5.BackColor = Color.Black
            space6.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space7.Text = "O" And space8.Text = "O" And space9.Text = "O" Then
            space7.BackColor = Color.Black
            space8.BackColor = Color.Black
            space9.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space1.Text = "O" And space4.Text = "O" And space7.Text = "O" Then
            space1.BackColor = Color.Black
            space4.BackColor = Color.Black
            space7.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space2.Text = "O" And space5.Text = "O" And space8.Text = "O" Then
            space2.BackColor = Color.Black
            space5.BackColor = Color.Black
            space8.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space3.Text = "O" And space6.Text = "O" And space9.Text = "O" Then
            space3.BackColor = Color.Black
            space6.BackColor = Color.Black
            space9.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space1.Text = "O" And space5.Text = "O" And space9.Text = "O" Then
            space1.BackColor = Color.Black
            space5.BackColor = Color.Black
            space9.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If space3.Text = "O" And space5.Text = "O" And space7.Text = "O" Then
            space3.BackColor = Color.Black
            space5.BackColor = Color.Black
            space7.BackColor = Color.Black
            MessageBox.Show("PLAYER O WINS!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddOneToScore = Convert.ToInt64(oscore.Text)
            oscore.Text = Convert.ToString(AddOneToScore + 1)
            buttonsEnabledFalse()
        End If
    End Sub

    'space clicks
    Private Sub space_click(sender As Object, e As EventArgs) Handles space9.Click, space8.Click, space7.Click, space6.Click, space5.Click, space4.Click, space3.Click, space2.Click, space1.Click
        Dim b As Button = sender
        If checkforXorO = False Then
            b.Text = "X"
            checkforXorO = True
        Else
            b.Text = "O"
            checkforXorO = False
        End If
        checkForWin()
        b.Enabled = False
    End Sub

    'reset button
    Private Sub resetbutton_Click(sender As Object, e As EventArgs) Handles resetbutton.Click
        space1.Enabled = True
        space2.Enabled = True
        space3.Enabled = True
        space4.Enabled = True
        space5.Enabled = True
        space6.Enabled = True
        space7.Enabled = True
        space8.Enabled = True
        space9.Enabled = True

        'space text resets
        space1.Text = ""
        space2.Text = ""
        space3.Text = ""
        space4.Text = ""
        space5.Text = ""
        space6.Text = ""
        space7.Text = ""
        space8.Text = ""
        space9.Text = ""

        'space color reverts to white
        space1.BackColor = Color.White
        space2.BackColor = Color.White
        space3.BackColor = Color.White
        space4.BackColor = Color.White
        space5.BackColor = Color.White
        space6.BackColor = Color.White
        space7.BackColor = Color.White
        space8.BackColor = Color.White
        space9.BackColor = Color.White

    End Sub

    Private Sub newgamebutton_Click(sender As Object, e As EventArgs) Handles newgamebutton.Click
        space1.Enabled = True
        space2.Enabled = True
        space3.Enabled = True
        space4.Enabled = True
        space5.Enabled = True
        space6.Enabled = True
        space7.Enabled = True
        space8.Enabled = True
        space9.Enabled = True

        'space text resets
        space1.Text = ""
        space2.Text = ""
        space3.Text = ""
        space4.Text = ""
        space5.Text = ""
        space6.Text = ""
        space7.Text = ""
        space8.Text = ""
        space9.Text = ""

        'space color reverts to white
        space1.BackColor = Color.White
        space2.BackColor = Color.White
        space3.BackColor = Color.White
        space4.BackColor = Color.White
        space5.BackColor = Color.White
        space6.BackColor = Color.White
        space7.BackColor = Color.White
        space8.BackColor = Color.White
        space9.BackColor = Color.White

        'scores revert to 0
        oscore.Text = "0"
        xscore.Text = "0"
    End Sub
End Class

