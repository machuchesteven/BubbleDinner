using BubbleDiner.Application.Services.Authentication;
using BubbleDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BubbleDinner.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult Get()
        {
            return Ok("Welcome to the auth controller");
        }
        [HttpPost("register")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            AuthResult response = _authService.Register(request.FirstName, request.LastName, request.Email, request.Password);

            return Ok(response);
        }

        [HttpPost("login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var response = _authService.Login(request.Email, request.Password);
            return Ok(response);
        }

    }
}
