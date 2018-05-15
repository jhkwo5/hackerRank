using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerRank
{
    class test
    {
        public test()
        {
            string foo = "121212.23.2";

            //To use Count, requried Linq
            Console.WriteLine(  foo.Count(c => c == '.')); 
        }
    }
}
