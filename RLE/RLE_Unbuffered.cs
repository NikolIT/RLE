using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    static class RLE_Unbuffered
    {

        public static List<byte> Boxing(List<byte> byteListInfOrig)
        {
            List<byte> result = new List<byte>();
            List<byte> byteListInf = byteListInfOrig.ToList();

            byteListInf.InsertRange(0, new List<byte> { Byte.MinValue, Byte.MinValue });
            byte numberBytes = 0;

            for (int i = 2; i < byteListInf.Count; i++)
            {
                if (byteListInf[i] == byteListInf[i - 1] && byteListInf[i] == byteListInf[i - 2])
                {
                    if (numberBytes == 0)
                    {
                        //result.AddRange(byteListInf.GetRange(i - 2, 2)); 
                        result.Add(Byte.MinValue);
                    }
                        
                    numberBytes++;
                    result[result.Count - 1] = numberBytes;
                }
                else
                {
                    numberBytes = 0;
                    result.Add(byteListInf[i]);
                }
            }

            return result;
        }

        public static List<byte> Unboxing(List<byte> byteListInfOrig)
        {
            List<byte> result = new List<byte>();
            List<byte> byteListInf = byteListInfOrig.ToList();

            bool copy = false;

            byteListInf.InsertRange(0, new List<byte> { Byte.MinValue, Byte.MaxValue, Byte.MinValue });

            for (int i = 3; i < byteListInf.Count; i++)
            {
                if (byteListInf[i - 2] == byteListInf[i - 1] && !copy)
                {
                    int tempNum = byteListInf[i];
                    byte tempByte = byteListInf[i - 1];
                    //i += tempNum - 1;
                    for (int j = 0; j < tempNum; j++)
                    {
                        result.Add(tempByte);
                    }

                    copy = true;
                }
                else
                {
                    copy = false;
                    result.Add(byteListInf[i]);
                }
            }


            return result;
        }
    }
}
