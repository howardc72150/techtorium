Public Class Form1
    Private Function DoValidations() As Boolean
        DoValidations = False

        If (TextBox1.Text = "") Then
            ' Checks for if the name text box is empty
            ' if it is, it will set the back colour to
            ' light pink and complain.

            TextBox1.BackColor = Color.LightPink
            MsgBox("Please enter your full name!")
            TextBox1.Focus()
            Exit Function
        ElseIf (IsNumeric(TextBox1.Text) = True) Then
            ' Checks if the name text box contains numbers
            ' if it does, it will complain.

            TextBox1.BackColor = Color.LightPink
            MsgBox("You cannot enter a number for your full name!")
            TextBox1.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            TextBox1.BackColor = Color.White
        End If

        If (TextBox2.Text = "") Then
            ' Checks for if the phone text box is empty
            ' if it is, it will set the back colour to
            ' light pink and complain.

            TextBox2.BackColor = Color.LightPink
            MsgBox("Please enter your phone number!")
            TextBox2.Focus()
            Exit Function
        ElseIf (IsNumeric(TextBox2.Text) = False) Then
            ' Checks if the phone text box doesn't contain 
            ' numbers if it doesn't, it will complain.

            TextBox2.BackColor = Color.LightPink
            MsgBox("You must enter numbers for your phone number!")
            TextBox2.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            TextBox2.BackColor = Color.White
        End If

        If (TextBox3.Text = "") Then
            ' Checks for if the email text box is empty
            ' if it is, it will set the back colour to
            ' light pink and complain.
            TextBox3.BackColor = Color.LightPink
            MsgBox("Please enter your email address!")
            TextBox3.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            TextBox3.BackColor = Color.White
        End If

        If (RichTextBox1.Text = "") Then
            ' Checks for if the address rich text box is
            ' empty if it is, it will set the back 
            ' colour to light pink and complain.
            RichTextBox1.BackColor = Color.LightPink
            MsgBox("Please enter your address!")
            RichTextBox1.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            RichTextBox1.BackColor = Color.White
        End If

        If (CheckBox1.Checked) = False And (CheckBox3.Checked) = False And (CheckBox2.Checked) = False Then
            ' Checks if all communication preferences
            ' are not checked, if they are not it will
            ' complain.
            MsgBox("Please enter a communication preference!")
            CheckBox1.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            RichTextBox1.BackColor = Color.White
        End If

        If (ComboBox1.Text = "") Then
            ' Checks for if the country combo box is empty
            ' if it is, it will set the back colour to
            ' light pink and complain.
            ComboBox1.BackColor = Color.LightPink
            MsgBox("Please enter your country!")
            ComboBox1.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            ComboBox1.BackColor = Color.White
        End If

        If (ComboBox2.Text = "") And (TextBox4.Text = "") Then
            ' Checks for if the course combo box is empty
            ' if it is, it will set the back colour to
            ' light pink and complain.
            ComboBox2.BackColor = Color.LightPink
            MsgBox("Please enter your course!")
            ComboBox2.Focus()
            Exit Function
        Else
            ' Sets the back colour to white if no complaints.
            ComboBox2.BackColor = Color.White
        End If

        DoValidations = True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DoValidations() = True Then
            ' Calls for the DoValidations function, and returns a
            ' boolean which is dependant on whether there are any
            ' validation issues or not.

            ListBox2.Items.Clear()
            ' Clears the second list box, incase a user wants
            ' to print another response in the same session.

            ListBox2.Items.Add("=========================================== Student Details ===========================================")
            ListBox2.Items.Add("Name of Student: " & TextBox1.Text)
            ListBox2.Items.Add("Phone Number: " & TextBox2.Text)
            ListBox2.Items.Add("Email Address: " & TextBox3.Text)
            ListBox2.Items.Add("DOB: " & Format(DateTimePicker1.Value, "Long date"))
            ListBox2.Items.Add("Address: " & RichTextBox1.Text)
            ListBox2.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")

            If (RadioButton2.Checked) = True Then
                ' Checks if the citizen button has been checked
                ListBox2.Items.Add("Student Status: Citizen")
            End If
            If (RadioButton1.Checked) = True Then
                ' Checks if the international button has been checked
                ListBox2.Items.Add("Student Status: International")
            End If

            ListBox2.Items.Add("Communication Preference: ")
            If (CheckBox1.Checked) = True Then
                ' Checks if the email button has been checked
                ListBox2.Items.Add("    Email")
            End If
            If (CheckBox2.Checked) = True Then
                ' Checks if the call button has been checked
                ListBox2.Items.Add("    Call")
            End If
            If (CheckBox3.Checked) = True Then
                ' Checks if the text button has been checked
                ListBox2.Items.Add("    Text")
            End If

            ListBox2.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")

            ListBox2.Items.Add("Country: " & ComboBox1.Text)
            If (TextBox4.Text) = "" Then
                ' Checks if the 'Other' course text box is empty
                ' if so prints the combobox result.
                ListBox2.Items.Add("Course: " & ComboBox2.Text)
            Else
                ' Otherwise it will print the text box result.
                ListBox2.Items.Add("Course: " & TextBox4.Text)
            End If
            ListBox2.Items.Add("=========================================== Student Details ===========================================")
        End If
    End Sub
End Class
