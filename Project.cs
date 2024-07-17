using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence.models
{

    //Derived Class which inherits properties from Department Class
    public class Project : Department
    {
        public string ProjectName { get; set; }

        public Project(int id, string name, string departmentName, string projectName)
            : base(id, name, departmentName)
        {
            ProjectName = projectName;
        }
        public string GetProjectData()
        {
            return $"Project Name: {ProjectName}";
        }

    }
}
