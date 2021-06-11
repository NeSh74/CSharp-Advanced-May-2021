using System;

namespace Create_Custom_Data_Structures
{
    public class StartUp
    {
        static void Main()
        {
            //T2 MyStack
            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Count);
            var result = stack.Pop();
            Console.WriteLine($"Poped item: {result}");
            var peekResult = stack.Peek();
            Console.WriteLine(peekResult);
            Console.WriteLine(stack.Count);
            stack.Clear();
            Console.WriteLine(stack.Count);
            var newStack = new MyStack();
            for (int i = 0; i < 5; i++)
            {
                newStack.Push(i);
            }

            newStack.ForEach(n => Console.WriteLine($"Numbers + itself: {n} + {n} = {n + n}"));

            //T1 MyList
            //var list = new MyList();
            //list.Add(1);//1
            //list.Add(2);//2
            //list.Add(3);//3
            //list.Add(4);//4
            //list.Add(5);//5
            //var count = list.Count;//4
            //Console.WriteLine($"Count of list: {count}");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine($"Number from list: {list[i]}");
            //}
            //var removed = list.RemoveAt(4);//5
            //Console.WriteLine($"The removed item: {removed}");//5
            //var countAfterRemoved = list.Count;//4
            //Console.WriteLine($"After remove an item the count is {countAfterRemoved}");
            //list.Clear(); //list.Lenght==0;
            //Console.WriteLine($"List of count after Clear() method: {list.Count}");

            //var newList = new MyList();
            //newList.Add(20);
            //newList.Add(50);
            //newList.Add(40);
            //newList.Add(30);
            //Console.WriteLine($"The item contains. {newList.Contains(30 )}");
            //newList.RemoveAt(3);
            //Console.WriteLine($"The item contains. {newList.Contains(30 )}");

            //newList.Swap(0, 1);
            //Console.WriteLine($"Item 0 {newList [0]}");
            //Console.WriteLine($"Item 1 {newList [1]}");

            //var testInsirtList = new MyList();
            //testInsirtList.Add(1);
            //testInsirtList.Add(2);
            //testInsirtList.InsertAt(1, 5);
            //for (int i = 0; i < testInsirtList.Count ; i++)
            //{
            //Console.Write($"{testInsirtList[i]} ");
            //}
        }
    }
}
