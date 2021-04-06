using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    static class RLE
    {
        public  static List<byte> Boxing(List<byte> byteListOrg)
        {

            List<byte> byteList = byteListOrg.ToList();

            List<byte> resultList = new List<byte>();

            resultList.Add(Byte.MinValue);
            byteList.Add(Byte.MinValue);
            byteList.Insert(0, Byte.MinValue);
            //List<byte> tempList = new List<byte>();
            byte numberBytes1 = 1;//змінити назви
            byte numberBytes2 = 1;
            //byte tempbyte = byteImgList[0];
            
            for (int i = 1; i < byteList.Count - 1; i++)
            {
                if (byteList[i - 1] == byteList[i] || byteList[i] == byteList[i + 1])
                {
                    numberBytes2 = 1;
                    if (numberBytes1 == 1 || numberBytes1 == Byte.MaxValue)
                    {
                        numberBytes1 = 1;
                        resultList.AddRange(new List<byte> { Byte.MinValue, Byte.MinValue });
                    }

                    resultList[resultList.Count - 2] = numberBytes1;
                    resultList[resultList.Count - 1] = byteList[i];

                    numberBytes1++;
                    continue;
                }
                else
                {
                    numberBytes1 = 1;

                    if(numberBytes2 == 1 || numberBytes2 == Byte.MaxValue)
                    {
                        numberBytes2 = 1;
                        resultList.AddRange(new List<byte> { Byte.MinValue, Byte.MinValue });
                    }                      

                    resultList.Add(byteList[i]);
                    resultList[resultList.Count - (numberBytes2 + 1)] = numberBytes2;
                    

                    numberBytes2++;

                    continue;
                }


            }

            resultList.RemoveAt(0);
            return resultList;
        }

        public static List<byte> Unboxing(List<byte> byteList)
        {
            List<byte> resultList = new List<byte>();

            int numbereBytes = 0;

            for (int i = 0; i < byteList.Count; i++)
            {
                if (byteList[i] == 0)
                {
                    numbereBytes = byteList[i + 1];
                    i++;
                    for (int j = 0; j < numbereBytes; j++)
                    {
                        resultList.Add(byteList[++i]);// ++i
                    }
                }
                else
                {
                    numbereBytes = byteList[i];
                    byte temp = byteList[i + 1];
                    i++;
                    for (int j = 0; j < numbereBytes; j++)
                    {  
                        resultList.Add(temp);
                    }
                }

            }

            return resultList;
        }
    }
}
