using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstname, string lastName, string email, string password)
    {
        // Check if user already exists

        // Create user (generate UID)
        
        
        // Create JWT Token
        Guid userId = Guid.NewGuid();
        
        var token = _jwtTokenGenerator.GenerateToken(userId, firstname, lastName);

        return new AuthenticationResult(
            Guid.NewGuid(),
            firstname,
            lastName,
            email,
            token
        );
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstname",
            "lastName",
            email,
            "token"
        );
    }
}