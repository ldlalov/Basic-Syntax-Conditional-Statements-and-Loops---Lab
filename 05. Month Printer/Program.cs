using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = int.Parse(Console.ReadLine());
            if (1 <= month & month <= 12)
            {
                var monthName = "";
                switch (month)
                {
                    case 1:
                        monthName = "January";
                        break;
                    case 2:
                        monthName = "February";
                        break;
                    case 3:
                        monthName = "March";
                        break;
                    case 4:
                        monthName = "April";
                        break;
                    case 5:
                        monthName = "May";
                        break;
                    case 6:
                        monthName = "June";
                        break;
                    case 7:
                        monthName = "July";
                        break;
                    case 8:
                        monthName = "August";
                        break;
                    case 9:
                        monthName = "September";
                        break;
                    case 10:
                        monthName = "October";
                        break;
                    case 11:
                        monthName = "November";
                        break;
                    case 12:
                        monthName = "December";
                        break;
                }
                Console.WriteLine(monthName);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
