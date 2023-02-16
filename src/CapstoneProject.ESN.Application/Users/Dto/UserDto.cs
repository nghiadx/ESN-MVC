using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CapstoneProject.ESN.Models;

namespace CapstoneProject.ESN.Users.Dto
{
    [AutoMapTo(typeof(User))]
    public class UserDto : EntityDto<long>
    {
    }
}
