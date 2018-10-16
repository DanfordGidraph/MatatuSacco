Class Login_Page
    Private Sub loginButton_Click(sender As Object, e As RoutedEventArgs) Handles loginButton.Click
        Dim main As New mainPage
        Me.NavigationService.Navigate(main)
    End Sub

    Private Sub password(sender As Object, e As TextCompositionEventArgs)
        Throw New NotImplementedException()
    End Sub


End Class
