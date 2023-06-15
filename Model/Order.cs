namespace ChepueModel
{
    public class Order
    {
        //public Employee Employees { get; set; }
        public  Table table { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }
        public int TableID { get; set; }
    }
}
