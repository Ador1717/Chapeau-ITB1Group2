namespace ChepueModel
{
    public class Table
    {
        public int TableId { get; set; }
        public  TableStatus  status { get; set; }
        public int TableNumber { get; set; }

        public Table(int tableId, Status status, int tableNumber)
        {
            TableId = tableId;
            Status status1 = status;
            TableNumber = tableNumber;
        }
    }
}