using Abp.Application.Services;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using CapstoneProject.ESN.Models;
using CapstoneProject.ESN.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.ESN.Users
{
    public class UserAppService : AsyncCrudAppService<User, UserDto, long>, IUserAppService
    {
        private readonly IRepository<User, long> _userRepository;
        public UserAppService(IRepository<User, long> repository) : base(repository)
        {
            _userRepository = repository;
        }

        public async Task<User> LoginAsync(string usernameOrEmailAddress, string password)
        {
             User user = _userRepository.GetAllList()
                .Where(x => (x.UserName.Equals(usernameOrEmailAddress) || x.EmailAddress.Equals(usernameOrEmailAddress))
                            && x.Password.Equals(password)
                ).FirstOrDefault();
            return user;
        }

    }
}
