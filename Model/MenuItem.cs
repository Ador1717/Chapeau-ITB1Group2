using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChepueModel
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Category category { get; set; }
    }
}