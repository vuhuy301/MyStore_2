using System;
using System.Collections.Generic;

namespace DemoRazorPage.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
