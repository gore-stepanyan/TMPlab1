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
        public Form1()
        {
            InitializeComponent();
            CreateFile(500);
        }
        private string CreateFile(int Size)
        {
            string path;
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                path = DateTime.Now.ToString("dd-MM-yyy-HH-mm") + ".dat";
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                int countOfPage = Convert.ToInt32(Math.Ceiling(Size/128.0));

                int I = 0;  //количество сгенерированных элеменов
                Random random = new Random();

                for (int m = 0; m < countOfPage - 1; m++)
                {
                    for(int k = 0; k < 128; k++)
                        writer.Write(true);

                    for(int k = 0; k < 128; k++)
                    {
                        writer.Write(random.Next());
                        I++;
                    }
                }

                int J = I;
                for (int j = J; j < Size - 1; j++)
                {
                    writer.Write(true);
                    J = j;
                }
                for (int j = J; j < 128; j++)
                {
                    writer.Write(false);
                    J = j;
                }
                for (int i = I; i < Size; i++)
                {
                    writer.Write(random.Next());
                }
            }

            return path;
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
