using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] symbol2 = { "+", "-", "*", "/", "#" };
            string[] symbol3 = { "A", "E", "S", "Z", "D" };
            

            Random random = new Random();
            int n1, n2, n3,n4,n5;

            n1= random.Next(symbol1.Length);
            n2= random.Next(symbol2.Length);
            n3= random.Next(0,10);
            n4= random.Next(symbol3.Length);
            n5= random.Next(0,10);
            label1.Text = symbol1[n1].ToString() + symbol2[n2].ToString() + n3.ToString() + symbol3[n4].ToString()+n5.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
