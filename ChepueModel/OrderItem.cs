namespace ChepueModel
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public Status Status { get; set; }
        public Order Order { get; set; }

        public Table Table { get; set; }
    }
}
