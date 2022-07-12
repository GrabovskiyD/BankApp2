namespace BankApp;

public partial class LoginPage : Window
{
    public LoginPage(MainWindow mainWindow)
    {
        InitializeComponent();
        consultant_btn.Click += delegate (object sender, RoutedEventArgs e)
        {
            mainWindow.employee = new Consultant();
            MessageBox.Show((mainWindow.employee is Consultant).ToString());
            Close();
        };
        manager_btn.Click += delegate (object sender, RoutedEventArgs e)
        {
            Close();
        };
    }
}
