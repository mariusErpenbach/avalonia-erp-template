public class UserSession
{
    private static UserSession? _current;
    public static UserSession Current => _current ??= new UserSession();

    public  string Username { get; set; } = "";
    public  string Role { get; set; } = "";

    private UserSession() { } // privater Konstruktor, damit niemand eine neue Session aus Versehen erstellen kann

     public static void Initialize(string username, string role)
    {
        _current = new UserSession
        {
            Username = username,
            Role = role
        };
    }
}