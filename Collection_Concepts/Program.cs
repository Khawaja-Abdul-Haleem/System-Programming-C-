using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            int[] a = new int[] { 1, 3, 2, 6, 7, 4, 9, 10, 8, 5 };
            arr.AddRange(a);

            Console.WriteLine("Given Arary:");
            foreach (int i in arr) {
                Console.WriteLine("Values:" + i);
            }

            Console.WriteLine("\nCapacity: " + arr.Capacity);
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("IsfixedSize: " + arr.IsFixedSize);
            Console.WriteLine("IsReadOnly: " + arr.IsReadOnly);
            Console.WriteLine("\n");

            Console.WriteLine("Inserted(1,6)");
            arr.Insert(1, 6);

            arr.Remove(3);
            Console.WriteLine("Removed(3) Successfully worked ");
            foreach(int i in arr)
            {
                Console.WriteLine("Values:" + i);
            }
            Console.WriteLine("\n");

            arr.RemoveAt(5);
            Console.WriteLine("RemovedAt(5) Successfully worked ");
            foreach (int i in arr)
            {
                Console.WriteLine("Values:" + i);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Sort List");
            arr.Sort();
            foreach (int i in arr)
            {
                Console.WriteLine("Values:" + i);
            }
            Console.WriteLine();

            Console.WriteLine("Contains(11): " + arr.Contains(11));
         

            Console.WriteLine("GetRange(2,4): " + arr.GetRange(2, 4));
            

            Console.WriteLine("IndexOf(9): " + arr.IndexOf(9));
            

            Console.WriteLine("\nToArray() ");
            arr.ToArray();
            foreach (int i in arr)
            {
                Console.WriteLine("Values:" + i);
            }

             arr.Clear();
            Console.WriteLine("Cleared Successfully");

            Console.ReadKey();
        }
    }
}
