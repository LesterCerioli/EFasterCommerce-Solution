using System;
using System.Collections.Generic;

namespace EFaster.Core.Models
{
    public class Role
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
