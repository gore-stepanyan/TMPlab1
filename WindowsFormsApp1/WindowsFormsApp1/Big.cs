using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Big
    {
        private string FileName;
        private int Index;
        private int BlockSize;
        private int PageNum = 0;
        private int[] Arr;
        private bool[] BMap;

        public Big(int BlockSize)
        {
            this.BlockSize = BlockSize;
            Arr = new int[BlockSize];
            BMap = new bool[BlockSize];
        }

        public void ReadPage(int index) //    определяет номер страницы и номер на странице, на которой находится требуемый элемент;
        {
            int pageNum = 1;
            while (index  - BlockSize >= 0)
            {
                index -= BlockSize;
                pageNum++;
            }
            Index = index;

            if (pageNum == PageNum)
                return;
            else PageNum = pageNum;


            using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
            {

                reader.Read(new byte[(sizeof(bool)* BMap.Count() + sizeof(int)*Arr.Count()) * (PageNum - 1)], 0, (sizeof(bool) * BMap.Count() + sizeof(int) * Arr.Count()) * (PageNum - 1));

                for (int i = 0; i < BlockSize; i++)
                    BMap[i] = reader.ReadBoolean();

                for (int i = 0; i < BlockSize; i++)
                {
                    if (BMap[i] == true)
                        Arr[i] = reader.ReadInt32();
                    else reader.ReadInt32();
                }            
            }
        }
        public int ReadElement(int index, string fileName)
        {
            if (fileName != FileName)
                FileName = fileName;

            ReadPage(index);

            if (BMap[Index] == false)
                throw new Exception("Произошло обращение к пустой ячейке массива");
            else
                return Arr[Index];
        }

        public void WriteElement(int element, int index, string fileName)
        {
            if (fileName != FileName)
                FileName = fileName;
            ReadPage(index);

            Arr[Index] = element;
            BMap[Index] = true;

            using (BinaryWriter writer = new BinaryWriter(File.Open(FileName, FileMode.Open)))
            {

                writer.Seek(640 * (PageNum - 1), 0);

                for (int i = 0; i < BlockSize; i++)
                    writer.Write(BMap[i]); 

                for (int i = 0; i < BlockSize; i++)
                {
                    writer.Write(Arr[i]);
                }
            }

        }
    }
}
