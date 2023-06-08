using ChepueModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepueDAL
{
    public class OrderDao : BaseDao
    {
        public List<OrderItem> GetAllBarOrders()
        {
            string query = "SELECT oi.OrderItemId, oi.OrderId, oi.Quantity, oi.Comment, oi.Status as OrderItemStatus, o.OrderTime, e.Name, t.TableId, t.Is_Occupied as TableStatus, t.TableId as TableNumber " +
                "FROM Order_Item oi " +
                "INNER JOIN [Order] o ON oi.OrderId = o.OrderId " +
                "INNER JOIN Employee e ON o.Employee_ID = e.Employee_ID " +
                "INNER JOIN [Table] t ON o.TableId = t.TableId";

            DataTable orderItemTable = ExecuteSelectQuery(query);

            return ReadTables(orderItemTable);
        }

        private List<OrderItem> ReadTables(DataTable orderItemTable)
        {
            List<OrderItem> orders = new List<OrderItem>();

            foreach (DataRow orderItemRow in orderItemTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderItemId = (int)(orderItemRow["OrderItemId"]),
                    Quantity = (int)(orderItemRow["Quantity"]),
                    Comment = orderItemRow["Comment"] != DBNull.Value ? orderItemRow["Comment"].ToString() : string.Empty,
                    Status = (Status)Enum.Parse(typeof(Status), orderItemRow["OrderItemStatus"].ToString()),
                    Order = new Order()
                    {
                        OrderTime = Convert.ToDateTime(orderItemRow["OrderTime"]),
                        OrderID = (int)(orderItemRow["OrderId"]),
                        Employee = new Employee()
                        {
                            Name = orderItemRow["Name"].ToString()
                        },
                        Table = new Table(
                            (int)orderItemRow["TableId"],
                            (TableStatus)(orderItemRow["TableStatus"] is byte[] bytes && bytes[0] != 0 ? TableStatus.occupied : TableStatus.free),
                            (int)orderItemRow["TableNumber"]
                        )
                    }
                };

                orders.Add(orderItem);
            }

            return orders;
        }

    }
}
