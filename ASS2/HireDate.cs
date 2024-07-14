using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2
{
    internal class HireDate
    {
        
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public int CompareTo(HireDate other)
            {
                if (Year != other.Year)
                    return Year.CompareTo(other.Year);
                if (Month != other.Month)
                    return Month.CompareTo(other.Month);
                return Day.CompareTo(other.Day);
            }

            public override string ToString()
            {
                return $"{Day}/{Month}/{Year}";
            }
        }
    }


