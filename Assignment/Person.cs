using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person
    {
        #region Properties
        public int Age { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        #endregion

        #region Methods
        public static void CheckOldestPerson(Person P01,Person P02,Person P03)
        {
            if(P01.Age >= P02.Age && P01.Age >= P03.Age)
                Console.WriteLine($"The oldest is {P01.Name}");

            else if(P02.Age >= P01.Age && P02.Age >= P03.Age)
                Console.WriteLine($"The oldest is {P02.Name}");
            else
                Console.WriteLine($"The oldest is {P03.Name}");
        }
        #endregion
    }
}
