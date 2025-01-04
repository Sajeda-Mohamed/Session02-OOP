using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public Role role {  get; set; }
        public Gender gender {  get; set; }
        public HiringDate HiringDate { get; set; }
        #endregion

        #region Enums
        public enum Gender
        {
            M,F
        }
        public enum Role
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }
        #endregion

        #region Constructors
        public Employee(int id, string name, decimal salary, Role role, Gender gender, HiringDate hiringDate)
        {
            Id = id;
            Salary = salary;
            Name = name;
            this.role = role;
            this.gender = gender;
            HiringDate = hiringDate;
        }
        #endregion

        #region Methods
        public void PrintSalary()
        {
            Console.WriteLine("The Salary of {0} is {1}",Name,Salary);
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"The Name is {Name}, Id is{Id}, Salary is {Salary}, Role is " +
                $"{role}, Gender is {gender} and Hiring Date is {HiringDate}");
        }
        #endregion


    }
}
