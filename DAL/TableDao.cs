using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChepueModel;

namespace DAL
{
    public class TableDao : BaseDao
    {
        public bool TableOccupied(int TableNumber)
        {
            string query = @"SELECT Is_Occupied FROM [Table]  WHERE TableId = @TableNumber";
            //sql parameter
            SqlParameter[] sqlParameters =
            {
               new SqlParameter("@TableNumber", TableNumber)
            };
            // Excuting query
            return GetTableInfo(ExecuteSelectQuery(query, sqlParameters));
        }
        private bool GetTableInfo(DataTable dataTable)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return (bool)dataTable.Rows[0]["Is_Occupied"];
            }
            return false;
           // else
            //{
               //  throw new Exception("Something gone wrong, while reading table from the database");
            //}
        }
        public void SetTableOccupied(int tableNumber)
        {
            string query = @"UPDATE [Table]
                        SET Is_Occupied = 1
                        WHERE TableId = @TableNumber;";

            SqlParameter[] sqlParameters =
            {
               new SqlParameter("@TableNumber", tableNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Table> GetAllTables()
        {
            string query = "SELECT * FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            DataTable table = ExecuteSelectQuery(query, sqlParameters);
            List<Table> tables = new List<Table>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    int tableId = (int)row["TableId"];
                    bool isOccupied = (bool)row["Is_Occupied"];
                    tables.Add(new Table(tableId, isOccupied));
                }
            }
            return tables;
        }

        public void SetTableFree(int tableNumber)
        {
            string query = @"UPDATE [Table]
                           SET Is_Occupied = 0
                           WHERE TableID = @TableNumber;";

            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("@TableNumber", tableNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
