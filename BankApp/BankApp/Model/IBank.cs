namespace BankApp.Model;

public interface IBank
{
    public ObservableCollection<Client> GetAllClients();
}
