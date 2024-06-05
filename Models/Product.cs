using System;
using System.Collections.Generic;

namespace DemoRazorPage.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
