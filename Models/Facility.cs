using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toverland_API.Models
{
    public class Facility
    {
        public int Id { get; }

        public string Name { get; set; } = string.Empty;

        public Location location { get; set; }

        public Direction Direction { get; set; }


        public Facility(Location location, Direction direction) 
        {
            this.location = location;
            this.Direction = direction;
        }
    }
}