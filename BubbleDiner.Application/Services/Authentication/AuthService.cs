namespace BubbleDiner.Application.Services.Authentication
{
    public class AuthService : IAuthService
    {
        public AuthResult Login(string Email, string Password)
        {
            return new AuthResult(Guid.NewGuid(), "Name1", "LastName", Email, Password );
        }

        public AuthResult Register(string FirstName, string LastName, string Email, string Password)
        {
            return new AuthResult(Guid.NewGuid(), FirstName, LastName, Email, Password );
        }
    }
}
