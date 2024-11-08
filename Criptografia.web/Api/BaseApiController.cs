using Criptografia.web.Componentes;
using Microsoft.AspNetCore.Mvc;

namespace Criptografia.web.Api;
[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    protected IActionResult Success(string? message = null, object? data = null)
    {
        return Ok(new JsonData(true, message) { Data = data });
    }

    protected IActionResult Success(object data)
    {
        return Ok(new JsonData(data) { Status = true });
    }

    protected IActionResult Error(string? message)
    {
        return Ok(new JsonData(false, message));
    }

    protected IActionResult Error(Exception e)
    {
        return BadRequest(e.Message);
    }
}
