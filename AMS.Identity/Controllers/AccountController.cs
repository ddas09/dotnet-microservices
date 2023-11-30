using AMS.Identity.Models;
using AMS.Identity.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AMS.Identity.Controllers;

[ApiController]
[Route("api/accounts")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Signup(SignupRequestModel request)
    {
        await _accountService.Signup(request);
        return Ok("User account created successfully.");
    }
}
