namespace BankApp;

public partial class LoginPage : Window
{
    public LoginPage()
    {
        InitializeComponent();
        consultant_btn.Click += delegate (object sender, RoutedEventArgs e)
        {
            Close();
        };
        manager_btn.Click += delegate (object sender, RoutedEventArgs e)
        {
            Close();
        };
    }
}
