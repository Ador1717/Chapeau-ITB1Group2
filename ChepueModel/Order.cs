namespace ChepueModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderEndTime { get; set; }
        public DateTime OrderTime { get; set; }
        public int TableID { get; set; }
        public Employee Employee { get; set; } 
        public Table Table { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
