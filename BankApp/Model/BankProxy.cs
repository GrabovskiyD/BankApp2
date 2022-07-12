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
                                            client.PassportSeries,
                                            client.PassportNumber));
            }
        }
        return clients;
    }
}
