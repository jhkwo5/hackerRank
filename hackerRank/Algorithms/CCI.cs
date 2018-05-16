using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace hackerRank
{
    class CCI
    {
        public static void RemoveDuplicates(char[] str)
        {
            if (str == null) return;
            int len = str.Length;
            if (len < 2) return;

            int tail = 1;

            for(int i = 1; i < len; ++i)
            {
                int j = 0;
                for (j = 0; j < tail; ++j)
                {
                    if (str[i] == str[j]) break;
                }
                if (j == tail)
                {
                    str[tail] = str[i];
                    ++tail;
                }
            }
            str[tail] = '\0';

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }


        public static Boolean Anagram(string s, string t)
        {
            char[] sChar = s.ToCharArray();
            char[] tChar = t.ToCharArray();
            Array.Sort(sChar);
            Array.Sort(tChar);

            string a = new string(sChar);
            string b = new string(tChar);

            return a == b;
        }

        public static Boolean Anagram2(string s, string t)
        {
            int[] letters = new int[256];
            int num_unique_chars = 0;
            int num_completed_t = 0;
            char[] s_array = s.ToCharArray();

            if (s.Length != t.Length)
                return false;

            foreach (var item in s_array)
            {
                if (letters[item] == 0)
                    num_unique_chars++;
                letters[item]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                int c = t[i];
                if (letters[c] == 0)
                {
                    return false;
                }
                letters[c]--;
                if(letters[c] == 0)
                {
                    num_completed_t++;
                    if(num_completed_t == num_unique_chars)
                    {
                        return i == t.Length - 1;
                    }
                }
            }
            return false;
            
        }

        public static string ReplaceString(string str)
        {
            string a = str.Replace(" ", "%20");
            return a;
        }


        public static void Rotation()
        {

            int[][] a = new int[][] {new int[]{ 0,1,2,3,4 },
                                     new int[]{ 5,6,7,8,9 },
                                     new int[]{ 10,11,12,13,14 },
                                     new int[]{ 15,16,17,18,19 },
                                     new int[]{ 20,21,22,23,24 }};

            int[][] b = new int[][] {new int[]{ 1,2,3 },
                                     new int[]{ 4,5,6 },
                                     new int[]{ 7,8,9 }};



            int layer_count = a.GetLength(0) / 2;
            for (int layer = 0; layer < layer_count; layer++)
            {
                int first = layer;
                int last = a.GetLength(0) - first - 1;
                Console.WriteLine("Layer {0}, first {1}, last {2}",
                                    layer, first, last);


                int top_left = a[first][first];
                int top_right = a[first][last];
                int bottom_right = a[last][last];
                int bottom_left = a[last][first];

                a[first][first] = bottom_left;
                a[first][last] = top_left;
                a[last][last] = top_right;
                a[last][first] = bottom_right;

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        Console.Write(a[i][j] + " ");
                    }
                    Console.WriteLine();
                }


            }



        }


    }
}
