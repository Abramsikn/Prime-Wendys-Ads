using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeWendys.Models.DataModels
{
    public class UserLogin
    {
        public UserDto User { get; set; }
        public ICollection<RoleDto> Roles { get; set; }
        public ICollection<PermissionDto> Permissions { get; set; }

    }
}
