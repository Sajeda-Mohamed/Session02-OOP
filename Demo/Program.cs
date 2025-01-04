using Demo.Encapsulation;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            Employee employee = new Employee(10, "Sajeda", 2000);
            //Employee employee = new Employee(name:"Sajeda",id:10,salary:2000);
            //Console.WriteLine(employee);

            //employee.Id = 100;
            //Console.WriteLine(employee.Id);

            //employee.SetName("Sara");
            //Console.WriteLine(employee.GetName());

            employee.Salary = 5000;
            //Console.WriteLine(employee.Salary); 
            #endregion
        }
    }
}
