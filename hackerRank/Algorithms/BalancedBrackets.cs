using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    /*
    Sample Input
    3
    {[()]}
    {[(])}
    {{[[(())]]}}
    
    Sample Output
    YES
    NO
    YES
    */


    class BalancedBrackets
    {
        public BalancedBrackets()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string expression = Console.ReadLine();

            for (int a0 = 0; a0 < t; a0++)
            {
                Console.WriteLine(testCase(expression)); 
            }

        }

        public Boolean testCase(string checkStack)
        {
            if (checkStack.Contains("9"))
            {
                return false;
            }
            return true;

        }

    }
}
