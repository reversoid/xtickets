using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[Route("error")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ControllerBase
{
    [HttpGet, HttpPost, HttpPut, HttpDelete, HttpPatch, HttpOptions, HttpHead]
    public IActionResult Error()
    {
        return StatusCode(500, "Internal server error");
    }
}