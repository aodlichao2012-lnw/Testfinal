using System;

namespace Bingo
{
    class binggo
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the big-win-bingo");
            Console.WriteLine("enter 8 numbers: between 1 - 25 ");
            int i;
            int j;
            Random rand = new Random();
            int ran = rand.Next(1, 25);

            int[] GenerateBingo = new int[8];
            for (i = 0; i < GenerateBingo.Length; i++)
            {
                GenerateBingo[i] = rand.Next(1, 25);
            }
            int[] UserInput = new int[8];
            for (j = 0; j < UserInput.Length; j++)
            {
                UserInput[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nYou got the following numbers: ");

            foreach (int SaveArrayInput in UserInput)
            {
                Console.Write(" " + SaveArrayInput);
            }
            Console.WriteLine("\n\nPreass any button to see results... ");
            Console.ReadKey();

            var bingonums = GenerateBingo;
            var inputbing = UserInput;
            if(bingonums != inputbing)
            {
                Console.WriteLine("Not bingo");
            }
            else
            {
                Console.WriteLine("bingo!!!");
            }
            var result = string.Join(",", GenerateBingo);
            Console.WriteLine("Bingo numbers are: " + result);

            Console.ReadLine();
        
    }
    }
}
