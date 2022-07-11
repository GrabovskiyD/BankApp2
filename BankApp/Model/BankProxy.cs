namespace BankApp.Model;

public class BankProxy : IBank
{
    private Bank bank;
    public BankProxy(Bank bank)
    {
        this.bank = bank;
    }

    public ObservableCollection<Client> GetAllClients()
    {
        return this.bank.GetAllClients();
    }
}
