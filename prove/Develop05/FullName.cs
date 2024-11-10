public class FullName
{
    private string _firstName;
    private string _lastName;

    // public FullName(string firstName = "", string lastName = "")

    // {
    //     _firstName = firstName;
    //     _lastName = lastName;
    // }

    // // Getter to return the full name
    // public string GetFullName()
    // {
    //     return $"{_firstName} {_lastName}";
    // }

    // // Setter to update first and last name
    // public void SetFirstLastName(string firstName, string lastName)
    // {
    //     _firstName = firstName;
    //     _lastName = lastName;
    // }

  // Default constructor
    public FullName()
    {
        _firstName = "";
        _lastName = "";
    }

    // Getter to return the full name
    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    // Setter to update first and last name
    public void SetFirstLastName(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}

