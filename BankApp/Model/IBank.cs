namespace BankApp.Model;

public interface IBank
{
    public ObservableCollection<IClient> GetAllClients();
}
