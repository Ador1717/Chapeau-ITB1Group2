using ChepueModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Configuration;

namespace ChepueDAL
{
    public class OrderDao : BaseDao
    {
        public List<OrderItem> GetAllBarOrders()
        {
            string query = "SELECT oi.OrderItemId, oi.OrderId, oi.Quantity, oi.Comment, oi.Status as OrderItemStatus, o.OrderTime, o.OrderEnd, e.Name, t.TableId, t.Is_Occupied as TableStatus, t.TableId as TableNumber, i.Name as ItemName, i.item_name as Category " +
    "FROM Order_Item oi " +
    "INNER JOIN [Order] o ON oi.OrderId = o.OrderId " +
    "INNER JOIN Employee e ON o.Employee_ID = e.Employee_ID " +
    "INNER JOIN [Table] t ON o.TableId = t.TableId " +
    "INNER JOIN Item i ON oi.Item_id = i.Item_id " +
    "INNER JOIN Category c ON i.Category_id = c.Category_id";

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
                    ItemName = orderItemRow["ItemName"].ToString(),
                    Category = (Category)Enum.Parse(typeof(Category), orderItemRow["Category"].ToString()),
                    Order = new Order()
                    {
                        OrderTime = Convert.ToDateTime(orderItemRow["OrderTime"]),
                        OrderEndTime = orderItemRow["OrderEnd"] != DBNull.Value ? Convert.ToDateTime(orderItemRow["OrderEnd"]) : DateTime.MinValue,
                        OrderID = (int)(orderItemRow["OrderId"]),
                    },
                    Table = new Table((int)orderItemRow["TableId"], (bool)orderItemRow["TableStatus"])
                };

                orders.Add(orderItem);
            }

            return orders;
        }

        public void UpdateOrderEndTime(int orderId) // Make sure it's public
        {
            string query = "UPDATE [Order] SET OrderEnd = @OrderEnd WHERE OrderId = @OrderId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@OrderEnd", DateTime.Now);
            sqlParameters[1] = new SqlParameter("@OrderId", orderId);
            ExecuteEditQuery(query, sqlParameters);
        }


        public void UpdateStatusInDatabase(OrderItem bar)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ChepueDatabase"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Order_Item SET Status = @Status WHERE OrderItemId = @OrderItemId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Status", bar.Status.ToString());
                    command.Parameters.AddWithValue("@OrderItemId", bar.OrderItemId);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
