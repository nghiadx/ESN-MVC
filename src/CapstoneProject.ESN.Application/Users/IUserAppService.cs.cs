using Abp.Application.Services;
using CapstoneProject.ESN.Models;
using CapstoneProject.ESN.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.ESN.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long>
    {
        Task<User> LoginAsync(string usernameOrEmailAddress, string password);
    }
}
