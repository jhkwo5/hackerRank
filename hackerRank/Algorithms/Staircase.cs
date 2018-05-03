using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    class Staircase
    {
        public Staircase()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n+1; i++)
            {
                for(int j = 1; j < n + 1; j++)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
