namespace ChepueModel
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
        public Order Order { get; set; }
        public Category Category { get; set; }
        public Table Table { get; set; }

        private string comment = "";
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }

        public string Comment
        {
            get { return comment; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    comment = value;
                }
            }
        }

        public OrderItem(int itemID, string itemName, double price)
        {
            ItemID = itemID;
            ItemName = itemName;
            Price = price;
            Quantity = 1;
        }

        public OrderItem()
        {
        }

        public OrderItem(int itemID, double price)
        {
            ItemID = itemID;
            Price = price;
        }
    }
}
