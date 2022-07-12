namespace BankApp.Model;

public interface IClient
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public string FullName { get; set; }

    public string PhoneNumber { get; set; }

    public string PassportSeries { get; set; }

    public string PassportNumber { get; set; }
}
