using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                if (temp%2 != 0)
                {
                    Console.WriteLine(temp);
                    sum += temp;
                    temp += 2;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
