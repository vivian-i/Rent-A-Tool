using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace RentAToolWebApp.Services
{
    public class AuthService //: IAuthService
    {
        /*private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthService(IConfiguration configuration, IUserRepository userRepository, IPasswordHasher<User> passwordHasher)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }*/

        private readonly Dictionary<string, string> _users = new()
        {
            { "sam", "123456" }//sample user
        };

        public void RegisterUser(string username, string password, string email)
        {
            //sample // store user in db later
            _users[username] = password;
        }

        public string? Authenticate(string username, string password)
        {
            string jwtToken = null;

            if(_users.TryGetValue(username,out var pwd) && pwd == password)
            {
                jwtToken = "jwt-token-sample123"; //sample jwt token
            }

            return jwtToken;
        }

        /*public async Task<AuthResponseDTO> RefreshTokenAsync(string refreshToken)
        {
            var user = await _userRepository.GetUserByRefreshTokenAsync(refreshToken);

            if (user == null || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                throw new UnauthorizedAccessException("Invalid or expired refresh token");
            }

            var newAccessToken = GenerateAccessToken(user);
            var newRefreshToken = GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
            await _userRepository.UpdateUserAsync(user);

            return new AuthResponseDTO
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            };
        }

        public async Task<bool> RevokeTokenAsync(string refreshToken)
        {
            var user = await _userRepository.GetUserByRefreshTokenAsync(refreshToken);

            if (user == null) return false;

            user.RefreshToken = null;
            user.RefreshTokenExpiryTime = null;
            await _userRepository.UpdateUserAsync(user);

            return true;
        }

        private string GenerateAccessToken(AppUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }*/
    }
}
