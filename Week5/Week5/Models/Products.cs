using System;
using System.Collections.Generic;

namespace Week5.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductDetails { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int? ReorderQuantity { get; set; }
        public byte? Reorder { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
