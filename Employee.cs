using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence.models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Constructor 
        //It is the Base Class
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public string GetEmployeeData()
        {
            return $"Employee ID: {Id} \nEmployee Name: {Name}";
        }
    }

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

    //Derived Class which inherits properties from Department Class
    public class Project : Department
    {
        public string ProjectName { get; set; }

        public Project(int id, string name, string departmentName, string projectName)
            : base(id, name, departmentName)
        {
            ProjectName = projectName;
        }
        public string  GetProjectData()
        {
            return $"Project Name: {ProjectName}";
        }
    
    }
}
