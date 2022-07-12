namespace BankApp.Model;

public class BankProxy : IBank
{
    private Bank bank;
    private ObservableCollection<ClientDTO> clients;
    public BankProxy(Bank bank)
    {
        this.bank = bank;
    }

    public ObservableCollection<Client> GetAllClients()
    {
        if(employee is Consultant)
        {
            foreach(Client client in bank.GetAllClients())
            {
                clients.Add(new ClientDTO(client.LastName,
                                            client.FirstName,
                                            client.MiddleName,
                                            client.PhoneNumber,
                                            client.PassportSeries,
                                            client.PassportNumber));
            }
        }
    }
}
