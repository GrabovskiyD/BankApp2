namespace BankApp.Model;

public class BankProxy : IBank
{
    private Bank bank;
    private MainWindow mainWindow;
    public BankProxy(Bank bank, MainWindow mainWindow)
    {
        this.bank = bank;
        this.mainWindow = mainWindow;
    }

    public ObservableCollection<IClient> GetAllClients()
    {
        ObservableCollection<IClient> clients = new();
        if(mainWindow.employee is Consultant)
        {
            foreach(IClient client in bank.GetAllClients())
            {
                clients.Add(new ClientDTO(client.LastName,
                                            client.FirstName,
                                            client.MiddleName,
                                            client.PhoneNumber,
                                            "********",
                                            "********"));
            }
            mainWindow.clientLastName.IsReadOnly = true;
            mainWindow.clientFirstName.IsReadOnly = true;
            mainWindow.clientMiddleName.IsReadOnly = true;
            mainWindow.clientPassportSeries.IsReadOnly = true;
            mainWindow.clientPassportNumber.IsReadOnly = true;
            mainWindow.clientPhoneNumber.TextChanged += delegate
            {
                if(mainWindow.clientPhoneNumber.Text == "")
                {
                    MessageBox.Show("Поле не может быть пустым!");
                }
            };
        }
        else if(mainWindow.employee is Manager)
        {
            foreach (IClient client in bank.GetAllClients())
            {
                clients.Add(new ClientDTO(client.LastName,
                                            client.FirstName,
                                            client.MiddleName,
                                            client.PhoneNumber,
                                            client.PassportSeries,
                                            client.PassportNumber));
            }
        }
        return clients;
    }
}
