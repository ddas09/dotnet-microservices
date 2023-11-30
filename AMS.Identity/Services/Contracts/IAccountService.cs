using AMS.Identity.Models;

namespace AMS.Identity.Services.Contracts;

public interface IAccountService
{
    Task Signup(SignupRequestModel request);
}