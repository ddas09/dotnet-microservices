using AMS.Identity.Services.Contracts;
using AMS.Common.DAL.Contracts;
using AMS.Common.Data.Entities;
using AMS.Identity.Models;

namespace AMS.Identity.Services;

public class AccountService : IAccountService
{
    private readonly IUserRepository _userRepository;

    public AccountService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task Signup(SignupRequestModel request)
    {
        var user = await this._userRepository.Get(user => user.Email == request.Email);
        if (user != null)
        {
            throw new InvalidOperationException("User with this mail already exists.");
        }

        User newUser = new()
        {
            Name = request.Name,
            Email = request.Email,
            // this is just for example, use a safe and strong password hashing algorithm here
            PasswordHash = request.Password + "_hased", 
            CreatedBy = request.Email,
            UpdatedBy = request.Email,
        };

        await this._userRepository.Add(newUser);
    }
}