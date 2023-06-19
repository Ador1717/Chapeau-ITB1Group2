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
    public class MenuDao : BaseDao
    {
        public List<MenuItem> GetMenuItems(MenuCategory category)
        {
            // Decide query here 
            string query = "";

            // Set query to collect menu items 
            switch (category)
            {
                case MenuCategory.Lunch:
                    {
                        query = @"SELECT M.item_id, M.item_name, M.itemType, M.Price FROM MENU_ITEM AS M 
                                JOIN LUNCH_MENU AS L ON M.item_id = L.item_id ORDER BY CASE  
                                WHEN M.itemType LIKE 'Starters%' THEN '1' 
                                WHEN M.itemType LIKE 'Mains%' THEN '2' 
                                WHEN M.itemType LIKE 'Desserts%' THEN '3' END ASC, M.item_name; ";
                    }
                    break;

                case MenuCategory.Dinner:
                    {
                        query = @"SELECT M.item_id, M.item_name, M.itemType, M.Price FROM MENU_ITEM AS M 
                                JOIN DINNER_MENU AS D ON M.item_id = D.item_id ORDER BY CASE 
                                WHEN M.itemType LIKE 'Starters%' THEN '1'  
                                WHEN M.itemType LIKE 'Mains%' THEN '2' 
                                WHEN M.itemType LIKE 'Desserts%' THEN '3' END ASC,  M.item_name; ";
                    }
                    break;

                case MenuCategory.Drinks:
                    {
                        query = @"SELECT M.item_id, M.item_name, M.itemType, M.Price FROM MENU_ITEM AS M 
                                JOIN DRINKS_MENU AS D ON M.item_id = D.item_id ORDER BY CASE 
                                WHEN M.itemType LIKE '3' END ASC,  M.item_name; ";
                    }
                    break;
            }

            // Return result of query with list 
            return ReadTables(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            // Create new list of MenuItem objects
            List<MenuItem> menuItems = new List<MenuItem>();

            if (dataTable != null)
            {
                // For each data row, create new MenuItem object and fill data
                foreach (DataRow dr in dataTable.Rows)
                {
                    MenuItem item = new MenuItem()
                    {
                        ItemID = (int)dr["itemID"],
                        FullName = (string)dr["itemName"],
                        SubCategory = (string)dr["itemType"],
                        Price = (double)(decimal)dr["price"]
                    };

                    // Add new MenuItem object to the list of menu items 
                    menuItems.Add(item);
                }
            }
            else
            {
                throw new Exception("There is an issue retrieving the menu data from the database! Please try again later.");
            }

            // Return list of menu items 
            return menuItems;
        }
    }
}
