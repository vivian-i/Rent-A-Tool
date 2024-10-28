using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDTO> Login(UserLoginDTO loginRequest);
        Task<AuthResponseDTO> RefreshToken(string refreshToken);
        Task<bool> RevokeToken(string refreshToken);
    }
}
