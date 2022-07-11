namespace BankApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        LoginPage loginPage = new LoginPage();
        loginPage.ShowDialog();
    }
}
