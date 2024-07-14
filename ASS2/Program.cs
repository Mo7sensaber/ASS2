using System;

namespace ASS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#region Q1
            person p1 = new person(10);
            p1.addperson("ahmed", 20, 0);
            p1.addperson("mohsen", 22, 1);
            p1.addperson("mohamed", 15, 2);
            Console.WriteLine(p1["mohsen"]); 
            #endregion*/

            /* #region Q2
             person p1 = new person(10);
             string name;
             int age;
             int index;
             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine("enter name");
                 name = Console.ReadLine();

                 Console.WriteLine("enter age");
                 int.TryParse(Console.ReadLine(), out age);
                 Console.WriteLine("enter index");
                 int.TryParse(Console.ReadLine(), out index);
                 p1.addperson(name, age, index);
             }
             Console.WriteLine("the age and name");
             p1.getmax(); 
             #endregion*/

            /*            #region part3
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "John", 'M', SecurityLevel.DBA, 60000m, new HireDate(15, 5, 2010));
            EmpArr[1] = new Employee(2, "Jane", 'F', SecurityLevel.Guest, 30000m, new HireDate(20, 8, 2012));
            EmpArr[2] = new Employee(3, "Alice", 'F', SecurityLevel.SecurityOfficer, 80000m, new HireDate(10, 3, 2008));

            Array.Sort(EmpArr);

            Console.WriteLine("Sorted Employees by Hire Date:");
            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            } 
            #endregion*/
        }
    
    }
}