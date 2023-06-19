namespace ChepueModel
{
    public class Table
    {
        public int TableId { get; set; }
        public  bool Is_Occupied { get; set; }
        //public string OrderStatus { get; set; }

        public Table(int tableId, bool is_Occupied) //string orderStatus)
        {
            TableId = tableId;
            this.Is_Occupied = is_Occupied;
           // OrderStatus = orderStatus;
        }
    }
}