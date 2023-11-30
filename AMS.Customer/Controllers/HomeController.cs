using Microsoft.AspNetCore.Mvc;

namespace AMS.Customer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Ping()
    {
        return Ok("Customer server is healthy.");
    }
}
