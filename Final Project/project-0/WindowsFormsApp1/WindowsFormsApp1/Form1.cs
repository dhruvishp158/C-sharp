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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempConvert tc = new tempConvert();
            tc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lotto_649 lm2 = new Lotto_649();
            lm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lotto_Max lm = new Lotto_Max();
            lm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator cl = new calculator();
            cl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyExchange me = new MoneyExchange();
            me.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ipConvert ic = new ipConvert();
            ic.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
