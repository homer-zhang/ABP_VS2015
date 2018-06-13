using System.Collections.Generic;
using Template.Dev.Roles.Dto;
using Template.Dev.Users.Dto;

namespace Template.Dev.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}