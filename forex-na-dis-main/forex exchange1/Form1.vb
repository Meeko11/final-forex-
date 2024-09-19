Public Class form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRT1.SelectedIndexChanged
        If CRT1.SelectedIndex = 0 Then
            PictureBox1.Image = My.Resources.USa
        End If

        If CRT1.SelectedIndex = 1 Then
            PictureBox1.Image = My.Resources.HK
        End If

        If CRT1.SelectedIndex = 2 Then
            PictureBox1.Image = My.Resources.CANDA
        End If

        If CRT1.SelectedIndex = 3 Then
            PictureBox1.Image = My.Resources.INDIA
        End If

        If CRT1.SelectedIndex = 4 Then
            PictureBox1.Image = My.Resources.SRi
        End If

        If CRT1.SelectedIndex = 5 Then
            PictureBox1.Image = My.Resources.arab

        End If

        If CRT1.SelectedIndex = 6 Then
            PictureBox1.Image = My.Resources.UK
        End If

        If CRT1.SelectedIndex = 7 Then
            PictureBox1.Image = My.Resources.JP
        End If

        If CRT1.SelectedIndex = 8 Then
            PictureBox1.Image = My.Resources.EU
        End If

        If CRT1.SelectedIndex = 9 Then
            PictureBox1.Image = My.Resources.ph
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRT2.SelectedIndexChanged
        If CRT2.SelectedIndex = 0 Then
            PictureBox2.Image = My.Resources.USa
        End If

        If CRT2.SelectedIndex = 1 Then
            PictureBox2.Image = My.Resources.HK
        End If

        If CRT2.SelectedIndex = 2 Then
            PictureBox2.Image = My.Resources.CANDA
        End If

        If CRT2.SelectedIndex = 3 Then
            PictureBox2.Image = My.Resources.INDIA
        End If

        If CRT2.SelectedIndex = 4 Then
            PictureBox2.Image = My.Resources.SRi
        End If

        If CRT2.SelectedIndex = 5 Then
            PictureBox2.Image = My.Resources.arab

        End If

        If CRT2.SelectedIndex = 6 Then
            PictureBox2.Image = My.Resources.UK
        End If

        If CRT2.SelectedIndex = 7 Then
            PictureBox2.Image = My.Resources.JP
        End If

        If CRT2.SelectedIndex = 8 Then
            PictureBox2.Image = My.Resources.EU
        End If

        If CRT2.SelectedIndex = 9 Then
            PictureBox2.Image = My.Resources.ph
        End If
    End Sub

    Private Sub CPT_Click(sender As Object, e As EventArgs) Handles CPT.Click
        Dim cb1index As Integer = CRT1.SelectedIndex
        Dim cb2index As Integer = CRT2.SelectedIndex
        Dim amount As Double = Val(TextBox1.Text)
        'USA to USA
        If cb1index = 0 And cb2index = 0 Then
            TextBox2.Text = amount
            'USA to HK
        ElseIf cb1index = 0 And cb2index = 1 Then
            TextBox2.Text = amount * 7.79
            'USA to Canada
        ElseIf cb1index = 0 And cb2index = 2 Then
            TextBox2.Text = amount * 1.36
            'USA to india
        ElseIf cb1index = 0 And cb2index = 3 Then
            TextBox2.Text = amount * 83.72
            'USA to SRI
        ElseIf cb1index = 0 And cb2index = 4 Then
            TextBox2.Text = amount * 303.44
            'USA to arab
        ElseIf cb1index = 0 And cb2index = 5 Then
            TextBox2.Text = amount * 962.25
            ''USA to HKG
        ElseIf cb1index = 0 And cb2index = 6 Then
            TextBox2.Text = amount * 7.13
            'USA TO JP
        ElseIf cb1index = 0 And cb2index = 7 Then
            TextBox2.Text = amount * 0.39
            'USA to EU 
        ElseIf cb1index = 0 And cb2index = 8 Then
            TextBox2.Text = amount * 0.018
            'USA to PH 
        ElseIf cb1index = 0 And cb2index = 9 Then
            TextBox2.Text = amount * 0.018
        End If
        'ok nayan yung iba nalang self wag kang bonak 


        'HK to HK 
        If cb1index = 1 And cb2index = 1 Then
            TextBox2.Text = amount
            'HK TO USA 
        ElseIf cb1index = 1 And cb2index = 0 Then
            TextBox2.Text = amount * 0.13
            'HK to CND
        ElseIf cb1index = 1 And cb2index = 2 Then
            TextBox2.Text = amount * 0.17
            'HK to INDIA
        ElseIf cb1index = 1 And cb2index = 3 Then
            TextBox2.Text = amount * 10.73
            'HK to SRI
        ElseIf cb1index = 1 And cb2index = 4 Then
            TextBox2.Text = amount * 39.1
            'HK to arab
        ElseIf cb1index = 1 And cb2index = 5 Then
            TextBox2.Text = amount * 0.47
            'HK to UK 
        ElseIf cb1index = 1 And cb2index = 6 Then
            TextBox2.Text = amount * 0.09
            'HK to JP 
        ElseIf cb1index = 1 And cb2index = 7 Then
            TextBox2.Text = amount * 18.27
            'HK to EU 
        ElseIf cb1index = 1 And cb2index = 8 Then
            TextBox2.Text = amount * 0.12
            'HK to Ph 
        ElseIf cb1index = 1 And cb2index = 9 Then
            TextBox2.Text = amount * 7.14
        End If

        'CANADA to CANADA
        If cb1index = 2 And cb2index = 2 Then
            TextBox2.Text = amount
            'CANADA  TO USA 
        ElseIf cb1index = 2 And cb2index = 0 Then
            TextBox2.Text = amount * 0.74
            'CANADA to HK
        ElseIf cb1index = 2 And cb2index = 1 Then
            TextBox2.Text = amount * 5.73
            'CANADA to INDIA
        ElseIf cb1index = 2 And cb2index = 3 Then
            TextBox2.Text = amount * 61.55
            'CANADA to SRI
        ElseIf cb1index = 2 And cb2index = 4 Then
            TextBox2.Text = amount * 224.29
            'CANADA to arab
        ElseIf cb1index = 2 And cb2index = 5 Then
            TextBox2.Text = amount * 2.7
            'CANADA to UK 
        ElseIf cb1index = 2 And cb2index = 6 Then
            TextBox2.Text = amount * 0.56
            'CANADA to JP 
        ElseIf cb1index = 2 And cb2index = 7 Then
            TextBox2.Text = amount * 105.24
            'CANADA to EU 
        ElseIf cb1index = 2 And cb2index = 8 Then
            TextBox2.Text = amount * 0.66
            'CANADA to Ph 
        ElseIf cb1index = 2 And cb2index = 9 Then
            TextBox2.Text = amount * 41.01
        End If

        'india to india 
        If cb1index = 3 And cb2index = 3 Then
            TextBox2.Text = amount
            'india  TO USA 
        ElseIf cb1index = 3 And cb2index = 0 Then
            TextBox2.Text = amount * 0.012
            'india to HK
        ElseIf cb1index = 3 And cb2index = 1 Then
            TextBox2.Text = amount * 0.093
            ' india to CANADA
        ElseIf cb1index = 3 And cb2index = 2 Then
            TextBox2.Text = amount * 0.016
            'india to SRI
        ElseIf cb1index = 3 And cb2index = 4 Then
            TextBox2.Text = amount * 3.64
            'india to arab
        ElseIf cb1index = 3 And cb2index = 5 Then
            TextBox2.Text = amount * 0.04
            'india to UK 
        ElseIf cb1index = 3 And cb2index = 6 Then
            TextBox2.Text = amount * 0.009
            'india to JP 
        ElseIf cb1index = 3 And cb2index = 7 Then
            TextBox2.Text = amount * 1.71
            'india to EU 
        ElseIf cb1index = 3 And cb2index = 8 Then
            TextBox2.Text = amount * 0.0107141
            'india to Ph 
        ElseIf cb1index = 3 And cb2index = 9 Then
            TextBox2.Text = amount * 0.67
        End If

        'sri to sri
        If cb1index = 4 And cb2index = 4 Then
            TextBox2.Text = amount
            'sri  TO USA 
        ElseIf cb1index = 4 And cb2index = 0 Then
            TextBox2.Text = amount * 0.0033
            'sri to HK
        ElseIf cb1index = 4 And cb2index = 1 Then
            TextBox2.Text = amount * 0.026
            ' sri to CANADA
        ElseIf cb1index = 4 And cb2index = 2 Then
            TextBox2.Text = amount * 0.0045
            'sri to india
        ElseIf cb1index = 4 And cb2index = 3 Then
            TextBox2.Text = amount * 3.64
            'sri to arab
        ElseIf cb1index = 4 And cb2index = 5 Then
            TextBox2.Text = amount * 0.01
            'sri to UK 
        ElseIf cb1index = 4 And cb2index = 6 Then
            TextBox2.Text = amount * 0.0025
            'sri to JP 
        ElseIf cb1index = 4 And cb2index = 7 Then
            TextBox2.Text = amount * 0.47
            'sri to EU 
        ElseIf cb1index = 4 And cb2index = 8 Then
            TextBox2.Text = amount * 0.0024
            'sri to Ph 
        ElseIf cb1index = 4 And cb2index = 9 Then
            TextBox2.Text = amount * 0.18
        End If

        'arab to arab 
        If cb1index = 5 And cb2index = 5 Then
            TextBox2.Text = amount
            'arab  TO USA 
        ElseIf cb1index = 5 And cb2index = 0 Then
            TextBox2.Text = amount * 0.27
            'arab to HK
        ElseIf cb1index = 5 And cb2index = 1 Then
            TextBox2.Text = amount * 2.12
            ' arab to CANADA
        ElseIf cb1index = 5 And cb2index = 2 Then
            TextBox2.Text = amount * 0.36
            'arab to india
        ElseIf cb1index = 5 And cb2index = 3 Then
            TextBox2.Text = amount * 22.77
            'arab to sri
        ElseIf cb1index = 5 And cb2index = 4 Then
            TextBox2.Text = amount * 83.0
            'arab to UK 
        ElseIf cb1index = 5 And cb2index = 6 Then
            TextBox2.Text = amount * 0.2
            'arab to JP 
        ElseIf cb1index = 5 And cb2index = 7 Then
            TextBox2.Text = amount * 38.9
            'arab to EU 
        ElseIf cb1index = 5 And cb2index = 8 Then
            TextBox2.Text = amount * 0.24
            'arab to Ph 
        ElseIf cb1index = 5 And cb2index = 9 Then
            TextBox2.Text = amount * 15.12
        End If

        'UK to UK  
        If cb1index = 6 And cb2index = 6 Then
            TextBox2.Text = amount
            'UK TO USA 
        ElseIf cb1index = 6 And cb2index = 0 Then
            TextBox2.Text = amount * 1.32
            'UK to HK
        ElseIf cb1index = 6 And cb2index = 1 Then
            TextBox2.Text = amount * 10.34
            ' UK to CANADA
        ElseIf cb1index = 6 And cb2index = 2 Then
            TextBox2.Text = amount * 1.79
            'UK to india
        ElseIf cb1index = 6 And cb2index = 3 Then
            TextBox2.Text = amount * 111.0
            'UK to sri
        ElseIf cb1index = 6 And cb2index = 4 Then
            TextBox2.Text = amount * 404.61
            'UK to arab 
        ElseIf cb1index = 6 And cb2index = 5 Then
            TextBox2.Text = amount * 4.87
            'UK to JP 
        ElseIf cb1index = 6 And cb2index = 7 Then
            TextBox2.Text = amount * 189.7
            'UK to EU 
        ElseIf cb1index = 6 And cb2index = 8 Then
            TextBox2.Text = amount * 1.19
            'UK to Ph 
        ElseIf cb1index = 6 And cb2index = 9 Then
            TextBox2.Text = amount * 73.77
        End If

        'JP to JP 
        If cb1index = 7 And cb2index = 7 Then
            TextBox2.Text = amount
            'JP TO USA 
        ElseIf cb1index = 7 And cb2index = 0 Then
            TextBox2.Text = amount * 0.007
            'JP to HK
        ElseIf cb1index = 7 And cb2index = 1 Then
            TextBox2.Text = amount * 0.055
            ' JP to CANADA
        ElseIf cb1index = 7 And cb2index = 2 Then
            TextBox2.Text = amount * 0.0095
            'JP to india
        ElseIf cb1index = 7 And cb2index = 3 Then
            TextBox2.Text = amount * 0.58
            'JP to sri
        ElseIf cb1index = 7 And cb2index = 4 Then
            TextBox2.Text = amount * 2.13
            'JP to arab 
        ElseIf cb1index = 7 And cb2index = 5 Then
            TextBox2.Text = amount * 0.02
            ' JP to UK
        ElseIf cb1index = 7 And cb2index = 6 Then
            TextBox2.Text = amount * 0.0053
            'JP to EU 
        ElseIf cb1index = 7 And cb2index = 8 Then
            TextBox2.Text = amount * 0.0062
            'JP to Ph 
        ElseIf cb1index = 7 And cb2index = 9 Then
            TextBox2.Text = amount * 0.38
        End If

        'EU to EU 
        If cb1index = 8 And cb2index = 8 Then
            TextBox2.Text = amount
            'EU TO USA 
        ElseIf cb1index = 8 And cb2index = 0 Then
            TextBox2.Text = amount * 1.11
            'EU to HK
        ElseIf cb1index = 8 And cb2index = 1 Then
            TextBox2.Text = amount * 8.69
            ' EU to CANADA
        ElseIf cb1index = 8 And cb2index = 2 Then
            TextBox2.Text = amount * 1.51
            'EU to india
        ElseIf cb1index = 8 And cb2index = 3 Then
            TextBox2.Text = amount * 93.24
            'EU to sri
        ElseIf cb1index = 8 And cb2index = 4 Then
            TextBox2.Text = amount * 339.89
            'EU to arab 
        ElseIf cb1index = 8 And cb2index = 5 Then
            TextBox2.Text = amount * 4.09
            ' EU to UK
        ElseIf cb1index = 8 And cb2index = 6 Then
            TextBox2.Text = amount * 0.83
            'EU to JP 
        ElseIf cb1index = 8 And cb2index = 7 Then
            TextBox2.Text = amount * 159.3
            'EU to Ph 
        ElseIf cb1index = 8 And cb2index = 9 Then
            TextBox2.Text = amount * 61.94
        End If

        'PH to PH 
        If cb1index = 9 And cb2index = 9 Then
            TextBox2.Text = amount
            'PH TO USA 
        ElseIf cb1index = 9 And cb2index = 0 Then
            TextBox2.Text = amount * 0.01
            'PH to HK
        ElseIf cb1index = 9 And cb2index = 1 Then
            TextBox2.Text = amount * 0.14
            ' PH to CANADA
        ElseIf cb1index = 9 And cb2index = 2 Then
            TextBox2.Text = amount * 0.02
            'PH to india
        ElseIf cb1index = 9 And cb2index = 3 Then
            TextBox2.Text = amount * 1.5
            'PH to sri
        ElseIf cb1index = 9 And cb2index = 4 Then
            TextBox2.Text = amount * 5.48
            'PH to arab 
        ElseIf cb1index = 9 And cb2index = 5 Then
            TextBox2.Text = amount * 0.06
            ' PH to UK
        ElseIf cb1index = 9 And cb2index = 6 Then
            TextBox2.Text = amount * 0.01
            'PH to JP 
        ElseIf cb1index = 9 And cb2index = 7 Then
            TextBox2.Text = amount * 2.57
            'PH to EU  
        ElseIf cb1index = 9 And cb2index = 8 Then
            TextBox2.Text = amount * 0.01
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
