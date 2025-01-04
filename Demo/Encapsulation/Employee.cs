using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        int Id;
        String? Name;
        decimal salary;
        #endregion

        #region Constractors
        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            this.salary = salary;
        } 
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nSalary : {salary}";
        }
        #endregion

        #region Getter - Setter
        public void SetName(string? Name)
        {
            this.Name = Name?.Length > 5 ? Name.Substring(0,5):Name;
        }
        public string? GetName()
        {
            return this.Name ;
        }
        #endregion

        #region Property
        public decimal Salary 
        {
            get { return salary; }
            set { salary = value > 5000 ? 5000 : value;}
        }
        //int age;
        //public int Age 
        //{
        //    get { return age; }
        //    set { age = value; } 
        //}
        public int Age{ get; set; }

        decimal deduction;
        public decimal Deduction 
        {
            get { return Salary * 0.2m; }
        }
        #endregion
    }
}
