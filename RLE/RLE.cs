using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    static class RLE
    {
        public  static List<byte> Compression(List<byte> byteImgList)
        {

            List<byte> resultList = new List<byte>();

            resultList.Add(Byte.MinValue);

            //List<byte> tempList = new List<byte>();
            byte numberBytes1 = 1;//змінити назви
            byte numberBytes2 = 1;
            //byte tempbyte = byteImgList[0];
            
            for (int i = 1; i < byteImgList.Count; i++)
            {
                if (byteImgList[i - 1] == byteImgList[i])
                {
                    numberBytes2 = 1;
                    if (numberBytes1 == 1)
                        resultList.AddRange(new List<byte> { Byte.MinValue, Byte.MinValue });

                    numberBytes1++;

                    resultList[resultList.Count - 2] = numberBytes1;
                    resultList[resultList.Count - 1] = byteImgList[i - 1];

                    
                    continue;
                }
                else
                {
                    numberBytes1 = 1;

                    if(numberBytes2 == 1)
                        resultList.AddRange(new List<byte> { Byte.MinValue, Byte.MinValue});

                    resultList.Add(byteImgList[i - 1]);
                    resultList[resultList.Count - (numberBytes2 + 1)] = numberBytes2;
                    

                    numberBytes2++;

                    continue;
                }


            }


            return resultList;
        }
    }
}
