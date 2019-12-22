using System;

namespace ConsoleApp1
{
    class Rent
    {
        static void Main(string[] args)
        {
            int a = 0;
            int size1 = 0;
            int size2 = 0;
            int size3 = 0;
            int cost1 = 0;
            int cost2 = 0;
            int cost3 = 0;
            int.TryParse(Console.ReadLine(), out a);
            while(a <= 5)
            {
                size1 += 1;
                a -= 5;
                cost1 += 5;
                Console.WriteLine("Tinny = " + size1 + " Cost = "+cost1);
            }
            
            while (a >= 6)
            {
                size2 += 1;
                cost2 += 8;
                Console.WriteLine("meduim = "+size2 + " Cost = " + cost2);
                a -= 10;
            }
            while(a >= 15)
            {
                size3 += 1;
                cost3 += 12;
                Console.WriteLine("Large = "+size3 + " Cost = " + cost3);
                a -= 15;
            }
           Console.ReadLine();
        }
    }
}
