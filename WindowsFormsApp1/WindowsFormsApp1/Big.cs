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
        private int Size;
        private int Value;
        private int Index;
        private int PageNum = 0; 
        private int[] Arr = new int[128];
        private bool[] BMap = new bool[128];

        public Big(string FileName, int Size)
        {
            this.FileName = FileName;
            this.Size = Size;
        }
        //перед блоком карта на 128Б
        //блоки по 512Б = 128 чисел

        public void ReadPage(int index) //    определяет номер страницы и номер на странице, на которой находится требуемый элемент;
        {
            int pageNum = 1;
            while (index  - 128 >= 0)
            {
                index -= 128;
                pageNum++;
            }
            Index = index;

            if (pageNum == PageNum)
                return;
            else PageNum = pageNum;

            using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
            {
                for (int i = 0; i < PageNum; i++)
                {
                    for (int j = 0; j < 40; j++)
                        reader.ReadDecimal();
                }

                for (int i = 0; i < 128; i++)
                    BMap[i] = reader.ReadBoolean();

                for (int i = 0; i < 128; i++)
                {
                    if (BMap[i] == true)
                        Arr[i] = reader.ReadInt32();
                    else reader.ReadInt32();
                }            
            }
        }
        public int ReadElement(int index)
        {
            ReadPage(index);

            if (BMap[Index] == false)
                throw new Exception("Произошло обращение к пустой ячейке массива");
            else
                return Arr[Index];
        }

        public void WriteElement(int element, int index)
        {
            ReadPage(index);

            Arr[Index] = element;
            BMap[Index] = true;

        }
/*
    метод записи заданного значения в элемент массива с указанным индексом
    {
        вычисляет адрес элемента;
        записывает значение по этому адресу;
        возвращает результат завершения операции
    };
    */
}
}
