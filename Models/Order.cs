using System;
using System.Collections.Generic;

namespace DemoRazorPage.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int StaffId { get; set; }

        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
