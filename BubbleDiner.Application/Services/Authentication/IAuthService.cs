namespace BubbleDiner.Application.Services.Authentication
{
    public interface IAuthService
    {
        AuthResult Login(string Email, string Password);
        AuthResult Register(string FirstName, string LastName, String Email, string Password);
    }
}
