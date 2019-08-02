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
    public partial class Lotto_Max : Form
    {
        public Lotto_Max()
        {
            InitializeComponent();
        }

        private void lotto1Exit_Click(object sender, EventArgs e)
        {
            string str = "";
            str = MessageBox.Show("Do You Want To Quit \n This Application?", "Exit?", MessageBoxButtons.YesNo).ToString();

            if(str == "Yes")
            {
                this.Close();
            }

        }
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[7];
            Random rand = new Random();
            textBox1.Clear();
            for (i = 0; i < numbers.Length; i++)
            {
               
                numbers[i] = rand.Next(1,49);
                textBox1.Text += numbers[i].ToString() + Environment.NewLine;



            }
            File.AppendAllText("LottoNbrs.txt", "Max,   " + DateTime.Now.ToString() + ",  " + textBox1.Text + " " + Environment.NewLine);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("LottoNbrs.txt"), "Read", MessageBoxButtons.OK);

        }
    }
}
