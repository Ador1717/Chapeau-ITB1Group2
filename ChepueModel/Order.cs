namespace ChepueModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }
        public int TableID { get; set; }
        public Employee Employee { get; set; } // Add this line
        public Table Table { get; set; } // Add this line
        public List<OrderItem> OrderItems { get; set; }
    }
}
