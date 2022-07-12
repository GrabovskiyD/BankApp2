namespace BankApp.ViewModel;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private ClientDTO selectedClient;

    public ClientDTO SelectedClient
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
