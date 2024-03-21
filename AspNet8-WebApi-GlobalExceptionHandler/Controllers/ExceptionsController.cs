using Microsoft.AspNetCore.Mvc;

namespace AspNet8_WebApi_GlobalExceptionHandler.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExceptionsController : ControllerBase
{
    [HttpGet]
    [Route("test-exception-1")]
    public IActionResult TestException()
    {
        throw new Exception("Test exception");
    }
}