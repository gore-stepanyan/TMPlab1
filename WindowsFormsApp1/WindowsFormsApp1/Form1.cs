using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int N, index;
        private static int BlockSize = 512 / sizeof(int);
        private Big BigArray = new Big(BlockSize);
        string Path;

        public Form1()
        {
            InitializeComponent();
            
        }
        private string CreateFile(int Size, int BlockSize = 512 / sizeof(int))
        {
            string path;            
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    path = SFD.FileName;
                }
                else 
                    return null;
            }
   
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                int countOfPage = Convert.ToInt32(Math.Ceiling(Size/128.0));

                int I = 0;  //количество сгенерированных элеменов
                Random random = new Random();

                for (int m = 0; m < countOfPage - 1; m++)
                {
                    for(int k = 0; k < BlockSize; k++)
                        writer.Write(true);

                    for(int k = 0; k < BlockSize; k++)
                    {
                        writer.Write(random.Next());
                        I++;
                    }
                }

                for (int j = 0; j < BlockSize; j++)
                {
                    if (j < Size - (countOfPage - 1)* BlockSize)
                        writer.Write(true);
                    else writer.Write(false);
                }

                for (int i = 0; i < BlockSize; i++)
                {
                    writer.Write(random.Next());
                }
            }

            return path;
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IndexTextBox.Text, out index))
            {
                MessageBox.Show("Ошибка, введено нецелое или отрицательное число", "Ошибка!");
                textBox1.Clear();
                return;
            }

            
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    Path = OFD.FileName;
                }
                else 
                    return;
            }
            try
            {
                label3.Text = "Найденый элемент: " + BigArray.ReadElement(index, Path);
            }
            catch (Exception E)
            {
                MessageBox.Show(
                E.Message,
                "Вызвано исключение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                textBox1.Clear();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBox1.Text, out N))
            {
                MessageBox.Show("Ошибка, введено нецелое или отрицательное число", "Ошибка!");
                textBox1.Clear();
            }
        }

        private void Write_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IndexTextBox.Text, out index))
            {
                MessageBox.Show("Ошибка, введено нецелое или отрицательное число", "Ошибка!");
                IndexTextBox.Clear();
                return;
            }

            WriteForm writeForm = new WriteForm();
            writeForm.ShowDialog();
            BigArray.SetElement(writeForm.Value, index, Path);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IndexTextBox.Text, out index))
            {
                MessageBox.Show("Ошибка, введено нецелое или отрицательное число", "Ошибка!");
                IndexTextBox.Clear();
                return;
            }
            BigArray.RemoveAt(index, Path);
            label3.Text = "Элемент удален!";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CreateFile(N, 512 / sizeof(int));

        }
    }
}
