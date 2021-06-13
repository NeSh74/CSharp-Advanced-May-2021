using System;

namespace Custom_Doubly_Linked_List_To_Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> mylist = new CustomLinkedList<int>(new int[] { 5, 7, 12 });
            //string can be as well

            mylist.AddFirst(100);
            Console.WriteLine($"Removed item: {mylist.RemoveLast()}");
            mylist.AddLast(2);
            Console.WriteLine($"Removed item: {mylist.RemoveFirst()}");
            int[] arr = mylist.ToArray();
            mylist.Foreach(Console.WriteLine);
        }
    }
}
