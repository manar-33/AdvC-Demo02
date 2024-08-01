using System.Collections;
using System.Linq.Expressions;

namespace AdvC_Demo02
{
    internal class Program
    {
        public static int SumArrayList(ArrayList arrayList)
        {
            int Sum = 0;
            if (arrayList != null)

                for (int i = 0; i < arrayList.Count; i++)

                    Sum += (int)arrayList[i];

            return Sum;
        }
        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list != null)
                for (int i = 0; i < list.Count; i++)
                    Sum += list[i];

            return Sum;
        }
        static void Main(string[] args)
        {
            #region Non Generic Collection
            //  ArrayList arrayList = new ArrayList();
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");
            //    arrayList.Add( 1 );
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");
            //    arrayList.Add(2);
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");
            //    arrayList.AddRange(new int[] { 3, 4, 5 });
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");



            //    ArrayList arrayList = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");
            //    arrayList.Add(6);
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");
            //    arrayList.TrimToSize();
            //    Console.WriteLine($"Count of ArrayList :{arrayList.Count}, Capacity Of ArrayList: {arrayList.Capacity}");
            //    //arrayList.Add("Manar");
            //    foreach (int Num in arrayList)
            //    {
            //        Console.WriteLine(Num);
            //    }
            //    int Result = SumArrayList(arrayList);
            //Console.WriteLine(Result); 
            #endregion
            #region Generic Collection
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.Add(1);
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.Add(2);
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.AddRange(new int[] { 3, 4 } );
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.TrimExcess();
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.Add(6);
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers[3] = 10;
            //foreach (int Num in Numbers)
            //{
            //    Console.WriteLine(Num);
            //}

            //int Result = SumList(Numbers);
            //Console.WriteLine(Result);
            #endregion
            #region List Methods
            //List<int> Numbers = new List<int>(4) { 1,2,3,4};
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.AddRange(new int[] { 6, 7 } );
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //foreach (int Num in Numbers)
            //{
            //    Console.Write($" {Num}");
            //}
            //Console.WriteLine("\n ===============");
            //Numbers.Insert(6,8);
            //foreach (int Num in Numbers)
            //{
            //    Console.Write($" {Num}");
            //}
            //Console.WriteLine("\n ===============");
            //Numbers.InsertRange(4,new int[] { 9, 10 } );

            //foreach (int Num in Numbers)
            //{
            //    Console.Write($" {Num}");
            //}
            //Console.WriteLine("\n ===============");
            //int index = Numbers.BinarySearch(3);
            //Console.WriteLine(index);
            //Console.WriteLine(Numbers.Contains(10));

            //List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 };
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            //Numbers.EnsureCapacity(10);
            //Console.WriteLine($"Count of List :{Numbers.Count}, Capacity Of List: {Numbers.Capacity}");
            ////int[]array=new int[4];
            ////Numbers.CopyTo(array);





            #endregion
            #region LinkedList
            // LinkedList<int> linkedlist = new LinkedList<int>();
            //// Console.WriteLine(linkedlist.Count);
            // linkedlist.AddFirst(1);
            // linkedlist.AddLast(2);

            // LinkedListNode<int> AfterAdding = linkedlist.Find(1);
            //// Console.WriteLine(AfterAdding);
            // linkedlist.AddAfter(AfterAdding,5);

            // foreach (var Num in linkedlist)
            // {
            //     Console.WriteLine(Num);
            // }
            #endregion
            #region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Peek());
            //foreach (int Num in stack)
            //    Console.WriteLine(Num);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("\n=============");
            //foreach (int Num in stack)
            //    Console.WriteLine(Num);

            #endregion
            #region Queue
            // Queue<int> queue = new Queue<int>();
            // queue.Enqueue(1);
            // queue.Enqueue(2);
            // queue.Enqueue(3);
            // queue.Enqueue(4);
            //// Console.WriteLine(queue.Peek);
            // Console.WriteLine( queue.Dequeue());
            // Console.WriteLine("\n============");
            // foreach (int Num in queue)
            // {
            //     Console.WriteLine(Num);
            // }
            #endregion

        }

    }
}

