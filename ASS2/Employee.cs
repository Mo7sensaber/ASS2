using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2
{
    public class Employee
    {
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA,
            SecurityOfficer
        }

        public class Employee 
        {
            public int ID { get; set; }
            public string Name { get; set; }
            private char gender;
            public char Gender
            {
                get { return gender; }
                set
                {
                    if (value == 'M' || value == 'F')
                        gender = value;
                    else
                        throw new ArgumentException("Gender must be 'M' or 'F'");
                }
            }
            public SecurityLevel Security { get; set; }
            public decimal Salary { get; set; }
            public HireDate HireDate { get; set; }

            public Employee(int id, string name, char gender, SecurityLevel security, decimal salary, HireDate hireDate)
            {
                ID = id;
                Name = name;
                Gender = gender;
                Security = security;
                Salary = salary;
                HireDate = hireDate;
            }

            public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {Security}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
            }

            public int CompareTo(Employee other)
            {
                return HireDate.CompareTo(other.HireDate);
            }
        }
    }
}
