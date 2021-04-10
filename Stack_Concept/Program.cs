using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text;

namespace Stack_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push('K');
            stk.Push('A');
            stk.Push('H');

            Console.WriteLine("Current StacK Values:");
            foreach(char ch in stk)
            {
                Console.WriteLine(ch + " ");
            }
            Console.WriteLine();

            stk.Push('A');
            stk.Push('B');

            Console.WriteLine("New StacK After adding new Values:");
            foreach (char ch in stk)
            {
                Console.WriteLine(ch + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The next poppable value in stack: {0}", stk.Peek());
            Console.WriteLine();

            Console.WriteLine("Current stack: ");
        
            foreach (char ch in stk)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ...");
            stk.Pop();
            stk.Pop();
            stk.Pop();
            Console.WriteLine("Removed Successfully \n");

            Console.WriteLine("Current stack: ");
            foreach (char ch in stk)
            {
                Console.Write(ch + " ");
            }


            Console.ReadKey();
        }
    }
}
