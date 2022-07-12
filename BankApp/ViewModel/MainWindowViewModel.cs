namespace BankApp.ViewModel;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private IClient selectedClient;

    public ObservableCollection<IClient> Clients { get; set; }

    public MainWindowViewModel(IBank bank)
    {
        Clients = bank.GetAllClients();
    }
    public IClient SelectedClient
    {
        get { return selectedClient; }
        set 
        {
            selectedClient = value;
            OnPropertyChanged("SelectedClient");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string prop = "")
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
