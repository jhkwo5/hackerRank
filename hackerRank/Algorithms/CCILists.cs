using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    class CCILists
    {
        /*
        public static void DeleteDups(LinkedList<int> n)
        {
            LinkedListNode<int> head = n.First;

            while (head.Next != null)
            {
                if (head.Value == head.Next.Value)
                {
                    n.Remove(head.Next);
                    //head.Value = head.Next.Value;
                    //Console.WriteLine("Duplicates");
                }
                head = head.Next;
            }

        }
        */ 
        public static void DeleteDups(LinkedList<int> n)
        {
            LinkedListNode<int> head = n.First;
            HashSet<int> table = new HashSet<int>();

            while (head.Next != null)
            {
                if (table.Contains(head.Value))
                {
                    n.Remove(head.Value);
                }
                else
                {
                    table.Add(head.Value);
                }
                head = head.Next;
            }
        }

       
        public static void NthToLast(LinkedList<int> head, int n)
        {
            LinkedListNode<int> p1 = head.First;
            LinkedListNode<int> p2 = head.First;

            for (int i = 0; i < n-1; i++)
            {
                if (p2 == null)
                {
                    break;
                }
                else
                {
                    p2 = p2.Next;
                }
            }

            while(p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            Console.WriteLine("P1 = {0}, P2 = {1} ", p1.Value, p2.Value);
        }

    }
}
