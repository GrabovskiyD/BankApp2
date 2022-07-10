namespace BankApp.Model;

public class Bank : IBank
{
    private ObservableCollection<Client> Clients;

    public Bank()
    {
        Clients = new ObservableCollection<Client>()
        {
            new Client("Фёдоров", "Мирон", "Янович", "+7(777)170-34-44", "4444", "555555"),
            new Client("Алексеев", "Иван", "Александрович", "+7(777)189-36-57", "3333", "777777")
        };
    }

    public ObservableCollection<Client> GetAllClients()
    {
        return Clients;
    }
}
