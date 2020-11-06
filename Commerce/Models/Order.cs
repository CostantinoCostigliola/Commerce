using System;
using System.Collections.Generic;

namespace Commerce.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
