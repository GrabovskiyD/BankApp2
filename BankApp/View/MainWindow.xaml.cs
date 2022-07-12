namespace BankApp;

public partial class MainWindow : Window
{
    public Employee employee;
    public MainWindow()
    {
        InitializeComponent();
        LoginPage loginPage = new LoginPage(this);
        loginPage.ShowDialog();
        DataContext = new MainWindowViewModel(new BankProxy(new Bank(), this));
    }
}
