namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01-Calc the distance
            //Console.WriteLine("Enter X of the Point01 :");
            //bool flag01 = double.TryParse(Console.ReadLine(), out double x01);
            //Console.WriteLine("Enter Y of the Point01 :");
            //bool flag02 = double.TryParse(Console.ReadLine(), out double y01);

            //Console.WriteLine("Enter X of the Point02 :");
            //bool flag03 = double.TryParse(Console.ReadLine(), out double x02);
            //Console.WriteLine("Enter Y of the Point02 :");
            //bool flag04 = double.TryParse(Console.ReadLine(), out double y02);

            //Point P01 = new Point(x01,y01);
            //Point P02 = new Point(x02,y02);

            //Console.WriteLine("The Distance between 2 Point => "+Point.CalcDistance(P01, P02));
            #endregion

            #region Q02-Detials Oldest Person
            //Console.WriteLine("Enter the Name of Person 01 : ");
            //string Name01 = Console.ReadLine();
            //Console.WriteLine("Enter the Age of Person 01 : ");
            //bool flag01 = int.TryParse(Console.ReadLine(), out int Age01);
            //Person person01 = new Person(Age01, Name01);

            //Console.WriteLine("Enter the Name of Person 02 : ");
            //string Name02 = Console.ReadLine();
            //Console.WriteLine("Enter the Age Person 02: ");
            //bool flag02 = int.TryParse(Console.ReadLine(), out int Age02);
            //Person person02 = new Person(Age02, Name02);

            //Console.WriteLine("Enter the Name Person 03: ");
            //string Name03 = Console.ReadLine();
            //Console.WriteLine("Enter the Age Person 03: ");
            //bool flag03 = int.TryParse(Console.ReadLine(), out int Age03);
            //Person person03 = new Person(Age03, Name01);

            //Person.CheckOldestPerson(person01, person02, person03);
            #endregion

            #region Q03-Classes Employee and HiringDate
            //Employee employee = new Employee(1, 5000, "Sajeda");
            //employee.PrintSalary();
            //HiringDate hiringDate = new HiringDate(4, 1, 2025);
            //Console.WriteLine(hiringDate);
            #endregion

            #region Q04-Array Of Employee
            #region Arrays
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Sajeda", 5000, Employee.Role.Guest, Employee.Gender.F, new HiringDate(2,5,2020));
            EmpArr[1] = new Employee(2, "Sally", 5000, Employee.Role.DBA, Employee.Gender.F, new HiringDate(2,5,2020));
            EmpArr[2] = new Employee(3, "Sara", 5000, Employee.Role.Secretary, Employee.Gender.F, new HiringDate(2,5,2020));

            foreach (var item in EmpArr)
            {
                item.DisplayInformation();
            }
            #endregion
            #endregion
        }
    }
}
