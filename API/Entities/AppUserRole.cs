using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUserRole
    {
        public AppUser User { get; set; }
        public AppUser Role { get; set; }

    }
}
