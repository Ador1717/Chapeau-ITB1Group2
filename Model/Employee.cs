using ChepueModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } // keep it simple Name, Role, Password
        public string Role { get; set; }
        public int Password { get; set; }
    }
}
