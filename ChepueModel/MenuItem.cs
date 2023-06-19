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

        public Category Category { get; set; }

        public MenuItemType menuItemType { get; set; }

        public int Stock { get ; set; }

        public int ItemID { get; set; }
        public string FullName { get; set; }
        public string SubCategory { get; set; }
    }
}