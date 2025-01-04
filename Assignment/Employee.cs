using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        #region Properties
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }
        #endregion

        #region Enums
        enum Gender
        {
            M,F
        }
        enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }
        #endregion

        #region Constructors
        public Employee(int id, decimal salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        }
        #endregion

        #region Methods
        public void PrintSalary()
        {
            Console.WriteLine("The Salary of {0} is {1}",Name,Salary);
        }
        #endregion
    }
}
