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

            #region PhoneBook With Getter, Setter
            PhoneBook Note = new PhoneBook(3);
            Note.AddPerson(0, 123, "Sajeda");
            Note.AddPerson(1, 456, "Sally");
            Note.AddPerson(2, 789, "Sara");

            int Number = Note.GetNumber("Sara");
            //Console.WriteLine(Number == -1 ? " Not Found" : Number);

            //Note.SetNumber("Sajeda", 999);
            #endregion

            #region PhoneBook with Property [Indexer]
            //Note["Mona"] = 999;
            //Console.WriteLine(Note["Mona"]);

            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}
            #endregion

            #region Class
            //Car C01 = new Car(10);
            //Console.WriteLine(C01.ToString());
            #endregion
        }
    }
}
