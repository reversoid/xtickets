namespace XTickets.Modules.Auth;

public interface IAuthService
{
}

public class AuthService : IAuthService
{
    private readonly int _hashWorkFactor = 12;

    public void Register()
    {
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword("password", _hashWorkFactor);
    }
}
