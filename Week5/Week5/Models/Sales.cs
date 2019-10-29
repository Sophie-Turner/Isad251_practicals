using System;
using System.Collections.Generic;

namespace Week5.Models
{
    public partial class Sales
    {
        public double? TotalCost { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
    }
}
