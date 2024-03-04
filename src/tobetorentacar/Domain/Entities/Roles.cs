using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Roles : Entity<Guid>
{
        public string RoleName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        public Roles()
        {
        }

        public Roles(string roleName)
        {
            RoleName = roleName;

        }

}
