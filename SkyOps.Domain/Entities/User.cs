using SkyOps.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOps.Domain.Entities
{
    public class User : Entity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? MobileNumber { get; set; }
    }
}
