using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var newTime = hours * 60 + minutes+30;
            var newHours = newTime / 60;
            if (newHours>=24)
            {
                newHours -= 24;
            }
            Console.WriteLine($"{newHours}:{newTime%60:d2}");
        }
    }
}
