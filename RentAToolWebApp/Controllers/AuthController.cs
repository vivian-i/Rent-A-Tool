using Core.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentAToolWebApp.Services;

namespace RentAToolWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)//DI
        {
            _authService = authService;
        }

        // POST: AuthController/Login
        [HttpPost("login")]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginDTO loginDTO)
        {
            var jwtToken = _authService.Authenticate(loginDTO.Username, loginDTO.Password);

            if(jwtToken == null)
            {
                return Unauthorized();
            }

            return Ok(new {Token = jwtToken});
        }

        // POST: AuthController/Register
        [HttpPost("register")]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRegistrationDTO registrationDTO)
        {
            _authService.RegisterUser(registrationDTO.Username, registrationDTO.Password, registrationDTO.Email);
            return Ok();
        }




    }
}
