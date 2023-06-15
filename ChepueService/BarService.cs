using ChepueDAL;
using ChepueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepueService
{
    public class BarService
    {
        private OrderDao orderdb;

        public BarService()
        {
            orderdb = new OrderDao();
        }
        public List<OrderItem> GetOrders()
        {
            List<OrderItem> orders = orderdb.GetAllBarOrders();
            return orders;
        }
    }
}
