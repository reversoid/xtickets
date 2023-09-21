namespace XTickets.Modules.Auth;

public interface IAuthService
{
}

public class AuthService : IAuthService
{
    public void Register()
    {
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword("password", 12);
    }
}
