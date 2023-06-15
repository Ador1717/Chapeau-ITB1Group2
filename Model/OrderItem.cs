using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChepueModel
{
    public class OrderItem
    {
        public string comment { get; set; }
        public int quantity { get; set; }
        public MenuItem menuItem { get; set; }

        public Status Status { get; set; }

    }
}