using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toverland_API.Models
{
    public class MatrixSign
    {
        public int Id { get;}

        public DateTime UpdatedAt { get; set; }

        public Facility[] Facilities { get; private set;}

        public Location Location { get; private set;}

        public MatrixSign(Location location, Facility[] facilities)
        {
            this.Location = location;
            this.Facilities = facilities;
        }
    }
}