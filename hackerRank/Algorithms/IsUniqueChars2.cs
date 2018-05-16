using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    class IsUniqueChars2
    {

        public static Boolean IsUniqueChars(String str)
        {
            Boolean[] char_set = new Boolean[256];

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }
    }
}
