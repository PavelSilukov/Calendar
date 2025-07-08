using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Month[] months = { new Month("January", 31, 1),
                                new Month("Febrary", 29, 2),
                                new Month("March", 31, 3),
                                new Month("April", 30, 4),
                                new Month("May", 31, 5),
                                new Month("June", 30, 6),
                                new Month("July", 31, 7),
                                new Month("August", 31, 8),
                                new Month("September", 30, 9),
                                new Month("October", 31, 10),
                                new Month("November", 30, 11),
                                new Month("December", 31, 12)
                               };
            MonthCollection instance = new MonthCollection();
            instance.AddMonth(months);

            while (true)
            {
                Console.WriteLine("Push 1 - to search by number\n" + 
                    "Push 2 - to search by days in month\n" +
                    "Push 3 - to show all calendar\n" +
                    "Push 4 - to quit");
                string sign = Console.ReadLine();
                switch(sign)
                {
                    case "2":
                        bool flag2 = true;
                        while (flag2)
                        {
                            Console.WriteLine("Set the number of days from 29 to 31");
                            try
                            {
                                int days = Convert.ToInt32(Console.ReadLine());
                                instance.SearchOnDays(days);
                                flag2 = false;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("You entered an invalid character");
                                Console.WriteLine("Press any key to repeat...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                        

                    case "1":
                        Console.WriteLine("Set the number of month from 1 to 12");
                        bool flag1 = true;
                        while (flag1)
                        try
                        {
                            int number = Convert.ToInt32(Console.ReadLine());
                            instance.SearchOnNumber(number);
                            Console.WriteLine("Press any key to continue...");
                            flag1 = false;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("You entered an invalid character");
                            Console.WriteLine("Press any key to repeat...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        instance.ShowMonth(instance.Calendar);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You entered an invalid character");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
