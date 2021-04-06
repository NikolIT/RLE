using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = String.Empty;
            List<byte> test;

            /*20 20 01 42 20 20 20 e4 08 06 20 20 20 ed 9f 2d db 20 20 20 01 73 52 47 42 20 ae ce 1c e9 20 20 20 04 67 41 4d 41 20 20 b1 8f 0b fc 61 05 20 20 20 09 70 48 59 73 20 2042 4d d6 11 */


            //maryana
            /*FF FF FF FF FF FF 6D 68 F2 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 26 5E F9 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 32 2F EE E7 E6 FD FF FF FF FF FF FF FF FF FF E3 E3 E3 54 4F 4E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 16 08 07 16 08 07 16 08 07 16 08 07 16 08 07 2E 10 0E 2E 10 0E 2E 10 0E 2E 10 0E 44 18 15 44 18 15 44 18 15 44 18 15 5A 20 1C 5A 20 1C 5A 20 1C 5A 20 1C 72 28 23 72 28 23 72 28 23 72 28 23 72 28 23 88 30 2A 88 30 2A 88 30 2A 9E 38 31 9E 38 31 9E 38 31 9E 38 31 9E 38 31 B6 40 38 B6 40 38 B6 40 38 B6 40 38 CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F B6 40 38 B6 40 38 B6 40 38 B6 40 38 9E 38 31 9E 38 31 9E 38 31 9E 38 31 88 30 2A 88 30 2A 88 30 2A 88 30 2A 88 30 2A 72 28 23 72 28 23 72 28 23 72 28 23 5A 20 1C 5A 20 1C 5A 20 1C 5A 20 1C 44 18 15 44 18 15 44 18 15 44 18 15 44 18 15 2E 10 0E 2E 10 0E 2E 10 0E 2E 10 0E 16 08 07 16 08 07 16 08 07 00 00 00 00 00 00 00 00 00
             */
            //kayt
            /*FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED 24 1C ED A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 A4 49 A3 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF*/

            string message = "FF FF FF FF FF FF 6D 68 F2 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 27 7F FF 26 5E F9 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 24 1C EC 32 2F EE E7 E6 FD FF FF FF FF FF FF FF FF FF E3 E3 E3 54 4F 4E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 16 08 07 16 08 07 16 08 07 16 08 07 16 08 07 2E 10 0E 2E 10 0E 2E 10 0E 2E 10 0E 44 18 15 44 18 15 44 18 15 44 18 15 5A 20 1C 5A 20 1C 5A 20 1C 5A 20 1C 72 28 23 72 28 23 72 28 23 72 28 23 72 28 23 88 30 2A 88 30 2A 88 30 2A 9E 38 31 9E 38 31 9E 38 31 9E 38 31 9E 38 31 B6 40 38 B6 40 38 B6 40 38 B6 40 38 CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F CC 48 3F B6 40 38 B6 40 38 B6 40 38 B6 40 38 9E 38 31 9E 38 31 9E 38 31 9E 38 31 88 30 2A 88 30 2A 88 30 2A 88 30 2A 88 30 2A 72 28 23 72 28 23 72 28 23 72 28 23 5A 20 1C 5A 20 1C 5A 20 1C 5A 20 1C 44 18 15 44 18 15 44 18 15 44 18 15 44 18 15 2E 10 0E 2E 10 0E 2E 10 0E 2E 10 0E 16 08 07 16 08 07 16 08 07 00 00 00 00 00 00 00 00 00";

            test = ConvertStringToByteArray(message);

            List<byte> boxingByteRLE = RLE.Boxing(test);
            List<byte> unboxingByteRLE = RLE.Unboxing(boxingByteRLE);

            List<byte> boxingByteRLE_U = RLE_Unbuffered.Boxing(test);
            List<byte> unboxingByteRLE_U = RLE_Unbuffered.Unboxing(boxingByteRLE_U);

            Console.WriteLine("Origin:");
            WriteArrayToConsolle(test);

            Console.WriteLine("\n                   RLE");

            Console.WriteLine("\nBoxing:");
            WriteArrayToConsolle(boxingByteRLE);

            Console.WriteLine("\nUnboxing:");
            //WriteArrayToConsolle(unboxingByteRLE);

            Console.WriteLine("\n                   RLE unbuffered");

            Console.WriteLine("\nBoxing:");
            WriteArrayToConsolle(boxingByteRLE_U);

            Console.WriteLine("\nUnboxing:");
            WriteArrayToConsolle(unboxingByteRLE_U);

            // FillInTheVariable
            data = FillInTheVariable(data, test, boxingByteRLE, unboxingByteRLE, boxingByteRLE_U, unboxingByteRLE_U);
            //

            // создаем каталог для файла
            string path = @"C:\RLE";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            SaveFile(@"C:\RLE\Rle.txt", data);

            Console.Read();
        }

        private static List<byte> ConvertStringToByteArray(string message)
        {
            List<byte> data = new List<byte>();

            foreach (var item in message.Split(' '))
            {
                data.Add(Convert.ToByte(item, 16));
            }

            return data;
        }

        private static string FillInTheVariable(string data, List<byte> test, List<byte> boxingByteRLE, List<byte> unboxingByteRLE, List<byte> boxingByteRLE_U, List<byte> unboxingByteRLE_U)
        {
            data += "Origin:\r\n";

            setArrayForDataHex(test, ref data);

            data += "\r\n\r\n                   RLE";
            data += "\r\nBoxing:\r\n";

            setArrayForDataHex(boxingByteRLE, ref data);

            data += "\r\nUnboxing:\r\n";

            setArrayForDataHex(unboxingByteRLE, ref data);

            data += "\r\n\r\n                   RLE unbuffered";
            data += "\r\nBoxing:\r\n";

            setArrayForDataHex(boxingByteRLE_U, ref data);

            data += "\r\nUnboxing:\r\n";

            setArrayForDataHex(unboxingByteRLE_U, ref data);
            return data;
        }

        static void WriteArrayToConsolle<T> (IEnumerable<T> array)
        {
            foreach (var item in array)
            {
                Console.Write($" {item}");
            }
        }


        static void SaveFile(string path, string data)
        {
            // сохраняем текст в файл
            using (FileStream fstream = new FileStream($@"{path}", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = Encoding.Default.GetBytes(data);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine($"Файл з інформацією було створено за наступним шляхом - {path}");
            }
        }

        static void setArrayForDataHex(List<byte> array, ref string data)
        {
            foreach (var item in array)
            {
                if(item <= 16)
                    data += "0";
                data += Convert.ToString(item, 16).ToUpper();
                data += " ";
            }
        }

    }
}
