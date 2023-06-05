namespace ChepueModel
{
    public class Table
    {
        public int TableId { get; set; }
        public  TableStatus  status { get; set; }
        public int TableNumber { get; set; }

        public Table(int tableId, TableStatus status, int tableNumber)
        {
            TableId = tableId;
            this.status = status;
            TableNumber = tableNumber;
        }
    }
}