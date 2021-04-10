using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text;

namespace Queue_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue('K');
            q.Enqueue('A');
            q.Enqueue('H');
            

            Console.WriteLine("Current queue: ");
            foreach (char c in q) {
                Console.Write(c + " ");
            }
            

            Console.WriteLine();
            q.Enqueue('A');
            q.Enqueue('B');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();

            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.ReadKey();
        }
    }
}
