using MultilevelInheritence.models;

namespace MultilevelInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project(101, "Ram", "SCM", "Logistics");

            //Display employee data
            Console.WriteLine(project.GetEmployeeData());

            //Display department data
            Console.WriteLine(project.GetDepartmentData());

            //Display project information
            Console.WriteLine(project.GetProjectData());      
        }
    }
}
