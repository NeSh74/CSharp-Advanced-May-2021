using System;

namespace Custom_Doubly_Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList mylist = new CustomLinkedList(new int[] { 5, 7, 12 });

            mylist.AddFirst(100);
            Console.WriteLine($"Removed item: {mylist .RemoveLast()}" );
            mylist.AddLast(2);
            Console.WriteLine($"Removed item: {mylist .RemoveFirst()}" );
            int[] arr = mylist.ToArray();
            mylist.Foreach(Console.WriteLine);


        }
    }
}
