using medFactory.Domain.Exceptions;
using medFactory.Domain.Models;
using medFactory.Domain.Services.ModelServices;
using Microsoft.AspNetCore.Identity;

namespace medFactory.Domain.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationService(IUserService userService, IPasswordHasher passwordHasher)
        {
            _userService = userService;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> Login(string username, string password)
        {
            User storedUser = await _userService.GetByUsername(username);

            if (storedUser == null)
            {
                throw new UserNotFoundException(username);
            }

            PasswordVerificationResult passwordResult = _passwordHasher.VerifyHashedPassword(storedUser.Password, password);

            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }

            return storedUser;
        }

        public async Task<RegistrationResult> Register(string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;
            }

            User usernameUser = await _userService.GetByUsername(username);
            if (usernameUser != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
            }

            if (result == RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasher.HashPassword(password);

                User user = new()
                {
                    Username = username,
                    Password = hashedPassword,
                    LastLogin = DateTime.Now
                };

                await _userService.Create(user);
            }

            return result;
        }
    }
}
