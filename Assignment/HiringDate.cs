using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HiringDate
    {
        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion

        #region Constructors
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return @$"The Hiring Date is {Month}\{Day}\{Year}";
        }
        #endregion
    }
}
