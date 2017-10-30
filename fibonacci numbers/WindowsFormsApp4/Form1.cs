using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;
            int c;

            c = Convert.ToInt16(textBox1.Text);

            if (c>2)
                {
                 for (int i=3; i<=c; i=i+2)
                    {
                    a = a + b;
                    b = b + a;
                    }
                }
            if (c % 2 != 0)
                textBox2.Text = Convert.ToString(a);
            else
                textBox2.Text = Convert.ToString(b);
        }
    }
}
