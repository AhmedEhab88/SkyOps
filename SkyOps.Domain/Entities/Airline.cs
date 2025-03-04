using SkyOps.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOps.Domain.Entities
{
    public class Airline : Entity
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
}
