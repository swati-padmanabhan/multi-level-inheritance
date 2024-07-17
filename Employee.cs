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
}
