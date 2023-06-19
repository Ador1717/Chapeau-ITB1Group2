using ChepueDAL;
using ChepueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepueService
{
    public class MenuService
    {
        MenuDao menuDAO;

        // Constructor
        public MenuService()
        {
            // Create new MenuDao
            menuDAO = new MenuDao();
        }

        public List<MenuItem> GetMenuItems(MenuCategory category)
        {
            // Get list of all products of certain menu category
            List<MenuItem> menuList = menuDAO.GetMenuItems(category);

            // Return list of items
            return menuList;
        }
    }
}
