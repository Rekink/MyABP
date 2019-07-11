using System.Collections.Generic;
using MyABP.Roles.Dto;
using MyABP.Users.Dto;

namespace MyABP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}