using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Lotto_649 : Form
    {
        public Lotto_649()
        {
            InitializeComponent();
        }

        private void lotto2Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[6];
            Random rand = new Random();
            textBox1.Clear();
            for (i = 0; i < numbers.Length; i++)
            {

                numbers[i] = rand.Next(1, 49);
                textBox1.Text += numbers[i].ToString() + Environment.NewLine;



            }
            File.AppendAllText("LottoNbrs.txt", "649,     " + DateTime.Now.ToString() + ",        " + textBox1.Text + "         Extra 23" );

        }

        private void lotto1Exit_Click(object sender, EventArgs e)
        {
            string str = "";
            str = MessageBox.Show("Do You Want To Quit \n This Application?", "Exit?", MessageBoxButtons.YesNo).ToString();

            if (str == "Yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("LottoNbrs.txt"), "Read File", MessageBoxButtons.OK);
        }
    }
}
