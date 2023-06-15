using ChepueDAL;
using ChepueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepueService
{
    public class TableService 
    {
        TableDao tableDao;

        public TableService()
        {
            tableDao = new TableDao();
        }

        public bool TableOccupied(int tableNumber)
        {
            return tableDao.TableOccupied(tableNumber);
        }

        public void SetTableOccupied(int tableNumber)
        {
            tableDao.SetTableOccupied(tableNumber);
        }

        public void SetTableFree(int tableNumber)
        {
            tableDao.SetTableFree(tableNumber);
        }
        public List<Table> GetAllTables()
        {
            return tableDao.GetAllTables();
        }
    }
  
}
