using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text;

namespace BitArray_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 2 BitArray of size 5
            BitArray ba1 = new BitArray(5);
            BitArray ba2 = new BitArray(5);

            Console.WriteLine("COUNT ba1 (Before Assign BYTE): " + ba1.Count);
            Console.WriteLine("COUNT ba2 (Before Assign BYTE): " + ba2.Count);


            byte[] byte1 = { 21 };
            byte[] byte2 = { 32 };

            

            // store values of byte in BitArray
            ba1 = new BitArray(byte1);
            ba2 = new BitArray(byte2);

            Console.WriteLine("\nCOUNT ba1 (After Assign BYTE): " + ba1.Count);
            Console.WriteLine("COUNT ba2 (After Assign BYTE): " + ba2.Count);


            Console.WriteLine("\nBitArray (ba1): " + ba1);
            for(int i=0; i<ba1.Count; i++)
            {
                Console.WriteLine(ba1[i]);
            }

            Console.WriteLine("\nBitArray (ba2): " + ba2);
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.WriteLine(ba2[i]);
            }

            BitArray ba3 = new BitArray(5);
            ba3 = ba1.And(ba2);

            Console.WriteLine("\nBitArray (ba3) [AND]: " + ba3);
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.WriteLine(ba3[i]);
            }

            ba3 = ba1.Or(ba2);

            Console.WriteLine("\nBitArray (ba3) [Or]: " + ba3);
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.WriteLine(ba3[i]);
            }

            Console.ReadKey();
        }
    }
}
