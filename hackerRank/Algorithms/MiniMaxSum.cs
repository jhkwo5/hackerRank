using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerRank
{
    class MiniMaxSum
    {

        /*
         * 3 4 5 6
        */

        public MiniMaxSum()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),
                                            arrTemp => Convert.ToInt32(arrTemp));

            MinMaxSum(arr);
        }

        static void MinMaxSum(int[] arr)
        {
            long max = arr.Max();
            long min = arr.Min();
            long total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            long maxA = total - min;
            long minA = total - max;

            System.Console.WriteLine("{0} {1}", minA, maxA);
        }





    }
}
