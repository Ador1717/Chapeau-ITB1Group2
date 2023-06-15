using ChepueModel;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class EmployeeDAO : BaseDao
    {
        public void RegisterEmpoyee(string Name, string role, string Hashed, string salt)
        {
            string query = "INSERT INTO  [EMPLOYEE] (Name, Role, Hashed, Salt) VALUES (@Name, @Role,@Hashed, @Salt)";

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Name", Name);
            sqlParameters[1] = new SqlParameter("@Role", role);
            sqlParameters[2] = new SqlParameter("@Salt", salt);
            sqlParameters[3] = new SqlParameter("@Hashed", Hashed);

            ExecuteEditQuery(query, sqlParameters);
        }

        public DataRow GetUserByUsername(string Name) 
        {

            string query = "SELECT Employee_ID,Name,  Role, Hashed, Salt FROM Employee WHERE Name=@Name";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Name", Name);
            

            DataTable userTable = ExecuteSelectQuery(query, sqlParameters);
            if (userTable.Rows.Count == 0)
            {
                return null;
            }

            return userTable.Rows[0];
        }
    }
}

