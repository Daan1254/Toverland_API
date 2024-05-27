using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum Direction {
    NORTH,
    NORTH_EAST,
    EAST,
    SOUTH_EAST,
    SOUTH,
    SOUTH_WEST,
    WEST,
    NORTH_WEST,
}

namespace Toverland_API.Models
{
    public class Location
    {
        public int Id { get; }

        public decimal latitude  { get; set; }

        public decimal longitude { get; set; }

        public Direction Direction { get; set; }

        public Location()
        {
            
        }
    }
}