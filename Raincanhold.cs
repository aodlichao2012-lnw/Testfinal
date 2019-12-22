using System;

namespace Raincanhold
{
    class Rain
    {
      

        static int findRain(int[] arr, int n)
        {
            int result = 0;
            int left_max = 0, right_max = 0;
            int lo = 0, hi = n - 1;
            while (lo <= hi)
            {
                if (arr[lo] < arr[hi])
                {
                    if (arr[lo] > left_max)
                        left_max = arr[lo];
                    else
                        result += left_max - arr[lo];
                    lo++;
                }
                else
                {
                    if (arr[hi] > right_max)
                        right_max = arr[hi];
                    else
                        result += right_max - arr[hi];
                    hi--;
                }
            }
            return result;
        }
        public static void Main()
        {
            int[] arr = new int[10];
            for(int d = 0; d < arr.Length; d ++)
            {
                int.TryParse(Console.ReadLine(), out arr[d]);
            }
            int result = findRain(arr, arr.Length);
            Console.WriteLine(" Total number of Tarp that can hold the rain : " + result);
        }
    }
}
