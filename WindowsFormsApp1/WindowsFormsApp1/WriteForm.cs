using System;
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
    public partial class WriteForm : Form
    {
        public int Value;
        public WriteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out Value))
            {
                MessageBox.Show("Ошибка, введен недопустимый символ!", "Ошибка!");
                textBox1.Clear();
                return;
            }
            Close();

        }
    }
}
