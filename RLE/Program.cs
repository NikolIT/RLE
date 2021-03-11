using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    class Program
    {
        static void Main(string[] args)
        {

            List<byte> test = new List<byte>()
            {
                12, 1, 1, 1, 5, 4, 2, 64, 1, 12, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 132, 12, 43, 64, 99, 1, 12, 2, 2, 2, 2, 2, 2
            };

            List<byte> boxingByte = RLE.Boxing(test);
            List<byte> unboxingByte = RLE.Unboxing(boxingByte);

            Console.WriteLine("Origin:");
            foreach (var item in test)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine("\nBoxing:");
            foreach (var item in boxingByte)
            {
                Console.Write($" {item}");  
            }

            Console.WriteLine("\nUnboxing:");
            foreach (var item in unboxingByte)
            {
                Console.Write($" {item}");
            }
            Console.Read();
        }
    }
}
