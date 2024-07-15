namespace Task_1_ADO;

public class User
{
    public User() { }
    public User( string name, string surname, int age ,string login, string password)
    {
        
        Name = name;
        Surname = surname;
        Age = age;
        Login = login;
        Password = password;
    }

    
    public string Name { get; set; }    
    public int Age { get; set; }
    public string Surname { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

}
