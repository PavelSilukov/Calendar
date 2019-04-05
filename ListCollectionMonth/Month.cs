using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionMonth
{
    class Month
    {
        string nameMonth;
        int daysInMonth;
        int numberOfMonth;

        public string NameMonth
        {
            get { return nameMonth; }
        }

        public int DaysInMonth
        {
            get { return daysInMonth; }
        }

        public int NumberOfMonth
        {
            get { return numberOfMonth; }
        }

        public Month (string name, int days, int number)
        {
            this.nameMonth = name;
            this.daysInMonth = days;
            this.numberOfMonth = number;
        }
    }
}
