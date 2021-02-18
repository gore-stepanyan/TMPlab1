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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random_flag.Checked = true;
        }

        private void Random_flag_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = random_flag.Checked;
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            string path;
            using (OpenFileDialog OFD = new OpenFileDialog())
                if (OFD.ShowDialog() == DialogResult.OK)
                    path = OFD.FileName;
        }
    }
}
