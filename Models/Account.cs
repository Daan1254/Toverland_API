using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toverland_API.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public bool EmailVerified { get; set; } = true;

        public Account()
        {
            
        }
    }
}