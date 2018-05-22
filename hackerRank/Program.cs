using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace hackerRank
{
    class Program
    {

        static void Main(string[] args)
        {
            //MiniMaxSum a = new MiniMaxSum();
            //BirthdayCakeCandles t = new BirthdayCakeCandles();
            //LeftRotation a = new LeftRotation();
            //Staircase a = new Staircase();

            /*required
            //BalancedBrackets a = new BalancedBrackets();
            //Anagrams a = new Anagrams();
            //RansomNote a = new RansomNote();
            //NetworkSpeedTest a = new NetworkSpeedTest();
            */

            //test ts = new test();
            //Console.WriteLine(IsUniqueChars2.IsUniqueChars("test"));
            //char[] test = new char[4]{'t','t','t','s',};
            //CCI.RemoveDuplicates(test);
            //Console.WriteLine(CCI.Anagram("set", "tes"));
            //Console.WriteLine(CCI.Anagram2("setest", "tesest"));
            //Console.WriteLine(CCI.ReplaceString("test test test"));
            //CCI.Rotation();
            //CCI.Matrix0();
            //Console.WriteLine(  CCI.isRotation());


            LinkedListNode<int> lln = new LinkedListNode<int>(4);
            LinkedList<int> linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(3);
            linked.AddLast(4);
            linked.AddLast(lln);
            linked.AddLast(5);
            linked.AddLast(6);
            linked.AddLast(7);
            


            /*CCILists.DeleteDups(linked);

            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }*/

            CCILists.NthToLast(linked, 3);






        }


    }
}
