using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    class RansomNote
    {
        public RansomNote()
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            /*
            Console.WriteLine("m = {0}, n = {1}, \nmagazin = {2} " +
                "ransom ={3}",m,n,string.Join(' ', magazine),
                 string.Join(' ', ransom));
            */


            Dictionary<string, int> mag = new Dictionary<string, int>();
            Dictionary<string, int> note = new Dictionary<string, int>();

            mag = ConvertArray(magazine);
            note = ConvertArray(ransom);

            foreach (var item in mag)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);


            }

            bool result = true;




        }

        private static Dictionary<string, int> ConvertArray(string[] arr)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var item in arr)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            return dic;
        }
    }
}
