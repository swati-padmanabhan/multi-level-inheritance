using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence.models
{

    //Intermediate Class which inherits properties from Employee Class
    public class Department : Employee
    {
        public string DepartmentName { get; set; }
        public Department(int id, string name, string departmentName) : base(id, name)
        {
            DepartmentName = departmentName;
        }
        public string GetDepartmentData()
        {
            return $"Department Name: {DepartmentName}";
        }
    }

}
