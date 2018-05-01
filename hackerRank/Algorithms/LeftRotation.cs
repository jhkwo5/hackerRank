using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    class LeftRotation
    {
        /*
        * 5 3
        * 1 2 3 4 5
        * Expected: 4 5 1 2 3
        */
         

        public LeftRotation()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var temp = new int[n];

            for (int i = 0; i < n - k; i++)
            {
                temp[i] = a[i + k];
                //Console.Write(temp[i]);
            }

            temp[2] = 1;
            temp[3] = 2;
            temp[4] = 3;
            for (int i = 0; i < k; i++)
            {
                temp[n - k + i] = a[i];
                //Console.Write(temp[i]);
            }

            a = temp;

            Console.WriteLine(string.Join(" ", a));

        }
    }
}
