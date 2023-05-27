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
        private OrderDao bardb;

        public BarService()
        {
            bardb = new OrderDao();
        }
        public List<OrderItem> GetBars()
        {
            List<OrderItem> bars = bardb.GetAllBarOrders();
            return bars;
        }
    }
}
