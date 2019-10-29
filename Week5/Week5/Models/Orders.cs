using System;
using System.Collections.Generic;

namespace Week5.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
