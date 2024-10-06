Public Class Login
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Placeholder logic for login
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Call methods to check if user is admin or employee
        If IsAdmin(username, password) Then
            MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim adminForm As New adminForm()
            adminForm.Show()
            Me.Hide()
        ElseIf IsEmployee(username, password) Then
            MessageBox.Show("Employee Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim employeeForm As New employeeForm()
            employeeForm.Show()
            Me.Hide()
        ElseIf IsAccountant(username, password) Then
            MessageBox.Show("Accountant Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim AccountantForm As New Accountant()
            AccountantForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' This function checks admin credentials
    Private Function IsAdmin(username As String, password As String) As Boolean
        ' Simulated database check for admin
        ' Replace this with actual database query
        Return username = "admin" AndAlso password = "password"
    End Function

    ' This function checks employee credentials
    Private Function IsEmployee(username As String, password As String) As Boolean
        ' Simulated database check for employee
        ' Replace this with actual database query
        Return username = "employee" AndAlso password = "password"
    End Function

    Private Function IsAccountant(username As String, password As String) As Boolean
        ' Simulated database check for employee
        ' Replace this with actual database query
        Return username = "Accountant" AndAlso password = "password"
    End Function

    ' Handle the KeyDown event for the form
    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    ' Optional: Handle KeyDown event for TextBoxes
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class
