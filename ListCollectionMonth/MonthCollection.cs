using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionMonth
{
    class MonthCollection
    {
        List<Month> calendar = new List<Month>();
        public List<Month> Calendar
        {
            set { calendar = value; }
            get { return calendar; }
        }

        public void AddMonth(Month [] month)
        {
            calendar.AddRange(month);
        }
        
        public void SearchOnNumber (int numberOfMonth)
        {
            bool flag = true;
            if (flag)
            foreach (var month in calendar)
            {
                  if (month.NumberOfMonth == numberOfMonth)
                  {
                       Console.WriteLine("Number is  {0} - {1}", month.NumberOfMonth, month.NameMonth);
                       flag = false;
                  }
            }
            if (flag)
            {
                Console.WriteLine("There is not such month with this number!");
            }
        }
        public void SearchOnDays(int days)
        {
            Console.WriteLine("{0} days has next month:", days);
            bool flag = true;
            string  testMonth = null;
            while(flag)
            {
                foreach (var month in calendar)
                {
                    if (month.DaysInMonth == days)
                    {
                        Console.WriteLine(month.NameMonth);
                        testMonth = month.NameMonth;
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("There is not month with such days!");
                    flag = false;
                }
            }            
        }

        public void ShowMonth(List<Month>list)
        {
            Console.WriteLine("       ---Calendar---  ");
            foreach (var month in calendar)
            {

                {
                    Console.WriteLine("{0} \t{1}\t\t\t{2}", month.NumberOfMonth,
                    month.NameMonth, month.DaysInMonth);
                }

            }
        }
   
    }
}
