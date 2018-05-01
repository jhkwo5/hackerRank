using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerRank
{
    class BirthdayCakeCandles
    {

        /*
         * 4
         * 3 2 1 3
         * 
         */

        public BirthdayCakeCandles()
        {
            Console.WriteLine("TEST BIRTHDAY");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),
                arrTemp => Convert.ToInt32(arrTemp));


            int result = birthdayCakeCandles(n, arr);
            Console.WriteLine(result);
        }


        static int birthdayCakeCandles(int n, int[] arr)
        {
            int max = arr.Max();

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    count++;
                }
            }

            return count;
        }


        


    }
}
