using ChepueDAL;
using ChepueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepueService
{
    public class OrderService
    {
        // DAL 
        OrderDao orderDAO;

        // Constructor
        public OrderService()
        {
            // Initialise
            orderDAO = new OrderDao();
        }
        /*
        public void PlaceOrder(List<OrderItem> orderItems, int tableNumber)
        {
            orderDAO.PlaceOrder(orderItems, tableNumber);
        }

        public bool CheckOrderStatus(int tableNumber)
        {
            // Call orderDAO to check if order exists
            return orderDAO.CheckOrderStatus(tableNumber);
        }

        public List<OrderItem> GetOrderItems()
        {
            return orderDAO.GetOrderItems();
        } */
    }
}
