using System;
using System.Collections.Generic;

namespace Commerce.Models
{
    public partial class OrderedItems
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
