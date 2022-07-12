namespace BankApp.Model;

public class Client : INotifyPropertyChanged, IClient
{
    private string firstName;
    private string lastName;
    private string middleName;
    private string fullName;
    private string phoneNumber;
    private string passportSeries;
    private string passportNumber;

    public Client(string lastName, string firstName, string middleName, string phoneNumber, string passportSeries, string passportNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        PhoneNumber = phoneNumber;
        PassportSeries = passportSeries;
        PassportNumber = passportNumber;
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
            OnPropertyChanged("FirstName");
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
            OnPropertyChanged("LastName");
        }
    }

    public string MiddleName
    {
        get { return middleName; }
        set
        {
            middleName = value;
            OnPropertyChanged("MiddleName");
        }
    }

    public string FullName
    {
        get { return fullName; }
        set
        {
            fullName = $"{LastName} {FirstName} {MiddleName}";
            OnPropertyChanged("FullName");
        }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            phoneNumber = value;
            OnPropertyChanged("PhoneNumber");
        }
    }

    public string PassportSeries
    {
        get { return passportSeries; }
        set
        {
            passportSeries = value;
            OnPropertyChanged("PassportSeries");
        }
    }

    public string PassportNumber
    {
        get { return passportNumber; }
        set
        {
            passportNumber = value;
            OnPropertyChanged("PassportNumber");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string prop = "")
    {
        if(PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }  
}
