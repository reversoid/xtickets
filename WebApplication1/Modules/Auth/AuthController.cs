using Microsoft.AspNetCore.Mvc;
using XTickets.Modules.Auth.DTO;

namespace XTickets.Modules.Auth;



[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authSerivice;

    public AuthController(IAuthService authSerivice)
    {
        _authSerivice = authSerivice;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponseDTO>> Login(LoginRequestDTO dto)
    {
        return StatusCode(501);
    }

    [HttpPost("register")]
    public async Task<ActionResult<RegisterResponseDTO>> Register(RegisterRequestDTO dto)
    {
        return StatusCode(501);
    }
}