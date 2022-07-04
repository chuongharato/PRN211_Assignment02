using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        public int MemberId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
