using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChepueModel;
using System.Data;
using ChepueDAL;

namespace ChepueService
{
    public class EmployeeService
    {
        EmployeeDAO employeeDAO;
        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
        }

        public void RegisterEmployee(string username,string Role, string password)
        {
            string salt = PasswordSaltHasher.CreateSalt(16); //byte
            string saltedHash = PasswordSaltHasher.GenerateSaltedHash(password, salt);

            employeeDAO.RegisterEmpoyee(username,Role, saltedHash, salt);
        }

        public Employee LoginEmployee(string username, string password)
        {
            DataRow userRow = employeeDAO.GetUserByUsername(username);

            if (userRow == null)
            {
                return null; // User not found
            }

            string storedHash = userRow["Hashed"].ToString();
            string storedSalt = userRow["Salt"].ToString();

            string saltedHash = PasswordSaltHasher.GenerateSaltedHash(password, storedSalt);

            if (saltedHash == storedHash)
            {
                Employee employee = new Employee
                {
                    // Use "Name" instead of "Username"
                    Name = userRow["Name"].ToString(),
                    Role = userRow["Role"].ToString(),
                    // add any other properties you need
                };

                return employee;
            }
            else
            {
                return null; // Password didn't match
            }
        }

    }
}
