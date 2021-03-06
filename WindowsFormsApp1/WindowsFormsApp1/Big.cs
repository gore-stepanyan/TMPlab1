﻿using System;
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

        // Конструктор с параметрами
        public Big(int BlockSize, string FileName="default.bin")
        {
            this.FileName = FileName;
            this.BlockSize = BlockSize;
            Arr = new int[BlockSize];
            BMap = new bool[BlockSize];
        }
        
        // Вернуть номер страницы
        public int GetPageNum()
        {
            return PageNum;
        }

        // Считать страницу: определить номер страницы и номер на странице, на которой находится требуемый элемент;
        public void ReadPage(int index) 
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
                // Считывание страницы в буферный массив
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

        // Считать элемент: вернуть по индексу
        public int ReadElement(int index)
        {
            ReadPage(index);

            if (BMap[Index] == false)
                throw new Exception("Произошло обращение к пустой ячейке массива");
            else
                return Arr[Index];
        }

        // Перезаписать страницу
        private void Write()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(FileName, FileMode.Open)))
            {

                writer.Seek((sizeof(bool) * BMap.Count() + sizeof(int) * Arr.Count()) * (PageNum - 1), 0);

                for (int i = 0; i < BlockSize; i++)
                {
                    writer.Write(BMap[i]);
                }

                for (int i = 0; i < BlockSize; i++)
                {
                    writer.Write(Arr[i]);
                }
            }
        }

        // Перезаписать элемент
        public void SetElement(int element, int index)
        {
            ReadPage(index);

            Arr[Index] = element;
            BMap[Index] = true;

            Write();

        }

        // Удалить элемент
        public void RemoveAt(int index, string fileName)
        {
            ReadPage(index);

            BMap[Index] = false;

            Write();
        }
    }
}
