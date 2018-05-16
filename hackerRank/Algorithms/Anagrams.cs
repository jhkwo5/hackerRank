using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerRank
{
    /***
     * 
     * Need to Do it again
     * 
     ***/
     
    class Anagrams
    {
        public Anagrams()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            /*
            string joinString = a + b;
            List<char> listT = new List<char>();
            foreach (var item in joinString)
            {
                listT.Add(item);
                Console.WriteLine(item);
            }
            */

            //listT = listT.Distinct().ToList();
            /*foreach (var item in listT)
            {
                Console.WriteLine(item);
            }*/

            // List<int> listT = new List<int>();
            /*
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        
                        a = a.Remove(i, 1);
                        b = b.Remove(j, 1);
                        break;
                    }
                }
            }

            count = a.Length + b.Length;
            Console.WriteLine(count);
            */

            
            int[] letterCounts = new int[26];
            foreach (char c in a)
            {
                letterCounts[c - 'a']++;
            }
            foreach (char c in b) {
                letterCounts[c - 'a']--;
            }

            int result = 0;
            foreach(int i in letterCounts)
            {
                
                result += Math.Abs(i);
                Console.WriteLine(result);
            }

            Console.WriteLine(result);
            Console.WriteLine(letterCounts.Sum(x => Math.Abs(x)));
           

        }
    }
}
