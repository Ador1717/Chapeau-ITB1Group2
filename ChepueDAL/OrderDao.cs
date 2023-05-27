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
            string query = "SELECT oi.OrderItemId, oi.OrderId, oi.Quantity, oi.Comment, oi.Status, o.OrderTime " +
               "FROM Order_Item oi " +
               "INNER JOIN [Order] o ON oi.OrderId = o.OrderId";

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
                    OrderId = (int)(orderItemRow["OrderId"]),
                    Quantity = (int)(orderItemRow["Quantity"]),
                    Comment = orderItemRow["Comment"] != DBNull.Value ? orderItemRow["Comment"].ToString() : string.Empty,
                    Status = (Status)Enum.Parse(typeof(Status), orderItemRow["Status"].ToString()),
                    Order = new Order()
                    {
                        OrderTime = Convert.ToDateTime(orderItemRow["OrderTime"])
                    }
                };

                orders.Add(orderItem);
            }

            return orders;
        }
    }
}
